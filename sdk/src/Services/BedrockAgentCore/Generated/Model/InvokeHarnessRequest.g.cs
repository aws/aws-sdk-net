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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeHarness operation. Operation to invoke a
    /// Harness.
    /// </summary>
    public partial class InvokeHarnessRequest : AmazonBedrockAgentCoreRequest
    {
        /// <summary>
        /// Gets and sets the property ActorId. 
        /// <para>
        /// The actor ID for memory operations. Overrides the actor ID configured on the harness.
        /// </para>
        /// </summary>
        public string ActorId { get; set; }

        /// <summary>
        /// Checks to see if the ActorId property is set.
        /// </summary>
        internal bool IsSetActorId() => this.ActorId != null;

        /// <summary>
        /// Gets and sets the property AllowedTools. 
        /// <para>
        /// The tools that the agent is allowed to use for this invocation. If specified, overrides
        /// the harness default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedTools { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedTools property is set.
        /// </summary>
        internal bool IsSetAllowedTools() => this.AllowedTools != null && (this.AllowedTools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Baggage. 
        /// <para>
        /// W3C Baggage header for user-defined context propagation. Format: key1=value1,key2=value2
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string Baggage { get; set; }

        /// <summary>
        /// Checks to see if the Baggage property is set.
        /// </summary>
        internal bool IsSetBaggage() => this.Baggage != null;

        /// <summary>
        /// Gets and sets the property HarnessArn. 
        /// <para>
        /// The ARN of the harness to invoke.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HarnessArn { get; set; }

        /// <summary>
        /// Checks to see if the HarnessArn property is set.
        /// </summary>
        internal bool IsSetHarnessArn() => this.HarnessArn != null;

        /// <summary>
        /// Gets and sets the property MaxIterations. 
        /// <para>
        /// The maximum number of iterations the agent loop can execute. If specified, overrides
        /// the harness default.
        /// </para>
        /// </summary>
        public int? MaxIterations { get; set; }

        /// <summary>
        /// Checks to see if the MaxIterations property is set.
        /// </summary>
        internal bool IsSetMaxIterations() => this.MaxIterations.HasValue;

        /// <summary>
        /// Gets and sets the property MaxTokens. 
        /// <para>
        /// The maximum number of tokens the agent can generate per iteration. If specified, overrides
        /// the harness default.
        /// </para>
        /// </summary>
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Checks to see if the MaxTokens property is set.
        /// </summary>
        internal bool IsSetMaxTokens() => this.MaxTokens.HasValue;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// The messages to send to the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<HarnessMessage> Messages { get; set; } = AWSConfigs.InitializeCollections ? new List<HarnessMessage>() : null;

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null && (this.Messages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// The model configuration to use for this invocation. If specified, overrides the harness
        /// default.
        /// </para>
        /// </summary>
        public HarnessModelConfiguration Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// The endpoint name to invoke. If omitted, the DEFAULT endpoint is used.
        /// </para>
        /// </summary>
        public string Qualifier { get; set; }

        /// <summary>
        /// Checks to see if the Qualifier property is set.
        /// </summary>
        internal bool IsSetQualifier() => this.Qualifier != null;

        /// <summary>
        /// Gets and sets the property RuntimeSessionId. 
        /// <para>
        /// The session ID for the invocation. Use the same session ID across requests to continue
        /// a conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 33, Max = 100)]
        public string RuntimeSessionId { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeSessionId property is set.
        /// </summary>
        internal bool IsSetRuntimeSessionId() => this.RuntimeSessionId != null;

        /// <summary>
        /// Gets and sets the property RuntimeUserId. 
        /// <para>
        /// An identifier for the end user making the request. This value is passed through to
        /// the runtime container.
        /// </para>
        /// </summary>
        public string RuntimeUserId { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeUserId property is set.
        /// </summary>
        internal bool IsSetRuntimeUserId() => this.RuntimeUserId != null;

        /// <summary>
        /// Gets and sets the property Skills. 
        /// <para>
        /// The skills available to the agent for this invocation. If specified, overrides the
        /// harness default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarnessSkill> Skills { get; set; } = AWSConfigs.InitializeCollections ? new List<HarnessSkill>() : null;

        /// <summary>
        /// Checks to see if the Skills property is set.
        /// </summary>
        internal bool IsSetSkills() => this.Skills != null && (this.Skills.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SystemPrompt. 
        /// <para>
        /// The system prompt to use for this invocation. If specified, overrides the harness
        /// default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarnessSystemContentBlock> SystemPrompt { get; set; } = AWSConfigs.InitializeCollections ? new List<HarnessSystemContentBlock>() : null;

        /// <summary>
        /// Checks to see if the SystemPrompt property is set.
        /// </summary>
        internal bool IsSetSystemPrompt() => this.SystemPrompt != null && (this.SystemPrompt.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The maximum duration in seconds for the agent loop execution. If specified, overrides
        /// the harness default.
        /// </para>
        /// </summary>
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutSeconds() => this.TimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Tools. 
        /// <para>
        /// The tools available to the agent for this invocation. If specified, overrides the
        /// harness default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarnessTool> Tools { get; set; } = AWSConfigs.InitializeCollections ? new List<HarnessTool>() : null;

        /// <summary>
        /// Checks to see if the Tools property is set.
        /// </summary>
        internal bool IsSetTools() => this.Tools != null && (this.Tools.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// Trace ID for maintaining observability through the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TraceId { get; set; }

        /// <summary>
        /// Checks to see if the TraceId property is set.
        /// </summary>
        internal bool IsSetTraceId() => this.TraceId != null;

        /// <summary>
        /// Gets and sets the property TraceParent. 
        /// <para>
        /// W3C trace context parent header containing version, trace ID, parent span ID, and
        /// trace flags.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string TraceParent { get; set; }

        /// <summary>
        /// Checks to see if the TraceParent property is set.
        /// </summary>
        internal bool IsSetTraceParent() => this.TraceParent != null;

        /// <summary>
        /// Gets and sets the property TraceState. 
        /// <para>
        /// W3C trace context state header for vendor-specific trace information.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string TraceState { get; set; }

        /// <summary>
        /// Checks to see if the TraceState property is set.
        /// </summary>
        internal bool IsSetTraceState() => this.TraceState != null;
    }
}
