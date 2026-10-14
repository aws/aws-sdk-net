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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the ListCampaigns operation. Returns a list of campaigns
    /// that use the given solution. When a solution is not specified, all the campaigns associated
    /// with the account are listed. The response provides the properties for each campaign,
    /// including the Amazon Resource Name (ARN). For more information on campaigns, see <a
    /// href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateCampaign.html">CreateCampaign</a>.
    /// </summary>
    public partial class ListCampaignsRequest : AmazonPersonalizeRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of campaigns to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token returned from the previous call to <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListCampaigns.html">ListCampaigns</a>
        /// for getting the next set of campaigns (if they exist).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1500)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SolutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the solution to list the campaigns for. When a solution
        /// is not specified, all the campaigns associated with the account are listed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SolutionArn { get; set; }

        /// <summary>
        /// Checks to see if the SolutionArn property is set.
        /// </summary>
        internal bool IsSetSolutionArn() => this.SolutionArn != null;
    }
}
