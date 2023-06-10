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
    /// Details for Site-to-Site VPN tunnel endpoint maintenance events.
    /// </summary>
    public partial class MaintenanceDetails
    {
        private DateTime? _lastMaintenanceApplied;
        private DateTime? _maintenanceAutoAppliedAfter;
        private string _pendingMaintenance;

        /// <summary>
        /// Gets and sets the property LastMaintenanceApplied. 
        /// <para>
        /// Timestamp of last applied maintenance.
        /// </para>
        /// </summary>
        public DateTime LastMaintenanceApplied
        {
            get { return this._lastMaintenanceApplied.GetValueOrDefault(); }
            set { this._lastMaintenanceApplied = value; }
        }

        // Check to see if LastMaintenanceApplied property is set
        internal bool IsSetLastMaintenanceApplied()
        {
            return this._lastMaintenanceApplied.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaintenanceAutoAppliedAfter. 
        /// <para>
        /// The timestamp after which Amazon Web Services will automatically apply maintenance.
        /// </para>
        /// </summary>
        public DateTime MaintenanceAutoAppliedAfter
        {
            get { return this._maintenanceAutoAppliedAfter.GetValueOrDefault(); }
            set { this._maintenanceAutoAppliedAfter = value; }
        }

        // Check to see if MaintenanceAutoAppliedAfter property is set
        internal bool IsSetMaintenanceAutoAppliedAfter()
        {
            return this._maintenanceAutoAppliedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingMaintenance. 
        /// <para>
        /// Verify existence of a pending maintenance.
        /// </para>
        /// </summary>
        public string PendingMaintenance
        {
            get { return this._pendingMaintenance; }
            set { this._pendingMaintenance = value; }
        }

        // Check to see if PendingMaintenance property is set
        internal bool IsSetPendingMaintenance()
        {
            return this._pendingMaintenance != null;
        }

    }
}