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
        private List<EnvironmentVariable> _environmentVariablesOverride = new List<EnvironmentVariable>();
        private int? _gitCloneDepthOverride;
        private string _projectName;
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