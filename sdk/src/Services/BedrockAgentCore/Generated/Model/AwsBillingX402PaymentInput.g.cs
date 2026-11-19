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
    /// The input for an AWS Billing x402 payment. The payment pays an AWS Marketplace seller's
    /// x402 (HTTP 402) payment requirement and is billed to the AWS account that owns the
    /// payment manager, through the payment manager's AWS Billing payment connector.
    /// </summary>
    public partial class AwsBillingX402PaymentInput
    {
        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Optional settings for the AWS Billing payment.
        /// </para>
        /// </summary>
        public AwsBillingPaymentOptions Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The seller's x402 payment requirement for AWS Billing, passed unchanged as a JSON
        /// object. The service reads the seller-signed quote token from <c>extra.quoteToken</c>
        /// and returns a <c>ValidationException</c> if it is missing or invalid. Any change to
        /// the quote token invalidates its signature.
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
        /// The x402 protocol version of the seller's HTTP 402 response, from its <c>x402Version</c>
        /// field. For example, <c>2</c>.
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
