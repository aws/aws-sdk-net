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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
        private string _availabilityDomain;
        private int? _lagTimeInSeconds;
        private string _maintenanceTargetComponent;
        private AutonomousDatabaseResourceStatus _status;
        private string _statusReason;
        private DateTime? _timeDataGuardRoleChanged;
        private DateTime? _timeDisasterRecoveryRoleChanged;
        private DateTime? _timeMaintenanceBegin;
        private DateTime? _timeMaintenanceEnd;

        /// <summary>
        /// Gets and sets the property AvailabilityDomain. 
        /// <para>
        /// The availability domain of the standby Autonomous Database.
        /// </para>
        /// </summary>
        public string AvailabilityDomain
        {
            get { return this._availabilityDomain; }
            set { this._availabilityDomain = value; }
        }

        // Check to see if AvailabilityDomain property is set
        internal bool IsSetAvailabilityDomain()
        {
            return this._availabilityDomain != null;
        }

        /// <summary>
        /// Gets and sets the property LagTimeInSeconds. 
        /// <para>
        /// The time lag, in seconds, between the standby database and the primary database.
        /// </para>
        /// </summary>
        public int? LagTimeInSeconds
        {
            get { return this._lagTimeInSeconds; }
            set { this._lagTimeInSeconds = value; }
        }

        // Check to see if LagTimeInSeconds property is set
        internal bool IsSetLagTimeInSeconds()
        {
            return this._lagTimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaintenanceTargetComponent. 
        /// <para>
        /// The component on the standby Autonomous Database that the current maintenance is being
        /// applied to.
        /// </para>
        /// </summary>
        public string MaintenanceTargetComponent
        {
            get { return this._maintenanceTargetComponent; }
            set { this._maintenanceTargetComponent = value; }
        }

        // Check to see if MaintenanceTargetComponent property is set
        internal bool IsSetMaintenanceTargetComponent()
        {
            return this._maintenanceTargetComponent != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the standby Autonomous Database.
        /// </para>
        /// </summary>
        public AutonomousDatabaseResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the current status of the standby Autonomous Database,
        /// if applicable.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property TimeDataGuardRoleChanged. 
        /// <para>
        /// The date and time when the Oracle Data Guard role of the standby database last changed.
        /// </para>
        /// </summary>
        public DateTime? TimeDataGuardRoleChanged
        {
            get { return this._timeDataGuardRoleChanged; }
            set { this._timeDataGuardRoleChanged = value; }
        }

        // Check to see if TimeDataGuardRoleChanged property is set
        internal bool IsSetTimeDataGuardRoleChanged()
        {
            return this._timeDataGuardRoleChanged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeDisasterRecoveryRoleChanged. 
        /// <para>
        /// The date and time when the disaster recovery role of the standby database last changed.
        /// </para>
        /// </summary>
        public DateTime? TimeDisasterRecoveryRoleChanged
        {
            get { return this._timeDisasterRecoveryRoleChanged; }
            set { this._timeDisasterRecoveryRoleChanged = value; }
        }

        // Check to see if TimeDisasterRecoveryRoleChanged property is set
        internal bool IsSetTimeDisasterRecoveryRoleChanged()
        {
            return this._timeDisasterRecoveryRoleChanged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeMaintenanceBegin. 
        /// <para>
        /// The date and time when the next maintenance of the standby database begins.
        /// </para>
        /// </summary>
        public DateTime? TimeMaintenanceBegin
        {
            get { return this._timeMaintenanceBegin; }
            set { this._timeMaintenanceBegin = value; }
        }

        // Check to see if TimeMaintenanceBegin property is set
        internal bool IsSetTimeMaintenanceBegin()
        {
            return this._timeMaintenanceBegin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeMaintenanceEnd. 
        /// <para>
        /// The date and time when the next maintenance of the standby database ends.
        /// </para>
        /// </summary>
        public DateTime? TimeMaintenanceEnd
        {
            get { return this._timeMaintenanceEnd; }
            set { this._timeMaintenanceEnd = value; }
        }

        // Check to see if TimeMaintenanceEnd property is set
        internal bool IsSetTimeMaintenanceEnd()
        {
            return this._timeMaintenanceEnd.HasValue; 
        }

    }
}