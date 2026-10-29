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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Configuration settings for batching.
    /// </summary>
    public partial class BatchConfig
    {
        /// <summary>
        /// Gets and sets the property BatchAcrossTopics. 
        /// <para>
        /// Whether to allow batching messages from different MQTT topics into a single HTTP request.
        /// By default, only messages from the same topic are batched together. The default value
        /// is <c>false</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When <c>batchAcrossTopics</c> is enabled, the error payload format changes: the <c>topic</c>
        /// field moves from the top level to inside each entry in the <c>payloadsWithMetadata</c>
        /// array, since each message in the batch may originate from a different topic.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Messages are always batched within the scope of the same account, rule name, target
        /// HTTP endpoint URL, and billing group. Messages that differ in any of these attributes
        /// are never combined into the same batch, regardless of the <c>batchAcrossTopics</c>
        /// setting.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? BatchAcrossTopics { get; set; }

        /// <summary>
        /// Checks to see if the BatchAcrossTopics property is set.
        /// </summary>
        internal bool IsSetBatchAcrossTopics() => this.BatchAcrossTopics.HasValue;

        /// <summary>
        /// Gets and sets the property MaxBatchOpenMs. 
        /// <para>
        /// The maximum amount of time (in milliseconds) that an outgoing call waits for other
        /// calls with which it batches messages of the same type. The higher the setting, the
        /// longer the latency of the batched HTTP Action will be.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 200)]
        public int? MaxBatchOpenMs { get; set; }

        /// <summary>
        /// Checks to see if the MaxBatchOpenMs property is set.
        /// </summary>
        internal bool IsSetMaxBatchOpenMs() => this.MaxBatchOpenMs.HasValue;

        /// <summary>
        /// Gets and sets the property MaxBatchSize. 
        /// <para>
        /// The maximum number of messages that are batched together in a single action execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 10)]
        public int? MaxBatchSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxBatchSize property is set.
        /// </summary>
        internal bool IsSetMaxBatchSize() => this.MaxBatchSize.HasValue;

        /// <summary>
        /// Gets and sets the property MaxBatchSizeBytes. 
        /// <para>
        /// Maximum size of a message batch, in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 100, Max = 131072)]
        public int? MaxBatchSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the MaxBatchSizeBytes property is set.
        /// </summary>
        internal bool IsSetMaxBatchSizeBytes() => this.MaxBatchSizeBytes.HasValue;
    }
}
