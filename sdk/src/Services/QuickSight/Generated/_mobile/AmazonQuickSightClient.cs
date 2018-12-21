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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.QuickSight.Model;
using Amazon.QuickSight.Model.Internal.MarshallTransformations;
using Amazon.QuickSight.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.QuickSight
{
    /// <summary>
    /// Implementation for accessing QuickSight
    ///
    /// Amazon QuickSight API Reference 
    /// <para>
    /// Amazon QuickSight is a fully managed, serverless, cloud business intelligence service
    /// that makes it easy to extend data and insights to every user in your organization.
    /// This API interface reference contains documentation for a programming interface that
    /// you can use to manage Amazon QuickSight. 
    /// </para>
    /// </summary>
    public partial class AmazonQuickSightClient : AmazonServiceClient, IAmazonQuickSight
    {
        private static IServiceMetadata serviceMetadata = new AmazonQuickSightMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonQuickSightClient with the credentials loaded from the application's
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
        public AmazonQuickSightClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQuickSightConfig()) { }

        /// <summary>
        /// Constructs AmazonQuickSightClient with the credentials loaded from the application's
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
        public AmazonQuickSightClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonQuickSightConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonQuickSightClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(AmazonQuickSightConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonQuickSightClient(AWSCredentials credentials)
            : this(credentials, new AmazonQuickSightConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQuickSightClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonQuickSightConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Credentials and an
        /// AmazonQuickSightClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(AWSCredentials credentials, AmazonQuickSightConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQuickSightConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonQuickSightConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQuickSightClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonQuickSightConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQuickSightConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonQuickSightConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonQuickSightClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonQuickSightClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonQuickSightClient Configuration Object</param>
        public AmazonQuickSightClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonQuickSightConfig clientConfig)
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


        #region  CreateGroup

        internal virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGroupMembership

        internal virtual CreateGroupMembershipResponse CreateGroupMembership(CreateGroupMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateGroupMembershipResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        public virtual Task<CreateGroupMembershipResponse> CreateGroupMembershipAsync(CreateGroupMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroup

        internal virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGroupMembership

        internal virtual DeleteGroupMembershipResponse DeleteGroupMembership(DeleteGroupMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupMembershipResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        public virtual Task<DeleteGroupMembershipResponse> DeleteGroupMembershipAsync(DeleteGroupMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGroupMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUser

        internal virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGroup

        internal virtual DescribeGroupResponse DescribeGroup(DescribeGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual Task<DescribeGroupResponse> DescribeGroupAsync(DescribeGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeUser

        internal virtual DescribeUserResponse DescribeUser(DescribeUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return Invoke<DescribeUserResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDashboardEmbedUrl

        internal virtual GetDashboardEmbedUrlResponse GetDashboardEmbedUrl(GetDashboardEmbedUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDashboardEmbedUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDashboardEmbedUrlResponseUnmarshaller.Instance;

            return Invoke<GetDashboardEmbedUrlResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDashboardEmbedUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDashboardEmbedUrl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/GetDashboardEmbedUrl">REST API Reference for GetDashboardEmbedUrl Operation</seealso>
        public virtual Task<GetDashboardEmbedUrlResponse> GetDashboardEmbedUrlAsync(GetDashboardEmbedUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDashboardEmbedUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDashboardEmbedUrlResponseUnmarshaller.Instance;

            return InvokeAsync<GetDashboardEmbedUrlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGroupMemberships

        internal virtual ListGroupMembershipsResponse ListGroupMemberships(ListGroupMembershipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListGroupMembershipsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        public virtual Task<ListGroupMembershipsResponse> ListGroupMembershipsAsync(ListGroupMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembershipsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupMembershipsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGroups

        internal virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUserGroups

        internal virtual ListUserGroupsResponse ListUserGroups(ListUserGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserGroupsResponseUnmarshaller.Instance;

            return Invoke<ListUserGroupsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListUserGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUserGroups">REST API Reference for ListUserGroups Operation</seealso>
        public virtual Task<ListUserGroupsResponse> ListUserGroupsAsync(ListUserGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUserGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUserGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUserGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUsers

        internal virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterUser

        internal virtual RegisterUserResponse RegisterUser(RegisterUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterUserResponseUnmarshaller.Instance;

            return Invoke<RegisterUserResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/RegisterUser">REST API Reference for RegisterUser Operation</seealso>
        public virtual Task<RegisterUserResponse> RegisterUserAsync(RegisterUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterUserResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGroup

        internal virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUser

        internal virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/quicksight-2018-04-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}