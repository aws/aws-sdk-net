/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-08-31
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///IP Permission
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-08-31/", IsNullable = false)]
    public class IpPermissionSpecification
    {    
        private string ipProtocolField;
        private Decimal? fromPortField;
        private Decimal? toPortField;
        private List<UserIdGroupPair> groupsField;
        private List<string> ipRangesField;

        /// <summary>
        /// Gets and sets the IpProtocol property.
        /// IP protocol.Valid Values: tcp | udp | icmp
        /// </summary>
        [XmlElementAttribute(ElementName = "IpProtocol")]
        public string IpProtocol
        {
            get { return this.ipProtocolField; }
            set { this.ipProtocolField = value; }
        }

        /// <summary>
        /// Sets the IpProtocol property
        /// </summary>
        /// <param name="ipProtocol">IP protocol.Valid Values: tcp | udp | icmp</param>
        /// <returns>this instance</returns>
        public IpPermissionSpecification WithIpProtocol(string ipProtocol)
        {
            this.ipProtocolField = ipProtocol;
            return this;
        }

        /// <summary>
        /// Checks if IpProtocol property is set
        /// </summary>
        /// <returns>true if IpProtocol property is set</returns>
        public bool IsSetIpProtocol()
        {
            return this.ipProtocolField != null;
        }

        /// <summary>
        /// Gets and sets the FromPort property.
        /// Start of port range for the TCP and UDP
        /// protocols, or an ICMP type
        /// number. An ICMP type number of -1
        /// indicates a wildcard (i.e., any ICMP type
        /// number).
        /// </summary>
        [XmlElementAttribute(ElementName = "FromPort")]
        public Decimal FromPort
        {
            get { return this.fromPortField.GetValueOrDefault(); }
            set { this.fromPortField = value; }
        }

        /// <summary>
        /// Sets the FromPort property
        /// </summary>
        /// <param name="fromPort">Start of port range for the TCP and UDP
        /// protocols, or an ICMP type
        /// number. An ICMP type number of -1
        /// indicates a wildcard (i.e., any ICMP type
        /// number).</param>
        /// <returns>this instance</returns>
        public IpPermissionSpecification WithFromPort(Decimal fromPort)
        {
            this.fromPortField = fromPort;
            return this;
        }

        /// <summary>
        /// Checks if FromPort property is set
        /// </summary>
        /// <returns>true if FromPort property is set</returns>
        public bool IsSetFromPort()
        {
            return this.fromPortField.HasValue;
        }

        /// <summary>
        /// Gets and sets the ToPort property.
        /// End of port range for the TCP and UDP
        /// protocols, or an ICMP code.
        /// An ICMP code of -1 indicates a
        /// wildcard (i.e., any ICMP code).
        /// </summary>
        [XmlElementAttribute(ElementName = "ToPort")]
        public Decimal ToPort
        {
            get { return this.toPortField.GetValueOrDefault(); }
            set { this.toPortField = value; }
        }

        /// <summary>
        /// Sets the ToPort property
        /// </summary>
        /// <param name="toPort">End of port range for the TCP and UDP
        /// protocols, or an ICMP code.
        /// An ICMP code of -1 indicates a
        /// wildcard (i.e., any ICMP code).</param>
        /// <returns>this instance</returns>
        public IpPermissionSpecification WithToPort(Decimal toPort)
        {
            this.toPortField = toPort;
            return this;
        }

        /// <summary>
        /// Checks if ToPort property is set
        /// </summary>
        /// <returns>true if ToPort property is set</returns>
        public bool IsSetToPort()
        {
            return this.toPortField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Groups property.
        /// List of security group and user ID pairs.
        /// </summary>
        [XmlElementAttribute(ElementName = "Groups")]
        public List<UserIdGroupPair> Groups
        {
            get
            {
                if (this.groupsField == null)
                {
                    this.groupsField = new List<UserIdGroupPair>();
                }
                return this.groupsField;
            }
            set { this.groupsField = value; }
        }

        /// <summary>
        /// Sets the Groups property
        /// </summary>
        /// <param name="list">List of security group and user ID pairs.</param>
        /// <returns>this instance</returns>
        public IpPermissionSpecification WithGroups(params UserIdGroupPair[] list)
        {
            foreach (UserIdGroupPair item in list)
            {
                Groups.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Groups property is set
        /// </summary>
        /// <returns>true if Groups property is set</returns>
        public bool IsSetGroups()
        {
            return (Groups.Count > 0);
        }

        /// <summary>
        /// Gets and sets the IpRanges property.
        /// IP ranges.
        /// </summary>
        [XmlElementAttribute(ElementName = "IpRanges")]
        public List<string> IpRanges
        {
            get
            {
                if (this.ipRangesField == null)
                {
                    this.ipRangesField = new List<string>();
                }
                return this.ipRangesField;
            }
            set { this.ipRangesField = value; }
        }

        /// <summary>
        /// Sets the IpRanges property
        /// </summary>
        /// <param name="list">IP ranges.</param>
        /// <returns>this instance</returns>
        public IpPermissionSpecification WithIpRanges(params string[] list)
        {
            foreach (string item in list)
            {
                IpRanges.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if IpRanges property is set
        /// </summary>
        /// <returns>true if IpRanges property is set</returns>
        public bool IsSetIpRanges()
        {
            return (IpRanges.Count > 0);
        }

    }
}
