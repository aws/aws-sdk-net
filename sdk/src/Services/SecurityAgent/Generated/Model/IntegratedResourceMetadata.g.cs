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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Contains metadata about an integrated resource. This is a union type that contains
    /// provider-specific metadata.
    /// </summary>
    public partial class IntegratedResourceMetadata
    {
        /// <summary>
        /// Gets and sets the property BitbucketRepository.
        /// </summary>
        public BitbucketRepositoryMetadata BitbucketRepository { get; set; }

        /// <summary>
        /// Checks to see if the BitbucketRepository property is set.
        /// </summary>
        internal bool IsSetBitbucketRepository() => this.BitbucketRepository != null;

        /// <summary>
        /// Gets and sets the property ConfluenceDocument.
        /// </summary>
        public ConfluenceDocumentMetadata ConfluenceDocument { get; set; }

        /// <summary>
        /// Checks to see if the ConfluenceDocument property is set.
        /// </summary>
        internal bool IsSetConfluenceDocument() => this.ConfluenceDocument != null;

        /// <summary>
        /// Gets and sets the property GithubRepository. 
        /// <para>
        /// The GitHub repository metadata.
        /// </para>
        /// </summary>
        public GitHubRepositoryMetadata GithubRepository { get; set; }

        /// <summary>
        /// Checks to see if the GithubRepository property is set.
        /// </summary>
        internal bool IsSetGithubRepository() => this.GithubRepository != null;

        /// <summary>
        /// Gets and sets the property GitlabRepository.
        /// </summary>
        public GitLabRepositoryMetadata GitlabRepository { get; set; }

        /// <summary>
        /// Checks to see if the GitlabRepository property is set.
        /// </summary>
        internal bool IsSetGitlabRepository() => this.GitlabRepository != null;
    }
}
