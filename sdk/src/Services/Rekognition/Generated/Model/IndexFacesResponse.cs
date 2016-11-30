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
    /// This is the response object from the IndexFaces operation.
    /// </summary>
    public partial class IndexFacesResponse : AmazonWebServiceResponse
    {
        private List<FaceRecord> _faceRecords = new List<FaceRecord>();
        private OrientationCorrection _orientationCorrection;

        /// <summary>
        /// Gets and sets the property FaceRecords. 
        /// <para>
        /// An array of faces detected and added to the collection. For more information, see
        /// <a>howitworks-index-faces</a>. 
        /// </para>
        /// </summary>
        public List<FaceRecord> FaceRecords
        {
            get { return this._faceRecords; }
            set { this._faceRecords = value; }
        }

        // Check to see if FaceRecords property is set
        internal bool IsSetFaceRecords()
        {
            return this._faceRecords != null && this._faceRecords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrientationCorrection. 
        /// <para>
        /// The algorithm detects the image orientation. If it detects that the image was rotated,
        /// it returns the degree of rotation. You can use this value to correct the orientation
        /// and also appropriately analyze the bounding box coordinates that are returned. 
        /// </para>
        /// </summary>
        public OrientationCorrection OrientationCorrection
        {
            get { return this._orientationCorrection; }
            set { this._orientationCorrection = value; }
        }

        // Check to see if OrientationCorrection property is set
        internal bool IsSetOrientationCorrection()
        {
            return this._orientationCorrection != null;
        }

    }
}