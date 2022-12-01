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
    /// Container for the parameters to the StopMatchmaking operation.
    /// Cancels a matchmaking ticket or match backfill ticket that is currently being processed.
    /// To stop the matchmaking operation, specify the ticket ID. If successful, work on the
    /// ticket is stopped, and the ticket status is changed to <code>CANCELLED</code>.
    /// 
    ///  
    /// <para>
    /// This call is also used to turn off automatic backfill for an individual game session.
    /// This is for game sessions that are created with a matchmaking configuration that has
    /// automatic backfill enabled. The ticket ID is included in the <code>MatchmakerData</code>
    /// of an updated game session object, which is provided to the game server.
    /// </para>
    ///  <note> 
    /// <para>
    /// If the operation is successful, the service sends back an empty JSON struct with the
    /// HTTP 200 response (not an empty HTTP body).
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-client.html">
    /// Add FlexMatch to a game client</a> 
    /// </para>
    /// </summary>
    public partial class StopMatchmakingRequest : AmazonGameLiftRequest
    {
        private string _ticketId;

        /// <summary>
        /// Gets and sets the property TicketId. 
        /// <para>
        /// A unique identifier for a matchmaking ticket.
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