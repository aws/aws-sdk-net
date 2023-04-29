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
    /// Container for the parameters to the UpdateProvisionedProduct operation.
    /// Requests updates to the configuration of the specified provisioned product.
    /// 
    ///  
    /// <para>
    /// If there are tags associated with the object, they cannot be updated or added. Depending
    /// on the specific updates requested, this operation can update with no interruption,
    /// with some interruption, or replace the provisioned product entirely.
    /// </para>
    ///  
    /// <para>
    /// You can check the status of this request using <a>DescribeRecord</a>.
    /// </para>
    /// </summary>
    public partial class UpdateProvisionedProductRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _pathId;
        private string _pathName;
        private string _productId;
        private string _productName;
        private string _provisionedProductId;
        private string _provisionedProductName;
        private string _provisioningArtifactId;
        private string _provisioningArtifactName;
        private List<UpdateProvisioningParameter> _provisioningParameters = new List<UpdateProvisioningParameter>();
        private UpdateProvisioningPreferences _provisioningPreferences;
        private List<Tag> _tags = new List<Tag>();
        private string _updateToken;

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
        /// The path identifier. This value is optional if the product has a default path, and
        /// required if the product has more than one path. You must provide the name or ID, but
        /// not both.
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
        /// The identifier of the product. You must provide the name or ID, but not both.
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
        /// Gets and sets the property ProvisionedProductId. 
        /// <para>
        /// The identifier of the provisioned product. You must provide the name or ID, but not
        /// both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The name of the provisioned product. You cannot specify both <code>ProvisionedProductName</code>
        /// and <code>ProvisionedProductId</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
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
        /// The identifier of the provisioning artifact.
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

        /// <summary>
        /// Gets and sets the property ProvisioningParameters. 
        /// <para>
        /// The new parameters.
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
        /// Gets and sets the property ProvisioningPreferences. 
        /// <para>
        /// An object that contains information about the provisioning preferences for a stack
        /// set.
        /// </para>
        /// </summary>
        public UpdateProvisioningPreferences ProvisioningPreferences
        {
            get { return this._provisioningPreferences; }
            set { this._provisioningPreferences = value; }
        }

        // Check to see if ProvisioningPreferences property is set
        internal bool IsSetProvisioningPreferences()
        {
            return this._provisioningPreferences != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags. Requires the product to have <code>RESOURCE_UPDATE</code> constraint
        /// with <code>TagUpdatesOnProvisionedProduct</code> set to <code>ALLOWED</code> to allow
        /// tag updates.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// The idempotency token that uniquely identifies the provisioning update request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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