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
    /// Container for the parameters to the CreateTable operation.
    /// The <c>CreateTable</c> operation adds a new table to the specified keyspace. Within
    /// a keyspace, table names must be unique.
    /// 
    ///  
    /// <para>
    ///  <c>CreateTable</c> is an asynchronous operation. When the request is received, the
    /// status of the table is set to <c>CREATING</c>. You can monitor the creation status
    /// of the new table by using the <c>GetTable</c> operation, which returns the current
    /// <c>status</c> of the table. You can start using a table when the status is <c>ACTIVE</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/getting-started.tables.html">Create
    /// a table</a> in the <i>Amazon Keyspaces Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateTableRequest : AmazonKeyspacesRequest
    {
        private AutoScalingSpecification _autoScalingSpecification;
        private CapacitySpecification _capacitySpecification;
        private CdcSpecification _cdcSpecification;
        private ClientSideTimestamps _clientSideTimestamps;
        private Comment _comment;
        private int? _defaultTimeToLive;
        private EncryptionSpecification _encryptionSpecification;
        private string _keyspaceName;
        private PointInTimeRecovery _pointInTimeRecovery;
        private List<ReplicaSpecification> _replicaSpecifications = AWSConfigs.InitializeCollections ? new List<ReplicaSpecification>() : null;
        private SchemaDefinition _schemaDefinition;
        private string _tableName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TimeToLive _ttl;

        /// <summary>
        /// Gets and sets the property AutoScalingSpecification. 
        /// <para>
        /// The optional auto scaling settings for a table in provisioned capacity mode. Specifies
        /// if the service can manage throughput capacity automatically on your behalf.
        /// </para>
        ///  
        /// <para>
        /// Auto scaling helps you provision throughput capacity for variable workloads efficiently
        /// by increasing and decreasing your table's read and write capacity automatically in
        /// response to application traffic. For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/autoscaling.html">Managing
        /// throughput capacity automatically with Amazon Keyspaces auto scaling</a> in the <i>Amazon
        /// Keyspaces Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, auto scaling is disabled for a table. 
        /// </para>
        /// </summary>
        public AutoScalingSpecification AutoScalingSpecification
        {
            get { return this._autoScalingSpecification; }
            set { this._autoScalingSpecification = value; }
        }

        // Check to see if AutoScalingSpecification property is set
        internal bool IsSetAutoScalingSpecification()
        {
            return this._autoScalingSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property CapacitySpecification. 
        /// <para>
        /// Specifies the read/write throughput capacity mode for the table. The options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>throughputMode:PAY_PER_REQUEST</c> and 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>throughputMode:PROVISIONED</c> - Provisioned capacity mode requires <c>readCapacityUnits</c>
        /// and <c>writeCapacityUnits</c> as input.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <c>throughput_mode:PAY_PER_REQUEST</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/ReadWriteCapacityMode.html">Read/write
        /// capacity modes</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        public CapacitySpecification CapacitySpecification
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
        public CdcSpecification CdcSpecification
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
        ///  Enables client-side timestamps for the table. By default, the setting is disabled.
        /// You can enable client-side timestamps with the following option:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>status: "enabled"</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Once client-side timestamps are enabled for a table, this setting cannot be disabled.
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
        /// This parameter allows to enter a description of the table.
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
        /// Gets and sets the property DefaultTimeToLive. 
        /// <para>
        /// The default Time to Live setting in seconds for the table.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/TTL-how-it-works.html#ttl-howitworks_default_ttl">Setting
        /// the default TTL value for a table</a> in the <i>Amazon Keyspaces Developer Guide</i>.
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
        /// Specifies how the encryption key for encryption at rest is managed for the table.
        /// You can choose one of the following KMS key (KMS key):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>type:AWS_OWNED_KMS_KEY</c> - This key is owned by Amazon Keyspaces. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>type:CUSTOMER_MANAGED_KMS_KEY</c> - This key is stored in your account and is
        /// created, owned, and managed by you. This option requires the <c>kms_key_identifier</c>
        /// of the KMS key in Amazon Resource Name (ARN) format as input.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <c>type:AWS_OWNED_KMS_KEY</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/EncryptionAtRest.html">Encryption
        /// at rest</a> in the <i>Amazon Keyspaces Developer Guide</i>.
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
        /// The name of the keyspace that the table is going to be created in.
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
        /// Gets and sets the property PointInTimeRecovery. 
        /// <para>
        /// Specifies if <c>pointInTimeRecovery</c> is enabled or disabled for the table. The
        /// options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>status=ENABLED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status=DISABLED</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If it's not specified, the default is <c>status=DISABLED</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/PointInTimeRecovery.html">Point-in-time
        /// recovery</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        public PointInTimeRecovery PointInTimeRecovery
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
        /// The optional Amazon Web Services Region specific settings of a multi-Region table.
        /// These settings overwrite the general settings of the table for the specified Region.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For a multi-Region table in provisioned capacity mode, you can configure the table's
        /// read capacity differently for each Region's replica. The write capacity, however,
        /// remains synchronized between all replicas to ensure that there's enough capacity to
        /// replicate writes across all Regions. To define the read capacity for a table replica
        /// in a specific Region, you can do so by configuring the following parameters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>region</c>: The Region where these settings are applied. (Required)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>readCapacityUnits</c>: The provisioned read capacity units. (Optional)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>readCapacityAutoScaling</c>: The read capacity auto scaling settings for the table.
        /// (Optional) 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ReplicaSpecification> ReplicaSpecifications
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
        /// Gets and sets the property SchemaDefinition. 
        /// <para>
        /// The <c>schemaDefinition</c> consists of the following parameters.
        /// </para>
        ///  
        /// <para>
        /// For each column to be created:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>name</c> - The name of the column.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>type</c> - An Amazon Keyspaces data type. For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/cql.elements.html#cql.data-types">Data
        /// types</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The primary key of the table consists of the following columns:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>partitionKeys</c> - The partition key can be a single column, or it can be a compound
        /// value composed of two or more columns. The partition key portion of the primary key
        /// is required and determines how Amazon Keyspaces stores your data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>name</c> - The name of each partition key column.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>clusteringKeys</c> - The optional clustering column portion of your primary key
        /// determines how the data is clustered and sorted within each partition.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>name</c> - The name of the clustering column. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>orderBy</c> - Sets the ascendant (<c>ASC</c>) or descendant (<c>DESC</c>) order
        /// modifier.
        /// </para>
        ///  
        /// <para>
        /// To define a column as static use <c>staticColumns</c> - Static columns store values
        /// that are shared by all rows in the same partition:
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>name</c> - The name of the column.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>type</c> - An Amazon Keyspaces data type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pair tags to be attached to the resource. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/tagging-keyspaces.html">Adding
        /// tags and labels to Amazon Keyspaces resources</a> in the <i>Amazon Keyspaces Developer
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Ttl. 
        /// <para>
        /// Enables Time to Live custom settings for the table. The options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>status:enabled</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status:disabled</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The default is <c>status:disabled</c>. After <c>ttl</c> is enabled, you can't disable
        /// it for the table.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/TTL.html">Expiring
        /// data by using Amazon Keyspaces Time to Live (TTL)</a> in the <i>Amazon Keyspaces Developer
        /// Guide</i>.
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