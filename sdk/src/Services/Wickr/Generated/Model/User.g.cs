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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Represents a user account in a Wickr network with detailed profile information, status,
    /// security settings, and authentication details.
    /// 
    ///  <note> 
    /// <para>
    /// codeValidation, inviteCode and inviteCodeTtl are restricted to networks under preview
    /// only.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class User
    {
        /// <summary>
        /// Gets and sets the property Cell. 
        /// <para>
        /// The phone number minus country code, used for cloud deployments.
        /// </para>
        /// </summary>
        public string Cell { get; set; }

        /// <summary>
        /// Checks to see if the Cell property is set.
        /// </summary>
        internal bool IsSetCell() => this.Cell != null;

        /// <summary>
        /// Gets and sets the property ChallengeFailures. 
        /// <para>
        /// The number of failed password attempts for enterprise deployments, used for account
        /// lockout policies.
        /// </para>
        /// </summary>
        public int? ChallengeFailures { get; set; }

        /// <summary>
        /// Checks to see if the ChallengeFailures property is set.
        /// </summary>
        internal bool IsSetChallengeFailures() => this.ChallengeFailures.HasValue;

        /// <summary>
        /// Gets and sets the property CodeValidation. 
        /// <para>
        /// Indicates whether the user can be verified through a custom invite code.
        /// </para>
        /// </summary>
        public bool? CodeValidation { get; set; }

        /// <summary>
        /// Checks to see if the CodeValidation property is set.
        /// </summary>
        internal bool IsSetCodeValidation() => this.CodeValidation.HasValue;

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The country code for the user's phone number, used for cloud deployments.
        /// </para>
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Checks to see if the CountryCode property is set.
        /// </summary>
        internal bool IsSetCountryCode() => this.CountryCode != null;

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The first name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Checks to see if the FirstName property is set.
        /// </summary>
        internal bool IsSetFirstName() => this.FirstName != null;

        /// <summary>
        /// Gets and sets the property InviteCode. 
        /// <para>
        /// The invitation code for this user, used during registration to join the network.
        /// </para>
        /// </summary>
        public string InviteCode { get; set; }

        /// <summary>
        /// Checks to see if the InviteCode property is set.
        /// </summary>
        internal bool IsSetInviteCode() => this.InviteCode != null;

        /// <summary>
        /// Gets and sets the property IsAdmin. 
        /// <para>
        /// Indicates whether the user has administrator privileges in the network.
        /// </para>
        /// </summary>
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// Checks to see if the IsAdmin property is set.
        /// </summary>
        internal bool IsSetIsAdmin() => this.IsAdmin.HasValue;

        /// <summary>
        /// Gets and sets the property IsInviteExpired. 
        /// <para>
        /// Indicates whether the user's email invitation code has expired, applicable to cloud
        /// deployments.
        /// </para>
        /// </summary>
        public bool? IsInviteExpired { get; set; }

        /// <summary>
        /// Checks to see if the IsInviteExpired property is set.
        /// </summary>
        internal bool IsSetIsInviteExpired() => this.IsInviteExpired.HasValue;

        /// <summary>
        /// Gets and sets the property IsUser. 
        /// <para>
        /// Indicates whether this account is a user (as opposed to a bot or other account type).
        /// </para>
        /// </summary>
        public bool? IsUser { get; set; }

        /// <summary>
        /// Checks to see if the IsUser property is set.
        /// </summary>
        internal bool IsSetIsUser() => this.IsUser.HasValue;

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Checks to see if the LastName property is set.
        /// </summary>
        internal bool IsSetLastName() => this.LastName != null;

        /// <summary>
        /// Gets and sets the property OtpEnabled. 
        /// <para>
        /// Indicates whether one-time password (OTP) authentication is enabled for the user.
        /// </para>
        /// </summary>
        public bool? OtpEnabled { get; set; }

        /// <summary>
        /// Checks to see if the OtpEnabled property is set.
        /// </summary>
        internal bool IsSetOtpEnabled() => this.OtpEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ScimId. 
        /// <para>
        /// The SCIM (System for Cross-domain Identity Management) identifier for the user, used
        /// for identity synchronization. Currently not used.
        /// </para>
        /// </summary>
        public string ScimId { get; set; }

        /// <summary>
        /// Checks to see if the ScimId property is set.
        /// </summary>
        internal bool IsSetScimId() => this.ScimId != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// A list of security group IDs to which the user is assigned, determining their permissions
        /// and feature access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the user (1 for pending invitation, 2 for active).
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;

        /// <summary>
        /// Gets and sets the property Suspended. 
        /// <para>
        /// Indicates whether the user is currently suspended and unable to access the network.
        /// </para>
        /// </summary>
        public bool? Suspended { get; set; }

        /// <summary>
        /// Checks to see if the Suspended property is set.
        /// </summary>
        internal bool IsSetSuspended() => this.Suspended.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The descriptive type of the user account (e.g., 'user').
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Uname. 
        /// <para>
        /// The unique identifier for the user.
        /// </para>
        /// </summary>
        public string Uname { get; set; }

        /// <summary>
        /// Checks to see if the Uname property is set.
        /// </summary>
        internal bool IsSetUname() => this.Uname != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique identifier for the user within the network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The email address or username of the user. For bots, this must end in 'bot'.
        /// </para>
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
