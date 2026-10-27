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
    /// Describes a virtual machine that is used to create an image.
    /// </summary>
    public partial class ImageBuilder
    {
        /// <summary>
        /// Gets and sets the property AccessEndpoints. 
        /// <para>
        /// The list of virtual private cloud (VPC) interface endpoint objects. Administrators
        /// can connect to the image builder only through the specified endpoints.
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
        /// The version of the WorkSpaces Applications agent that is currently being used by the
        /// image builder. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string AppstreamAgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AppstreamAgentVersion property is set.
        /// </summary>
        internal bool IsSetAppstreamAgentVersion() => this.AppstreamAgentVersion != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN for the image builder.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time stamp when the image builder was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisableIMDSV1. 
        /// <para>
        /// Indicates whether Instance Metadata Service Version 1 (IMDSv1) is disabled for the
        /// image builder.
        /// </para>
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
        [AWSProperty(Min = 1)]
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
        /// The ARN of the IAM role that is applied to the image builder. To assume a role, the
        /// image builder calls the AWS Security Token Service (STS) <c>AssumeRole</c> API operation
        /// and passes the ARN of the role to use. The operation creates a new session with temporary
        /// credentials. WorkSpaces Applications retrieves the temporary credentials and creates
        /// the <b>appstream_machine_role</b> credential profile on the instance.
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
        /// The ARN of the image from which this builder was created.
        /// </para>
        /// </summary>
        public string ImageArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageArn property is set.
        /// </summary>
        internal bool IsSetImageArn() => this.ImageArn != null;

        /// <summary>
        /// Gets and sets the property ImageBuilderErrors. 
        /// <para>
        /// The image builder errors.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceError> ImageBuilderErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceError>() : null;

        /// <summary>
        /// Checks to see if the ImageBuilderErrors property is set.
        /// </summary>
        internal bool IsSetImageBuilderErrors() => this.ImageBuilderErrors != null && (this.ImageBuilderErrors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type for the image builder. The following instance types are available:
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
        [AWSProperty(Min = 1)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LatestAppstreamAgentVersion. 
        /// <para>
        /// Indicates whether the image builder is using the latest WorkSpaces Applications agent
        /// version or not.
        /// </para>
        /// </summary>
        public LatestAppstreamAgentVersion LatestAppstreamAgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestAppstreamAgentVersion property is set.
        /// </summary>
        internal bool IsSetLatestAppstreamAgentVersion() => this.LatestAppstreamAgentVersion != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkAccessConfiguration.
        /// </summary>
        public NetworkAccessConfiguration NetworkAccessConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkAccessConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkAccessConfiguration() => this.NetworkAccessConfiguration != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system platform of the image builder.
        /// </para>
        /// </summary>
        public PlatformType Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property RootVolumeConfig. 
        /// <para>
        /// The current configuration of the root volume for the image builder, including the
        /// storage size in GB.
        /// </para>
        /// </summary>
        public VolumeConfig RootVolumeConfig { get; set; }

        /// <summary>
        /// Checks to see if the RootVolumeConfig property is set.
        /// </summary>
        internal bool IsSetRootVolumeConfig() => this.RootVolumeConfig != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the image builder.
        /// </para>
        /// </summary>
        public ImageBuilderState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateChangeReason. 
        /// <para>
        /// The reason why the last state change occurred.
        /// </para>
        /// </summary>
        public ImageBuilderStateChangeReason StateChangeReason { get; set; }

        /// <summary>
        /// Checks to see if the StateChangeReason property is set.
        /// </summary>
        internal bool IsSetStateChangeReason() => this.StateChangeReason != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC configuration of the image builder.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
