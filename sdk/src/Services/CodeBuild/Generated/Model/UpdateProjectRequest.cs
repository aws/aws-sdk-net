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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProject operation.
    /// Changes the settings of a build project.
    /// </summary>
    public partial class UpdateProjectRequest : AmazonCodeBuildRequest
    {
        private ProjectArtifacts _artifacts;
        private bool? _badgeEnabled;
        private ProjectCache _cache;
        private string _description;
        private string _encryptionKey;
        private ProjectEnvironment _environment;
        private string _name;
        private List<ProjectArtifacts> _secondaryArtifacts = new List<ProjectArtifacts>();
        private List<ProjectSource> _secondarySources = new List<ProjectSource>();
        private string _serviceRole;
        private ProjectSource _source;
        private List<Tag> _tags = new List<Tag>();
        private int? _timeoutInMinutes;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property Artifacts. 
        /// <para>
        /// Information to be changed about the build output artifacts for the build project.
        /// </para>
        /// </summary>
        public ProjectArtifacts Artifacts
        {
            get { return this._artifacts; }
            set { this._artifacts = value; }
        }

        // Check to see if Artifacts property is set
        internal bool IsSetArtifacts()
        {
            return this._artifacts != null;
        }

        /// <summary>
        /// Gets and sets the property BadgeEnabled. 
        /// <para>
        /// Set this to true to generate a publicly-accessible URL for your project's build badge.
        /// </para>
        /// </summary>
        public bool BadgeEnabled
        {
            get { return this._badgeEnabled.GetValueOrDefault(); }
            set { this._badgeEnabled = value; }
        }

        // Check to see if BadgeEnabled property is set
        internal bool IsSetBadgeEnabled()
        {
            return this._badgeEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Cache. 
        /// <para>
        /// Stores recently used information so that it can be quickly accessed at a later time.
        /// </para>
        /// </summary>
        public ProjectCache Cache
        {
            get { return this._cache; }
            set { this._cache = value; }
        }

        // Check to see if Cache property is set
        internal bool IsSetCache()
        {
            return this._cache != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new or replacement description of the build project.
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
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The replacement AWS Key Management Service (AWS KMS) customer master key (CMK) to
        /// be used for encrypting the build output artifacts.
        /// </para>
        ///  
        /// <para>
        /// You can specify either the CMK's Amazon Resource Name (ARN) or, if available, the
        /// CMK's alias (using the format <code>alias/<i>alias-name</i> </code>).
        /// </para>
        /// </summary>
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// Information to be changed about the build environment for the build project.
        /// </para>
        /// </summary>
        public ProjectEnvironment Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the build project.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot change a build project's name.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property SecondaryArtifacts. 
        /// <para>
        ///  An array of <code>ProjectSource</code> objects. 
        /// </para>
        /// </summary>
        public List<ProjectArtifacts> SecondaryArtifacts
        {
            get { return this._secondaryArtifacts; }
            set { this._secondaryArtifacts = value; }
        }

        // Check to see if SecondaryArtifacts property is set
        internal bool IsSetSecondaryArtifacts()
        {
            return this._secondaryArtifacts != null && this._secondaryArtifacts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecondarySources. 
        /// <para>
        ///  An array of <code>ProjectSource</code> objects. 
        /// </para>
        /// </summary>
        public List<ProjectSource> SecondarySources
        {
            get { return this._secondarySources; }
            set { this._secondarySources = value; }
        }

        // Check to see if SecondarySources property is set
        internal bool IsSetSecondarySources()
        {
            return this._secondarySources != null && this._secondarySources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The replacement ARN of the AWS Identity and Access Management (IAM) role that enables
        /// AWS CodeBuild to interact with dependent AWS services on behalf of the AWS account.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Source. 
        /// <para>
        /// Information to be changed about the build input source code for the build project.
        /// </para>
        /// </summary>
        public ProjectSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The replacement set of tags for this build project.
        /// </para>
        ///  
        /// <para>
        /// These tags are available for use by AWS services that support AWS CodeBuild build
        /// project tags.
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
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// The replacement value in minutes, from 5 to 480 (8 hours), for AWS CodeBuild to wait
        /// before timing out any related build that did not get marked as completed.
        /// </para>
        /// </summary>
        public int TimeoutInMinutes
        {
            get { return this._timeoutInMinutes.GetValueOrDefault(); }
            set { this._timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this._timeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// VpcConfig enables AWS CodeBuild to access resources in an Amazon VPC.
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