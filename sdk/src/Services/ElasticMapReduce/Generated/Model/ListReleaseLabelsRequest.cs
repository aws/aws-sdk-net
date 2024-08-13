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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ListReleaseLabels operation.
    /// Retrieves release labels of Amazon EMR services in the Region where the API is called.
    /// </summary>
    public partial class ListReleaseLabelsRequest : AmazonElasticMapReduceRequest
    {
        private ReleaseLabelFilter _filters;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters the results of the request. <c>Prefix</c> specifies the prefix of release
        /// labels to return. <c>Application</c> specifies the application (with/without version)
        /// of release labels to return.
        /// </para>
        /// </summary>
        public ReleaseLabelFilter Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Defines the maximum number of release labels to return in a single response. The default
        /// is <c>100</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// Specifies the next page of results. If <c>NextToken</c> is not specified, which is
        /// usually the case for the first request of ListReleaseLabels, the first page of results
        /// are determined by other filtering parameters or by the latest version. The <c>ListReleaseLabels</c>
        /// request fails if the identity (Amazon Web Services account ID) and all filtering parameters
        /// are different from the original request, or if the <c>NextToken</c> is expired or
        /// tampered with.
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