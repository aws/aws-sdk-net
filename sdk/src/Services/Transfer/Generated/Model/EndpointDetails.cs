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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// The virtual private cloud (VPC) endpoint settings that are configured for your file
    /// transfer protocol-enabled server. With a VPC endpoint, you can restrict access to
    /// your server and resources only within your VPC. To control incoming internet traffic,
    /// invoke the <c>UpdateServer</c> API and attach an Elastic IP address to your server's
    /// endpoint.
    /// 
    ///  <note> 
    /// <para>
    ///  After May 19, 2021, you won't be able to create a server using <c>EndpointType=VPC_ENDPOINT</c>
    /// in your Amazon Web Services account if your account hasn't already done so before
    /// May 19, 2021. If you have already created servers with <c>EndpointType=VPC_ENDPOINT</c>
    /// in your Amazon Web Services account on or before May 19, 2021, you will not be affected.
    /// After this date, use <c>EndpointType</c>=<c>VPC</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see https://docs.aws.amazon.com/transfer/latest/userguide/create-server-in-vpc.html#deprecate-vpc-endpoint.
    /// </para>
    ///  
    /// <para>
    /// It is recommended that you use <c>VPC</c> as the <c>EndpointType</c>. With this endpoint
    /// type, you have the option to directly associate up to three Elastic IPv4 addresses
    /// (BYO IP included) with your server's endpoint and use VPC security groups to restrict
    /// traffic by the client's public IP address. This is not possible with <c>EndpointType</c>
    /// set to <c>VPC_ENDPOINT</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class EndpointDetails
    {
        private List<string> _addressAllocationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcEndpointId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AddressAllocationIds. 
        /// <para>
        /// A list of address allocation IDs that are required to attach an Elastic IP address
        /// to your server's endpoint.
        /// </para>
        ///  
        /// <para>
        /// An address allocation ID corresponds to the allocation ID of an Elastic IP address.
        /// This value can be retrieved from the <c>allocationId</c> field from the Amazon EC2
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_Address.html">Address</a>
        /// data type. One way to retrieve this value is by calling the EC2 <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeAddresses.html">DescribeAddresses</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. Set this parameter if you want to make your VPC endpoint
        /// public-facing. For details, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/create-server-in-vpc.html#create-internet-facing-endpoint">Create
        /// an internet-facing endpoint for your server</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This property can only be set as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EndpointType</c> must be set to <c>VPC</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Transfer Family server must be offline.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot set this parameter for Transfer Family servers that use the FTP protocol.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The server must already have <c>SubnetIds</c> populated (<c>SubnetIds</c> and <c>AddressAllocationIds</c>
        /// cannot be updated simultaneously).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AddressAllocationIds</c> can't contain duplicates, and must be equal in length
        /// to <c>SubnetIds</c>. For example, if you have three subnet IDs, you must also specify
        /// three address allocation IDs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <c>UpdateServer</c> API to set or change this parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't set address allocation IDs for servers that have an <c>IpAddressType</c>
        /// set to <c>DUALSTACK</c> You can only set this property if <c>IpAddressType</c> is
        /// set to <c>IPV4</c>.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddressAllocationIds
        {
            get { return this._addressAllocationIds; }
            set { this._addressAllocationIds = value; }
        }

        // Check to see if AddressAllocationIds property is set
        internal bool IsSetAddressAllocationIds()
        {
            return this._addressAllocationIds != null && (this._addressAllocationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of security groups IDs that are available to attach to your server's endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// While <c>SecurityGroupIds</c> appears in the response syntax for consistency with
        /// <c>CreateServer</c> and <c>UpdateServer</c> operations, this field is not populated
        /// in <c>DescribeServer</c> responses. Security groups are managed at the VPC endpoint
        /// level and can be modified outside of the Transfer Family service. To retrieve current
        /// security group information, use the EC2 <c>DescribeVpcEndpoints</c> API with the <c>VpcEndpointId</c>
        /// returned in the response.
        /// </para>
        ///  
        /// <para>
        /// This property can only be set when <c>EndpointType</c> is set to <c>VPC</c>.
        /// </para>
        ///  
        /// <para>
        /// You can edit the <c>SecurityGroupIds</c> property in the <a href="https://docs.aws.amazon.com/transfer/latest/userguide/API_UpdateServer.html">UpdateServer</a>
        /// API only if you are changing the <c>EndpointType</c> from <c>PUBLIC</c> or <c>VPC_ENDPOINT</c>
        /// to <c>VPC</c>. To change security groups associated with your server's VPC endpoint
        /// after creation, use the Amazon EC2 <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifyVpcEndpoint.html">ModifyVpcEndpoint</a>
        /// API.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of subnet IDs that are required to host your server endpoint in your VPC.
        /// </para>
        ///  <note> 
        /// <para>
        /// This property can only be set when <c>EndpointType</c> is set to <c>VPC</c>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The identifier of the VPC endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// This property can only be set when <c>EndpointType</c> is set to <c>VPC_ENDPOINT</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see https://docs.aws.amazon.com/transfer/latest/userguide/create-server-in-vpc.html#deprecate-vpc-endpoint.
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
        /// The VPC identifier of the VPC in which a server's endpoint will be hosted.
        /// </para>
        ///  <note> 
        /// <para>
        /// This property can only be set when <c>EndpointType</c> is set to <c>VPC</c>.
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