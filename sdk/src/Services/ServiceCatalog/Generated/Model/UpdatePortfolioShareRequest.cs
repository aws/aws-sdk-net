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
    /// Container for the parameters to the UpdatePortfolioShare operation.
    /// Updates the specified portfolio share. You can use this API to enable or disable TagOptions
    /// sharing for an existing portfolio share. 
    /// 
    ///  
    /// <para>
    /// The portfolio share cannot be updated if the <code> CreatePortfolioShare</code> operation
    /// is <code>IN_PROGRESS</code>, as the share is not available to recipient entities.
    /// In this case, you must wait for the portfolio share to be COMPLETED.
    /// </para>
    ///  
    /// <para>
    /// You must provide the <code>accountId</code> or organization node in the input, but
    /// not both.
    /// </para>
    ///  
    /// <para>
    /// If the portfolio is shared to both an external account and an organization node, and
    /// both shares need to be updated, you must invoke <code>UpdatePortfolioShare</code>
    /// separately for each share type. 
    /// </para>
    ///  
    /// <para>
    /// This API cannot be used for removing the portfolio share. You must use <code>DeletePortfolioShare</code>
    /// API for that action. 
    /// </para>
    /// </summary>
    public partial class UpdatePortfolioShareRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _accountId;
        private OrganizationNode _organizationNode;
        private string _portfolioId;
        private bool? _shareTagOptions;

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>en</code> - English (default)
        /// </para>
        ///  </li> <li> 
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
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The AWS Account Id of the recipient account. This field is required when updating
        /// an external account to account type share.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationNode.
        /// </summary>
        public OrganizationNode OrganizationNode
        {
            get { return this._organizationNode; }
            set { this._organizationNode = value; }
        }

        // Check to see if OrganizationNode property is set
        internal bool IsSetOrganizationNode()
        {
            return this._organizationNode != null;
        }

        /// <summary>
        /// Gets and sets the property PortfolioId. 
        /// <para>
        /// The unique identifier of the portfolio for which the share will be updated.
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
        /// Gets and sets the property ShareTagOptions. 
        /// <para>
        /// A flag to enable or disable TagOptions sharing for the portfolio share. If this field
        /// is not provided, the current state of TagOptions sharing on the portfolio share will
        /// not be modified.
        /// </para>
        /// </summary>
        public bool ShareTagOptions
        {
            get { return this._shareTagOptions.GetValueOrDefault(); }
            set { this._shareTagOptions = value; }
        }

        // Check to see if ShareTagOptions property is set
        internal bool IsSetShareTagOptions()
        {
            return this._shareTagOptions.HasValue; 
        }

    }
}