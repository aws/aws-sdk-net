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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the RejectPortfolioShare operation. Rejects an offer
    /// to share the specified portfolio.
    /// </summary>
    public partial class RejectPortfolioShareRequest : AmazonServiceCatalogRequest
    {
        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>jp</c> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh</c> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Checks to see if the AcceptLanguage property is set.
        /// </summary>
        internal bool IsSetAcceptLanguage() => this.AcceptLanguage != null;

        /// <summary>
        /// Gets and sets the property PortfolioId. 
        /// <para>
        /// The portfolio identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// Checks to see if the PortfolioId property is set.
        /// </summary>
        internal bool IsSetPortfolioId() => this.PortfolioId != null;

        /// <summary>
        /// Gets and sets the property PortfolioShareType. 
        /// <para>
        /// The type of shared portfolios to reject. The default is to reject imported portfolios.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS_ORGANIZATIONS</c> - Reject portfolios shared by the management account of
        /// your organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPORTED</c> - Reject imported portfolios.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SERVICECATALOG</c> - Not supported. (Throws ResourceNotFoundException.)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, <c>aws servicecatalog reject-portfolio-share --portfolio-id "port-2qwzkwxt3y5fk"
        /// --portfolio-share-type AWS_ORGANIZATIONS</c> 
        /// </para>
        /// </summary>
        public PortfolioShareType PortfolioShareType { get; set; }

        /// <summary>
        /// Checks to see if the PortfolioShareType property is set.
        /// </summary>
        internal bool IsSetPortfolioShareType() => this.PortfolioShareType != null;
    }
}
