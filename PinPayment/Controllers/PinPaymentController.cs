using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Xml;
using System.Xml.Serialization;
using PinPayment.Models;
using PinPayment.Models.ViewModel;
using PinPayment.Models.Utilities;
using System.Configuration;
namespace PinPayment.Controllers
{
    public class PinPaymentController : Controller
    {
        #region
        //Variable declaration
        WebRequest myReq = null;
        CredentialCache mycache = null;
        Stream requestStream = null;
        WebResponse wr = null;
        Stream receiveStream = null;
        StreamReader reader = null;
        List<Plans> planlist = new List<Plans>();
        XmlSerializer serializer = null;
        StringReader rdr = null;
        subscriptionplans _subscriptionplans = null;
        XmlDocument xmlDoc = null;
        string xml = "";
        string site = "";
        string url = "";
        byte[] bytes;
        string credentials = ConfigurationManager.AppSettings["apiToken"].ToString();
        #endregion
        #region
        //Action methods
        public ActionResult Index()
        {
            return View("Plans", GetPlans());
        }
        public ActionResult xposeSubscriber(string url, string xml, string method)
        {
            try
            {
                myReq = WebRequest.Create(url);
                mycache = new CredentialCache();
                myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
                myReq.ContentType = "Application/json;";
                if (method.ToLower() == "post")
                {
                    byte[] bytes;
                    myReq.ContentType = "text/xml; encoding='utf-8'";
                    bytes = System.Text.Encoding.ASCII.GetBytes(xml);
                    myReq.ContentLength = bytes.Length;
                    myReq.Method = method;
                    requestStream = myReq.GetRequestStream();
                    requestStream.Write(bytes, 0, bytes.Length);
                    requestStream.Close();
                }
                wr = myReq.GetResponse();
                receiveStream = wr.GetResponseStream();
                reader = new StreamReader(receiveStream, Encoding.UTF8);
                xmlDoc = new XmlDocument();
                xmlDoc.Load(wr.GetResponseStream());
                serializer = new XmlSerializer(typeof(subscriptionplans));
                rdr = new StringReader(xmlDoc.InnerXml);
                _subscriptionplans = (subscriptionplans)serializer.Deserialize(rdr);
                foreach (var item in _subscriptionplans.subscriptionplan)
                {
                    Plans plans = new Plans();
                    plans.Amount = item.amount.Value;
                    plans.Name = item.name;
                    plans.Type = item.plantype;
                    plans.Id = item.id.Value;
                    plans.ServiceLevel = item.featurelevel;
                    planlist.Add(plans);
                }
                string content = reader.ReadToEnd();

                return View("Plans", planlist);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [Route("{id}")]
        public ActionResult CreateSubscriber(string id)
        {
            try
            {
                IList<Plans> plans = GetPlans();
                var f = plans.FirstOrDefault(x => x.Name == id);
                SiteSubscriber obj = new SiteSubscriber();
                obj.SubscriptionId = f.Id.ToString();
                return View("CreateSubscriber", obj);
            }
            catch
            {
                return null;
            }
        }
        [HttpPost]
        [Route("{id}")]
        public ActionResult CreateSubscriber(SiteSubscriber obj)
        {
            if (ModelState.IsValid)
            {
                Guid guid = new Guid();
                Random rnmd = new Random();
                PinPaymentsDbEntities db = new PinPaymentsDbEntities();
                if (ModelState.IsValid)
                {
                    tblCustomer obtbl = new tblCustomer();
                    CustomerModel model = new CustomerModel();
                    int cutomerid = model.AddCustomer(obj);
                    xml = "<subscriber><customer-id>" + cutomerid + "</customer-id><screen-name>" + obj.FirstName + obj.LastName + "</screen-name></subscriber>";
                    site = ConfigurationManager.AppSettings["apiUrl"].ToString();
                    url = string.Format("https://subs.pinpayments.com/api/v4/{0}/subscribers.xml", site);
                    CreateSubscriberApi(url, xml, "Post");
                    CardDetail obj1 = new CardDetail();
                    obj1.token = GenrateInvoice(obj.SubscriptionId, cutomerid.ToString(), obj.FirstName, obj.Email);
                    obj1.firstName = obj.FirstName;
                    obj1.lastName = obj.Email;
                    ViewBag.year = DBCommon.BindYear();
                    ViewBag.month = DBCommon.BindMonth();
                    return RedirectToAction("AddCardDetail", obj1);
                }
                return View("CreateSubscriber");
            }
            else
            {
                return View(obj);
            }

        }
        public ActionResult AddCardDetail(string firstName, string lastName, string token)
        {
            if (ModelState.IsValid)
            {
                CardDetail obj = new CardDetail();
                obj.token = token;
                obj.firstName = firstName;
                obj.lastName = lastName;
                ViewBag.year = DBCommon.BindYear();
                ViewBag.month = DBCommon.BindMonth();
                return View();
            }
            else
            {
                return View();
            }

        }
        [HttpPost]
        public ActionResult AddCardDetail(CardDetail obj)
        {
            if (ModelState.IsValid)
            {
                xml = "<payment><account-type>credit-card</account-type><credit-card><number>" + obj.cardNumber + "</number><card-type>" + obj.cardType + "</card-type><verification-value>" + obj.verificationValue + "</verification-value><month>" + obj.month + "</month><year>" + obj.year + "</year><first-name>" + obj.firstName + "</first-name><last-name>" + obj.lastName + "</last-name></credit-card></payment>";
                site = ConfigurationManager.AppSettings["apiUrl"].ToString();
                url = string.Format("https://subs.pinpayments.com/api/v4/{0}/invoices/", site);
                Payment(url + obj.token + "/pay.xml", xml, "PUT", obj.token);
                return View("PaymentSuccess");
            }
            else
            {
                return View("PaymentSuccess", obj);
            }
        }
        public ActionResult IsEmailExist(string Email)
        {
            CustomerModel cust = new CustomerModel();
            return Json(cust.IsEmailExist(Email), JsonRequestBehavior.AllowGet);
        }
        #endregion
        #region
        //api methods
        public string CreateSubscriberApi(string url, string xml, string method)
        {
            try
            {
                myReq = WebRequest.Create(url);
                mycache = new CredentialCache();
                myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
                myReq.ContentType = "text/xml; encoding='utf-8'";
                bytes = System.Text.Encoding.ASCII.GetBytes(xml);
                myReq.ContentLength = bytes.Length;
                myReq.Method = method;
                requestStream = myReq.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                wr = myReq.GetResponse();
                receiveStream = wr.GetResponseStream();
                reader = new StreamReader(receiveStream, Encoding.UTF8);
                return reader.ReadToEnd(); ;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Payment(string url, string xml, string method, string token)
        {
            try
            {
                myReq = WebRequest.Create(url);
                mycache = new CredentialCache();
                myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
                myReq.ContentType = "text/xml; encoding='utf-8'";
                bytes = System.Text.Encoding.ASCII.GetBytes(xml);
                myReq.ContentLength = bytes.Length;
                myReq.Method = method;
                requestStream = myReq.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                wr = myReq.GetResponse();
                receiveStream = wr.GetResponseStream();
                reader = new StreamReader(receiveStream, Encoding.UTF8);
                return reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string GenrateInvoice(string subsciptionid, string customerId, string screenName, string email)
        {
            try
            {
                xml = "<invoice><subscription-plan-id>" + subsciptionid + "</subscription-plan-id><subscriber><customer-id>" + customerId + "</customer-id><screen-name>" + screenName + "</screen-name><email>" + email + "</email></subscriber></invoice>";
                site = ConfigurationManager.AppSettings["apiUrl"].ToString();
                string url = string.Format("https://subs.pinpayments.com/api/v4/{0}/invoices.xml", site);
                myReq = WebRequest.Create(url);
                mycache = new CredentialCache();
                myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
                myReq.ContentType = "text/xml; encoding='utf-8'";
                bytes = System.Text.Encoding.ASCII.GetBytes(xml);
                myReq.ContentLength = bytes.Length;
                myReq.Method = "POST";
                requestStream = myReq.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                wr = myReq.GetResponse();
                receiveStream = wr.GetResponseStream();
                reader = new StreamReader(receiveStream, Encoding.UTF8);
                serializer = new XmlSerializer(typeof(invoice));
                rdr = new StringReader(reader.ReadToEnd());
                invoice _invoice = (invoice)serializer.Deserialize(rdr);
                return _invoice.token;
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public IList<Plans> GetPlans()
        {
            try
            {
                string site = ConfigurationManager.AppSettings["apiUrl"].ToString();
                string url = string.Format("https://subs.pinpayments.com/api/v4/{0}/subscription_plans.xml", site);
                myReq = WebRequest.Create(url);
                mycache = new CredentialCache();
                myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
                myReq.ContentType = "Application/json;";
                myReq.Method = "Get";
                wr = myReq.GetResponse();
                receiveStream = wr.GetResponseStream();
                reader = new StreamReader(receiveStream, Encoding.UTF8);
                xmlDoc = new XmlDocument();
                xmlDoc.Load(wr.GetResponseStream());
                serializer = new XmlSerializer(typeof(subscriptionplans));
                rdr = new StringReader(xmlDoc.InnerXml);
                _subscriptionplans = new subscriptionplans();
                using (XmlReader reade = new XmlTextReader(rdr))
                {
                    if (reade.Name == "nil-classes")
                    {
                        return null;
                    }
                    else
                    {
                        var subscriptionplanssubscriptionplans = new XmlSerializer(typeof(subscriptionplans));
                        _subscriptionplans = subscriptionplanssubscriptionplans.Deserialize(reade) as subscriptionplans;
                        List<Plans> planlist = new List<Plans>();
                        foreach (var item in _subscriptionplans.subscriptionplan)
                        {
                            Plans plans = new Plans();
                            plans.Amount = item.amount.Value;
                            plans.Name = item.name;
                            plans.Type = item.plantype;
                            plans.Id = item.id.Value;
                            plans.ServiceLevel = item.featurelevel;
                            planlist.Add(plans);
                        }
                        return planlist;

                    }

                }
            }
            catch (Exception ex)
            {

                return null;
            }


        }
        #endregion
    }
}
