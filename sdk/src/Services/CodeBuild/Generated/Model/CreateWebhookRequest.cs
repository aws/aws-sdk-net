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
    /// Container for the parameters to the CreateWebhook operation.
    /// For an existing AWS CodeBuild build project that has its source code stored in a GitHub
    /// repository, enables AWS CodeBuild to begin automatically rebuilding the source code
    /// every time a code change is pushed to the repository.
    /// 
    ///  <important> 
    /// <para>
    /// If you enable webhooks for an AWS CodeBuild project, and the project is used as a
    /// build step in AWS CodePipeline, then two identical builds will be created for each
    /// commit. One build is triggered through webhooks, and one through AWS CodePipeline.
    /// Because billing is on a per-build basis, you will be billed for both builds. Therefore,
    /// if you are using AWS CodePipeline, we recommend that you disable webhooks in CodeBuild.
    /// In the AWS CodeBuild console, clear the Webhook box. For more information, see step
    /// 9 in <a href="http://docs.aws.amazon.com/codebuild/latest/userguide/change-project.html#change-project-console">Change
    /// a Build Project’s Settings</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateWebhookRequest : AmazonCodeBuildRequest
    {
        private string _projectName;

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the build project.
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

    }
}