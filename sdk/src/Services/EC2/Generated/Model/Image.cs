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
    /// Describes an image.
    /// </summary>
    public partial class Image
    {
        private ArchitectureValues _architecture;
        private List<BlockDeviceMapping> _blockDeviceMappings = new List<BlockDeviceMapping>();
        private BootModeValues _bootMode;
        private string _creationDate;
        private string _deprecationTime;
        private string _description;
        private bool? _enaSupport;
        private HypervisorType _hypervisor;
        private string _imageId;
        private string _imageLocation;
        private string _imageOwnerAlias;
        private ImageTypeValues _imageType;
        private ImdsSupportValues _imdsSupport;
        private string _kernelId;
        private string _name;
        private string _ownerId;
        private PlatformValues _platform;
        private string _platformDetails;
        private List<ProductCode> _productCodes = new List<ProductCode>();
        private bool? _public;
        private string _ramdiskId;
        private string _rootDeviceName;
        private DeviceType _rootDeviceType;
        private string _sriovNetSupport;
        private ImageState _state;
        private StateReason _stateReason;
        private List<Tag> _tags = new List<Tag>();
        private TpmSupportValues _tpmSupport;
        private string _usageOperation;
        private VirtualizationType _virtualizationType;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the image.
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
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// Any block device mapping entries.
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
        /// The boot mode of the image. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-boot.html">Boot
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time the image was created.
        /// </para>
        /// </summary>
        public string CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property DeprecationTime. 
        /// <para>
        /// The date and time to deprecate the AMI, in UTC, in the following format: <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z.
        /// If you specified a value for seconds, Amazon EC2 rounds the seconds to the nearest
        /// minute.
        /// </para>
        /// </summary>
        public string DeprecationTime
        {
            get { return this._deprecationTime; }
            set { this._deprecationTime = value; }
        }

        // Check to see if DeprecationTime property is set
        internal bool IsSetDeprecationTime()
        {
            return this._deprecationTime != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the AMI that was provided during image creation.
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
        /// Specifies whether enhanced networking with ENA is enabled.
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
        /// Gets and sets the property Hypervisor. 
        /// <para>
        /// The hypervisor type of the image.
        /// </para>
        /// </summary>
        public HypervisorType Hypervisor
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
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property ImageLocation. 
        /// <para>
        /// The location of the AMI.
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
        /// Gets and sets the property ImageOwnerAlias. 
        /// <para>
        /// The Amazon Web Services account alias (for example, <code>amazon</code>, <code>self</code>)
        /// or the Amazon Web Services account ID of the AMI owner.
        /// </para>
        /// </summary>
        public string ImageOwnerAlias
        {
            get { return this._imageOwnerAlias; }
            set { this._imageOwnerAlias = value; }
        }

        // Check to see if ImageOwnerAlias property is set
        internal bool IsSetImageOwnerAlias()
        {
            return this._imageOwnerAlias != null;
        }

        /// <summary>
        /// Gets and sets the property ImageType. 
        /// <para>
        /// The type of image.
        /// </para>
        /// </summary>
        public ImageTypeValues ImageType
        {
            get { return this._imageType; }
            set { this._imageType = value; }
        }

        // Check to see if ImageType property is set
        internal bool IsSetImageType()
        {
            return this._imageType != null;
        }

        /// <summary>
        /// Gets and sets the property ImdsSupport. 
        /// <para>
        /// If <code>v2.0</code>, it indicates that IMDSv2 is specified in the AMI. Instances
        /// launched from this AMI will have <code>HttpTokens</code> automatically set to <code>required</code>
        /// so that, by default, the instance requires that IMDSv2 is used when requesting instance
        /// metadata. In addition, <code>HttpPutResponseHopLimit</code> is set to <code>2</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-IMDS-new-instances.html#configure-IMDS-new-instances-ami-configuration">Configure
        /// the AMI</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
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
        /// The kernel associated with the image, if any. Only applicable for machine images.
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
        /// The name of the AMI that was provided during image creation.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the image.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// This value is set to <code>windows</code> for Windows AMIs; otherwise, it is blank.
        /// </para>
        /// </summary>
        public PlatformValues Platform
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
        /// Gets and sets the property PlatformDetails. 
        /// <para>
        /// The platform details associated with the billing code of the AMI. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-billing-info.html">Understand
        /// AMI billing information</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string PlatformDetails
        {
            get { return this._platformDetails; }
            set { this._platformDetails = value; }
        }

        // Check to see if PlatformDetails property is set
        internal bool IsSetPlatformDetails()
        {
            return this._platformDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// Any product codes associated with the AMI.
        /// </para>
        /// </summary>
        public List<ProductCode> ProductCodes
        {
            get { return this._productCodes; }
            set { this._productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this._productCodes != null && this._productCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Public. 
        /// <para>
        /// Indicates whether the image has public launch permissions. The value is <code>true</code>
        /// if this image has public launch permissions or <code>false</code> if it has only implicit
        /// and explicit launch permissions.
        /// </para>
        /// </summary>
        public bool Public
        {
            get { return this._public.GetValueOrDefault(); }
            set { this._public = value; }
        }

        // Check to see if Public property is set
        internal bool IsSetPublic()
        {
            return this._public.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The RAM disk associated with the image, if any. Only applicable for machine images.
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
        /// Gets and sets the property RootDeviceType. 
        /// <para>
        /// The type of root device used by the AMI. The AMI can use an Amazon EBS volume or an
        /// instance store volume.
        /// </para>
        /// </summary>
        public DeviceType RootDeviceType
        {
            get { return this._rootDeviceType; }
            set { this._rootDeviceType = value; }
        }

        // Check to see if RootDeviceType property is set
        internal bool IsSetRootDeviceType()
        {
            return this._rootDeviceType != null;
        }

        /// <summary>
        /// Gets and sets the property SriovNetSupport. 
        /// <para>
        /// Specifies whether enhanced networking with the Intel 82599 Virtual Function interface
        /// is enabled.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the AMI. If the state is <code>available</code>, the image is
        /// successfully registered and can be used to launch an instance.
        /// </para>
        /// </summary>
        public ImageState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the state change.
        /// </para>
        /// </summary>
        public StateReason StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the image.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TpmSupport. 
        /// <para>
        /// If the image is configured for NitroTPM support, the value is <code>v2.0</code>. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitrotpm.html">NitroTPM</a>
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
        /// Gets and sets the property UsageOperation. 
        /// <para>
        /// The operation of the Amazon EC2 instance and the billing code that is associated with
        /// the AMI. <code>usageOperation</code> corresponds to the <a href="https://docs.aws.amazon.com/cur/latest/userguide/Lineitem-columns.html#Lineitem-details-O-Operation">lineitem/Operation</a>
        /// column on your Amazon Web Services Cost and Usage Report and in the <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/price-changes.html">Amazon
        /// Web Services Price List API</a>. You can view these fields on the <b>Instances</b>
        /// or <b>AMIs</b> pages in the Amazon EC2 console, or in the responses that are returned
        /// by the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeImages.html">DescribeImages</a>
        /// command in the Amazon EC2 API, or the <a href="https://docs.aws.amazon.com/cli/latest/reference/ec2/describe-images.html">describe-images</a>
        /// command in the CLI.
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

        /// <summary>
        /// Gets and sets the property VirtualizationType. 
        /// <para>
        /// The type of virtualization of the AMI.
        /// </para>
        /// </summary>
        public VirtualizationType VirtualizationType
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