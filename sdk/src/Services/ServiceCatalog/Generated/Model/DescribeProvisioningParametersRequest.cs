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
    /// Container for the parameters to the DescribeProvisioningParameters operation.
    /// Gets information about the configuration required to provision the specified product
    /// using the specified provisioning artifact.
    /// 
    ///  
    /// <para>
    /// If the output contains a TagOption key with an empty list of values, there is a TagOption
    /// conflict for that key. The end user cannot take action to fix the conflict, and launch
    /// is not blocked. In subsequent calls to <a>ProvisionProduct</a>, do not include conflicted
    /// TagOption keys as tags, or this causes the error "Parameter validation failed: Missing
    /// required parameter in Tags[<i>N</i>]:<i>Value</i>". Tag the provisioned product with
    /// the value <code>sc-tagoption-conflict-portfolioId-productId</code>.
    /// </para>
    /// </summary>
    public partial class DescribeProvisioningParametersRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _pathId;
        private string _pathName;
        private string _productId;
        private string _productName;
        private string _provisioningArtifactId;
        private string _provisioningArtifactName;

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
        /// Gets and sets the property PathId. 
        /// <para>
        /// The path identifier of the product. This value is optional if the product has a default
        /// path, and required if the product has more than one path. To list the paths for a
        /// product, use <a>ListLaunchPaths</a>. You must provide the name or ID, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PathId
        {
            get { return this._pathId; }
            set { this._pathId = value; }
        }

        // Check to see if PathId property is set
        internal bool IsSetPathId()
        {
            return this._pathId != null;
        }

        /// <summary>
        /// Gets and sets the property PathName. 
        /// <para>
        /// The name of the path. You must provide the name or ID, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PathName
        {
            get { return this._pathName; }
            set { this._pathName = value; }
        }

        // Check to see if PathName property is set
        internal bool IsSetPathName()
        {
            return this._pathName != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier. You must provide the product name or ID, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The name of the product. You must provide the name or ID, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
        public string ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }

        // Check to see if ProductName property is set
        internal bool IsSetProductName()
        {
            return this._productName != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The identifier of the provisioning artifact. You must provide the name or ID, but
        /// not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ProvisioningArtifactId
        {
            get { return this._provisioningArtifactId; }
            set { this._provisioningArtifactId = value; }
        }

        // Check to see if ProvisioningArtifactId property is set
        internal bool IsSetProvisioningArtifactId()
        {
            return this._provisioningArtifactId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactName. 
        /// <para>
        /// The name of the provisioning artifact. You must provide the name or ID, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string ProvisioningArtifactName
        {
            get { return this._provisioningArtifactName; }
            set { this._provisioningArtifactName = value; }
        }

        // Check to see if ProvisioningArtifactName property is set
        internal bool IsSetProvisioningArtifactName()
        {
            return this._provisioningArtifactName != null;
        }

    }
}