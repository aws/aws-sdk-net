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
    /// Provides face metadata for target image faces that are analyzed by <c>CompareFaces</c>
    /// and <c>RecognizeCelebrities</c>.
    /// </summary>
    public partial class ComparedFace
    {
        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// Bounding box of the face.
        /// </para>
        /// </summary>
        public BoundingBox BoundingBox { get; set; }

        /// <summary>
        /// Checks to see if the BoundingBox property is set.
        /// </summary>
        internal bool IsSetBoundingBox() => this.BoundingBox != null;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Level of confidence that what the bounding box contains is a face.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property Emotions. 
        /// <para>
        ///  The emotions that appear to be expressed on the face, and the confidence level in
        /// the determination. Valid values include "Happy", "Sad", "Angry", "Confused", "Disgusted",
        /// "Surprised", "Calm", "Unknown", and "Fear". 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Emotion> Emotions { get; set; } = AWSConfigs.InitializeCollections ? new List<Emotion>() : null;

        /// <summary>
        /// Checks to see if the Emotions property is set.
        /// </summary>
        internal bool IsSetEmotions() => this.Emotions != null && (this.Emotions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Landmarks. 
        /// <para>
        /// An array of facial landmarks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Landmark> Landmarks { get; set; } = AWSConfigs.InitializeCollections ? new List<Landmark>() : null;

        /// <summary>
        /// Checks to see if the Landmarks property is set.
        /// </summary>
        internal bool IsSetLandmarks() => this.Landmarks != null && (this.Landmarks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Pose. 
        /// <para>
        /// Indicates the pose of the face as determined by its pitch, roll, and yaw.
        /// </para>
        /// </summary>
        public Pose Pose { get; set; }

        /// <summary>
        /// Checks to see if the Pose property is set.
        /// </summary>
        internal bool IsSetPose() => this.Pose != null;

        /// <summary>
        /// Gets and sets the property Quality. 
        /// <para>
        /// Identifies face image brightness and sharpness. 
        /// </para>
        /// </summary>
        public ImageQuality Quality { get; set; }

        /// <summary>
        /// Checks to see if the Quality property is set.
        /// </summary>
        internal bool IsSetQuality() => this.Quality != null;

        /// <summary>
        /// Gets and sets the property Smile. 
        /// <para>
        ///  Indicates whether or not the face is smiling, and the confidence level in the determination.
        /// 
        /// </para>
        /// </summary>
        public Smile Smile { get; set; }

        /// <summary>
        /// Checks to see if the Smile property is set.
        /// </summary>
        internal bool IsSetSmile() => this.Smile != null;
    }
}
