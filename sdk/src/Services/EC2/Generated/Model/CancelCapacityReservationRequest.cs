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
    /// Container for the parameters to the CancelCapacityReservation operation.
    /// Cancels the specified Capacity Reservation, releases the reserved capacity, and changes
    /// the Capacity Reservation's state to <c>cancelled</c>.
    /// 
    ///  
    /// <para>
    /// You can cancel a Capacity Reservation that is in the following states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>assessing</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>active</c> and there is no commitment duration or the commitment duration has
    /// elapsed. You can't cancel a future-dated Capacity Reservation during the commitment
    /// duration.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// You can't modify or cancel a Capacity Block. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-capacity-blocks.html">Capacity
    /// Blocks for ML</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// If a future-dated Capacity Reservation enters the <c>delayed</c> state, the commitment
    /// duration is waived, and you can cancel it as soon as it enters the <c>active</c> state.
    /// </para>
    ///  
    /// <para>
    /// Instances running in the reserved capacity continue running until you stop them. Stopped
    /// instances that target the Capacity Reservation can no longer launch. Modify these
    /// instances to either target a different Capacity Reservation, launch On-Demand Instance
    /// capacity, or run in any open Capacity Reservation that has matching attributes and
    /// sufficient capacity.
    /// </para>
    /// </summary>
    public partial class CancelCapacityReservationRequest : AmazonEC2Request
    {
        private string _capacityReservationId;
        private bool? _dryRun;

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation to be cancelled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CapacityReservationId
        {
            get { return this._capacityReservationId; }
            set { this._capacityReservationId = value; }
        }

        // Check to see if CapacityReservationId property is set
        internal bool IsSetCapacityReservationId()
        {
            return this._capacityReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

    }
}