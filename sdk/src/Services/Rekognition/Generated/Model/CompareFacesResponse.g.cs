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
    /// This is the response object from the CompareFaces operation.
    /// </summary>
    public partial class CompareFacesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FaceMatches. 
        /// <para>
        /// An array of faces in the target image that match the source image face. Each <c>CompareFacesMatch</c>
        /// object provides the bounding box, the confidence level that the bounding box contains
        /// a face, and the similarity score for the face in the bounding box and the face in
        /// the source image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CompareFacesMatch> FaceMatches { get; set; } = AWSConfigs.InitializeCollections ? new List<CompareFacesMatch>() : null;

        /// <summary>
        /// Checks to see if the FaceMatches property is set.
        /// </summary>
        internal bool IsSetFaceMatches() => this.FaceMatches != null && (this.FaceMatches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceImageFace. 
        /// <para>
        /// The face in the source image that was used for comparison.
        /// </para>
        /// </summary>
        public ComparedSourceImageFace SourceImageFace { get; set; }

        /// <summary>
        /// Checks to see if the SourceImageFace property is set.
        /// </summary>
        internal bool IsSetSourceImageFace() => this.SourceImageFace != null;

        /// <summary>
        /// Gets and sets the property SourceImageOrientationCorrection. 
        /// <para>
        /// The value of <c>SourceImageOrientationCorrection</c> is always null.
        /// </para>
        ///  
        /// <para>
        /// If the input image is in .jpeg format, it might contain exchangeable image file format
        /// (Exif) metadata that includes the image's orientation. Amazon Rekognition uses this
        /// orientation information to perform image correction. The bounding box coordinates
        /// are translated to represent object locations after the orientation information in
        /// the Exif metadata is used to correct the image orientation. Images in .png format
        /// don't contain Exif metadata.
        /// </para>
        ///  
        /// <para>
        /// Amazon Rekognition doesn’t perform image correction for images in .png format and
        /// .jpeg images without orientation information in the image Exif metadata. The bounding
        /// box coordinates aren't translated and represent the object locations before the image
        /// is rotated. 
        /// </para>
        /// </summary>
        public OrientationCorrection SourceImageOrientationCorrection { get; set; }

        /// <summary>
        /// Checks to see if the SourceImageOrientationCorrection property is set.
        /// </summary>
        internal bool IsSetSourceImageOrientationCorrection() => this.SourceImageOrientationCorrection != null;

        /// <summary>
        /// Gets and sets the property TargetImageOrientationCorrection. 
        /// <para>
        /// The value of <c>TargetImageOrientationCorrection</c> is always null.
        /// </para>
        ///  
        /// <para>
        /// If the input image is in .jpeg format, it might contain exchangeable image file format
        /// (Exif) metadata that includes the image's orientation. Amazon Rekognition uses this
        /// orientation information to perform image correction. The bounding box coordinates
        /// are translated to represent object locations after the orientation information in
        /// the Exif metadata is used to correct the image orientation. Images in .png format
        /// don't contain Exif metadata.
        /// </para>
        ///  
        /// <para>
        /// Amazon Rekognition doesn’t perform image correction for images in .png format and
        /// .jpeg images without orientation information in the image Exif metadata. The bounding
        /// box coordinates aren't translated and represent the object locations before the image
        /// is rotated. 
        /// </para>
        /// </summary>
        public OrientationCorrection TargetImageOrientationCorrection { get; set; }

        /// <summary>
        /// Checks to see if the TargetImageOrientationCorrection property is set.
        /// </summary>
        internal bool IsSetTargetImageOrientationCorrection() => this.TargetImageOrientationCorrection != null;

        /// <summary>
        /// Gets and sets the property UnmatchedFaces. 
        /// <para>
        /// An array of faces in the target image that did not match the source image face.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComparedFace> UnmatchedFaces { get; set; } = AWSConfigs.InitializeCollections ? new List<ComparedFace>() : null;

        /// <summary>
        /// Checks to see if the UnmatchedFaces property is set.
        /// </summary>
        internal bool IsSetUnmatchedFaces() => this.UnmatchedFaces != null && (this.UnmatchedFaces.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
