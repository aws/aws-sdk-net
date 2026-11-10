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
    /// Container for the parameters to the ModifyInstanceConnectEndpoint operation. Modifies
    /// the specified EC2 Instance Connect Endpoint. <para> For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/modify-ec2-instance-connect-endpoint.html">Modify
    /// an EC2 Instance Connect Endpoint</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// </summary>
    public partial class ModifyInstanceConnectEndpointRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
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
        /// Gets and sets the property InstanceConnectEndpointId. 
        /// <para>
        /// The ID of the EC2 Instance Connect Endpoint to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceConnectEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceConnectEndpointId property is set.
        /// </summary>
        internal bool IsSetInstanceConnectEndpointId() => this.InstanceConnectEndpointId != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The new IP address type for the EC2 Instance Connect Endpoint.
        /// </para>
        ///  <note> 
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
        /// Indicates whether the client IP address is preserved as the source when you connect
        /// to a resource. The following are the possible values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>true</c> - Use the IP address of the client. Your instance must have an IPv4 address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>false</c> - Use the IP address of the network interface.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? PreserveClientIp { get; set; }

        /// <summary>
        /// Checks to see if the PreserveClientIp property is set.
        /// </summary>
        internal bool IsSetPreserveClientIp() => this.PreserveClientIp.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// Changes the security groups for the EC2 Instance Connect Endpoint. The new set of
        /// groups you specify replaces the current set. You must specify at least one group,
        /// even if it's just the default security group in the VPC. You must specify the ID of
        /// the security group, not the name.
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
    }
}
