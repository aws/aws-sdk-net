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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeJobQueues operation.
    /// Describes one or more of your job queues.
    /// </summary>
    public partial class DescribeJobQueuesRequest : AmazonBatchRequest
    {
        private List<string> _jobQueues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property JobQueues. 
        /// <para>
        /// A list of up to 100 queue names or full queue Amazon Resource Name (ARN) entries.
        /// </para>
        /// </summary>
        public List<string> JobQueues
        {
            get { return this._jobQueues; }
            set { this._jobQueues = value; }
        }

        // Check to see if JobQueues property is set
        internal bool IsSetJobQueues()
        {
            return this._jobQueues != null && (this._jobQueues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results returned by <c>DescribeJobQueues</c> in paginated output.
        /// When this parameter is used, <c>DescribeJobQueues</c> only returns <c>maxResults</c>
        /// results in a single page and a <c>nextToken</c> response element. The remaining results
        /// of the initial request can be seen by sending another <c>DescribeJobQueues</c> request
        /// with the returned <c>nextToken</c> value. This value can be between 1 and 100. If
        /// this parameter isn't used, then <c>DescribeJobQueues</c> returns up to 100 results
        /// and a <c>nextToken</c> value if applicable.
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
        /// The <c>nextToken</c> value returned from a previous paginated <c>DescribeJobQueues</c>
        /// request where <c>maxResults</c> was used and the results exceeded the value of that
        /// parameter. Pagination continues from the end of the previous results that returned
        /// the <c>nextToken</c> value. This value is <c>null</c> when there are no more results
        /// to return.
        /// </para>
        ///  <note> 
        /// <para>
        /// Treat this token as an opaque identifier that's only used to retrieve the next items
        /// in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
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