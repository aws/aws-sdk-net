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
    /// <para> An IP permission describing allowed incoming IP traffic to an Amazon EC2 security group. </para>
    /// </summary>
    public class IpPermission
    {
        
        private string ipProtocol;
        private int? fromPort;
        private int? toPort;
        private List<UserIdGroupPair> userIdGroupPairs = new List<UserIdGroupPair>();
        private List<string> ipRanges = new List<string>();


        /// <summary>
        /// The IP protocol of this permission. Valid protocol values: <c>tcp</c>, <c>udp</c>, <c>icmp</c>
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
        /// Start of port range for the TCP and UDP protocols, or an ICMP type number. An ICMP type number of <c>-1</c> indicates a wildcard (i.e., any
        /// ICMP type number).
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
        /// End of port range for the TCP and UDP protocols, or an ICMP code. An ICMP code of <c>-1</c> indicates a wildcard (i.e., any ICMP code).
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
        /// The list of AWS user IDs and groups included in this permission.
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
        /// The list of CIDR IP ranges included in this permission.
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
