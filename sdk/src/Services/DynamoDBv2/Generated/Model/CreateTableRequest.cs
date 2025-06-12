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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTable operation.
    /// The <c>CreateTable</c> operation adds a new table to your account. In an Amazon Web
    /// Services account, table names must be unique within each Region. That is, you can
    /// have two tables with same name if you create the tables in different Regions.
    /// 
    ///  
    /// <para>
    ///  <c>CreateTable</c> is an asynchronous operation. Upon receiving a <c>CreateTable</c>
    /// request, DynamoDB immediately returns a response with a <c>TableStatus</c> of <c>CREATING</c>.
    /// After the table is created, DynamoDB sets the <c>TableStatus</c> to <c>ACTIVE</c>.
    /// You can perform read and write operations only on an <c>ACTIVE</c> table. 
    /// </para>
    ///  
    /// <para>
    /// You can optionally define secondary indexes on the new table, as part of the <c>CreateTable</c>
    /// operation. If you want to create multiple tables with secondary indexes on them, you
    /// must create the tables sequentially. Only one table with secondary indexes can be
    /// in the <c>CREATING</c> state at any given time.
    /// </para>
    ///  
    /// <para>
    /// You can use the <c>DescribeTable</c> action to check the table status.
    /// </para>
    /// </summary>
    public partial class CreateTableRequest : AmazonDynamoDBRequest
    {
        private List<AttributeDefinition> _attributeDefinitions = AWSConfigs.InitializeCollections ? new List<AttributeDefinition>() : null;
        private BillingMode _billingMode;
        private bool? _deletionProtectionEnabled;
        private List<GlobalSecondaryIndex> _globalSecondaryIndexes = AWSConfigs.InitializeCollections ? new List<GlobalSecondaryIndex>() : null;
        private List<KeySchemaElement> _keySchema = AWSConfigs.InitializeCollections ? new List<KeySchemaElement>() : null;
        private List<LocalSecondaryIndex> _localSecondaryIndexes = AWSConfigs.InitializeCollections ? new List<LocalSecondaryIndex>() : null;
        private OnDemandThroughput _onDemandThroughput;
        private ProvisionedThroughput _provisionedThroughput;
        private string _resourcePolicy;
        private SSESpecification _sseSpecification;
        private StreamSpecification _streamSpecification;
        private TableClass _tableClass;
        private string _tableName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private WarmThroughput _warmThroughput;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateTableRequest() { }

        /// <summary>
        /// Instantiates CreateTableRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table to create. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="keySchema">Specifies the attributes that make up the primary key for a table or an index. The attributes in <c>KeySchema</c> must also be defined in the <c>AttributeDefinitions</c> array. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataModel.html">Data Model</a> in the <i>Amazon DynamoDB Developer Guide</i>. Each <c>KeySchemaElement</c> in the array is composed of: <ul> <li>  <c>AttributeName</c> - The name of this key attribute. </li> <li>  <c>KeyType</c> - The role that the key attribute will assume: <ul> <li>  <c>HASH</c> - partition key </li> <li>  <c>RANGE</c> - sort key </li> </ul> </li> </ul> <note> The partition key of an item is also known as its <i>hash attribute</i>. The term "hash attribute" derives from the DynamoDB usage of an internal hash function to evenly distribute data items across partitions, based on their partition key values. The sort key of an item is also known as its <i>range attribute</i>. The term "range attribute" derives from the way DynamoDB stores items with the same partition key physically close together, in sorted order by the sort key value. </note> For a simple primary key (partition key), you must provide exactly one element with a <c>KeyType</c> of <c>HASH</c>. For a composite primary key (partition key and sort key), you must provide exactly two elements, in this order: The first element must have a <c>KeyType</c> of <c>HASH</c>, and the second element must have a <c>KeyType</c> of <c>RANGE</c>. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#WorkingWithTables.primary.key">Working with Tables</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        public CreateTableRequest(string tableName, List<KeySchemaElement> keySchema)
        {
            _tableName = tableName;
            _keySchema = keySchema;
        }

        /// <summary>
        /// Instantiates CreateTableRequest with the parameterized properties
        /// </summary>
        /// <param name="tableName">The name of the table to create. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="keySchema">Specifies the attributes that make up the primary key for a table or an index. The attributes in <c>KeySchema</c> must also be defined in the <c>AttributeDefinitions</c> array. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataModel.html">Data Model</a> in the <i>Amazon DynamoDB Developer Guide</i>. Each <c>KeySchemaElement</c> in the array is composed of: <ul> <li>  <c>AttributeName</c> - The name of this key attribute. </li> <li>  <c>KeyType</c> - The role that the key attribute will assume: <ul> <li>  <c>HASH</c> - partition key </li> <li>  <c>RANGE</c> - sort key </li> </ul> </li> </ul> <note> The partition key of an item is also known as its <i>hash attribute</i>. The term "hash attribute" derives from the DynamoDB usage of an internal hash function to evenly distribute data items across partitions, based on their partition key values. The sort key of an item is also known as its <i>range attribute</i>. The term "range attribute" derives from the way DynamoDB stores items with the same partition key physically close together, in sorted order by the sort key value. </note> For a simple primary key (partition key), you must provide exactly one element with a <c>KeyType</c> of <c>HASH</c>. For a composite primary key (partition key and sort key), you must provide exactly two elements, in this order: The first element must have a <c>KeyType</c> of <c>HASH</c>, and the second element must have a <c>KeyType</c> of <c>RANGE</c>. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#WorkingWithTables.primary.key">Working with Tables</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// <param name="attributeDefinitions">An array of attributes that describe the key schema for the table and indexes.</param>
        /// <param name="provisionedThroughput">Represents the provisioned throughput settings for a specified table or index. The settings can be modified using the <c>UpdateTable</c> operation.  If you set BillingMode as <c>PROVISIONED</c>, you must specify this property. If you set BillingMode as <c>PAY_PER_REQUEST</c>, you cannot specify this property. For current minimum and maximum provisioned throughput values, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Service, Account, and Table Quotas</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        public CreateTableRequest(string tableName, List<KeySchemaElement> keySchema, List<AttributeDefinition> attributeDefinitions, ProvisionedThroughput provisionedThroughput)
        {
            _tableName = tableName;
            _keySchema = keySchema;
            _attributeDefinitions = attributeDefinitions;
            _provisionedThroughput = provisionedThroughput;
        }

        /// <summary>
        /// Gets and sets the property AttributeDefinitions. 
        /// <para>
        /// An array of attributes that describe the key schema for the table and indexes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AttributeDefinition> AttributeDefinitions
        {
            get { return this._attributeDefinitions; }
            set { this._attributeDefinitions = value; }
        }

        // Check to see if AttributeDefinitions property is set
        internal bool IsSetAttributeDefinitions()
        {
            return this._attributeDefinitions != null && (this._attributeDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// Controls how you are charged for read and write throughput and how you manage capacity.
        /// This setting can be changed later.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PAY_PER_REQUEST</c> - We recommend using <c>PAY_PER_REQUEST</c> for most DynamoDB
        /// workloads. <c>PAY_PER_REQUEST</c> sets the billing mode to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/on-demand-capacity-mode.html">On-demand
        /// capacity mode</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROVISIONED</c> - We recommend using <c>PROVISIONED</c> for steady workloads with
        /// predictable growth where capacity requirements can be reliably forecasted. <c>PROVISIONED</c>
        /// sets the billing mode to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/provisioned-capacity-mode.html">Provisioned
        /// capacity mode</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BillingMode BillingMode
        {
            get { return this._billingMode; }
            set { this._billingMode = value; }
        }

        // Check to see if BillingMode property is set
        internal bool IsSetBillingMode()
        {
            return this._billingMode != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// Indicates whether deletion protection is to be enabled (true) or disabled (false)
        /// on the table.
        /// </para>
        /// </summary>
        public bool? DeletionProtectionEnabled
        {
            get { return this._deletionProtectionEnabled; }
            set { this._deletionProtectionEnabled = value; }
        }

        // Check to see if DeletionProtectionEnabled property is set
        internal bool IsSetDeletionProtectionEnabled()
        {
            return this._deletionProtectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlobalSecondaryIndexes. 
        /// <para>
        /// One or more global secondary indexes (the maximum is 20) to be created on the table.
        /// Each global secondary index in the array includes the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IndexName</c> - The name of the global secondary index. Must be unique only for
        /// this table.
        /// </para>
        ///   </li> <li> 
        /// <para>
        ///  <c>KeySchema</c> - Specifies the key schema for the global secondary index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Projection</c> - Specifies attributes that are copied (projected) from the table
        /// into the index. These are in addition to the primary key attributes and index key
        /// attributes, which are automatically projected. Each attribute specification is composed
        /// of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ProjectionType</c> - One of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KEYS_ONLY</c> - Only the index and primary keys are projected into the index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INCLUDE</c> - Only the specified table attributes are projected into the index.
        /// The list of projected attributes is in <c>NonKeyAttributes</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c> - All of the table attributes are projected into the index.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>NonKeyAttributes</c> - A list of one or more non-key attribute names that are
        /// projected into the secondary index. The total count of attributes provided in <c>NonKeyAttributes</c>,
        /// summed across all of the secondary indexes, must not exceed 100. If you project the
        /// same attribute into two different indexes, this counts as two distinct attributes
        /// when determining the total. This limit only applies when you specify the ProjectionType
        /// of <c>INCLUDE</c>. You still can specify the ProjectionType of <c>ALL</c> to project
        /// all attributes from the source table, even if the table has more than 100 attributes.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ProvisionedThroughput</c> - The provisioned throughput settings for the global
        /// secondary index, consisting of read and write capacity units.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlobalSecondaryIndex> GlobalSecondaryIndexes
        {
            get { return this._globalSecondaryIndexes; }
            set { this._globalSecondaryIndexes = value; }
        }

        // Check to see if GlobalSecondaryIndexes property is set
        internal bool IsSetGlobalSecondaryIndexes()
        {
            return this._globalSecondaryIndexes != null && (this._globalSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeySchema. 
        /// <para>
        /// Specifies the attributes that make up the primary key for a table or an index. The
        /// attributes in <c>KeySchema</c> must also be defined in the <c>AttributeDefinitions</c>
        /// array. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataModel.html">Data
        /// Model</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Each <c>KeySchemaElement</c> in the array is composed of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AttributeName</c> - The name of this key attribute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KeyType</c> - The role that the key attribute will assume:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HASH</c> - partition key
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RANGE</c> - sort key
        /// </para>
        ///  </li> </ul> </li> </ul> <note> 
        /// <para>
        /// The partition key of an item is also known as its <i>hash attribute</i>. The term
        /// "hash attribute" derives from the DynamoDB usage of an internal hash function to evenly
        /// distribute data items across partitions, based on their partition key values.
        /// </para>
        ///  
        /// <para>
        /// The sort key of an item is also known as its <i>range attribute</i>. The term "range
        /// attribute" derives from the way DynamoDB stores items with the same partition key
        /// physically close together, in sorted order by the sort key value.
        /// </para>
        ///  </note> 
        /// <para>
        /// For a simple primary key (partition key), you must provide exactly one element with
        /// a <c>KeyType</c> of <c>HASH</c>.
        /// </para>
        ///  
        /// <para>
        /// For a composite primary key (partition key and sort key), you must provide exactly
        /// two elements, in this order: The first element must have a <c>KeyType</c> of <c>HASH</c>,
        /// and the second element must have a <c>KeyType</c> of <c>RANGE</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#WorkingWithTables.primary.key">Working
        /// with Tables</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<KeySchemaElement> KeySchema
        {
            get { return this._keySchema; }
            set { this._keySchema = value; }
        }

        // Check to see if KeySchema property is set
        internal bool IsSetKeySchema()
        {
            return this._keySchema != null && (this._keySchema.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LocalSecondaryIndexes. 
        /// <para>
        /// One or more local secondary indexes (the maximum is 5) to be created on the table.
        /// Each index is scoped to a given partition key value. There is a 10 GB size limit per
        /// partition key value; otherwise, the size of a local secondary index is unconstrained.
        /// </para>
        ///  
        /// <para>
        /// Each local secondary index in the array includes the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IndexName</c> - The name of the local secondary index. Must be unique only for
        /// this table.
        /// </para>
        ///   </li> <li> 
        /// <para>
        ///  <c>KeySchema</c> - Specifies the key schema for the local secondary index. The key
        /// schema must begin with the same partition key as the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Projection</c> - Specifies attributes that are copied (projected) from the table
        /// into the index. These are in addition to the primary key attributes and index key
        /// attributes, which are automatically projected. Each attribute specification is composed
        /// of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ProjectionType</c> - One of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KEYS_ONLY</c> - Only the index and primary keys are projected into the index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INCLUDE</c> - Only the specified table attributes are projected into the index.
        /// The list of projected attributes is in <c>NonKeyAttributes</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c> - All of the table attributes are projected into the index.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>NonKeyAttributes</c> - A list of one or more non-key attribute names that are
        /// projected into the secondary index. The total count of attributes provided in <c>NonKeyAttributes</c>,
        /// summed across all of the secondary indexes, must not exceed 100. If you project the
        /// same attribute into two different indexes, this counts as two distinct attributes
        /// when determining the total. This limit only applies when you specify the ProjectionType
        /// of <c>INCLUDE</c>. You still can specify the ProjectionType of <c>ALL</c> to project
        /// all attributes from the source table, even if the table has more than 100 attributes.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LocalSecondaryIndex> LocalSecondaryIndexes
        {
            get { return this._localSecondaryIndexes; }
            set { this._localSecondaryIndexes = value; }
        }

        // Check to see if LocalSecondaryIndexes property is set
        internal bool IsSetLocalSecondaryIndexes()
        {
            return this._localSecondaryIndexes != null && (this._localSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OnDemandThroughput. 
        /// <para>
        /// Sets the maximum number of read and write units for the specified table in on-demand
        /// capacity mode. If you use this parameter, you must specify <c>MaxReadRequestUnits</c>,
        /// <c>MaxWriteRequestUnits</c>, or both.
        /// </para>
        /// </summary>
        public OnDemandThroughput OnDemandThroughput
        {
            get { return this._onDemandThroughput; }
            set { this._onDemandThroughput = value; }
        }

        // Check to see if OnDemandThroughput property is set
        internal bool IsSetOnDemandThroughput()
        {
            return this._onDemandThroughput != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedThroughput. 
        /// <para>
        /// Represents the provisioned throughput settings for a specified table or index. The
        /// settings can be modified using the <c>UpdateTable</c> operation.
        /// </para>
        ///  
        /// <para>
        ///  If you set BillingMode as <c>PROVISIONED</c>, you must specify this property. If
        /// you set BillingMode as <c>PAY_PER_REQUEST</c>, you cannot specify this property.
        /// </para>
        ///  
        /// <para>
        /// For current minimum and maximum provisioned throughput values, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Service,
        /// Account, and Table Quotas</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public ProvisionedThroughput ProvisionedThroughput
        {
            get { return this._provisionedThroughput; }
            set { this._provisionedThroughput = value; }
        }

        // Check to see if ProvisionedThroughput property is set
        internal bool IsSetProvisionedThroughput()
        {
            return this._provisionedThroughput != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcePolicy. 
        /// <para>
        /// An Amazon Web Services resource-based policy document in JSON format that will be
        /// attached to the table.
        /// </para>
        ///  
        /// <para>
        /// When you attach a resource-based policy while creating a table, the policy application
        /// is <i>strongly consistent</i>.
        /// </para>
        ///  
        /// <para>
        /// The maximum size supported for a resource-based policy document is 20 KB. DynamoDB
        /// counts whitespaces when calculating the size of a policy against this limit. For a
        /// full list of all considerations that apply for resource-based policies, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/rbac-considerations.html">Resource-based
        /// policy considerations</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You need to specify the <c>CreateTable</c> and <c>PutResourcePolicy</c> IAM actions
        /// for authorizing a user to create a table with a resource-based policy.
        /// </para>
        ///  </note>
        /// </summary>
        public string ResourcePolicy
        {
            get { return this._resourcePolicy; }
            set { this._resourcePolicy = value; }
        }

        // Check to see if ResourcePolicy property is set
        internal bool IsSetResourcePolicy()
        {
            return this._resourcePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property SSESpecification. 
        /// <para>
        /// Represents the settings used to enable server-side encryption.
        /// </para>
        /// </summary>
        public SSESpecification SSESpecification
        {
            get { return this._sseSpecification; }
            set { this._sseSpecification = value; }
        }

        // Check to see if SSESpecification property is set
        internal bool IsSetSSESpecification()
        {
            return this._sseSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property StreamSpecification. 
        /// <para>
        /// The settings for DynamoDB Streams on the table. These settings consist of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>StreamEnabled</c> - Indicates whether DynamoDB Streams is to be enabled (true)
        /// or disabled (false).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StreamViewType</c> - When an item in the table is modified, <c>StreamViewType</c>
        /// determines what information is written to the table's stream. Valid values for <c>StreamViewType</c>
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KEYS_ONLY</c> - Only the key attributes of the modified item are written to the
        /// stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_IMAGE</c> - The entire item, as it appears after it was modified, is written
        /// to the stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OLD_IMAGE</c> - The entire item, as it appeared before it was modified, is written
        /// to the stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_AND_OLD_IMAGES</c> - Both the new and the old item images of the item are
        /// written to the stream.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public StreamSpecification StreamSpecification
        {
            get { return this._streamSpecification; }
            set { this._streamSpecification = value; }
        }

        // Check to see if StreamSpecification property is set
        internal bool IsSetStreamSpecification()
        {
            return this._streamSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TableClass. 
        /// <para>
        /// The table class of the new table. Valid values are <c>STANDARD</c> and <c>STANDARD_INFREQUENT_ACCESS</c>.
        /// </para>
        /// </summary>
        public TableClass TableClass
        {
            get { return this._tableClass; }
            set { this._tableClass = value; }
        }

        // Check to see if TableClass property is set
        internal bool IsSetTableClass()
        {
            return this._tableClass != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table to create. You can also provide the Amazon Resource Name (ARN)
        /// of the table in this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// A list of key-value pairs to label the table. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Tagging.html">Tagging
        /// for DynamoDB</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property WarmThroughput. 
        /// <para>
        /// Represents the warm throughput (in read units per second and write units per second)
        /// for creating a table.
        /// </para>
        /// </summary>
        public WarmThroughput WarmThroughput
        {
            get { return this._warmThroughput; }
            set { this._warmThroughput = value; }
        }

        // Check to see if WarmThroughput property is set
        internal bool IsSetWarmThroughput()
        {
            return this._warmThroughput != null;
        }

    }
}