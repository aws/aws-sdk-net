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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Provides a report detailing the data repository task results of the files processed
    /// that match the criteria specified in the report <c>Scope</c> parameter. FSx delivers
    /// the report to the file system's linked data repository in Amazon S3, using the path
    /// specified in the report <c>Path</c> parameter. You can specify whether or not a report
    /// gets generated for a task using the <c>Enabled</c> parameter.
    /// </summary>
    public partial class CompletionReport
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Set <c>Enabled</c> to <c>True</c> to generate a <c>CompletionReport</c> when the task
        /// completes. If set to <c>true</c>, then you need to provide a report <c>Scope</c>,
        /// <c>Path</c>, and <c>Format</c>. Set <c>Enabled</c> to <c>False</c> if you do not want
        /// a <c>CompletionReport</c> generated when the task completes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Required if <c>Enabled</c> is set to <c>true</c>. Specifies the format of the <c>CompletionReport</c>.
        /// <c>REPORT_CSV_20191124</c> is the only format currently supported. When <c>Format</c>
        /// is set to <c>REPORT_CSV_20191124</c>, the <c>CompletionReport</c> is provided in CSV
        /// format, and is delivered to <c>{path}/task-{id}/failures.csv</c>. 
        /// </para>
        /// </summary>
        public ReportFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Required if <c>Enabled</c> is set to <c>true</c>. Specifies the location of the report
        /// on the file system's linked S3 data repository. An absolute path that defines where
        /// the completion report will be stored in the destination location. The <c>Path</c>
        /// you provide must be located within the file system’s ExportPath. An example <c>Path</c>
        /// value is "s3://amzn-s3-demo-bucket/myExportPath/optionalPrefix". The report provides
        /// the following information for each file in the report: FilePath, FileStatus, and ErrorCode.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 4357)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Required if <c>Enabled</c> is set to <c>true</c>. Specifies the scope of the <c>CompletionReport</c>;
        /// <c>FAILED_FILES_ONLY</c> is the only scope currently supported. When <c>Scope</c>
        /// is set to <c>FAILED_FILES_ONLY</c>, the <c>CompletionReport</c> only contains information
        /// about files that the data repository task failed to process.
        /// </para>
        /// </summary>
        public ReportScope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;
    }
}
