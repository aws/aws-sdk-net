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
    /// Describes the strategy for using unused Capacity Reservations for fulfilling On-Demand
    /// capacity.
    /// 
    ///  <note> 
    /// <para>
    /// This strategy can only be used if the EC2 Fleet is of type <c>instant</c>.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information about Capacity Reservations, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-capacity-reservations.html">On-Demand
    /// Capacity Reservations</a> in the <i>Amazon EC2 User Guide</i>. For examples of using
    /// Capacity Reservations in an EC2 Fleet, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-examples.html">EC2
    /// Fleet example configurations</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CapacityReservationOptionsRequest
    {
        private FleetCapacityReservationUsageStrategy _usageStrategy;

        /// <summary>
        /// Gets and sets the property UsageStrategy. 
        /// <para>
        /// Indicates whether to use unused Capacity Reservations for fulfilling On-Demand capacity.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>use-capacity-reservations-first</c>, the fleet uses unused Capacity
        /// Reservations to fulfill On-Demand capacity up to the target On-Demand capacity. If
        /// multiple instance pools have unused Capacity Reservations, the On-Demand allocation
        /// strategy (<c>lowest-price</c> or <c>prioritized</c>) is applied. If the number of
        /// unused Capacity Reservations is less than the On-Demand target capacity, the remaining
        /// On-Demand target capacity is launched according to the On-Demand allocation strategy
        /// (<c>lowest-price</c> or <c>prioritized</c>).
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value, the fleet fulfils the On-Demand capacity according
        /// to the chosen On-Demand allocation strategy.
        /// </para>
        /// </summary>
        public FleetCapacityReservationUsageStrategy UsageStrategy
        {
            get { return this._usageStrategy; }
            set { this._usageStrategy = value; }
        }

        // Check to see if UsageStrategy property is set
        internal bool IsSetUsageStrategy()
        {
            return this._usageStrategy != null;
        }

    }
}