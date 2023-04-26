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
    /// Container for the parameters to the RejectPortfolioShare operation.
    /// Rejects an offer to share the specified portfolio.
    /// </summary>
    public partial class RejectPortfolioShareRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _portfolioId;
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
        /// Gets and sets the property PortfolioId. 
        /// <para>
        /// The portfolio identifier.
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

        /// <summary>
        /// Gets and sets the property PortfolioShareType. 
        /// <para>
        /// The type of shared portfolios to reject. The default is to reject imported portfolios.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AWS_ORGANIZATIONS</code> - Reject portfolios shared by the management account
        /// of your organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IMPORTED</code> - Reject imported portfolios.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS_SERVICECATALOG</code> - Not supported. (Throws ResourceNotFoundException.)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, <code>aws servicecatalog reject-portfolio-share --portfolio-id "port-2qwzkwxt3y5fk"
        /// --portfolio-share-type AWS_ORGANIZATIONS</code> 
        /// </para>
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