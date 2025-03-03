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
    /// Settings for user pool actions when Amazon Cognito detects compromised credentials
    /// with threat protection in full-function <c>ENFORCED</c> mode.
    /// </summary>
    public partial class CompromisedCredentialsActionsType
    {
        private CompromisedCredentialsEventActionType _eventAction;

        /// <summary>
        /// Gets and sets the property EventAction. 
        /// <para>
        /// The action that Amazon Cognito takes when it detects compromised credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CompromisedCredentialsEventActionType EventAction
        {
            get { return this._eventAction; }
            set { this._eventAction = value; }
        }

        // Check to see if EventAction property is set
        internal bool IsSetEventAction()
        {
            return this._eventAction != null;
        }

    }
}