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
    /// The configuration for creating a new user profile.
    /// </summary>
    public partial class AdminCreateUserConfigType
    {
        private bool? _allowAdminCreateUserOnly;
        private MessageTemplateType _inviteMessageTemplate;
        private int? _unusedAccountValidityDays;

        /// <summary>
        /// Gets and sets the property AllowAdminCreateUserOnly. 
        /// <para>
        /// Set to <c>True</c> if only the administrator is allowed to create user profiles. Set
        /// to <c>False</c> if users can sign themselves up via an app.
        /// </para>
        /// </summary>
        public bool AllowAdminCreateUserOnly
        {
            get { return this._allowAdminCreateUserOnly.GetValueOrDefault(); }
            set { this._allowAdminCreateUserOnly = value; }
        }

        // Check to see if AllowAdminCreateUserOnly property is set
        internal bool IsSetAllowAdminCreateUserOnly()
        {
            return this._allowAdminCreateUserOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InviteMessageTemplate. 
        /// <para>
        /// The message template to be used for the welcome message to new users.
        /// </para>
        ///  
        /// <para>
        /// See also <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-message-customizations.html#cognito-user-pool-settings-user-invitation-message-customization">Customizing
        /// User Invitation Messages</a>.
        /// </para>
        /// </summary>
        public MessageTemplateType InviteMessageTemplate
        {
            get { return this._inviteMessageTemplate; }
            set { this._inviteMessageTemplate = value; }
        }

        // Check to see if InviteMessageTemplate property is set
        internal bool IsSetInviteMessageTemplate()
        {
            return this._inviteMessageTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property UnusedAccountValidityDays. 
        /// <para>
        /// The user account expiration limit, in days, after which a new account that hasn't
        /// signed in is no longer usable. To reset the account after that time limit, you must
        /// call <c>AdminCreateUser</c> again, specifying <c>"RESEND"</c> for the <c>MessageAction</c>
        /// parameter. The default value for this parameter is 7.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set a value for <c>TemporaryPasswordValidityDays</c> in <c>PasswordPolicy</c>,
        /// that value will be used, and <c>UnusedAccountValidityDays</c> will be no longer be
        /// an available parameter for that user pool.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=365)]
        public int UnusedAccountValidityDays
        {
            get { return this._unusedAccountValidityDays.GetValueOrDefault(); }
            set { this._unusedAccountValidityDays = value; }
        }

        // Check to see if UnusedAccountValidityDays property is set
        internal bool IsSetUnusedAccountValidityDays()
        {
            return this._unusedAccountValidityDays.HasValue; 
        }

    }
}