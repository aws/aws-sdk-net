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
    /// Identifies face image brightness and sharpness.
    /// </summary>
    public partial class ImageQuality
    {
        private float? _brightness;
        private float? _sharpness;

        /// <summary>
        /// Gets and sets the property Brightness. 
        /// <para>
        /// Value representing brightness of the face. The service returns a value between 0 and
        /// 100 (inclusive). A higher value indicates a brighter face image.
        /// </para>
        /// </summary>
        public float? Brightness
        {
            get { return this._brightness; }
            set { this._brightness = value; }
        }

        // Check to see if Brightness property is set
        internal bool IsSetBrightness()
        {
            return this._brightness.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sharpness. 
        /// <para>
        /// Value representing sharpness of the face. The service returns a value between 0 and
        /// 100 (inclusive). A higher value indicates a sharper face image.
        /// </para>
        /// </summary>
        public float? Sharpness
        {
            get { return this._sharpness; }
            set { this._sharpness = value; }
        }

        // Check to see if Sharpness property is set
        internal bool IsSetSharpness()
        {
            return this._sharpness.HasValue; 
        }

    }
}