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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
        private string _buildWorkflowId;
        private string _clientRequestToken;
        private string _policyArn;
        private List<string> _testCaseIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BuildWorkflowId. 
        /// <para>
        /// The build workflow identifier. The build workflow must show a <c>COMPLETED</c> status
        /// before running tests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=36)]
        public string BuildWorkflowId
        {
            get { return this._buildWorkflowId; }
            set { this._buildWorkflowId = value; }
        }

        // Check to see if BuildWorkflowId property is set
        internal bool IsSetBuildWorkflowId()
        {
            return this._buildWorkflowId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request but doesn't return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy to test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property TestCaseIds. 
        /// <para>
        /// The list of test identifiers to run. If not provided, all tests for the policy are
        /// run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> TestCaseIds
        {
            get { return this._testCaseIds; }
            set { this._testCaseIds = value; }
        }

        // Check to see if TestCaseIds property is set
        internal bool IsSetTestCaseIds()
        {
            return this._testCaseIds != null && (this._testCaseIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}