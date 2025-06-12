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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is the response object from the DetectModerationLabels operation.
    /// </summary>
    public partial class DetectModerationLabelsResponse : AmazonWebServiceResponse
    {
        private List<ContentType> _contentTypes = AWSConfigs.InitializeCollections ? new List<ContentType>() : null;
        private HumanLoopActivationOutput _humanLoopActivationOutput;
        private List<ModerationLabel> _moderationLabels = AWSConfigs.InitializeCollections ? new List<ModerationLabel>() : null;
        private string _moderationModelVersion;
        private string _projectVersion;

        /// <summary>
        /// Gets and sets the property ContentTypes. 
        /// <para>
        /// A list of predicted results for the type of content an image contains. For example,
        /// the image content might be from animation, sports, or a video game.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<ContentType> ContentTypes
        {
            get { return this._contentTypes; }
            set { this._contentTypes = value; }
        }

        // Check to see if ContentTypes property is set
        internal bool IsSetContentTypes()
        {
            return this._contentTypes != null && (this._contentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HumanLoopActivationOutput. 
        /// <para>
        /// Shows the results of the human in the loop evaluation.
        /// </para>
        /// </summary>
        public HumanLoopActivationOutput HumanLoopActivationOutput
        {
            get { return this._humanLoopActivationOutput; }
            set { this._humanLoopActivationOutput = value; }
        }

        // Check to see if HumanLoopActivationOutput property is set
        internal bool IsSetHumanLoopActivationOutput()
        {
            return this._humanLoopActivationOutput != null;
        }

        /// <summary>
        /// Gets and sets the property ModerationLabels. 
        /// <para>
        /// Array of detected Moderation labels. For video operations, this includes the time,
        /// in milliseconds from the start of the video, they were detected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModerationLabel> ModerationLabels
        {
            get { return this._moderationLabels; }
            set { this._moderationLabels = value; }
        }

        // Check to see if ModerationLabels property is set
        internal bool IsSetModerationLabels()
        {
            return this._moderationLabels != null && (this._moderationLabels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModerationModelVersion. 
        /// <para>
        /// Version number of the base moderation detection model that was used to detect unsafe
        /// content.
        /// </para>
        /// </summary>
        public string ModerationModelVersion
        {
            get { return this._moderationModelVersion; }
            set { this._moderationModelVersion = value; }
        }

        // Check to see if ModerationModelVersion property is set
        internal bool IsSetModerationModelVersion()
        {
            return this._moderationModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectVersion. 
        /// <para>
        /// Identifier of the custom adapter that was used during inference. If during inference
        /// the adapter was EXPIRED, then the parameter will not be returned, indicating that
        /// a base moderation detection project version was used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ProjectVersion
        {
            get { return this._projectVersion; }
            set { this._projectVersion = value; }
        }

        // Check to see if ProjectVersion property is set
        internal bool IsSetProjectVersion()
        {
            return this._projectVersion != null;
        }

    }
}