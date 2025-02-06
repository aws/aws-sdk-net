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
    /// Information about the build input source code for the build project.
    /// </summary>
    public partial class ProjectSource
    {
        private SourceAuth _auth;
        private string _buildspec;
        private BuildStatusConfig _buildStatusConfig;
        private int? _gitCloneDepth;
        private GitSubmodulesConfig _gitSubmodulesConfig;
        private bool? _insecureSsl;
        private string _location;
        private bool? _reportBuildStatus;
        private string _sourceIdentifier;
        private SourceType _type;

        /// <summary>
        /// Gets and sets the property Auth. 
        /// <para>
        /// Information about the authorization settings for CodeBuild to access the source code
        /// to be built.
        /// </para>
        /// </summary>
        public SourceAuth Auth
        {
            get { return this._auth; }
            set { this._auth = value; }
        }

        // Check to see if Auth property is set
        internal bool IsSetAuth()
        {
            return this._auth != null;
        }

        /// <summary>
        /// Gets and sets the property Buildspec. 
        /// <para>
        /// The buildspec file declaration to use for the builds in this build project.
        /// </para>
        ///  
        /// <para>
        ///  If this value is set, it can be either an inline buildspec definition, the path to
        /// an alternate buildspec file relative to the value of the built-in <c>CODEBUILD_SRC_DIR</c>
        /// environment variable, or the path to an S3 bucket. The bucket must be in the same
        /// Amazon Web Services Region as the build project. Specify the buildspec file using
        /// its ARN (for example, <c>arn:aws:s3:::my-codebuild-sample2/buildspec.yml</c>). If
        /// this value is not provided or is set to an empty string, the source code must contain
        /// a buildspec file in its root directory. For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/build-spec-ref.html#build-spec-ref-name-storage">Buildspec
        /// File Name and Storage Location</a>. 
        /// </para>
        /// </summary>
        public string Buildspec
        {
            get { return this._buildspec; }
            set { this._buildspec = value; }
        }

        // Check to see if Buildspec property is set
        internal bool IsSetBuildspec()
        {
            return this._buildspec != null;
        }

        /// <summary>
        /// Gets and sets the property BuildStatusConfig. 
        /// <para>
        /// Contains information that defines how the build project reports the build status to
        /// the source provider. This option is only used when the source provider is <c>GITHUB</c>,
        /// <c>GITHUB_ENTERPRISE</c>, or <c>BITBUCKET</c>.
        /// </para>
        /// </summary>
        public BuildStatusConfig BuildStatusConfig
        {
            get { return this._buildStatusConfig; }
            set { this._buildStatusConfig = value; }
        }

        // Check to see if BuildStatusConfig property is set
        internal bool IsSetBuildStatusConfig()
        {
            return this._buildStatusConfig != null;
        }

        /// <summary>
        /// Gets and sets the property GitCloneDepth. 
        /// <para>
        /// Information about the Git clone depth for the build project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? GitCloneDepth
        {
            get { return this._gitCloneDepth; }
            set { this._gitCloneDepth = value; }
        }

        // Check to see if GitCloneDepth property is set
        internal bool IsSetGitCloneDepth()
        {
            return this._gitCloneDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GitSubmodulesConfig. 
        /// <para>
        ///  Information about the Git submodules configuration for the build project. 
        /// </para>
        /// </summary>
        public GitSubmodulesConfig GitSubmodulesConfig
        {
            get { return this._gitSubmodulesConfig; }
            set { this._gitSubmodulesConfig = value; }
        }

        // Check to see if GitSubmodulesConfig property is set
        internal bool IsSetGitSubmodulesConfig()
        {
            return this._gitSubmodulesConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InsecureSsl. 
        /// <para>
        /// Enable this flag to ignore SSL warnings while connecting to the project source code.
        /// </para>
        /// </summary>
        public bool? InsecureSsl
        {
            get { return this._insecureSsl; }
            set { this._insecureSsl = value; }
        }

        // Check to see if InsecureSsl property is set
        internal bool IsSetInsecureSsl()
        {
            return this._insecureSsl.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Information about the location of the source code to be built. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For source code settings that are specified in the source action of a pipeline in
        /// CodePipeline, <c>location</c> should not be specified. If it is specified, CodePipeline
        /// ignores it. This is because CodePipeline uses the settings in a pipeline's source
        /// action instead of this value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For source code in an CodeCommit repository, the HTTPS clone URL to the repository
        /// that contains the source code and the buildspec file (for example, <c>https://git-codecommit.&lt;region-ID&gt;.amazonaws.com/v1/repos/&lt;repo-name&gt;</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For source code in an Amazon S3 input bucket, one of the following. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The path to the ZIP file that contains the source code (for example, <c>&lt;bucket-name&gt;/&lt;path&gt;/&lt;object-name&gt;.zip</c>).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The path to the folder that contains the source code (for example, <c>&lt;bucket-name&gt;/&lt;path-to-source-code&gt;/&lt;folder&gt;/</c>).
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For source code in a GitHub repository, the HTTPS clone URL to the repository that
        /// contains the source and the buildspec file. You must connect your Amazon Web Services
        /// account to your GitHub account. Use the CodeBuild console to start creating a build
        /// project. When you use the console to connect (or reconnect) with GitHub, on the GitHub
        /// <b>Authorize application</b> page, for <b>Organization access</b>, choose <b>Request
        /// access</b> next to each repository you want to allow CodeBuild to have access to,
        /// and then choose <b>Authorize application</b>. (After you have connected to your GitHub
        /// account, you do not need to finish creating the build project. You can leave the CodeBuild
        /// console.) To instruct CodeBuild to use this connection, in the <c>source</c> object,
        /// set the <c>auth</c> object's <c>type</c> value to <c>OAUTH</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For source code in an GitLab or self-managed GitLab repository, the HTTPS clone URL
        /// to the repository that contains the source and the buildspec file. You must connect
        /// your Amazon Web Services account to your GitLab account. Use the CodeBuild console
        /// to start creating a build project. When you use the console to connect (or reconnect)
        /// with GitLab, on the Connections <b>Authorize application</b> page, choose <b>Authorize</b>.
        /// Then on the CodeConnections <b>Create GitLab connection</b> page, choose <b>Connect
        /// to GitLab</b>. (After you have connected to your GitLab account, you do not need to
        /// finish creating the build project. You can leave the CodeBuild console.) To instruct
        /// CodeBuild to override the default connection and use this connection instead, set
        /// the <c>auth</c> object's <c>type</c> value to <c>CODECONNECTIONS</c> in the <c>source</c>
        /// object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For source code in a Bitbucket repository, the HTTPS clone URL to the repository that
        /// contains the source and the buildspec file. You must connect your Amazon Web Services
        /// account to your Bitbucket account. Use the CodeBuild console to start creating a build
        /// project. When you use the console to connect (or reconnect) with Bitbucket, on the
        /// Bitbucket <b>Confirm access to your account</b> page, choose <b>Grant access</b>.
        /// (After you have connected to your Bitbucket account, you do not need to finish creating
        /// the build project. You can leave the CodeBuild console.) To instruct CodeBuild to
        /// use this connection, in the <c>source</c> object, set the <c>auth</c> object's <c>type</c>
        /// value to <c>OAUTH</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If you specify <c>CODEPIPELINE</c> for the <c>Type</c> property, don't specify this
        /// property. For all of the other types, you must specify <c>Location</c>. 
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property ReportBuildStatus. 
        /// <para>
        ///  Set to true to report the status of a build's start and finish to your source provider.
        /// This option is valid only when your source provider is GitHub, GitHub Enterprise,
        /// GitLab, GitLab Self Managed, GitLab, GitLab Self Managed, or Bitbucket. If this is
        /// set and you use a different source provider, an <c>invalidInputException</c> is thrown.
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
        ///  
        /// <para>
        /// The status of a build triggered by a webhook is always reported to your source provider.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If your project's builds are triggered by a webhook, you must push a new commit to
        /// the repo for a change to this property to take effect.
        /// </para>
        /// </summary>
        public bool? ReportBuildStatus
        {
            get { return this._reportBuildStatus; }
            set { this._reportBuildStatus = value; }
        }

        // Check to see if ReportBuildStatus property is set
        internal bool IsSetReportBuildStatus()
        {
            return this._reportBuildStatus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceIdentifier. 
        /// <para>
        /// An identifier for this project source. The identifier can only contain alphanumeric
        /// characters and underscores, and must be less than 128 characters in length. 
        /// </para>
        /// </summary>
        public string SourceIdentifier
        {
            get { return this._sourceIdentifier; }
            set { this._sourceIdentifier = value; }
        }

        // Check to see if SourceIdentifier property is set
        internal bool IsSetSourceIdentifier()
        {
            return this._sourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of repository that contains the source code to be built. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BITBUCKET</c>: The source code is in a Bitbucket repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CODECOMMIT</c>: The source code is in an CodeCommit repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CODEPIPELINE</c>: The source code settings are specified in the source action
        /// of a pipeline in CodePipeline.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GITHUB</c>: The source code is in a GitHub repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GITHUB_ENTERPRISE</c>: The source code is in a GitHub Enterprise Server repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GITLAB</c>: The source code is in a GitLab repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GITLAB_SELF_MANAGED</c>: The source code is in a self-managed GitLab repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_SOURCE</c>: The project does not have input source code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c>: The source code is in an Amazon S3 bucket.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}