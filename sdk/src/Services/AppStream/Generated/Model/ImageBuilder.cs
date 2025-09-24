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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
        private List<AccessEndpoint> _accessEndpoints = AWSConfigs.InitializeCollections ? new List<AccessEndpoint>() : null;
        private string _appstreamAgentVersion;
        private string _arn;
        private DateTime? _createdTime;
        private string _description;
        private string _displayName;
        private DomainJoinInfo _domainJoinInfo;
        private bool? _enableDefaultInternetAccess;
        private string _iamRoleArn;
        private string _imageArn;
        private List<ResourceError> _imageBuilderErrors = AWSConfigs.InitializeCollections ? new List<ResourceError>() : null;
        private string _instanceType;
        private LatestAppstreamAgentVersion _latestAppstreamAgentVersion;
        private string _name;
        private NetworkAccessConfiguration _networkAccessConfiguration;
        private PlatformType _platform;
        private ImageBuilderState _state;
        private ImageBuilderStateChangeReason _stateChangeReason;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property AccessEndpoints. 
        /// <para>
        /// The list of virtual private cloud (VPC) interface endpoint objects. Administrators
        /// can connect to the image builder only through the specified endpoints.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<AccessEndpoint> AccessEndpoints
        {
            get { return this._accessEndpoints; }
            set { this._accessEndpoints = value; }
        }

        // Check to see if AccessEndpoints property is set
        internal bool IsSetAccessEndpoints()
        {
            return this._accessEndpoints != null && (this._accessEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AppstreamAgentVersion. 
        /// <para>
        /// The version of the AppStream 2.0 agent that is currently being used by the image builder.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AppstreamAgentVersion
        {
            get { return this._appstreamAgentVersion; }
            set { this._appstreamAgentVersion = value; }
        }

        // Check to see if AppstreamAgentVersion property is set
        internal bool IsSetAppstreamAgentVersion()
        {
            return this._appstreamAgentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN for the image builder.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time stamp when the image builder was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The image builder name to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property DomainJoinInfo. 
        /// <para>
        /// The name of the directory and organizational unit (OU) to use to join the image builder
        /// to a Microsoft Active Directory domain. 
        /// </para>
        /// </summary>
        public DomainJoinInfo DomainJoinInfo
        {
            get { return this._domainJoinInfo; }
            set { this._domainJoinInfo = value; }
        }

        // Check to see if DomainJoinInfo property is set
        internal bool IsSetDomainJoinInfo()
        {
            return this._domainJoinInfo != null;
        }

        /// <summary>
        /// Gets and sets the property EnableDefaultInternetAccess. 
        /// <para>
        /// Enables or disables default internet access for the image builder.
        /// </para>
        /// </summary>
        public bool? EnableDefaultInternetAccess
        {
            get { return this._enableDefaultInternetAccess; }
            set { this._enableDefaultInternetAccess = value; }
        }

        // Check to see if EnableDefaultInternetAccess property is set
        internal bool IsSetEnableDefaultInternetAccess()
        {
            return this._enableDefaultInternetAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role that is applied to the image builder. To assume a role, the
        /// image builder calls the AWS Security Token Service (STS) <c>AssumeRole</c> API operation
        /// and passes the ARN of the role to use. The operation creates a new session with temporary
        /// credentials. AppStream 2.0 retrieves the temporary credentials and creates the <b>appstream_machine_role</b>
        /// credential profile on the instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/using-iam-roles-to-grant-permissions-to-applications-scripts-streaming-instances.html">Using
        /// an IAM Role to Grant Permissions to Applications and Scripts Running on AppStream
        /// 2.0 Streaming Instances</a> in the <i>Amazon AppStream 2.0 Administration Guide</i>.
        /// </para>
        /// </summary>
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN of the image from which this builder was created.
        /// </para>
        /// </summary>
        public string ImageArn
        {
            get { return this._imageArn; }
            set { this._imageArn = value; }
        }

        // Check to see if ImageArn property is set
        internal bool IsSetImageArn()
        {
            return this._imageArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageBuilderErrors. 
        /// <para>
        /// The image builder errors.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceError> ImageBuilderErrors
        {
            get { return this._imageBuilderErrors; }
            set { this._imageBuilderErrors = value; }
        }

        // Check to see if ImageBuilderErrors property is set
        internal bool IsSetImageBuilderErrors()
        {
            return this._imageBuilderErrors != null && (this._imageBuilderErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// stream.graphics-design.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics-design.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics-design.2xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics-design.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics-desktop.2xlarge
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
        /// stream.graphics-pro.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics-pro.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics-pro.16xlarge
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
        [AWSProperty(Min=1)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LatestAppstreamAgentVersion. 
        /// <para>
        /// Indicates whether the image builder is using the latest AppStream 2.0 agent version
        /// or not.
        /// </para>
        /// </summary>
        public LatestAppstreamAgentVersion LatestAppstreamAgentVersion
        {
            get { return this._latestAppstreamAgentVersion; }
            set { this._latestAppstreamAgentVersion = value; }
        }

        // Check to see if LatestAppstreamAgentVersion property is set
        internal bool IsSetLatestAppstreamAgentVersion()
        {
            return this._latestAppstreamAgentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the image builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property NetworkAccessConfiguration.
        /// </summary>
        public NetworkAccessConfiguration NetworkAccessConfiguration
        {
            get { return this._networkAccessConfiguration; }
            set { this._networkAccessConfiguration = value; }
        }

        // Check to see if NetworkAccessConfiguration property is set
        internal bool IsSetNetworkAccessConfiguration()
        {
            return this._networkAccessConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The operating system platform of the image builder.
        /// </para>
        /// </summary>
        public PlatformType Platform
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the image builder.
        /// </para>
        /// </summary>
        public ImageBuilderState State
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
        /// Gets and sets the property StateChangeReason. 
        /// <para>
        /// The reason why the last state change occurred.
        /// </para>
        /// </summary>
        public ImageBuilderStateChangeReason StateChangeReason
        {
            get { return this._stateChangeReason; }
            set { this._stateChangeReason = value; }
        }

        // Check to see if StateChangeReason property is set
        internal bool IsSetStateChangeReason()
        {
            return this._stateChangeReason != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC configuration of the image builder.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}