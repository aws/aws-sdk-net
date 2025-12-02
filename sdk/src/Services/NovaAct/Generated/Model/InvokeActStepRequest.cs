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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
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
namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeActStep operation.
    /// Executes the next step of an act, processing tool call results and returning new tool
    /// calls if needed.
    /// </summary>
    public partial class InvokeActStepRequest : AmazonNovaActRequest
    {
        private string _actId;
        private List<CallResult> _callResults = AWSConfigs.InitializeCollections ? new List<CallResult>() : null;
        private string _previousStepId;
        private string _sessionId;
        private string _workflowDefinitionName;
        private string _workflowRunId;

        /// <summary>
        /// Gets and sets the property ActId. 
        /// <para>
        /// The unique identifier of the act to invoke the next step for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActId
        {
            get { return this._actId; }
            set { this._actId = value; }
        }

        // Check to see if ActId property is set
        internal bool IsSetActId()
        {
            return this._actId != null;
        }

        /// <summary>
        /// Gets and sets the property CallResults. 
        /// <para>
        /// The results from previous tool calls that the act requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<CallResult> CallResults
        {
            get { return this._callResults; }
            set { this._callResults = value; }
        }

        // Check to see if CallResults property is set
        internal bool IsSetCallResults()
        {
            return this._callResults != null && (this._callResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PreviousStepId. 
        /// <para>
        /// The identifier of the previous step, used for tracking execution flow.
        /// </para>
        /// </summary>
        public string PreviousStepId
        {
            get { return this._previousStepId; }
            set { this._previousStepId = value; }
        }

        // Check to see if PreviousStepId property is set
        internal bool IsSetPreviousStepId()
        {
            return this._previousStepId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session containing the act.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowDefinitionName. 
        /// <para>
        /// The name of the workflow definition containing the act.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string WorkflowDefinitionName
        {
            get { return this._workflowDefinitionName; }
            set { this._workflowDefinitionName = value; }
        }

        // Check to see if WorkflowDefinitionName property is set
        internal bool IsSetWorkflowDefinitionName()
        {
            return this._workflowDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowRunId. 
        /// <para>
        /// The unique identifier of the workflow run containing the act.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkflowRunId
        {
            get { return this._workflowRunId; }
            set { this._workflowRunId = value; }
        }

        // Check to see if WorkflowRunId property is set
        internal bool IsSetWorkflowRunId()
        {
            return this._workflowRunId != null;
        }

    }
}