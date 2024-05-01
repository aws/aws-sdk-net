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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
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
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Information about the pixels in an anomaly mask. For more information, see <a>Anomaly</a>.
    /// <c>PixelAnomaly</c> is only returned by image segmentation models.
    /// </summary>
    public partial class PixelAnomaly
    {
        private string _color;
        private float? _totalPercentageArea;

        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// A hex color value for the mask that covers an anomaly type. Each anomaly type has
        /// a different mask color. The color maps to the color of the anomaly type used in the
        /// training dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=7)]
        public string Color
        {
            get { return this._color; }
            set { this._color = value; }
        }

        // Check to see if Color property is set
        internal bool IsSetColor()
        {
            return this._color != null;
        }

        /// <summary>
        /// Gets and sets the property TotalPercentageArea. 
        /// <para>
        /// The percentage area of the image that the anomaly type covers.
        /// </para>
        /// </summary>
        public float? TotalPercentageArea
        {
            get { return this._totalPercentageArea; }
            set { this._totalPercentageArea = value; }
        }

        // Check to see if TotalPercentageArea property is set
        internal bool IsSetTotalPercentageArea()
        {
            return this._totalPercentageArea.HasValue; 
        }

    }
}