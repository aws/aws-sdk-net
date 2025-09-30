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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CodeCommit.Model;
using Amazon.CodeCommit.Model.Internal.MarshallTransformations;
using Amazon.CodeCommit.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CodeCommit
{
    /// <summary>
    /// <para>Implementation for accessing CodeCommit</para>
    ///
    /// CodeCommit 
    /// <para>
    /// This is the <i>CodeCommit API Reference</i>. This reference provides descriptions
    /// of the operations and data types for CodeCommit API along with usage examples.
    /// </para>
    ///  
    /// <para>
    /// You can use the CodeCommit API to work with the following objects:
    /// </para>
    ///  
    /// <para>
    /// Repositories, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>BatchGetRepositories</a>, which returns information about one or more repositories
    /// associated with your Amazon Web Services account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateRepository</a>, which creates an CodeCommit repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteRepository</a>, which deletes an CodeCommit repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetRepository</a>, which returns information about a specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListRepositories</a>, which lists all CodeCommit repositories associated with
    /// your Amazon Web Services account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRepositoryDescription</a>, which sets or updates the description of the
    /// repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRepositoryEncryptionKey</a>, which updates the Key Management Service encryption
    /// key used to encrypt and decrypt a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRepositoryName</a>, which changes the name of the repository. If you change
    /// the name of a repository, no other users of that repository can access it until you
    /// send them the new HTTPS or SSH URL to use.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Branches, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateBranch</a>, which creates a branch in a specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteBranch</a>, which deletes the specified branch in a repository unless it
    /// is the default branch.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetBranch</a>, which returns information about a specified branch.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListBranches</a>, which lists all branches for a specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateDefaultBranch</a>, which changes the default branch for a repository.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Files, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteFile</a>, which deletes the content of a specified file from a specified
    /// branch.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetBlob</a>, which returns the base-64 encoded content of an individual Git blob
    /// object in a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetFile</a>, which returns the base-64 encoded content of a specified file.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetFolder</a>, which returns the contents of a specified folder or directory.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListFileCommitHistory</a>, which retrieves a list of commits and changes to a
    /// specified file. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutFile</a>, which adds or modifies a single file in a specified repository and
    /// branch.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Commits, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>BatchGetCommits</a>, which returns information about one or more commits in a
    /// repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateCommit</a>, which creates a commit for changes to a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetCommit</a>, which returns information about a commit, including commit messages
    /// and author and committer information.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetDifferences</a>, which returns information about the differences in a valid
    /// commit specifier (such as a branch, tag, HEAD, commit ID, or other fully qualified
    /// reference).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Merges, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>BatchDescribeMergeConflicts</a>, which returns information about conflicts in
    /// a merge between commits in a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateUnreferencedMergeCommit</a>, which creates an unreferenced commit between
    /// two branches or commits for the purpose of comparing them and identifying any potential
    /// conflicts.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeMergeConflicts</a>, which returns information about merge conflicts between
    /// the base, source, and destination versions of a file in a potential merge.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetMergeCommit</a>, which returns information about the merge between a source
    /// and destination commit. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetMergeConflicts</a>, which returns information about merge conflicts between
    /// the source and destination branch in a pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetMergeOptions</a>, which returns information about the available merge options
    /// between two branches or commit specifiers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>MergeBranchesByFastForward</a>, which merges two branches using the fast-forward
    /// merge option.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>MergeBranchesBySquash</a>, which merges two branches using the squash merge option.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>MergeBranchesByThreeWay</a>, which merges two branches using the three-way merge
    /// option.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Pull requests, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreatePullRequest</a>, which creates a pull request in a specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreatePullRequestApprovalRule</a>, which creates an approval rule for a specified
    /// pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeletePullRequestApprovalRule</a>, which deletes an approval rule for a specified
    /// pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribePullRequestEvents</a>, which returns information about one or more pull
    /// request events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>EvaluatePullRequestApprovalRules</a>, which evaluates whether a pull request has
    /// met all the conditions specified in its associated approval rules.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetCommentsForPullRequest</a>, which returns information about comments on a specified
    /// pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPullRequest</a>, which returns information about a specified pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPullRequestApprovalStates</a>, which returns information about the approval
    /// states for a specified pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPullRequestOverrideState</a>, which returns information about whether approval
    /// rules have been set aside (overriden) for a pull request, and if so, the Amazon Resource
    /// Name (ARN) of the user or identity that overrode the rules and their requirements
    /// for the pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListPullRequests</a>, which lists all pull requests for a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>MergePullRequestByFastForward</a>, which merges the source destination branch
    /// of a pull request into the specified destination branch for that pull request using
    /// the fast-forward merge option.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>MergePullRequestBySquash</a>, which merges the source destination branch of a
    /// pull request into the specified destination branch for that pull request using the
    /// squash merge option.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>MergePullRequestByThreeWay</a>, which merges the source destination branch of
    /// a pull request into the specified destination branch for that pull request using the
    /// three-way merge option.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>OverridePullRequestApprovalRules</a>, which sets aside all approval rule requirements
    /// for a pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PostCommentForPullRequest</a>, which posts a comment to a pull request at the
    /// specified line, file, or request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdatePullRequestApprovalRuleContent</a>, which updates the structure of an approval
    /// rule for a pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdatePullRequestApprovalState</a>, which updates the state of an approval on
    /// a pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdatePullRequestDescription</a>, which updates the description of a pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdatePullRequestStatus</a>, which updates the status of a pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdatePullRequestTitle</a>, which updates the title of a pull request.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Approval rule templates, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>AssociateApprovalRuleTemplateWithRepository</a>, which associates a template with
    /// a specified repository. After the template is associated with a repository, CodeCommit
    /// creates approval rules that match the template conditions on every pull request created
    /// in the specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>BatchAssociateApprovalRuleTemplateWithRepositories</a>, which associates a template
    /// with one or more specified repositories. After the template is associated with a repository,
    /// CodeCommit creates approval rules that match the template conditions on every pull
    /// request created in the specified repositories.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>BatchDisassociateApprovalRuleTemplateFromRepositories</a>, which removes the association
    /// between a template and specified repositories so that approval rules based on the
    /// template are not automatically created when pull requests are created in those repositories.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateApprovalRuleTemplate</a>, which creates a template for approval rules that
    /// can then be associated with one or more repositories in your Amazon Web Services account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteApprovalRuleTemplate</a>, which deletes the specified template. It does
    /// not remove approval rules on pull requests already created with the template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DisassociateApprovalRuleTemplateFromRepository</a>, which removes the association
    /// between a template and a repository so that approval rules based on the template are
    /// not automatically created when pull requests are created in the specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetApprovalRuleTemplate</a>, which returns information about an approval rule
    /// template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListApprovalRuleTemplates</a>, which lists all approval rule templates in the
    /// Amazon Web Services Region in your Amazon Web Services account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListAssociatedApprovalRuleTemplatesForRepository</a>, which lists all approval
    /// rule templates that are associated with a specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListRepositoriesForApprovalRuleTemplate</a>, which lists all repositories associated
    /// with the specified approval rule template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateApprovalRuleTemplateDescription</a>, which updates the description of an
    /// approval rule template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateApprovalRuleTemplateName</a>, which updates the name of an approval rule
    /// template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateApprovalRuleTemplateContent</a>, which updates the content of an approval
    /// rule template.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Comments in a repository, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteCommentContent</a>, which deletes the content of a comment on a commit in
    /// a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetComment</a>, which returns information about a comment on a commit.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetCommentReactions</a>, which returns information about emoji reactions to comments.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetCommentsForComparedCommit</a>, which returns information about comments on
    /// the comparison between two commit specifiers in a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PostCommentForComparedCommit</a>, which creates a comment on the comparison between
    /// two commit specifiers in a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PostCommentReply</a>, which creates a reply to a comment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutCommentReaction</a>, which creates or updates an emoji reaction to a comment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateComment</a>, which updates the content of a comment on a commit in a repository.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Tags used to tag resources in CodeCommit (not Git tags), by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a>, which gets information about Amazon Web Servicestags
    /// for a specified Amazon Resource Name (ARN) in CodeCommit.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TagResource</a>, which adds or updates tags for a resource in CodeCommit.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a>, which removes tags for a resource in CodeCommit.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Triggers, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GetRepositoryTriggers</a>, which returns information about triggers configured
    /// for a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutRepositoryTriggers</a>, which replaces all triggers for a repository and can
    /// be used to create or delete triggers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TestRepositoryTriggers</a>, which tests the functionality of a repository trigger
    /// by sending data to the trigger target.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about how to use CodeCommit, see the <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">CodeCommit
    /// User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCodeCommitClient : AmazonServiceClient, IAmazonCodeCommit
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodeCommitMetadata();
        private ICodeCommitPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICodeCommitPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CodeCommitPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonCodeCommitClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCodeCommitClient()
            : base(new AmazonCodeCommitConfig()) { }

        /// <summary>
        /// Constructs AmazonCodeCommitClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeCommitClient(RegionEndpoint region)
            : base(new AmazonCodeCommitConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodeCommitClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCodeCommitClient Configuration Object</param>
        public AmazonCodeCommitClient(AmazonCodeCommitConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonCodeCommitClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodeCommitClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodeCommitConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCommitClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeCommitClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodeCommitConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCommitClient with AWS Credentials and an
        /// AmazonCodeCommitClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodeCommitClient Configuration Object</param>
        public AmazonCodeCommitClient(AWSCredentials credentials, AmazonCodeCommitConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCommitClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodeCommitClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeCommitConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCommitClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeCommitClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeCommitConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCommitClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeCommitClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodeCommitClient Configuration Object</param>
        public AmazonCodeCommitClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodeCommitConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCommitClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodeCommitClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeCommitConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCommitClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeCommitClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeCommitConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeCommitClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeCommitClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodeCommitClient Configuration Object</param>
        public AmazonCodeCommitClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodeCommitConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCodeCommitEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCodeCommitAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AssociateApprovalRuleTemplateWithRepository


        /// <summary>
        /// Creates an association between an approval rule template and a specified repository.
        /// Then, the next time a pull request is created in the repository where the destination
        /// reference (if specified) matches the destination reference (branch) for the pull request,
        /// an approval rule that matches the template conditions is automatically created for
        /// that pull request. If no destination references are specified in the template, an
        /// approval rule that matches the template contents is created for all pull requests
        /// in that repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApprovalRuleTemplateWithRepository service method.</param>
        /// 
        /// <returns>The response from the AssociateApprovalRuleTemplateWithRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRuleTemplatesAssociatedWithRepositoryException">
        /// The maximum number of approval rule templates for a repository has been exceeded.
        /// You cannot associate more than 25 approval rule templates with a repository.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/AssociateApprovalRuleTemplateWithRepository">REST API Reference for AssociateApprovalRuleTemplateWithRepository Operation</seealso>
        public virtual AssociateApprovalRuleTemplateWithRepositoryResponse AssociateApprovalRuleTemplateWithRepository(AssociateApprovalRuleTemplateWithRepositoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateApprovalRuleTemplateWithRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApprovalRuleTemplateWithRepositoryResponseUnmarshaller.Instance;

            return Invoke<AssociateApprovalRuleTemplateWithRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Creates an association between an approval rule template and a specified repository.
        /// Then, the next time a pull request is created in the repository where the destination
        /// reference (if specified) matches the destination reference (branch) for the pull request,
        /// an approval rule that matches the template conditions is automatically created for
        /// that pull request. If no destination references are specified in the template, an
        /// approval rule that matches the template contents is created for all pull requests
        /// in that repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApprovalRuleTemplateWithRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateApprovalRuleTemplateWithRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRuleTemplatesAssociatedWithRepositoryException">
        /// The maximum number of approval rule templates for a repository has been exceeded.
        /// You cannot associate more than 25 approval rule templates with a repository.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/AssociateApprovalRuleTemplateWithRepository">REST API Reference for AssociateApprovalRuleTemplateWithRepository Operation</seealso>
        public virtual Task<AssociateApprovalRuleTemplateWithRepositoryResponse> AssociateApprovalRuleTemplateWithRepositoryAsync(AssociateApprovalRuleTemplateWithRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateApprovalRuleTemplateWithRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateApprovalRuleTemplateWithRepositoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateApprovalRuleTemplateWithRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchAssociateApprovalRuleTemplateWithRepositories


        /// <summary>
        /// Creates an association between an approval rule template and one or more specified
        /// repositories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateApprovalRuleTemplateWithRepositories service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateApprovalRuleTemplateWithRepositories service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryNamesExceededException">
        /// The maximum number of allowed repository names was exceeded. Currently, this number
        /// is 100.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNamesRequiredException">
        /// At least one repository name object is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchAssociateApprovalRuleTemplateWithRepositories">REST API Reference for BatchAssociateApprovalRuleTemplateWithRepositories Operation</seealso>
        public virtual BatchAssociateApprovalRuleTemplateWithRepositoriesResponse BatchAssociateApprovalRuleTemplateWithRepositories(BatchAssociateApprovalRuleTemplateWithRepositoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateApprovalRuleTemplateWithRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateApprovalRuleTemplateWithRepositoriesResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateApprovalRuleTemplateWithRepositoriesResponse>(request, options);
        }


        /// <summary>
        /// Creates an association between an approval rule template and one or more specified
        /// repositories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateApprovalRuleTemplateWithRepositories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchAssociateApprovalRuleTemplateWithRepositories service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryNamesExceededException">
        /// The maximum number of allowed repository names was exceeded. Currently, this number
        /// is 100.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNamesRequiredException">
        /// At least one repository name object is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchAssociateApprovalRuleTemplateWithRepositories">REST API Reference for BatchAssociateApprovalRuleTemplateWithRepositories Operation</seealso>
        public virtual Task<BatchAssociateApprovalRuleTemplateWithRepositoriesResponse> BatchAssociateApprovalRuleTemplateWithRepositoriesAsync(BatchAssociateApprovalRuleTemplateWithRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateApprovalRuleTemplateWithRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateApprovalRuleTemplateWithRepositoriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchAssociateApprovalRuleTemplateWithRepositoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDescribeMergeConflicts


        /// <summary>
        /// Returns information about one or more merge conflicts in the attempted merge of two
        /// commit specifiers using the squash or three-way merge strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeMergeConflicts service method.</param>
        /// 
        /// <returns>The response from the BatchDescribeMergeConflicts service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxConflictFilesException">
        /// The specified value for the number of conflict files to return is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxMergeHunksException">
        /// The specified value for the number of merge hunks to return is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMergeOptionException">
        /// The specified merge option is not valid for this operation. Not all merge strategies
        /// are supported for all operations.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MergeOptionRequiredException">
        /// A merge option or stategy is required, and none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchDescribeMergeConflicts">REST API Reference for BatchDescribeMergeConflicts Operation</seealso>
        public virtual BatchDescribeMergeConflictsResponse BatchDescribeMergeConflicts(BatchDescribeMergeConflictsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDescribeMergeConflictsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDescribeMergeConflictsResponseUnmarshaller.Instance;

            return Invoke<BatchDescribeMergeConflictsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about one or more merge conflicts in the attempted merge of two
        /// commit specifiers using the squash or three-way merge strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeMergeConflicts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDescribeMergeConflicts service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxConflictFilesException">
        /// The specified value for the number of conflict files to return is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxMergeHunksException">
        /// The specified value for the number of merge hunks to return is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMergeOptionException">
        /// The specified merge option is not valid for this operation. Not all merge strategies
        /// are supported for all operations.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MergeOptionRequiredException">
        /// A merge option or stategy is required, and none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchDescribeMergeConflicts">REST API Reference for BatchDescribeMergeConflicts Operation</seealso>
        public virtual Task<BatchDescribeMergeConflictsResponse> BatchDescribeMergeConflictsAsync(BatchDescribeMergeConflictsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDescribeMergeConflictsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDescribeMergeConflictsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDescribeMergeConflictsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDisassociateApprovalRuleTemplateFromRepositories


        /// <summary>
        /// Removes the association between an approval rule template and one or more specified
        /// repositories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateApprovalRuleTemplateFromRepositories service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateApprovalRuleTemplateFromRepositories service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryNamesExceededException">
        /// The maximum number of allowed repository names was exceeded. Currently, this number
        /// is 100.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNamesRequiredException">
        /// At least one repository name object is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchDisassociateApprovalRuleTemplateFromRepositories">REST API Reference for BatchDisassociateApprovalRuleTemplateFromRepositories Operation</seealso>
        public virtual BatchDisassociateApprovalRuleTemplateFromRepositoriesResponse BatchDisassociateApprovalRuleTemplateFromRepositories(BatchDisassociateApprovalRuleTemplateFromRepositoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateApprovalRuleTemplateFromRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateApprovalRuleTemplateFromRepositoriesResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateApprovalRuleTemplateFromRepositoriesResponse>(request, options);
        }


        /// <summary>
        /// Removes the association between an approval rule template and one or more specified
        /// repositories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateApprovalRuleTemplateFromRepositories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDisassociateApprovalRuleTemplateFromRepositories service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryNamesExceededException">
        /// The maximum number of allowed repository names was exceeded. Currently, this number
        /// is 100.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNamesRequiredException">
        /// At least one repository name object is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchDisassociateApprovalRuleTemplateFromRepositories">REST API Reference for BatchDisassociateApprovalRuleTemplateFromRepositories Operation</seealso>
        public virtual Task<BatchDisassociateApprovalRuleTemplateFromRepositoriesResponse> BatchDisassociateApprovalRuleTemplateFromRepositoriesAsync(BatchDisassociateApprovalRuleTemplateFromRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateApprovalRuleTemplateFromRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateApprovalRuleTemplateFromRepositoriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDisassociateApprovalRuleTemplateFromRepositoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetCommits


        /// <summary>
        /// Returns information about the contents of one or more commits in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCommits service method.</param>
        /// 
        /// <returns>The response from the BatchGetCommits service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdsLimitExceededException">
        /// The maximum number of allowed commit IDs in a batch request is 100. Verify that your
        /// batch requests contains no more than 100 commit IDs, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdsListRequiredException">
        /// A list of commit IDs is required, but was either not specified or the list was empty.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchGetCommits">REST API Reference for BatchGetCommits Operation</seealso>
        public virtual BatchGetCommitsResponse BatchGetCommits(BatchGetCommitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetCommitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCommitsResponseUnmarshaller.Instance;

            return Invoke<BatchGetCommitsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the contents of one or more commits in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCommits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCommits service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdsLimitExceededException">
        /// The maximum number of allowed commit IDs in a batch request is 100. Verify that your
        /// batch requests contains no more than 100 commit IDs, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdsListRequiredException">
        /// A list of commit IDs is required, but was either not specified or the list was empty.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchGetCommits">REST API Reference for BatchGetCommits Operation</seealso>
        public virtual Task<BatchGetCommitsResponse> BatchGetCommitsAsync(BatchGetCommitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetCommitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetCommitsResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetCommitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetRepositories


        /// <summary>
        /// Returns information about one or more repositories.
        /// 
        ///  <note> 
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a webpage can expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a webpage.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRepositories service method.</param>
        /// 
        /// <returns>The response from the BatchGetRepositories service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryNamesExceededException">
        /// The maximum number of allowed repository names was exceeded. Currently, this number
        /// is 100.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNamesRequiredException">
        /// At least one repository name object is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchGetRepositories">REST API Reference for BatchGetRepositories Operation</seealso>
        public virtual BatchGetRepositoriesResponse BatchGetRepositories(BatchGetRepositoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetRepositoriesResponseUnmarshaller.Instance;

            return Invoke<BatchGetRepositoriesResponse>(request, options);
        }


        /// <summary>
        /// Returns information about one or more repositories.
        /// 
        ///  <note> 
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a webpage can expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a webpage.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRepositories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetRepositories service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryNamesExceededException">
        /// The maximum number of allowed repository names was exceeded. Currently, this number
        /// is 100.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNamesRequiredException">
        /// At least one repository name object is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchGetRepositories">REST API Reference for BatchGetRepositories Operation</seealso>
        public virtual Task<BatchGetRepositoriesResponse> BatchGetRepositoriesAsync(BatchGetRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetRepositoriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchGetRepositoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApprovalRuleTemplate


        /// <summary>
        /// Creates a template for approval rules that can then be associated with one or more
        /// repositories in your Amazon Web Services account. When you associate a template with
        /// a repository, CodeCommit creates an approval rule that matches the conditions of the
        /// template for all pull requests that meet the conditions of the template. For more
        /// information, see <a>AssociateApprovalRuleTemplateWithRepository</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApprovalRuleTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateApprovalRuleTemplate service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateContentRequiredException">
        /// The content for the approval rule template is empty. You must provide some content
        /// for an approval rule template. The content cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameAlreadyExistsException">
        /// You cannot create an approval rule template with that name because a template with
        /// that name already exists in this Amazon Web Services Region for your Amazon Web Services
        /// account. Approval rule template names must be unique.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateContentException">
        /// The content of the approval rule template is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateDescriptionException">
        /// The description for the approval rule template is not valid because it exceeds the
        /// maximum characters allowed for a description. For more information about limits in
        /// CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NumberOfRuleTemplatesExceededException">
        /// The maximum number of approval rule templates has been exceeded for this Amazon Web
        /// Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateApprovalRuleTemplate">REST API Reference for CreateApprovalRuleTemplate Operation</seealso>
        public virtual CreateApprovalRuleTemplateResponse CreateApprovalRuleTemplate(CreateApprovalRuleTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApprovalRuleTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApprovalRuleTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateApprovalRuleTemplateResponse>(request, options);
        }


        /// <summary>
        /// Creates a template for approval rules that can then be associated with one or more
        /// repositories in your Amazon Web Services account. When you associate a template with
        /// a repository, CodeCommit creates an approval rule that matches the conditions of the
        /// template for all pull requests that meet the conditions of the template. For more
        /// information, see <a>AssociateApprovalRuleTemplateWithRepository</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApprovalRuleTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApprovalRuleTemplate service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateContentRequiredException">
        /// The content for the approval rule template is empty. You must provide some content
        /// for an approval rule template. The content cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameAlreadyExistsException">
        /// You cannot create an approval rule template with that name because a template with
        /// that name already exists in this Amazon Web Services Region for your Amazon Web Services
        /// account. Approval rule template names must be unique.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateContentException">
        /// The content of the approval rule template is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateDescriptionException">
        /// The description for the approval rule template is not valid because it exceeds the
        /// maximum characters allowed for a description. For more information about limits in
        /// CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NumberOfRuleTemplatesExceededException">
        /// The maximum number of approval rule templates has been exceeded for this Amazon Web
        /// Services Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateApprovalRuleTemplate">REST API Reference for CreateApprovalRuleTemplate Operation</seealso>
        public virtual Task<CreateApprovalRuleTemplateResponse> CreateApprovalRuleTemplateAsync(CreateApprovalRuleTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApprovalRuleTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApprovalRuleTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateApprovalRuleTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBranch


        /// <summary>
        /// Creates a branch in a repository and points the branch to a commit.
        /// 
        ///  <note> 
        /// <para>
        /// Calling the create branch operation does not set a repository's default branch. To
        /// do this, call the update default branch operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch service method.</param>
        /// 
        /// <returns>The response from the CreateBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameExistsException">
        /// Cannot create the branch with the specified name because the commit conflicts with
        /// an existing branch with the same name. Branch names must be unique.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        public virtual CreateBranchResponse CreateBranch(CreateBranchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBranchResponseUnmarshaller.Instance;

            return Invoke<CreateBranchResponse>(request, options);
        }


        /// <summary>
        /// Creates a branch in a repository and points the branch to a commit.
        /// 
        ///  <note> 
        /// <para>
        /// Calling the create branch operation does not set a repository's default branch. To
        /// do this, call the update default branch operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameExistsException">
        /// Cannot create the branch with the specified name because the commit conflicts with
        /// an existing branch with the same name. Branch names must be unique.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        public virtual Task<CreateBranchResponse> CreateBranchAsync(CreateBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBranchResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCommit


        /// <summary>
        /// Creates a commit for a repository on the tip of a specified branch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCommit service method.</param>
        /// 
        /// <returns>The response from the CreateCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.DirectoryNameConflictsWithFileNameException">
        /// A file cannot be added to the repository because the specified path name has the same
        /// name as a file that already exists in this repository. Either provide a different
        /// name for the file, or specify a different path for the file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentAndSourceFileSpecifiedException">
        /// The commit cannot be created because both a source file and file content have been
        /// specified for the same file. You cannot provide both. Either specify a source file
        /// or provide the file content directly.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileDoesNotExistException">
        /// The specified file does not exist. Verify that you have used the correct file name,
        /// full path, and extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileEntryRequiredException">
        /// The commit cannot be created because no files have been specified as added, updated,
        /// or changed (PutFile or DeleteFile) for the commit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileModeRequiredException">
        /// The commit cannot be created because no file mode has been specified. A file mode
        /// is required to update mode permissions for a file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileNameConflictsWithDirectoryNameException">
        /// A file cannot be added to the repository because the specified file name has the same
        /// name as a directory in this repository. Either provide another name for the file,
        /// or add the file in a directory that does not match the file name.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FilePathConflictsWithSubmodulePathException">
        /// The commit cannot be created because a specified file path points to a submodule.
        /// Verify that the destination files have valid file paths that do not point to a submodule.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDeletionParameterException">
        /// The specified deletion parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidParentCommitIdException">
        /// The parent commit ID is not valid. The commit ID cannot be empty, and must match the
        /// head commit ID for the branch of the repository where you want to add or update a
        /// file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileEntriesExceededException">
        /// The number of specified files to change as part of this commit exceeds the maximum
        /// number of files that can be changed in a single commit. Consider using a Git client
        /// for these changes.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NoChangeException">
        /// The commit cannot be created because no changes will be made to the repository as
        /// a result of this commit. A commit must contain at least one change.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitDoesNotExistException">
        /// The parent commit ID is not valid because it does not exist. The specified parent
        /// commit ID does not exist in the specified branch of the repository.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdOutdatedException">
        /// The file could not be added because the provided parent commit ID is not the current
        /// tip of the specified branch. To view the full commit ID of the current head of the
        /// branch, use <a>GetBranch</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdRequiredException">
        /// A parent commit ID is required. To view the full commit ID of a branch in a repository,
        /// use <a>GetBranch</a> or a Git command (for example, git pull or git log).
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PutFileEntryConflictException">
        /// The commit cannot be created because one or more files specified in the commit reference
        /// both a file and a folder.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RestrictedSourceFileException">
        /// The commit cannot be created because one of the changes specifies copying or moving
        /// a .gitkeep file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.SamePathRequestException">
        /// The commit cannot be created because one or more changes in this commit duplicate
        /// actions in the same file path. For example, you cannot make the same delete request
        /// to the same file in the same file path twice, or make a delete request and a move
        /// request to the same file as part of the same commit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.SourceFileOrContentRequiredException">
        /// The commit cannot be created because no source files or file content have been specified
        /// for the commit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateCommit">REST API Reference for CreateCommit Operation</seealso>
        public virtual CreateCommitResponse CreateCommit(CreateCommitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCommitResponseUnmarshaller.Instance;

            return Invoke<CreateCommitResponse>(request, options);
        }


        /// <summary>
        /// Creates a commit for a repository on the tip of a specified branch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCommit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.DirectoryNameConflictsWithFileNameException">
        /// A file cannot be added to the repository because the specified path name has the same
        /// name as a file that already exists in this repository. Either provide a different
        /// name for the file, or specify a different path for the file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentAndSourceFileSpecifiedException">
        /// The commit cannot be created because both a source file and file content have been
        /// specified for the same file. You cannot provide both. Either specify a source file
        /// or provide the file content directly.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileDoesNotExistException">
        /// The specified file does not exist. Verify that you have used the correct file name,
        /// full path, and extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileEntryRequiredException">
        /// The commit cannot be created because no files have been specified as added, updated,
        /// or changed (PutFile or DeleteFile) for the commit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileModeRequiredException">
        /// The commit cannot be created because no file mode has been specified. A file mode
        /// is required to update mode permissions for a file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileNameConflictsWithDirectoryNameException">
        /// A file cannot be added to the repository because the specified file name has the same
        /// name as a directory in this repository. Either provide another name for the file,
        /// or add the file in a directory that does not match the file name.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FilePathConflictsWithSubmodulePathException">
        /// The commit cannot be created because a specified file path points to a submodule.
        /// Verify that the destination files have valid file paths that do not point to a submodule.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDeletionParameterException">
        /// The specified deletion parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidParentCommitIdException">
        /// The parent commit ID is not valid. The commit ID cannot be empty, and must match the
        /// head commit ID for the branch of the repository where you want to add or update a
        /// file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileEntriesExceededException">
        /// The number of specified files to change as part of this commit exceeds the maximum
        /// number of files that can be changed in a single commit. Consider using a Git client
        /// for these changes.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NoChangeException">
        /// The commit cannot be created because no changes will be made to the repository as
        /// a result of this commit. A commit must contain at least one change.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitDoesNotExistException">
        /// The parent commit ID is not valid because it does not exist. The specified parent
        /// commit ID does not exist in the specified branch of the repository.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdOutdatedException">
        /// The file could not be added because the provided parent commit ID is not the current
        /// tip of the specified branch. To view the full commit ID of the current head of the
        /// branch, use <a>GetBranch</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdRequiredException">
        /// A parent commit ID is required. To view the full commit ID of a branch in a repository,
        /// use <a>GetBranch</a> or a Git command (for example, git pull or git log).
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PutFileEntryConflictException">
        /// The commit cannot be created because one or more files specified in the commit reference
        /// both a file and a folder.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RestrictedSourceFileException">
        /// The commit cannot be created because one of the changes specifies copying or moving
        /// a .gitkeep file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.SamePathRequestException">
        /// The commit cannot be created because one or more changes in this commit duplicate
        /// actions in the same file path. For example, you cannot make the same delete request
        /// to the same file in the same file path twice, or make a delete request and a move
        /// request to the same file as part of the same commit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.SourceFileOrContentRequiredException">
        /// The commit cannot be created because no source files or file content have been specified
        /// for the commit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateCommit">REST API Reference for CreateCommit Operation</seealso>
        public virtual Task<CreateCommitResponse> CreateCommitAsync(CreateCommitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCommitResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCommitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePullRequest


        /// <summary>
        /// Creates a pull request in the specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePullRequest service method.</param>
        /// 
        /// <returns>The response from the CreatePullRequest service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ClientRequestTokenRequiredException">
        /// A client request token is required. A client request token is an unique, client-generated
        /// idempotency token that, when provided in a request, ensures the request cannot be
        /// repeated with a changed parameter. If a request is received with the same parameters
        /// and a token is included, the request returns information about the initial request
        /// that used that token.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.IdempotencyParameterMismatchException">
        /// The client request token is not valid. Either the token is not in a valid format,
        /// or the token has been used in a previous request and cannot be reused.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDescriptionException">
        /// The pull request description is not valid. Descriptions cannot be more than 1,000
        /// characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReferenceNameException">
        /// The specified reference name format is not valid. Reference names must conform to
        /// the Git references format (for example, refs/heads/main). For more information, see
        /// <a href="https://git-scm.com/book/en/v2/Git-Internals-Git-References">Git Internals
        /// - Git References</a> or consult your Git documentation.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetException">
        /// The target for the pull request is not valid. A target must contain the full values
        /// for the repository name, source branch, and destination branch for the pull request.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetsException">
        /// The targets for the pull request is not valid or not in a valid format. Targets are
        /// a list of target objects. Each target object must contain the full values for the
        /// repository name, source branch, and destination branch for a pull request.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTitleException">
        /// The title of the pull request is not valid. Pull request titles cannot exceed 100
        /// characters in length.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumOpenPullRequestsExceededException">
        /// You cannot create the pull request because the repository has too many open pull requests.
        /// The maximum number of open pull requests for a repository is 1,000. Close one or more
        /// open pull requests, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleRepositoriesInPullRequestException">
        /// You cannot include more than one repository in a pull request. Make sure you have
        /// specified only one repository name in your request, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReferenceDoesNotExistException">
        /// The specified reference does not exist. You must provide a full commit ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReferenceNameRequiredException">
        /// A reference name is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReferenceTypeNotSupportedException">
        /// The specified reference is not a supported type.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.SourceAndDestinationAreSameException">
        /// The source branch and destination branch for the pull request are the same. You must
        /// specify different branches for the source and destination.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TargetRequiredException">
        /// A pull request target is required. It cannot be empty or null. A pull request target
        /// must contain the full values for the repository name, source branch, and destination
        /// branch for the pull request.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TargetsRequiredException">
        /// An array of target objects is required. It cannot be empty or null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TitleRequiredException">
        /// A pull request title is required. It cannot be empty or null.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreatePullRequest">REST API Reference for CreatePullRequest Operation</seealso>
        public virtual CreatePullRequestResponse CreatePullRequest(CreatePullRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePullRequestResponseUnmarshaller.Instance;

            return Invoke<CreatePullRequestResponse>(request, options);
        }


        /// <summary>
        /// Creates a pull request in the specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePullRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePullRequest service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ClientRequestTokenRequiredException">
        /// A client request token is required. A client request token is an unique, client-generated
        /// idempotency token that, when provided in a request, ensures the request cannot be
        /// repeated with a changed parameter. If a request is received with the same parameters
        /// and a token is included, the request returns information about the initial request
        /// that used that token.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.IdempotencyParameterMismatchException">
        /// The client request token is not valid. Either the token is not in a valid format,
        /// or the token has been used in a previous request and cannot be reused.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDescriptionException">
        /// The pull request description is not valid. Descriptions cannot be more than 1,000
        /// characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReferenceNameException">
        /// The specified reference name format is not valid. Reference names must conform to
        /// the Git references format (for example, refs/heads/main). For more information, see
        /// <a href="https://git-scm.com/book/en/v2/Git-Internals-Git-References">Git Internals
        /// - Git References</a> or consult your Git documentation.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetException">
        /// The target for the pull request is not valid. A target must contain the full values
        /// for the repository name, source branch, and destination branch for the pull request.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetsException">
        /// The targets for the pull request is not valid or not in a valid format. Targets are
        /// a list of target objects. Each target object must contain the full values for the
        /// repository name, source branch, and destination branch for a pull request.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTitleException">
        /// The title of the pull request is not valid. Pull request titles cannot exceed 100
        /// characters in length.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumOpenPullRequestsExceededException">
        /// You cannot create the pull request because the repository has too many open pull requests.
        /// The maximum number of open pull requests for a repository is 1,000. Close one or more
        /// open pull requests, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleRepositoriesInPullRequestException">
        /// You cannot include more than one repository in a pull request. Make sure you have
        /// specified only one repository name in your request, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReferenceDoesNotExistException">
        /// The specified reference does not exist. You must provide a full commit ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReferenceNameRequiredException">
        /// A reference name is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReferenceTypeNotSupportedException">
        /// The specified reference is not a supported type.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.SourceAndDestinationAreSameException">
        /// The source branch and destination branch for the pull request are the same. You must
        /// specify different branches for the source and destination.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TargetRequiredException">
        /// A pull request target is required. It cannot be empty or null. A pull request target
        /// must contain the full values for the repository name, source branch, and destination
        /// branch for the pull request.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TargetsRequiredException">
        /// An array of target objects is required. It cannot be empty or null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TitleRequiredException">
        /// A pull request title is required. It cannot be empty or null.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreatePullRequest">REST API Reference for CreatePullRequest Operation</seealso>
        public virtual Task<CreatePullRequestResponse> CreatePullRequestAsync(CreatePullRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePullRequestResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePullRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePullRequestApprovalRule


        /// <summary>
        /// Creates an approval rule for a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePullRequestApprovalRule service method.</param>
        /// 
        /// <returns>The response from the CreatePullRequestApprovalRule service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleContentRequiredException">
        /// The content for the approval rule is empty. You must provide some content for an approval
        /// rule. The content cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleNameAlreadyExistsException">
        /// An approval rule with that name already exists. Approval rule names must be unique
        /// within the scope of a pull request.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleNameRequiredException">
        /// An approval rule name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleContentException">
        /// The content for the approval rule is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleNameException">
        /// The name for the approval rule is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NumberOfRulesExceededException">
        /// The approval rule cannot be added. The pull request has the maximum number of approval
        /// rules associated with it.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreatePullRequestApprovalRule">REST API Reference for CreatePullRequestApprovalRule Operation</seealso>
        public virtual CreatePullRequestApprovalRuleResponse CreatePullRequestApprovalRule(CreatePullRequestApprovalRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePullRequestApprovalRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePullRequestApprovalRuleResponseUnmarshaller.Instance;

            return Invoke<CreatePullRequestApprovalRuleResponse>(request, options);
        }


        /// <summary>
        /// Creates an approval rule for a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePullRequestApprovalRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePullRequestApprovalRule service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleContentRequiredException">
        /// The content for the approval rule is empty. You must provide some content for an approval
        /// rule. The content cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleNameAlreadyExistsException">
        /// An approval rule with that name already exists. Approval rule names must be unique
        /// within the scope of a pull request.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleNameRequiredException">
        /// An approval rule name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleContentException">
        /// The content for the approval rule is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleNameException">
        /// The name for the approval rule is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NumberOfRulesExceededException">
        /// The approval rule cannot be added. The pull request has the maximum number of approval
        /// rules associated with it.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreatePullRequestApprovalRule">REST API Reference for CreatePullRequestApprovalRule Operation</seealso>
        public virtual Task<CreatePullRequestApprovalRuleResponse> CreatePullRequestApprovalRuleAsync(CreatePullRequestApprovalRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePullRequestApprovalRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePullRequestApprovalRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePullRequestApprovalRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRepository


        /// <summary>
        /// Creates a new, empty repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository service method.</param>
        /// 
        /// <returns>The response from the CreateRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyInvalidIdException">
        /// The Key Management Service encryption key is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyInvalidUsageException">
        /// A KMS encryption key was used to try and encrypt or decrypt a repository, but either
        /// the repository or the key was not in a valid state to support the operation.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryDescriptionException">
        /// The specified repository description is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSystemTagUsageException">
        /// The specified tag is not valid. Key names cannot be prefixed with aws:.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTagsMapException">
        /// The map of tags is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.OperationNotAllowedException">
        /// The requested action is not allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryLimitExceededException">
        /// A repository resource limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameExistsException">
        /// The specified repository name already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagPolicyException">
        /// The tag policy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TooManyTagsException">
        /// The maximum number of tags for an CodeCommit resource has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        public virtual CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return Invoke<CreateRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Creates a new, empty repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyInvalidIdException">
        /// The Key Management Service encryption key is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyInvalidUsageException">
        /// A KMS encryption key was used to try and encrypt or decrypt a repository, but either
        /// the repository or the key was not in a valid state to support the operation.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryDescriptionException">
        /// The specified repository description is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSystemTagUsageException">
        /// The specified tag is not valid. Key names cannot be prefixed with aws:.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTagsMapException">
        /// The map of tags is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.OperationNotAllowedException">
        /// The requested action is not allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryLimitExceededException">
        /// A repository resource limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameExistsException">
        /// The specified repository name already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagPolicyException">
        /// The tag policy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TooManyTagsException">
        /// The maximum number of tags for an CodeCommit resource has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        public virtual Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUnreferencedMergeCommit


        /// <summary>
        /// Creates an unreferenced commit that represents the result of merging two branches
        /// using a specified merge strategy. This can help you determine the outcome of a potential
        /// merge. This API cannot be used with the fast-forward merge strategy because that strategy
        /// does not create a merge commit.
        /// 
        ///  <note> 
        /// <para>
        /// This unreferenced merge commit can only be accessed using the GetCommit API or through
        /// git commands such as git fetch. To retrieve this commit, you must specify its commit
        /// ID or otherwise reference it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUnreferencedMergeCommit service method.</param>
        /// 
        /// <returns>The response from the CreateUnreferencedMergeCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileModeRequiredException">
        /// The commit cannot be created because no file mode has been specified. A file mode
        /// is required to update mode permissions for a file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMergeOptionException">
        /// The specified merge option is not valid for this operation. Not all merge strategies
        /// are supported for all operations.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MergeOptionRequiredException">
        /// A merge option or stategy is required, and none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateUnreferencedMergeCommit">REST API Reference for CreateUnreferencedMergeCommit Operation</seealso>
        public virtual CreateUnreferencedMergeCommitResponse CreateUnreferencedMergeCommit(CreateUnreferencedMergeCommitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUnreferencedMergeCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUnreferencedMergeCommitResponseUnmarshaller.Instance;

            return Invoke<CreateUnreferencedMergeCommitResponse>(request, options);
        }


        /// <summary>
        /// Creates an unreferenced commit that represents the result of merging two branches
        /// using a specified merge strategy. This can help you determine the outcome of a potential
        /// merge. This API cannot be used with the fast-forward merge strategy because that strategy
        /// does not create a merge commit.
        /// 
        ///  <note> 
        /// <para>
        /// This unreferenced merge commit can only be accessed using the GetCommit API or through
        /// git commands such as git fetch. To retrieve this commit, you must specify its commit
        /// ID or otherwise reference it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUnreferencedMergeCommit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUnreferencedMergeCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileModeRequiredException">
        /// The commit cannot be created because no file mode has been specified. A file mode
        /// is required to update mode permissions for a file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMergeOptionException">
        /// The specified merge option is not valid for this operation. Not all merge strategies
        /// are supported for all operations.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MergeOptionRequiredException">
        /// A merge option or stategy is required, and none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateUnreferencedMergeCommit">REST API Reference for CreateUnreferencedMergeCommit Operation</seealso>
        public virtual Task<CreateUnreferencedMergeCommitResponse> CreateUnreferencedMergeCommitAsync(CreateUnreferencedMergeCommitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUnreferencedMergeCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUnreferencedMergeCommitResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateUnreferencedMergeCommitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApprovalRuleTemplate


        /// <summary>
        /// Deletes a specified approval rule template. Deleting a template does not remove approval
        /// rules on pull requests already created with the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApprovalRuleTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteApprovalRuleTemplate service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateInUseException">
        /// The approval rule template is associated with one or more repositories. You cannot
        /// delete a template that is associated with a repository. Remove all associations, and
        /// then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteApprovalRuleTemplate">REST API Reference for DeleteApprovalRuleTemplate Operation</seealso>
        public virtual DeleteApprovalRuleTemplateResponse DeleteApprovalRuleTemplate(DeleteApprovalRuleTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApprovalRuleTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApprovalRuleTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteApprovalRuleTemplateResponse>(request, options);
        }


        /// <summary>
        /// Deletes a specified approval rule template. Deleting a template does not remove approval
        /// rules on pull requests already created with the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApprovalRuleTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApprovalRuleTemplate service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateInUseException">
        /// The approval rule template is associated with one or more repositories. You cannot
        /// delete a template that is associated with a repository. Remove all associations, and
        /// then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteApprovalRuleTemplate">REST API Reference for DeleteApprovalRuleTemplate Operation</seealso>
        public virtual Task<DeleteApprovalRuleTemplateResponse> DeleteApprovalRuleTemplateAsync(DeleteApprovalRuleTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApprovalRuleTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApprovalRuleTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteApprovalRuleTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBranch


        /// <summary>
        /// Deletes a branch from a repository, unless that branch is the default branch for the
        /// repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBranch service method.</param>
        /// 
        /// <returns>The response from the DeleteBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.DefaultBranchCannotBeDeletedException">
        /// The specified branch is the default branch for the repository, and cannot be deleted.
        /// To delete this branch, you must first set another branch as the default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        public virtual DeleteBranchResponse DeleteBranch(DeleteBranchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBranchResponseUnmarshaller.Instance;

            return Invoke<DeleteBranchResponse>(request, options);
        }


        /// <summary>
        /// Deletes a branch from a repository, unless that branch is the default branch for the
        /// repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBranch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.DefaultBranchCannotBeDeletedException">
        /// The specified branch is the default branch for the repository, and cannot be deleted.
        /// To delete this branch, you must first set another branch as the default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        public virtual Task<DeleteBranchResponse> DeleteBranchAsync(DeleteBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBranchResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCommentContent


        /// <summary>
        /// Deletes the content of a comment made on a change, file, or commit in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCommentContent service method.</param>
        /// 
        /// <returns>The response from the DeleteCommentContent service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDeletedException">
        /// This comment has already been deleted. You cannot edit or delete a deleted comment.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteCommentContent">REST API Reference for DeleteCommentContent Operation</seealso>
        public virtual DeleteCommentContentResponse DeleteCommentContent(DeleteCommentContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCommentContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCommentContentResponseUnmarshaller.Instance;

            return Invoke<DeleteCommentContentResponse>(request, options);
        }


        /// <summary>
        /// Deletes the content of a comment made on a change, file, or commit in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCommentContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCommentContent service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDeletedException">
        /// This comment has already been deleted. You cannot edit or delete a deleted comment.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteCommentContent">REST API Reference for DeleteCommentContent Operation</seealso>
        public virtual Task<DeleteCommentContentResponse> DeleteCommentContentAsync(DeleteCommentContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCommentContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCommentContentResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCommentContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFile


        /// <summary>
        /// Deletes a specified file from a specified branch. A commit is created on the branch
        /// that contains the revision. The file still exists in the commits earlier to the commit
        /// that contains the deletion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFile service method.</param>
        /// 
        /// <returns>The response from the DeleteFile service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileDoesNotExistException">
        /// The specified file does not exist. Verify that you have used the correct file name,
        /// full path, and extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidParentCommitIdException">
        /// The parent commit ID is not valid. The commit ID cannot be empty, and must match the
        /// head commit ID for the branch of the repository where you want to add or update a
        /// file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitDoesNotExistException">
        /// The parent commit ID is not valid because it does not exist. The specified parent
        /// commit ID does not exist in the specified branch of the repository.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdOutdatedException">
        /// The file could not be added because the provided parent commit ID is not the current
        /// tip of the specified branch. To view the full commit ID of the current head of the
        /// branch, use <a>GetBranch</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdRequiredException">
        /// A parent commit ID is required. To view the full commit ID of a branch in a repository,
        /// use <a>GetBranch</a> or a Git command (for example, git pull or git log).
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteFile">REST API Reference for DeleteFile Operation</seealso>
        public virtual DeleteFileResponse DeleteFile(DeleteFileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileResponseUnmarshaller.Instance;

            return Invoke<DeleteFileResponse>(request, options);
        }


        /// <summary>
        /// Deletes a specified file from a specified branch. A commit is created on the branch
        /// that contains the revision. The file still exists in the commits earlier to the commit
        /// that contains the deletion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFile service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileDoesNotExistException">
        /// The specified file does not exist. Verify that you have used the correct file name,
        /// full path, and extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidParentCommitIdException">
        /// The parent commit ID is not valid. The commit ID cannot be empty, and must match the
        /// head commit ID for the branch of the repository where you want to add or update a
        /// file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitDoesNotExistException">
        /// The parent commit ID is not valid because it does not exist. The specified parent
        /// commit ID does not exist in the specified branch of the repository.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdOutdatedException">
        /// The file could not be added because the provided parent commit ID is not the current
        /// tip of the specified branch. To view the full commit ID of the current head of the
        /// branch, use <a>GetBranch</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdRequiredException">
        /// A parent commit ID is required. To view the full commit ID of a branch in a repository,
        /// use <a>GetBranch</a> or a Git command (for example, git pull or git log).
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteFile">REST API Reference for DeleteFile Operation</seealso>
        public virtual Task<DeleteFileResponse> DeleteFileAsync(DeleteFileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePullRequestApprovalRule


        /// <summary>
        /// Deletes an approval rule from a specified pull request. Approval rules can be deleted
        /// from a pull request only if the pull request is open, and if the approval rule was
        /// created specifically for a pull request and not generated from an approval rule template
        /// associated with the repository where the pull request was created. You cannot delete
        /// an approval rule from a merged or closed pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePullRequestApprovalRule service method.</param>
        /// 
        /// <returns>The response from the DeletePullRequestApprovalRule service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleNameRequiredException">
        /// An approval rule name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CannotDeleteApprovalRuleFromTemplateException">
        /// The approval rule cannot be deleted from the pull request because it was created by
        /// an approval rule template and applied to the pull request automatically.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleNameException">
        /// The name for the approval rule is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeletePullRequestApprovalRule">REST API Reference for DeletePullRequestApprovalRule Operation</seealso>
        public virtual DeletePullRequestApprovalRuleResponse DeletePullRequestApprovalRule(DeletePullRequestApprovalRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePullRequestApprovalRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePullRequestApprovalRuleResponseUnmarshaller.Instance;

            return Invoke<DeletePullRequestApprovalRuleResponse>(request, options);
        }


        /// <summary>
        /// Deletes an approval rule from a specified pull request. Approval rules can be deleted
        /// from a pull request only if the pull request is open, and if the approval rule was
        /// created specifically for a pull request and not generated from an approval rule template
        /// associated with the repository where the pull request was created. You cannot delete
        /// an approval rule from a merged or closed pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePullRequestApprovalRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePullRequestApprovalRule service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleNameRequiredException">
        /// An approval rule name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CannotDeleteApprovalRuleFromTemplateException">
        /// The approval rule cannot be deleted from the pull request because it was created by
        /// an approval rule template and applied to the pull request automatically.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleNameException">
        /// The name for the approval rule is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeletePullRequestApprovalRule">REST API Reference for DeletePullRequestApprovalRule Operation</seealso>
        public virtual Task<DeletePullRequestApprovalRuleResponse> DeletePullRequestApprovalRuleAsync(DeletePullRequestApprovalRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePullRequestApprovalRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePullRequestApprovalRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePullRequestApprovalRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRepository


        /// <summary>
        /// Deletes a repository. If a specified repository was already deleted, a null repository
        /// ID is returned.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a repository also deletes all associated objects and metadata. After a repository
        /// is deleted, all future push calls to the deleted repository fail.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository service method.</param>
        /// 
        /// <returns>The response from the DeleteRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        public virtual DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return Invoke<DeleteRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Deletes a repository. If a specified repository was already deleted, a null repository
        /// ID is returned.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a repository also deletes all associated objects and metadata. After a repository
        /// is deleted, all future push calls to the deleted repository fail.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        public virtual Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMergeConflicts


        /// <summary>
        /// Returns information about one or more merge conflicts in the attempted merge of two
        /// commit specifiers using the squash or three-way merge strategy. If the merge option
        /// for the attempted merge is specified as FAST_FORWARD_MERGE, an exception is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMergeConflicts service method.</param>
        /// 
        /// <returns>The response from the DescribeMergeConflicts service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileDoesNotExistException">
        /// The specified file does not exist. Verify that you have used the correct file name,
        /// full path, and extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxMergeHunksException">
        /// The specified value for the number of merge hunks to return is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMergeOptionException">
        /// The specified merge option is not valid for this operation. Not all merge strategies
        /// are supported for all operations.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MergeOptionRequiredException">
        /// A merge option or stategy is required, and none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DescribeMergeConflicts">REST API Reference for DescribeMergeConflicts Operation</seealso>
        public virtual DescribeMergeConflictsResponse DescribeMergeConflicts(DescribeMergeConflictsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMergeConflictsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMergeConflictsResponseUnmarshaller.Instance;

            return Invoke<DescribeMergeConflictsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about one or more merge conflicts in the attempted merge of two
        /// commit specifiers using the squash or three-way merge strategy. If the merge option
        /// for the attempted merge is specified as FAST_FORWARD_MERGE, an exception is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMergeConflicts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMergeConflicts service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileDoesNotExistException">
        /// The specified file does not exist. Verify that you have used the correct file name,
        /// full path, and extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxMergeHunksException">
        /// The specified value for the number of merge hunks to return is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMergeOptionException">
        /// The specified merge option is not valid for this operation. Not all merge strategies
        /// are supported for all operations.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MergeOptionRequiredException">
        /// A merge option or stategy is required, and none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DescribeMergeConflicts">REST API Reference for DescribeMergeConflicts Operation</seealso>
        public virtual Task<DescribeMergeConflictsResponse> DescribeMergeConflictsAsync(DescribeMergeConflictsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeMergeConflictsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMergeConflictsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeMergeConflictsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePullRequestEvents


        /// <summary>
        /// Returns information about one or more pull request events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePullRequestEvents service method.</param>
        /// 
        /// <returns>The response from the DescribePullRequestEvents service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ActorDoesNotExistException">
        /// The specified Amazon Resource Name (ARN) does not exist in the Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidActorArnException">
        /// The Amazon Resource Name (ARN) is not valid. Make sure that you have provided the
        /// full ARN for the user who initiated the change for the pull request, and then try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestEventTypeException">
        /// The pull request event type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DescribePullRequestEvents">REST API Reference for DescribePullRequestEvents Operation</seealso>
        public virtual DescribePullRequestEventsResponse DescribePullRequestEvents(DescribePullRequestEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePullRequestEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePullRequestEventsResponseUnmarshaller.Instance;

            return Invoke<DescribePullRequestEventsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about one or more pull request events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePullRequestEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePullRequestEvents service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ActorDoesNotExistException">
        /// The specified Amazon Resource Name (ARN) does not exist in the Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidActorArnException">
        /// The Amazon Resource Name (ARN) is not valid. Make sure that you have provided the
        /// full ARN for the user who initiated the change for the pull request, and then try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestEventTypeException">
        /// The pull request event type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DescribePullRequestEvents">REST API Reference for DescribePullRequestEvents Operation</seealso>
        public virtual Task<DescribePullRequestEventsResponse> DescribePullRequestEventsAsync(DescribePullRequestEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePullRequestEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePullRequestEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePullRequestEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateApprovalRuleTemplateFromRepository


        /// <summary>
        /// Removes the association between a template and a repository so that approval rules
        /// based on the template are not automatically created when pull requests are created
        /// in the specified repository. This does not delete any approval rules previously created
        /// for pull requests through the template association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApprovalRuleTemplateFromRepository service method.</param>
        /// 
        /// <returns>The response from the DisassociateApprovalRuleTemplateFromRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DisassociateApprovalRuleTemplateFromRepository">REST API Reference for DisassociateApprovalRuleTemplateFromRepository Operation</seealso>
        public virtual DisassociateApprovalRuleTemplateFromRepositoryResponse DisassociateApprovalRuleTemplateFromRepository(DisassociateApprovalRuleTemplateFromRepositoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateApprovalRuleTemplateFromRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApprovalRuleTemplateFromRepositoryResponseUnmarshaller.Instance;

            return Invoke<DisassociateApprovalRuleTemplateFromRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Removes the association between a template and a repository so that approval rules
        /// based on the template are not automatically created when pull requests are created
        /// in the specified repository. This does not delete any approval rules previously created
        /// for pull requests through the template association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApprovalRuleTemplateFromRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateApprovalRuleTemplateFromRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DisassociateApprovalRuleTemplateFromRepository">REST API Reference for DisassociateApprovalRuleTemplateFromRepository Operation</seealso>
        public virtual Task<DisassociateApprovalRuleTemplateFromRepositoryResponse> DisassociateApprovalRuleTemplateFromRepositoryAsync(DisassociateApprovalRuleTemplateFromRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateApprovalRuleTemplateFromRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateApprovalRuleTemplateFromRepositoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateApprovalRuleTemplateFromRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EvaluatePullRequestApprovalRules


        /// <summary>
        /// Evaluates whether a pull request has met all the conditions specified in its associated
        /// approval rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluatePullRequestApprovalRules service method.</param>
        /// 
        /// <returns>The response from the EvaluatePullRequestApprovalRules service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionNotCurrentException">
        /// The revision ID provided in the request does not match the current revision ID. Use
        /// GetPullRequest to retrieve the current revision ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/EvaluatePullRequestApprovalRules">REST API Reference for EvaluatePullRequestApprovalRules Operation</seealso>
        public virtual EvaluatePullRequestApprovalRulesResponse EvaluatePullRequestApprovalRules(EvaluatePullRequestApprovalRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EvaluatePullRequestApprovalRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluatePullRequestApprovalRulesResponseUnmarshaller.Instance;

            return Invoke<EvaluatePullRequestApprovalRulesResponse>(request, options);
        }


        /// <summary>
        /// Evaluates whether a pull request has met all the conditions specified in its associated
        /// approval rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluatePullRequestApprovalRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EvaluatePullRequestApprovalRules service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionNotCurrentException">
        /// The revision ID provided in the request does not match the current revision ID. Use
        /// GetPullRequest to retrieve the current revision ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/EvaluatePullRequestApprovalRules">REST API Reference for EvaluatePullRequestApprovalRules Operation</seealso>
        public virtual Task<EvaluatePullRequestApprovalRulesResponse> EvaluatePullRequestApprovalRulesAsync(EvaluatePullRequestApprovalRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EvaluatePullRequestApprovalRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluatePullRequestApprovalRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<EvaluatePullRequestApprovalRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApprovalRuleTemplate


        /// <summary>
        /// Returns information about a specified approval rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApprovalRuleTemplate service method.</param>
        /// 
        /// <returns>The response from the GetApprovalRuleTemplate service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetApprovalRuleTemplate">REST API Reference for GetApprovalRuleTemplate Operation</seealso>
        public virtual GetApprovalRuleTemplateResponse GetApprovalRuleTemplate(GetApprovalRuleTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApprovalRuleTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApprovalRuleTemplateResponseUnmarshaller.Instance;

            return Invoke<GetApprovalRuleTemplateResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a specified approval rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApprovalRuleTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApprovalRuleTemplate service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetApprovalRuleTemplate">REST API Reference for GetApprovalRuleTemplate Operation</seealso>
        public virtual Task<GetApprovalRuleTemplateResponse> GetApprovalRuleTemplateAsync(GetApprovalRuleTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApprovalRuleTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApprovalRuleTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetApprovalRuleTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBlob


        /// <summary>
        /// Returns the base-64 encoded content of an individual blob in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlob service method.</param>
        /// 
        /// <returns>The response from the GetBlob service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BlobIdDoesNotExistException">
        /// The specified blob does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BlobIdRequiredException">
        /// A blob ID is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileTooLargeException">
        /// The specified file exceeds the file size limit for CodeCommit. For more information
        /// about limits in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBlobIdException">
        /// The specified blob is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBlob">REST API Reference for GetBlob Operation</seealso>
        public virtual GetBlobResponse GetBlob(GetBlobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlobResponseUnmarshaller.Instance;

            return Invoke<GetBlobResponse>(request, options);
        }


        /// <summary>
        /// Returns the base-64 encoded content of an individual blob in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBlob service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BlobIdDoesNotExistException">
        /// The specified blob does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BlobIdRequiredException">
        /// A blob ID is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileTooLargeException">
        /// The specified file exceeds the file size limit for CodeCommit. For more information
        /// about limits in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBlobIdException">
        /// The specified blob is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBlob">REST API Reference for GetBlob Operation</seealso>
        public virtual Task<GetBlobResponse> GetBlobAsync(GetBlobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBlobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBranch


        /// <summary>
        /// Returns information about a repository branch, including its name and the last commit
        /// ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBranch service method.</param>
        /// 
        /// <returns>The response from the GetBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBranch">REST API Reference for GetBranch Operation</seealso>
        public virtual GetBranchResponse GetBranch(GetBranchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBranchResponseUnmarshaller.Instance;

            return Invoke<GetBranchResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a repository branch, including its name and the last commit
        /// ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBranch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBranch">REST API Reference for GetBranch Operation</seealso>
        public virtual Task<GetBranchResponse> GetBranchAsync(GetBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBranchResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComment


        /// <summary>
        /// Returns the content of a comment made on a change, file, or commit in a repository.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// Reaction counts might include numbers from user identities who were deleted after
        /// the reaction was made. For a count of reactions from active identities, use GetCommentReactions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComment service method.</param>
        /// 
        /// <returns>The response from the GetComment service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDeletedException">
        /// This comment has already been deleted. You cannot edit or delete a deleted comment.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetComment">REST API Reference for GetComment Operation</seealso>
        public virtual GetCommentResponse GetComment(GetCommentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommentResponseUnmarshaller.Instance;

            return Invoke<GetCommentResponse>(request, options);
        }


        /// <summary>
        /// Returns the content of a comment made on a change, file, or commit in a repository.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// Reaction counts might include numbers from user identities who were deleted after
        /// the reaction was made. For a count of reactions from active identities, use GetCommentReactions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComment service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDeletedException">
        /// This comment has already been deleted. You cannot edit or delete a deleted comment.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetComment">REST API Reference for GetComment Operation</seealso>
        public virtual Task<GetCommentResponse> GetCommentAsync(GetCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCommentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCommentReactions


        /// <summary>
        /// Returns information about reactions to a specified comment ID. Reactions from users
        /// who have been deleted will not be included in the count.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommentReactions service method.</param>
        /// 
        /// <returns>The response from the GetCommentReactions service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDeletedException">
        /// This comment has already been deleted. You cannot edit or delete a deleted comment.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReactionUserArnException">
        /// The Amazon Resource Name (ARN) of the user or identity is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentReactions">REST API Reference for GetCommentReactions Operation</seealso>
        public virtual GetCommentReactionsResponse GetCommentReactions(GetCommentReactionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCommentReactionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommentReactionsResponseUnmarshaller.Instance;

            return Invoke<GetCommentReactionsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about reactions to a specified comment ID. Reactions from users
        /// who have been deleted will not be included in the count.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommentReactions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCommentReactions service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDeletedException">
        /// This comment has already been deleted. You cannot edit or delete a deleted comment.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReactionUserArnException">
        /// The Amazon Resource Name (ARN) of the user or identity is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentReactions">REST API Reference for GetCommentReactions Operation</seealso>
        public virtual Task<GetCommentReactionsResponse> GetCommentReactionsAsync(GetCommentReactionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCommentReactionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommentReactionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCommentReactionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCommentsForComparedCommit


        /// <summary>
        /// Returns information about comments made on the comparison between two commits.
        /// 
        ///  <note> 
        /// <para>
        /// Reaction counts might include numbers from user identities who were deleted after
        /// the reaction was made. For a count of reactions from active identities, use GetCommentReactions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommentsForComparedCommit service method.</param>
        /// 
        /// <returns>The response from the GetCommentsForComparedCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForComparedCommit">REST API Reference for GetCommentsForComparedCommit Operation</seealso>
        public virtual GetCommentsForComparedCommitResponse GetCommentsForComparedCommit(GetCommentsForComparedCommitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCommentsForComparedCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommentsForComparedCommitResponseUnmarshaller.Instance;

            return Invoke<GetCommentsForComparedCommitResponse>(request, options);
        }


        /// <summary>
        /// Returns information about comments made on the comparison between two commits.
        /// 
        ///  <note> 
        /// <para>
        /// Reaction counts might include numbers from user identities who were deleted after
        /// the reaction was made. For a count of reactions from active identities, use GetCommentReactions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommentsForComparedCommit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCommentsForComparedCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForComparedCommit">REST API Reference for GetCommentsForComparedCommit Operation</seealso>
        public virtual Task<GetCommentsForComparedCommitResponse> GetCommentsForComparedCommitAsync(GetCommentsForComparedCommitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCommentsForComparedCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommentsForComparedCommitResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCommentsForComparedCommitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCommentsForPullRequest


        /// <summary>
        /// Returns comments made on a pull request.
        /// 
        ///  <note> 
        /// <para>
        /// Reaction counts might include numbers from user identities who were deleted after
        /// the reaction was made. For a count of reactions from active identities, use GetCommentReactions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommentsForPullRequest service method.</param>
        /// 
        /// <returns>The response from the GetCommentsForPullRequest service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForPullRequest">REST API Reference for GetCommentsForPullRequest Operation</seealso>
        public virtual GetCommentsForPullRequestResponse GetCommentsForPullRequest(GetCommentsForPullRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCommentsForPullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommentsForPullRequestResponseUnmarshaller.Instance;

            return Invoke<GetCommentsForPullRequestResponse>(request, options);
        }


        /// <summary>
        /// Returns comments made on a pull request.
        /// 
        ///  <note> 
        /// <para>
        /// Reaction counts might include numbers from user identities who were deleted after
        /// the reaction was made. For a count of reactions from active identities, use GetCommentReactions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommentsForPullRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCommentsForPullRequest service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForPullRequest">REST API Reference for GetCommentsForPullRequest Operation</seealso>
        public virtual Task<GetCommentsForPullRequestResponse> GetCommentsForPullRequestAsync(GetCommentsForPullRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCommentsForPullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommentsForPullRequestResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCommentsForPullRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCommit


        /// <summary>
        /// Returns information about a commit, including commit message and committer information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommit service method.</param>
        /// 
        /// <returns>The response from the GetCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdDoesNotExistException">
        /// The specified commit ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommit">REST API Reference for GetCommit Operation</seealso>
        public virtual GetCommitResponse GetCommit(GetCommitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommitResponseUnmarshaller.Instance;

            return Invoke<GetCommitResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a commit, including commit message and committer information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdDoesNotExistException">
        /// The specified commit ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommit">REST API Reference for GetCommit Operation</seealso>
        public virtual Task<GetCommitResponse> GetCommitAsync(GetCommitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommitResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCommitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDifferences


        /// <summary>
        /// Returns information about the differences in a valid commit specifier (such as a branch,
        /// tag, HEAD, commit ID, or other fully qualified reference). Results can be limited
        /// to a specified path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDifferences service method.</param>
        /// 
        /// <returns>The response from the GetDifferences service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathDoesNotExistException">
        /// The specified path does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetDifferences">REST API Reference for GetDifferences Operation</seealso>
        public virtual GetDifferencesResponse GetDifferences(GetDifferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDifferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDifferencesResponseUnmarshaller.Instance;

            return Invoke<GetDifferencesResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the differences in a valid commit specifier (such as a branch,
        /// tag, HEAD, commit ID, or other fully qualified reference). Results can be limited
        /// to a specified path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDifferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDifferences service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathDoesNotExistException">
        /// The specified path does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetDifferences">REST API Reference for GetDifferences Operation</seealso>
        public virtual Task<GetDifferencesResponse> GetDifferencesAsync(GetDifferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDifferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDifferencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDifferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFile


        /// <summary>
        /// Returns the base-64 encoded contents of a specified file and its metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFile service method.</param>
        /// 
        /// <returns>The response from the GetFile service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileDoesNotExistException">
        /// The specified file does not exist. Verify that you have used the correct file name,
        /// full path, and extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileTooLargeException">
        /// The specified file exceeds the file size limit for CodeCommit. For more information
        /// about limits in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFile">REST API Reference for GetFile Operation</seealso>
        public virtual GetFileResponse GetFile(GetFileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFileResponseUnmarshaller.Instance;

            return Invoke<GetFileResponse>(request, options);
        }


        /// <summary>
        /// Returns the base-64 encoded contents of a specified file and its metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFile service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileDoesNotExistException">
        /// The specified file does not exist. Verify that you have used the correct file name,
        /// full path, and extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileTooLargeException">
        /// The specified file exceeds the file size limit for CodeCommit. For more information
        /// about limits in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFile">REST API Reference for GetFile Operation</seealso>
        public virtual Task<GetFileResponse> GetFileAsync(GetFileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFileResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFolder


        /// <summary>
        /// Returns the contents of a specified folder in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFolder service method.</param>
        /// 
        /// <returns>The response from the GetFolder service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderDoesNotExistException">
        /// The specified folder does not exist. Either the folder name is not correct, or you
        /// did not enter the full path to the folder.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFolder">REST API Reference for GetFolder Operation</seealso>
        public virtual GetFolderResponse GetFolder(GetFolderRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFolderResponseUnmarshaller.Instance;

            return Invoke<GetFolderResponse>(request, options);
        }


        /// <summary>
        /// Returns the contents of a specified folder in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFolder service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFolder service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderDoesNotExistException">
        /// The specified folder does not exist. Either the folder name is not correct, or you
        /// did not enter the full path to the folder.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFolder">REST API Reference for GetFolder Operation</seealso>
        public virtual Task<GetFolderResponse> GetFolderAsync(GetFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFolderResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetFolderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMergeCommit


        /// <summary>
        /// Returns information about a specified merge commit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMergeCommit service method.</param>
        /// 
        /// <returns>The response from the GetMergeCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeCommit">REST API Reference for GetMergeCommit Operation</seealso>
        public virtual GetMergeCommitResponse GetMergeCommit(GetMergeCommitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMergeCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMergeCommitResponseUnmarshaller.Instance;

            return Invoke<GetMergeCommitResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a specified merge commit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMergeCommit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMergeCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeCommit">REST API Reference for GetMergeCommit Operation</seealso>
        public virtual Task<GetMergeCommitResponse> GetMergeCommitAsync(GetMergeCommitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMergeCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMergeCommitResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMergeCommitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMergeConflicts


        /// <summary>
        /// Returns information about merge conflicts between the before and after commit IDs
        /// for a pull request in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMergeConflicts service method.</param>
        /// 
        /// <returns>The response from the GetMergeConflicts service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDestinationCommitSpecifierException">
        /// The destination commit specifier is not valid. You must provide a valid branch name,
        /// tag, or full commit ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxConflictFilesException">
        /// The specified value for the number of conflict files to return is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMergeOptionException">
        /// The specified merge option is not valid for this operation. Not all merge strategies
        /// are supported for all operations.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSourceCommitSpecifierException">
        /// The source commit specifier is not valid. You must provide a valid branch name, tag,
        /// or full commit ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MergeOptionRequiredException">
        /// A merge option or stategy is required, and none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeConflicts">REST API Reference for GetMergeConflicts Operation</seealso>
        public virtual GetMergeConflictsResponse GetMergeConflicts(GetMergeConflictsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMergeConflictsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMergeConflictsResponseUnmarshaller.Instance;

            return Invoke<GetMergeConflictsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about merge conflicts between the before and after commit IDs
        /// for a pull request in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMergeConflicts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMergeConflicts service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDestinationCommitSpecifierException">
        /// The destination commit specifier is not valid. You must provide a valid branch name,
        /// tag, or full commit ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxConflictFilesException">
        /// The specified value for the number of conflict files to return is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMergeOptionException">
        /// The specified merge option is not valid for this operation. Not all merge strategies
        /// are supported for all operations.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSourceCommitSpecifierException">
        /// The source commit specifier is not valid. You must provide a valid branch name, tag,
        /// or full commit ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MergeOptionRequiredException">
        /// A merge option or stategy is required, and none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeConflicts">REST API Reference for GetMergeConflicts Operation</seealso>
        public virtual Task<GetMergeConflictsResponse> GetMergeConflictsAsync(GetMergeConflictsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMergeConflictsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMergeConflictsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMergeConflictsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMergeOptions


        /// <summary>
        /// Returns information about the merge options available for merging two specified branches.
        /// For details about why a merge option is not available, use GetMergeConflicts or DescribeMergeConflicts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMergeOptions service method.</param>
        /// 
        /// <returns>The response from the GetMergeOptions service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeOptions">REST API Reference for GetMergeOptions Operation</seealso>
        public virtual GetMergeOptionsResponse GetMergeOptions(GetMergeOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMergeOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMergeOptionsResponseUnmarshaller.Instance;

            return Invoke<GetMergeOptionsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the merge options available for merging two specified branches.
        /// For details about why a merge option is not available, use GetMergeConflicts or DescribeMergeConflicts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMergeOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMergeOptions service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeOptions">REST API Reference for GetMergeOptions Operation</seealso>
        public virtual Task<GetMergeOptionsResponse> GetMergeOptionsAsync(GetMergeOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMergeOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMergeOptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMergeOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPullRequest


        /// <summary>
        /// Gets information about a pull request in a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPullRequest service method.</param>
        /// 
        /// <returns>The response from the GetPullRequest service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequest">REST API Reference for GetPullRequest Operation</seealso>
        public virtual GetPullRequestResponse GetPullRequest(GetPullRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPullRequestResponseUnmarshaller.Instance;

            return Invoke<GetPullRequestResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a pull request in a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPullRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPullRequest service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequest">REST API Reference for GetPullRequest Operation</seealso>
        public virtual Task<GetPullRequestResponse> GetPullRequestAsync(GetPullRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPullRequestResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPullRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPullRequestApprovalStates


        /// <summary>
        /// Gets information about the approval states for a specified pull request. Approval
        /// states only apply to pull requests that have one or more approval rules applied to
        /// them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPullRequestApprovalStates service method.</param>
        /// 
        /// <returns>The response from the GetPullRequestApprovalStates service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequestApprovalStates">REST API Reference for GetPullRequestApprovalStates Operation</seealso>
        public virtual GetPullRequestApprovalStatesResponse GetPullRequestApprovalStates(GetPullRequestApprovalStatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPullRequestApprovalStatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPullRequestApprovalStatesResponseUnmarshaller.Instance;

            return Invoke<GetPullRequestApprovalStatesResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the approval states for a specified pull request. Approval
        /// states only apply to pull requests that have one or more approval rules applied to
        /// them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPullRequestApprovalStates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPullRequestApprovalStates service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequestApprovalStates">REST API Reference for GetPullRequestApprovalStates Operation</seealso>
        public virtual Task<GetPullRequestApprovalStatesResponse> GetPullRequestApprovalStatesAsync(GetPullRequestApprovalStatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPullRequestApprovalStatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPullRequestApprovalStatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPullRequestApprovalStatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPullRequestOverrideState


        /// <summary>
        /// Returns information about whether approval rules have been set aside (overridden)
        /// for a pull request, and if so, the Amazon Resource Name (ARN) of the user or identity
        /// that overrode the rules and their requirements for the pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPullRequestOverrideState service method.</param>
        /// 
        /// <returns>The response from the GetPullRequestOverrideState service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequestOverrideState">REST API Reference for GetPullRequestOverrideState Operation</seealso>
        public virtual GetPullRequestOverrideStateResponse GetPullRequestOverrideState(GetPullRequestOverrideStateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPullRequestOverrideStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPullRequestOverrideStateResponseUnmarshaller.Instance;

            return Invoke<GetPullRequestOverrideStateResponse>(request, options);
        }


        /// <summary>
        /// Returns information about whether approval rules have been set aside (overridden)
        /// for a pull request, and if so, the Amazon Resource Name (ARN) of the user or identity
        /// that overrode the rules and their requirements for the pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPullRequestOverrideState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPullRequestOverrideState service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequestOverrideState">REST API Reference for GetPullRequestOverrideState Operation</seealso>
        public virtual Task<GetPullRequestOverrideStateResponse> GetPullRequestOverrideStateAsync(GetPullRequestOverrideStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPullRequestOverrideStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPullRequestOverrideStateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPullRequestOverrideStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRepository


        /// <summary>
        /// Returns information about a repository.
        /// 
        ///  <note> 
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a webpage can expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a webpage.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepository service method.</param>
        /// 
        /// <returns>The response from the GetRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepository">REST API Reference for GetRepository Operation</seealso>
        public virtual GetRepositoryResponse GetRepository(GetRepositoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryResponseUnmarshaller.Instance;

            return Invoke<GetRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a repository.
        /// 
        ///  <note> 
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a webpage can expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a webpage.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepository">REST API Reference for GetRepository Operation</seealso>
        public virtual Task<GetRepositoryResponse> GetRepositoryAsync(GetRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRepositoryTriggers


        /// <summary>
        /// Gets information about triggers configured for a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryTriggers service method.</param>
        /// 
        /// <returns>The response from the GetRepositoryTriggers service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepositoryTriggers">REST API Reference for GetRepositoryTriggers Operation</seealso>
        public virtual GetRepositoryTriggersResponse GetRepositoryTriggers(GetRepositoryTriggersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRepositoryTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryTriggersResponseUnmarshaller.Instance;

            return Invoke<GetRepositoryTriggersResponse>(request, options);
        }


        /// <summary>
        /// Gets information about triggers configured for a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryTriggers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRepositoryTriggers service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepositoryTriggers">REST API Reference for GetRepositoryTriggers Operation</seealso>
        public virtual Task<GetRepositoryTriggersResponse> GetRepositoryTriggersAsync(GetRepositoryTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRepositoryTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryTriggersResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRepositoryTriggersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApprovalRuleTemplates


        /// <summary>
        /// Lists all approval rule templates in the specified Amazon Web Services Region in your
        /// Amazon Web Services account. If an Amazon Web Services Region is not specified, the
        /// Amazon Web Services Region where you are signed in is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApprovalRuleTemplates service method.</param>
        /// 
        /// <returns>The response from the ListApprovalRuleTemplates service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListApprovalRuleTemplates">REST API Reference for ListApprovalRuleTemplates Operation</seealso>
        public virtual ListApprovalRuleTemplatesResponse ListApprovalRuleTemplates(ListApprovalRuleTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApprovalRuleTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApprovalRuleTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListApprovalRuleTemplatesResponse>(request, options);
        }


        /// <summary>
        /// Lists all approval rule templates in the specified Amazon Web Services Region in your
        /// Amazon Web Services account. If an Amazon Web Services Region is not specified, the
        /// Amazon Web Services Region where you are signed in is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApprovalRuleTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApprovalRuleTemplates service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListApprovalRuleTemplates">REST API Reference for ListApprovalRuleTemplates Operation</seealso>
        public virtual Task<ListApprovalRuleTemplatesResponse> ListApprovalRuleTemplatesAsync(ListApprovalRuleTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApprovalRuleTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApprovalRuleTemplatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListApprovalRuleTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssociatedApprovalRuleTemplatesForRepository


        /// <summary>
        /// Lists all approval rule templates that are associated with a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedApprovalRuleTemplatesForRepository service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedApprovalRuleTemplatesForRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListAssociatedApprovalRuleTemplatesForRepository">REST API Reference for ListAssociatedApprovalRuleTemplatesForRepository Operation</seealso>
        public virtual ListAssociatedApprovalRuleTemplatesForRepositoryResponse ListAssociatedApprovalRuleTemplatesForRepository(ListAssociatedApprovalRuleTemplatesForRepositoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedApprovalRuleTemplatesForRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedApprovalRuleTemplatesForRepositoryResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedApprovalRuleTemplatesForRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Lists all approval rule templates that are associated with a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedApprovalRuleTemplatesForRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociatedApprovalRuleTemplatesForRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListAssociatedApprovalRuleTemplatesForRepository">REST API Reference for ListAssociatedApprovalRuleTemplatesForRepository Operation</seealso>
        public virtual Task<ListAssociatedApprovalRuleTemplatesForRepositoryResponse> ListAssociatedApprovalRuleTemplatesForRepositoryAsync(ListAssociatedApprovalRuleTemplatesForRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedApprovalRuleTemplatesForRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedApprovalRuleTemplatesForRepositoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAssociatedApprovalRuleTemplatesForRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBranches


        /// <summary>
        /// Gets information about one or more branches in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBranches service method.</param>
        /// 
        /// <returns>The response from the ListBranches service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListBranches">REST API Reference for ListBranches Operation</seealso>
        public virtual ListBranchesResponse ListBranches(ListBranchesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBranchesResponseUnmarshaller.Instance;

            return Invoke<ListBranchesResponse>(request, options);
        }


        /// <summary>
        /// Gets information about one or more branches in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBranches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBranches service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListBranches">REST API Reference for ListBranches Operation</seealso>
        public virtual Task<ListBranchesResponse> ListBranchesAsync(ListBranchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBranchesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListBranchesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFileCommitHistory


        /// <summary>
        /// Retrieves a list of commits and changes to a specified file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFileCommitHistory service method.</param>
        /// 
        /// <returns>The response from the ListFileCommitHistory service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListFileCommitHistory">REST API Reference for ListFileCommitHistory Operation</seealso>
        public virtual ListFileCommitHistoryResponse ListFileCommitHistory(ListFileCommitHistoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFileCommitHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFileCommitHistoryResponseUnmarshaller.Instance;

            return Invoke<ListFileCommitHistoryResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of commits and changes to a specified file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFileCommitHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFileCommitHistory service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListFileCommitHistory">REST API Reference for ListFileCommitHistory Operation</seealso>
        public virtual Task<ListFileCommitHistoryResponse> ListFileCommitHistoryAsync(ListFileCommitHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFileCommitHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFileCommitHistoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFileCommitHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPullRequests


        /// <summary>
        /// Returns a list of pull requests for a specified repository. The return list can be
        /// refined by pull request status or pull request author ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPullRequests service method.</param>
        /// 
        /// <returns>The response from the ListPullRequests service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.AuthorDoesNotExistException">
        /// The specified Amazon Resource Name (ARN) does not exist in the Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidAuthorArnException">
        /// The Amazon Resource Name (ARN) is not valid. Make sure that you have provided the
        /// full ARN for the author of the pull request, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestStatusException">
        /// The pull request status is not valid. The only valid values are <c>OPEN</c> and <c>CLOSED</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListPullRequests">REST API Reference for ListPullRequests Operation</seealso>
        public virtual ListPullRequestsResponse ListPullRequests(ListPullRequestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPullRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPullRequestsResponseUnmarshaller.Instance;

            return Invoke<ListPullRequestsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of pull requests for a specified repository. The return list can be
        /// refined by pull request status or pull request author ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPullRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPullRequests service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.AuthorDoesNotExistException">
        /// The specified Amazon Resource Name (ARN) does not exist in the Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidAuthorArnException">
        /// The Amazon Resource Name (ARN) is not valid. Make sure that you have provided the
        /// full ARN for the author of the pull request, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestStatusException">
        /// The pull request status is not valid. The only valid values are <c>OPEN</c> and <c>CLOSED</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListPullRequests">REST API Reference for ListPullRequests Operation</seealso>
        public virtual Task<ListPullRequestsResponse> ListPullRequestsAsync(ListPullRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPullRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPullRequestsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPullRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRepositories


        /// <summary>
        /// Gets information about one or more repositories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositories service method.</param>
        /// 
        /// <returns>The response from the ListRepositories service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidOrderException">
        /// The specified sort order is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSortByException">
        /// The specified sort by value is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListRepositories">REST API Reference for ListRepositories Operation</seealso>
        public virtual ListRepositoriesResponse ListRepositories(ListRepositoriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoriesResponseUnmarshaller.Instance;

            return Invoke<ListRepositoriesResponse>(request, options);
        }


        /// <summary>
        /// Gets information about one or more repositories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRepositories service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidOrderException">
        /// The specified sort order is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSortByException">
        /// The specified sort by value is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListRepositories">REST API Reference for ListRepositories Operation</seealso>
        public virtual Task<ListRepositoriesResponse> ListRepositoriesAsync(ListRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRepositoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRepositoriesForApprovalRuleTemplate


        /// <summary>
        /// Lists all repositories associated with the specified approval rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoriesForApprovalRuleTemplate service method.</param>
        /// 
        /// <returns>The response from the ListRepositoriesForApprovalRuleTemplate service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListRepositoriesForApprovalRuleTemplate">REST API Reference for ListRepositoriesForApprovalRuleTemplate Operation</seealso>
        public virtual ListRepositoriesForApprovalRuleTemplateResponse ListRepositoriesForApprovalRuleTemplate(ListRepositoriesForApprovalRuleTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRepositoriesForApprovalRuleTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoriesForApprovalRuleTemplateResponseUnmarshaller.Instance;

            return Invoke<ListRepositoriesForApprovalRuleTemplateResponse>(request, options);
        }


        /// <summary>
        /// Lists all repositories associated with the specified approval rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoriesForApprovalRuleTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRepositoriesForApprovalRuleTemplate service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListRepositoriesForApprovalRuleTemplate">REST API Reference for ListRepositoriesForApprovalRuleTemplate Operation</seealso>
        public virtual Task<ListRepositoriesForApprovalRuleTemplateResponse> ListRepositoriesForApprovalRuleTemplateAsync(ListRepositoriesForApprovalRuleTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRepositoriesForApprovalRuleTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoriesForApprovalRuleTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRepositoriesForApprovalRuleTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets information about Amazon Web Servicestags for a specified Amazon Resource Name
        /// (ARN) in CodeCommit. For a list of valid resources in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the<i> CodeCommit User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidResourceArnException">
        /// The value for the resource ARN is not valid. For more information about resources
        /// in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ResourceArnRequiredException">
        /// A valid Amazon Resource Name (ARN) for an CodeCommit resource is required. For a list
        /// of valid resources in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the CodeCommit User Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Gets information about Amazon Web Servicestags for a specified Amazon Resource Name
        /// (ARN) in CodeCommit. For a list of valid resources in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the<i> CodeCommit User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidResourceArnException">
        /// The value for the resource ARN is not valid. For more information about resources
        /// in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ResourceArnRequiredException">
        /// A valid Amazon Resource Name (ARN) for an CodeCommit resource is required. For a list
        /// of valid resources in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the CodeCommit User Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MergeBranchesByFastForward


        /// <summary>
        /// Merges two branches using the fast-forward merge strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeBranchesByFastForward service method.</param>
        /// 
        /// <returns>The response from the MergeBranchesByFastForward service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetBranchException">
        /// The specified target branch is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesByFastForward">REST API Reference for MergeBranchesByFastForward Operation</seealso>
        public virtual MergeBranchesByFastForwardResponse MergeBranchesByFastForward(MergeBranchesByFastForwardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MergeBranchesByFastForwardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeBranchesByFastForwardResponseUnmarshaller.Instance;

            return Invoke<MergeBranchesByFastForwardResponse>(request, options);
        }


        /// <summary>
        /// Merges two branches using the fast-forward merge strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeBranchesByFastForward service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MergeBranchesByFastForward service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetBranchException">
        /// The specified target branch is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesByFastForward">REST API Reference for MergeBranchesByFastForward Operation</seealso>
        public virtual Task<MergeBranchesByFastForwardResponse> MergeBranchesByFastForwardAsync(MergeBranchesByFastForwardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MergeBranchesByFastForwardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeBranchesByFastForwardResponseUnmarshaller.Instance;
            
            return InvokeAsync<MergeBranchesByFastForwardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MergeBranchesBySquash


        /// <summary>
        /// Merges two branches using the squash merge strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeBranchesBySquash service method.</param>
        /// 
        /// <returns>The response from the MergeBranchesBySquash service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileModeRequiredException">
        /// The commit cannot be created because no file mode has been specified. A file mode
        /// is required to update mode permissions for a file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetBranchException">
        /// The specified target branch is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesBySquash">REST API Reference for MergeBranchesBySquash Operation</seealso>
        public virtual MergeBranchesBySquashResponse MergeBranchesBySquash(MergeBranchesBySquashRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MergeBranchesBySquashRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeBranchesBySquashResponseUnmarshaller.Instance;

            return Invoke<MergeBranchesBySquashResponse>(request, options);
        }


        /// <summary>
        /// Merges two branches using the squash merge strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeBranchesBySquash service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MergeBranchesBySquash service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileModeRequiredException">
        /// The commit cannot be created because no file mode has been specified. A file mode
        /// is required to update mode permissions for a file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetBranchException">
        /// The specified target branch is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesBySquash">REST API Reference for MergeBranchesBySquash Operation</seealso>
        public virtual Task<MergeBranchesBySquashResponse> MergeBranchesBySquashAsync(MergeBranchesBySquashRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MergeBranchesBySquashRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeBranchesBySquashResponseUnmarshaller.Instance;
            
            return InvokeAsync<MergeBranchesBySquashResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MergeBranchesByThreeWay


        /// <summary>
        /// Merges two specified branches using the three-way merge strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeBranchesByThreeWay service method.</param>
        /// 
        /// <returns>The response from the MergeBranchesByThreeWay service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileModeRequiredException">
        /// The commit cannot be created because no file mode has been specified. A file mode
        /// is required to update mode permissions for a file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetBranchException">
        /// The specified target branch is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesByThreeWay">REST API Reference for MergeBranchesByThreeWay Operation</seealso>
        public virtual MergeBranchesByThreeWayResponse MergeBranchesByThreeWay(MergeBranchesByThreeWayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MergeBranchesByThreeWayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeBranchesByThreeWayResponseUnmarshaller.Instance;

            return Invoke<MergeBranchesByThreeWayResponse>(request, options);
        }


        /// <summary>
        /// Merges two specified branches using the three-way merge strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeBranchesByThreeWay service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MergeBranchesByThreeWay service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileModeRequiredException">
        /// The commit cannot be created because no file mode has been specified. A file mode
        /// is required to update mode permissions for a file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetBranchException">
        /// The specified target branch is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesByThreeWay">REST API Reference for MergeBranchesByThreeWay Operation</seealso>
        public virtual Task<MergeBranchesByThreeWayResponse> MergeBranchesByThreeWayAsync(MergeBranchesByThreeWayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MergeBranchesByThreeWayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergeBranchesByThreeWayResponseUnmarshaller.Instance;
            
            return InvokeAsync<MergeBranchesByThreeWayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MergePullRequestByFastForward


        /// <summary>
        /// Attempts to merge the source commit of a pull request into the specified destination
        /// branch for that pull request at the specified commit using the fast-forward merge
        /// strategy. If the merge is successful, it closes the pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestByFastForward service method.</param>
        /// 
        /// <returns>The response from the MergePullRequestByFastForward service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestApprovalRulesNotSatisfiedException">
        /// The pull request cannot be merged because one or more approval rules applied to the
        /// pull request have conditions that have not been met.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReferenceDoesNotExistException">
        /// The specified reference does not exist. You must provide a full commit ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipOfSourceReferenceIsDifferentException">
        /// The tip of the source branch in the destination repository does not match the tip
        /// of the source branch specified in your request. The pull request might have been updated.
        /// Make sure that you have the latest changes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestByFastForward">REST API Reference for MergePullRequestByFastForward Operation</seealso>
        public virtual MergePullRequestByFastForwardResponse MergePullRequestByFastForward(MergePullRequestByFastForwardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MergePullRequestByFastForwardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergePullRequestByFastForwardResponseUnmarshaller.Instance;

            return Invoke<MergePullRequestByFastForwardResponse>(request, options);
        }


        /// <summary>
        /// Attempts to merge the source commit of a pull request into the specified destination
        /// branch for that pull request at the specified commit using the fast-forward merge
        /// strategy. If the merge is successful, it closes the pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestByFastForward service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MergePullRequestByFastForward service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestApprovalRulesNotSatisfiedException">
        /// The pull request cannot be merged because one or more approval rules applied to the
        /// pull request have conditions that have not been met.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReferenceDoesNotExistException">
        /// The specified reference does not exist. You must provide a full commit ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipOfSourceReferenceIsDifferentException">
        /// The tip of the source branch in the destination repository does not match the tip
        /// of the source branch specified in your request. The pull request might have been updated.
        /// Make sure that you have the latest changes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestByFastForward">REST API Reference for MergePullRequestByFastForward Operation</seealso>
        public virtual Task<MergePullRequestByFastForwardResponse> MergePullRequestByFastForwardAsync(MergePullRequestByFastForwardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MergePullRequestByFastForwardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergePullRequestByFastForwardResponseUnmarshaller.Instance;
            
            return InvokeAsync<MergePullRequestByFastForwardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MergePullRequestBySquash


        /// <summary>
        /// Attempts to merge the source commit of a pull request into the specified destination
        /// branch for that pull request at the specified commit using the squash merge strategy.
        /// If the merge is successful, it closes the pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestBySquash service method.</param>
        /// 
        /// <returns>The response from the MergePullRequestBySquash service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestApprovalRulesNotSatisfiedException">
        /// The pull request cannot be merged because one or more approval rules applied to the
        /// pull request have conditions that have not been met.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipOfSourceReferenceIsDifferentException">
        /// The tip of the source branch in the destination repository does not match the tip
        /// of the source branch specified in your request. The pull request might have been updated.
        /// Make sure that you have the latest changes.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestBySquash">REST API Reference for MergePullRequestBySquash Operation</seealso>
        public virtual MergePullRequestBySquashResponse MergePullRequestBySquash(MergePullRequestBySquashRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MergePullRequestBySquashRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergePullRequestBySquashResponseUnmarshaller.Instance;

            return Invoke<MergePullRequestBySquashResponse>(request, options);
        }


        /// <summary>
        /// Attempts to merge the source commit of a pull request into the specified destination
        /// branch for that pull request at the specified commit using the squash merge strategy.
        /// If the merge is successful, it closes the pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestBySquash service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MergePullRequestBySquash service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestApprovalRulesNotSatisfiedException">
        /// The pull request cannot be merged because one or more approval rules applied to the
        /// pull request have conditions that have not been met.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipOfSourceReferenceIsDifferentException">
        /// The tip of the source branch in the destination repository does not match the tip
        /// of the source branch specified in your request. The pull request might have been updated.
        /// Make sure that you have the latest changes.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestBySquash">REST API Reference for MergePullRequestBySquash Operation</seealso>
        public virtual Task<MergePullRequestBySquashResponse> MergePullRequestBySquashAsync(MergePullRequestBySquashRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MergePullRequestBySquashRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergePullRequestBySquashResponseUnmarshaller.Instance;
            
            return InvokeAsync<MergePullRequestBySquashResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MergePullRequestByThreeWay


        /// <summary>
        /// Attempts to merge the source commit of a pull request into the specified destination
        /// branch for that pull request at the specified commit using the three-way merge strategy.
        /// If the merge is successful, it closes the pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestByThreeWay service method.</param>
        /// 
        /// <returns>The response from the MergePullRequestByThreeWay service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestApprovalRulesNotSatisfiedException">
        /// The pull request cannot be merged because one or more approval rules applied to the
        /// pull request have conditions that have not been met.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipOfSourceReferenceIsDifferentException">
        /// The tip of the source branch in the destination repository does not match the tip
        /// of the source branch specified in your request. The pull request might have been updated.
        /// Make sure that you have the latest changes.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestByThreeWay">REST API Reference for MergePullRequestByThreeWay Operation</seealso>
        public virtual MergePullRequestByThreeWayResponse MergePullRequestByThreeWay(MergePullRequestByThreeWayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MergePullRequestByThreeWayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergePullRequestByThreeWayResponseUnmarshaller.Instance;

            return Invoke<MergePullRequestByThreeWayResponse>(request, options);
        }


        /// <summary>
        /// Attempts to merge the source commit of a pull request into the specified destination
        /// branch for that pull request at the specified commit using the three-way merge strategy.
        /// If the merge is successful, it closes the pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestByThreeWay service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MergePullRequestByThreeWay service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestApprovalRulesNotSatisfiedException">
        /// The pull request cannot be merged because one or more approval rules applied to the
        /// pull request have conditions that have not been met.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipOfSourceReferenceIsDifferentException">
        /// The tip of the source branch in the destination repository does not match the tip
        /// of the source branch specified in your request. The pull request might have been updated.
        /// Make sure that you have the latest changes.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <c>git diff</c> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestByThreeWay">REST API Reference for MergePullRequestByThreeWay Operation</seealso>
        public virtual Task<MergePullRequestByThreeWayResponse> MergePullRequestByThreeWayAsync(MergePullRequestByThreeWayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = MergePullRequestByThreeWayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergePullRequestByThreeWayResponseUnmarshaller.Instance;
            
            return InvokeAsync<MergePullRequestByThreeWayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  OverridePullRequestApprovalRules


        /// <summary>
        /// Sets aside (overrides) all approval rule requirements for a specified pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OverridePullRequestApprovalRules service method.</param>
        /// 
        /// <returns>The response from the OverridePullRequestApprovalRules service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidOverrideStatusException">
        /// The override status is not valid. Valid statuses are OVERRIDE and REVOKE.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.OverrideAlreadySetException">
        /// The pull request has already had its approval rules set to override.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.OverrideStatusRequiredException">
        /// An override status is required, but no value was provided. Valid values include OVERRIDE
        /// and REVOKE.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionNotCurrentException">
        /// The revision ID provided in the request does not match the current revision ID. Use
        /// GetPullRequest to retrieve the current revision ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/OverridePullRequestApprovalRules">REST API Reference for OverridePullRequestApprovalRules Operation</seealso>
        public virtual OverridePullRequestApprovalRulesResponse OverridePullRequestApprovalRules(OverridePullRequestApprovalRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OverridePullRequestApprovalRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OverridePullRequestApprovalRulesResponseUnmarshaller.Instance;

            return Invoke<OverridePullRequestApprovalRulesResponse>(request, options);
        }


        /// <summary>
        /// Sets aside (overrides) all approval rule requirements for a specified pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OverridePullRequestApprovalRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OverridePullRequestApprovalRules service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidOverrideStatusException">
        /// The override status is not valid. Valid statuses are OVERRIDE and REVOKE.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.OverrideAlreadySetException">
        /// The pull request has already had its approval rules set to override.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.OverrideStatusRequiredException">
        /// An override status is required, but no value was provided. Valid values include OVERRIDE
        /// and REVOKE.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionNotCurrentException">
        /// The revision ID provided in the request does not match the current revision ID. Use
        /// GetPullRequest to retrieve the current revision ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/OverridePullRequestApprovalRules">REST API Reference for OverridePullRequestApprovalRules Operation</seealso>
        public virtual Task<OverridePullRequestApprovalRulesResponse> OverridePullRequestApprovalRulesAsync(OverridePullRequestApprovalRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = OverridePullRequestApprovalRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = OverridePullRequestApprovalRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<OverridePullRequestApprovalRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PostCommentForComparedCommit


        /// <summary>
        /// Posts a comment on the comparison between two commits.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostCommentForComparedCommit service method.</param>
        /// 
        /// <returns>The response from the PostCommentForComparedCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BeforeCommitIdAndAfterCommitIdAreSameException">
        /// The before commit ID and the after commit ID are the same, which is not valid. The
        /// before commit ID and the after commit ID must be different commit IDs.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ClientRequestTokenRequiredException">
        /// A client request token is required. A client request token is an unique, client-generated
        /// idempotency token that, when provided in a request, ensures the request cannot be
        /// repeated with a changed parameter. If a request is received with the same parameters
        /// and a token is included, the request returns information about the initial request
        /// that used that token.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentRequiredException">
        /// The comment is empty. You must provide some content for a comment. The content cannot
        /// be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentSizeLimitExceededException">
        /// The comment is too large. Comments are limited to 10,240 characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.IdempotencyParameterMismatchException">
        /// The client request token is not valid. Either the token is not in a valid format,
        /// or the token has been used in a previous request and cannot be reused.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileLocationException">
        /// The location of the file is not valid. Make sure that you include the file name and
        /// extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFilePositionException">
        /// The position is not valid. Make sure that the line number exists in the version of
        /// the file you want to comment on.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRelativeFileVersionEnumException">
        /// Either the enum is not in a valid format, or the specified file version enum is not
        /// valid in respect to the current file version.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathDoesNotExistException">
        /// The specified path does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForComparedCommit">REST API Reference for PostCommentForComparedCommit Operation</seealso>
        public virtual PostCommentForComparedCommitResponse PostCommentForComparedCommit(PostCommentForComparedCommitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostCommentForComparedCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostCommentForComparedCommitResponseUnmarshaller.Instance;

            return Invoke<PostCommentForComparedCommitResponse>(request, options);
        }


        /// <summary>
        /// Posts a comment on the comparison between two commits.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostCommentForComparedCommit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PostCommentForComparedCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BeforeCommitIdAndAfterCommitIdAreSameException">
        /// The before commit ID and the after commit ID are the same, which is not valid. The
        /// before commit ID and the after commit ID must be different commit IDs.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ClientRequestTokenRequiredException">
        /// A client request token is required. A client request token is an unique, client-generated
        /// idempotency token that, when provided in a request, ensures the request cannot be
        /// repeated with a changed parameter. If a request is received with the same parameters
        /// and a token is included, the request returns information about the initial request
        /// that used that token.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentRequiredException">
        /// The comment is empty. You must provide some content for a comment. The content cannot
        /// be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentSizeLimitExceededException">
        /// The comment is too large. Comments are limited to 10,240 characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.IdempotencyParameterMismatchException">
        /// The client request token is not valid. Either the token is not in a valid format,
        /// or the token has been used in a previous request and cannot be reused.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileLocationException">
        /// The location of the file is not valid. Make sure that you include the file name and
        /// extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFilePositionException">
        /// The position is not valid. Make sure that the line number exists in the version of
        /// the file you want to comment on.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRelativeFileVersionEnumException">
        /// Either the enum is not in a valid format, or the specified file version enum is not
        /// valid in respect to the current file version.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathDoesNotExistException">
        /// The specified path does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForComparedCommit">REST API Reference for PostCommentForComparedCommit Operation</seealso>
        public virtual Task<PostCommentForComparedCommitResponse> PostCommentForComparedCommitAsync(PostCommentForComparedCommitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostCommentForComparedCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostCommentForComparedCommitResponseUnmarshaller.Instance;
            
            return InvokeAsync<PostCommentForComparedCommitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PostCommentForPullRequest


        /// <summary>
        /// Posts a comment on a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostCommentForPullRequest service method.</param>
        /// 
        /// <returns>The response from the PostCommentForPullRequest service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BeforeCommitIdAndAfterCommitIdAreSameException">
        /// The before commit ID and the after commit ID are the same, which is not valid. The
        /// before commit ID and the after commit ID must be different commit IDs.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ClientRequestTokenRequiredException">
        /// A client request token is required. A client request token is an unique, client-generated
        /// idempotency token that, when provided in a request, ensures the request cannot be
        /// repeated with a changed parameter. If a request is received with the same parameters
        /// and a token is included, the request returns information about the initial request
        /// that used that token.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentRequiredException">
        /// The comment is empty. You must provide some content for a comment. The content cannot
        /// be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentSizeLimitExceededException">
        /// The comment is too large. Comments are limited to 10,240 characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.IdempotencyParameterMismatchException">
        /// The client request token is not valid. Either the token is not in a valid format,
        /// or the token has been used in a previous request and cannot be reused.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileLocationException">
        /// The location of the file is not valid. Make sure that you include the file name and
        /// extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFilePositionException">
        /// The position is not valid. Make sure that the line number exists in the version of
        /// the file you want to comment on.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRelativeFileVersionEnumException">
        /// Either the enum is not in a valid format, or the specified file version enum is not
        /// valid in respect to the current file version.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathDoesNotExistException">
        /// The specified path does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForPullRequest">REST API Reference for PostCommentForPullRequest Operation</seealso>
        public virtual PostCommentForPullRequestResponse PostCommentForPullRequest(PostCommentForPullRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostCommentForPullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostCommentForPullRequestResponseUnmarshaller.Instance;

            return Invoke<PostCommentForPullRequestResponse>(request, options);
        }


        /// <summary>
        /// Posts a comment on a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostCommentForPullRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PostCommentForPullRequest service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BeforeCommitIdAndAfterCommitIdAreSameException">
        /// The before commit ID and the after commit ID are the same, which is not valid. The
        /// before commit ID and the after commit ID must be different commit IDs.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ClientRequestTokenRequiredException">
        /// A client request token is required. A client request token is an unique, client-generated
        /// idempotency token that, when provided in a request, ensures the request cannot be
        /// repeated with a changed parameter. If a request is received with the same parameters
        /// and a token is included, the request returns information about the initial request
        /// that used that token.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentRequiredException">
        /// The comment is empty. You must provide some content for a comment. The content cannot
        /// be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentSizeLimitExceededException">
        /// The comment is too large. Comments are limited to 10,240 characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.IdempotencyParameterMismatchException">
        /// The client request token is not valid. Either the token is not in a valid format,
        /// or the token has been used in a previous request and cannot be reused.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileLocationException">
        /// The location of the file is not valid. Make sure that you include the file name and
        /// extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFilePositionException">
        /// The position is not valid. Make sure that the line number exists in the version of
        /// the file you want to comment on.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRelativeFileVersionEnumException">
        /// Either the enum is not in a valid format, or the specified file version enum is not
        /// valid in respect to the current file version.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathDoesNotExistException">
        /// The specified path does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForPullRequest">REST API Reference for PostCommentForPullRequest Operation</seealso>
        public virtual Task<PostCommentForPullRequestResponse> PostCommentForPullRequestAsync(PostCommentForPullRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostCommentForPullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostCommentForPullRequestResponseUnmarshaller.Instance;
            
            return InvokeAsync<PostCommentForPullRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PostCommentReply


        /// <summary>
        /// Posts a comment in reply to an existing comment on a comparison between commits or
        /// a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostCommentReply service method.</param>
        /// 
        /// <returns>The response from the PostCommentReply service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ClientRequestTokenRequiredException">
        /// A client request token is required. A client request token is an unique, client-generated
        /// idempotency token that, when provided in a request, ensures the request cannot be
        /// repeated with a changed parameter. If a request is received with the same parameters
        /// and a token is included, the request returns information about the initial request
        /// that used that token.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentRequiredException">
        /// The comment is empty. You must provide some content for a comment. The content cannot
        /// be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentSizeLimitExceededException">
        /// The comment is too large. Comments are limited to 10,240 characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.IdempotencyParameterMismatchException">
        /// The client request token is not valid. Either the token is not in a valid format,
        /// or the token has been used in a previous request and cannot be reused.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentReply">REST API Reference for PostCommentReply Operation</seealso>
        public virtual PostCommentReplyResponse PostCommentReply(PostCommentReplyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostCommentReplyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostCommentReplyResponseUnmarshaller.Instance;

            return Invoke<PostCommentReplyResponse>(request, options);
        }


        /// <summary>
        /// Posts a comment in reply to an existing comment on a comparison between commits or
        /// a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostCommentReply service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PostCommentReply service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ClientRequestTokenRequiredException">
        /// A client request token is required. A client request token is an unique, client-generated
        /// idempotency token that, when provided in a request, ensures the request cannot be
        /// repeated with a changed parameter. If a request is received with the same parameters
        /// and a token is included, the request returns information about the initial request
        /// that used that token.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentRequiredException">
        /// The comment is empty. You must provide some content for a comment. The content cannot
        /// be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentSizeLimitExceededException">
        /// The comment is too large. Comments are limited to 10,240 characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.IdempotencyParameterMismatchException">
        /// The client request token is not valid. Either the token is not in a valid format,
        /// or the token has been used in a previous request and cannot be reused.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentReply">REST API Reference for PostCommentReply Operation</seealso>
        public virtual Task<PostCommentReplyResponse> PostCommentReplyAsync(PostCommentReplyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostCommentReplyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostCommentReplyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PostCommentReplyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutCommentReaction


        /// <summary>
        /// Adds or updates a reaction to a specified comment for the user whose identity is used
        /// to make the request. You can only add or update a reaction for yourself. You cannot
        /// add, modify, or delete a reaction for another user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCommentReaction service method.</param>
        /// 
        /// <returns>The response from the PutCommentReaction service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDeletedException">
        /// This comment has already been deleted. You cannot edit or delete a deleted comment.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReactionValueException">
        /// The value of the reaction is not valid. For more information, see the <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">CodeCommit
        /// User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReactionLimitExceededException">
        /// The number of reactions has been exceeded. Reactions are limited to one reaction per
        /// user for each individual comment ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReactionValueRequiredException">
        /// A reaction value is required.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutCommentReaction">REST API Reference for PutCommentReaction Operation</seealso>
        public virtual PutCommentReactionResponse PutCommentReaction(PutCommentReactionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutCommentReactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCommentReactionResponseUnmarshaller.Instance;

            return Invoke<PutCommentReactionResponse>(request, options);
        }


        /// <summary>
        /// Adds or updates a reaction to a specified comment for the user whose identity is used
        /// to make the request. You can only add or update a reaction for yourself. You cannot
        /// add, modify, or delete a reaction for another user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCommentReaction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutCommentReaction service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDeletedException">
        /// This comment has already been deleted. You cannot edit or delete a deleted comment.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReactionValueException">
        /// The value of the reaction is not valid. For more information, see the <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">CodeCommit
        /// User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReactionLimitExceededException">
        /// The number of reactions has been exceeded. Reactions are limited to one reaction per
        /// user for each individual comment ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReactionValueRequiredException">
        /// A reaction value is required.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutCommentReaction">REST API Reference for PutCommentReaction Operation</seealso>
        public virtual Task<PutCommentReactionResponse> PutCommentReactionAsync(PutCommentReactionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutCommentReactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCommentReactionResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutCommentReactionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutFile


        /// <summary>
        /// Adds or updates a file in a branch in an CodeCommit repository, and generates a commit
        /// for the addition in the specified branch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFile service method.</param>
        /// 
        /// <returns>The response from the PutFile service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.DirectoryNameConflictsWithFileNameException">
        /// A file cannot be added to the repository because the specified path name has the same
        /// name as a file that already exists in this repository. Either provide a different
        /// name for the file, or specify a different path for the file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentRequiredException">
        /// The file cannot be added because it is empty. Empty files cannot be added to the repository
        /// with this API.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileNameConflictsWithDirectoryNameException">
        /// A file cannot be added to the repository because the specified file name has the same
        /// name as a directory in this repository. Either provide another name for the file,
        /// or add the file in a directory that does not match the file name.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FilePathConflictsWithSubmodulePathException">
        /// The commit cannot be created because a specified file path points to a submodule.
        /// Verify that the destination files have valid file paths that do not point to a submodule.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDeletionParameterException">
        /// The specified deletion parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidParentCommitIdException">
        /// The parent commit ID is not valid. The commit ID cannot be empty, and must match the
        /// head commit ID for the branch of the repository where you want to add or update a
        /// file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitDoesNotExistException">
        /// The parent commit ID is not valid because it does not exist. The specified parent
        /// commit ID does not exist in the specified branch of the repository.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdOutdatedException">
        /// The file could not be added because the provided parent commit ID is not the current
        /// tip of the specified branch. To view the full commit ID of the current head of the
        /// branch, use <a>GetBranch</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdRequiredException">
        /// A parent commit ID is required. To view the full commit ID of a branch in a repository,
        /// use <a>GetBranch</a> or a Git command (for example, git pull or git log).
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.SameFileContentException">
        /// The file was not added or updated because the content of the file is exactly the same
        /// as the content of that file in the repository and branch that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutFile">REST API Reference for PutFile Operation</seealso>
        public virtual PutFileResponse PutFile(PutFileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutFileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFileResponseUnmarshaller.Instance;

            return Invoke<PutFileResponse>(request, options);
        }


        /// <summary>
        /// Adds or updates a file in a branch in an CodeCommit repository, and generates a commit
        /// for the addition in the specified branch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutFile service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.DirectoryNameConflictsWithFileNameException">
        /// A file cannot be added to the repository because the specified path name has the same
        /// name as a file that already exists in this repository. Either provide a different
        /// name for the file, or specify a different path for the file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentRequiredException">
        /// The file cannot be added because it is empty. Empty files cannot be added to the repository
        /// with this API.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileNameConflictsWithDirectoryNameException">
        /// A file cannot be added to the repository because the specified file name has the same
        /// name as a directory in this repository. Either provide another name for the file,
        /// or add the file in a directory that does not match the file name.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FilePathConflictsWithSubmodulePathException">
        /// The commit cannot be created because a specified file path points to a submodule.
        /// Verify that the destination files have valid file paths that do not point to a submodule.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDeletionParameterException">
        /// The specified deletion parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidParentCommitIdException">
        /// The parent commit ID is not valid. The commit ID cannot be empty, and must match the
        /// head commit ID for the branch of the repository where you want to add or update a
        /// file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitDoesNotExistException">
        /// The parent commit ID is not valid because it does not exist. The specified parent
        /// commit ID does not exist in the specified branch of the repository.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdOutdatedException">
        /// The file could not be added because the provided parent commit ID is not the current
        /// tip of the specified branch. To view the full commit ID of the current head of the
        /// branch, use <a>GetBranch</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdRequiredException">
        /// A parent commit ID is required. To view the full commit ID of a branch in a repository,
        /// use <a>GetBranch</a> or a Git command (for example, git pull or git log).
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.SameFileContentException">
        /// The file was not added or updated because the content of the file is exactly the same
        /// as the content of that file in the repository and branch that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutFile">REST API Reference for PutFile Operation</seealso>
        public virtual Task<PutFileResponse> PutFileAsync(PutFileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutFileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFileResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutFileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRepositoryTriggers


        /// <summary>
        /// Replaces all triggers for a repository. Used to create or delete triggers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRepositoryTriggers service method.</param>
        /// 
        /// <returns>The response from the PutRepositoryTriggers service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerBranchNameException">
        /// One or more branch names specified for the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerCustomDataException">
        /// The custom data provided for the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerDestinationArnException">
        /// The Amazon Resource Name (ARN) for the trigger is not valid for the specified destination.
        /// The most common reason for this error is that the ARN does not meet the requirements
        /// for the service type.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerEventsException">
        /// One or more events specified for the trigger is not valid. Check to make sure that
        /// all events specified match the requirements for allowed events.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerNameException">
        /// The name of the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerRegionException">
        /// The Amazon Web Services Region for the trigger target does not match the Amazon Web
        /// Services Region for the repository. Triggers must be created in the same Amazon Web
        /// Services Region as the target for the trigger.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumBranchesExceededException">
        /// The number of branches for the trigger was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryTriggersExceededException">
        /// The number of triggers allowed for the repository was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerBranchNameListRequiredException">
        /// At least one branch name is required, but was not specified in the trigger configuration.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerDestinationArnRequiredException">
        /// A destination ARN for the target service for the trigger is required, but was not
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerEventsListRequiredException">
        /// At least one event for the trigger is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerNameRequiredException">
        /// A name for the trigger is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggersListRequiredException">
        /// The list of triggers for the repository is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutRepositoryTriggers">REST API Reference for PutRepositoryTriggers Operation</seealso>
        public virtual PutRepositoryTriggersResponse PutRepositoryTriggers(PutRepositoryTriggersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRepositoryTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRepositoryTriggersResponseUnmarshaller.Instance;

            return Invoke<PutRepositoryTriggersResponse>(request, options);
        }


        /// <summary>
        /// Replaces all triggers for a repository. Used to create or delete triggers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRepositoryTriggers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRepositoryTriggers service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerBranchNameException">
        /// One or more branch names specified for the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerCustomDataException">
        /// The custom data provided for the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerDestinationArnException">
        /// The Amazon Resource Name (ARN) for the trigger is not valid for the specified destination.
        /// The most common reason for this error is that the ARN does not meet the requirements
        /// for the service type.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerEventsException">
        /// One or more events specified for the trigger is not valid. Check to make sure that
        /// all events specified match the requirements for allowed events.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerNameException">
        /// The name of the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerRegionException">
        /// The Amazon Web Services Region for the trigger target does not match the Amazon Web
        /// Services Region for the repository. Triggers must be created in the same Amazon Web
        /// Services Region as the target for the trigger.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumBranchesExceededException">
        /// The number of branches for the trigger was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryTriggersExceededException">
        /// The number of triggers allowed for the repository was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerBranchNameListRequiredException">
        /// At least one branch name is required, but was not specified in the trigger configuration.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerDestinationArnRequiredException">
        /// A destination ARN for the target service for the trigger is required, but was not
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerEventsListRequiredException">
        /// At least one event for the trigger is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerNameRequiredException">
        /// A name for the trigger is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggersListRequiredException">
        /// The list of triggers for the repository is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutRepositoryTriggers">REST API Reference for PutRepositoryTriggers Operation</seealso>
        public virtual Task<PutRepositoryTriggersResponse> PutRepositoryTriggersAsync(PutRepositoryTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRepositoryTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRepositoryTriggersResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutRepositoryTriggersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates tags for a resource in CodeCommit. For a list of valid resources in
        /// CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the <i>CodeCommit User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidResourceArnException">
        /// The value for the resource ARN is not valid. For more information about resources
        /// in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSystemTagUsageException">
        /// The specified tag is not valid. Key names cannot be prefixed with aws:.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTagsMapException">
        /// The map of tags is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ResourceArnRequiredException">
        /// A valid Amazon Resource Name (ARN) for an CodeCommit resource is required. For a list
        /// of valid resources in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagPolicyException">
        /// The tag policy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagsMapRequiredException">
        /// A map of tags is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TooManyTagsException">
        /// The maximum number of tags for an CodeCommit resource has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds or updates tags for a resource in CodeCommit. For a list of valid resources in
        /// CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the <i>CodeCommit User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidResourceArnException">
        /// The value for the resource ARN is not valid. For more information about resources
        /// in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSystemTagUsageException">
        /// The specified tag is not valid. Key names cannot be prefixed with aws:.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTagsMapException">
        /// The map of tags is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ResourceArnRequiredException">
        /// A valid Amazon Resource Name (ARN) for an CodeCommit resource is required. For a list
        /// of valid resources in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagPolicyException">
        /// The tag policy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagsMapRequiredException">
        /// A map of tags is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TooManyTagsException">
        /// The maximum number of tags for an CodeCommit resource has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestRepositoryTriggers


        /// <summary>
        /// Tests the functionality of repository triggers by sending information to the trigger
        /// target. If real data is available in the repository, the test sends data from the
        /// last commit. If no data is available, sample data is generated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestRepositoryTriggers service method.</param>
        /// 
        /// <returns>The response from the TestRepositoryTriggers service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerBranchNameException">
        /// One or more branch names specified for the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerCustomDataException">
        /// The custom data provided for the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerDestinationArnException">
        /// The Amazon Resource Name (ARN) for the trigger is not valid for the specified destination.
        /// The most common reason for this error is that the ARN does not meet the requirements
        /// for the service type.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerEventsException">
        /// One or more events specified for the trigger is not valid. Check to make sure that
        /// all events specified match the requirements for allowed events.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerNameException">
        /// The name of the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerRegionException">
        /// The Amazon Web Services Region for the trigger target does not match the Amazon Web
        /// Services Region for the repository. Triggers must be created in the same Amazon Web
        /// Services Region as the target for the trigger.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumBranchesExceededException">
        /// The number of branches for the trigger was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryTriggersExceededException">
        /// The number of triggers allowed for the repository was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerBranchNameListRequiredException">
        /// At least one branch name is required, but was not specified in the trigger configuration.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerDestinationArnRequiredException">
        /// A destination ARN for the target service for the trigger is required, but was not
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerEventsListRequiredException">
        /// At least one event for the trigger is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerNameRequiredException">
        /// A name for the trigger is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggersListRequiredException">
        /// The list of triggers for the repository is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/TestRepositoryTriggers">REST API Reference for TestRepositoryTriggers Operation</seealso>
        public virtual TestRepositoryTriggersResponse TestRepositoryTriggers(TestRepositoryTriggersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestRepositoryTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestRepositoryTriggersResponseUnmarshaller.Instance;

            return Invoke<TestRepositoryTriggersResponse>(request, options);
        }


        /// <summary>
        /// Tests the functionality of repository triggers by sending information to the trigger
        /// target. If real data is available in the repository, the test sends data from the
        /// last commit. If no data is available, sample data is generated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestRepositoryTriggers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestRepositoryTriggers service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerBranchNameException">
        /// One or more branch names specified for the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerCustomDataException">
        /// The custom data provided for the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerDestinationArnException">
        /// The Amazon Resource Name (ARN) for the trigger is not valid for the specified destination.
        /// The most common reason for this error is that the ARN does not meet the requirements
        /// for the service type.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerEventsException">
        /// One or more events specified for the trigger is not valid. Check to make sure that
        /// all events specified match the requirements for allowed events.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerNameException">
        /// The name of the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerRegionException">
        /// The Amazon Web Services Region for the trigger target does not match the Amazon Web
        /// Services Region for the repository. Triggers must be created in the same Amazon Web
        /// Services Region as the target for the trigger.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumBranchesExceededException">
        /// The number of branches for the trigger was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryTriggersExceededException">
        /// The number of triggers allowed for the repository was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerBranchNameListRequiredException">
        /// At least one branch name is required, but was not specified in the trigger configuration.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerDestinationArnRequiredException">
        /// A destination ARN for the target service for the trigger is required, but was not
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerEventsListRequiredException">
        /// At least one event for the trigger is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerNameRequiredException">
        /// A name for the trigger is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggersListRequiredException">
        /// The list of triggers for the repository is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/TestRepositoryTriggers">REST API Reference for TestRepositoryTriggers Operation</seealso>
        public virtual Task<TestRepositoryTriggersResponse> TestRepositoryTriggersAsync(TestRepositoryTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestRepositoryTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestRepositoryTriggersResponseUnmarshaller.Instance;
            
            return InvokeAsync<TestRepositoryTriggersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags for a resource in CodeCommit. For a list of valid resources in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the <i>CodeCommit User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidResourceArnException">
        /// The value for the resource ARN is not valid. For more information about resources
        /// in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSystemTagUsageException">
        /// The specified tag is not valid. Key names cannot be prefixed with aws:.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTagKeysListException">
        /// The list of tags is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ResourceArnRequiredException">
        /// A valid Amazon Resource Name (ARN) for an CodeCommit resource is required. For a list
        /// of valid resources in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagKeysListRequiredException">
        /// A list of tag keys is required. The list cannot be empty or null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagPolicyException">
        /// The tag policy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TooManyTagsException">
        /// The maximum number of tags for an CodeCommit resource has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags for a resource in CodeCommit. For a list of valid resources in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the <i>CodeCommit User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidResourceArnException">
        /// The value for the resource ARN is not valid. For more information about resources
        /// in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSystemTagUsageException">
        /// The specified tag is not valid. Key names cannot be prefixed with aws:.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTagKeysListException">
        /// The list of tags is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ResourceArnRequiredException">
        /// A valid Amazon Resource Name (ARN) for an CodeCommit resource is required. For a list
        /// of valid resources in CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagKeysListRequiredException">
        /// A list of tag keys is required. The list cannot be empty or null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagPolicyException">
        /// The tag policy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TooManyTagsException">
        /// The maximum number of tags for an CodeCommit resource has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApprovalRuleTemplateContent


        /// <summary>
        /// Updates the content of an approval rule template. You can change the number of required
        /// approvals, the membership of the approval rule, and whether an approval pool is defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalRuleTemplateContent service method.</param>
        /// 
        /// <returns>The response from the UpdateApprovalRuleTemplateContent service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateContentRequiredException">
        /// The content for the approval rule template is empty. You must provide some content
        /// for an approval rule template. The content cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateContentException">
        /// The content of the approval rule template is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRuleContentSha256Exception">
        /// The SHA-256 hash signature for the rule content is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateContent">REST API Reference for UpdateApprovalRuleTemplateContent Operation</seealso>
        public virtual UpdateApprovalRuleTemplateContentResponse UpdateApprovalRuleTemplateContent(UpdateApprovalRuleTemplateContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApprovalRuleTemplateContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApprovalRuleTemplateContentResponseUnmarshaller.Instance;

            return Invoke<UpdateApprovalRuleTemplateContentResponse>(request, options);
        }


        /// <summary>
        /// Updates the content of an approval rule template. You can change the number of required
        /// approvals, the membership of the approval rule, and whether an approval pool is defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalRuleTemplateContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApprovalRuleTemplateContent service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateContentRequiredException">
        /// The content for the approval rule template is empty. You must provide some content
        /// for an approval rule template. The content cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateContentException">
        /// The content of the approval rule template is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRuleContentSha256Exception">
        /// The SHA-256 hash signature for the rule content is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateContent">REST API Reference for UpdateApprovalRuleTemplateContent Operation</seealso>
        public virtual Task<UpdateApprovalRuleTemplateContentResponse> UpdateApprovalRuleTemplateContentAsync(UpdateApprovalRuleTemplateContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApprovalRuleTemplateContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApprovalRuleTemplateContentResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateApprovalRuleTemplateContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApprovalRuleTemplateDescription


        /// <summary>
        /// Updates the description for a specified approval rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalRuleTemplateDescription service method.</param>
        /// 
        /// <returns>The response from the UpdateApprovalRuleTemplateDescription service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateDescriptionException">
        /// The description for the approval rule template is not valid because it exceeds the
        /// maximum characters allowed for a description. For more information about limits in
        /// CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateDescription">REST API Reference for UpdateApprovalRuleTemplateDescription Operation</seealso>
        public virtual UpdateApprovalRuleTemplateDescriptionResponse UpdateApprovalRuleTemplateDescription(UpdateApprovalRuleTemplateDescriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApprovalRuleTemplateDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApprovalRuleTemplateDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateApprovalRuleTemplateDescriptionResponse>(request, options);
        }


        /// <summary>
        /// Updates the description for a specified approval rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalRuleTemplateDescription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApprovalRuleTemplateDescription service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateDescriptionException">
        /// The description for the approval rule template is not valid because it exceeds the
        /// maximum characters allowed for a description. For more information about limits in
        /// CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateDescription">REST API Reference for UpdateApprovalRuleTemplateDescription Operation</seealso>
        public virtual Task<UpdateApprovalRuleTemplateDescriptionResponse> UpdateApprovalRuleTemplateDescriptionAsync(UpdateApprovalRuleTemplateDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApprovalRuleTemplateDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApprovalRuleTemplateDescriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateApprovalRuleTemplateDescriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApprovalRuleTemplateName


        /// <summary>
        /// Updates the name of a specified approval rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalRuleTemplateName service method.</param>
        /// 
        /// <returns>The response from the UpdateApprovalRuleTemplateName service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameAlreadyExistsException">
        /// You cannot create an approval rule template with that name because a template with
        /// that name already exists in this Amazon Web Services Region for your Amazon Web Services
        /// account. Approval rule template names must be unique.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateName">REST API Reference for UpdateApprovalRuleTemplateName Operation</seealso>
        public virtual UpdateApprovalRuleTemplateNameResponse UpdateApprovalRuleTemplateName(UpdateApprovalRuleTemplateNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApprovalRuleTemplateNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApprovalRuleTemplateNameResponseUnmarshaller.Instance;

            return Invoke<UpdateApprovalRuleTemplateNameResponse>(request, options);
        }


        /// <summary>
        /// Updates the name of a specified approval rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalRuleTemplateName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApprovalRuleTemplateName service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the Amazon Web Services Region where the template was
        /// created, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameAlreadyExistsException">
        /// You cannot create an approval rule template with that name because a template with
        /// that name already exists in this Amazon Web Services Region for your Amazon Web Services
        /// account. Approval rule template names must be unique.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the <i>CodeCommit User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateName">REST API Reference for UpdateApprovalRuleTemplateName Operation</seealso>
        public virtual Task<UpdateApprovalRuleTemplateNameResponse> UpdateApprovalRuleTemplateNameAsync(UpdateApprovalRuleTemplateNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApprovalRuleTemplateNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApprovalRuleTemplateNameResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateApprovalRuleTemplateNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateComment


        /// <summary>
        /// Replaces the contents of a comment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComment service method.</param>
        /// 
        /// <returns>The response from the UpdateComment service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentRequiredException">
        /// The comment is empty. You must provide some content for a comment. The content cannot
        /// be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentSizeLimitExceededException">
        /// The comment is too large. Comments are limited to 10,240 characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDeletedException">
        /// This comment has already been deleted. You cannot edit or delete a deleted comment.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentNotCreatedByCallerException">
        /// You cannot modify or delete this comment. Only comment authors can modify or delete
        /// their comments.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateComment">REST API Reference for UpdateComment Operation</seealso>
        public virtual UpdateCommentResponse UpdateComment(UpdateCommentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCommentResponseUnmarshaller.Instance;

            return Invoke<UpdateCommentResponse>(request, options);
        }


        /// <summary>
        /// Replaces the contents of a comment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateComment service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentRequiredException">
        /// The comment is empty. You must provide some content for a comment. The content cannot
        /// be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentSizeLimitExceededException">
        /// The comment is too large. Comments are limited to 10,240 characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDeletedException">
        /// This comment has already been deleted. You cannot edit or delete a deleted comment.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentNotCreatedByCallerException">
        /// You cannot modify or delete this comment. Only comment authors can modify or delete
        /// their comments.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateComment">REST API Reference for UpdateComment Operation</seealso>
        public virtual Task<UpdateCommentResponse> UpdateCommentAsync(UpdateCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCommentResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCommentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDefaultBranch


        /// <summary>
        /// Sets or changes the default branch name for the specified repository.
        /// 
        ///  <note> 
        /// <para>
        /// If you use this operation to change the default branch name to the current default
        /// branch name, a success message is returned even though the default branch did not
        /// change.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultBranch service method.</param>
        /// 
        /// <returns>The response from the UpdateDefaultBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateDefaultBranch">REST API Reference for UpdateDefaultBranch Operation</seealso>
        public virtual UpdateDefaultBranchResponse UpdateDefaultBranch(UpdateDefaultBranchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDefaultBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDefaultBranchResponseUnmarshaller.Instance;

            return Invoke<UpdateDefaultBranchResponse>(request, options);
        }


        /// <summary>
        /// Sets or changes the default branch name for the specified repository.
        /// 
        ///  <note> 
        /// <para>
        /// If you use this operation to change the default branch name to the current default
        /// branch name, a success message is returned even though the default branch did not
        /// change.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultBranch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDefaultBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateDefaultBranch">REST API Reference for UpdateDefaultBranch Operation</seealso>
        public virtual Task<UpdateDefaultBranchResponse> UpdateDefaultBranchAsync(UpdateDefaultBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDefaultBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDefaultBranchResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDefaultBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePullRequestApprovalRuleContent


        /// <summary>
        /// Updates the structure of an approval rule created specifically for a pull request.
        /// For example, you can change the number of required approvers and the approval pool
        /// for approvers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestApprovalRuleContent service method.</param>
        /// 
        /// <returns>The response from the UpdatePullRequestApprovalRuleContent service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleContentRequiredException">
        /// The content for the approval rule is empty. You must provide some content for an approval
        /// rule. The content cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleDoesNotExistException">
        /// The specified approval rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleNameRequiredException">
        /// An approval rule name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CannotModifyApprovalRuleFromTemplateException">
        /// The approval rule cannot be modified for the pull request because it was created by
        /// an approval rule template and applied to the pull request automatically.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleContentException">
        /// The content for the approval rule is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleNameException">
        /// The name for the approval rule is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRuleContentSha256Exception">
        /// The SHA-256 hash signature for the rule content is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestApprovalRuleContent">REST API Reference for UpdatePullRequestApprovalRuleContent Operation</seealso>
        public virtual UpdatePullRequestApprovalRuleContentResponse UpdatePullRequestApprovalRuleContent(UpdatePullRequestApprovalRuleContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestApprovalRuleContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestApprovalRuleContentResponseUnmarshaller.Instance;

            return Invoke<UpdatePullRequestApprovalRuleContentResponse>(request, options);
        }


        /// <summary>
        /// Updates the structure of an approval rule created specifically for a pull request.
        /// For example, you can change the number of required approvers and the approval pool
        /// for approvers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestApprovalRuleContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePullRequestApprovalRuleContent service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleContentRequiredException">
        /// The content for the approval rule is empty. You must provide some content for an approval
        /// rule. The content cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleDoesNotExistException">
        /// The specified approval rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleNameRequiredException">
        /// An approval rule name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CannotModifyApprovalRuleFromTemplateException">
        /// The approval rule cannot be modified for the pull request because it was created by
        /// an approval rule template and applied to the pull request automatically.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleContentException">
        /// The content for the approval rule is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleNameException">
        /// The name for the approval rule is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRuleContentSha256Exception">
        /// The SHA-256 hash signature for the rule content is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestApprovalRuleContent">REST API Reference for UpdatePullRequestApprovalRuleContent Operation</seealso>
        public virtual Task<UpdatePullRequestApprovalRuleContentResponse> UpdatePullRequestApprovalRuleContentAsync(UpdatePullRequestApprovalRuleContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestApprovalRuleContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestApprovalRuleContentResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePullRequestApprovalRuleContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePullRequestApprovalState


        /// <summary>
        /// Updates the state of a user's approval on a pull request. The user is derived from
        /// the signed-in account when the request is made.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestApprovalState service method.</param>
        /// 
        /// <returns>The response from the UpdatePullRequestApprovalState service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalStateRequiredException">
        /// An approval state is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalStateException">
        /// The state for the approval is not valid. Valid values include APPROVE and REVOKE.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumNumberOfApprovalsExceededException">
        /// The number of approvals required for the approval rule exceeds the maximum number
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestCannotBeApprovedByAuthorException">
        /// The approval cannot be applied because the user approving the pull request matches
        /// the user who created the pull request. You cannot approve a pull request that you
        /// created.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionNotCurrentException">
        /// The revision ID provided in the request does not match the current revision ID. Use
        /// GetPullRequest to retrieve the current revision ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestApprovalState">REST API Reference for UpdatePullRequestApprovalState Operation</seealso>
        public virtual UpdatePullRequestApprovalStateResponse UpdatePullRequestApprovalState(UpdatePullRequestApprovalStateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestApprovalStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestApprovalStateResponseUnmarshaller.Instance;

            return Invoke<UpdatePullRequestApprovalStateResponse>(request, options);
        }


        /// <summary>
        /// Updates the state of a user's approval on a pull request. The user is derived from
        /// the signed-in account when the request is made.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestApprovalState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePullRequestApprovalState service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalStateRequiredException">
        /// An approval state is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalStateException">
        /// The state for the approval is not valid. Valid values include APPROVE and REVOKE.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumNumberOfApprovalsExceededException">
        /// The number of approvals required for the approval rule exceeds the maximum number
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestCannotBeApprovedByAuthorException">
        /// The approval cannot be applied because the user approving the pull request matches
        /// the user who created the pull request. You cannot approve a pull request that you
        /// created.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionNotCurrentException">
        /// The revision ID provided in the request does not match the current revision ID. Use
        /// GetPullRequest to retrieve the current revision ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestApprovalState">REST API Reference for UpdatePullRequestApprovalState Operation</seealso>
        public virtual Task<UpdatePullRequestApprovalStateResponse> UpdatePullRequestApprovalStateAsync(UpdatePullRequestApprovalStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestApprovalStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestApprovalStateResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePullRequestApprovalStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePullRequestDescription


        /// <summary>
        /// Replaces the contents of the description of a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestDescription service method.</param>
        /// 
        /// <returns>The response from the UpdatePullRequestDescription service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDescriptionException">
        /// The pull request description is not valid. Descriptions cannot be more than 1,000
        /// characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestDescription">REST API Reference for UpdatePullRequestDescription Operation</seealso>
        public virtual UpdatePullRequestDescriptionResponse UpdatePullRequestDescription(UpdatePullRequestDescriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdatePullRequestDescriptionResponse>(request, options);
        }


        /// <summary>
        /// Replaces the contents of the description of a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestDescription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePullRequestDescription service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDescriptionException">
        /// The pull request description is not valid. Descriptions cannot be more than 1,000
        /// characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestDescription">REST API Reference for UpdatePullRequestDescription Operation</seealso>
        public virtual Task<UpdatePullRequestDescriptionResponse> UpdatePullRequestDescriptionAsync(UpdatePullRequestDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestDescriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePullRequestDescriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePullRequestStatus


        /// <summary>
        /// Updates the status of a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestStatus service method.</param>
        /// 
        /// <returns>The response from the UpdatePullRequestStatus service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestStatusException">
        /// The pull request status is not valid. The only valid values are <c>OPEN</c> and <c>CLOSED</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestStatusUpdateException">
        /// The pull request status update is not valid. The only valid update is from <c>OPEN</c>
        /// to <c>CLOSED</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestStatusRequiredException">
        /// A pull request status is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestStatus">REST API Reference for UpdatePullRequestStatus Operation</seealso>
        public virtual UpdatePullRequestStatusResponse UpdatePullRequestStatus(UpdatePullRequestStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestStatusResponseUnmarshaller.Instance;

            return Invoke<UpdatePullRequestStatusResponse>(request, options);
        }


        /// <summary>
        /// Updates the status of a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePullRequestStatus service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestStatusException">
        /// The pull request status is not valid. The only valid values are <c>OPEN</c> and <c>CLOSED</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestStatusUpdateException">
        /// The pull request status update is not valid. The only valid update is from <c>OPEN</c>
        /// to <c>CLOSED</c>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestStatusRequiredException">
        /// A pull request status is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestStatus">REST API Reference for UpdatePullRequestStatus Operation</seealso>
        public virtual Task<UpdatePullRequestStatusResponse> UpdatePullRequestStatusAsync(UpdatePullRequestStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePullRequestStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePullRequestTitle


        /// <summary>
        /// Replaces the title of a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestTitle service method.</param>
        /// 
        /// <returns>The response from the UpdatePullRequestTitle service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTitleException">
        /// The title of the pull request is not valid. Pull request titles cannot exceed 100
        /// characters in length.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TitleRequiredException">
        /// A pull request title is required. It cannot be empty or null.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestTitle">REST API Reference for UpdatePullRequestTitle Operation</seealso>
        public virtual UpdatePullRequestTitleResponse UpdatePullRequestTitle(UpdatePullRequestTitleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestTitleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestTitleResponseUnmarshaller.Instance;

            return Invoke<UpdatePullRequestTitleResponse>(request, options);
        }


        /// <summary>
        /// Replaces the title of a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestTitle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePullRequestTitle service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTitleException">
        /// The title of the pull request is not valid. Pull request titles cannot exceed 100
        /// characters in length.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TitleRequiredException">
        /// A pull request title is required. It cannot be empty or null.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestTitle">REST API Reference for UpdatePullRequestTitle Operation</seealso>
        public virtual Task<UpdatePullRequestTitleResponse> UpdatePullRequestTitleAsync(UpdatePullRequestTitleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestTitleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestTitleResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePullRequestTitleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRepositoryDescription


        /// <summary>
        /// Sets or changes the comment or description for a repository.
        /// 
        ///  <note> 
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a webpage can expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a webpage.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryDescription service method.</param>
        /// 
        /// <returns>The response from the UpdateRepositoryDescription service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryDescriptionException">
        /// The specified repository description is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryDescription">REST API Reference for UpdateRepositoryDescription Operation</seealso>
        public virtual UpdateRepositoryDescriptionResponse UpdateRepositoryDescription(UpdateRepositoryDescriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRepositoryDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRepositoryDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateRepositoryDescriptionResponse>(request, options);
        }


        /// <summary>
        /// Sets or changes the comment or description for a repository.
        /// 
        ///  <note> 
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a webpage can expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a webpage.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryDescription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRepositoryDescription service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryDescriptionException">
        /// The specified repository description is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryDescription">REST API Reference for UpdateRepositoryDescription Operation</seealso>
        public virtual Task<UpdateRepositoryDescriptionResponse> UpdateRepositoryDescriptionAsync(UpdateRepositoryDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRepositoryDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRepositoryDescriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRepositoryDescriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRepositoryEncryptionKey


        /// <summary>
        /// Updates the Key Management Service encryption key used to encrypt and decrypt a CodeCommit
        /// repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the UpdateRepositoryEncryptionKey service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyInvalidIdException">
        /// The Key Management Service encryption key is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyInvalidUsageException">
        /// A KMS encryption key was used to try and encrypt or decrypt a repository, but either
        /// the repository or the key was not in a valid state to support the operation.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyRequiredException">
        /// A KMS encryption key ID is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryEncryptionKey">REST API Reference for UpdateRepositoryEncryptionKey Operation</seealso>
        public virtual UpdateRepositoryEncryptionKeyResponse UpdateRepositoryEncryptionKey(UpdateRepositoryEncryptionKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRepositoryEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRepositoryEncryptionKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateRepositoryEncryptionKeyResponse>(request, options);
        }


        /// <summary>
        /// Updates the Key Management Service encryption key used to encrypt and decrypt a CodeCommit
        /// repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryEncryptionKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRepositoryEncryptionKey service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyInvalidIdException">
        /// The Key Management Service encryption key is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyInvalidUsageException">
        /// A KMS encryption key was used to try and encrypt or decrypt a repository, but either
        /// the repository or the key was not in a valid state to support the operation.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyRequiredException">
        /// A KMS encryption key ID is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryEncryptionKey">REST API Reference for UpdateRepositoryEncryptionKey Operation</seealso>
        public virtual Task<UpdateRepositoryEncryptionKeyResponse> UpdateRepositoryEncryptionKeyAsync(UpdateRepositoryEncryptionKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRepositoryEncryptionKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRepositoryEncryptionKeyResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRepositoryEncryptionKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRepositoryName


        /// <summary>
        /// Renames a repository. The repository name must be unique across the calling Amazon
        /// Web Services account. Repository names are limited to 100 alphanumeric, dash, and
        /// underscore characters, and cannot include certain characters. The suffix .git is prohibited.
        /// For more information about the limits on repository names, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the CodeCommit User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryName service method.</param>
        /// 
        /// <returns>The response from the UpdateRepositoryName service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameExistsException">
        /// The specified repository name already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryName">REST API Reference for UpdateRepositoryName Operation</seealso>
        public virtual UpdateRepositoryNameResponse UpdateRepositoryName(UpdateRepositoryNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRepositoryNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRepositoryNameResponseUnmarshaller.Instance;

            return Invoke<UpdateRepositoryNameResponse>(request, options);
        }


        /// <summary>
        /// Renames a repository. The repository name must be unique across the calling Amazon
        /// Web Services account. Repository names are limited to 100 alphanumeric, dash, and
        /// underscore characters, and cannot include certain characters. The suffix .git is prohibited.
        /// For more information about the limits on repository names, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
        /// in the CodeCommit User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRepositoryName service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameExistsException">
        /// The specified repository name already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryName">REST API Reference for UpdateRepositoryName Operation</seealso>
        public virtual Task<UpdateRepositoryNameResponse> UpdateRepositoryNameAsync(UpdateRepositoryNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRepositoryNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRepositoryNameResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRepositoryNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}