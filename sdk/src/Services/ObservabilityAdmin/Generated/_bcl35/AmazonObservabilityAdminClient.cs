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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ObservabilityAdmin.Model;
using Amazon.ObservabilityAdmin.Model.Internal.MarshallTransformations;
using Amazon.ObservabilityAdmin.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ObservabilityAdmin
{
    /// <summary>
    /// <para>Implementation for accessing ObservabilityAdmin</para>
    ///
    /// You can use Amazon CloudWatch Observability Admin to discover and understand the
    /// state of telemetry configuration in CloudWatch for your Amazon Web Services Organization
    /// or account. This simplifies the process of auditing your telemetry collection configurations
    /// across multiple resource types within your Amazon Web Services Organization or account.
    /// By providing a consolidated view, it allows you to easily review and manage telemetry
    /// settings, helping you ensure proper monitoring and data collection across your Amazon
    /// Web Services environment. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/telemetry-config-cloudwatch.html">Auditing
    /// CloudWatch telemetry conﬁgurations</a> in the CloudWatch User Guide.
    /// 
    ///  
    /// <para>
    /// For information on the permissions you need to use this API, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/auth-and-access-control-cw.html">Identity
    /// and access management for Amazon CloudWatch</a> in the CloudWatch User Guide.
    /// </para>
    /// </summary>
    public partial class AmazonObservabilityAdminClient : AmazonServiceClient, IAmazonObservabilityAdmin
    {
        private static IServiceMetadata serviceMetadata = new AmazonObservabilityAdminMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IObservabilityAdminPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IObservabilityAdminPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ObservabilityAdminPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with the credentials loaded from the application's
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
        public AmazonObservabilityAdminClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonObservabilityAdminConfig()) { }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with the credentials loaded from the application's
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
        public AmazonObservabilityAdminClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonObservabilityAdminConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonObservabilityAdminClient Configuration Object</param>
        public AmazonObservabilityAdminClient(AmazonObservabilityAdminConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonObservabilityAdminClient(AWSCredentials credentials)
            : this(credentials, new AmazonObservabilityAdminConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonObservabilityAdminClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonObservabilityAdminConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Credentials and an
        /// AmazonObservabilityAdminClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonObservabilityAdminClient Configuration Object</param>
        public AmazonObservabilityAdminClient(AWSCredentials credentials, AmazonObservabilityAdminConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonObservabilityAdminClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonObservabilityAdminConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonObservabilityAdminClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonObservabilityAdminConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonObservabilityAdminClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonObservabilityAdminClient Configuration Object</param>
        public AmazonObservabilityAdminClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonObservabilityAdminConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonObservabilityAdminClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonObservabilityAdminConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonObservabilityAdminClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonObservabilityAdminConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonObservabilityAdminClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonObservabilityAdminClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonObservabilityAdminClient Configuration Object</param>
        public AmazonObservabilityAdminClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonObservabilityAdminConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonObservabilityAdminEndpointResolver());
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


        #region  CreateCentralizationRuleForOrganization

        /// <summary>
        /// Creates a centralization rule that applies across an Amazon Web Services Organization.
        /// This operation can only be called by the organization's management account or a delegated
        /// administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCentralizationRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the CreateCentralizationRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ConflictException">
        /// The requested operation conflicts with the current state of the specified resource
        /// or with another request.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateCentralizationRuleForOrganization">REST API Reference for CreateCentralizationRuleForOrganization Operation</seealso>
        public virtual CreateCentralizationRuleForOrganizationResponse CreateCentralizationRuleForOrganization(CreateCentralizationRuleForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCentralizationRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCentralizationRuleForOrganizationResponseUnmarshaller.Instance;

            return Invoke<CreateCentralizationRuleForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCentralizationRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCentralizationRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateCentralizationRuleForOrganization">REST API Reference for CreateCentralizationRuleForOrganization Operation</seealso>
        public virtual IAsyncResult BeginCreateCentralizationRuleForOrganization(CreateCentralizationRuleForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCentralizationRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCentralizationRuleForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCentralizationRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  CreateCentralizationRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateCentralizationRuleForOrganization">REST API Reference for CreateCentralizationRuleForOrganization Operation</seealso>
        public virtual CreateCentralizationRuleForOrganizationResponse EndCreateCentralizationRuleForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCentralizationRuleForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateS3TableIntegration

        /// <summary>
        /// Creates an integration between CloudWatch and S3 Tables for analytics. This integration
        /// enables querying CloudWatch telemetry data using analytics engines like Amazon Athena,
        /// Amazon Redshift, and Apache Spark.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateS3TableIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateS3TableIntegration service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ConflictException">
        /// The requested operation conflicts with the current state of the specified resource
        /// or with another request.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateS3TableIntegration">REST API Reference for CreateS3TableIntegration Operation</seealso>
        public virtual CreateS3TableIntegrationResponse CreateS3TableIntegration(CreateS3TableIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateS3TableIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateS3TableIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateS3TableIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateS3TableIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateS3TableIntegration operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateS3TableIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateS3TableIntegration">REST API Reference for CreateS3TableIntegration Operation</seealso>
        public virtual IAsyncResult BeginCreateS3TableIntegration(CreateS3TableIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateS3TableIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateS3TableIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateS3TableIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateS3TableIntegration.</param>
        /// 
        /// <returns>Returns a  CreateS3TableIntegrationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateS3TableIntegration">REST API Reference for CreateS3TableIntegration Operation</seealso>
        public virtual CreateS3TableIntegrationResponse EndCreateS3TableIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateS3TableIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTelemetryPipeline

        /// <summary>
        /// Creates a telemetry pipeline for processing and transforming telemetry data. The pipeline
        /// defines how data flows from sources through processors to destinations, enabling data
        /// transformation and delivering capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTelemetryPipeline service method.</param>
        /// 
        /// <returns>The response from the CreateTelemetryPipeline service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ConflictException">
        /// The requested operation conflicts with the current state of the specified resource
        /// or with another request.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryPipeline">REST API Reference for CreateTelemetryPipeline Operation</seealso>
        public virtual CreateTelemetryPipelineResponse CreateTelemetryPipeline(CreateTelemetryPipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTelemetryPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTelemetryPipelineResponseUnmarshaller.Instance;

            return Invoke<CreateTelemetryPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTelemetryPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTelemetryPipeline operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTelemetryPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryPipeline">REST API Reference for CreateTelemetryPipeline Operation</seealso>
        public virtual IAsyncResult BeginCreateTelemetryPipeline(CreateTelemetryPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTelemetryPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTelemetryPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTelemetryPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTelemetryPipeline.</param>
        /// 
        /// <returns>Returns a  CreateTelemetryPipelineResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryPipeline">REST API Reference for CreateTelemetryPipeline Operation</seealso>
        public virtual CreateTelemetryPipelineResponse EndCreateTelemetryPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTelemetryPipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTelemetryRule

        /// <summary>
        /// Creates a telemetry rule that defines how telemetry should be configured for Amazon
        /// Web Services resources in your account. The rule specifies which resources should
        /// have telemetry enabled and how that telemetry data should be collected based on resource
        /// type, telemetry type, and selection criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTelemetryRule service method.</param>
        /// 
        /// <returns>The response from the CreateTelemetryRule service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ConflictException">
        /// The requested operation conflicts with the current state of the specified resource
        /// or with another request.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryRule">REST API Reference for CreateTelemetryRule Operation</seealso>
        public virtual CreateTelemetryRuleResponse CreateTelemetryRule(CreateTelemetryRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTelemetryRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTelemetryRuleResponseUnmarshaller.Instance;

            return Invoke<CreateTelemetryRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTelemetryRule operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTelemetryRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryRule">REST API Reference for CreateTelemetryRule Operation</seealso>
        public virtual IAsyncResult BeginCreateTelemetryRule(CreateTelemetryRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTelemetryRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTelemetryRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTelemetryRule.</param>
        /// 
        /// <returns>Returns a  CreateTelemetryRuleResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryRule">REST API Reference for CreateTelemetryRule Operation</seealso>
        public virtual CreateTelemetryRuleResponse EndCreateTelemetryRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTelemetryRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTelemetryRuleForOrganization

        /// <summary>
        /// Creates a telemetry rule that applies across an Amazon Web Services Organization.
        /// This operation can only be called by the organization's management account or a delegated
        /// administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTelemetryRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the CreateTelemetryRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ConflictException">
        /// The requested operation conflicts with the current state of the specified resource
        /// or with another request.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryRuleForOrganization">REST API Reference for CreateTelemetryRuleForOrganization Operation</seealso>
        public virtual CreateTelemetryRuleForOrganizationResponse CreateTelemetryRuleForOrganization(CreateTelemetryRuleForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTelemetryRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTelemetryRuleForOrganizationResponseUnmarshaller.Instance;

            return Invoke<CreateTelemetryRuleForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTelemetryRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTelemetryRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryRuleForOrganization">REST API Reference for CreateTelemetryRuleForOrganization Operation</seealso>
        public virtual IAsyncResult BeginCreateTelemetryRuleForOrganization(CreateTelemetryRuleForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTelemetryRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTelemetryRuleForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTelemetryRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  CreateTelemetryRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryRuleForOrganization">REST API Reference for CreateTelemetryRuleForOrganization Operation</seealso>
        public virtual CreateTelemetryRuleForOrganizationResponse EndCreateTelemetryRuleForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTelemetryRuleForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCentralizationRuleForOrganization

        /// <summary>
        /// Deletes an organization-wide centralization rule. This operation can only be called
        /// by the organization's management account or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCentralizationRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the DeleteCentralizationRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteCentralizationRuleForOrganization">REST API Reference for DeleteCentralizationRuleForOrganization Operation</seealso>
        public virtual DeleteCentralizationRuleForOrganizationResponse DeleteCentralizationRuleForOrganization(DeleteCentralizationRuleForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCentralizationRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCentralizationRuleForOrganizationResponseUnmarshaller.Instance;

            return Invoke<DeleteCentralizationRuleForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCentralizationRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCentralizationRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteCentralizationRuleForOrganization">REST API Reference for DeleteCentralizationRuleForOrganization Operation</seealso>
        public virtual IAsyncResult BeginDeleteCentralizationRuleForOrganization(DeleteCentralizationRuleForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCentralizationRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCentralizationRuleForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCentralizationRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  DeleteCentralizationRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteCentralizationRuleForOrganization">REST API Reference for DeleteCentralizationRuleForOrganization Operation</seealso>
        public virtual DeleteCentralizationRuleForOrganizationResponse EndDeleteCentralizationRuleForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCentralizationRuleForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteS3TableIntegration

        /// <summary>
        /// Deletes an S3 Table integration and its associated data. This operation removes the
        /// connection between CloudWatch Observability Admin and S3 Tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteS3TableIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteS3TableIntegration service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InvalidStateException">
        /// The requested operation cannot be completed on the specified resource in the current
        /// state.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteS3TableIntegration">REST API Reference for DeleteS3TableIntegration Operation</seealso>
        public virtual DeleteS3TableIntegrationResponse DeleteS3TableIntegration(DeleteS3TableIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteS3TableIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteS3TableIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteS3TableIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteS3TableIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteS3TableIntegration operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteS3TableIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteS3TableIntegration">REST API Reference for DeleteS3TableIntegration Operation</seealso>
        public virtual IAsyncResult BeginDeleteS3TableIntegration(DeleteS3TableIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteS3TableIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteS3TableIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteS3TableIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteS3TableIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteS3TableIntegrationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteS3TableIntegration">REST API Reference for DeleteS3TableIntegration Operation</seealso>
        public virtual DeleteS3TableIntegrationResponse EndDeleteS3TableIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteS3TableIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTelemetryPipeline

        /// <summary>
        /// Deletes a telemetry pipeline and its associated resources. This operation stops data
        /// processing and removes the pipeline configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTelemetryPipeline service method.</param>
        /// 
        /// <returns>The response from the DeleteTelemetryPipeline service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ConflictException">
        /// The requested operation conflicts with the current state of the specified resource
        /// or with another request.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryPipeline">REST API Reference for DeleteTelemetryPipeline Operation</seealso>
        public virtual DeleteTelemetryPipelineResponse DeleteTelemetryPipeline(DeleteTelemetryPipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTelemetryPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTelemetryPipelineResponseUnmarshaller.Instance;

            return Invoke<DeleteTelemetryPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTelemetryPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTelemetryPipeline operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTelemetryPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryPipeline">REST API Reference for DeleteTelemetryPipeline Operation</seealso>
        public virtual IAsyncResult BeginDeleteTelemetryPipeline(DeleteTelemetryPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTelemetryPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTelemetryPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTelemetryPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTelemetryPipeline.</param>
        /// 
        /// <returns>Returns a  DeleteTelemetryPipelineResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryPipeline">REST API Reference for DeleteTelemetryPipeline Operation</seealso>
        public virtual DeleteTelemetryPipelineResponse EndDeleteTelemetryPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTelemetryPipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTelemetryRule

        /// <summary>
        /// Deletes a telemetry rule from your account. Any telemetry configurations previously
        /// created by the rule will remain but no new resources will be configured by this rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTelemetryRule service method.</param>
        /// 
        /// <returns>The response from the DeleteTelemetryRule service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryRule">REST API Reference for DeleteTelemetryRule Operation</seealso>
        public virtual DeleteTelemetryRuleResponse DeleteTelemetryRule(DeleteTelemetryRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTelemetryRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTelemetryRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteTelemetryRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTelemetryRule operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTelemetryRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryRule">REST API Reference for DeleteTelemetryRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteTelemetryRule(DeleteTelemetryRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTelemetryRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTelemetryRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTelemetryRule.</param>
        /// 
        /// <returns>Returns a  DeleteTelemetryRuleResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryRule">REST API Reference for DeleteTelemetryRule Operation</seealso>
        public virtual DeleteTelemetryRuleResponse EndDeleteTelemetryRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTelemetryRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTelemetryRuleForOrganization

        /// <summary>
        /// Deletes an organization-wide telemetry rule. This operation can only be called by
        /// the organization's management account or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTelemetryRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the DeleteTelemetryRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryRuleForOrganization">REST API Reference for DeleteTelemetryRuleForOrganization Operation</seealso>
        public virtual DeleteTelemetryRuleForOrganizationResponse DeleteTelemetryRuleForOrganization(DeleteTelemetryRuleForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTelemetryRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTelemetryRuleForOrganizationResponseUnmarshaller.Instance;

            return Invoke<DeleteTelemetryRuleForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTelemetryRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTelemetryRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryRuleForOrganization">REST API Reference for DeleteTelemetryRuleForOrganization Operation</seealso>
        public virtual IAsyncResult BeginDeleteTelemetryRuleForOrganization(DeleteTelemetryRuleForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTelemetryRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTelemetryRuleForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTelemetryRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  DeleteTelemetryRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryRuleForOrganization">REST API Reference for DeleteTelemetryRuleForOrganization Operation</seealso>
        public virtual DeleteTelemetryRuleForOrganizationResponse EndDeleteTelemetryRuleForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTelemetryRuleForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCentralizationRuleForOrganization

        /// <summary>
        /// Retrieves the details of a specific organization centralization rule. This operation
        /// can only be called by the organization's management account or a delegated administrator
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCentralizationRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the GetCentralizationRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetCentralizationRuleForOrganization">REST API Reference for GetCentralizationRuleForOrganization Operation</seealso>
        public virtual GetCentralizationRuleForOrganizationResponse GetCentralizationRuleForOrganization(GetCentralizationRuleForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCentralizationRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCentralizationRuleForOrganizationResponseUnmarshaller.Instance;

            return Invoke<GetCentralizationRuleForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCentralizationRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCentralizationRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetCentralizationRuleForOrganization">REST API Reference for GetCentralizationRuleForOrganization Operation</seealso>
        public virtual IAsyncResult BeginGetCentralizationRuleForOrganization(GetCentralizationRuleForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCentralizationRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCentralizationRuleForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCentralizationRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  GetCentralizationRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetCentralizationRuleForOrganization">REST API Reference for GetCentralizationRuleForOrganization Operation</seealso>
        public virtual GetCentralizationRuleForOrganizationResponse EndGetCentralizationRuleForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCentralizationRuleForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetS3TableIntegration

        /// <summary>
        /// Retrieves information about a specific S3 Table integration, including its configuration,
        /// status, and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetS3TableIntegration service method.</param>
        /// 
        /// <returns>The response from the GetS3TableIntegration service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetS3TableIntegration">REST API Reference for GetS3TableIntegration Operation</seealso>
        public virtual GetS3TableIntegrationResponse GetS3TableIntegration(GetS3TableIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetS3TableIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetS3TableIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetS3TableIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetS3TableIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetS3TableIntegration operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetS3TableIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetS3TableIntegration">REST API Reference for GetS3TableIntegration Operation</seealso>
        public virtual IAsyncResult BeginGetS3TableIntegration(GetS3TableIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetS3TableIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetS3TableIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetS3TableIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetS3TableIntegration.</param>
        /// 
        /// <returns>Returns a  GetS3TableIntegrationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetS3TableIntegration">REST API Reference for GetS3TableIntegration Operation</seealso>
        public virtual GetS3TableIntegrationResponse EndGetS3TableIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetS3TableIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTelemetryEnrichmentStatus

        /// <summary>
        /// Returns the current status of the resource tags for telemetry feature, which enhances
        /// telemetry data with additional resource metadata from Resource Explorer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEnrichmentStatus service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryEnrichmentStatus service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEnrichmentStatus">REST API Reference for GetTelemetryEnrichmentStatus Operation</seealso>
        public virtual GetTelemetryEnrichmentStatusResponse GetTelemetryEnrichmentStatus(GetTelemetryEnrichmentStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryEnrichmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryEnrichmentStatusResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryEnrichmentStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryEnrichmentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEnrichmentStatus operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTelemetryEnrichmentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEnrichmentStatus">REST API Reference for GetTelemetryEnrichmentStatus Operation</seealso>
        public virtual IAsyncResult BeginGetTelemetryEnrichmentStatus(GetTelemetryEnrichmentStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryEnrichmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryEnrichmentStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTelemetryEnrichmentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTelemetryEnrichmentStatus.</param>
        /// 
        /// <returns>Returns a  GetTelemetryEnrichmentStatusResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEnrichmentStatus">REST API Reference for GetTelemetryEnrichmentStatus Operation</seealso>
        public virtual GetTelemetryEnrichmentStatusResponse EndGetTelemetryEnrichmentStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTelemetryEnrichmentStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTelemetryEvaluationStatus

        /// <summary>
        /// Returns the current onboarding status of the telemetry config feature, including
        /// the status of the feature and reason the feature failed to start or stop.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEvaluationStatus service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryEvaluationStatus service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatus">REST API Reference for GetTelemetryEvaluationStatus Operation</seealso>
        public virtual GetTelemetryEvaluationStatusResponse GetTelemetryEvaluationStatus(GetTelemetryEvaluationStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryEvaluationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryEvaluationStatusResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryEvaluationStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryEvaluationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEvaluationStatus operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTelemetryEvaluationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatus">REST API Reference for GetTelemetryEvaluationStatus Operation</seealso>
        public virtual IAsyncResult BeginGetTelemetryEvaluationStatus(GetTelemetryEvaluationStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryEvaluationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryEvaluationStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTelemetryEvaluationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTelemetryEvaluationStatus.</param>
        /// 
        /// <returns>Returns a  GetTelemetryEvaluationStatusResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatus">REST API Reference for GetTelemetryEvaluationStatus Operation</seealso>
        public virtual GetTelemetryEvaluationStatusResponse EndGetTelemetryEvaluationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTelemetryEvaluationStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTelemetryEvaluationStatusForOrganization

        /// <summary>
        /// This returns the onboarding status of the telemetry configuration feature for the
        /// organization. It can only be called by a Management Account of an Amazon Web Services
        /// Organization or an assigned Delegated Admin Account of Amazon CloudWatch telemetry
        /// config.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEvaluationStatusForOrganization service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryEvaluationStatusForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatusForOrganization">REST API Reference for GetTelemetryEvaluationStatusForOrganization Operation</seealso>
        public virtual GetTelemetryEvaluationStatusForOrganizationResponse GetTelemetryEvaluationStatusForOrganization(GetTelemetryEvaluationStatusForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryEvaluationStatusForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryEvaluationStatusForOrganizationResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryEvaluationStatusForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryEvaluationStatusForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEvaluationStatusForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTelemetryEvaluationStatusForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatusForOrganization">REST API Reference for GetTelemetryEvaluationStatusForOrganization Operation</seealso>
        public virtual IAsyncResult BeginGetTelemetryEvaluationStatusForOrganization(GetTelemetryEvaluationStatusForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryEvaluationStatusForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryEvaluationStatusForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTelemetryEvaluationStatusForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTelemetryEvaluationStatusForOrganization.</param>
        /// 
        /// <returns>Returns a  GetTelemetryEvaluationStatusForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatusForOrganization">REST API Reference for GetTelemetryEvaluationStatusForOrganization Operation</seealso>
        public virtual GetTelemetryEvaluationStatusForOrganizationResponse EndGetTelemetryEvaluationStatusForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTelemetryEvaluationStatusForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTelemetryPipeline

        /// <summary>
        /// Retrieves information about a specific telemetry pipeline, including its configuration,
        /// status, and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryPipeline service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryPipeline service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryPipeline">REST API Reference for GetTelemetryPipeline Operation</seealso>
        public virtual GetTelemetryPipelineResponse GetTelemetryPipeline(GetTelemetryPipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryPipelineResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryPipeline operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTelemetryPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryPipeline">REST API Reference for GetTelemetryPipeline Operation</seealso>
        public virtual IAsyncResult BeginGetTelemetryPipeline(GetTelemetryPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTelemetryPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTelemetryPipeline.</param>
        /// 
        /// <returns>Returns a  GetTelemetryPipelineResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryPipeline">REST API Reference for GetTelemetryPipeline Operation</seealso>
        public virtual GetTelemetryPipelineResponse EndGetTelemetryPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTelemetryPipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTelemetryRule

        /// <summary>
        /// Retrieves the details of a specific telemetry rule in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryRule service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryRule service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryRule">REST API Reference for GetTelemetryRule Operation</seealso>
        public virtual GetTelemetryRuleResponse GetTelemetryRule(GetTelemetryRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryRuleResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryRule operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTelemetryRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryRule">REST API Reference for GetTelemetryRule Operation</seealso>
        public virtual IAsyncResult BeginGetTelemetryRule(GetTelemetryRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTelemetryRule.</param>
        /// 
        /// <returns>Returns a  GetTelemetryRuleResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryRule">REST API Reference for GetTelemetryRule Operation</seealso>
        public virtual GetTelemetryRuleResponse EndGetTelemetryRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTelemetryRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTelemetryRuleForOrganization

        /// <summary>
        /// Retrieves the details of a specific organization telemetry rule. This operation can
        /// only be called by the organization's management account or a delegated administrator
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryRuleForOrganization">REST API Reference for GetTelemetryRuleForOrganization Operation</seealso>
        public virtual GetTelemetryRuleForOrganizationResponse GetTelemetryRuleForOrganization(GetTelemetryRuleForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryRuleForOrganizationResponseUnmarshaller.Instance;

            return Invoke<GetTelemetryRuleForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTelemetryRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryRuleForOrganization">REST API Reference for GetTelemetryRuleForOrganization Operation</seealso>
        public virtual IAsyncResult BeginGetTelemetryRuleForOrganization(GetTelemetryRuleForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTelemetryRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTelemetryRuleForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTelemetryRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  GetTelemetryRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryRuleForOrganization">REST API Reference for GetTelemetryRuleForOrganization Operation</seealso>
        public virtual GetTelemetryRuleForOrganizationResponse EndGetTelemetryRuleForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTelemetryRuleForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCentralizationRulesForOrganization

        /// <summary>
        /// Lists all centralization rules in your organization. This operation can only be called
        /// by the organization's management account or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCentralizationRulesForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListCentralizationRulesForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListCentralizationRulesForOrganization">REST API Reference for ListCentralizationRulesForOrganization Operation</seealso>
        public virtual ListCentralizationRulesForOrganizationResponse ListCentralizationRulesForOrganization(ListCentralizationRulesForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCentralizationRulesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCentralizationRulesForOrganizationResponseUnmarshaller.Instance;

            return Invoke<ListCentralizationRulesForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCentralizationRulesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCentralizationRulesForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCentralizationRulesForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListCentralizationRulesForOrganization">REST API Reference for ListCentralizationRulesForOrganization Operation</seealso>
        public virtual IAsyncResult BeginListCentralizationRulesForOrganization(ListCentralizationRulesForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCentralizationRulesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCentralizationRulesForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCentralizationRulesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCentralizationRulesForOrganization.</param>
        /// 
        /// <returns>Returns a  ListCentralizationRulesForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListCentralizationRulesForOrganization">REST API Reference for ListCentralizationRulesForOrganization Operation</seealso>
        public virtual ListCentralizationRulesForOrganizationResponse EndListCentralizationRulesForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCentralizationRulesForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourceTelemetry

        /// <summary>
        /// Returns a list of telemetry configurations for Amazon Web Services resources supported
        /// by telemetry config. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/telemetry-config-cloudwatch.html">Auditing
        /// CloudWatch telemetry configurations</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTelemetry service method.</param>
        /// 
        /// <returns>The response from the ListResourceTelemetry service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetry">REST API Reference for ListResourceTelemetry Operation</seealso>
        public virtual ListResourceTelemetryResponse ListResourceTelemetry(ListResourceTelemetryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceTelemetryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTelemetryResponseUnmarshaller.Instance;

            return Invoke<ListResourceTelemetryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceTelemetry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTelemetry operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceTelemetry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetry">REST API Reference for ListResourceTelemetry Operation</seealso>
        public virtual IAsyncResult BeginListResourceTelemetry(ListResourceTelemetryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceTelemetryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTelemetryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceTelemetry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceTelemetry.</param>
        /// 
        /// <returns>Returns a  ListResourceTelemetryResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetry">REST API Reference for ListResourceTelemetry Operation</seealso>
        public virtual ListResourceTelemetryResponse EndListResourceTelemetry(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceTelemetryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourceTelemetryForOrganization

        /// <summary>
        /// Returns a list of telemetry configurations for Amazon Web Services resources supported
        /// by telemetry config in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTelemetryForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListResourceTelemetryForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetryForOrganization">REST API Reference for ListResourceTelemetryForOrganization Operation</seealso>
        public virtual ListResourceTelemetryForOrganizationResponse ListResourceTelemetryForOrganization(ListResourceTelemetryForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceTelemetryForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTelemetryForOrganizationResponseUnmarshaller.Instance;

            return Invoke<ListResourceTelemetryForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceTelemetryForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTelemetryForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceTelemetryForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetryForOrganization">REST API Reference for ListResourceTelemetryForOrganization Operation</seealso>
        public virtual IAsyncResult BeginListResourceTelemetryForOrganization(ListResourceTelemetryForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourceTelemetryForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTelemetryForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceTelemetryForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceTelemetryForOrganization.</param>
        /// 
        /// <returns>Returns a  ListResourceTelemetryForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetryForOrganization">REST API Reference for ListResourceTelemetryForOrganization Operation</seealso>
        public virtual ListResourceTelemetryForOrganizationResponse EndListResourceTelemetryForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourceTelemetryForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListS3TableIntegrations

        /// <summary>
        /// Lists all S3 Table integrations in your account. We recommend using pagination to
        /// ensure that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListS3TableIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListS3TableIntegrations service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListS3TableIntegrations">REST API Reference for ListS3TableIntegrations Operation</seealso>
        public virtual ListS3TableIntegrationsResponse ListS3TableIntegrations(ListS3TableIntegrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListS3TableIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListS3TableIntegrationsResponseUnmarshaller.Instance;

            return Invoke<ListS3TableIntegrationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListS3TableIntegrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListS3TableIntegrations operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListS3TableIntegrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListS3TableIntegrations">REST API Reference for ListS3TableIntegrations Operation</seealso>
        public virtual IAsyncResult BeginListS3TableIntegrations(ListS3TableIntegrationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListS3TableIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListS3TableIntegrationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListS3TableIntegrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListS3TableIntegrations.</param>
        /// 
        /// <returns>Returns a  ListS3TableIntegrationsResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListS3TableIntegrations">REST API Reference for ListS3TableIntegrations Operation</seealso>
        public virtual ListS3TableIntegrationsResponse EndListS3TableIntegrations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListS3TableIntegrationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags attached to the specified resource. Supports telemetry rule resources
        /// and telemetry pipeline resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTelemetryPipelines

        /// <summary>
        /// Returns a list of telemetry pipelines in your account. Returns up to 100 results.
        /// If more than 100 telemetry pipelines exist, include the <c>NextToken</c> value from
        /// the response to retrieve the next set of results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryPipelines service method.</param>
        /// 
        /// <returns>The response from the ListTelemetryPipelines service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryPipelines">REST API Reference for ListTelemetryPipelines Operation</seealso>
        public virtual ListTelemetryPipelinesResponse ListTelemetryPipelines(ListTelemetryPipelinesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTelemetryPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTelemetryPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListTelemetryPipelinesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTelemetryPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryPipelines operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTelemetryPipelines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryPipelines">REST API Reference for ListTelemetryPipelines Operation</seealso>
        public virtual IAsyncResult BeginListTelemetryPipelines(ListTelemetryPipelinesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTelemetryPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTelemetryPipelinesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTelemetryPipelines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTelemetryPipelines.</param>
        /// 
        /// <returns>Returns a  ListTelemetryPipelinesResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryPipelines">REST API Reference for ListTelemetryPipelines Operation</seealso>
        public virtual ListTelemetryPipelinesResponse EndListTelemetryPipelines(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTelemetryPipelinesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTelemetryRules

        /// <summary>
        /// Lists all telemetry rules in your account. You can filter the results by specifying
        /// a rule name prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryRules service method.</param>
        /// 
        /// <returns>The response from the ListTelemetryRules service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryRules">REST API Reference for ListTelemetryRules Operation</seealso>
        public virtual ListTelemetryRulesResponse ListTelemetryRules(ListTelemetryRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTelemetryRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTelemetryRulesResponseUnmarshaller.Instance;

            return Invoke<ListTelemetryRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTelemetryRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryRules operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTelemetryRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryRules">REST API Reference for ListTelemetryRules Operation</seealso>
        public virtual IAsyncResult BeginListTelemetryRules(ListTelemetryRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTelemetryRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTelemetryRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTelemetryRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTelemetryRules.</param>
        /// 
        /// <returns>Returns a  ListTelemetryRulesResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryRules">REST API Reference for ListTelemetryRules Operation</seealso>
        public virtual ListTelemetryRulesResponse EndListTelemetryRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTelemetryRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTelemetryRulesForOrganization

        /// <summary>
        /// Lists all telemetry rules in your organization. This operation can only be called
        /// by the organization's management account or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryRulesForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListTelemetryRulesForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryRulesForOrganization">REST API Reference for ListTelemetryRulesForOrganization Operation</seealso>
        public virtual ListTelemetryRulesForOrganizationResponse ListTelemetryRulesForOrganization(ListTelemetryRulesForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTelemetryRulesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTelemetryRulesForOrganizationResponseUnmarshaller.Instance;

            return Invoke<ListTelemetryRulesForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTelemetryRulesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryRulesForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTelemetryRulesForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryRulesForOrganization">REST API Reference for ListTelemetryRulesForOrganization Operation</seealso>
        public virtual IAsyncResult BeginListTelemetryRulesForOrganization(ListTelemetryRulesForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTelemetryRulesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTelemetryRulesForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTelemetryRulesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTelemetryRulesForOrganization.</param>
        /// 
        /// <returns>Returns a  ListTelemetryRulesForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryRulesForOrganization">REST API Reference for ListTelemetryRulesForOrganization Operation</seealso>
        public virtual ListTelemetryRulesForOrganizationResponse EndListTelemetryRulesForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTelemetryRulesForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTelemetryEnrichment

        /// <summary>
        /// Enables the resource tags for telemetry feature for your account, which enhances
        /// telemetry data with additional resource metadata from Resource Explorer to provide
        /// richer context for monitoring and observability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEnrichment service method.</param>
        /// 
        /// <returns>The response from the StartTelemetryEnrichment service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ConflictException">
        /// The requested operation conflicts with the current state of the specified resource
        /// or with another request.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEnrichment">REST API Reference for StartTelemetryEnrichment Operation</seealso>
        public virtual StartTelemetryEnrichmentResponse StartTelemetryEnrichment(StartTelemetryEnrichmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTelemetryEnrichmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTelemetryEnrichmentResponseUnmarshaller.Instance;

            return Invoke<StartTelemetryEnrichmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTelemetryEnrichment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEnrichment operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTelemetryEnrichment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEnrichment">REST API Reference for StartTelemetryEnrichment Operation</seealso>
        public virtual IAsyncResult BeginStartTelemetryEnrichment(StartTelemetryEnrichmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTelemetryEnrichmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTelemetryEnrichmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTelemetryEnrichment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTelemetryEnrichment.</param>
        /// 
        /// <returns>Returns a  StartTelemetryEnrichmentResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEnrichment">REST API Reference for StartTelemetryEnrichment Operation</seealso>
        public virtual StartTelemetryEnrichmentResponse EndStartTelemetryEnrichment(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTelemetryEnrichmentResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTelemetryEvaluation

        /// <summary>
        /// This action begins onboarding the caller Amazon Web Services account to the telemetry
        /// config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEvaluation service method.</param>
        /// 
        /// <returns>The response from the StartTelemetryEvaluation service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluation">REST API Reference for StartTelemetryEvaluation Operation</seealso>
        public virtual StartTelemetryEvaluationResponse StartTelemetryEvaluation(StartTelemetryEvaluationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTelemetryEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTelemetryEvaluationResponseUnmarshaller.Instance;

            return Invoke<StartTelemetryEvaluationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTelemetryEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEvaluation operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTelemetryEvaluation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluation">REST API Reference for StartTelemetryEvaluation Operation</seealso>
        public virtual IAsyncResult BeginStartTelemetryEvaluation(StartTelemetryEvaluationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTelemetryEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTelemetryEvaluationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTelemetryEvaluation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTelemetryEvaluation.</param>
        /// 
        /// <returns>Returns a  StartTelemetryEvaluationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluation">REST API Reference for StartTelemetryEvaluation Operation</seealso>
        public virtual StartTelemetryEvaluationResponse EndStartTelemetryEvaluation(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTelemetryEvaluationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTelemetryEvaluationForOrganization

        /// <summary>
        /// This actions begins onboarding the organization and all member accounts to the telemetry
        /// config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEvaluationForOrganization service method.</param>
        /// 
        /// <returns>The response from the StartTelemetryEvaluationForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluationForOrganization">REST API Reference for StartTelemetryEvaluationForOrganization Operation</seealso>
        public virtual StartTelemetryEvaluationForOrganizationResponse StartTelemetryEvaluationForOrganization(StartTelemetryEvaluationForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTelemetryEvaluationForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTelemetryEvaluationForOrganizationResponseUnmarshaller.Instance;

            return Invoke<StartTelemetryEvaluationForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTelemetryEvaluationForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEvaluationForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTelemetryEvaluationForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluationForOrganization">REST API Reference for StartTelemetryEvaluationForOrganization Operation</seealso>
        public virtual IAsyncResult BeginStartTelemetryEvaluationForOrganization(StartTelemetryEvaluationForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartTelemetryEvaluationForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTelemetryEvaluationForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTelemetryEvaluationForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTelemetryEvaluationForOrganization.</param>
        /// 
        /// <returns>Returns a  StartTelemetryEvaluationForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluationForOrganization">REST API Reference for StartTelemetryEvaluationForOrganization Operation</seealso>
        public virtual StartTelemetryEvaluationForOrganizationResponse EndStartTelemetryEvaluationForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTelemetryEvaluationForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  StopTelemetryEnrichment

        /// <summary>
        /// Disables the resource tags for telemetry feature for your account, stopping the enhancement
        /// of telemetry data with additional resource metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEnrichment service method.</param>
        /// 
        /// <returns>The response from the StopTelemetryEnrichment service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ConflictException">
        /// The requested operation conflicts with the current state of the specified resource
        /// or with another request.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEnrichment">REST API Reference for StopTelemetryEnrichment Operation</seealso>
        public virtual StopTelemetryEnrichmentResponse StopTelemetryEnrichment(StopTelemetryEnrichmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopTelemetryEnrichmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTelemetryEnrichmentResponseUnmarshaller.Instance;

            return Invoke<StopTelemetryEnrichmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopTelemetryEnrichment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEnrichment operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTelemetryEnrichment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEnrichment">REST API Reference for StopTelemetryEnrichment Operation</seealso>
        public virtual IAsyncResult BeginStopTelemetryEnrichment(StopTelemetryEnrichmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopTelemetryEnrichmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTelemetryEnrichmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopTelemetryEnrichment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTelemetryEnrichment.</param>
        /// 
        /// <returns>Returns a  StopTelemetryEnrichmentResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEnrichment">REST API Reference for StopTelemetryEnrichment Operation</seealso>
        public virtual StopTelemetryEnrichmentResponse EndStopTelemetryEnrichment(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTelemetryEnrichmentResponse>(asyncResult);
        }

        #endregion
        
        #region  StopTelemetryEvaluation

        /// <summary>
        /// This action begins offboarding the caller Amazon Web Services account from the telemetry
        /// config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEvaluation service method.</param>
        /// 
        /// <returns>The response from the StopTelemetryEvaluation service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluation">REST API Reference for StopTelemetryEvaluation Operation</seealso>
        public virtual StopTelemetryEvaluationResponse StopTelemetryEvaluation(StopTelemetryEvaluationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopTelemetryEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTelemetryEvaluationResponseUnmarshaller.Instance;

            return Invoke<StopTelemetryEvaluationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopTelemetryEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEvaluation operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTelemetryEvaluation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluation">REST API Reference for StopTelemetryEvaluation Operation</seealso>
        public virtual IAsyncResult BeginStopTelemetryEvaluation(StopTelemetryEvaluationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopTelemetryEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTelemetryEvaluationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopTelemetryEvaluation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTelemetryEvaluation.</param>
        /// 
        /// <returns>Returns a  StopTelemetryEvaluationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluation">REST API Reference for StopTelemetryEvaluation Operation</seealso>
        public virtual StopTelemetryEvaluationResponse EndStopTelemetryEvaluation(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTelemetryEvaluationResponse>(asyncResult);
        }

        #endregion
        
        #region  StopTelemetryEvaluationForOrganization

        /// <summary>
        /// This action offboards the Organization of the caller Amazon Web Services account
        /// from the telemetry config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEvaluationForOrganization service method.</param>
        /// 
        /// <returns>The response from the StopTelemetryEvaluationForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluationForOrganization">REST API Reference for StopTelemetryEvaluationForOrganization Operation</seealso>
        public virtual StopTelemetryEvaluationForOrganizationResponse StopTelemetryEvaluationForOrganization(StopTelemetryEvaluationForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopTelemetryEvaluationForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTelemetryEvaluationForOrganizationResponseUnmarshaller.Instance;

            return Invoke<StopTelemetryEvaluationForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopTelemetryEvaluationForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEvaluationForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTelemetryEvaluationForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluationForOrganization">REST API Reference for StopTelemetryEvaluationForOrganization Operation</seealso>
        public virtual IAsyncResult BeginStopTelemetryEvaluationForOrganization(StopTelemetryEvaluationForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopTelemetryEvaluationForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTelemetryEvaluationForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopTelemetryEvaluationForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTelemetryEvaluationForOrganization.</param>
        /// 
        /// <returns>Returns a  StopTelemetryEvaluationForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluationForOrganization">REST API Reference for StopTelemetryEvaluationForOrganization Operation</seealso>
        public virtual StopTelemetryEvaluationForOrganizationResponse EndStopTelemetryEvaluationForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTelemetryEvaluationForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or updates tags for a resource. Supports telemetry rule resources and telemetry
        /// pipeline resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TestTelemetryPipeline

        /// <summary>
        /// Tests a pipeline configuration with sample records to validate data processing before
        /// deployment. This operation helps ensure your pipeline configuration works as expected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestTelemetryPipeline service method.</param>
        /// 
        /// <returns>The response from the TestTelemetryPipeline service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/TestTelemetryPipeline">REST API Reference for TestTelemetryPipeline Operation</seealso>
        public virtual TestTelemetryPipelineResponse TestTelemetryPipeline(TestTelemetryPipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestTelemetryPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestTelemetryPipelineResponseUnmarshaller.Instance;

            return Invoke<TestTelemetryPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestTelemetryPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestTelemetryPipeline operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestTelemetryPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/TestTelemetryPipeline">REST API Reference for TestTelemetryPipeline Operation</seealso>
        public virtual IAsyncResult BeginTestTelemetryPipeline(TestTelemetryPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestTelemetryPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestTelemetryPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestTelemetryPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestTelemetryPipeline.</param>
        /// 
        /// <returns>Returns a  TestTelemetryPipelineResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/TestTelemetryPipeline">REST API Reference for TestTelemetryPipeline Operation</seealso>
        public virtual TestTelemetryPipelineResponse EndTestTelemetryPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<TestTelemetryPipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a resource. Supports telemetry rule resources and telemetry pipeline
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCentralizationRuleForOrganization

        /// <summary>
        /// Updates an existing centralization rule that applies across an Amazon Web Services
        /// Organization. This operation can only be called by the organization's management account
        /// or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCentralizationRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the UpdateCentralizationRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateCentralizationRuleForOrganization">REST API Reference for UpdateCentralizationRuleForOrganization Operation</seealso>
        public virtual UpdateCentralizationRuleForOrganizationResponse UpdateCentralizationRuleForOrganization(UpdateCentralizationRuleForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCentralizationRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCentralizationRuleForOrganizationResponseUnmarshaller.Instance;

            return Invoke<UpdateCentralizationRuleForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCentralizationRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCentralizationRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateCentralizationRuleForOrganization">REST API Reference for UpdateCentralizationRuleForOrganization Operation</seealso>
        public virtual IAsyncResult BeginUpdateCentralizationRuleForOrganization(UpdateCentralizationRuleForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCentralizationRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCentralizationRuleForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCentralizationRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  UpdateCentralizationRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateCentralizationRuleForOrganization">REST API Reference for UpdateCentralizationRuleForOrganization Operation</seealso>
        public virtual UpdateCentralizationRuleForOrganizationResponse EndUpdateCentralizationRuleForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCentralizationRuleForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTelemetryPipeline

        /// <summary>
        /// Updates the configuration of an existing telemetry pipeline.
        /// 
        ///  <note> 
        /// <para>
        /// The following attributes cannot be updated after pipeline creation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Pipeline name</b> - The pipeline name is immutable
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Pipeline ARN</b> - The ARN is automatically generated and cannot be changed
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Source type</b> - Once a pipeline is created with a specific source type (such
        /// as S3, CloudWatch Logs, GitHub, or third-party sources), it cannot be changed to a
        /// different source type
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Processors can be added, removed, or modified. However, some processors are not supported
        /// for third-party pipelines and cannot be added through updates.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Source-Specific Update Rules</b> 
        /// </para>
        ///  <dl> <dt>CloudWatch Logs Sources (Vended and Custom)</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> <c>sts_role_arn</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Fixed:</b> <c>data_source_name</c>, <c>data_source_type</c>, sink (must remain
        /// <c>@original</c>)
        /// </para>
        ///  </dd> <dt>S3 Sources (Crowdstrike, Zscaler, SentinelOne, Custom)</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> All SQS configuration parameters, <c>sts_role_arn</c>, codec settings,
        /// compression type, bucket ownership settings, sink log group
        /// </para>
        ///  
        /// <para>
        ///  <b>Fixed:</b> <c>notification_type</c>, <c>aws.region</c> 
        /// </para>
        ///  </dd> <dt>GitHub Audit Logs</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>scope</c>
        /// (can switch between ORGANIZATION/ENTERPRISE), <c>organization</c> or <c>enterprise</c>
        /// name, <c>range</c>, authentication credentials (PAT or GitHub App)
        /// </para>
        ///  </dd> <dt>Microsoft Sources (Entra ID, Office365, Windows)</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>tenant_id</c>,
        /// <c>workspace_id</c> (Windows only), OAuth2 credentials (<c>client_id</c>, <c>client_secret</c>)
        /// </para>
        ///  </dd> <dt>Okta Sources (SSO, Auth0)</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>domain</c>,
        /// <c>range</c> (SSO only), OAuth2 credentials (<c>client_id</c>, <c>client_secret</c>)
        /// </para>
        ///  </dd> <dt>Palo Alto Networks</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>hostname</c>,
        /// basic authentication credentials (<c>username</c>, <c>password</c>)
        /// </para>
        ///  </dd> <dt>ServiceNow CMDB</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>instance_url</c>,
        /// <c>range</c>, OAuth2 credentials (<c>client_id</c>, <c>client_secret</c>)
        /// </para>
        ///  </dd> <dt>Wiz CNAPP</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>region</c>,
        /// <c>range</c>, OAuth2 credentials (<c>client_id</c>, <c>client_secret</c>)
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTelemetryPipeline service method.</param>
        /// 
        /// <returns>The response from the UpdateTelemetryPipeline service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryPipeline">REST API Reference for UpdateTelemetryPipeline Operation</seealso>
        public virtual UpdateTelemetryPipelineResponse UpdateTelemetryPipeline(UpdateTelemetryPipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTelemetryPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTelemetryPipelineResponseUnmarshaller.Instance;

            return Invoke<UpdateTelemetryPipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTelemetryPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTelemetryPipeline operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTelemetryPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryPipeline">REST API Reference for UpdateTelemetryPipeline Operation</seealso>
        public virtual IAsyncResult BeginUpdateTelemetryPipeline(UpdateTelemetryPipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTelemetryPipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTelemetryPipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTelemetryPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTelemetryPipeline.</param>
        /// 
        /// <returns>Returns a  UpdateTelemetryPipelineResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryPipeline">REST API Reference for UpdateTelemetryPipeline Operation</seealso>
        public virtual UpdateTelemetryPipelineResponse EndUpdateTelemetryPipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTelemetryPipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTelemetryRule

        /// <summary>
        /// Updates an existing telemetry rule in your account. If multiple users attempt to
        /// modify the same telemetry rule simultaneously, a ConflictException is returned to
        /// provide specific error information for concurrent modification scenarios.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTelemetryRule service method.</param>
        /// 
        /// <returns>The response from the UpdateTelemetryRule service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ConflictException">
        /// The requested operation conflicts with the current state of the specified resource
        /// or with another request.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryRule">REST API Reference for UpdateTelemetryRule Operation</seealso>
        public virtual UpdateTelemetryRuleResponse UpdateTelemetryRule(UpdateTelemetryRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTelemetryRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTelemetryRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateTelemetryRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTelemetryRule operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTelemetryRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryRule">REST API Reference for UpdateTelemetryRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateTelemetryRule(UpdateTelemetryRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTelemetryRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTelemetryRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTelemetryRule.</param>
        /// 
        /// <returns>Returns a  UpdateTelemetryRuleResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryRule">REST API Reference for UpdateTelemetryRule Operation</seealso>
        public virtual UpdateTelemetryRuleResponse EndUpdateTelemetryRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTelemetryRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTelemetryRuleForOrganization

        /// <summary>
        /// Updates an existing telemetry rule that applies across an Amazon Web Services Organization.
        /// This operation can only be called by the organization's management account or a delegated
        /// administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTelemetryRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the UpdateTelemetryRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryRuleForOrganization">REST API Reference for UpdateTelemetryRuleForOrganization Operation</seealso>
        public virtual UpdateTelemetryRuleForOrganizationResponse UpdateTelemetryRuleForOrganization(UpdateTelemetryRuleForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTelemetryRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTelemetryRuleForOrganizationResponseUnmarshaller.Instance;

            return Invoke<UpdateTelemetryRuleForOrganizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTelemetryRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTelemetryRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryRuleForOrganization">REST API Reference for UpdateTelemetryRuleForOrganization Operation</seealso>
        public virtual IAsyncResult BeginUpdateTelemetryRuleForOrganization(UpdateTelemetryRuleForOrganizationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTelemetryRuleForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTelemetryRuleForOrganizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTelemetryRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  UpdateTelemetryRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryRuleForOrganization">REST API Reference for UpdateTelemetryRuleForOrganization Operation</seealso>
        public virtual UpdateTelemetryRuleForOrganizationResponse EndUpdateTelemetryRuleForOrganization(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTelemetryRuleForOrganizationResponse>(asyncResult);
        }

        #endregion
        
        #region  ValidateTelemetryPipelineConfiguration

        /// <summary>
        /// Validates a pipeline configuration without creating the pipeline. This operation checks
        /// the configuration for syntax errors and compatibility issues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateTelemetryPipelineConfiguration service method.</param>
        /// 
        /// <returns>The response from the ValidateTelemetryPipelineConfiguration service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ValidateTelemetryPipelineConfiguration">REST API Reference for ValidateTelemetryPipelineConfiguration Operation</seealso>
        public virtual ValidateTelemetryPipelineConfigurationResponse ValidateTelemetryPipelineConfiguration(ValidateTelemetryPipelineConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateTelemetryPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateTelemetryPipelineConfigurationResponseUnmarshaller.Instance;

            return Invoke<ValidateTelemetryPipelineConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateTelemetryPipelineConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateTelemetryPipelineConfiguration operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateTelemetryPipelineConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ValidateTelemetryPipelineConfiguration">REST API Reference for ValidateTelemetryPipelineConfiguration Operation</seealso>
        public virtual IAsyncResult BeginValidateTelemetryPipelineConfiguration(ValidateTelemetryPipelineConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateTelemetryPipelineConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateTelemetryPipelineConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateTelemetryPipelineConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateTelemetryPipelineConfiguration.</param>
        /// 
        /// <returns>Returns a  ValidateTelemetryPipelineConfigurationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ValidateTelemetryPipelineConfiguration">REST API Reference for ValidateTelemetryPipelineConfiguration Operation</seealso>
        public virtual ValidateTelemetryPipelineConfigurationResponse EndValidateTelemetryPipelineConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<ValidateTelemetryPipelineConfigurationResponse>(asyncResult);
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
            var resolver = new AmazonObservabilityAdminEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}