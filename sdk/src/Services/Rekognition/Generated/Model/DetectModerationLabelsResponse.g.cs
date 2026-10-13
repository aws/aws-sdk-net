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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is the response object from the DetectModerationLabels operation.
    /// </summary>
    public partial class DetectModerationLabelsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ContentTypes. 
        /// <para>
        /// A list of predicted results for the type of content an image contains. For example,
        /// the image content might be from animation, sports, or a video game.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<ContentType> ContentTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<ContentType>() : null;

        /// <summary>
        /// Checks to see if the ContentTypes property is set.
        /// </summary>
        internal bool IsSetContentTypes() => this.ContentTypes != null && (this.ContentTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HumanLoopActivationOutput. 
        /// <para>
        /// Shows the results of the human in the loop evaluation.
        /// </para>
        /// </summary>
        public HumanLoopActivationOutput HumanLoopActivationOutput { get; set; }

        /// <summary>
        /// Checks to see if the HumanLoopActivationOutput property is set.
        /// </summary>
        internal bool IsSetHumanLoopActivationOutput() => this.HumanLoopActivationOutput != null;

        /// <summary>
        /// Gets and sets the property ModerationLabels. 
        /// <para>
        /// Array of detected Moderation labels. For video operations, this includes the time,
        /// in milliseconds from the start of the video, they were detected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModerationLabel> ModerationLabels { get; set; } = AWSConfigs.InitializeCollections ? new List<ModerationLabel>() : null;

        /// <summary>
        /// Checks to see if the ModerationLabels property is set.
        /// </summary>
        internal bool IsSetModerationLabels() => this.ModerationLabels != null && (this.ModerationLabels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ModerationModelVersion. 
        /// <para>
        /// Version number of the base moderation detection model that was used to detect unsafe
        /// content.
        /// </para>
        /// </summary>
        public string ModerationModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModerationModelVersion property is set.
        /// </summary>
        internal bool IsSetModerationModelVersion() => this.ModerationModelVersion != null;

        /// <summary>
        /// Gets and sets the property ProjectVersion. 
        /// <para>
        /// Identifier of the custom adapter that was used during inference. If during inference
        /// the adapter was EXPIRED, then the parameter will not be returned, indicating that
        /// a base moderation detection project version was used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ProjectVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProjectVersion property is set.
        /// </summary>
        internal bool IsSetProjectVersion() => this.ProjectVersion != null;
    }
}
