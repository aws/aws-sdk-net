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

#pragma warning disable CS1570
namespace Amazon.PrometheusService
{
    /// <summary>
    /// <para>Implementation for accessing PrometheusService</para>
    ///
    /// Amazon Managed Service for Prometheus is a serverless, Prometheus-compatible monitoring
    /// service for container metrics that makes it easier to securely monitor container environments
    /// at scale. With Amazon Managed Service for Prometheus, you can use the same open-source
    /// Prometheus data model and query language that you use today to monitor the performance
    /// of your containerized workloads, and also enjoy improved scalability, availability,
    /// and security without having to manage the underlying infrastructure.
    /// 
    ///  
    /// <para>
    /// For more information about Amazon Managed Service for Prometheus, see the <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/what-is-Amazon-Managed-Service-Prometheus.html">Amazon
    /// Managed Service for Prometheus</a> User Guide.
    /// </para>
    ///  
    /// <para>
    /// Amazon Managed Service for Prometheus includes two APIs.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use the Amazon Web Services API described in this guide to manage Amazon Managed Service
    /// for Prometheus resources, such as workspaces, rule groups, and alert managers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-APIReference.html#AMP-APIReference-Prometheus-Compatible-Apis">Prometheus-compatible
    /// API</a> to work within your Prometheus workspace.
    /// </para>
    ///  </li> </ul>
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
        /// The <c>CreateAlertManagerDefinition</c> operation creates the alert manager definition
        /// in a workspace. If a workspace already has an alert manager definition, don't use
        /// this operation to update it. Instead, use <c>PutAlertManagerDefinition</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlertManagerDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateAlertManagerDefinition service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        /// The <c>CreateLoggingConfiguration</c> operation creates rules and alerting logging
        /// configuration for the workspace. Use this operation to set the CloudWatch log group
        /// to which the logs will be published to.
        /// 
        ///  <note> 
        /// <para>
        /// These logging configurations are only for rules and alerting logs.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        
        #region  CreateQueryLoggingConfiguration

