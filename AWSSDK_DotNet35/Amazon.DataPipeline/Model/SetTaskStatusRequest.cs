/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the SetTaskStatus operation.
    /// <para> Notifies AWS Data Pipeline that a task is completed and provides information about the final status. The task runner calls this
    /// action regardless of whether the task was sucessful. The task runner does not need to call SetTaskStatus for tasks that are canceled by the
    /// web service during a call to ReportTaskProgress. </para>
    /// </summary>
    public partial class SetTaskStatusRequest : AmazonWebServiceRequest
    {
        private string taskId;
        private TaskStatus taskStatus;
        private string errorId;
        private string errorMessage;
        private string errorStackTrace;

        /// <summary>
        /// Identifies the task assigned to the task runner. This value is set in the <a>TaskObject</a> that is returned by the <a>PollForTask</a>
        /// action.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 2048</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TaskId
        {
            get { return this.taskId; }
            set { this.taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this.taskId != null;
        }

        /// <summary>
        /// If <c>FINISHED</c>, the task successfully completed. If <c>FAILED</c> the task ended unsuccessfully. The <c>FALSE</c> value is used by
        /// preconditions.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>FINISHED, FAILED, FALSE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public TaskStatus TaskStatus
        {
            get { return this.taskStatus; }
            set { this.taskStatus = value; }
        }

        // Check to see if TaskStatus property is set
        internal bool IsSetTaskStatus()
        {
            return this.taskStatus != null;
        }

        /// <summary>
        /// If an error occurred during the task, this value specifies an id value that represents the error. This value is set on the physical attempt
        /// object. It is used to display error information to the user. It should not start with string "Service_" which is reserved by the system.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ErrorId
        {
            get { return this.errorId; }
            set { this.errorId = value; }
        }

        // Check to see if ErrorId property is set
        internal bool IsSetErrorId()
        {
            return this.errorId != null;
        }

        /// <summary>
        /// If an error occurred during the task, this value specifies a text description of the error. This value is set on the physical attempt
        /// object. It is used to display error information to the user. The web service does not parse this value.
        ///  
        /// </summary>
        public string ErrorMessage
        {
            get { return this.errorMessage; }
            set { this.errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this.errorMessage != null;
        }

        /// <summary>
        /// If an error occurred during the task, this value specifies the stack trace associated with the error. This value is set on the physical
        /// attempt object. It is used to display error information to the user. The web service does not parse this value.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ErrorStackTrace
        {
            get { return this.errorStackTrace; }
            set { this.errorStackTrace = value; }
        }

        // Check to see if ErrorStackTrace property is set
        internal bool IsSetErrorStackTrace()
        {
            return this.errorStackTrace != null;
        }

    }
}
    
