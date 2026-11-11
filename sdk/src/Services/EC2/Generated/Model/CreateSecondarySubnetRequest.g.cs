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
    /// Container for the parameters to the CreateSecondarySubnet operation. Creates a secondary
    /// subnet in a secondary network. <para> A secondary subnet CIDR block must not overlap
    /// with the CIDR block of an existing secondary subnet in the secondary network. After
    /// you create a secondary subnet, you can't change its CIDR block. </para> <para> The
    /// allowed size for a secondary subnet CIDR block is between /28 netmask (16 IP addresses)
    /// and /12 netmask (1,048,576 IP addresses). Amazon reserves the first four IP addresses
    /// and the last IP address in each secondary subnet for internal use. </para>
    /// </summary>
    public partial class CreateSecondarySubnetRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the secondary subnet. You cannot specify both <c>AvailabilityZone</c>
        /// and <c>AvailabilityZoneId</c> in the same request.
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
        /// The ID of the Availability Zone for the secondary subnet. This option is preferred
        /// over <c>AvailabilityZone</c> as it provides a consistent identifier across Amazon
        /// Web Services accounts. You cannot specify both <c>AvailabilityZone</c> and <c>AvailabilityZoneId</c>
        /// in the same request.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensure
        /// Idempotency</a>.
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
        /// Gets and sets the property Ipv4CidrBlock. 
        /// <para>
        /// The IPv4 CIDR block for the secondary subnet. The CIDR block size must be between
        /// /12 and /28.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Ipv4CidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the Ipv4CidrBlock property is set.
        /// </summary>
        internal bool IsSetIpv4CidrBlock() => this.Ipv4CidrBlock != null;

        /// <summary>
        /// Gets and sets the property SecondaryNetworkId. 
        /// <para>
        /// The ID of the secondary network in which to create the secondary subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecondaryNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryNetworkId property is set.
        /// </summary>
        internal bool IsSetSecondaryNetworkId() => this.SecondaryNetworkId != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the secondary subnet.
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
