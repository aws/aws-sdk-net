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
    /// The automated response to a risk level for adaptive authentication in full-function,
    /// or <c>ENFORCED</c>, mode. You can assign an action to each risk level that threat
    /// protection evaluates.
    /// </summary>
    public partial class AccountTakeoverActionType
    {
        private AccountTakeoverEventActionType _eventAction;
        private bool? _notify;

        /// <summary>
        /// Gets and sets the property EventAction. 
        /// <para>
        /// The action to take for the attempted account takeover action for the associated risk
        /// level. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BLOCK</c>: Block the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MFA_IF_CONFIGURED</c>: Present an MFA challenge if possible. MFA is possible if
        /// the user pool has active MFA methods that the user can set up. For example, if the
        /// user pool only supports SMS message MFA but the user doesn't have a phone number attribute,
        /// MFA setup isn't possible. If MFA setup isn't possible, allow the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MFA_REQUIRED</c>: Present an MFA challenge if possible. Block the request if a
        /// user hasn't set up MFA. To sign in with required MFA, users must have an email address
        /// or phone number attribute, or a registered TOTP factor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_ACTION</c>: Take no action. Permit sign-in.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccountTakeoverEventActionType EventAction
        {
            get { return this._eventAction; }
            set { this._eventAction = value; }
        }

        // Check to see if EventAction property is set
        internal bool IsSetEventAction()
        {
            return this._eventAction != null;
        }

        /// <summary>
        /// Gets and sets the property Notify. 
        /// <para>
        /// Determines whether Amazon Cognito sends a user a notification message when your user
        /// pools assesses a user's session at the associated risk level.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Notify
        {
            get { return this._notify; }
            set { this._notify = value; }
        }

        // Check to see if Notify property is set
        internal bool IsSetNotify()
        {
            return this._notify.HasValue; 
        }

    }
}