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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateJobFromSourceControl operation.
    /// Synchronizes a job from the source control repository. This operation takes the job
    /// artifacts that are located in the remote repository and updates the Glue internal
    /// stores with these artifacts.
    /// 
    ///  
    /// <para>
    /// This API supports optional parameters which take in the repository information.
    /// </para>
    /// </summary>
    public partial class UpdateJobFromSourceControlRequest : AmazonGlueRequest
    {
        private SourceControlAuthStrategy _authStrategy;
        private string _authToken;
        private string _branchName;
        private string _commitId;
        private string _folder;
        private string _jobName;
        private SourceControlProvider _provider;
        private string _repositoryName;
        private string _repositoryOwner;

        /// <summary>
        /// Gets and sets the property AuthStrategy. 
        /// <para>
        /// The type of authentication, which can be an authentication token stored in Amazon
        /// Web Services Secrets Manager, or a personal access token.
        /// </para>
        /// </summary>
        public SourceControlAuthStrategy AuthStrategy
        {
            get { return this._authStrategy; }
            set { this._authStrategy = value; }
        }

        // Check to see if AuthStrategy property is set
        internal bool IsSetAuthStrategy()
        {
            return this._authStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        /// The value of the authorization token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AuthToken
        {
            get { return this._authToken; }
            set { this._authToken = value; }
        }

        // Check to see if AuthToken property is set
        internal bool IsSetAuthToken()
        {
            return this._authToken != null;
        }

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// An optional branch in the remote repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string BranchName
        {
            get { return this._branchName; }
            set { this._branchName = value; }
        }

        // Check to see if BranchName property is set
        internal bool IsSetBranchName()
        {
            return this._branchName != null;
        }

        /// <summary>
        /// Gets and sets the property CommitId. 
        /// <para>
        /// A commit ID for a commit in the remote repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string CommitId
        {
            get { return this._commitId; }
            set { this._commitId = value; }
        }

        // Check to see if CommitId property is set
        internal bool IsSetCommitId()
        {
            return this._commitId != null;
        }

        /// <summary>
        /// Gets and sets the property Folder. 
        /// <para>
        /// An optional folder in the remote repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Folder
        {
            get { return this._folder; }
            set { this._folder = value; }
        }

        // Check to see if Folder property is set
        internal bool IsSetFolder()
        {
            return this._folder != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the Glue job to be synchronized to or from the remote repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        ///  The provider for the remote repository. Possible values: GITHUB, AWS_CODE_COMMIT,
        /// GITLAB, BITBUCKET. 
        /// </para>
        /// </summary>
        public SourceControlProvider Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the remote repository that contains the job artifacts. For BitBucket providers,
        /// <c>RepositoryName</c> should include <c>WorkspaceName</c>. Use the format <c>&lt;WorkspaceName&gt;/&lt;RepositoryName&gt;</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryOwner. 
        /// <para>
        /// The owner of the remote repository that contains the job artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RepositoryOwner
        {
            get { return this._repositoryOwner; }
            set { this._repositoryOwner = value; }
        }

        // Check to see if RepositoryOwner property is set
        internal bool IsSetRepositoryOwner()
        {
            return this._repositoryOwner != null;
        }

    }
}