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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the PutAppReplicationConfiguration operation.
    /// Creates or updates the replication configuration for the specified application.
    /// </summary>
    public partial class PutAppReplicationConfigurationRequest : AmazonServerMigrationServiceRequest
    {
        private string _appId;
        private List<ServerGroupReplicationConfiguration> _serverGroupReplicationConfigurations = new List<ServerGroupReplicationConfiguration>();

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerGroupReplicationConfigurations. 
        /// <para>
        /// Information about the replication configurations for server groups in the application.
        /// </para>
        /// </summary>
        public List<ServerGroupReplicationConfiguration> ServerGroupReplicationConfigurations
        {
            get { return this._serverGroupReplicationConfigurations; }
            set { this._serverGroupReplicationConfigurations = value; }
        }

        // Check to see if ServerGroupReplicationConfigurations property is set
        internal bool IsSetServerGroupReplicationConfigurations()
        {
            return this._serverGroupReplicationConfigurations != null && this._serverGroupReplicationConfigurations.Count > 0; 
        }

    }
}