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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// This is the response object from the ListWorkflowStepExecutions operation.
    /// </summary>
    public partial class ListWorkflowStepExecutionsResponse : AmazonWebServiceResponse
    {
        private string _imageBuildVersionArn;
        private string _message;
        private string _nextToken;
        private string _requestId;
        private List<WorkflowStepMetadata> _steps = new List<WorkflowStepMetadata>();
        private string _workflowBuildVersionArn;
        private string _workflowExecutionId;

        /// <summary>
        /// Gets and sets the property ImageBuildVersionArn. 
        /// <para>
        /// The image build version resource ARN that's associated with the specified runtime
        /// instance of the workflow.
        /// </para>
        /// </summary>
        public string ImageBuildVersionArn
        {
            get { return this._imageBuildVersionArn; }
            set { this._imageBuildVersionArn = value; }
        }

        // Check to see if ImageBuildVersionArn property is set
        internal bool IsSetImageBuildVersionArn()
        {
            return this._imageBuildVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The output message from the list action, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token used for paginated responses. When this field isn't empty, there are
        /// additional elements that the service has'ot included in this request. Use this token
        /// with the next request to retrieve additional objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The request ID that uniquely identifies this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// Contains an array of runtime details that represents each step in this runtime instance
        /// of the workflow.
        /// </para>
        /// </summary>
        public List<WorkflowStepMetadata> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && this._steps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkflowBuildVersionArn. 
        /// <para>
        /// The build version ARN for the Image Builder workflow resource that defines the steps
        /// for this runtime instance of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string WorkflowBuildVersionArn
        {
            get { return this._workflowBuildVersionArn; }
            set { this._workflowBuildVersionArn = value; }
        }

        // Check to see if WorkflowBuildVersionArn property is set
        internal bool IsSetWorkflowBuildVersionArn()
        {
            return this._workflowBuildVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkflowExecutionId. 
        /// <para>
        /// The unique identifier that Image Builder assigned to keep track of runtime details
        /// when it ran the workflow.
        /// </para>
        /// </summary>
        public string WorkflowExecutionId
        {
            get { return this._workflowExecutionId; }
            set { this._workflowExecutionId = value; }
        }

        // Check to see if WorkflowExecutionId property is set
        internal bool IsSetWorkflowExecutionId()
        {
            return this._workflowExecutionId != null;
        }

    }
}