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
    /// Describes an EC2 Instance Connect Endpoint.
    /// </summary>
    public partial class Ec2InstanceConnectEndpoint
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone of the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the EC2 Instance Connect Endpoint was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name of the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public string DnsName { get; set; }

        /// <summary>
        /// Checks to see if the DnsName property is set.
        /// </summary>
        internal bool IsSetDnsName() => this.DnsName != null;

        /// <summary>
        /// Gets and sets the property FipsDnsName. 
        /// <para>
        /// The Federal Information Processing Standards (FIPS) compliant DNS name of the EC2
        /// Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public string FipsDnsName { get; set; }

        /// <summary>
        /// Checks to see if the FipsDnsName property is set.
        /// </summary>
        internal bool IsSetFipsDnsName() => this.FipsDnsName != null;

        /// <summary>
        /// Gets and sets the property InstanceConnectEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string InstanceConnectEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceConnectEndpointArn property is set.
        /// </summary>
        internal bool IsSetInstanceConnectEndpointArn() => this.InstanceConnectEndpointArn != null;

        /// <summary>
        /// Gets and sets the property InstanceConnectEndpointId. 
        /// <para>
        /// The ID of the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public string InstanceConnectEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceConnectEndpointId property is set.
        /// </summary>
        internal bool IsSetInstanceConnectEndpointId() => this.InstanceConnectEndpointId != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type of the endpoint.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceIds. 
        /// <para>
        /// The ID of the elastic network interface that Amazon EC2 automatically created when
        /// creating the EC2 Instance Connect Endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NetworkInterfaceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfaceIds property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceIds() => this.NetworkInterfaceIds != null && (this.NetworkInterfaceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that created the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PreserveClientIp. 
        /// <para>
        /// Indicates whether your client's IP address is preserved as the source when you connect
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
        /// Gets and sets the property PublicDnsNames. 
        /// <para>
        /// The public DNS names of the endpoint.
        /// </para>
        /// </summary>
        public InstanceConnectEndpointPublicDnsNames PublicDnsNames { get; set; }

        /// <summary>
        /// Checks to see if the PublicDnsNames property is set.
        /// </summary>
        internal bool IsSetPublicDnsNames() => this.PublicDnsNames != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security groups associated with the endpoint. If you didn't specify a security
        /// group, the default security group for your VPC is associated with the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the EC2 Instance Connect Endpoint.
        /// </para>
        /// </summary>
        public Ec2InstanceConnectEndpointState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// The message for the current state of the EC2 Instance Connect Endpoint. Can include
        /// a failure message.
        /// </para>
        /// </summary>
        public string StateMessage { get; set; }

        /// <summary>
        /// Checks to see if the StateMessage property is set.
        /// </summary>
        internal bool IsSetStateMessage() => this.StateMessage != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in which the EC2 Instance Connect Endpoint was created.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the EC2 Instance Connect Endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC in which the EC2 Instance Connect Endpoint was created.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
