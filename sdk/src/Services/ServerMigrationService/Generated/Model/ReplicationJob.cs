/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Object representing a Replication Job
    /// </summary>
    public partial class ReplicationJob
    {
        private string _description;
        private int? _frequency;
        private string _latestAmiId;
        private LicenseType _licenseType;
        private DateTime? _nextReplicationRunStartTime;
        private string _replicationJobId;
        private List<ReplicationRun> _replicationRunList = new List<ReplicationRun>();
        private string _roleName;
        private DateTime? _seedReplicationTime;
        private string _serverId;
        private ServerType _serverType;
        private ReplicationJobState _state;
        private string _statusMessage;
        private VmServer _vmServer;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Frequency.
        /// </summary>
        public int Frequency
        {
            get { return this._frequency.GetValueOrDefault(); }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestAmiId.
        /// </summary>
        public string LatestAmiId
        {
            get { return this._latestAmiId; }
            set { this._latestAmiId = value; }
        }

        // Check to see if LatestAmiId property is set
        internal bool IsSetLatestAmiId()
        {
            return this._latestAmiId != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseType.
        /// </summary>
        public LicenseType LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }

        // Check to see if LicenseType property is set
        internal bool IsSetLicenseType()
        {
            return this._licenseType != null;
        }

        /// <summary>
        /// Gets and sets the property NextReplicationRunStartTime.
        /// </summary>
        public DateTime NextReplicationRunStartTime
        {
            get { return this._nextReplicationRunStartTime.GetValueOrDefault(); }
            set { this._nextReplicationRunStartTime = value; }
        }

        // Check to see if NextReplicationRunStartTime property is set
        internal bool IsSetNextReplicationRunStartTime()
        {
            return this._nextReplicationRunStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationJobId.
        /// </summary>
        public string ReplicationJobId
        {
            get { return this._replicationJobId; }
            set { this._replicationJobId = value; }
        }

        // Check to see if ReplicationJobId property is set
        internal bool IsSetReplicationJobId()
        {
            return this._replicationJobId != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationRunList.
        /// </summary>
        public List<ReplicationRun> ReplicationRunList
        {
            get { return this._replicationRunList; }
            set { this._replicationRunList = value; }
        }

        // Check to see if ReplicationRunList property is set
        internal bool IsSetReplicationRunList()
        {
            return this._replicationRunList != null && this._replicationRunList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoleName.
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

        /// <summary>
        /// Gets and sets the property SeedReplicationTime.
        /// </summary>
        public DateTime SeedReplicationTime
        {
            get { return this._seedReplicationTime.GetValueOrDefault(); }
            set { this._seedReplicationTime = value; }
        }

        // Check to see if SeedReplicationTime property is set
        internal bool IsSetSeedReplicationTime()
        {
            return this._seedReplicationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerId.
        /// </summary>
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }

        // Check to see if ServerId property is set
        internal bool IsSetServerId()
        {
            return this._serverId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerType.
        /// </summary>
        public ServerType ServerType
        {
            get { return this._serverType; }
            set { this._serverType = value; }
        }

        // Check to see if ServerType property is set
        internal bool IsSetServerType()
        {
            return this._serverType != null;
        }

        /// <summary>
        /// Gets and sets the property State.
        /// </summary>
        public ReplicationJobState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage.
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property VmServer.
        /// </summary>
        public VmServer VmServer
        {
            get { return this._vmServer; }
            set { this._vmServer = value; }
        }

        // Check to see if VmServer property is set
        internal bool IsSetVmServer()
        {
            return this._vmServer != null;
        }

    }
}