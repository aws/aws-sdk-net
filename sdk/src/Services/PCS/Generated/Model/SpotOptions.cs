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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// Additional configuration when you specify <c>SPOT</c> as the <c>purchaseOption</c>
    /// for the <c>CreateComputeNodeGroup</c> API action.
    /// </summary>
    public partial class SpotOptions
    {
        private SpotAllocationStrategy _allocationStrategy;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The Amazon EC2 allocation strategy PCS uses to provision EC2 instances. PCS supports
        /// <b>lowest price</b>, <b>capacity optimized</b>, and <b>price capacity optimized</b>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet-allocation-strategy.html">Use
        /// allocation strategies to determine how EC2 Fleet or Spot Fleet fulfills Spot and On-Demand
        /// capacity</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. If you don't provide
        /// this option, it defaults to <b>price capacity optimized</b>.
        /// </para>
        /// </summary>
        public SpotAllocationStrategy AllocationStrategy
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