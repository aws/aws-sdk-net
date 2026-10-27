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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the GetGatewayRateLimit operation. Retrieves information
    /// about a gateway rate limit.
    /// </summary>
    public partial class GetGatewayRateLimitRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property GatewayIdentifier. 
        /// <para>
        /// The unique identifier of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GatewayIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GatewayIdentifier property is set.
        /// </summary>
        internal bool IsSetGatewayIdentifier() => this.GatewayIdentifier != null;

        /// <summary>
        /// Gets and sets the property RateLimitId. 
        /// <para>
        /// The unique identifier of the rate limit to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 64)]
        public string RateLimitId { get; set; }

        /// <summary>
        /// Checks to see if the RateLimitId property is set.
        /// </summary>
        internal bool IsSetRateLimitId() => this.RateLimitId != null;
    }
}
