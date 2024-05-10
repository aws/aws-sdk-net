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
    /// Container for the parameters to the AssociatePrincipalWithPortfolio operation.
    /// Associates the specified principal ARN with the specified portfolio.
    /// 
    ///  
    /// <para>
    /// If you share the portfolio with principal name sharing enabled, the <c>PrincipalARN</c>
    /// association is included in the share. 
    /// </para>
    ///  
    /// <para>
    /// The <c>PortfolioID</c>, <c>PrincipalARN</c>, and <c>PrincipalType</c> parameters are
    /// required. 
    /// </para>
    ///  
    /// <para>
    /// You can associate a maximum of 10 Principals with a portfolio using <c>PrincipalType</c>
    /// as <c>IAM_PATTERN</c>. 
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
        /// The ARN of the principal (user, role, or group). If the <c>PrincipalType</c> is <c>IAM</c>,
        /// the supported value is a fully defined <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns">IAM
        /// Amazon Resource Name (ARN)</a>. If the <c>PrincipalType</c> is <c>IAM_PATTERN</c>,
        /// the supported value is an <c>IAM</c> ARN <i>without an AccountID</i> in the following
        /// format:
        /// </para>
        ///  
        /// <para>
        ///  <i>arn:partition:iam:::resource-type/resource-id</i> 
        /// </para>
        ///  
        /// <para>
        /// The ARN resource-id can be either:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A fully formed resource-id. For example, <i>arn:aws:iam:::role/resource-name</i> or
        /// <i>arn:aws:iam:::role/resource-path/resource-name</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A wildcard ARN. The wildcard ARN accepts <c>IAM_PATTERN</c> values with a "*" or "?"
        /// in the resource-id segment of the ARN. For example <i>arn:partition:service:::resource-type/resource-path/resource-name</i>.
        /// The new symbols are exclusive to the <b>resource-path</b> and <b>resource-name</b>
        /// and cannot replace the <b>resource-type</b> or other ARN values. 
        /// </para>
        ///  
        /// <para>
        /// The ARN path and principal name allow unlimited wildcard characters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Examples of an <b>acceptable</b> wildcard ARN:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// arn:aws:iam:::role/ResourceName_*
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// arn:aws:iam:::role/*/ResourceName_?
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Examples of an <b>unacceptable</b> wildcard ARN:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// arn:aws:iam:::*/ResourceName
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can associate multiple <c>IAM_PATTERN</c>s even if the account has no principal
        /// with that name. 
        /// </para>
        ///  
        /// <para>
        /// The "?" wildcard character matches zero or one of any character. This is similar to
        /// ".?" in regular regex context. The "*" wildcard character matches any number of any
        /// characters. This is similar to ".*" in regular regex context.
        /// </para>
        ///  
        /// <para>
        /// In the IAM Principal ARN format (<i>arn:partition:iam:::resource-type/resource-path/resource-name</i>),
        /// valid resource-type values include <b>user/</b>, <b>group/</b>, or <b>role/</b>. The
        /// "?" and "*" characters are allowed only after the resource-type in the resource-id
        /// segment. You can use special characters anywhere within the resource-id. 
        /// </para>
        ///  
        /// <para>
        /// The "*" character also matches the "/" character, allowing paths to be formed <i>within</i>
        /// the resource-id. For example, <i>arn:aws:iam:::role/<b>*</b>/ResourceName_?</i> matches
        /// both <i>arn:aws:iam:::role/pathA/pathB/ResourceName_1</i> and <i>arn:aws:iam:::role/pathA/ResourceName_1</i>.
        /// 
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
        /// The principal type. The supported value is <c>IAM</c> if you use a fully defined Amazon
        /// Resource Name (ARN), or <c>IAM_PATTERN</c> if you use an ARN with no <c>accountID</c>,
        /// with or without wildcard characters. 
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