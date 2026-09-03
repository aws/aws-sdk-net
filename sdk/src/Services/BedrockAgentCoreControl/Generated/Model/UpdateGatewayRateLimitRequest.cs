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
    /// Container for the parameters to the UpdateGatewayRateLimit operation.
    /// Updates the entries of a gateway rate limit. The dimension keys are immutable after
    /// creation.
    /// </summary>
    public partial class UpdateGatewayRateLimitRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _description;
        private List<LimitEntry> _entries = AWSConfigs.InitializeCollections ? new List<LimitEntry>() : null;
        private string _gatewayIdentifier;
        private string _rateLimitId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated human-readable description for this rate limit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The updated rule entries. The dimension keys are immutable after creation and cannot
        /// be changed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public List<LimitEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && (this._entries.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property RateLimitId. 
        /// <para>
        /// The unique identifier of the rate limit to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=64)]
        public string RateLimitId
        {
            get { return this._rateLimitId; }
            set { this._rateLimitId = value; }
        }

        // Check to see if RateLimitId property is set
        internal bool IsSetRateLimitId()
        {
            return this._rateLimitId != null;
        }

    }
}