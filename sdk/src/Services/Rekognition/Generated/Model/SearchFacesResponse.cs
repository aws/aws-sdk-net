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
    /// This is the response object from the SearchFaces operation.
    /// </summary>
    public partial class SearchFacesResponse : AmazonWebServiceResponse
    {
        private List<FaceMatch> _faceMatches = AWSConfigs.InitializeCollections ? new List<FaceMatch>() : null;
        private string _faceModelVersion;
        private string _searchedFaceId;

        /// <summary>
        /// Gets and sets the property FaceMatches. 
        /// <para>
        /// An array of faces that matched the input face, along with the confidence in the match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FaceMatch> FaceMatches
        {
            get { return this._faceMatches; }
            set { this._faceMatches = value; }
        }

        // Check to see if FaceMatches property is set
        internal bool IsSetFaceMatches()
        {
            return this._faceMatches != null && (this._faceMatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FaceModelVersion. 
        /// <para>
        /// Version number of the face detection model associated with the input collection (<c>CollectionId</c>).
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
        /// Gets and sets the property SearchedFaceId. 
        /// <para>
        /// ID of the face that was searched for matches in a collection.
        /// </para>
        /// </summary>
        public string SearchedFaceId
        {
            get { return this._searchedFaceId; }
            set { this._searchedFaceId = value; }
        }

        // Check to see if SearchedFaceId property is set
        internal bool IsSetSearchedFaceId()
        {
            return this._searchedFaceId != null;
        }

    }
}