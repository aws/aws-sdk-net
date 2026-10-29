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
    /// Container for the parameters to the DescribeGameServerInstances operation. <b>This
    /// API works with the following fleet types:</b> EC2 (FleetIQ) <para> Retrieves status
    /// information about the Amazon EC2 instances associated with a Amazon GameLift Servers
    /// FleetIQ game server group. Use this operation to detect when instances are active
    /// or not available to host new game servers. </para> <para> To request status for all
    /// instances in the game server group, provide a game server group ID only. To request
    /// status for specific instances, provide the game server group ID and one or more instance
    /// IDs. Use the pagination parameters to retrieve results in sequential segments. If
    /// successful, a collection of <c>GameServerInstance</c> objects is returned. </para>
    /// <para> This operation is not designed to be called with every game server claim request;
    /// this practice can cause you to exceed your API limit, which results in errors. Instead,
    /// as a best practice, cache the results and refresh your cache no more than once every
    /// 10 seconds. </para> <para> <b>Learn more</b> </para> <para> <a href="https://docs.aws.amazon.com/gamelift/latest/fleetiqguide/gsg-intro.html">Amazon
    /// GameLift Servers FleetIQ Guide</a> </para>
    /// </summary>
    public partial class DescribeGameServerInstancesRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property GameServerGroupName. 
        /// <para>
        /// A unique identifier for the game server group. Use either the name or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string GameServerGroupName { get; set; }

        /// <summary>
        /// Checks to see if the GameServerGroupName property is set.
        /// </summary>
        internal bool IsSetGameServerGroupName() => this.GameServerGroupName != null;

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The Amazon EC2 instance IDs that you want to retrieve status on. Amazon EC2 instance
        /// IDs use a 17-character format, for example: <c>i-1234567890abcdef0</c>. To retrieve
        /// all instances in the game server group, leave this parameter empty. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> InstanceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceIds property is set.
        /// </summary>
        internal bool IsSetInstanceIds() => this.InstanceIds != null && (this.InstanceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <c>NextToken</c>
        /// to get results as a set of sequential pages.
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
        /// of the result set, do not specify a value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
