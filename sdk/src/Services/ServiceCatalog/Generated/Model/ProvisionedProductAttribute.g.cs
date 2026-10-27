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
    /// Information about a provisioned product.
    /// </summary>
    public partial class ProvisionedProductAttribute
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

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
        /// Gets and sets the property LastProvisioningRecordId. 
        /// <para>
        /// The record identifier of the last request performed on this provisioned product of
        /// the following types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  ProvisionProduct 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  UpdateProvisionedProduct 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  ExecuteProvisionedProductPlan 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  TerminateProvisionedProduct 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string LastProvisioningRecordId { get; set; }

        /// <summary>
        /// Checks to see if the LastProvisioningRecordId property is set.
        /// </summary>
        internal bool IsSetLastProvisioningRecordId() => this.LastProvisioningRecordId != null;

        /// <summary>
        /// Gets and sets the property LastRecordId. 
        /// <para>
        /// The record identifier of the last request performed on this provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string LastRecordId { get; set; }

        /// <summary>
        /// Checks to see if the LastRecordId property is set.
        /// </summary>
        internal bool IsSetLastRecordId() => this.LastRecordId != null;

        /// <summary>
        /// Gets and sets the property LastSuccessfulProvisioningRecordId. 
        /// <para>
        /// The record identifier of the last successful request performed on this provisioned
        /// product of the following types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  ProvisionProduct 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  UpdateProvisionedProduct 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  ExecuteProvisionedProductPlan 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  TerminateProvisionedProduct 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string LastSuccessfulProvisioningRecordId { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulProvisioningRecordId property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulProvisioningRecordId() => this.LastSuccessfulProvisioningRecordId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The user-friendly name of the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PhysicalId. 
        /// <para>
        /// The assigned identifier for the resource, such as an EC2 instance ID or an S3 bucket
        /// name.
        /// </para>
        /// </summary>
        public string PhysicalId { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalId property is set.
        /// </summary>
        internal bool IsSetPhysicalId() => this.PhysicalId != null;

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
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The name of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8191)]
        public string ProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null;

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
        /// Gets and sets the property ProvisioningArtifactName. 
        /// <para>
        /// The name of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string ProvisioningArtifactName { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningArtifactName property is set.
        /// </summary>
        internal bool IsSetProvisioningArtifactName() => this.ProvisioningArtifactName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the provisioned product.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - Stable state, ready to perform any operation. The most recent
        /// operation succeeded and completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNDER_CHANGE</c> - Transitive state. Operations performed might not have valid
        /// results. Wait for an <c>AVAILABLE</c> status before performing operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TAINTED</c> - Stable state, ready to perform any operation. The stack has completed
        /// the requested operation but is not exactly what was requested. For example, a request
        /// to update to a new version failed and the stack rolled back to the current version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c> - An unexpected error occurred. The provisioned product exists but the
        /// stack is not running. For example, CloudFormation received a parameter value that
        /// was not valid and could not launch the stack.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PLAN_IN_PROGRESS</c> - Transitive state. The plan operations were performed to
        /// provision a new product, but resources have not yet been created. After reviewing
        /// the list of resources to be created, execute the plan. Wait for an <c>AVAILABLE</c>
        /// status before performing operations.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ProvisionedProductStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The current status message of the provisioned product.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of provisioned product. The supported values are <c>CFN_STACK</c>, <c>CFN_STACKSET</c>,
        /// <c>TERRAFORM_OPEN_SOURCE</c>, <c>TERRAFORM_CLOUD</c>, and <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user.
        /// </para>
        /// </summary>
        public string UserArn { get; set; }

        /// <summary>
        /// Checks to see if the UserArn property is set.
        /// </summary>
        internal bool IsSetUserArn() => this.UserArn != null;

        /// <summary>
        /// Gets and sets the property UserArnSession. 
        /// <para>
        /// The ARN of the user in the session. This ARN might contain a session ID.
        /// </para>
        /// </summary>
        public string UserArnSession { get; set; }

        /// <summary>
        /// Checks to see if the UserArnSession property is set.
        /// </summary>
        internal bool IsSetUserArnSession() => this.UserArnSession != null;
    }
}
