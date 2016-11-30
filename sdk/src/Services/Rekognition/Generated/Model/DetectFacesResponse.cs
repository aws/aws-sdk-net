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
    /// This is the response object from the DetectFaces operation.
    /// </summary>
    public partial class DetectFacesResponse : AmazonWebServiceResponse
    {
        private List<FaceDetail> _faceDetails = new List<FaceDetail>();
        private OrientationCorrection _orientationCorrection;

        /// <summary>
        /// Gets and sets the property FaceDetails. 
        /// <para>
        /// Details of each face found in the image. 
        /// </para>
        /// </summary>
        public List<FaceDetail> FaceDetails
        {
            get { return this._faceDetails; }
            set { this._faceDetails = value; }
        }

        // Check to see if FaceDetails property is set
        internal bool IsSetFaceDetails()
        {
            return this._faceDetails != null && this._faceDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrientationCorrection. 
        /// <para>
        /// The algorithm detects the image orientation. If it detects that the image was rotated,
        /// it returns the degrees of rotation. If your application is displaying the image, you
        /// can use this value to adjust the orientation. 
        /// </para>
        ///  
        /// <para>
        /// For example, if the service detects that the input image was rotated by 90 degrees,
        /// it corrects orientation, performs face detection, and then returns the faces. That
        /// is, the bounding box coordinates in the response are based on the corrected orientation.
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

    }
}