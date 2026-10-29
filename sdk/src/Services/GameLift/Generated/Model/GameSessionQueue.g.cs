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
    /// Configuration for a game session placement mechanism that processes requests for new
    /// game sessions. A queue can be used on its own or as part of a matchmaking solution.
    /// </summary>
    public partial class GameSessionQueue
    {
        /// <summary>
        /// Gets and sets the property CustomEventData. 
        /// <para>
        ///  Information that is added to all events that are related to this game session queue.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string CustomEventData { get; set; }

        /// <summary>
        /// Checks to see if the CustomEventData property is set.
        /// </summary>
        internal bool IsSetCustomEventData() => this.CustomEventData != null;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// A list of fleets and/or fleet aliases that can be used to fulfill game session placement
        /// requests in the queue. Destinations are identified by either a fleet ARN or a fleet
        /// alias ARN, and are listed in order of placement preference.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GameSessionQueueDestination> Destinations { get; set; } = AWSConfigs.InitializeCollections ? new List<GameSessionQueueDestination>() : null;

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.Destinations != null && (this.Destinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilterConfiguration. 
        /// <para>
        /// A list of locations where a queue is allowed to place new game sessions. Locations
        /// are specified in the form of Amazon Web Services Region codes, such as <c>us-west-2</c>.
        /// If this parameter is not set, game sessions can be placed in any queue location. 
        /// </para>
        /// </summary>
        public FilterConfiguration FilterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FilterConfiguration property is set.
        /// </summary>
        internal bool IsSetFilterConfiguration() => this.FilterConfiguration != null;

        /// <summary>
        /// Gets and sets the property GameSessionQueueArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to a Amazon GameLift Servers game session queue resource and uniquely
        /// identifies it. ARNs are unique across all Regions. Format is <c>arn:aws:gamelift:&lt;region&gt;::gamesessionqueue/&lt;queue
        /// name&gt;</c>. In a Amazon GameLift Servers game session queue ARN, the resource ID
        /// matches the <i>Name</i> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string GameSessionQueueArn { get; set; }

        /// <summary>
        /// Checks to see if the GameSessionQueueArn property is set.
        /// </summary>
        internal bool IsSetGameSessionQueueArn() => this.GameSessionQueueArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with game session queue. Queue names must be
        /// unique within each Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NotificationTarget. 
        /// <para>
        /// An SNS topic ARN that is set up to receive game session placement notifications. See
        /// <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queue-notification.html">
        /// Setting up notifications for game session placement</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 300)]
        public string NotificationTarget { get; set; }

        /// <summary>
        /// Checks to see if the NotificationTarget property is set.
        /// </summary>
        internal bool IsSetNotificationTarget() => this.NotificationTarget != null;

        /// <summary>
        /// Gets and sets the property PlayerLatencyPolicies. 
        /// <para>
        /// A set of policies that enforce a sliding cap on player latency when processing game
        /// sessions placement requests. Use multiple policies to gradually relax the cap over
        /// time if Amazon GameLift Servers can't make a placement. Policies are evaluated in
        /// order starting with the lowest maximum latency value. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlayerLatencyPolicy> PlayerLatencyPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<PlayerLatencyPolicy>() : null;

        /// <summary>
        /// Checks to see if the PlayerLatencyPolicies property is set.
        /// </summary>
        internal bool IsSetPlayerLatencyPolicies() => this.PlayerLatencyPolicies != null && (this.PlayerLatencyPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PriorityConfiguration. 
        /// <para>
        /// Custom settings to use when prioritizing destinations and locations for game session
        /// placements. This configuration replaces the FleetIQ default prioritization process.
        /// Priority types that are not explicitly named will be automatically applied at the
        /// end of the prioritization process. 
        /// </para>
        /// </summary>
        public PriorityConfiguration PriorityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PriorityConfiguration property is set.
        /// </summary>
        internal bool IsSetPriorityConfiguration() => this.PriorityConfiguration != null;

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// The maximum time, in seconds, that a new game session placement request remains in
        /// the queue. When a request exceeds this time, the game session placement changes to
        /// a <c>TIMED_OUT</c> status.
        /// </para>
        ///  <note> 
        /// <para>
        /// The minimum value is 10 and the maximum value is 600.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutInSeconds() => this.TimeoutInSeconds.HasValue;
    }
}
