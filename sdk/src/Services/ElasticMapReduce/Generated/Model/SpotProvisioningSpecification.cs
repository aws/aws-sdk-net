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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The launch specification for Spot Instances in the instance fleet, which determines
    /// the defined duration, provisioning timeout behavior, and allocation strategy.
    /// 
    ///  <note> 
    /// <para>
    /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
    /// later, excluding 5.0.x versions. Spot Instance allocation strategy is available in
    /// Amazon EMR releases 5.12.1 and later.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Spot Instances with a defined duration (also known as Spot blocks) are no longer available
    /// to new customers from July 1, 2021. For customers who have previously used the feature,
    /// we will continue to support Spot Instances with a defined duration until December
    /// 31, 2022. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SpotProvisioningSpecification
    {
        private SpotProvisioningAllocationStrategy _allocationStrategy;
        private int? _blockDurationMinutes;
        private SpotProvisioningTimeoutAction _timeoutAction;
        private int? _timeoutDurationMinutes;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// Specifies one of the following strategies to launch Spot Instance fleets: <c>capacity-optimized</c>,
        /// <c>price-capacity-optimized</c>, <c>lowest-price</c>, or <c>diversified</c>, and <c>capacity-optimized-prioritized</c>.
        /// For more information on the provisioning strategies, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-allocation-strategy.html">Allocation
        /// strategies for Spot Instances</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you launch a Spot Instance fleet with the old console, it automatically launches
        /// with the <c>capacity-optimized</c> strategy. You can't change the allocation strategy
        /// from the old console.
        /// </para>
        ///  </note>
        /// </summary>
        public SpotProvisioningAllocationStrategy AllocationStrategy
        {
            get { return this._allocationStrategy; }
            set { this._allocationStrategy = value; }
        }

        // Check to see if AllocationStrategy property is set
        internal bool IsSetAllocationStrategy()
        {
            return this._allocationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property BlockDurationMinutes. 
        /// <para>
        /// The defined duration for Spot Instances (also known as Spot blocks) in minutes. When
        /// specified, the Spot Instance does not terminate before the defined duration expires,
        /// and defined duration pricing for Spot Instances applies. Valid values are 60, 120,
        /// 180, 240, 300, or 360. The duration period starts as soon as a Spot Instance receives
        /// its instance ID. At the end of the duration, Amazon EC2 marks the Spot Instance for
        /// termination and provides a Spot Instance termination notice, which gives the instance
        /// a two-minute warning before it terminates. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Spot Instances with a defined duration (also known as Spot blocks) are no longer available
        /// to new customers from July 1, 2021. For customers who have previously used the feature,
        /// we will continue to support Spot Instances with a defined duration until December
        /// 31, 2022. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? BlockDurationMinutes
        {
            get { return this._blockDurationMinutes; }
            set { this._blockDurationMinutes = value; }
        }

        // Check to see if BlockDurationMinutes property is set
        internal bool IsSetBlockDurationMinutes()
        {
            return this._blockDurationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutAction. 
        /// <para>
        /// The action to take when <c>TargetSpotCapacity</c> has not been fulfilled when the
        /// <c>TimeoutDurationMinutes</c> has expired; that is, when all Spot Instances could
        /// not be provisioned within the Spot provisioning timeout. Valid values are <c>TERMINATE_CLUSTER</c>
        /// and <c>SWITCH_TO_ON_DEMAND</c>. SWITCH_TO_ON_DEMAND specifies that if no Spot Instances
        /// are available, On-Demand Instances should be provisioned to fulfill any remaining
        /// Spot capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SpotProvisioningTimeoutAction TimeoutAction
        {
            get { return this._timeoutAction; }
            set { this._timeoutAction = value; }
        }

        // Check to see if TimeoutAction property is set
        internal bool IsSetTimeoutAction()
        {
            return this._timeoutAction != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutDurationMinutes. 
        /// <para>
        /// The Spot provisioning timeout period in minutes. If Spot Instances are not provisioned
        /// within this time period, the <c>TimeOutAction</c> is taken. Minimum value is 5 and
        /// maximum value is 1440. The timeout applies only during initial provisioning, when
        /// the cluster is first created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? TimeoutDurationMinutes
        {
            get { return this._timeoutDurationMinutes; }
            set { this._timeoutDurationMinutes = value; }
        }

        // Check to see if TimeoutDurationMinutes property is set
        internal bool IsSetTimeoutDurationMinutes()
        {
            return this._timeoutDurationMinutes.HasValue; 
        }

    }
}