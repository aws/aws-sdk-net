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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
        private bool? _appendOnly;
        private Catalog _catalog;
        private IcebergCompressionType _compressionType;
        private int? _dataFreshnessInSeconds;
        private DeadLetterQueueS3 _deadLetterQueueS3;
        private List<DestinationTable> _destinationTableList = AWSConfigs.InitializeCollections ? new List<DestinationTable>() : null;
        private SchemaEvolution _schemaEvolution;
        private string _serviceExecutionRoleArn;
        private TableCreation _tableCreation;

        /// <summary>
        /// Gets and sets the property AppendOnly. 
        /// <para>
        /// Whether the destination is append-only. Must be true; updates and deletes are not
        /// supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? AppendOnly
        {
            get { return this._appendOnly; }
            set { this._appendOnly = value; }
        }

        // Check to see if AppendOnly property is set
        internal bool IsSetAppendOnly()
        {
            return this._appendOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The AWS Glue Data Catalog and S3 Tables warehouse used by the destination.
        /// </para>
        /// </summary>
        public Catalog Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// The compression codec for Iceberg table data files. Defaults to ZSTD.
        /// </para>
        /// </summary>
        public IcebergCompressionType CompressionType
        {
            get { return this._compressionType; }
            set { this._compressionType = value; }
        }

        // Check to see if CompressionType property is set
        internal bool IsSetCompressionType()
        {
            return this._compressionType != null;
        }

        /// <summary>
        /// Gets and sets the property DataFreshnessInSeconds. 
        /// <para>
        /// The maximum time, in seconds, that records buffer in MSK before being flushed to the
        /// destination. Allowed range: 300 to 900. Default: 600.
        /// </para>
        /// </summary>
        public int? DataFreshnessInSeconds
        {
            get { return this._dataFreshnessInSeconds; }
            set { this._dataFreshnessInSeconds = value; }
        }

        // Check to see if DataFreshnessInSeconds property is set
        internal bool IsSetDataFreshnessInSeconds()
        {
            return this._dataFreshnessInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeadLetterQueueS3. 
        /// <para>
        /// The Amazon S3 bucket and prefix where MSK writes records that fail to deliver.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeadLetterQueueS3 DeadLetterQueueS3
        {
            get { return this._deadLetterQueueS3; }
            set { this._deadLetterQueueS3 = value; }
        }

        // Check to see if DeadLetterQueueS3 property is set
        internal bool IsSetDeadLetterQueueS3()
        {
            return this._deadLetterQueueS3 != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationTableList. 
        /// <para>
        /// The destination Iceberg tables. Currently exactly one table must be specified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DestinationTable> DestinationTableList
        {
            get { return this._destinationTableList; }
            set { this._destinationTableList = value; }
        }

        // Check to see if DestinationTableList property is set
        internal bool IsSetDestinationTableList()
        {
            return this._destinationTableList != null && (this._destinationTableList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SchemaEvolution. 
        /// <para>
        /// Configuration controlling whether the destination table's schema is evolved to match
        /// incoming records.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SchemaEvolution SchemaEvolution
        {
            get { return this._schemaEvolution; }
            set { this._schemaEvolution = value; }
        }

        // Check to see if SchemaEvolution property is set
        internal bool IsSetSchemaEvolution()
        {
            return this._schemaEvolution != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that MSK assumes to access the destination
        /// table, the AWS Glue Data Catalog, and the dead-letter Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceExecutionRoleArn
        {
            get { return this._serviceExecutionRoleArn; }
            set { this._serviceExecutionRoleArn = value; }
        }

        // Check to see if ServiceExecutionRoleArn property is set
        internal bool IsSetServiceExecutionRoleArn()
        {
            return this._serviceExecutionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TableCreation. 
        /// <para>
        /// Configuration controlling whether MSK creates the destination table if it does not
        /// already exist.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TableCreation TableCreation
        {
            get { return this._tableCreation; }
            set { this._tableCreation = value; }
        }

        // Check to see if TableCreation property is set
        internal bool IsSetTableCreation()
        {
            return this._tableCreation != null;
        }

    }
}