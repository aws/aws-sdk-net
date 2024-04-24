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
    /// Object containing both the face metadata (stored in the backend database), and facial
    /// attributes that are detected but aren't stored in the database.
    /// </summary>
    public partial class FaceRecord
    {
        private Face _face;
        private FaceDetail _faceDetail;

        /// <summary>
        /// Gets and sets the property Face. 
        /// <para>
        /// Describes the face properties such as the bounding box, face ID, image ID of the input
        /// image, and external image ID that you assigned. 
        /// </para>
        /// </summary>
        public Face Face
        {
            get { return this._face; }
            set { this._face = value; }
        }

        // Check to see if Face property is set
        internal bool IsSetFace()
        {
            return this._face != null;
        }

        /// <summary>
        /// Gets and sets the property FaceDetail. 
        /// <para>
        /// Structure containing attributes of the face that the algorithm detected.
        /// </para>
        /// </summary>
        public FaceDetail FaceDetail
        {
            get { return this._faceDetail; }
            set { this._faceDetail = value; }
        }

        // Check to see if FaceDetail property is set
        internal bool IsSetFaceDetail()
        {
            return this._faceDetail != null;
        }

    }
}