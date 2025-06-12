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
    /// Container for the parameters to the CreateCollection operation.
    /// Creates a collection in an AWS Region. You can add faces to the collection using the
    /// <a>IndexFaces</a> operation. 
    /// 
    ///  
    /// <para>
    /// For example, you might create collections, one for each of your application users.
    /// A user can then index faces using the <c>IndexFaces</c> operation and persist results
    /// in a specific collection. Then, a user can search the collection for faces in the
    /// user-specific container. 
    /// </para>
    ///  
    /// <para>
    /// When you create a collection, it is associated with the latest version of the face
    /// model version.
    /// </para>
    ///  <note> 
    /// <para>
    /// Collection names are case-sensitive.
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation requires permissions to perform the <c>rekognition:CreateCollection</c>
    /// action. If you want to tag your collection, you also require permission to perform
    /// the <c>rekognition:TagResource</c> operation.
    /// </para>
    /// </summary>
    public partial class CreateCollectionRequest : AmazonRekognitionRequest
    {
        private string _collectionId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// ID for the collection that you are creating.
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
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A set of tags (key-value pairs) that you want to attach to the collection. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}