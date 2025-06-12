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
    /// This is the response object from the RecognizeCelebrities operation.
    /// </summary>
    public partial class RecognizeCelebritiesResponse : AmazonWebServiceResponse
    {
        private List<Celebrity> _celebrityFaces = AWSConfigs.InitializeCollections ? new List<Celebrity>() : null;
        private OrientationCorrection _orientationCorrection;
        private List<ComparedFace> _unrecognizedFaces = AWSConfigs.InitializeCollections ? new List<ComparedFace>() : null;

        /// <summary>
        /// Gets and sets the property CelebrityFaces. 
        /// <para>
        /// Details about each celebrity found in the image. Amazon Rekognition can detect a maximum
        /// of 64 celebrities in an image. Each celebrity object includes the following attributes:
        /// <c>Face</c>, <c>Confidence</c>, <c>Emotions</c>, <c>Landmarks</c>, <c>Pose</c>, <c>Quality</c>,
        /// <c>Smile</c>, <c>Id</c>, <c>KnownGender</c>, <c>MatchConfidence</c>, <c>Name</c>,
        /// <c>Urls</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Celebrity> CelebrityFaces
        {
            get { return this._celebrityFaces; }
            set { this._celebrityFaces = value; }
        }

        // Check to see if CelebrityFaces property is set
        internal bool IsSetCelebrityFaces()
        {
            return this._celebrityFaces != null && (this._celebrityFaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OrientationCorrection. <note> 
        /// <para>
        /// Support for estimating image orientation using the the OrientationCorrection field
        /// has ceased as of August 2021. Any returned values for this field included in an API
        /// response will always be NULL.
        /// </para>
        ///  </note> 
        /// <para>
        /// The orientation of the input image (counterclockwise direction). If your application
        /// displays the image, you can use this value to correct the orientation. The bounding
        /// box coordinates returned in <c>CelebrityFaces</c> and <c>UnrecognizedFaces</c> represent
        /// face locations before the image orientation is corrected. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If the input image is in .jpeg format, it might contain exchangeable image (Exif)
        /// metadata that includes the image's orientation. If so, and the Exif metadata for the
        /// input image populates the orientation field, the value of <c>OrientationCorrection</c>
        /// is null. The <c>CelebrityFaces</c> and <c>UnrecognizedFaces</c> bounding box coordinates
        /// represent face locations after Exif metadata is used to correct the image orientation.
        /// Images in .png format don't contain Exif metadata. 
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

        /// <summary>
        /// Gets and sets the property UnrecognizedFaces. 
        /// <para>
        /// Details about each unrecognized face in the image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComparedFace> UnrecognizedFaces
        {
            get { return this._unrecognizedFaces; }
            set { this._unrecognizedFaces = value; }
        }

        // Check to see if UnrecognizedFaces property is set
        internal bool IsSetUnrecognizedFaces()
        {
            return this._unrecognizedFaces != null && (this._unrecognizedFaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}