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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// This is the response object from the GetTable operation.
    /// </summary>
    public partial class GetTableResponse : AmazonWebServiceResponse
    {
        private CapacitySpecificationSummary _capacitySpecification;
        private CdcSpecificationSummary _cdcSpecification;
        private ClientSideTimestamps _clientSideTimestamps;
        private Comment _comment;
        private DateTime? _creationTimestamp;
        private int? _defaultTimeToLive;
        private EncryptionSpecification _encryptionSpecification;
        private string _keyspaceName;
        private string _latestStreamArn;
        private PointInTimeRecoverySummary _pointInTimeRecovery;
        private List<ReplicaSpecificationSummary> _replicaSpecifications = AWSConfigs.InitializeCollections ? new List<ReplicaSpecificationSummary>() : null;
        private string _resourceArn;
        private SchemaDefinition _schemaDefinition;
        private TableStatus _status;
        private string _tableName;
        private TimeToLive _ttl;

        /// <summary>
        /// Gets and sets the property CapacitySpecification. 
        /// <para>
        /// The read/write throughput capacity mode for a table. The options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>throughputMode:PAY_PER_REQUEST</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>throughputMode:PROVISIONED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CapacitySpecificationSummary CapacitySpecification
        {
            get { return this._capacitySpecification; }
            set { this._capacitySpecification = value; }
        }

        // Check to see if CapacitySpecification property is set
        internal bool IsSetCapacitySpecification()
        {
            return this._capacitySpecification != null;
        }

        /// <summary>
        /// Gets and sets the property CdcSpecification. 
        /// <para>
        /// The CDC stream settings of the table.
        /// </para>
        /// </summary>
        public CdcSpecificationSummary CdcSpecification
        {
            get { return this._cdcSpecification; }
            set { this._cdcSpecification = value; }
        }

        // Check to see if CdcSpecification property is set
        internal bool IsSetCdcSpecification()
        {
            return this._cdcSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property ClientSideTimestamps. 
        /// <para>
        ///  The client-side timestamps setting of the table.
        /// </para>
        /// </summary>
        public ClientSideTimestamps ClientSideTimestamps
        {
            get { return this._clientSideTimestamps; }
            set { this._clientSideTimestamps = value; }
        }

        // Check to see if ClientSideTimestamps property is set
        internal bool IsSetClientSideTimestamps()
        {
            return this._clientSideTimestamps != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The the description of the specified table.
        /// </para>
        /// </summary>
        public Comment Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The creation timestamp of the specified table.
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp
        {
            get { return this._creationTimestamp; }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultTimeToLive. 
        /// <para>
        /// The default Time to Live settings in seconds of the specified table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=630720000)]
        public int? DefaultTimeToLive
        {
            get { return this._defaultTimeToLive; }
            set { this._defaultTimeToLive = value; }
        }

        // Check to see if DefaultTimeToLive property is set
        internal bool IsSetDefaultTimeToLive()
        {
            return this._defaultTimeToLive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionSpecification. 
        /// <para>
        /// The encryption settings of the specified table.
        /// </para>
        /// </summary>
        public EncryptionSpecification EncryptionSpecification
        {
            get { return this._encryptionSpecification; }
            set { this._encryptionSpecification = value; }
        }

        // Check to see if EncryptionSpecification property is set
        internal bool IsSetEncryptionSpecification()
        {
            return this._encryptionSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        /// The name of the keyspace that the specified table is stored in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string KeyspaceName
        {
            get { return this._keyspaceName; }
            set { this._keyspaceName = value; }
        }

        // Check to see if KeyspaceName property is set
        internal bool IsSetKeyspaceName()
        {
            return this._keyspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property LatestStreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string LatestStreamArn
        {
            get { return this._latestStreamArn; }
            set { this._latestStreamArn = value; }
        }

        // Check to see if LatestStreamArn property is set
        internal bool IsSetLatestStreamArn()
        {
            return this._latestStreamArn != null;
        }

        /// <summary>
        /// Gets and sets the property PointInTimeRecovery. 
        /// <para>
        /// The point-in-time recovery status of the specified table.
        /// </para>
        /// </summary>
        public PointInTimeRecoverySummary PointInTimeRecovery
        {
            get { return this._pointInTimeRecovery; }
            set { this._pointInTimeRecovery = value; }
        }

        // Check to see if PointInTimeRecovery property is set
        internal bool IsSetPointInTimeRecovery()
        {
            return this._pointInTimeRecovery != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicaSpecifications. 
        /// <para>
        /// Returns the Amazon Web Services Region specific settings of all Regions a multi-Region
        /// table is replicated in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0)]
        public List<ReplicaSpecificationSummary> ReplicaSpecifications
        {
            get { return this._replicaSpecifications; }
            set { this._replicaSpecifications = value; }
        }

        // Check to see if ReplicaSpecifications property is set
        internal bool IsSetReplicaSpecifications()
        {
            return this._replicaSpecifications != null && (this._replicaSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the specified table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1000)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaDefinition. 
        /// <para>
        /// The schema definition of the specified table.
        /// </para>
        /// </summary>
        public SchemaDefinition SchemaDefinition
        {
            get { return this._schemaDefinition; }
            set { this._schemaDefinition = value; }
        }

        // Check to see if SchemaDefinition property is set
        internal bool IsSetSchemaDefinition()
        {
            return this._schemaDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the specified table.
        /// </para>
        /// </summary>
        public TableStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the specified table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property Ttl. 
        /// <para>
        /// The custom Time to Live settings of the specified table.
        /// </para>
        /// </summary>
        public TimeToLive Ttl
        {
            get { return this._ttl; }
            set { this._ttl = value; }
        }

        // Check to see if Ttl property is set
        internal bool IsSetTtl()
        {
            return this._ttl != null;
        }

    }
}