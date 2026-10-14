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

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Container for the parameters to the ListAgents operation. Returns a list of DataSync
    /// agents that belong to an Amazon Web Services account in the Amazon Web Services Region
    /// specified in the request. <para> With pagination, you can reduce the number of agents
    /// returned in a response. If you get a truncated list of agents in a response, the response
    /// contains a marker that you can specify in your next request to fetch the next page
    /// of agents. </para> <para> <c>ListAgents</c> is eventually consistent. This means the
    /// result of running the operation might not reflect that you just created or deleted
    /// an agent. For example, if you create an agent with <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_CreateAgent.html">CreateAgent</a>
    /// and then immediately run <c>ListAgents</c>, that agent might not show up in the list
    /// right away. In situations like this, you can always confirm whether an agent has been
    /// created (or deleted) by using <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeAgent.html">DescribeAgent</a>.
    /// </para>
    /// </summary>
    public partial class ListAgentsRequest : AmazonDataSyncRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of DataSync agents to list in a response. By default,
        /// a response shows a maximum of 100 agents.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specifies an opaque string that indicates the position to begin the next list of results
        /// in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
