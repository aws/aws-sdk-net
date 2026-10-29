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
    /// Ticket generated to track the progress of a matchmaking request. Each ticket is uniquely
    /// identified by a ticket ID, supplied by the requester, when creating a matchmaking
    /// request.
    /// </summary>
    public partial class MatchmakingTicket
    {
        /// <summary>
        /// Gets and sets the property ConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// associated with the GameLift matchmaking configuration resource that is used with
        /// this ticket.
        /// </para>
        /// </summary>
        public string ConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationArn property is set.
        /// </summary>
        internal bool IsSetConfigurationArn() => this.ConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ConfigurationName. 
        /// <para>
        /// Name of the matchmaking configuration that is used with this ticket. Matchmaking configurations
        /// determine how players are grouped into a match and how a new game session is created
        /// for the match.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationName property is set.
        /// </summary>
        internal bool IsSetConfigurationName() => this.ConfigurationName != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Time stamp indicating when the matchmaking request stopped being processed due to
        /// successful completion, timeout, or cancellation. Format is a number expressed in Unix
        /// time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedWaitTime. 
        /// <para>
        /// Average amount of time (in seconds) that players are currently waiting for a match.
        /// If there is not enough recent data, this property may be empty.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? EstimatedWaitTime { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedWaitTime property is set.
        /// </summary>
        internal bool IsSetEstimatedWaitTime() => this.EstimatedWaitTime.HasValue;

        /// <summary>
        /// Gets and sets the property GameSessionConnectionInfo. 
        /// <para>
        /// Connection information for a new game session. Once a match is made, the FlexMatch
        /// engine creates a new game session for it. This information is added to the matchmaking
        /// ticket, which you can retrieve by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeMatchmaking.html">DescribeMatchmaking</a>
        /// .
        /// </para>
        /// </summary>
        public GameSessionConnectionInfo GameSessionConnectionInfo { get; set; }

        /// <summary>
        /// Checks to see if the GameSessionConnectionInfo property is set.
        /// </summary>
        internal bool IsSetGameSessionConnectionInfo() => this.GameSessionConnectionInfo != null;

        /// <summary>
        /// Gets and sets the property Players. 
        /// <para>
        /// A set of <c>Player</c> objects, each representing a player to find matches for. Players
        /// are identified by a unique player ID and may include latency data for use during matchmaking.
        /// If the ticket is in status <c>COMPLETED</c>, the <c>Player</c> objects include the
        /// team the players were assigned to in the resulting match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Player> Players { get; set; } = AWSConfigs.InitializeCollections ? new List<Player>() : null;

        /// <summary>
        /// Checks to see if the Players property is set.
        /// </summary>
        internal bool IsSetPlayers() => this.Players != null && (this.Players.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Time stamp indicating when this matchmaking request was received. Format is a number
        /// expressed in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the matchmaking request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>QUEUED</b> -- The matchmaking request has been received and is currently waiting
        /// to be processed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SEARCHING</b> -- The matchmaking request is currently being processed. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>REQUIRES_ACCEPTANCE</b> -- A match has been proposed and the players must accept
        /// the match. This status is used only with requests that use a matchmaking configuration
        /// with a player acceptance requirement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PLACING</b> -- The FlexMatch engine has matched players and is in the process
        /// of placing a new game session for the match.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>COMPLETED</b> -- Players have been matched and a game session is ready to host
        /// the players. A ticket in this state contains the necessary connection information
        /// for players.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAILED</b> -- The matchmaking request was not completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CANCELLED</b> -- The matchmaking request was canceled. This may be the result
        /// of a <c>StopMatchmaking</c> operation or a proposed match that one or more players
        /// failed to accept.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TIMED_OUT</b> -- The matchmaking request was not successful within the duration
        /// specified in the matchmaking configuration. 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Matchmaking requests that fail to successfully complete (statuses FAILED, CANCELLED,
        /// TIMED_OUT) can be resubmitted as new requests with new ticket IDs.
        /// </para>
        ///  </note>
        /// </summary>
        public MatchmakingConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Additional information about the current status.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Code to explain the current status. For example, a status reason may indicate when
        /// a ticket has returned to <c>SEARCHING</c> status after a proposed match fails to receive
        /// player acceptances.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property TicketId. 
        /// <para>
        /// A unique identifier for a matchmaking ticket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string TicketId { get; set; }

        /// <summary>
        /// Checks to see if the TicketId property is set.
        /// </summary>
        internal bool IsSetTicketId() => this.TicketId != null;
    }
}
