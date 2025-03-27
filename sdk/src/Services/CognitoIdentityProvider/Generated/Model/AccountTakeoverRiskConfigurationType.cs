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
    /// The settings for automated responses and notification templates for adaptive authentication
    /// with threat protection features.
    /// </summary>
    public partial class AccountTakeoverRiskConfigurationType
    {
        private AccountTakeoverActionsType _actions;
        private NotifyConfigurationType _notifyConfiguration;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of account-takeover actions for each level of risk that Amazon Cognito might
        /// assess with threat protection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The settings for composing and sending an email message when threat protection assesses
        /// a risk level with adaptive authentication. When you choose to notify users in <c>AccountTakeoverRiskConfiguration</c>,
        /// Amazon Cognito sends an email message using the method and template that you set with
        /// this data type.
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