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
    /// Input face recognition parameters for an Amazon Rekognition stream processor. Includes
    /// the collection to use for face recognition and the face attributes to detect. Defining
    /// the settings is required in the request parameter for <a>CreateStreamProcessor</a>.
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
        [AWSProperty(Min=1, Max=255)]
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
        /// face. The default is 80. 0 is the lowest confidence. 100 is the highest confidence.
        /// Values between 0 and 100 are accepted, and values lower than 80 are set to 80.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? FaceMatchThreshold
        {
            get { return this._faceMatchThreshold; }
            set { this._faceMatchThreshold = value; }
        }

        // Check to see if FaceMatchThreshold property is set
        internal bool IsSetFaceMatchThreshold()
        {
            return this._faceMatchThreshold.HasValue; 
        }

    }
}