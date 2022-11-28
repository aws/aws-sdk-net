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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// The accuracy of the estimated position in meters. An empty value indicates that no
    /// position data is available. A value of ‘0.0’ value indicates that position data is
    /// available. This data corresponds to the position information that you specified instead
    /// of the position computed by solver.
    /// </summary>
    public partial class Accuracy
    {
        private float? _horizontalAccuracy;
        private float? _verticalAccuracy;

        /// <summary>
        /// Gets and sets the property HorizontalAccuracy. 
        /// <para>
        /// The horizontal accuracy of the estimated position, which is the difference between
        /// the estimated location and the actual device location.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public float HorizontalAccuracy
        {
            get { return this._horizontalAccuracy.GetValueOrDefault(); }
            set { this._horizontalAccuracy = value; }
        }

        // Check to see if HorizontalAccuracy property is set
        internal bool IsSetHorizontalAccuracy()
        {
            return this._horizontalAccuracy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VerticalAccuracy. 
        /// <para>
        /// The vertical accuracy of the estimated position, which is the difference between the
        /// estimated altitude and actual device latitude in meters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public float VerticalAccuracy
        {
            get { return this._verticalAccuracy.GetValueOrDefault(); }
            set { this._verticalAccuracy = value; }
        }

        // Check to see if VerticalAccuracy property is set
        internal bool IsSetVerticalAccuracy()
        {
            return this._verticalAccuracy.HasValue; 
        }

    }
}