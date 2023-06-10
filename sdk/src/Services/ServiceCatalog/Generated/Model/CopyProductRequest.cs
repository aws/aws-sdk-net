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
    /// Container for the parameters to the CopyProduct operation.
    /// Copies the specified source product to the specified target product or a new product.
    /// 
    ///  
    /// <para>
    /// You can copy a product to the same account or another account. You can copy a product
    /// to the same Region or another Region. If you copy a product to another account, you
    /// must first share the product in a portfolio using <a>CreatePortfolioShare</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation is performed asynchronously. To track the progress of the operation,
    /// use <a>DescribeCopyProductStatus</a>.
    /// </para>
    /// </summary>
    public partial class CopyProductRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private List<string> _copyOptions = new List<string>();
        private string _idempotencyToken;
        private string _sourceProductArn;
        private List<Dictionary<string, string>> _sourceProvisioningArtifactIdentifiers = new List<Dictionary<string, string>>();
        private string _targetProductId;
        private string _targetProductName;

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
        /// Gets and sets the property CopyOptions. 
        /// <para>
        /// The copy options. If the value is <code>CopyTags</code>, the tags from the source
        /// product are copied to the target product.
        /// </para>
        /// </summary>
        public List<string> CopyOptions
        {
            get { return this._copyOptions; }
            set { this._copyOptions = value; }
        }

        // Check to see if CopyOptions property is set
        internal bool IsSetCopyOptions()
        {
            return this._copyOptions != null && this._copyOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        ///  A unique identifier that you provide to ensure idempotency. If multiple requests
        /// differ only by the idempotency token, the same response is returned for each repeated
        /// request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property SourceProductArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1224)]
        public string SourceProductArn
        {
            get { return this._sourceProductArn; }
            set { this._sourceProductArn = value; }
        }

        // Check to see if SourceProductArn property is set
        internal bool IsSetSourceProductArn()
        {
            return this._sourceProductArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceProvisioningArtifactIdentifiers. 
        /// <para>
        /// The identifiers of the provisioning artifacts (also known as versions) of the product
        /// to copy. By default, all provisioning artifacts are copied.
        /// </para>
        /// </summary>
        public List<Dictionary<string, string>> SourceProvisioningArtifactIdentifiers
        {
            get { return this._sourceProvisioningArtifactIdentifiers; }
            set { this._sourceProvisioningArtifactIdentifiers = value; }
        }

        // Check to see if SourceProvisioningArtifactIdentifiers property is set
        internal bool IsSetSourceProvisioningArtifactIdentifiers()
        {
            return this._sourceProvisioningArtifactIdentifiers != null && this._sourceProvisioningArtifactIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetProductId. 
        /// <para>
        /// The identifier of the target product. By default, a new product is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string TargetProductId
        {
            get { return this._targetProductId; }
            set { this._targetProductId = value; }
        }

        // Check to see if TargetProductId property is set
        internal bool IsSetTargetProductId()
        {
            return this._targetProductId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetProductName. 
        /// <para>
        /// A name for the target product. The default is the name of the source product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
        public string TargetProductName
        {
            get { return this._targetProductName; }
            set { this._targetProductName = value; }
        }

        // Check to see if TargetProductName property is set
        internal bool IsSetTargetProductName()
        {
            return this._targetProductName != null;
        }

    }
}