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
        private AgeRange _ageRange;
        private Beard _beard;
        private BoundingBox _boundingBox;
        private float? _confidence;
        private List<Emotion> _emotions = AWSConfigs.InitializeCollections ? new List<Emotion>() : null;
        private EyeDirection _eyeDirection;
        private Eyeglasses _eyeglasses;
        private EyeOpen _eyesOpen;
        private FaceOccluded _faceOccluded;
        private Gender _gender;
        private List<Landmark> _landmarks = AWSConfigs.InitializeCollections ? new List<Landmark>() : null;
        private MouthOpen _mouthOpen;
        private Mustache _mustache;
        private Pose _pose;
        private ImageQuality _quality;
        private Smile _smile;
        private Sunglasses _sunglasses;

        /// <summary>
        /// Gets and sets the property AgeRange. 
        /// <para>
        /// The estimated age range, in years, for the face. Low represents the lowest estimated
        /// age and High represents the highest estimated age.
        /// </para>
        /// </summary>
        public AgeRange AgeRange
        {
            get { return this._ageRange; }
            set { this._ageRange = value; }
        }

        // Check to see if AgeRange property is set
        internal bool IsSetAgeRange()
        {
            return this._ageRange != null;
        }

        /// <summary>
        /// Gets and sets the property Beard. 
        /// <para>
        /// Indicates whether or not the face has a beard, and the confidence level in the determination.
        /// </para>
        /// </summary>
        public Beard Beard
        {
            get { return this._beard; }
            set { this._beard = value; }
        }

        // Check to see if Beard property is set
        internal bool IsSetBeard()
        {
            return this._beard != null;
        }

        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// Bounding box of the face. Default attribute.
        /// </para>
        /// </summary>
        public BoundingBox BoundingBox
        {
            get { return this._boundingBox; }
            set { this._boundingBox = value; }
        }

        // Check to see if BoundingBox property is set
        internal bool IsSetBoundingBox()
        {
            return this._boundingBox != null;
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Confidence level that the bounding box contains a face (and not a different object
        /// such as a tree). Default attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Emotion> Emotions
        {
            get { return this._emotions; }
            set { this._emotions = value; }
        }

        // Check to see if Emotions property is set
        internal bool IsSetEmotions()
        {
            return this._emotions != null && (this._emotions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EyeDirection. 
        /// <para>
        /// Indicates the direction the eyes are gazing in, as defined by pitch and yaw.
        /// </para>
        /// </summary>
        public EyeDirection EyeDirection
        {
            get { return this._eyeDirection; }
            set { this._eyeDirection = value; }
        }

        // Check to see if EyeDirection property is set
        internal bool IsSetEyeDirection()
        {
            return this._eyeDirection != null;
        }

        /// <summary>
        /// Gets and sets the property Eyeglasses. 
        /// <para>
        /// Indicates whether or not the face is wearing eye glasses, and the confidence level
        /// in the determination.
        /// </para>
        /// </summary>
        public Eyeglasses Eyeglasses
        {
            get { return this._eyeglasses; }
            set { this._eyeglasses = value; }
        }

        // Check to see if Eyeglasses property is set
        internal bool IsSetEyeglasses()
        {
            return this._eyeglasses != null;
        }

        /// <summary>
        /// Gets and sets the property EyesOpen. 
        /// <para>
        /// Indicates whether or not the eyes on the face are open, and the confidence level in
        /// the determination.
        /// </para>
        /// </summary>
        public EyeOpen EyesOpen
        {
            get { return this._eyesOpen; }
            set { this._eyesOpen = value; }
        }

        // Check to see if EyesOpen property is set
        internal bool IsSetEyesOpen()
        {
            return this._eyesOpen != null;
        }

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
        public FaceOccluded FaceOccluded
        {
            get { return this._faceOccluded; }
            set { this._faceOccluded = value; }
        }

        // Check to see if FaceOccluded property is set
        internal bool IsSetFaceOccluded()
        {
            return this._faceOccluded != null;
        }

        /// <summary>
        /// Gets and sets the property Gender. 
        /// <para>
        /// The predicted gender of a detected face. 
        /// </para>
        /// </summary>
        public Gender Gender
        {
            get { return this._gender; }
            set { this._gender = value; }
        }

        // Check to see if Gender property is set
        internal bool IsSetGender()
        {
            return this._gender != null;
        }

        /// <summary>
        /// Gets and sets the property Landmarks. 
        /// <para>
        /// Indicates the location of landmarks on the face. Default attribute.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Landmark> Landmarks
        {
            get { return this._landmarks; }
            set { this._landmarks = value; }
        }

        // Check to see if Landmarks property is set
        internal bool IsSetLandmarks()
        {
            return this._landmarks != null && (this._landmarks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MouthOpen. 
        /// <para>
        /// Indicates whether or not the mouth on the face is open, and the confidence level in
        /// the determination.
        /// </para>
        /// </summary>
        public MouthOpen MouthOpen
        {
            get { return this._mouthOpen; }
            set { this._mouthOpen = value; }
        }

        // Check to see if MouthOpen property is set
        internal bool IsSetMouthOpen()
        {
            return this._mouthOpen != null;
        }

        /// <summary>
        /// Gets and sets the property Mustache. 
        /// <para>
        /// Indicates whether or not the face has a mustache, and the confidence level in the
        /// determination.
        /// </para>
        /// </summary>
        public Mustache Mustache
        {
            get { return this._mustache; }
            set { this._mustache = value; }
        }

        // Check to see if Mustache property is set
        internal bool IsSetMustache()
        {
            return this._mustache != null;
        }

        /// <summary>
        /// Gets and sets the property Pose. 
        /// <para>
        /// Indicates the pose of the face as determined by its pitch, roll, and yaw. Default
        /// attribute.
        /// </para>
        /// </summary>
        public Pose Pose
        {
            get { return this._pose; }
            set { this._pose = value; }
        }

        // Check to see if Pose property is set
        internal bool IsSetPose()
        {
            return this._pose != null;
        }

        /// <summary>
        /// Gets and sets the property Quality. 
        /// <para>
        /// Identifies image brightness and sharpness. Default attribute.
        /// </para>
        /// </summary>
        public ImageQuality Quality
        {
            get { return this._quality; }
            set { this._quality = value; }
        }

        // Check to see if Quality property is set
        internal bool IsSetQuality()
        {
            return this._quality != null;
        }

        /// <summary>
        /// Gets and sets the property Smile. 
        /// <para>
        /// Indicates whether or not the face is smiling, and the confidence level in the determination.
        /// </para>
        /// </summary>
        public Smile Smile
        {
            get { return this._smile; }
            set { this._smile = value; }
        }

        // Check to see if Smile property is set
        internal bool IsSetSmile()
        {
            return this._smile != null;
        }

        /// <summary>
        /// Gets and sets the property Sunglasses. 
        /// <para>
        /// Indicates whether or not the face is wearing sunglasses, and the confidence level
        /// in the determination.
        /// </para>
        /// </summary>
        public Sunglasses Sunglasses
        {
            get { return this._sunglasses; }
            set { this._sunglasses = value; }
        }

        // Check to see if Sunglasses property is set
        internal bool IsSetSunglasses()
        {
            return this._sunglasses != null;
        }

    }
}