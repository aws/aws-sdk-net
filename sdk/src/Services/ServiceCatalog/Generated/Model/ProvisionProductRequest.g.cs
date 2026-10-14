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
    /// Container for the parameters to the ProvisionProduct operation. Provisions the specified
    /// product. <para> A provisioned product is a resourced instance of a product. For example,
    /// provisioning a product that's based on an CloudFormation template launches an CloudFormation
    /// stack and its underlying resources. You can check the status of this request using
    /// <a>DescribeRecord</a>. </para> <para> If the request contains a tag key with an empty
    /// list of values, there's a tag conflict for that key. Don't include conflicted keys
    /// as tags, or this will cause the error "Parameter validation failed: Missing required
    /// parameter in Tags[<i>N</i>]:<i>Value</i>". </para> <note> <para> When provisioning
    /// a product that's been added to a portfolio, you must grant your user, group, or role
    /// access to the portfolio. For more information, see <a href="https://docs.aws.amazon.com/servicecatalog/latest/adminguide/catalogs_portfolios_users.html">Granting
    /// users access</a> in the <i>Service Catalog User Guide</i>. </para> </note>
    /// </summary>
    public partial class ProvisionProductRequest : AmazonServiceCatalogRequest
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
        /// Gets and sets the property NotificationArns. 
        /// <para>
        /// Passed to CloudFormation. The SNS topic ARNs to which to publish stack-related events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> NotificationArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NotificationArns property is set.
        /// </summary>
        internal bool IsSetNotificationArns() => this.NotificationArns != null && (this.NotificationArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PathId. 
        /// <para>
        /// The path identifier of the product. This value is optional if the product has a default
        /// path, and required if the product has more than one path. To list the paths for a
        /// product, use <a>ListLaunchPaths</a>. You must provide the name or ID, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PathId { get; set; }

        /// <summary>
        /// Checks to see if the PathId property is set.
        /// </summary>
        internal bool IsSetPathId() => this.PathId != null;

        /// <summary>
        /// Gets and sets the property PathName. 
        /// <para>
        /// The name of the path. You must provide the name or ID, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PathName { get; set; }

        /// <summary>
        /// Checks to see if the PathName property is set.
        /// </summary>
        internal bool IsSetPathName() => this.PathName != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier. You must provide the name or ID, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The name of the product. You must provide the name or ID, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8191)]
        public string ProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null;

        /// <summary>
        /// Gets and sets the property ProvisionToken. 
        /// <para>
        /// An idempotency token that uniquely identifies the provisioning request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProvisionToken { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionToken property is set.
        /// </summary>
        internal bool IsSetProvisionToken() => this.ProvisionToken != null;

        /// <summary>
        /// Gets and sets the property ProvisionedProductName. 
        /// <para>
        /// A user-friendly name for the provisioned product. This value must be unique for the
        /// Amazon Web Services account and cannot be updated after the product is provisioned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ProvisionedProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedProductName property is set.
        /// </summary>
        internal bool IsSetProvisionedProductName() => this.ProvisionedProductName != null;

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The identifier of the provisioning artifact. You must provide the name or ID, but
        /// not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ProvisioningArtifactId { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningArtifactId property is set.
        /// </summary>
        internal bool IsSetProvisioningArtifactId() => this.ProvisioningArtifactId != null;

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactName. 
        /// <para>
        /// The name of the provisioning artifact. You must provide the name or ID, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string ProvisioningArtifactName { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningArtifactName property is set.
        /// </summary>
        internal bool IsSetProvisioningArtifactName() => this.ProvisioningArtifactName != null;

        /// <summary>
        /// Gets and sets the property ProvisioningParameters. 
        /// <para>
        /// Parameters specified by the administrator that are required for provisioning the product.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProvisioningParameter> ProvisioningParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<ProvisioningParameter>() : null;

        /// <summary>
        /// Checks to see if the ProvisioningParameters property is set.
        /// </summary>
        internal bool IsSetProvisioningParameters() => this.ProvisioningParameters != null && (this.ProvisioningParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProvisioningPreferences. 
        /// <para>
        /// An object that contains information about the provisioning preferences for a stack
        /// set.
        /// </para>
        /// </summary>
        public ProvisioningPreferences ProvisioningPreferences { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningPreferences property is set.
        /// </summary>
        internal bool IsSetProvisioningPreferences() => this.ProvisioningPreferences != null;

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
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
