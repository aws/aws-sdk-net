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
    /// The output of an AWS Billing x402 payment.
    /// </summary>
    public partial class AwsBillingX402PaymentOutput
    {
        /// <summary>
        /// Gets and sets the property PaymentToken. 
        /// <para>
        /// The payment token, a signed JSON Web Token (JWT). Include it when you retry your request
        /// to the seller. Treat the payment token as a credential: don't log or share it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 65536)]
        public string PaymentToken { get; set; }

        /// <summary>
        /// Checks to see if the PaymentToken property is set.
        /// </summary>
        internal bool IsSetPaymentToken() => this.PaymentToken != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The x402 protocol version. This is the same value as the <c>version</c> in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
