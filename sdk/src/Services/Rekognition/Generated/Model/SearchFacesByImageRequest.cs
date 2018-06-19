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
    /// Container for the parameters to the SearchFacesByImage operation.
    /// For a given input image, first detects the largest face in the image, and then searches
    /// the specified collection for matching faces. The operation compares the features of
    /// the input face with faces in the specified collection. 
    /// 
    ///  <note> 
    /// <para>
    /// To search for all faces in an input image, you might first call the operation, and
    /// then use the face IDs returned in subsequent calls to the operation. 
    /// </para>
    ///  
    /// <para>
    ///  You can also call the <code>DetectFaces</code> operation and use the bounding boxes
    /// in the response to make face crops, which then you can pass in to the <code>SearchFacesByImage</code>
    /// operation. 
    /// </para>
    ///  </note> 
    /// <para>
    /// You pass the input image either as base64-encoded image bytes or as a reference to
    /// an image in an Amazon S3 bucket. If you use the Amazon CLI to call Amazon Rekognition
    /// operations, passing image bytes is not supported. The image must be either a PNG or
    /// JPEG formatted file. 
    /// </para>
    ///  
    /// <para>
    ///  The response returns an array of faces that match, ordered by similarity score with
    /// the highest similarity first. More specifically, it is an array of metadata for each
    /// face match found. Along with the metadata, the response also includes a <code>similarity</code>
    /// indicating how similar the face is to the input face. In the response, the operation
    /// also returns the bounding box (and a confidence level that the bounding box contains
    /// a face) of the face that Amazon Rekognition used for the input image. 
    /// </para>
    ///  
    /// <para>
    /// For an example, Searching for a Face Using an Image in the Amazon Rekognition Developer
    /// Guide.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:SearchFacesByImage</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class SearchFacesByImageRequest : AmazonRekognitionRequest
    {
        private string _collectionId;
        private float? _faceMatchThreshold;
        private Image _image;
        private int? _maxFaces;

        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// ID of the collection to search.
        /// </para>
        /// </summary>
        public string CollectionId
        {
            get { return this._collectionId; }
            set { this._collectionId = value; }
        }

        // Check to see if CollectionId property is set
        internal bool IsSetCollectionId()
        {
            return this._collectionId != null;
        }

        /// <summary>
        /// Gets and sets the property FaceMatchThreshold. 
        /// <para>
        /// (Optional) Specifies the minimum confidence in the face match to return. For example,
        /// don't return any matches where confidence in matches is less than 70%.
        /// </para>
        /// </summary>
        public float FaceMatchThreshold
        {
            get { return this._faceMatchThreshold.GetValueOrDefault(); }
            set { this._faceMatchThreshold = value; }
        }

        // Check to see if FaceMatchThreshold property is set
        internal bool IsSetFaceMatchThreshold()
        {
            return this._faceMatchThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The input image as base64-encoded bytes or an S3 object. If you use the AWS CLI to
        /// call Amazon Rekognition operations, passing base64-encoded image bytes is not supported.
        /// 
        /// </para>
        /// </summary>
        public Image Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property MaxFaces. 
        /// <para>
        /// Maximum number of faces to return. The operation returns the maximum number of faces
        /// with the highest confidence in the match.
        /// </para>
        /// </summary>
        public int MaxFaces
        {
            get { return this._maxFaces.GetValueOrDefault(); }
            set { this._maxFaces = value; }
        }

        // Check to see if MaxFaces property is set
        internal bool IsSetMaxFaces()
        {
            return this._maxFaces.HasValue; 
        }

    }
}