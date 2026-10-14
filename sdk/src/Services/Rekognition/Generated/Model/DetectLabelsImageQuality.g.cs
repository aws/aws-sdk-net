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
    /// The quality of an image provided for label detection, with regard to brightness, sharpness,
    /// and contrast.
    /// </summary>
    public partial class DetectLabelsImageQuality
    {
        /// <summary>
        /// Gets and sets the property Brightness. 
        /// <para>
        /// The brightness of an image provided for label detection.
        /// </para>
        /// </summary>
        public float? Brightness { get; set; }

        /// <summary>
        /// Checks to see if the Brightness property is set.
        /// </summary>
        internal bool IsSetBrightness() => this.Brightness.HasValue;

        /// <summary>
        /// Gets and sets the property Contrast. 
        /// <para>
        /// The contrast of an image provided for label detection.
        /// </para>
        /// </summary>
        public float? Contrast { get; set; }

        /// <summary>
        /// Checks to see if the Contrast property is set.
        /// </summary>
        internal bool IsSetContrast() => this.Contrast.HasValue;

        /// <summary>
        /// Gets and sets the property Sharpness. 
        /// <para>
        /// The sharpness of an image provided for label detection.
        /// </para>
        /// </summary>
        public float? Sharpness { get; set; }

        /// <summary>
        /// Checks to see if the Sharpness property is set.
        /// </summary>
        internal bool IsSetSharpness() => this.Sharpness.HasValue;
    }
}
