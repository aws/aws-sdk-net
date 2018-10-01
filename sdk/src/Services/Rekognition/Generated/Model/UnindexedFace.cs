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
    /// A face that detected, but didn't index. Use the <code>Reasons</code> response attribute
    /// to determine why a face wasn't indexed.
    /// </summary>
    public partial class UnindexedFace
    {
        private FaceDetail _faceDetail;
        private List<string> _reasons = new List<string>();

        /// <summary>
        /// Gets and sets the property FaceDetail. 
        /// <para>
        /// The structure that contains attributes of a face that <code>IndexFaces</code>detected,
        /// but didn't index. 
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

        /// <summary>
        /// Gets and sets the property Reasons. 
        /// <para>
        /// An array of reasons that specify why a face wasn't indexed. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// EXTREME_POSE - The face is at a pose that can't be detected. For example, the head
        /// is turned too far away from the camera.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EXCEEDS_MAX_FACES - The number of faces detected is already higher than that specified
        /// by the <code>MaxFaces</code> input parameter for <code>IndexFaces</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LOW_BRIGHTNESS - The image is too dark.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LOW_SHARPNESS - The image is too blurry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LOW_CONFIDENCE - The face was detected with a low confidence.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SMALL_BOUNDING_BOX - The bounding box around the face is too small.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> Reasons
        {
            get { return this._reasons; }
            set { this._reasons = value; }
        }

        // Check to see if Reasons property is set
        internal bool IsSetReasons()
        {
            return this._reasons != null && this._reasons.Count > 0; 
        }

    }
}