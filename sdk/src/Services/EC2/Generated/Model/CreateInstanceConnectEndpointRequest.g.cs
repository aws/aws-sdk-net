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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateInstanceConnectEndpoint operation. Creates
    /// an EC2 Instance Connect Endpoint. <para> An EC2 Instance Connect Endpoint allows you
    /// to connect to an instance, without requiring the instance to have a public IPv4 or
    /// public IPv6 address. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Connect-using-EC2-Instance-Connect-Endpoint.html">Connect
    /// to your instances using EC2 Instance Connect Endpoint</a> in the <i>Amazon EC2 User
    /// Guide</i>. </para>
    /// </summary>
    public partial class CreateInstanceConnectEndpointRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type of the endpoint.
        /// </para>
        ///  
        /// <para>
        /// If no value is specified, the default value is determined by the IP address type of
        /// the subnet:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>dualstack</c> - If the subnet has both IPv4 and IPv6 CIDRs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv4</c> - If the subnet has only IPv4 CIDRs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6</c> - If the subnet has only IPv6 CIDRs
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <c>PreserveClientIp</c> is only supported on IPv4 EC2 Instance Connect Endpoints.
        /// To use <c>PreserveClientIp</c>, the value for <c>IpAddressType</c> must be <c>ipv4</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property PreserveClientIp. 
        /// <para>
        /// Indicates whether the client IP address is preserved as the source. The following
        /// are the possible values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>true</c> - Use the client IP address as the source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>false</c> - Use the network interface IP address as the source.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <c>PreserveClientIp</c> is only supported on IPv4 EC2 Instance Connect Endpoints.
        /// To use <c>PreserveClientIp</c>, the value for <c>IpAddressType</c> must be <c>ipv4</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? PreserveClientIp { get; set; }

        /// <summary>
        /// Checks to see if the PreserveClientIp property is set.
        /// </summary>
        internal bool IsSetPreserveClientIp() => this.PreserveClientIp.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// One or more security groups to associate with the endpoint. If you don't specify a
        /// security group, the default security group for your VPC will be associated with the
        /// endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in which to create the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the EC2 Instance Connect Endpoint during creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
