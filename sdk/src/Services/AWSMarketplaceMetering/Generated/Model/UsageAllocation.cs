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
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSMarketplaceMetering.Model
{
    /// <summary>
    /// Usage allocations allow you to split usage into buckets by tags.
    /// 
    ///  
    /// <para>
    /// Each UsageAllocation indicates the usage quantity for a specific set of tags.
    /// </para>
    /// </summary>
    public partial class UsageAllocation
    {
        private int? _allocatedUsageQuantity;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AllocatedUsageQuantity. 
        /// <para>
        /// The total quantity allocated to this bucket of usage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int AllocatedUsageQuantity
        {
            get { return this._allocatedUsageQuantity.GetValueOrDefault(); }
            set { this._allocatedUsageQuantity = value; }
        }

        // Check to see if AllocatedUsageQuantity property is set
        internal bool IsSetAllocatedUsageQuantity()
        {
            return this._allocatedUsageQuantity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The set of tags that define the bucket of usage. For the bucket of items with no tags,
        /// this parameter can be left out.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}