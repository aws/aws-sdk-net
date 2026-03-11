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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
        private string _cell;
        private int? _challengeFailures;
        private bool? _codeValidation;
        private string _countryCode;
        private string _firstName;
        private string _inviteCode;
        private bool? _isAdmin;
        private bool? _isInviteExpired;
        private bool? _isUser;
        private string _lastName;
        private bool? _otpEnabled;
        private string _scimId;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _status;
        private bool? _suspended;
        private string _type;
        private string _uname;
        private string _userId;
        private string _username;

        /// <summary>
        /// Gets and sets the property Cell. 
        /// <para>
        /// The phone number minus country code, used for cloud deployments.
        /// </para>
        /// </summary>
        public string Cell
        {
            get { return this._cell; }
            set { this._cell = value; }
        }

        // Check to see if Cell property is set
        internal bool IsSetCell()
        {
            return this._cell != null;
        }

        /// <summary>
        /// Gets and sets the property ChallengeFailures. 
        /// <para>
        /// The number of failed password attempts for enterprise deployments, used for account
        /// lockout policies.
        /// </para>
        /// </summary>
        public int? ChallengeFailures
        {
            get { return this._challengeFailures; }
            set { this._challengeFailures = value; }
        }

        // Check to see if ChallengeFailures property is set
        internal bool IsSetChallengeFailures()
        {
            return this._challengeFailures.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CodeValidation. 
        /// <para>
        /// Indicates whether the user can be verified through a custom invite code.
        /// </para>
        /// </summary>
        public bool? CodeValidation
        {
            get { return this._codeValidation; }
            set { this._codeValidation = value; }
        }

        // Check to see if CodeValidation property is set
        internal bool IsSetCodeValidation()
        {
            return this._codeValidation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The country code for the user's phone number, used for cloud deployments.
        /// </para>
        /// </summary>
        public string CountryCode
        {
            get { return this._countryCode; }
            set { this._countryCode = value; }
        }

        // Check to see if CountryCode property is set
        internal bool IsSetCountryCode()
        {
            return this._countryCode != null;
        }

        /// <summary>
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The first name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property InviteCode. 
        /// <para>
        /// The invitation code for this user, used during registration to join the network.
        /// </para>
        /// </summary>
        public string InviteCode
        {
            get { return this._inviteCode; }
            set { this._inviteCode = value; }
        }

        // Check to see if InviteCode property is set
        internal bool IsSetInviteCode()
        {
            return this._inviteCode != null;
        }

        /// <summary>
        /// Gets and sets the property IsAdmin. 
        /// <para>
        /// Indicates whether the user has administrator privileges in the network.
        /// </para>
        /// </summary>
        public bool? IsAdmin
        {
            get { return this._isAdmin; }
            set { this._isAdmin = value; }
        }

        // Check to see if IsAdmin property is set
        internal bool IsSetIsAdmin()
        {
            return this._isAdmin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsInviteExpired. 
        /// <para>
        /// Indicates whether the user's email invitation code has expired, applicable to cloud
        /// deployments.
        /// </para>
        /// </summary>
        public bool? IsInviteExpired
        {
            get { return this._isInviteExpired; }
            set { this._isInviteExpired = value; }
        }

        // Check to see if IsInviteExpired property is set
        internal bool IsSetIsInviteExpired()
        {
            return this._isInviteExpired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsUser. 
        /// <para>
        /// Indicates whether this account is a user (as opposed to a bot or other account type).
        /// </para>
        /// </summary>
        public bool? IsUser
        {
            get { return this._isUser; }
            set { this._isUser = value; }
        }

        // Check to see if IsUser property is set
        internal bool IsSetIsUser()
        {
            return this._isUser.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property OtpEnabled. 
        /// <para>
        /// Indicates whether one-time password (OTP) authentication is enabled for the user.
        /// </para>
        /// </summary>
        public bool? OtpEnabled
        {
            get { return this._otpEnabled; }
            set { this._otpEnabled = value; }
        }

        // Check to see if OtpEnabled property is set
        internal bool IsSetOtpEnabled()
        {
            return this._otpEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScimId. 
        /// <para>
        /// The SCIM (System for Cross-domain Identity Management) identifier for the user, used
        /// for identity synchronization. Currently not used.
        /// </para>
        /// </summary>
        public string ScimId
        {
            get { return this._scimId; }
            set { this._scimId = value; }
        }

        // Check to see if ScimId property is set
        internal bool IsSetScimId()
        {
            return this._scimId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// A list of security group IDs to which the user is assigned, determining their permissions
        /// and feature access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the user (1 for pending invitation, 2 for active).
        /// </para>
        /// </summary>
        public int? Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Suspended. 
        /// <para>
        /// Indicates whether the user is currently suspended and unable to access the network.
        /// </para>
        /// </summary>
        public bool? Suspended
        {
            get { return this._suspended; }
            set { this._suspended = value; }
        }

        // Check to see if Suspended property is set
        internal bool IsSetSuspended()
        {
            return this._suspended.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The descriptive type of the user account (e.g., 'user').
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Uname. 
        /// <para>
        /// The unique identifier for the user.
        /// </para>
        /// </summary>
        public string Uname
        {
            get { return this._uname; }
            set { this._uname = value; }
        }

        // Check to see if Uname property is set
        internal bool IsSetUname()
        {
            return this._uname != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique identifier for the user within the network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The email address or username of the user. For bots, this must end in 'bot'.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}