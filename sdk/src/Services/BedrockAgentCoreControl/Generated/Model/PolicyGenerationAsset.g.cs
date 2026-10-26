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
    /// Represents a generated policy asset from the AI-powered policy generation process
    /// within the AgentCore Policy system. Each asset contains a Dogwood policy statement
    /// generated from natural language input, along with associated metadata and analysis
    /// findings to help users evaluate and select the most appropriate policy option.
    /// </summary>
    public partial class PolicyGenerationAsset
    {
        /// <summary>
        /// Gets and sets the property Definition.
        /// </summary>
        public PolicyDefinition Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        /// Analysis findings and insights related to this specific generated policy asset. These
        /// findings may include validation results, potential issues, or recommendations for
        /// improvement to help users evaluate the quality and appropriateness of the generated
        /// policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Finding> Findings { get; set; } = AWSConfigs.InitializeCollections ? new List<Finding>() : null;

        /// <summary>
        /// Checks to see if the Findings property is set.
        /// </summary>
        internal bool IsSetFindings() => this.Findings != null && (this.Findings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PolicyGenerationAssetId. 
        /// <para>
        /// The unique identifier for this generated policy asset within the policy generation
        /// request. This ID can be used to reference specific generated policy options when creating
        /// actual policies from the generation results.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 59)]
        public string PolicyGenerationAssetId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyGenerationAssetId property is set.
        /// </summary>
        internal bool IsSetPolicyGenerationAssetId() => this.PolicyGenerationAssetId != null;

        /// <summary>
        /// Gets and sets the property RawTextFragment. 
        /// <para>
        /// The portion of the original natural language input that this generated policy asset
        /// addresses. This helps users understand which part of their policy description was
        /// translated into this specific Dogwood policy statement, enabling better policy selection
        /// and refinement. When a single natural language input describes multiple authorization
        /// requirements, the generation process creates separate policy assets for each requirement,
        /// with each asset's rawTextFragment showing which requirement it addresses. Use this
        /// mapping to verify that all parts of your natural language input were correctly translated
        /// into Dogwood policies.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2000)]
        public string RawTextFragment { get; set; }

        /// <summary>
        /// Checks to see if the RawTextFragment property is set.
        /// </summary>
        internal bool IsSetRawTextFragment() => this.RawTextFragment != null;
    }
}
