/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The type of configuration for creating a new user profile.
    /// </summary>
    public partial class AdminCreateUserConfigType
    {
        private bool? _allowAdminCreateUserOnly;
        private MessageTemplateType _inviteMessageTemplate;
        private int? _unusedAccountValidityDays;

        /// <summary>
        /// Gets and sets the property AllowAdminCreateUserOnly. 
        /// <para>
        /// Set to <code>True</code> if only the administrator is allowed to create user profiles.
        /// Set to <code>False</code> if users can sign themselves up via an app.
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
        /// The user account expiration limit, in days, after which the account is no longer usable.
        /// To reset the account after that time limit, you must call <code>AdminCreateUser</code>
        /// again, specifying <code>"RESEND"</code> for the <code>MessageAction</code> parameter.
        /// The default value for this parameter is 7.
        /// </para>
        /// </summary>
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