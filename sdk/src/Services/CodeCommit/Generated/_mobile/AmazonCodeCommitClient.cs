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

using Amazon.CodeCommit.Model;
using Amazon.CodeCommit.Model.Internal.MarshallTransformations;
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
    /// of the operations and data types for AWS CodeCommit API.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodeCommit API to work with the following objects:
    /// </para>
    ///  <ul> <li>Repositories, by calling the following: <ul> <li><a>BatchGetRepositories</a>,
    /// which returns information about one or more repositories associated with your AWS
    /// account</li> <li><a>CreateRepository</a>, which creates an AWS CodeCommit repository</li>
    /// <li><a>DeleteRepository</a>, which deletes an AWS CodeCommit repository</li> <li><a>GetRepository</a>,
    /// which returns information about a specified repository</li> <li><a>ListRepositories</a>,
    /// which lists all AWS CodeCommit repositories associated with your AWS account</li>
    /// <li><a>UpdateRepositoryDescription</a>, which sets or updates the description of the
    /// repository</li> <li><a>UpdateRepositoryName</a>, which changes the name of the repository.
    /// If you change the name of a repository, no other users of that repository will be
    /// able to access it until you send them the new HTTPS or SSH URL to use.</li> </ul></li>
    /// <li>Branches, by calling the following: <ul> <li><a>CreateBranch</a>, which creates
    /// a new branch in a specified repository</li> <li><a>GetBranch</a>, which returns information
    /// about a specified branch</li> <li><a>ListBranches</a>, which lists all branches for
    /// a specified repository</li> <li><a>UpdateDefaultBranch</a>, which changes the default
    /// branch for a repository</li> </ul></li> <li>Information about committed code in a
    /// repository, by calling the following: <ul> <li><a>GetCommit</a>, which returns information
    /// about a commit, including commit messages and committer information.</li> </ul></li>
    /// <li>Triggers, by calling the following: <ul> <li><a>GetRepositoryTriggers</a>, which
    /// returns information about triggers configured for a repository</li> <li><a>PutRepositoryTriggers</a>,
    /// which replaces all triggers for a repository and can be used to create or delete triggers</li>
    /// <li><a>TestRepositoryTriggers</a>, which tests the functionality of a repository trigger
    /// by sending data to the trigger target</li> </ul> </li> </ul> 
    /// <para>
    /// For information about how to use AWS CodeCommit, see the <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">AWS
    /// CodeCommit User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCodeCommitClient : AmazonServiceClient, IAmazonCodeCommit
    {
        
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

        internal BatchGetRepositoriesResponse BatchGetRepositories(BatchGetRepositoriesRequest request)
        {
            var marshaller = new BatchGetRepositoriesRequestMarshaller();
            var unmarshaller = BatchGetRepositoriesResponseUnmarshaller.Instance;

            return Invoke<BatchGetRepositoriesRequest,BatchGetRepositoriesResponse>(request, marshaller, unmarshaller);
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
        public Task<BatchGetRepositoriesResponse> BatchGetRepositoriesAsync(BatchGetRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchGetRepositoriesRequestMarshaller();
            var unmarshaller = BatchGetRepositoriesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetRepositoriesRequest,BatchGetRepositoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateBranch

        internal CreateBranchResponse CreateBranch(CreateBranchRequest request)
        {
            var marshaller = new CreateBranchRequestMarshaller();
            var unmarshaller = CreateBranchResponseUnmarshaller.Instance;

            return Invoke<CreateBranchRequest,CreateBranchResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateBranchResponse> CreateBranchAsync(CreateBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateBranchRequestMarshaller();
            var unmarshaller = CreateBranchResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBranchRequest,CreateBranchResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRepository

        internal CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request)
        {
            var marshaller = new CreateRepositoryRequestMarshaller();
            var unmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return Invoke<CreateRepositoryRequest,CreateRepositoryResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRepositoryRequestMarshaller();
            var unmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRepositoryRequest,CreateRepositoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRepository

        internal DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request)
        {
            var marshaller = new DeleteRepositoryRequestMarshaller();
            var unmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return Invoke<DeleteRepositoryRequest,DeleteRepositoryResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRepositoryRequestMarshaller();
            var unmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRepositoryRequest,DeleteRepositoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBranch

        internal GetBranchResponse GetBranch(GetBranchRequest request)
        {
            var marshaller = new GetBranchRequestMarshaller();
            var unmarshaller = GetBranchResponseUnmarshaller.Instance;

            return Invoke<GetBranchRequest,GetBranchResponse>(request, marshaller, unmarshaller);
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
        public Task<GetBranchResponse> GetBranchAsync(GetBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBranchRequestMarshaller();
            var unmarshaller = GetBranchResponseUnmarshaller.Instance;

            return InvokeAsync<GetBranchRequest,GetBranchResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCommit

        internal GetCommitResponse GetCommit(GetCommitRequest request)
        {
            var marshaller = new GetCommitRequestMarshaller();
            var unmarshaller = GetCommitResponseUnmarshaller.Instance;

            return Invoke<GetCommitRequest,GetCommitResponse>(request, marshaller, unmarshaller);
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
        public Task<GetCommitResponse> GetCommitAsync(GetCommitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCommitRequestMarshaller();
            var unmarshaller = GetCommitResponseUnmarshaller.Instance;

            return InvokeAsync<GetCommitRequest,GetCommitResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRepository

        internal GetRepositoryResponse GetRepository(GetRepositoryRequest request)
        {
            var marshaller = new GetRepositoryRequestMarshaller();
            var unmarshaller = GetRepositoryResponseUnmarshaller.Instance;

            return Invoke<GetRepositoryRequest,GetRepositoryResponse>(request, marshaller, unmarshaller);
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
        public Task<GetRepositoryResponse> GetRepositoryAsync(GetRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetRepositoryRequestMarshaller();
            var unmarshaller = GetRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetRepositoryRequest,GetRepositoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRepositoryTriggers

        internal GetRepositoryTriggersResponse GetRepositoryTriggers(GetRepositoryTriggersRequest request)
        {
            var marshaller = new GetRepositoryTriggersRequestMarshaller();
            var unmarshaller = GetRepositoryTriggersResponseUnmarshaller.Instance;

            return Invoke<GetRepositoryTriggersRequest,GetRepositoryTriggersResponse>(request, marshaller, unmarshaller);
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
        public Task<GetRepositoryTriggersResponse> GetRepositoryTriggersAsync(GetRepositoryTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetRepositoryTriggersRequestMarshaller();
            var unmarshaller = GetRepositoryTriggersResponseUnmarshaller.Instance;

            return InvokeAsync<GetRepositoryTriggersRequest,GetRepositoryTriggersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListBranches

        internal ListBranchesResponse ListBranches(ListBranchesRequest request)
        {
            var marshaller = new ListBranchesRequestMarshaller();
            var unmarshaller = ListBranchesResponseUnmarshaller.Instance;

            return Invoke<ListBranchesRequest,ListBranchesResponse>(request, marshaller, unmarshaller);
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
        public Task<ListBranchesResponse> ListBranchesAsync(ListBranchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListBranchesRequestMarshaller();
            var unmarshaller = ListBranchesResponseUnmarshaller.Instance;

            return InvokeAsync<ListBranchesRequest,ListBranchesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRepositories

        internal ListRepositoriesResponse ListRepositories(ListRepositoriesRequest request)
        {
            var marshaller = new ListRepositoriesRequestMarshaller();
            var unmarshaller = ListRepositoriesResponseUnmarshaller.Instance;

            return Invoke<ListRepositoriesRequest,ListRepositoriesResponse>(request, marshaller, unmarshaller);
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
        public Task<ListRepositoriesResponse> ListRepositoriesAsync(ListRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListRepositoriesRequestMarshaller();
            var unmarshaller = ListRepositoriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRepositoriesRequest,ListRepositoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutRepositoryTriggers

        internal PutRepositoryTriggersResponse PutRepositoryTriggers(PutRepositoryTriggersRequest request)
        {
            var marshaller = new PutRepositoryTriggersRequestMarshaller();
            var unmarshaller = PutRepositoryTriggersResponseUnmarshaller.Instance;

            return Invoke<PutRepositoryTriggersRequest,PutRepositoryTriggersResponse>(request, marshaller, unmarshaller);
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
        public Task<PutRepositoryTriggersResponse> PutRepositoryTriggersAsync(PutRepositoryTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutRepositoryTriggersRequestMarshaller();
            var unmarshaller = PutRepositoryTriggersResponseUnmarshaller.Instance;

            return InvokeAsync<PutRepositoryTriggersRequest,PutRepositoryTriggersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TestRepositoryTriggers

        internal TestRepositoryTriggersResponse TestRepositoryTriggers(TestRepositoryTriggersRequest request)
        {
            var marshaller = new TestRepositoryTriggersRequestMarshaller();
            var unmarshaller = TestRepositoryTriggersResponseUnmarshaller.Instance;

            return Invoke<TestRepositoryTriggersRequest,TestRepositoryTriggersResponse>(request, marshaller, unmarshaller);
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
        public Task<TestRepositoryTriggersResponse> TestRepositoryTriggersAsync(TestRepositoryTriggersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TestRepositoryTriggersRequestMarshaller();
            var unmarshaller = TestRepositoryTriggersResponseUnmarshaller.Instance;

            return InvokeAsync<TestRepositoryTriggersRequest,TestRepositoryTriggersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDefaultBranch

        internal UpdateDefaultBranchResponse UpdateDefaultBranch(UpdateDefaultBranchRequest request)
        {
            var marshaller = new UpdateDefaultBranchRequestMarshaller();
            var unmarshaller = UpdateDefaultBranchResponseUnmarshaller.Instance;

            return Invoke<UpdateDefaultBranchRequest,UpdateDefaultBranchResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateDefaultBranchResponse> UpdateDefaultBranchAsync(UpdateDefaultBranchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDefaultBranchRequestMarshaller();
            var unmarshaller = UpdateDefaultBranchResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDefaultBranchRequest,UpdateDefaultBranchResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRepositoryDescription

        internal UpdateRepositoryDescriptionResponse UpdateRepositoryDescription(UpdateRepositoryDescriptionRequest request)
        {
            var marshaller = new UpdateRepositoryDescriptionRequestMarshaller();
            var unmarshaller = UpdateRepositoryDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateRepositoryDescriptionRequest,UpdateRepositoryDescriptionResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateRepositoryDescriptionResponse> UpdateRepositoryDescriptionAsync(UpdateRepositoryDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateRepositoryDescriptionRequestMarshaller();
            var unmarshaller = UpdateRepositoryDescriptionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRepositoryDescriptionRequest,UpdateRepositoryDescriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRepositoryName

        internal UpdateRepositoryNameResponse UpdateRepositoryName(UpdateRepositoryNameRequest request)
        {
            var marshaller = new UpdateRepositoryNameRequestMarshaller();
            var unmarshaller = UpdateRepositoryNameResponseUnmarshaller.Instance;

            return Invoke<UpdateRepositoryNameRequest,UpdateRepositoryNameResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateRepositoryNameResponse> UpdateRepositoryNameAsync(UpdateRepositoryNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateRepositoryNameRequestMarshaller();
            var unmarshaller = UpdateRepositoryNameResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRepositoryNameRequest,UpdateRepositoryNameResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}