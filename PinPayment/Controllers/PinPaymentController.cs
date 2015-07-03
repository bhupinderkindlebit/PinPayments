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
        // GET: PinPayment
        public ActionResult Index()
        {
      
            return View("Plans",GetPlans());            
        }

        public string CreateSubscriberApi(string url, string xml, string method)
        {             
            WebRequest myReq = WebRequest.Create(url);
            string credentials = ConfigurationManager.AppSettings["apiToken"].ToString();
            CredentialCache mycache = new CredentialCache();
            myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
            byte[] bytes;
            myReq.ContentType = "text/xml; encoding='utf-8'";            
            bytes = System.Text.Encoding.ASCII.GetBytes(xml);
            myReq.ContentLength = bytes.Length;
            myReq.Method = method;
            Stream requestStream = myReq.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            WebResponse wr = myReq.GetResponse();
            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            string content = reader.ReadToEnd();
        
      
            return content;
        }
        public string Payment(string url, string xml, string method, string token)
        {
            WebRequest myReq = WebRequest.Create(url);
            string credentials = ConfigurationManager.AppSettings["apiToken"].ToString();
            CredentialCache mycache = new CredentialCache();
            myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
            byte[] bytes;
            myReq.ContentType = "text/xml; encoding='utf-8'";            
            bytes = System.Text.Encoding.ASCII.GetBytes(xml);
            myReq.ContentLength = bytes.Length;
            myReq.Method = method;
            Stream requestStream = myReq.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            WebResponse wr = myReq.GetResponse();
            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            string content = reader.ReadToEnd();
            return content;

        }
        public ActionResult xposeSubscriber(string url, string xml, string method)
        {
            //string url = "https://subs.pinpayments.com/api/v4/vipin-kumar-kindlebit-com-test/subscribers.xml";
            WebRequest myReq = WebRequest.Create(url);
            string credentials = ConfigurationManager.AppSettings["apiToken"].ToString();
            CredentialCache mycache = new CredentialCache();
            myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
            myReq.ContentType = "Application/json;";
            if (method.ToLower() == "post")
            {
                byte[] bytes;
                myReq.ContentType = "text/xml; encoding='utf-8'";
                bytes = System.Text.Encoding.ASCII.GetBytes(xml);
                myReq.ContentLength = bytes.Length;
                myReq.Method = method;
                Stream requestStream = myReq.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
            }
            WebResponse wr = myReq.GetResponse();
            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(wr.GetResponseStream());
            XmlSerializer serializer = new XmlSerializer(typeof(subscriptionplans));
            StringReader rdr = new StringReader(xmlDoc.InnerXml);
            subscriptionplans _subscriptionplans = (subscriptionplans)serializer.Deserialize(rdr);

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
            string content = reader.ReadToEnd();
           
            return View("Plans", planlist);
        }

        [Route("{id}")]
        public ActionResult CreateSubscriber(string id)
        {
            IList<Plans> plans = GetPlans();
            var f = plans.FirstOrDefault(x => x.Name == id);
            SiteSubscriber obj = new SiteSubscriber();
            obj.SubscriptionId = f.Id.ToString();
            return View("CreateSubscriber",obj);
        }

        [HttpPost]
        [Route("{id}")]
        public ActionResult CreateSubscriber(SiteSubscriber obj)
        {
            Guid guid = new Guid();
            Random rnmd=new Random ();            
            PinPaymentsDbEntities db = new PinPaymentsDbEntities();
            if(ModelState.IsValid)
            {
                //if (db.tblCustomers.Where(x => x.Email == obj.Email).Count() > 0)
                //{
                //    ModelState.AddModelError("DuplicateEmail", "User already exists");
                //    obj.SubscriptionId = obj.SubscriptionId;
                //    return View(obj);
                //}
                //else
                //{

                    tblCustomer obtbl = new tblCustomer();
                    //if ((db.tblCustomers.ToList().Count() > 0) && db.tblCustomers.ToList()!=null)
                    //{
                    //    obtbl.CustmerId = (db.tblCustomers.Max(m => m.Id) + 1).ToString();
                    //}
                    //else
                    //{
                    //    obtbl.CustmerId="1008";
                    //}
                    
                    //obtbl.FirstName = obj.FirstName;
                    //obtbl.LastName = obj.LastName;
                    //obtbl.Password = obj.Password;
                    //obtbl.Email = obj.Email;
                    //db.tblCustomers.Add(obtbl);
                    //db.SaveChanges();
                    CustomerModel model = new CustomerModel();
                    int cutomerid =model.AddCustomer(obj);
                    string xml = "<subscriber><customer-id>" + cutomerid + "</customer-id><screen-name>" + obj.FirstName + obj.LastName + "</screen-name></subscriber>";
                    string site = ConfigurationManager.AppSettings["apiUrl"].ToString();
                    string url = string.Format("https://subs.pinpayments.com/api/v4/{0}/subscribers.xml", site);
                    CreateSubscriberApi(url, xml, "Post");
                    string token = GenrateInvoice(obj.SubscriptionId, cutomerid.ToString(), obj.FirstName, obj.Email);
                   
                    return RedirectToAction("AddCardDetail", new {firstName=obj.FirstName,lastName=obj.LastName,token = token });

                //}
                //return View("CreateSubscriber");

            }

            return View("CreateSubscriber");
        }



        public string  GenrateInvoice(string subsciptionid,string customerId,string screenName,string email)
        {
            string xm = "<invoice><subscription-plan-id>" + subsciptionid + "</subscription-plan-id><subscriber><customer-id>"+customerId+"</customer-id><screen-name>"+screenName+"</screen-name><email>"+email+"</email></subscriber></invoice>";
           
            string site = ConfigurationManager.AppSettings["apiUrl"].ToString();
            string url = string.Format("https://subs.pinpayments.com/api/v4/{0}/invoices.xml", site);
            
            WebRequest myReq = WebRequest.Create(url);
            string credentials = ConfigurationManager.AppSettings["apiToken"].ToString();
            CredentialCache mycache = new CredentialCache();
            myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
            byte[] bytes;
            myReq.ContentType = "text/xml; encoding='utf-8'";
            //string xml = "<subscriber><customer-id>420420420</customer-id><screen-name>sumitsharda</screen-name></subscriber>";
            bytes = System.Text.Encoding.ASCII.GetBytes(xm);
            myReq.ContentLength = bytes.Length;
            myReq.Method = "POST";
            Stream requestStream = myReq.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            WebResponse wr = myReq.GetResponse();
            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            string content = reader.ReadToEnd();
            XmlSerializer serializer = new XmlSerializer(typeof(invoice));
            StringReader rdr = new StringReader(content);            
            invoice _invoice = (invoice)serializer.Deserialize(rdr);
            return _invoice.token;
            
        }
        public ActionResult AddCardDetail(string firstName,string lastName, string token)
        {
            CardDetail obj = new CardDetail();
            obj.token = token;
            obj.firstName=firstName ;
            obj.lastName = lastName;
            ViewBag.year = DBCommon.BindYear();
            ViewBag.month = DBCommon.BindMonth();
            return View();
        }
        [HttpPost]
        public ActionResult AddCardDetail(CardDetail obj)
        {
            if(ModelState.IsValid)
            {
                string xmlpayment = "<payment><account-type>credit-card</account-type><credit-card><number>" + obj.cardNumber + "</number><card-type>" + obj.cardType + "</card-type><verification-value>" + obj.verificationValue + "</verification-value><month>" + obj.month + "</month><year>" + obj.year + "</year><first-name>" + obj.firstName + "</first-name><last-name>" + obj.lastName + "</last-name></credit-card></payment>";

                string site = ConfigurationManager.AppSettings["apiUrl"].ToString();
                string url = string.Format("https://subs.pinpayments.com/api/v4/{0}/invoices/", site);
                Payment(url + obj.token + "/pay.xml", xmlpayment, "PUT", obj.token);
                 
            }

            return View("PaymentSuccess");
        }


        public ActionResult IsEmailExist(string Email)
        {
            CustomerModel cust = new CustomerModel();

            return Json(cust.IsEmailExist(Email), JsonRequestBehavior.AllowGet);
        }


        public IList<Plans> GetPlans()
        {
            //WebRequest myReq = WebRequest.Create("https://subs.pinpayments.com/api/v4/vipin-kumar-kindlebit-com-test/subscription_plans.xml");
            string site = ConfigurationManager.AppSettings["apiUrl"].ToString();
            string url = string.Format("https://subs.pinpayments.com/api/v4/{0}/subscription_plans.xml", site);
            WebRequest myReq = WebRequest.Create(url);
            //string credentials = "13cb12868229a30552863504f71b019d98bdd747";
            string credentials = ConfigurationManager.AppSettings["apiToken"].ToString();
            CredentialCache mycache = new CredentialCache();
            myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
            myReq.ContentType = "Application/json;";
            myReq.Method = "Get";
            WebResponse wr = myReq.GetResponse();
            Stream receiveStream = wr.GetResponseStream();
            StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(wr.GetResponseStream());
            XmlSerializer serializer = new XmlSerializer(typeof(subscriptionplans));
            StringReader rdr = new StringReader(xmlDoc.InnerXml);

            subscriptionplans _subscriptionplans = (subscriptionplans)serializer.Deserialize(rdr);



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
            //TempData["Plans"] = planlist;
            return planlist;
        }
    }
}
