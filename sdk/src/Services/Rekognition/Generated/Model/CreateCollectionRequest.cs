/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCollection operation.
    /// Creates a collection in an AWS Region. You can add faces to the collection using the
    /// operation. 
    /// 
    ///  
    /// <para>
    /// For example, you might create collections, one for each of your application users.
    /// A user can then index faces using the <code>IndexFaces</code> operation and persist
    /// results in a specific collection. Then, a user can search the collection for faces
    /// in the user-specific container. 
    /// </para>
    ///  
    /// <para>
    /// For an example, see <a>example1</a>. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>rekognition:CreateCollection</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class CreateCollectionRequest : AmazonRekognitionRequest
    {
        private string _collectionId;

        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// ID for the collection that you are creating.
        /// </para>
        /// </summary>
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

    }
}