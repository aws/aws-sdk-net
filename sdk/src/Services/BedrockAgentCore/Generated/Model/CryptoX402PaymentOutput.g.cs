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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The output from a crypto X402 payment.
    /// </summary>
    public partial class CryptoX402PaymentOutput
    {
        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The X402 payment response payload.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public Amazon.Runtime.Documents.Document Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => !this.Payload.IsNull();

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the X402 protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
