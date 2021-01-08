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
    /// Container for the parameters to the DeleteFaces operation.
    /// Deletes faces from a collection. You specify a collection ID and an array of face
    /// IDs to remove from the collection.
    /// 
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:DeleteFaces</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class DeleteFacesRequest : AmazonRekognitionRequest
    {
        private string _collectionId;
        private List<string> _faceIds = new List<string>();

        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// Collection from which to remove the specific faces.
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
        /// An array of face IDs to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
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

    }
}