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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the StartBuildBatch operation. Starts a batch build
    /// for a project.
    /// </summary>
    public partial class StartBuildBatchRequest : AmazonCodeBuildRequest
    {
        /// <summary>
        /// Gets and sets the property ArtifactsOverride. 
        /// <para>
        /// An array of <c>ProjectArtifacts</c> objects that contains information about the build
        /// output artifact overrides for the build project.
        /// </para>
        /// </summary>
        public ProjectArtifacts ArtifactsOverride { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactsOverride property is set.
        /// </summary>
        internal bool IsSetArtifactsOverride() => this.ArtifactsOverride != null;

        /// <summary>
        /// Gets and sets the property BuildBatchConfigOverride. 
        /// <para>
        /// A <c>BuildBatchConfigOverride</c> object that contains batch build configuration overrides.
        /// </para>
        /// </summary>
        public ProjectBuildBatchConfig BuildBatchConfigOverride { get; set; }

        /// <summary>
        /// Checks to see if the BuildBatchConfigOverride property is set.
        /// </summary>
        internal bool IsSetBuildBatchConfigOverride() => this.BuildBatchConfigOverride != null;

        /// <summary>
        /// Gets and sets the property BuildTimeoutInMinutesOverride. 
        /// <para>
        /// Overrides the build timeout specified in the batch build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 2160)]
        public int? BuildTimeoutInMinutesOverride { get; set; }

        /// <summary>
        /// Checks to see if the BuildTimeoutInMinutesOverride property is set.
        /// </summary>
        internal bool IsSetBuildTimeoutInMinutesOverride() => this.BuildTimeoutInMinutesOverride.HasValue;

        /// <summary>
        /// Gets and sets the property BuildspecOverride. 
        /// <para>
        /// A buildspec file declaration that overrides, for this build only, the latest one already
        /// defined in the build project.
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
        /// </summary>
        public string BuildspecOverride { get; set; }

        /// <summary>
        /// Checks to see if the BuildspecOverride property is set.
        /// </summary>
        internal bool IsSetBuildspecOverride() => this.BuildspecOverride != null;

        /// <summary>
        /// Gets and sets the property CacheOverride. 
        /// <para>
        /// A <c>ProjectCache</c> object that specifies cache overrides.
        /// </para>
        /// </summary>
        public ProjectCache CacheOverride { get; set; }

        /// <summary>
        /// Checks to see if the CacheOverride property is set.
        /// </summary>
        internal bool IsSetCacheOverride() => this.CacheOverride != null;

        /// <summary>
        /// Gets and sets the property CertificateOverride. 
        /// <para>
        /// The name of a certificate for this batch build that overrides the one specified in
        /// the batch build project.
        /// </para>
        /// </summary>
        public string CertificateOverride { get; set; }

        /// <summary>
        /// Checks to see if the CertificateOverride property is set.
        /// </summary>
        internal bool IsSetCertificateOverride() => this.CertificateOverride != null;

        /// <summary>
        /// Gets and sets the property ComputeTypeOverride. 
        /// <para>
        /// The name of a compute type for this batch build that overrides the one specified in
        /// the batch build project.
        /// </para>
        /// </summary>
        public ComputeType ComputeTypeOverride { get; set; }

        /// <summary>
        /// Checks to see if the ComputeTypeOverride property is set.
        /// </summary>
        internal bool IsSetComputeTypeOverride() => this.ComputeTypeOverride != null;

        /// <summary>
        /// Gets and sets the property DebugSessionEnabled. 
        /// <para>
        /// Specifies if session debugging is enabled for this batch build. For more information,
        /// see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/session-manager.html">Viewing
        /// a running build in Session Manager</a>. Batch session debugging is not supported for
        /// matrix batch builds.
        /// </para>
        /// </summary>
        public bool? DebugSessionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DebugSessionEnabled property is set.
        /// </summary>
        internal bool IsSetDebugSessionEnabled() => this.DebugSessionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionKeyOverride. 
        /// <para>
        /// The Key Management Service customer master key (CMK) that overrides the one specified
        /// in the batch build project. The CMK key encrypts the build output artifacts.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use a cross-account KMS key to encrypt the build output artifacts if your
        /// service role has permission to that key. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can specify either the Amazon Resource Name (ARN) of the CMK or, if available,
        /// the CMK's alias (using the format <c>alias/&lt;alias-name&gt;</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string EncryptionKeyOverride { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyOverride property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyOverride() => this.EncryptionKeyOverride != null;

        /// <summary>
        /// Gets and sets the property EnvironmentTypeOverride. 
        /// <para>
        /// A container type for this batch build that overrides the one specified in the batch
        /// build project.
        /// </para>
        /// </summary>
        public EnvironmentType EnvironmentTypeOverride { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentTypeOverride property is set.
        /// </summary>
        internal bool IsSetEnvironmentTypeOverride() => this.EnvironmentTypeOverride != null;

        /// <summary>
        /// Gets and sets the property EnvironmentVariablesOverride. 
        /// <para>
        /// An array of <c>EnvironmentVariable</c> objects that override, or add to, the environment
        /// variables defined in the batch build project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentVariable> EnvironmentVariablesOverride { get; set; } = AWSConfigs.InitializeCollections ? new List<EnvironmentVariable>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentVariablesOverride property is set.
        /// </summary>
        internal bool IsSetEnvironmentVariablesOverride() => this.EnvironmentVariablesOverride != null && (this.EnvironmentVariablesOverride.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GitCloneDepthOverride. 
        /// <para>
        /// The user-defined depth of history, with a minimum value of 0, that overrides, for
        /// this batch build only, any previous depth of history defined in the batch build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? GitCloneDepthOverride { get; set; }

        /// <summary>
        /// Checks to see if the GitCloneDepthOverride property is set.
        /// </summary>
        internal bool IsSetGitCloneDepthOverride() => this.GitCloneDepthOverride.HasValue;

        /// <summary>
        /// Gets and sets the property GitSubmodulesConfigOverride. 
        /// <para>
        /// A <c>GitSubmodulesConfig</c> object that overrides the Git submodules configuration
        /// for this batch build.
        /// </para>
        /// </summary>
        public GitSubmodulesConfig GitSubmodulesConfigOverride { get; set; }

        /// <summary>
        /// Checks to see if the GitSubmodulesConfigOverride property is set.
        /// </summary>
        internal bool IsSetGitSubmodulesConfigOverride() => this.GitSubmodulesConfigOverride != null;

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case sensitive identifier you provide to ensure the idempotency of the <c>StartBuildBatch</c>
        /// request. The token is included in the <c>StartBuildBatch</c> request and is valid
        /// for five minutes. If you repeat the <c>StartBuildBatch</c> request with the same token,
        /// but change a parameter, CodeBuild returns a parameter mismatch error.
        /// </para>
        /// </summary>
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;

        /// <summary>
        /// Gets and sets the property ImageOverride. 
        /// <para>
        /// The name of an image for this batch build that overrides the one specified in the
        /// batch build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ImageOverride { get; set; }

        /// <summary>
        /// Checks to see if the ImageOverride property is set.
        /// </summary>
        internal bool IsSetImageOverride() => this.ImageOverride != null;

        /// <summary>
        /// Gets and sets the property ImagePullCredentialsTypeOverride. 
        /// <para>
        /// The type of credentials CodeBuild uses to pull images in your batch build. There are
        /// two valid values: 
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
        public ImagePullCredentialsType ImagePullCredentialsTypeOverride { get; set; }

        /// <summary>
        /// Checks to see if the ImagePullCredentialsTypeOverride property is set.
        /// </summary>
        internal bool IsSetImagePullCredentialsTypeOverride() => this.ImagePullCredentialsTypeOverride != null;

        /// <summary>
        /// Gets and sets the property InsecureSslOverride. 
        /// <para>
        /// Enable this flag to override the insecure SSL setting that is specified in the batch
        /// build project. The insecure SSL setting determines whether to ignore SSL warnings
        /// while connecting to the project source code. This override applies only if the build's
        /// source is GitHub Enterprise.
        /// </para>
        /// </summary>
        public bool? InsecureSslOverride { get; set; }

        /// <summary>
        /// Checks to see if the InsecureSslOverride property is set.
        /// </summary>
        internal bool IsSetInsecureSslOverride() => this.InsecureSslOverride.HasValue;

        /// <summary>
        /// Gets and sets the property LogsConfigOverride. 
        /// <para>
        /// A <c>LogsConfig</c> object that override the log settings defined in the batch build
        /// project.
        /// </para>
        /// </summary>
        public LogsConfig LogsConfigOverride { get; set; }

        /// <summary>
        /// Checks to see if the LogsConfigOverride property is set.
        /// </summary>
        internal bool IsSetLogsConfigOverride() => this.LogsConfigOverride != null;

        /// <summary>
        /// Gets and sets the property PrivilegedModeOverride. 
        /// <para>
        /// Enable this flag to override privileged mode in the batch build project.
        /// </para>
        /// </summary>
        public bool? PrivilegedModeOverride { get; set; }

        /// <summary>
        /// Checks to see if the PrivilegedModeOverride property is set.
        /// </summary>
        internal bool IsSetPrivilegedModeOverride() => this.PrivilegedModeOverride.HasValue;

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;

        /// <summary>
        /// Gets and sets the property QueuedTimeoutInMinutesOverride. 
        /// <para>
        /// The number of minutes a batch build is allowed to be queued before it times out.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 480)]
        public int? QueuedTimeoutInMinutesOverride { get; set; }

        /// <summary>
        /// Checks to see if the QueuedTimeoutInMinutesOverride property is set.
        /// </summary>
        internal bool IsSetQueuedTimeoutInMinutesOverride() => this.QueuedTimeoutInMinutesOverride.HasValue;

        /// <summary>
        /// Gets and sets the property RegistryCredentialOverride. 
        /// <para>
        /// A <c>RegistryCredential</c> object that overrides credentials for access to a private
        /// registry.
        /// </para>
        /// </summary>
        public RegistryCredential RegistryCredentialOverride { get; set; }

        /// <summary>
        /// Checks to see if the RegistryCredentialOverride property is set.
        /// </summary>
        internal bool IsSetRegistryCredentialOverride() => this.RegistryCredentialOverride != null;

        /// <summary>
        /// Gets and sets the property ReportBuildBatchStatusOverride. 
        /// <para>
        /// Set to <c>true</c> to report to your source provider the status of a batch build's
        /// start and completion. If you use this option with a source provider other than GitHub,
        /// GitHub Enterprise, or Bitbucket, an <c>invalidInputException</c> is thrown. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The status of a build triggered by a webhook is always reported to your source provider.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        public bool? ReportBuildBatchStatusOverride { get; set; }

        /// <summary>
        /// Checks to see if the ReportBuildBatchStatusOverride property is set.
        /// </summary>
        internal bool IsSetReportBuildBatchStatusOverride() => this.ReportBuildBatchStatusOverride.HasValue;

        /// <summary>
        /// Gets and sets the property SecondaryArtifactsOverride. 
        /// <para>
        /// An array of <c>ProjectArtifacts</c> objects that override the secondary artifacts
        /// defined in the batch build project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public List<ProjectArtifacts> SecondaryArtifactsOverride { get; set; } = AWSConfigs.InitializeCollections ? new List<ProjectArtifacts>() : null;

        /// <summary>
        /// Checks to see if the SecondaryArtifactsOverride property is set.
        /// </summary>
        internal bool IsSetSecondaryArtifactsOverride() => this.SecondaryArtifactsOverride != null && (this.SecondaryArtifactsOverride.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecondarySourcesOverride. 
        /// <para>
        /// An array of <c>ProjectSource</c> objects that override the secondary sources defined
        /// in the batch build project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public List<ProjectSource> SecondarySourcesOverride { get; set; } = AWSConfigs.InitializeCollections ? new List<ProjectSource>() : null;

        /// <summary>
        /// Checks to see if the SecondarySourcesOverride property is set.
        /// </summary>
        internal bool IsSetSecondarySourcesOverride() => this.SecondarySourcesOverride != null && (this.SecondarySourcesOverride.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecondarySourcesVersionOverride. 
        /// <para>
        /// An array of <c>ProjectSourceVersion</c> objects that override the secondary source
        /// versions in the batch build project.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public List<ProjectSourceVersion> SecondarySourcesVersionOverride { get; set; } = AWSConfigs.InitializeCollections ? new List<ProjectSourceVersion>() : null;

        /// <summary>
        /// Checks to see if the SecondarySourcesVersionOverride property is set.
        /// </summary>
        internal bool IsSetSecondarySourcesVersionOverride() => this.SecondarySourcesVersionOverride != null && (this.SecondarySourcesVersionOverride.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceRoleOverride. 
        /// <para>
        /// The name of a service role for this batch build that overrides the one specified in
        /// the batch build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ServiceRoleOverride { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRoleOverride property is set.
        /// </summary>
        internal bool IsSetServiceRoleOverride() => this.ServiceRoleOverride != null;

        /// <summary>
        /// Gets and sets the property SourceAuthOverride. 
        /// <para>
        /// A <c>SourceAuth</c> object that overrides the one defined in the batch build project.
        /// This override applies only if the build project's source is BitBucket or GitHub.
        /// </para>
        /// </summary>
        public SourceAuth SourceAuthOverride { get; set; }

        /// <summary>
        /// Checks to see if the SourceAuthOverride property is set.
        /// </summary>
        internal bool IsSetSourceAuthOverride() => this.SourceAuthOverride != null;

        /// <summary>
        /// Gets and sets the property SourceLocationOverride. 
        /// <para>
        /// A location that overrides, for this batch build, the source location defined in the
        /// batch build project.
        /// </para>
        /// </summary>
        public string SourceLocationOverride { get; set; }

        /// <summary>
        /// Checks to see if the SourceLocationOverride property is set.
        /// </summary>
        internal bool IsSetSourceLocationOverride() => this.SourceLocationOverride != null;

        /// <summary>
        /// Gets and sets the property SourceTypeOverride. 
        /// <para>
        /// The source input type that overrides the source input defined in the batch build project.
        /// </para>
        /// </summary>
        public SourceType SourceTypeOverride { get; set; }

        /// <summary>
        /// Checks to see if the SourceTypeOverride property is set.
        /// </summary>
        internal bool IsSetSourceTypeOverride() => this.SourceTypeOverride != null;

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// The version of the batch build input to be built, for this build only. If not specified,
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
        public string SourceVersion { get; set; }

        /// <summary>
        /// Checks to see if the SourceVersion property is set.
        /// </summary>
        internal bool IsSetSourceVersion() => this.SourceVersion != null;
    }
}
