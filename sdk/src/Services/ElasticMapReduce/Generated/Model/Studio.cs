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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Details for an Amazon EMR Studio including ID, creation time, name, and so on.
    /// </summary>
    public partial class Studio
    {
        private AuthMode _authMode;
        private DateTime? _creationTime;
        private string _defaultS3Location;
        private string _description;
        private string _encryptionKeyArn;
        private string _engineSecurityGroupId;
        private string _idcInstanceArn;
        private IdcUserAssignment _idcUserAssignment;
        private string _idpAuthUrl;
        private string _idpRelayStateParameterName;
        private string _name;
        private string _serviceRole;
        private string _studioArn;
        private string _studioId;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _trustedIdentityPropagationEnabled;
        private string _url;
        private string _userRole;
        private string _vpcId;
        private string _workspaceSecurityGroupId;

        /// <summary>
        /// Gets and sets the property AuthMode. 
        /// <para>
        /// Specifies whether the Amazon EMR Studio authenticates users with IAM or IAM Identity
        /// Center.
        /// </para>
        /// </summary>
        public AuthMode AuthMode
        {
            get { return this._authMode; }
            set { this._authMode = value; }
        }

        // Check to see if AuthMode property is set
        internal bool IsSetAuthMode()
        {
            return this._authMode != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the Amazon EMR Studio was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultS3Location. 
        /// <para>
        /// The Amazon S3 location to back up Amazon EMR Studio Workspaces and notebook files.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string DefaultS3Location
        {
            get { return this._defaultS3Location; }
            set { this._defaultS3Location = value; }
        }

        // Check to see if DefaultS3Location property is set
        internal bool IsSetDefaultS3Location()
        {
            return this._defaultS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The detailed description of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The KMS key identifier (ARN) used to encrypt Amazon EMR Studio workspace and notebook
        /// files when backed up to Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property EngineSecurityGroupId. 
        /// <para>
        /// The ID of the Engine security group associated with the Amazon EMR Studio. The Engine
        /// security group allows inbound network traffic from resources in the Workspace security
        /// group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string EngineSecurityGroupId
        {
            get { return this._engineSecurityGroupId; }
            set { this._engineSecurityGroupId = value; }
        }

        // Check to see if EngineSecurityGroupId property is set
        internal bool IsSetEngineSecurityGroupId()
        {
            return this._engineSecurityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property IdcInstanceArn. 
        /// <para>
        ///  The ARN of the IAM Identity Center instance the Studio application belongs to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string IdcInstanceArn
        {
            get { return this._idcInstanceArn; }
            set { this._idcInstanceArn = value; }
        }

        // Check to see if IdcInstanceArn property is set
        internal bool IsSetIdcInstanceArn()
        {
            return this._idcInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdcUserAssignment. 
        /// <para>
        ///  Indicates whether the Studio has <c>REQUIRED</c> or <c>OPTIONAL</c> IAM Identity
        /// Center user assignment. If the value is set to <c>REQUIRED</c>, users must be explicitly
        /// assigned to the Studio application to access the Studio. 
        /// </para>
        /// </summary>
        public IdcUserAssignment IdcUserAssignment
        {
            get { return this._idcUserAssignment; }
            set { this._idcUserAssignment = value; }
        }

        // Check to see if IdcUserAssignment property is set
        internal bool IsSetIdcUserAssignment()
        {
            return this._idcUserAssignment != null;
        }

        /// <summary>
        /// Gets and sets the property IdpAuthUrl. 
        /// <para>
        /// Your identity provider's authentication endpoint. Amazon EMR Studio redirects federated
        /// users to this endpoint for authentication when logging in to a Studio with the Studio
        /// URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string IdpAuthUrl
        {
            get { return this._idpAuthUrl; }
            set { this._idpAuthUrl = value; }
        }

        // Check to see if IdpAuthUrl property is set
        internal bool IsSetIdpAuthUrl()
        {
            return this._idpAuthUrl != null;
        }

        /// <summary>
        /// Gets and sets the property IdpRelayStateParameterName. 
        /// <para>
        /// The name of your identity provider's <c>RelayState</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string IdpRelayStateParameterName
        {
            get { return this._idpRelayStateParameterName; }
            set { this._idpRelayStateParameterName = value; }
        }

        // Check to see if IdpRelayStateParameterName property is set
        internal bool IsSetIdpRelayStateParameterName()
        {
            return this._idpRelayStateParameterName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The name of the IAM role assumed by the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property StudioArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string StudioArn
        {
            get { return this._studioArn; }
            set { this._studioArn = value; }
        }

        // Check to see if StudioArn property is set
        internal bool IsSetStudioArn()
        {
            return this._studioArn != null;
        }

        /// <summary>
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The ID of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string StudioId
        {
            get { return this._studioId; }
            set { this._studioId = value; }
        }

        // Check to see if StudioId property is set
        internal bool IsSetStudioId()
        {
            return this._studioId != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The list of IDs of the subnets associated with the Amazon EMR Studio.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with the Amazon EMR Studio.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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
        /// Gets and sets the property TrustedIdentityPropagationEnabled. 
        /// <para>
        ///  Indicates whether the Studio has Trusted identity propagation enabled. The default
        /// value is <c>false</c>. 
        /// </para>
        /// </summary>
        public bool? TrustedIdentityPropagationEnabled
        {
            get { return this._trustedIdentityPropagationEnabled; }
            set { this._trustedIdentityPropagationEnabled = value; }
        }

        // Check to see if TrustedIdentityPropagationEnabled property is set
        internal bool IsSetTrustedIdentityPropagationEnabled()
        {
            return this._trustedIdentityPropagationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The unique access URL of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

        /// <summary>
        /// Gets and sets the property UserRole. 
        /// <para>
        /// The name of the IAM role assumed by users logged in to the Amazon EMR Studio. A Studio
        /// only requires a <c>UserRole</c> when you use IAM authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string UserRole
        {
            get { return this._userRole; }
            set { this._userRole = value; }
        }

        // Check to see if UserRole property is set
        internal bool IsSetUserRole()
        {
            return this._userRole != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC associated with the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceSecurityGroupId. 
        /// <para>
        /// The ID of the Workspace security group associated with the Amazon EMR Studio. The
        /// Workspace security group allows outbound network traffic to resources in the Engine
        /// security group and to the internet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string WorkspaceSecurityGroupId
        {
            get { return this._workspaceSecurityGroupId; }
            set { this._workspaceSecurityGroupId = value; }
        }

        // Check to see if WorkspaceSecurityGroupId property is set
        internal bool IsSetWorkspaceSecurityGroupId()
        {
            return this._workspaceSecurityGroupId != null;
        }

    }
}