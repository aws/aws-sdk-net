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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Represents an export task.
    /// </summary>
    public partial class ExportTask
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The name of the S3 bucket to which the log data was exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property DestinationPrefix. 
        /// <para>
        /// The prefix that was used as the start of Amazon S3 key for every object exported.
        /// </para>
        /// </summary>
        public string DestinationPrefix { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPrefix property is set.
        /// </summary>
        internal bool IsSetDestinationPrefix() => this.DestinationPrefix != null;

        /// <summary>
        /// Gets and sets the property ExecutionInfo. 
        /// <para>
        /// Execution information about the export task.
        /// </para>
        /// </summary>
        public ExportTaskExecutionInfo ExecutionInfo { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionInfo property is set.
        /// </summary>
        internal bool IsSetExecutionInfo() => this.ExecutionInfo != null;

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The start time, expressed as the number of milliseconds after <c>Jan 1, 1970 00:00:00
        /// UTC</c>. Events with a timestamp before this time are not exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? From { get; set; }

        /// <summary>
        /// Checks to see if the From property is set.
        /// </summary>
        internal bool IsSetFrom() => this.From.HasValue;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group from which logs data was exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the export task.
        /// </para>
        /// </summary>
        public ExportTaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The ID of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property TaskName. 
        /// <para>
        /// The name of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string TaskName { get; set; }

        /// <summary>
        /// Checks to see if the TaskName property is set.
        /// </summary>
        internal bool IsSetTaskName() => this.TaskName != null;

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The end time, expressed as the number of milliseconds after <c>Jan 1, 1970 00:00:00
        /// UTC</c>. Events with a timestamp later than this time are not exported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? To { get; set; }

        /// <summary>
        /// Checks to see if the To property is set.
        /// </summary>
        internal bool IsSetTo() => this.To.HasValue;
    }
}
