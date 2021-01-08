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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// An object representing the remote access configuration for the managed node group.
    /// </summary>
    public partial class RemoteAccessConfig
    {
        private string _ec2SshKey;
        private List<string> _sourceSecurityGroups = new List<string>();

        /// <summary>
        /// Gets and sets the property Ec2SshKey. 
        /// <para>
        /// The Amazon EC2 SSH key that provides access for SSH communication with the worker
        /// nodes in the managed node group. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Amazon
        /// EC2 Key Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        public string Ec2SshKey
        {
            get { return this._ec2SshKey; }
            set { this._ec2SshKey = value; }
        }

        // Check to see if Ec2SshKey property is set
        internal bool IsSetEc2SshKey()
        {
            return this._ec2SshKey != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSecurityGroups. 
        /// <para>
        /// The security groups that are allowed SSH access (port 22) to the worker nodes. If
        /// you specify an Amazon EC2 SSH key but do not specify a source security group when
        /// you create a managed node group, then port 22 on the worker nodes is opened to the
        /// internet (0.0.0.0/0). For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> SourceSecurityGroups
        {
            get { return this._sourceSecurityGroups; }
            set { this._sourceSecurityGroups = value; }
        }

        // Check to see if SourceSecurityGroups property is set
        internal bool IsSetSourceSecurityGroups()
        {
            return this._sourceSecurityGroups != null && this._sourceSecurityGroups.Count > 0; 
        }

    }
}