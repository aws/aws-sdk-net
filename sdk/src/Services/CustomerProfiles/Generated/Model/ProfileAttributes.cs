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
    /// The object used to segment on attributes within the customer profile.
    /// </summary>
    public partial class ProfileAttributes
    {
        private ProfileDimension _accountNumber;
        private ExtraLengthValueProfileDimension _additionalInformation;
        private AddressDimension _address;
        private Dictionary<string, AttributeDimension> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeDimension>() : null;
        private AddressDimension _billingAddress;
        private DateDimension _birthDate;
        private ProfileDimension _businessEmailAddress;
        private ProfileDimension _businessName;
        private ProfileDimension _businessPhoneNumber;
        private ProfileDimension _emailAddress;
        private ProfileDimension _firstName;
        private ProfileDimension _genderString;
        private ProfileDimension _homePhoneNumber;
        private ProfileDimension _lastName;
        private AddressDimension _mailingAddress;
        private ProfileDimension _middleName;
        private ProfileDimension _mobilePhoneNumber;
        private ProfileDimension _partyTypeString;
        private ProfileDimension _personalEmailAddress;
        private ProfileDimension _phoneNumber;
        private ProfileTypeDimension _profileType;
        private AddressDimension _shippingAddress;

        /// <summary>
        /// Gets and sets the property AccountNumber. 
        /// <para>
        /// A field to describe values to segment on within account number.
        /// </para>
        /// </summary>
        public ProfileDimension AccountNumber
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
        /// A field to describe values to segment on within additional information.
        /// </para>
        /// </summary>
        public ExtraLengthValueProfileDimension AdditionalInformation
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
        /// A field to describe values to segment on within address.
        /// </para>
        /// </summary>
        public AddressDimension Address
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
        /// A field to describe values to segment on within attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeDimension> Attributes
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
        /// A field to describe values to segment on within billing address.
        /// </para>
        /// </summary>
        public AddressDimension BillingAddress
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
        /// A field to describe values to segment on within birthDate.
        /// </para>
        /// </summary>
        public DateDimension BirthDate
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
        /// A field to describe values to segment on within business email address.
        /// </para>
        /// </summary>
        public ProfileDimension BusinessEmailAddress
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
        /// A field to describe values to segment on within business name.
        /// </para>
        /// </summary>
        public ProfileDimension BusinessName
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
        /// A field to describe values to segment on within business phone number.
        /// </para>
        /// </summary>
        public ProfileDimension BusinessPhoneNumber
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
        /// A field to describe values to segment on within email address.
        /// </para>
        /// </summary>
        public ProfileDimension EmailAddress
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
        /// A field to describe values to segment on within first name.
        /// </para>
        /// </summary>
        public ProfileDimension FirstName
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
        /// Gets and sets the property GenderString. 
        /// <para>
        /// A field to describe values to segment on within genderString.
        /// </para>
        /// </summary>
        public ProfileDimension GenderString
        {
            get { return this._genderString; }
            set { this._genderString = value; }
        }

        // Check to see if GenderString property is set
        internal bool IsSetGenderString()
        {
            return this._genderString != null;
        }

        /// <summary>
        /// Gets and sets the property HomePhoneNumber. 
        /// <para>
        /// A field to describe values to segment on within home phone number.
        /// </para>
        /// </summary>
        public ProfileDimension HomePhoneNumber
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
        /// A field to describe values to segment on within last name.
        /// </para>
        /// </summary>
        public ProfileDimension LastName
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
        /// A field to describe values to segment on within mailing address.
        /// </para>
        /// </summary>
        public AddressDimension MailingAddress
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
        /// A field to describe values to segment on within middle name.
        /// </para>
        /// </summary>
        public ProfileDimension MiddleName
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
        /// A field to describe values to segment on within mobile phone number.
        /// </para>
        /// </summary>
        public ProfileDimension MobilePhoneNumber
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
        /// Gets and sets the property PartyTypeString. 
        /// <para>
        /// A field to describe values to segment on within partyTypeString.
        /// </para>
        /// </summary>
        public ProfileDimension PartyTypeString
        {
            get { return this._partyTypeString; }
            set { this._partyTypeString = value; }
        }

        // Check to see if PartyTypeString property is set
        internal bool IsSetPartyTypeString()
        {
            return this._partyTypeString != null;
        }

        /// <summary>
        /// Gets and sets the property PersonalEmailAddress. 
        /// <para>
        /// A field to describe values to segment on within personal email address.
        /// </para>
        /// </summary>
        public ProfileDimension PersonalEmailAddress
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
        /// A field to describe values to segment on within phone number.
        /// </para>
        /// </summary>
        public ProfileDimension PhoneNumber
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
        /// A field to describe values to segment on within profile type.
        /// </para>
        /// </summary>
        public ProfileTypeDimension ProfileType
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
        /// A field to describe values to segment on within shipping address.
        /// </para>
        /// </summary>
        public AddressDimension ShippingAddress
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