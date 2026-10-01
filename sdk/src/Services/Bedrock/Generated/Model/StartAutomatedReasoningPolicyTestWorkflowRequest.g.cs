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
    /// Container for the parameters to the StartAutomatedReasoningPolicyTestWorkflow operation.
    /// Initiates a test workflow to validate Automated Reasoning policy tests. The workflow
    /// executes the specified tests against the policy and generates validation results.
    /// </summary>
    public partial class StartAutomatedReasoningPolicyTestWorkflowRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property BuildWorkflowId. 
        /// <para>
        /// The build workflow identifier. The build workflow must show a <c>COMPLETED</c> status
        /// before running tests.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 36)]
        public string BuildWorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the BuildWorkflowId property is set.
        /// </summary>
        internal bool IsSetBuildWorkflowId() => this.BuildWorkflowId != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request but doesn't return an error.
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
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy to test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property TestCaseIds. 
        /// <para>
        /// The list of test identifiers to run. If not provided, all tests for the policy are
        /// run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<string> TestCaseIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TestCaseIds property is set.
        /// </summary>
        internal bool IsSetTestCaseIds() => this.TestCaseIds != null && (this.TestCaseIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
