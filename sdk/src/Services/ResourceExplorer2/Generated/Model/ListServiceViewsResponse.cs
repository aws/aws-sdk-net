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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// This is the response object from the ListServiceViews operation.
    /// </summary>
    public partial class ListServiceViewsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _serviceViews = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use in a subsequent <c>ListServiceViews</c> request to retrieve
        /// the next set of results.
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
        /// Gets and sets the property ServiceViews. 
        /// <para>
        /// A list of Amazon Resource Names (ARNs) for the service views available in the current
        /// Amazon Web Services account.
        /// </para>
        /// </summary>
        public List<string> ServiceViews
        {
            get { return this._serviceViews; }
            set { this._serviceViews = value; }
        }

        // Check to see if ServiceViews property is set
        internal bool IsSetServiceViews()
        {
            return this._serviceViews != null && (this._serviceViews.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}