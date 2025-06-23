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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
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
namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Identifies a specific capacity reservation.
    /// </summary>
    public partial class CapacityReservationTarget
    {
        private string _capacityReservationId;
        private string _capacityReservationResourceGroupArn;

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// Unique identifier for the capacity reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
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
        /// Gets and sets the property CapacityReservationResourceGroupArn. 
        /// <para>
        /// ARN of the capacity reservation resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string CapacityReservationResourceGroupArn
        {
            get { return this._capacityReservationResourceGroupArn; }
            set { this._capacityReservationResourceGroupArn = value; }
        }

        // Check to see if CapacityReservationResourceGroupArn property is set
        internal bool IsSetCapacityReservationResourceGroupArn()
        {
            return this._capacityReservationResourceGroupArn != null;
        }

    }
}