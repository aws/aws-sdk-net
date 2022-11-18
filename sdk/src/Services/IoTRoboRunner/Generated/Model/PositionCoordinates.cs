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
    /// Supported coordinates for worker position.
    /// </summary>
    public partial class PositionCoordinates
    {
        private CartesianCoordinates _cartesianCoordinates;

        /// <summary>
        /// Gets and sets the property CartesianCoordinates. 
        /// <para>
        /// Cartesian coordinates.
        /// </para>
        /// </summary>
        public CartesianCoordinates CartesianCoordinates
        {
            get { return this._cartesianCoordinates; }
            set { this._cartesianCoordinates = value; }
        }

        // Check to see if CartesianCoordinates property is set
        internal bool IsSetCartesianCoordinates()
        {
            return this._cartesianCoordinates != null;
        }

    }
}