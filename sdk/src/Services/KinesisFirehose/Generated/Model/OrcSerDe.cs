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
    /// A serializer to use for converting data to the ORC format before storing it in Amazon
    /// S3. For more information, see <a href="https://orc.apache.org/docs/">Apache ORC</a>.
    /// </summary>
    public partial class OrcSerDe
    {
        private int? _blockSizeBytes;
        private List<string> _bloomFilterColumns = new List<string>();
        private double? _bloomFilterFalsePositiveProbability;
        private OrcCompression _compression;
        private double? _dictionaryKeyThreshold;
        private bool? _enablePadding;
        private OrcFormatVersion _formatVersion;
        private double? _paddingTolerance;
        private int? _rowIndexStride;
        private int? _stripeSizeBytes;

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
        /// Gets and sets the property BloomFilterColumns. 
        /// <para>
        /// The column names for which you want Kinesis Data Firehose to create bloom filters.
        /// The default is <code>null</code>.
        /// </para>
        /// </summary>
        public List<string> BloomFilterColumns
        {
            get { return this._bloomFilterColumns; }
            set { this._bloomFilterColumns = value; }
        }

        // Check to see if BloomFilterColumns property is set
        internal bool IsSetBloomFilterColumns()
        {
            return this._bloomFilterColumns != null && this._bloomFilterColumns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BloomFilterFalsePositiveProbability. 
        /// <para>
        /// The Bloom filter false positive probability (FPP). The lower the FPP, the bigger the
        /// Bloom filter. The default value is 0.05, the minimum is 0, and the maximum is 1.
        /// </para>
        /// </summary>
        public double BloomFilterFalsePositiveProbability
        {
            get { return this._bloomFilterFalsePositiveProbability.GetValueOrDefault(); }
            set { this._bloomFilterFalsePositiveProbability = value; }
        }

        // Check to see if BloomFilterFalsePositiveProbability property is set
        internal bool IsSetBloomFilterFalsePositiveProbability()
        {
            return this._bloomFilterFalsePositiveProbability.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Compression. 
        /// <para>
        /// The compression code to use over data blocks. The default is <code>SNAPPY</code>.
        /// </para>
        /// </summary>
        public OrcCompression Compression
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
        /// Gets and sets the property DictionaryKeyThreshold. 
        /// <para>
        /// Represents the fraction of the total number of non-null rows. To turn off dictionary
        /// encoding, set this fraction to a number that is less than the number of distinct keys
        /// in a dictionary. To always use dictionary encoding, set this threshold to 1.
        /// </para>
        /// </summary>
        public double DictionaryKeyThreshold
        {
            get { return this._dictionaryKeyThreshold.GetValueOrDefault(); }
            set { this._dictionaryKeyThreshold = value; }
        }

        // Check to see if DictionaryKeyThreshold property is set
        internal bool IsSetDictionaryKeyThreshold()
        {
            return this._dictionaryKeyThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnablePadding. 
        /// <para>
        /// Set this to <code>true</code> to indicate that you want stripes to be padded to the
        /// HDFS block boundaries. This is useful if you intend to copy the data from Amazon S3
        /// to HDFS before querying. The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool EnablePadding
        {
            get { return this._enablePadding.GetValueOrDefault(); }
            set { this._enablePadding = value; }
        }

        // Check to see if EnablePadding property is set
        internal bool IsSetEnablePadding()
        {
            return this._enablePadding.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FormatVersion. 
        /// <para>
        /// The version of the file to write. The possible values are <code>V0_11</code> and <code>V0_12</code>.
        /// The default is <code>V0_12</code>.
        /// </para>
        /// </summary>
        public OrcFormatVersion FormatVersion
        {
            get { return this._formatVersion; }
            set { this._formatVersion = value; }
        }

        // Check to see if FormatVersion property is set
        internal bool IsSetFormatVersion()
        {
            return this._formatVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PaddingTolerance. 
        /// <para>
        /// A number between 0 and 1 that defines the tolerance for block padding as a decimal
        /// fraction of stripe size. The default value is 0.05, which means 5 percent of stripe
        /// size.
        /// </para>
        ///  
        /// <para>
        /// For the default values of 64 MiB ORC stripes and 256 MiB HDFS blocks, the default
        /// block padding tolerance of 5 percent reserves a maximum of 3.2 MiB for padding within
        /// the 256 MiB block. In such a case, if the available size within the block is more
        /// than 3.2 MiB, a new, smaller stripe is inserted to fit within that space. This ensures
        /// that no stripe crosses block boundaries and causes remote reads within a node-local
        /// task.
        /// </para>
        ///  
        /// <para>
        /// Kinesis Data Firehose ignores this parameter when <a>OrcSerDe$EnablePadding</a> is
        /// <code>false</code>.
        /// </para>
        /// </summary>
        public double PaddingTolerance
        {
            get { return this._paddingTolerance.GetValueOrDefault(); }
            set { this._paddingTolerance = value; }
        }

        // Check to see if PaddingTolerance property is set
        internal bool IsSetPaddingTolerance()
        {
            return this._paddingTolerance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RowIndexStride. 
        /// <para>
        /// The number of rows between index entries. The default is 10,000 and the minimum is
        /// 1,000.
        /// </para>
        /// </summary>
        public int RowIndexStride
        {
            get { return this._rowIndexStride.GetValueOrDefault(); }
            set { this._rowIndexStride = value; }
        }

        // Check to see if RowIndexStride property is set
        internal bool IsSetRowIndexStride()
        {
            return this._rowIndexStride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StripeSizeBytes. 
        /// <para>
        /// The number of bytes in each stripe. The default is 64 MiB and the minimum is 8 MiB.
        /// </para>
        /// </summary>
        public int StripeSizeBytes
        {
            get { return this._stripeSizeBytes.GetValueOrDefault(); }
            set { this._stripeSizeBytes = value; }
        }

        // Check to see if StripeSizeBytes property is set
        internal bool IsSetStripeSizeBytes()
        {
            return this._stripeSizeBytes.HasValue; 
        }

    }
}