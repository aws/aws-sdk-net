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
    /// Describes an image attribute.
    /// </summary>
    public partial class ImageAttribute
    {
        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mapping entries.
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
        /// The boot mode.
        /// </para>
        /// </summary>
        public string BootMode { get; set; }

        /// <summary>
        /// Checks to see if the BootMode property is set.
        /// </summary>
        internal bool IsSetBootMode() => this.BootMode != null;

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
        /// A description for the AMI.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        public string ImdsSupport { get; set; }

        /// <summary>
        /// Checks to see if the ImdsSupport property is set.
        /// </summary>
        internal bool IsSetImdsSupport() => this.ImdsSupport != null;

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The kernel ID.
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
        /// Gets and sets the property LaunchPermissions. 
        /// <para>
        /// The launch permissions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchPermission> LaunchPermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<LaunchPermission>() : null;

        /// <summary>
        /// Checks to see if the LaunchPermissions property is set.
        /// </summary>
        internal bool IsSetLaunchPermissions() => this.LaunchPermissions != null && (this.LaunchPermissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// The product codes.
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
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The RAM disk ID.
        /// </para>
        /// </summary>
        public string RamdiskId { get; set; }

        /// <summary>
        /// Checks to see if the RamdiskId property is set.
        /// </summary>
        internal bool IsSetRamdiskId() => this.RamdiskId != null;

        /// <summary>
        /// Gets and sets the property SriovNetSupport. 
        /// <para>
        /// Indicates whether enhanced networking with the Intel 82599 Virtual Function interface
        /// is enabled.
        /// </para>
        /// </summary>
        public string SriovNetSupport { get; set; }

        /// <summary>
        /// Checks to see if the SriovNetSupport property is set.
        /// </summary>
        internal bool IsSetSriovNetSupport() => this.SriovNetSupport != null;

        /// <summary>
        /// Gets and sets the property TpmSupport. 
        /// <para>
        /// If the image is configured for NitroTPM support, the value is <c>v2.0</c>.
        /// </para>
        /// </summary>
        public string TpmSupport { get; set; }

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
        public string UefiData { get; set; }

        /// <summary>
        /// Checks to see if the UefiData property is set.
        /// </summary>
        internal bool IsSetUefiData() => this.UefiData != null;
    }
}
