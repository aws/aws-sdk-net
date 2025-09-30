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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Neptunedata.Model;
using Amazon.Neptunedata.Model.Internal.MarshallTransformations;
using Amazon.Neptunedata.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Neptunedata
{
    /// <summary>
    /// <para>Implementation for accessing Neptunedata</para>
    ///
    /// Neptune Data API 
    /// <para>
    /// The Amazon Neptune data API provides SDK support for more than 40 of Neptune's data
    /// operations, including data loading, query execution, data inquiry, and machine learning.
    /// It supports the Gremlin and openCypher query languages, and is available in all SDK
    /// languages. It automatically signs API requests and greatly simplifies integrating
    /// Neptune into your applications.
    /// 
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonNeptunedataClient : AmazonServiceClient, IAmazonNeptunedata
    {
        private static IServiceMetadata serviceMetadata = new AmazonNeptunedataMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonNeptunedataClient with the credentials loaded from the application's
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
        public AmazonNeptunedataClient()
            : base(new AmazonNeptunedataConfig()) { }

        /// <summary>
        /// Constructs AmazonNeptunedataClient with the credentials loaded from the application's
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
        public AmazonNeptunedataClient(RegionEndpoint region)
            : base(new AmazonNeptunedataConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNeptunedataClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNeptunedataClient Configuration Object</param>
        public AmazonNeptunedataClient(AmazonNeptunedataConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonNeptunedataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNeptunedataClient(AWSCredentials credentials)
            : this(credentials, new AmazonNeptunedataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNeptunedataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNeptunedataClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNeptunedataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNeptunedataClient with AWS Credentials and an
        /// AmazonNeptunedataClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNeptunedataClient Configuration Object</param>
        public AmazonNeptunedataClient(AWSCredentials credentials, AmazonNeptunedataConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNeptunedataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNeptunedataClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNeptunedataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNeptunedataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNeptunedataClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNeptunedataConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNeptunedataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNeptunedataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNeptunedataClient Configuration Object</param>
        public AmazonNeptunedataClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNeptunedataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNeptunedataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNeptunedataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNeptunedataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNeptunedataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNeptunedataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNeptunedataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNeptunedataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNeptunedataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNeptunedataClient Configuration Object</param>
        public AmazonNeptunedataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNeptunedataConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNeptunedataEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNeptunedataAuthSchemeHandler());
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


        #region  CancelGremlinQuery


        /// <summary>
        /// Cancels a Gremlin query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-api-status-cancel.html">Gremlin
        /// query cancellation</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelquery">neptune-db:CancelQuery</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelGremlinQuery service method.</param>
        /// 
        /// <returns>The response from the CancelGremlinQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelGremlinQuery">REST API Reference for CancelGremlinQuery Operation</seealso>
        public virtual CancelGremlinQueryResponse CancelGremlinQuery(CancelGremlinQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelGremlinQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelGremlinQueryResponseUnmarshaller.Instance;

            return Invoke<CancelGremlinQueryResponse>(request, options);
        }


        /// <summary>
        /// Cancels a Gremlin query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-api-status-cancel.html">Gremlin
        /// query cancellation</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelquery">neptune-db:CancelQuery</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelGremlinQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelGremlinQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelGremlinQuery">REST API Reference for CancelGremlinQuery Operation</seealso>
        public virtual Task<CancelGremlinQueryResponse> CancelGremlinQueryAsync(CancelGremlinQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelGremlinQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelGremlinQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelGremlinQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelLoaderJob


        /// <summary>
        /// Cancels a specified load job. This is an HTTP <c>DELETE</c> request. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/load-api-reference-status.htm">Neptune
        /// Loader Get-Status API</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelloaderjob">neptune-db:CancelLoaderJob</a>
        /// IAM action in that cluster..
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelLoaderJob service method.</param>
        /// 
        /// <returns>The response from the CancelLoaderJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelLoaderJob">REST API Reference for CancelLoaderJob Operation</seealso>
        public virtual CancelLoaderJobResponse CancelLoaderJob(CancelLoaderJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelLoaderJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelLoaderJobResponseUnmarshaller.Instance;

            return Invoke<CancelLoaderJobResponse>(request, options);
        }


        /// <summary>
        /// Cancels a specified load job. This is an HTTP <c>DELETE</c> request. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/load-api-reference-status.htm">Neptune
        /// Loader Get-Status API</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelloaderjob">neptune-db:CancelLoaderJob</a>
        /// IAM action in that cluster..
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelLoaderJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelLoaderJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelLoaderJob">REST API Reference for CancelLoaderJob Operation</seealso>
        public virtual Task<CancelLoaderJobResponse> CancelLoaderJobAsync(CancelLoaderJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelLoaderJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelLoaderJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelLoaderJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelMLDataProcessingJob


        /// <summary>
        /// Cancels a Neptune ML data processing job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <c>dataprocessing</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelmldataprocessingjob">neptune-db:CancelMLDataProcessingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMLDataProcessingJob service method.</param>
        /// 
        /// <returns>The response from the CancelMLDataProcessingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLDataProcessingJob">REST API Reference for CancelMLDataProcessingJob Operation</seealso>
        public virtual CancelMLDataProcessingJobResponse CancelMLDataProcessingJob(CancelMLDataProcessingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelMLDataProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMLDataProcessingJobResponseUnmarshaller.Instance;

            return Invoke<CancelMLDataProcessingJobResponse>(request, options);
        }


        /// <summary>
        /// Cancels a Neptune ML data processing job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <c>dataprocessing</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelmldataprocessingjob">neptune-db:CancelMLDataProcessingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMLDataProcessingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMLDataProcessingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLDataProcessingJob">REST API Reference for CancelMLDataProcessingJob Operation</seealso>
        public virtual Task<CancelMLDataProcessingJobResponse> CancelMLDataProcessingJobAsync(CancelMLDataProcessingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelMLDataProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMLDataProcessingJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelMLDataProcessingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelMLModelTrainingJob


        /// <summary>
        /// Cancels a Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelmlmodeltrainingjob">neptune-db:CancelMLModelTrainingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMLModelTrainingJob service method.</param>
        /// 
        /// <returns>The response from the CancelMLModelTrainingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLModelTrainingJob">REST API Reference for CancelMLModelTrainingJob Operation</seealso>
        public virtual CancelMLModelTrainingJobResponse CancelMLModelTrainingJob(CancelMLModelTrainingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelMLModelTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMLModelTrainingJobResponseUnmarshaller.Instance;

            return Invoke<CancelMLModelTrainingJobResponse>(request, options);
        }


        /// <summary>
        /// Cancels a Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelmlmodeltrainingjob">neptune-db:CancelMLModelTrainingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMLModelTrainingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMLModelTrainingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLModelTrainingJob">REST API Reference for CancelMLModelTrainingJob Operation</seealso>
        public virtual Task<CancelMLModelTrainingJobResponse> CancelMLModelTrainingJobAsync(CancelMLModelTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelMLModelTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMLModelTrainingJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelMLModelTrainingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelMLModelTransformJob


        /// <summary>
        /// Cancels a specified model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelmlmodeltransformjob">neptune-db:CancelMLModelTransformJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMLModelTransformJob service method.</param>
        /// 
        /// <returns>The response from the CancelMLModelTransformJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLModelTransformJob">REST API Reference for CancelMLModelTransformJob Operation</seealso>
        public virtual CancelMLModelTransformJobResponse CancelMLModelTransformJob(CancelMLModelTransformJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelMLModelTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMLModelTransformJobResponseUnmarshaller.Instance;

            return Invoke<CancelMLModelTransformJobResponse>(request, options);
        }


        /// <summary>
        /// Cancels a specified model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelmlmodeltransformjob">neptune-db:CancelMLModelTransformJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMLModelTransformJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMLModelTransformJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLModelTransformJob">REST API Reference for CancelMLModelTransformJob Operation</seealso>
        public virtual Task<CancelMLModelTransformJobResponse> CancelMLModelTransformJobAsync(CancelMLModelTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelMLModelTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMLModelTransformJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelMLModelTransformJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelOpenCypherQuery


        /// <summary>
        /// Cancels a specified openCypher query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-status.html">Neptune
        /// openCypher status endpoint</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelquery">neptune-db:CancelQuery</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelOpenCypherQuery service method.</param>
        /// 
        /// <returns>The response from the CancelOpenCypherQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelOpenCypherQuery">REST API Reference for CancelOpenCypherQuery Operation</seealso>
        public virtual CancelOpenCypherQueryResponse CancelOpenCypherQuery(CancelOpenCypherQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelOpenCypherQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelOpenCypherQueryResponseUnmarshaller.Instance;

            return Invoke<CancelOpenCypherQueryResponse>(request, options);
        }


        /// <summary>
        /// Cancels a specified openCypher query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-status.html">Neptune
        /// openCypher status endpoint</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelquery">neptune-db:CancelQuery</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelOpenCypherQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelOpenCypherQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelOpenCypherQuery">REST API Reference for CancelOpenCypherQuery Operation</seealso>
        public virtual Task<CancelOpenCypherQueryResponse> CancelOpenCypherQueryAsync(CancelOpenCypherQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelOpenCypherQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelOpenCypherQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelOpenCypherQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMLEndpoint


        /// <summary>
        /// Creates a new Neptune ML inference endpoint that lets you query one specific model
        /// that the model-training process constructed. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#createmlendpoint">neptune-db:CreateMLEndpoint</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMLEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateMLEndpoint service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CreateMLEndpoint">REST API Reference for CreateMLEndpoint Operation</seealso>
        public virtual CreateMLEndpointResponse CreateMLEndpoint(CreateMLEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMLEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMLEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateMLEndpointResponse>(request, options);
        }


        /// <summary>
        /// Creates a new Neptune ML inference endpoint that lets you query one specific model
        /// that the model-training process constructed. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#createmlendpoint">neptune-db:CreateMLEndpoint</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMLEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMLEndpoint service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CreateMLEndpoint">REST API Reference for CreateMLEndpoint Operation</seealso>
        public virtual Task<CreateMLEndpointResponse> CreateMLEndpointAsync(CreateMLEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMLEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMLEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMLEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMLEndpoint


        /// <summary>
        /// Cancels the creation of a Neptune ML inference endpoint. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletemlendpoint">neptune-db:DeleteMLEndpoint</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteMLEndpoint service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeleteMLEndpoint">REST API Reference for DeleteMLEndpoint Operation</seealso>
        public virtual DeleteMLEndpointResponse DeleteMLEndpoint(DeleteMLEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMLEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMLEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteMLEndpointResponse>(request, options);
        }


        /// <summary>
        /// Cancels the creation of a Neptune ML inference endpoint. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletemlendpoint">neptune-db:DeleteMLEndpoint</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMLEndpoint service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeleteMLEndpoint">REST API Reference for DeleteMLEndpoint Operation</seealso>
        public virtual Task<DeleteMLEndpointResponse> DeleteMLEndpointAsync(DeleteMLEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMLEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMLEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMLEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePropertygraphStatistics


        /// <summary>
        /// Deletes statistics for Gremlin and openCypher (property graph) data.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletestatistics">neptune-db:DeleteStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePropertygraphStatistics service method.</param>
        /// 
        /// <returns>The response from the DeletePropertygraphStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeletePropertygraphStatistics">REST API Reference for DeletePropertygraphStatistics Operation</seealso>
        public virtual DeletePropertygraphStatisticsResponse DeletePropertygraphStatistics(DeletePropertygraphStatisticsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePropertygraphStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePropertygraphStatisticsResponseUnmarshaller.Instance;

            return Invoke<DeletePropertygraphStatisticsResponse>(request, options);
        }


        /// <summary>
        /// Deletes statistics for Gremlin and openCypher (property graph) data.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletestatistics">neptune-db:DeleteStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePropertygraphStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePropertygraphStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeletePropertygraphStatistics">REST API Reference for DeletePropertygraphStatistics Operation</seealso>
        public virtual Task<DeletePropertygraphStatisticsResponse> DeletePropertygraphStatisticsAsync(DeletePropertygraphStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePropertygraphStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePropertygraphStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePropertygraphStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSparqlStatistics


        /// <summary>
        /// Deletes SPARQL statistics
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletestatistics">neptune-db:DeleteStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSparqlStatistics service method.</param>
        /// 
        /// <returns>The response from the DeleteSparqlStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeleteSparqlStatistics">REST API Reference for DeleteSparqlStatistics Operation</seealso>
        public virtual DeleteSparqlStatisticsResponse DeleteSparqlStatistics(DeleteSparqlStatisticsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSparqlStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSparqlStatisticsResponseUnmarshaller.Instance;

            return Invoke<DeleteSparqlStatisticsResponse>(request, options);
        }


        /// <summary>
        /// Deletes SPARQL statistics
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletestatistics">neptune-db:DeleteStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSparqlStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSparqlStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeleteSparqlStatistics">REST API Reference for DeleteSparqlStatistics Operation</seealso>
        public virtual Task<DeleteSparqlStatisticsResponse> DeleteSparqlStatisticsAsync(DeleteSparqlStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSparqlStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSparqlStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSparqlStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteFastReset


        /// <summary>
        /// The fast reset REST API lets you reset a Neptune graph quicky and easily, removing
        /// all of its data.
        /// 
        ///  
        /// <para>
        /// Neptune fast reset is a two-step process. First you call <c>ExecuteFastReset</c> with
        /// <c>action</c> set to <c>initiateDatabaseReset</c>. This returns a UUID token which
        /// you then include when calling <c>ExecuteFastReset</c> again with <c>action</c> set
        /// to <c>performDatabaseReset</c>. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/manage-console-fast-reset.html">Empty
        /// an Amazon Neptune DB cluster using the fast reset API</a>.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#resetdatabase">neptune-db:ResetDatabase</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteFastReset service method.</param>
        /// 
        /// <returns>The response from the ExecuteFastReset service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MethodNotAllowedException">
        /// Raised when the HTTP method used by a request is not supported by the endpoint being
        /// used.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ServerShutdownException">
        /// Raised when the server shuts down while processing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteFastReset">REST API Reference for ExecuteFastReset Operation</seealso>
        public virtual ExecuteFastResetResponse ExecuteFastReset(ExecuteFastResetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteFastResetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteFastResetResponseUnmarshaller.Instance;

            return Invoke<ExecuteFastResetResponse>(request, options);
        }


        /// <summary>
        /// The fast reset REST API lets you reset a Neptune graph quicky and easily, removing
        /// all of its data.
        /// 
        ///  
        /// <para>
        /// Neptune fast reset is a two-step process. First you call <c>ExecuteFastReset</c> with
        /// <c>action</c> set to <c>initiateDatabaseReset</c>. This returns a UUID token which
        /// you then include when calling <c>ExecuteFastReset</c> again with <c>action</c> set
        /// to <c>performDatabaseReset</c>. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/manage-console-fast-reset.html">Empty
        /// an Amazon Neptune DB cluster using the fast reset API</a>.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#resetdatabase">neptune-db:ResetDatabase</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteFastReset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteFastReset service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MethodNotAllowedException">
        /// Raised when the HTTP method used by a request is not supported by the endpoint being
        /// used.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ServerShutdownException">
        /// Raised when the server shuts down while processing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteFastReset">REST API Reference for ExecuteFastReset Operation</seealso>
        public virtual Task<ExecuteFastResetResponse> ExecuteFastResetAsync(ExecuteFastResetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteFastResetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteFastResetResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteFastResetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteGremlinExplainQuery


        /// <summary>
        /// Executes a Gremlin Explain query.
        /// 
        ///  
        /// <para>
        /// Amazon Neptune has added a Gremlin feature named <c>explain</c> that provides is a
        /// self-service tool for understanding the execution approach being taken by the Neptune
        /// engine for the query. You invoke it by adding an <c>explain</c> parameter to an HTTP
        /// call that submits a Gremlin query.
        /// </para>
        ///  
        /// <para>
        /// The explain feature provides information about the logical structure of query execution
        /// plans. You can use this information to identify potential evaluation and execution
        /// bottlenecks and to tune your query, as explained in <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-traversal-tuning.html">Tuning
        /// Gremlin queries</a>. You can also use query hints to improve query execution plans.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows one
        /// of the following IAM actions in that cluster, depending on the query:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#writedataviaquery">neptune-db:WriteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletedataviaquery">neptune-db:DeleteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinExplainQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteGremlinExplainQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinExplainQuery">REST API Reference for ExecuteGremlinExplainQuery Operation</seealso>
        public virtual ExecuteGremlinExplainQueryResponse ExecuteGremlinExplainQuery(ExecuteGremlinExplainQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteGremlinExplainQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteGremlinExplainQueryResponseUnmarshaller.Instance;

            return Invoke<ExecuteGremlinExplainQueryResponse>(request, options);
        }


        /// <summary>
        /// Executes a Gremlin Explain query.
        /// 
        ///  
        /// <para>
        /// Amazon Neptune has added a Gremlin feature named <c>explain</c> that provides is a
        /// self-service tool for understanding the execution approach being taken by the Neptune
        /// engine for the query. You invoke it by adding an <c>explain</c> parameter to an HTTP
        /// call that submits a Gremlin query.
        /// </para>
        ///  
        /// <para>
        /// The explain feature provides information about the logical structure of query execution
        /// plans. You can use this information to identify potential evaluation and execution
        /// bottlenecks and to tune your query, as explained in <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-traversal-tuning.html">Tuning
        /// Gremlin queries</a>. You can also use query hints to improve query execution plans.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows one
        /// of the following IAM actions in that cluster, depending on the query:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#writedataviaquery">neptune-db:WriteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletedataviaquery">neptune-db:DeleteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinExplainQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteGremlinExplainQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinExplainQuery">REST API Reference for ExecuteGremlinExplainQuery Operation</seealso>
        public virtual Task<ExecuteGremlinExplainQueryResponse> ExecuteGremlinExplainQueryAsync(ExecuteGremlinExplainQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteGremlinExplainQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteGremlinExplainQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteGremlinExplainQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteGremlinProfileQuery


        /// <summary>
        /// Executes a Gremlin Profile query, which runs a specified traversal, collects various
        /// metrics about the run, and produces a profile report as output. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-profile-api.html">Gremlin
        /// profile API in Neptune</a> for details.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinProfileQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteGremlinProfileQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinProfileQuery">REST API Reference for ExecuteGremlinProfileQuery Operation</seealso>
        public virtual ExecuteGremlinProfileQueryResponse ExecuteGremlinProfileQuery(ExecuteGremlinProfileQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteGremlinProfileQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteGremlinProfileQueryResponseUnmarshaller.Instance;

            return Invoke<ExecuteGremlinProfileQueryResponse>(request, options);
        }


        /// <summary>
        /// Executes a Gremlin Profile query, which runs a specified traversal, collects various
        /// metrics about the run, and produces a profile report as output. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-profile-api.html">Gremlin
        /// profile API in Neptune</a> for details.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinProfileQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteGremlinProfileQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinProfileQuery">REST API Reference for ExecuteGremlinProfileQuery Operation</seealso>
        public virtual Task<ExecuteGremlinProfileQueryResponse> ExecuteGremlinProfileQueryAsync(ExecuteGremlinProfileQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteGremlinProfileQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteGremlinProfileQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteGremlinProfileQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteGremlinQuery


        /// <summary>
        /// This commands executes a Gremlin query. Amazon Neptune is compatible with Apache TinkerPop3
        /// and Gremlin, so you can use the Gremlin traversal language to query the graph, as
        /// described under <a href="https://tinkerpop.apache.org/docs/current/reference/#graph">The
        /// Graph</a> in the Apache TinkerPop3 documentation. More details can also be found in
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-gremlin.html">Accessing
        /// a Neptune graph with Gremlin</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that enables one
        /// of the following IAM actions in that cluster, depending on the query:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#writedataviaquery">neptune-db:WriteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletedataviaquery">neptune-db:DeleteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteGremlinQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinQuery">REST API Reference for ExecuteGremlinQuery Operation</seealso>
        public virtual ExecuteGremlinQueryResponse ExecuteGremlinQuery(ExecuteGremlinQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteGremlinQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteGremlinQueryResponseUnmarshaller.Instance;

            return Invoke<ExecuteGremlinQueryResponse>(request, options);
        }


        /// <summary>
        /// This commands executes a Gremlin query. Amazon Neptune is compatible with Apache TinkerPop3
        /// and Gremlin, so you can use the Gremlin traversal language to query the graph, as
        /// described under <a href="https://tinkerpop.apache.org/docs/current/reference/#graph">The
        /// Graph</a> in the Apache TinkerPop3 documentation. More details can also be found in
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-gremlin.html">Accessing
        /// a Neptune graph with Gremlin</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that enables one
        /// of the following IAM actions in that cluster, depending on the query:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#writedataviaquery">neptune-db:WriteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletedataviaquery">neptune-db:DeleteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteGremlinQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinQuery">REST API Reference for ExecuteGremlinQuery Operation</seealso>
        public virtual Task<ExecuteGremlinQueryResponse> ExecuteGremlinQueryAsync(ExecuteGremlinQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteGremlinQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteGremlinQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteGremlinQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteOpenCypherExplainQuery


        /// <summary>
        /// Executes an openCypher <c>explain</c> request. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-explain.html">The
        /// openCypher explain feature</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteOpenCypherExplainQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteOpenCypherExplainQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteOpenCypherExplainQuery">REST API Reference for ExecuteOpenCypherExplainQuery Operation</seealso>
        public virtual ExecuteOpenCypherExplainQueryResponse ExecuteOpenCypherExplainQuery(ExecuteOpenCypherExplainQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteOpenCypherExplainQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteOpenCypherExplainQueryResponseUnmarshaller.Instance;

            return Invoke<ExecuteOpenCypherExplainQueryResponse>(request, options);
        }


        /// <summary>
        /// Executes an openCypher <c>explain</c> request. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-explain.html">The
        /// openCypher explain feature</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteOpenCypherExplainQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteOpenCypherExplainQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteOpenCypherExplainQuery">REST API Reference for ExecuteOpenCypherExplainQuery Operation</seealso>
        public virtual Task<ExecuteOpenCypherExplainQueryResponse> ExecuteOpenCypherExplainQueryAsync(ExecuteOpenCypherExplainQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteOpenCypherExplainQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteOpenCypherExplainQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteOpenCypherExplainQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteOpenCypherQuery


        /// <summary>
        /// Executes an openCypher query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher.html">Accessing
        /// the Neptune Graph with openCypher</a> for more information.
        /// 
        ///  
        /// <para>
        /// Neptune supports building graph applications using openCypher, which is currently
        /// one of the most popular query languages among developers working with graph databases.
        /// Developers, business analysts, and data scientists like openCypher's declarative,
        /// SQL-inspired syntax because it provides a familiar structure in which to querying
        /// property graphs.
        /// </para>
        ///  
        /// <para>
        /// The openCypher language was originally developed by Neo4j, then open-sourced in 2015
        /// and contributed to the <a href="https://opencypher.org/">openCypher project</a> under
        /// an Apache 2 open-source license.
        /// </para>
        ///  
        /// <para>
        /// Note that when invoking this operation in a Neptune cluster that has IAM authentication
        /// enabled, the IAM user or role making the request must have a policy attached that
        /// allows one of the following IAM actions in that cluster, depending on the query:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#writedataviaquery">neptune-db:WriteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletedataviaquery">neptune-db:DeleteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note also that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteOpenCypherQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteOpenCypherQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteOpenCypherQuery">REST API Reference for ExecuteOpenCypherQuery Operation</seealso>
        public virtual ExecuteOpenCypherQueryResponse ExecuteOpenCypherQuery(ExecuteOpenCypherQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteOpenCypherQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteOpenCypherQueryResponseUnmarshaller.Instance;

            return Invoke<ExecuteOpenCypherQueryResponse>(request, options);
        }


        /// <summary>
        /// Executes an openCypher query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher.html">Accessing
        /// the Neptune Graph with openCypher</a> for more information.
        /// 
        ///  
        /// <para>
        /// Neptune supports building graph applications using openCypher, which is currently
        /// one of the most popular query languages among developers working with graph databases.
        /// Developers, business analysts, and data scientists like openCypher's declarative,
        /// SQL-inspired syntax because it provides a familiar structure in which to querying
        /// property graphs.
        /// </para>
        ///  
        /// <para>
        /// The openCypher language was originally developed by Neo4j, then open-sourced in 2015
        /// and contributed to the <a href="https://opencypher.org/">openCypher project</a> under
        /// an Apache 2 open-source license.
        /// </para>
        ///  
        /// <para>
        /// Note that when invoking this operation in a Neptune cluster that has IAM authentication
        /// enabled, the IAM user or role making the request must have a policy attached that
        /// allows one of the following IAM actions in that cluster, depending on the query:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#writedataviaquery">neptune-db:WriteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletedataviaquery">neptune-db:DeleteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note also that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteOpenCypherQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteOpenCypherQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteOpenCypherQuery">REST API Reference for ExecuteOpenCypherQuery Operation</seealso>
        public virtual Task<ExecuteOpenCypherQueryResponse> ExecuteOpenCypherQueryAsync(ExecuteOpenCypherQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteOpenCypherQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteOpenCypherQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteOpenCypherQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEngineStatus


        /// <summary>
        /// Retrieves the status of the graph database on the host.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getenginestatus">neptune-db:GetEngineStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEngineStatus service method.</param>
        /// 
        /// <returns>The response from the GetEngineStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetEngineStatus">REST API Reference for GetEngineStatus Operation</seealso>
        public virtual GetEngineStatusResponse GetEngineStatus(GetEngineStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEngineStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEngineStatusResponseUnmarshaller.Instance;

            return Invoke<GetEngineStatusResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the status of the graph database on the host.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getenginestatus">neptune-db:GetEngineStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEngineStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEngineStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetEngineStatus">REST API Reference for GetEngineStatus Operation</seealso>
        public virtual Task<GetEngineStatusResponse> GetEngineStatusAsync(GetEngineStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEngineStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEngineStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEngineStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGremlinQueryStatus


        /// <summary>
        /// Gets the status of a specified Gremlin query.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGremlinQueryStatus service method.</param>
        /// 
        /// <returns>The response from the GetGremlinQueryStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetGremlinQueryStatus">REST API Reference for GetGremlinQueryStatus Operation</seealso>
        public virtual GetGremlinQueryStatusResponse GetGremlinQueryStatus(GetGremlinQueryStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGremlinQueryStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGremlinQueryStatusResponseUnmarshaller.Instance;

            return Invoke<GetGremlinQueryStatusResponse>(request, options);
        }


        /// <summary>
        /// Gets the status of a specified Gremlin query.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGremlinQueryStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGremlinQueryStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetGremlinQueryStatus">REST API Reference for GetGremlinQueryStatus Operation</seealso>
        public virtual Task<GetGremlinQueryStatusResponse> GetGremlinQueryStatusAsync(GetGremlinQueryStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGremlinQueryStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGremlinQueryStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetGremlinQueryStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLoaderJobStatus


        /// <summary>
        /// Gets status information about a specified load job. Neptune keeps track of the most
        /// recent 1,024 bulk load jobs, and stores the last 10,000 error details per job.
        /// 
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/load-api-reference-status.htm">Neptune
        /// Loader Get-Status API</a> for more information.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getloaderjobstatus">neptune-db:GetLoaderJobStatus</a>
        /// IAM action in that cluster..
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoaderJobStatus service method.</param>
        /// 
        /// <returns>The response from the GetLoaderJobStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetLoaderJobStatus">REST API Reference for GetLoaderJobStatus Operation</seealso>
        public virtual GetLoaderJobStatusResponse GetLoaderJobStatus(GetLoaderJobStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLoaderJobStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoaderJobStatusResponseUnmarshaller.Instance;

            return Invoke<GetLoaderJobStatusResponse>(request, options);
        }


        /// <summary>
        /// Gets status information about a specified load job. Neptune keeps track of the most
        /// recent 1,024 bulk load jobs, and stores the last 10,000 error details per job.
        /// 
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/load-api-reference-status.htm">Neptune
        /// Loader Get-Status API</a> for more information.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getloaderjobstatus">neptune-db:GetLoaderJobStatus</a>
        /// IAM action in that cluster..
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoaderJobStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLoaderJobStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetLoaderJobStatus">REST API Reference for GetLoaderJobStatus Operation</seealso>
        public virtual Task<GetLoaderJobStatusResponse> GetLoaderJobStatusAsync(GetLoaderJobStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLoaderJobStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLoaderJobStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLoaderJobStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMLDataProcessingJob


        /// <summary>
        /// Retrieves information about a specified data processing job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <c>dataprocessing</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmldataprocessingjobstatus">neptune-db:neptune-db:GetMLDataProcessingJobStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLDataProcessingJob service method.</param>
        /// 
        /// <returns>The response from the GetMLDataProcessingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLDataProcessingJob">REST API Reference for GetMLDataProcessingJob Operation</seealso>
        public virtual GetMLDataProcessingJobResponse GetMLDataProcessingJob(GetMLDataProcessingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMLDataProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLDataProcessingJobResponseUnmarshaller.Instance;

            return Invoke<GetMLDataProcessingJobResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a specified data processing job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <c>dataprocessing</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmldataprocessingjobstatus">neptune-db:neptune-db:GetMLDataProcessingJobStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLDataProcessingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLDataProcessingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLDataProcessingJob">REST API Reference for GetMLDataProcessingJob Operation</seealso>
        public virtual Task<GetMLDataProcessingJobResponse> GetMLDataProcessingJobAsync(GetMLDataProcessingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMLDataProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLDataProcessingJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMLDataProcessingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMLEndpoint


        /// <summary>
        /// Retrieves details about an inference endpoint. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmlendpointstatus">neptune-db:GetMLEndpointStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetMLEndpoint service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLEndpoint">REST API Reference for GetMLEndpoint Operation</seealso>
        public virtual GetMLEndpointResponse GetMLEndpoint(GetMLEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMLEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLEndpointResponseUnmarshaller.Instance;

            return Invoke<GetMLEndpointResponse>(request, options);
        }


        /// <summary>
        /// Retrieves details about an inference endpoint. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmlendpointstatus">neptune-db:GetMLEndpointStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLEndpoint service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLEndpoint">REST API Reference for GetMLEndpoint Operation</seealso>
        public virtual Task<GetMLEndpointResponse> GetMLEndpointAsync(GetMLEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMLEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMLEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMLModelTrainingJob


        /// <summary>
        /// Retrieves information about a Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmlmodeltrainingjobstatus">neptune-db:GetMLModelTrainingJobStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLModelTrainingJob service method.</param>
        /// 
        /// <returns>The response from the GetMLModelTrainingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLModelTrainingJob">REST API Reference for GetMLModelTrainingJob Operation</seealso>
        public virtual GetMLModelTrainingJobResponse GetMLModelTrainingJob(GetMLModelTrainingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMLModelTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLModelTrainingJobResponseUnmarshaller.Instance;

            return Invoke<GetMLModelTrainingJobResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmlmodeltrainingjobstatus">neptune-db:GetMLModelTrainingJobStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLModelTrainingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLModelTrainingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLModelTrainingJob">REST API Reference for GetMLModelTrainingJob Operation</seealso>
        public virtual Task<GetMLModelTrainingJobResponse> GetMLModelTrainingJobAsync(GetMLModelTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMLModelTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLModelTrainingJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMLModelTrainingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMLModelTransformJob


        /// <summary>
        /// Gets information about a specified model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmlmodeltransformjobstatus">neptune-db:GetMLModelTransformJobStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLModelTransformJob service method.</param>
        /// 
        /// <returns>The response from the GetMLModelTransformJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLModelTransformJob">REST API Reference for GetMLModelTransformJob Operation</seealso>
        public virtual GetMLModelTransformJobResponse GetMLModelTransformJob(GetMLModelTransformJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMLModelTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLModelTransformJobResponseUnmarshaller.Instance;

            return Invoke<GetMLModelTransformJobResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a specified model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmlmodeltransformjobstatus">neptune-db:GetMLModelTransformJobStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLModelTransformJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLModelTransformJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLModelTransformJob">REST API Reference for GetMLModelTransformJob Operation</seealso>
        public virtual Task<GetMLModelTransformJobResponse> GetMLModelTransformJobAsync(GetMLModelTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMLModelTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMLModelTransformJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMLModelTransformJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOpenCypherQueryStatus


        /// <summary>
        /// Retrieves the status of a specified openCypher query.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpenCypherQueryStatus service method.</param>
        /// 
        /// <returns>The response from the GetOpenCypherQueryStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetOpenCypherQueryStatus">REST API Reference for GetOpenCypherQueryStatus Operation</seealso>
        public virtual GetOpenCypherQueryStatusResponse GetOpenCypherQueryStatus(GetOpenCypherQueryStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOpenCypherQueryStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpenCypherQueryStatusResponseUnmarshaller.Instance;

            return Invoke<GetOpenCypherQueryStatusResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the status of a specified openCypher query.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpenCypherQueryStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOpenCypherQueryStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetOpenCypherQueryStatus">REST API Reference for GetOpenCypherQueryStatus Operation</seealso>
        public virtual Task<GetOpenCypherQueryStatusResponse> GetOpenCypherQueryStatusAsync(GetOpenCypherQueryStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOpenCypherQueryStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpenCypherQueryStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetOpenCypherQueryStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPropertygraphStatistics


        /// <summary>
        /// Gets property graph statistics (Gremlin and openCypher).
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstatisticsstatus">neptune-db:GetStatisticsStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphStatistics service method.</param>
        /// 
        /// <returns>The response from the GetPropertygraphStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphStatistics">REST API Reference for GetPropertygraphStatistics Operation</seealso>
        public virtual GetPropertygraphStatisticsResponse GetPropertygraphStatistics(GetPropertygraphStatisticsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPropertygraphStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPropertygraphStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetPropertygraphStatisticsResponse>(request, options);
        }


        /// <summary>
        /// Gets property graph statistics (Gremlin and openCypher).
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstatisticsstatus">neptune-db:GetStatisticsStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPropertygraphStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphStatistics">REST API Reference for GetPropertygraphStatistics Operation</seealso>
        public virtual Task<GetPropertygraphStatisticsResponse> GetPropertygraphStatisticsAsync(GetPropertygraphStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPropertygraphStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPropertygraphStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPropertygraphStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPropertygraphStream


        /// <summary>
        /// Gets a stream for a property graph.
        /// 
        ///  
        /// <para>
        /// With the Neptune Streams feature, you can generate a complete sequence of change-log
        /// entries that record every change made to your graph data as it happens. <c>GetPropertygraphStream</c>
        /// lets you collect these change-log entries for a property graph.
        /// </para>
        ///  
        /// <para>
        /// The Neptune streams feature needs to be enabled on your Neptune DBcluster. To enable
        /// streams, set the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/parameters.html#parameters-db-cluster-parameters-neptune_streams">neptune_streams</a>
        /// DB cluster parameter to <c>1</c>.
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/streams.html">Capturing
        /// graph changes in real time using Neptune streams</a>.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstreamrecords">neptune-db:GetStreamRecords</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that enables one
        /// of the following IAM actions, depending on the query:
        /// </para>
        ///  
        /// <para>
        /// Note that you can restrict property-graph queries using the following IAM context
        /// keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphStream service method.</param>
        /// 
        /// <returns>The response from the GetPropertygraphStream service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ExpiredStreamException">
        /// Raised when a request attempts to access an stream that has expired.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StreamRecordsNotFoundException">
        /// Raised when stream records requested by a query cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ThrottlingException">
        /// Raised when the rate of requests exceeds the maximum throughput. Requests can be retried
        /// after encountering this exception.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphStream">REST API Reference for GetPropertygraphStream Operation</seealso>
        public virtual GetPropertygraphStreamResponse GetPropertygraphStream(GetPropertygraphStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPropertygraphStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPropertygraphStreamResponseUnmarshaller.Instance;

            return Invoke<GetPropertygraphStreamResponse>(request, options);
        }


        /// <summary>
        /// Gets a stream for a property graph.
        /// 
        ///  
        /// <para>
        /// With the Neptune Streams feature, you can generate a complete sequence of change-log
        /// entries that record every change made to your graph data as it happens. <c>GetPropertygraphStream</c>
        /// lets you collect these change-log entries for a property graph.
        /// </para>
        ///  
        /// <para>
        /// The Neptune streams feature needs to be enabled on your Neptune DBcluster. To enable
        /// streams, set the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/parameters.html#parameters-db-cluster-parameters-neptune_streams">neptune_streams</a>
        /// DB cluster parameter to <c>1</c>.
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/streams.html">Capturing
        /// graph changes in real time using Neptune streams</a>.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstreamrecords">neptune-db:GetStreamRecords</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that enables one
        /// of the following IAM actions, depending on the query:
        /// </para>
        ///  
        /// <para>
        /// Note that you can restrict property-graph queries using the following IAM context
        /// keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPropertygraphStream service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ExpiredStreamException">
        /// Raised when a request attempts to access an stream that has expired.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StreamRecordsNotFoundException">
        /// Raised when stream records requested by a query cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ThrottlingException">
        /// Raised when the rate of requests exceeds the maximum throughput. Requests can be retried
        /// after encountering this exception.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphStream">REST API Reference for GetPropertygraphStream Operation</seealso>
        public virtual Task<GetPropertygraphStreamResponse> GetPropertygraphStreamAsync(GetPropertygraphStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPropertygraphStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPropertygraphStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPropertygraphStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPropertygraphSummary


        /// <summary>
        /// Gets a graph summary for a property graph.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getgraphsummary">neptune-db:GetGraphSummary</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphSummary service method.</param>
        /// 
        /// <returns>The response from the GetPropertygraphSummary service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphSummary">REST API Reference for GetPropertygraphSummary Operation</seealso>
        public virtual GetPropertygraphSummaryResponse GetPropertygraphSummary(GetPropertygraphSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPropertygraphSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPropertygraphSummaryResponseUnmarshaller.Instance;

            return Invoke<GetPropertygraphSummaryResponse>(request, options);
        }


        /// <summary>
        /// Gets a graph summary for a property graph.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getgraphsummary">neptune-db:GetGraphSummary</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPropertygraphSummary service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphSummary">REST API Reference for GetPropertygraphSummary Operation</seealso>
        public virtual Task<GetPropertygraphSummaryResponse> GetPropertygraphSummaryAsync(GetPropertygraphSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPropertygraphSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPropertygraphSummaryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPropertygraphSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRDFGraphSummary


        /// <summary>
        /// Gets a graph summary for an RDF graph.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getgraphsummary">neptune-db:GetGraphSummary</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRDFGraphSummary service method.</param>
        /// 
        /// <returns>The response from the GetRDFGraphSummary service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetRDFGraphSummary">REST API Reference for GetRDFGraphSummary Operation</seealso>
        public virtual GetRDFGraphSummaryResponse GetRDFGraphSummary(GetRDFGraphSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRDFGraphSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRDFGraphSummaryResponseUnmarshaller.Instance;

            return Invoke<GetRDFGraphSummaryResponse>(request, options);
        }


        /// <summary>
        /// Gets a graph summary for an RDF graph.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getgraphsummary">neptune-db:GetGraphSummary</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRDFGraphSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRDFGraphSummary service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetRDFGraphSummary">REST API Reference for GetRDFGraphSummary Operation</seealso>
        public virtual Task<GetRDFGraphSummaryResponse> GetRDFGraphSummaryAsync(GetRDFGraphSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRDFGraphSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRDFGraphSummaryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRDFGraphSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSparqlStatistics


        /// <summary>
        /// Gets RDF statistics (SPARQL).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSparqlStatistics service method.</param>
        /// 
        /// <returns>The response from the GetSparqlStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetSparqlStatistics">REST API Reference for GetSparqlStatistics Operation</seealso>
        public virtual GetSparqlStatisticsResponse GetSparqlStatistics(GetSparqlStatisticsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSparqlStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSparqlStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetSparqlStatisticsResponse>(request, options);
        }


        /// <summary>
        /// Gets RDF statistics (SPARQL).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSparqlStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSparqlStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetSparqlStatistics">REST API Reference for GetSparqlStatistics Operation</seealso>
        public virtual Task<GetSparqlStatisticsResponse> GetSparqlStatisticsAsync(GetSparqlStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSparqlStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSparqlStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSparqlStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSparqlStream


        /// <summary>
        /// Gets a stream for an RDF graph.
        /// 
        ///  
        /// <para>
        /// With the Neptune Streams feature, you can generate a complete sequence of change-log
        /// entries that record every change made to your graph data as it happens. <c>GetSparqlStream</c>
        /// lets you collect these change-log entries for an RDF graph.
        /// </para>
        ///  
        /// <para>
        /// The Neptune streams feature needs to be enabled on your Neptune DBcluster. To enable
        /// streams, set the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/parameters.html#parameters-db-cluster-parameters-neptune_streams">neptune_streams</a>
        /// DB cluster parameter to <c>1</c>.
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/streams.html">Capturing
        /// graph changes in real time using Neptune streams</a>.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstreamrecords">neptune-db:GetStreamRecords</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Sparql</a>
        /// IAM condition key can be used in the policy document to restrict the use of SPARQL
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSparqlStream service method.</param>
        /// 
        /// <returns>The response from the GetSparqlStream service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ExpiredStreamException">
        /// Raised when a request attempts to access an stream that has expired.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StreamRecordsNotFoundException">
        /// Raised when stream records requested by a query cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ThrottlingException">
        /// Raised when the rate of requests exceeds the maximum throughput. Requests can be retried
        /// after encountering this exception.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetSparqlStream">REST API Reference for GetSparqlStream Operation</seealso>
        public virtual GetSparqlStreamResponse GetSparqlStream(GetSparqlStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSparqlStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSparqlStreamResponseUnmarshaller.Instance;

            return Invoke<GetSparqlStreamResponse>(request, options);
        }


        /// <summary>
        /// Gets a stream for an RDF graph.
        /// 
        ///  
        /// <para>
        /// With the Neptune Streams feature, you can generate a complete sequence of change-log
        /// entries that record every change made to your graph data as it happens. <c>GetSparqlStream</c>
        /// lets you collect these change-log entries for an RDF graph.
        /// </para>
        ///  
        /// <para>
        /// The Neptune streams feature needs to be enabled on your Neptune DBcluster. To enable
        /// streams, set the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/parameters.html#parameters-db-cluster-parameters-neptune_streams">neptune_streams</a>
        /// DB cluster parameter to <c>1</c>.
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/streams.html">Capturing
        /// graph changes in real time using Neptune streams</a>.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstreamrecords">neptune-db:GetStreamRecords</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Sparql</a>
        /// IAM condition key can be used in the policy document to restrict the use of SPARQL
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSparqlStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSparqlStream service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ExpiredStreamException">
        /// Raised when a request attempts to access an stream that has expired.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StreamRecordsNotFoundException">
        /// Raised when stream records requested by a query cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ThrottlingException">
        /// Raised when the rate of requests exceeds the maximum throughput. Requests can be retried
        /// after encountering this exception.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetSparqlStream">REST API Reference for GetSparqlStream Operation</seealso>
        public virtual Task<GetSparqlStreamResponse> GetSparqlStreamAsync(GetSparqlStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSparqlStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSparqlStreamResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSparqlStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGremlinQueries


        /// <summary>
        /// Lists active Gremlin queries. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-api-status.html">Gremlin
        /// query status API</a> for details about the output.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGremlinQueries service method.</param>
        /// 
        /// <returns>The response from the ListGremlinQueries service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListGremlinQueries">REST API Reference for ListGremlinQueries Operation</seealso>
        public virtual ListGremlinQueriesResponse ListGremlinQueries(ListGremlinQueriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGremlinQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGremlinQueriesResponseUnmarshaller.Instance;

            return Invoke<ListGremlinQueriesResponse>(request, options);
        }


        /// <summary>
        /// Lists active Gremlin queries. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-api-status.html">Gremlin
        /// query status API</a> for details about the output.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGremlinQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGremlinQueries service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListGremlinQueries">REST API Reference for ListGremlinQueries Operation</seealso>
        public virtual Task<ListGremlinQueriesResponse> ListGremlinQueriesAsync(ListGremlinQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGremlinQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGremlinQueriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListGremlinQueriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLoaderJobs


        /// <summary>
        /// Retrieves a list of the <c>loadIds</c> for all active loader jobs.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listloaderjobs">neptune-db:ListLoaderJobs</a>
        /// IAM action in that cluster..
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoaderJobs service method.</param>
        /// 
        /// <returns>The response from the ListLoaderJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListLoaderJobs">REST API Reference for ListLoaderJobs Operation</seealso>
        public virtual ListLoaderJobsResponse ListLoaderJobs(ListLoaderJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLoaderJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLoaderJobsResponseUnmarshaller.Instance;

            return Invoke<ListLoaderJobsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of the <c>loadIds</c> for all active loader jobs.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listloaderjobs">neptune-db:ListLoaderJobs</a>
        /// IAM action in that cluster..
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoaderJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLoaderJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListLoaderJobs">REST API Reference for ListLoaderJobs Operation</seealso>
        public virtual Task<ListLoaderJobsResponse> ListLoaderJobsAsync(ListLoaderJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLoaderJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLoaderJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLoaderJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMLDataProcessingJobs


        /// <summary>
        /// Returns a list of Neptune ML data processing jobs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html#machine-learning-api-dataprocessing-list-jobs">Listing
        /// active data-processing jobs using the Neptune ML dataprocessing command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listmldataprocessingjobs">neptune-db:ListMLDataProcessingJobs</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLDataProcessingJobs service method.</param>
        /// 
        /// <returns>The response from the ListMLDataProcessingJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLDataProcessingJobs">REST API Reference for ListMLDataProcessingJobs Operation</seealso>
        public virtual ListMLDataProcessingJobsResponse ListMLDataProcessingJobs(ListMLDataProcessingJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMLDataProcessingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMLDataProcessingJobsResponseUnmarshaller.Instance;

            return Invoke<ListMLDataProcessingJobsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of Neptune ML data processing jobs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html#machine-learning-api-dataprocessing-list-jobs">Listing
        /// active data-processing jobs using the Neptune ML dataprocessing command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listmldataprocessingjobs">neptune-db:ListMLDataProcessingJobs</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLDataProcessingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMLDataProcessingJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLDataProcessingJobs">REST API Reference for ListMLDataProcessingJobs Operation</seealso>
        public virtual Task<ListMLDataProcessingJobsResponse> ListMLDataProcessingJobsAsync(ListMLDataProcessingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMLDataProcessingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMLDataProcessingJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMLDataProcessingJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMLEndpoints


        /// <summary>
        /// Lists existing inference endpoints. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listmlendpoints">neptune-db:ListMLEndpoints</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListMLEndpoints service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLEndpoints">REST API Reference for ListMLEndpoints Operation</seealso>
        public virtual ListMLEndpointsResponse ListMLEndpoints(ListMLEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMLEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMLEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListMLEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Lists existing inference endpoints. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listmlendpoints">neptune-db:ListMLEndpoints</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMLEndpoints service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLEndpoints">REST API Reference for ListMLEndpoints Operation</seealso>
        public virtual Task<ListMLEndpointsResponse> ListMLEndpointsAsync(ListMLEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMLEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMLEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMLEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMLModelTrainingJobs


        /// <summary>
        /// Lists Neptune ML model-training jobs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#neptune-db:listmlmodeltrainingjobs">neptune-db:neptune-db:ListMLModelTrainingJobs</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLModelTrainingJobs service method.</param>
        /// 
        /// <returns>The response from the ListMLModelTrainingJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLModelTrainingJobs">REST API Reference for ListMLModelTrainingJobs Operation</seealso>
        public virtual ListMLModelTrainingJobsResponse ListMLModelTrainingJobs(ListMLModelTrainingJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMLModelTrainingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMLModelTrainingJobsResponseUnmarshaller.Instance;

            return Invoke<ListMLModelTrainingJobsResponse>(request, options);
        }


        /// <summary>
        /// Lists Neptune ML model-training jobs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#neptune-db:listmlmodeltrainingjobs">neptune-db:neptune-db:ListMLModelTrainingJobs</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLModelTrainingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMLModelTrainingJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLModelTrainingJobs">REST API Reference for ListMLModelTrainingJobs Operation</seealso>
        public virtual Task<ListMLModelTrainingJobsResponse> ListMLModelTrainingJobsAsync(ListMLModelTrainingJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMLModelTrainingJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMLModelTrainingJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMLModelTrainingJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMLModelTransformJobs


        /// <summary>
        /// Returns a list of model transform job IDs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listmlmodeltransformjobs">neptune-db:ListMLModelTransformJobs</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLModelTransformJobs service method.</param>
        /// 
        /// <returns>The response from the ListMLModelTransformJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLModelTransformJobs">REST API Reference for ListMLModelTransformJobs Operation</seealso>
        public virtual ListMLModelTransformJobsResponse ListMLModelTransformJobs(ListMLModelTransformJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMLModelTransformJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMLModelTransformJobsResponseUnmarshaller.Instance;

            return Invoke<ListMLModelTransformJobsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of model transform job IDs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listmlmodeltransformjobs">neptune-db:ListMLModelTransformJobs</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLModelTransformJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMLModelTransformJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLModelTransformJobs">REST API Reference for ListMLModelTransformJobs Operation</seealso>
        public virtual Task<ListMLModelTransformJobsResponse> ListMLModelTransformJobsAsync(ListMLModelTransformJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMLModelTransformJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMLModelTransformJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMLModelTransformJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOpenCypherQueries


        /// <summary>
        /// Lists active openCypher queries. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-status.html">Neptune
        /// openCypher status endpoint</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpenCypherQueries service method.</param>
        /// 
        /// <returns>The response from the ListOpenCypherQueries service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListOpenCypherQueries">REST API Reference for ListOpenCypherQueries Operation</seealso>
        public virtual ListOpenCypherQueriesResponse ListOpenCypherQueries(ListOpenCypherQueriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOpenCypherQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpenCypherQueriesResponseUnmarshaller.Instance;

            return Invoke<ListOpenCypherQueriesResponse>(request, options);
        }


        /// <summary>
        /// Lists active openCypher queries. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-status.html">Neptune
        /// openCypher status endpoint</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpenCypherQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOpenCypherQueries service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListOpenCypherQueries">REST API Reference for ListOpenCypherQueries Operation</seealso>
        public virtual Task<ListOpenCypherQueriesResponse> ListOpenCypherQueriesAsync(ListOpenCypherQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOpenCypherQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpenCypherQueriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListOpenCypherQueriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ManagePropertygraphStatistics


        /// <summary>
        /// Manages the generation and use of property graph statistics.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#managestatistics">neptune-db:ManageStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ManagePropertygraphStatistics service method.</param>
        /// 
        /// <returns>The response from the ManagePropertygraphStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ManagePropertygraphStatistics">REST API Reference for ManagePropertygraphStatistics Operation</seealso>
        public virtual ManagePropertygraphStatisticsResponse ManagePropertygraphStatistics(ManagePropertygraphStatisticsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ManagePropertygraphStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ManagePropertygraphStatisticsResponseUnmarshaller.Instance;

            return Invoke<ManagePropertygraphStatisticsResponse>(request, options);
        }


        /// <summary>
        /// Manages the generation and use of property graph statistics.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#managestatistics">neptune-db:ManageStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ManagePropertygraphStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ManagePropertygraphStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ManagePropertygraphStatistics">REST API Reference for ManagePropertygraphStatistics Operation</seealso>
        public virtual Task<ManagePropertygraphStatisticsResponse> ManagePropertygraphStatisticsAsync(ManagePropertygraphStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ManagePropertygraphStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ManagePropertygraphStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ManagePropertygraphStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ManageSparqlStatistics


        /// <summary>
        /// Manages the generation and use of RDF graph statistics.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#managestatistics">neptune-db:ManageStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ManageSparqlStatistics service method.</param>
        /// 
        /// <returns>The response from the ManageSparqlStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ManageSparqlStatistics">REST API Reference for ManageSparqlStatistics Operation</seealso>
        public virtual ManageSparqlStatisticsResponse ManageSparqlStatistics(ManageSparqlStatisticsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ManageSparqlStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ManageSparqlStatisticsResponseUnmarshaller.Instance;

            return Invoke<ManageSparqlStatisticsResponse>(request, options);
        }


        /// <summary>
        /// Manages the generation and use of RDF graph statistics.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#managestatistics">neptune-db:ManageStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ManageSparqlStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ManageSparqlStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ManageSparqlStatistics">REST API Reference for ManageSparqlStatistics Operation</seealso>
        public virtual Task<ManageSparqlStatisticsResponse> ManageSparqlStatisticsAsync(ManageSparqlStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ManageSparqlStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ManageSparqlStatisticsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ManageSparqlStatisticsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartLoaderJob


        /// <summary>
        /// Starts a Neptune bulk loader job to load data from an Amazon S3 bucket into a Neptune
        /// DB instance. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load.html">Using
        /// the Amazon Neptune Bulk Loader to Ingest Data</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startloaderjob">neptune-db:StartLoaderJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLoaderJob service method.</param>
        /// 
        /// <returns>The response from the StartLoaderJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.S3Exception">
        /// Raised when there is a problem accessing Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartLoaderJob">REST API Reference for StartLoaderJob Operation</seealso>
        public virtual StartLoaderJobResponse StartLoaderJob(StartLoaderJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartLoaderJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLoaderJobResponseUnmarshaller.Instance;

            return Invoke<StartLoaderJobResponse>(request, options);
        }


        /// <summary>
        /// Starts a Neptune bulk loader job to load data from an Amazon S3 bucket into a Neptune
        /// DB instance. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load.html">Using
        /// the Amazon Neptune Bulk Loader to Ingest Data</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startloaderjob">neptune-db:StartLoaderJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLoaderJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartLoaderJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.S3Exception">
        /// Raised when there is a problem accessing Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartLoaderJob">REST API Reference for StartLoaderJob Operation</seealso>
        public virtual Task<StartLoaderJobResponse> StartLoaderJobAsync(StartLoaderJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartLoaderJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLoaderJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartLoaderJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMLDataProcessingJob


        /// <summary>
        /// Creates a new Neptune ML data processing job for processing the graph data exported
        /// from Neptune for training. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <c>dataprocessing</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startmlmodeldataprocessingjob">neptune-db:StartMLModelDataProcessingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLDataProcessingJob service method.</param>
        /// 
        /// <returns>The response from the StartMLDataProcessingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLDataProcessingJob">REST API Reference for StartMLDataProcessingJob Operation</seealso>
        public virtual StartMLDataProcessingJobResponse StartMLDataProcessingJob(StartMLDataProcessingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMLDataProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMLDataProcessingJobResponseUnmarshaller.Instance;

            return Invoke<StartMLDataProcessingJobResponse>(request, options);
        }


        /// <summary>
        /// Creates a new Neptune ML data processing job for processing the graph data exported
        /// from Neptune for training. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <c>dataprocessing</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startmlmodeldataprocessingjob">neptune-db:StartMLModelDataProcessingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLDataProcessingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMLDataProcessingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLDataProcessingJob">REST API Reference for StartMLDataProcessingJob Operation</seealso>
        public virtual Task<StartMLDataProcessingJobResponse> StartMLDataProcessingJobAsync(StartMLDataProcessingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMLDataProcessingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMLDataProcessingJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartMLDataProcessingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMLModelTrainingJob


        /// <summary>
        /// Creates a new Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startmlmodeltrainingjob">neptune-db:StartMLModelTrainingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLModelTrainingJob service method.</param>
        /// 
        /// <returns>The response from the StartMLModelTrainingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLModelTrainingJob">REST API Reference for StartMLModelTrainingJob Operation</seealso>
        public virtual StartMLModelTrainingJobResponse StartMLModelTrainingJob(StartMLModelTrainingJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMLModelTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMLModelTrainingJobResponseUnmarshaller.Instance;

            return Invoke<StartMLModelTrainingJobResponse>(request, options);
        }


        /// <summary>
        /// Creates a new Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startmlmodeltrainingjob">neptune-db:StartMLModelTrainingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLModelTrainingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMLModelTrainingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLModelTrainingJob">REST API Reference for StartMLModelTrainingJob Operation</seealso>
        public virtual Task<StartMLModelTrainingJobResponse> StartMLModelTrainingJobAsync(StartMLModelTrainingJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMLModelTrainingJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMLModelTrainingJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartMLModelTrainingJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMLModelTransformJob


        /// <summary>
        /// Creates a new model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startmlmodeltransformjob">neptune-db:StartMLModelTransformJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLModelTransformJob service method.</param>
        /// 
        /// <returns>The response from the StartMLModelTransformJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLModelTransformJob">REST API Reference for StartMLModelTransformJob Operation</seealso>
        public virtual StartMLModelTransformJobResponse StartMLModelTransformJob(StartMLModelTransformJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMLModelTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMLModelTransformJobResponseUnmarshaller.Instance;

            return Invoke<StartMLModelTransformJobResponse>(request, options);
        }


        /// <summary>
        /// Creates a new model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startmlmodeltransformjob">neptune-db:StartMLModelTransformJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLModelTransformJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMLModelTransformJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLModelTransformJob">REST API Reference for StartMLModelTransformJob Operation</seealso>
        public virtual Task<StartMLModelTransformJobResponse> StartMLModelTransformJobAsync(StartMLModelTransformJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMLModelTransformJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMLModelTransformJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartMLModelTransformJobResponse>(request, options, cancellationToken);
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