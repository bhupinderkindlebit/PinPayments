using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PinPayment.Models
{


    







    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class invoice
    {

        private invoiceClosed closedField;

        private invoiceCreatedat createdatField;

        private invoiceResponseclientmessage responseclientmessageField;

        private invoiceResponsecustomermessage responsecustomermessageField;

        private invoiceResponsemessage responsemessageField;

        private string titleField;

        private string tokenField;

        private invoiceUpdatedat updatedatField;

        private invoiceAmount amountField;

        private string priceField;

        private string currencycodeField;

        private string metadataField;

        private invoiceGatewaytransactionreference gatewaytransactionreferenceField;

        private invoiceRecurringamount recurringamountField;

        private invoiceSubscriber subscriberField;

        private invoiceLineitems lineitemsField;

        /// <remarks/>
        public invoiceClosed closed
        {
            get
            {
                return this.closedField;
            }
            set
            {
                this.closedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("created-at")]
        public invoiceCreatedat createdat
        {
            get
            {
                return this.createdatField;
            }
            set
            {
                this.createdatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("response-client-message")]
        public invoiceResponseclientmessage responseclientmessage
        {
            get
            {
                return this.responseclientmessageField;
            }
            set
            {
                this.responseclientmessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("response-customer-message")]
        public invoiceResponsecustomermessage responsecustomermessage
        {
            get
            {
                return this.responsecustomermessageField;
            }
            set
            {
                this.responsecustomermessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("response-message")]
        public invoiceResponsemessage responsemessage
        {
            get
            {
                return this.responsemessageField;
            }
            set
            {
                this.responsemessageField = value;
            }
        }

        /// <remarks/>
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public string token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("updated-at")]
        public invoiceUpdatedat updatedat
        {
            get
            {
                return this.updatedatField;
            }
            set
            {
                this.updatedatField = value;
            }
        }

        /// <remarks/>
        public invoiceAmount amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public string price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("currency-code")]
        public string currencycode
        {
            get
            {
                return this.currencycodeField;
            }
            set
            {
                this.currencycodeField = value;
            }
        }

        /// <remarks/>
        public string metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gateway-transaction-reference")]
        public invoiceGatewaytransactionreference gatewaytransactionreference
        {
            get
            {
                return this.gatewaytransactionreferenceField;
            }
            set
            {
                this.gatewaytransactionreferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recurring-amount")]
        public invoiceRecurringamount recurringamount
        {
            get
            {
                return this.recurringamountField;
            }
            set
            {
                this.recurringamountField = value;
            }
        }

        /// <remarks/>
        public invoiceSubscriber subscriber
        {
            get
            {
                return this.subscriberField;
            }
            set
            {
                this.subscriberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("line-items")]
        public invoiceLineitems lineitems
        {
            get
            {
                return this.lineitemsField;
            }
            set
            {
                this.lineitemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceClosed
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceCreatedat
    {

        private string typeField;

        private System.DateTime valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public System.DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceResponseclientmessage
    {

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceResponsecustomermessage
    {

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceResponsemessage
    {

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceUpdatedat
    {

        private string typeField;

        private System.DateTime valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public System.DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceAmount
    {

        private string typeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceGatewaytransactionreference
    {

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceRecurringamount
    {

        private string typeField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriber
    {

        private invoiceSubscriberActiveuntil activeuntilField;

        private invoiceSubscriberBillingfirstname billingfirstnameField;

        private invoiceSubscriberBillinglastname billinglastnameField;

        private invoiceSubscriberCreatedat createdatField;

        private uint customeridField;

        private invoiceSubscriberEligibleforfreetrial eligibleforfreetrialField;

        private string emailField;

        private invoiceSubscriberExpiredat expiredatField;

        private invoiceSubscriberGraceuntil graceuntilField;

        private invoiceSubscriberLifetimesubscription lifetimesubscriptionField;

        private invoiceSubscriberOngift ongiftField;

        private invoiceSubscriberOnmetered onmeteredField;

        private invoiceSubscriberOntrial ontrialField;

        private invoiceSubscriberReadytorenew readytorenewField;

        private invoiceSubscriberReadytorenewsince readytorenewsinceField;

        private invoiceSubscriberRecurring recurringField;

        private string screennameField;

        private invoiceSubscriberStorecredit storecreditField;

        private string storecreditcurrencycodeField;

        private string tokenField;

        private invoiceSubscriberUpdatedat updatedatField;

        private invoiceSubscriberEligibleforsetupfee eligibleforsetupfeeField;

        private invoiceSubscriberCardexpiresbeforenextautorenew cardexpiresbeforenextautorenewField;

        private object subscriptionplannameField;

        private invoiceSubscriberActive activeField;

        private invoiceSubscriberIngraceperiod ingraceperiodField;

        private invoiceSubscriberFeaturelevel featurelevelField;

        private invoiceSubscriberPaymentaccountonfile paymentaccountonfileField;

        private invoiceSubscriberPaymentaccountdisplay paymentaccountdisplayField;

        private invoiceSubscriberBillingaddress1 billingaddress1Field;

        private invoiceSubscriberBillingcity billingcityField;

        private invoiceSubscriberBillingstate billingstateField;

        private invoiceSubscriberBillingzip billingzipField;

        private invoiceSubscriberBillingcountry billingcountryField;

        private invoiceSubscriberBillingphonenumber billingphonenumberField;

        private invoiceSubscriberPaginationid paginationidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("active-until")]
        public invoiceSubscriberActiveuntil activeuntil
        {
            get
            {
                return this.activeuntilField;
            }
            set
            {
                this.activeuntilField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billing-first-name")]
        public invoiceSubscriberBillingfirstname billingfirstname
        {
            get
            {
                return this.billingfirstnameField;
            }
            set
            {
                this.billingfirstnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billing-last-name")]
        public invoiceSubscriberBillinglastname billinglastname
        {
            get
            {
                return this.billinglastnameField;
            }
            set
            {
                this.billinglastnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("created-at")]
        public invoiceSubscriberCreatedat createdat
        {
            get
            {
                return this.createdatField;
            }
            set
            {
                this.createdatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("customer-id")]
        public uint customerid
        {
            get
            {
                return this.customeridField;
            }
            set
            {
                this.customeridField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("eligible-for-free-trial")]
        public invoiceSubscriberEligibleforfreetrial eligibleforfreetrial
        {
            get
            {
                return this.eligibleforfreetrialField;
            }
            set
            {
                this.eligibleforfreetrialField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("expired-at")]
        public invoiceSubscriberExpiredat expiredat
        {
            get
            {
                return this.expiredatField;
            }
            set
            {
                this.expiredatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("grace-until")]
        public invoiceSubscriberGraceuntil graceuntil
        {
            get
            {
                return this.graceuntilField;
            }
            set
            {
                this.graceuntilField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("lifetime-subscription")]
        public invoiceSubscriberLifetimesubscription lifetimesubscription
        {
            get
            {
                return this.lifetimesubscriptionField;
            }
            set
            {
                this.lifetimesubscriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("on-gift")]
        public invoiceSubscriberOngift ongift
        {
            get
            {
                return this.ongiftField;
            }
            set
            {
                this.ongiftField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("on-metered")]
        public invoiceSubscriberOnmetered onmetered
        {
            get
            {
                return this.onmeteredField;
            }
            set
            {
                this.onmeteredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("on-trial")]
        public invoiceSubscriberOntrial ontrial
        {
            get
            {
                return this.ontrialField;
            }
            set
            {
                this.ontrialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ready-to-renew")]
        public invoiceSubscriberReadytorenew readytorenew
        {
            get
            {
                return this.readytorenewField;
            }
            set
            {
                this.readytorenewField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ready-to-renew-since")]
        public invoiceSubscriberReadytorenewsince readytorenewsince
        {
            get
            {
                return this.readytorenewsinceField;
            }
            set
            {
                this.readytorenewsinceField = value;
            }
        }

        /// <remarks/>
        public invoiceSubscriberRecurring recurring
        {
            get
            {
                return this.recurringField;
            }
            set
            {
                this.recurringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("screen-name")]
        public string screenname
        {
            get
            {
                return this.screennameField;
            }
            set
            {
                this.screennameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("store-credit")]
        public invoiceSubscriberStorecredit storecredit
        {
            get
            {
                return this.storecreditField;
            }
            set
            {
                this.storecreditField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("store-credit-currency-code")]
        public string storecreditcurrencycode
        {
            get
            {
                return this.storecreditcurrencycodeField;
            }
            set
            {
                this.storecreditcurrencycodeField = value;
            }
        }

        /// <remarks/>
        public string token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("updated-at")]
        public invoiceSubscriberUpdatedat updatedat
        {
            get
            {
                return this.updatedatField;
            }
            set
            {
                this.updatedatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("eligible-for-setup-fee")]
        public invoiceSubscriberEligibleforsetupfee eligibleforsetupfee
        {
            get
            {
                return this.eligibleforsetupfeeField;
            }
            set
            {
                this.eligibleforsetupfeeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("card-expires-before-next-auto-renew")]
        public invoiceSubscriberCardexpiresbeforenextautorenew cardexpiresbeforenextautorenew
        {
            get
            {
                return this.cardexpiresbeforenextautorenewField;
            }
            set
            {
                this.cardexpiresbeforenextautorenewField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subscription-plan-name")]
        public object subscriptionplanname
        {
            get
            {
                return this.subscriptionplannameField;
            }
            set
            {
                this.subscriptionplannameField = value;
            }
        }

        /// <remarks/>
        public invoiceSubscriberActive active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("in-grace-period")]
        public invoiceSubscriberIngraceperiod ingraceperiod
        {
            get
            {
                return this.ingraceperiodField;
            }
            set
            {
                this.ingraceperiodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("feature-level")]
        public invoiceSubscriberFeaturelevel featurelevel
        {
            get
            {
                return this.featurelevelField;
            }
            set
            {
                this.featurelevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("payment-account-on-file")]
        public invoiceSubscriberPaymentaccountonfile paymentaccountonfile
        {
            get
            {
                return this.paymentaccountonfileField;
            }
            set
            {
                this.paymentaccountonfileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("payment-account-display")]
        public invoiceSubscriberPaymentaccountdisplay paymentaccountdisplay
        {
            get
            {
                return this.paymentaccountdisplayField;
            }
            set
            {
                this.paymentaccountdisplayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billing-address1")]
        public invoiceSubscriberBillingaddress1 billingaddress1
        {
            get
            {
                return this.billingaddress1Field;
            }
            set
            {
                this.billingaddress1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billing-city")]
        public invoiceSubscriberBillingcity billingcity
        {
            get
            {
                return this.billingcityField;
            }
            set
            {
                this.billingcityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billing-state")]
        public invoiceSubscriberBillingstate billingstate
        {
            get
            {
                return this.billingstateField;
            }
            set
            {
                this.billingstateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billing-zip")]
        public invoiceSubscriberBillingzip billingzip
        {
            get
            {
                return this.billingzipField;
            }
            set
            {
                this.billingzipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billing-country")]
        public invoiceSubscriberBillingcountry billingcountry
        {
            get
            {
                return this.billingcountryField;
            }
            set
            {
                this.billingcountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("billing-phone-number")]
        public invoiceSubscriberBillingphonenumber billingphonenumber
        {
            get
            {
                return this.billingphonenumberField;
            }
            set
            {
                this.billingphonenumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pagination-id")]
        public invoiceSubscriberPaginationid paginationid
        {
            get
            {
                return this.paginationidField;
            }
            set
            {
                this.paginationidField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberActiveuntil
    {

        private string typeField;

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberBillingfirstname
    {

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberBillinglastname
    {

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberCreatedat
    {

        private string typeField;

        private System.DateTime valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public System.DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberEligibleforfreetrial
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberExpiredat
    {

        private string typeField;

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberGraceuntil
    {

        private string typeField;

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberLifetimesubscription
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberOngift
    {

        private string typeField;

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberOnmetered
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberOntrial
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberReadytorenew
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberReadytorenewsince
    {

        private string typeField;

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberRecurring
    {

        private string typeField;

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberStorecredit
    {

        private string typeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberUpdatedat
    {

        private string typeField;

        private System.DateTime valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public System.DateTime Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberEligibleforsetupfee
    {

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberCardexpiresbeforenextautorenew
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberActive
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberIngraceperiod
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberFeaturelevel
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberPaymentaccountonfile
    {

        private string typeField;

        private bool valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public bool Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberPaymentaccountdisplay
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberBillingaddress1
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberBillingcity
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberBillingstate
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberBillingzip
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberBillingcountry
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberBillingphonenumber
    {

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceSubscriberPaginationid
    {

        private string typeField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceLineitems
    {

        private invoiceLineitemsLineitem lineitemField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("line-item")]
        public invoiceLineitemsLineitem lineitem
        {
            get
            {
                return this.lineitemField;
            }
            set
            {
                this.lineitemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceLineitemsLineitem
    {

        private invoiceLineitemsLineitemAmount amountField;

        private string currencycodeField;

        private string descriptionField;

        private invoiceLineitemsLineitemNotes notesField;

        private string priceField;

        private string featurelevelField;

        private string metadataField;

        private invoiceLineitemsLineitemOnetime onetimeField;

        /// <remarks/>
        public invoiceLineitemsLineitemAmount amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("currency-code")]
        public string currencycode
        {
            get
            {
                return this.currencycodeField;
            }
            set
            {
                this.currencycodeField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public invoiceLineitemsLineitemNotes notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        public string price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("feature-level")]
        public string featurelevel
        {
            get
            {
                return this.featurelevelField;
            }
            set
            {
                this.featurelevelField = value;
            }
        }

        /// <remarks/>
        public string metadata
        {
            get
            {
                return this.metadataField;
            }
            set
            {
                this.metadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("one-time")]
        public invoiceLineitemsLineitemOnetime onetime
        {
            get
            {
                return this.onetimeField;
            }
            set
            {
                this.onetimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceLineitemsLineitemAmount
    {

        private string typeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceLineitemsLineitemNotes
    {

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class invoiceLineitemsLineitemOnetime
    {

        private bool nilField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool nil
        {
            get
            {
                return this.nilField;
            }
            set
            {
                this.nilField = value;
            }
        }
    }


}