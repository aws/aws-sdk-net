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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Configuration of an Apache Iceberg destination for a channel.
    /// </summary>
    public partial class IcebergDestinationConfiguration
    {
        /// <summary>
        /// Gets and sets the property AppendOnly. 
        /// <para>
        /// Whether the destination is append-only. Must be true; updates and deletes are not
        /// supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? AppendOnly { get; set; }

        /// <summary>
        /// Checks to see if the AppendOnly property is set.
        /// </summary>
        internal bool IsSetAppendOnly() => this.AppendOnly.HasValue;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The AWS Glue Data Catalog and S3 Tables warehouse used by the destination.
        /// </para>
        /// </summary>
        public Catalog Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// The compression codec for Iceberg table data files. Defaults to ZSTD.
        /// </para>
        /// </summary>
        public IcebergCompressionType CompressionType { get; set; }

        /// <summary>
        /// Checks to see if the CompressionType property is set.
        /// </summary>
        internal bool IsSetCompressionType() => this.CompressionType != null;

        /// <summary>
        /// Gets and sets the property DataFreshnessInSeconds. 
        /// <para>
        /// The maximum time, in seconds, that records buffer in MSK before being flushed to the
        /// destination. Allowed range: 300 to 900. Default: 600.
        /// </para>
        /// </summary>
        public int? DataFreshnessInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DataFreshnessInSeconds property is set.
        /// </summary>
        internal bool IsSetDataFreshnessInSeconds() => this.DataFreshnessInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property DeadLetterQueueS3. 
        /// <para>
        /// The Amazon S3 bucket and prefix where MSK writes records that fail to deliver.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeadLetterQueueS3 DeadLetterQueueS3 { get; set; }

        /// <summary>
        /// Checks to see if the DeadLetterQueueS3 property is set.
        /// </summary>
        internal bool IsSetDeadLetterQueueS3() => this.DeadLetterQueueS3 != null;

        /// <summary>
        /// Gets and sets the property DestinationTableList. 
        /// <para>
        /// The destination Iceberg tables. Currently exactly one table must be specified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<DestinationTable> DestinationTableList { get; set; } = AWSConfigs.InitializeCollections ? new List<DestinationTable>() : null;

        /// <summary>
        /// Checks to see if the DestinationTableList property is set.
        /// </summary>
        internal bool IsSetDestinationTableList() => this.DestinationTableList != null && (this.DestinationTableList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SchemaEvolution. 
        /// <para>
        /// Configuration controlling whether the destination table's schema is evolved to match
        /// incoming records.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SchemaEvolution SchemaEvolution { get; set; }

        /// <summary>
        /// Checks to see if the SchemaEvolution property is set.
        /// </summary>
        internal bool IsSetSchemaEvolution() => this.SchemaEvolution != null;

        /// <summary>
        /// Gets and sets the property ServiceExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that MSK assumes to access the destination
        /// table, the AWS Glue Data Catalog, and the dead-letter Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceExecutionRoleArn() => this.ServiceExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property TableCreation. 
        /// <para>
        /// Configuration controlling whether MSK creates the destination table if it does not
        /// already exist.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TableCreation TableCreation { get; set; }

        /// <summary>
        /// Checks to see if the TableCreation property is set.
        /// </summary>
        internal bool IsSetTableCreation() => this.TableCreation != null;
    }
}
