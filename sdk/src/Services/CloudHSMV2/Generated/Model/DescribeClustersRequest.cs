/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeClusters operation.
    /// Gets information about AWS CloudHSM clusters.
    /// 
    ///  
    /// <para>
    /// This is a paginated operation, which means that each response might contain only a
    /// subset of all the clusters. When the response contains only a subset of clusters,
    /// it includes a <code>NextToken</code> value. Use this value in a subsequent <code>DescribeClusters</code>
    /// request to get more clusters. When you receive a response with no <code>NextToken</code>
    /// (or an empty or null value), that means there are no more clusters to get.
    /// </para>
    /// </summary>
    public partial class DescribeClustersRequest : AmazonCloudHSMV2Request
    {
        private Dictionary<string, List<string>> _filters = new Dictionary<string, List<string>>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters to limit the items returned in the response.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>clusterIds</code> filter to return only the specified clusters. Specify
        /// clusters by their cluster identifier (ID).
        /// </para>
        ///  
        /// <para>
        /// Use the <code>vpcIds</code> filter to return only the clusters in the specified virtual
        /// private clouds (VPCs). Specify VPCs by their VPC identifier (ID).
        /// </para>
        ///  
        /// <para>
        /// Use the <code>states</code> filter to return only clusters that match the specified
        /// state.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of clusters to return in the response. When there are more clusters
        /// than the number you specify, the response contains a <code>NextToken</code> value.
        /// </para>
        /// </summary>
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
        /// The <code>NextToken</code> value that you received in the previous response. Use this
        /// value to get more clusters.
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

    }
}