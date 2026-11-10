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
    /// Container for the parameters to the RegisterImage operation. Registers an AMI. When
    /// you're creating an instance-store backed AMI, registering the AMI is the final step
    /// in the creation process. For more information about creating AMIs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html#creating-launching-ami-from-snapshot">Create
    /// an AMI from a snapshot</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-instance-store.html">Create
    /// an instance-store backed AMI</a> in the <i>Amazon EC2 User Guide</i>. <para> If needed,
    /// you can deregister an AMI at any time. Any modifications you make to an AMI backed
    /// by an instance store volume invalidates its registration. If you make changes to an
    /// image, deregister the previous image and register the new image. </para> <para> <b>Register
    /// a snapshot of a root device volume</b> </para> <para> You can use <c>RegisterImage</c>
    /// to create an Amazon EBS-backed Linux AMI from a snapshot of a root device volume.
    /// You specify the snapshot using a block device mapping. You can't set the encryption
    /// state of the volume using the block device mapping. If the snapshot is encrypted,
    /// or encryption by default is enabled, the root volume of an instance launched from
    /// the AMI is encrypted. </para> <para> For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html#creating-launching-ami-from-snapshot">Create
    /// an AMI from a snapshot</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AMIEncryption.html">Use
    /// encryption with EBS-backed AMIs</a> in the <i>Amazon EC2 User Guide</i>. </para> <para>
    /// <b>Amazon Web Services Marketplace product codes</b> </para> <para> If any snapshots
    /// have Amazon Web Services Marketplace product codes, they are copied to the new AMI.
    /// </para> <para> In most cases, AMIs for Windows, RedHat, SUSE, and SQL Server require
    /// correct licensing information to be present on the AMI. For more information, see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-billing-info.html">Understand
    /// AMI billing information</a> in the <i>Amazon EC2 User Guide</i>. When creating an
    /// AMI from a snapshot, the <c>RegisterImage</c> operation derives the correct billing
    /// information from the snapshot's metadata, but this requires the appropriate metadata
    /// to be present. To verify if the correct billing information was applied, check the
    /// <c>PlatformDetails</c> field on the new AMI. If the field is empty or doesn't match
    /// the expected operating system code (for example, Windows, RedHat, SUSE, or SQL), the
    /// AMI creation was unsuccessful, and you should discard the AMI and instead create the
    /// AMI from an instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html#how-to-create-ebs-ami">Create
    /// an AMI from an instance </a> in the <i>Amazon EC2 User Guide</i>. </para> <para> If
    /// you purchase a Reserved Instance to apply to an On-Demand Instance that was launched
    /// from an AMI with a billing product code, make sure that the Reserved Instance has
    /// the matching billing product code. If you purchase a Reserved Instance without the
    /// matching billing product code, the Reserved Instance is not applied to the On-Demand
    /// Instance. For information about how to obtain the platform details and billing information
    /// of an AMI, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-billing-info.html">Understand
    /// AMI billing information</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// </summary>
    public partial class RegisterImageRequest : AmazonEC2Request
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public RegisterImageRequest() { }

        /// <summary>
        /// Instantiates RegisterImageRequest with the parameterized properties
        /// </summary>
        /// <param name="imageLocation">The full path to your AMI manifest in Amazon S3 storage. The specified bucket must have the  <c>aws-exec-read</c> canned access control list (ACL) to ensure that it can be   accessed by Amazon EC2. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#canned-acl">Canned ACL</a> in the  <i>Amazon S3 Service Developer Guide</i>.</param>
        public RegisterImageRequest(string imageLocation)
        {
            this.ImageLocation = imageLocation;
        }

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the AMI.
        /// </para>
        ///  
        /// <para>
        /// Default: For Amazon EBS-backed AMIs, <c>i386</c>. For instance store-backed AMIs,
        /// the architecture specified in the manifest file.
        /// </para>
        /// </summary>
        public ArchitectureValues Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property BillingProducts. 
        /// <para>
        /// The billing product codes. Your account must be authorized to specify billing product
        /// codes.
        /// </para>
        ///  
        /// <para>
        /// If your account is not authorized to specify billing product codes, you can publish
        /// AMIs that include billable software and list them on the Amazon Web Services Marketplace.
        /// You must first register as a seller on the Amazon Web Services Marketplace. For more
        /// information, see <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/user-guide-for-sellers.html">Getting
        /// started as an Amazon Web Services Marketplace seller</a> and <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/ami-products.html">AMI-based
        /// products in Amazon Web Services Marketplace</a> in the <i>Amazon Web Services Marketplace
        /// Seller Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BillingProducts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BillingProducts property is set.
        /// </summary>
        internal bool IsSetBillingProducts() => this.BillingProducts != null && (this.BillingProducts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mapping entries.
        /// </para>
        ///  
        /// <para>
        /// If you specify an Amazon EBS volume using the ID of an Amazon EBS snapshot, you can't
        /// specify the encryption state of the volume.
        /// </para>
        ///  
        /// <para>
        /// If you create an AMI on an Outpost, then all backing snapshots must be on the same
        /// Outpost or in the Region of that Outpost. AMIs on an Outpost that include local snapshots
        /// can be used to launch instances on the same Outpost only. For more information, <a
        /// href="https://docs.aws.amazon.com/ebs/latest/userguide/snapshots-outposts.html#ami">Create
        /// AMIs from local snapshots</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<BlockDeviceMapping>() : null;

        /// <summary>
        /// Checks to see if the BlockDeviceMappings property is set.
        /// </summary>
        internal bool IsSetBlockDeviceMappings() => this.BlockDeviceMappings != null && (this.BlockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BootMode. 
        /// <para>
        /// The boot mode of the AMI. A value of <c>uefi-preferred</c> indicates that the AMI
        /// supports both UEFI and Legacy BIOS.
        /// </para>
        ///  <note> 
        /// <para>
        /// The operating system contained in the AMI must be configured to support the specified
        /// boot mode.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-boot.html">Instance
        /// launch behavior with Amazon EC2 boot modes</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public BootModeValues BootMode { get; set; }

        /// <summary>
        /// Checks to see if the BootMode property is set.
        /// </summary>
        internal bool IsSetBootMode() => this.BootMode != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for your AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// Gets and sets the property EnaSupport. 
        /// <para>
        /// Set to <c>true</c> to enable enhanced networking with ENA for the AMI and any instances
        /// that you launch from the AMI.
        /// </para>
        ///  
        /// <para>
        /// This option is supported only for HVM AMIs. Specifying this option with a PV AMI can
        /// make instances launched from the AMI unreachable.
        /// </para>
        /// </summary>
        public bool? EnaSupport { get; set; }

        /// <summary>
        /// Checks to see if the EnaSupport property is set.
        /// </summary>
        internal bool IsSetEnaSupport() => this.EnaSupport.HasValue;

        /// <summary>
        /// Gets and sets the property ImageLocation. 
        /// <para>
        /// The full path to your AMI manifest in Amazon S3 storage. The specified bucket must
        /// have the <c>aws-exec-read</c> canned access control list (ACL) to ensure that it can
        /// be accessed by Amazon EC2. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#canned-acl">Canned
        /// ACL</a> in the <i>Amazon S3 Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ImageLocation { get; set; }

        /// <summary>
        /// Checks to see if the ImageLocation property is set.
        /// </summary>
        internal bool IsSetImageLocation() => this.ImageLocation != null;

        /// <summary>
        /// Gets and sets the property ImdsSupport. 
        /// <para>
        /// Set to <c>v2.0</c> to indicate that IMDSv2 is specified in the AMI. Instances launched
        /// from this AMI will have <c>HttpTokens</c> automatically set to <c>required</c> so
        /// that, by default, the instance requires that IMDSv2 is used when requesting instance
        /// metadata. In addition, <c>HttpPutResponseHopLimit</c> is set to <c>2</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-IMDS-new-instances.html#configure-IMDS-new-instances-ami-configuration">Configure
        /// the AMI</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set the value to <c>v2.0</c>, make sure that your AMI software can support
        /// IMDSv2.
        /// </para>
        ///  </note>
        /// </summary>
        public ImdsSupportValues ImdsSupport { get; set; }

        /// <summary>
        /// Checks to see if the ImdsSupport property is set.
        /// </summary>
        internal bool IsSetImdsSupport() => this.ImdsSupport != null;

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The ID of the kernel.
        /// </para>
        /// </summary>
        public string KernelId { get; set; }

        /// <summary>
        /// Checks to see if the KernelId property is set.
        /// </summary>
        internal bool IsSetKernelId() => this.KernelId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for your AMI.
        /// </para>
        ///  
        /// <para>
        /// Constraints: 3-128 alphanumeric characters, parentheses (()), square brackets ([]),
        /// spaces ( ), periods (.), slashes (/), dashes (-), single quotes ('), at-signs (@),
        /// or underscores(_)
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The ID of the RAM disk.
        /// </para>
        /// </summary>
        public string RamdiskId { get; set; }

        /// <summary>
        /// Checks to see if the RamdiskId property is set.
        /// </summary>
        internal bool IsSetRamdiskId() => this.RamdiskId != null;

        /// <summary>
        /// Gets and sets the property RootDeviceName. 
        /// <para>
        /// The device name of the root device volume (for example, <c>/dev/sda1</c>).
        /// </para>
        /// </summary>
        public string RootDeviceName { get; set; }

        /// <summary>
        /// Checks to see if the RootDeviceName property is set.
        /// </summary>
        internal bool IsSetRootDeviceName() => this.RootDeviceName != null;

        /// <summary>
        /// Gets and sets the property SriovNetSupport. 
        /// <para>
        /// Set to <c>simple</c> to enable enhanced networking with the Intel 82599 Virtual Function
        /// interface for the AMI and any instances that you launch from the AMI.
        /// </para>
        ///  
        /// <para>
        /// There is no way to disable <c>sriovNetSupport</c> at this time.
        /// </para>
        ///  
        /// <para>
        /// This option is supported only for HVM AMIs. Specifying this option with a PV AMI can
        /// make instances launched from the AMI unreachable.
        /// </para>
        /// </summary>
        public string SriovNetSupport { get; set; }

        /// <summary>
        /// Checks to see if the SriovNetSupport property is set.
        /// </summary>
        internal bool IsSetSriovNetSupport() => this.SriovNetSupport != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the AMI.
        /// </para>
        ///  
        /// <para>
        /// To tag the AMI, the value for <c>ResourceType</c> must be <c>image</c>. If you specify
        /// another value for <c>ResourceType</c>, the request fails.
        /// </para>
        ///  
        /// <para>
        /// To tag an AMI after it has been registered, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTags.html">CreateTags</a>.
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
        /// Gets and sets the property TpmSupport. 
        /// <para>
        /// Set to <c>v2.0</c> to enable Trusted Platform Module (TPM) support. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitrotpm.html">NitroTPM</a>
        /// in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public TpmSupportValues TpmSupport { get; set; }

        /// <summary>
        /// Checks to see if the TpmSupport property is set.
        /// </summary>
        internal bool IsSetTpmSupport() => this.TpmSupport != null;

        /// <summary>
        /// Gets and sets the property UefiData. 
        /// <para>
        /// Base64 representation of the non-volatile UEFI variable store. To retrieve the UEFI
        /// data, use the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_GetInstanceUefiData">GetInstanceUefiData</a>
        /// command. You can inspect and modify the UEFI data by using the <a href="https://github.com/awslabs/python-uefivars">python-uefivars
        /// tool</a> on GitHub. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/uefi-secure-boot.html">UEFI
        /// Secure Boot for Amazon EC2 instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 64000)]
        public string UefiData { get; set; }

        /// <summary>
        /// Checks to see if the UefiData property is set.
        /// </summary>
        internal bool IsSetUefiData() => this.UefiData != null;

        /// <summary>
        /// Gets and sets the property VirtualizationType. 
        /// <para>
        /// The type of virtualization (<c>hvm</c> | <c>paravirtual</c>).
        /// </para>
        ///  
        /// <para>
        /// Default: <c>paravirtual</c> 
        /// </para>
        /// </summary>
        public string VirtualizationType { get; set; }

        /// <summary>
        /// Checks to see if the VirtualizationType property is set.
        /// </summary>
        internal bool IsSetVirtualizationType() => this.VirtualizationType != null;
    }
}
