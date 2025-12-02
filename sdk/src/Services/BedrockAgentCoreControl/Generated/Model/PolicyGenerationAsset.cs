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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
    /// within the AgentCore Policy system. Each asset contains a Cedar policy statement generated
    /// from natural language input, along with associated metadata and analysis findings
    /// to help users evaluate and select the most appropriate policy option.
    /// </summary>
    public partial class PolicyGenerationAsset
    {
        private PolicyDefinition _definition;
        private List<Finding> _findings = AWSConfigs.InitializeCollections ? new List<Finding>() : null;
        private string _policyGenerationAssetId;
        private string _rawTextFragment;

        /// <summary>
        /// Gets and sets the property Definition.
        /// </summary>
        public PolicyDefinition Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        /// Analysis findings and insights related to this specific generated policy asset. These
        /// findings may include validation results, potential issues, or recommendations for
        /// improvement to help users evaluate the quality and appropriateness of the generated
        /// policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Finding> Findings
        {
            get { return this._findings; }
            set { this._findings = value; }
        }

        // Check to see if Findings property is set
        internal bool IsSetFindings()
        {
            return this._findings != null && (this._findings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PolicyGenerationAssetId. 
        /// <para>
        /// The unique identifier for this generated policy asset within the policy generation
        /// request. This ID can be used to reference specific generated policy options when creating
        /// actual policies from the generation results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=59)]
        public string PolicyGenerationAssetId
        {
            get { return this._policyGenerationAssetId; }
            set { this._policyGenerationAssetId = value; }
        }

        // Check to see if PolicyGenerationAssetId property is set
        internal bool IsSetPolicyGenerationAssetId()
        {
            return this._policyGenerationAssetId != null;
        }

        /// <summary>
        /// Gets and sets the property RawTextFragment. 
        /// <para>
        /// The portion of the original natural language input that this generated policy asset
        /// addresses. This helps users understand which part of their policy description was
        /// translated into this specific Cedar policy statement, enabling better policy selection
        /// and refinement. When a single natural language input describes multiple authorization
        /// requirements, the generation process creates separate policy assets for each requirement,
        /// with each asset's rawTextFragment showing which requirement it addresses. Use this
        /// mapping to verify that all parts of your natural language input were correctly translated
        /// into Cedar policies.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
        public string RawTextFragment
        {
            get { return this._rawTextFragment; }
            set { this._rawTextFragment = value; }
        }

        // Check to see if RawTextFragment property is set
        internal bool IsSetRawTextFragment()
        {
            return this._rawTextFragment != null;
        }

    }
}