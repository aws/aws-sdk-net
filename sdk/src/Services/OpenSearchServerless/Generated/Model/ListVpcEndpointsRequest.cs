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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Container for the parameters to the ListVpcEndpoints operation.
    /// Returns the OpenSearch Serverless-managed interface VPC endpoints associated with
    /// the current account. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-vpc.html">Access
    /// Amazon OpenSearch Serverless using an interface endpoint</a>.
    /// </summary>
    public partial class ListVpcEndpointsRequest : AmazonOpenSearchServerlessRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private VpcEndpointFilters _vpcEndpointFilters;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// An optional parameter that specifies the maximum number of results to return. You
        /// can use <code>nextToken</code> to get the next page of results. The default is 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If your initial <code>ListVpcEndpoints</code> operation returns a <code>nextToken</code>,
        /// you can include the returned <code>nextToken</code> in subsequent <code>ListVpcEndpoints</code>
        /// operations, which returns results in the next page. 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointFilters. 
        /// <para>
        /// Filter the results according to the current status of the VPC endpoint. Possible statuses
        /// are <code>CREATING</code>, <code>DELETING</code>, <code>UPDATING</code>, <code>ACTIVE</code>,
        /// and <code>FAILED</code>.
        /// </para>
        /// </summary>
        public VpcEndpointFilters VpcEndpointFilters
        {
            get { return this._vpcEndpointFilters; }
            set { this._vpcEndpointFilters = value; }
        }

        // Check to see if VpcEndpointFilters property is set
        internal bool IsSetVpcEndpointFilters()
        {
            return this._vpcEndpointFilters != null;
        }

    }
}