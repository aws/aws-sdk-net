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
    /// Container for the parameters to the DescribeMatchmaking operation.
    /// Retrieves one or more matchmaking tickets. Use this operation to retrieve ticket information,
    /// including--after a successful match is made--connection information for the resulting
    /// new game session. 
    /// 
    ///  
    /// <para>
    /// To request matchmaking tickets, provide a list of up to 10 ticket IDs. If the request
    /// is successful, a ticket object is returned for each requested ID that currently exists.
    /// </para>
    ///  
    /// <para>
    /// This operation is not designed to be continually called to track matchmaking ticket
    /// status. This practice can cause you to exceed your API limit, which results in errors.
    /// Instead, as a best practice, set up an Amazon Simple Notification Service to receive
    /// notifications, and provide the topic ARN in the matchmaking configuration.
    /// </para>
    ///   
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
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/flexmatchguide/match-notification.html">
    /// Set Up FlexMatch event notification</a> 
    /// </para>
    /// </summary>
    public partial class DescribeMatchmakingRequest : AmazonGameLiftRequest
    {
        private List<string> _ticketIds = new List<string>();

        /// <summary>
        /// Gets and sets the property TicketIds. 
        /// <para>
        /// A unique identifier for a matchmaking ticket. You can include up to 10 ID values.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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