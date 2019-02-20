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

namespace Amazon.CodeCommit
{
    /// <summary>
    /// Implementation for accessing CodeCommit
    ///
    /// AWS CodeCommit 
    /// <para>
    /// This is the <i>AWS CodeCommit API Reference</i>. This reference provides descriptions
    /// of the operations and data types for AWS CodeCommit API along with usage examples.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodeCommit API to work with the following objects:
    /// </para>
    ///  
    /// <para>
    /// Repositories, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>BatchGetRepositories</a>, which returns information about one or more repositories
    /// associated with your AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateRepository</a>, which creates an AWS CodeCommit repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteRepository</a>, which deletes an AWS CodeCommit repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetRepository</a>, which returns information about a specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListRepositories</a>, which lists all AWS CodeCommit repositories associated with
    /// your AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRepositoryDescription</a>, which sets or updates the description of the
    /// repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRepositoryName</a>, which changes the name of the repository. If you change
    /// the name of a repository, no other users of that repository will be able to access
    /// it until you send them the new HTTPS or SSH URL to use.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Branches, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateBranch</a>, which creates a new branch in a specified repository.
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
    ///  <a>GetFile</a>, which returns the base-64 encoded content of a specified file.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetFolder</a>, which returns the contents of a specified folder or directory.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutFile</a>, which adds or modifies a file in a specified repository and branch.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Information about committed code in a repository, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateCommit</a>, which creates a commit for changes to a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetBlob</a>, which returns the base-64 encoded content of an individual Git blob
    /// object within a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetCommit</a>, which returns information about a commit, including commit messages
    /// and author and committer information.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetDifferences</a>, which returns information about the differences in a valid
    /// commit specifier (such as a branch, tag, HEAD, commit ID or other fully qualified
    /// reference).
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
    ///  <a>DescribePullRequestEvents</a>, which returns information about one or more pull
    /// request events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetCommentsForPullRequest</a>, which returns information about comments on a specified
    /// pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetMergeConflicts</a>, which returns information about merge conflicts between
    /// the source and destination branch in a pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPullRequest</a>, which returns information about a specified pull request.
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
    ///  <a>PostCommentForPullRequest</a>, which posts a comment to a pull request at the
    /// specified line, file, or request.
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
    /// Information about comments in a repository, by calling the following:
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
    ///  <a>UpdateComment</a>, which updates the content of a comment on a commit in a repository.
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
    /// For information about how to use AWS CodeCommit, see the <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">AWS
    /// CodeCommit User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCodeCommitClient : AmazonServiceClient, IAmazonCodeCommit
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodeCommitMetadata();
        
        #region Constructors

#if CORECLR
    
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeCommitConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeCommitConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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


        #region  BatchGetRepositories

