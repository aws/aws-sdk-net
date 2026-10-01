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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The user on the Amazon Chime account.
    /// </summary>
    public partial class User
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Chime account ID.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AlexaForBusinessMetadata. 
        /// <para>
        /// The Alexa for Business metadata.
        /// </para>
        /// </summary>
        public AlexaForBusinessMetadata AlexaForBusinessMetadata { get; set; }

        /// <summary>
        /// Checks to see if the AlexaForBusinessMetadata property is set.
        /// </summary>
        internal bool IsSetAlexaForBusinessMetadata() => this.AlexaForBusinessMetadata != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property InvitedOn. 
        /// <para>
        /// Date and time when the user is invited to the Amazon Chime account, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? InvitedOn { get; set; }

        /// <summary>
        /// Checks to see if the InvitedOn property is set.
        /// </summary>
        internal bool IsSetInvitedOn() => this.InvitedOn.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// The license type for the user.
        /// </para>
        /// </summary>
        public License LicenseType { get; set; }

        /// <summary>
        /// Checks to see if the LicenseType property is set.
        /// </summary>
        internal bool IsSetLicenseType() => this.LicenseType != null;

        /// <summary>
        /// Gets and sets the property PersonalPIN. 
        /// <para>
        /// The user's personal meeting PIN.
        /// </para>
        /// </summary>
        public string PersonalPIN { get; set; }

        /// <summary>
        /// Checks to see if the PersonalPIN property is set.
        /// </summary>
        internal bool IsSetPersonalPIN() => this.PersonalPIN != null;

        /// <summary>
        /// Gets and sets the property PrimaryEmail. 
        /// <para>
        /// The primary email address of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PrimaryEmail { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryEmail property is set.
        /// </summary>
        internal bool IsSetPrimaryEmail() => this.PrimaryEmail != null;

        /// <summary>
        /// Gets and sets the property PrimaryProvisionedNumber. 
        /// <para>
        /// The primary phone number associated with the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PrimaryProvisionedNumber { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryProvisionedNumber property is set.
        /// </summary>
        internal bool IsSetPrimaryProvisionedNumber() => this.PrimaryProvisionedNumber != null;

        /// <summary>
        /// Gets and sets the property RegisteredOn. 
        /// <para>
        /// Date and time when the user is registered, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? RegisteredOn { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredOn property is set.
        /// </summary>
        internal bool IsSetRegisteredOn() => this.RegisteredOn.HasValue;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property UserInvitationStatus. 
        /// <para>
        /// The user invite status.
        /// </para>
        /// </summary>
        public InviteStatus UserInvitationStatus { get; set; }

        /// <summary>
        /// Checks to see if the UserInvitationStatus property is set.
        /// </summary>
        internal bool IsSetUserInvitationStatus() => this.UserInvitationStatus != null;

        /// <summary>
        /// Gets and sets the property UserRegistrationStatus. 
        /// <para>
        /// The user registration status.
        /// </para>
        /// </summary>
        public RegistrationStatus UserRegistrationStatus { get; set; }

        /// <summary>
        /// Checks to see if the UserRegistrationStatus property is set.
        /// </summary>
        internal bool IsSetUserRegistrationStatus() => this.UserRegistrationStatus != null;

        /// <summary>
        /// Gets and sets the property UserType. 
        /// <para>
        /// The user type.
        /// </para>
        /// </summary>
        public UserType UserType { get; set; }

        /// <summary>
        /// Checks to see if the UserType property is set.
        /// </summary>
        internal bool IsSetUserType() => this.UserType != null;
    }
}
