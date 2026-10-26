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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the StartPolicyGeneration operation. Initiates the
    /// AI-powered generation of Dogwood policies from natural language descriptions within
    /// the AgentCore Policy system. This feature enables both technical and non-technical
    /// users to create policies by describing their authorization requirements in plain English,
    /// which is then automatically translated into formal Dogwood policy statements. The
    /// generation process analyzes the natural language input along with the Gateway's tool
    /// context to produce validated policy options. Generated policy assets are automatically
    /// deleted after 7 days, so you should review and create policies from the generated
    /// assets within this timeframe. Once created, policies are permanent and not subject
    /// to this expiration. Generated policies should be reviewed and tested in log-only mode
    /// before deploying to production. Use this when you want to describe policy intent naturally
    /// rather than learning Dogwood syntax, though generated policies may require refinement
    /// for complex scenarios.
    /// </summary>
    public partial class StartPolicyGenerationRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure the idempotency of the request. The
        /// Amazon Web Services SDK automatically generates this token, so you don't need to provide
        /// it in most cases. If you retry a request with the same client token, the service returns
        /// the same response without starting a duplicate generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The natural language description of the desired policy behavior. This content is processed
        /// by AI to generate corresponding Dogwood policy statements that match the described
        /// intent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Content Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A customer-assigned name for the policy generation request. This helps track and identify
        /// generation operations, especially when running multiple generations simultaneously.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PolicyEngineId. 
        /// <para>
        /// The identifier of the policy engine that provides the context for policy generation.
        /// This engine's schema and tool context are used to ensure generated policies are valid
        /// and applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 59)]
        public string PolicyEngineId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyEngineId property is set.
        /// </summary>
        internal bool IsSetPolicyEngineId() => this.PolicyEngineId != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource information that provides context for policy generation. This helps the
        /// AI understand the target resources and generate appropriate access control rules.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Resource Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;
    }
}
