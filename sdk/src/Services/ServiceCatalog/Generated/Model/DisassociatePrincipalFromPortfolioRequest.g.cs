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
    /// Container for the parameters to the DisassociatePrincipalFromPortfolio operation.
    /// Disassociates a previously associated principal ARN from a specified portfolio. <para>
    /// The <c>PrincipalType</c> and <c>PrincipalARN</c> must match the <c>AssociatePrincipalWithPortfolio</c>
    /// call request details. For example, to disassociate an association created with a <c>PrincipalARN</c>
    /// of <c>PrincipalType</c> IAM you must use the <c>PrincipalType</c> IAM when calling
    /// <c>DisassociatePrincipalFromPortfolio</c>. </para> <para> For portfolios that have
    /// been shared with principal name sharing enabled: after disassociating a principal,
    /// share recipient accounts will no longer be able to provision products in this portfolio
    /// using a role matching the name of the associated principal. </para> <para> For more
    /// information, review <a href="https://docs.aws.amazon.com/cli/latest/reference/servicecatalog/associate-principal-with-portfolio.html#options">associate-principal-with-portfolio</a>
    /// in the Amazon Web Services CLI Command Reference. </para> <note> <para> If you disassociate
    /// a principal from a portfolio, with PrincipalType as <c>IAM</c>, the same principal
    /// will still have access to the portfolio if it matches one of the associated principals
    /// of type <c>IAM_PATTERN</c>. To fully remove access for a principal, verify all the
    /// associated Principals of type <c>IAM_PATTERN</c>, and then ensure you disassociate
    /// any <c>IAM_PATTERN</c> principals that match the principal whose access you are removing.
    /// </para> </note>
    /// </summary>
    public partial class DisassociatePrincipalFromPortfolioRequest : AmazonServiceCatalogRequest
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
        /// Gets and sets the property PrincipalARN. 
        /// <para>
        /// The ARN of the principal (user, role, or group). This field allows an ARN with no
        /// <c>accountID</c> with or without wildcard characters if <c>PrincipalType</c> is <c>IAM_PATTERN</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string PrincipalARN { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalARN property is set.
        /// </summary>
        internal bool IsSetPrincipalARN() => this.PrincipalARN != null;

        /// <summary>
        /// Gets and sets the property PrincipalType. 
        /// <para>
        /// The supported value is <c>IAM</c> if you use a fully defined ARN, or <c>IAM_PATTERN</c>
        /// if you specify an <c>IAM</c> ARN with no AccountId, with or without wildcard characters.
        /// 
        /// </para>
        /// </summary>
        public PrincipalType PrincipalType { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalType property is set.
        /// </summary>
        internal bool IsSetPrincipalType() => this.PrincipalType != null;
    }
}
