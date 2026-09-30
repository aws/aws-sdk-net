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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// A duplicate customer profile that is to be merged into a main profile.
    /// </summary>
    public partial class FieldSourceProfileIds
    {
        /// <summary>
        /// Gets and sets the property AccountNumber. 
        /// <para>
        /// A unique identifier for the account number field to be merged. 
        /// </para>
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Checks to see if the AccountNumber property is set.
        /// </summary>
        internal bool IsSetAccountNumber() => this.AccountNumber != null;

        /// <summary>
        /// Gets and sets the property AdditionalInformation. 
        /// <para>
        /// A unique identifier for the additional information field to be merged.
        /// </para>
        /// </summary>
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalInformation property is set.
        /// </summary>
        internal bool IsSetAdditionalInformation() => this.AdditionalInformation != null;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// A unique identifier for the party type field to be merged.
        /// </para>
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A unique identifier for the attributes field to be merged.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BillingAddress. 
        /// <para>
        /// A unique identifier for the billing type field to be merged.
        /// </para>
        /// </summary>
        public string BillingAddress { get; set; }

        /// <summary>
        /// Checks to see if the BillingAddress property is set.
        /// </summary>
        internal bool IsSetBillingAddress() => this.BillingAddress != null;

        /// <summary>
        /// Gets and sets the property BirthDate. 
        /// <para>
        /// A unique identifier for the birthdate field to be merged.
        /// </para>
        /// </summary>
        public string BirthDate { get; set; }

        /// <summary>
        /// Checks to see if the BirthDate property is set.
        /// </summary>
        internal bool IsSetBirthDate() => this.BirthDate != null;

        /// <summary>
        /// Gets and sets the property BusinessEmailAddress. 
        /// <para>
        /// A unique identifier for the party type field to be merged.
        /// </para>
        /// </summary>
        public string BusinessEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the BusinessEmailAddress property is set.
        /// </summary>
        internal bool IsSetBusinessEmailAddress() => this.BusinessEmailAddress != null;

        /// <summary>
        /// Gets and sets the property BusinessName. 
        /// <para>
        /// A unique identifier for the business name field to be merged.
        /// </para>
        /// </summary>
        public string BusinessName { get; set; }

        /// <summary>
        /// Checks to see if the BusinessName property is set.
        /// </summary>
        internal bool IsSetBusinessName() => this.BusinessName != null;

        /// <summary>
        /// Gets and sets the property BusinessPhoneNumber. 
        /// <para>
        /// A unique identifier for the business phone number field to be merged.
        /// </para>
        /// </summary>
        public string BusinessPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the BusinessPhoneNumber property is set.
        /// </summary>
        internal bool IsSetBusinessPhoneNumber() => this.BusinessPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// A unique identifier for the email address field to be merged.
        /// </para>
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property EngagementPreferences. 
        /// <para>
        /// A unique identifier for the engagement preferences field to be merged.
        /// </para>
        /// </summary>
        public string EngagementPreferences { get; set; }

        /// <summary>
        /// Checks to see if the EngagementPreferences property is set.
        /// </summary>
        internal bool IsSetEngagementPreferences() => this.EngagementPreferences != null;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// A unique identifier for the first name field to be merged.
        /// </para>
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Checks to see if the FirstName property is set.
        /// </summary>
        internal bool IsSetFirstName() => this.FirstName != null;

        /// <summary>
        /// Gets and sets the property Gender. 
        /// <para>
        /// A unique identifier for the gender field to be merged.
        /// </para>
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Checks to see if the Gender property is set.
        /// </summary>
        internal bool IsSetGender() => this.Gender != null;

        /// <summary>
        /// Gets and sets the property HomePhoneNumber. 
        /// <para>
        /// A unique identifier for the home phone number field to be merged.
        /// </para>
        /// </summary>
        public string HomePhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the HomePhoneNumber property is set.
        /// </summary>
        internal bool IsSetHomePhoneNumber() => this.HomePhoneNumber != null;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// A unique identifier for the last name field to be merged.
        /// </para>
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property MailingAddress. 
        /// <para>
        /// A unique identifier for the mailing address field to be merged.
        /// </para>
        /// </summary>
        public string MailingAddress { get; set; }

        /// <summary>
        /// Checks to see if the MailingAddress property is set.
        /// </summary>
        internal bool IsSetMailingAddress() => this.MailingAddress != null;

        /// <summary>
        /// Gets and sets the property MiddleName. 
        /// <para>
        /// A unique identifier for the middle name field to be merged.
        /// </para>
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Checks to see if the MiddleName property is set.
        /// </summary>
        internal bool IsSetMiddleName() => this.MiddleName != null;

        /// <summary>
        /// Gets and sets the property MobilePhoneNumber. 
        /// <para>
        /// A unique identifier for the mobile phone number field to be merged.
        /// </para>
        /// </summary>
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the MobilePhoneNumber property is set.
        /// </summary>
        internal bool IsSetMobilePhoneNumber() => this.MobilePhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PartyType. 
        /// <para>
        /// A unique identifier for the party type field to be merged.
        /// </para>
        /// </summary>
        public string PartyType { get; set; }

        /// <summary>
        /// Checks to see if the PartyType property is set.
        /// </summary>
        internal bool IsSetPartyType() => this.PartyType != null;

        /// <summary>
        /// Gets and sets the property PersonalEmailAddress. 
        /// <para>
        /// A unique identifier for the personal email address field to be merged.
        /// </para>
        /// </summary>
        public string PersonalEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the PersonalEmailAddress property is set.
        /// </summary>
        internal bool IsSetPersonalEmailAddress() => this.PersonalEmailAddress != null;

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// A unique identifier for the phone number field to be merged.
        /// </para>
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property ProfileType. 
        /// <para>
        /// A unique identifier for the profile type field to be merged.
        /// </para>
        /// </summary>
        public string ProfileType { get; set; }

        /// <summary>
        /// Checks to see if the ProfileType property is set.
        /// </summary>
        internal bool IsSetProfileType() => this.ProfileType != null;

        /// <summary>
        /// Gets and sets the property ShippingAddress. 
        /// <para>
        /// A unique identifier for the shipping address field to be merged.
        /// </para>
        /// </summary>
        public string ShippingAddress { get; set; }

        /// <summary>
        /// Checks to see if the ShippingAddress property is set.
        /// </summary>
        internal bool IsSetShippingAddress() => this.ShippingAddress != null;
    }
}
