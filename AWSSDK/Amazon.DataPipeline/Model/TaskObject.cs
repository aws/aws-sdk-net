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

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// <para>Contains information about a pipeline task that is assigned to a task runner.</para>
    /// </summary>
    public class TaskObject
    {
        
        private string taskId;
        private string pipelineId;
        private string attemptId;
        private Dictionary<string,PipelineObject> objects = new Dictionary<string,PipelineObject>();

        /// <summary>
        /// An internal identifier for the task. This ID is passed to the <a>SetTaskStatus</a> and <a>ReportTaskProgress</a> actions.
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
        public TaskObject WithTaskId(string taskId)
        {
            this.taskId = taskId;
            return this;
        }
            

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this.taskId != null;
        }

        /// <summary>
        /// Identifier of the pipeline that provided the task.
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
        public string PipelineId
        {
            get { return this.pipelineId; }
            set { this.pipelineId = value; }
        }

        /// <summary>
        /// Sets the PipelineId property
        /// </summary>
        /// <param name="pipelineId">The value to set for the PipelineId property </param>
        /// <returns>this instance</returns>
        public TaskObject WithPipelineId(string pipelineId)
        {
            this.pipelineId = pipelineId;
            return this;
        }
            

        // Check to see if PipelineId property is set
        internal bool IsSetPipelineId()
        {
            return this.pipelineId != null;
        }

        /// <summary>
        /// Identifier of the pipeline task attempt object. AWS Data Pipeline uses this value to track how many times a task is attempted.
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
        public string AttemptId
        {
            get { return this.attemptId; }
            set { this.attemptId = value; }
        }

        /// <summary>
        /// Sets the AttemptId property
        /// </summary>
        /// <param name="attemptId">The value to set for the AttemptId property </param>
        /// <returns>this instance</returns>
        public TaskObject WithAttemptId(string attemptId)
        {
            this.attemptId = attemptId;
            return this;
        }
            

        // Check to see if AttemptId property is set
        internal bool IsSetAttemptId()
        {
            return this.attemptId != null;
        }

        /// <summary>
        /// Connection information for the location where the task runner will publish the output of the task.
        ///  
        /// </summary>
        public Dictionary<string,PipelineObject> Objects
        {
            get { return this.objects; }
            set { this.objects = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Objects dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Objects dictionary.</param>
        /// <returns>this instance</returns>
        public TaskObject WithObjects(params KeyValuePair<string, PipelineObject>[] pairs)
        {
            foreach (KeyValuePair<string, PipelineObject> pair in pairs)
            {
                this.Objects[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if Objects property is set
        internal bool IsSetObjects()
        {
            return this.objects != null;
        }
    }
}
