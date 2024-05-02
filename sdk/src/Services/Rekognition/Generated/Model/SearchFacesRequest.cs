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
    /// Container for the parameters to the SearchFaces operation.
    /// For a given input face ID, searches for matching faces in the collection the face
    /// belongs to. You get a face ID when you add a face to the collection using the <a>IndexFaces</a>
    /// operation. The operation compares the features of the input face with faces in the
    /// specified collection. 
    /// 
    ///  <note> 
    /// <para>
    /// You can also search faces without indexing faces by using the <c>SearchFacesByImage</c>
    /// operation.
    /// </para>
    ///  </note> 
    /// <para>
    ///  The operation response returns an array of faces that match, ordered by similarity
    /// score with the highest similarity first. More specifically, it is an array of metadata
    /// for each face match that is found. Along with the metadata, the response also includes
    /// a <c>confidence</c> value for each face match, indicating the confidence that the
    /// specific face matches the input face. 
    /// </para>
    ///  
    /// <para>
    /// For an example, see Searching for a face using its face ID in the Amazon Rekognition
    /// Developer Guide.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>rekognition:SearchFaces</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class SearchFacesRequest : AmazonRekognitionRequest
    {
        private string _collectionId;
        private string _faceId;
        private float? _faceMatchThreshold;
        private int? _maxFaces;

        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// ID of the collection the face belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property FaceId. 
        /// <para>
        /// ID of a face to find matches for in the collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FaceMatchThreshold. 
        /// <para>
        /// Optional value specifying the minimum confidence in the face match to return. For
        /// example, don't return any matches where confidence in matches is less than 70%. The
        /// default value is 80%. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? FaceMatchThreshold
        {
            get { return this._faceMatchThreshold; }
            set { this._faceMatchThreshold = value; }
        }

        // Check to see if FaceMatchThreshold property is set
        internal bool IsSetFaceMatchThreshold()
        {
            return this._faceMatchThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFaces. 
        /// <para>
        /// Maximum number of faces to return. The operation returns the maximum number of faces
        /// with the highest confidence in the match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public int? MaxFaces
        {
            get { return this._maxFaces; }
            set { this._maxFaces = value; }
        }

        // Check to see if MaxFaces property is set
        internal bool IsSetMaxFaces()
        {
            return this._maxFaces.HasValue; 
        }

    }
}