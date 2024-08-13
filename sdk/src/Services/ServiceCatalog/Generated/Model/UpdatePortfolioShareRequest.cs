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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePortfolioShare operation.
    /// Updates the specified portfolio share. You can use this API to enable or disable <c>TagOptions</c>
    /// sharing or Principal sharing for an existing portfolio share. 
    /// 
    ///  
    /// <para>
    /// The portfolio share cannot be updated if the <c>CreatePortfolioShare</c> operation
    /// is <c>IN_PROGRESS</c>, as the share is not available to recipient entities. In this
    /// case, you must wait for the portfolio share to be completed.
    /// </para>
    ///  
    /// <para>
    /// You must provide the <c>accountId</c> or organization node in the input, but not both.
    /// </para>
    ///  
    /// <para>
    /// If the portfolio is shared to both an external account and an organization node, and
    /// both shares need to be updated, you must invoke <c>UpdatePortfolioShare</c> separately
    /// for each share type. 
    /// </para>
    ///  
    /// <para>
    /// This API cannot be used for removing the portfolio share. You must use <c>DeletePortfolioShare</c>
    /// API for that action. 
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
    /// using <c>PrincipalType</c> as <c>IAM</c>. With this configuration, the <c>PrincipalARN</c>
    /// must already exist in the recipient account before it can be associated. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdatePortfolioShareRequest : AmazonServiceCatalogRequest
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
        ///  <c>jp</c> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh</c> - Chinese
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
        /// The Amazon Web Services account Id of the recipient account. This field is required
        /// when updating an external account to account type share.
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
        /// Gets and sets the property SharePrincipals. 
        /// <para>
        /// A flag to enables or disables <c>Principals</c> sharing in the portfolio. If this
        /// field is not provided, the current state of the <c>Principals</c> sharing on the portfolio
        /// share will not be modified. 
        /// </para>
        /// </summary>
        public bool? SharePrincipals
        {
            get { return this._sharePrincipals; }
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
        /// Enables or disables <c>TagOptions</c> sharing for the portfolio share. If this field
        /// is not provided, the current state of TagOptions sharing on the portfolio share will
        /// not be modified.
        /// </para>
        /// </summary>
        public bool? ShareTagOptions
        {
            get { return this._shareTagOptions; }
            set { this._shareTagOptions = value; }
        }

        // Check to see if ShareTagOptions property is set
        internal bool IsSetShareTagOptions()
        {
            return this._shareTagOptions.HasValue; 
        }

    }
}