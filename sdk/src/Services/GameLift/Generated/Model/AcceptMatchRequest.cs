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
    /// Container for the parameters to the AcceptMatch operation.
    /// Registers a player's acceptance or rejection of a proposed FlexMatch match. A matchmaking
    /// configuration may require player acceptance; if so, then matches built with that configuration
    /// cannot be completed unless all players accept the proposed match within a specified
    /// time limit. 
    /// 
    ///  
    /// <para>
    /// When FlexMatch builds a match, all the matchmaking tickets involved in the proposed
    /// match are placed into status <code>REQUIRES_ACCEPTANCE</code>. This is a trigger for
    /// your game to get acceptance from all players in each ticket. Calls to this action
    /// are only valid for tickets that are in this status; calls for tickets not in this
    /// status result in an error.
    /// </para>
    ///  
    /// <para>
    /// To register acceptance, specify the ticket ID, one or more players, and an acceptance
    /// response. When all players have accepted, Amazon GameLift advances the matchmaking
    /// tickets to status <code>PLACING</code>, and attempts to create a new game session
    /// for the match. 
    /// </para>
    ///  
    /// <para>
    /// If any player rejects the match, or if acceptances are not received before a specified
    /// timeout, the proposed match is dropped. Each matchmaking ticket in the failed match
    /// is handled as follows: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the ticket has one or more players who rejected the match or failed to respond,
    /// the ticket status is set <code>CANCELLED</code> and processing is terminated.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If all players in the ticket accepted the match, the ticket status is returned to
    /// <code>SEARCHING</code> to find a new match. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-client.html">
    /// Add FlexMatch to a game client</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-events.html">
    /// FlexMatch events</a> (reference)
    /// </para>
    /// </summary>
    public partial class AcceptMatchRequest : AmazonGameLiftRequest
    {
        private AcceptanceType _acceptanceType;
        private List<string> _playerIds = new List<string>();
        private string _ticketId;

        /// <summary>
        /// Gets and sets the property AcceptanceType. 
        /// <para>
        /// Player response to the proposed match.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AcceptanceType AcceptanceType
        {
            get { return this._acceptanceType; }
            set { this._acceptanceType = value; }
        }

        // Check to see if AcceptanceType property is set
        internal bool IsSetAcceptanceType()
        {
            return this._acceptanceType != null;
        }

        /// <summary>
        /// Gets and sets the property PlayerIds. 
        /// <para>
        /// A unique identifier for a player delivering the response. This parameter can include
        /// one or multiple player IDs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> PlayerIds
        {
            get { return this._playerIds; }
            set { this._playerIds = value; }
        }

        // Check to see if PlayerIds property is set
        internal bool IsSetPlayerIds()
        {
            return this._playerIds != null && this._playerIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TicketId. 
        /// <para>
        /// A unique identifier for a matchmaking ticket. The ticket must be in status <code>REQUIRES_ACCEPTANCE</code>;
        /// otherwise this request will fail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
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