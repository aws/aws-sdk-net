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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// A user profile in a Amazon Cognito user pool.
    /// </summary>
    public partial class UserType
    {
        private List<AttributeType> _attributes = AWSConfigs.InitializeCollections ? new List<AttributeType>() : null;
        private bool? _enabled;
        private List<MFAOptionType> _mfaOptions = AWSConfigs.InitializeCollections ? new List<MFAOptionType>() : null;
        private DateTime? _userCreateDate;
        private DateTime? _userLastModifiedDate;
        private string _username;
        private UserStatusType _userStatus;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Names and values of a user's attributes, for example <c>email</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeType> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the user's account is enabled or disabled.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
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
        /// The user's MFA configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MFAOptionType> MFAOptions
        {
            get { return this._mfaOptions; }
            set { this._mfaOptions = value; }
        }

        // Check to see if MFAOptions property is set
        internal bool IsSetMFAOptions()
        {
            return this._mfaOptions != null && (this._mfaOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserCreateDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? UserCreateDate
        {
            get { return this._userCreateDate; }
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
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? UserLastModifiedDate
        {
            get { return this._userLastModifiedDate; }
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
        /// The user's username.
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
        ///  <c>UNCONFIRMED</c>: User has been created but not confirmed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONFIRMED</c>: User has been confirmed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXTERNAL_PROVIDER</c>: User signed in with a third-party IdP.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESET_REQUIRED</c>: User is confirmed, but the user must request a code and reset
        /// their password before they can sign in.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FORCE_CHANGE_PASSWORD</c>: The user is confirmed and the user can sign in using
        /// a temporary password, but on first sign-in, the user must change their password to
        /// a new value before doing anything else. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The statuses <c>ARCHIVED</c>, <c>UNKNOWN</c>, and <c>COMPROMISED</c> are no longer
        /// used.
        /// </para>
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