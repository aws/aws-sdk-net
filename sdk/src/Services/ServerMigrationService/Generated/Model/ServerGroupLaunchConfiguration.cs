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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Launch configuration for a server group.
    /// </summary>
    public partial class ServerGroupLaunchConfiguration
    {
        private int? _launchOrder;
        private string _serverGroupId;
        private List<ServerLaunchConfiguration> _serverLaunchConfigurations = AWSConfigs.InitializeCollections ? new List<ServerLaunchConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property LaunchOrder. 
        /// <para>
        /// The launch order of servers in the server group.
        /// </para>
        /// </summary>
        public int? LaunchOrder
        {
            get { return this._launchOrder; }
            set { this._launchOrder = value; }
        }

        // Check to see if LaunchOrder property is set
        internal bool IsSetLaunchOrder()
        {
            return this._launchOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerGroupId. 
        /// <para>
        /// The ID of the server group with which the launch configuration is associated.
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
        /// Gets and sets the property ServerLaunchConfigurations. 
        /// <para>
        /// The launch configuration for servers in the server group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServerLaunchConfiguration> ServerLaunchConfigurations
        {
            get { return this._serverLaunchConfigurations; }
            set { this._serverLaunchConfigurations = value; }
        }

        // Check to see if ServerLaunchConfigurations property is set
        internal bool IsSetServerLaunchConfigurations()
        {
            return this._serverLaunchConfigurations != null && (this._serverLaunchConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}