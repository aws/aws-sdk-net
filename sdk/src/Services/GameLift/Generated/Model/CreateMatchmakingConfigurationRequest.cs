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
    /// Container for the parameters to the CreateMatchmakingConfiguration operation.
    /// Defines a new matchmaking configuration for use with FlexMatch. Whether your are using
    /// FlexMatch with Amazon GameLift Servers hosting or as a standalone matchmaking service,
    /// the matchmaking configuration sets out rules for matching players and forming teams.
    /// If you're also using Amazon GameLift Servers hosting, it defines how to start game
    /// sessions for each match. Your matchmaking system can use multiple configurations to
    /// handle different game scenarios. All matchmaking requests identify the matchmaking
    /// configuration to use and provide player attributes consistent with that configuration.
    /// 
    /// 
    ///  
    /// <para>
    /// To create a matchmaking configuration, you must provide the following: configuration
    /// name and FlexMatch mode (with or without Amazon GameLift Servers hosting); a rule
    /// set that specifies how to evaluate players and find acceptable matches; whether player
    /// acceptance is required; and the maximum time allowed for a matchmaking attempt. When
    /// using FlexMatch with Amazon GameLift Servers hosting, you also need to identify the
    /// game session queue to use when starting a game session for the match.
    /// </para>
    ///  
    /// <para>
    /// In addition, you must set up an Amazon Simple Notification Service topic to receive
    /// matchmaking notifications. Provide the topic ARN in the matchmaking configuration.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-configuration.html">
    /// Design a FlexMatch matchmaker</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-notification.html">
    /// Set up FlexMatch event notification</a> 
    /// </para>
    /// </summary>
    public partial class CreateMatchmakingConfigurationRequest : AmazonGameLiftRequest
    {
        private bool? _acceptanceRequired;
        private int? _acceptanceTimeoutSeconds;
        private int? _additionalPlayerCount;
        private BackfillMode _backfillMode;
        private string _customEventData;
        private string _description;
        private FlexMatchMode _flexMatchMode;
        private List<GameProperty> _gameProperties = AWSConfigs.InitializeCollections ? new List<GameProperty>() : null;
        private string _gameSessionData;
        private List<string> _gameSessionQueueArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _notificationTarget;
        private int? _requestTimeoutSeconds;
        private string _ruleSetName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AcceptanceRequired. 
        /// <para>
        /// A flag that determines whether a match that was created with this configuration must
        /// be accepted by the matched players. To require acceptance, set to <c>TRUE</c>. With
        /// this option enabled, matchmaking tickets use the status <c>REQUIRES_ACCEPTANCE</c>
        /// to indicate when a completed potential match is waiting for player acceptance. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? AcceptanceRequired
        {
            get { return this._acceptanceRequired; }
            set { this._acceptanceRequired = value; }
        }

        // Check to see if AcceptanceRequired property is set
        internal bool IsSetAcceptanceRequired()
        {
            return this._acceptanceRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AcceptanceTimeoutSeconds. 
        /// <para>
        /// The length of time (in seconds) to wait for players to accept a proposed match, if
        /// acceptance is required. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=600)]
        public int? AcceptanceTimeoutSeconds
        {
            get { return this._acceptanceTimeoutSeconds; }
            set { this._acceptanceTimeoutSeconds = value; }
        }

        // Check to see if AcceptanceTimeoutSeconds property is set
        internal bool IsSetAcceptanceTimeoutSeconds()
        {
            return this._acceptanceTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AdditionalPlayerCount. 
        /// <para>
        /// The number of player slots in a match to keep open for future players. For example,
        /// if the configuration's rule set specifies a match for a single 12-person team, and
        /// the additional player count is set to 2, only 10 players are selected for the match.
        /// This parameter is not used if <c>FlexMatchMode</c> is set to <c>STANDALONE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AdditionalPlayerCount
        {
            get { return this._additionalPlayerCount; }
            set { this._additionalPlayerCount = value; }
        }

        // Check to see if AdditionalPlayerCount property is set
        internal bool IsSetAdditionalPlayerCount()
        {
            return this._additionalPlayerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BackfillMode. 
        /// <para>
        /// The method used to backfill game sessions that are created with this matchmaking configuration.
        /// Specify <c>MANUAL</c> when your game manages backfill requests manually or does not
        /// use the match backfill feature. Specify <c>AUTOMATIC</c> to have Amazon GameLift Servers
        /// create a backfill request whenever a game session has one or more open slots. Learn
        /// more about manual and automatic backfill in <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-backfill.html">
        /// Backfill Existing Games with FlexMatch</a>. Automatic backfill is not available when
        /// <c>FlexMatchMode</c> is set to <c>STANDALONE</c>.
        /// </para>
        /// </summary>
        public BackfillMode BackfillMode
        {
            get { return this._backfillMode; }
            set { this._backfillMode = value; }
        }

        // Check to see if BackfillMode property is set
        internal bool IsSetBackfillMode()
        {
            return this._backfillMode != null;
        }

        /// <summary>
        /// Gets and sets the property CustomEventData. 
        /// <para>
        /// Information to be added to all events related to this matchmaking configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string CustomEventData
        {
            get { return this._customEventData; }
            set { this._customEventData = value; }
        }

        // Check to see if CustomEventData property is set
        internal bool IsSetCustomEventData()
        {
            return this._customEventData != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the matchmaking configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

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
        public FlexMatchMode FlexMatchMode
        {
            get { return this._flexMatchMode; }
            set { this._flexMatchMode = value; }
        }

        // Check to see if FlexMatchMode property is set
        internal bool IsSetFlexMatchMode()
        {
            return this._flexMatchMode != null;
        }

        /// <summary>
        /// Gets and sets the property GameProperties. 
        /// <para>
        /// A set of key-value pairs that can store custom data in a game session. For example:
        /// <c>{"Key": "difficulty", "Value": "novice"}</c>. This information is added to the
        /// new <c>GameSession</c> object that is created for a successful match. This parameter
        /// is not used if <c>FlexMatchMode</c> is set to <c>STANDALONE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=16)]
        public List<GameProperty> GameProperties
        {
            get { return this._gameProperties; }
            set { this._gameProperties = value; }
        }

        // Check to see if GameProperties property is set
        internal bool IsSetGameProperties()
        {
            return this._gameProperties != null && (this._gameProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GameSessionData. 
        /// <para>
        /// A set of custom game session properties, formatted as a single string value. This
        /// data is passed to a game server process with a request to start a new game session.
        /// For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a game session</a>. This information is added to the new <c>GameSession</c> object
        /// that is created for a successful match. This parameter is not used if <c>FlexMatchMode</c>
        /// is set to <c>STANDALONE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string GameSessionData
        {
            get { return this._gameSessionData; }
            set { this._gameSessionData = value; }
        }

        // Check to see if GameSessionData property is set
        internal bool IsSetGameSessionData()
        {
            return this._gameSessionData != null;
        }

        /// <summary>
        /// Gets and sets the property GameSessionQueueArns. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a Amazon GameLift Servers game session queue resource and uniquely
        /// identifies it. ARNs are unique across all Regions. Format is <c>arn:aws:gamelift:&lt;region&gt;::gamesessionqueue/&lt;queue
        /// name&gt;</c>. Queues can be located in any Region. Queues are used to start new Amazon
        /// GameLift Servers-hosted game sessions for matches that are created with this matchmaking
        /// configuration. If <c>FlexMatchMode</c> is set to <c>STANDALONE</c>, do not set this
        /// parameter. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GameSessionQueueArns
        {
            get { return this._gameSessionQueueArns; }
            set { this._gameSessionQueueArns = value; }
        }

        // Check to see if GameSessionQueueArns property is set
        internal bool IsSetGameSessionQueueArns()
        {
            return this._gameSessionQueueArns != null && (this._gameSessionQueueArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique identifier for the matchmaking configuration. This name is used to identify
        /// the configuration associated with a matchmaking request or ticket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationTarget. 
        /// <para>
        /// An SNS topic ARN that is set up to receive matchmaking notifications. See <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-notification.html">
        /// Setting up notifications for matchmaking</a> for more information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public string NotificationTarget
        {
            get { return this._notificationTarget; }
            set { this._notificationTarget = value; }
        }

        // Check to see if NotificationTarget property is set
        internal bool IsSetNotificationTarget()
        {
            return this._notificationTarget != null;
        }

        /// <summary>
        /// Gets and sets the property RequestTimeoutSeconds. 
        /// <para>
        /// The maximum duration, in seconds, that a matchmaking ticket can remain in process
        /// before timing out. Requests that fail due to timing out can be resubmitted as needed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=43200)]
        public int? RequestTimeoutSeconds
        {
            get { return this._requestTimeoutSeconds; }
            set { this._requestTimeoutSeconds = value; }
        }

        // Check to see if RequestTimeoutSeconds property is set
        internal bool IsSetRequestTimeoutSeconds()
        {
            return this._requestTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleSetName. 
        /// <para>
        /// A unique identifier for the matchmaking rule set to use with this configuration. You
        /// can use either the rule set name or ARN value. A matchmaking configuration can only
        /// use rule sets that are defined in the same Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string RuleSetName
        {
            get { return this._ruleSetName; }
            set { this._ruleSetName = value; }
        }

        // Check to see if RuleSetName property is set
        internal bool IsSetRuleSetName()
        {
            return this._ruleSetName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the new matchmaking configuration resource. Tags are
        /// developer-defined key-value pairs. Tagging Amazon Web Services resources are useful
        /// for resource management, access management and cost allocation. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html"> Tagging
        /// Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}