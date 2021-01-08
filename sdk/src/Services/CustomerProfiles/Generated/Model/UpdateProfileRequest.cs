/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProfile operation.
    /// Updates the properties of a profile. The ProfileId is required for updating a customer
    /// profile.
    /// 
    ///  
    /// <para>
    /// When calling the UpdateProfile API, specifying an empty string value means that any
    /// existing value will be removed. Not specifying a string value means that any value
    /// already there will be kept.
    /// </para>
    /// </summary>
    public partial class UpdateProfileRequest : AmazonCustomerProfilesRequest
    {
        private string _accountNumber;
        private string _additionalInformation;
        private UpdateAddress _address;
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private UpdateAddress _billingAddress;
        private string _birthDate;
        private string _businessEmailAddress;
        private string _businessName;
        private string _businessPhoneNumber;
        private string _domainName;
        private string _emailAddress;
        private string _firstName;
        private Gender _gender;
        private string _homePhoneNumber;
        private string _lastName;
        private UpdateAddress _mailingAddress;
        private string _middleName;
        private string _mobilePhoneNumber;
        private PartyType _partyType;
        private string _personalEmailAddress;
        private string _phoneNumber;
        private string _profileId;
        private UpdateAddress _shippingAddress;

        /// <summary>
        /// Gets and sets the property AccountNumber. 
        /// <para>
        /// A unique account number that you have given to the customer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string AccountNumber
        {
            get { return this._accountNumber; }
            set { this._accountNumber = value; }
        }

        // Check to see if AccountNumber property is set
        internal bool IsSetAccountNumber()
        {
            return this._accountNumber != null;
        }

        /// <summary>
        /// Gets and sets the property AdditionalInformation. 
        /// <para>
        /// Any additional information relevant to the customer's profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string AdditionalInformation
        {
            get { return this._additionalInformation; }
            set { this._additionalInformation = value; }
        }

        // Check to see if AdditionalInformation property is set
        internal bool IsSetAdditionalInformation()
        {
            return this._additionalInformation != null;
        }

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// A generic address associated with the customer that is not mailing, shipping, or billing.
        /// </para>
        /// </summary>
        public UpdateAddress Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A key value pair of attributes of a customer profile.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BillingAddress. 
        /// <para>
        /// The customer’s billing address.
        /// </para>
        /// </summary>
        public UpdateAddress BillingAddress
        {
            get { return this._billingAddress; }
            set { this._billingAddress = value; }
        }

        // Check to see if BillingAddress property is set
        internal bool IsSetBillingAddress()
        {
            return this._billingAddress != null;
        }

        /// <summary>
        /// Gets and sets the property BirthDate. 
        /// <para>
        /// The customer’s birth date.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string BirthDate
        {
            get { return this._birthDate; }
            set { this._birthDate = value; }
        }

        // Check to see if BirthDate property is set
        internal bool IsSetBirthDate()
        {
            return this._birthDate != null;
        }

        /// <summary>
        /// Gets and sets the property BusinessEmailAddress. 
        /// <para>
        /// The customer’s business email address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string BusinessEmailAddress
        {
            get { return this._businessEmailAddress; }
            set { this._businessEmailAddress = value; }
        }

        // Check to see if BusinessEmailAddress property is set
        internal bool IsSetBusinessEmailAddress()
        {
            return this._businessEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property BusinessName. 
        /// <para>
        /// The name of the customer’s business.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string BusinessName
        {
            get { return this._businessName; }
            set { this._businessName = value; }
        }

        // Check to see if BusinessName property is set
        internal bool IsSetBusinessName()
        {
            return this._businessName != null;
        }

        /// <summary>
        /// Gets and sets the property BusinessPhoneNumber. 
        /// <para>
        /// The customer’s business phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string BusinessPhoneNumber
        {
            get { return this._businessPhoneNumber; }
            set { this._businessPhoneNumber = value; }
        }

        // Check to see if BusinessPhoneNumber property is set
        internal bool IsSetBusinessPhoneNumber()
        {
            return this._businessPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The customer's email address, which has not been specified as a personal or business
        /// address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The customer’s first name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        // Check to see if FirstName property is set
        internal bool IsSetFirstName()
        {
            return this._firstName != null;
        }

        /// <summary>
        /// Gets and sets the property Gender. 
        /// <para>
        /// The gender with which the customer identifies.
        /// </para>
        /// </summary>
        public Gender Gender
        {
            get { return this._gender; }
            set { this._gender = value; }
        }

        // Check to see if Gender property is set
        internal bool IsSetGender()
        {
            return this._gender != null;
        }

        /// <summary>
        /// Gets and sets the property HomePhoneNumber. 
        /// <para>
        /// The customer’s home phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string HomePhoneNumber
        {
            get { return this._homePhoneNumber; }
            set { this._homePhoneNumber = value; }
        }

        // Check to see if HomePhoneNumber property is set
        internal bool IsSetHomePhoneNumber()
        {
            return this._homePhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The customer’s last name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        // Check to see if LastName property is set
        internal bool IsSetLastName()
        {
            return this._lastName != null;
        }

        /// <summary>
        /// Gets and sets the property MailingAddress. 
        /// <para>
        /// The customer’s mailing address.
        /// </para>
        /// </summary>
        public UpdateAddress MailingAddress
        {
            get { return this._mailingAddress; }
            set { this._mailingAddress = value; }
        }

        // Check to see if MailingAddress property is set
        internal bool IsSetMailingAddress()
        {
            return this._mailingAddress != null;
        }

        /// <summary>
        /// Gets and sets the property MiddleName. 
        /// <para>
        /// The customer’s middle name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string MiddleName
        {
            get { return this._middleName; }
            set { this._middleName = value; }
        }

        // Check to see if MiddleName property is set
        internal bool IsSetMiddleName()
        {
            return this._middleName != null;
        }

        /// <summary>
        /// Gets and sets the property MobilePhoneNumber. 
        /// <para>
        /// The customer’s mobile phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string MobilePhoneNumber
        {
            get { return this._mobilePhoneNumber; }
            set { this._mobilePhoneNumber = value; }
        }

        // Check to see if MobilePhoneNumber property is set
        internal bool IsSetMobilePhoneNumber()
        {
            return this._mobilePhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property PartyType. 
        /// <para>
        /// The type of profile used to describe the customer.
        /// </para>
        /// </summary>
        public PartyType PartyType
        {
            get { return this._partyType; }
            set { this._partyType = value; }
        }

        // Check to see if PartyType property is set
        internal bool IsSetPartyType()
        {
            return this._partyType != null;
        }

        /// <summary>
        /// Gets and sets the property PersonalEmailAddress. 
        /// <para>
        /// The customer’s personal email address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string PersonalEmailAddress
        {
            get { return this._personalEmailAddress; }
            set { this._personalEmailAddress = value; }
        }

        // Check to see if PersonalEmailAddress property is set
        internal bool IsSetPersonalEmailAddress()
        {
            return this._personalEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The customer's phone number, which has not been specified as a mobile, home, or business
        /// number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string PhoneNumber
        {
            get { return this._phoneNumber; }
            set { this._phoneNumber = value; }
        }

        // Check to see if PhoneNumber property is set
        internal bool IsSetPhoneNumber()
        {
            return this._phoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of a customer profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingAddress. 
        /// <para>
        /// The customer’s shipping address.
        /// </para>
        /// </summary>
        public UpdateAddress ShippingAddress
        {
            get { return this._shippingAddress; }
            set { this._shippingAddress = value; }
        }

        // Check to see if ShippingAddress property is set
        internal bool IsSetShippingAddress()
        {
            return this._shippingAddress != null;
        }

    }
}