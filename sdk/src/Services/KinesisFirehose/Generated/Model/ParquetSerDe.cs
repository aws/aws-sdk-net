/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// A serializer to use for converting data to the Parquet format before storing it in
    /// Amazon S3. For more information, see <a href="https://parquet.apache.org/documentation/latest/">Apache
    /// Parquet</a>.
    /// </summary>
    public partial class ParquetSerDe
    {
        private int? _blockSizeBytes;
        private ParquetCompression _compression;
        private bool? _enableDictionaryCompression;
        private int? _maxPaddingBytes;
        private int? _pageSizeBytes;
        private ParquetWriterVersion _writerVersion;

        /// <summary>
        /// Gets and sets the property BlockSizeBytes. 
        /// <para>
        /// The Hadoop Distributed File System (HDFS) block size. This is useful if you intend
        /// to copy the data from Amazon S3 to HDFS before querying. The default is 256 MiB and
        /// the minimum is 64 MiB. Kinesis Data Firehose uses this value for padding calculations.
        /// </para>
        /// </summary>
        public int BlockSizeBytes
        {
            get { return this._blockSizeBytes.GetValueOrDefault(); }
            set { this._blockSizeBytes = value; }
        }

        // Check to see if BlockSizeBytes property is set
        internal bool IsSetBlockSizeBytes()
        {
            return this._blockSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Compression. 
        /// <para>
        /// The compression code to use over data blocks. The possible values are <code>UNCOMPRESSED</code>,
        /// <code>SNAPPY</code>, and <code>GZIP</code>, with the default being <code>SNAPPY</code>.
        /// Use <code>SNAPPY</code> for higher decompression speed. Use <code>GZIP</code> if the
        /// compression ration is more important than speed.
        /// </para>
        /// </summary>
        public ParquetCompression Compression
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
        /// Gets and sets the property EnableDictionaryCompression. 
        /// <para>
        /// Indicates whether to enable dictionary compression.
        /// </para>
        /// </summary>
        public bool EnableDictionaryCompression
        {
            get { return this._enableDictionaryCompression.GetValueOrDefault(); }
            set { this._enableDictionaryCompression = value; }
        }

        // Check to see if EnableDictionaryCompression property is set
        internal bool IsSetEnableDictionaryCompression()
        {
            return this._enableDictionaryCompression.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxPaddingBytes. 
        /// <para>
        /// The maximum amount of padding to apply. This is useful if you intend to copy the data
        /// from Amazon S3 to HDFS before querying. The default is 0.
        /// </para>
        /// </summary>
        public int MaxPaddingBytes
        {
            get { return this._maxPaddingBytes.GetValueOrDefault(); }
            set { this._maxPaddingBytes = value; }
        }

        // Check to see if MaxPaddingBytes property is set
        internal bool IsSetMaxPaddingBytes()
        {
            return this._maxPaddingBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PageSizeBytes. 
        /// <para>
        /// The Parquet page size. Column chunks are divided into pages. A page is conceptually
        /// an indivisible unit (in terms of compression and encoding). The minimum value is 64
        /// KiB and the default is 1 MiB.
        /// </para>
        /// </summary>
        public int PageSizeBytes
        {
            get { return this._pageSizeBytes.GetValueOrDefault(); }
            set { this._pageSizeBytes = value; }
        }

        // Check to see if PageSizeBytes property is set
        internal bool IsSetPageSizeBytes()
        {
            return this._pageSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WriterVersion. 
        /// <para>
        /// Indicates the version of row format to output. The possible values are <code>V1</code>
        /// and <code>V2</code>. The default is <code>V1</code>.
        /// </para>
        /// </summary>
        public ParquetWriterVersion WriterVersion
        {
            get { return this._writerVersion; }
            set { this._writerVersion = value; }
        }

        // Check to see if WriterVersion property is set
        internal bool IsSetWriterVersion()
        {
            return this._writerVersion != null;
        }

    }
}