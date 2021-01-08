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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Provides face metadata for target image faces that are analyzed by <code>CompareFaces</code>
    /// and <code>RecognizeCelebrities</code>.
    /// </summary>
    public partial class ComparedFace
    {
        private BoundingBox _boundingBox;
        private float? _confidence;
        private List<Landmark> _landmarks = new List<Landmark>();
        private Pose _pose;
        private ImageQuality _quality;

        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// Bounding box of the face.
        /// </para>
        /// </summary>
        public BoundingBox BoundingBox
        {
            get { return this._boundingBox; }
            set { this._boundingBox = value; }
        }

        // Check to see if BoundingBox property is set
        internal bool IsSetBoundingBox()
        {
            return this._boundingBox != null;
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Level of confidence that what the bounding box contains is a face.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float Confidence
        {
            get { return this._confidence.GetValueOrDefault(); }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Landmarks. 
        /// <para>
        /// An array of facial landmarks.
        /// </para>
        /// </summary>
        public List<Landmark> Landmarks
        {
            get { return this._landmarks; }
            set { this._landmarks = value; }
        }

        // Check to see if Landmarks property is set
        internal bool IsSetLandmarks()
        {
            return this._landmarks != null && this._landmarks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Pose. 
        /// <para>
        /// Indicates the pose of the face as determined by its pitch, roll, and yaw.
        /// </para>
        /// </summary>
        public Pose Pose
        {
            get { return this._pose; }
            set { this._pose = value; }
        }

        // Check to see if Pose property is set
        internal bool IsSetPose()
        {
            return this._pose != null;
        }

        /// <summary>
        /// Gets and sets the property Quality. 
        /// <para>
        /// Identifies face image brightness and sharpness. 
        /// </para>
        /// </summary>
        public ImageQuality Quality
        {
            get { return this._quality; }
            set { this._quality = value; }
        }

        // Check to see if Quality property is set
        internal bool IsSetQuality()
        {
            return this._quality != null;
        }

    }
}