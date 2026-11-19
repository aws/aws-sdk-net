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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Details for Site-to-Site VPN tunnel endpoint maintenance events.
    /// </summary>
    public partial class MaintenanceDetails
    {
        /// <summary>
        /// Gets and sets the property LastMaintenanceApplied. 
        /// <para>
        /// Timestamp of last applied maintenance.
        /// </para>
        /// </summary>
        public DateTime? LastMaintenanceApplied { get; set; }

        /// <summary>
        /// Checks to see if the LastMaintenanceApplied property is set.
        /// </summary>
        internal bool IsSetLastMaintenanceApplied() => this.LastMaintenanceApplied.HasValue;

        /// <summary>
        /// Gets and sets the property MaintenanceAutoAppliedAfter. 
        /// <para>
        /// The timestamp after which Amazon Web Services will automatically apply maintenance.
        /// </para>
        /// </summary>
        public DateTime? MaintenanceAutoAppliedAfter { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceAutoAppliedAfter property is set.
        /// </summary>
        internal bool IsSetMaintenanceAutoAppliedAfter() => this.MaintenanceAutoAppliedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property PendingMaintenance. 
        /// <para>
        /// Verify existence of a pending maintenance.
        /// </para>
        /// </summary>
        public string PendingMaintenance { get; set; }

        /// <summary>
        /// Checks to see if the PendingMaintenance property is set.
        /// </summary>
        internal bool IsSetPendingMaintenance() => this.PendingMaintenance != null;
    }
}
