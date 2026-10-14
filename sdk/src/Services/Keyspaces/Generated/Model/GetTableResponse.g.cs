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
    /// This is the response object from the GetTable operation.
    /// </summary>
    public partial class GetTableResponse : AmazonWebServiceResponse
    {
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
        public CapacitySpecificationSummary CapacitySpecification { get; set; }

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
        public CdcSpecificationSummary CdcSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CdcSpecification property is set.
        /// </summary>
        internal bool IsSetCdcSpecification() => this.CdcSpecification != null;

        /// <summary>
        /// Gets and sets the property ClientSideTimestamps. 
        /// <para>
        ///  The client-side timestamps setting of the table.
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
        /// The the description of the specified table.
        /// </para>
        /// </summary>
        public Comment Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The creation timestamp of the specified table.
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimestamp property is set.
        /// </summary>
        internal bool IsSetCreationTimestamp() => this.CreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultTimeToLive. 
        /// <para>
        /// The default Time to Live settings in seconds of the specified table.
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
        /// The encryption settings of the specified table.
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
        /// The name of the keyspace that the specified table is stored in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string KeyspaceName { get; set; }

        /// <summary>
        /// Checks to see if the KeyspaceName property is set.
        /// </summary>
        internal bool IsSetKeyspaceName() => this.KeyspaceName != null;

        /// <summary>
        /// Gets and sets the property LatestStreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string LatestStreamArn { get; set; }

        /// <summary>
        /// Checks to see if the LatestStreamArn property is set.
        /// </summary>
        internal bool IsSetLatestStreamArn() => this.LatestStreamArn != null;

        /// <summary>
        /// Gets and sets the property PointInTimeRecovery. 
        /// <para>
        /// The point-in-time recovery status of the specified table.
        /// </para>
        /// </summary>
        public PointInTimeRecoverySummary PointInTimeRecovery { get; set; }

        /// <summary>
        /// Checks to see if the PointInTimeRecovery property is set.
        /// </summary>
        internal bool IsSetPointInTimeRecovery() => this.PointInTimeRecovery != null;

        /// <summary>
        /// Gets and sets the property ReplicaSpecifications. 
        /// <para>
        /// Returns the Amazon Web Services Region specific settings of all Regions a multi-Region
        /// table is replicated in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0)]
        public List<ReplicaSpecificationSummary> ReplicaSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicaSpecificationSummary>() : null;

        /// <summary>
        /// Checks to see if the ReplicaSpecifications property is set.
        /// </summary>
        internal bool IsSetReplicaSpecifications() => this.ReplicaSpecifications != null && (this.ReplicaSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the specified table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1000)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property SchemaDefinition. 
        /// <para>
        /// The schema definition of the specified table.
        /// </para>
        /// </summary>
        public SchemaDefinition SchemaDefinition { get; set; }

        /// <summary>
        /// Checks to see if the SchemaDefinition property is set.
        /// </summary>
        internal bool IsSetSchemaDefinition() => this.SchemaDefinition != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the specified table.
        /// </para>
        /// </summary>
        public TableStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the specified table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property Ttl. 
        /// <para>
        /// The custom Time to Live settings of the specified table.
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
        /// The warm throughput settings for the table, including the current status and configured
        /// read and write capacity units.
        /// </para>
        /// </summary>
        public WarmThroughputSpecificationSummary WarmThroughputSpecification { get; set; }

        /// <summary>
        /// Checks to see if the WarmThroughputSpecification property is set.
        /// </summary>
        internal bool IsSetWarmThroughputSpecification() => this.WarmThroughputSpecification != null;
    }
}
