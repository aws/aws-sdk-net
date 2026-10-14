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
    /// Container for the parameters to the UpdateProject operation. Changes the settings
    /// of a build project.
    /// </summary>
    public partial class UpdateProjectRequest : AmazonCodeBuildRequest
    {
        /// <summary>
        /// Gets and sets the property Artifacts. 
        /// <para>
        /// Information to be changed about the build output artifacts for the build project.
        /// </para>
        /// </summary>
        public ProjectArtifacts Artifacts { get; set; }

        /// <summary>
        /// Checks to see if the Artifacts property is set.
        /// </summary>
        internal bool IsSetArtifacts() => this.Artifacts != null;

        /// <summary>
        /// Gets and sets the property AutoRetryLimit. 
        /// <para>
        /// The maximum number of additional automatic retries after a failed build. For example,
        /// if the auto-retry limit is set to 2, CodeBuild will call the <c>RetryBuild</c> API
        /// to automatically retry your build for up to 2 additional times.
        /// </para>
        /// </summary>
        public int? AutoRetryLimit { get; set; }

        /// <summary>
        /// Checks to see if the AutoRetryLimit property is set.
        /// </summary>
        internal bool IsSetAutoRetryLimit() => this.AutoRetryLimit.HasValue;

        /// <summary>
        /// Gets and sets the property BadgeEnabled. 
        /// <para>
        /// Set this to true to generate a publicly accessible URL for your project's build badge.
        /// </para>
        /// </summary>
        public bool? BadgeEnabled { get; set; }

        /// <summary>
        /// Checks to see if the BadgeEnabled property is set.
        /// </summary>
        internal bool IsSetBadgeEnabled() => this.BadgeEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property BuildBatchConfig.
        /// </summary>
        public ProjectBuildBatchConfig BuildBatchConfig { get; set; }

        /// <summary>
        /// Checks to see if the BuildBatchConfig property is set.
        /// </summary>
        internal bool IsSetBuildBatchConfig() => this.BuildBatchConfig != null;

        /// <summary>
        /// Gets and sets the property Cache. 
        /// <para>
        /// Stores recently used information so that it can be quickly accessed at a later time.
        /// </para>
        /// </summary>
        public ProjectCache Cache { get; set; }

        /// <summary>
        /// Checks to see if the Cache property is set.
        /// </summary>
        internal bool IsSetCache() => this.Cache != null;

        /// <summary>
        /// Gets and sets the property ConcurrentBuildLimit. 
        /// <para>
        /// The maximum number of concurrent builds that are allowed for this project.
        /// </para>
        ///  
        /// <para>
        /// New builds are only started if the current number of builds is less than or equal
        /// to this limit. If the current build count meets this limit, new builds are throttled
        /// and are not run.
        /// </para>
        ///  
        /// <para>
        /// To remove this limit, set this value to -1.
        /// </para>
        /// </summary>
        public int? ConcurrentBuildLimit { get; set; }

        /// <summary>
        /// Checks to see if the ConcurrentBuildLimit property is set.
        /// </summary>
        internal bool IsSetConcurrentBuildLimit() => this.ConcurrentBuildLimit.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new or replacement description of the build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The Key Management Service customer master key (CMK) to be used for encrypting the
        /// build output artifacts.
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
        [AWSProperty(Min = 1)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// Information to be changed about the build environment for the build project.
        /// </para>
        /// </summary>
        public ProjectEnvironment Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property FileSystemLocations. 
        /// <para>
        ///  An array of <c>ProjectFileSystemLocation</c> objects for a CodeBuild build project.
        /// A <c>ProjectFileSystemLocation</c> object specifies the <c>identifier</c>, <c>location</c>,
        /// <c>mountOptions</c>, <c>mountPoint</c>, and <c>type</c> of a file system created using
        /// Amazon Elastic File System. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProjectFileSystemLocation> FileSystemLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<ProjectFileSystemLocation>() : null;

        /// <summary>
        /// Checks to see if the FileSystemLocations property is set.
        /// </summary>
        internal bool IsSetFileSystemLocations() => this.FileSystemLocations != null && (this.FileSystemLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogsConfig. 
        /// <para>
        ///  Information about logs for the build project. A project can create logs in CloudWatch
        /// Logs, logs in an S3 bucket, or both. 
        /// </para>
        /// </summary>
        public LogsConfig LogsConfig { get; set; }

        /// <summary>
        /// Checks to see if the LogsConfig property is set.
        /// </summary>
        internal bool IsSetLogsConfig() => this.LogsConfig != null;

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
        [AWSProperty(Required = true, Min = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property QueuedTimeoutInMinutes. 
        /// <para>
        ///  The number of minutes a build is allowed to be queued before it times out. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 480)]
        public int? QueuedTimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the QueuedTimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetQueuedTimeoutInMinutes() => this.QueuedTimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property SecondaryArtifacts. 
        /// <para>
        ///  An array of <c>ProjectArtifact</c> objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public List<ProjectArtifacts> SecondaryArtifacts { get; set; } = AWSConfigs.InitializeCollections ? new List<ProjectArtifacts>() : null;

        /// <summary>
        /// Checks to see if the SecondaryArtifacts property is set.
        /// </summary>
        internal bool IsSetSecondaryArtifacts() => this.SecondaryArtifacts != null && (this.SecondaryArtifacts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecondarySourceVersions. 
        /// <para>
        ///  An array of <c>ProjectSourceVersion</c> objects. If <c>secondarySourceVersions</c>
        /// is specified at the build level, then they take over these <c>secondarySourceVersions</c>
        /// (at the project level). 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public List<ProjectSourceVersion> SecondarySourceVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<ProjectSourceVersion>() : null;

        /// <summary>
        /// Checks to see if the SecondarySourceVersions property is set.
        /// </summary>
        internal bool IsSetSecondarySourceVersions() => this.SecondarySourceVersions != null && (this.SecondarySourceVersions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecondarySources. 
        /// <para>
        ///  An array of <c>ProjectSource</c> objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public List<ProjectSource> SecondarySources { get; set; } = AWSConfigs.InitializeCollections ? new List<ProjectSource>() : null;

        /// <summary>
        /// Checks to see if the SecondarySources property is set.
        /// </summary>
        internal bool IsSetSecondarySources() => this.SecondarySources != null && (this.SecondarySources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The replacement ARN of the IAM role that enables CodeBuild to interact with dependent
        /// Amazon Web Services services on behalf of the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Information to be changed about the build input source code for the build project.
        /// </para>
        /// </summary>
        public ProjectSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        ///  A version of the build input to be built for this project. If not specified, the
        /// latest version is used. If specified, it must be one of: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For CodeCommit: the commit ID, branch, or Git tag to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For GitHub: the commit ID, pull request ID, branch name, or tag name that corresponds
        /// to the version of the source code you want to build. If a pull request ID is specified,
        /// it must use the format <c>pr/pull-request-ID</c> (for example <c>pr/25</c>). If a
        /// branch name is specified, the branch's HEAD commit ID is used. If not specified, the
        /// default branch's HEAD commit ID is used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For GitLab: the commit ID, branch, or Git tag to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Bitbucket: the commit ID, branch name, or tag name that corresponds to the version
        /// of the source code you want to build. If a branch name is specified, the branch's
        /// HEAD commit ID is used. If not specified, the default branch's HEAD commit ID is used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon S3: the version ID of the object that represents the build input ZIP file
        /// to use.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If <c>sourceVersion</c> is specified at the build level, then that version takes
        /// precedence over this <c>sourceVersion</c> (at the project level). 
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/sample-source-version.html">Source
        /// Version Sample with CodeBuild</a> in the <i>CodeBuild User Guide</i>. 
        /// </para>
        /// </summary>
        public string SourceVersion { get; set; }

        /// <summary>
        /// Checks to see if the SourceVersion property is set.
        /// </summary>
        internal bool IsSetSourceVersion() => this.SourceVersion != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An updated list of tag key and value pairs associated with this build project.
        /// </para>
        ///  
        /// <para>
        /// These tags are available for use by Amazon Web Services services that support CodeBuild
        /// build project tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// The replacement value in minutes, from 5 to 2160 (36 hours), for CodeBuild to wait
        /// before timing out any related build that did not get marked as completed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 2160)]
        public int? TimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetTimeoutInMinutes() => this.TimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// VpcConfig enables CodeBuild to access resources in an Amazon VPC.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
