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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkLink.Model
{
    /// <summary>
    /// This is the response object from the ListWebsiteAuthorizationProviders operation.
    /// </summary>
    public partial class ListWebsiteAuthorizationProvidersResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<WebsiteAuthorizationProviderSummary> _websiteAuthorizationProviders = new List<WebsiteAuthorizationProviderSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// If this value is null, it retrieves the first page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Gets and sets the property WebsiteAuthorizationProviders. 
        /// <para>
        /// The website authorization providers.
        /// </para>
        /// </summary>
        public List<WebsiteAuthorizationProviderSummary> WebsiteAuthorizationProviders
        {
            get { return this._websiteAuthorizationProviders; }
            set { this._websiteAuthorizationProviders = value; }
        }

        // Check to see if WebsiteAuthorizationProviders property is set
        internal bool IsSetWebsiteAuthorizationProviders()
        {
            return this._websiteAuthorizationProviders != null && this._websiteAuthorizationProviders.Count > 0; 
        }

    }
}