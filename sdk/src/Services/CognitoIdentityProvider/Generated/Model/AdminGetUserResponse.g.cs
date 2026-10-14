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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// This is the response object from the AdminGetUser operation.
    /// </summary>
    public partial class AdminGetUserResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the user is activated for sign-in.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property MFAOptions. 
        /// <para>
        ///  <i>This response parameter is no longer supported.</i> It provides information only
        /// about SMS MFA configurations. It doesn't provide information about time-based one-time
        /// password (TOTP) software token MFA configurations. To look up information about either
        /// type of MFA configuration, use UserMFASettingList instead.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MFAOptionType> MFAOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<MFAOptionType>() : null;

        /// <summary>
        /// Checks to see if the MFAOptions property is set.
        /// </summary>
        internal bool IsSetMFAOptions() => this.MFAOptions != null && (this.MFAOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PreferredMfaSetting. 
        /// <para>
        /// The user's preferred MFA. Users can prefer SMS message, email message, or TOTP MFA.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 131072)]
        public string PreferredMfaSetting { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMfaSetting property is set.
        /// </summary>
        internal bool IsSetPreferredMfaSetting() => this.PreferredMfaSetting != null;

        /// <summary>
        /// Gets and sets the property UserAttributes. 
        /// <para>
        /// An array of name-value pairs of user attributes and their values, for example <c>"email":
        /// "testuser@example.com"</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeType> UserAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<AttributeType>() : null;

        /// <summary>
        /// Checks to see if the UserAttributes property is set.
        /// </summary>
        internal bool IsSetUserAttributes() => this.UserAttributes != null && (this.UserAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserCreateDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? UserCreateDate { get; set; }

        /// <summary>
        /// Checks to see if the UserCreateDate property is set.
        /// </summary>
        internal bool IsSetUserCreateDate() => this.UserCreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property UserLastModifiedDate. 
        /// <para>
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? UserLastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the UserLastModifiedDate property is set.
        /// </summary>
        internal bool IsSetUserLastModifiedDate() => this.UserLastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property UserMFASettingList. 
        /// <para>
        /// The MFA options that are activated for the user. The possible values in this list
        /// are <c>SMS_MFA</c>, <c>EMAIL_OTP</c>, and <c>SOFTWARE_TOKEN_MFA</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserMFASettingList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserMFASettingList property is set.
        /// </summary>
        internal bool IsSetUserMFASettingList() => this.UserMFASettingList != null && (this.UserMFASettingList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserStatus. 
        /// <para>
        /// The user's status. Can be one of the following:
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
        ///  </li> <li> 
        /// <para>
        /// EXTERNAL_PROVIDER - The user signed in with a third-party identity provider.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UserStatusType UserStatus { get; set; }

        /// <summary>
        /// Checks to see if the UserStatus property is set.
        /// </summary>
        internal bool IsSetUserStatus() => this.UserStatus != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username of the user that you requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
