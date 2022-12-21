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
    /// Describes an image attribute.
    /// </summary>
    public partial class ImageAttribute
    {
        private List<BlockDeviceMapping> _blockDeviceMappings = new List<BlockDeviceMapping>();
        private string _bootMode;
        private string _description;
        private string _imageId;
        private string _imdsSupport;
        private string _kernelId;
        private string _lastLaunchedTime;
        private List<LaunchPermission> _launchPermissions = new List<LaunchPermission>();
        private List<ProductCode> _productCodes = new List<ProductCode>();
        private string _ramdiskId;
        private string _sriovNetSupport;
        private string _tpmSupport;
        private string _uefiData;

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mapping entries.
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
        /// The boot mode.
        /// </para>
        /// </summary>
        public string BootMode
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
        /// A description for the AMI.
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
        public string ImdsSupport
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
        /// The kernel ID.
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
        /// Gets and sets the property LastLaunchedTime. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the AMI was last used to launch an EC2 instance. When the AMI is
        /// used to launch an instance, there is a 24-hour delay before that usage is reported.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>lastLaunchedTime</code> data is available starting April 2017.
        /// </para>
        ///  </note>
        /// </summary>
        public string LastLaunchedTime
        {
            get { return this._lastLaunchedTime; }
            set { this._lastLaunchedTime = value; }
        }

        // Check to see if LastLaunchedTime property is set
        internal bool IsSetLastLaunchedTime()
        {
            return this._lastLaunchedTime != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchPermissions. 
        /// <para>
        /// The launch permissions.
        /// </para>
        /// </summary>
        public List<LaunchPermission> LaunchPermissions
        {
            get { return this._launchPermissions; }
            set { this._launchPermissions = value; }
        }

        // Check to see if LaunchPermissions property is set
        internal bool IsSetLaunchPermissions()
        {
            return this._launchPermissions != null && this._launchPermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// The product codes.
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
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The RAM disk ID.
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
        /// Gets and sets the property SriovNetSupport. 
        /// <para>
        /// Indicates whether enhanced networking with the Intel 82599 Virtual Function interface
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
        /// Gets and sets the property TpmSupport. 
        /// <para>
        /// If the image is configured for NitroTPM support, the value is <code>v2.0</code>.
        /// </para>
        /// </summary>
        public string TpmSupport
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

    }
}