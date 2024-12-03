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
    /// A security group rule removed with <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RevokeSecurityGroupEgress.html">RevokeSecurityGroupEgress</a>
    /// or <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RevokeSecurityGroupIngress.html">RevokeSecurityGroupIngress</a>.
    /// </summary>
    public partial class RevokedSecurityGroupRule
    {
        private string _cidrIpv4;
        private string _cidrIpv6;
        private string _description;
        private int? _fromPort;
        private string _groupId;
        private string _ipProtocol;
        private bool? _isEgress;
        private string _prefixListId;
        private string _referencedGroupId;
        private string _securityGroupRuleId;
        private int? _toPort;

        /// <summary>
        /// Gets and sets the property CidrIpv4. 
        /// <para>
        /// The IPv4 CIDR of the traffic source.
        /// </para>
        /// </summary>
        public string CidrIpv4
        {
            get { return this._cidrIpv4; }
            set { this._cidrIpv4 = value; }
        }

        // Check to see if CidrIpv4 property is set
        internal bool IsSetCidrIpv4()
        {
            return this._cidrIpv4 != null;
        }

        /// <summary>
        /// Gets and sets the property CidrIpv6. 
        /// <para>
        /// The IPv6 CIDR of the traffic source.
        /// </para>
        /// </summary>
        public string CidrIpv6
        {
            get { return this._cidrIpv6; }
            set { this._cidrIpv6 = value; }
        }

        // Check to see if CidrIpv6 property is set
        internal bool IsSetCidrIpv6()
        {
            return this._cidrIpv6 != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the revoked security group rule.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// The 'from' port number of the security group rule.
        /// </para>
        /// </summary>
        public int? FromPort
        {
            get { return this._fromPort; }
            set { this._fromPort = value; }
        }

        // Check to see if FromPort property is set
        internal bool IsSetFromPort()
        {
            return this._fromPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// A security group ID.
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property IpProtocol. 
        /// <para>
        /// The security group rule's protocol.
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
        /// Gets and sets the property IsEgress. 
        /// <para>
        /// Defines if a security group rule is an outbound rule.
        /// </para>
        /// </summary>
        public bool? IsEgress
        {
            get { return this._isEgress; }
            set { this._isEgress = value; }
        }

        // Check to see if IsEgress property is set
        internal bool IsSetIsEgress()
        {
            return this._isEgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrefixListId. 
        /// <para>
        /// The ID of a prefix list that's the traffic source.
        /// </para>
        /// </summary>
        public string PrefixListId
        {
            get { return this._prefixListId; }
            set { this._prefixListId = value; }
        }

        // Check to see if PrefixListId property is set
        internal bool IsSetPrefixListId()
        {
            return this._prefixListId != null;
        }

        /// <summary>
        /// Gets and sets the property ReferencedGroupId. 
        /// <para>
        /// The ID of a referenced security group.
        /// </para>
        /// </summary>
        public string ReferencedGroupId
        {
            get { return this._referencedGroupId; }
            set { this._referencedGroupId = value; }
        }

        // Check to see if ReferencedGroupId property is set
        internal bool IsSetReferencedGroupId()
        {
            return this._referencedGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupRuleId. 
        /// <para>
        /// A security group rule ID.
        /// </para>
        /// </summary>
        public string SecurityGroupRuleId
        {
            get { return this._securityGroupRuleId; }
            set { this._securityGroupRuleId = value; }
        }

        // Check to see if SecurityGroupRuleId property is set
        internal bool IsSetSecurityGroupRuleId()
        {
            return this._securityGroupRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// The 'to' port number of the security group rule.
        /// </para>
        /// </summary>
        public int? ToPort
        {
            get { return this._toPort; }
            set { this._toPort = value; }
        }

        // Check to see if ToPort property is set
        internal bool IsSetToPort()
        {
            return this._toPort.HasValue; 
        }

    }
}