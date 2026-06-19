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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
        private BitbucketRepositoryMetadata _bitbucketRepository;
        private ConfluenceDocumentMetadata _confluenceDocument;
        private GitHubRepositoryMetadata _githubRepository;
        private GitLabRepositoryMetadata _gitlabRepository;

        /// <summary>
        /// Gets and sets the property BitbucketRepository.
        /// </summary>
        public BitbucketRepositoryMetadata BitbucketRepository
        {
            get { return this._bitbucketRepository; }
            set { this._bitbucketRepository = value; }
        }

        // Check to see if BitbucketRepository property is set
        internal bool IsSetBitbucketRepository()
        {
            return this._bitbucketRepository != null;
        }

        /// <summary>
        /// Gets and sets the property ConfluenceDocument.
        /// </summary>
        public ConfluenceDocumentMetadata ConfluenceDocument
        {
            get { return this._confluenceDocument; }
            set { this._confluenceDocument = value; }
        }

        // Check to see if ConfluenceDocument property is set
        internal bool IsSetConfluenceDocument()
        {
            return this._confluenceDocument != null;
        }

        /// <summary>
        /// Gets and sets the property GithubRepository. 
        /// <para>
        /// The GitHub repository metadata.
        /// </para>
        /// </summary>
        public GitHubRepositoryMetadata GithubRepository
        {
            get { return this._githubRepository; }
            set { this._githubRepository = value; }
        }

        // Check to see if GithubRepository property is set
        internal bool IsSetGithubRepository()
        {
            return this._githubRepository != null;
        }

        /// <summary>
        /// Gets and sets the property GitlabRepository.
        /// </summary>
        public GitLabRepositoryMetadata GitlabRepository
        {
            get { return this._gitlabRepository; }
            set { this._gitlabRepository = value; }
        }

        // Check to see if GitlabRepository property is set
        internal bool IsSetGitlabRepository()
        {
            return this._gitlabRepository != null;
        }

    }
}