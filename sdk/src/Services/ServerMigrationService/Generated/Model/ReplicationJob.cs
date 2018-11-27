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
    /// Represents a replication job.
    /// </summary>
    public partial class ReplicationJob
    {
        private string _description;
        private bool? _encrypted;
        private int? _frequency;
        private string _kmsKeyId;
        private string _latestAmiId;
        private LicenseType _licenseType;
        private DateTime? _nextReplicationRunStartTime;
        private int? _numberOfRecentAmisToKeep;
        private string _replicationJobId;
        private List<ReplicationRun> _replicationRunList = new List<ReplicationRun>();
        private string _roleName;
        private bool? _runOnce;
        private DateTime? _seedReplicationTime;
        private string _serverId;
        private ServerType _serverType;
        private ReplicationJobState _state;
        private string _statusMessage;
        private VmServer _vmServer;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the replication job.
        /// </para>
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
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Whether the replication job should produce encrypted AMIs or not. See also <code>KmsKeyId</code>
        /// below.
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// The time between consecutive replication runs, in hours.
        /// </para>
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// KMS key ID for replication jobs that produce encrypted AMIs. Can be any of the following:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS key ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// KMS key alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN referring to KMS key ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN referring to KMS key alias
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If encrypted is <i>true</i> but a KMS key id is not specified, the customer's default
        /// KMS key for EBS is used. 
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LatestAmiId. 
        /// <para>
        /// The ID of the latest Amazon Machine Image (AMI).
        /// </para>
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
        /// <para>
        /// The license type to be used for the AMI created by a successful replication run.
        /// </para>
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
        /// <para>
        /// The start time of the next replication run.
        /// </para>
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
        /// Gets and sets the property NumberOfRecentAmisToKeep. 
        /// <para>
        /// Number of recent AMIs to keep in the customer's account for a replication job. By
        /// default the value is set to zero, meaning that all AMIs are kept.
        /// </para>
        /// </summary>
        public int NumberOfRecentAmisToKeep
        {
            get { return this._numberOfRecentAmisToKeep.GetValueOrDefault(); }
            set { this._numberOfRecentAmisToKeep = value; }
        }

        // Check to see if NumberOfRecentAmisToKeep property is set
        internal bool IsSetNumberOfRecentAmisToKeep()
        {
            return this._numberOfRecentAmisToKeep.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationJobId. 
        /// <para>
        /// The identifier of the replication job.
        /// </para>
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
        /// <para>
        /// Information about the replication runs.
        /// </para>
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
        /// <para>
        /// The name of the IAM role to be used by the Server Migration Service.
        /// </para>
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
        /// Gets and sets the property RunOnce.
        /// </summary>
        public bool RunOnce
        {
            get { return this._runOnce.GetValueOrDefault(); }
            set { this._runOnce = value; }
        }

        // Check to see if RunOnce property is set
        internal bool IsSetRunOnce()
        {
            return this._runOnce.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SeedReplicationTime. 
        /// <para>
        /// The seed replication time.
        /// </para>
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
        /// <para>
        /// The identifier of the server.
        /// </para>
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
        /// <para>
        /// The type of server.
        /// </para>
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
        /// <para>
        /// The state of the replication job.
        /// </para>
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
        /// <para>
        /// The description of the current status of the replication job.
        /// </para>
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
        /// <para>
        /// Information about the VM server.
        /// </para>
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