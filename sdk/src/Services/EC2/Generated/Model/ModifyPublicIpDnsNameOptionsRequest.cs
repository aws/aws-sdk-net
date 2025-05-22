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
    /// Container for the parameters to the ModifyPublicIpDnsNameOptions operation.
    /// Modify public hostname options for a network interface. For more information, see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-naming.html">EC2
    /// instance hostnames, DNS names, and domains</a> in the <i>Amazon EC2 User Guide</i>.
    /// </summary>
    public partial class ModifyPublicIpDnsNameOptionsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private PublicIpDnsOption _hostnameType;
        private string _networkInterfaceId;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HostnameType. 
        /// <para>
        /// The public hostname type. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-naming.html">EC2
        /// instance hostnames, DNS names, and domains</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>public-dual-stack-dns-name</c>: A dual-stack public hostname for a network interface.
        /// Requests from within the VPC resolve to both the private IPv4 address and the IPv6
        /// Global Unicast Address of the network interface. Requests from the internet resolve
        /// to both the public IPv4 and the IPv6 GUA address of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public-ipv4-dns-name</c>: An IPv4-enabled public hostname for a network interface.
        /// Requests from within the VPC resolve to the private primary IPv4 address of the network
        /// interface. Requests from the internet resolve to the public IPv4 address of the network
        /// interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public-ipv6-dns-name</c>: An IPv6-enabled public hostname for a network interface.
        /// Requests from within the VPC or from the internet resolve to the IPv6 GUA of the network
        /// interface. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public PublicIpDnsOption HostnameType
        {
            get { return this._hostnameType; }
            set { this._hostnameType = value; }
        }

        // Check to see if HostnameType property is set
        internal bool IsSetHostnameType()
        {
            return this._hostnameType != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// A network interface ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

    }
}