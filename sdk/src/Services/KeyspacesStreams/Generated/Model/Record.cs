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
 * Do not modify this file. This file is generated from the keyspacesstreams-2024-09-09.normal.json service model.
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
        private Dictionary<string, KeyspacesCellValue> _clusteringKeys = AWSConfigs.InitializeCollections ? new Dictionary<string, KeyspacesCellValue>() : null;
        private DateTime? _createdAt;
        private string _eventVersion;
        private KeyspacesRow _newImage;
        private KeyspacesRow _oldImage;
        private OriginType _origin;
        private Dictionary<string, KeyspacesCellValue> _partitionKeys = AWSConfigs.InitializeCollections ? new Dictionary<string, KeyspacesCellValue>() : null;
        private string _sequenceNumber;

        /// <summary>
        /// Gets and sets the property ClusteringKeys. 
        /// <para>
        /// The clustering key columns and their values for the affected row, which determine
        /// the order of rows within a partition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, KeyspacesCellValue> ClusteringKeys
        {
            get { return this._clusteringKeys; }
            set { this._clusteringKeys = value; }
        }

        // Check to see if ClusteringKeys property is set
        internal bool IsSetClusteringKeys()
        {
            return this._clusteringKeys != null && (this._clusteringKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp indicating when this change data capture record was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventVersion. 
        /// <para>
        /// The version of the record format, used to track the evolution of the record structure
        /// over time.
        /// </para>
        /// </summary>
        public string EventVersion
        {
            get { return this._eventVersion; }
            set { this._eventVersion = value; }
        }

        // Check to see if EventVersion property is set
        internal bool IsSetEventVersion()
        {
            return this._eventVersion != null;
        }

        /// <summary>
        /// Gets and sets the property NewImage. 
        /// <para>
        /// The state of the row after the change operation that generated this record.
        /// </para>
        /// </summary>
        public KeyspacesRow NewImage
        {
            get { return this._newImage; }
            set { this._newImage = value; }
        }

        // Check to see if NewImage property is set
        internal bool IsSetNewImage()
        {
            return this._newImage != null;
        }

        /// <summary>
        /// Gets and sets the property OldImage. 
        /// <para>
        /// The state of the row before the change operation that generated this record.
        /// </para>
        /// </summary>
        public KeyspacesRow OldImage
        {
            get { return this._oldImage; }
            set { this._oldImage = value; }
        }

        // Check to see if OldImage property is set
        internal bool IsSetOldImage()
        {
            return this._oldImage != null;
        }

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// The origin or source of this change data capture record.
        /// </para>
        /// </summary>
        public OriginType Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionKeys. 
        /// <para>
        /// The partition key columns and their values for the affected row.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, KeyspacesCellValue> PartitionKeys
        {
            get { return this._partitionKeys; }
            set { this._partitionKeys = value; }
        }

        // Check to see if PartitionKeys property is set
        internal bool IsSetPartitionKeys()
        {
            return this._partitionKeys != null && (this._partitionKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// A unique identifier assigned to this record within the shard, used for ordering and
        /// tracking purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=48)]
        public string SequenceNumber
        {
            get { return this._sequenceNumber; }
            set { this._sequenceNumber = value; }
        }

        // Check to see if SequenceNumber property is set
        internal bool IsSetSequenceNumber()
        {
            return this._sequenceNumber != null;
        }

    }
}