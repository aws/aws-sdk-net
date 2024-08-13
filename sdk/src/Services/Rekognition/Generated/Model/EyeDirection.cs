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
    /// Indicates the direction the eyes are gazing in (independent of the head pose) as determined
    /// by its pitch and yaw.
    /// </summary>
    public partial class EyeDirection
    {
        private float? _confidence;
        private float? _pitch;
        private float? _yaw;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence that the service has in its predicted eye direction.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pitch. 
        /// <para>
        /// Value representing eye direction on the pitch axis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-180, Max=180)]
        public float? Pitch
        {
            get { return this._pitch; }
            set { this._pitch = value; }
        }

        // Check to see if Pitch property is set
        internal bool IsSetPitch()
        {
            return this._pitch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Yaw. 
        /// <para>
        /// Value representing eye direction on the yaw axis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-180, Max=180)]
        public float? Yaw
        {
            get { return this._yaw; }
            set { this._yaw = value; }
        }

        // Check to see if Yaw property is set
        internal bool IsSetYaw()
        {
            return this._yaw.HasValue; 
        }

    }
}