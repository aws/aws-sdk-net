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
 * Do not modify this file. This file is generated from the forecastquery-2018-06-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ForecastQueryService.Model;
using Amazon.ForecastQueryService.Model.Internal.MarshallTransformations;
using Amazon.ForecastQueryService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ForecastQueryService
{
    /// <summary>
    /// <para>Implementation for accessing ForecastQueryService</para>
    ///
    /// Provides APIs for creating and managing Amazon Forecast resources.
    /// </summary>
    public partial class AmazonForecastQueryServiceClient : AmazonServiceClient, IAmazonForecastQueryService
    {
        private static IServiceMetadata serviceMetadata = new AmazonForecastQueryServiceMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonForecastQueryServiceClient with the credentials loaded from the application's
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
        public AmazonForecastQueryServiceClient()
            : base(new AmazonForecastQueryServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonForecastQueryServiceClient with the credentials loaded from the application's
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
        public AmazonForecastQueryServiceClient(RegionEndpoint region)
            : base(new AmazonForecastQueryServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonForecastQueryServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonForecastQueryServiceClient Configuration Object</param>
        public AmazonForecastQueryServiceClient(AmazonForecastQueryServiceConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonForecastQueryServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonForecastQueryServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonForecastQueryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonForecastQueryServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonForecastQueryServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonForecastQueryServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonForecastQueryServiceClient with AWS Credentials and an
        /// AmazonForecastQueryServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonForecastQueryServiceClient Configuration Object</param>
        public AmazonForecastQueryServiceClient(AWSCredentials credentials, AmazonForecastQueryServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonForecastQueryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonForecastQueryServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonForecastQueryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonForecastQueryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonForecastQueryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonForecastQueryServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonForecastQueryServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonForecastQueryServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonForecastQueryServiceClient Configuration Object</param>
        public AmazonForecastQueryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonForecastQueryServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonForecastQueryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonForecastQueryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonForecastQueryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonForecastQueryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonForecastQueryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonForecastQueryServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonForecastQueryServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonForecastQueryServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonForecastQueryServiceClient Configuration Object</param>
        public AmazonForecastQueryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonForecastQueryServiceConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonForecastQueryServiceEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonForecastQueryServiceAuthSchemeHandler());
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


        #region  QueryForecast


        /// <summary>
        /// Retrieves a forecast for a single item, filtered by the supplied criteria.
        /// 
        ///  
        /// <para>
        /// The criteria is a key-value pair. The key is either <c>item_id</c> (or the equivalent
        /// non-timestamp, non-target field) from the <c>TARGET_TIME_SERIES</c> dataset, or one
        /// of the forecast dimensions specified as part of the <c>FeaturizationConfig</c> object.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>QueryForecast</c> returns the complete date range for the filtered
        /// forecast. You can request a specific date range.
        /// </para>
        ///  
        /// <para>
        /// To get the full forecast, use the <a href="https://docs.aws.amazon.com/en_us/forecast/latest/dg/API_CreateForecastExportJob.html">CreateForecastExportJob</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The forecasts generated by Amazon Forecast are in the same timezone as the dataset
        /// that was used to create the predictor.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryForecast service method.</param>
        /// 
        /// <returns>The response from the QueryForecast service method, as returned by ForecastQueryService.</returns>
        /// <exception cref="Amazon.ForecastQueryService.Model.InvalidInputException">
        /// The value is invalid or is too long.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.ResourceNotFoundException">
        /// We can't find that resource. Check the information that you've provided and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecastquery-2018-06-26/QueryForecast">REST API Reference for QueryForecast Operation</seealso>
        public virtual QueryForecastResponse QueryForecast(QueryForecastRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryForecastResponseUnmarshaller.Instance;

            return Invoke<QueryForecastResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a forecast for a single item, filtered by the supplied criteria.
        /// 
        ///  
        /// <para>
        /// The criteria is a key-value pair. The key is either <c>item_id</c> (or the equivalent
        /// non-timestamp, non-target field) from the <c>TARGET_TIME_SERIES</c> dataset, or one
        /// of the forecast dimensions specified as part of the <c>FeaturizationConfig</c> object.
        /// </para>
        ///  
        /// <para>
        /// By default, <c>QueryForecast</c> returns the complete date range for the filtered
        /// forecast. You can request a specific date range.
        /// </para>
        ///  
        /// <para>
        /// To get the full forecast, use the <a href="https://docs.aws.amazon.com/en_us/forecast/latest/dg/API_CreateForecastExportJob.html">CreateForecastExportJob</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The forecasts generated by Amazon Forecast are in the same timezone as the dataset
        /// that was used to create the predictor.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryForecast service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryForecast service method, as returned by ForecastQueryService.</returns>
        /// <exception cref="Amazon.ForecastQueryService.Model.InvalidInputException">
        /// The value is invalid or is too long.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.ResourceNotFoundException">
        /// We can't find that resource. Check the information that you've provided and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecastquery-2018-06-26/QueryForecast">REST API Reference for QueryForecast Operation</seealso>
        public virtual Task<QueryForecastResponse> QueryForecastAsync(QueryForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryForecastResponseUnmarshaller.Instance;
            
            return InvokeAsync<QueryForecastResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  QueryWhatIfForecast


        /// <summary>
        /// Retrieves a what-if forecast.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryWhatIfForecast service method.</param>
        /// 
        /// <returns>The response from the QueryWhatIfForecast service method, as returned by ForecastQueryService.</returns>
        /// <exception cref="Amazon.ForecastQueryService.Model.InvalidInputException">
        /// The value is invalid or is too long.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.ResourceNotFoundException">
        /// We can't find that resource. Check the information that you've provided and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecastquery-2018-06-26/QueryWhatIfForecast">REST API Reference for QueryWhatIfForecast Operation</seealso>
        public virtual QueryWhatIfForecastResponse QueryWhatIfForecast(QueryWhatIfForecastRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryWhatIfForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryWhatIfForecastResponseUnmarshaller.Instance;

            return Invoke<QueryWhatIfForecastResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a what-if forecast.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryWhatIfForecast service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryWhatIfForecast service method, as returned by ForecastQueryService.</returns>
        /// <exception cref="Amazon.ForecastQueryService.Model.InvalidInputException">
        /// The value is invalid or is too long.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastQueryService.Model.ResourceNotFoundException">
        /// We can't find that resource. Check the information that you've provided and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecastquery-2018-06-26/QueryWhatIfForecast">REST API Reference for QueryWhatIfForecast Operation</seealso>
        public virtual Task<QueryWhatIfForecastResponse> QueryWhatIfForecastAsync(QueryWhatIfForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryWhatIfForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryWhatIfForecastResponseUnmarshaller.Instance;
            
            return InvokeAsync<QueryWhatIfForecastResponse>(request, options, cancellationToken);
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