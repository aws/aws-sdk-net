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
    /// Information about a request operation.
    /// </summary>
    public partial class RecordDetail
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
        /// Gets and sets the property LaunchRoleArn. 
        /// <para>
        /// The ARN of the launch role associated with the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string LaunchRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the LaunchRoleArn property is set.
        /// </summary>
        internal bool IsSetLaunchRoleArn() => this.LaunchRoleArn != null;

        /// <summary>
        /// Gets and sets the property PathId. 
        /// <para>
        /// The path identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PathId { get; set; }

        /// <summary>
        /// Checks to see if the PathId property is set.
        /// </summary>
        internal bool IsSetPathId() => this.PathId != null;

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
        /// Gets and sets the property ProvisionedProductId. 
        /// <para>
        /// The identifier of the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ProvisionedProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedProductId property is set.
        /// </summary>
        internal bool IsSetProvisionedProductId() => this.ProvisionedProductId != null;

        /// <summary>
        /// Gets and sets the property ProvisionedProductName. 
        /// <para>
        /// The user-friendly name of the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProvisionedProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedProductName property is set.
        /// </summary>
        internal bool IsSetProvisionedProductName() => this.ProvisionedProductName != null;

        /// <summary>
        /// Gets and sets the property ProvisionedProductType. 
        /// <para>
        /// The type of provisioned product. The supported values are <c>CFN_STACK</c>, <c>CFN_STACKSET</c>,
        /// <c>TERRAFORM_OPEN_SOURCE</c>, <c>TERRAFORM_CLOUD</c>, and <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        public string ProvisionedProductType { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedProductType property is set.
        /// </summary>
        internal bool IsSetProvisionedProductType() => this.ProvisionedProductType != null;

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
        /// Gets and sets the property RecordErrors. 
        /// <para>
        /// The errors that occurred.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecordError> RecordErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<RecordError>() : null;

        /// <summary>
        /// Checks to see if the RecordErrors property is set.
        /// </summary>
        internal bool IsSetRecordErrors() => this.RecordErrors != null && (this.RecordErrors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        /// The identifier of the record.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RecordId { get; set; }

        /// <summary>
        /// Checks to see if the RecordId property is set.
        /// </summary>
        internal bool IsSetRecordId() => this.RecordId != null;

        /// <summary>
        /// Gets and sets the property RecordTags. 
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
        public List<RecordTag> RecordTags { get; set; } = AWSConfigs.InitializeCollections ? new List<RecordTag>() : null;

        /// <summary>
        /// Checks to see if the RecordTags property is set.
        /// </summary>
        internal bool IsSetRecordTags() => this.RecordTags != null && (this.RecordTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecordType. 
        /// <para>
        /// The record type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROVISION_PRODUCT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_PROVISIONED_PRODUCT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TERMINATE_PROVISIONED_PRODUCT</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string RecordType { get; set; }

        /// <summary>
        /// Checks to see if the RecordType property is set.
        /// </summary>
        internal bool IsSetRecordType() => this.RecordType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the provisioned product.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATED</c> - The request was created but the operation has not started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - The requested operation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS_IN_ERROR</c> - The provisioned product is under change but the requested
        /// operation failed and some remediation is occurring. For example, a rollback.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c> - The requested operation has successfully completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The requested operation has unsuccessfully completed. Investigate
        /// using the error messages returned.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RecordStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        /// The time when the record was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTime property is set.
        /// </summary>
        internal bool IsSetUpdatedTime() => this.UpdatedTime.HasValue;
    }
}
