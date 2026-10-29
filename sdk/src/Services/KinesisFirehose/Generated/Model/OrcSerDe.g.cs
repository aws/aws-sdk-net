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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// A serializer to use for converting data to the ORC format before storing it in Amazon
    /// S3. For more information, see <a href="https://orc.apache.org/docs/">Apache ORC</a>.
    /// </summary>
    public partial class OrcSerDe
    {
        /// <summary>
        /// Gets and sets the property BlockSizeBytes. 
        /// <para>
        /// The Hadoop Distributed File System (HDFS) block size. This is useful if you intend
        /// to copy the data from Amazon S3 to HDFS before querying. The default is 256 MiB and
        /// the minimum is 64 MiB. Firehose uses this value for padding calculations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 67108864)]
        public int? BlockSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the BlockSizeBytes property is set.
        /// </summary>
        internal bool IsSetBlockSizeBytes() => this.BlockSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property BloomFilterColumns. 
        /// <para>
        /// The column names for which you want Firehose to create bloom filters. The default
        /// is <c>null</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BloomFilterColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BloomFilterColumns property is set.
        /// </summary>
        internal bool IsSetBloomFilterColumns() => this.BloomFilterColumns != null && (this.BloomFilterColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BloomFilterFalsePositiveProbability. 
        /// <para>
        /// The Bloom filter false positive probability (FPP). The lower the FPP, the bigger the
        /// Bloom filter. The default value is 0.05, the minimum is 0, and the maximum is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? BloomFilterFalsePositiveProbability { get; set; }

        /// <summary>
        /// Checks to see if the BloomFilterFalsePositiveProbability property is set.
        /// </summary>
        internal bool IsSetBloomFilterFalsePositiveProbability() => this.BloomFilterFalsePositiveProbability.HasValue;

        /// <summary>
        /// Gets and sets the property Compression. 
        /// <para>
        /// The compression code to use over data blocks. The default is <c>SNAPPY</c>.
        /// </para>
        /// </summary>
        public OrcCompression Compression { get; set; }

        /// <summary>
        /// Checks to see if the Compression property is set.
        /// </summary>
        internal bool IsSetCompression() => this.Compression != null;

        /// <summary>
        /// Gets and sets the property DictionaryKeyThreshold. 
        /// <para>
        /// Represents the fraction of the total number of non-null rows. To turn off dictionary
        /// encoding, set this fraction to a number that is less than the number of distinct keys
        /// in a dictionary. To always use dictionary encoding, set this threshold to 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? DictionaryKeyThreshold { get; set; }

        /// <summary>
        /// Checks to see if the DictionaryKeyThreshold property is set.
        /// </summary>
        internal bool IsSetDictionaryKeyThreshold() => this.DictionaryKeyThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property EnablePadding. 
        /// <para>
        /// Set this to <c>true</c> to indicate that you want stripes to be padded to the HDFS
        /// block boundaries. This is useful if you intend to copy the data from Amazon S3 to
        /// HDFS before querying. The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? EnablePadding { get; set; }

        /// <summary>
        /// Checks to see if the EnablePadding property is set.
        /// </summary>
        internal bool IsSetEnablePadding() => this.EnablePadding.HasValue;

        /// <summary>
        /// Gets and sets the property FormatVersion. 
        /// <para>
        /// The version of the file to write. The possible values are <c>V0_11</c> and <c>V0_12</c>.
        /// The default is <c>V0_12</c>.
        /// </para>
        /// </summary>
        public OrcFormatVersion FormatVersion { get; set; }

        /// <summary>
        /// Checks to see if the FormatVersion property is set.
        /// </summary>
        internal bool IsSetFormatVersion() => this.FormatVersion != null;

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
        /// Firehose ignores this parameter when <a>OrcSerDe$EnablePadding</a> is <c>false</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? PaddingTolerance { get; set; }

        /// <summary>
        /// Checks to see if the PaddingTolerance property is set.
        /// </summary>
        internal bool IsSetPaddingTolerance() => this.PaddingTolerance.HasValue;

        /// <summary>
        /// Gets and sets the property RowIndexStride. 
        /// <para>
        /// The number of rows between index entries. The default is 10,000 and the minimum is
        /// 1,000.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1000)]
        public int? RowIndexStride { get; set; }

        /// <summary>
        /// Checks to see if the RowIndexStride property is set.
        /// </summary>
        internal bool IsSetRowIndexStride() => this.RowIndexStride.HasValue;

        /// <summary>
        /// Gets and sets the property StripeSizeBytes. 
        /// <para>
        /// The number of bytes in each stripe. The default is 64 MiB and the minimum is 8 MiB.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8388608)]
        public int? StripeSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the StripeSizeBytes property is set.
        /// </summary>
        internal bool IsSetStripeSizeBytes() => this.StripeSizeBytes.HasValue;
    }
}
