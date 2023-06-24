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
    /// The Identity Store service used by AWS IAM Identity Center (successor to AWS Single
    /// Sign-On) provides a single place to retrieve all of your identities (users and groups).
    /// For more information, see the <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html">IAM
    /// Identity Center User Guide</a>.
    /// 
    ///  <pre><code> &lt;note&gt; &lt;p&gt;Although AWS Single Sign-On was renamed, the &lt;code&gt;sso&lt;/code&gt;
    /// and &lt;code&gt;identitystore&lt;/code&gt; API namespaces will continue to retain
    /// their original name for backward compatibility purposes. For more information, see
    /// &lt;a href=&quot;https://docs.aws.amazon.com/singlesignon/latest/userguide/what-is.html#renamed&quot;&gt;IAM
    /// Identity Center rename&lt;/a&gt;.&lt;/p&gt; &lt;/note&gt; &lt;p&gt;This reference
    /// guide describes the identity store operations that you can call programatically and
    /// includes detailed information about data types and errors.&lt;/p&gt; </code></pre>
    /// </summary>
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIdentityStoreEndpointResolver());
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
        /// Creates a group within the specified identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ServiceQuotaExceededException">
        /// The request would cause the number of users or groups in the identity store to exceed
        /// the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
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
        /// Creates a relationship between a member and a group. The following identifiers must
        /// be specified: <code>GroupId</code>, <code>IdentityStoreId</code>, and <code>MemberId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroupMembership service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ServiceQuotaExceededException">
        /// The request would cause the number of users or groups in the identity store to exceed
        /// the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        public virtual Task<CreateGroupMembershipResponse> CreateGroupMembershipAsync(CreateGroupMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGroupMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUser

        internal virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }



        /// <summary>
        /// Creates a user within the specified identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ServiceQuotaExceededException">
        /// The request would cause the number of users or groups in the identity store to exceed
        /// the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUserResponse>(request, options, cancellationToken);
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
        /// Delete a group within an identity store given <code>GroupId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
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
        /// Delete a membership within a group given <code>MembershipId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroupMembership service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
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
        /// Deletes a user within an identity store given <code>UserId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
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
        
        #region  DescribeGroupMembership

        internal virtual DescribeGroupMembershipResponse DescribeGroupMembership(DescribeGroupMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupMembershipResponseUnmarshaller.Instance;

            return Invoke<DescribeGroupMembershipResponse>(request, options);
        }



        /// <summary>
        /// Retrieves membership metadata and attributes from <code>MembershipId</code> in an
        /// identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroupMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGroupMembership service method, as returned by IdentityStore.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeGroupMembership">REST API Reference for DescribeGroupMembership Operation</seealso>
        public virtual Task<DescribeGroupMembershipResponse> DescribeGroupMembershipAsync(DescribeGroupMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGroupMembershipResponse>(request, options, cancellationToken);
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
        /// Retrieves the user metadata and attributes from the <code>UserId</code> in an identity
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
        
        #region  GetGroupId

        internal virtual GetGroupIdResponse GetGroupId(GetGroupIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupIdResponseUnmarshaller.Instance;

            return Invoke<GetGroupIdResponse>(request, options);
        }



        /// <summary>
        /// Retrieves <code>GroupId</code> in an identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroupId service method, as returned by IdentityStore.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetGroupId">REST API Reference for GetGroupId Operation</seealso>
        public virtual Task<GetGroupIdResponse> GetGroupIdAsync(GetGroupIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupIdResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupIdResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGroupMembershipId

        internal virtual GetGroupMembershipIdResponse GetGroupMembershipId(GetGroupMembershipIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupMembershipIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupMembershipIdResponseUnmarshaller.Instance;

            return Invoke<GetGroupMembershipIdResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the <code>MembershipId</code> in an identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupMembershipId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroupMembershipId service method, as returned by IdentityStore.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetGroupMembershipId">REST API Reference for GetGroupMembershipId Operation</seealso>
        public virtual Task<GetGroupMembershipIdResponse> GetGroupMembershipIdAsync(GetGroupMembershipIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupMembershipIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupMembershipIdResponseUnmarshaller.Instance;

            return InvokeAsync<GetGroupMembershipIdResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUserId

        internal virtual GetUserIdResponse GetUserId(GetUserIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserIdResponseUnmarshaller.Instance;

            return Invoke<GetUserIdResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the <code>UserId</code> in an identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserId service method, as returned by IdentityStore.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetUserId">REST API Reference for GetUserId Operation</seealso>
        public virtual Task<GetUserIdResponse> GetUserIdAsync(GetUserIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserIdResponseUnmarshaller.Instance;

            return InvokeAsync<GetUserIdResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  IsMemberInGroups

        internal virtual IsMemberInGroupsResponse IsMemberInGroups(IsMemberInGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IsMemberInGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IsMemberInGroupsResponseUnmarshaller.Instance;

            return Invoke<IsMemberInGroupsResponse>(request, options);
        }



        /// <summary>
        /// Checks the user's membership in all requested groups and returns if the member exists
        /// in all queried groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IsMemberInGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IsMemberInGroups service method, as returned by IdentityStore.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/IsMemberInGroups">REST API Reference for IsMemberInGroups Operation</seealso>
        public virtual Task<IsMemberInGroupsResponse> IsMemberInGroupsAsync(IsMemberInGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IsMemberInGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IsMemberInGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<IsMemberInGroupsResponse>(request, options, cancellationToken);
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
        /// For the specified group in the specified identity store, returns the list of all <code>GroupMembership</code>
        /// objects and returns results in paginated form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupMemberships service method, as returned by IdentityStore.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        public virtual Task<ListGroupMembershipsResponse> ListGroupMembershipsAsync(ListGroupMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembershipsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupMembershipsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGroupMembershipsForMember

        internal virtual ListGroupMembershipsForMemberResponse ListGroupMembershipsForMember(ListGroupMembershipsForMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembershipsForMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembershipsForMemberResponseUnmarshaller.Instance;

            return Invoke<ListGroupMembershipsForMemberResponse>(request, options);
        }



        /// <summary>
        /// For the specified member in the specified identity store, returns the list of all
        /// <code>GroupMembership</code> objects and returns results in paginated form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembershipsForMember service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroupMembershipsForMember service method, as returned by IdentityStore.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroupMembershipsForMember">REST API Reference for ListGroupMembershipsForMember Operation</seealso>
        public virtual Task<ListGroupMembershipsForMemberResponse> ListGroupMembershipsForMemberAsync(ListGroupMembershipsForMemberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembershipsForMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembershipsForMemberResponseUnmarshaller.Instance;

            return InvokeAsync<ListGroupMembershipsForMemberResponse>(request, options, cancellationToken);
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
        /// Lists all groups in the identity store. Returns a paginated list of complete <code>Group</code>
        /// objects. Filtering for a <code>Group</code> by the <code>DisplayName</code> attribute
        /// is deprecated. Instead, use the <code>GetGroupId</code> API action.
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
        /// Lists all users in the identity store. Returns a paginated list of complete <code>User</code>
        /// objects. Filtering for a <code>User</code> by the <code>UserName</code> attribute
        /// is deprecated. Instead, use the <code>GetUserId</code> API action.
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
        
        #region  UpdateGroup

        internal virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }



        /// <summary>
        /// For the specified group in the specified identity store, updates the group metadata
        /// and attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ServiceQuotaExceededException">
        /// The request would cause the number of users or groups in the identity store to exceed
        /// the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
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
        /// For the specified user in the specified identity store, updates the user metadata
        /// and attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by IdentityStore.</returns>
        /// <exception cref="Amazon.IdentityStore.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Performing the requested operation would violate an existing uniqueness claim in the
        /// identity store. Resolve the conflict before retrying this request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The requested resource was being concurrently modified by another request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ResourceNotFoundException">
        /// Indicates that a requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ServiceQuotaExceededException">
        /// The request would cause the number of users or groups in the identity store to exceed
        /// the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ThrottlingException">
        /// Indicates that the principal has crossed the throttling limits of the API operations.
        /// </exception>
        /// <exception cref="Amazon.IdentityStore.Model.ValidationException">
        /// The request failed because it contains a syntax error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
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