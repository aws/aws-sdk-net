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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// The provider sends HTTP Basic authentication credentials: an Authorization header
    /// with the value "Basic " followed by the Base64 encoding of username:password. Supply
    /// both Username and Password, or omit both so that EventBridge generates the pair. Supplying
    /// only one fails with InvalidInputException. EventBridge stores both only in AWS Secrets
    /// Manager and never returns them, including from DescribeEventSource.
    /// </summary>
    public partial class WebhookBasicHttpAuthConfiguration
    {
        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 6, Max = 512)]
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if the Password property is set.
        /// </summary>
        internal bool IsSetPassword() => this.Password != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
