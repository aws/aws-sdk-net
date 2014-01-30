/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a security group rule.</para>
    /// </summary>
    public class IpPermission
    {
        
        private string ipProtocol;
        private int? fromPort;
        private int? toPort;
        private List<UserIdGroupPair> userIdGroupPairs = new List<UserIdGroupPair>();
        private List<string> ipRanges = new List<string>();


        /// <summary>
        /// The protocol. When you call <a>DescribeSecurityGroups</a>, the protocol value returned is the number. Exception: For TCP, UDP, and ICMP, the
        /// value returned is the name (for example, <c>tcp</c>, <c>udp</c>, or <c>icmp</c>). For a list of protocol numbers, see <a
        /// href="http://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml">Protocol Numbers</a>.
        ///  
        /// </summary>
        public string IpProtocol
        {
            get { return this.ipProtocol; }
            set { this.ipProtocol = value; }
        }

        // Check to see if IpProtocol property is set
        internal bool IsSetIpProtocol()
        {
            return this.ipProtocol != null;
        }

        /// <summary>
        /// The start of port range for the TCP and UDP protocols, or an ICMP type number. A value of <c>-1</c> indicates all ICMP types.
        ///  
        /// </summary>
        public int FromPort
        {
            get { return this.fromPort ?? default(int); }
            set { this.fromPort = value; }
        }

        // Check to see if FromPort property is set
        internal bool IsSetFromPort()
        {
            return this.fromPort.HasValue;
        }

        /// <summary>
        /// The end of port range for the TCP and UDP protocols, or an ICMP code. A value of <c>-1</c> indicates all ICMP codes for the specified ICMP
        /// type.
        ///  
        /// </summary>
        public int ToPort
        {
            get { return this.toPort ?? default(int); }
            set { this.toPort = value; }
        }

        // Check to see if ToPort property is set
        internal bool IsSetToPort()
        {
            return this.toPort.HasValue;
        }

        /// <summary>
        /// One or more security group and AWS account ID pairs.
        ///  
        /// </summary>
        public List<UserIdGroupPair> UserIdGroupPairs
        {
            get { return this.userIdGroupPairs; }
            set { this.userIdGroupPairs = value; }
        }

        // Check to see if UserIdGroupPairs property is set
        internal bool IsSetUserIdGroupPairs()
        {
            return this.userIdGroupPairs.Count > 0;
        }

        /// <summary>
        /// One or more IP ranges.
        ///  
        /// </summary>
        public List<string> IpRanges
        {
            get { return this.ipRanges; }
            set { this.ipRanges = value; }
        }

        // Check to see if IpRanges property is set
        internal bool IsSetIpRanges()
        {
            return this.ipRanges.Count > 0;
        }
    }
}
