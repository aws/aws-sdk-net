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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// The properties of the data files that a migration writes. The migration also sets
    /// the compression codec and dictionary encoding as the destination table's write properties,
    /// so they remain the table's defaults after you complete the migration.
    /// </summary>
    public partial class MigrationTableProperties
    {
        /// <summary>
        /// Gets and sets the property CompressionCodec. 
        /// <para>
        /// The compression codec of the data files. The default is <c>zstd</c>.
        /// </para>
        /// </summary>
        public CompressionCodec CompressionCodec { get; set; }

        /// <summary>
        /// Checks to see if the CompressionCodec property is set.
        /// </summary>
        internal bool IsSetCompressionCodec() => this.CompressionCodec != null;

        /// <summary>
        /// Gets and sets the property DictionaryEncoding. 
        /// <para>
        /// Specifies whether the data files use dictionary encoding. The default is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? DictionaryEncoding { get; set; }

        /// <summary>
        /// Checks to see if the DictionaryEncoding property is set.
        /// </summary>
        internal bool IsSetDictionaryEncoding() => this.DictionaryEncoding.HasValue;

        /// <summary>
        /// Gets and sets the property IcebergFormatVersion. 
        /// <para>
        /// The Iceberg format version of the destination table. Valid values are <c>2</c> and
        /// <c>3</c>. The default is <c>2</c>.
        /// </para>
        /// </summary>
        public int? IcebergFormatVersion { get; set; }

        /// <summary>
        /// Checks to see if the IcebergFormatVersion property is set.
        /// </summary>
        internal bool IsSetIcebergFormatVersion() => this.IcebergFormatVersion.HasValue;

        /// <summary>
        /// Gets and sets the property WriteFormat. 
        /// <para>
        /// The file format of the data files. The only supported format is <c>parquet</c>, the
        /// default.
        /// </para>
        /// </summary>
        public DataFileFormat WriteFormat { get; set; }

        /// <summary>
        /// Checks to see if the WriteFormat property is set.
        /// </summary>
        internal bool IsSetWriteFormat() => this.WriteFormat != null;
    }
}
