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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ListDocuments operation.
    /// Returns all Systems Manager (SSM) documents in the current Amazon Web Services account
    /// and Amazon Web Services Region. You can limit the results of this request by using
    /// a filter.
    /// </summary>
    public partial class ListDocumentsRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<DocumentFilter> _documentFilterList = new List<DocumentFilter>();
        private List<DocumentKeyValuesFilter> _filters = new List<DocumentKeyValuesFilter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListDocumentsRequest() { }

        /// <summary>
        /// Instantiates ListDocumentsRequest with the parameterized properties
        /// </summary>
        /// <param name="documentFilterList">This data type is deprecated. Instead, use <code>Filters</code>.</param>
        public ListDocumentsRequest(List<DocumentFilter> documentFilterList)
        {
            _documentFilterList = documentFilterList;
        }

        /// <summary>
        /// Gets and sets the property DocumentFilterList. 
        /// <para>
        /// This data type is deprecated. Instead, use <code>Filters</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<DocumentFilter> DocumentFilterList
        {
            get { return this._documentFilterList; }
            set { this._documentFilterList = value; }
        }

        // Check to see if DocumentFilterList property is set
        internal bool IsSetDocumentFilterList()
        {
            return this._documentFilterList != null && this._documentFilterList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more <code>DocumentKeyValuesFilter</code> objects. Use a filter to return a
        /// more specific list of results. For keys, you can specify one or more key-value pair
        /// tags that have been applied to a document. Other valid keys include <code>Owner</code>,
        /// <code>Name</code>, <code>PlatformTypes</code>, <code>DocumentType</code>, and <code>TargetType</code>.
        /// For example, to return documents you own use <code>Key=Owner,Values=Self</code>. To
        /// specify a custom key-value pair, use the format <code>Key=tag:tagName,Values=valueName</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation only supports filtering documents by using a single tag key and
        /// one or more tag values. For example: <code>Key=tag:tagName,Values=valueName1,valueName2</code>
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=6)]
        public List<DocumentKeyValuesFilter> Filters
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
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
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