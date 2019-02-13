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
    /// Container for the parameters to the IndexFaces operation.
    /// Detects faces in the input image and adds them to the specified collection. 
    /// 
    ///  
    /// <para>
    /// Amazon Rekognition doesn't save the actual faces that are detected. Instead, the underlying
    /// detection algorithm first detects the faces in the input image. For each face, the
    /// algorithm extracts facial features into a feature vector, and stores it in the backend
    /// database. Amazon Rekognition uses feature vectors when it performs face match and
    /// search operations using the <a>SearchFaces</a> and <a>SearchFacesByImage</a> operations.
    /// </para>
    ///  
    /// <para>
    /// For more information, see Adding Faces to a Collection in the Amazon Rekognition Developer
    /// Guide.
    /// </para>
    ///  
    /// <para>
    /// To get the number of faces in a collection, call <a>DescribeCollection</a>. 
    /// </para>
    ///  
    /// <para>
    /// If you're using version 1.0 of the face detection model, <code>IndexFaces</code> indexes
    /// the 15 largest faces in the input image. Later versions of the face detection model
    /// index the 100 largest faces in the input image. 
    /// </para>
    ///  
    /// <para>
    /// If you're using version 4 or later of the face model, image orientation information
    /// is not returned in the <code>OrientationCorrection</code> field. 
    /// </para>
    ///  
    /// <para>
    /// To determine which version of the model you're using, call <a>DescribeCollection</a>
    /// and supply the collection ID. You can also get the model version from the value of
    /// <code>FaceModelVersion</code> in the response from <code>IndexFaces</code> 
    /// </para>
    ///  
    /// <para>
    /// For more information, see Model Versioning in the Amazon Rekognition Developer Guide.
    /// </para>
    ///  
    /// <para>
    /// If you provide the optional <code>ExternalImageID</code> for the input image you provided,
    /// Amazon Rekognition associates this ID with all faces that it detects. When you call
    /// the <a>ListFaces</a> operation, the response returns the external ID. You can use
    /// this external image ID to create a client-side index to associate the faces with each
    /// image. You can then use the index to find all faces in an image.
    /// </para>
    ///  
    /// <para>
    /// You can specify the maximum number of faces to index with the <code>MaxFaces</code>
    /// input parameter. This is useful when you want to index the largest faces in an image
    /// and don't want to index smaller faces, such as those belonging to people standing
    /// in the background.
    /// </para>
    ///  
    /// <para>
    /// The <code>QualityFilter</code> input parameter allows you to filter out detected faces
    /// that don’t meet the required quality bar chosen by Amazon Rekognition. The quality
    /// bar is based on a variety of common use cases. By default, <code>IndexFaces</code>
    /// filters detected faces. You can also explicitly filter detected faces by specifying
    /// <code>AUTO</code> for the value of <code>QualityFilter</code>. If you do not want
    /// to filter detected faces, specify <code>NONE</code>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// To use quality filtering, you need a collection associated with version 3 of the face
    /// model. To get the version of the face model associated with a collection, call <a>DescribeCollection</a>.
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    /// Information about faces detected in an image, but not indexed, is returned in an array
    /// of <a>UnindexedFace</a> objects, <code>UnindexedFaces</code>. Faces aren't indexed
    /// for reasons such as:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The number of faces detected exceeds the value of the <code>MaxFaces</code> request
    /// parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The face is too small compared to the image dimensions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The face is too blurry.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The image is too dark.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The face has an extreme pose.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// In response, the <code>IndexFaces</code> operation returns an array of metadata for
    /// all detected faces, <code>FaceRecords</code>. This includes: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The bounding box, <code>BoundingBox</code>, of the detected face. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A confidence value, <code>Confidence</code>, which indicates the confidence that the
    /// bounding box contains a face.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A face ID, <code>FaceId</code>, assigned by the service for each face that's detected
    /// and stored.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An image ID, <code>ImageId</code>, assigned by the service for the input image.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you request all facial attributes (by using the <code>detectionAttributes</code>
    /// parameter), Amazon Rekognition returns detailed facial attributes, such as facial
    /// landmarks (for example, location of eye and mouth) and other facial attributes like
    /// gender. If you provide the same image, specify the same collection, and use the same
    /// external ID in the <code>IndexFaces</code> operation, Amazon Rekognition doesn't save
    /// duplicate face metadata.
    /// </para>
    ///   
    /// <para>
    /// The input image is passed either as base64-encoded image bytes, or as a reference
    /// to an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
    /// operations, passing image bytes isn't supported. The image must be formatted as a
    /// PNG or JPEG file. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:IndexFaces</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class IndexFacesRequest : AmazonRekognitionRequest
    {
        private string _collectionId;
        private List<string> _detectionAttributes = new List<string>();
        private string _externalImageId;
        private Image _image;
        private int? _maxFaces;
        private QualityFilter _qualityFilter;

        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// The ID of an existing collection to which you want to add the faces that are detected
        /// in the input images.
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
        /// Gets and sets the property DetectionAttributes. 
        /// <para>
        /// An array of facial attributes that you want to be returned. This can be the default
        /// list of attributes or all attributes. If you don't specify a value for <code>Attributes</code>
        /// or if you specify <code>["DEFAULT"]</code>, the API returns the following subset of
        /// facial attributes: <code>BoundingBox</code>, <code>Confidence</code>, <code>Pose</code>,
        /// <code>Quality</code>, and <code>Landmarks</code>. If you provide <code>["ALL"]</code>,
        /// all facial attributes are returned, but the operation takes longer to complete.
        /// </para>
        ///  
        /// <para>
        /// If you provide both, <code>["ALL", "DEFAULT"]</code>, the service uses a logical AND
        /// operator to determine which attributes to return (in this case, all attributes). 
        /// </para>
        /// </summary>
        public List<string> DetectionAttributes
        {
            get { return this._detectionAttributes; }
            set { this._detectionAttributes = value; }
        }

        // Check to see if DetectionAttributes property is set
        internal bool IsSetDetectionAttributes()
        {
            return this._detectionAttributes != null && this._detectionAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExternalImageId. 
        /// <para>
        /// The ID you want to assign to all the faces detected in the image.
        /// </para>
        /// </summary>
        public string ExternalImageId
        {
            get { return this._externalImageId; }
            set { this._externalImageId = value; }
        }

        // Check to see if ExternalImageId property is set
        internal bool IsSetExternalImageId()
        {
            return this._externalImageId != null;
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The input image as base64-encoded bytes or an S3 object. If you use the AWS CLI to
        /// call Amazon Rekognition operations, passing base64-encoded image bytes isn't supported.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you are using an AWS SDK to call Amazon Rekognition, you might not need to base64-encode
        /// image bytes passed using the <code>Bytes</code> field. For more information, see Images
        /// in the Amazon Rekognition developer guide.
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
        /// The maximum number of faces to index. The value of <code>MaxFaces</code> must be greater
        /// than or equal to 1. <code>IndexFaces</code> returns no more than 100 detected faces
        /// in an image, even if you specify a larger value for <code>MaxFaces</code>.
        /// </para>
        ///  
        /// <para>
        /// If <code>IndexFaces</code> detects more faces than the value of <code>MaxFaces</code>,
        /// the faces with the lowest quality are filtered out first. If there are still more
        /// faces than the value of <code>MaxFaces</code>, the faces with the smallest bounding
        /// boxes are filtered out (up to the number that's needed to satisfy the value of <code>MaxFaces</code>).
        /// Information about the unindexed faces is available in the <code>UnindexedFaces</code>
        /// array. 
        /// </para>
        ///  
        /// <para>
        /// The faces that are returned by <code>IndexFaces</code> are sorted by the largest face
        /// bounding box size to the smallest size, in descending order.
        /// </para>
        ///  
        /// <para>
        ///  <code>MaxFaces</code> can be used with a collection associated with any version of
        /// the face model.
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

        /// <summary>
        /// Gets and sets the property QualityFilter. 
        /// <para>
        /// A filter that specifies how much filtering is done to identify faces that are detected
        /// with low quality. Filtered faces aren't indexed. If you specify <code>AUTO</code>,
        /// filtering prioritizes the identification of faces that don’t meet the required quality
        /// bar chosen by Amazon Rekognition. The quality bar is based on a variety of common
        /// use cases. Low-quality detections can occur for a number of reasons. Some examples
        /// are an object that's misidentified as a face, a face that's too blurry, or a face
        /// with a pose that's too extreme to use. If you specify <code>NONE</code>, no filtering
        /// is performed. The default value is AUTO.
        /// </para>
        ///  
        /// <para>
        /// To use quality filtering, the collection you are using must be associated with version
        /// 3 of the face model.
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

    }
}