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
    /// Input face recognition parameters for an Amazon Rekognition stream processor. <code>FaceRecognitionSettings</code>
    /// is a request parameter for <a>CreateStreamProcessor</a>.
    /// </summary>
    public partial class FaceSearchSettings
    {
        private string _collectionId;
        private float? _faceMatchThreshold;

        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// The ID of a collection that contains faces that you want to search for.
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

        /// <summary>
        /// Gets and sets the property FaceMatchThreshold. 
        /// <para>
        /// Minimum face match confidence score that must be met to return a result for a recognized
        /// face. Default is 70. 0 is the lowest confidence. 100 is the highest confidence.
        /// </para>
        /// </summary>
        public float FaceMatchThreshold
        {
            get { return this._faceMatchThreshold.GetValueOrDefault(); }
            set { this._faceMatchThreshold = value; }
        }

        // Check to see if FaceMatchThreshold property is set
        internal bool IsSetFaceMatchThreshold()
        {
            return this._faceMatchThreshold.HasValue; 
        }

    }
}