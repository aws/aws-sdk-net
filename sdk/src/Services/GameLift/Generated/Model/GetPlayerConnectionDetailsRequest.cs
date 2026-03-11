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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the GetPlayerConnectionDetails operation.
    /// <b>This API works with the following fleet types:</b> EC2 (server SDK 5.x or later),
    /// Container
    /// 
    ///  
    /// <para>
    /// Retrieves connection details for game clients to connect to game sessions. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Player gateway benefits:</b> DDoS protection with negligible impact to latency.
    /// 
    /// </para>
    ///  
    /// <para>
    /// To enable player gateway on your fleet, set <c>PlayerGatewayMode</c> to <c>ENABLED</c>
    /// or <c>REQUIRED</c> when calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateFleet.html">CreateFleet</a>
    /// or <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateContainerFleet.html">CreateContainerFleet</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>How to use:</b> After creating a game session and adding players, call this operation
    /// with the game session ID and player IDs. When player gateway is enabled, the response
    /// includes connection endpoints and player gateway tokens that your game clients can
    /// use to connect to the game session through player gateway. To learn more about player
    /// gateway integration, see <a href="https://docs.aws.amazon.com/gameliftservers/latest/developerguide/ddos-protection-intro.html">DDoS
    /// protection with Amazon GameLift Servers player gateway</a>.
    /// </para>
    ///  
    /// <para>
    /// When player gateway is disabled or in locations where player gateway is not supported,
    /// this operation returns game server connection information without player gateway tokens,
    /// so that your game clients directly connect to the game server endpoint.
    /// </para>
    /// </summary>
    public partial class GetPlayerConnectionDetailsRequest : AmazonGameLiftRequest
    {
        private string _gameSessionId;
        private List<string> _playerIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// A unique identifier for the game session for which to retrieve player connection details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string GameSessionId
        {
            get { return this._gameSessionId; }
            set { this._gameSessionId = value; }
        }

        // Check to see if GameSessionId property is set
        internal bool IsSetGameSessionId()
        {
            return this._gameSessionId != null;
        }

        /// <summary>
        /// Gets and sets the property PlayerIds. 
        /// <para>
        /// List of unique identifiers for players. Connection details are returned for each player
        /// in this list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=25)]
        public List<string> PlayerIds
        {
            get { return this._playerIds; }
            set { this._playerIds = value; }
        }

        // Check to see if PlayerIds property is set
        internal bool IsSetPlayerIds()
        {
            return this._playerIds != null && (this._playerIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}