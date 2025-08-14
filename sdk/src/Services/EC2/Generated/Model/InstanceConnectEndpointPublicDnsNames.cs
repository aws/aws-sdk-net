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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The public DNS names of the endpoint, including IPv4-only and dualstack DNS names.
    /// </summary>
    public partial class InstanceConnectEndpointPublicDnsNames
    {
        private InstanceConnectEndpointDnsNames _dualstack;
        private InstanceConnectEndpointDnsNames _ipv4;

        /// <summary>
        /// Gets and sets the property Dualstack. 
        /// <para>
        /// The dualstack DNS name of the EC2 Instance Connect Endpoint. A dualstack DNS name
        /// supports connections from both IPv4 and IPv6 clients.
        /// </para>
        /// </summary>
        public InstanceConnectEndpointDnsNames Dualstack
        {
            get { return this._dualstack; }
            set { this._dualstack = value; }
        }

        // Check to see if Dualstack property is set
        internal bool IsSetDualstack()
        {
            return this._dualstack != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv4. 
        /// <para>
        /// The IPv4-only DNS name of the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public InstanceConnectEndpointDnsNames Ipv4
        {
            get { return this._ipv4; }
            set { this._ipv4 = value; }
        }

        // Check to see if Ipv4 property is set
        internal bool IsSetIpv4()
        {
            return this._ipv4 != null;
        }

    }
}