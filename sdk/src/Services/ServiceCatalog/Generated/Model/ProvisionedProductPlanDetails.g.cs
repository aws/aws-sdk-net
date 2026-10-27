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
    /// Information about a plan.
    /// </summary>
    public partial class ProvisionedProductPlanDetails
    {
        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The UTC time stamp of the creation time.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

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
        /// Gets and sets the property PlanId. 
        /// <para>
        /// The plan identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PlanId { get; set; }

        /// <summary>
        /// Checks to see if the PlanId property is set.
        /// </summary>
        internal bool IsSetPlanId() => this.PlanId != null;

        /// <summary>
        /// Gets and sets the property PlanName. 
        /// <para>
        /// The name of the plan.
        /// </para>
        /// </summary>
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
        [AWSProperty(Min = 1, Max = 100)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property ProvisionProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ProvisionProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionProductId property is set.
        /// </summary>
        internal bool IsSetProvisionProductId() => this.ProvisionProductId != null;

        /// <summary>
        /// Gets and sets the property ProvisionProductName. 
        /// <para>
        /// The user-friendly name of the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProvisionProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionProductName property is set.
        /// </summary>
        internal bool IsSetProvisionProductName() => this.ProvisionProductName != null;

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The identifier of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public ProvisionedProductPlanStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

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

        /// <summary>
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        /// The UTC time stamp when the plan was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTime property is set.
        /// </summary>
        internal bool IsSetUpdatedTime() => this.UpdatedTime.HasValue;
    }
}
