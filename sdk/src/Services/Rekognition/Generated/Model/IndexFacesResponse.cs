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
        private string _faceModelVersion;
        private List<FaceRecord> _faceRecords = new List<FaceRecord>();
        private OrientationCorrection _orientationCorrection;

        /// <summary>
        /// Gets and sets the property FaceModelVersion. 
        /// <para>
        /// Version number of the face detection model associated with the input collection (<code>CollectionId</code>).
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
        /// The orientation of the input image (counterclockwise direction). If your application
        /// displays the image, you can use this value to correct image orientation. The bounding
        /// box coordinates returned in <code>FaceRecords</code> represent face locations before
        /// the image orientation is corrected. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If the input image is in jpeg format, it might contain exchangeable image (Exif) metadata.
        /// If so, and the Exif metadata populates the orientation field, the value of <code>OrientationCorrection</code>
        /// is null and the bounding box coordinates in <code>FaceRecords</code> represent face
        /// locations after Exif metadata is used to correct the image orientation. Images in
        /// .png format don't contain Exif metadata.
        /// </para>
        ///  </note>
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