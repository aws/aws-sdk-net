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
    /// <para> A structure that represents a decision task. Decision tasks are sent to deciders in order for them to make decisions. </para>
    /// </summary>
    public partial class DecisionTask : AmazonWebServiceResponse
    {
        
        private string taskToken;
        private long? startedEventId;
        private WorkflowExecution workflowExecution;
        private WorkflowType workflowType;
        private List<HistoryEvent> events = new List<HistoryEvent>();
        private string nextPageToken;
        private long? previousStartedEventId;

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
        /// The id of the <c>DecisionTaskStarted</c> event recorded in the history.
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
        /// The workflow execution for which this decision task was created.
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
        /// The type of the workflow execution for which this decision task was created.
        ///  
        /// </summary>
        public WorkflowType WorkflowType
        {
            get { return this.workflowType; }
            set { this.workflowType = value; }
        }

        // Check to see if WorkflowType property is set
        internal bool IsSetWorkflowType()
        {
            return this.workflowType != null;
        }

        /// <summary>
        /// A paginated list of history events of the workflow execution. The decider uses this during the processing of the decision task.
        ///  
        /// </summary>
        public List<HistoryEvent> Events
        {
            get { return this.events; }
            set { this.events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this.events.Count > 0;
        }

        /// <summary>
        /// Returns a value if the results are paginated. To get the next page of results, repeat the request specifying this token and all other
        /// arguments unchanged.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this.nextPageToken; }
            set { this.nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this.nextPageToken != null;
        }

        /// <summary>
        /// The id of the DecisionTaskStarted event of the previous decision task of this workflow execution that was processed by the decider. This can
        /// be used to determine the events in the history new since the last decision task received by the decider.
        ///  
        /// </summary>
        public long PreviousStartedEventId
        {
            get { return this.previousStartedEventId ?? default(long); }
            set { this.previousStartedEventId = value; }
        }

        // Check to see if PreviousStartedEventId property is set
        internal bool IsSetPreviousStartedEventId()
        {
            return this.previousStartedEventId.HasValue;
        }
    }
}
