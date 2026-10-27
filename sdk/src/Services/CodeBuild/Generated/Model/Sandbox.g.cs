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
    /// Contains sandbox information.
    /// </summary>
    public partial class Sandbox
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the sandbox.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CurrentSession. 
        /// <para>
        /// The current session for the sandbox.
        /// </para>
        /// </summary>
        public SandboxSession CurrentSession { get; set; }

        /// <summary>
        /// Checks to see if the CurrentSession property is set.
        /// </summary>
        internal bool IsSetCurrentSession() => this.CurrentSession != null;

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The Key Management Service customer master key (CMK) to be used for encrypting the
        /// sandbox output artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// When the sandbox process ended, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Environment.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the sandbox.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LogConfig.
        /// </summary>
        public LogsConfig LogConfig { get; set; }

        /// <summary>
        /// Checks to see if the LogConfig property is set.
        /// </summary>
        internal bool IsSetLogConfig() => this.LogConfig != null;

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The CodeBuild project name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;

        /// <summary>
        /// Gets and sets the property QueuedTimeoutInMinutes. 
        /// <para>
        /// The number of minutes a sandbox is allowed to be queued before it times out. 
        /// </para>
        /// </summary>
        public int? QueuedTimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the QueuedTimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetQueuedTimeoutInMinutes() => this.QueuedTimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// When the sandbox process was initially requested, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? RequestTime { get; set; }

        /// <summary>
        /// Checks to see if the RequestTime property is set.
        /// </summary>
        internal bool IsSetRequestTime() => this.RequestTime.HasValue;

        /// <summary>
        /// Gets and sets the property SecondarySourceVersions. 
        /// <para>
        ///  An array of <c>ProjectSourceVersion</c> objects.
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
        /// The name of a service role used for this sandbox.
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
        /// </summary>
        public ProjectSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// Any version identifier for the version of the sandbox to be built.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string SourceVersion { get; set; }

        /// <summary>
        /// Checks to see if the SourceVersion property is set.
        /// </summary>
        internal bool IsSetSourceVersion() => this.SourceVersion != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the sandbox process started, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the sandbox.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// How long, in minutes, from 5 to 2160 (36 hours), for CodeBuild to wait before timing
        /// out this sandbox if it does not get marked as completed.
        /// </para>
        /// </summary>
        public int? TimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetTimeoutInMinutes() => this.TimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property VpcConfig.
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
