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
    /// Container for the parameters to the GetAutomatedReasoningPolicyBuildWorkflowResultAssets operation.
    /// Retrieves the resulting assets from a completed Automated Reasoning policy build workflow,
    /// including build logs, quality reports, and generated policy artifacts.
    /// </summary>
    public partial class GetAutomatedReasoningPolicyBuildWorkflowResultAssetsRequest : AmazonBedrockRequest
    {
        private AutomatedReasoningPolicyBuildResultAssetType _assetType;
        private string _buildWorkflowId;
        private string _policyArn;

        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        /// The type of asset to retrieve (e.g., BUILD_LOG, QUALITY_REPORT, POLICY_DEFINITION).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomatedReasoningPolicyBuildResultAssetType AssetType
        {
            get { return this._assetType; }
            set { this._assetType = value; }
        }

        // Check to see if AssetType property is set
        internal bool IsSetAssetType()
        {
            return this._assetType != null;
        }

        /// <summary>
        /// Gets and sets the property BuildWorkflowId. 
        /// <para>
        /// The unique identifier of the build workflow whose result assets you want to retrieve.
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
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy whose build workflow
        /// assets you want to retrieve.
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

    }
}