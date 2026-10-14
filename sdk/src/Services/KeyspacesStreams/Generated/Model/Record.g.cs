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

namespace Amazon.KeyspacesStreams.Model
{
    /// <summary>
    /// Represents a change data capture record for a row in an Amazon Keyspaces table, containing
    /// both the new and old states of the row.
    /// </summary>
    public partial class Record
    {
        /// <summary>
        /// Gets and sets the property ClusteringKeys. 
        /// <para>
        /// The clustering key columns and their values for the affected row, which determine
        /// the order of rows within a partition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, KeyspacesCellValue> ClusteringKeys { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, KeyspacesCellValue>() : null;

        /// <summary>
        /// Checks to see if the ClusteringKeys property is set.
        /// </summary>
        internal bool IsSetClusteringKeys() => this.ClusteringKeys != null && (this.ClusteringKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp indicating when this change data capture record was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EventVersion. 
        /// <para>
        /// The version of the record format, used to track the evolution of the record structure
        /// over time.
        /// </para>
        /// </summary>
        public string EventVersion { get; set; }

        /// <summary>
        /// Checks to see if the EventVersion property is set.
        /// </summary>
        internal bool IsSetEventVersion() => this.EventVersion != null;

        /// <summary>
        /// Gets and sets the property NewImage. 
        /// <para>
        /// The state of the row after the change operation that generated this record.
        /// </para>
        /// </summary>
        public KeyspacesRow NewImage { get; set; }

        /// <summary>
        /// Checks to see if the NewImage property is set.
        /// </summary>
        internal bool IsSetNewImage() => this.NewImage != null;

        /// <summary>
        /// Gets and sets the property OldImage. 
        /// <para>
        /// The state of the row before the change operation that generated this record.
        /// </para>
        /// </summary>
        public KeyspacesRow OldImage { get; set; }

        /// <summary>
        /// Checks to see if the OldImage property is set.
        /// </summary>
        internal bool IsSetOldImage() => this.OldImage != null;

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// The origin or source of this change data capture record.
        /// </para>
        /// </summary>
        public OriginType Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;

        /// <summary>
        /// Gets and sets the property PartitionKeys. 
        /// <para>
        /// The partition key columns and their values for the affected row.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, KeyspacesCellValue> PartitionKeys { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, KeyspacesCellValue>() : null;

        /// <summary>
        /// Checks to see if the PartitionKeys property is set.
        /// </summary>
        internal bool IsSetPartitionKeys() => this.PartitionKeys != null && (this.PartitionKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// A unique identifier assigned to this record within the shard, used for ordering and
        /// tracking purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 48)]
        public string SequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the SequenceNumber property is set.
        /// </summary>
        internal bool IsSetSequenceNumber() => this.SequenceNumber != null;
    }
}
