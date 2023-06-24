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
    /// Container for the parameters to the CreatePortfolioShare operation.
    /// Shares the specified portfolio with the specified account or organization node. Shares
    /// to an organization node can only be created by the management account of an organization
    /// or by a delegated administrator. You can share portfolios to an organization, an organizational
    /// unit, or a specific account.
    /// 
    ///  
    /// <para>
    /// Note that if a delegated admin is de-registered, they can no longer create portfolio
    /// shares.
    /// </para>
    ///  
    /// <para>
    ///  <code>AWSOrganizationsAccess</code> must be enabled in order to create a portfolio
    /// share to an organization node.
    /// </para>
    ///  
    /// <para>
    /// You can't share a shared resource, including portfolios that contain a shared product.
    /// </para>
    ///  
    /// <para>
    /// If the portfolio share with the specified account or organization node already exists,
    /// this action will have no effect and will not return an error. To update an existing
    /// share, you must use the <code> UpdatePortfolioShare</code> API instead. 
    /// </para>
    ///  <note> 
    /// <para>
    /// When you associate a principal with portfolio, a potential privilege escalation path
    /// may occur when that portfolio is then shared with other accounts. For a user in a
    /// recipient account who is <i>not</i> an Service Catalog Admin, but still has the ability
    /// to create Principals (Users/Groups/Roles), that user could create a role that matches
    /// a principal name association for the portfolio. Although this user may not know which
    /// principal names are associated through Service Catalog, they may be able to guess
    /// the user. If this potential escalation path is a concern, then Service Catalog recommends
    /// using <code>PrincipalType</code> as <code>IAM</code>. With this configuration, the
    /// <code>PrincipalARN</code> must already exist in the recipient account before it can
    /// be associated. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePortfolioShareRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _accountId;
        private OrganizationNode _organizationNode;
        private string _portfolioId;
        private bool? _sharePrincipals;
        private bool? _shareTagOptions;

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
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID. For example, <code>123456789012</code>.
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
        /// <para>
        /// The organization node to whom you are going to share. When you pass <code>OrganizationNode</code>,
        /// it creates <code>PortfolioShare</code> for all of the Amazon Web Services accounts
        /// that are associated to the <code>OrganizationNode</code>. The output returns a <code>PortfolioShareToken</code>,
        /// which enables the administrator to monitor the status of the <code>PortfolioShare</code>
        /// creation process.
        /// </para>
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
        /// Gets and sets the property SharePrincipals. 
        /// <para>
        /// Enables or disables <code>Principal</code> sharing when creating the portfolio share.
        /// If this flag is not provided, principal sharing is disabled. 
        /// </para>
        ///  
        /// <para>
        /// When you enable Principal Name Sharing for a portfolio share, the share recipient
        /// account end users with a principal that matches any of the associated IAM patterns
        /// can provision products from the portfolio. Once shared, the share recipient can view
        /// associations of <code>PrincipalType</code>: <code>IAM_PATTERN</code> on their portfolio.
        /// You can create the principals in the recipient account before or after creating the
        /// share. 
        /// </para>
        /// </summary>
        public bool SharePrincipals
        {
            get { return this._sharePrincipals.GetValueOrDefault(); }
            set { this._sharePrincipals = value; }
        }

        // Check to see if SharePrincipals property is set
        internal bool IsSetSharePrincipals()
        {
            return this._sharePrincipals.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShareTagOptions. 
        /// <para>
        /// Enables or disables <code>TagOptions </code> sharing when creating the portfolio share.
        /// If this flag is not provided, TagOptions sharing is disabled.
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