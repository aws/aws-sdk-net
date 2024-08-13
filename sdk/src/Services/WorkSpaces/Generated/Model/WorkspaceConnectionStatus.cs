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
    /// Describes the connection status of a WorkSpace.
    /// </summary>
    public partial class WorkspaceConnectionStatus
    {
        private ConnectionState _connectionState;
        private DateTime? _connectionStateCheckTimestamp;
        private DateTime? _lastKnownUserConnectionTimestamp;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property ConnectionState. 
        /// <para>
        /// The connection state of the WorkSpace. The connection state is unknown if the WorkSpace
        /// is stopped.
        /// </para>
        /// </summary>
        public ConnectionState ConnectionState
        {
            get { return this._connectionState; }
            set { this._connectionState = value; }
        }

        // Check to see if ConnectionState property is set
        internal bool IsSetConnectionState()
        {
            return this._connectionState != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionStateCheckTimestamp. 
        /// <para>
        /// The timestamp of the connection status check.
        /// </para>
        /// </summary>
        public DateTime? ConnectionStateCheckTimestamp
        {
            get { return this._connectionStateCheckTimestamp; }
            set { this._connectionStateCheckTimestamp = value; }
        }

        // Check to see if ConnectionStateCheckTimestamp property is set
        internal bool IsSetConnectionStateCheckTimestamp()
        {
            return this._connectionStateCheckTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastKnownUserConnectionTimestamp. 
        /// <para>
        /// The timestamp of the last known user connection.
        /// </para>
        /// </summary>
        public DateTime? LastKnownUserConnectionTimestamp
        {
            get { return this._lastKnownUserConnectionTimestamp; }
            set { this._lastKnownUserConnectionTimestamp = value; }
        }

        // Check to see if LastKnownUserConnectionTimestamp property is set
        internal bool IsSetLastKnownUserConnectionTimestamp()
        {
            return this._lastKnownUserConnectionTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The identifier of the WorkSpace.
        /// </para>
        /// </summary>
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}