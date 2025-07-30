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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterImage operation.
    /// Registers an AMI. When you're creating an instance-store backed AMI, registering the
    /// AMI is the final step in the creation process. For more information about creating
    /// AMIs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html#creating-launching-ami-from-snapshot">Create
    /// an AMI from a snapshot</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-instance-store.html">Create
    /// an instance-store backed AMI</a> in the <i>Amazon EC2 User Guide</i>.
    /// 
    ///  
    /// <para>
    /// If needed, you can deregister an AMI at any time. Any modifications you make to an
    /// AMI backed by an instance store volume invalidates its registration. If you make changes
    /// to an image, deregister the previous image and register the new image.
    /// </para>
    ///  
    /// <para>
    ///  <b>Register a snapshot of a root device volume</b> 
    /// </para>
    ///  
    /// <para>
    /// You can use <c>RegisterImage</c> to create an Amazon EBS-backed Linux AMI from a snapshot
    /// of a root device volume. You specify the snapshot using a block device mapping. You
    /// can't set the encryption state of the volume using the block device mapping. If the
    /// snapshot is encrypted, or encryption by default is enabled, the root volume of an
    /// instance launched from the AMI is encrypted.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html#creating-launching-ami-from-snapshot">Create
    /// an AMI from a snapshot</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AMIEncryption.html">Use
    /// encryption with EBS-backed AMIs</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Amazon Web Services Marketplace product codes</b> 
    /// </para>
    ///  
    /// <para>
    /// If any snapshots have Amazon Web Services Marketplace product codes, they are copied
    /// to the new AMI.
    /// </para>
    ///  
    /// <para>
    /// In most cases, AMIs for Windows, RedHat, SUSE, and SQL Server require correct licensing
    /// information to be present on the AMI. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-billing-info.html">Understand
    /// AMI billing information</a> in the <i>Amazon EC2 User Guide</i>. When creating an
    /// AMI from a snapshot, the <c>RegisterImage</c> operation derives the correct billing
    /// information from the snapshot's metadata, but this requires the appropriate metadata
    /// to be present. To verify if the correct billing information was applied, check the
    /// <c>PlatformDetails</c> field on the new AMI. If the field is empty or doesn't match
    /// the expected operating system code (for example, Windows, RedHat, SUSE, or SQL), the
    /// AMI creation was unsuccessful, and you should discard the AMI and instead create the
    /// AMI from an instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html#how-to-create-ebs-ami">Create
    /// an AMI from an instance </a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you purchase a Reserved Instance to apply to an On-Demand Instance that was launched
    /// from an AMI with a billing product code, make sure that the Reserved Instance has
    /// the matching billing product code. If you purchase a Reserved Instance without the
    /// matching billing product code, the Reserved Instance is not applied to the On-Demand
    /// Instance. For information about how to obtain the platform details and billing information
    /// of an AMI, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-billing-info.html">Understand
    /// AMI billing information</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class RegisterImageRequest : AmazonEC2Request
    {
        private ArchitectureValues _architecture;
        private List<string> _billingProducts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<BlockDeviceMapping> _blockDeviceMappings = AWSConfigs.InitializeCollections ? new List<BlockDeviceMapping>() : null;
        private BootModeValues _bootMode;
        private string _description;
        private bool? _dryRun;
        private bool? _enaSupport;
        private string _imageLocation;
        private ImdsSupportValues _imdsSupport;
        private string _kernelId;
        private string _name;
        private string _ramdiskId;
        private string _rootDeviceName;
        private string _sriovNetSupport;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private TpmSupportValues _tpmSupport;
        private string _uefiData;
        private string _virtualizationType;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RegisterImageRequest() { }

        /// <summary>
        /// Instantiates RegisterImageRequest with the parameterized properties
        /// </summary>
        /// <param name="imageLocation">The full path to your AMI manifest in Amazon S3 storage. The specified bucket must have the <c>aws-exec-read</c> canned access control list (ACL) to ensure that it can be accessed by Amazon EC2. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#canned-acl">Canned ACL</a> in the <i>Amazon S3 Service Developer Guide</i>.</param>
        public RegisterImageRequest(string imageLocation)
        {
            _imageLocation = imageLocation;
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
        public ArchitectureValues Architecture
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BillingProducts
        {
            get { return this._billingProducts; }
            set { this._billingProducts = value; }
        }

        // Check to see if BillingProducts property is set
        internal bool IsSetBillingProducts()
        {
            return this._billingProducts != null && (this._billingProducts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get { return this._blockDeviceMappings; }
            set { this._blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this._blockDeviceMappings != null && (this._blockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for your AMI.
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

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
        public bool? EnaSupport
        {
            get { return this._enaSupport; }
            set { this._enaSupport = value; }
        }

        // Check to see if EnaSupport property is set
        internal bool IsSetEnaSupport()
        {
            return this._enaSupport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageLocation. 
        /// <para>
        /// The full path to your AMI manifest in Amazon S3 storage. The specified bucket must
        /// have the <c>aws-exec-read</c> canned access control list (ACL) to ensure that it can
        /// be accessed by Amazon EC2. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#canned-acl">Canned
        /// ACL</a> in the <i>Amazon S3 Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ImageLocation
        {
            get { return this._imageLocation; }
            set { this._imageLocation = value; }
        }

        // Check to see if ImageLocation property is set
        internal bool IsSetImageLocation()
        {
            return this._imageLocation != null;
        }

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
        public ImdsSupportValues ImdsSupport
        {
            get { return this._imdsSupport; }
            set { this._imdsSupport = value; }
        }

        // Check to see if ImdsSupport property is set
        internal bool IsSetImdsSupport()
        {
            return this._imdsSupport != null;
        }

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The ID of the kernel.
        /// </para>
        /// </summary>
        public string KernelId
        {
            get { return this._kernelId; }
            set { this._kernelId = value; }
        }

        // Check to see if KernelId property is set
        internal bool IsSetKernelId()
        {
            return this._kernelId != null;
        }

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
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The ID of the RAM disk.
        /// </para>
        /// </summary>
        public string RamdiskId
        {
            get { return this._ramdiskId; }
            set { this._ramdiskId = value; }
        }

        // Check to see if RamdiskId property is set
        internal bool IsSetRamdiskId()
        {
            return this._ramdiskId != null;
        }

        /// <summary>
        /// Gets and sets the property RootDeviceName. 
        /// <para>
        /// The device name of the root device volume (for example, <c>/dev/sda1</c>).
        /// </para>
        /// </summary>
        public string RootDeviceName
        {
            get { return this._rootDeviceName; }
            set { this._rootDeviceName = value; }
        }

        // Check to see if RootDeviceName property is set
        internal bool IsSetRootDeviceName()
        {
            return this._rootDeviceName != null;
        }

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
        public string SriovNetSupport
        {
            get { return this._sriovNetSupport; }
            set { this._sriovNetSupport = value; }
        }

        // Check to see if SriovNetSupport property is set
        internal bool IsSetSriovNetSupport()
        {
            return this._sriovNetSupport != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TpmSupport. 
        /// <para>
        /// Set to <c>v2.0</c> to enable Trusted Platform Module (TPM) support. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitrotpm.html">NitroTPM</a>
        /// in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public TpmSupportValues TpmSupport
        {
            get { return this._tpmSupport; }
            set { this._tpmSupport = value; }
        }

        // Check to see if TpmSupport property is set
        internal bool IsSetTpmSupport()
        {
            return this._tpmSupport != null;
        }

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
        [AWSProperty(Min=0, Max=64000)]
        public string UefiData
        {
            get { return this._uefiData; }
            set { this._uefiData = value; }
        }

        // Check to see if UefiData property is set
        internal bool IsSetUefiData()
        {
            return this._uefiData != null;
        }

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
        public string VirtualizationType
        {
            get { return this._virtualizationType; }
            set { this._virtualizationType = value; }
        }

        // Check to see if VirtualizationType property is set
        internal bool IsSetVirtualizationType()
        {
            return this._virtualizationType != null;
        }

    }
}