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
    /// Container for the parameters to the DescribePlayerSessions operation. <b>This API
    /// works with the following fleet types:</b> EC2, Anywhere, Container <para> Retrieves
    /// properties for one or more player sessions. </para> <para> This action can be used
    /// in the following ways: </para> <ul> <li> <para> To retrieve a specific player session,
    /// provide the player session ID only. </para> </li> <li> <para> To retrieve all player
    /// sessions in a game session, provide the game session ID only. </para> </li> <li> <para>
    /// To retrieve all player sessions for a specific player, provide a player ID only. </para>
    /// </li> </ul> <para> To request player sessions, specify either a player session ID,
    /// game session ID, or player ID. You can filter this request by player session status.
    /// If you provide a specific <c>PlayerSessionId</c> or <c>PlayerId</c>, Amazon GameLift
    /// Servers ignores the filter criteria. Use the pagination parameters to retrieve results
    /// as a set of sequential pages. </para> <para> If successful, a <c>PlayerSession</c>
    /// object is returned for each session that matches the request. </para> <para> <b>Related
    /// actions</b> </para> <para> <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> </para>
    /// </summary>
    public partial class DescribePlayerSessionsRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// An identifier for the game session that is unique across all regions to retrieve player
        /// sessions for. The value is always a full ARN in the following format: For Home Region
        /// game session - <c>arn:aws:gamelift:&lt;home_region&gt;::gamesession/&lt;fleet ID&gt;/&lt;ID
        /// string&gt;</c>. For Remote Location game session - <c>arn:aws:gamelift:&lt;home_region&gt;::gamesession/&lt;fleet
        /// ID&gt;/&lt;location&gt;/&lt;ID string&gt;</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string GameSessionId { get; set; }

        /// <summary>
        /// Checks to see if the GameSessionId property is set.
        /// </summary>
        internal bool IsSetGameSessionId() => this.GameSessionId != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <c>NextToken</c>
        /// to get results as a set of sequential pages. If a player session ID is specified,
        /// this parameter is ignored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this operation. To start at the beginning
        /// of the result set, do not specify a value. If a player session ID is specified, this
        /// parameter is ignored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PlayerId. 
        /// <para>
        /// A unique identifier for a player to retrieve player sessions for.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string PlayerId { get; set; }

        /// <summary>
        /// Checks to see if the PlayerId property is set.
        /// </summary>
        internal bool IsSetPlayerId() => this.PlayerId != null;

        /// <summary>
        /// Gets and sets the property PlayerSessionId. 
        /// <para>
        /// A unique identifier for a player session to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PlayerSessionId { get; set; }

        /// <summary>
        /// Checks to see if the PlayerSessionId property is set.
        /// </summary>
        internal bool IsSetPlayerSessionId() => this.PlayerSessionId != null;

        /// <summary>
        /// Gets and sets the property PlayerSessionStatusFilter. 
        /// <para>
        /// Player session status to filter results on. Note that when a PlayerSessionId or PlayerId
        /// is provided in a DescribePlayerSessions request, then the PlayerSessionStatusFilter
        /// has no effect on the response.
        /// </para>
        ///  
        /// <para>
        /// Possible player session statuses include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>RESERVED</b> -- The player session request has been received, but the player has
        /// not yet connected to the server process and/or been validated. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ACTIVE</b> -- The player has been validated by the server process and is currently
        /// connected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>COMPLETED</b> -- The player connection has been dropped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>TIMEDOUT</b> -- A player session request was received, but the player did not
        /// connect and/or was not validated within the timeout limit (60 seconds).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string PlayerSessionStatusFilter { get; set; }

        /// <summary>
        /// Checks to see if the PlayerSessionStatusFilter property is set.
        /// </summary>
        internal bool IsSetPlayerSessionStatusFilter() => this.PlayerSessionStatusFilter != null;
    }
}
