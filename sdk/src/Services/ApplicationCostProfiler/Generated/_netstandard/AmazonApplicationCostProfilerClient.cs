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
 * Do not modify this file. This file is generated from the applicationcostprofiler-2020-09-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ApplicationCostProfiler.Model;
using Amazon.ApplicationCostProfiler.Model.Internal.MarshallTransformations;
using Amazon.ApplicationCostProfiler.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ApplicationCostProfiler
{
    /// <summary>
    /// <para>Implementation for accessing ApplicationCostProfiler</para>
    ///
    /// This reference provides descriptions of the AWS Application Cost Profiler API.
    /// 
    ///  
    /// <para>
    /// The AWS Application Cost Profiler API provides programmatic access to view, create,
    /// update, and delete application cost report definitions, as well as to import your
    /// usage data into the Application Cost Profiler service.
    /// </para>
    ///  
    /// <para>
    /// For more information about using this service, see the <a href="https://docs.aws.amazon.com/application-cost-profiler/latest/userguide/introduction.html">AWS
    /// Application Cost Profiler User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonApplicationCostProfilerClient : AmazonServiceClient, IAmazonApplicationCostProfiler
    {
        private static IServiceMetadata serviceMetadata = new AmazonApplicationCostProfilerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with the credentials loaded from the application's
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
        public AmazonApplicationCostProfilerClient()
            : base(new AmazonApplicationCostProfilerConfig()) { }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with the credentials loaded from the application's
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
        public AmazonApplicationCostProfilerClient(RegionEndpoint region)
            : base(new AmazonApplicationCostProfilerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonApplicationCostProfilerClient Configuration Object</param>
        public AmazonApplicationCostProfilerClient(AmazonApplicationCostProfilerConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonApplicationCostProfilerClient(AWSCredentials credentials)
            : this(credentials, new AmazonApplicationCostProfilerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationCostProfilerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonApplicationCostProfilerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Credentials and an
        /// AmazonApplicationCostProfilerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonApplicationCostProfilerClient Configuration Object</param>
        public AmazonApplicationCostProfilerClient(AWSCredentials credentials, AmazonApplicationCostProfilerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonApplicationCostProfilerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationCostProfilerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationCostProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationCostProfilerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationCostProfilerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonApplicationCostProfilerClient Configuration Object</param>
        public AmazonApplicationCostProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonApplicationCostProfilerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonApplicationCostProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationCostProfilerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationCostProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationCostProfilerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationCostProfilerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationCostProfilerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonApplicationCostProfilerClient Configuration Object</param>
        public AmazonApplicationCostProfilerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonApplicationCostProfilerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IApplicationCostProfilerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IApplicationCostProfilerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ApplicationCostProfilerPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonApplicationCostProfilerEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonApplicationCostProfilerAuthSchemeHandler());
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


        #region  DeleteReportDefinition

        internal virtual DeleteReportDefinitionResponse DeleteReportDefinition(DeleteReportDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteReportDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified report definition in AWS Application Cost Profiler. This stops
        /// the report from being generated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/DeleteReportDefinition">REST API Reference for DeleteReportDefinition Operation</seealso>
        public virtual Task<DeleteReportDefinitionResponse> DeleteReportDefinitionAsync(DeleteReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteReportDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReportDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReportDefinition

        internal virtual GetReportDefinitionResponse GetReportDefinition(GetReportDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetReportDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the definition of a report already configured in AWS Application Cost Profiler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/GetReportDefinition">REST API Reference for GetReportDefinition Operation</seealso>
        public virtual Task<GetReportDefinitionResponse> GetReportDefinitionAsync(GetReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReportDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetReportDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ImportApplicationUsage

        internal virtual ImportApplicationUsageResponse ImportApplicationUsage(ImportApplicationUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportApplicationUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportApplicationUsageResponseUnmarshaller.Instance;

            return Invoke<ImportApplicationUsageResponse>(request, options);
        }



        /// <summary>
        /// Ingests application usage data from Amazon Simple Storage Service (Amazon S3).
        /// 
        ///  
        /// <para>
        /// The data must already exist in the S3 location. As part of the action, AWS Application
        /// Cost Profiler copies the object from your S3 bucket to an S3 bucket owned by Amazon
        /// for processing asynchronously.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApplicationUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportApplicationUsage service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ImportApplicationUsage">REST API Reference for ImportApplicationUsage Operation</seealso>
        public virtual Task<ImportApplicationUsageResponse> ImportApplicationUsageAsync(ImportApplicationUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportApplicationUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportApplicationUsageResponseUnmarshaller.Instance;

            return InvokeAsync<ImportApplicationUsageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReportDefinitions

        internal virtual ListReportDefinitionsResponse ListReportDefinitions(ListReportDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReportDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListReportDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of all reports and their configurations for your AWS account.
        /// 
        ///  
        /// <para>
        /// The maximum number of reports is one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReportDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReportDefinitions service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/ListReportDefinitions">REST API Reference for ListReportDefinitions Operation</seealso>
        public virtual Task<ListReportDefinitionsResponse> ListReportDefinitionsAsync(ListReportDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListReportDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReportDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReportDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutReportDefinition

        internal virtual PutReportDefinitionResponse PutReportDefinition(PutReportDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<PutReportDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates the report definition for a report in Application Cost Profiler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ServiceQuotaExceededException">
        /// Your request exceeds one or more of the service quotas.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/PutReportDefinition">REST API Reference for PutReportDefinition Operation</seealso>
        public virtual Task<PutReportDefinitionResponse> PutReportDefinitionAsync(PutReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutReportDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<PutReportDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateReportDefinition

        internal virtual UpdateReportDefinitionResponse UpdateReportDefinition(UpdateReportDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReportDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateReportDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Updates existing report in AWS Application Cost Profiler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReportDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateReportDefinition service method, as returned by ApplicationCostProfiler.</returns>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.AccessDeniedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ThrottlingException">
        /// The calls to AWS Application Cost Profiler API are throttled. The request was denied.
        /// </exception>
        /// <exception cref="Amazon.ApplicationCostProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints for the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/AWSApplicationCostProfiler-2020-09-10/UpdateReportDefinition">REST API Reference for UpdateReportDefinition Operation</seealso>
        public virtual Task<UpdateReportDefinitionResponse> UpdateReportDefinitionAsync(UpdateReportDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateReportDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateReportDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateReportDefinitionResponse>(request, options, cancellationToken);
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