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
    /// Container for the parameters to the ReportTaskRunnerHeartbeat operation.
    /// <para>Task runners call ReportTaskRunnerHeartbeat to indicate that they are operational. In the case of AWS Data Pipeline Task Runner
    /// launched on a resource managed by AWS Data Pipeline, the web service can use this call to detect when the task runner application has failed
    /// and restart a new instance.</para>
    /// </summary>
    /// <seealso cref="Amazon.DataPipeline.AmazonDataPipeline.ReportTaskRunnerHeartbeat"/>
    public class ReportTaskRunnerHeartbeatRequest : AmazonWebServiceRequest
    {
        private string taskrunnerId;
        private string workerGroup;
        private string hostname;

        /// <summary>
        /// The identifier of the task runner. This value should be unique across your AWS account. In the case of AWS Data Pipeline Task Runner
        /// launched on a resource managed by AWS Data Pipeline, the web service provides a unique identifier when it launches the application. If you
        /// have written a custom task runner, you should assign a unique identifier for the task runner.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TaskrunnerId
        {
            get { return this.taskrunnerId; }
            set { this.taskrunnerId = value; }
        }

        /// <summary>
        /// Sets the TaskrunnerId property
        /// </summary>
        /// <param name="taskrunnerId">The value to set for the TaskrunnerId property </param>
        /// <returns>this instance</returns>
        public ReportTaskRunnerHeartbeatRequest WithTaskrunnerId(string taskrunnerId)
        {
            this.taskrunnerId = taskrunnerId;
            return this;
        }
            

        // Check to see if TaskrunnerId property is set
        internal bool IsSetTaskrunnerId()
        {
            return this.taskrunnerId != null;
        }

        /// <summary>
        /// Indicates the type of task the task runner is configured to accept and process. The worker group is set as a field on objects in the
        /// pipeline when they are created. You can only specify a single value for workerGroup in the call to ReportTaskRunnerHeartbeat. There are no
        /// wildcard values permitted in workerGroup, the string must be an exact, case-sensitive, match.
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
        public string WorkerGroup
        {
            get { return this.workerGroup; }
            set { this.workerGroup = value; }
        }

        /// <summary>
        /// Sets the WorkerGroup property
        /// </summary>
        /// <param name="workerGroup">The value to set for the WorkerGroup property </param>
        /// <returns>this instance</returns>
        public ReportTaskRunnerHeartbeatRequest WithWorkerGroup(string workerGroup)
        {
            this.workerGroup = workerGroup;
            return this;
        }
            

        // Check to see if WorkerGroup property is set
        internal bool IsSetWorkerGroup()
        {
            return this.workerGroup != null;
        }

        /// <summary>
        /// The public DNS name of the calling task runner.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Hostname
        {
            get { return this.hostname; }
            set { this.hostname = value; }
        }

        /// <summary>
        /// Sets the Hostname property
        /// </summary>
        /// <param name="hostname">The value to set for the Hostname property </param>
        /// <returns>this instance</returns>
        public ReportTaskRunnerHeartbeatRequest WithHostname(string hostname)
        {
            this.hostname = hostname;
            return this;
        }
            

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this.hostname != null;
        }
    }
}
    
