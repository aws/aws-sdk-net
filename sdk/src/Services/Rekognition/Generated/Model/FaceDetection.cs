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
    /// Information about a face detected in a video analysis request and the time the face
    /// was detected in the video.
    /// </summary>
    public partial class FaceDetection
    {
        private FaceDetail _face;
        private long? _timestamp;

        /// <summary>
        /// Gets and sets the property Face. 
        /// <para>
        /// The face properties for the detected face.
        /// </para>
        /// </summary>
        public FaceDetail Face
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
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Time, in milliseconds from the start of the video, that the face was detected. Note
        /// that <c>Timestamp</c> is not guaranteed to be accurate to the individual frame where
        /// the face first appears.
        /// </para>
        /// </summary>
        public long? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}