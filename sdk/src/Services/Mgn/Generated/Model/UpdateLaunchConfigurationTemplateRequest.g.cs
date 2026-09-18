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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLaunchConfigurationTemplate operation. Updates
    /// an existing Launch Configuration Template by ID.
    /// </summary>
    public partial class UpdateLaunchConfigurationTemplateRequest : AmazonMgnRequest
    {
        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// Associate public Ip address.
        /// </para>
        /// </summary>
        public bool? AssociatePublicIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the AssociatePublicIpAddress property is set.
        /// </summary>
        internal bool IsSetAssociatePublicIpAddress() => this.AssociatePublicIpAddress.HasValue;

        /// <summary>
        /// Gets and sets the property BootMode. 
        /// <para>
        /// Launch configuration template boot mode.
        /// </para>
        /// </summary>
        public BootMode BootMode { get; set; }

        /// <summary>
        /// Checks to see if the BootMode property is set.
        /// </summary>
        internal bool IsSetBootMode() => this.BootMode != null;

        /// <summary>
        /// Gets and sets the property CopyPrivateIp. 
        /// <para>
        /// Copy private Ip.
        /// </para>
        /// </summary>
        public bool? CopyPrivateIp { get; set; }

        /// <summary>
        /// Checks to see if the CopyPrivateIp property is set.
        /// </summary>
        internal bool IsSetCopyPrivateIp() => this.CopyPrivateIp.HasValue;

        /// <summary>
        /// Gets and sets the property CopyTags. 
        /// <para>
        /// Copy tags.
        /// </para>
        /// </summary>
        public bool? CopyTags { get; set; }

        /// <summary>
        /// Checks to see if the CopyTags property is set.
        /// </summary>
        internal bool IsSetCopyTags() => this.CopyTags.HasValue;

        /// <summary>
        /// Gets and sets the property EnableMapAutoTagging. 
        /// <para>
        /// Enable map auto tagging.
        /// </para>
        /// </summary>
        public bool? EnableMapAutoTagging { get; set; }

        /// <summary>
        /// Checks to see if the EnableMapAutoTagging property is set.
        /// </summary>
        internal bool IsSetEnableMapAutoTagging() => this.EnableMapAutoTagging.HasValue;

        /// <summary>
        /// Gets and sets the property EnableParametersEncryption. 
        /// <para>
        /// Enable parameters encryption.
        /// </para>
        /// </summary>
        public bool? EnableParametersEncryption { get; set; }

        /// <summary>
        /// Checks to see if the EnableParametersEncryption property is set.
        /// </summary>
        internal bool IsSetEnableParametersEncryption() => this.EnableParametersEncryption.HasValue;

        /// <summary>
        /// Gets and sets the property LargeVolumeConf. 
        /// <para>
        /// Large volume config.
        /// </para>
        /// </summary>
        public LaunchTemplateDiskConf LargeVolumeConf { get; set; }

        /// <summary>
        /// Checks to see if the LargeVolumeConf property is set.
        /// </summary>
        internal bool IsSetLargeVolumeConf() => this.LargeVolumeConf != null;

        /// <summary>
        /// Gets and sets the property LaunchConfigurationTemplateID. 
        /// <para>
        /// Launch Configuration Template ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 21, Max = 21)]
        public string LaunchConfigurationTemplateID { get; set; }

        /// <summary>
        /// Checks to see if the LaunchConfigurationTemplateID property is set.
        /// </summary>
        internal bool IsSetLaunchConfigurationTemplateID() => this.LaunchConfigurationTemplateID != null;

        /// <summary>
        /// Gets and sets the property LaunchDisposition. 
        /// <para>
        /// Launch disposition.
        /// </para>
        /// </summary>
        public LaunchDisposition LaunchDisposition { get; set; }

        /// <summary>
        /// Checks to see if the LaunchDisposition property is set.
        /// </summary>
        internal bool IsSetLaunchDisposition() => this.LaunchDisposition != null;

        /// <summary>
        /// Gets and sets the property Licensing.
        /// </summary>
        public Licensing Licensing { get; set; }

        /// <summary>
        /// Checks to see if the Licensing property is set.
        /// </summary>
        internal bool IsSetLicensing() => this.Licensing != null;

        /// <summary>
        /// Gets and sets the property MapAutoTaggingMpeID. 
        /// <para>
        /// Launch configuration template map auto tagging MPE ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string MapAutoTaggingMpeID { get; set; }

        /// <summary>
        /// Checks to see if the MapAutoTaggingMpeID property is set.
        /// </summary>
        internal bool IsSetMapAutoTaggingMpeID() => this.MapAutoTaggingMpeID != null;

        /// <summary>
        /// Gets and sets the property ParametersEncryptionKey. 
        /// <para>
        /// Parameters encryption key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ParametersEncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the ParametersEncryptionKey property is set.
        /// </summary>
        internal bool IsSetParametersEncryptionKey() => this.ParametersEncryptionKey != null;

        /// <summary>
        /// Gets and sets the property PostLaunchActions. 
        /// <para>
        /// Post Launch Action to execute on the Test or Cutover instance.
        /// </para>
        /// </summary>
        public PostLaunchActions PostLaunchActions { get; set; }

        /// <summary>
        /// Checks to see if the PostLaunchActions property is set.
        /// </summary>
        internal bool IsSetPostLaunchActions() => this.PostLaunchActions != null;

        /// <summary>
        /// Gets and sets the property SmallVolumeConf. 
        /// <para>
        /// Small volume config.
        /// </para>
        /// </summary>
        public LaunchTemplateDiskConf SmallVolumeConf { get; set; }

        /// <summary>
        /// Checks to see if the SmallVolumeConf property is set.
        /// </summary>
        internal bool IsSetSmallVolumeConf() => this.SmallVolumeConf != null;

        /// <summary>
        /// Gets and sets the property SmallVolumeMaxSize. 
        /// <para>
        /// Small volume maximum size.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? SmallVolumeMaxSize { get; set; }

        /// <summary>
        /// Checks to see if the SmallVolumeMaxSize property is set.
        /// </summary>
        internal bool IsSetSmallVolumeMaxSize() => this.SmallVolumeMaxSize.HasValue;

        /// <summary>
        /// Gets and sets the property TargetInstanceTypeRightSizingMethod. 
        /// <para>
        /// Target instance type right-sizing method.
        /// </para>
        /// </summary>
        public TargetInstanceTypeRightSizingMethod TargetInstanceTypeRightSizingMethod { get; set; }

        /// <summary>
        /// Checks to see if the TargetInstanceTypeRightSizingMethod property is set.
        /// </summary>
        internal bool IsSetTargetInstanceTypeRightSizingMethod() => this.TargetInstanceTypeRightSizingMethod != null;
    }
}
