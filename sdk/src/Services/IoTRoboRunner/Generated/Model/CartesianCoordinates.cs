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
    /// Cartesian coordinates in 3D space relative to the RoboRunner origin.
    /// </summary>
    public partial class CartesianCoordinates
    {
        private double? _x;
        private double? _y;
        private double? _z;

        /// <summary>
        /// Gets and sets the property X. 
        /// <para>
        /// X coordinate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double X
        {
            get { return this._x.GetValueOrDefault(); }
            set { this._x = value; }
        }

        // Check to see if X property is set
        internal bool IsSetX()
        {
            return this._x.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Y. 
        /// <para>
        /// Y coordinate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double Y
        {
            get { return this._y.GetValueOrDefault(); }
            set { this._y = value; }
        }

        // Check to see if Y property is set
        internal bool IsSetY()
        {
            return this._y.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Z. 
        /// <para>
        /// Z coordinate.
        /// </para>
        /// </summary>
        public double Z
        {
            get { return this._z.GetValueOrDefault(); }
            set { this._z = value; }
        }

        // Check to see if Z property is set
        internal bool IsSetZ()
        {
            return this._z.HasValue; 
        }

    }
}