/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an address pool.
    /// </summary>
    public partial class PublicIpv4Pool
    {
        private string _description;
        private List<PublicIpv4PoolRange> _poolAddressRanges = new List<PublicIpv4PoolRange>();
        private string _poolId;
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
        /// Gets and sets the property PoolAddressRanges. 
        /// <para>
        /// The address ranges.
        /// </para>
        /// </summary>
        public List<PublicIpv4PoolRange> PoolAddressRanges
        {
            get { return this._poolAddressRanges; }
            set { this._poolAddressRanges = value; }
        }

        // Check to see if PoolAddressRanges property is set
        internal bool IsSetPoolAddressRanges()
        {
            return this._poolAddressRanges != null && this._poolAddressRanges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the IPv4 address pool.
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
        /// Gets and sets the property TotalAddressCount. 
        /// <para>
        /// The total number of addresses.
        /// </para>
        /// </summary>
        public int TotalAddressCount
        {
            get { return this._totalAddressCount.GetValueOrDefault(); }
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
        public int TotalAvailableAddressCount
        {
            get { return this._totalAvailableAddressCount.GetValueOrDefault(); }
            set { this._totalAvailableAddressCount = value; }
        }

        // Check to see if TotalAvailableAddressCount property is set
        internal bool IsSetTotalAvailableAddressCount()
        {
            return this._totalAvailableAddressCount.HasValue; 
        }

    }
}