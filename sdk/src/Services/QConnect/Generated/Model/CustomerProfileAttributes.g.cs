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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AccountNumber. 
        /// <para>
        /// A unique account number that you have given to the customer.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Checks to see if the AccountNumber property is set.
        /// </summary>
        internal bool IsSetAccountNumber() => this.AccountNumber != null;

        /// <summary>
        /// Gets and sets the property AdditionalInformation. 
        /// <para>
        /// Any additional information relevant to the customer's profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalInformation property is set.
        /// </summary>
        internal bool IsSetAdditionalInformation() => this.AdditionalInformation != null;

        /// <summary>
        /// Gets and sets the property Address1. 
        /// <para>
        /// The first line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Address1 { get; set; }

        /// <summary>
        /// Checks to see if the Address1 property is set.
        /// </summary>
        internal bool IsSetAddress1() => this.Address1 != null;

        /// <summary>
        /// Gets and sets the property Address2. 
        /// <para>
        /// The second line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Address2 { get; set; }

        /// <summary>
        /// Checks to see if the Address2 property is set.
        /// </summary>
        internal bool IsSetAddress2() => this.Address2 != null;

        /// <summary>
        /// Gets and sets the property Address3. 
        /// <para>
        /// The third line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Address3 { get; set; }

        /// <summary>
        /// Checks to see if the Address3 property is set.
        /// </summary>
        internal bool IsSetAddress3() => this.Address3 != null;

        /// <summary>
        /// Gets and sets the property Address4. 
        /// <para>
        /// The fourth line of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Address4 { get; set; }

        /// <summary>
        /// Checks to see if the Address4 property is set.
        /// </summary>
        internal bool IsSetAddress4() => this.Address4 != null;

        /// <summary>
        /// Gets and sets the property BillingAddress1. 
        /// <para>
        /// The first line of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string BillingAddress1 { get; set; }

        /// <summary>
        /// Checks to see if the BillingAddress1 property is set.
        /// </summary>
        internal bool IsSetBillingAddress1() => this.BillingAddress1 != null;

        /// <summary>
        /// Gets and sets the property BillingAddress2. 
        /// <para>
        /// The second line of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string BillingAddress2 { get; set; }

        /// <summary>
        /// Checks to see if the BillingAddress2 property is set.
        /// </summary>
        internal bool IsSetBillingAddress2() => this.BillingAddress2 != null;

        /// <summary>
        /// Gets and sets the property BillingAddress3. 
        /// <para>
        /// The third line of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string BillingAddress3 { get; set; }

        /// <summary>
        /// Checks to see if the BillingAddress3 property is set.
        /// </summary>
        internal bool IsSetBillingAddress3() => this.BillingAddress3 != null;

        /// <summary>
        /// Gets and sets the property BillingAddress4. 
        /// <para>
        /// The fourth line of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string BillingAddress4 { get; set; }

        /// <summary>
        /// Checks to see if the BillingAddress4 property is set.
        /// </summary>
        internal bool IsSetBillingAddress4() => this.BillingAddress4 != null;

        /// <summary>
        /// Gets and sets the property BillingCity. 
        /// <para>
        /// The city of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string BillingCity { get; set; }

        /// <summary>
        /// Checks to see if the BillingCity property is set.
        /// </summary>
        internal bool IsSetBillingCity() => this.BillingCity != null;

        /// <summary>
        /// Gets and sets the property BillingCountry. 
        /// <para>
        /// The country of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string BillingCountry { get; set; }

        /// <summary>
        /// Checks to see if the BillingCountry property is set.
        /// </summary>
        internal bool IsSetBillingCountry() => this.BillingCountry != null;

        /// <summary>
        /// Gets and sets the property BillingCounty. 
        /// <para>
        /// The county of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string BillingCounty { get; set; }

        /// <summary>
        /// Checks to see if the BillingCounty property is set.
        /// </summary>
        internal bool IsSetBillingCounty() => this.BillingCounty != null;

        /// <summary>
        /// Gets and sets the property BillingPostalCode. 
        /// <para>
        /// The postal code of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string BillingPostalCode { get; set; }

        /// <summary>
        /// Checks to see if the BillingPostalCode property is set.
        /// </summary>
        internal bool IsSetBillingPostalCode() => this.BillingPostalCode != null;

        /// <summary>
        /// Gets and sets the property BillingProvince. 
        /// <para>
        /// The province of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string BillingProvince { get; set; }

        /// <summary>
        /// Checks to see if the BillingProvince property is set.
        /// </summary>
        internal bool IsSetBillingProvince() => this.BillingProvince != null;

        /// <summary>
        /// Gets and sets the property BillingState. 
        /// <para>
        /// The state of a customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string BillingState { get; set; }

        /// <summary>
        /// Checks to see if the BillingState property is set.
        /// </summary>
        internal bool IsSetBillingState() => this.BillingState != null;

        /// <summary>
        /// Gets and sets the property BirthDate. 
        /// <para>
        /// The customer's birth date.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string BirthDate { get; set; }

        /// <summary>
        /// Checks to see if the BirthDate property is set.
        /// </summary>
        internal bool IsSetBirthDate() => this.BirthDate != null;

        /// <summary>
        /// Gets and sets the property BusinessEmailAddress. 
        /// <para>
        /// The customer's business email address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string BusinessEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the BusinessEmailAddress property is set.
        /// </summary>
        internal bool IsSetBusinessEmailAddress() => this.BusinessEmailAddress != null;

        /// <summary>
        /// Gets and sets the property BusinessName. 
        /// <para>
        /// The name of the customer's business.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Checks to see if the BusinessName property is set.
        /// </summary>
        internal bool IsSetBusinessName() => this.BusinessName != null;

        /// <summary>
        /// Gets and sets the property BusinessPhoneNumber. 
        /// <para>
        /// The customer's business phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string BusinessPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the BusinessPhoneNumber property is set.
        /// </summary>
        internal bool IsSetBusinessPhoneNumber() => this.BusinessPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property City. 
        /// <para>
        /// The city in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string City { get; set; }

        /// <summary>
        /// Checks to see if the City property is set.
        /// </summary>
        internal bool IsSetCity() => this.City != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property County. 
        /// <para>
        /// The county in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string County { get; set; }

        /// <summary>
        /// Checks to see if the County property is set.
        /// </summary>
        internal bool IsSetCounty() => this.County != null;

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        /// The custom attributes in customer profile attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Custom { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Custom property is set.
        /// </summary>
        internal bool IsSetCustom() => this.Custom != null && (this.Custom.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The customer's email address, which has not been specified as a personal or business
        /// address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The customer's first name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string FirstName { get; set; }

        /// <summary>
        /// Checks to see if the FirstName property is set.
        /// </summary>
        internal bool IsSetFirstName() => this.FirstName != null;

        /// <summary>
        /// Gets and sets the property Gender. 
        /// <para>
        /// The customer's gender.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Gender { get; set; }

        /// <summary>
        /// Checks to see if the Gender property is set.
        /// </summary>
        internal bool IsSetGender() => this.Gender != null;

        /// <summary>
        /// Gets and sets the property HomePhoneNumber. 
        /// <para>
        /// The customer's mobile phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string HomePhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the HomePhoneNumber property is set.
        /// </summary>
        internal bool IsSetHomePhoneNumber() => this.HomePhoneNumber != null;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The customer's last name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property MailingAddress1. 
        /// <para>
        /// The first line of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string MailingAddress1 { get; set; }

        /// <summary>
        /// Checks to see if the MailingAddress1 property is set.
        /// </summary>
        internal bool IsSetMailingAddress1() => this.MailingAddress1 != null;

        /// <summary>
        /// Gets and sets the property MailingAddress2. 
        /// <para>
        /// The second line of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string MailingAddress2 { get; set; }

        /// <summary>
        /// Checks to see if the MailingAddress2 property is set.
        /// </summary>
        internal bool IsSetMailingAddress2() => this.MailingAddress2 != null;

        /// <summary>
        /// Gets and sets the property MailingAddress3. 
        /// <para>
        /// The third line of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string MailingAddress3 { get; set; }

        /// <summary>
        /// Checks to see if the MailingAddress3 property is set.
        /// </summary>
        internal bool IsSetMailingAddress3() => this.MailingAddress3 != null;

        /// <summary>
        /// Gets and sets the property MailingAddress4. 
        /// <para>
        /// The fourth line of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string MailingAddress4 { get; set; }

        /// <summary>
        /// Checks to see if the MailingAddress4 property is set.
        /// </summary>
        internal bool IsSetMailingAddress4() => this.MailingAddress4 != null;

        /// <summary>
        /// Gets and sets the property MailingCity. 
        /// <para>
        /// The city of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string MailingCity { get; set; }

        /// <summary>
        /// Checks to see if the MailingCity property is set.
        /// </summary>
        internal bool IsSetMailingCity() => this.MailingCity != null;

        /// <summary>
        /// Gets and sets the property MailingCountry. 
        /// <para>
        /// The country of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string MailingCountry { get; set; }

        /// <summary>
        /// Checks to see if the MailingCountry property is set.
        /// </summary>
        internal bool IsSetMailingCountry() => this.MailingCountry != null;

        /// <summary>
        /// Gets and sets the property MailingCounty. 
        /// <para>
        /// The county of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string MailingCounty { get; set; }

        /// <summary>
        /// Checks to see if the MailingCounty property is set.
        /// </summary>
        internal bool IsSetMailingCounty() => this.MailingCounty != null;

        /// <summary>
        /// Gets and sets the property MailingPostalCode. 
        /// <para>
        /// The postal code of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string MailingPostalCode { get; set; }

        /// <summary>
        /// Checks to see if the MailingPostalCode property is set.
        /// </summary>
        internal bool IsSetMailingPostalCode() => this.MailingPostalCode != null;

        /// <summary>
        /// Gets and sets the property MailingProvince. 
        /// <para>
        /// The province of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string MailingProvince { get; set; }

        /// <summary>
        /// Checks to see if the MailingProvince property is set.
        /// </summary>
        internal bool IsSetMailingProvince() => this.MailingProvince != null;

        /// <summary>
        /// Gets and sets the property MailingState. 
        /// <para>
        /// The state of a customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string MailingState { get; set; }

        /// <summary>
        /// Checks to see if the MailingState property is set.
        /// </summary>
        internal bool IsSetMailingState() => this.MailingState != null;

        /// <summary>
        /// Gets and sets the property MiddleName. 
        /// <para>
        /// The customer's middle name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Checks to see if the MiddleName property is set.
        /// </summary>
        internal bool IsSetMiddleName() => this.MiddleName != null;

        /// <summary>
        /// Gets and sets the property MobilePhoneNumber. 
        /// <para>
        /// The customer's mobile phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the MobilePhoneNumber property is set.
        /// </summary>
        internal bool IsSetMobilePhoneNumber() => this.MobilePhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PartyType. 
        /// <para>
        /// The customer's party type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string PartyType { get; set; }

        /// <summary>
        /// Checks to see if the PartyType property is set.
        /// </summary>
        internal bool IsSetPartyType() => this.PartyType != null;

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The customer's phone number, which has not been specified as a mobile, home, or business
        /// number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PostalCode. 
        /// <para>
        /// The postal code of a customer address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Checks to see if the PostalCode property is set.
        /// </summary>
        internal bool IsSetPostalCode() => this.PostalCode != null;

        /// <summary>
        /// Gets and sets the property ProfileARN. 
        /// <para>
        /// The ARN of a customer profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string ProfileARN { get; set; }

        /// <summary>
        /// Checks to see if the ProfileARN property is set.
        /// </summary>
        internal bool IsSetProfileARN() => this.ProfileARN != null;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of a customer profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property Province. 
        /// <para>
        /// The province in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Province { get; set; }

        /// <summary>
        /// Checks to see if the Province property is set.
        /// </summary>
        internal bool IsSetProvince() => this.Province != null;

        /// <summary>
        /// Gets and sets the property ShippingAddress1. 
        /// <para>
        /// The first line of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string ShippingAddress1 { get; set; }

        /// <summary>
        /// Checks to see if the ShippingAddress1 property is set.
        /// </summary>
        internal bool IsSetShippingAddress1() => this.ShippingAddress1 != null;

        /// <summary>
        /// Gets and sets the property ShippingAddress2. 
        /// <para>
        /// The second line of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string ShippingAddress2 { get; set; }

        /// <summary>
        /// Checks to see if the ShippingAddress2 property is set.
        /// </summary>
        internal bool IsSetShippingAddress2() => this.ShippingAddress2 != null;

        /// <summary>
        /// Gets and sets the property ShippingAddress3. 
        /// <para>
        /// The third line of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string ShippingAddress3 { get; set; }

        /// <summary>
        /// Checks to see if the ShippingAddress3 property is set.
        /// </summary>
        internal bool IsSetShippingAddress3() => this.ShippingAddress3 != null;

        /// <summary>
        /// Gets and sets the property ShippingAddress4. 
        /// <para>
        /// The fourth line of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string ShippingAddress4 { get; set; }

        /// <summary>
        /// Checks to see if the ShippingAddress4 property is set.
        /// </summary>
        internal bool IsSetShippingAddress4() => this.ShippingAddress4 != null;

        /// <summary>
        /// Gets and sets the property ShippingCity. 
        /// <para>
        /// The city of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string ShippingCity { get; set; }

        /// <summary>
        /// Checks to see if the ShippingCity property is set.
        /// </summary>
        internal bool IsSetShippingCity() => this.ShippingCity != null;

        /// <summary>
        /// Gets and sets the property ShippingCountry. 
        /// <para>
        /// The country of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string ShippingCountry { get; set; }

        /// <summary>
        /// Checks to see if the ShippingCountry property is set.
        /// </summary>
        internal bool IsSetShippingCountry() => this.ShippingCountry != null;

        /// <summary>
        /// Gets and sets the property ShippingCounty. 
        /// <para>
        /// The county of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string ShippingCounty { get; set; }

        /// <summary>
        /// Checks to see if the ShippingCounty property is set.
        /// </summary>
        internal bool IsSetShippingCounty() => this.ShippingCounty != null;

        /// <summary>
        /// Gets and sets the property ShippingPostalCode. 
        /// <para>
        /// The postal code of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string ShippingPostalCode { get; set; }

        /// <summary>
        /// Checks to see if the ShippingPostalCode property is set.
        /// </summary>
        internal bool IsSetShippingPostalCode() => this.ShippingPostalCode != null;

        /// <summary>
        /// Gets and sets the property ShippingProvince. 
        /// <para>
        /// The province of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string ShippingProvince { get; set; }

        /// <summary>
        /// Checks to see if the ShippingProvince property is set.
        /// </summary>
        internal bool IsSetShippingProvince() => this.ShippingProvince != null;

        /// <summary>
        /// Gets and sets the property ShippingState. 
        /// <para>
        /// The state of a customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string ShippingState { get; set; }

        /// <summary>
        /// Checks to see if the ShippingState property is set.
        /// </summary>
        internal bool IsSetShippingState() => this.ShippingState != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state in which a customer lives.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
