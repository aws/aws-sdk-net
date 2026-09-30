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
    /// The object used to segment on attributes within the customer profile.
    /// </summary>
    public partial class ProfileAttributes
    {
        /// <summary>
        /// Gets and sets the property AccountNumber. 
        /// <para>
        /// A field to describe values to segment on within account number.
        /// </para>
        /// </summary>
        public ProfileDimension AccountNumber { get; set; }

        /// <summary>
        /// Checks to see if the AccountNumber property is set.
        /// </summary>
        internal bool IsSetAccountNumber() => this.AccountNumber != null;

        /// <summary>
        /// Gets and sets the property AdditionalInformation. 
        /// <para>
        /// A field to describe values to segment on within additional information.
        /// </para>
        /// </summary>
        public ExtraLengthValueProfileDimension AdditionalInformation { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalInformation property is set.
        /// </summary>
        internal bool IsSetAdditionalInformation() => this.AdditionalInformation != null;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// A field to describe values to segment on within address.
        /// </para>
        /// </summary>
        public AddressDimension Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A field to describe values to segment on within attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeDimension> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeDimension>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BillingAddress. 
        /// <para>
        /// A field to describe values to segment on within billing address.
        /// </para>
        /// </summary>
        public AddressDimension BillingAddress { get; set; }

        /// <summary>
        /// Checks to see if the BillingAddress property is set.
        /// </summary>
        internal bool IsSetBillingAddress() => this.BillingAddress != null;

        /// <summary>
        /// Gets and sets the property BirthDate. 
        /// <para>
        /// A field to describe values to segment on within birthDate.
        /// </para>
        /// </summary>
        public DateDimension BirthDate { get; set; }

        /// <summary>
        /// Checks to see if the BirthDate property is set.
        /// </summary>
        internal bool IsSetBirthDate() => this.BirthDate != null;

        /// <summary>
        /// Gets and sets the property BusinessEmailAddress. 
        /// <para>
        /// A field to describe values to segment on within business email address.
        /// </para>
        /// </summary>
        public ProfileDimension BusinessEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the BusinessEmailAddress property is set.
        /// </summary>
        internal bool IsSetBusinessEmailAddress() => this.BusinessEmailAddress != null;

        /// <summary>
        /// Gets and sets the property BusinessName. 
        /// <para>
        /// A field to describe values to segment on within business name.
        /// </para>
        /// </summary>
        public ProfileDimension BusinessName { get; set; }

        /// <summary>
        /// Checks to see if the BusinessName property is set.
        /// </summary>
        internal bool IsSetBusinessName() => this.BusinessName != null;

        /// <summary>
        /// Gets and sets the property BusinessPhoneNumber. 
        /// <para>
        /// A field to describe values to segment on within business phone number.
        /// </para>
        /// </summary>
        public ProfileDimension BusinessPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the BusinessPhoneNumber property is set.
        /// </summary>
        internal bool IsSetBusinessPhoneNumber() => this.BusinessPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// A field to describe values to segment on within email address.
        /// </para>
        /// </summary>
        public ProfileDimension EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// A field to describe values to segment on within first name.
        /// </para>
        /// </summary>
        public ProfileDimension FirstName { get; set; }

        /// <summary>
        /// Checks to see if the FirstName property is set.
        /// </summary>
        internal bool IsSetFirstName() => this.FirstName != null;

        /// <summary>
        /// Gets and sets the property GenderString. 
        /// <para>
        /// A field to describe values to segment on within genderString.
        /// </para>
        /// </summary>
        public ProfileDimension GenderString { get; set; }

        /// <summary>
        /// Checks to see if the GenderString property is set.
        /// </summary>
        internal bool IsSetGenderString() => this.GenderString != null;

        /// <summary>
        /// Gets and sets the property HomePhoneNumber. 
        /// <para>
        /// A field to describe values to segment on within home phone number.
        /// </para>
        /// </summary>
        public ProfileDimension HomePhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the HomePhoneNumber property is set.
        /// </summary>
        internal bool IsSetHomePhoneNumber() => this.HomePhoneNumber != null;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// A field to describe values to segment on within last name.
        /// </para>
        /// </summary>
        public ProfileDimension LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property MailingAddress. 
        /// <para>
        /// A field to describe values to segment on within mailing address.
        /// </para>
        /// </summary>
        public AddressDimension MailingAddress { get; set; }

        /// <summary>
        /// Checks to see if the MailingAddress property is set.
        /// </summary>
        internal bool IsSetMailingAddress() => this.MailingAddress != null;

        /// <summary>
        /// Gets and sets the property MiddleName. 
        /// <para>
        /// A field to describe values to segment on within middle name.
        /// </para>
        /// </summary>
        public ProfileDimension MiddleName { get; set; }

        /// <summary>
        /// Checks to see if the MiddleName property is set.
        /// </summary>
        internal bool IsSetMiddleName() => this.MiddleName != null;

        /// <summary>
        /// Gets and sets the property MobilePhoneNumber. 
        /// <para>
        /// A field to describe values to segment on within mobile phone number.
        /// </para>
        /// </summary>
        public ProfileDimension MobilePhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the MobilePhoneNumber property is set.
        /// </summary>
        internal bool IsSetMobilePhoneNumber() => this.MobilePhoneNumber != null;

        /// <summary>
        /// Gets and sets the property PartyTypeString. 
        /// <para>
        /// A field to describe values to segment on within partyTypeString.
        /// </para>
        /// </summary>
        public ProfileDimension PartyTypeString { get; set; }

        /// <summary>
        /// Checks to see if the PartyTypeString property is set.
        /// </summary>
        internal bool IsSetPartyTypeString() => this.PartyTypeString != null;

        /// <summary>
        /// Gets and sets the property PersonalEmailAddress. 
        /// <para>
        /// A field to describe values to segment on within personal email address.
        /// </para>
        /// </summary>
        public ProfileDimension PersonalEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the PersonalEmailAddress property is set.
        /// </summary>
        internal bool IsSetPersonalEmailAddress() => this.PersonalEmailAddress != null;

        /// <summary>
        /// Gets and sets the property PhoneNumber. 
        /// <para>
        /// A field to describe values to segment on within phone number.
        /// </para>
        /// </summary>
        public ProfileDimension PhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the PhoneNumber property is set.
        /// </summary>
        internal bool IsSetPhoneNumber() => this.PhoneNumber != null;

        /// <summary>
        /// Gets and sets the property ProfileType. 
        /// <para>
        /// A field to describe values to segment on within profile type.
        /// </para>
        /// </summary>
        public ProfileTypeDimension ProfileType { get; set; }

        /// <summary>
        /// Checks to see if the ProfileType property is set.
        /// </summary>
        internal bool IsSetProfileType() => this.ProfileType != null;

        /// <summary>
        /// Gets and sets the property ShippingAddress. 
        /// <para>
        /// A field to describe values to segment on within shipping address.
        /// </para>
        /// </summary>
        public AddressDimension ShippingAddress { get; set; }

        /// <summary>
        /// Checks to see if the ShippingAddress property is set.
        /// </summary>
        internal bool IsSetShippingAddress() => this.ShippingAddress != null;
    }
}
