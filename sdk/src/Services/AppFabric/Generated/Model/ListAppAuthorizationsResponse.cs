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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
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
namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// This is the response object from the ListAppAuthorizations operation.
    /// </summary>
    public partial class ListAppAuthorizationsResponse : AmazonWebServiceResponse
    {
        private List<AppAuthorizationSummary> _appAuthorizationSummaryList = AWSConfigs.InitializeCollections ? new List<AppAuthorizationSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AppAuthorizationSummaryList. 
        /// <para>
        /// Contains a list of app authorization summaries.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AppAuthorizationSummary> AppAuthorizationSummaryList
        {
            get { return this._appAuthorizationSummaryList; }
            set { this._appAuthorizationSummaryList = value; }
        }

        // Check to see if AppAuthorizationSummaryList property is set
        internal bool IsSetAppAuthorizationSummaryList()
        {
            return this._appAuthorizationSummaryList != null && (this._appAuthorizationSummaryList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <c>nextToken</c> is returned, there are more results available. The value of <c>nextToken</c>
        /// is a unique pagination token for each page. Make the call again using the returned
        /// token to retrieve the next page. Keep all other arguments unchanged. Each pagination
        /// token expires after 24 hours. Using an expired pagination token will return an <i>HTTP
        /// 400 InvalidToken error</i>.
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

    }
}