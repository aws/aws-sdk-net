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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
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
namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// Container for the parameters to the SetTaskStatus operation.
    /// Task runners call <c>SetTaskStatus</c> to notify AWS Data Pipeline that a task is
    /// completed and provide information about the final status. A task runner makes this
    /// call regardless of whether the task was sucessful. A task runner does not need to
    /// call <c>SetTaskStatus</c> for tasks that are canceled by the web service during a
    /// call to <a>ReportTaskProgress</a>.
    /// </summary>
    public partial class SetTaskStatusRequest : AmazonDataPipelineRequest
    {
        private string _errorId;
        private string _errorMessage;
        private string _errorStackTrace;
        private string _taskId;
        private TaskStatus _taskStatus;

        /// <summary>
        /// Gets and sets the property ErrorId. 
        /// <para>
        /// If an error occurred during the task, this value specifies the error code. This value
        /// is set on the physical attempt object. It is used to display error information to
        /// the user. It should not start with string "Service_" which is reserved by the system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ErrorId
        {
            get { return this._errorId; }
            set { this._errorId = value; }
        }

        // Check to see if ErrorId property is set
        internal bool IsSetErrorId()
        {
            return this._errorId != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// If an error occurred during the task, this value specifies a text description of the
        /// error. This value is set on the physical attempt object. It is used to display error
        /// information to the user. The web service does not parse this value.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorStackTrace. 
        /// <para>
        /// If an error occurred during the task, this value specifies the stack trace associated
        /// with the error. This value is set on the physical attempt object. It is used to display
        /// error information to the user. The web service does not parse this value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ErrorStackTrace
        {
            get { return this._errorStackTrace; }
            set { this._errorStackTrace = value; }
        }

        // Check to see if ErrorStackTrace property is set
        internal bool IsSetErrorStackTrace()
        {
            return this._errorStackTrace != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The ID of the task assigned to the task runner. This value is provided in the response
        /// for <a>PollForTask</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// If <c>FINISHED</c>, the task successfully completed. If <c>FAILED</c>, the task ended
        /// unsuccessfully. Preconditions use false.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaskStatus TaskStatus
        {
            get { return this._taskStatus; }
            set { this._taskStatus = value; }
        }

        // Check to see if TaskStatus property is set
        internal bool IsSetTaskStatus()
        {
            return this._taskStatus != null;
        }

    }
}