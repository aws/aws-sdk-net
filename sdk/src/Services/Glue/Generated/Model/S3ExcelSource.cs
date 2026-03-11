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
    /// Specifies an S3 Excel data source.
    /// </summary>
    public partial class S3ExcelSource
    {
        private S3DirectSourceAdditionalOptions _additionalOptions;
        private ParquetCompressionType _compressionType;
        private List<string> _exclusions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _groupFiles;
        private string _groupSize;
        private int? _maxBand;
        private int? _maxFilesInBand;
        private string _name;
        private long? _numberRows;
        private List<GlueSchema> _outputSchemas = AWSConfigs.InitializeCollections ? new List<GlueSchema>() : null;
        private List<string> _paths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _recurse;
        private int? _skipFooter;

        /// <summary>
        /// Gets and sets the property AdditionalOptions. 
        /// <para>
        /// Additional configuration options for S3 direct source processing.
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
        /// The compression format used for the Excel files.
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
        /// Patterns to exclude specific files or paths from processing.
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
        /// Specifies how files should be grouped for processing.
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
        /// Defines the size of file groups for batch processing.
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
        /// The maximum number of processing bands to use.
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
        /// The maximum number of files to process in each band.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the S3 Excel data source.
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
        /// Gets and sets the property NumberRows. 
        /// <para>
        /// The number of rows to process from each Excel file.
        /// </para>
        /// </summary>
        public long? NumberRows
        {
            get { return this._numberRows; }
            set { this._numberRows = value; }
        }

        // Check to see if NumberRows property is set
        internal bool IsSetNumberRows()
        {
            return this._numberRows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputSchemas. 
        /// <para>
        /// The Glue schemas to apply to the processed data.
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
        /// The S3 paths where the Excel files are located.
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
        /// Gets and sets the property Recurse. 
        /// <para>
        /// Indicates whether to recursively process subdirectories.
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
        /// Gets and sets the property SkipFooter. 
        /// <para>
        /// The number of rows to skip at the end of each Excel file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? SkipFooter
        {
            get { return this._skipFooter; }
            set { this._skipFooter = value; }
        }

        // Check to see if SkipFooter property is set
        internal bool IsSetSkipFooter()
        {
            return this._skipFooter.HasValue; 
        }

    }
}