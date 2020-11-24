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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStudio operation.
    /// <note> 
    /// <para>
    /// The Amazon EMR Studio APIs are in preview release for Amazon EMR and are subject to
    /// change.
    /// </para>
    ///  </note> 
    /// <para>
    /// Creates a new Amazon EMR Studio.
    /// </para>
    /// </summary>
    public partial class CreateStudioRequest : AmazonElasticMapReduceRequest
    {
        private AuthMode _authMode;
        private string _defaultS3Location;
        private string _description;
        private string _engineSecurityGroupId;
        private string _name;
        private string _serviceRole;
        private List<string> _subnetIds = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private string _userRole;
        private string _vpcId;
        private string _workspaceSecurityGroupId;

        /// <summary>
        /// Gets and sets the property AuthMode. 
        /// <para>
        /// Specifies whether the Studio authenticates users using single sign-on (SSO) or IAM.
        /// Amazon EMR Studio currently only supports SSO authentication.
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
        /// The default Amazon S3 location to back up EMR Studio Workspaces and notebook files.
        /// A Studio user can select an alternative Amazon S3 location when creating a Workspace.
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
        /// A detailed description of the Studio.
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
        /// Gets and sets the property EngineSecurityGroupId. 
        /// <para>
        /// The ID of the Amazon EMR Studio Engine security group. The Engine security group allows
        /// inbound network traffic from the Workspace security group, and it must be in the same
        /// VPC specified by <code>VpcId</code>.
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
        /// The IAM role that will be assumed by the Amazon EMR Studio. The service role provides
        /// a way for Amazon EMR Studio to interoperate with other AWS services.
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
        /// A list of subnet IDs to associate with the Studio. The subnets must belong to the
        /// VPC specified by <code>VpcId</code>. Studio users can create a Workspace in any of
        /// the specified subnets.
        /// </para>
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
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the Studio. Tags are user-defined key-value pairs
        /// that consist of a required key string with a maximum of 128 characters, and an optional
        /// value string with a maximum of 256 characters.
        /// </para>
        /// </summary>
        public List<Tag> Tags
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
        /// Gets and sets the property UserRole. 
        /// <para>
        /// The IAM user role that will be assumed by users and groups logged in to a Studio.
        /// The permissions attached to this IAM role can be scoped down for each user or group
        /// using session policies.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10280)]
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
        /// must be in the same VPC specified by <code>VpcId</code>.
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