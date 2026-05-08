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
    /// A weighted configuration bundle override that splits traffic between multiple bundle
    /// versions.
    /// </summary>
    public partial class WeightedOverride
    {
        private List<TrafficSplitEntry> _trafficSplit = AWSConfigs.InitializeCollections ? new List<TrafficSplitEntry>() : null;

        /// <summary>
        /// Gets and sets the property TrafficSplit. 
        /// <para>
        /// The traffic split entries defining how traffic is distributed between configuration
        /// bundle versions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public List<TrafficSplitEntry> TrafficSplit
        {
            get { return this._trafficSplit; }
            set { this._trafficSplit = value; }
        }

        // Check to see if TrafficSplit property is set
        internal bool IsSetTrafficSplit()
        {
            return this._trafficSplit != null && (this._trafficSplit.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}