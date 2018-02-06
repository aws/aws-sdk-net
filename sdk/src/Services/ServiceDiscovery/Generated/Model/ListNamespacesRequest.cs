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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceDiscovery.Model
{
    /// <summary>
    /// Container for the parameters to the ListNamespaces operation.
    /// Lists summary information about the namespaces that were created by the current AWS
    /// account.
    /// </summary>
    public partial class ListNamespacesRequest : AmazonServiceDiscoveryRequest
    {
        private List<NamespaceFilter> _filters = new List<NamespaceFilter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A complex type that contains specifications for the namespaces that you want to list.
        /// </para>
        ///  
        /// <para>
        /// If you specify more than one filter, a namespace must match all filters to be returned
        /// by <code>ListNamespaces</code>.
        /// </para>
        /// </summary>
        public List<NamespaceFilter> Filters
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
        /// The maximum number of namespaces that you want Amazon Route 53 to return in the response
        /// to a <code>ListNamespaces</code> request. If you don't specify a value for <code>MaxResults</code>,
        /// Route 53 returns up to 100 namespaces.
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
        /// For the first <code>ListNamespaces</code> request, omit this value.
        /// </para>
        ///  
        /// <para>
        /// If the response contains <code>NextToken</code>, submit another <code>ListNamespaces</code>
        /// request to get the next group of results. Specify the value of <code>NextToken</code>
        /// from the previous response in the next request.
        /// </para>
        ///  <note> 
        /// <para>
        /// Route 53 gets <code>MaxResults</code> namespaces and then filters them based on the
        /// specified criteria. It's possible that no namespaces in the first <code>MaxResults</code>
        /// namespaces matched the specified criteria but that subsequent groups of <code>MaxResults</code>
        /// namespaces do contain namespaces that match the criteria.
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