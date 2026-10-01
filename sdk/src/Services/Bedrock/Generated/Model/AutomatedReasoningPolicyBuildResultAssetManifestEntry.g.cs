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
    /// Represents a single entry in the asset manifest, describing one artifact produced
    /// by the build workflow.
    /// </summary>
    public partial class AutomatedReasoningPolicyBuildResultAssetManifestEntry
    {
        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// A unique identifier for the asset, if applicable. Use this ID when requesting specific
        /// assets through the API.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 36)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property AssetName. 
        /// <para>
        /// A human-readable name for the asset, if applicable. This helps identify specific documents
        /// or reports within the workflow results.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 256)]
        public string AssetName { get; set; }

        /// <summary>
        /// Checks to see if the AssetName property is set.
        /// </summary>
        internal bool IsSetAssetName() => this.AssetName != null;

        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        /// The type of asset (e.g., BUILD_LOG, QUALITY_REPORT, POLICY_DEFINITION, GENERATED_TEST_CASES,
        /// POLICY_SCENARIOS, FIDELITY_REPORT, ASSET_MANIFEST, SOURCE_DOCUMENT).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutomatedReasoningPolicyBuildResultAssetType AssetType { get; set; }

        /// <summary>
        /// Checks to see if the AssetType property is set.
        /// </summary>
        internal bool IsSetAssetType() => this.AssetType != null;
    }
}
