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
    /// This is the response object from the CompareFaces operation.
    /// </summary>
    public partial class CompareFacesResponse : AmazonWebServiceResponse
    {
        private List<CompareFacesMatch> _faceMatches = new List<CompareFacesMatch>();
        private ComparedSourceImageFace _sourceImageFace;
        private OrientationCorrection _sourceImageOrientationCorrection;
        private OrientationCorrection _targetImageOrientationCorrection;
        private List<ComparedFace> _unmatchedFaces = new List<ComparedFace>();

        /// <summary>
        /// Gets and sets the property FaceMatches. 
        /// <para>
        /// An array of faces in the target image that match the source image face. Each <code>CompareFacesMatch</code>
        /// object provides the bounding box, the confidence level that the bounding box contains
        /// a face, and the similarity score for the face in the bounding box and the face in
        /// the source image.
        /// </para>
        /// </summary>
        public List<CompareFacesMatch> FaceMatches
        {
            get { return this._faceMatches; }
            set { this._faceMatches = value; }
        }

        // Check to see if FaceMatches property is set
        internal bool IsSetFaceMatches()
        {
            return this._faceMatches != null && this._faceMatches.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceImageFace. 
        /// <para>
        /// The face in the source image that was used for comparison.
        /// </para>
        /// </summary>
        public ComparedSourceImageFace SourceImageFace
        {
            get { return this._sourceImageFace; }
            set { this._sourceImageFace = value; }
        }

        // Check to see if SourceImageFace property is set
        internal bool IsSetSourceImageFace()
        {
            return this._sourceImageFace != null;
        }

        /// <summary>
        /// Gets and sets the property SourceImageOrientationCorrection. 
        /// <para>
        ///  The orientation of the source image (counterclockwise direction). If your application
        /// displays the source image, you can use this value to correct image orientation. The
        /// bounding box coordinates returned in <code>SourceImageFace</code> represent the location
        /// of the face before the image orientation is corrected. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If the source image is in .jpeg format, it might contain exchangeable image (Exif)
        /// metadata that includes the image's orientation. If the Exif metadata for the source
        /// image populates the orientation field, the value of <code>OrientationCorrection</code>
        /// is null and the <code>SourceImageFace</code> bounding box coordinates represent the
        /// location of the face after Exif metadata is used to correct the orientation. Images
        /// in .png format don't contain Exif metadata.
        /// </para>
        ///  </note>
        /// </summary>
        public OrientationCorrection SourceImageOrientationCorrection
        {
            get { return this._sourceImageOrientationCorrection; }
            set { this._sourceImageOrientationCorrection = value; }
        }

        // Check to see if SourceImageOrientationCorrection property is set
        internal bool IsSetSourceImageOrientationCorrection()
        {
            return this._sourceImageOrientationCorrection != null;
        }

        /// <summary>
        /// Gets and sets the property TargetImageOrientationCorrection. 
        /// <para>
        ///  The orientation of the target image (in counterclockwise direction). If your application
        /// displays the target image, you can use this value to correct the orientation of the
        /// image. The bounding box coordinates returned in <code>FaceMatches</code> and <code>UnmatchedFaces</code>
        /// represent face locations before the image orientation is corrected. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If the target image is in .jpg format, it might contain Exif metadata that includes
        /// the orientation of the image. If the Exif metadata for the target image populates
        /// the orientation field, the value of <code>OrientationCorrection</code> is null and
        /// the bounding box coordinates in <code>FaceMatches</code> and <code>UnmatchedFaces</code>
        /// represent the location of the face after Exif metadata is used to correct the orientation.
        /// Images in .png format don't contain Exif metadata.
        /// </para>
        ///  </note>
        /// </summary>
        public OrientationCorrection TargetImageOrientationCorrection
        {
            get { return this._targetImageOrientationCorrection; }
            set { this._targetImageOrientationCorrection = value; }
        }

        // Check to see if TargetImageOrientationCorrection property is set
        internal bool IsSetTargetImageOrientationCorrection()
        {
            return this._targetImageOrientationCorrection != null;
        }

        /// <summary>
        /// Gets and sets the property UnmatchedFaces. 
        /// <para>
        /// An array of faces in the target image that did not match the source image face.
        /// </para>
        /// </summary>
        public List<ComparedFace> UnmatchedFaces
        {
            get { return this._unmatchedFaces; }
            set { this._unmatchedFaces = value; }
        }

        // Check to see if UnmatchedFaces property is set
        internal bool IsSetUnmatchedFaces()
        {
            return this._unmatchedFaces != null && this._unmatchedFaces.Count > 0; 
        }

    }
}