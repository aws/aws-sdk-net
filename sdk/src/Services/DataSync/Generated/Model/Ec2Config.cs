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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// The subnet and the security group that DataSync uses to access target EFS file system.
    /// The subnet must have at least one mount target for that file system. The security
    /// group that you provide needs to be able to communicate with the security group on
    /// the mount target in the subnet specified.
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
        [AWSProperty(Required=true, Min=1, Max=5)]
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
        /// The ARN of the subnet and the security group that DataSync uses to access the target
        /// EFS file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
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