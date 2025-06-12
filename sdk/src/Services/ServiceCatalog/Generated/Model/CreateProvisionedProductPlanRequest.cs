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
    /// Container for the parameters to the CreateProvisionedProductPlan operation.
    /// Creates a plan.
    /// 
    ///  
    /// <para>
    /// A plan includes the list of resources to be created (when provisioning a new product)
    /// or modified (when updating a provisioned product) when the plan is executed.
    /// </para>
    ///  
    /// <para>
    /// You can create one plan for each provisioned product. To create a plan for an existing
    /// provisioned product, the product status must be AVAILABLE or TAINTED.
    /// </para>
    ///  
    /// <para>
    /// To view the resource changes in the change set, use <a>DescribeProvisionedProductPlan</a>.
    /// To create or modify the provisioned product, use <a>ExecuteProvisionedProductPlan</a>.
    /// </para>
    /// </summary>
    public partial class CreateProvisionedProductPlanRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _idempotencyToken;
        private List<string> _notificationArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _pathId;
        private string _planName;
        private ProvisionedProductPlanType _planType;
        private string _productId;
        private string _provisionedProductName;
        private string _provisioningArtifactId;
        private List<UpdateProvisioningParameter> _provisioningParameters = AWSConfigs.InitializeCollections ? new List<UpdateProvisioningParameter>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        /// Gets and sets the property NotificationArns. 
        /// <para>
        /// Passed to CloudFormation. The SNS topic ARNs to which to publish stack-related events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> NotificationArns
        {
            get { return this._notificationArns; }
            set { this._notificationArns = value; }
        }

        // Check to see if NotificationArns property is set
        internal bool IsSetNotificationArns()
        {
            return this._notificationArns != null && (this._notificationArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PathId. 
        /// <para>
        /// The path identifier of the product. This value is optional if the product has a default
        /// path, and required if the product has more than one path. To list the paths for a
        /// product, use <a>ListLaunchPaths</a>.
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
        /// Gets and sets the property PlanName. 
        /// <para>
        /// The name of the plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PlanName
        {
            get { return this._planName; }
            set { this._planName = value; }
        }

        // Check to see if PlanName property is set
        internal bool IsSetPlanName()
        {
            return this._planName != null;
        }

        /// <summary>
        /// Gets and sets the property PlanType. 
        /// <para>
        /// The plan type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProvisionedProductPlanType PlanType
        {
            get { return this._planType; }
            set { this._planType = value; }
        }

        // Check to see if PlanType property is set
        internal bool IsSetPlanType()
        {
            return this._planType != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property ProvisionedProductName. 
        /// <para>
        /// A user-friendly name for the provisioned product. This value must be unique for the
        /// Amazon Web Services account and cannot be updated after the product is provisioned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Parameters specified by the administrator that are required for provisioning the product.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UpdateProvisioningParameter> ProvisioningParameters
        {
            get { return this._provisioningParameters; }
            set { this._provisioningParameters = value; }
        }

        // Check to see if ProvisioningParameters property is set
        internal bool IsSetProvisioningParameters()
        {
            return this._provisioningParameters != null && (this._provisioningParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}