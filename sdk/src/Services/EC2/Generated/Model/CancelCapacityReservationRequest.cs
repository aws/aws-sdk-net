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
    /// Container for the parameters to the CancelCapacityReservation operation.
    /// Cancels the specified Capacity Reservation, releases the reserved capacity, and changes
    /// the Capacity Reservation's state to <code>cancelled</code>.
    /// 
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

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation to be cancelled.
        /// </para>
        /// </summary>
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

    }
}