        /// <summary>
        /// Creates a query logging configuration for the specified workspace. This operation
        /// enables logging of queries that exceed the specified QSP threshold.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueryLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateQueryLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateQueryLoggingConfiguration">REST API Reference for CreateQueryLoggingConfiguration Operation</seealso>
        public virtual CreateQueryLoggingConfigurationResponse CreateQueryLoggingConfiguration(CreateQueryLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQueryLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueryLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateQueryLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQueryLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueryLoggingConfiguration operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQueryLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateQueryLoggingConfiguration">REST API Reference for CreateQueryLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateQueryLoggingConfiguration(CreateQueryLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQueryLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueryLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQueryLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQueryLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateQueryLoggingConfigurationResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateQueryLoggingConfiguration">REST API Reference for CreateQueryLoggingConfiguration Operation</seealso>
        public virtual CreateQueryLoggingConfigurationResponse EndCreateQueryLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateQueryLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRuleGroupsNamespace

        /// <summary>
        /// The <c>CreateRuleGroupsNamespace</c> operation creates a rule groups namespace within
        /// a workspace. A rule groups namespace is associated with exactly one rules file. A
        /// workspace can have multiple rule groups namespaces.
        /// 
        ///  
        /// <para>
        /// Use this operation only to create new rule groups namespaces. To update an existing
        /// rule groups namespace, use <c>PutRuleGroupsNamespace</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroupsNamespace service method.</param>
        /// 
        /// <returns>The response from the CreateRuleGroupsNamespace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        
        #region  CreateScraper

        /// <summary>
        /// The <c>CreateScraper</c> operation creates a scraper to collect metrics. A scraper
        /// pulls metrics from Prometheus-compatible sources within an Amazon EKS cluster, and
        /// sends them to your Amazon Managed Service for Prometheus workspace. Scrapers are flexible,
        /// and can be configured to control what metrics are collected, the frequency of collection,
        /// what transformations are applied to the metrics, and more.
        /// 
        ///  
        /// <para>
        /// An IAM role will be created for you that Amazon Managed Service for Prometheus uses
        /// to access the metrics in your cluster. You must configure this role with a policy
        /// that allows it to scrape metrics from your cluster. For more information, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-collector-how-to.html#AMP-collector-eks-setup">Configuring
        /// your Amazon EKS cluster</a> in the <i>Amazon Managed Service for Prometheus User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The <c>scrapeConfiguration</c> parameter contains the base-64 encoded YAML configuration
        /// for the scraper.
        /// </para>
        ///  
        /// <para>
        /// When creating a scraper, the service creates a <c>Network Interface</c> in each <b>Availability
        /// Zone</b> that are passed into <c>CreateScraper</c> through subnets. These network
        /// interfaces are used to connect to the Amazon EKS cluster within the VPC for scraping
        /// metrics.
        /// </para>
        ///  <note> 
        /// <para>
        /// For more information about collectors, including what metrics are collected, and how
        /// to configure the scraper, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-collector-how-to.html">Using
        /// an Amazon Web Services managed collector</a> in the <i>Amazon Managed Service for
        /// Prometheus User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScraper service method.</param>
        /// 
        /// <returns>The response from the CreateScraper service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateScraper">REST API Reference for CreateScraper Operation</seealso>
        public virtual CreateScraperResponse CreateScraper(CreateScraperRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScraperRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScraperResponseUnmarshaller.Instance;

            return Invoke<CreateScraperResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateScraper operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScraper operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateScraper
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateScraper">REST API Reference for CreateScraper Operation</seealso>
        public virtual IAsyncResult BeginCreateScraper(CreateScraperRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScraperRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScraperResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateScraper operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateScraper.</param>
        /// 
        /// <returns>Returns a  CreateScraperResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateScraper">REST API Reference for CreateScraper Operation</seealso>
        public virtual CreateScraperResponse EndCreateScraper(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateScraperResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateWorkspace

        /// <summary>
        /// Creates a Prometheus workspace. A workspace is a logical space dedicated to the storage
        /// and querying of Prometheus metrics. You can have one or more workspaces in each Region
        /// in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        /// Deletes the alert manager definition from a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlertManagerDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteAlertManagerDefinition service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        /// Deletes the rules and alerting logging configuration for a workspace.
        /// 
        ///  <note> 
        /// <para>
        /// These logging configurations are only for rules and alerting logs.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        
        #region  DeleteQueryLoggingConfiguration

        /// <summary>
        /// Deletes the query logging configuration for the specified workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueryLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteQueryLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteQueryLoggingConfiguration">REST API Reference for DeleteQueryLoggingConfiguration Operation</seealso>
        public virtual DeleteQueryLoggingConfigurationResponse DeleteQueryLoggingConfiguration(DeleteQueryLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQueryLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueryLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteQueryLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueryLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueryLoggingConfiguration operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQueryLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteQueryLoggingConfiguration">REST API Reference for DeleteQueryLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteQueryLoggingConfiguration(DeleteQueryLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQueryLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueryLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueryLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueryLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteQueryLoggingConfigurationResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteQueryLoggingConfiguration">REST API Reference for DeleteQueryLoggingConfiguration Operation</seealso>
        public virtual DeleteQueryLoggingConfigurationResponse EndDeleteQueryLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteQueryLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        /// <summary>
        /// Deletes the resource-based policy attached to an Amazon Managed Service for Prometheus
        /// workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRuleGroupsNamespace

        /// <summary>
        /// Deletes one rule groups namespace and its associated rule groups definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroupsNamespace service method.</param>
        /// 
        /// <returns>The response from the DeleteRuleGroupsNamespace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        
        #region  DeleteScraper

        /// <summary>
        /// The <c>DeleteScraper</c> operation deletes one scraper, and stops any metrics collection
        /// that the scraper performs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScraper service method.</param>
        /// 
        /// <returns>The response from the DeleteScraper service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteScraper">REST API Reference for DeleteScraper Operation</seealso>
        public virtual DeleteScraperResponse DeleteScraper(DeleteScraperRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScraperRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScraperResponseUnmarshaller.Instance;

            return Invoke<DeleteScraperResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScraper operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScraper operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScraper
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteScraper">REST API Reference for DeleteScraper Operation</seealso>
        public virtual IAsyncResult BeginDeleteScraper(DeleteScraperRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScraperRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScraperResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScraper operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScraper.</param>
        /// 
        /// <returns>Returns a  DeleteScraperResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteScraper">REST API Reference for DeleteScraper Operation</seealso>
        public virtual DeleteScraperResponse EndDeleteScraper(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteScraperResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteScraperLoggingConfiguration

        /// <summary>
        /// Deletes the logging configuration for a Amazon Managed Service for Prometheus scraper.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScraperLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteScraperLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteScraperLoggingConfiguration">REST API Reference for DeleteScraperLoggingConfiguration Operation</seealso>
        public virtual DeleteScraperLoggingConfigurationResponse DeleteScraperLoggingConfiguration(DeleteScraperLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScraperLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScraperLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteScraperLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScraperLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScraperLoggingConfiguration operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScraperLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteScraperLoggingConfiguration">REST API Reference for DeleteScraperLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteScraperLoggingConfiguration(DeleteScraperLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScraperLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScraperLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScraperLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScraperLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteScraperLoggingConfigurationResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteScraperLoggingConfiguration">REST API Reference for DeleteScraperLoggingConfiguration Operation</seealso>
        public virtual DeleteScraperLoggingConfigurationResponse EndDeleteScraperLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteScraperLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkspace

        /// <summary>
        /// Deletes an existing workspace. 
        /// 
        ///  <note> 
        /// <para>
        /// When you delete a workspace, the data that has been ingested into it is not immediately
        /// deleted. It will be permanently deleted within one month.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        /// Retrieves the full information about the alert manager definition for a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlertManagerDefinition service method.</param>
        /// 
        /// <returns>The response from the DescribeAlertManagerDefinition service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        /// Returns complete information about the current rules and alerting logging configuration
        /// of the workspace.
        /// 
        ///  <note> 
        /// <para>
        /// These logging configurations are only for rules and alerting logs.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        
        #region  DescribeQueryLoggingConfiguration

        /// <summary>
        /// Retrieves the details of the query logging configuration for the specified workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQueryLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeQueryLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeQueryLoggingConfiguration">REST API Reference for DescribeQueryLoggingConfiguration Operation</seealso>
        public virtual DescribeQueryLoggingConfigurationResponse DescribeQueryLoggingConfiguration(DescribeQueryLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQueryLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQueryLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeQueryLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeQueryLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeQueryLoggingConfiguration operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeQueryLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeQueryLoggingConfiguration">REST API Reference for DescribeQueryLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeQueryLoggingConfiguration(DescribeQueryLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQueryLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQueryLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeQueryLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeQueryLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeQueryLoggingConfigurationResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeQueryLoggingConfiguration">REST API Reference for DescribeQueryLoggingConfiguration Operation</seealso>
        public virtual DescribeQueryLoggingConfigurationResponse EndDescribeQueryLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeQueryLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeResourcePolicy

        /// <summary>
        /// Returns information about the resource-based policy attached to an Amazon Managed
        /// Service for Prometheus workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DescribeResourcePolicy service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        public virtual DescribeResourcePolicyResponse DescribeResourcePolicy(DescribeResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginDescribeResourcePolicy(DescribeResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DescribeResourcePolicyResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        public virtual DescribeResourcePolicyResponse EndDescribeResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRuleGroupsNamespace

        /// <summary>
        /// Returns complete information about one rule groups namespace. To retrieve a list of
        /// rule groups namespaces, use <c>ListRuleGroupsNamespaces</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuleGroupsNamespace service method.</param>
        /// 
        /// <returns>The response from the DescribeRuleGroupsNamespace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        
        #region  DescribeScraper

        /// <summary>
        /// The <c>DescribeScraper</c> operation displays information about an existing scraper.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScraper service method.</param>
        /// 
        /// <returns>The response from the DescribeScraper service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeScraper">REST API Reference for DescribeScraper Operation</seealso>
        public virtual DescribeScraperResponse DescribeScraper(DescribeScraperRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScraperRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScraperResponseUnmarshaller.Instance;

            return Invoke<DescribeScraperResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScraper operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScraper operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScraper
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeScraper">REST API Reference for DescribeScraper Operation</seealso>
        public virtual IAsyncResult BeginDescribeScraper(DescribeScraperRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScraperRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScraperResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScraper operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScraper.</param>
        /// 
        /// <returns>Returns a  DescribeScraperResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeScraper">REST API Reference for DescribeScraper Operation</seealso>
        public virtual DescribeScraperResponse EndDescribeScraper(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScraperResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeScraperLoggingConfiguration

        /// <summary>
        /// Describes the logging configuration for a Amazon Managed Service for Prometheus scraper.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScraperLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeScraperLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeScraperLoggingConfiguration">REST API Reference for DescribeScraperLoggingConfiguration Operation</seealso>
        public virtual DescribeScraperLoggingConfigurationResponse DescribeScraperLoggingConfiguration(DescribeScraperLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScraperLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScraperLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeScraperLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScraperLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScraperLoggingConfiguration operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScraperLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeScraperLoggingConfiguration">REST API Reference for DescribeScraperLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeScraperLoggingConfiguration(DescribeScraperLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScraperLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScraperLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScraperLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScraperLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeScraperLoggingConfigurationResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeScraperLoggingConfiguration">REST API Reference for DescribeScraperLoggingConfiguration Operation</seealso>
        public virtual DescribeScraperLoggingConfigurationResponse EndDescribeScraperLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScraperLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeWorkspace

        /// <summary>
        /// Returns information about an existing workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspace service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        
        #region  DescribeWorkspaceConfiguration

        /// <summary>
        /// Use this operation to return information about the configuration of a workspace. The
        /// configuration details returned include workspace configuration status, label set limits,
        /// and retention period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeWorkspaceConfiguration">REST API Reference for DescribeWorkspaceConfiguration Operation</seealso>
        public virtual DescribeWorkspaceConfigurationResponse DescribeWorkspaceConfiguration(DescribeWorkspaceConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceConfiguration operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspaceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeWorkspaceConfiguration">REST API Reference for DescribeWorkspaceConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeWorkspaceConfiguration(DescribeWorkspaceConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspaceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspaceConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceConfigurationResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeWorkspaceConfiguration">REST API Reference for DescribeWorkspaceConfiguration Operation</seealso>
        public virtual DescribeWorkspaceConfigurationResponse EndDescribeWorkspaceConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWorkspaceConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDefaultScraperConfiguration

        /// <summary>
        /// The <c>GetDefaultScraperConfiguration</c> operation returns the default scraper configuration
        /// used when Amazon EKS creates a scraper for you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultScraperConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetDefaultScraperConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/GetDefaultScraperConfiguration">REST API Reference for GetDefaultScraperConfiguration Operation</seealso>
        public virtual GetDefaultScraperConfigurationResponse GetDefaultScraperConfiguration(GetDefaultScraperConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDefaultScraperConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDefaultScraperConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetDefaultScraperConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDefaultScraperConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultScraperConfiguration operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDefaultScraperConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/GetDefaultScraperConfiguration">REST API Reference for GetDefaultScraperConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetDefaultScraperConfiguration(GetDefaultScraperConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDefaultScraperConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDefaultScraperConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDefaultScraperConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDefaultScraperConfiguration.</param>
        /// 
        /// <returns>Returns a  GetDefaultScraperConfigurationResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/GetDefaultScraperConfiguration">REST API Reference for GetDefaultScraperConfiguration Operation</seealso>
        public virtual GetDefaultScraperConfigurationResponse EndGetDefaultScraperConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDefaultScraperConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRuleGroupsNamespaces

        /// <summary>
        /// Returns a list of rule groups namespaces in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroupsNamespaces service method.</param>
        /// 
        /// <returns>The response from the ListRuleGroupsNamespaces service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        
        #region  ListScrapers

        /// <summary>
        /// The <c>ListScrapers</c> operation lists all of the scrapers in your account. This
        /// includes scrapers being created or deleted. You can optionally filter the returned
        /// list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScrapers service method.</param>
        /// 
        /// <returns>The response from the ListScrapers service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListScrapers">REST API Reference for ListScrapers Operation</seealso>
        public virtual ListScrapersResponse ListScrapers(ListScrapersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScrapersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScrapersResponseUnmarshaller.Instance;

            return Invoke<ListScrapersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListScrapers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListScrapers operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListScrapers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListScrapers">REST API Reference for ListScrapers Operation</seealso>
        public virtual IAsyncResult BeginListScrapers(ListScrapersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScrapersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScrapersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListScrapers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListScrapers.</param>
        /// 
        /// <returns>Returns a  ListScrapersResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListScrapers">REST API Reference for ListScrapers Operation</seealso>
        public virtual ListScrapersResponse EndListScrapers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListScrapersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// The <c>ListTagsForResource</c> operation returns the tags that are associated with
        /// an Amazon Managed Service for Prometheus resource. Currently, the only resources that
        /// can be tagged are scrapers, workspaces, and rule groups namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        /// Lists all of the Amazon Managed Service for Prometheus workspaces in your account.
        /// This includes workspaces being created or deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
        /// 
        /// <returns>The response from the ListWorkspaces service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        /// Updates an existing alert manager definition in a workspace. If the workspace does
        /// not already have an alert manager definition, don't use this operation to create it.
        /// Instead, use <c>CreateAlertManagerDefinition</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAlertManagerDefinition service method.</param>
        /// 
        /// <returns>The response from the PutAlertManagerDefinition service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        
        #region  PutResourcePolicy

        /// <summary>
        /// Creates or updates a resource-based policy for an Amazon Managed Service for Prometheus
        /// workspace. Use resource-based policies to grant permissions to other AWS accounts
        /// or services to access your workspace.
        /// 
        ///  
        /// <para>
        /// Only Prometheus-compatible APIs can be used for workspace sharing. You can add non-Prometheus-compatible
        /// APIs to the policy, but they will be ignored. For more information, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-APIReference-Prometheus-Compatible-Apis.html">Prometheus-compatible
        /// APIs</a> in the <i>Amazon Managed Service for Prometheus User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If your workspace uses customer-managed KMS keys for encryption, you must grant the
        /// principals in your resource-based policy access to those KMS keys. You can do this
        /// by creating KMS grants. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_CreateGrant.html">CreateGrant</a>
        /// in the <i>AWS Key Management Service API Reference</i> and <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/encryption-at-rest-Amazon-Service-Prometheus.html">Encryption
        /// at rest</a> in the <i>Amazon Managed Service for Prometheus User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about working with IAM, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/security_iam_service-with-iam.html">Using
        /// Amazon Managed Service for Prometheus with IAM</a> in the <i>Amazon Managed Service
        /// for Prometheus User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRuleGroupsNamespace

        /// <summary>
        /// Updates an existing rule groups namespace within a workspace. A rule groups namespace
        /// is associated with exactly one rules file. A workspace can have multiple rule groups
        /// namespaces.
        /// 
        ///  
        /// <para>
        /// Use this operation only to update existing rule groups namespaces. To create a new
        /// rule groups namespace, use <c>CreateRuleGroupsNamespace</c>.
        /// </para>
        ///  
        /// <para>
        /// You can't use this operation to add tags to an existing rule groups namespace. Instead,
        /// use <c>TagResource</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRuleGroupsNamespace service method.</param>
        /// 
        /// <returns>The response from the PutRuleGroupsNamespace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        /// The <c>TagResource</c> operation associates tags with an Amazon Managed Service for
        /// Prometheus resource. The only resources that can be tagged are rule groups namespaces,
        /// scrapers, and workspaces.
        /// 
        ///  
        /// <para>
        /// If you specify a new tag key for the resource, this tag is appended to the list of
        /// tags associated with the resource. If you specify a tag key that is already associated
        /// with the resource, the new tag value that you specify replaces the previous value
        /// for that tag. To remove a tag, use <c>UntagResource</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        /// Removes the specified tags from an Amazon Managed Service for Prometheus resource.
        /// The only resources that can be tagged are rule groups namespaces, scrapers, and workspaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        /// Updates the log group ARN or the workspace ID of the current rules and alerting logging
        /// configuration.
        /// 
        ///  <note> 
        /// <para>
        /// These logging configurations are only for rules and alerting logs.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        
        #region  UpdateQueryLoggingConfiguration

        /// <summary>
        /// Updates the query logging configuration for the specified workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueryLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateQueryLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateQueryLoggingConfiguration">REST API Reference for UpdateQueryLoggingConfiguration Operation</seealso>
        public virtual UpdateQueryLoggingConfigurationResponse UpdateQueryLoggingConfiguration(UpdateQueryLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQueryLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueryLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateQueryLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQueryLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueryLoggingConfiguration operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQueryLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateQueryLoggingConfiguration">REST API Reference for UpdateQueryLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateQueryLoggingConfiguration(UpdateQueryLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateQueryLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateQueryLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueryLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueryLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateQueryLoggingConfigurationResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateQueryLoggingConfiguration">REST API Reference for UpdateQueryLoggingConfiguration Operation</seealso>
        public virtual UpdateQueryLoggingConfigurationResponse EndUpdateQueryLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateQueryLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateScraper

        /// <summary>
        /// Updates an existing scraper.
        /// 
        ///  
        /// <para>
        /// You can't use this function to update the source from which the scraper is collecting
        /// metrics. To change the source, delete the scraper and create a new one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScraper service method.</param>
        /// 
        /// <returns>The response from the UpdateScraper service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateScraper">REST API Reference for UpdateScraper Operation</seealso>
        public virtual UpdateScraperResponse UpdateScraper(UpdateScraperRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScraperRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScraperResponseUnmarshaller.Instance;

            return Invoke<UpdateScraperResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScraper operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScraper operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateScraper
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateScraper">REST API Reference for UpdateScraper Operation</seealso>
        public virtual IAsyncResult BeginUpdateScraper(UpdateScraperRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScraperRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScraperResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateScraper operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateScraper.</param>
        /// 
        /// <returns>Returns a  UpdateScraperResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateScraper">REST API Reference for UpdateScraper Operation</seealso>
        public virtual UpdateScraperResponse EndUpdateScraper(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateScraperResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateScraperLoggingConfiguration

        /// <summary>
        /// Updates the logging configuration for a Amazon Managed Service for Prometheus scraper.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScraperLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateScraperLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateScraperLoggingConfiguration">REST API Reference for UpdateScraperLoggingConfiguration Operation</seealso>
        public virtual UpdateScraperLoggingConfigurationResponse UpdateScraperLoggingConfiguration(UpdateScraperLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScraperLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScraperLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateScraperLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScraperLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScraperLoggingConfiguration operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateScraperLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateScraperLoggingConfiguration">REST API Reference for UpdateScraperLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateScraperLoggingConfiguration(UpdateScraperLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScraperLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScraperLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateScraperLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateScraperLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateScraperLoggingConfigurationResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateScraperLoggingConfiguration">REST API Reference for UpdateScraperLoggingConfiguration Operation</seealso>
        public virtual UpdateScraperLoggingConfigurationResponse EndUpdateScraperLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateScraperLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateWorkspaceAlias

        /// <summary>
        /// Updates the alias of an existing workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspaceAlias service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
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
        
        #region  UpdateWorkspaceConfiguration

        /// <summary>
        /// Use this operation to create or update the label sets, label set limits, and retention
        /// period of a workspace.
        /// 
        ///  
        /// <para>
        /// You must specify at least one of <c>limitsPerLabelSet</c> or <c>retentionPeriodInDays</c>
        /// for the request to be valid.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspaceConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateWorkspaceConfiguration">REST API Reference for UpdateWorkspaceConfiguration Operation</seealso>
        public virtual UpdateWorkspaceConfigurationResponse UpdateWorkspaceConfiguration(UpdateWorkspaceConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkspaceConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkspaceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceConfiguration operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkspaceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateWorkspaceConfiguration">REST API Reference for UpdateWorkspaceConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateWorkspaceConfiguration(UpdateWorkspaceConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspaceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspaceConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspaceConfigurationResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateWorkspaceConfiguration">REST API Reference for UpdateWorkspaceConfiguration Operation</seealso>
        public virtual UpdateWorkspaceConfigurationResponse EndUpdateWorkspaceConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateWorkspaceConfigurationResponse>(asyncResult);
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
            var resolver = new AmazonPrometheusServiceEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}