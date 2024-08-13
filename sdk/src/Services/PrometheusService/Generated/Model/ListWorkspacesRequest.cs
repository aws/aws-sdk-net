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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Container for the parameters to the ListWorkspaces operation.
    /// Lists all of the Amazon Managed Service for Prometheus workspaces in your account.
    /// This includes workspaces being created or deleted.
    /// </summary>
    public partial class ListWorkspacesRequest : AmazonPrometheusServiceRequest
    {
        private string _alias;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// If this is included, it filters the results to only the workspaces with names that
        /// start with the value that you specify here.
        /// </para>
        ///  
        /// <para>
        /// Amazon Managed Service for Prometheus will automatically strip any blank spaces from
        /// the beginning and end of the alias that you specify.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of workspaces to return per request. The default is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// The token for the next set of items to return. You receive this token from a previous
        /// call, and use it to get the next page of results. The other parameters must be the
        /// same as the initial call.
        /// </para>
        ///  
        /// <para>
        /// For example, if your initial request has <c>maxResults</c> of 10, and there are 12
        /// workspaces to return, then your initial request will return 10 and a <c>nextToken</c>.
        /// Using the next token in a subsequent call will return the remaining 2 workspaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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