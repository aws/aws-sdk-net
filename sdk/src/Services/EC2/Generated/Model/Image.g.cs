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
    /// Describes an image.
    /// </summary>
    public partial class Image
    {
        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the image.
        /// </para>
        /// </summary>
        public ArchitectureValues Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// Any block device mapping entries.
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
        /// The boot mode of the image. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-boot.html">Instance
        /// launch behavior with Amazon EC2 boot modes</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public BootModeValues BootMode { get; set; }

        /// <summary>
        /// Checks to see if the BootMode property is set.
        /// </summary>
        internal bool IsSetBootMode() => this.BootMode != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time the image was created.
        /// </para>
        /// </summary>
        public string CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate != null;

        /// <summary>
        /// Gets and sets the property DeprecationTime. 
        /// <para>
        /// The date and time to deprecate the AMI, in UTC, in the following format: <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z.
        /// If you specified a value for seconds, Amazon EC2 rounds the seconds to the nearest
        /// minute.
        /// </para>
        /// </summary>
        public string DeprecationTime { get; set; }

        /// <summary>
        /// Checks to see if the DeprecationTime property is set.
        /// </summary>
        internal bool IsSetDeprecationTime() => this.DeprecationTime != null;

        /// <summary>
        /// Gets and sets the property DeregistrationProtection. 
        /// <para>
        /// Indicates whether deregistration protection is enabled for the AMI.
        /// </para>
        /// </summary>
        public string DeregistrationProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeregistrationProtection property is set.
        /// </summary>
        internal bool IsSetDeregistrationProtection() => this.DeregistrationProtection != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the AMI that was provided during image creation.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnaSupport. 
        /// <para>
        /// Specifies whether enhanced networking with ENA is enabled.
        /// </para>
        /// </summary>
        public bool? EnaSupport { get; set; }

        /// <summary>
        /// Checks to see if the EnaSupport property is set.
        /// </summary>
        internal bool IsSetEnaSupport() => this.EnaSupport.HasValue;

        /// <summary>
        /// Gets and sets the property FreeTierEligible. 
        /// <para>
        /// Indicates whether the image is eligible for Amazon Web Services Free Tier.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>true</c>, the AMI is eligible for Free Tier and can be used to launch instances
        /// under the Free Tier limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>false</c>, the AMI is not eligible for Free Tier.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? FreeTierEligible { get; set; }

        /// <summary>
        /// Checks to see if the FreeTierEligible property is set.
        /// </summary>
        internal bool IsSetFreeTierEligible() => this.FreeTierEligible.HasValue;

        /// <summary>
        /// Gets and sets the property Hypervisor. 
        /// <para>
        /// The hypervisor type of the image. Only <c>xen</c> is supported. <c>ovm</c> is not
        /// supported.
        /// </para>
        /// </summary>
        public HypervisorType Hypervisor { get; set; }

        /// <summary>
        /// Checks to see if the Hypervisor property is set.
        /// </summary>
        internal bool IsSetHypervisor() => this.Hypervisor != null;

        /// <summary>
        /// Gets and sets the property ImageAllowed. 
        /// <para>
        /// If <c>true</c>, the AMI satisfies the criteria for Allowed AMIs and can be discovered
        /// and used in the account. If <c>false</c> and Allowed AMIs is set to <c>enabled</c>,
        /// the AMI can't be discovered or used in the account. If <c>false</c> and Allowed AMIs
        /// is set to <c>audit-mode</c>, the AMI can be discovered and used in the account.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-allowed-amis.html">Control
        /// the discovery and use of AMIs in Amazon EC2 with Allowed AMIs</a> in <i>Amazon EC2
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public bool? ImageAllowed { get; set; }

        /// <summary>
        /// Checks to see if the ImageAllowed property is set.
        /// </summary>
        internal bool IsSetImageAllowed() => this.ImageAllowed.HasValue;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property ImageLocation. 
        /// <para>
        /// The location of the AMI.
        /// </para>
        /// </summary>
        public string ImageLocation { get; set; }

        /// <summary>
        /// Checks to see if the ImageLocation property is set.
        /// </summary>
        internal bool IsSetImageLocation() => this.ImageLocation != null;

        /// <summary>
        /// Gets and sets the property ImageOwnerAlias. 
        /// <para>
        /// The owner alias (<c>amazon</c> | <c>aws-backup-vault</c> | <c>aws-marketplace</c>).
        /// </para>
        /// </summary>
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// Checks to see if the ImageOwnerAlias property is set.
        /// </summary>
        internal bool IsSetImageOwnerAlias() => this.ImageOwnerAlias != null;

        /// <summary>
        /// Gets and sets the property ImageType. 
        /// <para>
        /// The type of image.
        /// </para>
        /// </summary>
        public ImageTypeValues ImageType { get; set; }

        /// <summary>
        /// Checks to see if the ImageType property is set.
        /// </summary>
        internal bool IsSetImageType() => this.ImageType != null;

        /// <summary>
        /// Gets and sets the property ImageWatermarks. 
        /// <para>
        /// The watermarks attached to the AMI.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ImageWatermark> ImageWatermarks { get; set; } = AWSConfigs.InitializeCollections ? new List<ImageWatermark>() : null;

        /// <summary>
        /// Checks to see if the ImageWatermarks property is set.
        /// </summary>
        internal bool IsSetImageWatermarks() => this.ImageWatermarks != null && (this.ImageWatermarks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImdsSupport. 
        /// <para>
        /// If <c>v2.0</c>, it indicates that IMDSv2 is specified in the AMI. Instances launched
        /// from this AMI will have <c>HttpTokens</c> automatically set to <c>required</c> so
        /// that, by default, the instance requires that IMDSv2 is used when requesting instance
        /// metadata. In addition, <c>HttpPutResponseHopLimit</c> is set to <c>2</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-IMDS-new-instances.html#configure-IMDS-new-instances-ami-configuration">Configure
        /// the AMI</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public ImdsSupportValues ImdsSupport { get; set; }

        /// <summary>
        /// Checks to see if the ImdsSupport property is set.
        /// </summary>
        internal bool IsSetImdsSupport() => this.ImdsSupport != null;

        /// <summary>
        /// Gets and sets the property InstanceTypeSpecification. 
        /// <para>
        /// The instance type specification for the AMI, which defines which instance types are
        /// compatible with this image.
        /// </para>
        /// </summary>
        public InstanceTypeSpecification InstanceTypeSpecification { get; set; }

        /// <summary>
        /// Checks to see if the InstanceTypeSpecification property is set.
        /// </summary>
        internal bool IsSetInstanceTypeSpecification() => this.InstanceTypeSpecification != null;

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The kernel associated with the image, if any. Only applicable for machine images.
        /// </para>
        /// </summary>
        public string KernelId { get; set; }

        /// <summary>
        /// Checks to see if the KernelId property is set.
        /// </summary>
        internal bool IsSetKernelId() => this.KernelId != null;

        /// <summary>
        /// Gets and sets the property LastLaunchedTime. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the AMI was last used to launch an EC2 instance. When the AMI is
        /// used to launch an instance, there is a 24-hour delay before that usage is reported.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>lastLaunchedTime</c> data is available starting April 2017.
        /// </para>
        ///  </note>
        /// </summary>
        public string LastLaunchedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastLaunchedTime property is set.
        /// </summary>
        internal bool IsSetLastLaunchedTime() => this.LastLaunchedTime != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the AMI that was provided during image creation.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the image.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// This value is set to <c>windows</c> for Windows AMIs; otherwise, it is blank.
        /// </para>
        /// </summary>
        public PlatformValues Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property PlatformDetails. 
        /// <para>
        /// The platform details associated with the billing code of the AMI. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-billing-info.html">Understand
        /// AMI billing information</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string PlatformDetails { get; set; }

        /// <summary>
        /// Checks to see if the PlatformDetails property is set.
        /// </summary>
        internal bool IsSetPlatformDetails() => this.PlatformDetails != null;

        /// <summary>
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// Any product codes associated with the AMI.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProductCode> ProductCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<ProductCode>() : null;

        /// <summary>
        /// Checks to see if the ProductCodes property is set.
        /// </summary>
        internal bool IsSetProductCodes() => this.ProductCodes != null && (this.ProductCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Public. 
        /// <para>
        /// Indicates whether the image has public launch permissions. The value is <c>true</c>
        /// if this image has public launch permissions or <c>false</c> if it has only implicit
        /// and explicit launch permissions.
        /// </para>
        /// </summary>
        public bool? Public { get; set; }

        /// <summary>
        /// Checks to see if the Public property is set.
        /// </summary>
        internal bool IsSetPublic() => this.Public.HasValue;

        /// <summary>
        /// Gets and sets the property PublicSsmParameterName. 
        /// <para>
        /// The name of the public Systems Manager parameter that resolves to this AMI, under
        /// the <c>aws/service/</c> namespace.
        /// </para>
        /// </summary>
        public string PublicSsmParameterName { get; set; }

        /// <summary>
        /// Checks to see if the PublicSsmParameterName property is set.
        /// </summary>
        internal bool IsSetPublicSsmParameterName() => this.PublicSsmParameterName != null;

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The RAM disk associated with the image, if any. Only applicable for machine images.
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
        /// Gets and sets the property RootDeviceType. 
        /// <para>
        /// The type of root device used by the AMI. The AMI can use an Amazon EBS volume or an
        /// instance store volume.
        /// </para>
        /// </summary>
        public DeviceType RootDeviceType { get; set; }

        /// <summary>
        /// Checks to see if the RootDeviceType property is set.
        /// </summary>
        internal bool IsSetRootDeviceType() => this.RootDeviceType != null;

        /// <summary>
        /// Gets and sets the property ScanResults. 
        /// <para>
        /// The Amazon Inspector scan results for the AMI. This information is present only for
        /// AMIs that Amazon Inspector has scanned.
        /// </para>
        ///  
        /// <para>
        /// When you share an AMI with other accounts, organizations, or organizational units
        /// (OUs), or make it public, its scan results are available to the accounts that can
        /// use the AMI.
        /// </para>
        /// </summary>
        public ScanResults ScanResults { get; set; }

        /// <summary>
        /// Checks to see if the ScanResults property is set.
        /// </summary>
        internal bool IsSetScanResults() => this.ScanResults != null;

        /// <summary>
        /// Gets and sets the property SourceImageId. 
        /// <para>
        /// The ID of the source AMI from which the AMI was created.
        /// </para>
        /// </summary>
        public string SourceImageId { get; set; }

        /// <summary>
        /// Checks to see if the SourceImageId property is set.
        /// </summary>
        internal bool IsSetSourceImageId() => this.SourceImageId != null;

        /// <summary>
        /// Gets and sets the property SourceImageRegion. 
        /// <para>
        /// The Region of the source AMI.
        /// </para>
        /// </summary>
        public string SourceImageRegion { get; set; }

        /// <summary>
        /// Checks to see if the SourceImageRegion property is set.
        /// </summary>
        internal bool IsSetSourceImageRegion() => this.SourceImageRegion != null;

        /// <summary>
        /// Gets and sets the property SourceInstanceId. 
        /// <para>
        /// The ID of the instance that the AMI was created from if the AMI was created using
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateImage.html">CreateImage</a>.
        /// This field only appears if the AMI was created using CreateImage.
        /// </para>
        /// </summary>
        public string SourceInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the SourceInstanceId property is set.
        /// </summary>
        internal bool IsSetSourceInstanceId() => this.SourceInstanceId != null;

        /// <summary>
        /// Gets and sets the property SriovNetSupport. 
        /// <para>
        /// Specifies whether enhanced networking with the Intel 82599 Virtual Function interface
        /// is enabled.
        /// </para>
        /// </summary>
        public string SriovNetSupport { get; set; }

        /// <summary>
        /// Checks to see if the SriovNetSupport property is set.
        /// </summary>
        internal bool IsSetSriovNetSupport() => this.SriovNetSupport != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the AMI. If the state is <c>available</c>, the image is successfully
        /// registered and can be used to launch an instance.
        /// </para>
        /// </summary>
        public ImageState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the state change.
        /// </para>
        /// </summary>
        public StateReason StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the image.
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
        /// Gets and sets the property TpmSupport. 
        /// <para>
        /// If the image is configured for NitroTPM support, the value is <c>v2.0</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitrotpm.html">NitroTPM</a>
        /// in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public TpmSupportValues TpmSupport { get; set; }

        /// <summary>
        /// Checks to see if the TpmSupport property is set.
        /// </summary>
        internal bool IsSetTpmSupport() => this.TpmSupport != null;

        /// <summary>
        /// Gets and sets the property UsageOperation. 
        /// <para>
        /// The operation of the Amazon EC2 instance and the billing code that is associated with
        /// the AMI. <c>usageOperation</c> corresponds to the <a href="https://docs.aws.amazon.com/cur/latest/userguide/Lineitem-columns.html#Lineitem-details-O-Operation">lineitem/Operation</a>
        /// column on your Amazon Web Services Cost and Usage Report and in the <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/price-changes.html">Amazon
        /// Web Services Price List API</a>. You can view these fields on the <b>Instances</b>
        /// or <b>AMIs</b> pages in the Amazon EC2 console, or in the responses that are returned
        /// by the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeImages.html">DescribeImages</a>
        /// command in the Amazon EC2 API, or the <a href="https://docs.aws.amazon.com/cli/latest/reference/ec2/describe-images.html">describe-images</a>
        /// command in the CLI.
        /// </para>
        /// </summary>
        public string UsageOperation { get; set; }

        /// <summary>
        /// Checks to see if the UsageOperation property is set.
        /// </summary>
        internal bool IsSetUsageOperation() => this.UsageOperation != null;

        /// <summary>
        /// Gets and sets the property VirtualizationType. 
        /// <para>
        /// The type of virtualization of the AMI.
        /// </para>
        /// </summary>
        public VirtualizationType VirtualizationType { get; set; }

        /// <summary>
        /// Checks to see if the VirtualizationType property is set.
        /// </summary>
        internal bool IsSetVirtualizationType() => this.VirtualizationType != null;
    }
}
