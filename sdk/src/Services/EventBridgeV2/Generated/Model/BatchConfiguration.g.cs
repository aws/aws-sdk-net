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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Batching configuration for a subscriber.
    /// </summary>
    public partial class BatchConfiguration
    {
        /// <summary>
        /// Gets and sets the property MaxBatchSize. The maximum number of events to include in
        /// a single batch delivered to the target. The service delivers up to this many events
        /// per batch; fewer may be delivered when the batch window elapses or the target's per-batch
        /// limit is smaller. This is a maximum, not a guaranteed count. Valid range is 1-500
        /// (default: 10, or the target API's per-batch maximum). The resolved value applied by
        /// the service is returned on read.
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxBatchSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxBatchSize property is set.
        /// </summary>
        internal bool IsSetMaxBatchSize() => this.MaxBatchSize.HasValue;

        /// <summary>
        /// Gets and sets the property MaxBatchWindowInSeconds. The maximum time in seconds to
        /// wait for a batch to fill before delivering it to the target. This is a maximum; a
        /// batch may be delivered sooner if it reaches MaxBatchSize or another delivery condition
        /// is met. Valid range is 0-300 (default: 0, meaning no wait). The resolved value applied
        /// by the service is always returned on read.
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public int? MaxBatchWindowInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the MaxBatchWindowInSeconds property is set.
        /// </summary>
        internal bool IsSetMaxBatchWindowInSeconds() => this.MaxBatchWindowInSeconds.HasValue;
    }
}
