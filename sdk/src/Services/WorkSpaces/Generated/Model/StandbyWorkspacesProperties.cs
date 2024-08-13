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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the properties of the related standby WorkSpaces.
    /// </summary>
    public partial class StandbyWorkspacesProperties
    {
        private DataReplication _dataReplication;
        private DateTime? _recoverySnapshotTime;
        private string _standbyWorkspaceId;

        /// <summary>
        /// Gets and sets the property DataReplication. 
        /// <para>
        /// Indicates whether data replication is enabled, and if enabled, the type of data replication.
        /// </para>
        /// </summary>
        public DataReplication DataReplication
        {
            get { return this._dataReplication; }
            set { this._dataReplication = value; }
        }

        // Check to see if DataReplication property is set
        internal bool IsSetDataReplication()
        {
            return this._dataReplication != null;
        }

        /// <summary>
        /// Gets and sets the property RecoverySnapshotTime. 
        /// <para>
        /// The date and time at which the last successful snapshot was taken of the primary WorkSpace
        /// used for replicating data.
        /// </para>
        /// </summary>
        public DateTime? RecoverySnapshotTime
        {
            get { return this._recoverySnapshotTime; }
            set { this._recoverySnapshotTime = value; }
        }

        // Check to see if RecoverySnapshotTime property is set
        internal bool IsSetRecoverySnapshotTime()
        {
            return this._recoverySnapshotTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StandbyWorkspaceId. 
        /// <para>
        /// The identifier of the standby WorkSpace
        /// </para>
        /// </summary>
        public string StandbyWorkspaceId
        {
            get { return this._standbyWorkspaceId; }
            set { this._standbyWorkspaceId = value; }
        }

        // Check to see if StandbyWorkspaceId property is set
        internal bool IsSetStandbyWorkspaceId()
        {
            return this._standbyWorkspaceId != null;
        }

    }
}