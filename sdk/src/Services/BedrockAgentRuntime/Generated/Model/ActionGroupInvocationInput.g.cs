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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information about the action group being invoked. For more information about
    /// the possible structures, see the InvocationInput tab in <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/trace-orchestration.html">OrchestrationTrace</a>
    /// in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
    /// Bedrock User Guide</a>.
    /// </summary>
    public partial class ActionGroupInvocationInput
    {
        /// <summary>
        /// Gets and sets the property ActionGroupName. 
        /// <para>
        /// The name of the action group.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ActionGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ActionGroupName property is set.
        /// </summary>
        internal bool IsSetActionGroupName() => this.ActionGroupName != null;

        /// <summary>
        /// Gets and sets the property ApiPath. 
        /// <para>
        /// The path to the API to call, based off the action group.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ApiPath { get; set; }

        /// <summary>
        /// Checks to see if the ApiPath property is set.
        /// </summary>
        internal bool IsSetApiPath() => this.ApiPath != null;

        /// <summary>
        /// Gets and sets the property ExecutionType. 
        /// <para>
        /// How fulfillment of the action is handled. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/action-handle.html">Handling
        /// fulfillment of the action</a>.
        /// </para>
        /// </summary>
        public ExecutionType ExecutionType { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionType property is set.
        /// </summary>
        internal bool IsSetExecutionType() => this.ExecutionType != null;

        /// <summary>
        /// Gets and sets the property Function. 
        /// <para>
        /// The function in the action group to call.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Function { get; set; }

        /// <summary>
        /// Checks to see if the Function property is set.
        /// </summary>
        internal bool IsSetFunction() => this.Function != null;

        /// <summary>
        /// Gets and sets the property InvocationId. 
        /// <para>
        /// The unique identifier of the invocation. Only returned if the <c>executionType</c>
        /// is <c>RETURN_CONTROL</c>.
        /// </para>
        /// </summary>
        public string InvocationId { get; set; }

        /// <summary>
        /// Checks to see if the InvocationId property is set.
        /// </summary>
        internal bool IsSetInvocationId() => this.InvocationId != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters in the Lambda input event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Parameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestBody. 
        /// <para>
        /// The parameters in the request body for the Lambda input event.
        /// </para>
        /// </summary>
        public RequestBody RequestBody { get; set; }

        /// <summary>
        /// Checks to see if the RequestBody property is set.
        /// </summary>
        internal bool IsSetRequestBody() => this.RequestBody != null;

        /// <summary>
        /// Gets and sets the property Verb. 
        /// <para>
        /// The API method being used, based off the action group.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Verb { get; set; }

        /// <summary>
        /// Checks to see if the Verb property is set.
        /// </summary>
        internal bool IsSetVerb() => this.Verb != null;
    }
}
