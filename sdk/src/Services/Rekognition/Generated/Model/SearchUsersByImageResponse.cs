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
    /// This is the response object from the SearchUsersByImage operation.
    /// </summary>
    public partial class SearchUsersByImageResponse : AmazonWebServiceResponse
    {
        private string _faceModelVersion;
        private SearchedFaceDetails _searchedFace;
        private List<UnsearchedFace> _unsearchedFaces = AWSConfigs.InitializeCollections ? new List<UnsearchedFace>() : null;
        private List<UserMatch> _userMatches = AWSConfigs.InitializeCollections ? new List<UserMatch>() : null;

        /// <summary>
        /// Gets and sets the property FaceModelVersion. 
        /// <para>
        /// Version number of the face detection model associated with the input collection CollectionId.
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
        /// Gets and sets the property SearchedFace. 
        /// <para>
        /// A list of FaceDetail objects containing the BoundingBox for the largest face in image,
        /// as well as the confidence in the bounding box, that was searched for matches. If no
        /// valid face is detected in the image the response will contain no SearchedFace object.
        /// </para>
        /// </summary>
        public SearchedFaceDetails SearchedFace
        {
            get { return this._searchedFace; }
            set { this._searchedFace = value; }
        }

        // Check to see if SearchedFace property is set
        internal bool IsSetSearchedFace()
        {
            return this._searchedFace != null;
        }

        /// <summary>
        /// Gets and sets the property UnsearchedFaces. 
        /// <para>
        /// List of UnsearchedFace objects. Contains the face details infered from the specified
        /// image but not used for search. Contains reasons that describe why a face wasn't used
        /// for Search. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnsearchedFace> UnsearchedFaces
        {
            get { return this._unsearchedFaces; }
            set { this._unsearchedFaces = value; }
        }

        // Check to see if UnsearchedFaces property is set
        internal bool IsSetUnsearchedFaces()
        {
            return this._unsearchedFaces != null && (this._unsearchedFaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserMatches. 
        /// <para>
        /// An array of UserID objects that matched the input face, along with the confidence
        /// in the match. The returned structure will be empty if there are no matches. Returned
        /// if the SearchUsersByImageResponse action is successful.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=500)]
        public List<UserMatch> UserMatches
        {
            get { return this._userMatches; }
            set { this._userMatches = value; }
        }

        // Check to see if UserMatches property is set
        internal bool IsSetUserMatches()
        {
            return this._userMatches != null && (this._userMatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}