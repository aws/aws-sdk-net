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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private Dictionary<string, string> _additionalOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private AutoDataQuality _autoDataQuality;
        private IcebergTargetCompressionType _compression;
        private TargetFormat _format;
        private List<string> _inputs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _numberTargetPartitions;
        private List<GlueSchema> _outputSchemas = AWSConfigs.InitializeCollections ? new List<GlueSchema>() : null;
        private List<List<string>> _partitionKeys = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;
        private string _path;
        private DirectSchemaChangePolicy _schemaChangePolicy;

        /// <summary>
        /// Gets and sets the property AdditionalOptions. 
        /// <para>
        /// Provides additional configuration options for customizing the Iceberg table behavior.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalOptions
        {
            get { return this._additionalOptions; }
            set { this._additionalOptions = value; }
        }

        // Check to see if AdditionalOptions property is set
        internal bool IsSetAdditionalOptions()
        {
            return this._additionalOptions != null && (this._additionalOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoDataQuality.
        /// </summary>
        public AutoDataQuality AutoDataQuality
        {
            get { return this._autoDataQuality; }
            set { this._autoDataQuality = value; }
        }

        // Check to see if AutoDataQuality property is set
        internal bool IsSetAutoDataQuality()
        {
            return this._autoDataQuality != null;
        }

        /// <summary>
        /// Gets and sets the property Compression. 
        /// <para>
        /// Specifies the compression codec used for Iceberg table files in S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IcebergTargetCompressionType Compression
        {
            get { return this._compression; }
            set { this._compression = value; }
        }

        // Check to see if Compression property is set
        internal bool IsSetCompression()
        {
            return this._compression != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Specifies the file format used for storing Iceberg table data (e.g., Parquet, ORC).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// Defines the single input source that provides data to this Iceberg target.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && (this._inputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the unique identifier for the Iceberg target node in your data pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NumberTargetPartitions. 
        /// <para>
        /// Sets the number of target partitions for distributing Iceberg table files across S3.
        /// </para>
        /// </summary>
        public string NumberTargetPartitions
        {
            get { return this._numberTargetPartitions; }
            set { this._numberTargetPartitions = value; }
        }

        // Check to see if NumberTargetPartitions property is set
        internal bool IsSetNumberTargetPartitions()
        {
            return this._numberTargetPartitions != null;
        }

        /// <summary>
        /// Gets and sets the property OutputSchemas. 
        /// <para>
        /// Specifies the data schema for the S3 Iceberg direct target.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlueSchema> OutputSchemas
        {
            get { return this._outputSchemas; }
            set { this._outputSchemas = value; }
        }

        // Check to see if OutputSchemas property is set
        internal bool IsSetOutputSchemas()
        {
            return this._outputSchemas != null && (this._outputSchemas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PartitionKeys. 
        /// <para>
        /// Specifies the columns used to partition the Iceberg table data in S3.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<List<string>> PartitionKeys
        {
            get { return this._partitionKeys; }
            set { this._partitionKeys = value; }
        }

        // Check to see if PartitionKeys property is set
        internal bool IsSetPartitionKeys()
        {
            return this._partitionKeys != null && (this._partitionKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Defines the S3 location where the Iceberg table data will be stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaChangePolicy. 
        /// <para>
        /// Defines how schema changes are handled when writing data to the Iceberg table.
        /// </para>
        /// </summary>
        public DirectSchemaChangePolicy SchemaChangePolicy
        {
            get { return this._schemaChangePolicy; }
            set { this._schemaChangePolicy = value; }
        }

        // Check to see if SchemaChangePolicy property is set
        internal bool IsSetSchemaChangePolicy()
        {
            return this._schemaChangePolicy != null;
        }

    }
}