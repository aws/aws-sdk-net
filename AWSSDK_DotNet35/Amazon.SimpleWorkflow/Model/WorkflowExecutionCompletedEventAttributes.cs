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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Provides details of the <c>WorkflowExecutionCompleted</c> event. </para>
    /// </summary>
    public class WorkflowExecutionCompletedEventAttributes
    {
        
        private string result;
        private long? decisionTaskCompletedEventId;

        /// <summary>
        /// The result produced by the workflow execution upon successful completion.
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
        public string Result
        {
            get { return this.result; }
            set { this.result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this.result != null;
        }

        /// <summary>
        /// The id of the <c>DecisionTaskCompleted</c> event corresponding to the decision task that resulted in the <c>CompleteWorkflowExecution</c>
        /// decision to complete this execution. This information can be useful for diagnosing problems by tracing back the cause of events.
        ///  
        /// </summary>
        public long DecisionTaskCompletedEventId
        {
            get { return this.decisionTaskCompletedEventId ?? default(long); }
            set { this.decisionTaskCompletedEventId = value; }
        }

        // Check to see if DecisionTaskCompletedEventId property is set
        internal bool IsSetDecisionTaskCompletedEventId()
        {
            return this.decisionTaskCompletedEventId.HasValue;
        }
    }
}
