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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the ListStoredQueries operation.
    /// </summary>
    public partial class ListStoredQueriesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<StoredQueryMetadata> _storedQueryMetadata = new List<StoredQueryMetadata>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous paginated request didn't return all of the remaining results, the
        /// response object's <code>NextToken</code> parameter value is set to a token. To retrieve
        /// the next set of results, call this action again and assign that token to the request
        /// object's <code>NextToken</code> parameter. If there are no remaining results, the
        /// previous response object's <code>NextToken</code> parameter is set to <code>null</code>.
        /// 
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
        /// Gets and sets the property StoredQueryMetadata. 
        /// <para>
        /// A list of <code>StoredQueryMetadata</code> objects.
        /// </para>
        /// </summary>
        public List<StoredQueryMetadata> StoredQueryMetadata
        {
            get { return this._storedQueryMetadata; }
            set { this._storedQueryMetadata = value; }
        }

        // Check to see if StoredQueryMetadata property is set
        internal bool IsSetStoredQueryMetadata()
        {
            return this._storedQueryMetadata != null && this._storedQueryMetadata.Count > 0; 
        }

    }
}