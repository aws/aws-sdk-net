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
    /// Configuration for mitigation actions and notification for different levels of risk
    /// detected for a potential account takeover.
    /// </summary>
    public partial class AccountTakeoverRiskConfigurationType
    {
        private AccountTakeoverActionsType _actions;
        private NotifyConfigurationType _notifyConfiguration;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// Account takeover risk configuration actions
        /// </para>
        /// </summary>
        public AccountTakeoverActionsType Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null;
        }

        /// <summary>
        /// Gets and sets the property NotifyConfiguration. 
        /// <para>
        /// The notify configuration used to construct email notifications.
        /// </para>
        /// </summary>
        public NotifyConfigurationType NotifyConfiguration
        {
            get { return this._notifyConfiguration; }
            set { this._notifyConfiguration = value; }
        }

        // Check to see if NotifyConfiguration property is set
        internal bool IsSetNotifyConfiguration()
        {
            return this._notifyConfiguration != null;
        }

    }
}