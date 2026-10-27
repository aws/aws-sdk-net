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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Specifies capacity reservation preferences.
    /// </summary>
    public partial class CapacityReservationSpecification
    {
        /// <summary>
        /// Gets and sets the property CapacityReservationPreference. 
        /// <para>
        /// Preference for using capacity reservation.
        /// </para>
        /// </summary>
        public CapacityReservationPreferenceEnum CapacityReservationPreference { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationPreference property is set.
        /// </summary>
        internal bool IsSetCapacityReservationPreference() => this.CapacityReservationPreference != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationTarget. 
        /// <para>
        /// Specific capacity reservation target.
        /// </para>
        /// </summary>
        public CapacityReservationTarget CapacityReservationTarget { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationTarget property is set.
        /// </summary>
        internal bool IsSetCapacityReservationTarget() => this.CapacityReservationTarget != null;
    }
}
