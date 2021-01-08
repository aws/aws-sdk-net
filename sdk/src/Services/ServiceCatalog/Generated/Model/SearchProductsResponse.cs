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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the SearchProducts operation.
    /// </summary>
    public partial class SearchProductsResponse : AmazonWebServiceResponse
    {
        private string _nextPageToken;
        private Dictionary<string, List<ProductViewAggregationValue>> _productViewAggregations = new Dictionary<string, List<ProductViewAggregationValue>>();
        private List<ProductViewSummary> _productViewSummaries = new List<ProductViewSummary>();

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The page token to use to retrieve the next set of results. If there are no additional
        /// results, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2024)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProductViewAggregations. 
        /// <para>
        /// The product view aggregations.
        /// </para>
        /// </summary>
        public Dictionary<string, List<ProductViewAggregationValue>> ProductViewAggregations
        {
            get { return this._productViewAggregations; }
            set { this._productViewAggregations = value; }
        }

        // Check to see if ProductViewAggregations property is set
        internal bool IsSetProductViewAggregations()
        {
            return this._productViewAggregations != null && this._productViewAggregations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProductViewSummaries. 
        /// <para>
        /// Information about the product views.
        /// </para>
        /// </summary>
        public List<ProductViewSummary> ProductViewSummaries
        {
            get { return this._productViewSummaries; }
            set { this._productViewSummaries = value; }
        }

        // Check to see if ProductViewSummaries property is set
        internal bool IsSetProductViewSummaries()
        {
            return this._productViewSummaries != null && this._productViewSummaries.Count > 0; 
        }

    }
}