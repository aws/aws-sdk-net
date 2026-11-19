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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// A description of a queue. Returned by <a>CreateQueue</a>, <a>UpdateQueue</a>, and
    /// <a>DescribeQueue</a>.
    /// </summary>
    public partial class QueueDescription
    {
        /// <summary>
        /// Gets and sets the property QueueARN. 
        /// <para>
        /// The ARN of the queue. The resource identifier in the ARN is generated when the queue
        /// is created and is not derived from <c>QueueName</c>. Use the returned <c>QueueARN</c>
        /// to identify the queue in subsequent requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string QueueARN { get; set; }

        /// <summary>
        /// Checks to see if the QueueARN property is set.
        /// </summary>
        internal bool IsSetQueueARN() => this.QueueARN != null;

        /// <summary>
        /// Gets and sets the property QueueAttributes. 
        /// <para>
        /// The configuration attributes of the queue.
        /// </para>
        /// </summary>
        public QueueAttributes QueueAttributes { get; set; }

        /// <summary>
        /// Checks to see if the QueueAttributes property is set.
        /// </summary>
        internal bool IsSetQueueAttributes() => this.QueueAttributes != null;

        /// <summary>
        /// Gets and sets the property QueueCreationTimestamp. 
        /// <para>
        /// The time the queue was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? QueueCreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the QueueCreationTimestamp property is set.
        /// </summary>
        internal bool IsSetQueueCreationTimestamp() => this.QueueCreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property QueueName. 
        /// <para>
        /// The name of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string QueueName { get; set; }

        /// <summary>
        /// Checks to see if the QueueName property is set.
        /// </summary>
        internal bool IsSetQueueName() => this.QueueName != null;

        /// <summary>
        /// Gets and sets the property QueueStatus. 
        /// <para>
        /// The current status of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueueStatus QueueStatus { get; set; }

        /// <summary>
        /// Checks to see if the QueueStatus property is set.
        /// </summary>
        internal bool IsSetQueueStatus() => this.QueueStatus != null;

        /// <summary>
        /// Gets and sets the property StreamConfigurationList. 
        /// <para>
        /// The data stream the queue delivers records from, and the position in that stream where
        /// delivery begins. The list contains exactly one entry, because a queue delivers records
        /// from a single data stream.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10000)]
        public List<QueueStreamConfiguration> StreamConfigurationList { get; set; } = AWSConfigs.InitializeCollections ? new List<QueueStreamConfiguration>() : null;

        /// <summary>
        /// Checks to see if the StreamConfigurationList property is set.
        /// </summary>
        internal bool IsSetStreamConfigurationList() => this.StreamConfigurationList != null && (this.StreamConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
