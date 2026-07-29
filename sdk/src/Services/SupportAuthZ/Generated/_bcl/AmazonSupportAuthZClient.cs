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
 * Do not modify this file. This file is generated from the supportauthz-2026-06-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SupportAuthZ.Model;
using Amazon.SupportAuthZ.Model.Internal.MarshallTransformations;
using Amazon.SupportAuthZ.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SupportAuthZ
{
    /// <summary>
    /// <para>Implementation for accessing SupportAuthZ</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// AWS Support Authorization 
    /// <para>
    /// AWS SupportAuthZ enables you to control and authorize the actions that AWS support
    /// operators can perform on your resources. You create cryptographically signed support
    /// permits specifying which actions operators can perform, on which resources, and under
    /// what time-window conditions. Permits are signed using a customer-managed AWS KMS key
    /// (ECC_NIST_P384, SIGN_VERIFY) to ensure non-repudiation.
    /// 
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonSupportAuthZClient : AmazonServiceClient, IAmazonSupportAuthZ
    {
        private static IServiceMetadata serviceMetadata = new AmazonSupportAuthZMetadata();
        private ISupportAuthZPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISupportAuthZPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SupportAuthZPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonSupportAuthZClient with the credentials loaded from the application's
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
        public AmazonSupportAuthZClient()
            : base(new AmazonSupportAuthZConfig()) { }

        /// <summary>
        /// Constructs AmazonSupportAuthZClient with the credentials loaded from the application's
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
        public AmazonSupportAuthZClient(RegionEndpoint region)
            : base(new AmazonSupportAuthZConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSupportAuthZClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSupportAuthZClient Configuration Object</param>
        public AmazonSupportAuthZClient(AmazonSupportAuthZConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonSupportAuthZClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSupportAuthZClient(AWSCredentials credentials)
            : this(credentials, new AmazonSupportAuthZConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAuthZClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSupportAuthZClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSupportAuthZConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAuthZClient with AWS Credentials and an
        /// AmazonSupportAuthZClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSupportAuthZClient Configuration Object</param>
        public AmazonSupportAuthZClient(AWSCredentials credentials, AmazonSupportAuthZConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAuthZClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSupportAuthZClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSupportAuthZConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAuthZClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSupportAuthZClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSupportAuthZConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAuthZClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSupportAuthZClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSupportAuthZClient Configuration Object</param>
        public AmazonSupportAuthZClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSupportAuthZConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAuthZClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSupportAuthZClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSupportAuthZConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAuthZClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSupportAuthZClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSupportAuthZConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSupportAuthZClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSupportAuthZClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSupportAuthZClient Configuration Object</param>
        public AmazonSupportAuthZClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSupportAuthZConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSupportAuthZEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSupportAuthZAuthSchemeHandler());
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


        #region  CreateSupportPermit


        /// <summary>
        /// Creates a support permit that authorizes an AWS support operator to perform specified
        /// actions on specified resources. The permit is cryptographically signed using a customer-managed
        /// AWS KMS key (ECC_NIST_P384, SIGN_VERIFY) to ensure non-repudiation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSupportPermit service method.</param>
        /// 
        /// <returns>The response from the CreateSupportPermit service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/CreateSupportPermit">REST API Reference for CreateSupportPermit Operation</seealso>
        public virtual CreateSupportPermitResponse CreateSupportPermit(CreateSupportPermitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSupportPermitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSupportPermitResponseUnmarshaller.Instance;

            return Invoke<CreateSupportPermitResponse>(request, options);
        }


        /// <summary>
        /// Creates a support permit that authorizes an AWS support operator to perform specified
        /// actions on specified resources. The permit is cryptographically signed using a customer-managed
        /// AWS KMS key (ECC_NIST_P384, SIGN_VERIFY) to ensure non-repudiation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSupportPermit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSupportPermit service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/CreateSupportPermit">REST API Reference for CreateSupportPermit Operation</seealso>
        public virtual Task<CreateSupportPermitResponse> CreateSupportPermitAsync(CreateSupportPermitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSupportPermitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSupportPermitResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSupportPermitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSupportPermit


        /// <summary>
        /// Deletes a support permit, revoking the authorization previously granted to the AWS
        /// support operator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSupportPermit service method.</param>
        /// 
        /// <returns>The response from the DeleteSupportPermit service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/DeleteSupportPermit">REST API Reference for DeleteSupportPermit Operation</seealso>
        public virtual DeleteSupportPermitResponse DeleteSupportPermit(DeleteSupportPermitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSupportPermitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSupportPermitResponseUnmarshaller.Instance;

            return Invoke<DeleteSupportPermitResponse>(request, options);
        }


        /// <summary>
        /// Deletes a support permit, revoking the authorization previously granted to the AWS
        /// support operator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSupportPermit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSupportPermit service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/DeleteSupportPermit">REST API Reference for DeleteSupportPermit Operation</seealso>
        public virtual Task<DeleteSupportPermitResponse> DeleteSupportPermitAsync(DeleteSupportPermitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSupportPermitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSupportPermitResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSupportPermitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAction


        /// <summary>
        /// Retrieves the description of a specific support action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAction service method.</param>
        /// 
        /// <returns>The response from the GetAction service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/GetAction">REST API Reference for GetAction Operation</seealso>
        public virtual GetActionResponse GetAction(GetActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetActionResponseUnmarshaller.Instance;

            return Invoke<GetActionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the description of a specific support action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAction service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/GetAction">REST API Reference for GetAction Operation</seealso>
        public virtual Task<GetActionResponse> GetActionAsync(GetActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSupportPermit


        /// <summary>
        /// Retrieves the details of a support permit by its ARN or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSupportPermit service method.</param>
        /// 
        /// <returns>The response from the GetSupportPermit service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/GetSupportPermit">REST API Reference for GetSupportPermit Operation</seealso>
        public virtual GetSupportPermitResponse GetSupportPermit(GetSupportPermitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSupportPermitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSupportPermitResponseUnmarshaller.Instance;

            return Invoke<GetSupportPermitResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the details of a support permit by its ARN or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSupportPermit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSupportPermit service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/GetSupportPermit">REST API Reference for GetSupportPermit Operation</seealso>
        public virtual Task<GetSupportPermitResponse> GetSupportPermitAsync(GetSupportPermitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSupportPermitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSupportPermitResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSupportPermitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListActions


        /// <summary>
        /// Lists available support actions for a specified AWS service. Use pagination to ensure
        /// that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActions service method.</param>
        /// 
        /// <returns>The response from the ListActions service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/ListActions">REST API Reference for ListActions Operation</seealso>
        public virtual ListActionsResponse ListActions(ListActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionsResponseUnmarshaller.Instance;

            return Invoke<ListActionsResponse>(request, options);
        }


        /// <summary>
        /// Lists available support actions for a specified AWS service. Use pagination to ensure
        /// that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActions service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/ListActions">REST API Reference for ListActions Operation</seealso>
        public virtual Task<ListActionsResponse> ListActionsAsync(ListActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSupportPermitRequests


        /// <summary>
        /// Lists permit requests from AWS support operators. Use pagination to ensure that the
        /// operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportPermitRequests service method.</param>
        /// 
        /// <returns>The response from the ListSupportPermitRequests service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/ListSupportPermitRequests">REST API Reference for ListSupportPermitRequests Operation</seealso>
        public virtual ListSupportPermitRequestsResponse ListSupportPermitRequests(ListSupportPermitRequestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSupportPermitRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupportPermitRequestsResponseUnmarshaller.Instance;

            return Invoke<ListSupportPermitRequestsResponse>(request, options);
        }


        /// <summary>
        /// Lists permit requests from AWS support operators. Use pagination to ensure that the
        /// operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportPermitRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSupportPermitRequests service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/ListSupportPermitRequests">REST API Reference for ListSupportPermitRequests Operation</seealso>
        public virtual Task<ListSupportPermitRequestsResponse> ListSupportPermitRequestsAsync(ListSupportPermitRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSupportPermitRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupportPermitRequestsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSupportPermitRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSupportPermits


        /// <summary>
        /// Lists all support permits in the caller's account. Use pagination to ensure that the
        /// operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportPermits service method.</param>
        /// 
        /// <returns>The response from the ListSupportPermits service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/ListSupportPermits">REST API Reference for ListSupportPermits Operation</seealso>
        public virtual ListSupportPermitsResponse ListSupportPermits(ListSupportPermitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSupportPermitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupportPermitsResponseUnmarshaller.Instance;

            return Invoke<ListSupportPermitsResponse>(request, options);
        }


        /// <summary>
        /// Lists all support permits in the caller's account. Use pagination to ensure that the
        /// operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportPermits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSupportPermits service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/ListSupportPermits">REST API Reference for ListSupportPermits Operation</seealso>
        public virtual Task<ListSupportPermitsResponse> ListSupportPermitsAsync(ListSupportPermitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSupportPermitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupportPermitsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSupportPermitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags associated with a support permit resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags associated with a support permit resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectSupportPermitRequest


        /// <summary>
        /// Rejects a permit request from an AWS support operator. The operator cannot proceed
        /// with the requested action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectSupportPermitRequest service method.</param>
        /// 
        /// <returns>The response from the RejectSupportPermitRequest service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/RejectSupportPermitRequest">REST API Reference for RejectSupportPermitRequest Operation</seealso>
        public virtual RejectSupportPermitRequestResponse RejectSupportPermitRequest(RejectSupportPermitRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectSupportPermitRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSupportPermitRequestResponseUnmarshaller.Instance;

            return Invoke<RejectSupportPermitRequestResponse>(request, options);
        }


        /// <summary>
        /// Rejects a permit request from an AWS support operator. The operator cannot proceed
        /// with the requested action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectSupportPermitRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectSupportPermitRequest service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/RejectSupportPermitRequest">REST API Reference for RejectSupportPermitRequest Operation</seealso>
        public virtual Task<RejectSupportPermitRequestResponse> RejectSupportPermitRequestAsync(RejectSupportPermitRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectSupportPermitRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSupportPermitRequestResponseUnmarshaller.Instance;
            
            return InvokeAsync<RejectSupportPermitRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or overwrites one or more tags for a support permit resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds or overwrites one or more tags for a support permit resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from a support permit resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes one or more tags from a support permit resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SupportAuthZ.</returns>
        /// <exception cref="Amazon.SupportAuthZ.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.InternalServerException">
        /// An internal service error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Try again later.
        /// </exception>
        /// <exception cref="Amazon.SupportAuthZ.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/supportauthz-2026-06-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
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