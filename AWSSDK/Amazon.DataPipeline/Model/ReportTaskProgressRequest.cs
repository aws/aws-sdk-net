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
    /// Container for the parameters to the ReportTaskProgress operation.
    /// <para> Updates the AWS Data Pipeline service on the progress of the calling task runner. When the task runner is assigned a task, it should
    /// call ReportTaskProgress to acknowledge that it has the task within 2 minutes. If the web service does not recieve this acknowledgement
    /// within the 2 minute window, it will assign the task in a subsequent PollForTask call. After this initial acknowledgement, the task runner
    /// only needs to report progress every 15 minutes to maintain its ownership of the task. You can change this reporting time from 15 minutes by
    /// specifying a <c>reportProgressTimeout</c> field in your pipeline. If a task runner does not report its status after 5 minutes, AWS Data
    /// Pipeline will assume that the task runner is unable to process the task and will reassign the task in a subsequent response to PollForTask.
    /// task runners should call ReportTaskProgress every 60 seconds. </para>
    /// </summary>
    /// <seealso cref="Amazon.DataPipeline.AmazonDataPipeline.ReportTaskProgress"/>
    public class ReportTaskProgressRequest : AmazonWebServiceRequest
    {
        private string taskId;

        /// <summary>
        /// Identifier of the task assigned to the task runner. This value is provided in the <a>TaskObject</a> that the service returns with the
        /// response for the <a>PollForTask</a> action.
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

        /// <summary>
        /// Sets the TaskId property
        /// </summary>
        /// <param name="taskId">The value to set for the TaskId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReportTaskProgressRequest WithTaskId(string taskId)
        {
            this.taskId = taskId;
            return this;
        }
            

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this.taskId != null;
        }
    }
}
    
