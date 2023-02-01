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
    /// A user profile in a Amazon Cognito user pool.
    /// </summary>
    public partial class UserType
    {
        private List<AttributeType> _attributes = new List<AttributeType>();
        private bool? _enabled;
        private List<MFAOptionType> _mfaOptions = new List<MFAOptionType>();
        private DateTime? _userCreateDate;
        private DateTime? _userLastModifiedDate;
        private string _username;
        private UserStatusType _userStatus;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A container with information about the user type attributes.
        /// </para>
        /// </summary>
        public List<AttributeType> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the user is enabled.
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
        /// The MFA options for the user.
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
        /// Gets and sets the property UserCreateDate. 
        /// <para>
        /// The creation date of the user.
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
        /// The last modified date of the user.
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
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name of the user you want to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// The user status. This can be one of the following:
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
        /// EXTERNAL_PROVIDER - User signed in with a third-party IdP.
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