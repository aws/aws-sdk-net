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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the ImportImage operation.
    /// </summary>
    public partial class ImportImageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the virtual machine.
        /// </para>
        /// </summary>
        public string Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the import task.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the AMI is encrypted.
        /// </para>
        /// </summary>
        public bool? Encrypted { get; set; }

        /// <summary>
        /// Checks to see if the Encrypted property is set.
        /// </summary>
        internal bool IsSetEncrypted() => this.Encrypted.HasValue;

        /// <summary>
        /// Gets and sets the property Hypervisor. 
        /// <para>
        /// The target hypervisor of the import task.
        /// </para>
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// Checks to see if the Hypervisor property is set.
        /// </summary>
        internal bool IsSetHypervisor() => this.Hypervisor != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the Amazon Machine Image (AMI) created by the import task.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property ImportTaskId. 
        /// <para>
        /// The task ID of the import image task.
        /// </para>
        /// </summary>
        public string ImportTaskId { get; set; }

        /// <summary>
        /// Checks to see if the ImportTaskId property is set.
        /// </summary>
        internal bool IsSetImportTaskId() => this.ImportTaskId != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier for the symmetric KMS key that was used to create the encrypted AMI.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LicenseSpecifications. 
        /// <para>
        /// The ARNs of the license configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ImportImageLicenseConfigurationResponse> LicenseSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<ImportImageLicenseConfigurationResponse>() : null;

        /// <summary>
        /// Checks to see if the LicenseSpecifications property is set.
        /// </summary>
        internal bool IsSetLicenseSpecifications() => this.LicenseSpecifications != null && (this.LicenseSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// The license type of the virtual machine.
        /// </para>
        /// </summary>
        public string LicenseType { get; set; }

        /// <summary>
        /// Checks to see if the LicenseType property is set.
        /// </summary>
        internal bool IsSetLicenseType() => this.LicenseType != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system of the virtual machine.
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The progress of the task.
        /// </para>
        /// </summary>
        public string Progress { get; set; }

        /// <summary>
        /// Checks to see if the Progress property is set.
        /// </summary>
        internal bool IsSetProgress() => this.Progress != null;

        /// <summary>
        /// Gets and sets the property SnapshotDetails. 
        /// <para>
        /// Information about the snapshots.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SnapshotDetail> SnapshotDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<SnapshotDetail>() : null;

        /// <summary>
        /// Checks to see if the SnapshotDetails property is set.
        /// </summary>
        internal bool IsSetSnapshotDetails() => this.SnapshotDetails != null && (this.SnapshotDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A brief status of the task.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed status message of the import task.
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
        /// Any tags assigned to the import image task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UsageOperation. 
        /// <para>
        /// The usage operation value.
        /// </para>
        /// </summary>
        public string UsageOperation { get; set; }

        /// <summary>
        /// Checks to see if the UsageOperation property is set.
        /// </summary>
        internal bool IsSetUsageOperation() => this.UsageOperation != null;
    }
}
