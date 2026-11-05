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
    /// Container for the parameters to the UpdateGameSessionQueue operation. <b>This API
    /// works with the following fleet types:</b> EC2, Anywhere, Container <para> Updates
    /// the configuration of a game session queue, which determines how the queue processes
    /// new game session requests. To update settings, specify the queue name to be updated
    /// and provide the new settings. When updating destinations, provide a complete list
    /// of destinations. </para> <para> <b>Learn more</b> </para> <para> <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/queues-intro.html">
    /// Using Multi-Region Queues</a> </para>
    /// </summary>
    public partial class UpdateGameSessionQueueRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property CustomEventData. 
        /// <para>
        /// Information to be added to all events that are related to this game session queue.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string CustomEventData { get; set; }

        /// <summary>
        /// Checks to see if the CustomEventData property is set.
        /// </summary>
        internal bool IsSetCustomEventData() => this.CustomEventData != null;

        private List<GameSessionQueueDestination> _Destinations = AWSConfigs.InitializeCollections ? new List<GameSessionQueueDestination>() : null;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// A list of fleets and/or fleet aliases that can be used to fulfill game session placement
        /// requests in the queue. Destinations are identified by either a fleet ARN or a fleet
        /// alias ARN, and are listed in order of placement preference. When updating this list,
        /// provide a complete list of destinations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GameSessionQueueDestination> Destinations { get => this._Destinations; set => this._Destinations = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="Destinations"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="Destinations"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsDestinationsSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._Destinations);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._Destinations);
        }

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.IsDestinationsSet;

        /// <summary>
        /// Gets and sets the property FilterConfiguration. 
        /// <para>
        /// A list of locations where a queue is allowed to place new game sessions. Locations
        /// are specified in the form of Amazon Web Services Region codes, such as <c>us-west-2</c>.
        /// If this parameter is not set, game sessions can be placed in any queue location. To
        /// remove an existing filter configuration, pass in an empty set.
        /// </para>
        /// </summary>
        public FilterConfiguration FilterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the FilterConfiguration property is set.
        /// </summary>
        internal bool IsSetFilterConfiguration() => this.FilterConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with game session queue. Queue names must be
        /// unique within each Region. You can use either the queue ID or ARN value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
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

        private List<PlayerLatencyPolicy> _PlayerLatencyPolicies = AWSConfigs.InitializeCollections ? new List<PlayerLatencyPolicy>() : null;

        /// <summary>
        /// Gets and sets the property PlayerLatencyPolicies. 
        /// <para>
        /// A set of policies that enforce a sliding cap on player latency when processing game
        /// sessions placement requests. Use multiple policies to gradually relax the cap over
        /// time if Amazon GameLift Servers can't make a placement. Policies are evaluated in
        /// order starting with the lowest maximum latency value. When updating policies, provide
        /// a complete collection of policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlayerLatencyPolicy> PlayerLatencyPolicies { get => this._PlayerLatencyPolicies; set => this._PlayerLatencyPolicies = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="PlayerLatencyPolicies"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="PlayerLatencyPolicies"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsPlayerLatencyPoliciesSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._PlayerLatencyPolicies);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._PlayerLatencyPolicies);
        }

        /// <summary>
        /// Checks to see if the PlayerLatencyPolicies property is set.
        /// </summary>
        internal bool IsSetPlayerLatencyPolicies() => this.IsPlayerLatencyPoliciesSet;

        /// <summary>
        /// Gets and sets the property PriorityConfiguration. 
        /// <para>
        /// Custom settings to use when prioritizing destinations and locations for game session
        /// placements. This configuration replaces the FleetIQ default prioritization process.
        /// Priority types that are not explicitly named will be automatically applied at the
        /// end of the prioritization process. To remove an existing priority configuration, pass
        /// in an empty set.
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
