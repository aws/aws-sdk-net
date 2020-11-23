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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The launch specification for On-Demand Instances in the instance fleet, which determines
    /// the allocation strategy. 
    /// 
    ///  <note> 
    /// <para>
    /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
    /// later, excluding 5.0.x versions. On-Demand Instances allocation strategy is available
    /// in Amazon EMR version 5.12.1 and later.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class OnDemandProvisioningSpecification
    {
        private OnDemandProvisioningAllocationStrategy _allocationStrategy;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        ///  Specifies the strategy to use in launching On-Demand Instance fleets. Currently,
        /// the only option is lowest-price (the default), which launches the lowest price first.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OnDemandProvisioningAllocationStrategy AllocationStrategy
        {
            get { return this._allocationStrategy; }
            set { this._allocationStrategy = value; }
        }

        // Check to see if AllocationStrategy property is set
        internal bool IsSetAllocationStrategy()
        {
            return this._allocationStrategy != null;
        }

    }
}