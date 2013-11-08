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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Unit of work sent to an activity worker. </para>
    /// </summary>
    public partial class ActivityTask : AmazonWebServiceResponse
    {
        
        private string taskToken;
        private string activityId;
        private long? startedEventId;
        private WorkflowExecution workflowExecution;
        private ActivityType activityType;
        private string input;

        /// <summary>
        /// The opaque string used as a handle on the task. This token is used by workers to communicate progress and response information back to the
        /// system about the task.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1024</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TaskToken
        {
            get { return this.taskToken; }
            set { this.taskToken = value; }
        }

        // Check to see if TaskToken property is set
        internal bool IsSetTaskToken()
        {
            return this.taskToken != null;
        }

        /// <summary>
        /// The unique ID of the task.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ActivityId
        {
            get { return this.activityId; }
            set { this.activityId = value; }
        }

        // Check to see if ActivityId property is set
        internal bool IsSetActivityId()
        {
            return this.activityId != null;
        }

        /// <summary>
        /// The id of the <c>ActivityTaskStarted</c> event recorded in the history.
        ///  
        /// </summary>
        public long StartedEventId
        {
            get { return this.startedEventId ?? default(long); }
            set { this.startedEventId = value; }
        }

        // Check to see if StartedEventId property is set
        internal bool IsSetStartedEventId()
        {
            return this.startedEventId.HasValue;
        }

        /// <summary>
        /// The workflow execution that started this activity task.
        ///  
        /// </summary>
        public WorkflowExecution WorkflowExecution
        {
            get { return this.workflowExecution; }
            set { this.workflowExecution = value; }
        }

        // Check to see if WorkflowExecution property is set
        internal bool IsSetWorkflowExecution()
        {
            return this.workflowExecution != null;
        }

        /// <summary>
        /// The type of this activity task.
        ///  
        /// </summary>
        public ActivityType ActivityType
        {
            get { return this.activityType; }
            set { this.activityType = value; }
        }

        // Check to see if ActivityType property is set
        internal bool IsSetActivityType()
        {
            return this.activityType != null;
        }

        /// <summary>
        /// The inputs provided when the activity task was scheduled. The form of the input is user defined and should be meaningful to the activity
        /// implementation.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 32768</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Input
        {
            get { return this.input; }
            set { this.input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this.input != null;
        }
    }
}
