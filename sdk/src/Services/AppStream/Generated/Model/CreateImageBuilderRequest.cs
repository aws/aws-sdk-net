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
    /// Container for the parameters to the CreateImageBuilder operation.
    /// Creates an image builder. An image builder is a virtual machine that is used to create
    /// an image.
    /// 
    ///  
    /// <para>
    /// The initial state of the builder is <c>PENDING</c>. When it is ready, the state is
    /// <c>RUNNING</c>.
    /// </para>
    /// </summary>
    public partial class CreateImageBuilderRequest : AmazonAppStreamRequest
    {
        private List<AccessEndpoint> _accessEndpoints = AWSConfigs.InitializeCollections ? new List<AccessEndpoint>() : null;
        private string _appstreamAgentVersion;
        private string _description;
        private string _displayName;
        private DomainJoinInfo _domainJoinInfo;
        private bool? _enableDefaultInternetAccess;
        private string _iamRoleArn;
        private string _imageArn;
        private string _imageName;
        private string _instanceType;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property AccessEndpoints. 
        /// <para>
        /// The list of interface VPC endpoint (interface endpoint) objects. Administrators can
        /// connect to the image builder only through the specified endpoints.
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
        /// The version of the AppStream 2.0 agent to use for this image builder. To use the latest
        /// version of the AppStream 2.0 agent, specify [LATEST]. 
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to display.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        [AWSProperty(Max=100)]
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
        /// The Amazon Resource Name (ARN) of the IAM role to apply to the image builder. To assume
        /// a role, the image builder calls the AWS Security Token Service (STS) <c>AssumeRole</c>
        /// API operation and passes the ARN of the role to use. The operation creates a new session
        /// with temporary credentials. AppStream 2.0 retrieves the temporary credentials and
        /// creates the <b>appstream_machine_role</b> credential profile on the instance.
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
        /// The ARN of the public, private, or shared image to use.
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
        /// Gets and sets the property ImageName. 
        /// <para>
        /// The name of the image used to create the image builder.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ImageName
        {
            get { return this._imageName; }
            set { this._imageName = value; }
        }

        // Check to see if ImageName property is set
        internal bool IsSetImageName()
        {
            return this._imageName != null;
        }

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
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the image builder.
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
        /// Your Resources</a> in the <i>Amazon AppStream 2.0 Administration Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC configuration for the image builder. You can specify only one subnet.
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