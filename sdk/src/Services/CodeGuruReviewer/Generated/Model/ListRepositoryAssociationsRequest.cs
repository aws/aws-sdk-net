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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Container for the parameters to the ListRepositoryAssociations operation.
    /// Returns a list of <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociationSummary.html">RepositoryAssociationSummary</a>
    /// objects that contain summary information about a repository association. You can filter
    /// the returned list by <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociationSummary.html#reviewer-Type-RepositoryAssociationSummary-ProviderType">ProviderType</a>,
    /// <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociationSummary.html#reviewer-Type-RepositoryAssociationSummary-Name">Name</a>,
    /// <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociationSummary.html#reviewer-Type-RepositoryAssociationSummary-State">State</a>,
    /// and <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-api/API_RepositoryAssociationSummary.html#reviewer-Type-RepositoryAssociationSummary-Owner">Owner</a>.
    /// </summary>
    public partial class ListRepositoryAssociationsRequest : AmazonCodeGuruReviewerRequest
    {
        private int? _maxResults;
        private List<string> _names = new List<string>();
        private string _nextToken;
        private List<string> _owners = new List<string>();
        private List<string> _providerTypes = new List<string>();
        private List<string> _states = new List<string>();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of repository association results returned by <code>ListRepositoryAssociations</code>
        /// in paginated output. When this parameter is used, <code>ListRepositoryAssociations</code>
        /// only returns <code>maxResults</code> results in a single page with a <code>nextToken</code>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <code>ListRepositoryAssociations</code> request with the returned <code>nextToken</code>
        /// value. This value can be between 1 and 100. If this parameter is not used, <code>ListRepositoryAssociations</code>
        /// returns up to 100 results and a <code>nextToken</code> value if applicable. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// List of repository names to use as a filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && this._names.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value returned from a previous paginated <code>ListRepositoryAssociations</code>
        /// request where <code>maxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>nextToken</code> value. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Treat this token as an opaque identifier that is only used to retrieve the next items
        /// in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Owners. 
        /// <para>
        /// List of owners to use as a filter. For Amazon Web Services CodeCommit, it is the name
        /// of the CodeCommit account that was used to associate the repository. For other repository
        /// source providers, such as Bitbucket and GitHub Enterprise Server, this is name of
        /// the account that was used to associate the repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> Owners
        {
            get { return this._owners; }
            set { this._owners = value; }
        }

        // Check to see if Owners property is set
        internal bool IsSetOwners()
        {
            return this._owners != null && this._owners.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProviderTypes. 
        /// <para>
        /// List of provider types to use as a filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> ProviderTypes
        {
            get { return this._providerTypes; }
            set { this._providerTypes = value; }
        }

        // Check to see if ProviderTypes property is set
        internal bool IsSetProviderTypes()
        {
            return this._providerTypes != null && this._providerTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property States. 
        /// <para>
        /// List of repository association states to use as a filter.
        /// </para>
        ///  
        /// <para>
        /// The valid repository association states are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Associated</b>: The repository association is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Associating</b>: CodeGuru Reviewer is:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Setting up pull request notifications. This is required for pull requests to trigger
        /// a CodeGuru Reviewer review.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your repository <code>ProviderType</code> is <code>GitHub</code>, <code>GitHub
        /// Enterprise Server</code>, or <code>Bitbucket</code>, CodeGuru Reviewer creates webhooks
        /// in your repository to trigger CodeGuru Reviewer reviews. If you delete these webhooks,
        /// reviews of code in your repository cannot be triggered.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Setting up source code access. This is required for CodeGuru Reviewer to securely
        /// clone code in your repository.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Failed</b>: The repository failed to associate or disassociate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Disassociating</b>: CodeGuru Reviewer is removing the repository's pull request
        /// notifications and source code access.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Disassociated</b>: CodeGuru Reviewer successfully disassociated the repository.
        /// You can create a new association with this repository if you want to review source
        /// code in it later. You can control access to code reviews created in anassociated repository
        /// with tags after it has been disassociated. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/reviewer-ug/auth-and-access-control-using-tags.html">Using
        /// tags to control access to associated repositories</a> in the <i>Amazon CodeGuru Reviewer
        /// User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> States
        {
            get { return this._states; }
            set { this._states = value; }
        }

        // Check to see if States property is set
        internal bool IsSetStates()
        {
            return this._states != null && this._states.Count > 0; 
        }

    }
}