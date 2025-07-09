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
    /// Container for the parameters to the CreateGameSessionQueue operation.
    /// Creates a placement queue that processes requests for new game sessions. A queue uses
    /// FleetIQ algorithms to locate the best available placement locations for a new game
    /// session, and then prompts the game server process to start a new game session.
    /// 
    ///  
    /// <para>
    /// A game session queue is configured with a set of destinations (Amazon GameLift Servers
    /// fleets or aliases) that determine where the queue can place new game sessions. These
    /// destinations can span multiple Amazon Web Services Regions, can use different instance
    /// types, and can include both Spot and On-Demand fleets. If the queue includes multi-location
    /// fleets, the queue can place game sessions in any of a fleet's remote locations.
    /// </para>
    ///  
    /// <para>
    /// You can configure a queue to determine how it selects the best available placement
    /// for a new game session. Queues can prioritize placement decisions based on a combination
    /// of location, hosting cost, and player latency. You can set up the queue to use the
    /// default prioritization or provide alternate instructions using <c>PriorityConfiguration</c>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Request options</b> 
    /// </para>
    ///  
    /// <para>
    /// Use this operation to make these common types of requests. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Create a queue with the minimum required parameters.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Name</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Destinations</c> (This parameter isn't required, but a queue can't make placements
    /// without at least one destination.)
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Create a queue with placement notification. Queues that have high placement activity
    /// must use a notification system, such as with Amazon Simple Notification Service (Amazon
    /// SNS) or Amazon CloudWatch.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Required parameters <c>Name</c> and <c>Destinations</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>NotificationTarget</c> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Create a queue with custom prioritization settings. These custom settings replace
    /// the default prioritization configuration for a queue.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Required parameters <c>Name</c> and <c>Destinations</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PriorityConfiguration</c> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Create a queue with special rules for processing player latency data.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Required parameters <c>Name</c> and <c>Destinations</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>PlayerLatencyPolicies</c> 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    ///  <b>Results</b> 
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation returns a new <c>GameSessionQueue</c> object with an
    /// assigned queue ARN. Use the queue's name or ARN when submitting new game session requests
    /// with <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StartGameSessionPlacement.html">StartGameSessionPlacement</a>
    /// or <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_StartMatchmaking.html">StartMatchmaking</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-design.html">
    /// Design a game session queue</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-creating.html">
    /// Create a game session queue</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateGameSessionQueue.html">CreateGameSessionQueue</a>
    /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeGameSessionQueues.html">DescribeGameSessionQueues</a>
    /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateGameSessionQueue.html">UpdateGameSessionQueue</a>
    /// | <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DeleteGameSessionQueue.html">DeleteGameSessionQueue</a>
    /// | <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class CreateGameSessionQueueRequest : AmazonGameLiftRequest
    {
        private string _customEventData;
        private List<GameSessionQueueDestination> _destinations = AWSConfigs.InitializeCollections ? new List<GameSessionQueueDestination>() : null;
        private FilterConfiguration _filterConfiguration;
        private string _name;
        private string _notificationTarget;
        private List<PlayerLatencyPolicy> _playerLatencyPolicies = AWSConfigs.InitializeCollections ? new List<PlayerLatencyPolicy>() : null;
        private PriorityConfiguration _priorityConfiguration;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private int? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property CustomEventData. 
        /// <para>
        /// Information to be added to all events that are related to this game session queue.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GameSessionQueueDestination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && (this._destinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FilterConfiguration. 
        /// <para>
        /// A list of locations where a queue is allowed to place new game sessions. Locations
        /// are specified in the form of Amazon Web Services Region codes, such as <c>us-west-2</c>.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with game session queue. Queue names must be
        /// unique within each Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// A set of policies that enforce a sliding cap on player latency when processing game
        /// sessions placement requests. Use multiple policies to gradually relax the cap over
        /// time if Amazon GameLift Servers can't make a placement. Policies are evaluated in
        /// order starting with the lowest maximum latency value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlayerLatencyPolicy> PlayerLatencyPolicies
        {
            get { return this._playerLatencyPolicies; }
            set { this._playerLatencyPolicies = value; }
        }

        // Check to see if PlayerLatencyPolicies property is set
        internal bool IsSetPlayerLatencyPolicies()
        {
            return this._playerLatencyPolicies != null && (this._playerLatencyPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the new game session queue resource. Tags are developer-defined
        /// key-value pairs. Tagging Amazon Web Services resources are useful for resource management,
        /// access management and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>.
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

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// The maximum time, in seconds, that a new game session placement request remains in
        /// the queue. When a request exceeds this time, the game session placement changes to
        /// a <c>TIMED_OUT</c> status. If you don't specify a request timeout, the queue uses
        /// a default value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TimeoutInSeconds
        {
            get { return this._timeoutInSeconds; }
            set { this._timeoutInSeconds = value; }
        }

        // Check to see if TimeoutInSeconds property is set
        internal bool IsSetTimeoutInSeconds()
        {
            return this._timeoutInSeconds.HasValue; 
        }

    }
}