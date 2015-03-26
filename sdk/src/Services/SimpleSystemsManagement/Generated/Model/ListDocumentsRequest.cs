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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ListDocuments operation.
    /// Describes one or more of your configuration documents.
    /// </summary>
    public partial class ListDocumentsRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<DocumentFilter> _documentFilterList = new List<DocumentFilter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListDocumentsRequest() { }

        /// <summary>
        /// Instantiates ListDocumentsRequest with the parameterized properties
        /// </summary>
        /// <param name="documentFilterList">One or more filters. Use a filter to return a more specific list of results.</param>
        public ListDocumentsRequest(List<DocumentFilter> documentFilterList)
        {
            _documentFilterList = documentFilterList;
        }

        /// <summary>
        /// Gets and sets the property DocumentFilterList. 
        /// <para>
        /// One or more filters. Use a filter to return a more specific list of results.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
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