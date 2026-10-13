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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a target that writes to an Iceberg data source in Amazon S3.
    /// </summary>
    public partial class S3IcebergDirectTarget
    {
        /// <summary>
        /// Gets and sets the property AdditionalOptions. 
        /// <para>
        /// Provides additional configuration options for customizing the Iceberg table behavior.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalOptions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalOptions property is set.
        /// </summary>
        internal bool IsSetAdditionalOptions() => this.AdditionalOptions != null && (this.AdditionalOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoDataQuality.
        /// </summary>
        public AutoDataQuality AutoDataQuality { get; set; }

        /// <summary>
        /// Checks to see if the AutoDataQuality property is set.
        /// </summary>
        internal bool IsSetAutoDataQuality() => this.AutoDataQuality != null;

        /// <summary>
        /// Gets and sets the property Compression. 
        /// <para>
        /// Specifies the compression codec used for Iceberg table files in S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IcebergTargetCompressionType Compression { get; set; }

        /// <summary>
        /// Checks to see if the Compression property is set.
        /// </summary>
        internal bool IsSetCompression() => this.Compression != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Specifies the file format used for storing Iceberg table data (e.g., Parquet, ORC).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// Defines the single input source that provides data to this Iceberg target.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> Inputs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Inputs property is set.
        /// </summary>
        internal bool IsSetInputs() => this.Inputs != null && (this.Inputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the unique identifier for the Iceberg target node in your data pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NumberTargetPartitions. 
        /// <para>
        /// Sets the number of target partitions for distributing Iceberg table files across S3.
        /// </para>
        /// </summary>
        public string NumberTargetPartitions { get; set; }

        /// <summary>
        /// Checks to see if the NumberTargetPartitions property is set.
        /// </summary>
        internal bool IsSetNumberTargetPartitions() => this.NumberTargetPartitions != null;

        /// <summary>
        /// Gets and sets the property OutputSchemas. 
        /// <para>
        /// Specifies the data schema for the S3 Iceberg direct target.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlueSchema> OutputSchemas { get; set; } = AWSConfigs.InitializeCollections ? new List<GlueSchema>() : null;

        /// <summary>
        /// Checks to see if the OutputSchemas property is set.
        /// </summary>
        internal bool IsSetOutputSchemas() => this.OutputSchemas != null && (this.OutputSchemas.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PartitionKeys. 
        /// <para>
        /// Specifies the columns used to partition the Iceberg table data in S3.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<string>> PartitionKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;

        /// <summary>
        /// Checks to see if the PartitionKeys property is set.
        /// </summary>
        internal bool IsSetPartitionKeys() => this.PartitionKeys != null && (this.PartitionKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Defines the S3 location where the Iceberg table data will be stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property SchemaChangePolicy. 
        /// <para>
        /// Defines how schema changes are handled when writing data to the Iceberg table.
        /// </para>
        /// </summary>
        public DirectSchemaChangePolicy SchemaChangePolicy { get; set; }

        /// <summary>
        /// Checks to see if the SchemaChangePolicy property is set.
        /// </summary>
        internal bool IsSetSchemaChangePolicy() => this.SchemaChangePolicy != null;
    }
}
