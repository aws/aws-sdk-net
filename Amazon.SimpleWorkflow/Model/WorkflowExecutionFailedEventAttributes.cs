/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Provides details of the <c>WorkflowExecutionFailed</c> event. </para>
    /// </summary>
    public class WorkflowExecutionFailedEventAttributes  
    {
        
        private string reason;
        private string details;
        private long? decisionTaskCompletedEventId;

        /// <summary>
        /// The descriptive reason provided for the failure (if any).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this.reason; }
            set { this.reason = value; }
        }

        /// <summary>
        /// Sets the Reason property
        /// </summary>
        /// <param name="reason">The value to set for the Reason property </param>
        /// <returns>this instance</returns>
        public WorkflowExecutionFailedEventAttributes WithReason(string reason)
        {
            this.reason = reason;
            return this;
        }
            

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this.reason != null;       
        }

        /// <summary>
        /// The details of the failure (if any).
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
        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        /// <summary>
        /// Sets the Details property
        /// </summary>
        /// <param name="details">The value to set for the Details property </param>
        /// <returns>this instance</returns>
        public WorkflowExecutionFailedEventAttributes WithDetails(string details)
        {
            this.details = details;
            return this;
        }
            

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this.details != null;       
        }

        /// <summary>
        /// The id of the <c>DecisionTaskCompleted</c> event corresponding to the decision task that resulted in the <c>FailWorkflowExecution</c>
        /// decision to fail this execution. This information can be useful for diagnosing problems by tracing back the cause of events.
        ///  
        /// </summary>
        public long DecisionTaskCompletedEventId
        {
            get { return this.decisionTaskCompletedEventId ?? default(long); }
            set { this.decisionTaskCompletedEventId = value; }
        }

        /// <summary>
        /// Sets the DecisionTaskCompletedEventId property
        /// </summary>
        /// <param name="decisionTaskCompletedEventId">The value to set for the DecisionTaskCompletedEventId property </param>
        /// <returns>this instance</returns>
        public WorkflowExecutionFailedEventAttributes WithDecisionTaskCompletedEventId(long decisionTaskCompletedEventId)
        {
            this.decisionTaskCompletedEventId = decisionTaskCompletedEventId;
            return this;
        }
            

        // Check to see if DecisionTaskCompletedEventId property is set
        internal bool IsSetDecisionTaskCompletedEventId()
        {
            return this.decisionTaskCompletedEventId.HasValue;       
        }
    }
}
