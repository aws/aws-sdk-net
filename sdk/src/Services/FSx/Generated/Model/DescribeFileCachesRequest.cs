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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFileCaches operation.
    /// Returns the description of a specific Amazon File Cache resource, if a <code>FileCacheIds</code>
    /// value is provided for that cache. Otherwise, it returns descriptions of all caches
    /// owned by your Amazon Web Services account in the Amazon Web Services Region of the
    /// endpoint that you're calling.
    /// 
    ///  
    /// <para>
    /// When retrieving all cache descriptions, you can optionally specify the <code>MaxResults</code>
    /// parameter to limit the number of descriptions in a response. If more cache descriptions
    /// remain, the operation returns a <code>NextToken</code> value in the response. In this
    /// case, send a later request with the <code>NextToken</code> request parameter set to
    /// the value of <code>NextToken</code> from the last response.
    /// </para>
    ///  
    /// <para>
    /// This operation is used in an iterative process to retrieve a list of your cache descriptions.
    /// <code>DescribeFileCaches</code> is called first without a <code>NextToken</code>value.
    /// Then the operation continues to be called with the <code>NextToken</code> parameter
    /// set to the value of the last <code>NextToken</code> value until a response has no
    /// <code>NextToken</code>.
    /// </para>
    ///  
    /// <para>
    /// When using this operation, keep the following in mind:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The implementation might return fewer than <code>MaxResults</code> cache descriptions
    /// while still including a <code>NextToken</code> value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The order of caches returned in the response of one <code>DescribeFileCaches</code>
    /// call and the order of caches returned across the responses of a multicall iteration
    /// is unspecified.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeFileCachesRequest : AmazonFSxRequest
    {
        private List<string> _fileCacheIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FileCacheIds. 
        /// <para>
        /// IDs of the caches whose descriptions you want to retrieve (String).
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> FileCacheIds
        {
            get { return this._fileCacheIds; }
            set { this._fileCacheIds = value; }
        }

        // Check to see if FileCacheIds property is set
        internal bool IsSetFileCacheIds()
        {
            return this._fileCacheIds != null && this._fileCacheIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
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
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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