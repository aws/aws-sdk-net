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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateImageBuilder operation. Creates an image
    /// builder. An image builder is a virtual machine that is used to create an image. <para>
    /// The initial state of the builder is <c>PENDING</c>. When it is ready, the state is
    /// <c>RUNNING</c>. </para>
    /// </summary>
    public partial class CreateImageBuilderRequest : AmazonAppStreamRequest
    {
        /// <summary>
        /// Gets and sets the property AccessEndpoints. 
        /// <para>
        /// The list of interface VPC endpoint (interface endpoint) objects. Administrators can
        /// connect to the image builder only through the specified endpoints.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<AccessEndpoint> AccessEndpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<AccessEndpoint>() : null;

        /// <summary>
        /// Checks to see if the AccessEndpoints property is set.
        /// </summary>
        internal bool IsSetAccessEndpoints() => this.AccessEndpoints != null && (this.AccessEndpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AppstreamAgentVersion. 
        /// <para>
        /// The version of the WorkSpaces Applications agent to use for this image builder. To
        /// use the latest version of the WorkSpaces Applications agent, specify [LATEST]. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string AppstreamAgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AppstreamAgentVersion property is set.
        /// </summary>
        internal bool IsSetAppstreamAgentVersion() => this.AppstreamAgentVersion != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisableIMDSV1. 
        /// <para>
        /// Set to true to disable Instance Metadata Service Version 1 (IMDSv1) and enforce IMDSv2.
        /// Set to false to enable both IMDSv1 and IMDSv2.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before disabling IMDSv1, ensure your WorkSpaces Applications images are running the
        /// agent version or managed image update released on or after January 16, 2024 to support
        /// IMDSv2 enforcement.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? DisableIMDSV1 { get; set; }

        /// <summary>
        /// Checks to see if the DisableIMDSV1 property is set.
        /// </summary>
        internal bool IsSetDisableIMDSV1() => this.DisableIMDSV1.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The image builder name to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property DomainJoinInfo. 
        /// <para>
        /// The name of the directory and organizational unit (OU) to use to join the image builder
        /// to a Microsoft Active Directory domain. 
        /// </para>
        /// </summary>
        public DomainJoinInfo DomainJoinInfo { get; set; }

        /// <summary>
        /// Checks to see if the DomainJoinInfo property is set.
        /// </summary>
        internal bool IsSetDomainJoinInfo() => this.DomainJoinInfo != null;

        /// <summary>
        /// Gets and sets the property EnableDefaultInternetAccess. 
        /// <para>
        /// Enables or disables default internet access for the image builder.
        /// </para>
        /// </summary>
        public bool? EnableDefaultInternetAccess { get; set; }

        /// <summary>
        /// Checks to see if the EnableDefaultInternetAccess property is set.
        /// </summary>
        internal bool IsSetEnableDefaultInternetAccess() => this.EnableDefaultInternetAccess.HasValue;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to apply to the image builder. To assume
        /// a role, the image builder calls the AWS Security Token Service (STS) <c>AssumeRole</c>
        /// API operation and passes the ARN of the role to use. The operation creates a new session
        /// with temporary credentials. WorkSpaces Applications retrieves the temporary credentials
        /// and creates the <b>appstream_machine_role</b> credential profile on the instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/using-iam-roles-to-grant-permissions-to-applications-scripts-streaming-instances.html">Using
        /// an IAM Role to Grant Permissions to Applications and Scripts Running on WorkSpaces
        /// Applications Streaming Instances</a> in the <i>Amazon WorkSpaces Applications Administration
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN of the public, private, or shared image to use.
        /// </para>
        /// </summary>
        public string ImageArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageArn property is set.
        /// </summary>
        internal bool IsSetImageArn() => this.ImageArn != null;

        /// <summary>
        /// Gets and sets the property ImageName. 
        /// <para>
        /// The name of the image used to create the image builder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ImageName { get; set; }

        /// <summary>
        /// Checks to see if the ImageName property is set.
        /// </summary>
        internal bool IsSetImageName() => this.ImageName != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type to use when launching the image builder. The following instance
        /// types are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// stream.standard.small
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.standard.medium
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.standard.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.compute.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.compute.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.compute.2xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.compute.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.compute.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.2xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.z1d.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.z1d.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.z1d.2xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.z1d.3xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.z1d.6xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.z1d.12xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g4dn.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g4dn.2xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g4dn.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g4dn.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g4dn.12xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g4dn.16xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g5.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g5.2xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g5.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g5.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g5.16xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g5.12xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g5.24xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g6.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g6.2xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g6.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g6.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g6.16xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g6.12xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g6.24xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.gr6.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.gr6.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g6f.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g6f.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g6f.2xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g6f.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.gr6f.4xlarge
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the image builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RootVolumeConfig. 
        /// <para>
        /// The configuration for the root volume of the image builder. Use this to customize
        /// storage capacity from 200 GB up to 500 GB based on your application installation requirements.
        /// </para>
        /// </summary>
        public VolumeConfig RootVolumeConfig { get; set; }

        /// <summary>
        /// Checks to see if the RootVolumeConfig property is set.
        /// </summary>
        internal bool IsSetRootVolumeConfig() => this.RootVolumeConfig != null;

        /// <summary>
        /// Gets and sets the property SoftwaresToInstall. 
        /// <para>
        /// The list of license included applications to install on the image builder during creation.
        /// </para>
        ///  
        /// <para>
        /// Possible values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Microsoft_Office_2021_LTSC_Professional_Plus_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2021_LTSC_Professional_Plus_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2024_LTSC_Professional_Plus_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2024_LTSC_Professional_Plus_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2021_LTSC_Professional_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2021_LTSC_Professional_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2024_LTSC_Professional_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2024_LTSC_Professional_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2021_Professional_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2021_Professional_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2024_Professional_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2024_Professional_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2021_LTSC_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2021_LTSC_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2024_LTSC_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2024_LTSC_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2021_LTSC_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2021_LTSC_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2024_LTSC_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2024_LTSC_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2021_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2021_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2024_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2024_Standard_64Bit
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SoftwaresToInstall { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SoftwaresToInstall property is set.
        /// </summary>
        internal bool IsSetSoftwaresToInstall() => this.SoftwaresToInstall != null && (this.SoftwaresToInstall.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SoftwaresToUninstall. 
        /// <para>
        /// The list of license included applications to uninstall from the image builder during
        /// creation.
        /// </para>
        ///  
        /// <para>
        /// Possible values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Microsoft_Office_2021_LTSC_Professional_Plus_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2021_LTSC_Professional_Plus_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2024_LTSC_Professional_Plus_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2024_LTSC_Professional_Plus_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2021_LTSC_Professional_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2021_LTSC_Professional_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2024_LTSC_Professional_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2024_LTSC_Professional_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2021_Professional_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2021_Professional_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2024_Professional_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2024_Professional_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2021_LTSC_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2021_LTSC_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2024_LTSC_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Office_2024_LTSC_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2021_LTSC_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2021_LTSC_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2024_LTSC_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Visio_2024_LTSC_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2021_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2021_Standard_64Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2024_Standard_32Bit
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Microsoft_Project_2024_Standard_64Bit
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SoftwaresToUninstall { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SoftwaresToUninstall property is set.
        /// </summary>
        internal bool IsSetSoftwaresToUninstall() => this.SoftwaresToUninstall != null && (this.SoftwaresToUninstall.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the image builder. A tag is a key-value pair, and the value
        /// is optional. For example, Environment=Test. If you do not specify a value, Environment=.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Generally allowed characters are: letters, numbers, and spaces representable in UTF-8,
        /// and the following special characters: 
        /// </para>
        ///  
        /// <para>
        /// _ . : / = + \ - @
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value, the value is set to an empty string.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/tagging-basic.html">Tagging
        /// Your Resources</a> in the <i>Amazon WorkSpaces Applications Administration Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC configuration for the image builder. You can specify only one subnet.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
