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
    /// Container for the parameters to the GetAutomatedReasoningPolicyBuildWorkflowResultAssets
    /// operation. Retrieves the resulting assets from a completed Automated Reasoning policy
    /// build workflow, including build logs, quality reports, and generated policy artifacts.
    /// </summary>
    public partial class GetAutomatedReasoningPolicyBuildWorkflowResultAssetsRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The unique identifier of the specific asset to retrieve when multiple assets of the
        /// same type exist. This is required when retrieving SOURCE_DOCUMENT assets, as multiple
        /// source documents may have been used in the workflow. The asset ID can be obtained
        /// from the asset manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 36)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        /// The type of asset to retrieve (e.g., BUILD_LOG, QUALITY_REPORT, POLICY_DEFINITION,
        /// GENERATED_TEST_CASES, POLICY_SCENARIOS, FIDELITY_REPORT, ASSET_MANIFEST, SOURCE_DOCUMENT).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutomatedReasoningPolicyBuildResultAssetType AssetType { get; set; }

        /// <summary>
        /// Checks to see if the AssetType property is set.
        /// </summary>
        internal bool IsSetAssetType() => this.AssetType != null;

        /// <summary>
        /// Gets and sets the property BuildWorkflowId. 
        /// <para>
        /// The unique identifier of the build workflow whose result assets you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 36)]
        public string BuildWorkflowId { get; set; }

        /// <summary>
        /// Checks to see if the BuildWorkflowId property is set.
        /// </summary>
        internal bool IsSetBuildWorkflowId() => this.BuildWorkflowId != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Automated Reasoning policy whose build workflow
        /// assets you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;
    }
}
