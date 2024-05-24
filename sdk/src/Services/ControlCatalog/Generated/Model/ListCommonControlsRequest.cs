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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the ListCommonControls operation.
    /// Returns a paginated list of common controls from the Amazon Web Services Control Catalog.
    /// 
    ///  
    /// <para>
    /// You can apply an optional filter to see common controls that have a specific objective.
    /// If you don’t provide a filter, the operation returns all common controls. 
    /// </para>
    /// </summary>
    public partial class ListCommonControlsRequest : AmazonControlCatalogRequest
    {
        private CommonControlFilter _commonControlFilter;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CommonControlFilter. 
        /// <para>
        /// An optional filter that narrows the results to a specific objective.
        /// </para>
        ///  
        /// <para>
        /// This filter allows you to specify one objective ARN at a time. Passing multiple ARNs
        /// in the <c>CommonControlFilter</c> isn’t currently supported.
        /// </para>
        /// </summary>
        public CommonControlFilter CommonControlFilter
        {
            get { return this._commonControlFilter; }
            set { this._commonControlFilter = value; }
        }

        // Check to see if CommonControlFilter property is set
        internal bool IsSetCommonControlFilter()
        {
            return this._commonControlFilter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results on a page or for an API request call.
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
        /// The pagination token that's used to fetch the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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