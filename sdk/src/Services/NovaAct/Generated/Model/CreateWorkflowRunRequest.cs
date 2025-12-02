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
    /// Container for the parameters to the CreateWorkflowRun operation.
    /// Creates a new execution instance of a workflow definition with specified parameters.
    /// </summary>
    public partial class CreateWorkflowRunRequest : AmazonNovaActRequest
    {
        private ClientInfo _clientInfo;
        private string _clientToken;
        private string _logGroupName;
        private string _modelId;
        private string _workflowDefinitionName;

        /// <summary>
        /// Gets and sets the property ClientInfo. 
        /// <para>
        /// Information about the client making the request, including compatibility version and
        /// SDK version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClientInfo ClientInfo
        {
            get { return this._clientInfo; }
            set { this._clientInfo = value; }
        }

        // Check to see if ClientInfo property is set
        internal bool IsSetClientInfo()
        {
            return this._clientInfo != null;
        }

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
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The CloudWatch log group name for storing workflow execution logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The ID of the AI model to use for workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowDefinitionName. 
        /// <para>
        /// The name of the workflow definition to execute.
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

    }
}