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
    /// Container for the parameters to the CreateProduct operation. Creates a product. <para>
    /// A delegated admin is authorized to invoke this command. </para> <para> The user or
    /// role that performs this operation must have the <c>cloudformation:GetTemplate</c>
    /// IAM policy permission. This policy permission is required when using the <c>ImportFromPhysicalId</c>
    /// template source in the information data section. </para>
    /// </summary>
    public partial class CreateProductRequest : AmazonServiceCatalogRequest
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8191)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Distributor. 
        /// <para>
        /// The distributor of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8191)]
        public string Distributor { get; set; }

        /// <summary>
        /// Checks to see if the Distributor property is set.
        /// </summary>
        internal bool IsSetDistributor() => this.Distributor != null;

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique identifier that you provide to ensure idempotency. If multiple requests differ
        /// only by the idempotency token, the same response is returned for each repeated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 8191)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 8191)]
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property ProductType. 
        /// <para>
        /// The type of product.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 8191)]
        public ProductType ProductType { get; set; }

        /// <summary>
        /// Checks to see if the ProductType property is set.
        /// </summary>
        internal bool IsSetProductType() => this.ProductType != null;

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactParameters. 
        /// <para>
        /// The configuration of the provisioning artifact. 
        /// </para>
        /// </summary>
        public ProvisioningArtifactProperties ProvisioningArtifactParameters { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningArtifactParameters property is set.
        /// </summary>
        internal bool IsSetProvisioningArtifactParameters() => this.ProvisioningArtifactParameters != null;

        /// <summary>
        /// Gets and sets the property SourceConnection. 
        /// <para>
        /// Specifies connection details for the created product and syncs the product to the
        /// connection source artifact. This automatically manages the product's artifacts based
        /// on changes to the source. The <c>SourceConnection</c> parameter consists of the following
        /// sub-fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Type</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConnectionParamters</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SourceConnection SourceConnection { get; set; }

        /// <summary>
        /// Checks to see if the SourceConnection property is set.
        /// </summary>
        internal bool IsSetSourceConnection() => this.SourceConnection != null;

        /// <summary>
        /// Gets and sets the property SupportDescription. 
        /// <para>
        /// The support information about the product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8191)]
        public string SupportDescription { get; set; }

        /// <summary>
        /// Checks to see if the SupportDescription property is set.
        /// </summary>
        internal bool IsSetSupportDescription() => this.SupportDescription != null;

        /// <summary>
        /// Gets and sets the property SupportEmail. 
        /// <para>
        /// The contact email for product support.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 254)]
        public string SupportEmail { get; set; }

        /// <summary>
        /// Checks to see if the SupportEmail property is set.
        /// </summary>
        internal bool IsSetSupportEmail() => this.SupportEmail != null;

        /// <summary>
        /// Gets and sets the property SupportUrl. 
        /// <para>
        /// The contact URL for product support.
        /// </para>
        ///  
        /// <para>
        ///  <c>^https?:\/\// </c>/ is the pattern used to validate SupportUrl.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2083)]
        public string SupportUrl { get; set; }

        /// <summary>
        /// Checks to see if the SupportUrl property is set.
        /// </summary>
        internal bool IsSetSupportUrl() => this.SupportUrl != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
