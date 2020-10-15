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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// The virtual private cloud (VPC) endpoint settings that are configured for your file
    /// transfer protocol-enabled server. With a VPC endpoint, you can restrict access to
    /// your server and resources only within your VPC. To control incoming internet traffic,
    /// invoke the <code>UpdateServer</code> API and attach an Elastic IP to your server's
    /// endpoint.
    /// </summary>
    public partial class EndpointDetails
    {
        private List<string> _addressAllocationIds = new List<string>();
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _subnetIds = new List<string>();
        private string _vpcEndpointId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AddressAllocationIds. 
        /// <para>
        /// A list of address allocation IDs that are required to attach an Elastic IP address
        /// to your server's endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// This property can only be set when <code>EndpointType</code> is set to <code>VPC</code>
        /// and it is only valid in the <code>UpdateServer</code> API.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> AddressAllocationIds
        {
            get { return this._addressAllocationIds; }
            set { this._addressAllocationIds = value; }
        }

        // Check to see if AddressAllocationIds property is set
        internal bool IsSetAddressAllocationIds()
        {
            return this._addressAllocationIds != null && this._addressAllocationIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of security groups IDs that are available to attach to your server's endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// This property can only be set when <code>EndpointType</code> is set to <code>VPC</code>.
        /// </para>
        ///  
        /// <para>
        /// You can only edit the <code>SecurityGroupIds</code> property in the <code>UpdateServer</code>
        /// API and only if you are changing the <code>EndpointType</code> from <code>PUBLIC</code>
        /// or <code>VPC_ENDPOINT</code> to <code>VPC</code>.
        /// </para>
        ///  </note>
        /// </summary>
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of subnet IDs that are required to host your server endpoint in your VPC.
        /// </para>
        ///  <note> 
        /// <para>
        /// This property can only be set when <code>EndpointType</code> is set to <code>VPC</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// This property can only be set when <code>EndpointType</code> is set to <code>VPC_ENDPOINT</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string VpcEndpointId
        {
            get { return this._vpcEndpointId; }
            set { this._vpcEndpointId = value; }
        }

        // Check to see if VpcEndpointId property is set
        internal bool IsSetVpcEndpointId()
        {
            return this._vpcEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID of the VPC in which a server's endpoint will be hosted.
        /// </para>
        ///  <note> 
        /// <para>
        /// This property can only be set when <code>EndpointType</code> is set to <code>VPC</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}