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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Specifies the configuration settings for individual NDI discovery servers. A maximum
    /// of 3 servers is allowed.
    /// </summary>
    public partial class NdiDiscoveryServerConfig
    {
        private string _discoveryServerAddress;
        private int? _discoveryServerPort;
        private string _vpcInterfaceAdapter;

        /// <summary>
        /// Gets and sets the property DiscoveryServerAddress. 
        /// <para>
        /// The unique network address of the NDI discovery server. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DiscoveryServerAddress
        {
            get { return this._discoveryServerAddress; }
            set { this._discoveryServerAddress = value; }
        }

        // Check to see if DiscoveryServerAddress property is set
        internal bool IsSetDiscoveryServerAddress()
        {
            return this._discoveryServerAddress != null;
        }

        /// <summary>
        /// Gets and sets the property DiscoveryServerPort. 
        /// <para>
        /// The port for the NDI discovery server. Defaults to 5959 if a custom port isn't specified.
        /// 
        /// </para>
        /// </summary>
        public int? DiscoveryServerPort
        {
            get { return this._discoveryServerPort; }
            set { this._discoveryServerPort = value; }
        }

        // Check to see if DiscoveryServerPort property is set
        internal bool IsSetDiscoveryServerPort()
        {
            return this._discoveryServerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcInterfaceAdapter. 
        /// <para>
        /// The identifier for the Virtual Private Cloud (VPC) network interface used by the flow.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpcInterfaceAdapter
        {
            get { return this._vpcInterfaceAdapter; }
            set { this._vpcInterfaceAdapter = value; }
        }

        // Check to see if VpcInterfaceAdapter property is set
        internal bool IsSetVpcInterfaceAdapter()
        {
            return this._vpcInterfaceAdapter != null;
        }

    }
}