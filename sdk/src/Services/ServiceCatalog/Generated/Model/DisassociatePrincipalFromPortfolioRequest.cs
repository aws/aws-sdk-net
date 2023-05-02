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
    /// Container for the parameters to the DisassociatePrincipalFromPortfolio operation.
    /// Disassociates a previously associated principal ARN from a specified portfolio.
    /// 
    ///  
    /// <para>
    /// The <code>PrincipalType</code> and <code>PrincipalARN</code> must match the <code>AssociatePrincipalWithPortfolio</code>
    /// call request details. For example, to disassociate an association created with a <code>PrincipalARN</code>
    /// of <code>PrincipalType</code> IAM you must use the <code>PrincipalType</code> IAM
    /// when calling <code>DisassociatePrincipalFromPortfolio</code>. 
    /// </para>
    ///  
    /// <para>
    /// For portfolios that have been shared with principal name sharing enabled: after disassociating
    /// a principal, share recipient accounts will no longer be able to provision products
    /// in this portfolio using a role matching the name of the associated principal. 
    /// </para>
    /// </summary>
    public partial class DisassociatePrincipalFromPortfolioRequest : AmazonServiceCatalogRequest
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
        /// The supported value is <code>IAM</code> if you use a fully defined ARN, or <code>IAM_PATTERN</code>
        /// if you use no <code>accountID</code>. 
        /// </para>
        /// </summary>
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