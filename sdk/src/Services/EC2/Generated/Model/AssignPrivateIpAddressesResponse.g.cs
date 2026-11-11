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
    /// This is the response object from the AssignPrivateIpAddresses operation.
    /// </summary>
    public partial class AssignPrivateIpAddressesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssignedIpv4Prefixes. 
        /// <para>
        /// The IPv4 prefixes that are assigned to the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Ipv4PrefixSpecification> AssignedIpv4Prefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<Ipv4PrefixSpecification>() : null;

        /// <summary>
        /// Checks to see if the AssignedIpv4Prefixes property is set.
        /// </summary>
        internal bool IsSetAssignedIpv4Prefixes() => this.AssignedIpv4Prefixes != null && (this.AssignedIpv4Prefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssignedPrivateIpAddresses. 
        /// <para>
        /// The private IP addresses assigned to the network interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssignedPrivateIpAddress> AssignedPrivateIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<AssignedPrivateIpAddress>() : null;

        /// <summary>
        /// Checks to see if the AssignedPrivateIpAddresses property is set.
        /// </summary>
        internal bool IsSetAssignedPrivateIpAddresses() => this.AssignedPrivateIpAddresses != null && (this.AssignedPrivateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;
    }
}
