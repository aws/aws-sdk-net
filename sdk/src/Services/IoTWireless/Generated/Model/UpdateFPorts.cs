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
    /// Object for updating the FPorts information.
    /// </summary>
    public partial class UpdateFPorts
    {
        private List<ApplicationConfig> _applications = new List<ApplicationConfig>();
        private Positioning _positioning;

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// LoRaWAN application, which can be used for geolocation by activating positioning.
        /// </para>
        /// </summary>
        public List<ApplicationConfig> Applications
        {
            get { return this._applications; }
            set { this._applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this._applications != null && this._applications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Positioning. 
        /// <para>
        /// Positioning FPorts for the ClockSync, Stream, and GNSS functions.
        /// </para>
        /// </summary>
        public Positioning Positioning
        {
            get { return this._positioning; }
            set { this._positioning = value; }
        }

        // Check to see if Positioning property is set
        internal bool IsSetPositioning()
        {
            return this._positioning != null;
        }

    }
}