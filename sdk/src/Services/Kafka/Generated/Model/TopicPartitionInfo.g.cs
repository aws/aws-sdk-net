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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Contains information about a topic partition.
    /// </summary>
    public partial class TopicPartitionInfo
    {
        /// <summary>
        /// Gets and sets the property Isr. 
        /// <para>
        /// The list of in-sync replica broker IDs for the partition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Isr { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Isr property is set.
        /// </summary>
        internal bool IsSetIsr() => this.Isr != null && (this.Isr.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Leader. 
        /// <para>
        /// The leader broker ID for the partition.
        /// </para>
        /// </summary>
        public int? Leader { get; set; }

        /// <summary>
        /// Checks to see if the Leader property is set.
        /// </summary>
        internal bool IsSetLeader() => this.Leader.HasValue;

        /// <summary>
        /// Gets and sets the property Partition. 
        /// <para>
        /// The partition ID.
        /// </para>
        /// </summary>
        public int? Partition { get; set; }

        /// <summary>
        /// Checks to see if the Partition property is set.
        /// </summary>
        internal bool IsSetPartition() => this.Partition.HasValue;

        /// <summary>
        /// Gets and sets the property Replicas. 
        /// <para>
        /// The list of replica broker IDs for the partition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Replicas { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Replicas property is set.
        /// </summary>
        internal bool IsSetReplicas() => this.Replicas != null && (this.Replicas.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
