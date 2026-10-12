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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// A summary of a standby Autonomous Database in an Oracle Data Guard configuration.
    /// </summary>
    public partial class DatabaseStandbySummary
    {
        /// <summary>
        /// Gets and sets the property AvailabilityDomain. 
        /// <para>
        /// The availability domain of the standby Autonomous Database.
        /// </para>
        /// </summary>
        public string AvailabilityDomain { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityDomain property is set.
        /// </summary>
        internal bool IsSetAvailabilityDomain() => this.AvailabilityDomain != null;

        /// <summary>
        /// Gets and sets the property LagTimeInSeconds. 
        /// <para>
        /// The time lag, in seconds, between the standby database and the primary database.
        /// </para>
        /// </summary>
        public int? LagTimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the LagTimeInSeconds property is set.
        /// </summary>
        internal bool IsSetLagTimeInSeconds() => this.LagTimeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property MaintenanceTargetComponent. 
        /// <para>
        /// The component on the standby Autonomous Database that the current maintenance is being
        /// applied to.
        /// </para>
        /// </summary>
        public string MaintenanceTargetComponent { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceTargetComponent property is set.
        /// </summary>
        internal bool IsSetMaintenanceTargetComponent() => this.MaintenanceTargetComponent != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the standby Autonomous Database.
        /// </para>
        /// </summary>
        public AutonomousDatabaseResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the current status of the standby Autonomous Database,
        /// if applicable.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property TimeDataGuardRoleChanged. 
        /// <para>
        /// The date and time when the Oracle Data Guard role of the standby database last changed.
        /// </para>
        /// </summary>
        public DateTime? TimeDataGuardRoleChanged { get; set; }

        /// <summary>
        /// Checks to see if the TimeDataGuardRoleChanged property is set.
        /// </summary>
        internal bool IsSetTimeDataGuardRoleChanged() => this.TimeDataGuardRoleChanged.HasValue;

        /// <summary>
        /// Gets and sets the property TimeDisasterRecoveryRoleChanged. 
        /// <para>
        /// The date and time when the disaster recovery role of the standby database last changed.
        /// </para>
        /// </summary>
        public DateTime? TimeDisasterRecoveryRoleChanged { get; set; }

        /// <summary>
        /// Checks to see if the TimeDisasterRecoveryRoleChanged property is set.
        /// </summary>
        internal bool IsSetTimeDisasterRecoveryRoleChanged() => this.TimeDisasterRecoveryRoleChanged.HasValue;

        /// <summary>
        /// Gets and sets the property TimeMaintenanceBegin. 
        /// <para>
        /// The date and time when the next maintenance of the standby database begins.
        /// </para>
        /// </summary>
        public DateTime? TimeMaintenanceBegin { get; set; }

        /// <summary>
        /// Checks to see if the TimeMaintenanceBegin property is set.
        /// </summary>
        internal bool IsSetTimeMaintenanceBegin() => this.TimeMaintenanceBegin.HasValue;

        /// <summary>
        /// Gets and sets the property TimeMaintenanceEnd. 
        /// <para>
        /// The date and time when the next maintenance of the standby database ends.
        /// </para>
        /// </summary>
        public DateTime? TimeMaintenanceEnd { get; set; }

        /// <summary>
        /// Checks to see if the TimeMaintenanceEnd property is set.
        /// </summary>
        internal bool IsSetTimeMaintenanceEnd() => this.TimeMaintenanceEnd.HasValue;
    }
}
