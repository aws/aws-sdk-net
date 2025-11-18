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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
        private List<int> _isr = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private int? _leader;
        private int? _partition;
        private List<int> _replicas = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Gets and sets the property Isr. 
        /// <para>
        /// The list of in-sync replica broker IDs for the partition.
        /// </para>
        /// </summary>
        public List<int> Isr
        {
            get { return this._isr; }
            set { this._isr = value; }
        }

        // Check to see if Isr property is set
        internal bool IsSetIsr()
        {
            return this._isr != null && (this._isr.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Leader. 
        /// <para>
        /// The leader broker ID for the partition.
        /// </para>
        /// </summary>
        public int Leader
        {
            get { return this._leader.GetValueOrDefault(); }
            set { this._leader = value; }
        }

        // Check to see if Leader property is set
        internal bool IsSetLeader()
        {
            return this._leader.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Partition. 
        /// <para>
        /// The partition ID.
        /// </para>
        /// </summary>
        public int Partition
        {
            get { return this._partition.GetValueOrDefault(); }
            set { this._partition = value; }
        }

        // Check to see if Partition property is set
        internal bool IsSetPartition()
        {
            return this._partition.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Replicas. 
        /// <para>
        /// The list of replica broker IDs for the partition.
        /// </para>
        /// </summary>
        public List<int> Replicas
        {
            get { return this._replicas; }
            set { this._replicas = value; }
        }

        // Check to see if Replicas property is set
        internal bool IsSetReplicas()
        {
            return this._replicas != null && (this._replicas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}