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
    /// Contains custom extraction configuration information.
    /// </summary>
    public partial class CustomExtractionConfiguration
    {
        private SemanticExtractionOverride _semanticExtractionOverride;
        private UserPreferenceExtractionOverride _userPreferenceExtractionOverride;

        /// <summary>
        /// Gets and sets the property SemanticExtractionOverride. 
        /// <para>
        /// The semantic extraction override configuration.
        /// </para>
        /// </summary>
        public SemanticExtractionOverride SemanticExtractionOverride
        {
            get { return this._semanticExtractionOverride; }
            set { this._semanticExtractionOverride = value; }
        }

        // Check to see if SemanticExtractionOverride property is set
        internal bool IsSetSemanticExtractionOverride()
        {
            return this._semanticExtractionOverride != null;
        }

        /// <summary>
        /// Gets and sets the property UserPreferenceExtractionOverride. 
        /// <para>
        /// The user preference extraction override configuration.
        /// </para>
        /// </summary>
        public UserPreferenceExtractionOverride UserPreferenceExtractionOverride
        {
            get { return this._userPreferenceExtractionOverride; }
            set { this._userPreferenceExtractionOverride = value; }
        }

        // Check to see if UserPreferenceExtractionOverride property is set
        internal bool IsSetUserPreferenceExtractionOverride()
        {
            return this._userPreferenceExtractionOverride != null;
        }

    }
}