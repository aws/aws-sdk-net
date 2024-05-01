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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// A device's network configuration.
    /// </summary>
    public partial class EthernetPayload
    {
        private ConnectionType _connectionType;
        private StaticIpConnectionInfo _staticIpConnectionInfo;

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// How the device gets an IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property StaticIpConnectionInfo. 
        /// <para>
        /// Network configuration for a static IP connection.
        /// </para>
        /// </summary>
        public StaticIpConnectionInfo StaticIpConnectionInfo
        {
            get { return this._staticIpConnectionInfo; }
            set { this._staticIpConnectionInfo = value; }
        }

        // Check to see if StaticIpConnectionInfo property is set
        internal bool IsSetStaticIpConnectionInfo()
        {
            return this._staticIpConnectionInfo != null;
        }

    }
}