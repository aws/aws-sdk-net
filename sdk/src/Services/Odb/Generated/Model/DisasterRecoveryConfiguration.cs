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
    /// The disaster recovery configuration for an Autonomous Database.
    /// </summary>
    public partial class DisasterRecoveryConfiguration
    {
        private DisasterRecoveryType _disasterRecoveryType;
        private bool? _isReplicateAutomaticBackups;
        private bool? _isSnapshotStandby;
        private DateTime? _timeSnapshotStandbyEnabledTill;

        /// <summary>
        /// Gets and sets the property DisasterRecoveryType. 
        /// <para>
        /// The type of disaster recovery configured for the Autonomous Database.
        /// </para>
        /// </summary>
        public DisasterRecoveryType DisasterRecoveryType
        {
            get { return this._disasterRecoveryType; }
            set { this._disasterRecoveryType = value; }
        }

        // Check to see if DisasterRecoveryType property is set
        internal bool IsSetDisasterRecoveryType()
        {
            return this._disasterRecoveryType != null;
        }

        /// <summary>
        /// Gets and sets the property IsReplicateAutomaticBackups. 
        /// <para>
        /// Indicates whether automatic backups are replicated to the disaster recovery database.
        /// </para>
        /// </summary>
        public bool? IsReplicateAutomaticBackups
        {
            get { return this._isReplicateAutomaticBackups; }
            set { this._isReplicateAutomaticBackups = value; }
        }

        // Check to see if IsReplicateAutomaticBackups property is set
        internal bool IsSetIsReplicateAutomaticBackups()
        {
            return this._isReplicateAutomaticBackups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsSnapshotStandby. 
        /// <para>
        /// Indicates whether the standby database is a snapshot standby.
        /// </para>
        /// </summary>
        public bool? IsSnapshotStandby
        {
            get { return this._isSnapshotStandby; }
            set { this._isSnapshotStandby = value; }
        }

        // Check to see if IsSnapshotStandby property is set
        internal bool IsSetIsSnapshotStandby()
        {
            return this._isSnapshotStandby.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeSnapshotStandbyEnabledTill. 
        /// <para>
        /// The date and time until which the snapshot standby database remains enabled.
        /// </para>
        /// </summary>
        public DateTime? TimeSnapshotStandbyEnabledTill
        {
            get { return this._timeSnapshotStandbyEnabledTill; }
            set { this._timeSnapshotStandbyEnabledTill = value; }
        }

        // Check to see if TimeSnapshotStandbyEnabledTill property is set
        internal bool IsSetTimeSnapshotStandbyEnabledTill()
        {
            return this._timeSnapshotStandbyEnabledTill.HasValue; 
        }

    }
}