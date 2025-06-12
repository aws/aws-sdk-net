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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The customer profile attributes that are used with the message template.
    /// </summary>
    public partial class CustomerProfileAttributes
    {
        private string _accountNumber;
        private string _additionalInformation;
        private string _address1;
        private string _address2;
        private string _address3;
        private string _address4;
        private string _billingAddress1;
        private string _billingAddress2;
        private string _billingAddress3;
        private string _billingAddress4;
        private string _billingCity;
        private string _billingCountry;
        private string _billingCounty;
        private string _billingPostalCode;
        private string _billingProvince;
        private string _billingState;
        private string _birthDate;
        private string _businessEmailAddress;
        private string _businessName;
        private string _businessPhoneNumber;
        private string _city;
        private string _country;
        private string _county;
        private Dictionary<string, string> _custom = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _emailAddress;
        private string _firstName;
        private string _gender;
        private string _homePhoneNumber;
        private string _lastName;
        private string _mailingAddress1;
        private string _mailingAddress2;
        private string _mailingAddress3;
        private string _mailingAddress4;
        private string _mailingCity;
        private string _mailingCountry;
        private string _mailingCounty;
        private string _mailingPostalCode;
        private string _mailingProvince;
        private string _mailingState;
        private string _middleName;
        private string _mobilePhoneNumber;
        private string _partyType;
        private string _phoneNumber;
        private string _postalCode;
        private string _profilearn;
        private string _profileId;
        private string _province;
        private string _shippingAddress1;
        private string _shippingAddress2;
        private string _shippingAddress3;
        private string _shippingAddress4;
        private string _shippingCity;
        private string _shippingCountry;
        private string _shippingCounty;
        private string _shippingPostalCode;
        private string _shippingProvince;
        private string _shippingState;
        private string _state;

        /// <summary>
        /// Gets and sets the property AccountNumber. 
        /// <para>
        /// A unique account number that you have given to the customer.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// Gets and sets the property Address1. 
        /// <para>
        /// The first line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string Address1
        {
            get { return this._address1; }
            set { this._address1 = value; }
        }

        // Check to see if Address1 property is set
        internal bool IsSetAddress1()
        {
            return this._address1 != null;
        }

        /// <summary>
        /// Gets and sets the property Address2. 
        /// <para>
        /// The second line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string Address2
        {
            get { return this._address2; }
            set { this._address2 = value; }
        }

        // Check to see if Address2 property is set
        internal bool IsSetAddress2()
        {
            return this._address2 != null;
        }

        /// <summary>
        /// Gets and sets the property Address3. 
        /// <para>
        /// The third line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string Address3
        {
            get { return this._address3; }
            set { this._address3 = value; }
        }

        // Check to see if Address3 property is set
        internal bool IsSetAddress3()
        {
            return this._address3 != null;
        }

        /// <summary>
        /// Gets and sets the property Address4. 
        /// <para>
        /// The fourth line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string Address4
        {
            get { return this._address4; }
            set { this._address4 = value; }
        }

        // Check to see if Address4 property is set
        internal bool IsSetAddress4()
        {
            return this._address4 != null;
        }

        /// <summary>
        /// Gets and sets the property BillingAddress1. 
        /// <para>
        /// The first line of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string BillingAddress1
        {
            get { return this._billingAddress1; }
            set { this._billingAddress1 = value; }
        }

        // Check to see if BillingAddress1 property is set
        internal bool IsSetBillingAddress1()
        {
            return this._billingAddress1 != null;
        }

        /// <summary>
        /// Gets and sets the property BillingAddress2. 
        /// <para>
        /// The second line of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string BillingAddress2
        {
            get { return this._billingAddress2; }
            set { this._billingAddress2 = value; }
        }

        // Check to see if BillingAddress2 property is set
        internal bool IsSetBillingAddress2()
        {
            return this._billingAddress2 != null;
        }

        /// <summary>
        /// Gets and sets the property BillingAddress3. 
        /// <para>
        /// The third line of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string BillingAddress3
        {
            get { return this._billingAddress3; }
            set { this._billingAddress3 = value; }
        }

        // Check to see if BillingAddress3 property is set
        internal bool IsSetBillingAddress3()
        {
            return this._billingAddress3 != null;
        }

        /// <summary>
        /// Gets and sets the property BillingAddress4. 
        /// <para>
        /// The fourth line of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string BillingAddress4
        {
            get { return this._billingAddress4; }
            set { this._billingAddress4 = value; }
        }

        // Check to see if BillingAddress4 property is set
        internal bool IsSetBillingAddress4()
        {
            return this._billingAddress4 != null;
        }

        /// <summary>
        /// Gets and sets the property BillingCity. 
        /// <para>
        /// The city of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string BillingCity
        {
            get { return this._billingCity; }
            set { this._billingCity = value; }
        }

        // Check to see if BillingCity property is set
        internal bool IsSetBillingCity()
        {
            return this._billingCity != null;
        }

        /// <summary>
        /// Gets and sets the property BillingCountry. 
        /// <para>
        /// The country of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string BillingCountry
        {
            get { return this._billingCountry; }
            set { this._billingCountry = value; }
        }

        // Check to see if BillingCountry property is set
        internal bool IsSetBillingCountry()
        {
            return this._billingCountry != null;
        }

        /// <summary>
        /// Gets and sets the property BillingCounty. 
        /// <para>
        /// The county of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string BillingCounty
        {
            get { return this._billingCounty; }
            set { this._billingCounty = value; }
        }

        // Check to see if BillingCounty property is set
        internal bool IsSetBillingCounty()
        {
            return this._billingCounty != null;
        }

        /// <summary>
        /// Gets and sets the property BillingPostalCode. 
        /// <para>
        /// The postal code of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string BillingPostalCode
        {
            get { return this._billingPostalCode; }
            set { this._billingPostalCode = value; }
        }

        // Check to see if BillingPostalCode property is set
        internal bool IsSetBillingPostalCode()
        {
            return this._billingPostalCode != null;
        }

        /// <summary>
        /// Gets and sets the property BillingProvince. 
        /// <para>
        /// The province of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string BillingProvince
        {
            get { return this._billingProvince; }
            set { this._billingProvince = value; }
        }

        // Check to see if BillingProvince property is set
        internal bool IsSetBillingProvince()
        {
            return this._billingProvince != null;
        }

        /// <summary>
        /// Gets and sets the property BillingState. 
        /// <para>
        /// The state of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string BillingState
        {
            get { return this._billingState; }
            set { this._billingState = value; }
        }

        // Check to see if BillingState property is set
        internal bool IsSetBillingState()
        {
            return this._billingState != null;
        }

        /// <summary>
        /// Gets and sets the property BirthDate. 
        /// <para>
        /// The customer's birth date.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// The customer's business email address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// The name of the customer's business.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// The customer's business phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// Gets and sets the property City. 
        /// <para>
        /// The city in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string City
        {
            get { return this._city; }
            set { this._city = value; }
        }

        // Check to see if City property is set
        internal bool IsSetCity()
        {
            return this._city != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property County. 
        /// <para>
        /// The county in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string County
        {
            get { return this._county; }
            set { this._county = value; }
        }

        // Check to see if County property is set
        internal bool IsSetCounty()
        {
            return this._county != null;
        }

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        /// The custom attributes in customer profile attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Custom
        {
            get { return this._custom; }
            set { this._custom = value; }
        }

        // Check to see if Custom property is set
        internal bool IsSetCustom()
        {
            return this._custom != null && (this._custom.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The customer's email address, which has not been specified as a personal or business
        /// address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// The customer's first name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// The customer's gender.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// The customer's mobile phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// The customer's last name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// Gets and sets the property MailingAddress1. 
        /// <para>
        /// The first line of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string MailingAddress1
        {
            get { return this._mailingAddress1; }
            set { this._mailingAddress1 = value; }
        }

        // Check to see if MailingAddress1 property is set
        internal bool IsSetMailingAddress1()
        {
            return this._mailingAddress1 != null;
        }

        /// <summary>
        /// Gets and sets the property MailingAddress2. 
        /// <para>
        /// The second line of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string MailingAddress2
        {
            get { return this._mailingAddress2; }
            set { this._mailingAddress2 = value; }
        }

        // Check to see if MailingAddress2 property is set
        internal bool IsSetMailingAddress2()
        {
            return this._mailingAddress2 != null;
        }

        /// <summary>
        /// Gets and sets the property MailingAddress3. 
        /// <para>
        /// The third line of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string MailingAddress3
        {
            get { return this._mailingAddress3; }
            set { this._mailingAddress3 = value; }
        }

        // Check to see if MailingAddress3 property is set
        internal bool IsSetMailingAddress3()
        {
            return this._mailingAddress3 != null;
        }

        /// <summary>
        /// Gets and sets the property MailingAddress4. 
        /// <para>
        /// The fourth line of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string MailingAddress4
        {
            get { return this._mailingAddress4; }
            set { this._mailingAddress4 = value; }
        }

        // Check to see if MailingAddress4 property is set
        internal bool IsSetMailingAddress4()
        {
            return this._mailingAddress4 != null;
        }

        /// <summary>
        /// Gets and sets the property MailingCity. 
        /// <para>
        /// The city of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string MailingCity
        {
            get { return this._mailingCity; }
            set { this._mailingCity = value; }
        }

        // Check to see if MailingCity property is set
        internal bool IsSetMailingCity()
        {
            return this._mailingCity != null;
        }

        /// <summary>
        /// Gets and sets the property MailingCountry. 
        /// <para>
        /// The country of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string MailingCountry
        {
            get { return this._mailingCountry; }
            set { this._mailingCountry = value; }
        }

        // Check to see if MailingCountry property is set
        internal bool IsSetMailingCountry()
        {
            return this._mailingCountry != null;
        }

        /// <summary>
        /// Gets and sets the property MailingCounty. 
        /// <para>
        /// The county of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string MailingCounty
        {
            get { return this._mailingCounty; }
            set { this._mailingCounty = value; }
        }

        // Check to see if MailingCounty property is set
        internal bool IsSetMailingCounty()
        {
            return this._mailingCounty != null;
        }

        /// <summary>
        /// Gets and sets the property MailingPostalCode. 
        /// <para>
        /// The postal code of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string MailingPostalCode
        {
            get { return this._mailingPostalCode; }
            set { this._mailingPostalCode = value; }
        }

        // Check to see if MailingPostalCode property is set
        internal bool IsSetMailingPostalCode()
        {
            return this._mailingPostalCode != null;
        }

        /// <summary>
        /// Gets and sets the property MailingProvince. 
        /// <para>
        /// The province of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string MailingProvince
        {
            get { return this._mailingProvince; }
            set { this._mailingProvince = value; }
        }

        // Check to see if MailingProvince property is set
        internal bool IsSetMailingProvince()
        {
            return this._mailingProvince != null;
        }

        /// <summary>
        /// Gets and sets the property MailingState. 
        /// <para>
        /// The state of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string MailingState
        {
            get { return this._mailingState; }
            set { this._mailingState = value; }
        }

        // Check to see if MailingState property is set
        internal bool IsSetMailingState()
        {
            return this._mailingState != null;
        }

        /// <summary>
        /// Gets and sets the property MiddleName. 
        /// <para>
        /// The customer's middle name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// The customer's mobile phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// The customer's party type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The customer's phone number, which has not been specified as a mobile, home, or business
        /// number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string PostalCode
        {
            get { return this._postalCode; }
            set { this._postalCode = value; }
        }

        // Check to see if PostalCode property is set
        internal bool IsSetPostalCode()
        {
            return this._postalCode != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileARN. 
        /// <para>
        /// The ARN of a customer profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string ProfileARN
        {
            get { return this._profilearn; }
            set { this._profilearn = value; }
        }

        // Check to see if ProfileARN property is set
        internal bool IsSetProfileARN()
        {
            return this._profilearn != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of a customer profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
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
        /// Gets and sets the property Province. 
        /// <para>
        /// The province in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string Province
        {
            get { return this._province; }
            set { this._province = value; }
        }

        // Check to see if Province property is set
        internal bool IsSetProvince()
        {
            return this._province != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingAddress1. 
        /// <para>
        /// The first line of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string ShippingAddress1
        {
            get { return this._shippingAddress1; }
            set { this._shippingAddress1 = value; }
        }

        // Check to see if ShippingAddress1 property is set
        internal bool IsSetShippingAddress1()
        {
            return this._shippingAddress1 != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingAddress2. 
        /// <para>
        /// The second line of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string ShippingAddress2
        {
            get { return this._shippingAddress2; }
            set { this._shippingAddress2 = value; }
        }

        // Check to see if ShippingAddress2 property is set
        internal bool IsSetShippingAddress2()
        {
            return this._shippingAddress2 != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingAddress3. 
        /// <para>
        /// The third line of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string ShippingAddress3
        {
            get { return this._shippingAddress3; }
            set { this._shippingAddress3 = value; }
        }

        // Check to see if ShippingAddress3 property is set
        internal bool IsSetShippingAddress3()
        {
            return this._shippingAddress3 != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingAddress4. 
        /// <para>
        /// The fourth line of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string ShippingAddress4
        {
            get { return this._shippingAddress4; }
            set { this._shippingAddress4 = value; }
        }

        // Check to see if ShippingAddress4 property is set
        internal bool IsSetShippingAddress4()
        {
            return this._shippingAddress4 != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingCity. 
        /// <para>
        /// The city of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string ShippingCity
        {
            get { return this._shippingCity; }
            set { this._shippingCity = value; }
        }

        // Check to see if ShippingCity property is set
        internal bool IsSetShippingCity()
        {
            return this._shippingCity != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingCountry. 
        /// <para>
        /// The country of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string ShippingCountry
        {
            get { return this._shippingCountry; }
            set { this._shippingCountry = value; }
        }

        // Check to see if ShippingCountry property is set
        internal bool IsSetShippingCountry()
        {
            return this._shippingCountry != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingCounty. 
        /// <para>
        /// The county of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string ShippingCounty
        {
            get { return this._shippingCounty; }
            set { this._shippingCounty = value; }
        }

        // Check to see if ShippingCounty property is set
        internal bool IsSetShippingCounty()
        {
            return this._shippingCounty != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingPostalCode. 
        /// <para>
        /// The postal code of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string ShippingPostalCode
        {
            get { return this._shippingPostalCode; }
            set { this._shippingPostalCode = value; }
        }

        // Check to see if ShippingPostalCode property is set
        internal bool IsSetShippingPostalCode()
        {
            return this._shippingPostalCode != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingProvince. 
        /// <para>
        /// The province of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string ShippingProvince
        {
            get { return this._shippingProvince; }
            set { this._shippingProvince = value; }
        }

        // Check to see if ShippingProvince property is set
        internal bool IsSetShippingProvince()
        {
            return this._shippingProvince != null;
        }

        /// <summary>
        /// Gets and sets the property ShippingState. 
        /// <para>
        /// The state of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string ShippingState
        {
            get { return this._shippingState; }
            set { this._shippingState = value; }
        }

        // Check to see if ShippingState property is set
        internal bool IsSetShippingState()
        {
            return this._shippingState != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=32767)]
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}