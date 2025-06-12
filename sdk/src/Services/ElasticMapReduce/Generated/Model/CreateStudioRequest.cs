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
    /// Container for the parameters to the CreateStudio operation.
    /// Creates a new Amazon EMR Studio.
    /// </summary>
    public partial class CreateStudioRequest : AmazonElasticMapReduceRequest
    {
        private AuthMode _authMode;
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
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _trustedIdentityPropagationEnabled;
        private string _userRole;
        private string _vpcId;
        private string _workspaceSecurityGroupId;

        /// <summary>
        /// Gets and sets the property AuthMode. 
        /// <para>
        /// Specifies whether the Studio authenticates users using IAM or IAM Identity Center.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DefaultS3Location. 
        /// <para>
        /// The Amazon S3 location to back up Amazon EMR Studio Workspaces and notebook files.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10280)]
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
        /// A detailed description of the Amazon EMR Studio.
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
        /// The ID of the Amazon EMR Studio Engine security group. The Engine security group allows
        /// inbound network traffic from the Workspace security group, and it must be in the same
        /// VPC specified by <c>VpcId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        ///  The ARN of the IAM Identity Center instance to create the Studio application. 
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
        ///  Specifies whether IAM Identity Center user assignment is <c>REQUIRED</c> or <c>OPTIONAL</c>.
        /// If the value is set to <c>REQUIRED</c>, users must be explicitly assigned to the Studio
        /// application to access the Studio. 
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
        /// The authentication endpoint of your identity provider (IdP). Specify this value when
        /// you use IAM authentication and want to let federated users log in to a Studio with
        /// the Studio URL and credentials from your IdP. Amazon EMR Studio redirects users to
        /// this endpoint to enter credentials.
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
        /// The name that your identity provider (IdP) uses for its <c>RelayState</c> parameter.
        /// For example, <c>RelayState</c> or <c>TargetSource</c>. Specify this value when you
        /// use IAM authentication and want to let federated users log in to a Studio using the
        /// Studio URL. The <c>RelayState</c> parameter differs by IdP.
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
        /// A descriptive name for the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// The IAM role that the Amazon EMR Studio assumes. The service role provides a way for
        /// Amazon EMR Studio to interoperate with other Amazon Web Services services.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10280)]
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of subnet IDs to associate with the Amazon EMR Studio. A Studio can have a
        /// maximum of 5 subnets. The subnets must belong to the VPC specified by <c>VpcId</c>.
        /// Studio users can create a Workspace in any of the specified subnets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A list of tags to associate with the Amazon EMR Studio. Tags are user-defined key-value
        /// pairs that consist of a required key string with a maximum of 128 characters, and
        /// an optional value string with a maximum of 256 characters.
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
        ///  A Boolean indicating whether to enable Trusted identity propagation for the Studio.
        /// The default value is <c>false</c>. 
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
        /// Gets and sets the property UserRole. 
        /// <para>
        /// The IAM user role that users and groups assume when logged in to an Amazon EMR Studio.
        /// Only specify a <c>UserRole</c> when you use IAM Identity Center authentication. The
        /// permissions attached to the <c>UserRole</c> can be scoped down for each user or group
        /// using session policies.
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
        /// The ID of the Amazon Virtual Private Cloud (Amazon VPC) to associate with the Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// The ID of the Amazon EMR Studio Workspace security group. The Workspace security group
        /// allows outbound network traffic to resources in the Engine security group, and it
        /// must be in the same VPC specified by <c>VpcId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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