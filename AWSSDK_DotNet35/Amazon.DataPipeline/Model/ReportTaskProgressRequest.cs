/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the ReportTaskProgress operation.
    /// Updates the AWS Data Pipeline service on the progress of the calling task runner.
    /// When the task runner is assigned a task, it should call ReportTaskProgress to acknowledge
    /// that it has the task within 2 minutes. If the web service does not recieve this acknowledgement
    /// within the 2 minute window, it will assign the task in a subsequent <a>PollForTask</a>
    /// call. After this initial acknowledgement, the task runner only needs to report progress
    /// every 15 minutes to maintain its ownership of the task. You can change this reporting
    /// time from 15 minutes by specifying a <code>reportProgressTimeout</code> field in your
    /// pipeline. If a task runner does not report its status after 5 minutes, AWS Data Pipeline
    /// will assume that the task runner is unable to process the task and will reassign the
    /// task in a subsequent response to <a>PollForTask</a>. task runners should call <a>ReportTaskProgress</a>
    /// every 60 seconds.
    /// </summary>
    public partial class ReportTaskProgressRequest : AmazonDataPipelineRequest
    {
        private string _taskId;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// Identifier of the task assigned to the task runner. This value is provided in the
        /// <a>TaskObject</a> that the service returns with the response for the <a>PollForTask</a>
        /// action.
        /// </para>
        /// </summary>
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

    }
}