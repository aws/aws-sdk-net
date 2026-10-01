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
    /// Container for the parameters to the CreateProfile operation. Creates a standard profile.
    /// <para> A standard profile represents the following attributes for a customer profile
    /// in a domain. </para>
    /// </summary>
    public partial class CreateProfileRequest : AmazonCustomerProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property AccountNumber. 
        /// <para>
        /// An account number that you have assigned to the customer.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Checks to see if the AccountNumber property is set.
        /// </summary>
        internal bool IsSetAccountNumber() => this.AccountNumber != null;

        /// <summary>
        /// Gets and sets the property AdditionalInformation. 
        /// <para>
        /// Any additional information relevant to the customer’s profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalInformation property is set.
        /// </summary>
        internal bool IsSetAdditionalInformation() => this.AdditionalInformation != null;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// A generic address associated with the customer that is not mailing, shipping, or billing.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Address Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A key value pair of attributes of a customer profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BillingAddress. 
        /// <para>
        /// The customer’s billing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Checks to see if the BillingAddress property is set.
        /// </summary>
        internal bool IsSetBillingAddress() => this.BillingAddress != null;

        /// <summary>
        /// Gets and sets the property BirthDate. 
        /// <para>
        /// The customer’s birth date. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string BirthDate { get; set; }

        /// <summary>
        /// Checks to see if the BirthDate property is set.
        /// </summary>
        internal bool IsSetBirthDate() => this.BirthDate != null;

        /// <summary>
        /// Gets and sets the property BusinessEmailAddress. 
        /// <para>
        /// The customer’s business email address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string BusinessEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the BusinessEmailAddress property is set.
        /// </summary>
        internal bool IsSetBusinessEmailAddress() => this.BusinessEmailAddress != null;

        /// <summary>
        /// Gets and sets the property BusinessName. 
        /// <para>
        /// The name of the customer’s business.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Checks to see if the BusinessName property is set.
        /// </summary>
        internal bool IsSetBusinessName() => this.BusinessName != null;

        /// <summary>
        /// Gets and sets the property BusinessPhoneNumber. 
        /// <para>
        /// The customer’s business phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string BusinessPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the BusinessPhoneNumber property is set.
        /// </summary>
        internal bool IsSetBusinessPhoneNumber() => this.BusinessPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The customer’s email address, which has not been specified as a personal or business
        /// address. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property EngagementPreferences. 
        /// <para>
        /// Object that defines the preferred methods of engagement, per channel.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public EngagementPreferences EngagementPreferences { get; set; }

        /// <summary>
        /// Checks to see if the EngagementPreferences property is set.
        /// </summary>
        internal bool IsSetEngagementPreferences() => this.EngagementPreferences != null;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The customer’s first name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string FirstName { get; set; }

        /// <summary>
        /// Checks to see if the FirstName property is set.
        /// </summary>
        internal bool IsSetFirstName() => this.FirstName != null;

        /// <summary>
        /// Gets and sets the property Gender. 
        /// <para>
        /// The gender with which the customer identifies. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Gender Gender { get; set; }

        /// <summary>
        /// Checks to see if the Gender property is set.
        /// </summary>
        internal bool IsSetGender() => this.Gender != null;

        /// <summary>
        /// Gets and sets the property GenderString. 
        /// <para>
        /// An alternative to <c>Gender</c> which accepts any string as input.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string GenderString { get; set; }

        /// <summary>
        /// Checks to see if the GenderString property is set.
        /// </summary>
        internal bool IsSetGenderString() => this.GenderString != null;

        /// <summary>
        /// Gets and sets the property HomePhoneNumber. 
        /// <para>
        /// The customer’s home phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string HomePhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the HomePhoneNumber property is set.
        /// </summary>
        internal bool IsSetHomePhoneNumber() => this.HomePhoneNumber != null;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The customer’s last name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property MailingAddress. 
        /// <para>
        /// The customer’s mailing address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Address MailingAddress { get; set; }

        /// <summary>
        /// Checks to see if the MailingAddress property is set.
        /// </summary>
        internal bool IsSetMailingAddress() => this.MailingAddress != null;

        /// <summary>
        /// Gets and sets the property MiddleName. 
        /// <para>
        /// The customer’s middle name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Checks to see if the MiddleName property is set.
        /// </summary>
        internal bool IsSetMiddleName() => this.MiddleName != null;

        /// <summary>
        /// Gets and sets the property MobilePhoneNumber. 
        /// <para>
        /// The customer’s mobile phone number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string MobilePhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the MobilePhoneNumber property is set.
        /// </summary>
        internal bool IsSetMobilePhoneNumber() => this.MobilePhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PartyType. 
        /// <para>
        /// The type of profile used to describe the customer.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public PartyType PartyType { get; set; }

        /// <summary>
        /// Checks to see if the PartyType property is set.
        /// </summary>
        internal bool IsSetPartyType() => this.PartyType != null;

        /// <summary>
        /// Gets and sets the property PartyTypeString. 
        /// <para>
        /// An alternative to <c>PartyType</c> which accepts any string as input.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string PartyTypeString { get; set; }

        /// <summary>
        /// Checks to see if the PartyTypeString property is set.
        /// </summary>
        internal bool IsSetPartyTypeString() => this.PartyTypeString != null;

        /// <summary>
        /// Gets and sets the property PersonalEmailAddress. 
        /// <para>
        /// The customer’s personal email address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string PersonalEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the PersonalEmailAddress property is set.
        /// </summary>
        internal bool IsSetPersonalEmailAddress() => this.PersonalEmailAddress != null;

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// The customer’s phone number, which has not been specified as a mobile, home, or business
        /// number. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property ProfileType. 
        /// <para>
        /// The type of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ProfileType ProfileType { get; set; }

        /// <summary>
        /// Checks to see if the ProfileType property is set.
        /// </summary>
        internal bool IsSetProfileType() => this.ProfileType != null;

        /// <summary>
        /// Gets and sets the property ShippingAddress. 
        /// <para>
        /// The customer’s shipping address.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Checks to see if the ShippingAddress property is set.
        /// </summary>
        internal bool IsSetShippingAddress() => this.ShippingAddress != null;
    }
}
