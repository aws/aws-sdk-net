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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        /// <summary>
        /// Create an alert manager definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlertManagerDefinition service method.</param>
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
        public virtual CreateAlertManagerDefinitionResponse CreateAlertManagerDefinition(CreateAlertManagerDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlertManagerDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateAlertManagerDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlertManagerDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlertManagerDefinition operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlertManagerDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateAlertManagerDefinition">REST API Reference for CreateAlertManagerDefinition Operation</seealso>
        public virtual IAsyncResult BeginCreateAlertManagerDefinition(CreateAlertManagerDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAlertManagerDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlertManagerDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlertManagerDefinition.</param>
        /// 
        /// <returns>Returns a  CreateAlertManagerDefinitionResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateAlertManagerDefinition">REST API Reference for CreateAlertManagerDefinition Operation</seealso>
        public virtual CreateAlertManagerDefinitionResponse EndCreateAlertManagerDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAlertManagerDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLoggingConfiguration

        /// <summary>
        /// Create logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggingConfiguration service method.</param>
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
        public virtual CreateLoggingConfigurationResponse CreateLoggingConfiguration(CreateLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggingConfiguration operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateLoggingConfiguration">REST API Reference for CreateLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateLoggingConfiguration(CreateLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateLoggingConfigurationResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateLoggingConfiguration">REST API Reference for CreateLoggingConfiguration Operation</seealso>
        public virtual CreateLoggingConfigurationResponse EndCreateLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRuleGroupsNamespace

        /// <summary>
        /// Create a rule group namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroupsNamespace service method.</param>
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
        public virtual CreateRuleGroupsNamespaceResponse CreateRuleGroupsNamespace(CreateRuleGroupsNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreateRuleGroupsNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRuleGroupsNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroupsNamespace operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRuleGroupsNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateRuleGroupsNamespace">REST API Reference for CreateRuleGroupsNamespace Operation</seealso>
        public virtual IAsyncResult BeginCreateRuleGroupsNamespace(CreateRuleGroupsNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRuleGroupsNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRuleGroupsNamespace.</param>
        /// 
        /// <returns>Returns a  CreateRuleGroupsNamespaceResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateRuleGroupsNamespace">REST API Reference for CreateRuleGroupsNamespace Operation</seealso>
        public virtual CreateRuleGroupsNamespaceResponse EndCreateRuleGroupsNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRuleGroupsNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkspace

        /// <summary>
        /// Creates a new AMP workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
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
        public virtual CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceResponseUnmarshaller.Instance;

            return Invoke<CreateWorkspaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkspace(CreateWorkspaceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspace.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        public virtual CreateWorkspaceResponse EndCreateWorkspace(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkspaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAlertManagerDefinition

        /// <summary>
        /// Deletes an alert manager definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlertManagerDefinition service method.</param>
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
        public virtual DeleteAlertManagerDefinitionResponse DeleteAlertManagerDefinition(DeleteAlertManagerDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlertManagerDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteAlertManagerDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlertManagerDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlertManagerDefinition operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlertManagerDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteAlertManagerDefinition">REST API Reference for DeleteAlertManagerDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeleteAlertManagerDefinition(DeleteAlertManagerDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlertManagerDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlertManagerDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlertManagerDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteAlertManagerDefinitionResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteAlertManagerDefinition">REST API Reference for DeleteAlertManagerDefinition Operation</seealso>
        public virtual DeleteAlertManagerDefinitionResponse EndDeleteAlertManagerDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAlertManagerDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLoggingConfiguration

        /// <summary>
        /// Delete logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
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
        public virtual DeleteLoggingConfigurationResponse DeleteLoggingConfiguration(DeleteLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteLoggingConfiguration(DeleteLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteLoggingConfigurationResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        public virtual DeleteLoggingConfigurationResponse EndDeleteLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRuleGroupsNamespace

        /// <summary>
        /// Delete a rule groups namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroupsNamespace service method.</param>
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
        public virtual DeleteRuleGroupsNamespaceResponse DeleteRuleGroupsNamespace(DeleteRuleGroupsNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleGroupsNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRuleGroupsNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroupsNamespace operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRuleGroupsNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteRuleGroupsNamespace">REST API Reference for DeleteRuleGroupsNamespace Operation</seealso>
        public virtual IAsyncResult BeginDeleteRuleGroupsNamespace(DeleteRuleGroupsNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRuleGroupsNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRuleGroupsNamespace.</param>
        /// 
        /// <returns>Returns a  DeleteRuleGroupsNamespaceResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteRuleGroupsNamespace">REST API Reference for DeleteRuleGroupsNamespace Operation</seealso>
        public virtual DeleteRuleGroupsNamespaceResponse EndDeleteRuleGroupsNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRuleGroupsNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkspace

        /// <summary>
        /// Deletes an AMP workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
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
        public virtual DeleteWorkspaceResponse DeleteWorkspace(DeleteWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkspaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkspace(DeleteWorkspaceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspace.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        public virtual DeleteWorkspaceResponse EndDeleteWorkspace(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkspaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAlertManagerDefinition

        /// <summary>
        /// Describes an alert manager definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlertManagerDefinition service method.</param>
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
        public virtual DescribeAlertManagerDefinitionResponse DescribeAlertManagerDefinition(DescribeAlertManagerDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlertManagerDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeAlertManagerDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlertManagerDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlertManagerDefinition operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlertManagerDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeAlertManagerDefinition">REST API Reference for DescribeAlertManagerDefinition Operation</seealso>
        public virtual IAsyncResult BeginDescribeAlertManagerDefinition(DescribeAlertManagerDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlertManagerDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlertManagerDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlertManagerDefinition.</param>
        /// 
        /// <returns>Returns a  DescribeAlertManagerDefinitionResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeAlertManagerDefinition">REST API Reference for DescribeAlertManagerDefinition Operation</seealso>
        public virtual DescribeAlertManagerDefinitionResponse EndDescribeAlertManagerDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAlertManagerDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLoggingConfiguration

        /// <summary>
        /// Describes logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingConfiguration service method.</param>
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
        public virtual DescribeLoggingConfigurationResponse DescribeLoggingConfiguration(DescribeLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingConfiguration operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeLoggingConfiguration">REST API Reference for DescribeLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeLoggingConfiguration(DescribeLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeLoggingConfigurationResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeLoggingConfiguration">REST API Reference for DescribeLoggingConfiguration Operation</seealso>
        public virtual DescribeLoggingConfigurationResponse EndDescribeLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRuleGroupsNamespace

        /// <summary>
        /// Describe a rule groups namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuleGroupsNamespace service method.</param>
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
        public virtual DescribeRuleGroupsNamespaceResponse DescribeRuleGroupsNamespace(DescribeRuleGroupsNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return Invoke<DescribeRuleGroupsNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRuleGroupsNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuleGroupsNamespace operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRuleGroupsNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeRuleGroupsNamespace">REST API Reference for DescribeRuleGroupsNamespace Operation</seealso>
        public virtual IAsyncResult BeginDescribeRuleGroupsNamespace(DescribeRuleGroupsNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRuleGroupsNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRuleGroupsNamespace.</param>
        /// 
        /// <returns>Returns a  DescribeRuleGroupsNamespaceResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeRuleGroupsNamespace">REST API Reference for DescribeRuleGroupsNamespace Operation</seealso>
        public virtual DescribeRuleGroupsNamespaceResponse EndDescribeRuleGroupsNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRuleGroupsNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkspace

        /// <summary>
        /// Describes an existing AMP workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspace service method.</param>
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
        public virtual DescribeWorkspaceResponse DescribeWorkspace(DescribeWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspace operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkspace(DescribeWorkspaceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspace.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        public virtual DescribeWorkspaceResponse EndDescribeWorkspace(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspaceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRuleGroupsNamespaces

        /// <summary>
        /// Lists rule groups namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroupsNamespaces service method.</param>
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
        public virtual ListRuleGroupsNamespacesResponse ListRuleGroupsNamespaces(ListRuleGroupsNamespacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListRuleGroupsNamespacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuleGroupsNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroupsNamespaces operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuleGroupsNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListRuleGroupsNamespaces">REST API Reference for ListRuleGroupsNamespaces Operation</seealso>
        public virtual IAsyncResult BeginListRuleGroupsNamespaces(ListRuleGroupsNamespacesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsNamespacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuleGroupsNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuleGroupsNamespaces.</param>
        /// 
        /// <returns>Returns a  ListRuleGroupsNamespacesResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListRuleGroupsNamespaces">REST API Reference for ListRuleGroupsNamespaces Operation</seealso>
        public virtual ListRuleGroupsNamespacesResponse EndListRuleGroupsNamespaces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRuleGroupsNamespacesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListWorkspaces

        /// <summary>
        /// Lists all AMP workspaces, including workspaces being created or deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
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
        public virtual ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkspacesResponseUnmarshaller.Instance;

            return Invoke<ListWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        public virtual IAsyncResult BeginListWorkspaces(ListWorkspacesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkspacesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkspaces.</param>
        /// 
        /// <returns>Returns a  ListWorkspacesResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        public virtual ListWorkspacesResponse EndListWorkspaces(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkspacesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAlertManagerDefinition

        /// <summary>
        /// Update an alert manager definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAlertManagerDefinition service method.</param>
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
        public virtual PutAlertManagerDefinitionResponse PutAlertManagerDefinition(PutAlertManagerDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAlertManagerDefinitionResponseUnmarshaller.Instance;

            return Invoke<PutAlertManagerDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAlertManagerDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAlertManagerDefinition operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAlertManagerDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/PutAlertManagerDefinition">REST API Reference for PutAlertManagerDefinition Operation</seealso>
        public virtual IAsyncResult BeginPutAlertManagerDefinition(PutAlertManagerDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAlertManagerDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAlertManagerDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAlertManagerDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAlertManagerDefinition.</param>
        /// 
        /// <returns>Returns a  PutAlertManagerDefinitionResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/PutAlertManagerDefinition">REST API Reference for PutAlertManagerDefinition Operation</seealso>
        public virtual PutAlertManagerDefinitionResponse EndPutAlertManagerDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAlertManagerDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRuleGroupsNamespace

        /// <summary>
        /// Update a rule groups namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRuleGroupsNamespace service method.</param>
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
        public virtual PutRuleGroupsNamespaceResponse PutRuleGroupsNamespace(PutRuleGroupsNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return Invoke<PutRuleGroupsNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRuleGroupsNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRuleGroupsNamespace operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRuleGroupsNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/PutRuleGroupsNamespace">REST API Reference for PutRuleGroupsNamespace Operation</seealso>
        public virtual IAsyncResult BeginPutRuleGroupsNamespace(PutRuleGroupsNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRuleGroupsNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRuleGroupsNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRuleGroupsNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRuleGroupsNamespace.</param>
        /// 
        /// <returns>Returns a  PutRuleGroupsNamespaceResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/PutRuleGroupsNamespace">REST API Reference for PutRuleGroupsNamespace Operation</seealso>
        public virtual PutRuleGroupsNamespaceResponse EndPutRuleGroupsNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRuleGroupsNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Creates tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLoggingConfiguration

        /// <summary>
        /// Update logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggingConfiguration service method.</param>
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
        public virtual UpdateLoggingConfigurationResponse UpdateLoggingConfiguration(UpdateLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggingConfiguration operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateLoggingConfiguration">REST API Reference for UpdateLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateLoggingConfiguration(UpdateLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateLoggingConfigurationResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateLoggingConfiguration">REST API Reference for UpdateLoggingConfiguration Operation</seealso>
        public virtual UpdateLoggingConfigurationResponse EndUpdateLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkspaceAlias

        /// <summary>
        /// Updates an AMP workspace alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceAlias service method.</param>
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
        public virtual UpdateWorkspaceAliasResponse UpdateWorkspaceAlias(UpdateWorkspaceAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkspaceAliasResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkspaceAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceAlias operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkspaceAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateWorkspaceAlias">REST API Reference for UpdateWorkspaceAlias Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkspaceAlias(UpdateWorkspaceAliasRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceAliasResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspaceAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspaceAlias.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspaceAliasResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateWorkspaceAlias">REST API Reference for UpdateWorkspaceAlias Operation</seealso>
        public virtual UpdateWorkspaceAliasResponse EndUpdateWorkspaceAlias(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkspaceAliasResponse>(asyncResult);
        }

        #endregion
        
    }
}