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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// This is the response object from the ListWorkflowExecutions operation.
    /// </summary>
    public partial class ListWorkflowExecutionsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ImageBuildVersionArn. 
        /// <para>
        /// The resource Amazon Resource Name (ARN) of the image build version for which you requested
        /// a list of workflow runtime details.
        /// </para>
        /// </summary>
        public string ImageBuildVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageBuildVersionArn property is set.
        /// </summary>
        internal bool IsSetImageBuildVersionArn() => this.ImageBuildVersionArn != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The failure reason for the image build version, if it's in a failed state. This comes
        /// from the image itself, not from an individual workflow, so it's available even when
        /// no workflow executions remain for the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token used for paginated responses. When this field isn't empty, there are
        /// additional elements that the service hasn't included in this request. Use this token
        /// with the next request to retrieve additional objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The request ID that uniquely identifies this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecutions. 
        /// <para>
        /// An array of runtime details that represents each time a workflow ran for the requested
        /// image build version. Image Builder retains workflow execution records for a limited
        /// time, so this array can be empty for older image build versions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WorkflowExecutionMetadata> WorkflowExecutions { get; set; } = AWSConfigs.InitializeCollections ? new List<WorkflowExecutionMetadata>() : null;

        /// <summary>
        /// Checks to see if the WorkflowExecutions property is set.
        /// </summary>
        internal bool IsSetWorkflowExecutions() => this.WorkflowExecutions != null && (this.WorkflowExecutions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
