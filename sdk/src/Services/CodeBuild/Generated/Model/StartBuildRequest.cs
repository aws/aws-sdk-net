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
    /// Container for the parameters to the StartBuild operation.
    /// Starts running a build.
    /// </summary>
    public partial class StartBuildRequest : AmazonCodeBuildRequest
    {
        private ProjectArtifacts _artifactsOverride;
        private string _buildspecOverride;
        private ProjectCache _cacheOverride;
        private string _certificateOverride;
        private ComputeType _computeTypeOverride;
        private EnvironmentType _environmentTypeOverride;
        private List<EnvironmentVariable> _environmentVariablesOverride = new List<EnvironmentVariable>();
        private int? _gitCloneDepthOverride;
        private string _idempotencyToken;
        private string _imageOverride;
        private bool? _insecureSslOverride;
        private bool? _privilegedModeOverride;
        private string _projectName;
        private string _serviceRoleOverride;
        private SourceAuth _sourceAuthOverride;
        private string _sourceLocationOverride;
        private SourceType _sourceTypeOverride;
        private string _sourceVersion;
        private int? _timeoutInMinutesOverride;

        /// <summary>
        /// Gets and sets the property ArtifactsOverride. 
        /// <para>
        /// Build output artifact settings that override, for this build only, the latest ones
        /// already defined in the build project.
        /// </para>
        /// </summary>
        public ProjectArtifacts ArtifactsOverride
        {
            get { return this._artifactsOverride; }
            set { this._artifactsOverride = value; }
        }

        // Check to see if ArtifactsOverride property is set
        internal bool IsSetArtifactsOverride()
        {
            return this._artifactsOverride != null;
        }

        /// <summary>
        /// Gets and sets the property BuildspecOverride. 
        /// <para>
        /// A build spec declaration that overrides, for this build only, the latest one already
        /// defined in the build project.
        /// </para>
        /// </summary>
        public string BuildspecOverride
        {
            get { return this._buildspecOverride; }
            set { this._buildspecOverride = value; }
        }

        // Check to see if BuildspecOverride property is set
        internal bool IsSetBuildspecOverride()
        {
            return this._buildspecOverride != null;
        }

        /// <summary>
        /// Gets and sets the property CacheOverride. 
        /// <para>
        /// A ProjectCache object specified for this build that overrides the one defined in the
        /// build project.
        /// </para>
        /// </summary>
        public ProjectCache CacheOverride
        {
            get { return this._cacheOverride; }
            set { this._cacheOverride = value; }
        }

        // Check to see if CacheOverride property is set
        internal bool IsSetCacheOverride()
        {
            return this._cacheOverride != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateOverride. 
        /// <para>
        /// The name of a certificate for this build that overrides the one specified in the build
        /// project.
        /// </para>
        /// </summary>
        public string CertificateOverride
        {
            get { return this._certificateOverride; }
            set { this._certificateOverride = value; }
        }

        // Check to see if CertificateOverride property is set
        internal bool IsSetCertificateOverride()
        {
            return this._certificateOverride != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeTypeOverride. 
        /// <para>
        /// The name of a compute type for this build that overrides the one specified in the
        /// build project.
        /// </para>
        /// </summary>
        public ComputeType ComputeTypeOverride
        {
            get { return this._computeTypeOverride; }
            set { this._computeTypeOverride = value; }
        }

        // Check to see if ComputeTypeOverride property is set
        internal bool IsSetComputeTypeOverride()
        {
            return this._computeTypeOverride != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentTypeOverride. 
        /// <para>
        /// A container type for this build that overrides the one specified in the build project.
        /// </para>
        /// </summary>
        public EnvironmentType EnvironmentTypeOverride
        {
            get { return this._environmentTypeOverride; }
            set { this._environmentTypeOverride = value; }
        }

        // Check to see if EnvironmentTypeOverride property is set
        internal bool IsSetEnvironmentTypeOverride()
        {
            return this._environmentTypeOverride != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariablesOverride. 
        /// <para>
        /// A set of environment variables that overrides, for this build only, the latest ones
        /// already defined in the build project.
        /// </para>
        /// </summary>
        public List<EnvironmentVariable> EnvironmentVariablesOverride
        {
            get { return this._environmentVariablesOverride; }
            set { this._environmentVariablesOverride = value; }
        }

        // Check to see if EnvironmentVariablesOverride property is set
        internal bool IsSetEnvironmentVariablesOverride()
        {
            return this._environmentVariablesOverride != null && this._environmentVariablesOverride.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GitCloneDepthOverride. 
        /// <para>
        /// The user-defined depth of history, with a minimum value of 0, that overrides, for
        /// this build only, any previous depth of history defined in the build project.
        /// </para>
        /// </summary>
        public int GitCloneDepthOverride
        {
            get { return this._gitCloneDepthOverride.GetValueOrDefault(); }
            set { this._gitCloneDepthOverride = value; }
        }

        // Check to see if GitCloneDepthOverride property is set
        internal bool IsSetGitCloneDepthOverride()
        {
            return this._gitCloneDepthOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case sensitive identifier you provide to ensure the idempotency of the StartBuild
        /// request. The token is included in the StartBuild request and is valid for 12 hours.
        /// If you repeat the StartBuild request with the same token, but change a parameter,
        /// AWS CodeBuild returns a parameter mismatch error. 
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property ImageOverride. 
        /// <para>
        /// The name of an image for this build that overrides the one specified in the build
        /// project.
        /// </para>
        /// </summary>
        public string ImageOverride
        {
            get { return this._imageOverride; }
            set { this._imageOverride = value; }
        }

        // Check to see if ImageOverride property is set
        internal bool IsSetImageOverride()
        {
            return this._imageOverride != null;
        }

        /// <summary>
        /// Gets and sets the property InsecureSslOverride. 
        /// <para>
        /// Enable this flag to override the insecure SSL setting that is specified in the build
        /// project. The insecure SSL setting determines whether to ignore SSL warnings while
        /// connecting to the project source code. This override applies only if the build's source
        /// is GitHub Enterprise.
        /// </para>
        /// </summary>
        public bool InsecureSslOverride
        {
            get { return this._insecureSslOverride.GetValueOrDefault(); }
            set { this._insecureSslOverride = value; }
        }

        // Check to see if InsecureSslOverride property is set
        internal bool IsSetInsecureSslOverride()
        {
            return this._insecureSslOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivilegedModeOverride. 
        /// <para>
        /// Enable this flag to override privileged mode in the build project.
        /// </para>
        /// </summary>
        public bool PrivilegedModeOverride
        {
            get { return this._privilegedModeOverride.GetValueOrDefault(); }
            set { this._privilegedModeOverride = value; }
        }

        // Check to see if PrivilegedModeOverride property is set
        internal bool IsSetPrivilegedModeOverride()
        {
            return this._privilegedModeOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the AWS CodeBuild build project to start running a build.
        /// </para>
        /// </summary>
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRoleOverride. 
        /// <para>
        /// The name of a service role for this build that overrides the one specified in the
        /// build project.
        /// </para>
        /// </summary>
        public string ServiceRoleOverride
        {
            get { return this._serviceRoleOverride; }
            set { this._serviceRoleOverride = value; }
        }

        // Check to see if ServiceRoleOverride property is set
        internal bool IsSetServiceRoleOverride()
        {
            return this._serviceRoleOverride != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAuthOverride. 
        /// <para>
        /// An authorization type for this build that overrides the one defined in the build project.
        /// This override applies only if the build project's source is BitBucket or GitHub.
        /// </para>
        /// </summary>
        public SourceAuth SourceAuthOverride
        {
            get { return this._sourceAuthOverride; }
            set { this._sourceAuthOverride = value; }
        }

        // Check to see if SourceAuthOverride property is set
        internal bool IsSetSourceAuthOverride()
        {
            return this._sourceAuthOverride != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLocationOverride. 
        /// <para>
        /// A location that overrides for this build the source location for the one defined in
        /// the build project.
        /// </para>
        /// </summary>
        public string SourceLocationOverride
        {
            get { return this._sourceLocationOverride; }
            set { this._sourceLocationOverride = value; }
        }

        // Check to see if SourceLocationOverride property is set
        internal bool IsSetSourceLocationOverride()
        {
            return this._sourceLocationOverride != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTypeOverride. 
        /// <para>
        /// A source input type for this build that overrides the source input defined in the
        /// build project
        /// </para>
        /// </summary>
        public SourceType SourceTypeOverride
        {
            get { return this._sourceTypeOverride; }
            set { this._sourceTypeOverride = value; }
        }

        // Check to see if SourceTypeOverride property is set
        internal bool IsSetSourceTypeOverride()
        {
            return this._sourceTypeOverride != null;
        }

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// A version of the build input to be built, for this build only. If not specified, the
        /// latest version will be used. If specified, must be one of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For AWS CodeCommit: the commit ID to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For GitHub: the commit ID, pull request ID, branch name, or tag name that corresponds
        /// to the version of the source code you want to build. If a pull request ID is specified,
        /// it must use the format <code>pr/pull-request-ID</code> (for example <code>pr/25</code>).
        /// If a branch name is specified, the branch's HEAD commit ID will be used. If not specified,
        /// the default branch's HEAD commit ID will be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Bitbucket: the commit ID, branch name, or tag name that corresponds to the version
        /// of the source code you want to build. If a branch name is specified, the branch's
        /// HEAD commit ID will be used. If not specified, the default branch's HEAD commit ID
        /// will be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon Simple Storage Service (Amazon S3): the version ID of the object representing
        /// the build input ZIP file to use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SourceVersion
        {
            get { return this._sourceVersion; }
            set { this._sourceVersion = value; }
        }

        // Check to see if SourceVersion property is set
        internal bool IsSetSourceVersion()
        {
            return this._sourceVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMinutesOverride. 
        /// <para>
        /// The number of build timeout minutes, from 5 to 480 (8 hours), that overrides, for
        /// this build only, the latest setting already defined in the build project.
        /// </para>
        /// </summary>
        public int TimeoutInMinutesOverride
        {
            get { return this._timeoutInMinutesOverride.GetValueOrDefault(); }
            set { this._timeoutInMinutesOverride = value; }
        }

        // Check to see if TimeoutInMinutesOverride property is set
        internal bool IsSetTimeoutInMinutesOverride()
        {
            return this._timeoutInMinutesOverride.HasValue; 
        }

    }
}