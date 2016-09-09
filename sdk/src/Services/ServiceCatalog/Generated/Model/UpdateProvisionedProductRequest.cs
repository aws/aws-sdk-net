/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProvisionedProduct operation.
    /// Requests updates to the configuration of an existing ProvisionedProduct object. If
    /// there are tags associated with the object, they cannot be updated or added with this
    /// operation. Depending on the specific updates requested, this operation may update
    /// with no interruption, with some interruption, or replace the ProvisionedProduct object
    /// entirely. 
    /// 
    ///  
    /// <para>
    /// You can check the status of this request using the <a>DescribeRecord</a> operation.
    /// </para>
    /// </summary>
    public partial class UpdateProvisionedProductRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _pathId;
        private string _productId;
        private string _provisionedProductId;
        private string _provisionedProductName;
        private string _provisioningArtifactId;
        private List<UpdateProvisioningParameter> _provisioningParameters = new List<UpdateProvisioningParameter>();
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// Optional language code. Supported language codes are as follows:
        /// </para>
        ///  
        /// <para>
        /// "en" (English)
        /// </para>
        ///  
        /// <para>
        /// "jp" (Japanese)
        /// </para>
        ///  
        /// <para>
        /// "zh" (Chinese)
        /// </para>
        ///  
        /// <para>
        /// If no code is specified, "en" is used as the default.
        /// </para>
        /// </summary>
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
        /// The identifier of the path to use in the updated ProvisionedProduct object. This value
        /// is optional if the product has a default path, and is required if there is more than
        /// one path for the specified product.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The identifier of the ProvisionedProduct object.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProvisionedProductId. 
        /// <para>
        /// The identifier of the ProvisionedProduct object to update. You must specify either
        /// <code>ProvisionedProductName</code> or <code>ProvisionedProductId</code>, but not
        /// both.
        /// </para>
        /// </summary>
        public string ProvisionedProductId
        {
            get { return this._provisionedProductId; }
            set { this._provisionedProductId = value; }
        }

        // Check to see if ProvisionedProductId property is set
        internal bool IsSetProvisionedProductId()
        {
            return this._provisionedProductId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedProductName. 
        /// <para>
        /// The updated name of the ProvisionedProduct object . You must specify either <code>ProvisionedProductName</code>
        /// or <code>ProvisionedProductId</code>, but not both.
        /// </para>
        /// </summary>
        public string ProvisionedProductName
        {
            get { return this._provisionedProductName; }
            set { this._provisionedProductName = value; }
        }

        // Check to see if ProvisionedProductName property is set
        internal bool IsSetProvisionedProductName()
        {
            return this._provisionedProductName != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The provisioning artifact identifier for this product.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProvisioningParameters. 
        /// <para>
        /// A list of <code>ProvisioningParameter</code> objects used to update the ProvisionedProduct
        /// object.
        /// </para>
        /// </summary>
        public List<UpdateProvisioningParameter> ProvisioningParameters
        {
            get { return this._provisioningParameters; }
            set { this._provisioningParameters = value; }
        }

        // Check to see if ProvisioningParameters property is set
        internal bool IsSetProvisioningParameters()
        {
            return this._provisioningParameters != null && this._provisioningParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// The idempotency token that uniquely identifies the provisioning update request.
        /// </para>
        /// </summary>
        public string UpdateToken
        {
            get { return this._updateToken; }
            set { this._updateToken = value; }
        }

        // Check to see if UpdateToken property is set
        internal bool IsSetUpdateToken()
        {
            return this._updateToken != null;
        }

    }
}