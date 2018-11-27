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
    /// Replication configuration of a server.
    /// </summary>
    public partial class ServerReplicationConfiguration
    {
        private Server _server;
        private ServerReplicationParameters _serverReplicationParameters;

        /// <summary>
        /// Gets and sets the property Server. 
        /// <para>
        /// Identifier of the server this replication configuration is associated with.
        /// </para>
        /// </summary>
        public Server Server
        {
            get { return this._server; }
            set { this._server = value; }
        }

        // Check to see if Server property is set
        internal bool IsSetServer()
        {
            return this._server != null;
        }

        /// <summary>
        /// Gets and sets the property ServerReplicationParameters. 
        /// <para>
        /// Parameters for replicating the server.
        /// </para>
        /// </summary>
        public ServerReplicationParameters ServerReplicationParameters
        {
            get { return this._serverReplicationParameters; }
            set { this._serverReplicationParameters = value; }
        }

        // Check to see if ServerReplicationParameters property is set
        internal bool IsSetServerReplicationParameters()
        {
            return this._serverReplicationParameters != null;
        }

    }
}