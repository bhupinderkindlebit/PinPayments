using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace PinPayment.Models
{

    /// <remarks/>
    /// [XmlRoot("NeweggAPIResponse")]
    /// 
    [XmlRoot("subscription-plans")]
    //[System.Xml.Serialization.XmlRootAttribute("subscription-plans", Namespace = "", IsNullable = false)]
    public partial class subscriptionplans
    {

        private subscriptionplansSubscriptionplan[] subscriptionplanField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subscription-plan")]
        public subscriptionplansSubscriptionplan[] subscriptionplan
        {
            get
            {
                return this.subscriptionplanField;
            }
            set
            {
                this.subscriptionplanField = value;
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
    public partial class subscriptionplansSubscriptionplan
    {

        private subscriptionplansSubscriptionplanAmount amountField;

        private subscriptionplansSubscriptionplanChargeafterfirstperiod chargeafterfirstperiodField;

        private subscriptionplansSubscriptionplanChargelaterdurationquantity chargelaterdurationquantityField;

        private subscriptionplansSubscriptionplanChargelaterdurationunits chargelaterdurationunitsField;

        private subscriptionplansSubscriptionplanCreatedat createdatField;

        private string currencycodeField;

        private string descriptionField;

        private subscriptionplansSubscriptionplanDurationquantity durationquantityField;

        private string durationunitsField;

        private subscriptionplansSubscriptionplanEnabled enabledField;

        private string featurelevelField;

        private subscriptionplansSubscriptionplanForcerecurring forcerecurringField;

        private subscriptionplansSubscriptionplanID idField;

        private subscriptionplansSubscriptionplanMinimumneededforcharge minimumneededforchargeField;

        private string nameField;

        private subscriptionplansSubscriptionplanNeedstoberenewed needstoberenewedField;

        private string plantypeField;

        private string returnurlField;

        private subscriptionplansSubscriptionplanSetupfeeamount setupfeeamountField;

        private string setupfeecurrencycodeField;

        private string setupfeedescriptionField;

        private subscriptionplansSubscriptionplanUpdatedat updatedatField;

        private subscriptionplansSubscriptionplanVersion versionField;

        private subscriptionplansSubscriptionplanVersions versionsField;

        private subscriptionplansSubscriptionplanTerms termsField;

        private subscriptionplansSubscriptionplanPrice priceField;

        /// <remarks/>
        public subscriptionplansSubscriptionplanAmount amount
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
        [System.Xml.Serialization.XmlElementAttribute("charge-after-first-period")]
        public subscriptionplansSubscriptionplanChargeafterfirstperiod chargeafterfirstperiod
        {
            get
            {
                return this.chargeafterfirstperiodField;
            }
            set
            {
                this.chargeafterfirstperiodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("charge-later-duration-quantity")]
        public subscriptionplansSubscriptionplanChargelaterdurationquantity chargelaterdurationquantity
        {
            get
            {
                return this.chargelaterdurationquantityField;
            }
            set
            {
                this.chargelaterdurationquantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("charge-later-duration-units")]
        public subscriptionplansSubscriptionplanChargelaterdurationunits chargelaterdurationunits
        {
            get
            {
                return this.chargelaterdurationunitsField;
            }
            set
            {
                this.chargelaterdurationunitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("created-at")]
        public subscriptionplansSubscriptionplanCreatedat createdat
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
        [System.Xml.Serialization.XmlElementAttribute("duration-quantity")]
        public subscriptionplansSubscriptionplanDurationquantity durationquantity
        {
            get
            {
                return this.durationquantityField;
            }
            set
            {
                this.durationquantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("duration-units")]
        public string durationunits
        {
            get
            {
                return this.durationunitsField;
            }
            set
            {
                this.durationunitsField = value;
            }
        }

        /// <remarks/>
        public subscriptionplansSubscriptionplanEnabled enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("force-recurring")]
        public subscriptionplansSubscriptionplanForcerecurring forcerecurring
        {
            get
            {
                return this.forcerecurringField;
            }
            set
            {
                this.forcerecurringField = value;
            }
        }

        /// <remarks/>
        public subscriptionplansSubscriptionplanID id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("minimum-needed-for-charge")]
        public subscriptionplansSubscriptionplanMinimumneededforcharge minimumneededforcharge
        {
            get
            {
                return this.minimumneededforchargeField;
            }
            set
            {
                this.minimumneededforchargeField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("needs-to-be-renewed")]
        public subscriptionplansSubscriptionplanNeedstoberenewed needstoberenewed
        {
            get
            {
                return this.needstoberenewedField;
            }
            set
            {
                this.needstoberenewedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("plan-type")]
        public string plantype
        {
            get
            {
                return this.plantypeField;
            }
            set
            {
                this.plantypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("return-url")]
        public string returnurl
        {
            get
            {
                return this.returnurlField;
            }
            set
            {
                this.returnurlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("setup-fee-amount")]
        public subscriptionplansSubscriptionplanSetupfeeamount setupfeeamount
        {
            get
            {
                return this.setupfeeamountField;
            }
            set
            {
                this.setupfeeamountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("setup-fee-currency-code")]
        public string setupfeecurrencycode
        {
            get
            {
                return this.setupfeecurrencycodeField;
            }
            set
            {
                this.setupfeecurrencycodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("setup-fee-description")]
        public string setupfeedescription
        {
            get
            {
                return this.setupfeedescriptionField;
            }
            set
            {
                this.setupfeedescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("updated-at")]
        public subscriptionplansSubscriptionplanUpdatedat updatedat
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
        public subscriptionplansSubscriptionplanVersion version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public subscriptionplansSubscriptionplanVersions versions
        {
            get
            {
                return this.versionsField;
            }
            set
            {
                this.versionsField = value;
            }
        }

        /// <remarks/>
        public subscriptionplansSubscriptionplanTerms terms
        {
            get
            {
                return this.termsField;
            }
            set
            {
                this.termsField = value;
            }
        }

        /// <remarks/>
        public subscriptionplansSubscriptionplanPrice price
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class subscriptionplansSubscriptionplanAmount
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
    public partial class subscriptionplansSubscriptionplanChargeafterfirstperiod
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
    public partial class subscriptionplansSubscriptionplanChargelaterdurationquantity
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
    public partial class subscriptionplansSubscriptionplanChargelaterdurationunits
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
    public partial class subscriptionplansSubscriptionplanCreatedat
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
    public partial class subscriptionplansSubscriptionplanDurationquantity
    {

        private string typeField;

        private ushort valueField;

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
        public ushort Value
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
    public partial class subscriptionplansSubscriptionplanEnabled
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
    public partial class subscriptionplansSubscriptionplanForcerecurring
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
    public partial class subscriptionplansSubscriptionplanID
    {

        private string typeField;

        private ushort valueField;

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
        public ushort Value
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
    public partial class subscriptionplansSubscriptionplanMinimumneededforcharge
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
    public partial class subscriptionplansSubscriptionplanNeedstoberenewed
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
    public partial class subscriptionplansSubscriptionplanSetupfeeamount
    {

        private string typeField;

        private bool nilField;

        private bool nilFieldSpecified;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nilSpecified
        {
            get
            {
                return this.nilFieldSpecified;
            }
            set
            {
                this.nilFieldSpecified = value;
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
    public partial class subscriptionplansSubscriptionplanUpdatedat
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
    public partial class subscriptionplansSubscriptionplanVersion
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
    public partial class subscriptionplansSubscriptionplanVersions
    {

        private subscriptionplansSubscriptionplanVersionsVersion[] versionField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("version")]
        public subscriptionplansSubscriptionplanVersionsVersion[] version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
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
    public partial class subscriptionplansSubscriptionplanVersionsVersion
    {

        private subscriptionplansSubscriptionplanVersionsVersionAmount amountField;

        private subscriptionplansSubscriptionplanVersionsVersionChargeafterfirstperiod chargeafterfirstperiodField;

        private subscriptionplansSubscriptionplanVersionsVersionChargelaterdurationquantity chargelaterdurationquantityField;

        private subscriptionplansSubscriptionplanVersionsVersionChargelaterdurationunits chargelaterdurationunitsField;

        private subscriptionplansSubscriptionplanVersionsVersionCreatedat createdatField;

        private string currencycodeField;

        private subscriptionplansSubscriptionplanVersionsVersionDescription descriptionField;

        private subscriptionplansSubscriptionplanVersionsVersionDurationquantity durationquantityField;

        private string durationunitsField;

        private subscriptionplansSubscriptionplanVersionsVersionEnabled enabledField;

        private string featurelevelField;

        private subscriptionplansSubscriptionplanVersionsVersionForcerecurring forcerecurringField;

        private subscriptionplansSubscriptionplanVersionsVersionID idField;

        private subscriptionplansSubscriptionplanVersionsVersionMinimumneededforcharge minimumneededforchargeField;

        private string nameField;

        private subscriptionplansSubscriptionplanVersionsVersionNeedstoberenewed needstoberenewedField;

        private string plantypeField;

        private string returnurlField;

        private subscriptionplansSubscriptionplanVersionsVersionSetupfeeamount setupfeeamountField;

        private string setupfeecurrencycodeField;

        private subscriptionplansSubscriptionplanVersionsVersionSetupfeedescription setupfeedescriptionField;

        private subscriptionplansSubscriptionplanVersionsVersionSubscriptionplanid subscriptionplanidField;

        private subscriptionplansSubscriptionplanVersionsVersionUpdatedat updatedatField;

        private subscriptionplansSubscriptionplanVersionsVersionVersion versionField;

        private subscriptionplansSubscriptionplanVersionsVersionTerms termsField;

        /// <remarks/>
        public subscriptionplansSubscriptionplanVersionsVersionAmount amount
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
        [System.Xml.Serialization.XmlElementAttribute("charge-after-first-period")]
        public subscriptionplansSubscriptionplanVersionsVersionChargeafterfirstperiod chargeafterfirstperiod
        {
            get
            {
                return this.chargeafterfirstperiodField;
            }
            set
            {
                this.chargeafterfirstperiodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("charge-later-duration-quantity")]
        public subscriptionplansSubscriptionplanVersionsVersionChargelaterdurationquantity chargelaterdurationquantity
        {
            get
            {
                return this.chargelaterdurationquantityField;
            }
            set
            {
                this.chargelaterdurationquantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("charge-later-duration-units")]
        public subscriptionplansSubscriptionplanVersionsVersionChargelaterdurationunits chargelaterdurationunits
        {
            get
            {
                return this.chargelaterdurationunitsField;
            }
            set
            {
                this.chargelaterdurationunitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("created-at")]
        public subscriptionplansSubscriptionplanVersionsVersionCreatedat createdat
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
        public subscriptionplansSubscriptionplanVersionsVersionDescription description
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
        [System.Xml.Serialization.XmlElementAttribute("duration-quantity")]
        public subscriptionplansSubscriptionplanVersionsVersionDurationquantity durationquantity
        {
            get
            {
                return this.durationquantityField;
            }
            set
            {
                this.durationquantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("duration-units")]
        public string durationunits
        {
            get
            {
                return this.durationunitsField;
            }
            set
            {
                this.durationunitsField = value;
            }
        }

        /// <remarks/>
        public subscriptionplansSubscriptionplanVersionsVersionEnabled enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("force-recurring")]
        public subscriptionplansSubscriptionplanVersionsVersionForcerecurring forcerecurring
        {
            get
            {
                return this.forcerecurringField;
            }
            set
            {
                this.forcerecurringField = value;
            }
        }

        /// <remarks/>
        public subscriptionplansSubscriptionplanVersionsVersionID id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("minimum-needed-for-charge")]
        public subscriptionplansSubscriptionplanVersionsVersionMinimumneededforcharge minimumneededforcharge
        {
            get
            {
                return this.minimumneededforchargeField;
            }
            set
            {
                this.minimumneededforchargeField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("needs-to-be-renewed")]
        public subscriptionplansSubscriptionplanVersionsVersionNeedstoberenewed needstoberenewed
        {
            get
            {
                return this.needstoberenewedField;
            }
            set
            {
                this.needstoberenewedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("plan-type")]
        public string plantype
        {
            get
            {
                return this.plantypeField;
            }
            set
            {
                this.plantypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("return-url")]
        public string returnurl
        {
            get
            {
                return this.returnurlField;
            }
            set
            {
                this.returnurlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("setup-fee-amount")]
        public subscriptionplansSubscriptionplanVersionsVersionSetupfeeamount setupfeeamount
        {
            get
            {
                return this.setupfeeamountField;
            }
            set
            {
                this.setupfeeamountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("setup-fee-currency-code")]
        public string setupfeecurrencycode
        {
            get
            {
                return this.setupfeecurrencycodeField;
            }
            set
            {
                this.setupfeecurrencycodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("setup-fee-description")]
        public subscriptionplansSubscriptionplanVersionsVersionSetupfeedescription setupfeedescription
        {
            get
            {
                return this.setupfeedescriptionField;
            }
            set
            {
                this.setupfeedescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("subscription-plan-id")]
        public subscriptionplansSubscriptionplanVersionsVersionSubscriptionplanid subscriptionplanid
        {
            get
            {
                return this.subscriptionplanidField;
            }
            set
            {
                this.subscriptionplanidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("updated-at")]
        public subscriptionplansSubscriptionplanVersionsVersionUpdatedat updatedat
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
        public subscriptionplansSubscriptionplanVersionsVersionVersion version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public subscriptionplansSubscriptionplanVersionsVersionTerms terms
        {
            get
            {
                return this.termsField;
            }
            set
            {
                this.termsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class subscriptionplansSubscriptionplanVersionsVersionAmount
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionChargeafterfirstperiod
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionChargelaterdurationquantity
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionChargelaterdurationunits
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionCreatedat
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionDescription
    {

        private bool nilField;

        private bool nilFieldSpecified;

        private string valueField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nilSpecified
        {
            get
            {
                return this.nilFieldSpecified;
            }
            set
            {
                this.nilFieldSpecified = value;
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionDurationquantity
    {

        private string typeField;

        private ushort valueField;

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
        public ushort Value
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionEnabled
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionForcerecurring
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionID
    {

        private string typeField;

        private ushort valueField;

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
        public ushort Value
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionMinimumneededforcharge
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionNeedstoberenewed
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionSetupfeeamount
    {

        private string typeField;

        private bool nilField;

        private bool nilFieldSpecified;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nilSpecified
        {
            get
            {
                return this.nilFieldSpecified;
            }
            set
            {
                this.nilFieldSpecified = value;
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionSetupfeedescription
    {

        private bool nilField;

        private bool nilFieldSpecified;

        private string valueField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool nilSpecified
        {
            get
            {
                return this.nilFieldSpecified;
            }
            set
            {
                this.nilFieldSpecified = value;
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionSubscriptionplanid
    {

        private string typeField;

        private ushort valueField;

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
        public ushort Value
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionUpdatedat
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionVersion
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
    public partial class subscriptionplansSubscriptionplanVersionsVersionTerms
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
    public partial class subscriptionplansSubscriptionplanTerms
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
    public partial class subscriptionplansSubscriptionplanPrice
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


}