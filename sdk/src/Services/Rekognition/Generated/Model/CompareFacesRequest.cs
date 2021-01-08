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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the CompareFaces operation.
    /// Compares a face in the <i>source</i> input image with each of the 100 largest faces
    /// detected in the <i>target</i> input image. 
    /// 
    ///  <note> 
    /// <para>
    ///  If the source image contains multiple faces, the service detects the largest face
    /// and compares it with each face detected in the target image. 
    /// </para>
    ///  </note> 
    /// <para>
    /// You pass the input and target images either as base64-encoded image bytes or as references
    /// to images in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
    /// operations, passing image bytes isn't supported. The image must be formatted as a
    /// PNG or JPEG file. 
    /// </para>
    ///  
    /// <para>
    /// In response, the operation returns an array of face matches ordered by similarity
    /// score in descending order. For each face match, the response provides a bounding box
    /// of the face, facial landmarks, pose details (pitch, role, and yaw), quality (brightness
    /// and sharpness), and confidence value (indicating the level of confidence that the
    /// bounding box contains a face). The response also provides a similarity score, which
    /// indicates how closely the faces match. 
    /// </para>
    ///  <note> 
    /// <para>
    /// By default, only faces with a similarity score of greater than or equal to 80% are
    /// returned in the response. You can change this value by specifying the <code>SimilarityThreshold</code>
    /// parameter.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <code>CompareFaces</code> also returns an array of faces that don't match the source
    /// image. For each face, it returns a bounding box, confidence value, landmarks, pose
    /// details, and quality. The response also returns information about the face in the
    /// source image, including the bounding box of the face and confidence value.
    /// </para>
    ///  
    /// <para>
    /// The <code>QualityFilter</code> input parameter allows you to filter out detected faces
    /// that don’t meet a required quality bar. The quality bar is based on a variety of common
    /// use cases. Use <code>QualityFilter</code> to set the quality bar by specifying <code>LOW</code>,
    /// <code>MEDIUM</code>, or <code>HIGH</code>. If you do not want to filter detected faces,
    /// specify <code>NONE</code>. The default value is <code>NONE</code>. 
    /// </para>
    ///  
    /// <para>
    /// If the image doesn't contain Exif metadata, <code>CompareFaces</code> returns orientation
    /// information for the source and target images. Use these values to display the images
    /// with the correct image orientation.
    /// </para>
    ///  
    /// <para>
    /// If no faces are detected in the source or target images, <code>CompareFaces</code>
    /// returns an <code>InvalidParameterException</code> error. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  This is a stateless API operation. That is, data returned by this operation doesn't
    /// persist.
    /// </para>
    ///  </note> 
    /// <para>
    /// For an example, see Comparing Faces in Images in the Amazon Rekognition Developer
    /// Guide.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:CompareFaces</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class CompareFacesRequest : AmazonRekognitionRequest
    {
        private QualityFilter _qualityFilter;
        private float? _similarityThreshold;
        private Image _sourceImage;
        private Image _targetImage;

        /// <summary>
        /// Gets and sets the property QualityFilter. 
        /// <para>
        /// A filter that specifies a quality bar for how much filtering is done to identify faces.
        /// Filtered faces aren't compared. If you specify <code>AUTO</code>, Amazon Rekognition
        /// chooses the quality bar. If you specify <code>LOW</code>, <code>MEDIUM</code>, or
        /// <code>HIGH</code>, filtering removes all faces that don’t meet the chosen quality
        /// bar. The quality bar is based on a variety of common use cases. Low-quality detections
        /// can occur for a number of reasons. Some examples are an object that's misidentified
        /// as a face, a face that's too blurry, or a face with a pose that's too extreme to use.
        /// If you specify <code>NONE</code>, no filtering is performed. The default value is
        /// <code>NONE</code>. 
        /// </para>
        ///  
        /// <para>
        /// To use quality filtering, the collection you are using must be associated with version
        /// 3 of the face model or higher.
        /// </para>
        /// </summary>
        public QualityFilter QualityFilter
        {
            get { return this._qualityFilter; }
            set { this._qualityFilter = value; }
        }

        // Check to see if QualityFilter property is set
        internal bool IsSetQualityFilter()
        {
            return this._qualityFilter != null;
        }

        /// <summary>
        /// Gets and sets the property SimilarityThreshold. 
        /// <para>
        /// The minimum level of confidence in the face matches that a match must meet to be included
        /// in the <code>FaceMatches</code> array.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float SimilarityThreshold
        {
            get { return this._similarityThreshold.GetValueOrDefault(); }
            set { this._similarityThreshold = value; }
        }

        // Check to see if SimilarityThreshold property is set
        internal bool IsSetSimilarityThreshold()
        {
            return this._similarityThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceImage. 
        /// <para>
        /// The input image as base64-encoded bytes or an S3 object. If you use the AWS CLI to
        /// call Amazon Rekognition operations, passing base64-encoded image bytes is not supported.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you are using an AWS SDK to call Amazon Rekognition, you might not need to base64-encode
        /// image bytes passed using the <code>Bytes</code> field. For more information, see Images
        /// in the Amazon Rekognition developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Image SourceImage
        {
            get { return this._sourceImage; }
            set { this._sourceImage = value; }
        }

        // Check to see if SourceImage property is set
        internal bool IsSetSourceImage()
        {
            return this._sourceImage != null;
        }

        /// <summary>
        /// Gets and sets the property TargetImage. 
        /// <para>
        /// The target image as base64-encoded bytes or an S3 object. If you use the AWS CLI to
        /// call Amazon Rekognition operations, passing base64-encoded image bytes is not supported.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you are using an AWS SDK to call Amazon Rekognition, you might not need to base64-encode
        /// image bytes passed using the <code>Bytes</code> field. For more information, see Images
        /// in the Amazon Rekognition developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Image TargetImage
        {
            get { return this._targetImage; }
            set { this._targetImage = value; }
        }

        // Check to see if TargetImage property is set
        internal bool IsSetTargetImage()
        {
            return this._targetImage != null;
        }

    }
}