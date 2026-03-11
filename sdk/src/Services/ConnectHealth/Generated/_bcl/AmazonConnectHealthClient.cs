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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ConnectHealth.Model;
using Amazon.ConnectHealth.Model.Internal.MarshallTransformations;
using Amazon.ConnectHealth.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ConnectHealth
{
    /// <summary>
    /// <para>Implementation for accessing ConnectHealth</para>
    ///
    /// Health Agent for healthcare providers and patient engagement
    /// </summary>
    public partial class AmazonConnectHealthClient : AmazonServiceClient, IAmazonConnectHealth
    {
        private static IServiceMetadata serviceMetadata = new AmazonConnectHealthMetadata();
        private IConnectHealthPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IConnectHealthPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ConnectHealthPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonConnectHealthClient with the credentials loaded from the application's
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
        public AmazonConnectHealthClient()
            : base(new AmazonConnectHealthConfig()) { }

        /// <summary>
        /// Constructs AmazonConnectHealthClient with the credentials loaded from the application's
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
        public AmazonConnectHealthClient(RegionEndpoint region)
            : base(new AmazonConnectHealthConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonConnectHealthClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonConnectHealthClient Configuration Object</param>
        public AmazonConnectHealthClient(AmazonConnectHealthConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonConnectHealthClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonConnectHealthClient(AWSCredentials credentials)
            : this(credentials, new AmazonConnectHealthConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectHealthClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectHealthClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonConnectHealthConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectHealthClient with AWS Credentials and an
        /// AmazonConnectHealthClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonConnectHealthClient Configuration Object</param>
        public AmazonConnectHealthClient(AWSCredentials credentials, AmazonConnectHealthConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectHealthClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonConnectHealthClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectHealthConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectHealthClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectHealthClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConnectHealthConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectHealthClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectHealthClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonConnectHealthClient Configuration Object</param>
        public AmazonConnectHealthClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonConnectHealthConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConnectHealthClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonConnectHealthClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectHealthConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConnectHealthClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConnectHealthClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConnectHealthConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConnectHealthClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConnectHealthClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonConnectHealthClient Configuration Object</param>
        public AmazonConnectHealthClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonConnectHealthConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonConnectHealthEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonConnectHealthAuthSchemeHandler());
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


        #region  ActivateSubscription


        /// <summary>
        /// Activates a Subscription to enable billing for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateSubscription service method.</param>
        /// 
        /// <returns>The response from the ActivateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ActivateSubscription">REST API Reference for ActivateSubscription Operation</seealso>
        public virtual ActivateSubscriptionResponse ActivateSubscription(ActivateSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ActivateSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Activates a Subscription to enable billing for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ActivateSubscription">REST API Reference for ActivateSubscription Operation</seealso>
        public virtual Task<ActivateSubscriptionResponse> ActivateSubscriptionAsync(ActivateSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivateSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ActivateSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomain


        /// <summary>
        /// Creates a new Domain for managing HealthAgent resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }


        /// <summary>
        /// Creates a new Domain for managing HealthAgent resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSubscription


        /// <summary>
        /// Creates a new Subscription within a Domain for billing and user management.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        public virtual CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Creates a new Subscription within a Domain for billing and user management.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        public virtual Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeactivateSubscription


        /// <summary>
        /// Deactivates a Subscription to stop billing for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateSubscription service method.</param>
        /// 
        /// <returns>The response from the DeactivateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/DeactivateSubscription">REST API Reference for DeactivateSubscription Operation</seealso>
        public virtual DeactivateSubscriptionResponse DeactivateSubscription(DeactivateSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeactivateSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Deactivates a Subscription to stop billing for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/DeactivateSubscription">REST API Reference for DeactivateSubscription Operation</seealso>
        public virtual Task<DeactivateSubscriptionResponse> DeactivateSubscriptionAsync(DeactivateSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivateSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivateSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeactivateSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// Deletes a Domain and all associated resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Domain and all associated resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomain


        /// <summary>
        /// Retrieves information about a Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual GetDomainResponse GetDomain(GetDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;

            return Invoke<GetDomainResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMedicalScribeListeningSession


        /// <summary>
        /// Retrieves details about an existing Medical Scribe listening session
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalScribeListeningSession service method.</param>
        /// 
        /// <returns>The response from the GetMedicalScribeListeningSession service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetMedicalScribeListeningSession">REST API Reference for GetMedicalScribeListeningSession Operation</seealso>
        public virtual GetMedicalScribeListeningSessionResponse GetMedicalScribeListeningSession(GetMedicalScribeListeningSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMedicalScribeListeningSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalScribeListeningSessionResponseUnmarshaller.Instance;

            return Invoke<GetMedicalScribeListeningSessionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves details about an existing Medical Scribe listening session
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalScribeListeningSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMedicalScribeListeningSession service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetMedicalScribeListeningSession">REST API Reference for GetMedicalScribeListeningSession Operation</seealso>
        public virtual Task<GetMedicalScribeListeningSessionResponse> GetMedicalScribeListeningSessionAsync(GetMedicalScribeListeningSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMedicalScribeListeningSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMedicalScribeListeningSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMedicalScribeListeningSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPatientInsightsJob


        /// <summary>
        /// Get details of a started patient insights job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatientInsightsJob service method.</param>
        /// 
        /// <returns>The response from the GetPatientInsightsJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetPatientInsightsJob">REST API Reference for GetPatientInsightsJob Operation</seealso>
        public virtual GetPatientInsightsJobResponse GetPatientInsightsJob(GetPatientInsightsJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPatientInsightsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPatientInsightsJobResponseUnmarshaller.Instance;

            return Invoke<GetPatientInsightsJobResponse>(request, options);
        }


        /// <summary>
        /// Get details of a started patient insights job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatientInsightsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPatientInsightsJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetPatientInsightsJob">REST API Reference for GetPatientInsightsJob Operation</seealso>
        public virtual Task<GetPatientInsightsJobResponse> GetPatientInsightsJobAsync(GetPatientInsightsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPatientInsightsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPatientInsightsJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPatientInsightsJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSubscription


        /// <summary>
        /// Retrieves information about a Subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// 
        /// <returns>The response from the GetSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        public virtual GetSubscriptionResponse GetSubscription(GetSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a Subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        public virtual Task<GetSubscriptionResponse> GetSubscriptionAsync(GetSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// Lists Domains for a given account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }


        /// <summary>
        /// Lists Domains for a given account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSubscriptions


        /// <summary>
        /// Lists all Subscriptions within a Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        public virtual ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionsResponse>(request, options);
        }


        /// <summary>
        /// Lists all Subscriptions within a Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        public virtual Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSubscriptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags associated with the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags associated with the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartPatientInsightsJob


        /// <summary>
        /// Starts a new patient insights job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPatientInsightsJob service method.</param>
        /// 
        /// <returns>The response from the StartPatientInsightsJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ConflictException">
        /// This error is thrown when a resource update is no longer valid due to assumptions
        /// about initial state changing.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/StartPatientInsightsJob">REST API Reference for StartPatientInsightsJob Operation</seealso>
        public virtual StartPatientInsightsJobResponse StartPatientInsightsJob(StartPatientInsightsJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPatientInsightsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPatientInsightsJobResponseUnmarshaller.Instance;

            return Invoke<StartPatientInsightsJobResponse>(request, options);
        }


        /// <summary>
        /// Starts a new patient insights job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPatientInsightsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPatientInsightsJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ConflictException">
        /// This error is thrown when a resource update is no longer valid due to assumptions
        /// about initial state changing.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/StartPatientInsightsJob">REST API Reference for StartPatientInsightsJob Operation</seealso>
        public virtual Task<StartPatientInsightsJobResponse> StartPatientInsightsJobAsync(StartPatientInsightsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPatientInsightsJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPatientInsightsJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartPatientInsightsJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates the specified tags with the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Associates the specified tags with the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes the specified tags from the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified tags from the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
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