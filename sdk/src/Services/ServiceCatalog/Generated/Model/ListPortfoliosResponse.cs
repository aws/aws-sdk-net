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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the ListPortfolios operation.
    /// </summary>
    public partial class ListPortfoliosResponse : AmazonWebServiceResponse
    {
        private string _nextPageToken;
        private List<PortfolioDetail> _portfolioDetails = new List<PortfolioDetail>();

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The page token to use to retrieve the next set of results. If there are no additional
        /// results, this value is null.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PortfolioDetails. 
        /// <para>
        /// Information about the portfolios.
        /// </para>
        /// </summary>
        public List<PortfolioDetail> PortfolioDetails
        {
            get { return this._portfolioDetails; }
            set { this._portfolioDetails = value; }
        }

        // Check to see if PortfolioDetails property is set
        internal bool IsSetPortfolioDetails()
        {
            return this._portfolioDetails != null && this._portfolioDetails.Count > 0; 
        }

    }
}