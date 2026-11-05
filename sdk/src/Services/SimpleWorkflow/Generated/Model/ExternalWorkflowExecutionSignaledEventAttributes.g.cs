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
    /// Provides the details of the <c>ExternalWorkflowExecutionSignaled</c> event.
    /// </summary>
    public partial class ExternalWorkflowExecutionSignaledEventAttributes
    {
        /// <summary>
        /// Gets and sets the property InitiatedEventId. 
        /// <para>
        /// The ID of the <c>SignalExternalWorkflowExecutionInitiated</c> event corresponding
        /// to the <c>SignalExternalWorkflowExecution</c> decision to request this signal. This
        /// information can be useful for diagnosing problems by tracing back the chain of events
        /// leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? InitiatedEventId { get; set; }

        /// <summary>
        /// Checks to see if the InitiatedEventId property is set.
        /// </summary>
        internal bool IsSetInitiatedEventId() => this.InitiatedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property WorkflowExecution. 
        /// <para>
        /// The external workflow execution that the signal was delivered to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowExecution WorkflowExecution { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecution property is set.
        /// </summary>
        internal bool IsSetWorkflowExecution() => this.WorkflowExecution != null;
    }
}
