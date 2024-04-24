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
    /// Container for the parameters to the UpdateProjectVisibility operation.
    /// Changes the public visibility for a project. The project's build results, logs, and
    /// artifacts are available to the general public. For more information, see <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/public-builds.html">Public
    /// build projects</a> in the <i>CodeBuild User Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// The following should be kept in mind when making your projects public:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// All of a project's build results, logs, and artifacts, including builds that were
    /// run when the project was private, are available to the general public.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// All build logs and artifacts are available to the public. Environment variables, source
    /// code, and other sensitive information may have been output to the build logs and artifacts.
    /// You must be careful about what information is output to the build logs. Some best
    /// practice are:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Do not store sensitive values in environment variables. We recommend that you use
    /// an Amazon EC2 Systems Manager Parameter Store or Secrets Manager to store sensitive
    /// values.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Follow <a href="https://docs.aws.amazon.com/codebuild/latest/userguide/webhooks.html#webhook-best-practices">Best
    /// practices for using webhooks</a> in the <i>CodeBuild User Guide</i> to limit which
    /// entities can trigger a build, and do not store the buildspec in the project itself,
    /// to ensure that your webhooks are as secure as possible.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// A malicious user can use public builds to distribute malicious artifacts. We recommend
    /// that you review all pull requests to verify that the pull request is a legitimate
    /// change. We also recommend that you validate any artifacts with their checksums to
    /// make sure that the correct artifacts are being downloaded.
    /// </para>
    ///  </li> </ul> </important>
    /// </summary>
    public partial class UpdateProjectVisibilityRequest : AmazonCodeBuildRequest
    {
        private string _projectArn;
        private ProjectVisibilityType _projectVisibility;
        private string _resourceAccessRole;

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the build project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectVisibility.
        /// </summary>
        [AWSProperty(Required=true)]
        public ProjectVisibilityType ProjectVisibility
        {
            get { return this._projectVisibility; }
            set { this._projectVisibility = value; }
        }

        // Check to see if ProjectVisibility property is set
        internal bool IsSetProjectVisibility()
        {
            return this._projectVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceAccessRole. 
        /// <para>
        /// The ARN of the IAM role that enables CodeBuild to access the CloudWatch Logs and Amazon
        /// S3 artifacts for the project's builds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ResourceAccessRole
        {
            get { return this._resourceAccessRole; }
            set { this._resourceAccessRole = value; }
        }

        // Check to see if ResourceAccessRole property is set
        internal bool IsSetResourceAccessRole()
        {
            return this._resourceAccessRole != null;
        }

    }
}