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
    /// Container for the parameters to the CopyProduct operation. Copies the specified source
    /// product to the specified target product or a new product. <para> You can copy a product
    /// to the same account or another account. You can copy a product to the same Region
    /// or another Region. If you copy a product to another account, you must first share
    /// the product in a portfolio using <a>CreatePortfolioShare</a>. </para> <para> This
    /// operation is performed asynchronously. To track the progress of the operation, use
    /// <a>DescribeCopyProductStatus</a>. </para>
    /// </summary>
    public partial class CopyProductRequest : AmazonServiceCatalogRequest
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
        /// Gets and sets the property CopyOptions. 
        /// <para>
        /// The copy options. If the value is <c>CopyTags</c>, the tags from the source product
        /// are copied to the target product.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CopyOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CopyOptions property is set.
        /// </summary>
        internal bool IsSetCopyOptions() => this.CopyOptions != null && (this.CopyOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        ///  A unique identifier that you provide to ensure idempotency. If multiple requests
        /// differ only by the idempotency token, the same response is returned for each repeated
        /// request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;

        /// <summary>
        /// Gets and sets the property SourceProductArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source product.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1224)]
        public string SourceProductArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceProductArn property is set.
        /// </summary>
        internal bool IsSetSourceProductArn() => this.SourceProductArn != null;

        /// <summary>
        /// Gets and sets the property SourceProvisioningArtifactIdentifiers. 
        /// <para>
        /// The identifiers of the provisioning artifacts (also known as versions) of the product
        /// to copy. By default, all provisioning artifacts are copied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, string>> SourceProvisioningArtifactIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<Dictionary<string, string>>() : null;

        /// <summary>
        /// Checks to see if the SourceProvisioningArtifactIdentifiers property is set.
        /// </summary>
        internal bool IsSetSourceProvisioningArtifactIdentifiers() => this.SourceProvisioningArtifactIdentifiers != null && (this.SourceProvisioningArtifactIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetProductId. 
        /// <para>
        /// The identifier of the target product. By default, a new product is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TargetProductId { get; set; }

        /// <summary>
        /// Checks to see if the TargetProductId property is set.
        /// </summary>
        internal bool IsSetTargetProductId() => this.TargetProductId != null;

        /// <summary>
        /// Gets and sets the property TargetProductName. 
        /// <para>
        /// A name for the target product. The default is the name of the source product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8191)]
        public string TargetProductName { get; set; }

        /// <summary>
        /// Checks to see if the TargetProductName property is set.
        /// </summary>
        internal bool IsSetTargetProductName() => this.TargetProductName != null;
    }
}
