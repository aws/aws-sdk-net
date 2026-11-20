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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The public IP addresses that an internet gateway firewall uses for network address
    /// translation in one Availability Zone. Resources that don't have a public IP address
    /// reach the internet through these addresses. Network Firewall manages the addresses
    /// for you: it allocates them in your account and adds or removes addresses automatically
    /// based on traffic.
    /// </summary>
    public partial class AddressTranslations
    {
        /// <summary>
        /// Gets and sets the property PublicIPv4Addresses. 
        /// <para>
        /// The public IPv4 addresses that the internet gateway firewall uses for network address
        /// translation in this Availability Zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PublicIPv4Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PublicIPv4Addresses property is set.
        /// </summary>
        internal bool IsSetPublicIPv4Addresses() => this.PublicIPv4Addresses != null && (this.PublicIPv4Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PublicIPv6Addresses. 
        /// <para>
        /// The public IPv6 addresses that the internet gateway firewall uses for network address
        /// translation in this Availability Zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PublicIPv6Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PublicIPv6Addresses property is set.
        /// </summary>
        internal bool IsSetPublicIPv6Addresses() => this.PublicIPv6Addresses != null && (this.PublicIPv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
