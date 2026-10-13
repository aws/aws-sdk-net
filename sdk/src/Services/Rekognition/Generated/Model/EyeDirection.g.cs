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
    /// Indicates the direction the eyes are gazing in (independent of the head pose) as determined
    /// by its pitch and yaw.
    /// </summary>
    public partial class EyeDirection
    {
        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence that the service has in its predicted eye direction.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property Pitch. 
        /// <para>
        /// Value representing eye direction on the pitch axis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -180, Max = 180)]
        public float? Pitch { get; set; }

        /// <summary>
        /// Checks to see if the Pitch property is set.
        /// </summary>
        internal bool IsSetPitch() => this.Pitch.HasValue;

        /// <summary>
        /// Gets and sets the property Yaw. 
        /// <para>
        /// Value representing eye direction on the yaw axis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -180, Max = 180)]
        public float? Yaw { get; set; }

        /// <summary>
        /// Checks to see if the Yaw property is set.
        /// </summary>
        internal bool IsSetYaw() => this.Yaw.HasValue;
    }
}
