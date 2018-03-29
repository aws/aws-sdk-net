/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.MachineLearning.Model;
using Amazon.MachineLearning.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.MachineLearning
{
    /// <summary>
    /// Implementation for accessing MachineLearning
    ///
    /// Definition of the public APIs exposed by Amazon Machine Learning
    /// </summary>
    public partial class AmazonMachineLearningClient : AmazonServiceClient, IAmazonMachineLearning
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonMachineLearningClient with the credentials loaded from the application's
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
        public AmazonMachineLearningClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMachineLearningConfig()) { }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with the credentials loaded from the application's
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
        public AmazonMachineLearningClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMachineLearningConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMachineLearningClient Configuration Object</param>
        public AmazonMachineLearningClient(AmazonMachineLearningConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMachineLearningClient(AWSCredentials credentials)
            : this(credentials, new AmazonMachineLearningConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMachineLearningClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMachineLearningConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Credentials and an
        /// AmazonMachineLearningClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMachineLearningClient Configuration Object</param>
        public AmazonMachineLearningClient(AWSCredentials credentials, AmazonMachineLearningConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMachineLearningClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMachineLearningConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMachineLearningClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMachineLearningConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMachineLearningClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMachineLearningClient Configuration Object</param>
        public AmazonMachineLearningClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMachineLearningConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMachineLearningClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMachineLearningConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMachineLearningClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMachineLearningConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMachineLearningClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMachineLearningClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMachineLearningClient Configuration Object</param>
        public AmazonMachineLearningClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMachineLearningConfig clientConfig)
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.MachineLearning.Internal.ProcessRequestHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.MachineLearning.Internal.IdempotencyHandler());
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

        
        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var marshaller = AddTagsRequestMarshaller.Instance;
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsRequest,AddTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddTagsRequestMarshaller.Instance;
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsRequest,AddTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateBatchPrediction

        internal virtual CreateBatchPredictionResponse CreateBatchPrediction(CreateBatchPredictionRequest request)
        {
            var marshaller = CreateBatchPredictionRequestMarshaller.Instance;
            var unmarshaller = CreateBatchPredictionResponseUnmarshaller.Instance;

            return Invoke<CreateBatchPredictionRequest,CreateBatchPredictionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchPrediction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateBatchPrediction">REST API Reference for CreateBatchPrediction Operation</seealso>
        public virtual Task<CreateBatchPredictionResponse> CreateBatchPredictionAsync(CreateBatchPredictionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateBatchPredictionRequestMarshaller.Instance;
            var unmarshaller = CreateBatchPredictionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBatchPredictionRequest,CreateBatchPredictionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDataSourceFromRDS

        internal virtual CreateDataSourceFromRDSResponse CreateDataSourceFromRDS(CreateDataSourceFromRDSRequest request)
        {
            var marshaller = CreateDataSourceFromRDSRequestMarshaller.Instance;
            var unmarshaller = CreateDataSourceFromRDSResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceFromRDSRequest,CreateDataSourceFromRDSResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSourceFromRDS operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromRDS operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromRDS">REST API Reference for CreateDataSourceFromRDS Operation</seealso>
        public virtual Task<CreateDataSourceFromRDSResponse> CreateDataSourceFromRDSAsync(CreateDataSourceFromRDSRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDataSourceFromRDSRequestMarshaller.Instance;
            var unmarshaller = CreateDataSourceFromRDSResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataSourceFromRDSRequest,CreateDataSourceFromRDSResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDataSourceFromRedshift

        internal virtual CreateDataSourceFromRedshiftResponse CreateDataSourceFromRedshift(CreateDataSourceFromRedshiftRequest request)
        {
            var marshaller = CreateDataSourceFromRedshiftRequestMarshaller.Instance;
            var unmarshaller = CreateDataSourceFromRedshiftResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceFromRedshiftRequest,CreateDataSourceFromRedshiftResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSourceFromRedshift operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromRedshift operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromRedshift">REST API Reference for CreateDataSourceFromRedshift Operation</seealso>
        public virtual Task<CreateDataSourceFromRedshiftResponse> CreateDataSourceFromRedshiftAsync(CreateDataSourceFromRedshiftRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDataSourceFromRedshiftRequestMarshaller.Instance;
            var unmarshaller = CreateDataSourceFromRedshiftResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataSourceFromRedshiftRequest,CreateDataSourceFromRedshiftResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDataSourceFromS3

        internal virtual CreateDataSourceFromS3Response CreateDataSourceFromS3(CreateDataSourceFromS3Request request)
        {
            var marshaller = CreateDataSourceFromS3RequestMarshaller.Instance;
            var unmarshaller = CreateDataSourceFromS3ResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceFromS3Request,CreateDataSourceFromS3Response>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSourceFromS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromS3 operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromS3">REST API Reference for CreateDataSourceFromS3 Operation</seealso>
        public virtual Task<CreateDataSourceFromS3Response> CreateDataSourceFromS3Async(CreateDataSourceFromS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDataSourceFromS3RequestMarshaller.Instance;
            var unmarshaller = CreateDataSourceFromS3ResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDataSourceFromS3Request,CreateDataSourceFromS3Response>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateEvaluation

        internal virtual CreateEvaluationResponse CreateEvaluation(CreateEvaluationRequest request)
        {
            var marshaller = CreateEvaluationRequestMarshaller.Instance;
            var unmarshaller = CreateEvaluationResponseUnmarshaller.Instance;

            return Invoke<CreateEvaluationRequest,CreateEvaluationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEvaluation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateEvaluation">REST API Reference for CreateEvaluation Operation</seealso>
        public virtual Task<CreateEvaluationResponse> CreateEvaluationAsync(CreateEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateEvaluationRequestMarshaller.Instance;
            var unmarshaller = CreateEvaluationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEvaluationRequest,CreateEvaluationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateMLModel

        internal virtual CreateMLModelResponse CreateMLModel(CreateMLModelRequest request)
        {
            var marshaller = CreateMLModelRequestMarshaller.Instance;
            var unmarshaller = CreateMLModelResponseUnmarshaller.Instance;

            return Invoke<CreateMLModelRequest,CreateMLModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateMLModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMLModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateMLModel">REST API Reference for CreateMLModel Operation</seealso>
        public virtual Task<CreateMLModelResponse> CreateMLModelAsync(CreateMLModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateMLModelRequestMarshaller.Instance;
            var unmarshaller = CreateMLModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMLModelRequest,CreateMLModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRealtimeEndpoint

        internal virtual CreateRealtimeEndpointResponse CreateRealtimeEndpoint(CreateRealtimeEndpointRequest request)
        {
            var marshaller = CreateRealtimeEndpointRequestMarshaller.Instance;
            var unmarshaller = CreateRealtimeEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateRealtimeEndpointRequest,CreateRealtimeEndpointResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Creates a real-time endpoint for the <code>MLModel</code>. The endpoint contains the
        /// URI of the <code>MLModel</code>; that is, the location to send real-time prediction
        /// requests for the specified <code>MLModel</code>.
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> during creation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRealtimeEndpoint service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateRealtimeEndpoint">REST API Reference for CreateRealtimeEndpoint Operation</seealso>
        public virtual Task<CreateRealtimeEndpointResponse> CreateRealtimeEndpointAsync(string mlModelId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateRealtimeEndpointRequest();
            request.MLModelId = mlModelId;
            return CreateRealtimeEndpointAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRealtimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRealtimeEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateRealtimeEndpoint">REST API Reference for CreateRealtimeEndpoint Operation</seealso>
        public virtual Task<CreateRealtimeEndpointResponse> CreateRealtimeEndpointAsync(CreateRealtimeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRealtimeEndpointRequestMarshaller.Instance;
            var unmarshaller = CreateRealtimeEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRealtimeEndpointRequest,CreateRealtimeEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBatchPrediction

        internal virtual DeleteBatchPredictionResponse DeleteBatchPrediction(DeleteBatchPredictionRequest request)
        {
            var marshaller = DeleteBatchPredictionRequestMarshaller.Instance;
            var unmarshaller = DeleteBatchPredictionResponseUnmarshaller.Instance;

            return Invoke<DeleteBatchPredictionRequest,DeleteBatchPredictionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Assigns the DELETED status to a <code>BatchPrediction</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteBatchPrediction</code> operation, you can use the <a>GetBatchPrediction</a>
        /// operation to verify that the status of the <code>BatchPrediction</code> changed to
        /// DELETED.
        /// </para>
        ///  
        /// <para>
        /// <b>Caution:</b> The result of the <code>DeleteBatchPrediction</code> operation is
        /// irreversible.
        /// </para>
        /// </summary>
        /// <param name="batchPredictionId">A user-supplied ID that uniquely identifies the <code>BatchPrediction</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteBatchPrediction">REST API Reference for DeleteBatchPrediction Operation</seealso>
        public virtual Task<DeleteBatchPredictionResponse> DeleteBatchPredictionAsync(string batchPredictionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBatchPredictionRequest();
            request.BatchPredictionId = batchPredictionId;
            return DeleteBatchPredictionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBatchPrediction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteBatchPrediction">REST API Reference for DeleteBatchPrediction Operation</seealso>
        public virtual Task<DeleteBatchPredictionResponse> DeleteBatchPredictionAsync(DeleteBatchPredictionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteBatchPredictionRequestMarshaller.Instance;
            var unmarshaller = DeleteBatchPredictionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBatchPredictionRequest,DeleteBatchPredictionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataSource

        internal virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var marshaller = DeleteDataSourceRequestMarshaller.Instance;
            var unmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceRequest,DeleteDataSourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Assigns the DELETED status to a <code>DataSource</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteDataSource</code> operation, you can use the <a>GetDataSource</a>
        /// operation to verify that the status of the <code>DataSource</code> changed to DELETED.
        /// </para>
        ///  
        /// <para>
        /// <b>Caution:</b> The results of the <code>DeleteDataSource</code> operation are irreversible.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">A user-supplied ID that uniquely identifies the <code>DataSource</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual Task<DeleteDataSourceResponse> DeleteDataSourceAsync(string dataSourceId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteDataSourceRequest();
            request.DataSourceId = dataSourceId;
            return DeleteDataSourceAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDataSourceRequestMarshaller.Instance;
            var unmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDataSourceRequest,DeleteDataSourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEvaluation

        internal virtual DeleteEvaluationResponse DeleteEvaluation(DeleteEvaluationRequest request)
        {
            var marshaller = DeleteEvaluationRequestMarshaller.Instance;
            var unmarshaller = DeleteEvaluationResponseUnmarshaller.Instance;

            return Invoke<DeleteEvaluationRequest,DeleteEvaluationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Assigns the <code>DELETED</code> status to an <code>Evaluation</code>, rendering it
        /// unusable.
        /// 
        ///  
        /// <para>
        /// After invoking the <code>DeleteEvaluation</code> operation, you can use the <code>GetEvaluation</code>
        /// operation to verify that the status of the <code>Evaluation</code> changed to <code>DELETED</code>.
        /// </para>
        ///  <caution><title>Caution</title> 
        /// <para>
        /// The results of the <code>DeleteEvaluation</code> operation are irreversible.
        /// </para>
        /// </caution>
        /// </summary>
        /// <param name="evaluationId">A user-supplied ID that uniquely identifies the <code>Evaluation</code> to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteEvaluation">REST API Reference for DeleteEvaluation Operation</seealso>
        public virtual Task<DeleteEvaluationResponse> DeleteEvaluationAsync(string evaluationId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteEvaluationRequest();
            request.EvaluationId = evaluationId;
            return DeleteEvaluationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvaluation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteEvaluation">REST API Reference for DeleteEvaluation Operation</seealso>
        public virtual Task<DeleteEvaluationResponse> DeleteEvaluationAsync(DeleteEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteEvaluationRequestMarshaller.Instance;
            var unmarshaller = DeleteEvaluationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEvaluationRequest,DeleteEvaluationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteMLModel

        internal virtual DeleteMLModelResponse DeleteMLModel(DeleteMLModelRequest request)
        {
            var marshaller = DeleteMLModelRequestMarshaller.Instance;
            var unmarshaller = DeleteMLModelResponseUnmarshaller.Instance;

            return Invoke<DeleteMLModelRequest,DeleteMLModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Assigns the <code>DELETED</code> status to an <code>MLModel</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteMLModel</code> operation, you can use the <code>GetMLModel</code>
        /// operation to verify that the status of the <code>MLModel</code> changed to DELETED.
        /// </para>
        ///  
        /// <para>
        /// <b>Caution:</b> The result of the <code>DeleteMLModel</code> operation is irreversible.
        /// </para>
        /// </summary>
        /// <param name="mlModelId">A user-supplied ID that uniquely identifies the <code>MLModel</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteMLModel">REST API Reference for DeleteMLModel Operation</seealso>
        public virtual Task<DeleteMLModelResponse> DeleteMLModelAsync(string mlModelId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteMLModelRequest();
            request.MLModelId = mlModelId;
            return DeleteMLModelAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMLModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteMLModel">REST API Reference for DeleteMLModel Operation</seealso>
        public virtual Task<DeleteMLModelResponse> DeleteMLModelAsync(DeleteMLModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteMLModelRequestMarshaller.Instance;
            var unmarshaller = DeleteMLModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMLModelRequest,DeleteMLModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRealtimeEndpoint

        internal virtual DeleteRealtimeEndpointResponse DeleteRealtimeEndpoint(DeleteRealtimeEndpointRequest request)
        {
            var marshaller = DeleteRealtimeEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteRealtimeEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteRealtimeEndpointRequest,DeleteRealtimeEndpointResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes a real time endpoint of an <code>MLModel</code>.
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> during creation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRealtimeEndpoint service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteRealtimeEndpoint">REST API Reference for DeleteRealtimeEndpoint Operation</seealso>
        public virtual Task<DeleteRealtimeEndpointResponse> DeleteRealtimeEndpointAsync(string mlModelId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteRealtimeEndpointRequest();
            request.MLModelId = mlModelId;
            return DeleteRealtimeEndpointAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRealtimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRealtimeEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteRealtimeEndpoint">REST API Reference for DeleteRealtimeEndpoint Operation</seealso>
        public virtual Task<DeleteRealtimeEndpointResponse> DeleteRealtimeEndpointAsync(DeleteRealtimeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRealtimeEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteRealtimeEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRealtimeEndpointRequest,DeleteRealtimeEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = DeleteTagsRequestMarshaller.Instance;
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteTagsRequestMarshaller.Instance;
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeBatchPredictions

        internal virtual DescribeBatchPredictionsResponse DescribeBatchPredictions(DescribeBatchPredictionsRequest request)
        {
            var marshaller = DescribeBatchPredictionsRequestMarshaller.Instance;
            var unmarshaller = DescribeBatchPredictionsResponseUnmarshaller.Instance;

            return Invoke<DescribeBatchPredictionsRequest,DescribeBatchPredictionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBatchPredictions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchPredictions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeBatchPredictions">REST API Reference for DescribeBatchPredictions Operation</seealso>
        public virtual Task<DescribeBatchPredictionsResponse> DescribeBatchPredictionsAsync(DescribeBatchPredictionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeBatchPredictionsRequestMarshaller.Instance;
            var unmarshaller = DescribeBatchPredictionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBatchPredictionsRequest,DescribeBatchPredictionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDataSources

        internal virtual DescribeDataSourcesResponse DescribeDataSources(DescribeDataSourcesRequest request)
        {
            var marshaller = DescribeDataSourcesRequestMarshaller.Instance;
            var unmarshaller = DescribeDataSourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeDataSourcesRequest,DescribeDataSourcesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeDataSources">REST API Reference for DescribeDataSources Operation</seealso>
        public virtual Task<DescribeDataSourcesResponse> DescribeDataSourcesAsync(DescribeDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDataSourcesRequestMarshaller.Instance;
            var unmarshaller = DescribeDataSourcesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDataSourcesRequest,DescribeDataSourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvaluations

        internal virtual DescribeEvaluationsResponse DescribeEvaluations(DescribeEvaluationsRequest request)
        {
            var marshaller = DescribeEvaluationsRequestMarshaller.Instance;
            var unmarshaller = DescribeEvaluationsResponseUnmarshaller.Instance;

            return Invoke<DescribeEvaluationsRequest,DescribeEvaluationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvaluations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvaluations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeEvaluations">REST API Reference for DescribeEvaluations Operation</seealso>
        public virtual Task<DescribeEvaluationsResponse> DescribeEvaluationsAsync(DescribeEvaluationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEvaluationsRequestMarshaller.Instance;
            var unmarshaller = DescribeEvaluationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEvaluationsRequest,DescribeEvaluationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMLModels

        internal virtual DescribeMLModelsResponse DescribeMLModels(DescribeMLModelsRequest request)
        {
            var marshaller = DescribeMLModelsRequestMarshaller.Instance;
            var unmarshaller = DescribeMLModelsResponseUnmarshaller.Instance;

            return Invoke<DescribeMLModelsRequest,DescribeMLModelsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMLModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMLModels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeMLModels">REST API Reference for DescribeMLModels Operation</seealso>
        public virtual Task<DescribeMLModelsResponse> DescribeMLModelsAsync(DescribeMLModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeMLModelsRequestMarshaller.Instance;
            var unmarshaller = DescribeMLModelsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMLModelsRequest,DescribeMLModelsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = DescribeTagsRequestMarshaller.Instance;
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeTagsRequestMarshaller.Instance;
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBatchPrediction

        internal virtual GetBatchPredictionResponse GetBatchPrediction(GetBatchPredictionRequest request)
        {
            var marshaller = GetBatchPredictionRequestMarshaller.Instance;
            var unmarshaller = GetBatchPredictionResponseUnmarshaller.Instance;

            return Invoke<GetBatchPredictionRequest,GetBatchPredictionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a <code>BatchPrediction</code> that includes detailed metadata, status, and
        /// data file information for a <code>Batch Prediction</code> request.
        /// </summary>
        /// <param name="batchPredictionId">An ID assigned to the <code>BatchPrediction</code> at creation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetBatchPrediction">REST API Reference for GetBatchPrediction Operation</seealso>
        public virtual Task<GetBatchPredictionResponse> GetBatchPredictionAsync(string batchPredictionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBatchPredictionRequest();
            request.BatchPredictionId = batchPredictionId;
            return GetBatchPredictionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBatchPrediction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetBatchPrediction">REST API Reference for GetBatchPrediction Operation</seealso>
        public virtual Task<GetBatchPredictionResponse> GetBatchPredictionAsync(GetBatchPredictionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetBatchPredictionRequestMarshaller.Instance;
            var unmarshaller = GetBatchPredictionResponseUnmarshaller.Instance;

            return InvokeAsync<GetBatchPredictionRequest,GetBatchPredictionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDataSource

        internal virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
        {
            var marshaller = GetDataSourceRequestMarshaller.Instance;
            var unmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceRequest,GetDataSourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns a <code>DataSource</code> that includes metadata and data file information,
        /// as well as the current status of the <code>DataSource</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetDataSource</code> provides results in normal or verbose format. The verbose
        /// format adds the schema description and the list of files pointed to by the DataSource
        /// to the normal format.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">The ID assigned to the <code>DataSource</code> at creation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual Task<GetDataSourceResponse> GetDataSourceAsync(string dataSourceId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetDataSourceRequest();
            request.DataSourceId = dataSourceId;
            return GetDataSourceAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns a <code>DataSource</code> that includes metadata and data file information,
        /// as well as the current status of the <code>DataSource</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetDataSource</code> provides results in normal or verbose format. The verbose
        /// format adds the schema description and the list of files pointed to by the DataSource
        /// to the normal format.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">The ID assigned to the <code>DataSource</code> at creation.</param>
        /// <param name="verbose">Specifies whether the <code>GetDataSource</code> operation should return <code>DataSourceSchema</code>. If true, <code>DataSourceSchema</code> is returned. If false, <code>DataSourceSchema</code> is not returned.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual Task<GetDataSourceResponse> GetDataSourceAsync(string dataSourceId, bool verbose, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetDataSourceRequest();
            request.DataSourceId = dataSourceId;
            request.Verbose = verbose;
            return GetDataSourceAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual Task<GetDataSourceResponse> GetDataSourceAsync(GetDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDataSourceRequestMarshaller.Instance;
            var unmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetDataSourceRequest,GetDataSourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetEvaluation

        internal virtual GetEvaluationResponse GetEvaluation(GetEvaluationRequest request)
        {
            var marshaller = GetEvaluationRequestMarshaller.Instance;
            var unmarshaller = GetEvaluationResponseUnmarshaller.Instance;

            return Invoke<GetEvaluationRequest,GetEvaluationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns an <code>Evaluation</code> that includes metadata as well as the current status
        /// of the <code>Evaluation</code>.
        /// </summary>
        /// <param name="evaluationId">The ID of the <code>Evaluation</code> to retrieve. The evaluation of each <code>MLModel</code> is recorded and cataloged. The ID provides the means to access the information. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetEvaluation">REST API Reference for GetEvaluation Operation</seealso>
        public virtual Task<GetEvaluationResponse> GetEvaluationAsync(string evaluationId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetEvaluationRequest();
            request.EvaluationId = evaluationId;
            return GetEvaluationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvaluation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetEvaluation">REST API Reference for GetEvaluation Operation</seealso>
        public virtual Task<GetEvaluationResponse> GetEvaluationAsync(GetEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetEvaluationRequestMarshaller.Instance;
            var unmarshaller = GetEvaluationResponseUnmarshaller.Instance;

            return InvokeAsync<GetEvaluationRequest,GetEvaluationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMLModel

        internal virtual GetMLModelResponse GetMLModel(GetMLModelRequest request)
        {
            var marshaller = GetMLModelRequestMarshaller.Instance;
            var unmarshaller = GetMLModelResponseUnmarshaller.Instance;

            return Invoke<GetMLModelRequest,GetMLModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns an <code>MLModel</code> that includes detailed metadata, data source information,
        /// and the current status of the <code>MLModel</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetMLModel</code> provides results in normal or verbose format. 
        /// </para>
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> at creation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetMLModel">REST API Reference for GetMLModel Operation</seealso>
        public virtual Task<GetMLModelResponse> GetMLModelAsync(string mlModelId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetMLModelRequest();
            request.MLModelId = mlModelId;
            return GetMLModelAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns an <code>MLModel</code> that includes detailed metadata, data source information,
        /// and the current status of the <code>MLModel</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetMLModel</code> provides results in normal or verbose format. 
        /// </para>
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> at creation.</param>
        /// <param name="verbose">Specifies whether the <code>GetMLModel</code> operation should return <code>Recipe</code>. If true, <code>Recipe</code> is returned. If false, <code>Recipe</code> is not returned.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetMLModel">REST API Reference for GetMLModel Operation</seealso>
        public virtual Task<GetMLModelResponse> GetMLModelAsync(string mlModelId, bool verbose, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetMLModelRequest();
            request.MLModelId = mlModelId;
            request.Verbose = verbose;
            return GetMLModelAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetMLModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMLModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetMLModel">REST API Reference for GetMLModel Operation</seealso>
        public virtual Task<GetMLModelResponse> GetMLModelAsync(GetMLModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetMLModelRequestMarshaller.Instance;
            var unmarshaller = GetMLModelResponseUnmarshaller.Instance;

            return InvokeAsync<GetMLModelRequest,GetMLModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  Predict

        internal virtual PredictResponse Predict(PredictRequest request)
        {
            var marshaller = PredictRequestMarshaller.Instance;
            var unmarshaller = PredictResponseUnmarshaller.Instance;

            return Invoke<PredictRequest,PredictResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Generates a prediction for the observation using the specified <code>ML Model</code>.
        /// 
        ///  <note><title>Note</title> 
        /// <para>
        /// Not all response parameters will be populated. Whether a response parameter is populated
        /// depends on the type of model requested.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="mlModelId">A unique identifier of the <code>MLModel</code>.</param>
        /// <param name="predictEndpoint">A property of PredictRequest used to execute the Predict service method.</param>
        /// <param name="record">A property of PredictRequest used to execute the Predict service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Predict service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.LimitExceededException">
        /// The subscriber exceeded the maximum number of operations. This exception can occur
        /// when listing objects such as <code>DataSource</code>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.PredictorNotMountedException">
        /// The exception is thrown when a predict request is made to an unmounted <code>MLModel</code>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/Predict">REST API Reference for Predict Operation</seealso>
        public virtual Task<PredictResponse> PredictAsync(string mlModelId, string predictEndpoint, Dictionary<string, string> record, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PredictRequest();
            request.MLModelId = mlModelId;
            request.PredictEndpoint = predictEndpoint;
            request.Record = record;
            return PredictAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the Predict operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Predict operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/Predict">REST API Reference for Predict Operation</seealso>
        public virtual Task<PredictResponse> PredictAsync(PredictRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PredictRequestMarshaller.Instance;
            var unmarshaller = PredictResponseUnmarshaller.Instance;

            return InvokeAsync<PredictRequest,PredictResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateBatchPrediction

        internal virtual UpdateBatchPredictionResponse UpdateBatchPrediction(UpdateBatchPredictionRequest request)
        {
            var marshaller = UpdateBatchPredictionRequestMarshaller.Instance;
            var unmarshaller = UpdateBatchPredictionResponseUnmarshaller.Instance;

            return Invoke<UpdateBatchPredictionRequest,UpdateBatchPredictionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Updates the <code>BatchPredictionName</code> of a <code>BatchPrediction</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetBatchPrediction</code> operation to view the contents of
        /// the updated data element.
        /// </para>
        /// </summary>
        /// <param name="batchPredictionId">The ID assigned to the <code>BatchPrediction</code> during creation.</param>
        /// <param name="batchPredictionName">A new user-supplied name or description of the <code>BatchPrediction</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateBatchPrediction">REST API Reference for UpdateBatchPrediction Operation</seealso>
        public virtual Task<UpdateBatchPredictionResponse> UpdateBatchPredictionAsync(string batchPredictionId, string batchPredictionName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateBatchPredictionRequest();
            request.BatchPredictionId = batchPredictionId;
            request.BatchPredictionName = batchPredictionName;
            return UpdateBatchPredictionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBatchPrediction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateBatchPrediction">REST API Reference for UpdateBatchPrediction Operation</seealso>
        public virtual Task<UpdateBatchPredictionResponse> UpdateBatchPredictionAsync(UpdateBatchPredictionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateBatchPredictionRequestMarshaller.Instance;
            var unmarshaller = UpdateBatchPredictionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBatchPredictionRequest,UpdateBatchPredictionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataSource

        internal virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var marshaller = UpdateDataSourceRequestMarshaller.Instance;
            var unmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceRequest,UpdateDataSourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Updates the <code>DataSourceName</code> of a <code>DataSource</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetDataSource</code> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">The ID assigned to the <code>DataSource</code> during creation.</param>
        /// <param name="dataSourceName">A new user-supplied name or description of the <code>DataSource</code> that will replace the current description. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual Task<UpdateDataSourceResponse> UpdateDataSourceAsync(string dataSourceId, string dataSourceName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateDataSourceRequest();
            request.DataSourceId = dataSourceId;
            request.DataSourceName = dataSourceName;
            return UpdateDataSourceAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDataSourceRequestMarshaller.Instance;
            var unmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDataSourceRequest,UpdateDataSourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateEvaluation

        internal virtual UpdateEvaluationResponse UpdateEvaluation(UpdateEvaluationRequest request)
        {
            var marshaller = UpdateEvaluationRequestMarshaller.Instance;
            var unmarshaller = UpdateEvaluationResponseUnmarshaller.Instance;

            return Invoke<UpdateEvaluationRequest,UpdateEvaluationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Updates the <code>EvaluationName</code> of an <code>Evaluation</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetEvaluation</code> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="evaluationId">The ID assigned to the <code>Evaluation</code> during creation.</param>
        /// <param name="evaluationName">A new user-supplied name or description of the <code>Evaluation</code> that will replace the current content. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateEvaluation">REST API Reference for UpdateEvaluation Operation</seealso>
        public virtual Task<UpdateEvaluationResponse> UpdateEvaluationAsync(string evaluationId, string evaluationName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateEvaluationRequest();
            request.EvaluationId = evaluationId;
            request.EvaluationName = evaluationName;
            return UpdateEvaluationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEvaluation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateEvaluation">REST API Reference for UpdateEvaluation Operation</seealso>
        public virtual Task<UpdateEvaluationResponse> UpdateEvaluationAsync(UpdateEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateEvaluationRequestMarshaller.Instance;
            var unmarshaller = UpdateEvaluationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEvaluationRequest,UpdateEvaluationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateMLModel

        internal virtual UpdateMLModelResponse UpdateMLModel(UpdateMLModelRequest request)
        {
            var marshaller = UpdateMLModelRequestMarshaller.Instance;
            var unmarshaller = UpdateMLModelResponseUnmarshaller.Instance;

            return Invoke<UpdateMLModelRequest,UpdateMLModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Updates the <code>MLModelName</code> and the <code>ScoreThreshold</code> of an <code>MLModel</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <code>GetMLModel</code> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> during creation.</param>
        /// <param name="mlModelName">A user-supplied name or description of the <code>MLModel</code>.</param>
        /// <param name="scoreThreshold">The <code>ScoreThreshold</code> used in binary classification <code>MLModel</code> that marks the boundary between a positive prediction and a negative prediction. Output values greater than or equal to the <code>ScoreThreshold</code> receive a positive result from the <code>MLModel</code>, such as <code>true</code>. Output values less than the <code>ScoreThreshold</code> receive a negative response from the <code>MLModel</code>, such as <code>false</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateMLModel">REST API Reference for UpdateMLModel Operation</seealso>
        public virtual Task<UpdateMLModelResponse> UpdateMLModelAsync(string mlModelId, string mlModelName, float scoreThreshold, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateMLModelRequest();
            request.MLModelId = mlModelId;
            request.MLModelName = mlModelName;
            request.ScoreThreshold = scoreThreshold;
            return UpdateMLModelAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMLModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMLModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateMLModel">REST API Reference for UpdateMLModel Operation</seealso>
        public virtual Task<UpdateMLModelResponse> UpdateMLModelAsync(UpdateMLModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateMLModelRequestMarshaller.Instance;
            var unmarshaller = UpdateMLModelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMLModelRequest,UpdateMLModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}