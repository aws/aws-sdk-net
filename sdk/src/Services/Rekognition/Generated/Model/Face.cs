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
    /// Describes the face properties such as the bounding box, face ID, image ID of the input
    /// image, and external image ID that you assigned.
    /// </summary>
    public partial class Face
    {
        private BoundingBox _boundingBox;
        private float? _confidence;
        private string _externalImageId;
        private string _faceId;
        private string _imageId;
        private string _indexFacesModelVersion;
        private string _userId;

        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// Bounding box of the face.
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
        /// such as a tree).
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
        /// Gets and sets the property ExternalImageId. 
        /// <para>
        /// Identifier that you assign to all the faces in the input image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property FaceId. 
        /// <para>
        /// Unique identifier that Amazon Rekognition assigns to the face.
        /// </para>
        /// </summary>
        public string FaceId
        {
            get { return this._faceId; }
            set { this._faceId = value; }
        }

        // Check to see if FaceId property is set
        internal bool IsSetFaceId()
        {
            return this._faceId != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// Unique identifier that Amazon Rekognition assigns to the input image.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property IndexFacesModelVersion. 
        /// <para>
        ///  The version of the face detect and storage model that was used when indexing the
        /// face vector. 
        /// </para>
        /// </summary>
        public string IndexFacesModelVersion
        {
            get { return this._indexFacesModelVersion; }
            set { this._indexFacesModelVersion = value; }
        }

        // Check to see if IndexFacesModelVersion property is set
        internal bool IsSetIndexFacesModelVersion()
        {
            return this._indexFacesModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// Unique identifier assigned to the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}