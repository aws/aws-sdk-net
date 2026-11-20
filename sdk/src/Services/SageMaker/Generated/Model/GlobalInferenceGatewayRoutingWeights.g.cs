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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The relative weights of the four routing signals, each from 0 to 1. Specify all four
    /// weights or none. If you specify them, they must sum to 1.0, within 0.001. If you specify
    /// none, the global inference gateway uses default weights.
    /// </summary>
    public partial class GlobalInferenceGatewayRoutingWeights
    {
        /// <summary>
        /// Gets and sets the property ErrorRate. 
        /// <para>
        /// The weight of the recent error rate of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public float? ErrorRate { get; set; }

        /// <summary>
        /// Checks to see if the ErrorRate property is set.
        /// </summary>
        internal bool IsSetErrorRate() => this.ErrorRate.HasValue;

        /// <summary>
        /// Gets and sets the property KVHeadroom. 
        /// <para>
        /// The weight of the free key-value (KV) cache capacity on the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public float? KVHeadroom { get; set; }

        /// <summary>
        /// Checks to see if the KVHeadroom property is set.
        /// </summary>
        internal bool IsSetKVHeadroom() => this.KVHeadroom.HasValue;

        /// <summary>
        /// Gets and sets the property QueueDepth. 
        /// <para>
        /// The weight of the number of requests that are waiting on the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public float? QueueDepth { get; set; }

        /// <summary>
        /// Checks to see if the QueueDepth property is set.
        /// </summary>
        internal bool IsSetQueueDepth() => this.QueueDepth.HasValue;

        /// <summary>
        /// Gets and sets the property RegionProximity. 
        /// <para>
        /// The weight of how close the cluster is to the caller.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public float? RegionProximity { get; set; }

        /// <summary>
        /// Checks to see if the RegionProximity property is set.
        /// </summary>
        internal bool IsSetRegionProximity() => this.RegionProximity.HasValue;
    }
}
