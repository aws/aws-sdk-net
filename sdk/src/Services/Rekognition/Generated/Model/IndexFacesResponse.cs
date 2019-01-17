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
        private List<UnindexedFace> _unindexedFaces = new List<UnindexedFace>();

        /// <summary>
        /// Gets and sets the property FaceModelVersion. 
        /// <para>
        /// The version number of the face detection model that's associated with the input collection
        /// (<code>CollectionId</code>).
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
        /// Searching Faces in a Collection in the Amazon Rekognition Developer Guide. 
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
        /// If your collection is associated with a face detection model that's later than version
        /// 3.0, the value of <code>OrientationCorrection</code> is always null and no orientation
        /// information is returned.
        /// </para>
        ///  
        /// <para>
        /// If your collection is associated with a face detection model that's version 3.0 or
        /// earlier, the following applies:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the input image is in .jpeg format, it might contain exchangeable image file format
        /// (Exif) metadata that includes the image's orientation. Amazon Rekognition uses this
        /// orientation information to perform image correction - the bounding box coordinates
        /// are translated to represent object locations after the orientation information in
        /// the Exif metadata is used to correct the image orientation. Images in .png format
        /// don't contain Exif metadata. The value of <code>OrientationCorrection</code> is null.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the image doesn't contain orientation information in its Exif metadata, Amazon
        /// Rekognition returns an estimated orientation (ROTATE_0, ROTATE_90, ROTATE_180, ROTATE_270).
        /// Amazon Rekognition doesn’t perform image correction for images. The bounding box coordinates
        /// aren't translated and represent the object locations before the image is rotated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Bounding box information is returned in the <code>FaceRecords</code> array. You can
        /// get the version of the face detection model by calling <a>DescribeCollection</a>.
        /// 
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

        /// <summary>
        /// Gets and sets the property UnindexedFaces. 
        /// <para>
        /// An array of faces that were detected in the image but weren't indexed. They weren't
        /// indexed because the quality filter identified them as low quality, or the <code>MaxFaces</code>
        /// request parameter filtered them out. To use the quality filter, you specify the <code>QualityFilter</code>
        /// request parameter.
        /// </para>
        /// </summary>
        public List<UnindexedFace> UnindexedFaces
        {
            get { return this._unindexedFaces; }
            set { this._unindexedFaces = value; }
        }

        // Check to see if UnindexedFaces property is set
        internal bool IsSetUnindexedFaces()
        {
            return this._unindexedFaces != null && this._unindexedFaces.Count > 0; 
        }

    }
}