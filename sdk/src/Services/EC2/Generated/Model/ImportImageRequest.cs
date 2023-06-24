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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ImportImage operation.
    /// <note> 
    /// <para>
    /// To import your virtual machines (VMs) with a console-based experience, you can use
    /// the <i>Import virtual machine images to Amazon Web Services</i> template in the <a
    /// href="https://console.aws.amazon.com/migrationhub/orchestrator">Migration Hub Orchestrator
    /// console</a>. For more information, see the <a href="https://docs.aws.amazon.com/migrationhub-orchestrator/latest/userguide/import-vm-images.html">
    /// <i>Migration Hub Orchestrator User Guide</i> </a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Import single or multi-volume disk images or EBS snapshots into an Amazon Machine
    /// Image (AMI).
    /// </para>
    ///  <important> 
    /// <para>
    /// Amazon Web Services VM Import/Export strongly recommends specifying a value for either
    /// the <code>--license-type</code> or <code>--usage-operation</code> parameter when you
    /// create a new VM Import task. This ensures your operating system is licensed appropriately
    /// and your billing is optimized.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmimport-image-import.html">Importing
    /// a VM as an image using VM Import/Export</a> in the <i>VM Import/Export User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ImportImageRequest : AmazonEC2Request
    {
        private string _architecture;
        private BootModeValues _bootMode;
        private ClientData _clientData;
        private string _clientToken;
        private string _description;
        private List<ImageDiskContainer> _diskContainers = new List<ImageDiskContainer>();
        private bool? _encrypted;
        private string _hypervisor;
        private string _kmsKeyId;
        private List<ImportImageLicenseConfigurationRequest> _licenseSpecifications = new List<ImportImageLicenseConfigurationRequest>();
        private string _licenseType;
        private string _platform;
        private string _roleName;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private string _usageOperation;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the virtual machine.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>i386</code> | <code>x86_64</code> 
        /// </para>
        /// </summary>
        public string Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property BootMode. 
        /// <para>
        /// The boot mode of the virtual machine.
        /// </para>
        /// </summary>
        public BootModeValues BootMode
        {
            get { return this._bootMode; }
            set { this._bootMode = value; }
        }

        // Check to see if BootMode property is set
        internal bool IsSetBootMode()
        {
            return this._bootMode != null;
        }

        /// <summary>
        /// Gets and sets the property ClientData. 
        /// <para>
        /// The client-specific data.
        /// </para>
        /// </summary>
        public ClientData ClientData
        {
            get { return this._clientData; }
            set { this._clientData = value; }
        }

        // Check to see if ClientData property is set
        internal bool IsSetClientData()
        {
            return this._clientData != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The token to enable idempotency for VM import requests.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description string for the import image task.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DiskContainers. 
        /// <para>
        /// Information about the disk containers.
        /// </para>
        /// </summary>
        public List<ImageDiskContainer> DiskContainers
        {
            get { return this._diskContainers; }
            set { this._diskContainers = value; }
        }

        // Check to see if DiskContainers property is set
        internal bool IsSetDiskContainers()
        {
            return this._diskContainers != null && this._diskContainers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Specifies whether the destination AMI of the imported image should be encrypted. The
        /// default KMS key for EBS is used unless you specify a non-default KMS key using <code>KmsKeyId</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Hypervisor. 
        /// <para>
        /// The target hypervisor platform.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>xen</code> 
        /// </para>
        /// </summary>
        public string Hypervisor
        {
            get { return this._hypervisor; }
            set { this._hypervisor = value; }
        }

        // Check to see if Hypervisor property is set
        internal bool IsSetHypervisor()
        {
            return this._hypervisor != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// An identifier for the symmetric KMS key to use when creating the encrypted AMI. This
        /// parameter is only required if you want to use a non-default KMS key; if this parameter
        /// is not specified, the default KMS key for EBS is used. If a <code>KmsKeyId</code>
        /// is specified, the <code>Encrypted</code> flag must also be set. 
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
        /// Key alias. The alias ARN contains the <code>arn:aws:kms</code> namespace, followed
        /// by the Region of the key, the Amazon Web Services account ID of the key owner, the
        /// <code>alias</code> namespace, and then the key alias. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:alias/<i>ExampleAlias</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN using key ID. The ID ARN contains the <code>arn:aws:kms</code> namespace, followed
        /// by the Region of the key, the Amazon Web Services account ID of the key owner, the
        /// <code>key</code> namespace, and then the key ID. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:key/<i>abcd1234-a123-456a-a12b-a123b4cd56ef</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN using key alias. The alias ARN contains the <code>arn:aws:kms</code> namespace,
        /// followed by the Region of the key, the Amazon Web Services account ID of the key owner,
        /// the <code>alias</code> namespace, and then the key alias. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:alias/<i>ExampleAlias</i>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon Web Services parses <code>KmsKeyId</code> asynchronously, meaning that the
        /// action you call may appear to complete even though you provided an invalid identifier.
        /// This action will eventually report failure. 
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
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseSpecifications. 
        /// <para>
        /// The ARNs of the license configurations.
        /// </para>
        /// </summary>
        public List<ImportImageLicenseConfigurationRequest> LicenseSpecifications
        {
            get { return this._licenseSpecifications; }
            set { this._licenseSpecifications = value; }
        }

        // Check to see if LicenseSpecifications property is set
        internal bool IsSetLicenseSpecifications()
        {
            return this._licenseSpecifications != null && this._licenseSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// The license type to be used for the Amazon Machine Image (AMI) after importing.
        /// </para>
        ///  
        /// <para>
        /// Specify <code>AWS</code> to replace the source-system license with an Amazon Web Services
        /// license or <code>BYOL</code> to retain the source-system license. Leaving this parameter
        /// undefined is the same as choosing <code>AWS</code> when importing a Windows Server
        /// operating system, and the same as choosing <code>BYOL</code> when importing a Windows
        /// client operating system (such as Windows 10) or a Linux operating system.
        /// </para>
        ///  
        /// <para>
        /// To use <code>BYOL</code>, you must have existing licenses with rights to use these
        /// licenses in a third party cloud, such as Amazon Web Services. For more information,
        /// see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmimport-image-import.html#prerequisites-image">Prerequisites</a>
        /// in the VM Import/Export User Guide.
        /// </para>
        /// </summary>
        public string LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }

        // Check to see if LicenseType property is set
        internal bool IsSetLicenseType()
        {
            return this._licenseType != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system of the virtual machine.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>Windows</code> | <code>Linux</code> 
        /// </para>
        /// </summary>
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role to use when not using the default role, 'vmimport'.
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the import image task during creation.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UsageOperation. 
        /// <para>
        /// The usage operation value. For more information, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmie_prereqs.html#prerequisites">Licensing
        /// options</a> in the <i>VM Import/Export User Guide</i>.
        /// </para>
        /// </summary>
        public string UsageOperation
        {
            get { return this._usageOperation; }
            set { this._usageOperation = value; }
        }

        // Check to see if UsageOperation property is set
        internal bool IsSetUsageOperation()
        {
            return this._usageOperation != null;
        }

    }
}