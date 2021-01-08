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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IdentityStore.Model;
using Amazon.IdentityStore.Model.Internal.MarshallTransformations;
using Amazon.IdentityStore.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IdentityStore
{
    /// <summary>
    /// Implementation for accessing IdentityStore
    ///
    /// 
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonIdentityStoreClient : AmazonServiceClient, IAmazonIdentityStore
    {
        private static IServiceMetadata serviceMetadata = new AmazonIdentityStoreMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonIdentityStoreClient with the credentials loaded from the application's
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
        public AmazonIdentityStoreClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIdentityStoreConfig()) { }

        /// <summary>
        /// Constructs AmazonIdentityStoreClient with the credentials loaded from the application's
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
        public AmazonIdentityStoreClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIdentityStoreConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIdentityStoreClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIdentityStoreClient Configuration Object</param>
        public AmazonIdentityStoreClient(AmazonIdentityStoreConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonIdentityStoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIdentityStoreClient(AWSCredentials credentials)
            : this(credentials, new AmazonIdentityStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityStoreClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityStoreClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIdentityStoreConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityStoreClient with AWS Credentials and an
        /// AmazonIdentityStoreClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIdentityStoreClient Configuration Object</param>
        public AmazonIdentityStoreClient(AWSCredentials credentials, AmazonIdentityStoreConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIdentityStoreClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIdentityStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityStoreClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIdentityStoreConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityStoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIdentityStoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIdentityStoreClient Configuration Object</param>
        public AmazonIdentityStoreClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIdentityStoreConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIdentityStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIdentityStoreConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityStoreClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIdentityStoreConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityStoreClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIdentityStoreClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIdentityStoreClient Configuration Object</param>
        public AmazonIdentityStoreClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIdentityStoreConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IIdentityStorePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIdentityStorePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IdentityStorePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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


        #region  DescribeGroup

        internal virtual DescribeGroupResponse DescribeGroup(DescribeGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeGroupResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the group metadata and attributes from <code>GroupId</code> in an identity
        /// store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
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
        /// Retrieves the user metadata and attributes from <code>UserId</code> in an identity
        /// store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeUserResponse>(request, options, cancellationToken);
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
        /// Lists the attribute name and value of the group that you specified in the search.
        /// We only support <code>DisplayName</code> as a valid filter attribute path currently,
        /// and filter is required. This API returns minimum attributes, including <code>GroupId</code>
        /// and group <code>DisplayName</code> in the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupsResponse>(request, options, cancellationToken);
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
        /// Lists the attribute name and value of the user that you specified in the search. We
        /// only support <code>UserName</code> as a valid filter attribute path currently, and
        /// filter is required. This API returns minimum attributes, including <code>UserId</code>
        /// and <code>UserName</code> in the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsersResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}