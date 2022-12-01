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
    /// Configuration for a game session placement mechanism that processes requests for new
    /// game sessions. A queue can be used on its own or as part of a matchmaking solution.
    /// </summary>
    public partial class GameSessionQueue
    {
        private string _customEventData;
        private List<GameSessionQueueDestination> _destinations = new List<GameSessionQueueDestination>();
        private FilterConfiguration _filterConfiguration;
        private string _gameSessionQueueArn;
        private string _name;
        private string _notificationTarget;
        private List<PlayerLatencyPolicy> _playerLatencyPolicies = new List<PlayerLatencyPolicy>();
        private PriorityConfiguration _priorityConfiguration;
        private int? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property CustomEventData. 
        /// <para>
        ///  Information that is added to all events that are related to this game session queue.
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
        /// Gets and sets the property Destinations. 
        /// <para>
        /// A list of fleets and/or fleet aliases that can be used to fulfill game session placement
        /// requests in the queue. Destinations are identified by either a fleet ARN or a fleet
        /// alias ARN, and are listed in order of placement preference.
        /// </para>
        /// </summary>
        public List<GameSessionQueueDestination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FilterConfiguration. 
        /// <para>
        /// A list of locations where a queue is allowed to place new game sessions. Locations
        /// are specified in the form of Amazon Web Services Region codes, such as <code>us-west-2</code>.
        /// If this parameter is not set, game sessions can be placed in any queue location. 
        /// </para>
        /// </summary>
        public FilterConfiguration FilterConfiguration
        {
            get { return this._filterConfiguration; }
            set { this._filterConfiguration = value; }
        }

        // Check to see if FilterConfiguration property is set
        internal bool IsSetFilterConfiguration()
        {
            return this._filterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property GameSessionQueueArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a GameLift game session queue resource and uniquely identifies
        /// it. ARNs are unique across all Regions. Format is <code>arn:aws:gamelift:&lt;region&gt;::gamesessionqueue/&lt;queue
        /// name&gt;</code>. In a GameLift game session queue ARN, the resource ID matches the
        /// <i>Name</i> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string GameSessionQueueArn
        {
            get { return this._gameSessionQueueArn; }
            set { this._gameSessionQueueArn = value; }
        }

        // Check to see if GameSessionQueueArn property is set
        internal bool IsSetGameSessionQueueArn()
        {
            return this._gameSessionQueueArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with game session queue. Queue names must be
        /// unique within each Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// An SNS topic ARN that is set up to receive game session placement notifications. See
        /// <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queue-notification.html">
        /// Setting up notifications for game session placement</a>.
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
        /// Gets and sets the property PlayerLatencyPolicies. 
        /// <para>
        /// A set of policies that act as a sliding cap on player latency. FleetIQ works to deliver
        /// low latency for most players in a game session. These policies ensure that no individual
        /// player can be placed into a game with unreasonably high latency. Use multiple policies
        /// to gradually relax latency requirements a step at a time. Multiple policies are applied
        /// based on their maximum allowed latency, starting with the lowest value. 
        /// </para>
        /// </summary>
        public List<PlayerLatencyPolicy> PlayerLatencyPolicies
        {
            get { return this._playerLatencyPolicies; }
            set { this._playerLatencyPolicies = value; }
        }

        // Check to see if PlayerLatencyPolicies property is set
        internal bool IsSetPlayerLatencyPolicies()
        {
            return this._playerLatencyPolicies != null && this._playerLatencyPolicies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PriorityConfiguration. 
        /// <para>
        /// Custom settings to use when prioritizing destinations and locations for game session
        /// placements. This configuration replaces the FleetIQ default prioritization process.
        /// Priority types that are not explicitly named will be automatically applied at the
        /// end of the prioritization process. 
        /// </para>
        /// </summary>
        public PriorityConfiguration PriorityConfiguration
        {
            get { return this._priorityConfiguration; }
            set { this._priorityConfiguration = value; }
        }

        // Check to see if PriorityConfiguration property is set
        internal bool IsSetPriorityConfiguration()
        {
            return this._priorityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// The maximum time, in seconds, that a new game session placement request remains in
        /// the queue. When a request exceeds this time, the game session placement changes to
        /// a <code>TIMED_OUT</code> status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int TimeoutInSeconds
        {
            get { return this._timeoutInSeconds.GetValueOrDefault(); }
            set { this._timeoutInSeconds = value; }
        }

        // Check to see if TimeoutInSeconds property is set
        internal bool IsSetTimeoutInSeconds()
        {
            return this._timeoutInSeconds.HasValue; 
        }

    }
}