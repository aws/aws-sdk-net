/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the StopMatchmaking operation.
    /// Cancels a matchmaking ticket that is currently being processed. To stop the matchmaking
    /// operation, specify the ticket ID. If successful, work on the ticket is stopped, and
    /// the ticket status is changed to <code>CANCELLED</code>.
    /// 
    ///  
    /// <para>
    /// Matchmaking-related operations include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>StartMatchmaking</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeMatchmaking</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StopMatchmaking</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>AcceptMatch</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartMatchBackfill</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StopMatchmakingRequest : AmazonGameLiftRequest
    {
        private string _ticketId;

        /// <summary>
        /// Gets and sets the property TicketId. 
        /// <para>
        /// Unique identifier for a matchmaking ticket.
        /// </para>
        /// </summary>
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