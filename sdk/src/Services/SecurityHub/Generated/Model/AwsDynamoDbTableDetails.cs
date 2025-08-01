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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about a DynamoDB table.
    /// </summary>
    public partial class AwsDynamoDbTableDetails
    {
        private List<AwsDynamoDbTableAttributeDefinition> _attributeDefinitions = AWSConfigs.InitializeCollections ? new List<AwsDynamoDbTableAttributeDefinition>() : null;
        private AwsDynamoDbTableBillingModeSummary _billingModeSummary;
        private string _creationDateTime;
        private bool? _deletionProtectionEnabled;
        private List<AwsDynamoDbTableGlobalSecondaryIndex> _globalSecondaryIndexes = AWSConfigs.InitializeCollections ? new List<AwsDynamoDbTableGlobalSecondaryIndex>() : null;
        private string _globalTableVersion;
        private int? _itemCount;
        private List<AwsDynamoDbTableKeySchema> _keySchema = AWSConfigs.InitializeCollections ? new List<AwsDynamoDbTableKeySchema>() : null;
        private string _latestStreamArn;
        private string _latestStreamLabel;
        private List<AwsDynamoDbTableLocalSecondaryIndex> _localSecondaryIndexes = AWSConfigs.InitializeCollections ? new List<AwsDynamoDbTableLocalSecondaryIndex>() : null;
        private AwsDynamoDbTableProvisionedThroughput _provisionedThroughput;
        private List<AwsDynamoDbTableReplica> _replicas = AWSConfigs.InitializeCollections ? new List<AwsDynamoDbTableReplica>() : null;
        private AwsDynamoDbTableRestoreSummary _restoreSummary;
        private AwsDynamoDbTableSseDescription _sseDescription;
        private AwsDynamoDbTableStreamSpecification _streamSpecification;
        private string _tableId;
        private string _tableName;
        private long? _tableSizeBytes;
        private string _tableStatus;

        /// <summary>
        /// Gets and sets the property AttributeDefinitions. 
        /// <para>
        /// A list of attribute definitions for the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsDynamoDbTableAttributeDefinition> AttributeDefinitions
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
        /// Gets and sets the property BillingModeSummary. 
        /// <para>
        /// Information about the billing for read/write capacity on the table.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableBillingModeSummary BillingModeSummary
        {
            get { return this._billingModeSummary; }
            set { this._billingModeSummary = value; }
        }

        // Check to see if BillingModeSummary property is set
        internal bool IsSetBillingModeSummary()
        {
            return this._billingModeSummary != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// Indicates when the table was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        ///  Indicates whether deletion protection is to be enabled (true) or disabled (false)
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
        /// List of global secondary indexes for the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsDynamoDbTableGlobalSecondaryIndex> GlobalSecondaryIndexes
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
        /// Gets and sets the property GlobalTableVersion. 
        /// <para>
        /// The version of global tables being used.
        /// </para>
        /// </summary>
        public string GlobalTableVersion
        {
            get { return this._globalTableVersion; }
            set { this._globalTableVersion = value; }
        }

        // Check to see if GlobalTableVersion property is set
        internal bool IsSetGlobalTableVersion()
        {
            return this._globalTableVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// The number of items in the table.
        /// </para>
        /// </summary>
        public int? ItemCount
        {
            get { return this._itemCount; }
            set { this._itemCount = value; }
        }

        // Check to see if ItemCount property is set
        internal bool IsSetItemCount()
        {
            return this._itemCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeySchema. 
        /// <para>
        /// The primary key structure for the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsDynamoDbTableKeySchema> KeySchema
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
        /// Gets and sets the property LatestStreamArn. 
        /// <para>
        /// The ARN of the latest stream for the table.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LatestStreamLabel. 
        /// <para>
        /// The label of the latest stream. The label is not a unique identifier.
        /// </para>
        /// </summary>
        public string LatestStreamLabel
        {
            get { return this._latestStreamLabel; }
            set { this._latestStreamLabel = value; }
        }

        // Check to see if LatestStreamLabel property is set
        internal bool IsSetLatestStreamLabel()
        {
            return this._latestStreamLabel != null;
        }

        /// <summary>
        /// Gets and sets the property LocalSecondaryIndexes. 
        /// <para>
        /// The list of local secondary indexes for the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsDynamoDbTableLocalSecondaryIndex> LocalSecondaryIndexes
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
        /// Gets and sets the property ProvisionedThroughput. 
        /// <para>
        /// Information about the provisioned throughput for the table.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableProvisionedThroughput ProvisionedThroughput
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
        /// Gets and sets the property Replicas. 
        /// <para>
        /// The list of replicas of this table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsDynamoDbTableReplica> Replicas
        {
            get { return this._replicas; }
            set { this._replicas = value; }
        }

        // Check to see if Replicas property is set
        internal bool IsSetReplicas()
        {
            return this._replicas != null && (this._replicas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RestoreSummary. 
        /// <para>
        /// Information about the restore for the table.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableRestoreSummary RestoreSummary
        {
            get { return this._restoreSummary; }
            set { this._restoreSummary = value; }
        }

        // Check to see if RestoreSummary property is set
        internal bool IsSetRestoreSummary()
        {
            return this._restoreSummary != null;
        }

        /// <summary>
        /// Gets and sets the property SseDescription. 
        /// <para>
        /// Information about the server-side encryption for the table.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableSseDescription SseDescription
        {
            get { return this._sseDescription; }
            set { this._sseDescription = value; }
        }

        // Check to see if SseDescription property is set
        internal bool IsSetSseDescription()
        {
            return this._sseDescription != null;
        }

        /// <summary>
        /// Gets and sets the property StreamSpecification. 
        /// <para>
        /// The current DynamoDB Streams configuration for the table.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableStreamSpecification StreamSpecification
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
        /// Gets and sets the property TableId. 
        /// <para>
        /// The identifier of the table.
        /// </para>
        /// </summary>
        public string TableId
        {
            get { return this._tableId; }
            set { this._tableId = value; }
        }

        // Check to see if TableId property is set
        internal bool IsSetTableId()
        {
            return this._tableId != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TableSizeBytes. 
        /// <para>
        /// The total size of the table in bytes.
        /// </para>
        /// </summary>
        public long? TableSizeBytes
        {
            get { return this._tableSizeBytes; }
            set { this._tableSizeBytes = value; }
        }

        // Check to see if TableSizeBytes property is set
        internal bool IsSetTableSizeBytes()
        {
            return this._tableSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TableStatus. 
        /// <para>
        /// The current status of the table. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARCHIVED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARCHIVING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INACCESSIBLE_ENCRYPTION_CREDENTIALS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string TableStatus
        {
            get { return this._tableStatus; }
            set { this._tableStatus = value; }
        }

        // Check to see if TableStatus property is set
        internal bool IsSetTableStatus()
        {
            return this._tableStatus != null;
        }

    }
}