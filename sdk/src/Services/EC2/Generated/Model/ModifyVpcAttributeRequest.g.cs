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
    /// Container for the parameters to the ModifyVpcAttribute operation. Modifies the specified
    /// attribute of the specified VPC.
    /// </summary>
    public partial class ModifyVpcAttributeRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property EnableDnsHostnames. 
        /// <para>
        /// Indicates whether the instances launched in the VPC get DNS hostnames. If enabled,
        /// instances in the VPC get DNS hostnames; otherwise, they do not.
        /// </para>
        ///  
        /// <para>
        /// You cannot modify the DNS resolution and DNS hostnames attributes in the same request.
        /// Use separate requests for each attribute. You can only enable DNS hostnames if you've
        /// enabled DNS support.
        /// </para>
        /// </summary>
        public bool? EnableDnsHostnames { get; set; }

        /// <summary>
        /// Checks to see if the EnableDnsHostnames property is set.
        /// </summary>
        internal bool IsSetEnableDnsHostnames() => this.EnableDnsHostnames.HasValue;

        /// <summary>
        /// Gets and sets the property EnableDnsSupport. 
        /// <para>
        /// Indicates whether the DNS resolution is supported for the VPC. If enabled, queries
        /// to the Amazon provided DNS server at the 169.254.169.253 IP address, or the reserved
        /// IP address at the base of the VPC network range "plus two" succeed. If disabled, the
        /// Amazon provided DNS service in the VPC that resolves public DNS hostnames to IP addresses
        /// is not enabled.
        /// </para>
        ///  
        /// <para>
        /// You cannot modify the DNS resolution and DNS hostnames attributes in the same request.
        /// Use separate requests for each attribute.
        /// </para>
        /// </summary>
        public bool? EnableDnsSupport { get; set; }

        /// <summary>
        /// Checks to see if the EnableDnsSupport property is set.
        /// </summary>
        internal bool IsSetEnableDnsSupport() => this.EnableDnsSupport.HasValue;

        /// <summary>
        /// Gets and sets the property EnableNetworkAddressUsageMetrics. 
        /// <para>
        /// Indicates whether Network Address Usage metrics are enabled for your VPC.
        /// </para>
        /// </summary>
        public bool? EnableNetworkAddressUsageMetrics { get; set; }

        /// <summary>
        /// Checks to see if the EnableNetworkAddressUsageMetrics property is set.
        /// </summary>
        internal bool IsSetEnableNetworkAddressUsageMetrics() => this.EnableNetworkAddressUsageMetrics.HasValue;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
