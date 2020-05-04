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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterGameServer operation.
    /// <b>This action is part of Amazon GameLift FleetIQ with game server groups, which
    /// is in preview release and is subject to change.</b> 
    /// 
    ///  
    /// <para>
    /// Creates a new game server resource and notifies GameLift FleetIQ that the game server
    /// is ready to host gameplay and players. This action is called by a game server process
    /// that is running on an instance in a game server group. Registering game servers enables
    /// GameLift FleetIQ to track available game servers and enables game clients and services
    /// to claim a game server for a new game session. 
    /// </para>
    ///  
    /// <para>
    /// To register a game server, identify the game server group and instance where the game
    /// server is running, and provide a unique identifier for the game server. You can also
    /// include connection and game server data; when a game client or service requests a
    /// game server by calling <a>ClaimGameServer</a>, this information is returned in response.
    /// </para>
    ///  
    /// <para>
    /// Once a game server is successfully registered, it is put in status AVAILABLE. A request
    /// to register a game server may fail if the instance it is in the process of shutting
    /// down as part of instance rebalancing or scale-down activity. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gsg-intro.html">GameLift
    /// FleetIQ Guide</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>RegisterGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListGameServers</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ClaimGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateGameServer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeregisterGameServer</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RegisterGameServerRequest : AmazonGameLiftRequest
    {
        private string _connectionInfo;
        private string _customSortKey;
        private string _gameServerData;
        private string _gameServerGroupName;
        private string _gameServerId;
        private string _instanceId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ConnectionInfo. 
        /// <para>
        /// Information needed to make inbound client connections to the game server. This might
        /// include IP address and port, DNS name, etc.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ConnectionInfo
        {
            get { return this._connectionInfo; }
            set { this._connectionInfo = value; }
        }

        // Check to see if ConnectionInfo property is set
        internal bool IsSetConnectionInfo()
        {
            return this._connectionInfo != null;
        }

        /// <summary>
        /// Gets and sets the property CustomSortKey. 
        /// <para>
        /// A game server tag that can be used to request sorted lists of game servers using <a>ListGameServers</a>.
        /// Custom sort keys are developer-defined based on how you want to organize the retrieved
        /// game server information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CustomSortKey
        {
            get { return this._customSortKey; }
            set { this._customSortKey = value; }
        }

        // Check to see if CustomSortKey property is set
        internal bool IsSetCustomSortKey()
        {
            return this._customSortKey != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerData. 
        /// <para>
        /// A set of custom game server properties, formatted as a single string value. This data
        /// is passed to a game client or service when it requests information on a game servers
        /// using <a>ListGameServers</a> or <a>ClaimGameServer</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string GameServerData
        {
            get { return this._gameServerData; }
            set { this._gameServerData = value; }
        }

        // Check to see if GameServerData property is set
        internal bool IsSetGameServerData()
        {
            return this._gameServerData != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerGroupName. 
        /// <para>
        /// An identifier for the game server group where the game server is running. You can
        /// use either the <a>GameServerGroup</a> name or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string GameServerGroupName
        {
            get { return this._gameServerGroupName; }
            set { this._gameServerGroupName = value; }
        }

        // Check to see if GameServerGroupName property is set
        internal bool IsSetGameServerGroupName()
        {
            return this._gameServerGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerId. 
        /// <para>
        /// A custom string that uniquely identifies the new game server. Game server IDs are
        /// developer-defined and must be unique across all game server groups in your AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=128)]
        public string GameServerId
        {
            get { return this._gameServerId; }
            set { this._gameServerId = value; }
        }

        // Check to see if GameServerId property is set
        internal bool IsSetGameServerId()
        {
            return this._gameServerId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier for the instance where the game server is running. This ID is
        /// available in the instance metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the new game server resource. Tags are developer-defined
        /// key-value pairs. Tagging AWS resources are useful for resource management, access
        /// management, and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging AWS Resources</a> in the <i>AWS General Reference</i>. Once the resource is
        /// created, you can use <a>TagResource</a>, <a>UntagResource</a>, and <a>ListTagsForResource</a>
        /// to add, remove, and view tags. The maximum tag limit may be lower than stated. See
        /// the AWS General Reference for actual tagging limits.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}