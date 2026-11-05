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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides the details of the <c>WorkflowExecutionTimedOut</c> event.
    /// </summary>
    public partial class WorkflowExecutionTimedOutEventAttributes
    {
        /// <summary>
        /// Gets and sets the property ChildPolicy. 
        /// <para>
        /// The policy used for the child workflow executions of this workflow execution.
        /// </para>
        ///  
        /// <para>
        /// The supported child policies are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TERMINATE</c> – The child executions are terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REQUEST_CANCEL</c> – A request to cancel is attempted for each child execution
        /// by recording a <c>WorkflowExecutionCancelRequested</c> event in its history. It is
        /// up to the decider to take appropriate actions when it receives an execution history
        /// with this event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ABANDON</c> – No action is taken. The child executions continue to run.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChildPolicy ChildPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ChildPolicy property is set.
        /// </summary>
        internal bool IsSetChildPolicy() => this.ChildPolicy != null;

        /// <summary>
        /// Gets and sets the property TimeoutType. 
        /// <para>
        /// The type of timeout that caused this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowExecutionTimeoutType TimeoutType { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutType property is set.
        /// </summary>
        internal bool IsSetTimeoutType() => this.TimeoutType != null;
    }
}
