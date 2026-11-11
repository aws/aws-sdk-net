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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Contains the details of the table when the backup was created.
    /// </summary>
    public partial class SourceTableDetails
    {
        /// <summary>
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// Controls how you are charged for read and write throughput and how you manage capacity.
        /// This setting can be changed later.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROVISIONED</c> - Sets the read/write capacity mode to <c>PROVISIONED</c>. We
        /// recommend using <c>PROVISIONED</c> for predictable workloads.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PAY_PER_REQUEST</c> - Sets the read/write capacity mode to <c>PAY_PER_REQUEST</c>.
        /// We recommend using <c>PAY_PER_REQUEST</c> for unpredictable workloads. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BillingMode BillingMode { get; set; }

        /// <summary>
        /// Checks to see if the BillingMode property is set.
        /// </summary>
        internal bool IsSetBillingMode() => this.BillingMode != null;

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// Number of items in the table. Note that this is an approximate value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ItemCount { get; set; }

        /// <summary>
        /// Checks to see if the ItemCount property is set.
        /// </summary>
        internal bool IsSetItemCount() => this.ItemCount.HasValue;

        /// <summary>
        /// Gets and sets the property KeySchema. 
        /// <para>
        /// Schema of the table. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<KeySchemaElement> KeySchema { get; set; } = AWSConfigs.InitializeCollections ? new List<KeySchemaElement>() : null;

        /// <summary>
        /// Checks to see if the KeySchema property is set.
        /// </summary>
        internal bool IsSetKeySchema() => this.KeySchema != null && (this.KeySchema.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OnDemandThroughput.
        /// </summary>
        public OnDemandThroughput OnDemandThroughput { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandThroughput property is set.
        /// </summary>
        internal bool IsSetOnDemandThroughput() => this.OnDemandThroughput != null;

        /// <summary>
        /// Gets and sets the property ProvisionedThroughput. 
        /// <para>
        /// Read IOPs and Write IOPS on the table when the backup was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProvisionedThroughput ProvisionedThroughput { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedThroughput property is set.
        /// </summary>
        internal bool IsSetProvisionedThroughput() => this.ProvisionedThroughput != null;

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        /// ARN of the table for which backup was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string TableArn { get; set; }

        /// <summary>
        /// Checks to see if the TableArn property is set.
        /// </summary>
        internal bool IsSetTableArn() => this.TableArn != null;

        /// <summary>
        /// Gets and sets the property TableCreationDateTime. 
        /// <para>
        /// Time when the source table was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? TableCreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the TableCreationDateTime property is set.
        /// </summary>
        internal bool IsSetTableCreationDateTime() => this.TableCreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property TableId. 
        /// <para>
        /// Unique identifier for the table for which the backup was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TableId { get; set; }

        /// <summary>
        /// Checks to see if the TableId property is set.
        /// </summary>
        internal bool IsSetTableId() => this.TableId != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table for which the backup was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 255)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property TableSizeBytes. 
        /// <para>
        /// Size of the table in bytes. Note that this is an approximate value.
        /// </para>
        /// </summary>
        public long? TableSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the TableSizeBytes property is set.
        /// </summary>
        internal bool IsSetTableSizeBytes() => this.TableSizeBytes.HasValue;
    }
}
