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
    /// Information about a player session. This object contains only the player ID and player
    /// session ID. To retrieve full details on a player session, call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribePlayerSessions.html">DescribePlayerSessions</a>
    /// with the player session ID.
    /// </summary>
    public partial class PlacedPlayerSession
    {
        /// <summary>
        /// Gets and sets the property PlayerId. 
        /// <para>
        /// A unique identifier for a player that is associated with this player session.
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
        /// A unique identifier for a player session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PlayerSessionId { get; set; }

        /// <summary>
        /// Checks to see if the PlayerSessionId property is set.
        /// </summary>
        internal bool IsSetPlayerSessionId() => this.PlayerSessionId != null;
    }
}
