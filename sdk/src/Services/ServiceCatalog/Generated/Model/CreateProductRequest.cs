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
    /// Container for the parameters to the CreateProduct operation.
    /// Creates a product.
    /// 
    ///  
    /// <para>
    /// A delegated admin is authorized to invoke this command.
    /// </para>
    ///  
    /// <para>
    /// The user or role that performs this operation must have the <code>cloudformation:GetTemplate</code>
    /// IAM policy permission. This policy permission is required when using the <code>ImportFromPhysicalId</code>
    /// template source in the information data section.
    /// </para>
    /// </summary>
    public partial class CreateProductRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _description;
        private string _distributor;
        private string _idempotencyToken;
        private string _name;
        private string _owner;
        private ProductType _productType;
        private ProvisioningArtifactProperties _provisioningArtifactParameters;
        private SourceConnection _sourceConnection;
        private string _supportDescription;
        private string _supportEmail;
        private string _supportUrl;
        private List<Tag> _tags = new List<Tag>();

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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Distributor. 
        /// <para>
        /// The distributor of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
        public string Distributor
        {
            get { return this._distributor; }
            set { this._distributor = value; }
        }

        // Check to see if Distributor property is set
        internal bool IsSetDistributor()
        {
            return this._distributor != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique identifier that you provide to ensure idempotency. If multiple requests differ
        /// only by the idempotency token, the same response is returned for each repeated request.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=8191)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=8191)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property ProductType. 
        /// <para>
        /// The type of product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=8191)]
        public ProductType ProductType
        {
            get { return this._productType; }
            set { this._productType = value; }
        }

        // Check to see if ProductType property is set
        internal bool IsSetProductType()
        {
            return this._productType != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactParameters. 
        /// <para>
        /// The configuration of the provisioning artifact. 
        /// </para>
        /// </summary>
        public ProvisioningArtifactProperties ProvisioningArtifactParameters
        {
            get { return this._provisioningArtifactParameters; }
            set { this._provisioningArtifactParameters = value; }
        }

        // Check to see if ProvisioningArtifactParameters property is set
        internal bool IsSetProvisioningArtifactParameters()
        {
            return this._provisioningArtifactParameters != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConnection. 
        /// <para>
        /// Specifies connection details for the created product and syncs the product to the
        /// connection source artifact. This automatically manages the product's artifacts based
        /// on changes to the source. The <code>SourceConnection</code> parameter consists of
        /// the following sub-fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Type</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ConnectionParamters</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SourceConnection SourceConnection
        {
            get { return this._sourceConnection; }
            set { this._sourceConnection = value; }
        }

        // Check to see if SourceConnection property is set
        internal bool IsSetSourceConnection()
        {
            return this._sourceConnection != null;
        }

        /// <summary>
        /// Gets and sets the property SupportDescription. 
        /// <para>
        /// The support information about the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
        public string SupportDescription
        {
            get { return this._supportDescription; }
            set { this._supportDescription = value; }
        }

        // Check to see if SupportDescription property is set
        internal bool IsSetSupportDescription()
        {
            return this._supportDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SupportEmail. 
        /// <para>
        /// The contact email for product support.
        /// </para>
        /// </summary>
        [AWSProperty(Max=254)]
        public string SupportEmail
        {
            get { return this._supportEmail; }
            set { this._supportEmail = value; }
        }

        // Check to see if SupportEmail property is set
        internal bool IsSetSupportEmail()
        {
            return this._supportEmail != null;
        }

        /// <summary>
        /// Gets and sets the property SupportUrl. 
        /// <para>
        /// The contact URL for product support.
        /// </para>
        ///  
        /// <para>
        ///  <code>^https?:\/\// </code>/ is the pattern used to validate SupportUrl.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2083)]
        public string SupportUrl
        {
            get { return this._supportUrl; }
            set { this._supportUrl = value; }
        }

        // Check to see if SupportUrl property is set
        internal bool IsSetSupportUrl()
        {
            return this._supportUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
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

    }
}