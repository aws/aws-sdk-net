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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The subnet and the security group that the target Amazon EFS file system uses. The
    /// subnet must have at least one mount target for that file system. The security group
    /// that you provide needs to be able to communicate with the security group on the mount
    /// target in the subnet specified. 
    /// 
    ///  
    /// <para>
    /// The exact relationship between security group M (of the mount target) and security
    /// group S (which you provide for DataSync to use at this stage) is as follows: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  Security group M (which you associate with the mount target) must allow inbound access
    /// for the Transmission Control Protocol (TCP) on the NFS port (2049) from security group
    /// S. You can enable inbound connections either by IP address (CIDR range) or security
    /// group. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Security group S (provided to DataSync to access EFS) should have a rule that enables
    /// outbound connections to the NFS port on one of the file system’s mount targets. You
    /// can enable outbound connections either by IP address (CIDR range) or security group.
    /// For information about security groups and mount targets, see <a href="https://docs.aws.amazon.com/efs/latest/ug/security-considerations.html#network-access">Security
    /// Groups for Amazon EC2 Instances and Mount Targets</a> in the <i>Amazon EFS User Guide.</i>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Ec2Config
    {
        private List<string> _securityGroupArns = new List<string>();
        private string _subnetArn;

        /// <summary>
        /// Gets and sets the property SecurityGroupArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the security groups that are configured for the
        /// Amazon EC2 resource.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupArns
        {
            get { return this._securityGroupArns; }
            set { this._securityGroupArns = value; }
        }

        // Check to see if SecurityGroupArns property is set
        internal bool IsSetSecurityGroupArns()
        {
            return this._securityGroupArns != null && this._securityGroupArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetArn. 
        /// <para>
        /// The ARN of the subnet that the Amazon EC2 resource belongs in. 
        /// </para>
        /// </summary>
        public string SubnetArn
        {
            get { return this._subnetArn; }
            set { this._subnetArn = value; }
        }

        // Check to see if SubnetArn property is set
        internal bool IsSetSubnetArn()
        {
            return this._subnetArn != null;
        }

    }
}