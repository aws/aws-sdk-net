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
    /// The configuration details for the source used to create an Autonomous Database. This
    /// is a union, so only one of the following members can be specified.
    /// </summary>
    public partial class SourceConfiguration
    {
        private CloneToRefreshableConfiguration _cloneToRefreshable;
        private CrossRegionDataGuardConfiguration _crossRegionDataGuard;
        private CrossRegionDisasterRecoveryConfiguration _crossRegionDisasterRecovery;
        private DatabaseCloneConfiguration _databaseClone;
        private PointInTimeRestoreConfiguration _pointInTimeRestore;
        private RestoreFromBackupConfiguration _restoreFromBackup;

        /// <summary>
        /// Gets and sets the property CloneToRefreshable. 
        /// <para>
        /// The configuration for creating the Autonomous Database as a refreshable clone.
        /// </para>
        /// </summary>
        public CloneToRefreshableConfiguration CloneToRefreshable
        {
            get { return this._cloneToRefreshable; }
            set { this._cloneToRefreshable = value; }
        }

        // Check to see if CloneToRefreshable property is set
        internal bool IsSetCloneToRefreshable()
        {
            return this._cloneToRefreshable != null;
        }

        /// <summary>
        /// Gets and sets the property CrossRegionDataGuard. 
        /// <para>
        /// The configuration for creating the Autonomous Database as a cross-Region Oracle Data
        /// Guard peer.
        /// </para>
        /// </summary>
        public CrossRegionDataGuardConfiguration CrossRegionDataGuard
        {
            get { return this._crossRegionDataGuard; }
            set { this._crossRegionDataGuard = value; }
        }

        // Check to see if CrossRegionDataGuard property is set
        internal bool IsSetCrossRegionDataGuard()
        {
            return this._crossRegionDataGuard != null;
        }

        /// <summary>
        /// Gets and sets the property CrossRegionDisasterRecovery. 
        /// <para>
        /// The configuration for creating the Autonomous Database as a cross-Region disaster
        /// recovery peer.
        /// </para>
        /// </summary>
        public CrossRegionDisasterRecoveryConfiguration CrossRegionDisasterRecovery
        {
            get { return this._crossRegionDisasterRecovery; }
            set { this._crossRegionDisasterRecovery = value; }
        }

        // Check to see if CrossRegionDisasterRecovery property is set
        internal bool IsSetCrossRegionDisasterRecovery()
        {
            return this._crossRegionDisasterRecovery != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseClone. 
        /// <para>
        /// The configuration for creating the Autonomous Database as a clone of an existing database.
        /// </para>
        /// </summary>
        public DatabaseCloneConfiguration DatabaseClone
        {
            get { return this._databaseClone; }
            set { this._databaseClone = value; }
        }

        // Check to see if DatabaseClone property is set
        internal bool IsSetDatabaseClone()
        {
            return this._databaseClone != null;
        }

        /// <summary>
        /// Gets and sets the property PointInTimeRestore. 
        /// <para>
        /// The configuration for creating the Autonomous Database by restoring to a point in
        /// time.
        /// </para>
        /// </summary>
        public PointInTimeRestoreConfiguration PointInTimeRestore
        {
            get { return this._pointInTimeRestore; }
            set { this._pointInTimeRestore = value; }
        }

        // Check to see if PointInTimeRestore property is set
        internal bool IsSetPointInTimeRestore()
        {
            return this._pointInTimeRestore != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreFromBackup. 
        /// <para>
        /// The configuration for creating the Autonomous Database by restoring from a backup.
        /// </para>
        /// </summary>
        public RestoreFromBackupConfiguration RestoreFromBackup
        {
            get { return this._restoreFromBackup; }
            set { this._restoreFromBackup = value; }
        }

        // Check to see if RestoreFromBackup property is set
        internal bool IsSetRestoreFromBackup()
        {
            return this._restoreFromBackup != null;
        }

    }
}