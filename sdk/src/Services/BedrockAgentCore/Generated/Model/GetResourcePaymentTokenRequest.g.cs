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
    /// Container for the parameters to the GetResourcePaymentToken operation. Generates authentication
    /// tokens for payment providers that use vendor-specific authentication mechanisms.
    /// </summary>
    public partial class GetResourcePaymentTokenRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property PaymentTokenRequest. 
        /// <para>
        /// Vendor-specific token request input. Contains all request parameters in a type-safe,
        /// vendor-specific structure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PaymentTokenRequestInput PaymentTokenRequest { get; set; }

        /// <summary>
        /// Checks to see if the PaymentTokenRequest property is set.
        /// </summary>
        internal bool IsSetPaymentTokenRequest() => this.PaymentTokenRequest != null;

        /// <summary>
        /// Gets and sets the property ResourceCredentialProviderName. 
        /// <para>
        /// Name of the payment credential provider to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ResourceCredentialProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceCredentialProviderName property is set.
        /// </summary>
        internal bool IsSetResourceCredentialProviderName() => this.ResourceCredentialProviderName != null;

        /// <summary>
        /// Gets and sets the property WorkloadIdentityToken. 
        /// <para>
        /// Workload access token for authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 131072)]
        public string WorkloadIdentityToken { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadIdentityToken property is set.
        /// </summary>
        internal bool IsSetWorkloadIdentityToken() => this.WorkloadIdentityToken != null;
    }
}
