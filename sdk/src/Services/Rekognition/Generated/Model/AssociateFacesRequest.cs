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
    /// Container for the parameters to the AssociateFaces operation.
    /// Associates one or more faces with an existing UserID. Takes an array of <c>FaceIds</c>.
    /// Each <c>FaceId</c> that are present in the <c>FaceIds</c> list is associated with
    /// the provided UserID. The number of FaceIds that can be used as input in a single request
    /// is limited to 100.
    /// 
    ///  
    /// <para>
    /// Note that the total number of faces that can be associated with a single <c>UserID</c>
    /// is also limited to 100. Once a <c>UserID</c> has 100 faces associated with it, no
    /// additional faces can be added. If more API calls are made after the limit is reached,
    /// a <c>ServiceQuotaExceededException</c> will result.
    /// </para>
    ///  
    /// <para>
    /// The <c>UserMatchThreshold</c> parameter specifies the minimum user match confidence
    /// required for the face to be associated with a UserID that has at least one <c>FaceID</c>
    /// already associated. This ensures that the <c>FaceIds</c> are associated with the right
    /// UserID. The value ranges from 0-100 and default value is 75. 
    /// </para>
    ///  
    /// <para>
    /// If successful, an array of <c>AssociatedFace</c> objects containing the associated
    /// <c>FaceIds</c> is returned. If a given face is already associated with the given <c>UserID</c>,
    /// it will be ignored and will not be returned in the response. If a given face is already
    /// associated to a different <c>UserID</c>, isn't found in the collection, doesn’t meet
    /// the <c>UserMatchThreshold</c>, or there are already 100 faces associated with the
    /// <c>UserID</c>, it will be returned as part of an array of <c>UnsuccessfulFaceAssociations.</c>
    /// 
    /// </para>
    ///  
    /// <para>
    /// The <c>UserStatus</c> reflects the status of an operation which updates a UserID representation
    /// with a list of given faces. The <c>UserStatus</c> can be: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// ACTIVE - All associations or disassociations of FaceID(s) for a UserID are complete.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CREATED - A UserID has been created, but has no FaceID(s) associated with it.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// UPDATING - A UserID is being updated and there are current associations or disassociations
    /// of FaceID(s) taking place.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AssociateFacesRequest : AmazonRekognitionRequest
    {
        private string _clientRequestToken;
        private string _collectionId;
        private List<string> _faceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _userId;
        private float? _userMatchThreshold;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Idempotent token used to identify the request to <c>AssociateFaces</c>. If you use
        /// the same token with multiple <c>AssociateFaces</c> requests, the same response is
        /// returned. Use ClientRequestToken to prevent the same request from being processed
        /// more than once.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// The ID of an existing collection containing the UserID.
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
        /// Gets and sets the property FaceIds. 
        /// <para>
        /// An array of FaceIDs to associate with the UserID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> FaceIds
        {
            get { return this._faceIds; }
            set { this._faceIds = value; }
        }

        // Check to see if FaceIds property is set
        internal bool IsSetFaceIds()
        {
            return this._faceIds != null && (this._faceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID for the existing UserID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property UserMatchThreshold. 
        /// <para>
        /// An optional value specifying the minimum confidence in the UserID match to return.
        /// The default value is 75.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? UserMatchThreshold
        {
            get { return this._userMatchThreshold; }
            set { this._userMatchThreshold = value; }
        }

        // Check to see if UserMatchThreshold property is set
        internal bool IsSetUserMatchThreshold()
        {
            return this._userMatchThreshold.HasValue; 
        }

    }
}