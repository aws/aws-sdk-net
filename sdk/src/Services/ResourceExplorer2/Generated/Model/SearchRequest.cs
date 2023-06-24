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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Container for the parameters to the Search operation.
    /// Searches for resources and displays details about all resources that match the specified
    /// criteria. You must specify a query string.
    /// 
    ///  
    /// <para>
    /// All search queries must use a view. If you don't explicitly specify a view, then Amazon
    /// Web Services Resource Explorer uses the default view for the Amazon Web Services Region
    /// in which you call this operation. The results are the logical intersection of the
    /// results that match both the <code>QueryString</code> parameter supplied to this operation
    /// and the <code>SearchFilter</code> parameter attached to the view.
    /// </para>
    ///  
    /// <para>
    /// For the complete syntax supported by the <code>QueryString</code> parameter, see <a
    /// href="https://docs.aws.amazon.com/resource-explorer/latest/APIReference/about-query-syntax.html">Search
    /// query syntax reference for Resource Explorer</a>.
    /// </para>
    ///  
    /// <para>
    /// If your search results are empty, or are missing results that you think should be
    /// there, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/troubleshooting_search.html">Troubleshooting
    /// Resource Explorer search</a>.
    /// </para>
    /// </summary>
    public partial class SearchRequest : AmazonResourceExplorer2Request
    {
        private int? _maxResults;
        private string _nextToken;
        private string _queryString;
        private string _viewArn;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that you want included on each page of the response.
        /// If you do not include this parameter, it defaults to a value appropriate to the operation.
        /// If additional items exist beyond those included in the current response, the <code>NextToken</code>
        /// response element is present and has a value (is not null). Include that value as the
        /// <code>NextToken</code> request parameter in the next call to the operation to get
        /// the next part of the results.
        /// </para>
        ///  <note> 
        /// <para>
        /// An API operation can return fewer results than the maximum even when there are more
        /// results available. You should check <code>NextToken</code> after every operation to
        /// ensure that you receive all of the results.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// The parameter for receiving additional results if you receive a <code>NextToken</code>
        /// response in a previous request. A <code>NextToken</code> response indicates that more
        /// output is available. Set this parameter to the value of the previous call's <code>NextToken</code>
        /// response to indicate where the output should continue from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property QueryString. 
        /// <para>
        /// A string that includes keywords and filters that specify the resources that you want
        /// to include in the results.
        /// </para>
        ///  
        /// <para>
        /// For the complete syntax supported by the <code>QueryString</code> parameter, see <a
        /// href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/using-search-query-syntax.html">Search
        /// query syntax reference for Resource Explorer</a>.
        /// </para>
        ///  
        /// <para>
        /// The search is completely case insensitive. You can specify an empty string to return
        /// all results up to the limit of 1,000 total results.
        /// </para>
        ///  <note> 
        /// <para>
        /// The operation can return only the first 1,000 results. If the resource you want is
        /// not included, then use a different value for <code>QueryString</code> to refine the
        /// results.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=1011)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

        /// <summary>
        /// Gets and sets the property ViewArn. 
        /// <para>
        /// Specifies the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of the view to use for the query. If you don't specify a value
        /// for this parameter, then the operation automatically uses the default view for the
        /// Amazon Web Services Region in which you called this operation. If the Region either
        /// doesn't have a default view or if you don't have permission to use the default view,
        /// then the operation fails with a <code>401 Unauthorized</code> exception.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string ViewArn
        {
            get { return this._viewArn; }
            set { this._viewArn = value; }
        }

        // Check to see if ViewArn property is set
        internal bool IsSetViewArn()
        {
            return this._viewArn != null;
        }

    }
}