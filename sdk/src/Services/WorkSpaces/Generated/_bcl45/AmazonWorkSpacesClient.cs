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

        
        #region  CreateWorkspaces

        /// <summary>
        /// Creates one or more WorkSpaces.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is asynchronous and returns before the WorkSpaces are created.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaces service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        public CreateWorkspacesResponse CreateWorkspaces(CreateWorkspacesRequest request)
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
        
        #region  DescribeWorkspaceBundles

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
        /// 
        /// <returns>The response from the DescribeWorkspaceBundles service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        public DescribeWorkspaceBundlesResponse DescribeWorkspaceBundles()
        {
            var request = new DescribeWorkspaceBundlesRequest();
            return DescribeWorkspaceBundles(request);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceBundles service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceBundles service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        public DescribeWorkspaceBundlesResponse DescribeWorkspaceBundles(DescribeWorkspaceBundlesRequest request)
        {
            var marshaller = new DescribeWorkspaceBundlesRequestMarshaller();
            var unmarshaller = DescribeWorkspaceBundlesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceBundlesRequest,DescribeWorkspaceBundlesResponse>(request, marshaller, unmarshaller);
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
        /// 
        /// <returns>The response from the DescribeWorkspaceDirectories service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        public DescribeWorkspaceDirectoriesResponse DescribeWorkspaceDirectories()
        {
            var request = new DescribeWorkspaceDirectoriesRequest();
            return DescribeWorkspaceDirectories(request);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceDirectories service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceDirectories service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        public DescribeWorkspaceDirectoriesResponse DescribeWorkspaceDirectories(DescribeWorkspaceDirectoriesRequest request)
        {
            var marshaller = new DescribeWorkspaceDirectoriesRequestMarshaller();
            var unmarshaller = DescribeWorkspaceDirectoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceDirectoriesRequest,DescribeWorkspaceDirectoriesResponse>(request, marshaller, unmarshaller);
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
        /// 
        /// <returns>The response from the DescribeWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        public DescribeWorkspacesResponse DescribeWorkspaces()
        {
            var request = new DescribeWorkspacesRequest();
            return DescribeWorkspaces(request);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaces service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        public DescribeWorkspacesResponse DescribeWorkspaces(DescribeWorkspacesRequest request)
        {
            var marshaller = new DescribeWorkspacesRequestMarshaller();
            var unmarshaller = DescribeWorkspacesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspacesRequest,DescribeWorkspacesResponse>(request, marshaller, unmarshaller);
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

        /// <summary>
        /// Reboots the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// To be able to reboot a WorkSpace, the WorkSpace must have a <b>State</b> of <code>AVAILABLE</code>,
        /// <code>IMPAIRED</code>, or <code>INOPERABLE</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is asynchronous and will return before the WorkSpaces have rebooted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootWorkspaces service method.</param>
        /// 
        /// <returns>The response from the RebootWorkspaces service method, as returned by WorkSpaces.</returns>
        public RebootWorkspacesResponse RebootWorkspaces(RebootWorkspacesRequest request)
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

        /// <summary>
        /// Rebuilds the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// Rebuilding a WorkSpace is a potentially destructive action that can result in the
        /// loss of data. Rebuilding a WorkSpace causes the following to occur:
        /// </para>
        ///  <ul> <li>The system is restored to the image of the bundle that the WorkSpace is
        /// created from. Any applications that have been installed, or system settings that have
        /// been made since the WorkSpace was created will be lost.</li> <li>The data drive (D
        /// drive) is re-created from the last automatic snapshot taken of the data drive. The
        /// current contents of the data drive are overwritten. Automatic snapshots of the data
        /// drive are taken every 12 hours, so the snapshot can be as much as 12 hours old.</li>
        /// </ul> 
        /// <para>
        /// To be able to rebuild a WorkSpace, the WorkSpace must have a <b>State</b> of <code>AVAILABLE</code>
        /// or <code>ERROR</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is asynchronous and will return before the WorkSpaces have been completely
        /// rebuilt.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebuildWorkspaces service method.</param>
        /// 
        /// <returns>The response from the RebuildWorkspaces service method, as returned by WorkSpaces.</returns>
        public RebuildWorkspacesResponse RebuildWorkspaces(RebuildWorkspacesRequest request)
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

        /// <summary>
        /// Terminates the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// Terminating a WorkSpace is a permanent action and cannot be undone. The user's data
        /// is not maintained and will be destroyed. If you need to archive any user data, contact
        /// Amazon Web Services before terminating the WorkSpace.
        /// </para>
        ///  
        /// <para>
        /// You can terminate a WorkSpace that is in any state except <code>SUSPENDED</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is asynchronous and will return before the WorkSpaces have been completely
        /// terminated.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkspaces service method.</param>
        /// 
        /// <returns>The response from the TerminateWorkspaces service method, as returned by WorkSpaces.</returns>
        public TerminateWorkspacesResponse TerminateWorkspaces(TerminateWorkspacesRequest request)
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