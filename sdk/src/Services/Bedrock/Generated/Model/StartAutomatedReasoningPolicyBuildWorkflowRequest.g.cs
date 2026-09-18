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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the StartAutomatedReasoningPolicyBuildWorkflow operation.
    /// Starts a new build workflow for an Automated Reasoning policy. This initiates the
    /// process of analyzing source documents and generating policy rules, variables, and
    /// types.
    /// </summary>
    public partial class StartAutomatedReasoningPolicyBuildWorkflowRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property BuildWorkflowType. 
        /// <para>
        /// The type of build workflow to start (e.g., DOCUMENT_INGESTION for processing new documents,
        /// POLICY_REPAIR for fixing existing policies).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutomatedReasoningPolicyBuildWorkflowType BuildWorkflowType { get; set; }

        /// <summary>
        /// Checks to see if the BuildWorkflowType property is set.
        /// </summary>
        internal bool IsSetBuildWorkflowType() => this.BuildWorkflowType != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than once. If this token matches a previous request, Amazon Bedrock ignores the request
        /// but doesn't return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy for which to start
        /// the build workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property SourceContent. 
        /// <para>
        /// The source content for the build workflow, such as documents to analyze or repair
        /// instructions for existing policies.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutomatedReasoningPolicyBuildWorkflowSource SourceContent { get; set; }

        /// <summary>
        /// Checks to see if the SourceContent property is set.
        /// </summary>
        internal bool IsSetSourceContent() => this.SourceContent != null;
    }
}