        internal virtual BatchGetRepositoriesResponse BatchGetRepositories(BatchGetRepositoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetRepositoriesResponseUnmarshaller.Instance;

            return Invoke<BatchGetRepositoriesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRepositories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchGetRepositories">REST API Reference for BatchGetRepositories Operation</seealso>
        public virtual Task<BatchGetRepositoriesResponse> BatchGetRepositoriesAsync(BatchGetRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetRepositoriesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetRepositoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBranch

        internal virtual CreateBranchResponse CreateBranch(CreateBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBranchResponseUnmarshaller.Instance;

            return Invoke<CreateBranchResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        public virtual Task<CreateBranchResponse> CreateBranchAsync(CreateBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBranchResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCommit

        internal virtual CreateCommitResponse CreateCommit(CreateCommitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCommitResponseUnmarshaller.Instance;

            return Invoke<CreateCommitResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCommit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCommit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateCommit">REST API Reference for CreateCommit Operation</seealso>
        public virtual Task<CreateCommitResponse> CreateCommitAsync(CreateCommitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCommitResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCommitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePullRequest

        internal virtual CreatePullRequestResponse CreatePullRequest(CreatePullRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePullRequestResponseUnmarshaller.Instance;

            return Invoke<CreatePullRequestResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePullRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePullRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreatePullRequest">REST API Reference for CreatePullRequest Operation</seealso>
        public virtual Task<CreatePullRequestResponse> CreatePullRequestAsync(CreatePullRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePullRequestResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePullRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRepository

        internal virtual CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return Invoke<CreateRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        public virtual Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBranch

        internal virtual DeleteBranchResponse DeleteBranch(DeleteBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBranchResponseUnmarshaller.Instance;

            return Invoke<DeleteBranchResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBranch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        public virtual Task<DeleteBranchResponse> DeleteBranchAsync(DeleteBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBranchResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCommentContent

        internal virtual DeleteCommentContentResponse DeleteCommentContent(DeleteCommentContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCommentContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCommentContentResponseUnmarshaller.Instance;

            return Invoke<DeleteCommentContentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCommentContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCommentContent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteCommentContent">REST API Reference for DeleteCommentContent Operation</seealso>
        public virtual Task<DeleteCommentContentResponse> DeleteCommentContentAsync(DeleteCommentContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCommentContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCommentContentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCommentContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFile

        internal virtual DeleteFileResponse DeleteFile(DeleteFileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileResponseUnmarshaller.Instance;

            return Invoke<DeleteFileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteFile">REST API Reference for DeleteFile Operation</seealso>
        public virtual Task<DeleteFileResponse> DeleteFileAsync(DeleteFileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRepository

        internal virtual DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return Invoke<DeleteRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        public virtual Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePullRequestEvents

        internal virtual DescribePullRequestEventsResponse DescribePullRequestEvents(DescribePullRequestEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePullRequestEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePullRequestEventsResponseUnmarshaller.Instance;

            return Invoke<DescribePullRequestEventsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePullRequestEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePullRequestEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DescribePullRequestEvents">REST API Reference for DescribePullRequestEvents Operation</seealso>
        public virtual Task<DescribePullRequestEventsResponse> DescribePullRequestEventsAsync(DescribePullRequestEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePullRequestEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePullRequestEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePullRequestEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBlob

        internal virtual GetBlobResponse GetBlob(GetBlobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlobResponseUnmarshaller.Instance;

            return Invoke<GetBlobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBlob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBlob">REST API Reference for GetBlob Operation</seealso>
        public virtual Task<GetBlobResponse> GetBlobAsync(GetBlobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlobResponseUnmarshaller.Instance;

            return InvokeAsync<GetBlobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBranch

        internal virtual GetBranchResponse GetBranch(GetBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBranchResponseUnmarshaller.Instance;

            return Invoke<GetBranchResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBranch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBranch">REST API Reference for GetBranch Operation</seealso>
        public virtual Task<GetBranchResponse> GetBranchAsync(GetBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBranchResponseUnmarshaller.Instance;

            return InvokeAsync<GetBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComment

        internal virtual GetCommentResponse GetComment(GetCommentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommentResponseUnmarshaller.Instance;

            return Invoke<GetCommentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetComment">REST API Reference for GetComment Operation</seealso>
        public virtual Task<GetCommentResponse> GetCommentAsync(GetCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommentResponseUnmarshaller.Instance;

            return InvokeAsync<GetCommentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCommentsForComparedCommit

        internal virtual GetCommentsForComparedCommitResponse GetCommentsForComparedCommit(GetCommentsForComparedCommitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCommentsForComparedCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommentsForComparedCommitResponseUnmarshaller.Instance;

            return Invoke<GetCommentsForComparedCommitResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCommentsForComparedCommit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCommentsForComparedCommit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForComparedCommit">REST API Reference for GetCommentsForComparedCommit Operation</seealso>
        public virtual Task<GetCommentsForComparedCommitResponse> GetCommentsForComparedCommitAsync(GetCommentsForComparedCommitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCommentsForComparedCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommentsForComparedCommitResponseUnmarshaller.Instance;

            return InvokeAsync<GetCommentsForComparedCommitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCommentsForPullRequest

        internal virtual GetCommentsForPullRequestResponse GetCommentsForPullRequest(GetCommentsForPullRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCommentsForPullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommentsForPullRequestResponseUnmarshaller.Instance;

            return Invoke<GetCommentsForPullRequestResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCommentsForPullRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCommentsForPullRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForPullRequest">REST API Reference for GetCommentsForPullRequest Operation</seealso>
        public virtual Task<GetCommentsForPullRequestResponse> GetCommentsForPullRequestAsync(GetCommentsForPullRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCommentsForPullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommentsForPullRequestResponseUnmarshaller.Instance;

            return InvokeAsync<GetCommentsForPullRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCommit

        internal virtual GetCommitResponse GetCommit(GetCommitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommitResponseUnmarshaller.Instance;

            return Invoke<GetCommitResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCommit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCommit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommit">REST API Reference for GetCommit Operation</seealso>
        public virtual Task<GetCommitResponse> GetCommitAsync(GetCommitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommitResponseUnmarshaller.Instance;

            return InvokeAsync<GetCommitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDifferences

        internal virtual GetDifferencesResponse GetDifferences(GetDifferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDifferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDifferencesResponseUnmarshaller.Instance;

            return Invoke<GetDifferencesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDifferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDifferences operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetDifferences">REST API Reference for GetDifferences Operation</seealso>
        public virtual Task<GetDifferencesResponse> GetDifferencesAsync(GetDifferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDifferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDifferencesResponseUnmarshaller.Instance;

            return InvokeAsync<GetDifferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFile

        internal virtual GetFileResponse GetFile(GetFileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFileResponseUnmarshaller.Instance;

            return Invoke<GetFileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFile">REST API Reference for GetFile Operation</seealso>
        public virtual Task<GetFileResponse> GetFileAsync(GetFileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFileResponseUnmarshaller.Instance;

            return InvokeAsync<GetFileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFolder

        internal virtual GetFolderResponse GetFolder(GetFolderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFolderResponseUnmarshaller.Instance;

            return Invoke<GetFolderResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFolder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFolder">REST API Reference for GetFolder Operation</seealso>
        public virtual Task<GetFolderResponse> GetFolderAsync(GetFolderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFolderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFolderResponseUnmarshaller.Instance;

            return InvokeAsync<GetFolderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMergeConflicts

        internal virtual GetMergeConflictsResponse GetMergeConflicts(GetMergeConflictsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMergeConflictsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMergeConflictsResponseUnmarshaller.Instance;

            return Invoke<GetMergeConflictsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetMergeConflicts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMergeConflicts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeConflicts">REST API Reference for GetMergeConflicts Operation</seealso>
        public virtual Task<GetMergeConflictsResponse> GetMergeConflictsAsync(GetMergeConflictsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMergeConflictsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMergeConflictsResponseUnmarshaller.Instance;

            return InvokeAsync<GetMergeConflictsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPullRequest

        internal virtual GetPullRequestResponse GetPullRequest(GetPullRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPullRequestResponseUnmarshaller.Instance;

            return Invoke<GetPullRequestResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPullRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPullRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequest">REST API Reference for GetPullRequest Operation</seealso>
        public virtual Task<GetPullRequestResponse> GetPullRequestAsync(GetPullRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPullRequestResponseUnmarshaller.Instance;

            return InvokeAsync<GetPullRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRepository

        internal virtual GetRepositoryResponse GetRepository(GetRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryResponseUnmarshaller.Instance;

            return Invoke<GetRepositoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepository operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepository">REST API Reference for GetRepository Operation</seealso>
        public virtual Task<GetRepositoryResponse> GetRepositoryAsync(GetRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRepositoryTriggers

        internal virtual GetRepositoryTriggersResponse GetRepositoryTriggers(GetRepositoryTriggersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryTriggersResponseUnmarshaller.Instance;

            return Invoke<GetRepositoryTriggersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRepositoryTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryTriggers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepositoryTriggers">REST API Reference for GetRepositoryTriggers Operation</seealso>
        public virtual Task<GetRepositoryTriggersResponse> GetRepositoryTriggersAsync(GetRepositoryTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryTriggersResponseUnmarshaller.Instance;

            return InvokeAsync<GetRepositoryTriggersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBranches

        internal virtual ListBranchesResponse ListBranches(ListBranchesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBranchesResponseUnmarshaller.Instance;

            return Invoke<ListBranchesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListBranches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBranches operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListBranches">REST API Reference for ListBranches Operation</seealso>
        public virtual Task<ListBranchesResponse> ListBranchesAsync(ListBranchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBranchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBranchesResponseUnmarshaller.Instance;

            return InvokeAsync<ListBranchesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPullRequests

        internal virtual ListPullRequestsResponse ListPullRequests(ListPullRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPullRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPullRequestsResponseUnmarshaller.Instance;

            return Invoke<ListPullRequestsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPullRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPullRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListPullRequests">REST API Reference for ListPullRequests Operation</seealso>
        public virtual Task<ListPullRequestsResponse> ListPullRequestsAsync(ListPullRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPullRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPullRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPullRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRepositories

        internal virtual ListRepositoriesResponse ListRepositories(ListRepositoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoriesResponseUnmarshaller.Instance;

            return Invoke<ListRepositoriesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRepositories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListRepositories">REST API Reference for ListRepositories Operation</seealso>
        public virtual Task<ListRepositoriesResponse> ListRepositoriesAsync(ListRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRepositoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MergePullRequestByFastForward

        internal virtual MergePullRequestByFastForwardResponse MergePullRequestByFastForward(MergePullRequestByFastForwardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MergePullRequestByFastForwardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergePullRequestByFastForwardResponseUnmarshaller.Instance;

            return Invoke<MergePullRequestByFastForwardResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the MergePullRequestByFastForward operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestByFastForward operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestByFastForward">REST API Reference for MergePullRequestByFastForward Operation</seealso>
        public virtual Task<MergePullRequestByFastForwardResponse> MergePullRequestByFastForwardAsync(MergePullRequestByFastForwardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MergePullRequestByFastForwardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MergePullRequestByFastForwardResponseUnmarshaller.Instance;

            return InvokeAsync<MergePullRequestByFastForwardResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PostCommentForComparedCommit

        internal virtual PostCommentForComparedCommitResponse PostCommentForComparedCommit(PostCommentForComparedCommitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostCommentForComparedCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostCommentForComparedCommitResponseUnmarshaller.Instance;

            return Invoke<PostCommentForComparedCommitResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PostCommentForComparedCommit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostCommentForComparedCommit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForComparedCommit">REST API Reference for PostCommentForComparedCommit Operation</seealso>
        public virtual Task<PostCommentForComparedCommitResponse> PostCommentForComparedCommitAsync(PostCommentForComparedCommitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostCommentForComparedCommitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostCommentForComparedCommitResponseUnmarshaller.Instance;

            return InvokeAsync<PostCommentForComparedCommitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PostCommentForPullRequest

        internal virtual PostCommentForPullRequestResponse PostCommentForPullRequest(PostCommentForPullRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostCommentForPullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostCommentForPullRequestResponseUnmarshaller.Instance;

            return Invoke<PostCommentForPullRequestResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PostCommentForPullRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostCommentForPullRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForPullRequest">REST API Reference for PostCommentForPullRequest Operation</seealso>
        public virtual Task<PostCommentForPullRequestResponse> PostCommentForPullRequestAsync(PostCommentForPullRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostCommentForPullRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostCommentForPullRequestResponseUnmarshaller.Instance;

            return InvokeAsync<PostCommentForPullRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PostCommentReply

        internal virtual PostCommentReplyResponse PostCommentReply(PostCommentReplyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostCommentReplyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostCommentReplyResponseUnmarshaller.Instance;

            return Invoke<PostCommentReplyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PostCommentReply operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostCommentReply operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentReply">REST API Reference for PostCommentReply Operation</seealso>
        public virtual Task<PostCommentReplyResponse> PostCommentReplyAsync(PostCommentReplyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PostCommentReplyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostCommentReplyResponseUnmarshaller.Instance;

            return InvokeAsync<PostCommentReplyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutFile

        internal virtual PutFileResponse PutFile(PutFileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFileResponseUnmarshaller.Instance;

            return Invoke<PutFileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutFile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutFile">REST API Reference for PutFile Operation</seealso>
        public virtual Task<PutFileResponse> PutFileAsync(PutFileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFileResponseUnmarshaller.Instance;

            return InvokeAsync<PutFileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRepositoryTriggers

        internal virtual PutRepositoryTriggersResponse PutRepositoryTriggers(PutRepositoryTriggersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRepositoryTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRepositoryTriggersResponseUnmarshaller.Instance;

            return Invoke<PutRepositoryTriggersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutRepositoryTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRepositoryTriggers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutRepositoryTriggers">REST API Reference for PutRepositoryTriggers Operation</seealso>
        public virtual Task<PutRepositoryTriggersResponse> PutRepositoryTriggersAsync(PutRepositoryTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRepositoryTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRepositoryTriggersResponseUnmarshaller.Instance;

            return InvokeAsync<PutRepositoryTriggersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestRepositoryTriggers

        internal virtual TestRepositoryTriggersResponse TestRepositoryTriggers(TestRepositoryTriggersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestRepositoryTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestRepositoryTriggersResponseUnmarshaller.Instance;

            return Invoke<TestRepositoryTriggersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TestRepositoryTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestRepositoryTriggers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/TestRepositoryTriggers">REST API Reference for TestRepositoryTriggers Operation</seealso>
        public virtual Task<TestRepositoryTriggersResponse> TestRepositoryTriggersAsync(TestRepositoryTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestRepositoryTriggersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestRepositoryTriggersResponseUnmarshaller.Instance;

            return InvokeAsync<TestRepositoryTriggersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateComment

        internal virtual UpdateCommentResponse UpdateComment(UpdateCommentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCommentResponseUnmarshaller.Instance;

            return Invoke<UpdateCommentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateComment">REST API Reference for UpdateComment Operation</seealso>
        public virtual Task<UpdateCommentResponse> UpdateCommentAsync(UpdateCommentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCommentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCommentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCommentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDefaultBranch

        internal virtual UpdateDefaultBranchResponse UpdateDefaultBranch(UpdateDefaultBranchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDefaultBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDefaultBranchResponseUnmarshaller.Instance;

            return Invoke<UpdateDefaultBranchResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDefaultBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultBranch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateDefaultBranch">REST API Reference for UpdateDefaultBranch Operation</seealso>
        public virtual Task<UpdateDefaultBranchResponse> UpdateDefaultBranchAsync(UpdateDefaultBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDefaultBranchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDefaultBranchResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDefaultBranchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePullRequestDescription

        internal virtual UpdatePullRequestDescriptionResponse UpdatePullRequestDescription(UpdatePullRequestDescriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdatePullRequestDescriptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePullRequestDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestDescription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestDescription">REST API Reference for UpdatePullRequestDescription Operation</seealso>
        public virtual Task<UpdatePullRequestDescriptionResponse> UpdatePullRequestDescriptionAsync(UpdatePullRequestDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestDescriptionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePullRequestDescriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePullRequestStatus

        internal virtual UpdatePullRequestStatusResponse UpdatePullRequestStatus(UpdatePullRequestStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestStatusResponseUnmarshaller.Instance;

            return Invoke<UpdatePullRequestStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePullRequestStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestStatus">REST API Reference for UpdatePullRequestStatus Operation</seealso>
        public virtual Task<UpdatePullRequestStatusResponse> UpdatePullRequestStatusAsync(UpdatePullRequestStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePullRequestStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePullRequestTitle

        internal virtual UpdatePullRequestTitleResponse UpdatePullRequestTitle(UpdatePullRequestTitleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestTitleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestTitleResponseUnmarshaller.Instance;

            return Invoke<UpdatePullRequestTitleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePullRequestTitle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestTitle operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestTitle">REST API Reference for UpdatePullRequestTitle Operation</seealso>
        public virtual Task<UpdatePullRequestTitleResponse> UpdatePullRequestTitleAsync(UpdatePullRequestTitleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePullRequestTitleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePullRequestTitleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePullRequestTitleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRepositoryDescription

        internal virtual UpdateRepositoryDescriptionResponse UpdateRepositoryDescription(UpdateRepositoryDescriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRepositoryDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRepositoryDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateRepositoryDescriptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRepositoryDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryDescription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryDescription">REST API Reference for UpdateRepositoryDescription Operation</seealso>
        public virtual Task<UpdateRepositoryDescriptionResponse> UpdateRepositoryDescriptionAsync(UpdateRepositoryDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRepositoryDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRepositoryDescriptionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRepositoryDescriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRepositoryName

        internal virtual UpdateRepositoryNameResponse UpdateRepositoryName(UpdateRepositoryNameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRepositoryNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRepositoryNameResponseUnmarshaller.Instance;

            return Invoke<UpdateRepositoryNameResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRepositoryName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryName">REST API Reference for UpdateRepositoryName Operation</seealso>
        public virtual Task<UpdateRepositoryNameResponse> UpdateRepositoryNameAsync(UpdateRepositoryNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRepositoryNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRepositoryNameResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRepositoryNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}