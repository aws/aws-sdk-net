/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomActionType operation.
    /// Creates a new custom action that can be used in all pipelines associated with the
    /// AWS account. Only used for custom actions.
    /// </summary>
    public partial class CreateCustomActionTypeRequest : AmazonCodePipelineRequest
    {
        private ActionCategory _category;
        private List<ActionConfigurationProperty> _configurationProperties = new List<ActionConfigurationProperty>();
        private ArtifactDetails _inputArtifactDetails;
        private ArtifactDetails _outputArtifactDetails;
        private string _provider;
        private ActionTypeSettings _settings;
        private string _version;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the custom action, such as a source action or a build action.
        /// </para>
        ///  <note>Although Source is listed as a valid value, it is not currently functional.
        /// This value is reserved for future use.</note>
        /// </summary>
        public ActionCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationProperties. 
        /// <para>
        /// The configuration properties for the custom action.
        /// </para>
        ///  <note>You can refer to a name in the configuration properties of the custom action
        /// within the URL templates by following the format of {Config:<i>name</i>}, as long
        /// as the configuration property is both required and not secret. For more information,
        /// see <a href="http://docs.aws.amazon.com/codepipeline/latest/userguide/how-to-create-custom-action.html">Create
        /// a Custom Action for a Pipeline</a>.</note>
        /// </summary>
        public List<ActionConfigurationProperty> ConfigurationProperties
        {
            get { return this._configurationProperties; }
            set { this._configurationProperties = value; }
        }

        // Check to see if ConfigurationProperties property is set
        internal bool IsSetConfigurationProperties()
        {
            return this._configurationProperties != null && this._configurationProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputArtifactDetails.
        /// </summary>
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
        /// Gets and sets the property OutputArtifactDetails.
        /// </summary>
        public ArtifactDetails OutputArtifactDetails
        {
            get { return this._outputArtifactDetails; }
            set { this._outputArtifactDetails = value; }
        }

        // Check to see if OutputArtifactDetails property is set
        internal bool IsSetOutputArtifactDetails()
        {
            return this._outputArtifactDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider of the service used in the custom action, such as AWS CodeDeploy.
        /// </para>
        /// </summary>
        public string Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property Settings.
        /// </summary>
        public ActionTypeSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the custom action. 
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}