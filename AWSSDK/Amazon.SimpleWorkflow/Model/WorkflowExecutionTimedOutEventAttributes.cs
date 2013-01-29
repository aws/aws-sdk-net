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
    /// <para> Provides details of the <c>WorkflowExecutionTimedOut</c> event. </para>
    /// </summary>
    public class WorkflowExecutionTimedOutEventAttributes
    {
        
        private string timeoutType;
        private string childPolicy;

        /// <summary>
        /// The type of timeout that caused this event.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>START_TO_CLOSE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TimeoutType
        {
            get { return this.timeoutType; }
            set { this.timeoutType = value; }
        }

        /// <summary>
        /// Sets the TimeoutType property
        /// </summary>
        /// <param name="timeoutType">The value to set for the TimeoutType property </param>
        /// <returns>this instance</returns>
        public WorkflowExecutionTimedOutEventAttributes WithTimeoutType(string timeoutType)
        {
            this.timeoutType = timeoutType;
            return this;
        }
            

        // Check to see if TimeoutType property is set
        internal bool IsSetTimeoutType()
        {
            return this.timeoutType != null;
        }

        /// <summary>
        /// The policy used for the child workflow executions of this workflow execution. The supported child policies are: <ul> <li><b>TERMINATE:</b>
        /// the child executions will be terminated.</li> <li><b>REQUEST_CANCEL:</b> a request to cancel will be attempted for each child execution by
        /// recording a <c>WorkflowExecutionCancelRequested</c> event in its history. It is up to the decider to take appropriate actions when it
        /// receives an execution history with this event. </li> <li><b>ABANDON:</b> no action will be taken. The child executions will continue to
        /// run.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>TERMINATE, REQUEST_CANCEL, ABANDON</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ChildPolicy
        {
            get { return this.childPolicy; }
            set { this.childPolicy = value; }
        }

        /// <summary>
        /// Sets the ChildPolicy property
        /// </summary>
        /// <param name="childPolicy">The value to set for the ChildPolicy property </param>
        /// <returns>this instance</returns>
        public WorkflowExecutionTimedOutEventAttributes WithChildPolicy(string childPolicy)
        {
            this.childPolicy = childPolicy;
            return this;
        }
            

        // Check to see if ChildPolicy property is set
        internal bool IsSetChildPolicy()
        {
            return this.childPolicy != null;
        }
    }
}
