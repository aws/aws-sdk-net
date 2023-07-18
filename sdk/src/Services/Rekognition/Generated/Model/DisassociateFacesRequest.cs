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
    /// Container for the parameters to the DisassociateFaces operation.
    /// Removes the association between a <code>Face</code> supplied in an array of <code>FaceIds</code>
    /// and the User. If the User is not present already, then a <code>ResourceNotFound</code>
    /// exception is thrown. If successful, an array of faces that are disassociated from
    /// the User is returned. If a given face is already disassociated from the given UserID,
    /// it will be ignored and not be returned in the response. If a given face is already
    /// associated with a different User or not found in the collection it will be returned
    /// as part of <code>UnsuccessfulDisassociations</code>. You can remove 1 - 100 face IDs
    /// from a user at one time.
    /// </summary>
    public partial class DisassociateFacesRequest : AmazonRekognitionRequest
    {
        private string _clientRequestToken;
        private string _collectionId;
        private List<string> _faceIds = new List<string>();
        private string _userId;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Idempotent token used to identify the request to <code>DisassociateFaces</code>. If
        /// you use the same token with multiple <code>DisassociateFaces</code> requests, the
        /// same response is returned. Use ClientRequestToken to prevent the same request from
        /// being processed more than once.
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
        /// An array of face IDs to disassociate from the UserID. 
        /// </para>
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
            return this._faceIds != null && this._faceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// ID for the existing UserID.
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

    }
}