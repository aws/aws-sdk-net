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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// This is the response object from the UpdateLaunchConfigurationTemplate operation.
    /// </summary>
    public partial class UpdateLaunchConfigurationTemplateResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private bool? _associatePublicIpAddress;
        private BootMode _bootMode;
        private bool? _copyPrivateIp;
        private bool? _copyTags;
        private string _ec2LaunchTemplateID;
        private bool? _enableMapAutoTagging;
        private LaunchTemplateDiskConf _largeVolumeConf;
        private string _launchConfigurationTemplateID;
        private LaunchDisposition _launchDisposition;
        private Licensing _licensing;
        private string _mapAutoTaggingMpeID;
        private PostLaunchActions _postLaunchActions;
        private LaunchTemplateDiskConf _smallVolumeConf;
        private long? _smallVolumeMaxSize;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private TargetInstanceTypeRightSizingMethod _targetInstanceTypeRightSizingMethod;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of the Launch Configuration Template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// Associate public Ip address.
        /// </para>
        /// </summary>
        public bool AssociatePublicIpAddress
        {
            get { return this._associatePublicIpAddress.GetValueOrDefault(); }
            set { this._associatePublicIpAddress = value; }
        }

        // Check to see if AssociatePublicIpAddress property is set
        internal bool IsSetAssociatePublicIpAddress()
        {
            return this._associatePublicIpAddress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BootMode. 
        /// <para>
        /// Launch configuration template boot mode.
        /// </para>
        /// </summary>
        public BootMode BootMode
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
        /// Gets and sets the property CopyPrivateIp. 
        /// <para>
        /// Copy private Ip.
        /// </para>
        /// </summary>
        public bool CopyPrivateIp
        {
            get { return this._copyPrivateIp.GetValueOrDefault(); }
            set { this._copyPrivateIp = value; }
        }

        // Check to see if CopyPrivateIp property is set
        internal bool IsSetCopyPrivateIp()
        {
            return this._copyPrivateIp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// Copy tags.
        /// </para>
        /// </summary>
        public bool CopyTags
        {
            get { return this._copyTags.GetValueOrDefault(); }
            set { this._copyTags = value; }
        }

        // Check to see if CopyTags property is set
        internal bool IsSetCopyTags()
        {
            return this._copyTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ec2LaunchTemplateID. 
        /// <para>
        /// EC2 launch template ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string Ec2LaunchTemplateID
        {
            get { return this._ec2LaunchTemplateID; }
            set { this._ec2LaunchTemplateID = value; }
        }

        // Check to see if Ec2LaunchTemplateID property is set
        internal bool IsSetEc2LaunchTemplateID()
        {
            return this._ec2LaunchTemplateID != null;
        }

        /// <summary>
        /// Gets and sets the property EnableMapAutoTagging. 
        /// <para>
        /// Enable map auto tagging.
        /// </para>
        /// </summary>
        public bool EnableMapAutoTagging
        {
            get { return this._enableMapAutoTagging.GetValueOrDefault(); }
            set { this._enableMapAutoTagging = value; }
        }

        // Check to see if EnableMapAutoTagging property is set
        internal bool IsSetEnableMapAutoTagging()
        {
            return this._enableMapAutoTagging.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LargeVolumeConf. 
        /// <para>
        /// Large volume config.
        /// </para>
        /// </summary>
        public LaunchTemplateDiskConf LargeVolumeConf
        {
            get { return this._largeVolumeConf; }
            set { this._largeVolumeConf = value; }
        }

        // Check to see if LargeVolumeConf property is set
        internal bool IsSetLargeVolumeConf()
        {
            return this._largeVolumeConf != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchConfigurationTemplateID. 
        /// <para>
        /// ID of the Launch Configuration Template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=21, Max=21)]
        public string LaunchConfigurationTemplateID
        {
            get { return this._launchConfigurationTemplateID; }
            set { this._launchConfigurationTemplateID = value; }
        }

        // Check to see if LaunchConfigurationTemplateID property is set
        internal bool IsSetLaunchConfigurationTemplateID()
        {
            return this._launchConfigurationTemplateID != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchDisposition. 
        /// <para>
        /// Launch disposition.
        /// </para>
        /// </summary>
        public LaunchDisposition LaunchDisposition
        {
            get { return this._launchDisposition; }
            set { this._launchDisposition = value; }
        }

        // Check to see if LaunchDisposition property is set
        internal bool IsSetLaunchDisposition()
        {
            return this._launchDisposition != null;
        }

        /// <summary>
        /// Gets and sets the property Licensing.
        /// </summary>
        public Licensing Licensing
        {
            get { return this._licensing; }
            set { this._licensing = value; }
        }

        // Check to see if Licensing property is set
        internal bool IsSetLicensing()
        {
            return this._licensing != null;
        }

        /// <summary>
        /// Gets and sets the property MapAutoTaggingMpeID. 
        /// <para>
        /// Launch configuration template map auto tagging MPE ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string MapAutoTaggingMpeID
        {
            get { return this._mapAutoTaggingMpeID; }
            set { this._mapAutoTaggingMpeID = value; }
        }

        // Check to see if MapAutoTaggingMpeID property is set
        internal bool IsSetMapAutoTaggingMpeID()
        {
            return this._mapAutoTaggingMpeID != null;
        }

        /// <summary>
        /// Gets and sets the property PostLaunchActions. 
        /// <para>
        /// Post Launch Actions of the Launch Configuration Template.
        /// </para>
        /// </summary>
        public PostLaunchActions PostLaunchActions
        {
            get { return this._postLaunchActions; }
            set { this._postLaunchActions = value; }
        }

        // Check to see if PostLaunchActions property is set
        internal bool IsSetPostLaunchActions()
        {
            return this._postLaunchActions != null;
        }

        /// <summary>
        /// Gets and sets the property SmallVolumeConf. 
        /// <para>
        /// Small volume config.
        /// </para>
        /// </summary>
        public LaunchTemplateDiskConf SmallVolumeConf
        {
            get { return this._smallVolumeConf; }
            set { this._smallVolumeConf = value; }
        }

        // Check to see if SmallVolumeConf property is set
        internal bool IsSetSmallVolumeConf()
        {
            return this._smallVolumeConf != null;
        }

        /// <summary>
        /// Gets and sets the property SmallVolumeMaxSize. 
        /// <para>
        /// Small volume maximum size.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long SmallVolumeMaxSize
        {
            get { return this._smallVolumeMaxSize.GetValueOrDefault(); }
            set { this._smallVolumeMaxSize = value; }
        }

        // Check to see if SmallVolumeMaxSize property is set
        internal bool IsSetSmallVolumeMaxSize()
        {
            return this._smallVolumeMaxSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags of the Launch Configuration Template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property TargetInstanceTypeRightSizingMethod. 
        /// <para>
        /// Target instance type right-sizing method.
        /// </para>
        /// </summary>
        public TargetInstanceTypeRightSizingMethod TargetInstanceTypeRightSizingMethod
        {
            get { return this._targetInstanceTypeRightSizingMethod; }
            set { this._targetInstanceTypeRightSizingMethod = value; }
        }

        // Check to see if TargetInstanceTypeRightSizingMethod property is set
        internal bool IsSetTargetInstanceTypeRightSizingMethod()
        {
            return this._targetInstanceTypeRightSizingMethod != null;
        }

    }
}