using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PinPayment.Models
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class subscriber
    {

        private subscriberActive activeField;

        private subscriberActiveuntil activeuntilField;

        private object billingfirstnameField;

        private object billinglastnameField;

        private subscriberCardexpiresbeforenextautorenew cardexpiresbeforenextautorenewField;

        private subscriberCreatedat createdatField;

        private ushort customeridField;

        private subscriberEligibleforfreetrial eligibleforfreetrialField;

        private object emailField;

        private subscriberFeaturelevel featurelevelField;

        private subscriberLifetimesubscription lifetimesubscriptionField;

        private subscriberOntrial ontrialField;

        private subscriberRecurring recurringField;

        private string screennameField;

        private subscriberStorecredit storecreditField;

        private string subscriptionplannameField;

        private string tokenField;

        private subscriberUpdatedat updatedatField;

        /// <remarks/>
        public subscriberActive active
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
        [System.Xml.Serialization.XmlElementAttribute("active-until")]
        public subscriberActiveuntil activeuntil
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
        public object billingfirstname
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
        public object billinglastname
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
        [System.Xml.Serialization.XmlElementAttribute("card-expires-before-next-auto-renew")]
        public subscriberCardexpiresbeforenextautorenew cardexpiresbeforenextautorenew
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
        [System.Xml.Serialization.XmlElementAttribute("created-at")]
        public subscriberCreatedat createdat
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
        public ushort customerid
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
        public subscriberEligibleforfreetrial eligibleforfreetrial
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
        public object email
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
        [System.Xml.Serialization.XmlElementAttribute("feature-level")]
        public subscriberFeaturelevel featurelevel
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
        [System.Xml.Serialization.XmlElementAttribute("lifetime-subscription")]
        public subscriberLifetimesubscription lifetimesubscription
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
        [System.Xml.Serialization.XmlElementAttribute("on-trial")]
        public subscriberOntrial ontrial
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
        public subscriberRecurring recurring
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
        public subscriberStorecredit storecredit
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
        [System.Xml.Serialization.XmlElementAttribute("subscription-plan-name")]
        public string subscriptionplanname
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
        public subscriberUpdatedat updatedat
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class subscriberActive
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
    public partial class subscriberActiveuntil
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
    public partial class subscriberCardexpiresbeforenextautorenew
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
    public partial class subscriberCreatedat
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
    public partial class subscriberEligibleforfreetrial
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
    public partial class subscriberFeaturelevel
    {

        private string typeField;

        private string valueField;

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
        public string Value
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
    public partial class subscriberLifetimesubscription
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
    public partial class subscriberOntrial
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
    public partial class subscriberRecurring
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
    public partial class subscriberStorecredit
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
    public partial class subscriberUpdatedat
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


}