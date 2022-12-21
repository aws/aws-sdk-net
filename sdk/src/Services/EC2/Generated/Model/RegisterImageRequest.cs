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
    /// Container for the parameters to the RegisterImage operation.
    /// Registers an AMI. When you're creating an AMI, this is the final step you must complete
    /// before you can launch an instance from the AMI. For more information about creating
    /// AMIs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami.html">Create
    /// your own AMI</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// For Amazon EBS-backed instances, <a>CreateImage</a> creates and registers the AMI
    /// in a single request, so you don't have to register the AMI yourself. We recommend
    /// that you always use <a>CreateImage</a> unless you have a specific reason to use RegisterImage.
    /// </para>
    ///  </note> 
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
    /// You can use <code>RegisterImage</code> to create an Amazon EBS-backed Linux AMI from
    /// a snapshot of a root device volume. You specify the snapshot using a block device
    /// mapping. You can't set the encryption state of the volume using the block device mapping.
    /// If the snapshot is encrypted, or encryption by default is enabled, the root volume
    /// of an instance launched from the AMI is encrypted.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html#creating-launching-ami-from-snapshot">Create
    /// a Linux AMI from a snapshot</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AMIEncryption.html">Use
    /// encryption with Amazon EBS-backed AMIs</a> in the <i>Amazon Elastic Compute Cloud
    /// User Guide</i>.
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
    /// Windows and some Linux distributions, such as Red Hat Enterprise Linux (RHEL) and
    /// SUSE Linux Enterprise Server (SLES), use the Amazon EC2 billing product code associated
    /// with an AMI to verify the subscription status for package updates. To create a new
    /// AMI for operating systems that require a billing product code, instead of registering
    /// the AMI, do the following to preserve the billing product code association:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Launch an instance from an existing AMI with that billing product code.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Customize the instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create an AMI from the instance using <a>CreateImage</a>.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// If you purchase a Reserved Instance to apply to an On-Demand Instance that was launched
    /// from an AMI with a billing product code, make sure that the Reserved Instance has
    /// the matching billing product code. If you purchase a Reserved Instance without the
    /// matching billing product code, the Reserved Instance will not be applied to the On-Demand
    /// Instance. For information about how to obtain the platform details and billing information
    /// of an AMI, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-billing-info.html">Understand
    /// AMI billing information</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class RegisterImageRequest : AmazonEC2Request
    {
        private ArchitectureValues _architecture;
        private List<string> _billingProducts = new List<string>();
        private List<BlockDeviceMapping> _blockDeviceMappings = new List<BlockDeviceMapping>();
        private BootModeValues _bootMode;
        private string _description;
        private bool? _enaSupport;
        private string _imageLocation;
        private ImdsSupportValues _imdsSupport;
        private string _kernelId;
        private string _name;
        private string _ramdiskId;
        private string _rootDeviceName;
        private string _sriovNetSupport;
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
        /// <param name="imageLocation">The full path to your AMI manifest in Amazon S3 storage. The specified bucket must have the <code>aws-exec-read</code> canned access control list (ACL) to ensure that it can be accessed by Amazon EC2. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#canned-acl">Canned ACLs</a> in the <i>Amazon S3 Service Developer Guide</i>.</param>
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
        /// Default: For Amazon EBS-backed AMIs, <code>i386</code>. For instance store-backed
        /// AMIs, the architecture specified in the manifest file.
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
        /// started as a seller</a> and <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/ami-products.html">AMI-based
        /// products</a> in the <i>Amazon Web Services Marketplace Seller Guide</i>.
        /// </para>
        /// </summary>
        public List<string> BillingProducts
        {
            get { return this._billingProducts; }
            set { this._billingProducts = value; }
        }

        // Check to see if BillingProducts property is set
        internal bool IsSetBillingProducts()
        {
            return this._billingProducts != null && this._billingProducts.Count > 0; 
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
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshots-outposts.html#ami">Amazon
        /// EBS local snapshots on Outposts</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get { return this._blockDeviceMappings; }
            set { this._blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this._blockDeviceMappings != null && this._blockDeviceMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BootMode. 
        /// <para>
        /// The boot mode of the AMI. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-boot.html">Boot
        /// modes</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// Gets and sets the property EnaSupport. 
        /// <para>
        /// Set to <code>true</code> to enable enhanced networking with ENA for the AMI and any
        /// instances that you launch from the AMI.
        /// </para>
        ///  
        /// <para>
        /// This option is supported only for HVM AMIs. Specifying this option with a PV AMI can
        /// make instances launched from the AMI unreachable.
        /// </para>
        /// </summary>
        public bool EnaSupport
        {
            get { return this._enaSupport.GetValueOrDefault(); }
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
        /// have the <code>aws-exec-read</code> canned access control list (ACL) to ensure that
        /// it can be accessed by Amazon EC2. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#canned-acl">Canned
        /// ACLs</a> in the <i>Amazon S3 Service Developer Guide</i>.
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
        /// Set to <code>v2.0</code> to indicate that IMDSv2 is specified in the AMI. Instances
        /// launched from this AMI will have <code>HttpTokens</code> automatically set to <code>required</code>
        /// so that, by default, the instance requires that IMDSv2 is used when requesting instance
        /// metadata. In addition, <code>HttpPutResponseHopLimit</code> is set to <code>2</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-IMDS-new-instances.html#configure-IMDS-new-instances-ami-configuration">Configure
        /// the AMI</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set the value to <code>v2.0</code>, make sure that your AMI software can support
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
        /// The device name of the root device volume (for example, <code>/dev/sda1</code>).
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
        /// Set to <code>simple</code> to enable enhanced networking with the Intel 82599 Virtual
        /// Function interface for the AMI and any instances that you launch from the AMI.
        /// </para>
        ///  
        /// <para>
        /// There is no way to disable <code>sriovNetSupport</code> at this time.
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
        /// Gets and sets the property TpmSupport. 
        /// <para>
        /// Set to <code>v2.0</code> to enable Trusted Platform Module (TPM) support. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitrotpm.html">NitroTPM</a>
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
        /// Secure Boot</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// The type of virtualization (<code>hvm</code> | <code>paravirtual</code>).
        /// </para>
        ///  
        /// <para>
        /// Default: <code>paravirtual</code> 
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