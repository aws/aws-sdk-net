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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Provides a report detailing the data repository task results of the files processed
    /// that match the criteria specified in the report <code>Scope</code> parameter. FSx
    /// delivers the report to the file system's linked data repository in Amazon S3, using
    /// the path specified in the report <code>Path</code> parameter. You can specify whether
    /// or not a report gets generated for a task using the <code>Enabled</code> parameter.
    /// </summary>
    public partial class CompletionReport
    {
        private bool? _enabled;
        private ReportFormat _format;
        private string _path;
        private ReportScope _scope;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Set <code>Enabled</code> to <code>True</code> to generate a <code>CompletionReport</code>
        /// when the task completes. If set to <code>true</code>, then you need to provide a report
        /// <code>Scope</code>, <code>Path</code>, and <code>Format</code>. Set <code>Enabled</code>
        /// to <code>False</code> if you do not want a <code>CompletionReport</code> generated
        /// when the task completes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Required if <code>Enabled</code> is set to <code>true</code>. Specifies the format
        /// of the <code>CompletionReport</code>. <code>REPORT_CSV_20191124</code> is the only
        /// format currently supported. When <code>Format</code> is set to <code>REPORT_CSV_20191124</code>,
        /// the <code>CompletionReport</code> is provided in CSV format, and is delivered to <code>{path}/task-{id}/failures.csv</code>.
        /// 
        /// </para>
        /// </summary>
        public ReportFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Required if <code>Enabled</code> is set to <code>true</code>. Specifies the location
        /// of the report on the file system's linked S3 data repository. An absolute path that
        /// defines where the completion report will be stored in the destination location. The
        /// <code>Path</code> you provide must be located within the file system’s ExportPath.
        /// An example <code>Path</code> value is "s3://myBucket/myExportPath/optionalPrefix".
        /// The report provides the following information for each file in the report: FilePath,
        /// FileStatus, and ErrorCode.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=4357)]
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Required if <code>Enabled</code> is set to <code>true</code>. Specifies the scope
        /// of the <code>CompletionReport</code>; <code>FAILED_FILES_ONLY</code> is the only scope
        /// currently supported. When <code>Scope</code> is set to <code>FAILED_FILES_ONLY</code>,
        /// the <code>CompletionReport</code> only contains information about files that the data
        /// repository task failed to process.
        /// </para>
        /// </summary>
        public ReportScope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}