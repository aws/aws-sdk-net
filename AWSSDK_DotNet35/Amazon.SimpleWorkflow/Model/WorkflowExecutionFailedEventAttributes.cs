/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Provides details of the <code>WorkflowExecutionFailed</code> event.
    /// </summary>
    public partial class WorkflowExecutionFailedEventAttributes
    {
        private long? _decisionTaskCompletedEventId;
        private string _details;
        private string _reason;

        /// <summary>
        /// Gets and sets the property DecisionTaskCompletedEventId. 
        /// <para>
        ///  The id of the <code>DecisionTaskCompleted</code> event corresponding to the decision
        /// task that resulted in the <code>FailWorkflowExecution</code> decision to fail this
        /// execution. This information can be useful for diagnosing problems by tracing back
        /// the cause of events. 
        /// </para>
        /// </summary>
        public long DecisionTaskCompletedEventId
        {
            get { return this._decisionTaskCompletedEventId.GetValueOrDefault(); }
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
        ///  The details of the failure (if any). 
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        ///  The descriptive reason provided for the failure (if any). 
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}