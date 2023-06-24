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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Represents the response from the server from the request to get the specified user
    /// as an administrator.
    /// </summary>
    public partial class AdminGetUserResponse : AmazonWebServiceResponse
    {
        private bool? _enabled;
        private List<MFAOptionType> _mfaOptions = new List<MFAOptionType>();
        private string _preferredMfaSetting;
        private List<AttributeType> _userAttributes = new List<AttributeType>();
        private DateTime? _userCreateDate;
        private DateTime? _userLastModifiedDate;
        private List<string> _userMFASettingList = new List<string>();
        private string _username;
        private UserStatusType _userStatus;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates that the status is <code>enabled</code>.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MFAOptions. 
        /// <para>
        ///  <i>This response parameter is no longer supported.</i> It provides information only
        /// about SMS MFA configurations. It doesn't provide information about time-based one-time
        /// password (TOTP) software token MFA configurations. To look up information about either
        /// type of MFA configuration, use UserMFASettingList instead.
        /// </para>
        /// </summary>
        public List<MFAOptionType> MFAOptions
        {
            get { return this._mfaOptions; }
            set { this._mfaOptions = value; }
        }

        // Check to see if MFAOptions property is set
        internal bool IsSetMFAOptions()
        {
            return this._mfaOptions != null && this._mfaOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PreferredMfaSetting. 
        /// <para>
        /// The user's preferred MFA setting.
        /// </para>
        /// </summary>
        public string PreferredMfaSetting
        {
            get { return this._preferredMfaSetting; }
            set { this._preferredMfaSetting = value; }
        }

        // Check to see if PreferredMfaSetting property is set
        internal bool IsSetPreferredMfaSetting()
        {
            return this._preferredMfaSetting != null;
        }

        /// <summary>
        /// Gets and sets the property UserAttributes. 
        /// <para>
        /// An array of name-value pairs representing user attributes.
        /// </para>
        /// </summary>
        public List<AttributeType> UserAttributes
        {
            get { return this._userAttributes; }
            set { this._userAttributes = value; }
        }

        // Check to see if UserAttributes property is set
        internal bool IsSetUserAttributes()
        {
            return this._userAttributes != null && this._userAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserCreateDate. 
        /// <para>
        /// The date the user was created.
        /// </para>
        /// </summary>
        public DateTime UserCreateDate
        {
            get { return this._userCreateDate.GetValueOrDefault(); }
            set { this._userCreateDate = value; }
        }

        // Check to see if UserCreateDate property is set
        internal bool IsSetUserCreateDate()
        {
            return this._userCreateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserLastModifiedDate. 
        /// <para>
        /// The date the user was last modified.
        /// </para>
        /// </summary>
        public DateTime UserLastModifiedDate
        {
            get { return this._userLastModifiedDate.GetValueOrDefault(); }
            set { this._userLastModifiedDate = value; }
        }

        // Check to see if UserLastModifiedDate property is set
        internal bool IsSetUserLastModifiedDate()
        {
            return this._userLastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserMFASettingList. 
        /// <para>
        /// The MFA options that are activated for the user. The possible values in this list
        /// are <code>SMS_MFA</code> and <code>SOFTWARE_TOKEN_MFA</code>.
        /// </para>
        /// </summary>
        public List<string> UserMFASettingList
        {
            get { return this._userMFASettingList; }
            set { this._userMFASettingList = value; }
        }

        // Check to see if UserMFASettingList property is set
        internal bool IsSetUserMFASettingList()
        {
            return this._userMFASettingList != null && this._userMFASettingList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name of the user about whom you're receiving information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property UserStatus. 
        /// <para>
        /// The user status. Can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// UNCONFIRMED - User has been created but not confirmed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CONFIRMED - User has been confirmed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARCHIVED - User is no longer active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNKNOWN - User status isn't known.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RESET_REQUIRED - User is confirmed, but the user must request a code and reset their
        /// password before they can sign in.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FORCE_CHANGE_PASSWORD - The user is confirmed and the user can sign in using a temporary
        /// password, but on first sign-in, the user must change their password to a new value
        /// before doing anything else. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UserStatusType UserStatus
        {
            get { return this._userStatus; }
            set { this._userStatus = value; }
        }

        // Check to see if UserStatus property is set
        internal bool IsSetUserStatus()
        {
            return this._userStatus != null;
        }

    }
}