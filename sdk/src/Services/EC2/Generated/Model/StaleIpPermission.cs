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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a stale rule in a security group.
    /// </summary>
    public partial class StaleIpPermission
    {
        private int? _fromPort;
        private string _ipProtocol;
        private List<string> _ipRanges = new List<string>();
        private List<string> _prefixListIds = new List<string>();
        private int? _toPort;
        private List<UserIdGroupPair> _userIdGroupPairs = new List<UserIdGroupPair>();

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// The start of the port range for the TCP and UDP protocols, or an ICMP type number.
        /// A value of -1 indicates all ICMP types. 
        /// </para>
        /// </summary>
        public int FromPort
        {
            get { return this._fromPort.GetValueOrDefault(); }
            set { this._fromPort = value; }
        }

        // Check to see if FromPort property is set
        internal bool IsSetFromPort()
        {
            return this._fromPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpProtocol. 
        /// <para>
        /// The IP protocol name (for <code>tcp</code>, <code>udp</code>, and <code>icmp</code>)
        /// or number (see <a href="http://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml">Protocol
        /// Numbers)</a>.
        /// </para>
        /// </summary>
        public string IpProtocol
        {
            get { return this._ipProtocol; }
            set { this._ipProtocol = value; }
        }

        // Check to see if IpProtocol property is set
        internal bool IsSetIpProtocol()
        {
            return this._ipProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property IpRanges. 
        /// <para>
        /// The IP ranges. Not applicable for stale security group rules.
        /// </para>
        /// </summary>
        public List<string> IpRanges
        {
            get { return this._ipRanges; }
            set { this._ipRanges = value; }
        }

        // Check to see if IpRanges property is set
        internal bool IsSetIpRanges()
        {
            return this._ipRanges != null && this._ipRanges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PrefixListIds. 
        /// <para>
        /// The prefix list IDs. Not applicable for stale security group rules.
        /// </para>
        /// </summary>
        public List<string> PrefixListIds
        {
            get { return this._prefixListIds; }
            set { this._prefixListIds = value; }
        }

        // Check to see if PrefixListIds property is set
        internal bool IsSetPrefixListIds()
        {
            return this._prefixListIds != null && this._prefixListIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// The end of the port range for the TCP and UDP protocols, or an ICMP type number. A
        /// value of <code>-1</code> indicates all ICMP types. 
        /// </para>
        /// </summary>
        public int ToPort
        {
            get { return this._toPort.GetValueOrDefault(); }
            set { this._toPort = value; }
        }

        // Check to see if ToPort property is set
        internal bool IsSetToPort()
        {
            return this._toPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserIdGroupPairs. 
        /// <para>
        /// The security group pairs. Returns the ID of the referenced security group and VPC,
        /// and the ID and status of the VPC peering connection.
        /// </para>
        /// </summary>
        public List<UserIdGroupPair> UserIdGroupPairs
        {
            get { return this._userIdGroupPairs; }
            set { this._userIdGroupPairs = value; }
        }

        // Check to see if UserIdGroupPairs property is set
        internal bool IsSetUserIdGroupPairs()
        {
            return this._userIdGroupPairs != null && this._userIdGroupPairs.Count > 0; 
        }

    }
}