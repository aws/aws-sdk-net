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
    /// Container for the parameters to the SearchUsers operation.
    /// Searches for UserIDs within a collection based on a <c>FaceId</c> or <c>UserId</c>.
    /// This API can be used to find the closest UserID (with a highest similarity) to associate
    /// a face. The request must be provided with either <c>FaceId</c> or <c>UserId</c>. The
    /// operation returns an array of UserID that match the <c>FaceId</c> or <c>UserId</c>,
    /// ordered by similarity score with the highest similarity first.
    /// </summary>
    public partial class SearchUsersRequest : AmazonRekognitionRequest
    {
        private string _collectionId;
        private string _faceId;
        private int? _maxUsers;
        private string _userId;
        private float? _userMatchThreshold;

        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// The ID of an existing collection containing the UserID, used with a UserId or FaceId.
        /// If a FaceId is provided, UserId isn’t required to be present in the Collection.
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
        /// ID for the existing face.
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
        /// Gets and sets the property MaxUsers. 
        /// <para>
        /// Maximum number of identities to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int? MaxUsers
        {
            get { return this._maxUsers; }
            set { this._maxUsers = value; }
        }

        // Check to see if MaxUsers property is set
        internal bool IsSetMaxUsers()
        {
            return this._maxUsers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// ID for the existing User.
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

        /// <summary>
        /// Gets and sets the property UserMatchThreshold. 
        /// <para>
        /// Optional value that specifies the minimum confidence in the matched UserID to return.
        /// Default value of 80.
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