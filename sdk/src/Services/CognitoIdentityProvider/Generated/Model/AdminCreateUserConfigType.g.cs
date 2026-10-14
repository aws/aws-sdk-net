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
    /// The settings for administrator creation of users in a user pool. Contains settings
    /// for allowing user sign-up, customizing invitation messages to new users, and the amount
    /// of time before temporary passwords expire.
    /// </summary>
    public partial class AdminCreateUserConfigType
    {
        /// <summary>
        /// Gets and sets the property AllowAdminCreateUserOnly. 
        /// <para>
        /// The setting for allowing self-service sign-up. When <c>true</c>, only administrators
        /// can create new user profiles. When <c>false</c>, users can register themselves and
        /// create a new user profile with the <c>SignUp</c> operation.
        /// </para>
        /// </summary>
        public bool? AllowAdminCreateUserOnly { get; set; }

        /// <summary>
        /// Checks to see if the AllowAdminCreateUserOnly property is set.
        /// </summary>
        internal bool IsSetAllowAdminCreateUserOnly() => this.AllowAdminCreateUserOnly.HasValue;

        /// <summary>
        /// Gets and sets the property InviteMessageTemplate. 
        /// <para>
        /// The template for the welcome message to new users. This template must include the
        /// <c>{####}</c> temporary password placeholder if you are creating users with passwords.
        /// If your users don't have passwords, you can omit the placeholder.
        /// </para>
        ///  
        /// <para>
        /// See also <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-message-customizations.html#cognito-user-pool-settings-user-invitation-message-customization">Customizing
        /// User Invitation Messages</a>.
        /// </para>
        /// </summary>
        public MessageTemplateType InviteMessageTemplate { get; set; }

        /// <summary>
        /// Checks to see if the InviteMessageTemplate property is set.
        /// </summary>
        internal bool IsSetInviteMessageTemplate() => this.InviteMessageTemplate != null;

        /// <summary>
        /// Gets and sets the property UnusedAccountValidityDays. 
        /// <para>
        /// This parameter is no longer in use.
        /// </para>
        ///  
        /// <para>
        /// The password expiration limit in days for administrator-created users. When this time
        /// expires, the user can't sign in with their temporary password. To reset the account
        /// after that time limit, you must call <c>AdminCreateUser</c> again, specifying <c>RESEND</c>
        /// for the <c>MessageAction</c> parameter. 
        /// </para>
        ///  
        /// <para>
        /// The default value for this parameter is 7.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 365)]
        public int? UnusedAccountValidityDays { get; set; }

        /// <summary>
        /// Checks to see if the UnusedAccountValidityDays property is set.
        /// </summary>
        internal bool IsSetUnusedAccountValidityDays() => this.UnusedAccountValidityDays.HasValue;
    }
}
