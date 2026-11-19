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
    /// The SSO session settings for a user pool app client.
    /// </summary>
    public partial class ClientSSOSessionConfigType
    {
        /// <summary>
        /// Gets and sets the property MaxValidityMinutes. 
        /// <para>
        /// The maximum amount of time, in minutes, that this app client silently reuses an existing
        /// SSO session, returning a new set of tokens without requiring the user to re-authenticate,
        /// measured from the user's last fresh authentication. The minimum value is <c>0</c>
        /// and the maximum value is <c>129600</c> (90 days). The default is <c>60</c>. A value
        /// of <c>0</c> means that this app client never silently reuses the SSO session and always
        /// re-authenticates the user. The SSO session record and its cookie are still created
        /// regardless of this value, and other app clients in the same user pool can still reuse
        /// the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 129600)]
        public int? MaxValidityMinutes { get; set; }

        /// <summary>
        /// Checks to see if the MaxValidityMinutes property is set.
        /// </summary>
        internal bool IsSetMaxValidityMinutes() => this.MaxValidityMinutes.HasValue;
    }
}
