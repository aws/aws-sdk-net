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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.DirectoryServiceData.Model;
using Amazon.DirectoryServiceData.Model.Internal.MarshallTransformations;
using Amazon.DirectoryServiceData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.DirectoryServiceData
{
    /// <summary>
    /// <para>Implementation for accessing DirectoryServiceData</para>
    ///
    /// Amazon Web Services Directory Service Data is an extension of Directory Service.
    /// This API reference provides detailed information about Directory Service Data operations
    /// and object types. 
    /// 
    ///  
    /// <para>
    ///  With Directory Service Data, you can create, read, update, and delete users, groups,
    /// and memberships from your Managed Microsoft AD without additional costs and without
    /// deploying dedicated management instances. You can also perform built-in object management
    /// tasks across directories without direct network connectivity, which simplifies provisioning
    /// and access management to achieve fully automated deployments. Directory Service Data
    /// supports user and group write operations, such as <c>CreateUser</c> and <c>CreateGroup</c>,
    /// within the organizational unit (OU) of your Managed Microsoft AD. Directory Service
    /// Data supports read operations, such as <c>ListUsers</c> and <c>ListGroups</c>, on
    /// all users, groups, and group memberships within your Managed Microsoft AD and across
    /// trusted realms. Directory Service Data supports adding and removing group members
    /// in your OU and the Amazon Web Services Delegated Groups OU, so you can grant and deny
    /// access to specific roles and permissions. For more information, see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/ms_ad_manage_users_groups.html">Manage
    /// users and groups</a> in the <i>Directory Service Administration Guide</i>. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  Directory management operations and configuration changes made against the Directory
    /// Service API will also reflect in Directory Service Data API with eventual consistency.
    /// You can expect a short delay between management changes, such as adding a new directory
    /// trust and calling the Directory Service Data API for the newly created trusted realm.
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    ///  Directory Service Data connects to your Managed Microsoft AD domain controllers and
    /// performs operations on underlying directory objects. When you create your Managed
    /// Microsoft AD, you choose subnets for domain controllers that Directory Service creates
    /// on your behalf. If a domain controller is unavailable, Directory Service Data uses
    /// an available domain controller. As a result, you might notice eventual consistency
    /// while objects replicate from one domain controller to another domain controller. For
    /// more information, see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/ms_ad_getting_started_what_gets_created.html">What
    /// gets created</a> in the <i>Directory Service Administration Guide</i>. Directory limits
    /// vary by Managed Microsoft AD edition: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Standard edition</b> – Supports 8 transactions per second (TPS) for read operations
    /// and 4 TPS for write operations per directory. There's a concurrency limit of 10 concurrent
    /// requests. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Enterprise edition</b> – Supports 16 transactions per second (TPS) for read operations
    /// and 8 TPS for write operations per directory. There's a concurrency limit of 10 concurrent
    /// requests.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Amazon Web Services Account</b> - Supports a total of 100 TPS for Directory Service
    /// Data operations across all directories.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  Directory Service Data only supports the Managed Microsoft AD directory type and
    /// is only available in the primary Amazon Web Services Region. For more information,
    /// see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/directory_microsoft_ad.html">Managed
    /// Microsoft AD</a> and <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/multi-region-global-primary-additional.html">Primary
    /// vs additional Regions</a> in the <i>Directory Service Administration Guide</i>. 
    /// </para>
    /// </summary>
    public partial class AmazonDirectoryServiceDataClient : AmazonServiceClient, IAmazonDirectoryServiceData
    {
        private static IServiceMetadata serviceMetadata = new AmazonDirectoryServiceDataMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IDirectoryServiceDataPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDirectoryServiceDataPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DirectoryServiceDataPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonDirectoryServiceDataClient with the credentials loaded from the application's
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
        public AmazonDirectoryServiceDataClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectoryServiceDataConfig()) { }

        /// <summary>
        /// Constructs AmazonDirectoryServiceDataClient with the credentials loaded from the application's
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
        public AmazonDirectoryServiceDataClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectoryServiceDataConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDirectoryServiceDataClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDirectoryServiceDataClient Configuration Object</param>
        public AmazonDirectoryServiceDataClient(AmazonDirectoryServiceDataConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonDirectoryServiceDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDirectoryServiceDataClient(AWSCredentials credentials)
            : this(credentials, new AmazonDirectoryServiceDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectoryServiceDataClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDirectoryServiceDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceDataClient with AWS Credentials and an
        /// AmazonDirectoryServiceDataClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDirectoryServiceDataClient Configuration Object</param>
        public AmazonDirectoryServiceDataClient(AWSCredentials credentials, AmazonDirectoryServiceDataConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDirectoryServiceDataClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectoryServiceDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectoryServiceDataClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectoryServiceDataConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectoryServiceDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDirectoryServiceDataClient Configuration Object</param>
        public AmazonDirectoryServiceDataClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDirectoryServiceDataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDirectoryServiceDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectoryServiceDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectoryServiceDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectoryServiceDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectoryServiceDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDirectoryServiceDataClient Configuration Object</param>
        public AmazonDirectoryServiceDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDirectoryServiceDataConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDirectoryServiceDataEndpointResolver());
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


        #region  AddGroupMember

        /// <summary>
        /// Adds an existing user, group, or computer as a group member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddGroupMember service method.</param>
        /// 
        /// <returns>The response from the AddGroupMember service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/AddGroupMember">REST API Reference for AddGroupMember Operation</seealso>
        public virtual AddGroupMemberResponse AddGroupMember(AddGroupMemberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddGroupMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddGroupMemberResponseUnmarshaller.Instance;

            return Invoke<AddGroupMemberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddGroupMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddGroupMember operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddGroupMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/AddGroupMember">REST API Reference for AddGroupMember Operation</seealso>
        public virtual IAsyncResult BeginAddGroupMember(AddGroupMemberRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddGroupMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddGroupMemberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddGroupMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddGroupMember.</param>
        /// 
        /// <returns>Returns a  AddGroupMemberResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/AddGroupMember">REST API Reference for AddGroupMember Operation</seealso>
        public virtual AddGroupMemberResponse EndAddGroupMember(IAsyncResult asyncResult)
        {
            return EndInvoke<AddGroupMemberResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGroup

        /// <summary>
        /// Creates a new group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;

            return Invoke<CreateGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  CreateGroupResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUser

        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse CreateUser(CreateUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;

            return Invoke<CreateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  CreateUserResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual CreateUserResponse EndCreateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGroup

        /// <summary>
        /// Deletes a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse DeleteGroup(DeleteGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  DeleteGroupResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUser

        /// <summary>
        /// Deletes a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;

            return Invoke<DeleteUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  DeleteUserResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGroup

        /// <summary>
        /// Returns information about a specific group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual DescribeGroupResponse DescribeGroup(DescribeGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeGroup(DescribeGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  DescribeGroupResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        public virtual DescribeGroupResponse EndDescribeGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeUser

        /// <summary>
        /// Returns information about a specific user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual DescribeUserResponse DescribeUser(DescribeUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeUserResponseUnmarshaller.Instance;

            return Invoke<DescribeUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual IAsyncResult BeginDescribeUser(DescribeUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  DescribeUserResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        public virtual DescribeUserResponse EndDescribeUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeUserResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableUser

        /// <summary>
        /// Deactivates an active user account. For information about how to enable an inactive
        /// user account, see <a href="https://docs.aws.amazon.com/directoryservice/latest/devguide/API_ResetUserPassword.html">ResetUserPassword</a>
        /// in the <i>Directory Service API Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableUser service method.</param>
        /// 
        /// <returns>The response from the DisableUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DisableUser">REST API Reference for DisableUser Operation</seealso>
        public virtual DisableUserResponse DisableUser(DisableUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableUserResponseUnmarshaller.Instance;

            return Invoke<DisableUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableUser operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DisableUser">REST API Reference for DisableUser Operation</seealso>
        public virtual IAsyncResult BeginDisableUser(DisableUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableUserResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableUser.</param>
        /// 
        /// <returns>Returns a  DisableUserResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/DisableUser">REST API Reference for DisableUser Operation</seealso>
        public virtual DisableUserResponse EndDisableUser(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableUserResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroupMembers

        /// <summary>
        /// Returns member information for the specified group. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>ListGroupMembers.NextToken</c>
        /// member contains a token that you pass in the next call to <c>ListGroupMembers</c>.
        /// This retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembers service method.</param>
        /// 
        /// <returns>The response from the ListGroupMembers service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroupMembers">REST API Reference for ListGroupMembers Operation</seealso>
        public virtual ListGroupMembersResponse ListGroupMembers(ListGroupMembersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGroupMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembersResponseUnmarshaller.Instance;

            return Invoke<ListGroupMembersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembers operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroupMembers">REST API Reference for ListGroupMembers Operation</seealso>
        public virtual IAsyncResult BeginListGroupMembers(ListGroupMembersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGroupMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupMembersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupMembers.</param>
        /// 
        /// <returns>Returns a  ListGroupMembersResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroupMembers">REST API Reference for ListGroupMembers Operation</seealso>
        public virtual ListGroupMembersResponse EndListGroupMembers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupMembersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroups

        /// <summary>
        /// Returns group information for the specified directory. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>ListGroups.NextToken</c>
        /// member contains a token that you pass in the next call to <c>ListGroups</c>. This
        /// retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;

            return Invoke<ListGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListGroupsResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual ListGroupsResponse EndListGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroupsForMember

        /// <summary>
        /// Returns group information for the specified member. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>ListGroupsForMember.NextToken</c>
        /// member contains a token that you pass in the next call to <c>ListGroupsForMember</c>.
        /// This retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForMember service method.</param>
        /// 
        /// <returns>The response from the ListGroupsForMember service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroupsForMember">REST API Reference for ListGroupsForMember Operation</seealso>
        public virtual ListGroupsForMemberResponse ListGroupsForMember(ListGroupsForMemberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGroupsForMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsForMemberResponseUnmarshaller.Instance;

            return Invoke<ListGroupsForMemberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupsForMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForMember operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupsForMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroupsForMember">REST API Reference for ListGroupsForMember Operation</seealso>
        public virtual IAsyncResult BeginListGroupsForMember(ListGroupsForMemberRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGroupsForMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupsForMemberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupsForMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupsForMember.</param>
        /// 
        /// <returns>Returns a  ListGroupsForMemberResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListGroupsForMember">REST API Reference for ListGroupsForMember Operation</seealso>
        public virtual ListGroupsForMemberResponse EndListGroupsForMember(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupsForMemberResponse>(asyncResult);
        }

        #endregion
        
        #region  ListUsers

        /// <summary>
        /// Returns user information for the specified directory. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>ListUsers.NextToken</c>
        /// member contains a token that you pass in the next call to <c>ListUsers</c>. This retrieves
        /// the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse ListUsers(ListUsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;

            return Invoke<ListUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListUsersResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual ListUsersResponse EndListUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveGroupMember

        /// <summary>
        /// Removes a member from a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveGroupMember service method.</param>
        /// 
        /// <returns>The response from the RemoveGroupMember service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/RemoveGroupMember">REST API Reference for RemoveGroupMember Operation</seealso>
        public virtual RemoveGroupMemberResponse RemoveGroupMember(RemoveGroupMemberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveGroupMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveGroupMemberResponseUnmarshaller.Instance;

            return Invoke<RemoveGroupMemberResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveGroupMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveGroupMember operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveGroupMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/RemoveGroupMember">REST API Reference for RemoveGroupMember Operation</seealso>
        public virtual IAsyncResult BeginRemoveGroupMember(RemoveGroupMemberRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveGroupMemberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveGroupMemberResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveGroupMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveGroupMember.</param>
        /// 
        /// <returns>Returns a  RemoveGroupMemberResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/RemoveGroupMember">REST API Reference for RemoveGroupMember Operation</seealso>
        public virtual RemoveGroupMemberResponse EndRemoveGroupMember(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveGroupMemberResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchGroups

        /// <summary>
        /// Searches the specified directory for a group. You can find groups that match the
        /// <c>SearchString</c> parameter with the value of their attributes included in the <c>SearchString</c>
        /// parameter. 
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>SearchGroups.NextToken</c>
        /// member contains a token that you pass in the next call to <c>SearchGroups</c>. This
        /// retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchGroups service method.</param>
        /// 
        /// <returns>The response from the SearchGroups service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/SearchGroups">REST API Reference for SearchGroups Operation</seealso>
        public virtual SearchGroupsResponse SearchGroups(SearchGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGroupsResponseUnmarshaller.Instance;

            return Invoke<SearchGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchGroups operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/SearchGroups">REST API Reference for SearchGroups Operation</seealso>
        public virtual IAsyncResult BeginSearchGroups(SearchGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchGroups.</param>
        /// 
        /// <returns>Returns a  SearchGroupsResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/SearchGroups">REST API Reference for SearchGroups Operation</seealso>
        public virtual SearchGroupsResponse EndSearchGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchUsers

        /// <summary>
        /// Searches the specified directory for a user. You can find users that match the <c>SearchString</c>
        /// parameter with the value of their attributes included in the <c>SearchString</c> parameter.
        /// 
        ///  
        /// <para>
        ///  This operation supports pagination with the use of the <c>NextToken</c> request and
        /// response parameters. If more results are available, the <c>SearchUsers.NextToken</c>
        /// member contains a token that you pass in the next call to <c>SearchUsers</c>. This
        /// retrieves the next set of items. 
        /// </para>
        ///  
        /// <para>
        ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
        /// parameter. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUsers service method.</param>
        /// 
        /// <returns>The response from the SearchUsers service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        public virtual SearchUsersResponse SearchUsers(SearchUsersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUsersResponseUnmarshaller.Instance;

            return Invoke<SearchUsersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchUsers operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        public virtual IAsyncResult BeginSearchUsers(SearchUsersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUsersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchUsers.</param>
        /// 
        /// <returns>Returns a  SearchUsersResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/SearchUsers">REST API Reference for SearchUsers Operation</seealso>
        public virtual SearchUsersResponse EndSearchUsers(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchUsersResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGroup

        /// <summary>
        /// Updates group information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse UpdateGroup(UpdateGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UpdateGroupResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUser

        /// <summary>
        /// Updates user information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by DirectoryServiceData.</returns>
        /// <exception cref="Amazon.DirectoryServiceData.Model.AccessDeniedException">
        /// You don't have permission to perform the request or access the directory. It can
        /// also occur when the <c>DirectoryId</c> doesn't exist or the user, member, or group
        /// might be outside of your organizational unit (OU). 
        /// 
        ///  
        /// <para>
        ///  Make sure that you have the authentication and authorization to perform the action.
        /// Review the directory information in the request, and make sure that the object isn't
        /// outside of your OU. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ConflictException">
        /// This error will occur when you try to create a resource that conflicts with an existing
        /// object. It can also occur when adding a member to a group that the member is already
        /// in.
        /// 
        ///  
        /// <para>
        ///  This error can be caused by a request sent within the 8-hour idempotency window with
        /// the same client token but different input parameters. Client tokens should not be
        /// re-used across different requests. After 8 hours, any request with the same client
        /// token is treated as a new request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.DirectoryUnavailableException">
        /// The request could not be completed due to a problem in the configuration or current
        /// state of the specified directory.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.InternalServerException">
        /// The operation didn't succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ThrottlingException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DirectoryServiceData.Model.ValidationException">
        /// The request isn't valid. Review the details in the error message to update the invalid
        /// parameters or values in your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;

            return Invoke<UpdateUserResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonDirectoryServiceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UpdateUserResult from DirectoryServiceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directory-service-data-2023-05-31/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonDirectoryServiceDataEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}