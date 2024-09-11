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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// A mapping that's used to pair a logical network interface name on a Node with the
    /// physical interface name exposed in the operating system.
    /// </summary>
    public partial class NodeInterfaceMapping
    {
        private string _logicalInterfaceName;
        private NetworkInterfaceMode _networkInterfaceMode;
        private string _physicalInterfaceName;

        /// <summary>
        /// Gets and sets the property LogicalInterfaceName. A uniform logical interface name
        /// to address in a MediaLive channel configuration.
        /// </summary>
        public string LogicalInterfaceName
        {
            get { return this._logicalInterfaceName; }
            set { this._logicalInterfaceName = value; }
        }

        // Check to see if LogicalInterfaceName property is set
        internal bool IsSetLogicalInterfaceName()
        {
            return this._logicalInterfaceName != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceMode.
        /// </summary>
        public NetworkInterfaceMode NetworkInterfaceMode
        {
            get { return this._networkInterfaceMode; }
            set { this._networkInterfaceMode = value; }
        }

        // Check to see if NetworkInterfaceMode property is set
        internal bool IsSetNetworkInterfaceMode()
        {
            return this._networkInterfaceMode != null;
        }

        /// <summary>
        /// Gets and sets the property PhysicalInterfaceName. The name of the physical interface
        /// on the hardware that will be running Elemental anywhere.
        /// </summary>
        public string PhysicalInterfaceName
        {
            get { return this._physicalInterfaceName; }
            set { this._physicalInterfaceName = value; }
        }

        // Check to see if PhysicalInterfaceName property is set
        internal bool IsSetPhysicalInterfaceName()
        {
            return this._physicalInterfaceName != null;
        }

    }
}