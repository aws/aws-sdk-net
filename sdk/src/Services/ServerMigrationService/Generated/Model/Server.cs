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
    /// Represents a server.
    /// </summary>
    public partial class Server
    {
        private string _replicationJobId;
        private bool? _replicationJobTerminated;
        private string _serverId;
        private ServerType _serverType;
        private VmServer _vmServer;

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
        /// Gets and sets the property ReplicationJobTerminated. 
        /// <para>
        /// Indicates whether the replication job is deleted or failed.
        /// </para>
        /// </summary>
        public bool ReplicationJobTerminated
        {
            get { return this._replicationJobTerminated.GetValueOrDefault(); }
            set { this._replicationJobTerminated = value; }
        }

        // Check to see if ReplicationJobTerminated property is set
        internal bool IsSetReplicationJobTerminated()
        {
            return this._replicationJobTerminated.HasValue; 
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