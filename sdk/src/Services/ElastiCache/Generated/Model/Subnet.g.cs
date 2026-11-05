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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Represents the subnet associated with a cluster. This parameter refers to subnets
    /// defined in Amazon Virtual Private Cloud (Amazon VPC) and used with ElastiCache.
    /// </summary>
    public partial class Subnet
    {
        /// <summary>
        /// Gets and sets the property SubnetAvailabilityZone. 
        /// <para>
        /// The Availability Zone associated with the subnet.
        /// </para>
        /// </summary>
        public AvailabilityZone SubnetAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the SubnetAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetSubnetAvailabilityZone() => this.SubnetAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property SubnetIdentifier. 
        /// <para>
        /// The unique identifier for the subnet.
        /// </para>
        /// </summary>
        public string SubnetIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SubnetIdentifier property is set.
        /// </summary>
        internal bool IsSetSubnetIdentifier() => this.SubnetIdentifier != null;

        /// <summary>
        /// Gets and sets the property SubnetOutpost. 
        /// <para>
        /// The outpost ARN of the subnet.
        /// </para>
        /// </summary>
        public SubnetOutpost SubnetOutpost { get; set; }

        /// <summary>
        /// Checks to see if the SubnetOutpost property is set.
        /// </summary>
        internal bool IsSetSubnetOutpost() => this.SubnetOutpost != null;

        /// <summary>
        /// Gets and sets the property SupportedNetworkTypes. 
        /// <para>
        /// Either <c>ipv4</c> | <c>ipv6</c> | <c>dual_stack</c>. IPv6 is supported for workloads
        /// using Valkey 7.2 and above, Redis OSS engine version 6.2 to 7.1 or Memcached engine
        /// version 1.6.6 and above on all instances built on the <a href="http://aws.amazon.com/ec2/nitro/">Nitro
        /// system</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedNetworkTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedNetworkTypes property is set.
        /// </summary>
        internal bool IsSetSupportedNetworkTypes() => this.SupportedNetworkTypes != null && (this.SupportedNetworkTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
