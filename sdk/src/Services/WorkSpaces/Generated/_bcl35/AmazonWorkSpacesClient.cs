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
    /// This reference provides detailed information about the Amazon WorkSpaces operations.
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

        
        #region  CreateTags

        /// <summary>
        /// Creates tags for a WorkSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        public CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsRequest,CreateTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTags
        ///         operation.</returns>
        public IAsyncResult BeginCreateTags(CreateTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return BeginInvoke<CreateTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTags.</param>
        /// 
        /// <returns>Returns a  CreateTagsResult from WorkSpaces.</returns>
        public  CreateTagsResponse EndCreateTags(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTagsResponse>(asyncResult);
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
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspaces
        ///         operation.</returns>
        public IAsyncResult BeginCreateWorkspaces(CreateWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateWorkspacesRequestMarshaller();
            var unmarshaller = CreateWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke<CreateWorkspacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspaces.</param>
        /// 
        /// <returns>Returns a  CreateWorkspacesResult from WorkSpaces.</returns>
        public  CreateWorkspacesResponse EndCreateWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkspacesResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTags

        /// <summary>
        /// Deletes tags from a WorkSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        public DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        public IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from WorkSpaces.</returns>
        public  DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTags

        /// <summary>
        /// Describes tags for a WorkSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from WorkSpaces.</returns>
        public  DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTagsResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceBundles operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaceBundles
        ///         operation.</returns>
        public IAsyncResult BeginDescribeWorkspaceBundles(DescribeWorkspaceBundlesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeWorkspaceBundlesRequestMarshaller();
            var unmarshaller = DescribeWorkspaceBundlesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeWorkspaceBundlesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceBundles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceBundles.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceBundlesResult from WorkSpaces.</returns>
        public  DescribeWorkspaceBundlesResponse EndDescribeWorkspaceBundles(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspaceBundlesResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceDirectories operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaceDirectories
        ///         operation.</returns>
        public IAsyncResult BeginDescribeWorkspaceDirectories(DescribeWorkspaceDirectoriesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeWorkspaceDirectoriesRequestMarshaller();
            var unmarshaller = DescribeWorkspaceDirectoriesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeWorkspaceDirectoriesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceDirectories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceDirectories.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceDirectoriesResult from WorkSpaces.</returns>
        public  DescribeWorkspaceDirectoriesResponse EndDescribeWorkspaceDirectories(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspaceDirectoriesResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaces
        ///         operation.</returns>
        public IAsyncResult BeginDescribeWorkspaces(DescribeWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeWorkspacesRequestMarshaller();
            var unmarshaller = DescribeWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeWorkspacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaces.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspacesResult from WorkSpaces.</returns>
        public  DescribeWorkspacesResponse EndDescribeWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspacesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkspacesConnectionStatus

        /// <summary>
        /// Describes the connection status of a specified WorkSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspacesConnectionStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspacesConnectionStatus service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        public DescribeWorkspacesConnectionStatusResponse DescribeWorkspacesConnectionStatus(DescribeWorkspacesConnectionStatusRequest request)
        {
            var marshaller = new DescribeWorkspacesConnectionStatusRequestMarshaller();
            var unmarshaller = DescribeWorkspacesConnectionStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspacesConnectionStatusRequest,DescribeWorkspacesConnectionStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspacesConnectionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspacesConnectionStatus operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspacesConnectionStatus
        ///         operation.</returns>
        public IAsyncResult BeginDescribeWorkspacesConnectionStatus(DescribeWorkspacesConnectionStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeWorkspacesConnectionStatusRequestMarshaller();
            var unmarshaller = DescribeWorkspacesConnectionStatusResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeWorkspacesConnectionStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspacesConnectionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspacesConnectionStatus.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspacesConnectionStatusResult from WorkSpaces.</returns>
        public  DescribeWorkspacesConnectionStatusResponse EndDescribeWorkspacesConnectionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspacesConnectionStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyWorkspaceProperties

        /// <summary>
        /// Modifies the WorkSpace properties, including the RunningMode and AutoStop time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceProperties service method.</param>
        /// 
        /// <returns>The response from the ModifyWorkspaceProperties service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The specified WorkSpace has an invalid state for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationInProgressException">
        /// The properties of this WorkSpace are currently being modified. Try again in a moment.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.UnsupportedWorkspaceConfigurationException">
        /// The WorkSpace does not have the supported configuration for this operation. For more
        /// information, see the <a href="http://docs.aws.amazon.com/workspaces/latest/adminguide">Amazon
        /// WorkSpaces Administration Guide</a>.
        /// </exception>
        public ModifyWorkspacePropertiesResponse ModifyWorkspaceProperties(ModifyWorkspacePropertiesRequest request)
        {
            var marshaller = new ModifyWorkspacePropertiesRequestMarshaller();
            var unmarshaller = ModifyWorkspacePropertiesResponseUnmarshaller.Instance;

            return Invoke<ModifyWorkspacePropertiesRequest,ModifyWorkspacePropertiesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyWorkspaceProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceProperties operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyWorkspaceProperties
        ///         operation.</returns>
        public IAsyncResult BeginModifyWorkspaceProperties(ModifyWorkspacePropertiesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyWorkspacePropertiesRequestMarshaller();
            var unmarshaller = ModifyWorkspacePropertiesResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyWorkspacePropertiesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyWorkspaceProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyWorkspaceProperties.</param>
        /// 
        /// <returns>Returns a  ModifyWorkspacePropertiesResult from WorkSpaces.</returns>
        public  ModifyWorkspacePropertiesResponse EndModifyWorkspaceProperties(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyWorkspacePropertiesResponse>(asyncResult);
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
        /// This operation is asynchronous and returns before the WorkSpaces have rebooted.
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
        /// <param name="request">Container for the necessary parameters to execute the RebootWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootWorkspaces
        ///         operation.</returns>
        public IAsyncResult BeginRebootWorkspaces(RebootWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RebootWorkspacesRequestMarshaller();
            var unmarshaller = RebootWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke<RebootWorkspacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RebootWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootWorkspaces.</param>
        /// 
        /// <returns>Returns a  RebootWorkspacesResult from WorkSpaces.</returns>
        public  RebootWorkspacesResponse EndRebootWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<RebootWorkspacesResponse>(asyncResult);
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
        ///  <ul> <li> 
        /// <para>
        /// The system is restored to the image of the bundle that the WorkSpace is created from.
        /// Any applications that have been installed, or system settings that have been made
        /// since the WorkSpace was created will be lost.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The data drive (D drive) is re-created from the last automatic snapshot taken of the
        /// data drive. The current contents of the data drive are overwritten. Automatic snapshots
        /// of the data drive are taken every 12 hours, so the snapshot can be as much as 12 hours
        /// old.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To be able to rebuild a WorkSpace, the WorkSpace must have a <b>State</b> of <code>AVAILABLE</code>
        /// or <code>ERROR</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is asynchronous and returns before the WorkSpaces have been completely
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
        /// <param name="request">Container for the necessary parameters to execute the RebuildWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebuildWorkspaces
        ///         operation.</returns>
        public IAsyncResult BeginRebuildWorkspaces(RebuildWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RebuildWorkspacesRequestMarshaller();
            var unmarshaller = RebuildWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke<RebuildWorkspacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RebuildWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebuildWorkspaces.</param>
        /// 
        /// <returns>Returns a  RebuildWorkspacesResult from WorkSpaces.</returns>
        public  RebuildWorkspacesResponse EndRebuildWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<RebuildWorkspacesResponse>(asyncResult);
        }

        #endregion
        
        #region  StartWorkspaces

        /// <summary>
        /// Starts the specified WorkSpaces. The API only works with WorkSpaces that have RunningMode
        /// configured as AutoStop and the State set to “STOPPED.”
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkspaces service method.</param>
        /// 
        /// <returns>The response from the StartWorkspaces service method, as returned by WorkSpaces.</returns>
        public StartWorkspacesResponse StartWorkspaces(StartWorkspacesRequest request)
        {
            var marshaller = new StartWorkspacesRequestMarshaller();
            var unmarshaller = StartWorkspacesResponseUnmarshaller.Instance;

            return Invoke<StartWorkspacesRequest,StartWorkspacesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartWorkspaces
        ///         operation.</returns>
        public IAsyncResult BeginStartWorkspaces(StartWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StartWorkspacesRequestMarshaller();
            var unmarshaller = StartWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke<StartWorkspacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartWorkspaces.</param>
        /// 
        /// <returns>Returns a  StartWorkspacesResult from WorkSpaces.</returns>
        public  StartWorkspacesResponse EndStartWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<StartWorkspacesResponse>(asyncResult);
        }

        #endregion
        
        #region  StopWorkspaces

        /// <summary>
        /// Stops the specified WorkSpaces. The API only works with WorkSpaces that have RunningMode
        /// configured as AutoStop and the State set to AVAILABLE, IMPAIRED, UNHEALTHY, or ERROR.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopWorkspaces service method.</param>
        /// 
        /// <returns>The response from the StopWorkspaces service method, as returned by WorkSpaces.</returns>
        public StopWorkspacesResponse StopWorkspaces(StopWorkspacesRequest request)
        {
            var marshaller = new StopWorkspacesRequestMarshaller();
            var unmarshaller = StopWorkspacesResponseUnmarshaller.Instance;

            return Invoke<StopWorkspacesRequest,StopWorkspacesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopWorkspaces
        ///         operation.</returns>
        public IAsyncResult BeginStopWorkspaces(StopWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StopWorkspacesRequestMarshaller();
            var unmarshaller = StopWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke<StopWorkspacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopWorkspaces.</param>
        /// 
        /// <returns>Returns a  StopWorkspacesResult from WorkSpaces.</returns>
        public  StopWorkspacesResponse EndStopWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<StopWorkspacesResponse>(asyncResult);
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
        /// This operation is asynchronous and returns before the WorkSpaces have been completely
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
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkspaces operation on AmazonWorkSpacesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateWorkspaces
        ///         operation.</returns>
        public IAsyncResult BeginTerminateWorkspaces(TerminateWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new TerminateWorkspacesRequestMarshaller();
            var unmarshaller = TerminateWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke<TerminateWorkspacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateWorkspaces.</param>
        /// 
        /// <returns>Returns a  TerminateWorkspacesResult from WorkSpaces.</returns>
        public  TerminateWorkspacesResponse EndTerminateWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateWorkspacesResponse>(asyncResult);
        }

        #endregion
        
    }
}