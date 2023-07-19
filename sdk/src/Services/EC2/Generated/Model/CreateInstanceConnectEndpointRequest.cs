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
    /// Container for the parameters to the CreateInstanceConnectEndpoint operation.
    /// Creates an EC2 Instance Connect Endpoint.
    /// 
    ///  
    /// <para>
    /// An EC2 Instance Connect Endpoint allows you to connect to an instance, without requiring
    /// the instance to have a public IPv4 address. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Connect-using-EC2-Instance-Connect-Endpoint.html">Connect
    /// to your instances without requiring a public IPv4 address using EC2 Instance Connect
    /// Endpoint</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateInstanceConnectEndpointRequest : AmazonEC2Request
    {
        private string _clientToken;
        private bool? _preserveClientIp;
        private List<string> _securityGroupIds = new List<string>();
        private string _subnetId;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property PreserveClientIp. 
        /// <para>
        /// Indicates whether your client's IP address is preserved as the source. The value is
        /// <code>true</code> or <code>false</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <code>true</code>, your client's IP address is used when you connect to a resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <code>false</code>, the elastic network interface IP address is used when you connect
        /// to a resource.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <code>true</code> 
        /// </para>
        /// </summary>
        public bool PreserveClientIp
        {
            get { return this._preserveClientIp.GetValueOrDefault(); }
            set { this._preserveClientIp = value; }
        }

        // Check to see if PreserveClientIp property is set
        internal bool IsSetPreserveClientIp()
        {
            return this._preserveClientIp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// One or more security groups to associate with the endpoint. If you don't specify a
        /// security group, the default security group for your VPC will be associated with the
        /// endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in which to create the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the EC2 Instance Connect Endpoint during creation.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}