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
    /// Container for the parameters to the CreateAct operation.
    /// Creates a new AI task (act) within a session that can interact with tools and perform
    /// specific actions.
    /// </summary>
    public partial class CreateActRequest : AmazonNovaActRequest
    {
        private string _clientToken;
        private string _sessionId;
        private string _task;
        private List<ToolSpec> _toolSpecs = AWSConfigs.InitializeCollections ? new List<ToolSpec>() : null;
        private string _workflowDefinitionName;
        private string _workflowRunId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session to create the act in.
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
        /// Gets and sets the property Task. 
        /// <para>
        /// The task description that defines what the act should accomplish.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=10000)]
        public string Task
        {
            get { return this._task; }
            set { this._task = value; }
        }

        // Check to see if Task property is set
        internal bool IsSetTask()
        {
            return this._task != null;
        }

        /// <summary>
        /// Gets and sets the property ToolSpecs. 
        /// <para>
        /// A list of tool specifications that the act can invoke to complete its task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<ToolSpec> ToolSpecs
        {
            get { return this._toolSpecs; }
            set { this._toolSpecs = value; }
        }

        // Check to see if ToolSpecs property is set
        internal bool IsSetToolSpecs()
        {
            return this._toolSpecs != null && (this._toolSpecs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkflowDefinitionName. 
        /// <para>
        /// The name of the workflow definition containing the session.
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
        /// The unique identifier of the workflow run containing the session.
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