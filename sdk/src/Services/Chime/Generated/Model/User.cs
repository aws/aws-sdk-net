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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The user on the Amazon Chime account.
    /// </summary>
    public partial class User
    {
        private string _accountId;
        private AlexaForBusinessMetadata _alexaForBusinessMetadata;
        private string _displayName;
        private DateTime? _invitedOn;
        private License _licenseType;
        private string _personalPIN;
        private string _primaryEmail;
        private string _primaryProvisionedNumber;
        private DateTime? _registeredOn;
        private string _userId;
        private InviteStatus _userInvitationStatus;
        private RegistrationStatus _userRegistrationStatus;
        private UserType _userType;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Chime account ID.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AlexaForBusinessMetadata. 
        /// <para>
        /// The Alexa for Business metadata.
        /// </para>
        /// </summary>
        public AlexaForBusinessMetadata AlexaForBusinessMetadata
        {
            get { return this._alexaForBusinessMetadata; }
            set { this._alexaForBusinessMetadata = value; }
        }

        // Check to see if AlexaForBusinessMetadata property is set
        internal bool IsSetAlexaForBusinessMetadata()
        {
            return this._alexaForBusinessMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property InvitedOn. 
        /// <para>
        /// Date and time when the user is invited to the Amazon Chime account, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime InvitedOn
        {
            get { return this._invitedOn.GetValueOrDefault(); }
            set { this._invitedOn = value; }
        }

        // Check to see if InvitedOn property is set
        internal bool IsSetInvitedOn()
        {
            return this._invitedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// The license type for the user.
        /// </para>
        /// </summary>
        public License LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }

        // Check to see if LicenseType property is set
        internal bool IsSetLicenseType()
        {
            return this._licenseType != null;
        }

        /// <summary>
        /// Gets and sets the property PersonalPIN. 
        /// <para>
        /// The user's personal meeting PIN.
        /// </para>
        /// </summary>
        public string PersonalPIN
        {
            get { return this._personalPIN; }
            set { this._personalPIN = value; }
        }

        // Check to see if PersonalPIN property is set
        internal bool IsSetPersonalPIN()
        {
            return this._personalPIN != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryEmail. 
        /// <para>
        /// The primary email address of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PrimaryEmail
        {
            get { return this._primaryEmail; }
            set { this._primaryEmail = value; }
        }

        // Check to see if PrimaryEmail property is set
        internal bool IsSetPrimaryEmail()
        {
            return this._primaryEmail != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryProvisionedNumber. 
        /// <para>
        /// The primary phone number associated with the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PrimaryProvisionedNumber
        {
            get { return this._primaryProvisionedNumber; }
            set { this._primaryProvisionedNumber = value; }
        }

        // Check to see if PrimaryProvisionedNumber property is set
        internal bool IsSetPrimaryProvisionedNumber()
        {
            return this._primaryProvisionedNumber != null;
        }

        /// <summary>
        /// Gets and sets the property RegisteredOn. 
        /// <para>
        /// Date and time when the user is registered, in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime RegisteredOn
        {
            get { return this._registeredOn.GetValueOrDefault(); }
            set { this._registeredOn = value; }
        }

        // Check to see if RegisteredOn property is set
        internal bool IsSetRegisteredOn()
        {
            return this._registeredOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property UserInvitationStatus. 
        /// <para>
        /// The user invite status.
        /// </para>
        /// </summary>
        public InviteStatus UserInvitationStatus
        {
            get { return this._userInvitationStatus; }
            set { this._userInvitationStatus = value; }
        }

        // Check to see if UserInvitationStatus property is set
        internal bool IsSetUserInvitationStatus()
        {
            return this._userInvitationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UserRegistrationStatus. 
        /// <para>
        /// The user registration status.
        /// </para>
        /// </summary>
        public RegistrationStatus UserRegistrationStatus
        {
            get { return this._userRegistrationStatus; }
            set { this._userRegistrationStatus = value; }
        }

        // Check to see if UserRegistrationStatus property is set
        internal bool IsSetUserRegistrationStatus()
        {
            return this._userRegistrationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UserType. 
        /// <para>
        /// The user type.
        /// </para>
        /// </summary>
        public UserType UserType
        {
            get { return this._userType; }
            set { this._userType = value; }
        }

        // Check to see if UserType property is set
        internal bool IsSetUserType()
        {
            return this._userType != null;
        }

    }
}