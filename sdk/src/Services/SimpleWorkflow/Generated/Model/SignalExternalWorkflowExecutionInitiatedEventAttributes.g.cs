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
    /// Provides the details of the <c>SignalExternalWorkflowExecutionInitiated</c> event.
    /// </summary>
    public partial class SignalExternalWorkflowExecutionInitiatedEventAttributes
    {
        /// <summary>
        /// Gets and sets the property Control. 
        /// <para>
        /// Data attached to the event that can be used by the decider in subsequent decision
        /// tasks.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string Control { get; set; }

        /// <summary>
        /// Checks to see if the Control property is set.
        /// </summary>
        internal bool IsSetControl() => this.Control != null;

        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        /// The ID of the <c>DecisionTaskCompleted</c> event corresponding to the decision task
        /// that resulted in the <c>SignalExternalWorkflowExecution</c> decision for this signal.
        /// This information can be useful for diagnosing problems by tracing back the chain of
        /// events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? DecisionTaskCompletedEventId { get; set; }

        /// <summary>
        /// Checks to see if the DecisionTaskCompletedEventId property is set.
        /// </summary>
        internal bool IsSetDecisionTaskCompletedEventId() => this.DecisionTaskCompletedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The input provided to the signal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The <c>runId</c> of the external workflow execution to send the signal to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property SignalName. 
        /// <para>
        /// The name of the signal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string SignalName { get; set; }

        /// <summary>
        /// Checks to see if the SignalName property is set.
        /// </summary>
        internal bool IsSetSignalName() => this.SignalName != null;

        /// <summary>
        /// Gets and sets the property WorkflowId. 
        /// <para>
        /// The <c>workflowId</c> of the external workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowId property is set.
        /// </summary>
        internal bool IsSetWorkflowId() => this.WorkflowId != null;
    }
}
