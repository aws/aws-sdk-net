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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// A duplicate customer profile that is to be merged into a main profile.
    /// </summary>
    public partial class FieldSourceProfileIds
    {
        private string _accountNumber;
        private string _additionalInformation;
        private string _address;
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _billingAddress;
        private string _birthDate;
        private string _businessEmailAddress;
        private string _businessName;
        private string _businessPhoneNumber;
        private string _emailAddress;
        private string _engagementPreferences;
        private string _firstName;
        private string _gender;
        private string _homePhoneNumber;
        private string _lastName;
        private string _mailingAddress;
        private string _middleName;
        private string _mobilePhoneNumber;
        private string _partyType;
        private string _personalEmailAddress;
        private string _phoneNumber;
        private string _profileType;
        private string _shippingAddress;

        /// <summary>
        /// Gets and sets the property AccountNumber. 
        /// <para>
        /// A unique identifier for the account number field to be merged. 
        /// </para>
        /// </summary>
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
        /// A unique identifier for the additional information field to be merged.
        /// </para>
        /// </summary>
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
        /// A unique identifier for the party type field to be merged.
        /// </para>
        /// </summary>
        public string Address
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
        /// A unique identifier for the attributes field to be merged.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BillingAddress. 
        /// <para>
        /// A unique identifier for the billing type field to be merged.
        /// </para>
        /// </summary>
        public string BillingAddress
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
        /// A unique identifier for the birthdate field to be merged.
        /// </para>
        /// </summary>
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
        /// A unique identifier for the party type field to be merged.
        /// </para>
        /// </summary>
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
        /// A unique identifier for the business name field to be merged.
        /// </para>
        /// </summary>
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
        /// A unique identifier for the business phone number field to be merged.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// A unique identifier for the email address field to be merged.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EngagementPreferences. 
        /// <para>
        /// A unique identifier for the engagement preferences field to be merged.
        /// </para>
        /// </summary>
        public string EngagementPreferences
        {
            get { return this._engagementPreferences; }
            set { this._engagementPreferences = value; }
        }

        // Check to see if EngagementPreferences property is set
        internal bool IsSetEngagementPreferences()
        {
            return this._engagementPreferences != null;
        }

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// A unique identifier for the first name field to be merged.
        /// </para>
        /// </summary>
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
        /// A unique identifier for the gender field to be merged.
        /// </para>
        /// </summary>
        public string Gender
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
        /// A unique identifier for the home phone number field to be merged.
        /// </para>
        /// </summary>
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
        /// A unique identifier for the last name field to be merged.
        /// </para>
        /// </summary>
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
        /// A unique identifier for the mailing address field to be merged.
        /// </para>
        /// </summary>
        public string MailingAddress
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
        /// A unique identifier for the middle name field to be merged.
        /// </para>
        /// </summary>
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
        /// A unique identifier for the mobile phone number field to be merged.
        /// </para>
        /// </summary>
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
        /// A unique identifier for the party type field to be merged.
        /// </para>
        /// </summary>
        public string PartyType
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
        /// A unique identifier for the personal email address field to be merged.
        /// </para>
        /// </summary>
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
        /// A unique identifier for the phone number field to be merged.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProfileType. 
        /// <para>
        /// A unique identifier for the profile type field to be merged.
        /// </para>
        /// </summary>
        public string ProfileType
        {
            get { return this._profileType; }
            set { this._profileType = value; }
        }

        // Check to see if ProfileType property is set
        internal bool IsSetProfileType()
        {
            return this._profileType != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingAddress. 
        /// <para>
        /// A unique identifier for the shipping address field to be merged.
        /// </para>
        /// </summary>
        public string ShippingAddress
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