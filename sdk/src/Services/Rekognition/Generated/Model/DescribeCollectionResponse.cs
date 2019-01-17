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
    /// This is the response object from the DescribeCollection operation.
    /// </summary>
    public partial class DescribeCollectionResponse : AmazonWebServiceResponse
    {
        private string _collectionARN;
        private DateTime? _creationTimestamp;
        private long? _faceCount;
        private string _faceModelVersion;

        /// <summary>
        /// Gets and sets the property CollectionARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the collection.
        /// </para>
        /// </summary>
        public string CollectionARN
        {
            get { return this._collectionARN; }
            set { this._collectionARN = value; }
        }

        // Check to see if CollectionARN property is set
        internal bool IsSetCollectionARN()
        {
            return this._collectionARN != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The number of milliseconds since the Unix epoch time until the creation of the collection.
        /// The Unix epoch time is 00:00:00 Coordinated Universal Time (UTC), Thursday, 1 January
        /// 1970.
        /// </para>
        /// </summary>
        public DateTime CreationTimestamp
        {
            get { return this._creationTimestamp.GetValueOrDefault(); }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FaceCount. 
        /// <para>
        /// The number of faces that are indexed into the collection. To index faces into a collection,
        /// use <a>IndexFaces</a>.
        /// </para>
        /// </summary>
        public long FaceCount
        {
            get { return this._faceCount.GetValueOrDefault(); }
            set { this._faceCount = value; }
        }

        // Check to see if FaceCount property is set
        internal bool IsSetFaceCount()
        {
            return this._faceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FaceModelVersion. 
        /// <para>
        /// The version of the face model that's used by the collection for face detection.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Model Versioning in the Amazon Rekognition Developer Guide.
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

    }
}