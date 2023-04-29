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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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

        /// <summary>
        /// Creates a group within the specified identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
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
        public virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGroupMembership

        /// <summary>
        /// Creates a relationship between a member and a group. The following identifiers must
        /// be specified: <code>GroupId</code>, <code>IdentityStoreId</code>, and <code>MemberId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership service method.</param>
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
        public virtual CreateGroupMembershipResponse CreateGroupMembership(CreateGroupMembershipRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupMembership operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        public virtual IAsyncResult BeginCreateGroupMembership(CreateGroupMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroupMembership.</param>
        /// 
        /// <returns>Returns a  CreateGroupMembershipResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateGroupMembership">REST API Reference for CreateGroupMembership Operation</seealso>
        public virtual CreateGroupMembershipResponse EndCreateGroupMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUser

        /// <summary>
        /// Creates a user within the specified identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
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
        public virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse EndCreateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGroup

        /// <summary>
        /// Delete a group within an identity store given <code>GroupId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
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
        public virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGroupMembership

        /// <summary>
        /// Delete a membership within a group given <code>MembershipId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership service method.</param>
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
        public virtual DeleteGroupMembershipResponse DeleteGroupMembership(DeleteGroupMembershipRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupMembership operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        public virtual IAsyncResult BeginDeleteGroupMembership(DeleteGroupMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroupMembership.</param>
        /// 
        /// <returns>Returns a  DeleteGroupMembershipResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteGroupMembership">REST API Reference for DeleteGroupMembership Operation</seealso>
        public virtual DeleteGroupMembershipResponse EndDeleteGroupMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUser

        /// <summary>
        /// Deletes a user within an identity store given <code>UserId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
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
        public virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGroup

        /// <summary>
        /// Retrieves the group metadata and attributes from <code>GroupId</code> in an identity
        /// store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
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
        public virtual DescribeGroupResponse DescribeGroup(DescribeGroupRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeGroup(DescribeGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGroup.</param>
        /// 
        /// <returns>Returns a  DescribeGroupResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual DescribeGroupResponse EndDescribeGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGroupMembership

        /// <summary>
        /// Retrieves membership metadata and attributes from <code>MembershipId</code> in an
        /// identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroupMembership service method.</param>
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
        public virtual DescribeGroupMembershipResponse DescribeGroupMembership(DescribeGroupMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupMembershipResponseUnmarshaller.Instance;

            return Invoke<DescribeGroupMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroupMembership operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGroupMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeGroupMembership">REST API Reference for DescribeGroupMembership Operation</seealso>
        public virtual IAsyncResult BeginDescribeGroupMembership(DescribeGroupMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGroupMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGroupMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGroupMembership.</param>
        /// 
        /// <returns>Returns a  DescribeGroupMembershipResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeGroupMembership">REST API Reference for DescribeGroupMembership Operation</seealso>
        public virtual DescribeGroupMembershipResponse EndDescribeGroupMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGroupMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUser

        /// <summary>
        /// Retrieves the user metadata and attributes from the <code>UserId</code> in an identity
        /// store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
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
        public virtual DescribeUserResponse DescribeUser(DescribeUserRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual IAsyncResult BeginDescribeUser(DescribeUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUser.</param>
        /// 
        /// <returns>Returns a  DescribeUserResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual DescribeUserResponse EndDescribeUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGroupId

        /// <summary>
        /// Retrieves <code>GroupId</code> in an identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupId service method.</param>
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
        public virtual GetGroupIdResponse GetGroupId(GetGroupIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupIdResponseUnmarshaller.Instance;

            return Invoke<GetGroupIdResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupId operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetGroupId">REST API Reference for GetGroupId Operation</seealso>
        public virtual IAsyncResult BeginGetGroupId(GetGroupIdRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupIdResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupId.</param>
        /// 
        /// <returns>Returns a  GetGroupIdResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetGroupId">REST API Reference for GetGroupId Operation</seealso>
        public virtual GetGroupIdResponse EndGetGroupId(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupIdResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGroupMembershipId

        /// <summary>
        /// Retrieves the <code>MembershipId</code> in an identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupMembershipId service method.</param>
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
        public virtual GetGroupMembershipIdResponse GetGroupMembershipId(GetGroupMembershipIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupMembershipIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupMembershipIdResponseUnmarshaller.Instance;

            return Invoke<GetGroupMembershipIdResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupMembershipId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupMembershipId operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupMembershipId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetGroupMembershipId">REST API Reference for GetGroupMembershipId Operation</seealso>
        public virtual IAsyncResult BeginGetGroupMembershipId(GetGroupMembershipIdRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGroupMembershipIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupMembershipIdResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupMembershipId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupMembershipId.</param>
        /// 
        /// <returns>Returns a  GetGroupMembershipIdResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetGroupMembershipId">REST API Reference for GetGroupMembershipId Operation</seealso>
        public virtual GetGroupMembershipIdResponse EndGetGroupMembershipId(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupMembershipIdResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUserId

        /// <summary>
        /// Retrieves the <code>UserId</code> in an identity store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserId service method.</param>
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
        public virtual GetUserIdResponse GetUserId(GetUserIdRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserIdResponseUnmarshaller.Instance;

            return Invoke<GetUserIdResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserId operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetUserId">REST API Reference for GetUserId Operation</seealso>
        public virtual IAsyncResult BeginGetUserId(GetUserIdRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUserIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserIdResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserId.</param>
        /// 
        /// <returns>Returns a  GetUserIdResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/GetUserId">REST API Reference for GetUserId Operation</seealso>
        public virtual GetUserIdResponse EndGetUserId(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserIdResponse>(asyncResult);
        }

        #endregion
        
        #region  IsMemberInGroups

        /// <summary>
        /// Checks the user's membership in all requested groups and returns if the member exists
        /// in all queried groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IsMemberInGroups service method.</param>
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
        public virtual IsMemberInGroupsResponse IsMemberInGroups(IsMemberInGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IsMemberInGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IsMemberInGroupsResponseUnmarshaller.Instance;

            return Invoke<IsMemberInGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the IsMemberInGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IsMemberInGroups operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIsMemberInGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/IsMemberInGroups">REST API Reference for IsMemberInGroups Operation</seealso>
        public virtual IAsyncResult BeginIsMemberInGroups(IsMemberInGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IsMemberInGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IsMemberInGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  IsMemberInGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIsMemberInGroups.</param>
        /// 
        /// <returns>Returns a  IsMemberInGroupsResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/IsMemberInGroups">REST API Reference for IsMemberInGroups Operation</seealso>
        public virtual IsMemberInGroupsResponse EndIsMemberInGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<IsMemberInGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroupMemberships

        /// <summary>
        /// For the specified group in the specified identity store, returns the list of all <code>GroupMembership</code>
        /// objects and returns results in paginated form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships service method.</param>
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
        public virtual ListGroupMembershipsResponse ListGroupMemberships(ListGroupMembershipsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMemberships operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        public virtual IAsyncResult BeginListGroupMemberships(ListGroupMembershipsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembershipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupMemberships.</param>
        /// 
        /// <returns>Returns a  ListGroupMembershipsResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroupMemberships">REST API Reference for ListGroupMemberships Operation</seealso>
        public virtual ListGroupMembershipsResponse EndListGroupMemberships(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupMembershipsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroupMembershipsForMember

        /// <summary>
        /// For the specified member in the specified identity store, returns the list of all
        /// <code>GroupMembership</code> objects and returns results in paginated form.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembershipsForMember service method.</param>
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
        public virtual ListGroupMembershipsForMemberResponse ListGroupMembershipsForMember(ListGroupMembershipsForMemberRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembershipsForMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembershipsForMemberResponseUnmarshaller.Instance;

            return Invoke<ListGroupMembershipsForMemberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupMembershipsForMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembershipsForMember operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupMembershipsForMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroupMembershipsForMember">REST API Reference for ListGroupMembershipsForMember Operation</seealso>
        public virtual IAsyncResult BeginListGroupMembershipsForMember(ListGroupMembershipsForMemberRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupMembershipsForMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembershipsForMemberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupMembershipsForMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupMembershipsForMember.</param>
        /// 
        /// <returns>Returns a  ListGroupMembershipsForMemberResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroupMembershipsForMember">REST API Reference for ListGroupMembershipsForMember Operation</seealso>
        public virtual ListGroupMembershipsForMemberResponse EndListGroupMembershipsForMember(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupMembershipsForMemberResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroups

        /// <summary>
        /// Lists all groups in the identity store. Returns a paginated list of complete <code>Group</code>
        /// objects. Filtering for a <code>Group</code> by the <code>DisplayName</code> attribute
        /// is deprecated. Instead, use the <code>GetGroupId</code> API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
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
        public virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse EndListGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUsers

        /// <summary>
        /// Lists all users in the identity store. Returns a paginated list of complete <code>User</code>
        /// objects. Filtering for a <code>User</code> by the <code>UserName</code> attribute
        /// is deprecated. Instead, use the <code>GetUserId</code> API action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
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
        public virtual ListUsersResponse ListUsers(ListUsersRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse EndListUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGroup

        /// <summary>
        /// For the specified group in the specified identity store, updates the group metadata
        /// and attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
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
        public virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUser

        /// <summary>
        /// For the specified user in the specified identity store, updates the user metadata
        /// and attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
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
        public virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonIdentityStoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from IdentityStore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/identitystore-2020-06-15/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserResponse>(asyncResult);
        }

        #endregion
        
    }
}