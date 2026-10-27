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
    /// Container for the parameters to the CreateProvisionedProductPlan operation. Creates
    /// a plan. <para> A plan includes the list of resources to be created (when provisioning
    /// a new product) or modified (when updating a provisioned product) when the plan is
    /// executed. </para> <para> You can create one plan for each provisioned product. To
    /// create a plan for an existing provisioned product, the product status must be AVAILABLE
    /// or TAINTED. </para> <para> To view the resource changes in the change set, use <a>DescribeProvisionedProductPlan</a>.
    /// To create or modify the provisioned product, use <a>ExecuteProvisionedProductPlan</a>.
    /// </para>
    /// </summary>
    public partial class CreateProvisionedProductPlanRequest : AmazonServiceCatalogRequest
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
        /// product, use <a>ListLaunchPaths</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PathId { get; set; }

        /// <summary>
        /// Checks to see if the PathId property is set.
        /// </summary>
        internal bool IsSetPathId() => this.PathId != null;

        /// <summary>
        /// Gets and sets the property PlanName. 
        /// <para>
        /// The name of the plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PlanName { get; set; }

        /// <summary>
        /// Checks to see if the PlanName property is set.
        /// </summary>
        internal bool IsSetPlanName() => this.PlanName != null;

        /// <summary>
        /// Gets and sets the property PlanType. 
        /// <para>
        /// The plan type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProvisionedProductPlanType PlanType { get; set; }

        /// <summary>
        /// Checks to see if the PlanType property is set.
        /// </summary>
        internal bool IsSetPlanType() => this.PlanType != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

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
        /// The identifier of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ProvisioningArtifactId { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningArtifactId property is set.
        /// </summary>
        internal bool IsSetProvisioningArtifactId() => this.ProvisioningArtifactId != null;

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
        public List<UpdateProvisioningParameter> ProvisioningParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<UpdateProvisioningParameter>() : null;

        /// <summary>
        /// Checks to see if the ProvisioningParameters property is set.
        /// </summary>
        internal bool IsSetProvisioningParameters() => this.ProvisioningParameters != null && (this.ProvisioningParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags.
        /// </para>
        ///  
        /// <para>
        /// If the plan is for an existing provisioned product, the product must have a <c>RESOURCE_UPDATE</c>
        /// constraint with <c>TagUpdatesOnProvisionedProduct</c> set to <c>ALLOWED</c> to allow
        /// tag updates.
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
