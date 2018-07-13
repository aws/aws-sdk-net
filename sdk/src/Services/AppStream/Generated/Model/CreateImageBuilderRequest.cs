/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateImageBuilder operation.
    /// Creates an image builder. An image builder is a virtual machine that is used to create
    /// an image.
    /// 
    ///  
    /// <para>
    /// The initial state of the builder is <code>PENDING</code>. When it is ready, the state
    /// is <code>RUNNING</code>.
    /// </para>
    /// </summary>
    public partial class CreateImageBuilderRequest : AmazonAppStreamRequest
    {
        private string _appstreamAgentVersion;
        private string _description;
        private string _displayName;
        private DomainJoinInfo _domainJoinInfo;
        private bool? _enableDefaultInternetAccess;
        private string _imageArn;
        private string _imageName;
        private string _instanceType;
        private string _name;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property AppstreamAgentVersion. 
        /// <para>
        /// The version of the AppStream 2.0 agent to use for this image builder. To use the latest
        /// version of the AppStream 2.0 agent, specify [LATEST]. 
        /// </para>
        /// </summary>
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
        /// The description for display.
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The image builder name for display.
        /// </para>
        /// </summary>
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
        /// The information needed to join a Microsoft Active Directory domain.
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
        public bool EnableDefaultInternetAccess
        {
            get { return this._enableDefaultInternetAccess.GetValueOrDefault(); }
            set { this._enableDefaultInternetAccess = value; }
        }

        // Check to see if EnableDefaultInternetAccess property is set
        internal bool IsSetEnableDefaultInternetAccess()
        {
            return this._enableDefaultInternetAccess.HasValue; 
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
        /// The name of the image used to create the builder.
        /// </para>
        /// </summary>
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
        /// The instance type to use when launching the image builder.
        /// </para>
        /// </summary>
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