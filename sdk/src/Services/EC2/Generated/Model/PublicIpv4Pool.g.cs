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
    /// Describes an IPv4 address pool.
    /// </summary>
    public partial class PublicIpv4Pool
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the address pool.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The name of the location from which the address pool is advertised. A network border
        /// group is a unique set of Availability Zones or Local Zones from where Amazon Web Services
        /// advertises public IP addresses.
        /// </para>
        /// </summary>
        public string NetworkBorderGroup { get; set; }

        /// <summary>
        /// Checks to see if the NetworkBorderGroup property is set.
        /// </summary>
        internal bool IsSetNetworkBorderGroup() => this.NetworkBorderGroup != null;

        /// <summary>
        /// Gets and sets the property PoolAddressRanges. 
        /// <para>
        /// The address ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PublicIpv4PoolRange> PoolAddressRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<PublicIpv4PoolRange>() : null;

        /// <summary>
        /// Checks to see if the PoolAddressRanges property is set.
        /// </summary>
        internal bool IsSetPoolAddressRanges() => this.PoolAddressRanges != null && (this.PoolAddressRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the address pool.
        /// </para>
        /// </summary>
        public string PoolId { get; set; }

        /// <summary>
        /// Checks to see if the PoolId property is set.
        /// </summary>
        internal bool IsSetPoolId() => this.PoolId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags for the address pool.
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
        /// Gets and sets the property TotalAddressCount. 
        /// <para>
        /// The total number of addresses.
        /// </para>
        /// </summary>
        public int? TotalAddressCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalAddressCount property is set.
        /// </summary>
        internal bool IsSetTotalAddressCount() => this.TotalAddressCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalAvailableAddressCount. 
        /// <para>
        /// The total number of available addresses.
        /// </para>
        /// </summary>
        public int? TotalAvailableAddressCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalAvailableAddressCount property is set.
        /// </summary>
        internal bool IsSetTotalAvailableAddressCount() => this.TotalAvailableAddressCount.HasValue;
    }
}
