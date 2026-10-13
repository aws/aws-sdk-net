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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateJobFromSourceControl operation. Synchronizes
    /// a job from the source control repository. This operation takes the job artifacts that
    /// are located in the remote repository and updates the Glue internal stores with these
    /// artifacts. <para> This API supports optional parameters which take in the repository
    /// information. </para>
    /// </summary>
    public partial class UpdateJobFromSourceControlRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property AuthStrategy. 
        /// <para>
        /// The type of authentication, which can be an authentication token stored in Amazon
        /// Web Services Secrets Manager, or a personal access token.
        /// </para>
        /// </summary>
        public SourceControlAuthStrategy AuthStrategy { get; set; }

        /// <summary>
        /// Checks to see if the AuthStrategy property is set.
        /// </summary>
        internal bool IsSetAuthStrategy() => this.AuthStrategy != null;

        /// <summary>
        /// Gets and sets the property AuthToken. 
        /// <para>
        /// The value of the authorization token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AuthToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthToken property is set.
        /// </summary>
        internal bool IsSetAuthToken() => this.AuthToken != null;

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// An optional branch in the remote repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string BranchName { get; set; }

        /// <summary>
        /// Checks to see if the BranchName property is set.
        /// </summary>
        internal bool IsSetBranchName() => this.BranchName != null;

        /// <summary>
        /// Gets and sets the property CommitId. 
        /// <para>
        /// A commit ID for a commit in the remote repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string CommitId { get; set; }

        /// <summary>
        /// Checks to see if the CommitId property is set.
        /// </summary>
        internal bool IsSetCommitId() => this.CommitId != null;

        /// <summary>
        /// Gets and sets the property Folder. 
        /// <para>
        /// An optional folder in the remote repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Folder { get; set; }

        /// <summary>
        /// Checks to see if the Folder property is set.
        /// </summary>
        internal bool IsSetFolder() => this.Folder != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the Glue job to be synchronized to or from the remote repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        ///  The provider for the remote repository. Possible values: GITHUB, AWS_CODE_COMMIT,
        /// GITLAB, BITBUCKET. 
        /// </para>
        /// </summary>
        public SourceControlProvider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the remote repository that contains the job artifacts. For BitBucket providers,
        /// <c>RepositoryName</c> should include <c>WorkspaceName</c>. Use the format <c>&lt;WorkspaceName&gt;/&lt;RepositoryName&gt;</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property RepositoryOwner. 
        /// <para>
        /// The owner of the remote repository that contains the job artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RepositoryOwner { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryOwner property is set.
        /// </summary>
        internal bool IsSetRepositoryOwner() => this.RepositoryOwner != null;
    }
}
