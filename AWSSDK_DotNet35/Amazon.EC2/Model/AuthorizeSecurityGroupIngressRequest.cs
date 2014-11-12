/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AuthorizeSecurityGroupIngress operation.
    /// Adds one or more ingress rules to a security group.
    /// 
    ///  <important> 
    /// <para>
    /// EC2-Classic: You can have up to 100 rules per group.
    /// </para>
    ///  
    /// <para>
    /// EC2-VPC: You can have up to 50 rules per group (covering both ingress and egress rules).
    /// </para>
    ///  </important> 
    /// <para>
    /// Rule changes are propagated to instances within the security group as quickly as possible.
    /// However, a small delay might occur.
    /// </para>
    ///  
    /// <para>
    /// [EC2-Classic] This action gives one or more CIDR IP address ranges permission to access
    /// a security group in your account, or gives one or more security groups (called the
    /// <i>source groups</i>) permission to access a security group for your account. A source
    /// group can be for your own AWS account, or another.
    /// </para>
    ///  
    /// <para>
    /// [EC2-VPC] This action gives one or more CIDR IP address ranges permission to access
    /// a security group in your VPC, or gives one or more other security groups (called the
    /// <i>source groups</i>) permission to access a security group for your VPC. The security
    /// groups must all be for the same VPC.
    /// </para>
    /// </summary>
    public partial class AuthorizeSecurityGroupIngressRequest : AmazonEC2Request
    {
        private string _groupId;
        private string _groupName;
        private List<IpPermission> _ipPermissions = new List<IpPermission>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AuthorizeSecurityGroupIngressRequest() { }

        /// <summary>
        /// Instantiates AuthorizeSecurityGroupIngressRequest with the parameterized properties
        /// </summary>
        /// <param name="groupName">[EC2-Classic, default VPC] The name of the security group.</param>
        /// <param name="ipPermissions">A set of IP permissions. You can't specify a source security group and a CIDR IP address range.</param>
        public AuthorizeSecurityGroupIngressRequest(string groupName, List<IpPermission> ipPermissions)
        {
            _groupName = groupName;
            _ipPermissions = ipPermissions;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group.
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
        /// Gets and sets the property GroupName. 
        /// <para>
        /// [EC2-Classic, default VPC] The name of the security group.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property IpPermissions. 
        /// <para>
        /// A set of IP permissions. You can't specify a source security group and a CIDR IP address
        /// range.
        /// </para>
        /// </summary>
        public List<IpPermission> IpPermissions
        {
            get { return this._ipPermissions; }
            set { this._ipPermissions = value; }
        }

        // Check to see if IpPermissions property is set
        internal bool IsSetIpPermissions()
        {
            return this._ipPermissions != null && this._ipPermissions.Count > 0; 
        }

    }
}