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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// LoRaWANUpdateGatewayTaskEntry object.
    /// </summary>
    public partial class LoRaWANUpdateGatewayTaskEntry
    {
        private LoRaWANGatewayVersion _currentVersion;
        private LoRaWANGatewayVersion _updateVersion;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        /// The version of the gateways that should receive the update.
        /// </para>
        /// </summary>
        public LoRaWANGatewayVersion CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateVersion. 
        /// <para>
        /// The firmware version to update the gateway to.
        /// </para>
        /// </summary>
        public LoRaWANGatewayVersion UpdateVersion
        {
            get { return this._updateVersion; }
            set { this._updateVersion = value; }
        }

        // Check to see if UpdateVersion property is set
        internal bool IsSetUpdateVersion()
        {
            return this._updateVersion != null;
        }

    }
}