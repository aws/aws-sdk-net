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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCodeRepository operation.
    /// Create a git repository as a resource in your Amazon SageMaker account. You can associate
    /// the repository with notebook instances so that you can use git source control for
    /// the notebooks you create. The git repository is a resource in your Amazon SageMaker
    /// account, so it can be associated with more than one notebook instance, and it persists
    /// independently from the lifecycle of any notebook instances it is associated with.
    /// 
    ///  
    /// <para>
    /// The repository can be hosted either in <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">AWS
    /// CodeCommit</a> or in any other git repository.
    /// </para>
    /// </summary>
    public partial class CreateCodeRepositoryRequest : AmazonSageMakerRequest
    {
        private string _codeRepositoryName;
        private GitConfig _gitConfig;

        /// <summary>
        /// Gets and sets the property CodeRepositoryName. 
        /// <para>
        /// The name of the git repository. The name must have 1 to 63 characters. Valid characters
        /// are a-z, A-Z, 0-9, and - (hyphen).
        /// </para>
        /// </summary>
        public string CodeRepositoryName
        {
            get { return this._codeRepositoryName; }
            set { this._codeRepositoryName = value; }
        }

        // Check to see if CodeRepositoryName property is set
        internal bool IsSetCodeRepositoryName()
        {
            return this._codeRepositoryName != null;
        }

        /// <summary>
        /// Gets and sets the property GitConfig. 
        /// <para>
        /// Specifies details about the repository, including the URL where the repository is
        /// located, the default branch, and credentials to use to access the repository.
        /// </para>
        /// </summary>
        public GitConfig GitConfig
        {
            get { return this._gitConfig; }
            set { this._gitConfig = value; }
        }

        // Check to see if GitConfig property is set
        internal bool IsSetGitConfig()
        {
            return this._gitConfig != null;
        }

    }
}