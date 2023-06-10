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
    /// Container for the parameters to the ListOrganizationPortfolioAccess operation.
    /// Lists the organization nodes that have access to the specified portfolio. This API
    /// can only be called by the management account in the organization or by a delegated
    /// admin.
    /// 
    ///  
    /// <para>
    /// If a delegated admin is de-registered, they can no longer perform this operation.
    /// </para>
    /// </summary>
    public partial class ListOrganizationPortfolioAccessRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private OrganizationNodeType _organizationNodeType;
        private int? _pageSize;
        private string _pageToken;
        private string _portfolioId;

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
        /// Gets and sets the property OrganizationNodeType. 
        /// <para>
        /// The organization node type that will be returned in the output.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ORGANIZATION</code> - Organization that has access to the portfolio. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ORGANIZATIONAL_UNIT</code> - Organizational unit that has access to the portfolio
        /// within your organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACCOUNT</code> - Account that has access to the portfolio within your organization.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public OrganizationNodeType OrganizationNodeType
        {
            get { return this._organizationNodeType; }
            set { this._organizationNodeType = value; }
        }

        // Check to see if OrganizationNodeType property is set
        internal bool IsSetOrganizationNodeType()
        {
            return this._organizationNodeType != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of items to return with this call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
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
        /// Gets and sets the property PortfolioId. 
        /// <para>
        /// The portfolio identifier. For example, <code>port-2abcdext3y5fk</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string PortfolioId
        {
            get { return this._portfolioId; }
            set { this._portfolioId = value; }
        }

        // Check to see if PortfolioId property is set
        internal bool IsSetPortfolioId()
        {
            return this._portfolioId != null;
        }

    }
}