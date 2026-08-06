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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
    /// This is the response object from the BatchPutGatewayRateLimits operation.
    /// </summary>
    public partial class BatchPutGatewayRateLimitsResponse : AmazonWebServiceResponse
    {
        private List<GatewayRateLimitDetail> _rateLimits = AWSConfigs.InitializeCollections ? new List<GatewayRateLimitDetail>() : null;

        /// <summary>
        /// Gets and sets the property RateLimits. 
        /// <para>
        /// The resulting set of rate limits after the batch operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GatewayRateLimitDetail> RateLimits
        {
            get { return this._rateLimits; }
            set { this._rateLimits = value; }
        }

        // Check to see if RateLimits property is set
        internal bool IsSetRateLimits()
        {
            return this._rateLimits != null && (this._rateLimits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}