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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _description;
        private string _networkBorderGroup;
        private List<PublicIpv4PoolRange> _poolAddressRanges = AWSConfigs.InitializeCollections ? new List<PublicIpv4PoolRange>() : null;
        private string _poolId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private int? _totalAddressCount;
        private int? _totalAvailableAddressCount;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the address pool.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The name of the location from which the address pool is advertised. A network border
        /// group is a unique set of Availability Zones or Local Zones from where Amazon Web Services
        /// advertises public IP addresses.
        /// </para>
        /// </summary>
        public string NetworkBorderGroup
        {
            get { return this._networkBorderGroup; }
            set { this._networkBorderGroup = value; }
        }

        // Check to see if NetworkBorderGroup property is set
        internal bool IsSetNetworkBorderGroup()
        {
            return this._networkBorderGroup != null;
        }

        /// <summary>
        /// Gets and sets the property PoolAddressRanges. 
        /// <para>
        /// The address ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PublicIpv4PoolRange> PoolAddressRanges
        {
            get { return this._poolAddressRanges; }
            set { this._poolAddressRanges = value; }
        }

        // Check to see if PoolAddressRanges property is set
        internal bool IsSetPoolAddressRanges()
        {
            return this._poolAddressRanges != null && (this._poolAddressRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the address pool.
        /// </para>
        /// </summary>
        public string PoolId
        {
            get { return this._poolId; }
            set { this._poolId = value; }
        }

        // Check to see if PoolId property is set
        internal bool IsSetPoolId()
        {
            return this._poolId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags for the address pool.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalAddressCount. 
        /// <para>
        /// The total number of addresses.
        /// </para>
        /// </summary>
        public int? TotalAddressCount
        {
            get { return this._totalAddressCount; }
            set { this._totalAddressCount = value; }
        }

        // Check to see if TotalAddressCount property is set
        internal bool IsSetTotalAddressCount()
        {
            return this._totalAddressCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalAvailableAddressCount. 
        /// <para>
        /// The total number of available addresses.
        /// </para>
        /// </summary>
        public int? TotalAvailableAddressCount
        {
            get { return this._totalAvailableAddressCount; }
            set { this._totalAvailableAddressCount = value; }
        }

        // Check to see if TotalAvailableAddressCount property is set
        internal bool IsSetTotalAvailableAddressCount()
        {
            return this._totalAvailableAddressCount.HasValue; 
        }

    }
}