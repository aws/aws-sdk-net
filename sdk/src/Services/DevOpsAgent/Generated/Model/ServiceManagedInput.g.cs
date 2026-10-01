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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Configuration for a service-managed Private Connection.
    /// </summary>
    public partial class ServiceManagedInput
    {
        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// Certificate for the Private Connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32768)]
        public string Certificate { get; set; }

        /// <summary>
        /// Checks to see if the Certificate property is set.
        /// </summary>
        internal bool IsSetCertificate() => this.Certificate != null;

        /// <summary>
        /// Gets and sets the property DnsResolution. 
        /// <para>
        /// DNS resolution mode for the resource gateway. Defaults to PUBLIC when not set.
        /// </para>
        /// </summary>
        public ResourceConfigDnsResolution DnsResolution { get; set; }

        /// <summary>
        /// Checks to see if the DnsResolution property is set.
        /// </summary>
        internal bool IsSetDnsResolution() => this.DnsResolution != null;

        /// <summary>
        /// Gets and sets the property HostAddress. 
        /// <para>
        /// IP address or DNS name of the target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 255)]
        public string HostAddress { get; set; }

        /// <summary>
        /// Checks to see if the HostAddress property is set.
        /// </summary>
        internal bool IsSetHostAddress() => this.HostAddress != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// IP address type of the service-managed Resource Gateway.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property Ipv4AddressesPerEni. 
        /// <para>
        /// Number of IPv4 addresses in each ENI for the service-managed Resource Gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 62)]
        public int? Ipv4AddressesPerEni { get; set; }

        /// <summary>
        /// Checks to see if the Ipv4AddressesPerEni property is set.
        /// </summary>
        internal bool IsSetIpv4AddressesPerEni() => this.Ipv4AddressesPerEni.HasValue;

        /// <summary>
        /// Gets and sets the property PortRanges. 
        /// <para>
        /// TCP port ranges that a consumer can use to access the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 11)]
        public List<string> PortRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PortRanges property is set.
        /// </summary>
        internal bool IsSetPortRanges() => this.PortRanges != null && (this.PortRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// Security groups to attach to the service-managed Resource Gateway. If not specified,
        /// a default security group is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// Subnets that the service-managed Resource Gateway will span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// VPC to create the service-managed Resource Gateway in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 50)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
