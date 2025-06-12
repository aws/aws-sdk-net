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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The rule type, which is made up of the combined values for category, owner, provider,
    /// and version.
    /// </summary>
    public partial class RuleType
    {
        private RuleTypeId _id;
        private ArtifactDetails _inputArtifactDetails;
        private List<RuleConfigurationProperty> _ruleConfigurationProperties = AWSConfigs.InitializeCollections ? new List<RuleConfigurationProperty>() : null;
        private RuleTypeSettings _settings;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Represents information about a rule type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleTypeId Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InputArtifactDetails.
        /// </summary>
        [AWSProperty(Required=true)]
        public ArtifactDetails InputArtifactDetails
        {
            get { return this._inputArtifactDetails; }
            set { this._inputArtifactDetails = value; }
        }

        // Check to see if InputArtifactDetails property is set
        internal bool IsSetInputArtifactDetails()
        {
            return this._inputArtifactDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RuleConfigurationProperties. 
        /// <para>
        /// The configuration properties for the rule type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<RuleConfigurationProperty> RuleConfigurationProperties
        {
            get { return this._ruleConfigurationProperties; }
            set { this._ruleConfigurationProperties = value; }
        }

        // Check to see if RuleConfigurationProperties property is set
        internal bool IsSetRuleConfigurationProperties()
        {
            return this._ruleConfigurationProperties != null && (this._ruleConfigurationProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Returns information about the settings for a rule type.
        /// </para>
        /// </summary>
        public RuleTypeSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

    }
}