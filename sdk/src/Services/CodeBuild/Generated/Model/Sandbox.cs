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
    /// Contains sandbox information.
    /// </summary>
    public partial class Sandbox
    {
        private string _arn;
        private SandboxSession _currentSession;
        private string _encryptionKey;
        private DateTime? _endTime;
        private ProjectEnvironment _environment;
        private List<ProjectFileSystemLocation> _fileSystemLocations = AWSConfigs.InitializeCollections ? new List<ProjectFileSystemLocation>() : null;
        private string _id;
        private LogsConfig _logConfig;
        private string _projectName;
        private int? _queuedTimeoutInMinutes;
        private DateTime? _requestTime;
        private List<ProjectSource> _secondarySources = AWSConfigs.InitializeCollections ? new List<ProjectSource>() : null;
        private List<ProjectSourceVersion> _secondarySourceVersions = AWSConfigs.InitializeCollections ? new List<ProjectSourceVersion>() : null;
        private string _serviceRole;
        private ProjectSource _source;
        private string _sourceVersion;
        private DateTime? _startTime;
        private string _status;
        private int? _timeoutInMinutes;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the sandbox.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentSession. 
        /// <para>
        /// The current session for the sandbox.
        /// </para>
        /// </summary>
        public SandboxSession CurrentSession
        {
            get { return this._currentSession; }
            set { this._currentSession = value; }
        }

        // Check to see if CurrentSession property is set
        internal bool IsSetCurrentSession()
        {
            return this._currentSession != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The Key Management Service customer master key (CMK) to be used for encrypting the
        /// sandbox output artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// When the sandbox process ended, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Environment.
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
        /// Gets and sets the property FileSystemLocations. 
        /// <para>
        ///  An array of <c>ProjectFileSystemLocation</c> objects for a CodeBuild build project.
        /// A <c>ProjectFileSystemLocation</c> object specifies the <c>identifier</c>, <c>location</c>,
        /// <c>mountOptions</c>, <c>mountPoint</c>, and <c>type</c> of a file system created using
        /// Amazon Elastic File System. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProjectFileSystemLocation> FileSystemLocations
        {
            get { return this._fileSystemLocations; }
            set { this._fileSystemLocations = value; }
        }

        // Check to see if FileSystemLocations property is set
        internal bool IsSetFileSystemLocations()
        {
            return this._fileSystemLocations != null && (this._fileSystemLocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the sandbox.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfig.
        /// </summary>
        public LogsConfig LogConfig
        {
            get { return this._logConfig; }
            set { this._logConfig = value; }
        }

        // Check to see if LogConfig property is set
        internal bool IsSetLogConfig()
        {
            return this._logConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The CodeBuild project name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property QueuedTimeoutInMinutes. 
        /// <para>
        /// The number of minutes a sandbox is allowed to be queued before it times out. 
        /// </para>
        /// </summary>
        public int? QueuedTimeoutInMinutes
        {
            get { return this._queuedTimeoutInMinutes; }
            set { this._queuedTimeoutInMinutes = value; }
        }

        // Check to see if QueuedTimeoutInMinutes property is set
        internal bool IsSetQueuedTimeoutInMinutes()
        {
            return this._queuedTimeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestTime. 
        /// <para>
        /// When the sandbox process was initially requested, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? RequestTime
        {
            get { return this._requestTime; }
            set { this._requestTime = value; }
        }

        // Check to see if RequestTime property is set
        internal bool IsSetRequestTime()
        {
            return this._requestTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecondarySources. 
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
        public List<ProjectSource> SecondarySources
        {
            get { return this._secondarySources; }
            set { this._secondarySources = value; }
        }

        // Check to see if SecondarySources property is set
        internal bool IsSetSecondarySources()
        {
            return this._secondarySources != null && (this._secondarySources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecondarySourceVersions. 
        /// <para>
        ///  An array of <c>ProjectSourceVersion</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<ProjectSourceVersion> SecondarySourceVersions
        {
            get { return this._secondarySourceVersions; }
            set { this._secondarySourceVersions = value; }
        }

        // Check to see if SecondarySourceVersions property is set
        internal bool IsSetSecondarySourceVersions()
        {
            return this._secondarySourceVersions != null && (this._secondarySourceVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The name of a service role used for this sandbox.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// Any version identifier for the version of the sandbox to be built.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// When the sandbox process started, expressed in Unix time format.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the sandbox.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// How long, in minutes, from 5 to 2160 (36 hours), for CodeBuild to wait before timing
        /// out this sandbox if it does not get marked as completed.
        /// </para>
        /// </summary>
        public int? TimeoutInMinutes
        {
            get { return this._timeoutInMinutes; }
            set { this._timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this._timeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig.
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