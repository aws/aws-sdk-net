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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the StartBuild operation.
    /// Starts running a build with the settings defined in the project. These setting include:
    /// how to run a build, where to get the source code, which build environment to use,
    /// which build commands to run, and where to store the build output.
    /// 
    ///  
    /// <para>
    /// You can also start a build run by overriding some of the build settings in the project.
    /// The overrides only apply for that specific start build request. The settings in the
    /// project are unaltered.
    /// </para>
    /// </summary>
    public partial class StartBuildRequest : AmazonCodeBuildRequest
    {
        private ProjectArtifacts _artifactsOverride;
        private int? _autoRetryLimitOverride;
        private string _buildspecOverride;
        private BuildStatusConfig _buildStatusConfigOverride;
        private ProjectCache _cacheOverride;
        private string _certificateOverride;
        private ComputeType _computeTypeOverride;
        private bool? _debugSessionEnabled;
        private string _encryptionKeyOverride;
        private EnvironmentType _environmentTypeOverride;
        private List<EnvironmentVariable> _environmentVariablesOverride = AWSConfigs.InitializeCollections ? new List<EnvironmentVariable>() : null;
        private ProjectFleet _fleetOverride;
        private int? _gitCloneDepthOverride;
        private GitSubmodulesConfig _gitSubmodulesConfigOverride;
        private string _idempotencyToken;
        private string _imageOverride;
        private ImagePullCredentialsType _imagePullCredentialsTypeOverride;
        private bool? _insecureSslOverride;
        private LogsConfig _logsConfigOverride;
        private bool? _privilegedModeOverride;
        private string _projectName;
        private int? _queuedTimeoutInMinutesOverride;
        private RegistryCredential _registryCredentialOverride;
        private bool? _reportBuildStatusOverride;
        private List<ProjectArtifacts> _secondaryArtifactsOverride = AWSConfigs.InitializeCollections ? new List<ProjectArtifacts>() : null;
        private List<ProjectSource> _secondarySourcesOverride = AWSConfigs.InitializeCollections ? new List<ProjectSource>() : null;
        private List<ProjectSourceVersion> _secondarySourcesVersionOverride = AWSConfigs.InitializeCollections ? new List<ProjectSourceVersion>() : null;
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
        /// Gets and sets the property AutoRetryLimitOverride. 
        /// <para>
        /// The maximum number of additional automatic retries after a failed build. For example,
        /// if the auto-retry limit is set to 2, CodeBuild will call the <c>RetryBuild</c> API
        /// to automatically retry your build for up to 2 additional times.
        /// </para>
        /// </summary>
        public int? AutoRetryLimitOverride
        {
            get { return this._autoRetryLimitOverride; }
            set { this._autoRetryLimitOverride = value; }
        }

        // Check to see if AutoRetryLimitOverride property is set
        internal bool IsSetAutoRetryLimitOverride()
        {
            return this._autoRetryLimitOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BuildspecOverride. 
        /// <para>
        /// A buildspec file declaration that overrides the latest one defined in the build project,
        /// for this build only. The buildspec defined on the project is not changed.
        /// </para>
        ///  
        /// <para>
        /// If this value is set, it can be either an inline buildspec definition, the path to
        /// an alternate buildspec file relative to the value of the built-in <c>CODEBUILD_SRC_DIR</c>
        /// environment variable, or the path to an S3 bucket. The bucket must be in the same
        /// Amazon Web Services Region as the build project. Specify the buildspec file using
        /// its ARN (for example, <c>arn:aws:s3:::my-codebuild-sample2/buildspec.yml</c>). If
        /// this value is not provided or is set to an empty string, the source code must contain
        /// a buildspec file in its root directory. For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-spec-ref.html#build-spec-ref-name-storage">Buildspec
        /// File Name and Storage Location</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Since this property allows you to change the build commands that will run in the container,
        /// you should note that an IAM principal with the ability to call this API and set this
        /// parameter can override the default settings. Moreover, we encourage that you use a
        /// trustworthy buildspec location like a file in your source repository or a Amazon S3
        /// bucket. Alternatively, you can restrict overrides to the buildspec by using a condition
        /// key: <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/action-context-keys.html#action-context-keys-example-overridebuildspec.html">Prevent
        /// unauthorized modifications to project buildspec</a>.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property BuildStatusConfigOverride. 
        /// <para>
        /// Contains information that defines how the build project reports the build status to
        /// the source provider. This option is only used when the source provider is <c>GITHUB</c>,
        /// <c>GITHUB_ENTERPRISE</c>, or <c>BITBUCKET</c>.
        /// </para>
        /// </summary>
        public BuildStatusConfig BuildStatusConfigOverride
        {
            get { return this._buildStatusConfigOverride; }
            set { this._buildStatusConfigOverride = value; }
        }

        // Check to see if BuildStatusConfigOverride property is set
        internal bool IsSetBuildStatusConfigOverride()
        {
            return this._buildStatusConfigOverride != null;
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
        /// Gets and sets the property DebugSessionEnabled. 
        /// <para>
        /// Specifies if session debugging is enabled for this build. For more information, see
        /// <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/session-manager.html">Viewing
        /// a running build in Session Manager</a>.
        /// </para>
        /// </summary>
        public bool? DebugSessionEnabled
        {
            get { return this._debugSessionEnabled; }
            set { this._debugSessionEnabled = value; }
        }

        // Check to see if DebugSessionEnabled property is set
        internal bool IsSetDebugSessionEnabled()
        {
            return this._debugSessionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyOverride. 
        /// <para>
        /// The Key Management Service customer master key (CMK) that overrides the one specified
        /// in the build project. The CMK key encrypts the build output artifacts.
        /// </para>
        ///  <note> 
        /// <para>
        ///  You can use a cross-account KMS key to encrypt the build output artifacts if your
        /// service role has permission to that key. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can specify either the Amazon Resource Name (ARN) of the CMK or, if available,
        /// the CMK's alias (using the format <c>alias/&lt;alias-name&gt;</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string EncryptionKeyOverride
        {
            get { return this._encryptionKeyOverride; }
            set { this._encryptionKeyOverride = value; }
        }

        // Check to see if EncryptionKeyOverride property is set
        internal bool IsSetEncryptionKeyOverride()
        {
            return this._encryptionKeyOverride != null;
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentVariable> EnvironmentVariablesOverride
        {
            get { return this._environmentVariablesOverride; }
            set { this._environmentVariablesOverride = value; }
        }

        // Check to see if EnvironmentVariablesOverride property is set
        internal bool IsSetEnvironmentVariablesOverride()
        {
            return this._environmentVariablesOverride != null && (this._environmentVariablesOverride.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FleetOverride. 
        /// <para>
        /// A ProjectFleet object specified for this build that overrides the one defined in the
        /// build project.
        /// </para>
        /// </summary>
        public ProjectFleet FleetOverride
        {
            get { return this._fleetOverride; }
            set { this._fleetOverride = value; }
        }

        // Check to see if FleetOverride property is set
        internal bool IsSetFleetOverride()
        {
            return this._fleetOverride != null;
        }

        /// <summary>
        /// Gets and sets the property GitCloneDepthOverride. 
        /// <para>
        /// The user-defined depth of history, with a minimum value of 0, that overrides, for
        /// this build only, any previous depth of history defined in the build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? GitCloneDepthOverride
        {
            get { return this._gitCloneDepthOverride; }
            set { this._gitCloneDepthOverride = value; }
        }

        // Check to see if GitCloneDepthOverride property is set
        internal bool IsSetGitCloneDepthOverride()
        {
            return this._gitCloneDepthOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GitSubmodulesConfigOverride. 
        /// <para>
        ///  Information about the Git submodules configuration for this build of an CodeBuild
        /// build project. 
        /// </para>
        /// </summary>
        public GitSubmodulesConfig GitSubmodulesConfigOverride
        {
            get { return this._gitSubmodulesConfigOverride; }
            set { this._gitSubmodulesConfigOverride = value; }
        }

        // Check to see if GitSubmodulesConfigOverride property is set
        internal bool IsSetGitSubmodulesConfigOverride()
        {
            return this._gitSubmodulesConfigOverride != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case sensitive identifier you provide to ensure the idempotency of the StartBuild
        /// request. The token is included in the StartBuild request and is valid for 5 minutes.
        /// If you repeat the StartBuild request with the same token, but change a parameter,
        /// CodeBuild returns a parameter mismatch error. 
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
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property ImagePullCredentialsTypeOverride. 
        /// <para>
        /// The type of credentials CodeBuild uses to pull images in your build. There are two
        /// valid values: 
        /// </para>
        ///  <dl> <dt>CODEBUILD</dt> <dd> 
        /// <para>
        /// Specifies that CodeBuild uses its own credentials. This requires that you modify your
        /// ECR repository policy to trust CodeBuild's service principal.
        /// </para>
        ///  </dd> <dt>SERVICE_ROLE</dt> <dd> 
        /// <para>
        /// Specifies that CodeBuild uses your build project's service role. 
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// When using a cross-account or private registry image, you must use <c>SERVICE_ROLE</c>
        /// credentials. When using an CodeBuild curated image, you must use <c>CODEBUILD</c>
        /// credentials. 
        /// </para>
        /// </summary>
        public ImagePullCredentialsType ImagePullCredentialsTypeOverride
        {
            get { return this._imagePullCredentialsTypeOverride; }
            set { this._imagePullCredentialsTypeOverride = value; }
        }

        // Check to see if ImagePullCredentialsTypeOverride property is set
        internal bool IsSetImagePullCredentialsTypeOverride()
        {
            return this._imagePullCredentialsTypeOverride != null;
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
        public bool? InsecureSslOverride
        {
            get { return this._insecureSslOverride; }
            set { this._insecureSslOverride = value; }
        }

        // Check to see if InsecureSslOverride property is set
        internal bool IsSetInsecureSslOverride()
        {
            return this._insecureSslOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogsConfigOverride. 
        /// <para>
        ///  Log settings for this build that override the log settings defined in the build project.
        /// 
        /// </para>
        /// </summary>
        public LogsConfig LogsConfigOverride
        {
            get { return this._logsConfigOverride; }
            set { this._logsConfigOverride = value; }
        }

        // Check to see if LogsConfigOverride property is set
        internal bool IsSetLogsConfigOverride()
        {
            return this._logsConfigOverride != null;
        }

        /// <summary>
        /// Gets and sets the property PrivilegedModeOverride. 
        /// <para>
        /// Enable this flag to override privileged mode in the build project.
        /// </para>
        /// </summary>
        public bool? PrivilegedModeOverride
        {
            get { return this._privilegedModeOverride; }
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
        /// The name of the CodeBuild build project to start running a build.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property QueuedTimeoutInMinutesOverride. 
        /// <para>
        ///  The number of minutes a build is allowed to be queued before it times out. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=480)]
        public int? QueuedTimeoutInMinutesOverride
        {
            get { return this._queuedTimeoutInMinutesOverride; }
            set { this._queuedTimeoutInMinutesOverride = value; }
        }

        // Check to see if QueuedTimeoutInMinutesOverride property is set
        internal bool IsSetQueuedTimeoutInMinutesOverride()
        {
            return this._queuedTimeoutInMinutesOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegistryCredentialOverride. 
        /// <para>
        ///  The credentials for access to a private registry. 
        /// </para>
        /// </summary>
        public RegistryCredential RegistryCredentialOverride
        {
            get { return this._registryCredentialOverride; }
            set { this._registryCredentialOverride = value; }
        }

        // Check to see if RegistryCredentialOverride property is set
        internal bool IsSetRegistryCredentialOverride()
        {
            return this._registryCredentialOverride != null;
        }

        /// <summary>
        /// Gets and sets the property ReportBuildStatusOverride. 
        /// <para>
        ///  Set to true to report to your source provider the status of a build's start and completion.
        /// If you use this option with a source provider other than GitHub, GitHub Enterprise,
        /// GitLab, GitLab Self Managed, or Bitbucket, an <c>invalidInputException</c> is thrown.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To be able to report the build status to the source provider, the user associated
        /// with the source provider must have write access to the repo. If the user does not
        /// have write access, the build status cannot be updated. For more information, see <a
        /// href="https://docs.aws.amazon.com/codebuild/latest/userguide/access-tokens.html">Source
        /// provider access</a> in the <i>CodeBuild User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  The status of a build triggered by a webhook is always reported to your source provider.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public bool? ReportBuildStatusOverride
        {
            get { return this._reportBuildStatusOverride; }
            set { this._reportBuildStatusOverride = value; }
        }

        // Check to see if ReportBuildStatusOverride property is set
        internal bool IsSetReportBuildStatusOverride()
        {
            return this._reportBuildStatusOverride.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecondaryArtifactsOverride. 
        /// <para>
        ///  An array of <c>ProjectArtifacts</c> objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<ProjectArtifacts> SecondaryArtifactsOverride
        {
            get { return this._secondaryArtifactsOverride; }
            set { this._secondaryArtifactsOverride = value; }
        }

        // Check to see if SecondaryArtifactsOverride property is set
        internal bool IsSetSecondaryArtifactsOverride()
        {
            return this._secondaryArtifactsOverride != null && (this._secondaryArtifactsOverride.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecondarySourcesOverride. 
        /// <para>
        ///  An array of <c>ProjectSource</c> objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<ProjectSource> SecondarySourcesOverride
        {
            get { return this._secondarySourcesOverride; }
            set { this._secondarySourcesOverride = value; }
        }

        // Check to see if SecondarySourcesOverride property is set
        internal bool IsSetSecondarySourcesOverride()
        {
            return this._secondarySourcesOverride != null && (this._secondarySourcesOverride.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecondarySourcesVersionOverride. 
        /// <para>
        ///  An array of <c>ProjectSourceVersion</c> objects that specify one or more versions
        /// of the project's secondary sources to be used for this build only. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<ProjectSourceVersion> SecondarySourcesVersionOverride
        {
            get { return this._secondarySourcesVersionOverride; }
            set { this._secondarySourcesVersionOverride = value; }
        }

        // Check to see if SecondarySourcesVersionOverride property is set
        internal bool IsSetSecondarySourcesVersionOverride()
        {
            return this._secondarySourcesVersionOverride != null && (this._secondarySourcesVersionOverride.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceRoleOverride. 
        /// <para>
        /// The name of a service role for this build that overrides the one specified in the
        /// build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// This override applies only if the build project's source is BitBucket, GitHub, GitLab,
        /// or GitLab Self Managed.
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
        /// A location that overrides, for this build, the source location for the one defined
        /// in the build project.
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
        /// A source input type, for this build, that overrides the source input defined in the
        /// build project.
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
        /// The version of the build input to be built, for this build only. If not specified,
        /// the latest version is used. If specified, the contents depends on the source provider:
        /// </para>
        ///  <dl> <dt>CodeCommit</dt> <dd> 
        /// <para>
        /// The commit ID, branch, or Git tag to use.
        /// </para>
        ///  </dd> <dt>GitHub</dt> <dd> 
        /// <para>
        /// The commit ID, pull request ID, branch name, or tag name that corresponds to the version
        /// of the source code you want to build. If a pull request ID is specified, it must use
        /// the format <c>pr/pull-request-ID</c> (for example <c>pr/25</c>). If a branch name
        /// is specified, the branch's HEAD commit ID is used. If not specified, the default branch's
        /// HEAD commit ID is used.
        /// </para>
        ///  </dd> <dt>GitLab</dt> <dd> 
        /// <para>
        /// The commit ID, branch, or Git tag to use.
        /// </para>
        ///  </dd> <dt>Bitbucket</dt> <dd> 
        /// <para>
        /// The commit ID, branch name, or tag name that corresponds to the version of the source
        /// code you want to build. If a branch name is specified, the branch's HEAD commit ID
        /// is used. If not specified, the default branch's HEAD commit ID is used.
        /// </para>
        ///  </dd> <dt>Amazon S3</dt> <dd> 
        /// <para>
        /// The version ID of the object that represents the build input ZIP file to use.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// If <c>sourceVersion</c> is specified at the project level, then this <c>sourceVersion</c>
        /// (at the build level) takes precedence. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/sample-source-version.html">Source
        /// Version Sample with CodeBuild</a> in the <i>CodeBuild User Guide</i>. 
        /// </para>
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
        /// The number of build timeout minutes, from 5 to 2160 (36 hours), that overrides, for
        /// this build only, the latest setting already defined in the build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=2160)]
        public int? TimeoutInMinutesOverride
        {
            get { return this._timeoutInMinutesOverride; }
            set { this._timeoutInMinutesOverride = value; }
        }

        // Check to see if TimeoutInMinutesOverride property is set
        internal bool IsSetTimeoutInMinutesOverride()
        {
            return this._timeoutInMinutesOverride.HasValue; 
        }

    }
}