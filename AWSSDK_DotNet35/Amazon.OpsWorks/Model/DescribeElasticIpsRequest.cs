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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeElasticIps operation.
    /// Describes <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
    /// IP addresses</a>.
    /// 
    ///  
    /// <para>
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
    /// or Manage permissions level for the stack, or an attached policy that explicitly grants
    /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class DescribeElasticIpsRequest : AmazonOpsWorksRequest
    {
        private string _instanceId;
        private List<string> _ips = new List<string>();
        private string _stackId;


        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID. If you include this parameter, <code>DescribeElasticIps</code> returns
        /// a description of the Elastic IP addresses associated with the specified instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }


        /// <summary>
        /// Gets and sets the property Ips. 
        /// <para>
        /// An array of Elastic IP addresses to be described. If you include this parameter, <code>DescribeElasticIps</code>
        /// returns a description of the specified Elastic IP addresses. Otherwise, it returns
        /// a description of every Elastic IP address.
        /// </para>
        /// </summary>
        public List<string> Ips
        {
            get { return this._ips; }
            set { this._ips = value; }
        }

        // Check to see if Ips property is set
        internal bool IsSetIps()
        {
            return this._ips != null && this._ips.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// A stack ID. If you include this parameter, <code>DescribeElasticIps</code> returns
        /// a description of the Elastic IP addresses that are registered with the specified stack.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}