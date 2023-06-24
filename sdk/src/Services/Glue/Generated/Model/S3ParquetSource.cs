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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies an Apache Parquet data store stored in Amazon S3.
    /// </summary>
    public partial class S3ParquetSource
    {
        private S3DirectSourceAdditionalOptions _additionalOptions;
        private ParquetCompressionType _compressionType;
        private List<string> _exclusions = new List<string>();
        private string _groupFiles;
        private string _groupSize;
        private int? _maxBand;
        private int? _maxFilesInBand;
        private string _name;
        private List<GlueSchema> _outputSchemas = new List<GlueSchema>();
        private List<string> _paths = new List<string>();
        private bool? _recurse;

        /// <summary>
        /// Gets and sets the property AdditionalOptions. 
        /// <para>
        /// Specifies additional connection options.
        /// </para>
        /// </summary>
        public S3DirectSourceAdditionalOptions AdditionalOptions
        {
            get { return this._additionalOptions; }
            set { this._additionalOptions = value; }
        }

        // Check to see if AdditionalOptions property is set
        internal bool IsSetAdditionalOptions()
        {
            return this._additionalOptions != null;
        }

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// Specifies how the data is compressed. This is generally not necessary if the data
        /// has a standard file extension. Possible values are <code>"gzip"</code> and <code>"bzip"</code>).
        /// </para>
        /// </summary>
        public ParquetCompressionType CompressionType
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
        /// Gets and sets the property Exclusions. 
        /// <para>
        /// A string containing a JSON list of Unix-style glob patterns to exclude. For example,
        /// "[\"**.pdf\"]" excludes all PDF files. 
        /// </para>
        /// </summary>
        public List<string> Exclusions
        {
            get { return this._exclusions; }
            set { this._exclusions = value; }
        }

        // Check to see if Exclusions property is set
        internal bool IsSetExclusions()
        {
            return this._exclusions != null && this._exclusions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GroupFiles. 
        /// <para>
        /// Grouping files is turned on by default when the input contains more than 50,000 files.
        /// To turn on grouping with fewer than 50,000 files, set this parameter to "inPartition".
        /// To disable grouping when there are more than 50,000 files, set this parameter to <code>"none"</code>.
        /// </para>
        /// </summary>
        public string GroupFiles
        {
            get { return this._groupFiles; }
            set { this._groupFiles = value; }
        }

        // Check to see if GroupFiles property is set
        internal bool IsSetGroupFiles()
        {
            return this._groupFiles != null;
        }

        /// <summary>
        /// Gets and sets the property GroupSize. 
        /// <para>
        /// The target group size in bytes. The default is computed based on the input data size
        /// and the size of your cluster. When there are fewer than 50,000 input files, <code>"groupFiles"</code>
        /// must be set to <code>"inPartition"</code> for this to take effect.
        /// </para>
        /// </summary>
        public string GroupSize
        {
            get { return this._groupSize; }
            set { this._groupSize = value; }
        }

        // Check to see if GroupSize property is set
        internal bool IsSetGroupSize()
        {
            return this._groupSize != null;
        }

        /// <summary>
        /// Gets and sets the property MaxBand. 
        /// <para>
        /// This option controls the duration in milliseconds after which the s3 listing is likely
        /// to be consistent. Files with modification timestamps falling within the last maxBand
        /// milliseconds are tracked specially when using JobBookmarks to account for Amazon S3
        /// eventual consistency. Most users don't need to set this option. The default is 900000
        /// milliseconds, or 15 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int MaxBand
        {
            get { return this._maxBand.GetValueOrDefault(); }
            set { this._maxBand = value; }
        }

        // Check to see if MaxBand property is set
        internal bool IsSetMaxBand()
        {
            return this._maxBand.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFilesInBand. 
        /// <para>
        /// This option specifies the maximum number of files to save from the last maxBand seconds.
        /// If this number is exceeded, extra files are skipped and only processed in the next
        /// job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int MaxFilesInBand
        {
            get { return this._maxFilesInBand.GetValueOrDefault(); }
            set { this._maxFilesInBand = value; }
        }

        // Check to see if MaxFilesInBand property is set
        internal bool IsSetMaxFilesInBand()
        {
            return this._maxFilesInBand.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data store.
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
        /// Gets and sets the property OutputSchemas. 
        /// <para>
        /// Specifies the data schema for the S3 Parquet source.
        /// </para>
        /// </summary>
        public List<GlueSchema> OutputSchemas
        {
            get { return this._outputSchemas; }
            set { this._outputSchemas = value; }
        }

        // Check to see if OutputSchemas property is set
        internal bool IsSetOutputSchemas()
        {
            return this._outputSchemas != null && this._outputSchemas.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Paths. 
        /// <para>
        /// A list of the Amazon S3 paths to read from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Paths
        {
            get { return this._paths; }
            set { this._paths = value; }
        }

        // Check to see if Paths property is set
        internal bool IsSetPaths()
        {
            return this._paths != null && this._paths.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Recurse. 
        /// <para>
        /// If set to true, recursively reads files in all subdirectories under the specified
        /// paths.
        /// </para>
        /// </summary>
        public bool Recurse
        {
            get { return this._recurse.GetValueOrDefault(); }
            set { this._recurse = value; }
        }

        // Check to see if Recurse property is set
        internal bool IsSetRecurse()
        {
            return this._recurse.HasValue; 
        }

    }
}