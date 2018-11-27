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
    /// Replication configuration for a server group.
    /// </summary>
    public partial class ServerGroupReplicationConfiguration
    {
        private string _serverGroupId;
        private List<ServerReplicationConfiguration> _serverReplicationConfigurations = new List<ServerReplicationConfiguration>();

        /// <summary>
        /// Gets and sets the property ServerGroupId. 
        /// <para>
        /// Identifier of the server group this replication configuration is associated with.
        /// </para>
        /// </summary>
        public string ServerGroupId
        {
            get { return this._serverGroupId; }
            set { this._serverGroupId = value; }
        }

        // Check to see if ServerGroupId property is set
        internal bool IsSetServerGroupId()
        {
            return this._serverGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerReplicationConfigurations. 
        /// <para>
        /// Replication configuration for servers in the server group.
        /// </para>
        /// </summary>
        public List<ServerReplicationConfiguration> ServerReplicationConfigurations
        {
            get { return this._serverReplicationConfigurations; }
            set { this._serverReplicationConfigurations = value; }
        }

        // Check to see if ServerReplicationConfigurations property is set
        internal bool IsSetServerReplicationConfigurations()
        {
            return this._serverReplicationConfigurations != null && this._serverReplicationConfigurations.Count > 0; 
        }

    }
}