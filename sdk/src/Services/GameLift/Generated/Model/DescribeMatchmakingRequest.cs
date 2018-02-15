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
    /// Container for the parameters to the DescribeMatchmaking operation.
    /// Retrieves one or more matchmaking tickets. Use this operation to retrieve ticket information,
    /// including status and--once a successful match is made--acquire connection information
    /// for the resulting new game session. 
    /// 
    ///  
    /// <para>
    /// You can use this operation to track the progress of matchmaking requests (through
    /// polling) as an alternative to using event notifications. See more details on tracking
    /// matchmaking requests through polling or notifications in <a>StartMatchmaking</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// To request matchmaking tickets, provide a list of up to 10 ticket IDs. If the request
    /// is successful, a ticket object is returned for each requested ID that currently exists.
    /// </para>
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
    public partial class DescribeMatchmakingRequest : AmazonGameLiftRequest
    {
        private List<string> _ticketIds = new List<string>();

        /// <summary>
        /// Gets and sets the property TicketIds. 
        /// <para>
        /// Unique identifier for a matchmaking ticket. You can include up to 10 ID values. 
        /// </para>
        /// </summary>
        public List<string> TicketIds
        {
            get { return this._ticketIds; }
            set { this._ticketIds = value; }
        }

        // Check to see if TicketIds property is set
        internal bool IsSetTicketIds()
        {
            return this._ticketIds != null && this._ticketIds.Count > 0; 
        }

    }
}