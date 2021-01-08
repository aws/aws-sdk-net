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
using System.Collections.Generic;
using System.Net;

using Amazon.ForecastQueryService.Model;
using Amazon.ForecastQueryService.Model.Internal.MarshallTransformations;
using Amazon.ForecastQueryService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ForecastQueryService
{
    /// <summary>
    /// Implementation for accessing ForecastQueryService
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonForecastQueryServiceConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonForecastQueryServiceConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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
        /// The criteria is a key-value pair. The key is either <code>item_id</code> (or the equivalent
        /// non-timestamp, non-target field) from the <code>TARGET_TIME_SERIES</code> dataset,
        /// or one of the forecast dimensions specified as part of the <code>FeaturizationConfig</code>
        /// object.
        /// </para>
        ///  
        /// <para>
        /// By default, <code>QueryForecast</code> returns the complete date range for the filtered
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
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryForecastResponseUnmarshaller.Instance;

            return Invoke<QueryForecastResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the QueryForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryForecast operation on AmazonForecastQueryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecastquery-2018-06-26/QueryForecast">REST API Reference for QueryForecast Operation</seealso>
        public virtual IAsyncResult BeginQueryForecast(QueryForecastRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryForecastResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  QueryForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryForecast.</param>
        /// 
        /// <returns>Returns a  QueryForecastResult from ForecastQueryService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecastquery-2018-06-26/QueryForecast">REST API Reference for QueryForecast Operation</seealso>
        public virtual QueryForecastResponse EndQueryForecast(IAsyncResult asyncResult)
        {
            return EndInvoke<QueryForecastResponse>(asyncResult);
        }

        #endregion
        
    }
}