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
    /// Represents a finding or issue discovered during policy generation or validation. Findings
    /// provide insights about potential problems, recommendations, or validation results
    /// from policy analysis operations. Finding types include: VALID (policy is ready to
    /// use), INVALID (policy has validation errors that must be fixed), NOT_TRANSLATABLE
    /// (input couldn't be converted to policy), ALLOW_ALL (policy would allow all actions,
    /// potential security risk), ALLOW_NONE (policy would allow no actions, unusable), DENY_ALL
    /// (policy would deny all actions, may be too restrictive), and DENY_NONE (policy would
    /// deny no actions, ineffective). Review all findings before creating policies from generated
    /// assets to ensure they match your security requirements.
    /// </summary>
    public partial class Finding
    {
        private string _description;
        private FindingType _type;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the finding. This provides detailed information about
        /// the issue, recommendation, or validation result to help users understand and address
        /// the finding. 
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type or category of the finding. This classifies the finding as an error, warning,
        /// recommendation, or informational message to help users understand the severity and
        /// nature of the issue.
        /// </para>
        /// </summary>
        public FindingType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}