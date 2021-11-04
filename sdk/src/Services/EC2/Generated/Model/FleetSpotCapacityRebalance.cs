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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The strategy to use when Amazon EC2 emits a signal that your Spot Instance is at an
    /// elevated risk of being interrupted.
    /// </summary>
    public partial class FleetSpotCapacityRebalance
    {
        private FleetReplacementStrategy _replacementStrategy;
        private int? _terminationDelay;

        /// <summary>
        /// Gets and sets the property ReplacementStrategy. 
        /// <para>
        /// The replacement strategy to use. Only available for fleets of type <code>maintain</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>launch</code> - EC2 Fleet launches a new replacement Spot Instance when a rebalance
        /// notification is emitted for an existing Spot Instance in the fleet. EC2 Fleet does
        /// not terminate the instances that receive a rebalance notification. You can terminate
        /// the old instances, or you can leave them running. You are charged for all instances
        /// while they are running. 
        /// </para>
        ///  
        /// <para>
        ///  <code>launch-before-terminate</code> - EC2 Fleet launches a new replacement Spot
        /// Instance when a rebalance notification is emitted for an existing Spot Instance in
        /// the fleet, and then, after a delay that you specify (in <code>TerminationDelay</code>),
        /// terminates the instances that received a rebalance notification.
        /// </para>
        /// </summary>
        public FleetReplacementStrategy ReplacementStrategy
        {
            get { return this._replacementStrategy; }
            set { this._replacementStrategy = value; }
        }

        // Check to see if ReplacementStrategy property is set
        internal bool IsSetReplacementStrategy()
        {
            return this._replacementStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property TerminationDelay. 
        /// <para>
        /// The amount of time (in seconds) that Amazon EC2 waits before terminating the old Spot
        /// Instance after launching a new replacement Spot Instance.
        /// </para>
        /// </summary>
        public int TerminationDelay
        {
            get { return this._terminationDelay.GetValueOrDefault(); }
            set { this._terminationDelay = value; }
        }

        // Check to see if TerminationDelay property is set
        internal bool IsSetTerminationDelay()
        {
            return this._terminationDelay.HasValue; 
        }

    }
}