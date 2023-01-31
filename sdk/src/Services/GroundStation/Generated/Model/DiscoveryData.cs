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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Data for agent discovery.
    /// </summary>
    public partial class DiscoveryData
    {
        private List<string> _capabilityArns = new List<string>();
        private List<string> _privateIpAddresses = new List<string>();
        private List<string> _publicIpAddresses = new List<string>();

        /// <summary>
        /// Gets and sets the property CapabilityArns. 
        /// <para>
        /// List of capabilities to associate with agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> CapabilityArns
        {
            get { return this._capabilityArns; }
            set { this._capabilityArns = value; }
        }

        // Check to see if CapabilityArns property is set
        internal bool IsSetCapabilityArns()
        {
            return this._capabilityArns != null && this._capabilityArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddresses. 
        /// <para>
        /// List of private IP addresses to associate with agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> PrivateIpAddresses
        {
            get { return this._privateIpAddresses; }
            set { this._privateIpAddresses = value; }
        }

        // Check to see if PrivateIpAddresses property is set
        internal bool IsSetPrivateIpAddresses()
        {
            return this._privateIpAddresses != null && this._privateIpAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PublicIpAddresses. 
        /// <para>
        /// List of public IP addresses to associate with agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<string> PublicIpAddresses
        {
            get { return this._publicIpAddresses; }
            set { this._publicIpAddresses = value; }
        }

        // Check to see if PublicIpAddresses property is set
        internal bool IsSetPublicIpAddresses()
        {
            return this._publicIpAddresses != null && this._publicIpAddresses.Count > 0; 
        }

    }
}