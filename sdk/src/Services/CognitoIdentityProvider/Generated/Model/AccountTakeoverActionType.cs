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
    /// Account takeover action type.
    /// </summary>
    public partial class AccountTakeoverActionType
    {
        private AccountTakeoverEventActionType _eventAction;
        private bool? _notify;

        /// <summary>
        /// Gets and sets the property EventAction. 
        /// <para>
        /// The event action.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BLOCK</code> Choosing this action will block the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MFA_IF_CONFIGURED</code> Throw MFA challenge if user has configured it, else
        /// allow the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MFA_REQUIRED</code> Throw MFA challenge if user has configured it, else block
        /// the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NO_ACTION</code> Allow the user sign-in.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Flag specifying whether to send a notification.
        /// </para>
        /// </summary>
        public bool Notify
        {
            get { return this._notify.GetValueOrDefault(); }
            set { this._notify = value; }
        }

        // Check to see if Notify property is set
        internal bool IsSetNotify()
        {
            return this._notify.HasValue; 
        }

    }
}