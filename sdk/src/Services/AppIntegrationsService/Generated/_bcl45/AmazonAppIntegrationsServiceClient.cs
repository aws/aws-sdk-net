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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AppIntegrationsService.Model;
using Amazon.AppIntegrationsService.Model.Internal.MarshallTransformations;
using Amazon.AppIntegrationsService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AppIntegrationsService
{
    /// <summary>
    /// Implementation for accessing AppIntegrationsService
    ///
    /// The Amazon AppIntegrations service enables you to configure and reuse connections
    /// to external applications.
    /// 
    ///  
    /// <para>
    /// For information about how you can use external applications with Amazon Connect, see
    /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/crm.html">Set up pre-built
    /// integrations</a> and <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-wisdom.html">Deliver
    /// information to agents using Amazon Connect Wisdom</a> in the <i>Amazon Connect Administrator
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonAppIntegrationsServiceClient : AmazonServiceClient, IAmazonAppIntegrationsService
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppIntegrationsServiceMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with the credentials loaded from the application's
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
        public AmazonAppIntegrationsServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppIntegrationsServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with the credentials loaded from the application's
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
        public AmazonAppIntegrationsServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppIntegrationsServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppIntegrationsServiceClient Configuration Object</param>
        public AmazonAppIntegrationsServiceClient(AmazonAppIntegrationsServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppIntegrationsServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppIntegrationsServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppIntegrationsServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppIntegrationsServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Credentials and an
        /// AmazonAppIntegrationsServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppIntegrationsServiceClient Configuration Object</param>
        public AmazonAppIntegrationsServiceClient(AWSCredentials credentials, AmazonAppIntegrationsServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppIntegrationsServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppIntegrationsServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppIntegrationsServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppIntegrationsServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppIntegrationsServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppIntegrationsServiceClient Configuration Object</param>
        public AmazonAppIntegrationsServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppIntegrationsServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppIntegrationsServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppIntegrationsServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppIntegrationsServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppIntegrationsServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppIntegrationsServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppIntegrationsServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppIntegrationsServiceClient Configuration Object</param>
        public AmazonAppIntegrationsServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppIntegrationsServiceConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppIntegrationsServiceEndpointResolver());
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


        #region  CreateDataIntegration


        /// <summary>
        /// Creates and persists a DataIntegration resource.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <code>CreateDataIntegration</code> API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateDataIntegration">REST API Reference for CreateDataIntegration Operation</seealso>
        public virtual CreateDataIntegrationResponse CreateDataIntegration(CreateDataIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateDataIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Creates and persists a DataIntegration resource.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <code>CreateDataIntegration</code> API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateDataIntegration">REST API Reference for CreateDataIntegration Operation</seealso>
        public virtual Task<CreateDataIntegrationResponse> CreateDataIntegrationAsync(CreateDataIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDataIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDataIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEventIntegration


        /// <summary>
        /// Creates an EventIntegration, given a specified name, description, and a reference
        /// to an Amazon EventBridge bus in your account and a partner event source that pushes
        /// events to that bus. No objects are created in the your account, only metadata that
        /// is persisted on the EventIntegration control plane.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateEventIntegration">REST API Reference for CreateEventIntegration Operation</seealso>
        public virtual CreateEventIntegrationResponse CreateEventIntegration(CreateEventIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateEventIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Creates an EventIntegration, given a specified name, description, and a reference
        /// to an Amazon EventBridge bus in your account and a partner event source that pushes
        /// events to that bus. No objects are created in the your account, only metadata that
        /// is persisted on the EventIntegration control plane.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.DuplicateResourceException">
        /// A resource with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceQuotaExceededException">
        /// The allowed quota for the resource has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/CreateEventIntegration">REST API Reference for CreateEventIntegration Operation</seealso>
        public virtual Task<CreateEventIntegrationResponse> CreateEventIntegrationAsync(CreateEventIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEventIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataIntegration


        /// <summary>
        /// Deletes the DataIntegration. Only DataIntegrations that don't have any DataIntegrationAssociations
        /// can be deleted. Deleting a DataIntegration also deletes the underlying Amazon AppFlow
        /// flow and service linked role. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteDataIntegration">REST API Reference for DeleteDataIntegration Operation</seealso>
        public virtual DeleteDataIntegrationResponse DeleteDataIntegration(DeleteDataIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteDataIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the DataIntegration. Only DataIntegrations that don't have any DataIntegrationAssociations
        /// can be deleted. Deleting a DataIntegration also deletes the underlying Amazon AppFlow
        /// flow and service linked role. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteDataIntegration">REST API Reference for DeleteDataIntegration Operation</seealso>
        public virtual Task<DeleteDataIntegrationResponse> DeleteDataIntegrationAsync(DeleteDataIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDataIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventIntegration


        /// <summary>
        /// Deletes the specified existing event integration. If the event integration is associated
        /// with clients, the request is rejected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteEventIntegration">REST API Reference for DeleteEventIntegration Operation</seealso>
        public virtual DeleteEventIntegrationResponse DeleteEventIntegration(DeleteEventIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteEventIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified existing event integration. If the event integration is associated
        /// with clients, the request is rejected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/DeleteEventIntegration">REST API Reference for DeleteEventIntegration Operation</seealso>
        public virtual Task<DeleteEventIntegrationResponse> DeleteEventIntegrationAsync(DeleteEventIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEventIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDataIntegration


        /// <summary>
        /// Returns information about the DataIntegration.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegration service method.</param>
        /// 
        /// <returns>The response from the GetDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetDataIntegration">REST API Reference for GetDataIntegration Operation</seealso>
        public virtual GetDataIntegrationResponse GetDataIntegration(GetDataIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetDataIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the DataIntegration.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetDataIntegration">REST API Reference for GetDataIntegration Operation</seealso>
        public virtual Task<GetDataIntegrationResponse> GetDataIntegrationAsync(GetDataIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDataIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEventIntegration


        /// <summary>
        /// Returns information about the event integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventIntegration service method.</param>
        /// 
        /// <returns>The response from the GetEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetEventIntegration">REST API Reference for GetEventIntegration Operation</seealso>
        public virtual GetEventIntegrationResponse GetEventIntegration(GetEventIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetEventIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the event integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/GetEventIntegration">REST API Reference for GetEventIntegration Operation</seealso>
        public virtual Task<GetEventIntegrationResponse> GetEventIntegrationAsync(GetEventIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEventIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataIntegrationAssociations


        /// <summary>
        /// Returns a paginated list of DataIntegration associations in the account.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationAssociations service method.</param>
        /// 
        /// <returns>The response from the ListDataIntegrationAssociations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListDataIntegrationAssociations">REST API Reference for ListDataIntegrationAssociations Operation</seealso>
        public virtual ListDataIntegrationAssociationsResponse ListDataIntegrationAssociations(ListDataIntegrationAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataIntegrationAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIntegrationAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListDataIntegrationAssociationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a paginated list of DataIntegration associations in the account.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrationAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataIntegrationAssociations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListDataIntegrationAssociations">REST API Reference for ListDataIntegrationAssociations Operation</seealso>
        public virtual Task<ListDataIntegrationAssociationsResponse> ListDataIntegrationAssociationsAsync(ListDataIntegrationAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataIntegrationAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIntegrationAssociationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDataIntegrationAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDataIntegrations


        /// <summary>
        /// Returns a paginated list of DataIntegrations in the account.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListDataIntegrations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListDataIntegrations">REST API Reference for ListDataIntegrations Operation</seealso>
        public virtual ListDataIntegrationsResponse ListDataIntegrations(ListDataIntegrationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIntegrationsResponseUnmarshaller.Instance;

            return Invoke<ListDataIntegrationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a paginated list of DataIntegrations in the account.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataIntegrations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListDataIntegrations">REST API Reference for ListDataIntegrations Operation</seealso>
        public virtual Task<ListDataIntegrationsResponse> ListDataIntegrationsAsync(ListDataIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDataIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIntegrationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDataIntegrationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEventIntegrationAssociations


        /// <summary>
        /// Returns a paginated list of event integration associations in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrationAssociations service method.</param>
        /// 
        /// <returns>The response from the ListEventIntegrationAssociations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrationAssociations">REST API Reference for ListEventIntegrationAssociations Operation</seealso>
        public virtual ListEventIntegrationAssociationsResponse ListEventIntegrationAssociations(ListEventIntegrationAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventIntegrationAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventIntegrationAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListEventIntegrationAssociationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a paginated list of event integration associations in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrationAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventIntegrationAssociations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrationAssociations">REST API Reference for ListEventIntegrationAssociations Operation</seealso>
        public virtual Task<ListEventIntegrationAssociationsResponse> ListEventIntegrationAssociationsAsync(ListEventIntegrationAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventIntegrationAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventIntegrationAssociationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEventIntegrationAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEventIntegrations


        /// <summary>
        /// Returns a paginated list of event integrations in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListEventIntegrations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrations">REST API Reference for ListEventIntegrations Operation</seealso>
        public virtual ListEventIntegrationsResponse ListEventIntegrations(ListEventIntegrationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventIntegrationsResponseUnmarshaller.Instance;

            return Invoke<ListEventIntegrationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a paginated list of event integrations in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventIntegrations service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListEventIntegrations">REST API Reference for ListEventIntegrations Operation</seealso>
        public virtual Task<ListEventIntegrationsResponse> ListEventIntegrationsAsync(ListEventIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventIntegrationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEventIntegrationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataIntegration


        /// <summary>
        /// Updates the description of a DataIntegration.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateDataIntegration">REST API Reference for UpdateDataIntegration Operation</seealso>
        public virtual UpdateDataIntegrationResponse UpdateDataIntegration(UpdateDataIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateDataIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Updates the description of a DataIntegration.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot create a DataIntegration association for a DataIntegration that has been
        /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
        /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateDataIntegration">REST API Reference for UpdateDataIntegration Operation</seealso>
        public virtual Task<UpdateDataIntegrationResponse> UpdateDataIntegrationAsync(UpdateDataIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDataIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDataIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEventIntegration


        /// <summary>
        /// Updates the description of an event integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateEventIntegration">REST API Reference for UpdateEventIntegration Operation</seealso>
        public virtual UpdateEventIntegrationResponse UpdateEventIntegration(UpdateEventIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateEventIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Updates the description of an event integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventIntegration service method, as returned by AppIntegrationsService.</returns>
        /// <exception cref="Amazon.AppIntegrationsService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InternalServiceErrorException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.AppIntegrationsService.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appintegrations-2020-07-29/UpdateEventIntegration">REST API Reference for UpdateEventIntegration Operation</seealso>
        public virtual Task<UpdateEventIntegrationResponse> UpdateEventIntegrationAsync(UpdateEventIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEventIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEventIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}