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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Guidelines for use with FlexMatch to match players into games. All matchmaking requests
    /// must specify a matchmaking configuration.
    /// </summary>
    public partial class MatchmakingConfiguration
    {
        private bool? _acceptanceRequired;
        private int? _acceptanceTimeoutSeconds;
        private int? _additionalPlayerCount;
        private BackfillMode _backfillMode;
        private string _configurationArn;
        private DateTime? _creationTime;
        private string _customEventData;
        private string _description;
        private FlexMatchMode _flexMatchMode;
        private List<GameProperty> _gameProperties = new List<GameProperty>();
        private string _gameSessionData;
        private List<string> _gameSessionQueueArns = new List<string>();
        private string _name;
        private string _notificationTarget;
        private int? _requestTimeoutSeconds;
        private string _ruleSetArn;
        private string _ruleSetName;

        /// <summary>
        /// Gets and sets the property AcceptanceRequired. 
        /// <para>
        /// A flag that indicates whether a match that was created with this configuration must
        /// be accepted by the matched players. To require acceptance, set to TRUE. When this
        /// option is enabled, matchmaking tickets use the status <code>REQUIRES_ACCEPTANCE</code>
        /// to indicate when a completed potential match is waiting for player acceptance.
        /// </para>
        /// </summary>
        public bool AcceptanceRequired
        {
            get { return this._acceptanceRequired.GetValueOrDefault(); }
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
        /// acceptance is required. If any player rejects the match or fails to accept before
        /// the timeout, the ticket continues to look for an acceptable match.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=600)]
        public int AcceptanceTimeoutSeconds
        {
            get { return this._acceptanceTimeoutSeconds.GetValueOrDefault(); }
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
        /// This parameter is not used when <code>FlexMatchMode</code> is set to <code>STANDALONE</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int AdditionalPlayerCount
        {
            get { return this._additionalPlayerCount.GetValueOrDefault(); }
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
        /// The method used to backfill game sessions created with this matchmaking configuration.
        /// MANUAL indicates that the game makes backfill requests or does not use the match backfill
        /// feature. AUTOMATIC indicates that GameLift creates backfill requests whenever a game
        /// session has one or more open slots. Learn more about manual and automatic backfill
        /// in <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-backfill.html">Backfill
        /// existing games with FlexMatch</a>. Automatic backfill is not available when <code>FlexMatchMode</code>
        /// is set to <code>STANDALONE</code>.
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
        /// Gets and sets the property ConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a GameLift matchmaking configuration resource and uniquely identifies
        /// it. ARNs are unique across all Regions. Format is <code>arn:aws:gamelift:&lt;region&gt;::matchmakingconfiguration/&lt;matchmaking
        /// configuration name&gt;</code>. In a GameLift configuration ARN, the resource ID matches
        /// the <i>Name</i> value.
        /// </para>
        /// </summary>
        public string ConfigurationArn
        {
            get { return this._configurationArn; }
            set { this._configurationArn = value; }
        }

        // Check to see if ConfigurationArn property is set
        internal bool IsSetConfigurationArn()
        {
            return this._configurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <code>"1469498468.057"</code>).
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomEventData. 
        /// <para>
        /// Information to attach to all events related to the matchmaking configuration. 
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
        /// A descriptive label that is associated with matchmaking configuration.
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
        /// Indicates whether this matchmaking configuration is being used with GameLift hosting
        /// or as a standalone matchmaking solution. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>STANDALONE</b> - FlexMatch forms matches and returns match information, including
        /// players and team assignments, in a <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-events.html#match-events-matchmakingsucceeded">
        /// MatchmakingSucceeded</a> event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>WITH_QUEUE</b> - FlexMatch forms matches and uses the specified GameLift queue
        /// to start a game session for the match. 
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
        /// A set of custom properties for a game session, formatted as key:value pairs. These
        /// properties are passed to a game server process with a request to start a new game
        /// session (see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a Game Session</a>). This information is added to the new <code>GameSession</code>
        /// object that is created for a successful match. This parameter is not used when <code>FlexMatchMode</code>
        /// is set to <code>STANDALONE</code>.
        /// </para>
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
            return this._gameProperties != null && this._gameProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GameSessionData. 
        /// <para>
        /// A set of custom game session properties, formatted as a single string value. This
        /// data is passed to a game server process with a request to start a new game session
        /// (see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-sdk-server-api.html#gamelift-sdk-server-startsession">Start
        /// a Game Session</a>). This information is added to the new <code>GameSession</code>
        /// object that is created for a successful match. This parameter is not used when <code>FlexMatchMode</code>
        /// is set to <code>STANDALONE</code>.
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
        /// that is assigned to a GameLift game session queue resource and uniquely identifies
        /// it. ARNs are unique across all Regions. Format is <code>arn:aws:gamelift:&lt;region&gt;::gamesessionqueue/&lt;queue
        /// name&gt;</code>. Queues can be located in any Region. Queues are used to start new
        /// GameLift-hosted game sessions for matches that are created with this matchmaking configuration.
        /// This property is not set when <code>FlexMatchMode</code> is set to <code>STANDALONE</code>.
        /// </para>
        /// </summary>
        public List<string> GameSessionQueueArns
        {
            get { return this._gameSessionQueueArns; }
            set { this._gameSessionQueueArns = value; }
        }

        // Check to see if GameSessionQueueArns property is set
        internal bool IsSetGameSessionQueueArns()
        {
            return this._gameSessionQueueArns != null && this._gameSessionQueueArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique identifier for the matchmaking configuration. This name is used to identify
        /// the configuration associated with a matchmaking request or ticket.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// An SNS topic ARN that is set up to receive matchmaking notifications.
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
        [AWSProperty(Min=1, Max=43200)]
        public int RequestTimeoutSeconds
        {
            get { return this._requestTimeoutSeconds.GetValueOrDefault(); }
            set { this._requestTimeoutSeconds = value; }
        }

        // Check to see if RequestTimeoutSeconds property is set
        internal bool IsSetRequestTimeoutSeconds()
        {
            return this._requestTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleSetArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// associated with the GameLift matchmaking rule set resource that this configuration
        /// uses.
        /// </para>
        /// </summary>
        public string RuleSetArn
        {
            get { return this._ruleSetArn; }
            set { this._ruleSetArn = value; }
        }

        // Check to see if RuleSetArn property is set
        internal bool IsSetRuleSetArn()
        {
            return this._ruleSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property RuleSetName. 
        /// <para>
        /// A unique identifier for the matchmaking rule set to use with this configuration. A
        /// matchmaking configuration can only use rule sets that are defined in the same Region.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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

    }
}