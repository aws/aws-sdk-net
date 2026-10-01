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

namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAct operation. Creates a new AI task (act)
    /// within a session that can interact with tools and perform specific actions.
    /// </summary>
    public partial class CreateActRequest : AmazonNovaActRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session to create the act in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Task. 
        /// <para>
        /// The task description that defines what the act should accomplish.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 10000)]
        public string Task { get; set; }

        /// <summary>
        /// Checks to see if the Task property is set.
        /// </summary>
        internal bool IsSetTask() => this.Task != null;

        /// <summary>
        /// Gets and sets the property ToolSpecs. 
        /// <para>
        /// A list of tool specifications that the act can invoke to complete its task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<ToolSpec> ToolSpecs { get; set; } = AWSConfigs.InitializeCollections ? new List<ToolSpec>() : null;

        /// <summary>
        /// Checks to see if the ToolSpecs property is set.
        /// </summary>
        internal bool IsSetToolSpecs() => this.ToolSpecs != null && (this.ToolSpecs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkflowDefinitionName. 
        /// <para>
        /// The name of the workflow definition containing the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 40)]
        public string WorkflowDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowDefinitionName property is set.
        /// </summary>
        internal bool IsSetWorkflowDefinitionName() => this.WorkflowDefinitionName != null;

        /// <summary>
        /// Gets and sets the property WorkflowRunId. 
        /// <para>
        /// The unique identifier of the workflow run containing the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkflowRunId { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowRunId property is set.
        /// </summary>
        internal bool IsSetWorkflowRunId() => this.WorkflowRunId != null;
    }
}
