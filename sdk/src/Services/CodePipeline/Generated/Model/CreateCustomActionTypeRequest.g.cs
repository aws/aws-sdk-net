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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomActionType operation. Creates a new
    /// custom action that can be used in all pipelines associated with the Amazon Web Services
    /// account. Only used for custom actions.
    /// </summary>
    public partial class CreateCustomActionTypeRequest : AmazonCodePipelineRequest
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the custom action, such as a build action or a test action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property ConfigurationProperties. 
        /// <para>
        /// The configuration properties for the custom action.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can refer to a name in the configuration properties of the custom action within
        /// the URL templates by following the format of {Config:name}, as long as the configuration
        /// property is both required and not secret. For more information, see <a href="https://docs.aws.amazon.com/codepipeline/latest/userguide/how-to-create-custom-action.html">Create
        /// a Custom Action for a Pipeline</a>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ActionConfigurationProperty> ConfigurationProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<ActionConfigurationProperty>() : null;

        /// <summary>
        /// Checks to see if the ConfigurationProperties property is set.
        /// </summary>
        internal bool IsSetConfigurationProperties() => this.ConfigurationProperties != null && (this.ConfigurationProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InputArtifactDetails. 
        /// <para>
        /// The details of the input artifact for the action, such as its commit ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ArtifactDetails InputArtifactDetails { get; set; }

        /// <summary>
        /// Checks to see if the InputArtifactDetails property is set.
        /// </summary>
        internal bool IsSetInputArtifactDetails() => this.InputArtifactDetails != null;

        /// <summary>
        /// Gets and sets the property OutputArtifactDetails. 
        /// <para>
        /// The details of the output artifact of the action, such as its commit ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ArtifactDetails OutputArtifactDetails { get; set; }

        /// <summary>
        /// Checks to see if the OutputArtifactDetails property is set.
        /// </summary>
        internal bool IsSetOutputArtifactDetails() => this.OutputArtifactDetails != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider of the service used in the custom action, such as CodeDeploy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 35)]
        public string Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// URLs that provide users information about this custom action.
        /// </para>
        /// </summary>
        public ActionTypeSettings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the custom action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version identifier of the custom action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 9)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
