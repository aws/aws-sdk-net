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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the CompareFaces operation.
    /// Compares a face in the <i>source</i> input image with each face detected in the <i>target</i>
    /// input image. 
    /// 
    ///  <note> 
    /// <para>
    ///  If the source image contains multiple faces, the service detects the largest face
    /// and uses it to compare with each face detected in the target image. 
    /// </para>
    ///  </note> 
    /// <para>
    /// In response, the operation returns an array of face matches ordered by similarity
    /// score with the highest similarity scores first. For each face match, the response
    /// provides a bounding box of the face and <code>confidence</code> value (indicating
    /// the level of confidence that the bounding box contains a face). The response also
    /// provides a <code>similarity</code> score, which indicates how closely the faces match.
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// By default, only faces with the similarity score of greater than or equal to 80% are
    /// returned in the response. You can change this value.
    /// </para>
    ///  </note> 
    /// <para>
    /// In addition to the face matches, the response returns information about the face in
    /// the source image, including the bounding box of the face and confidence value.
    /// </para>
    ///  <note> 
    /// <para>
    ///  This is a stateless API operation. That is, the operation does not persist any data.
    /// </para>
    ///  </note> 
    /// <para>
    /// For an example, see <a>get-started-exercise-compare-faces</a> 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:CompareFaces</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class CompareFacesRequest : AmazonRekognitionRequest
    {
        private float? _similarityThreshold;
        private Image _sourceImage;
        private Image _targetImage;

        /// <summary>
        /// Gets and sets the property SimilarityThreshold. 
        /// <para>
        /// The minimum level of confidence in the match you want included in the result.
        /// </para>
        /// </summary>
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
        /// Source image either as bytes or an Amazon S3 object
        /// </para>
        /// </summary>
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
        /// Target image either as bytes or an Amazon S3 object
        /// </para>
        /// </summary>
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