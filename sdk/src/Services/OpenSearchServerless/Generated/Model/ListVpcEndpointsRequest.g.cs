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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Container for the parameters to the ListVpcEndpoints operation. Returns the OpenSearch
    /// Serverless-managed interface VPC endpoints associated with the current account. For
    /// more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
    /// Amazon OpenSearch Serverless using an interface endpoint</a>.
    /// </summary>
    public partial class ListVpcEndpointsRequest : AmazonOpenSearchServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// An optional parameter that specifies the maximum number of results to return. You
        /// can use <c>nextToken</c> to get the next page of results. The default is 20.
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
        /// If your initial <c>ListVpcEndpoints</c> operation returns a <c>nextToken</c>, you
        /// can include the returned <c>nextToken</c> in subsequent <c>ListVpcEndpoints</c> operations,
        /// which returns results in the next page. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointFilters. 
        /// <para>
        /// Filter the results according to the current status of the VPC endpoint. Possible statuses
        /// are <c>CREATING</c>, <c>DELETING</c>, <c>UPDATING</c>, <c>ACTIVE</c>, and <c>FAILED</c>.
        /// </para>
        /// </summary>
        public VpcEndpointFilters VpcEndpointFilters { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointFilters property is set.
        /// </summary>
        internal bool IsSetVpcEndpointFilters() => this.VpcEndpointFilters != null;
    }
}
