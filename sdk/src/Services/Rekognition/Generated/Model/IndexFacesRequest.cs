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
    ///  Amazon Rekognition does not save the actual faces detected. Instead, the underlying
    /// detection algorithm first detects the faces in the input image, and for each face
    /// extracts facial features into a feature vector, and stores it in the back-end database.
    /// Amazon Rekognition uses feature vectors when performing face match and search operations
    /// using the and operations. 
    /// </para>
    ///  
    /// <para>
    /// If you provide the optional <code>externalImageID</code> for the input image you provided,
    /// Amazon Rekognition associates this ID with all faces that it detects. When you call
    /// the operation, the response returns the external ID. You can use this external image
    /// ID to create a client-side index to associate the faces with each image. You can then
    /// use the index to find all faces in an image. 
    /// </para>
    ///  
    /// <para>
    /// In response, the operation returns an array of metadata for all detected faces. This
    /// includes, the bounding box of the detected face, confidence value (indicating the
    /// bounding box contains a face), a face ID assigned by the service for each face that
    /// is detected and stored, and an image ID assigned by the service for the input image
    /// If you request all facial attributes (using the <code>detectionAttributes</code> parameter,
    /// Amazon Rekognition returns detailed facial attributes such as facial landmarks (for
    /// example, location of eye and mount) and other facial attributes such gender. If you
    /// provide the same image, specify the same collection, and use the same external ID
    /// in the <code>IndexFaces</code> operation, Amazon Rekognition doesn't save duplicate
    /// face metadata. 
    /// </para>
    ///  
    /// <para>
    /// For an example, see <a>example2</a>.
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

        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// ID of an existing collection to which you want to add the faces that are detected
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
        /// A list of facial attributes you want to be returned. This can be the default list
        /// of attributes or all attributes. If you don't specify a value for <code>Attributes</code>
        /// or if you specify <code>["DEFAULT"]</code>, the API returns the following subset of
        /// facial attributes: <code>BoundingBox</code>, <code>Confidence</code>, <code>Pose</code>,
        /// <code>Quality</code> and <code>Landmarks</code>. If you provide <code>["ALL"]</code>,
        /// all facial attributes are returned but the operation will take longer to complete.
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
        /// ID you want to assign to all the faces detected in the image.
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

    }
}