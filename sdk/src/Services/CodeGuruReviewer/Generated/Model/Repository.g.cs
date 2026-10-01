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

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Information about an associated Amazon Web Services CodeCommit repository or an associated
    /// repository that is managed by Amazon Web Services CodeStar Connections (for example,
    /// Bitbucket). This <c>Repository</c> object is not used if your source code is in an
    /// associated GitHub repository.
    /// </summary>
    public partial class Repository
    {
        /// <summary>
        /// Gets and sets the property Bitbucket. 
        /// <para>
        ///  Information about a Bitbucket repository. 
        /// </para>
        /// </summary>
        public ThirdPartySourceRepository Bitbucket { get; set; }

        /// <summary>
        /// Checks to see if the Bitbucket property is set.
        /// </summary>
        internal bool IsSetBitbucket() => this.Bitbucket != null;

        /// <summary>
        /// Gets and sets the property CodeCommit. 
        /// <para>
        /// Information about an Amazon Web Services CodeCommit repository.
        /// </para>
        /// </summary>
        public CodeCommitRepository CodeCommit { get; set; }

        /// <summary>
        /// Checks to see if the CodeCommit property is set.
        /// </summary>
        internal bool IsSetCodeCommit() => this.CodeCommit != null;

        /// <summary>
        /// Gets and sets the property GitHubEnterpriseServer. 
        /// <para>
        /// Information about a GitHub Enterprise Server repository.
        /// </para>
        /// </summary>
        public ThirdPartySourceRepository GitHubEnterpriseServer { get; set; }

        /// <summary>
        /// Checks to see if the GitHubEnterpriseServer property is set.
        /// </summary>
        internal bool IsSetGitHubEnterpriseServer() => this.GitHubEnterpriseServer != null;

        /// <summary>
        /// Gets and sets the property S3Bucket.
        /// </summary>
        public S3Repository S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;
    }
}
