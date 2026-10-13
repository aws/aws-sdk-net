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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the IndexFaces operation.
    /// </summary>
    public partial class IndexFacesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FaceModelVersion. 
        /// <para>
        /// The version number of the face detection model that's associated with the input collection
        /// (<c>CollectionId</c>).
        /// </para>
        /// </summary>
        public string FaceModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the FaceModelVersion property is set.
        /// </summary>
        internal bool IsSetFaceModelVersion() => this.FaceModelVersion != null;

        /// <summary>
        /// Gets and sets the property FaceRecords. 
        /// <para>
        /// An array of faces detected and added to the collection. For more information, see
        /// Searching Faces in a Collection in the Amazon Rekognition Developer Guide. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FaceRecord> FaceRecords { get; set; } = AWSConfigs.InitializeCollections ? new List<FaceRecord>() : null;

        /// <summary>
        /// Checks to see if the FaceRecords property is set.
        /// </summary>
        internal bool IsSetFaceRecords() => this.FaceRecords != null && (this.FaceRecords.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrientationCorrection. 
        /// <para>
        /// If your collection is associated with a face detection model that's later than version
        /// 3.0, the value of <c>OrientationCorrection</c> is always null and no orientation information
        /// is returned.
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
        /// don't contain Exif metadata. The value of <c>OrientationCorrection</c> is null.
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
        /// Bounding box information is returned in the <c>FaceRecords</c> array. You can get
        /// the version of the face detection model by calling <a>DescribeCollection</a>. 
        /// </para>
        /// </summary>
        public OrientationCorrection OrientationCorrection { get; set; }

        /// <summary>
        /// Checks to see if the OrientationCorrection property is set.
        /// </summary>
        internal bool IsSetOrientationCorrection() => this.OrientationCorrection != null;

        /// <summary>
        /// Gets and sets the property UnindexedFaces. 
        /// <para>
        /// An array of faces that were detected in the image but weren't indexed. They weren't
        /// indexed because the quality filter identified them as low quality, or the <c>MaxFaces</c>
        /// request parameter filtered them out. To use the quality filter, you specify the <c>QualityFilter</c>
        /// request parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnindexedFace> UnindexedFaces { get; set; } = AWSConfigs.InitializeCollections ? new List<UnindexedFace>() : null;

        /// <summary>
        /// Checks to see if the UnindexedFaces property is set.
        /// </summary>
        internal bool IsSetUnindexedFaces() => this.UnindexedFaces != null && (this.UnindexedFaces.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
