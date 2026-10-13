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
    /// Specifies a JSON data store stored in Amazon S3.
    /// </summary>
    public partial class S3JsonSource
    {
        /// <summary>
        /// Gets and sets the property AdditionalOptions. 
        /// <para>
        /// Specifies additional connection options.
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
        /// Specifies how the data is compressed. This is generally not necessary if the data
        /// has a standard file extension. Possible values are <c>"gzip"</c> and <c>"bzip"</c>).
        /// </para>
        /// </summary>
        public CompressionType CompressionType { get; set; }

        /// <summary>
        /// Checks to see if the CompressionType property is set.
        /// </summary>
        internal bool IsSetCompressionType() => this.CompressionType != null;

        /// <summary>
        /// Gets and sets the property Exclusions. 
        /// <para>
        /// A string containing a JSON list of Unix-style glob patterns to exclude. For example,
        /// "[\"**.pdf\"]" excludes all PDF files. 
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
        /// Grouping files is turned on by default when the input contains more than 50,000 files.
        /// To turn on grouping with fewer than 50,000 files, set this parameter to "inPartition".
        /// To disable grouping when there are more than 50,000 files, set this parameter to <c>"none"</c>.
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
        /// The target group size in bytes. The default is computed based on the input data size
        /// and the size of your cluster. When there are fewer than 50,000 input files, <c>"groupFiles"</c>
        /// must be set to <c>"inPartition"</c> for this to take effect.
        /// </para>
        /// </summary>
        public string GroupSize { get; set; }

        /// <summary>
        /// Checks to see if the GroupSize property is set.
        /// </summary>
        internal bool IsSetGroupSize() => this.GroupSize != null;

        /// <summary>
        /// Gets and sets the property JsonPath. 
        /// <para>
        /// A JsonPath string defining the JSON data.
        /// </para>
        /// </summary>
        public string JsonPath { get; set; }

        /// <summary>
        /// Checks to see if the JsonPath property is set.
        /// </summary>
        internal bool IsSetJsonPath() => this.JsonPath != null;

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
        [AWSProperty(Min = 0)]
        public int? MaxBand { get; set; }

        /// <summary>
        /// Checks to see if the MaxBand property is set.
        /// </summary>
        internal bool IsSetMaxBand() => this.MaxBand.HasValue;

        /// <summary>
        /// Gets and sets the property MaxFilesInBand. 
        /// <para>
        /// This option specifies the maximum number of files to save from the last maxBand seconds.
        /// If this number is exceeded, extra files are skipped and only processed in the next
        /// job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaxFilesInBand { get; set; }

        /// <summary>
        /// Checks to see if the MaxFilesInBand property is set.
        /// </summary>
        internal bool IsSetMaxFilesInBand() => this.MaxFilesInBand.HasValue;

        /// <summary>
        /// Gets and sets the property Multiline. 
        /// <para>
        /// A Boolean value that specifies whether a single record can span multiple lines. This
        /// can occur when a field contains a quoted new-line character. You must set this option
        /// to True if any record spans multiple lines. The default value is <c>False</c>, which
        /// allows for more aggressive file-splitting during parsing.
        /// </para>
        /// </summary>
        public bool? Multiline { get; set; }

        /// <summary>
        /// Checks to see if the Multiline property is set.
        /// </summary>
        internal bool IsSetMultiline() => this.Multiline.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputSchemas. 
        /// <para>
        /// Specifies the data schema for the S3 JSON source.
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
        /// A list of the Amazon S3 paths to read from.
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
        /// If set to true, recursively reads files in all subdirectories under the specified
        /// paths.
        /// </para>
        /// </summary>
        public bool? Recurse { get; set; }

        /// <summary>
        /// Checks to see if the Recurse property is set.
        /// </summary>
        internal bool IsSetRecurse() => this.Recurse.HasValue;
    }
}
