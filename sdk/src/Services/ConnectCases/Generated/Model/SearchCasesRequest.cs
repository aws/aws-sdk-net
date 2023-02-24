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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Container for the parameters to the SearchCases operation.
    /// Searches for cases within their associated Cases domain. Search results are returned
    /// as a paginated list of abridged case documents.
    /// 
    ///  <note> 
    /// <para>
    /// For <code>customer_id</code> you must provide the full customer profile ARN in this
    /// format: <code> arn:aws:profile:your AWS Region:your AWS account ID:domains/profiles
    /// domain name/profiles/profile ID</code>. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SearchCasesRequest : AmazonConnectCasesRequest
    {
        private string _domainId;
        private List<FieldIdentifier> _fields = new List<FieldIdentifier>();
        private CaseFilter _filter;
        private int? _maxResults;
        private string _nextToken;
        private string _searchTerm;
        private List<Sort> _sorts = new List<Sort>();

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The unique identifier of the Cases domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The list of field identifiers to be returned as part of the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<FieldIdentifier> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && this._fields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// A list of filter objects.
        /// </para>
        /// </summary>
        public CaseFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of cases to return. The current maximum supported value is 25.
        /// This is also the default value when no other value is provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
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
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=9000)]
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
        /// Gets and sets the property SearchTerm. 
        /// <para>
        /// A word or phrase used to perform a quick search.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string SearchTerm
        {
            get { return this._searchTerm; }
            set { this._searchTerm = value; }
        }

        // Check to see if SearchTerm property is set
        internal bool IsSetSearchTerm()
        {
            return this._searchTerm != null;
        }

        /// <summary>
        /// Gets and sets the property Sorts. 
        /// <para>
        /// A list of sorts where each sort specifies a field and their sort order to be applied
        /// to the results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<Sort> Sorts
        {
            get { return this._sorts; }
            set { this._sorts = value; }
        }

        // Check to see if Sorts property is set
        internal bool IsSetSorts()
        {
            return this._sorts != null && this._sorts.Count > 0; 
        }

    }
}