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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// The target for the Capacity Reservation. Specify Capacity Reservations IDs or Capacity
    /// Reservation resource group ARNs.
    /// </summary>
    public partial class CapacityReservationTarget
    {
        private List<string> _capacityReservationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _capacityReservationResourceGroupArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CapacityReservationIds. 
        /// <para>
        ///  The Capacity Reservation IDs to launch instances into. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CapacityReservationIds
        {
            get { return this._capacityReservationIds; }
            set { this._capacityReservationIds = value; }
        }

        // Check to see if CapacityReservationIds property is set
        internal bool IsSetCapacityReservationIds()
        {
            return this._capacityReservationIds != null && (this._capacityReservationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationResourceGroupArns. 
        /// <para>
        ///  The resource group ARNs of the Capacity Reservation to launch instances into. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CapacityReservationResourceGroupArns
        {
            get { return this._capacityReservationResourceGroupArns; }
            set { this._capacityReservationResourceGroupArns = value; }
        }

        // Check to see if CapacityReservationResourceGroupArns property is set
        internal bool IsSetCapacityReservationResourceGroupArns()
        {
            return this._capacityReservationResourceGroupArns != null && (this._capacityReservationResourceGroupArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}