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
    /// The configuration details for the source used to create an Autonomous Database. This
    /// is a union, so only one of the following members can be specified.
    /// </summary>
    public partial class SourceConfiguration
    {
        /// <summary>
        /// Gets and sets the property CloneToRefreshable. 
        /// <para>
        /// The configuration for creating the Autonomous Database as a refreshable clone.
        /// </para>
        /// </summary>
        public CloneToRefreshableConfiguration CloneToRefreshable { get; set; }

        /// <summary>
        /// Checks to see if the CloneToRefreshable property is set.
        /// </summary>
        internal bool IsSetCloneToRefreshable() => this.CloneToRefreshable != null;

        /// <summary>
        /// Gets and sets the property CrossRegionDataGuard. 
        /// <para>
        /// The configuration for creating the Autonomous Database as a cross-Region Oracle Data
        /// Guard peer.
        /// </para>
        /// </summary>
        public CrossRegionDataGuardConfiguration CrossRegionDataGuard { get; set; }

        /// <summary>
        /// Checks to see if the CrossRegionDataGuard property is set.
        /// </summary>
        internal bool IsSetCrossRegionDataGuard() => this.CrossRegionDataGuard != null;

        /// <summary>
        /// Gets and sets the property CrossRegionDisasterRecovery. 
        /// <para>
        /// The configuration for creating the Autonomous Database as a cross-Region disaster
        /// recovery peer.
        /// </para>
        /// </summary>
        public CrossRegionDisasterRecoveryConfiguration CrossRegionDisasterRecovery { get; set; }

        /// <summary>
        /// Checks to see if the CrossRegionDisasterRecovery property is set.
        /// </summary>
        internal bool IsSetCrossRegionDisasterRecovery() => this.CrossRegionDisasterRecovery != null;

        /// <summary>
        /// Gets and sets the property DatabaseClone. 
        /// <para>
        /// The configuration for creating the Autonomous Database as a clone of an existing database.
        /// </para>
        /// </summary>
        public DatabaseCloneConfiguration DatabaseClone { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseClone property is set.
        /// </summary>
        internal bool IsSetDatabaseClone() => this.DatabaseClone != null;

        /// <summary>
        /// Gets and sets the property PointInTimeRestore. 
        /// <para>
        /// The configuration for creating the Autonomous Database by restoring to a point in
        /// time.
        /// </para>
        /// </summary>
        public PointInTimeRestoreConfiguration PointInTimeRestore { get; set; }

        /// <summary>
        /// Checks to see if the PointInTimeRestore property is set.
        /// </summary>
        internal bool IsSetPointInTimeRestore() => this.PointInTimeRestore != null;

        /// <summary>
        /// Gets and sets the property RestoreFromBackup. 
        /// <para>
        /// The configuration for creating the Autonomous Database by restoring from a backup.
        /// </para>
        /// </summary>
        public RestoreFromBackupConfiguration RestoreFromBackup { get; set; }

        /// <summary>
        /// Checks to see if the RestoreFromBackup property is set.
        /// </summary>
        internal bool IsSetRestoreFromBackup() => this.RestoreFromBackup != null;
    }
}
