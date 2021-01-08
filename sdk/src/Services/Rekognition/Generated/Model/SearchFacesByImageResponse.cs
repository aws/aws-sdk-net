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
    /// This is the response object from the SearchFacesByImage operation.
    /// </summary>
    public partial class SearchFacesByImageResponse : AmazonWebServiceResponse
    {
        private List<FaceMatch> _faceMatches = new List<FaceMatch>();
        private string _faceModelVersion;
        private BoundingBox _searchedFaceBoundingBox;
        private float? _searchedFaceConfidence;

        /// <summary>
        /// Gets and sets the property FaceMatches. 
        /// <para>
        /// An array of faces that match the input face, along with the confidence in the match.
        /// </para>
        /// </summary>
        public List<FaceMatch> FaceMatches
        {
            get { return this._faceMatches; }
            set { this._faceMatches = value; }
        }

        // Check to see if FaceMatches property is set
        internal bool IsSetFaceMatches()
        {
            return this._faceMatches != null && this._faceMatches.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FaceModelVersion. 
        /// <para>
        /// Version number of the face detection model associated with the input collection (<code>CollectionId</code>).
        /// </para>
        /// </summary>
        public string FaceModelVersion
        {
            get { return this._faceModelVersion; }
            set { this._faceModelVersion = value; }
        }

        // Check to see if FaceModelVersion property is set
        internal bool IsSetFaceModelVersion()
        {
            return this._faceModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SearchedFaceBoundingBox. 
        /// <para>
        /// The bounding box around the face in the input image that Amazon Rekognition used for
        /// the search.
        /// </para>
        /// </summary>
        public BoundingBox SearchedFaceBoundingBox
        {
            get { return this._searchedFaceBoundingBox; }
            set { this._searchedFaceBoundingBox = value; }
        }

        // Check to see if SearchedFaceBoundingBox property is set
        internal bool IsSetSearchedFaceBoundingBox()
        {
            return this._searchedFaceBoundingBox != null;
        }

        /// <summary>
        /// Gets and sets the property SearchedFaceConfidence. 
        /// <para>
        /// The level of confidence that the <code>searchedFaceBoundingBox</code>, contains a
        /// face.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float SearchedFaceConfidence
        {
            get { return this._searchedFaceConfidence.GetValueOrDefault(); }
            set { this._searchedFaceConfidence = value; }
        }

        // Check to see if SearchedFaceConfidence property is set
        internal bool IsSetSearchedFaceConfidence()
        {
            return this._searchedFaceConfidence.HasValue; 
        }

    }
}