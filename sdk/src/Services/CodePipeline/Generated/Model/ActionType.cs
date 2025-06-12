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
    /// Returns information about the details of an action type.
    /// </summary>
    public partial class ActionType
    {
        private List<ActionConfigurationProperty> _actionConfigurationProperties = AWSConfigs.InitializeCollections ? new List<ActionConfigurationProperty>() : null;
        private ActionTypeId _id;
        private ArtifactDetails _inputArtifactDetails;
        private ArtifactDetails _outputArtifactDetails;
        private ActionTypeSettings _settings;

        /// <summary>
        /// Gets and sets the property ActionConfigurationProperties. 
        /// <para>
        /// The configuration properties for the action type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<ActionConfigurationProperty> ActionConfigurationProperties
        {
            get { return this._actionConfigurationProperties; }
            set { this._actionConfigurationProperties = value; }
        }

        // Check to see if ActionConfigurationProperties property is set
        internal bool IsSetActionConfigurationProperties()
        {
            return this._actionConfigurationProperties != null && (this._actionConfigurationProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Represents information about an action type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionTypeId Id
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
        /// <para>
        /// The details of the input artifact for the action, such as its commit ID.
        /// </para>
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
        /// Gets and sets the property OutputArtifactDetails. 
        /// <para>
        /// The details of the output artifact of the action, such as its commit ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Settings. 
        /// <para>
        /// The settings for the action type.
        /// </para>
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

    }
}