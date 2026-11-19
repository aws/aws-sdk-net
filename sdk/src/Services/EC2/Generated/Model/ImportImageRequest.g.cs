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
    /// Container for the parameters to the ImportImage operation. <note> <para> To import
    /// your virtual machines (VMs) with a console-based experience, you can use the <i>Import
    /// virtual machine images to Amazon Web Services</i> template in the <a href="https://console.aws.amazon.com/migrationhub/orchestrator">Migration
    /// Hub Orchestrator console</a>. For more information, see the <a href="https://docs.aws.amazon.com/migrationhub-orchestrator/latest/userguide/import-vm-images.html">
    /// <i>Migration Hub Orchestrator User Guide</i> </a>. </para> </note> <para> Import single
    /// or multi-volume disk images or EBS snapshots into an Amazon Machine Image (AMI). </para>
    /// <important> <para> Amazon Web Services VM Import/Export strongly recommends specifying
    /// a value for either the <c>--license-type</c> or <c>--usage-operation</c> parameter
    /// when you create a new VM Import task. This ensures your operating system is licensed
    /// appropriately and your billing is optimized. </para> </important> <para> For more
    /// information, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmimport-image-import.html">Importing
    /// a VM as an image using VM Import/Export</a> in the <i>VM Import/Export User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ImportImageRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the virtual machine.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>i386</c> | <c>x86_64</c> 
        /// </para>
        /// </summary>
        public string Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property BootMode. 
        /// <para>
        /// The boot mode of the virtual machine.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>uefi-preferred</c> boot mode isn't supported for importing images. For more
        /// information, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/prerequisites.html#vmimport-boot-modes">Boot
        /// modes</a> in the <i>VM Import/Export User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public BootModeValues BootMode { get; set; }

        /// <summary>
        /// Checks to see if the BootMode property is set.
        /// </summary>
        internal bool IsSetBootMode() => this.BootMode != null;

        /// <summary>
        /// Gets and sets the property ClientData. 
        /// <para>
        /// The client-specific data.
        /// </para>
        /// </summary>
        public ClientData ClientData { get; set; }

        /// <summary>
        /// Checks to see if the ClientData property is set.
        /// </summary>
        internal bool IsSetClientData() => this.ClientData != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The token to enable idempotency for VM import requests.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description string for the import image task.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DiskContainers. 
        /// <para>
        /// Information about the disk containers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ImageDiskContainer> DiskContainers { get; set; } = AWSConfigs.InitializeCollections ? new List<ImageDiskContainer>() : null;

        /// <summary>
        /// Checks to see if the DiskContainers property is set.
        /// </summary>
        internal bool IsSetDiskContainers() => this.DiskContainers != null && (this.DiskContainers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Specifies whether the destination AMI of the imported image should be encrypted. The
        /// default KMS key for EBS is used unless you specify a non-default KMS key using <c>KmsKeyId</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        /// The target hypervisor platform.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>xen</c> 
        /// </para>
        /// </summary>
        public string Hypervisor { get; set; }

        /// <summary>
        /// Checks to see if the Hypervisor property is set.
        /// </summary>
        internal bool IsSetHypervisor() => this.Hypervisor != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// An identifier for the symmetric KMS key to use when creating the encrypted AMI. This
        /// parameter is only required if you want to use a non-default KMS key; if this parameter
        /// is not specified, the default KMS key for EBS is used. If a <c>KmsKeyId</c> is specified,
        /// the <c>Encrypted</c> flag must also be set. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key identifier may be provided in any of the following formats: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN using key ID. The ID ARN contains the <c>arn:aws:kms</c> namespace, followed by
        /// the Region of the key, the Amazon Web Services account ID of the key owner, the <c>key</c>
        /// namespace, and then the key ID. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:key/<i>abcd1234-a123-456a-a12b-a123b4cd56ef</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN using key alias. The alias ARN contains the <c>arn:aws:kms</c> namespace, followed
        /// by the Region of the key, the Amazon Web Services account ID of the key owner, the
        /// <c>alias</c> namespace, and then the key alias. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:alias/<i>ExampleAlias</i>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon Web Services parses <c>KmsKeyId</c> asynchronously, meaning that the action
        /// you call may appear to complete even though you provided an invalid identifier. This
        /// action will eventually report failure. 
        /// </para>
        ///  
        /// <para>
        /// The specified KMS key must exist in the Region that the AMI is being copied to.
        /// </para>
        ///  
        /// <para>
        /// Amazon EBS does not support asymmetric KMS keys.
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
        public List<ImportImageLicenseConfigurationRequest> LicenseSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<ImportImageLicenseConfigurationRequest>() : null;

        /// <summary>
        /// Checks to see if the LicenseSpecifications property is set.
        /// </summary>
        internal bool IsSetLicenseSpecifications() => this.LicenseSpecifications != null && (this.LicenseSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// The license type to be used for the Amazon Machine Image (AMI) after importing.
        /// </para>
        ///  
        /// <para>
        /// Specify <c>AWS</c> to replace the source-system license with an Amazon Web Services
        /// license or <c>BYOL</c> to retain the source-system license. Leaving this parameter
        /// undefined is the same as choosing <c>AWS</c> when importing a Windows Server operating
        /// system, and the same as choosing <c>BYOL</c> when importing a Windows client operating
        /// system (such as Windows 10) or a Linux operating system.
        /// </para>
        ///  
        /// <para>
        /// To use <c>BYOL</c>, you must have existing licenses with rights to use these licenses
        /// in a third party cloud, such as Amazon Web Services. For more information, see <a
        /// href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmimport-image-import.html#prerequisites-image">Prerequisites</a>
        /// in the VM Import/Export User Guide.
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
        /// The operating system of the virtual machine. If you import a VM that is compatible
        /// with Unified Extensible Firmware Interface (UEFI) using an EBS snapshot, you must
        /// specify a value for the platform.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>Windows</c> | <c>Linux</c> 
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role to use when not using the default role, 'vmimport'.
        /// </para>
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// Checks to see if the RoleName property is set.
        /// </summary>
        internal bool IsSetRoleName() => this.RoleName != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the import image task during creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UsageOperation. 
        /// <para>
        /// The usage operation value. For more information, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmie_prereqs.html#prerequisites">Licensing
        /// options</a> in the <i>VM Import/Export User Guide</i>.
        /// </para>
        /// </summary>
        public string UsageOperation { get; set; }

        /// <summary>
        /// Checks to see if the UsageOperation property is set.
        /// </summary>
        internal bool IsSetUsageOperation() => this.UsageOperation != null;
    }
}
