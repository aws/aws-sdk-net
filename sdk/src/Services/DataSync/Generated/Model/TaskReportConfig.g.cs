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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Specifies how you want to configure a task report, which provides detailed information
    /// about for your DataSync transfer.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-reports.html">Task
    /// reports</a>.
    /// </para>
    /// </summary>
    public partial class TaskReportConfig
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// Specifies the Amazon S3 bucket where DataSync uploads your task report. For more information,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-reports.html#task-report-access">Task
        /// reports</a>.
        /// </para>
        /// </summary>
        public ReportDestination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property ObjectVersionIds. 
        /// <para>
        /// Specifies whether your task report includes the new version of each object transferred
        /// into an S3 bucket. This only applies if you <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/manage-versioning-examples.html">enable
        /// versioning on your bucket</a>. Keep in mind that setting this to <c>INCLUDE</c> can
        /// increase the duration of your task execution.
        /// </para>
        /// </summary>
        public ObjectVersionIds ObjectVersionIds { get; set; }

        /// <summary>
        /// Checks to see if the ObjectVersionIds property is set.
        /// </summary>
        internal bool IsSetObjectVersionIds() => this.ObjectVersionIds != null;

        /// <summary>
        /// Gets and sets the property OutputType. 
        /// <para>
        /// Specifies the type of task report that you want:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUMMARY_ONLY</c>: Provides necessary details about your task, including the number
        /// of files, objects, and directories transferred and transfer duration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STANDARD</c>: Provides complete details about your task, including a full list
        /// of files, objects, and directories that were transferred, skipped, verified, and more.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReportOutputType OutputType { get; set; }

        /// <summary>
        /// Checks to see if the OutputType property is set.
        /// </summary>
        internal bool IsSetOutputType() => this.OutputType != null;

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// Customizes the reporting level for aspects of your task report. For example, your
        /// report might generally only include errors, but you could specify that you want a
        /// list of successes and errors just for the files that DataSync attempted to delete
        /// in your destination location.
        /// </para>
        /// </summary>
        public ReportOverrides Overrides { get; set; }

        /// <summary>
        /// Checks to see if the Overrides property is set.
        /// </summary>
        internal bool IsSetOverrides() => this.Overrides != null;

        /// <summary>
        /// Gets and sets the property ReportLevel. 
        /// <para>
        /// Specifies whether you want your task report to include only what went wrong with your
        /// transfer or a list of what succeeded and didn't.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ERRORS_ONLY</c>: A report shows what DataSync was unable to transfer, skip, verify,
        /// and delete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESSES_AND_ERRORS</c>: A report shows what DataSync was able and unable to
        /// transfer, skip, verify, and delete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReportLevel ReportLevel { get; set; }

        /// <summary>
        /// Checks to see if the ReportLevel property is set.
        /// </summary>
        internal bool IsSetReportLevel() => this.ReportLevel != null;
    }
}
