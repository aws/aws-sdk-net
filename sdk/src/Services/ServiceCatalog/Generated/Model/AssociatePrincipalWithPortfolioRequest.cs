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
    /// Container for the parameters to the AssociatePrincipalWithPortfolio operation.
    /// Associates the specified principal ARN with the specified portfolio.
    /// 
    ///  
    /// <para>
    /// If you share the portfolio with principal name sharing enabled, the <code>PrincipalARN</code>
    /// association is included in the share. 
    /// </para>
    ///  
    /// <para>
    /// The <code>PortfolioID</code>, <code>PrincipalARN</code>, and <code>PrincipalType</code>
    /// parameters are required. 
    /// </para>
    ///  
    /// <para>
    /// You can associate a maximum of 10 Principals with a portfolio using <code>PrincipalType</code>
    /// as <code>IAM_PATTERN</code> 
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
    public partial class AssociatePrincipalWithPortfolioRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _portfolioId;
        private string _principalARN;
        private PrincipalType _principalType;

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
        /// Gets and sets the property PrincipalARN. 
        /// <para>
        /// The ARN of the principal (user, role, or group). This field allows an ARN with no
        /// <code>accountID</code> if <code>PrincipalType</code> is <code>IAM_PATTERN</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can associate multiple <code>IAM</code> patterns even if the account has no principal
        /// with that name. This is useful in Principal Name Sharing if you want to share a principal
        /// without creating it in the account that owns the portfolio. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string PrincipalARN
        {
            get { return this._principalARN; }
            set { this._principalARN = value; }
        }

        // Check to see if PrincipalARN property is set
        internal bool IsSetPrincipalARN()
        {
            return this._principalARN != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalType. 
        /// <para>
        /// The principal type. The supported value is <code>IAM</code> if you use a fully defined
        /// ARN, or <code>IAM_PATTERN</code> if you use an ARN with no <code>accountID</code>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PrincipalType PrincipalType
        {
            get { return this._principalType; }
            set { this._principalType = value; }
        }

        // Check to see if PrincipalType property is set
        internal bool IsSetPrincipalType()
        {
            return this._principalType != null;
        }

    }
}