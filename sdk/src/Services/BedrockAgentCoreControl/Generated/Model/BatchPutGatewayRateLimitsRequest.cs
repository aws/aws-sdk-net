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
    /// Container for the parameters to the BatchPutGatewayRateLimits operation.
    /// Atomically creates or updates multiple rate limits for a gateway. The operation updates
    /// existing limits with matching keys and creates new limits for new keys. If the operation
    /// fails, the service applies no changes. Retry the request after resolving the issue.
    /// </summary>
    public partial class BatchPutGatewayRateLimitsRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _clientToken;
        private string _gatewayIdentifier;
        private List<BatchPutLimitEntry> _rateLimits = AWSConfigs.InitializeCollections ? new List<BatchPutLimitEntry>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If you don't specify this field, a value is randomly generated for
        /// you. If this token matches a previous request, the service ignores the request, but
        /// doesn't return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayIdentifier. 
        /// <para>
        /// The unique identifier of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayIdentifier
        {
            get { return this._gatewayIdentifier; }
            set { this._gatewayIdentifier = value; }
        }

        // Check to see if GatewayIdentifier property is set
        internal bool IsSetGatewayIdentifier()
        {
            return this._gatewayIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RateLimits. 
        /// <para>
        /// The complete set of rate limits for this gateway. This operation replaces all existing
        /// rate limits in a single request. If the operation fails, no rate limits are changed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<BatchPutLimitEntry> RateLimits
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