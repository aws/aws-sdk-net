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

namespace Amazon.Detective.Model
{
    /// <summary>
    /// Container for the parameters to the ListMembers operation. Retrieves the list of member
    /// accounts for a behavior graph. <para> For invited accounts, the results do not include
    /// member accounts that were removed from the behavior graph. </para> <para> For the
    /// organization behavior graph, the results do not include organization accounts that
    /// the Detective administrator account has not enabled as member accounts. </para>
    /// </summary>
    public partial class ListMembersRequest : AmazonDetectiveRequest
    {
        /// <summary>
        /// Gets and sets the property GraphArn. 
        /// <para>
        /// The ARN of the behavior graph for which to retrieve the list of member accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GraphArn { get; set; }

        /// <summary>
        /// Checks to see if the GraphArn property is set.
        /// </summary>
        internal bool IsSetGraphArn() => this.GraphArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of member accounts to include in the response. The total must be
        /// less than the overall limit on the number of results to return, which is currently
        /// 200.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// For requests to retrieve the next page of member account results, the pagination token
        /// that was returned with the previous page of results. The initial request does not
        /// include a pagination token.
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
