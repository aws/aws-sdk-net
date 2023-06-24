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
    /// Ticket generated to track the progress of a matchmaking request. Each ticket is uniquely
    /// identified by a ticket ID, supplied by the requester, when creating a matchmaking
    /// request.
    /// </summary>
    public partial class MatchmakingTicket
    {
        private string _configurationArn;
        private string _configurationName;
        private DateTime? _endTime;
        private int? _estimatedWaitTime;
        private GameSessionConnectionInfo _gameSessionConnectionInfo;
        private List<Player> _players = new List<Player>();
        private DateTime? _startTime;
        private MatchmakingConfigurationStatus _status;
        private string _statusMessage;
        private string _statusReason;
        private string _ticketId;

        /// <summary>
        /// Gets and sets the property ConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// associated with the GameLift matchmaking configuration resource that is used with
        /// this ticket.
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
        /// Gets and sets the property ConfigurationName. 
        /// <para>
        /// Name of the matchmaking configuration that is used with this ticket. Matchmaking configurations
        /// determine how players are grouped into a match and how a new game session is created
        /// for the match.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string ConfigurationName
        {
            get { return this._configurationName; }
            set { this._configurationName = value; }
        }

        // Check to see if ConfigurationName property is set
        internal bool IsSetConfigurationName()
        {
            return this._configurationName != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Time stamp indicating when the matchmaking request stopped being processed due to
        /// successful completion, timeout, or cancellation. Format is a number expressed in Unix
        /// time as milliseconds (for example <code>"1469498468.057"</code>).
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedWaitTime. 
        /// <para>
        /// Average amount of time (in seconds) that players are currently waiting for a match.
        /// If there is not enough recent data, this property may be empty.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int EstimatedWaitTime
        {
            get { return this._estimatedWaitTime.GetValueOrDefault(); }
            set { this._estimatedWaitTime = value; }
        }

        // Check to see if EstimatedWaitTime property is set
        internal bool IsSetEstimatedWaitTime()
        {
            return this._estimatedWaitTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GameSessionConnectionInfo. 
        /// <para>
        /// Connection information for a new game session. Once a match is made, the FlexMatch
        /// engine creates a new game session for it. This information is added to the matchmaking
        /// ticket, which you can be retrieve by calling <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeMatchmaking.html">DescribeMatchmaking</a>
        /// .
        /// </para>
        /// </summary>
        public GameSessionConnectionInfo GameSessionConnectionInfo
        {
            get { return this._gameSessionConnectionInfo; }
            set { this._gameSessionConnectionInfo = value; }
        }

        // Check to see if GameSessionConnectionInfo property is set
        internal bool IsSetGameSessionConnectionInfo()
        {
            return this._gameSessionConnectionInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Players. 
        /// <para>
        /// A set of <code>Player</code> objects, each representing a player to find matches for.
        /// Players are identified by a unique player ID and may include latency data for use
        /// during matchmaking. If the ticket is in status <code>COMPLETED</code>, the <code>Player</code>
        /// objects include the team the players were assigned to in the resulting match.
        /// </para>
        /// </summary>
        public List<Player> Players
        {
            get { return this._players; }
            set { this._players = value; }
        }

        // Check to see if Players property is set
        internal bool IsSetPlayers()
        {
            return this._players != null && this._players.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Time stamp indicating when this matchmaking request was received. Format is a number
        /// expressed in Unix time as milliseconds (for example <code>"1469498468.057"</code>).
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

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
        /// of a <code>StopMatchmaking</code> operation or a proposed match that one or more players
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
        public MatchmakingConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Additional information about the current status.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Code to explain the current status. For example, a status reason may indicate when
        /// a ticket has returned to <code>SEARCHING</code> status after a proposed match fails
        /// to receive player acceptances.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property TicketId. 
        /// <para>
        /// A unique identifier for a matchmaking ticket.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string TicketId
        {
            get { return this._ticketId; }
            set { this._ticketId = value; }
        }

        // Check to see if TicketId property is set
        internal bool IsSetTicketId()
        {
            return this._ticketId != null;
        }

    }
}