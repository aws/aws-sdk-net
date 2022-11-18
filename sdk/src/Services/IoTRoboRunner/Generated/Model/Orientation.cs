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
 * Do not modify this file. This file is generated from the iot-roborunner-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTRoboRunner.Model
{
    /// <summary>
    /// Worker orientation measured in units clockwise from north.
    /// </summary>
    public partial class Orientation
    {
        private double? _degrees;

        /// <summary>
        /// Gets and sets the property Degrees. 
        /// <para>
        /// Degrees, limited on [0, 360)
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=360)]
        public double Degrees
        {
            get { return this._degrees.GetValueOrDefault(); }
            set { this._degrees = value; }
        }

        // Check to see if Degrees property is set
        internal bool IsSetDegrees()
        {
            return this._degrees.HasValue; 
        }

    }
}