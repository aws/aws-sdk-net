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
 * Do not modify this file. This file is generated from the account-access-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AccountAccess.Model;
using Amazon.AccountAccess.Model.Internal.MarshallTransformations;
using Amazon.AccountAccess.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.AccountAccess
{
    /// <summary>
    /// <para>Implementation for accessing AccountAccess</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Account access manager enables you to manage applications and entitlements that grant
    /// IAM Identity Center principals access to IAM roles across accounts.
    /// </summary>
    public partial class AmazonAccountAccessClient : AmazonServiceClient, IAmazonAccountAccess
    {
        private static IServiceMetadata serviceMetadata = new AmazonAccountAccessMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAccountAccessClient with the credentials loaded from the application's
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
        public AmazonAccountAccessClient()
            : base(new AmazonAccountAccessConfig()) { }

        /// <summary>
        /// Constructs AmazonAccountAccessClient with the credentials loaded from the application's
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
        public AmazonAccountAccessClient(RegionEndpoint region)
            : base(new AmazonAccountAccessConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAccountAccessClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAccountAccessClient Configuration Object</param>
        public AmazonAccountAccessClient(AmazonAccountAccessConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonAccountAccessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAccountAccessClient(AWSCredentials credentials)
            : this(credentials, new AmazonAccountAccessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountAccessClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAccountAccessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessClient with AWS Credentials and an
        /// AmazonAccountAccessClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAccountAccessClient Configuration Object</param>
        public AmazonAccountAccessClient(AWSCredentials credentials, AmazonAccountAccessConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAccountAccessClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAccountAccessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountAccessClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAccountAccessConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAccountAccessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAccountAccessClient Configuration Object</param>
        public AmazonAccountAccessClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAccountAccessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAccountAccessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAccountAccessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountAccessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAccountAccessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccountAccessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAccountAccessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAccountAccessClient Configuration Object</param>
        public AmazonAccountAccessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAccountAccessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IAccountAccessPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAccountAccessPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AccountAccessPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAccountAccessEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAccountAccessAuthSchemeHandler());
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


        #region  CreateApplication

        internal virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Creates an account access manager instance and its Amazon Web Services account access
        /// application in the associated IAM Identity Center instance. This operation is idempotent;
        /// calling it multiple times with the same parameters returns the existing application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.AlreadyCreatedException">
        /// The resource you are trying to create already exists. To retrieve the existing resource,
        /// use the corresponding Get operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEntitlement

        internal virtual CreateEntitlementResponse CreateEntitlement(CreateEntitlementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEntitlementResponseUnmarshaller.Instance;

            return Invoke<CreateEntitlementResponse>(request, options);
        }



        /// <summary>
        /// Creates an entitlement (assignment) in account access manager. An entitlement (assignment)
        /// grants a principal (IAM Identity Center user or group) permission to assume a specified
        /// IAM role in an Amazon Web Services account. This operation is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEntitlement service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/CreateEntitlement">REST API Reference for CreateEntitlement Operation</seealso>
        public virtual Task<CreateEntitlementResponse> CreateEntitlementAsync(CreateEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEntitlementResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEntitlementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteApplication

        internal virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an account access manager application. This operation is idempotent; deleting
        /// an application that has already been deleted does not return an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEntitlement

        internal virtual DeleteEntitlementResponse DeleteEntitlement(DeleteEntitlementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntitlementResponseUnmarshaller.Instance;

            return Invoke<DeleteEntitlementResponse>(request, options);
        }



        /// <summary>
        /// Deletes an entitlement from an account access manager application. This operation
        /// is idempotent; deleting an entitlement that has already been deleted does not return
        /// an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEntitlement service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/DeleteEntitlement">REST API Reference for DeleteEntitlement Operation</seealso>
        public virtual Task<DeleteEntitlementResponse> DeleteEntitlementAsync(DeleteEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntitlementResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEntitlementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetApplication

        internal virtual GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return Invoke<GetApplicationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details about an account access manager application, including its status,
        /// identity source, and tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/GetApplication">REST API Reference for GetApplication Operation</seealso>
        public virtual Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<GetApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEntitlement

        internal virtual GetEntitlementResponse GetEntitlement(GetEntitlementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEntitlementResponseUnmarshaller.Instance;

            return Invoke<GetEntitlementResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details about a specific entitlement for an account access manager application,
        /// including the principal, IAM role, and target account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEntitlement service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/GetEntitlement">REST API Reference for GetEntitlement Operation</seealso>
        public virtual Task<GetEntitlementResponse> GetEntitlementAsync(GetEntitlementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEntitlementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEntitlementResponseUnmarshaller.Instance;

            return InvokeAsync<GetEntitlementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListApplications

        internal virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the account access manager applications in your account. Use pagination to ensure
        /// that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEntitlements

        internal virtual ListEntitlementsResponse ListEntitlements(ListEntitlementsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitlementsResponseUnmarshaller.Instance;

            return Invoke<ListEntitlementsResponse>(request, options);
        }



        /// <summary>
        /// Lists the entitlements for a specified account access manager application. You can
        /// filter results by principal, IAM role, or account. Use pagination to ensure that the
        /// operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitlements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntitlements service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/ListEntitlements">REST API Reference for ListEntitlements Operation</seealso>
        public virtual Task<ListEntitlementsResponse> ListEntitlementsAsync(ListEntitlementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEntitlementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitlementsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEntitlementsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags associated with an account access manager resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds tags to an account access manager resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes tags from an account access manager resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AccountAccess.</returns>
        /// <exception cref="Amazon.AccountAccess.Model.InternalServerException">
        /// An internal service error occurred. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ResourceNotFoundException">
        /// The specified resource does not exist. Verify that the resource identifier is correct
        /// and that the resource exists in the current Region.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ThrottlingException">
        /// The request was denied due to request throttling. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.AccountAccess.Model.ValidationException">
        /// The input does not satisfy the constraints specified by the service. Check your request
        /// parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}