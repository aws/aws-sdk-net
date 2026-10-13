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
    /// Specifies an S3 Excel data source.
    /// </summary>
    public partial class S3ExcelSource
    {
        /// <summary>
        /// Gets and sets the property AdditionalOptions. 
        /// <para>
        /// Additional configuration options for S3 direct source processing.
        /// </para>
        /// </summary>
        public S3DirectSourceAdditionalOptions AdditionalOptions { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalOptions property is set.
        /// </summary>
        internal bool IsSetAdditionalOptions() => this.AdditionalOptions != null;

        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// The compression format used for the Excel files.
        /// </para>
        /// </summary>
        public ParquetCompressionType CompressionType { get; set; }

        /// <summary>
        /// Checks to see if the CompressionType property is set.
        /// </summary>
        internal bool IsSetCompressionType() => this.CompressionType != null;

        /// <summary>
        /// Gets and sets the property Exclusions. 
        /// <para>
        /// Patterns to exclude specific files or paths from processing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Exclusions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Exclusions property is set.
        /// </summary>
        internal bool IsSetExclusions() => this.Exclusions != null && (this.Exclusions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupFiles. 
        /// <para>
        /// Specifies how files should be grouped for processing.
        /// </para>
        /// </summary>
        public string GroupFiles { get; set; }

        /// <summary>
        /// Checks to see if the GroupFiles property is set.
        /// </summary>
        internal bool IsSetGroupFiles() => this.GroupFiles != null;

        /// <summary>
        /// Gets and sets the property GroupSize. 
        /// <para>
        /// Defines the size of file groups for batch processing.
        /// </para>
        /// </summary>
        public string GroupSize { get; set; }

        /// <summary>
        /// Checks to see if the GroupSize property is set.
        /// </summary>
        internal bool IsSetGroupSize() => this.GroupSize != null;

        /// <summary>
        /// Gets and sets the property MaxBand. 
        /// <para>
        /// The maximum number of processing bands to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaxBand { get; set; }

        /// <summary>
        /// Checks to see if the MaxBand property is set.
        /// </summary>
        internal bool IsSetMaxBand() => this.MaxBand.HasValue;

        /// <summary>
        /// Gets and sets the property MaxFilesInBand. 
        /// <para>
        /// The maximum number of files to process in each band.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaxFilesInBand { get; set; }

        /// <summary>
        /// Checks to see if the MaxFilesInBand property is set.
        /// </summary>
        internal bool IsSetMaxFilesInBand() => this.MaxFilesInBand.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the S3 Excel data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NumberRows. 
        /// <para>
        /// The number of rows to process from each Excel file.
        /// </para>
        /// </summary>
        public long? NumberRows { get; set; }

        /// <summary>
        /// Checks to see if the NumberRows property is set.
        /// </summary>
        internal bool IsSetNumberRows() => this.NumberRows.HasValue;

        /// <summary>
        /// Gets and sets the property OutputSchemas. 
        /// <para>
        /// The Glue schemas to apply to the processed data.
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
        /// Gets and sets the property Paths. 
        /// <para>
        /// The S3 paths where the Excel files are located.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Paths { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Paths property is set.
        /// </summary>
        internal bool IsSetPaths() => this.Paths != null && (this.Paths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Recurse. 
        /// <para>
        /// Indicates whether to recursively process subdirectories.
        /// </para>
        /// </summary>
        public bool? Recurse { get; set; }

        /// <summary>
        /// Checks to see if the Recurse property is set.
        /// </summary>
        internal bool IsSetRecurse() => this.Recurse.HasValue;

        /// <summary>
        /// Gets and sets the property SkipFooter. 
        /// <para>
        /// The number of rows to skip at the end of each Excel file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? SkipFooter { get; set; }

        /// <summary>
        /// Checks to see if the SkipFooter property is set.
        /// </summary>
        internal bool IsSetSkipFooter() => this.SkipFooter.HasValue;
    }
}
