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
    /// A user profile in a Amazon Cognito user pool.
    /// </summary>
    public partial class UserType
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Names and values of a user's attributes, for example <c>email</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttributeType> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new List<AttributeType>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the user's account is enabled or disabled.
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
        /// The user's MFA configuration.
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
        public UserStatusType UserStatus { get; set; }

        /// <summary>
        /// Checks to see if the UserStatus property is set.
        /// </summary>
        internal bool IsSetUserStatus() => this.UserStatus != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user's username.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
