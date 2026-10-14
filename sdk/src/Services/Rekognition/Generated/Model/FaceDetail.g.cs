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
    /// Structure containing attributes of the face that the algorithm detected.
    /// 
    ///  
    /// <para>
    /// A <c>FaceDetail</c> object contains either the default facial attributes or all facial
    /// attributes. The default attributes are <c>BoundingBox</c>, <c>Confidence</c>, <c>Landmarks</c>,
    /// <c>Pose</c>, and <c>Quality</c>.
    /// </para>
    ///  
    /// <para>
    ///  <a>GetFaceDetection</a> is the only Amazon Rekognition Video stored video operation
    /// that can return a <c>FaceDetail</c> object with all attributes. To specify which attributes
    /// to return, use the <c>FaceAttributes</c> input parameter for <a>StartFaceDetection</a>.
    /// The following Amazon Rekognition Video operations return only the default attributes.
    /// The corresponding Start operations don't have a <c>FaceAttributes</c> input parameter:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// GetCelebrityRecognition
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// GetPersonTracking
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// GetFaceSearch
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The Amazon Rekognition Image <a>DetectFaces</a> and <a>IndexFaces</a> operations can
    /// return all facial attributes. To specify which attributes to return, use the <c>Attributes</c>
    /// input parameter for <c>DetectFaces</c>. For <c>IndexFaces</c>, use the <c>DetectAttributes</c>
    /// input parameter.
    /// </para>
    /// </summary>
    public partial class FaceDetail
    {
        /// <summary>
        /// Gets and sets the property AgeRange. 
        /// <para>
        /// The estimated age range, in years, for the face. Low represents the lowest estimated
        /// age and High represents the highest estimated age.
        /// </para>
        /// </summary>
        public AgeRange AgeRange { get; set; }

        /// <summary>
        /// Checks to see if the AgeRange property is set.
        /// </summary>
        internal bool IsSetAgeRange() => this.AgeRange != null;

        /// <summary>
        /// Gets and sets the property Beard. 
        /// <para>
        /// Indicates whether or not the face has a beard, and the confidence level in the determination.
        /// </para>
        /// </summary>
        public Beard Beard { get; set; }

        /// <summary>
        /// Checks to see if the Beard property is set.
        /// </summary>
        internal bool IsSetBeard() => this.Beard != null;

        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// Bounding box of the face. Default attribute.
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
        /// Confidence level that the bounding box contains a face (and not a different object
        /// such as a tree). Default attribute.
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
        /// The emotions that appear to be expressed on the face, and the confidence level in
        /// the determination. The API is only making a determination of the physical appearance
        /// of a person's face. It is not a determination of the person’s internal emotional state
        /// and should not be used in such a way. For example, a person pretending to have a sad
        /// face might not be sad emotionally.
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
        /// Gets and sets the property EyeDirection. 
        /// <para>
        /// Indicates the direction the eyes are gazing in, as defined by pitch and yaw.
        /// </para>
        /// </summary>
        public EyeDirection EyeDirection { get; set; }

        /// <summary>
        /// Checks to see if the EyeDirection property is set.
        /// </summary>
        internal bool IsSetEyeDirection() => this.EyeDirection != null;

        /// <summary>
        /// Gets and sets the property Eyeglasses. 
        /// <para>
        /// Indicates whether or not the face is wearing eye glasses, and the confidence level
        /// in the determination.
        /// </para>
        /// </summary>
        public Eyeglasses Eyeglasses { get; set; }

        /// <summary>
        /// Checks to see if the Eyeglasses property is set.
        /// </summary>
        internal bool IsSetEyeglasses() => this.Eyeglasses != null;

        /// <summary>
        /// Gets and sets the property EyesOpen. 
        /// <para>
        /// Indicates whether or not the eyes on the face are open, and the confidence level in
        /// the determination.
        /// </para>
        /// </summary>
        public EyeOpen EyesOpen { get; set; }

        /// <summary>
        /// Checks to see if the EyesOpen property is set.
        /// </summary>
        internal bool IsSetEyesOpen() => this.EyesOpen != null;

        /// <summary>
        /// Gets and sets the property FaceOccluded. 
        /// <para>
        ///  <c>FaceOccluded</c> should return "true" with a high confidence score if a detected
        /// face’s eyes, nose, and mouth are partially captured or if they are covered by masks,
        /// dark sunglasses, cell phones, hands, or other objects. <c>FaceOccluded</c> should
        /// return "false" with a high confidence score if common occurrences that do not impact
        /// face verification are detected, such as eye glasses, lightly tinted sunglasses, strands
        /// of hair, and others. 
        /// </para>
        /// </summary>
        public FaceOccluded FaceOccluded { get; set; }

        /// <summary>
        /// Checks to see if the FaceOccluded property is set.
        /// </summary>
        internal bool IsSetFaceOccluded() => this.FaceOccluded != null;

        /// <summary>
        /// Gets and sets the property Gender. 
        /// <para>
        /// The predicted gender of a detected face. 
        /// </para>
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Checks to see if the Gender property is set.
        /// </summary>
        internal bool IsSetGender() => this.Gender != null;

        /// <summary>
        /// Gets and sets the property Landmarks. 
        /// <para>
        /// Indicates the location of landmarks on the face. Default attribute.
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
        /// Gets and sets the property MouthOpen. 
        /// <para>
        /// Indicates whether or not the mouth on the face is open, and the confidence level in
        /// the determination.
        /// </para>
        /// </summary>
        public MouthOpen MouthOpen { get; set; }

        /// <summary>
        /// Checks to see if the MouthOpen property is set.
        /// </summary>
        internal bool IsSetMouthOpen() => this.MouthOpen != null;

        /// <summary>
        /// Gets and sets the property Mustache. 
        /// <para>
        /// Indicates whether or not the face has a mustache, and the confidence level in the
        /// determination.
        /// </para>
        /// </summary>
        public Mustache Mustache { get; set; }

        /// <summary>
        /// Checks to see if the Mustache property is set.
        /// </summary>
        internal bool IsSetMustache() => this.Mustache != null;

        /// <summary>
        /// Gets and sets the property Pose. 
        /// <para>
        /// Indicates the pose of the face as determined by its pitch, roll, and yaw. Default
        /// attribute.
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
        /// Identifies image brightness and sharpness. Default attribute.
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
        /// Indicates whether or not the face is smiling, and the confidence level in the determination.
        /// </para>
        /// </summary>
        public Smile Smile { get; set; }

        /// <summary>
        /// Checks to see if the Smile property is set.
        /// </summary>
        internal bool IsSetSmile() => this.Smile != null;

        /// <summary>
        /// Gets and sets the property Sunglasses. 
        /// <para>
        /// Indicates whether or not the face is wearing sunglasses, and the confidence level
        /// in the determination.
        /// </para>
        /// </summary>
        public Sunglasses Sunglasses { get; set; }

        /// <summary>
        /// Checks to see if the Sunglasses property is set.
        /// </summary>
        internal bool IsSetSunglasses() => this.Sunglasses != null;
    }
}
