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
    /// Container for the parameters to the UpdateGameSession operation. <b>This API works
    /// with the following fleet types:</b> EC2, Anywhere, Container <para> Updates the mutable
    /// properties of a game session. </para> <para> To update a game session, specify the
    /// game session ID and the values you want to change. </para> <para> If successful, the
    /// updated <c>GameSession</c> object is returned. </para> <para> <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> </para>
    /// </summary>
    public partial class UpdateGameSessionRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property GameProperties. 
        /// <para>
        /// A set of key-value pairs that can store custom data in a game session. For example:
        /// <c>{"Key": "difficulty", "Value": "novice"}</c>. You can use this parameter to modify
        /// game properties in an active game session. This action adds new properties and modifies
        /// existing properties. There is no way to delete properties. For an example, see <a
        /// href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-client-api.html#game-properties-update">Update
        /// the value of a game property</a>. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// Avoid using periods (".") in property keys if you plan to search for game sessions
        /// by properties. Property keys containing periods cannot be searched and will be filtered
        /// out from search results due to search index limitations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use SearchGameSessions API, there is a limit of 500 game property keys across
        /// all game sessions and all fleets per region. If the limit is exceeded, there will
        /// potentially be game session entries missing from SearchGameSessions API results.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public List<GameProperty> GameProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<GameProperty>() : null;

        /// <summary>
        /// Checks to see if the GameProperties property is set.
        /// </summary>
        internal bool IsSetGameProperties() => this.GameProperties != null && (this.GameProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// An identifier for the game session that is unique across all regions to update. The
        /// value is always a full ARN in the following format: For Home Region game session -
        /// <c>arn:aws:gamelift:&lt;home_region&gt;::gamesession/&lt;fleet ID&gt;/&lt;ID string&gt;</c>.
        /// For Remote Location game session - <c>arn:aws:gamelift:&lt;home_region&gt;::gamesession/&lt;fleet
        /// ID&gt;/&lt;location&gt;/&lt;ID string&gt;</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string GameSessionId { get; set; }

        /// <summary>
        /// Checks to see if the GameSessionId property is set.
        /// </summary>
        internal bool IsSetGameSessionId() => this.GameSessionId != null;

        /// <summary>
        /// Gets and sets the property MaximumPlayerSessionCount. 
        /// <para>
        /// The maximum number of players that can be connected simultaneously to the game session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaximumPlayerSessionCount { get; set; }

        /// <summary>
        /// Checks to see if the MaximumPlayerSessionCount property is set.
        /// </summary>
        internal bool IsSetMaximumPlayerSessionCount() => this.MaximumPlayerSessionCount.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a game session. Session names do not need
        /// to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PlayerSessionCreationPolicy. 
        /// <para>
        /// A policy that determines whether the game session is accepting new players.
        /// </para>
        /// </summary>
        public PlayerSessionCreationPolicy PlayerSessionCreationPolicy { get; set; }

        /// <summary>
        /// Checks to see if the PlayerSessionCreationPolicy property is set.
        /// </summary>
        internal bool IsSetPlayerSessionCreationPolicy() => this.PlayerSessionCreationPolicy != null;

        /// <summary>
        /// Gets and sets the property ProtectionPolicy. 
        /// <para>
        /// Game session protection policy to apply to this game session only.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NoProtection</c> -- The game session can be terminated during a scale-down event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FullProtection</c> -- If the game session is in an <c>ACTIVE</c> status, it cannot
        /// be terminated during a scale-down event.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ProtectionPolicy ProtectionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ProtectionPolicy property is set.
        /// </summary>
        internal bool IsSetProtectionPolicy() => this.ProtectionPolicy != null;
    }
}
