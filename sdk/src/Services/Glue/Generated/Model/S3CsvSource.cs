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
    /// Specifies a command-separated value (CSV) data store stored in Amazon S3.
    /// </summary>
    public partial class S3CsvSource
    {
        private S3DirectSourceAdditionalOptions _additionalOptions;
        private CompressionType _compressionType;
        private string _escaper;
        private List<string> _exclusions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _groupFiles;
        private string _groupSize;
        private int? _maxBand;
        private int? _maxFilesInBand;
        private bool? _multiline;
        private string _name;
        private bool? _optimizePerformance;
        private List<GlueSchema> _outputSchemas = AWSConfigs.InitializeCollections ? new List<GlueSchema>() : null;
        private List<string> _paths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private QuoteChar _quoteChar;
        private bool? _recurse;
        private Separator _separator;
        private bool? _skipFirst;
        private bool? _withHeader;
        private bool? _writeHeader;

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
        /// has a standard file extension. Possible values are <c>"gzip"</c> and <c>"bzip"</c>).
        /// </para>
        /// </summary>
        public CompressionType CompressionType
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
        /// Gets and sets the property Escaper. 
        /// <para>
        /// Specifies a character to use for escaping. This option is used only when reading CSV
        /// files. The default value is <c>none</c>. If enabled, the character which immediately
        /// follows is used as-is, except for a small set of well-known escapes (<c>\n</c>, <c>\r</c>,
        /// <c>\t</c>, and <c>\0</c>).
        /// </para>
        /// </summary>
        public string Escaper
        {
            get { return this._escaper; }
            set { this._escaper = value; }
        }

        // Check to see if Escaper property is set
        internal bool IsSetEscaper()
        {
            return this._escaper != null;
        }

        /// <summary>
        /// Gets and sets the property Exclusions. 
        /// <para>
        /// A string containing a JSON list of Unix-style glob patterns to exclude. For example,
        /// "[\"**.pdf\"]" excludes all PDF files. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Exclusions
        {
            get { return this._exclusions; }
            set { this._exclusions = value; }
        }

        // Check to see if Exclusions property is set
        internal bool IsSetExclusions()
        {
            return this._exclusions != null && (this._exclusions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GroupFiles. 
        /// <para>
        /// Grouping files is turned on by default when the input contains more than 50,000 files.
        /// To turn on grouping with fewer than 50,000 files, set this parameter to "inPartition".
        /// To disable grouping when there are more than 50,000 files, set this parameter to <c>"none"</c>.
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
        /// and the size of your cluster. When there are fewer than 50,000 input files, <c>"groupFiles"</c>
        /// must be set to <c>"inPartition"</c> for this to take effect.
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
        public int? MaxBand
        {
            get { return this._maxBand; }
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
        public int? MaxFilesInBand
        {
            get { return this._maxFilesInBand; }
            set { this._maxFilesInBand = value; }
        }

        // Check to see if MaxFilesInBand property is set
        internal bool IsSetMaxFilesInBand()
        {
            return this._maxFilesInBand.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Multiline. 
        /// <para>
        /// A Boolean value that specifies whether a single record can span multiple lines. This
        /// can occur when a field contains a quoted new-line character. You must set this option
        /// to True if any record spans multiple lines. The default value is <c>False</c>, which
        /// allows for more aggressive file-splitting during parsing.
        /// </para>
        /// </summary>
        public bool? Multiline
        {
            get { return this._multiline; }
            set { this._multiline = value; }
        }

        // Check to see if Multiline property is set
        internal bool IsSetMultiline()
        {
            return this._multiline.HasValue; 
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
        /// Gets and sets the property OptimizePerformance. 
        /// <para>
        /// A Boolean value that specifies whether to use the advanced SIMD CSV reader along with
        /// Apache Arrow based columnar memory formats. Only available in Glue version 3.0.
        /// </para>
        /// </summary>
        public bool? OptimizePerformance
        {
            get { return this._optimizePerformance; }
            set { this._optimizePerformance = value; }
        }

        // Check to see if OptimizePerformance property is set
        internal bool IsSetOptimizePerformance()
        {
            return this._optimizePerformance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputSchemas. 
        /// <para>
        /// Specifies the data schema for the S3 CSV source.
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
        /// Gets and sets the property Paths. 
        /// <para>
        /// A list of the Amazon S3 paths to read from.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._paths != null && (this._paths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QuoteChar. 
        /// <para>
        /// Specifies the character to use for quoting. The default is a double quote: <c>'"'</c>.
        /// Set this to <c>-1</c> to turn off quoting entirely.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QuoteChar QuoteChar
        {
            get { return this._quoteChar; }
            set { this._quoteChar = value; }
        }

        // Check to see if QuoteChar property is set
        internal bool IsSetQuoteChar()
        {
            return this._quoteChar != null;
        }

        /// <summary>
        /// Gets and sets the property Recurse. 
        /// <para>
        /// If set to true, recursively reads files in all subdirectories under the specified
        /// paths.
        /// </para>
        /// </summary>
        public bool? Recurse
        {
            get { return this._recurse; }
            set { this._recurse = value; }
        }

        // Check to see if Recurse property is set
        internal bool IsSetRecurse()
        {
            return this._recurse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Separator. 
        /// <para>
        /// Specifies the delimiter character. The default is a comma: ",", but any other character
        /// can be specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Separator Separator
        {
            get { return this._separator; }
            set { this._separator = value; }
        }

        // Check to see if Separator property is set
        internal bool IsSetSeparator()
        {
            return this._separator != null;
        }

        /// <summary>
        /// Gets and sets the property SkipFirst. 
        /// <para>
        /// A Boolean value that specifies whether to skip the first data line. The default value
        /// is <c>False</c>.
        /// </para>
        /// </summary>
        public bool? SkipFirst
        {
            get { return this._skipFirst; }
            set { this._skipFirst = value; }
        }

        // Check to see if SkipFirst property is set
        internal bool IsSetSkipFirst()
        {
            return this._skipFirst.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WithHeader. 
        /// <para>
        /// A Boolean value that specifies whether to treat the first line as a header. The default
        /// value is <c>False</c>.
        /// </para>
        /// </summary>
        public bool? WithHeader
        {
            get { return this._withHeader; }
            set { this._withHeader = value; }
        }

        // Check to see if WithHeader property is set
        internal bool IsSetWithHeader()
        {
            return this._withHeader.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WriteHeader. 
        /// <para>
        /// A Boolean value that specifies whether to write the header to output. The default
        /// value is <c>True</c>. 
        /// </para>
        /// </summary>
        public bool? WriteHeader
        {
            get { return this._writeHeader; }
            set { this._writeHeader = value; }
        }

        // Check to see if WriteHeader property is set
        internal bool IsSetWriteHeader()
        {
            return this._writeHeader.HasValue; 
        }

    }
}