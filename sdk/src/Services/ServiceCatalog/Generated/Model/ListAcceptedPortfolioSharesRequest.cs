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
    /// Container for the parameters to the ListAcceptedPortfolioShares operation.
    /// Lists all imported portfolios for which account-to-account shares were accepted by
    /// this account. By specifying the <code>PortfolioShareType</code>, you can list portfolios
    /// for which organizational shares were accepted by this account.
    /// </summary>
    public partial class ListAcceptedPortfolioSharesRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private int? _pageSize;
        private string _pageToken;
        private PortfolioShareType _portfolioShareType;

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>jp</code> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>zh</code> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=100)]
        public string AcceptLanguage
        {
            get { return this._acceptLanguage; }
            set { this._acceptLanguage = value; }
        }

        // Check to see if AcceptLanguage property is set
        internal bool IsSetAcceptLanguage()
        {
            return this._acceptLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of items to return with this call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int PageSize
        {
            get { return this._pageSize.GetValueOrDefault(); }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The page token for the next set of results. To retrieve the first set of results,
        /// use null.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2024)]
        public string PageToken
        {
            get { return this._pageToken; }
            set { this._pageToken = value; }
        }

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this._pageToken != null;
        }

        /// <summary>
        /// Gets and sets the property PortfolioShareType. 
        /// <para>
        /// The type of shared portfolios to list. The default is to list imported portfolios.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AWS_ORGANIZATIONS</code> - List portfolios accepted and shared via organizational
        /// sharing by the management account or delegated administrator of your organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS_SERVICECATALOG</code> - Deprecated type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IMPORTED</code> - List imported portfolios that have been accepted and shared
        /// through account-to-account sharing.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PortfolioShareType PortfolioShareType
        {
            get { return this._portfolioShareType; }
            set { this._portfolioShareType = value; }
        }

        // Check to see if PortfolioShareType property is set
        internal bool IsSetPortfolioShareType()
        {
            return this._portfolioShareType != null;
        }

    }
}