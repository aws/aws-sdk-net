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
    /// This is the response object from the GetPlayerConnectionDetails operation.
    /// </summary>
    public partial class GetPlayerConnectionDetailsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property GameSessionId. 
        /// <para>
        /// An identifier for the game session that is unique across all regions for which the
        /// player connection details were retrieved. The value is always a full ARN in the following
        /// format: For Home Region game session - <c>arn:aws:gamelift:&lt;home_region&gt;::gamesession/&lt;fleet
        /// ID&gt;/&lt;ID string&gt;</c>. For Remote Location game session - <c>arn:aws:gamelift:&lt;home_region&gt;::gamesession/&lt;fleet
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
        /// Gets and sets the property PlayerConnectionDetails. 
        /// <para>
        /// A collection of player connection detail objects, one for each requested player.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<PlayerConnectionDetail> PlayerConnectionDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<PlayerConnectionDetail>() : null;

        /// <summary>
        /// Checks to see if the PlayerConnectionDetails property is set.
        /// </summary>
        internal bool IsSetPlayerConnectionDetails() => this.PlayerConnectionDetails != null && (this.PlayerConnectionDetails.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
