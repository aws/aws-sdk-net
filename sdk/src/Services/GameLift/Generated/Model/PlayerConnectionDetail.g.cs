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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Connection information for a game client to connect to a game session. This object
    /// contains the IP address(es), port(s), and authentication details your game client
    /// needs to establish a connection.
    /// 
    ///  
    /// <para>
    ///  <b>With player gateway enabled:</b> Contains relay endpoints and a player gateway
    /// token. Your game client must prepend player gateway token to each payload for validation
    /// and connection through relay endpoints.
    /// </para>
    ///  
    /// <para>
    ///  <b>With player gateway disabled:</b> Contains game server endpoint. Player gateway
    /// token and expiration fields are empty.
    /// </para>
    /// </summary>
    public partial class PlayerConnectionDetail
    {
        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// List of connection endpoints for the game client. Your game client uses these IP address(es)
        /// and port(s) to connect to the game session.
        /// </para>
        ///  
        /// <para>
        /// When player gateway is enabled, these are relay endpoints with benefits such as DDoS
        /// protection. When disabled, this is the game server endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlayerConnectionEndpoint> Endpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<PlayerConnectionEndpoint>() : null;

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null && (this.Endpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// When player gateway is enabled, this is the timestamp indicating when player gateway
        /// token expires. Your game backend should call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GetPlayerConnectionDetails.html">GetPlayerConnectionDetails</a>
        /// to retrieve fresh connection information for your game clients before this time. Format
        /// is a number expressed in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// 
        /// </para>
        ///  
        /// <para>
        /// This value is empty when player gateway is disabled.
        /// </para>
        /// </summary>
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// Checks to see if the Expiration property is set.
        /// </summary>
        internal bool IsSetExpiration() => this.Expiration.HasValue;

        /// <summary>
        /// Gets and sets the property PlayerGatewayToken. 
        /// <para>
        /// Access token that your game client must prepend to all traffic sent through player
        /// gateway. Player gateway verifies identity and authorizes connection based on this
        /// token.
        /// </para>
        ///  
        /// <para>
        /// This value is empty when player gateway is disabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PlayerGatewayToken { get; set; }

        /// <summary>
        /// Checks to see if the PlayerGatewayToken property is set.
        /// </summary>
        internal bool IsSetPlayerGatewayToken() => this.PlayerGatewayToken != null;

        /// <summary>
        /// Gets and sets the property PlayerId. 
        /// <para>
        /// A unique identifier for a player associated with this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string PlayerId { get; set; }

        /// <summary>
        /// Checks to see if the PlayerId property is set.
        /// </summary>
        internal bool IsSetPlayerId() => this.PlayerId != null;
    }
}
