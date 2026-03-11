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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ApplicationInsights.Model;
using Amazon.ApplicationInsights.Model.Internal.MarshallTransformations;
using Amazon.ApplicationInsights.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ApplicationInsights
{
    /// <summary>
    /// <para>Implementation for accessing ApplicationInsights</para>
    ///
    /// Amazon CloudWatch Application Insights 
    /// <para>
    ///  Amazon CloudWatch Application Insights is a service that helps you detect common
    /// problems with your applications. It enables you to pinpoint the source of issues in
    /// your applications (built with technologies such as Microsoft IIS, .NET, and Microsoft
    /// SQL Server), by providing key insights into detected problems.
    /// </para>
    ///  
    /// <para>
    /// After you onboard your application, CloudWatch Application Insights identifies, recommends,
    /// and sets up metrics and logs. It continuously analyzes and correlates your metrics
    /// and logs for unusual behavior to surface actionable problems with your application.
    /// For example, if your application is slow and unresponsive and leading to HTTP 500
    /// errors in your Application Load Balancer (ALB), Application Insights informs you that
    /// a memory pressure problem with your SQL Server database is occurring. It bases this
    /// analysis on impactful metrics and log errors. 
    /// </para>
    /// </summary>
    public partial class AmazonApplicationInsightsClient : AmazonServiceClient, IAmazonApplicationInsights
    {
        private static IServiceMetadata serviceMetadata = new AmazonApplicationInsightsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with the credentials loaded from the application's
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
        public AmazonApplicationInsightsClient()
            : base(new AmazonApplicationInsightsConfig()) { }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with the credentials loaded from the application's
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
        public AmazonApplicationInsightsClient(RegionEndpoint region)
            : base(new AmazonApplicationInsightsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonApplicationInsightsClient Configuration Object</param>
        public AmazonApplicationInsightsClient(AmazonApplicationInsightsConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonApplicationInsightsClient(AWSCredentials credentials)
            : this(credentials, new AmazonApplicationInsightsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationInsightsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonApplicationInsightsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Credentials and an
        /// AmazonApplicationInsightsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonApplicationInsightsClient Configuration Object</param>
        public AmazonApplicationInsightsClient(AWSCredentials credentials, AmazonApplicationInsightsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationInsightsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationInsightsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationInsightsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonApplicationInsightsClient Configuration Object</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonApplicationInsightsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationInsightsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationInsightsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationInsightsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationInsightsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonApplicationInsightsClient Configuration Object</param>
        public AmazonApplicationInsightsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonApplicationInsightsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IApplicationInsightsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IApplicationInsightsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ApplicationInsightsPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonApplicationInsightsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonApplicationInsightsAuthSchemeHandler());
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


        #region  AddWorkload

        internal virtual AddWorkloadResponse AddWorkload(AddWorkloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddWorkloadResponseUnmarshaller.Instance;

            return Invoke<AddWorkloadResponse>(request, options);
        }



        /// <summary>
        /// Adds a workload to a component. Each component can have at most five workloads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddWorkload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddWorkload service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/AddWorkload">REST API Reference for AddWorkload Operation</seealso>
        public virtual Task<AddWorkloadResponse> AddWorkloadAsync(AddWorkloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddWorkloadResponseUnmarshaller.Instance;

            return InvokeAsync<AddWorkloadResponse>(request, options, cancellationToken);
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
        /// Adds an application that is created from a resource group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.AccessDeniedException">
        /// User does not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.TagsAlreadyExistException">
        /// Tags are already registered for the specified application ARN.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateComponent

        internal virtual CreateComponentResponse CreateComponent(CreateComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return Invoke<CreateComponentResponse>(request, options);
        }



        /// <summary>
        /// Creates a custom component by grouping similar standalone instances to monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual Task<CreateComponentResponse> CreateComponentAsync(CreateComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateComponentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateLogPattern

        internal virtual CreateLogPatternResponse CreateLogPattern(CreateLogPatternRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogPatternResponseUnmarshaller.Instance;

            return Invoke<CreateLogPatternResponse>(request, options);
        }



        /// <summary>
        /// Adds an log pattern to a <c>LogPatternSet</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogPattern service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLogPattern service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/CreateLogPattern">REST API Reference for CreateLogPattern Operation</seealso>
        public virtual Task<CreateLogPatternResponse> CreateLogPatternAsync(CreateLogPatternRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogPatternResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLogPatternResponse>(request, options, cancellationToken);
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
        /// Removes the specified application from monitoring. Does not delete the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.BadRequestException">
        /// The request is not understood by the server.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteComponent

        internal virtual DeleteComponentResponse DeleteComponent(DeleteComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteComponentResponse>(request, options);
        }



        /// <summary>
        /// Ungroups a custom component. When you ungroup custom components, all applicable monitors
        /// that are set up for the component are removed and the instances revert to their standalone
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual Task<DeleteComponentResponse> DeleteComponentAsync(DeleteComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteComponentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteLogPattern

        internal virtual DeleteLogPatternResponse DeleteLogPattern(DeleteLogPatternRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogPatternResponseUnmarshaller.Instance;

            return Invoke<DeleteLogPatternResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified log pattern from a <c>LogPatternSet</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogPattern service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLogPattern service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.BadRequestException">
        /// The request is not understood by the server.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DeleteLogPattern">REST API Reference for DeleteLogPattern Operation</seealso>
        public virtual Task<DeleteLogPatternResponse> DeleteLogPatternAsync(DeleteLogPatternRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogPatternResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLogPatternResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeApplication

        internal virtual DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationResponse>(request, options);
        }



        /// <summary>
        /// Describes the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        public virtual Task<DescribeApplicationResponse> DescribeApplicationAsync(DescribeApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeComponent

        internal virtual DescribeComponentResponse DescribeComponent(DescribeComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentResponseUnmarshaller.Instance;

            return Invoke<DescribeComponentResponse>(request, options);
        }



        /// <summary>
        /// Describes a component and lists the resources that are grouped together in a component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        public virtual Task<DescribeComponentResponse> DescribeComponentAsync(DescribeComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeComponentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeComponentConfiguration

        internal virtual DescribeComponentConfigurationResponse DescribeComponentConfiguration(DescribeComponentConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComponentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeComponentConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Describes the monitoring configuration of the component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponentConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeComponentConfiguration service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfiguration">REST API Reference for DescribeComponentConfiguration Operation</seealso>
        public virtual Task<DescribeComponentConfigurationResponse> DescribeComponentConfigurationAsync(DescribeComponentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComponentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeComponentConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeComponentConfigurationRecommendation

        internal virtual DescribeComponentConfigurationRecommendationResponse DescribeComponentConfigurationRecommendation(DescribeComponentConfigurationRecommendationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComponentConfigurationRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentConfigurationRecommendationResponseUnmarshaller.Instance;

            return Invoke<DescribeComponentConfigurationRecommendationResponse>(request, options);
        }



        /// <summary>
        /// Describes the recommended monitoring configuration of the component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponentConfigurationRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeComponentConfigurationRecommendation service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeComponentConfigurationRecommendation">REST API Reference for DescribeComponentConfigurationRecommendation Operation</seealso>
        public virtual Task<DescribeComponentConfigurationRecommendationResponse> DescribeComponentConfigurationRecommendationAsync(DescribeComponentConfigurationRecommendationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComponentConfigurationRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentConfigurationRecommendationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeComponentConfigurationRecommendationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeLogPattern

        internal virtual DescribeLogPatternResponse DescribeLogPattern(DescribeLogPatternRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLogPatternResponseUnmarshaller.Instance;

            return Invoke<DescribeLogPatternResponse>(request, options);
        }



        /// <summary>
        /// Describe a specific log pattern from a <c>LogPatternSet</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogPattern service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLogPattern service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeLogPattern">REST API Reference for DescribeLogPattern Operation</seealso>
        public virtual Task<DescribeLogPatternResponse> DescribeLogPatternAsync(DescribeLogPatternRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLogPatternResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLogPatternResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeObservation

        internal virtual DescribeObservationResponse DescribeObservation(DescribeObservationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeObservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeObservationResponseUnmarshaller.Instance;

            return Invoke<DescribeObservationResponse>(request, options);
        }



        /// <summary>
        /// Describes an anomaly or error with the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeObservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeObservation service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeObservation">REST API Reference for DescribeObservation Operation</seealso>
        public virtual Task<DescribeObservationResponse> DescribeObservationAsync(DescribeObservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeObservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeObservationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeObservationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeProblem

        internal virtual DescribeProblemResponse DescribeProblem(DescribeProblemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProblemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProblemResponseUnmarshaller.Instance;

            return Invoke<DescribeProblemResponse>(request, options);
        }



        /// <summary>
        /// Describes an application problem.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProblem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProblem service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblem">REST API Reference for DescribeProblem Operation</seealso>
        public virtual Task<DescribeProblemResponse> DescribeProblemAsync(DescribeProblemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProblemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProblemResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProblemResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeProblemObservations

        internal virtual DescribeProblemObservationsResponse DescribeProblemObservations(DescribeProblemObservationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProblemObservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProblemObservationsResponseUnmarshaller.Instance;

            return Invoke<DescribeProblemObservationsResponse>(request, options);
        }



        /// <summary>
        /// Describes the anomalies or errors associated with the problem.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProblemObservations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProblemObservations service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeProblemObservations">REST API Reference for DescribeProblemObservations Operation</seealso>
        public virtual Task<DescribeProblemObservationsResponse> DescribeProblemObservationsAsync(DescribeProblemObservationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProblemObservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProblemObservationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProblemObservationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeWorkload

        internal virtual DescribeWorkloadResponse DescribeWorkload(DescribeWorkloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkloadResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkloadResponse>(request, options);
        }



        /// <summary>
        /// Describes a workload and its configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkload service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/DescribeWorkload">REST API Reference for DescribeWorkload Operation</seealso>
        public virtual Task<DescribeWorkloadResponse> DescribeWorkloadAsync(DescribeWorkloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkloadResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkloadResponse>(request, options, cancellationToken);
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
        /// Lists the IDs of the applications that you are monitoring.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListComponents

        internal virtual ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return Invoke<ListComponentsResponse>(request, options);
        }



        /// <summary>
        /// Lists the auto-grouped, standalone, and custom components of the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual Task<ListComponentsResponse> ListComponentsAsync(ListComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListComponentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListConfigurationHistory

        internal virtual ListConfigurationHistoryResponse ListConfigurationHistory(ListConfigurationHistoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationHistoryResponseUnmarshaller.Instance;

            return Invoke<ListConfigurationHistoryResponse>(request, options);
        }



        /// <summary>
        /// Lists the INFO, WARN, and ERROR events for periodic configuration updates performed
        /// by Application Insights. Examples of events represented are: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// INFO: creating a new alarm or updating an alarm threshold.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WARN: alarm not created due to insufficient data points used to predict thresholds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ERROR: alarm not created due to permission errors or exceeding quotas. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfigurationHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfigurationHistory service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListConfigurationHistory">REST API Reference for ListConfigurationHistory Operation</seealso>
        public virtual Task<ListConfigurationHistoryResponse> ListConfigurationHistoryAsync(ListConfigurationHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConfigurationHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfigurationHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfigurationHistoryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLogPatterns

        internal virtual ListLogPatternsResponse ListLogPatterns(ListLogPatternsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLogPatternsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogPatternsResponseUnmarshaller.Instance;

            return Invoke<ListLogPatternsResponse>(request, options);
        }



        /// <summary>
        /// Lists the log patterns in the specific log <c>LogPatternSet</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogPatterns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLogPatterns service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListLogPatterns">REST API Reference for ListLogPatterns Operation</seealso>
        public virtual Task<ListLogPatternsResponse> ListLogPatternsAsync(ListLogPatternsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLogPatternsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogPatternsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLogPatternsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLogPatternSets

        internal virtual ListLogPatternSetsResponse ListLogPatternSets(ListLogPatternSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLogPatternSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogPatternSetsResponseUnmarshaller.Instance;

            return Invoke<ListLogPatternSetsResponse>(request, options);
        }



        /// <summary>
        /// Lists the log pattern sets in the specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogPatternSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLogPatternSets service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListLogPatternSets">REST API Reference for ListLogPatternSets Operation</seealso>
        public virtual Task<ListLogPatternSetsResponse> ListLogPatternSetsAsync(ListLogPatternSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLogPatternSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogPatternSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLogPatternSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProblems

        internal virtual ListProblemsResponse ListProblems(ListProblemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProblemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProblemsResponseUnmarshaller.Instance;

            return Invoke<ListProblemsResponse>(request, options);
        }



        /// <summary>
        /// Lists the problems with your application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProblems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProblems service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListProblems">REST API Reference for ListProblems Operation</seealso>
        public virtual Task<ListProblemsResponse> ListProblemsAsync(ListProblemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProblemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProblemsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProblemsResponse>(request, options, cancellationToken);
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
        /// Retrieve a list of the tags (keys and values) that are associated with a specified
        /// application. A <i>tag</i> is a label that you optionally define and associate with
        /// an application. Each tag consists of a required <i>tag key</i> and an optional associated
        /// <i>tag value</i>. A tag key is a general label that acts as a category for more specific
        /// tag values. A tag value acts as a descriptor within a tag key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkloads

        internal virtual ListWorkloadsResponse ListWorkloads(ListWorkloadsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadsResponseUnmarshaller.Instance;

            return Invoke<ListWorkloadsResponse>(request, options);
        }



        /// <summary>
        /// Lists the workloads that are configured on a given component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloads service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkloads service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        public virtual Task<ListWorkloadsResponse> ListWorkloadsAsync(ListWorkloadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkloadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkloadsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkloadsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveWorkload

        internal virtual RemoveWorkloadResponse RemoveWorkload(RemoveWorkloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveWorkloadResponseUnmarshaller.Instance;

            return Invoke<RemoveWorkloadResponse>(request, options);
        }



        /// <summary>
        /// Remove workload from a component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveWorkload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveWorkload service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/RemoveWorkload">REST API Reference for RemoveWorkload Operation</seealso>
        public virtual Task<RemoveWorkloadResponse> RemoveWorkloadAsync(RemoveWorkloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveWorkloadResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveWorkloadResponse>(request, options, cancellationToken);
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
        /// Add one or more tags (keys and values) to a specified application. A <i>tag</i> is
        /// a label that you optionally define and associate with an application. Tags can help
        /// you categorize and manage application in different ways, such as by purpose, owner,
        /// environment, or other criteria. 
        /// 
        ///  
        /// <para>
        /// Each tag consists of a required <i>tag key</i> and an associated <i>tag value</i>,
        /// both of which you define. A tag key is a general label that acts as a category for
        /// more specific tag values. A tag value acts as a descriptor within a tag key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.TooManyTagsException">
        /// The number of the provided tags is beyond the limit, or the number of total tags you
        /// are trying to attach to the specified resource exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Remove one or more tags (keys and values) from a specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateApplication

        internal virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Updates the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateComponent

        internal virtual UpdateComponentResponse UpdateComponent(UpdateComponentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentResponseUnmarshaller.Instance;

            return Invoke<UpdateComponentResponse>(request, options);
        }



        /// <summary>
        /// Updates the custom component name and/or the list of resources that make up the component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateComponent service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        public virtual Task<UpdateComponentResponse> UpdateComponentAsync(UpdateComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateComponentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateComponentConfiguration

        internal virtual UpdateComponentConfigurationResponse UpdateComponentConfiguration(UpdateComponentConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateComponentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateComponentConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the monitoring configurations for the component. The configuration input parameter
        /// is an escaped JSON of the configuration and should match the schema of what is returned
        /// by <c>DescribeComponentConfigurationRecommendation</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponentConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateComponentConfiguration service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateComponentConfiguration">REST API Reference for UpdateComponentConfiguration Operation</seealso>
        public virtual Task<UpdateComponentConfigurationResponse> UpdateComponentConfigurationAsync(UpdateComponentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateComponentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateComponentConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateLogPattern

        internal virtual UpdateLogPatternResponse UpdateLogPattern(UpdateLogPatternRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLogPatternResponseUnmarshaller.Instance;

            return Invoke<UpdateLogPatternResponse>(request, options);
        }



        /// <summary>
        /// Adds a log pattern to a <c>LogPatternSet</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogPattern service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLogPattern service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceInUseException">
        /// The resource is already created or in use.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateLogPattern">REST API Reference for UpdateLogPattern Operation</seealso>
        public virtual Task<UpdateLogPatternResponse> UpdateLogPatternAsync(UpdateLogPatternRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLogPatternRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLogPatternResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLogPatternResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateProblem

        internal virtual UpdateProblemResponse UpdateProblem(UpdateProblemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProblemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProblemResponseUnmarshaller.Instance;

            return Invoke<UpdateProblemResponse>(request, options);
        }



        /// <summary>
        /// Updates the visibility of the problem or specifies the problem as <c>RESOLVED</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProblem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProblem service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateProblem">REST API Reference for UpdateProblem Operation</seealso>
        public virtual Task<UpdateProblemResponse> UpdateProblemAsync(UpdateProblemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProblemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProblemResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProblemResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWorkload

        internal virtual UpdateWorkloadResponse UpdateWorkload(UpdateWorkloadRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkloadResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkloadResponse>(request, options);
        }



        /// <summary>
        /// Adds a workload to a component. Each component can have at most five workloads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkload service method, as returned by ApplicationInsights.</returns>
        /// <exception cref="Amazon.ApplicationInsights.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ResourceNotFoundException">
        /// The resource does not exist in the customer account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationInsights.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-insights-2018-11-25/UpdateWorkload">REST API Reference for UpdateWorkload Operation</seealso>
        public virtual Task<UpdateWorkloadResponse> UpdateWorkloadAsync(UpdateWorkloadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkloadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkloadResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkloadResponse>(request, options, cancellationToken);
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