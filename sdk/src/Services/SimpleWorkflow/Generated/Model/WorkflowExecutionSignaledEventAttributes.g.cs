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
    /// Provides the details of the <c>WorkflowExecutionSignaled</c> event.
    /// </summary>
    public partial class WorkflowExecutionSignaledEventAttributes
    {
        /// <summary>
        /// Gets and sets the property ExternalInitiatedEventId. 
        /// <para>
        /// The ID of the <c>SignalExternalWorkflowExecutionInitiated</c> event corresponding
        /// to the <c>SignalExternalWorkflow</c> decision to signal this workflow execution.The
        /// source event with this ID can be found in the history of the source workflow execution.
        /// This information can be useful for diagnosing problems by tracing back the chain of
        /// events leading up to this event. This field is set only if the signal was initiated
        /// by another workflow execution.
        /// </para>
        /// </summary>
        public long? ExternalInitiatedEventId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalInitiatedEventId property is set.
        /// </summary>
        internal bool IsSetExternalInitiatedEventId() => this.ExternalInitiatedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property ExternalWorkflowExecution. 
        /// <para>
        /// The workflow execution that sent the signal. This is set only of the signal was sent
        /// by another workflow execution.
        /// </para>
        /// </summary>
        public WorkflowExecution ExternalWorkflowExecution { get; set; }

        /// <summary>
        /// Checks to see if the ExternalWorkflowExecution property is set.
        /// </summary>
        internal bool IsSetExternalWorkflowExecution() => this.ExternalWorkflowExecution != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The inputs provided with the signal. The decider can use the signal name and inputs
        /// to determine how to process the signal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property SignalName. 
        /// <para>
        /// The name of the signal received. The decider can use the signal name and inputs to
        /// determine how to the process the signal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string SignalName { get; set; }

        /// <summary>
        /// Checks to see if the SignalName property is set.
        /// </summary>
        internal bool IsSetSignalName() => this.SignalName != null;
    }
}
