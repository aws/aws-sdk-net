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
    /// Specifies a HyperDirect data target that writes to Amazon S3.
    /// </summary>
    public partial class S3HyperDirectTarget
    {
        private HyperTargetCompressionType _compression;
        private List<string> _inputs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private List<List<string>> _partitionKeys = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;
        private string _path;
        private DirectSchemaChangePolicy _schemaChangePolicy;

        /// <summary>
        /// Gets and sets the property Compression. 
        /// <para>
        /// The compression type to apply to the output data.
        /// </para>
        /// </summary>
        public HyperTargetCompressionType Compression
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
        /// Gets and sets the property Inputs. 
        /// <para>
        /// Specifies the input source for the HyperDirect target.
        /// </para>
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
        /// The unique identifier for the HyperDirect target node.
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
        /// Gets and sets the property PartitionKeys. 
        /// <para>
        /// Defines the partitioning strategy for the output data.
        /// </para>
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
        /// The S3 location where the output data will be written.
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
        /// Defines how schema changes are handled during write operations.
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