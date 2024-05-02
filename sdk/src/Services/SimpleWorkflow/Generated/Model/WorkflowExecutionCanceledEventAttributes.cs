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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
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
    /// Provides the details of the <c>WorkflowExecutionCanceled</c> event.
    /// </summary>
    public partial class WorkflowExecutionCanceledEventAttributes
    {
        private long? _decisionTaskCompletedEventId;
        private string _details;

        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        /// The ID of the <c>DecisionTaskCompleted</c> event corresponding to the decision task
        /// that resulted in the <c>CancelWorkflowExecution</c> decision for this cancellation
        /// request. This information can be useful for diagnosing problems by tracing back the
        /// chain of events leading up to this event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? DecisionTaskCompletedEventId
        {
            get { return this._decisionTaskCompletedEventId; }
            set { this._decisionTaskCompletedEventId = value; }
        }

        // Check to see if DecisionTaskCompletedEventId property is set
        internal bool IsSetDecisionTaskCompletedEventId()
        {
            return this._decisionTaskCompletedEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// The details of the cancellation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

    }
}