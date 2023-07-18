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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PrometheusService.Model;
using Amazon.PrometheusService.Model.Internal.MarshallTransformations;
using Amazon.PrometheusService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.PrometheusService
{
    /// <summary>
    /// Implementation for accessing PrometheusService
    ///
    /// Amazon Managed Service for Prometheus
    /// </summary>
    public partial class AmazonPrometheusServiceClient : AmazonServiceClient, IAmazonPrometheusService
    {
        private static IServiceMetadata serviceMetadata = new AmazonPrometheusServiceMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonPrometheusServiceClient with the credentials loaded from the application's
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
        public AmazonPrometheusServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPrometheusServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonPrometheusServiceClient with the credentials loaded from the application's
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
        public AmazonPrometheusServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPrometheusServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPrometheusServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPrometheusServiceClient Configuration Object</param>
        public AmazonPrometheusServiceClient(AmazonPrometheusServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonPrometheusServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPrometheusServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonPrometheusServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPrometheusServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPrometheusServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPrometheusServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPrometheusServiceClient with AWS Credentials and an
        /// AmazonPrometheusServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPrometheusServiceClient Configuration Object</param>
        public AmazonPrometheusServiceClient(AWSCredentials credentials, AmazonPrometheusServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPrometheusServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPrometheusServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPrometheusServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPrometheusServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPrometheusServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPrometheusServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPrometheusServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPrometheusServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPrometheusServiceClient Configuration Object</param>
        public AmazonPrometheusServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPrometheusServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPrometheusServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPrometheusServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPrometheusServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPrometheusServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPrometheusServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPrometheusServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPrometheusServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPrometheusServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPrometheusServiceClient Configuration Object</param>
        public AmazonPrometheusServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPrometheusServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IPrometheusServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPrometheusServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PrometheusServicePaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPrometheusServiceEndpointResolver());
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


        #region  CreateAlertManagerDefinition

        internal virtual CreateAlertManagerDefinitionResponse CreateAlertManagerDefinition(CreateAlertManagerDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlertManagerDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateAlertManagerDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Create an alert manager definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlertManagerDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlertManagerDefinition service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateAlertManagerDefinition">REST API Reference for CreateAlertManagerDefinition Operation</seealso>
        public virtual Task<CreateAlertManagerDefinitionResponse> CreateAlertManagerDefinitionAsync(CreateAlertManagerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlertManagerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAlertManagerDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLoggingConfiguration

        internal virtual CreateLoggingConfigurationResponse CreateLoggingConfiguration(CreateLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Create logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateLoggingConfiguration">REST API Reference for CreateLoggingConfiguration Operation</seealso>
        public virtual Task<CreateLoggingConfigurationResponse> CreateLoggingConfigurationAsync(CreateLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoggingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRuleGroupsNamespace

        internal virtual CreateRuleGroupsNamespaceResponse CreateRuleGroupsNamespace(CreateRuleGroupsNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreateRuleGroupsNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Create a rule group namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroupsNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRuleGroupsNamespace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateRuleGroupsNamespace">REST API Reference for CreateRuleGroupsNamespace Operation</seealso>
        public virtual Task<CreateRuleGroupsNamespaceResponse> CreateRuleGroupsNamespaceAsync(CreateRuleGroupsNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuleGroupsNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkspace

        internal virtual CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceResponseUnmarshaller.Instance;

            return Invoke<CreateWorkspaceResponse>(request, options);
        }



        /// <summary>
        /// Creates a new AMP workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkspace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        public virtual Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlertManagerDefinition

        internal virtual DeleteAlertManagerDefinitionResponse DeleteAlertManagerDefinition(DeleteAlertManagerDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlertManagerDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteAlertManagerDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an alert manager definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlertManagerDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlertManagerDefinition service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteAlertManagerDefinition">REST API Reference for DeleteAlertManagerDefinition Operation</seealso>
        public virtual Task<DeleteAlertManagerDefinitionResponse> DeleteAlertManagerDefinitionAsync(DeleteAlertManagerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlertManagerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAlertManagerDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoggingConfiguration

        internal virtual DeleteLoggingConfigurationResponse DeleteLoggingConfiguration(DeleteLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Delete logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        public virtual Task<DeleteLoggingConfigurationResponse> DeleteLoggingConfigurationAsync(DeleteLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoggingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRuleGroupsNamespace

        internal virtual DeleteRuleGroupsNamespaceResponse DeleteRuleGroupsNamespace(DeleteRuleGroupsNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleGroupsNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Delete a rule groups namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroupsNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRuleGroupsNamespace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteRuleGroupsNamespace">REST API Reference for DeleteRuleGroupsNamespace Operation</seealso>
        public virtual Task<DeleteRuleGroupsNamespaceResponse> DeleteRuleGroupsNamespaceAsync(DeleteRuleGroupsNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuleGroupsNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkspace

        internal virtual DeleteWorkspaceResponse DeleteWorkspace(DeleteWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkspaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes an AMP workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkspace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        public virtual Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(DeleteWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAlertManagerDefinition

        internal virtual DescribeAlertManagerDefinitionResponse DescribeAlertManagerDefinition(DescribeAlertManagerDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlertManagerDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeAlertManagerDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Describes an alert manager definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlertManagerDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlertManagerDefinition service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeAlertManagerDefinition">REST API Reference for DescribeAlertManagerDefinition Operation</seealso>
        public virtual Task<DescribeAlertManagerDefinitionResponse> DescribeAlertManagerDefinitionAsync(DescribeAlertManagerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlertManagerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAlertManagerDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoggingConfiguration

        internal virtual DescribeLoggingConfigurationResponse DescribeLoggingConfiguration(DescribeLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Describes logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeLoggingConfiguration">REST API Reference for DescribeLoggingConfiguration Operation</seealso>
        public virtual Task<DescribeLoggingConfigurationResponse> DescribeLoggingConfigurationAsync(DescribeLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoggingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRuleGroupsNamespace

        internal virtual DescribeRuleGroupsNamespaceResponse DescribeRuleGroupsNamespace(DescribeRuleGroupsNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return Invoke<DescribeRuleGroupsNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Describe a rule groups namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuleGroupsNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRuleGroupsNamespace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeRuleGroupsNamespace">REST API Reference for DescribeRuleGroupsNamespace Operation</seealso>
        public virtual Task<DescribeRuleGroupsNamespaceResponse> DescribeRuleGroupsNamespaceAsync(DescribeRuleGroupsNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRuleGroupsNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspace

        internal virtual DescribeWorkspaceResponse DescribeWorkspace(DescribeWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceResponse>(request, options);
        }



        /// <summary>
        /// Describes an existing AMP workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        public virtual Task<DescribeWorkspaceResponse> DescribeWorkspaceAsync(DescribeWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRuleGroupsNamespaces

        internal virtual ListRuleGroupsNamespacesResponse ListRuleGroupsNamespaces(ListRuleGroupsNamespacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListRuleGroupsNamespacesResponse>(request, options);
        }



        /// <summary>
        /// Lists rule groups namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroupsNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuleGroupsNamespaces service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListRuleGroupsNamespaces">REST API Reference for ListRuleGroupsNamespaces Operation</seealso>
        public virtual Task<ListRuleGroupsNamespacesResponse> ListRuleGroupsNamespacesAsync(ListRuleGroupsNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsNamespacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRuleGroupsNamespacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkspaces

        internal virtual ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkspacesResponseUnmarshaller.Instance;

            return Invoke<ListWorkspacesResponse>(request, options);
        }



        /// <summary>
        /// Lists all AMP workspaces, including workspaces being created or deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkspaces service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        public virtual Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAlertManagerDefinition

        internal virtual PutAlertManagerDefinitionResponse PutAlertManagerDefinition(PutAlertManagerDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAlertManagerDefinitionResponseUnmarshaller.Instance;

            return Invoke<PutAlertManagerDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Update an alert manager definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAlertManagerDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAlertManagerDefinition service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/PutAlertManagerDefinition">REST API Reference for PutAlertManagerDefinition Operation</seealso>
        public virtual Task<PutAlertManagerDefinitionResponse> PutAlertManagerDefinitionAsync(PutAlertManagerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAlertManagerDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<PutAlertManagerDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRuleGroupsNamespace

        internal virtual PutRuleGroupsNamespaceResponse PutRuleGroupsNamespace(PutRuleGroupsNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return Invoke<PutRuleGroupsNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Update a rule groups namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRuleGroupsNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRuleGroupsNamespace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/PutRuleGroupsNamespace">REST API Reference for PutRuleGroupsNamespace Operation</seealso>
        public virtual Task<PutRuleGroupsNamespaceResponse> PutRuleGroupsNamespaceAsync(PutRuleGroupsNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<PutRuleGroupsNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Creates tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLoggingConfiguration

        internal virtual UpdateLoggingConfigurationResponse UpdateLoggingConfiguration(UpdateLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Update logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateLoggingConfiguration">REST API Reference for UpdateLoggingConfiguration Operation</seealso>
        public virtual Task<UpdateLoggingConfigurationResponse> UpdateLoggingConfigurationAsync(UpdateLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLoggingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkspaceAlias

        internal virtual UpdateWorkspaceAliasResponse UpdateWorkspaceAlias(UpdateWorkspaceAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkspaceAliasResponse>(request, options);
        }



        /// <summary>
        /// Updates an AMP workspace alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkspaceAlias service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateWorkspaceAlias">REST API Reference for UpdateWorkspaceAlias Operation</seealso>
        public virtual Task<UpdateWorkspaceAliasResponse> UpdateWorkspaceAliasAsync(UpdateWorkspaceAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkspaceAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}