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
    /// Guidelines for use with FlexMatch to match players into games. All matchmaking requests
    /// must specify a matchmaking configuration.
    /// </summary>
    public partial class MatchmakingConfiguration
    {
        /// <summary>
        /// Gets and sets the property AcceptanceRequired. 
        /// <para>
        /// A flag that indicates whether a match that was created with this configuration must
        /// be accepted by the matched players. To require acceptance, set to TRUE. When this
        /// option is enabled, matchmaking tickets use the status <c>REQUIRES_ACCEPTANCE</c> to
        /// indicate when a completed potential match is waiting for player acceptance.
        /// </para>
        /// </summary>
        public bool? AcceptanceRequired { get; set; }

        /// <summary>
        /// Checks to see if the AcceptanceRequired property is set.
        /// </summary>
        internal bool IsSetAcceptanceRequired() => this.AcceptanceRequired.HasValue;

        /// <summary>
        /// Gets and sets the property AcceptanceTimeoutSeconds. 
        /// <para>
        /// The length of time (in seconds) to wait for players to accept a proposed match, if
        /// acceptance is required. If any player rejects the match or fails to accept before
        /// the timeout, the ticket continues to look for an acceptable match.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 600)]
        public int? AcceptanceTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the AcceptanceTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetAcceptanceTimeoutSeconds() => this.AcceptanceTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property AdditionalPlayerCount. 
        /// <para>
        /// The number of player slots in a match to keep open for future players. For example,
        /// if the configuration's rule set specifies a match for a single 12-person team, and
        /// the additional player count is set to 2, only 10 players are selected for the match.
        /// This parameter is not used when <c>FlexMatchMode</c> is set to <c>STANDALONE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? AdditionalPlayerCount { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalPlayerCount property is set.
        /// </summary>
        internal bool IsSetAdditionalPlayerCount() => this.AdditionalPlayerCount.HasValue;

        /// <summary>
        /// Gets and sets the property BackfillMode. 
        /// <para>
        /// The method used to backfill game sessions created with this matchmaking configuration.
        /// MANUAL indicates that the game makes backfill requests or does not use the match backfill
        /// feature. AUTOMATIC indicates that GameLift creates backfill requests whenever a game
        /// session has one or more open slots. Learn more about manual and automatic backfill
        /// in <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-backfill.html">Backfill
        /// existing games with FlexMatch</a>. Automatic backfill is not available when <c>FlexMatchMode</c>
        /// is set to <c>STANDALONE</c>.
        /// </para>
        /// </summary>
        public BackfillMode BackfillMode { get; set; }

        /// <summary>
        /// Checks to see if the BackfillMode property is set.
        /// </summary>
        internal bool IsSetBackfillMode() => this.BackfillMode != null;

        /// <summary>
        /// Gets and sets the property ConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a Amazon GameLift Servers matchmaking configuration resource and
        /// uniquely identifies it. ARNs are unique across all Regions. Format is <c>arn:aws:gamelift:&lt;region&gt;::matchmakingconfiguration/&lt;matchmaking
        /// configuration name&gt;</c>. In a Amazon GameLift Servers configuration ARN, the resource
        /// ID matches the <i>Name</i> value.
        /// </para>
        /// </summary>
        public string ConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationArn property is set.
        /// </summary>
        internal bool IsSetConfigurationArn() => this.ConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomEventData. 
        /// <para>
        /// Information to attach to all events related to the matchmaking configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string CustomEventData { get; set; }

        /// <summary>
        /// Checks to see if the CustomEventData property is set.
        /// </summary>
        internal bool IsSetCustomEventData() => this.CustomEventData != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A descriptive label that is associated with matchmaking configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FlexMatchMode. 
        /// <para>
        /// Indicates whether this matchmaking configuration is being used with Amazon GameLift
        /// Servers hosting or as a standalone matchmaking solution. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>STANDALONE</b> - FlexMatch forms matches and returns match information, including
        /// players and team assignments, in a <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-events.html#match-events-matchmakingsucceeded">
        /// MatchmakingSucceeded</a> event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WITH_QUEUE</b> - FlexMatch forms matches and uses the specified Amazon GameLift
        /// Servers queue to start a game session for the match. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FlexMatchMode FlexMatchMode { get; set; }

        /// <summary>
        /// Checks to see if the FlexMatchMode property is set.
        /// </summary>
        internal bool IsSetFlexMatchMode() => this.FlexMatchMode != null;

        /// <summary>
        /// Gets and sets the property GameProperties. 
        /// <para>
        /// A set of key-value pairs that can store custom data in a game session. For example:
        /// <c>{"Key": "difficulty", "Value": "novice"}</c>. This information is added to the
        /// new <c>GameSession</c> object that is created for a successful match. This parameter
        /// is not used when <c>FlexMatchMode</c> is set to <c>STANDALONE</c>.
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
        /// Gets and sets the property GameSessionData. 
        /// <para>
        /// A set of custom game session properties, formatted as a single string value. This
        /// data is passed to a game server process with a request to start a new game session.
        /// For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a game session</a>. This information is added to the new <c>GameSession</c> object
        /// that is created for a successful match. This parameter is not used when <c>FlexMatchMode</c>
        /// is set to <c>STANDALONE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string GameSessionData { get; set; }

        /// <summary>
        /// Checks to see if the GameSessionData property is set.
        /// </summary>
        internal bool IsSetGameSessionData() => this.GameSessionData != null;

        /// <summary>
        /// Gets and sets the property GameSessionQueueArns. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a Amazon GameLift Servers game session queue resource and uniquely
        /// identifies it. ARNs are unique across all Regions. Format is <c>arn:aws:gamelift:&lt;region&gt;::gamesessionqueue/&lt;queue
        /// name&gt;</c>. Queues can be located in any Region. Queues are used to start new Amazon
        /// GameLift Servers-hosted game sessions for matches that are created with this matchmaking
        /// configuration. This property is not set when <c>FlexMatchMode</c> is set to <c>STANDALONE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GameSessionQueueArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GameSessionQueueArns property is set.
        /// </summary>
        internal bool IsSetGameSessionQueueArns() => this.GameSessionQueueArns != null && (this.GameSessionQueueArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique identifier for the matchmaking configuration. This name is used to identify
        /// the configuration associated with a matchmaking request or ticket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NotificationTarget. 
        /// <para>
        /// An SNS topic ARN that is set up to receive matchmaking notifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public string NotificationTarget { get; set; }

        /// <summary>
        /// Checks to see if the NotificationTarget property is set.
        /// </summary>
        internal bool IsSetNotificationTarget() => this.NotificationTarget != null;

        /// <summary>
        /// Gets and sets the property RequestTimeoutSeconds. 
        /// <para>
        /// The maximum duration, in seconds, that a matchmaking ticket can remain in process
        /// before timing out. Requests that fail due to timing out can be resubmitted as needed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 43200)]
        public int? RequestTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the RequestTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetRequestTimeoutSeconds() => this.RequestTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property RuleSetArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// associated with the GameLift matchmaking rule set resource that this configuration
        /// uses.
        /// </para>
        /// </summary>
        public string RuleSetArn { get; set; }

        /// <summary>
        /// Checks to see if the RuleSetArn property is set.
        /// </summary>
        internal bool IsSetRuleSetArn() => this.RuleSetArn != null;

        /// <summary>
        /// Gets and sets the property RuleSetName. 
        /// <para>
        /// A unique identifier for the matchmaking rule set to use with this configuration. A
        /// matchmaking configuration can only use rule sets that are defined in the same Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string RuleSetName { get; set; }

        /// <summary>
        /// Checks to see if the RuleSetName property is set.
        /// </summary>
        internal bool IsSetRuleSetName() => this.RuleSetName != null;
    }
}
