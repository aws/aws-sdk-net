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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.WorkSpaces.Model;
using Amazon.WorkSpaces.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.WorkSpaces
{
    /// <summary>
    /// Implementation for accessing WorkSpaces
    ///
    /// Amazon WorkSpaces Service 
    /// <para>
    /// This is the <i>Amazon WorkSpaces API Reference</i>. This guide provides detailed information
    /// about Amazon WorkSpaces operations, data types, parameters, and errors.
    /// </para>
    /// </summary>
    public partial class AmazonWorkSpacesClient : AmazonServiceClient, IAmazonWorkSpaces
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonWorkSpacesClient with the credentials loaded from the application's
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
        public AmazonWorkSpacesClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkSpacesConfig()) { }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with the credentials loaded from the application's
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
        public AmazonWorkSpacesClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkSpacesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWorkSpacesClient Configuration Object</param>
        public AmazonWorkSpacesClient(AmazonWorkSpacesConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWorkSpacesClient(AWSCredentials credentials)
            : this(credentials, new AmazonWorkSpacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWorkSpacesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Credentials and an
        /// AmazonWorkSpacesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWorkSpacesClient Configuration Object</param>
        public AmazonWorkSpacesClient(AWSCredentials credentials, AmazonWorkSpacesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkSpacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkSpacesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkSpacesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWorkSpacesClient Configuration Object</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWorkSpacesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkSpacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkSpacesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkSpacesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWorkSpacesClient Configuration Object</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWorkSpacesConfig clientConfig)
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

        
        #region  CreateTags

        internal CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsRequest,CreateTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagsRequest,CreateTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkspaces

        internal CreateWorkspacesResponse CreateWorkspaces(CreateWorkspacesRequest request)
        {
            var marshaller = new CreateWorkspacesRequestMarshaller();
            var unmarshaller = CreateWorkspacesResponseUnmarshaller.Instance;

            return Invoke<CreateWorkspacesRequest,CreateWorkspacesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateWorkspacesResponse> CreateWorkspacesAsync(CreateWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateWorkspacesRequestMarshaller();
            var unmarshaller = CreateWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkspacesRequest,CreateWorkspacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaceBundles

        internal DescribeWorkspaceBundlesResponse DescribeWorkspaceBundles(DescribeWorkspaceBundlesRequest request)
        {
            var marshaller = new DescribeWorkspaceBundlesRequestMarshaller();
            var unmarshaller = DescribeWorkspaceBundlesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceBundlesRequest,DescribeWorkspaceBundlesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Obtains information about the WorkSpace bundles that are available to your account
        /// in the specified region.
        /// 
        ///  
        /// <para>
        /// You can filter the results with either the <code>BundleIds</code> parameter, or the
        /// <code>Owner</code> parameter, but not both.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> request
        /// and response parameters. If more results are available, the <code>NextToken</code>
        /// response member contains a token that you pass in the next call to this operation
        /// to retrieve the next set of items.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceBundles service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        public Task<DescribeWorkspaceBundlesResponse> DescribeWorkspaceBundlesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeWorkspaceBundlesRequest();
            return DescribeWorkspaceBundlesAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceBundles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceBundles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeWorkspaceBundlesResponse> DescribeWorkspaceBundlesAsync(DescribeWorkspaceBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeWorkspaceBundlesRequestMarshaller();
            var unmarshaller = DescribeWorkspaceBundlesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspaceBundlesRequest,DescribeWorkspaceBundlesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaceDirectories

        internal DescribeWorkspaceDirectoriesResponse DescribeWorkspaceDirectories(DescribeWorkspaceDirectoriesRequest request)
        {
            var marshaller = new DescribeWorkspaceDirectoriesRequestMarshaller();
            var unmarshaller = DescribeWorkspaceDirectoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceDirectoriesRequest,DescribeWorkspaceDirectoriesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves information about the AWS Directory Service directories in the region that
        /// are registered with Amazon WorkSpaces and are available to your account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> request
        /// and response parameters. If more results are available, the <code>NextToken</code>
        /// response member contains a token that you pass in the next call to this operation
        /// to retrieve the next set of items.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceDirectories service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        public Task<DescribeWorkspaceDirectoriesResponse> DescribeWorkspaceDirectoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeWorkspaceDirectoriesRequest();
            return DescribeWorkspaceDirectoriesAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceDirectories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceDirectories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeWorkspaceDirectoriesResponse> DescribeWorkspaceDirectoriesAsync(DescribeWorkspaceDirectoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeWorkspaceDirectoriesRequestMarshaller();
            var unmarshaller = DescribeWorkspaceDirectoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspaceDirectoriesRequest,DescribeWorkspaceDirectoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaces

        internal DescribeWorkspacesResponse DescribeWorkspaces(DescribeWorkspacesRequest request)
        {
            var marshaller = new DescribeWorkspacesRequestMarshaller();
            var unmarshaller = DescribeWorkspacesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspacesRequest,DescribeWorkspacesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Obtains information about the specified WorkSpaces. 
        /// 
        ///  
        /// <para>
        /// Only one of the filter parameters, such as <code>BundleId</code>, <code>DirectoryId</code>,
        /// or <code>WorkspaceIds</code>, can be specified at a time.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> request
        /// and response parameters. If more results are available, the <code>NextToken</code>
        /// response member contains a token that you pass in the next call to this operation
        /// to retrieve the next set of items.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        public Task<DescribeWorkspacesResponse> DescribeWorkspacesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeWorkspacesRequest();
            return DescribeWorkspacesAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeWorkspacesResponse> DescribeWorkspacesAsync(DescribeWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeWorkspacesRequestMarshaller();
            var unmarshaller = DescribeWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspacesRequest,DescribeWorkspacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RebootWorkspaces

        internal RebootWorkspacesResponse RebootWorkspaces(RebootWorkspacesRequest request)
        {
            var marshaller = new RebootWorkspacesRequestMarshaller();
            var unmarshaller = RebootWorkspacesResponseUnmarshaller.Instance;

            return Invoke<RebootWorkspacesRequest,RebootWorkspacesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RebootWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootWorkspaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RebootWorkspacesResponse> RebootWorkspacesAsync(RebootWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootWorkspacesRequestMarshaller();
            var unmarshaller = RebootWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<RebootWorkspacesRequest,RebootWorkspacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RebuildWorkspaces

        internal RebuildWorkspacesResponse RebuildWorkspaces(RebuildWorkspacesRequest request)
        {
            var marshaller = new RebuildWorkspacesRequestMarshaller();
            var unmarshaller = RebuildWorkspacesResponseUnmarshaller.Instance;

            return Invoke<RebuildWorkspacesRequest,RebuildWorkspacesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RebuildWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebuildWorkspaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RebuildWorkspacesResponse> RebuildWorkspacesAsync(RebuildWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebuildWorkspacesRequestMarshaller();
            var unmarshaller = RebuildWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<RebuildWorkspacesRequest,RebuildWorkspacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TerminateWorkspaces

        internal TerminateWorkspacesResponse TerminateWorkspaces(TerminateWorkspacesRequest request)
        {
            var marshaller = new TerminateWorkspacesRequestMarshaller();
            var unmarshaller = TerminateWorkspacesResponseUnmarshaller.Instance;

            return Invoke<TerminateWorkspacesRequest,TerminateWorkspacesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkspaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<TerminateWorkspacesResponse> TerminateWorkspacesAsync(TerminateWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TerminateWorkspacesRequestMarshaller();
            var unmarshaller = TerminateWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateWorkspacesRequest,TerminateWorkspacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}