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

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTable operation. The <c>CreateTable</c>
    /// operation adds a new table to the specified keyspace. Within a keyspace, table names
    /// must be unique. <para> <c>CreateTable</c> is an asynchronous operation. When the request
    /// is received, the status of the table is set to <c>CREATING</c>. You can monitor the
    /// creation status of the new table by using the <c>GetTable</c> operation, which returns
    /// the current <c>status</c> of the table. You can start using a table when the status
    /// is <c>ACTIVE</c>. </para> <para> For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/getting-started.tables.html">Create
    /// a table</a> in the <i>Amazon Keyspaces Developer Guide</i>. </para>
    /// </summary>
    public partial class CreateTableRequest : AmazonKeyspacesRequest
    {
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
        public AutoScalingSpecification AutoScalingSpecification { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingSpecification property is set.
        /// </summary>
        internal bool IsSetAutoScalingSpecification() => this.AutoScalingSpecification != null;

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
        public CapacitySpecification CapacitySpecification { get; set; }

        /// <summary>
        /// Checks to see if the CapacitySpecification property is set.
        /// </summary>
        internal bool IsSetCapacitySpecification() => this.CapacitySpecification != null;

        /// <summary>
        /// Gets and sets the property CdcSpecification. 
        /// <para>
        /// The CDC stream settings of the table.
        /// </para>
        /// </summary>
        public CdcSpecification CdcSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CdcSpecification property is set.
        /// </summary>
        internal bool IsSetCdcSpecification() => this.CdcSpecification != null;

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
        public ClientSideTimestamps ClientSideTimestamps { get; set; }

        /// <summary>
        /// Checks to see if the ClientSideTimestamps property is set.
        /// </summary>
        internal bool IsSetClientSideTimestamps() => this.ClientSideTimestamps != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// This parameter allows to enter a description of the table.
        /// </para>
        /// </summary>
        public Comment Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

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
        [AWSProperty(Min = 0, Max = 630720000)]
        public int? DefaultTimeToLive { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTimeToLive property is set.
        /// </summary>
        internal bool IsSetDefaultTimeToLive() => this.DefaultTimeToLive.HasValue;

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
        public EncryptionSpecification EncryptionSpecification { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionSpecification property is set.
        /// </summary>
        internal bool IsSetEncryptionSpecification() => this.EncryptionSpecification != null;

        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        /// The name of the keyspace that the table is going to be created in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string KeyspaceName { get; set; }

        /// <summary>
        /// Checks to see if the KeyspaceName property is set.
        /// </summary>
        internal bool IsSetKeyspaceName() => this.KeyspaceName != null;

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
        public PointInTimeRecovery PointInTimeRecovery { get; set; }

        /// <summary>
        /// Checks to see if the PointInTimeRecovery property is set.
        /// </summary>
        internal bool IsSetPointInTimeRecovery() => this.PointInTimeRecovery != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ReplicaSpecification> ReplicaSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicaSpecification>() : null;

        /// <summary>
        /// Checks to see if the ReplicaSpecifications property is set.
        /// </summary>
        internal bool IsSetReplicaSpecifications() => this.ReplicaSpecifications != null && (this.ReplicaSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true)]
        public SchemaDefinition SchemaDefinition { get; set; }

        /// <summary>
        /// Checks to see if the SchemaDefinition property is set.
        /// </summary>
        internal bool IsSetSchemaDefinition() => this.SchemaDefinition != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public TimeToLive Ttl { get; set; }

        /// <summary>
        /// Checks to see if the Ttl property is set.
        /// </summary>
        internal bool IsSetTtl() => this.Ttl != null;

        /// <summary>
        /// Gets and sets the property WarmThroughputSpecification. 
        /// <para>
        /// Specifies the warm throughput settings for the table. Pre-warming a table helps you
        /// avoid capacity exceeded exceptions by pre-provisioning read and write capacity units
        /// to reduce cold start latency when your table receives traffic.
        /// </para>
        ///  
        /// <para>
        /// For more information about pre-warming in Amazon Keyspaces, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/warm-throughput.html">Pre-warm
        /// a table in Amazon Keyspaces</a> in the <i>Amazon Keyspaces Developer Guide</i>.
        /// </para>
        /// </summary>
        public WarmThroughputSpecification WarmThroughputSpecification { get; set; }

        /// <summary>
        /// Checks to see if the WarmThroughputSpecification property is set.
        /// </summary>
        internal bool IsSetWarmThroughputSpecification() => this.WarmThroughputSpecification != null;
    }
}
