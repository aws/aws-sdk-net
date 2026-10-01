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
    /// Container for the parameters to the InvokeActStep operation. Executes the next step
    /// of an act, processing tool call results and returning new tool calls if needed.
    /// </summary>
    public partial class InvokeActStepRequest : AmazonNovaActRequest
    {
        /// <summary>
        /// Gets and sets the property ActId. 
        /// <para>
        /// The unique identifier of the act to invoke the next step for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ActId { get; set; }

        /// <summary>
        /// Checks to see if the ActId property is set.
        /// </summary>
        internal bool IsSetActId() => this.ActId != null;

        /// <summary>
        /// Gets and sets the property CallResults. 
        /// <para>
        /// The results from previous tool calls that the act requested.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<CallResult> CallResults { get; set; } = AWSConfigs.InitializeCollections ? new List<CallResult>() : null;

        /// <summary>
        /// Checks to see if the CallResults property is set.
        /// </summary>
        internal bool IsSetCallResults() => this.CallResults != null && (this.CallResults.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PreviousStepId. 
        /// <para>
        /// The identifier of the previous step, used for tracking execution flow.
        /// </para>
        /// </summary>
        public string PreviousStepId { get; set; }

        /// <summary>
        /// Checks to see if the PreviousStepId property is set.
        /// </summary>
        internal bool IsSetPreviousStepId() => this.PreviousStepId != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session containing the act.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property WorkflowDefinitionName. 
        /// <para>
        /// The name of the workflow definition containing the act.
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
        /// The unique identifier of the workflow run containing the act.
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
