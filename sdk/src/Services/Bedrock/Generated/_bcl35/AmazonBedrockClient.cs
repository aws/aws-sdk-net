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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Bedrock.Model;
using Amazon.Bedrock.Model.Internal.MarshallTransformations;
using Amazon.Bedrock.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Bedrock
{
    /// <summary>
    /// Implementation for accessing Bedrock
    ///
    /// Describes the API operations for creating and managing Bedrock models.
    /// </summary>
    public partial class AmazonBedrockClient : AmazonServiceClient, IAmazonBedrock
    {
        private static IServiceMetadata serviceMetadata = new AmazonBedrockMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IBedrockPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBedrockPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BedrockPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonBedrockClient with the credentials loaded from the application's
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
        public AmazonBedrockClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBedrockConfig()) { }

        /// <summary>
        /// Constructs AmazonBedrockClient with the credentials loaded from the application's
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
        public AmazonBedrockClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBedrockConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBedrockClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBedrockClient Configuration Object</param>
        public AmazonBedrockClient(AmazonBedrockConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBedrockClient(AWSCredentials credentials)
            : this(credentials, new AmazonBedrockConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBedrockConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Credentials and an
        /// AmazonBedrockClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBedrockClient Configuration Object</param>
        public AmazonBedrockClient(AWSCredentials credentials, AmazonBedrockConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBedrockClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBedrockClient Configuration Object</param>
        public AmazonBedrockClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBedrockConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBedrockClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBedrockClient Configuration Object</param>
        public AmazonBedrockClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBedrockConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockEndpointResolver());
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


        #region  CreateModelCustomizationJob

        /// <summary>
        /// Creates a fine-tuning job to customize a base model.
        /// 
        ///  
        /// <para>
        /// You specify the base foundation model and the location of the training data. After
        /// the model-customization job completes successfully, your custom model resource will
        /// be ready to use. Training data contains input and output text for each record in a
        /// JSONL format. Optionally, you can specify validation data in the same format as the
        /// training data. Bedrock returns validation loss metrics and output generations after
        /// the job completes. 
        /// </para>
        ///  
        /// <para>
        ///  Model-customization jobs are asynchronous and the completion time depends on the
        /// base model and the training/validation data size. To monitor a job, use the <code>GetModelCustomizationJob</code>
        /// operation to retrieve the job status.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCustomizationJob service method.</param>
        /// 
        /// <returns>The response from the CreateModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelCustomizationJob">REST API Reference for CreateModelCustomizationJob Operation</seealso>
        public virtual CreateModelCustomizationJobResponse CreateModelCustomizationJob(CreateModelCustomizationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelCustomizationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelCustomizationJobResponseUnmarshaller.Instance;

            return Invoke<CreateModelCustomizationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelCustomizationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCustomizationJob operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelCustomizationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelCustomizationJob">REST API Reference for CreateModelCustomizationJob Operation</seealso>
        public virtual IAsyncResult BeginCreateModelCustomizationJob(CreateModelCustomizationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelCustomizationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelCustomizationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelCustomizationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelCustomizationJob.</param>
        /// 
        /// <returns>Returns a  CreateModelCustomizationJobResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelCustomizationJob">REST API Reference for CreateModelCustomizationJob Operation</seealso>
        public virtual CreateModelCustomizationJobResponse EndCreateModelCustomizationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelCustomizationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProvisionedModelThroughput

        /// <summary>
        /// Creates a provisioned throughput with dedicated capacity for a foundation model or
        /// a fine-tuned model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisionedModelThroughput service method.</param>
        /// 
        /// <returns>The response from the CreateProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateProvisionedModelThroughput">REST API Reference for CreateProvisionedModelThroughput Operation</seealso>
        public virtual CreateProvisionedModelThroughputResponse CreateProvisionedModelThroughput(CreateProvisionedModelThroughputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisionedModelThroughputResponseUnmarshaller.Instance;

            return Invoke<CreateProvisionedModelThroughputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProvisionedModelThroughput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisionedModelThroughput operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProvisionedModelThroughput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateProvisionedModelThroughput">REST API Reference for CreateProvisionedModelThroughput Operation</seealso>
        public virtual IAsyncResult BeginCreateProvisionedModelThroughput(CreateProvisionedModelThroughputRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProvisionedModelThroughputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProvisionedModelThroughput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProvisionedModelThroughput.</param>
        /// 
        /// <returns>Returns a  CreateProvisionedModelThroughputResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateProvisionedModelThroughput">REST API Reference for CreateProvisionedModelThroughput Operation</seealso>
        public virtual CreateProvisionedModelThroughputResponse EndCreateProvisionedModelThroughput(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProvisionedModelThroughputResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCustomModel

        /// <summary>
        /// Deletes a custom model that you created earlier. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomModel service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteCustomModel">REST API Reference for DeleteCustomModel Operation</seealso>
        public virtual DeleteCustomModelResponse DeleteCustomModel(DeleteCustomModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomModelResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomModel operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteCustomModel">REST API Reference for DeleteCustomModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteCustomModel(DeleteCustomModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomModel.</param>
        /// 
        /// <returns>Returns a  DeleteCustomModelResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteCustomModel">REST API Reference for DeleteCustomModel Operation</seealso>
        public virtual DeleteCustomModelResponse EndDeleteCustomModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCustomModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteModelInvocationLoggingConfiguration

        /// <summary>
        /// Delete the invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelInvocationLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteModelInvocationLoggingConfiguration">REST API Reference for DeleteModelInvocationLoggingConfiguration Operation</seealso>
        public virtual DeleteModelInvocationLoggingConfigurationResponse DeleteModelInvocationLoggingConfiguration(DeleteModelInvocationLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelInvocationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelInvocationLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteModelInvocationLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModelInvocationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelInvocationLoggingConfiguration operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModelInvocationLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteModelInvocationLoggingConfiguration">REST API Reference for DeleteModelInvocationLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteModelInvocationLoggingConfiguration(DeleteModelInvocationLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelInvocationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelInvocationLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModelInvocationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModelInvocationLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteModelInvocationLoggingConfigurationResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteModelInvocationLoggingConfiguration">REST API Reference for DeleteModelInvocationLoggingConfiguration Operation</seealso>
        public virtual DeleteModelInvocationLoggingConfigurationResponse EndDeleteModelInvocationLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteModelInvocationLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProvisionedModelThroughput

        /// <summary>
        /// Deletes a provisioned throughput. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedModelThroughput service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteProvisionedModelThroughput">REST API Reference for DeleteProvisionedModelThroughput Operation</seealso>
        public virtual DeleteProvisionedModelThroughputResponse DeleteProvisionedModelThroughput(DeleteProvisionedModelThroughputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisionedModelThroughputResponseUnmarshaller.Instance;

            return Invoke<DeleteProvisionedModelThroughputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProvisionedModelThroughput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedModelThroughput operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProvisionedModelThroughput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteProvisionedModelThroughput">REST API Reference for DeleteProvisionedModelThroughput Operation</seealso>
        public virtual IAsyncResult BeginDeleteProvisionedModelThroughput(DeleteProvisionedModelThroughputRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProvisionedModelThroughputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProvisionedModelThroughput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProvisionedModelThroughput.</param>
        /// 
        /// <returns>Returns a  DeleteProvisionedModelThroughputResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteProvisionedModelThroughput">REST API Reference for DeleteProvisionedModelThroughput Operation</seealso>
        public virtual DeleteProvisionedModelThroughputResponse EndDeleteProvisionedModelThroughput(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProvisionedModelThroughputResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCustomModel

        /// <summary>
        /// Get the properties associated with a Bedrock custom model that you have created.For
        /// more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomModel service method.</param>
        /// 
        /// <returns>The response from the GetCustomModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetCustomModel">REST API Reference for GetCustomModel Operation</seealso>
        public virtual GetCustomModelResponse GetCustomModel(GetCustomModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomModelResponseUnmarshaller.Instance;

            return Invoke<GetCustomModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCustomModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCustomModel operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCustomModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetCustomModel">REST API Reference for GetCustomModel Operation</seealso>
        public virtual IAsyncResult BeginGetCustomModel(GetCustomModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCustomModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCustomModel.</param>
        /// 
        /// <returns>Returns a  GetCustomModelResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetCustomModel">REST API Reference for GetCustomModel Operation</seealso>
        public virtual GetCustomModelResponse EndGetCustomModel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCustomModelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFoundationModel

        /// <summary>
        /// Get details about a Bedrock foundation model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFoundationModel service method.</param>
        /// 
        /// <returns>The response from the GetFoundationModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetFoundationModel">REST API Reference for GetFoundationModel Operation</seealso>
        public virtual GetFoundationModelResponse GetFoundationModel(GetFoundationModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFoundationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFoundationModelResponseUnmarshaller.Instance;

            return Invoke<GetFoundationModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFoundationModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFoundationModel operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFoundationModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetFoundationModel">REST API Reference for GetFoundationModel Operation</seealso>
        public virtual IAsyncResult BeginGetFoundationModel(GetFoundationModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFoundationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFoundationModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFoundationModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFoundationModel.</param>
        /// 
        /// <returns>Returns a  GetFoundationModelResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetFoundationModel">REST API Reference for GetFoundationModel Operation</seealso>
        public virtual GetFoundationModelResponse EndGetFoundationModel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFoundationModelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModelCustomizationJob

        /// <summary>
        /// Retrieves the properties associated with a model-customization job, including the
        /// status of the job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelCustomizationJob service method.</param>
        /// 
        /// <returns>The response from the GetModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelCustomizationJob">REST API Reference for GetModelCustomizationJob Operation</seealso>
        public virtual GetModelCustomizationJobResponse GetModelCustomizationJob(GetModelCustomizationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelCustomizationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelCustomizationJobResponseUnmarshaller.Instance;

            return Invoke<GetModelCustomizationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetModelCustomizationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelCustomizationJob operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelCustomizationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelCustomizationJob">REST API Reference for GetModelCustomizationJob Operation</seealso>
        public virtual IAsyncResult BeginGetModelCustomizationJob(GetModelCustomizationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelCustomizationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelCustomizationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelCustomizationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelCustomizationJob.</param>
        /// 
        /// <returns>Returns a  GetModelCustomizationJobResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelCustomizationJob">REST API Reference for GetModelCustomizationJob Operation</seealso>
        public virtual GetModelCustomizationJobResponse EndGetModelCustomizationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelCustomizationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModelInvocationLoggingConfiguration

        /// <summary>
        /// Get the current configuration values for model invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelInvocationLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelInvocationLoggingConfiguration">REST API Reference for GetModelInvocationLoggingConfiguration Operation</seealso>
        public virtual GetModelInvocationLoggingConfigurationResponse GetModelInvocationLoggingConfiguration(GetModelInvocationLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelInvocationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelInvocationLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetModelInvocationLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetModelInvocationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelInvocationLoggingConfiguration operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelInvocationLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelInvocationLoggingConfiguration">REST API Reference for GetModelInvocationLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetModelInvocationLoggingConfiguration(GetModelInvocationLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelInvocationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelInvocationLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelInvocationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelInvocationLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetModelInvocationLoggingConfigurationResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelInvocationLoggingConfiguration">REST API Reference for GetModelInvocationLoggingConfiguration Operation</seealso>
        public virtual GetModelInvocationLoggingConfigurationResponse EndGetModelInvocationLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelInvocationLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProvisionedModelThroughput

        /// <summary>
        /// Get details for a provisioned throughput. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProvisionedModelThroughput service method.</param>
        /// 
        /// <returns>The response from the GetProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetProvisionedModelThroughput">REST API Reference for GetProvisionedModelThroughput Operation</seealso>
        public virtual GetProvisionedModelThroughputResponse GetProvisionedModelThroughput(GetProvisionedModelThroughputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProvisionedModelThroughputResponseUnmarshaller.Instance;

            return Invoke<GetProvisionedModelThroughputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProvisionedModelThroughput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProvisionedModelThroughput operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProvisionedModelThroughput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetProvisionedModelThroughput">REST API Reference for GetProvisionedModelThroughput Operation</seealso>
        public virtual IAsyncResult BeginGetProvisionedModelThroughput(GetProvisionedModelThroughputRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProvisionedModelThroughputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProvisionedModelThroughput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProvisionedModelThroughput.</param>
        /// 
        /// <returns>Returns a  GetProvisionedModelThroughputResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetProvisionedModelThroughput">REST API Reference for GetProvisionedModelThroughput Operation</seealso>
        public virtual GetProvisionedModelThroughputResponse EndGetProvisionedModelThroughput(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProvisionedModelThroughputResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCustomModels

        /// <summary>
        /// Returns a list of the custom models that you have created with the <code>CreateModelCustomizationJob</code>
        /// operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomModels service method.</param>
        /// 
        /// <returns>The response from the ListCustomModels service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListCustomModels">REST API Reference for ListCustomModels Operation</seealso>
        public virtual ListCustomModelsResponse ListCustomModels(ListCustomModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomModelsResponseUnmarshaller.Instance;

            return Invoke<ListCustomModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomModels operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListCustomModels">REST API Reference for ListCustomModels Operation</seealso>
        public virtual IAsyncResult BeginListCustomModels(ListCustomModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCustomModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomModels.</param>
        /// 
        /// <returns>Returns a  ListCustomModelsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListCustomModels">REST API Reference for ListCustomModels Operation</seealso>
        public virtual ListCustomModelsResponse EndListCustomModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCustomModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFoundationModels

        /// <summary>
        /// List of Bedrock foundation models that you can use. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/foundation-models.html">Foundation
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFoundationModels service method.</param>
        /// 
        /// <returns>The response from the ListFoundationModels service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListFoundationModels">REST API Reference for ListFoundationModels Operation</seealso>
        public virtual ListFoundationModelsResponse ListFoundationModels(ListFoundationModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFoundationModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFoundationModelsResponseUnmarshaller.Instance;

            return Invoke<ListFoundationModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFoundationModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFoundationModels operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFoundationModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListFoundationModels">REST API Reference for ListFoundationModels Operation</seealso>
        public virtual IAsyncResult BeginListFoundationModels(ListFoundationModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFoundationModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFoundationModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFoundationModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFoundationModels.</param>
        /// 
        /// <returns>Returns a  ListFoundationModelsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListFoundationModels">REST API Reference for ListFoundationModels Operation</seealso>
        public virtual ListFoundationModelsResponse EndListFoundationModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFoundationModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListModelCustomizationJobs

        /// <summary>
        /// Returns a list of model customization jobs that you have submitted. You can filter
        /// the jobs to return based on one or more criteria.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelCustomizationJobs service method.</param>
        /// 
        /// <returns>The response from the ListModelCustomizationJobs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelCustomizationJobs">REST API Reference for ListModelCustomizationJobs Operation</seealso>
        public virtual ListModelCustomizationJobsResponse ListModelCustomizationJobs(ListModelCustomizationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelCustomizationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelCustomizationJobsResponseUnmarshaller.Instance;

            return Invoke<ListModelCustomizationJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelCustomizationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelCustomizationJobs operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelCustomizationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelCustomizationJobs">REST API Reference for ListModelCustomizationJobs Operation</seealso>
        public virtual IAsyncResult BeginListModelCustomizationJobs(ListModelCustomizationJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListModelCustomizationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelCustomizationJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelCustomizationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelCustomizationJobs.</param>
        /// 
        /// <returns>Returns a  ListModelCustomizationJobsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelCustomizationJobs">REST API Reference for ListModelCustomizationJobs Operation</seealso>
        public virtual ListModelCustomizationJobsResponse EndListModelCustomizationJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListModelCustomizationJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProvisionedModelThroughputs

        /// <summary>
        /// List the provisioned capacities. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedModelThroughputs service method.</param>
        /// 
        /// <returns>The response from the ListProvisionedModelThroughputs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListProvisionedModelThroughputs">REST API Reference for ListProvisionedModelThroughputs Operation</seealso>
        public virtual ListProvisionedModelThroughputsResponse ListProvisionedModelThroughputs(ListProvisionedModelThroughputsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisionedModelThroughputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedModelThroughputsResponseUnmarshaller.Instance;

            return Invoke<ListProvisionedModelThroughputsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisionedModelThroughputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedModelThroughputs operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProvisionedModelThroughputs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListProvisionedModelThroughputs">REST API Reference for ListProvisionedModelThroughputs Operation</seealso>
        public virtual IAsyncResult BeginListProvisionedModelThroughputs(ListProvisionedModelThroughputsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProvisionedModelThroughputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProvisionedModelThroughputsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProvisionedModelThroughputs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProvisionedModelThroughputs.</param>
        /// 
        /// <returns>Returns a  ListProvisionedModelThroughputsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListProvisionedModelThroughputs">REST API Reference for ListProvisionedModelThroughputs Operation</seealso>
        public virtual ListProvisionedModelThroughputsResponse EndListProvisionedModelThroughputs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProvisionedModelThroughputsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List the tags associated with the specified resource.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutModelInvocationLoggingConfiguration

        /// <summary>
        /// Set the configuration values for model invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutModelInvocationLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutModelInvocationLoggingConfiguration">REST API Reference for PutModelInvocationLoggingConfiguration Operation</seealso>
        public virtual PutModelInvocationLoggingConfigurationResponse PutModelInvocationLoggingConfiguration(PutModelInvocationLoggingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutModelInvocationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutModelInvocationLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutModelInvocationLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutModelInvocationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutModelInvocationLoggingConfiguration operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutModelInvocationLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutModelInvocationLoggingConfiguration">REST API Reference for PutModelInvocationLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutModelInvocationLoggingConfiguration(PutModelInvocationLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutModelInvocationLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutModelInvocationLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutModelInvocationLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutModelInvocationLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutModelInvocationLoggingConfigurationResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutModelInvocationLoggingConfiguration">REST API Reference for PutModelInvocationLoggingConfiguration Operation</seealso>
        public virtual PutModelInvocationLoggingConfigurationResponse EndPutModelInvocationLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutModelInvocationLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  StopModelCustomizationJob

        /// <summary>
        /// Stops an active model customization job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopModelCustomizationJob service method.</param>
        /// 
        /// <returns>The response from the StopModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopModelCustomizationJob">REST API Reference for StopModelCustomizationJob Operation</seealso>
        public virtual StopModelCustomizationJobResponse StopModelCustomizationJob(StopModelCustomizationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopModelCustomizationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopModelCustomizationJobResponseUnmarshaller.Instance;

            return Invoke<StopModelCustomizationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopModelCustomizationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopModelCustomizationJob operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopModelCustomizationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopModelCustomizationJob">REST API Reference for StopModelCustomizationJob Operation</seealso>
        public virtual IAsyncResult BeginStopModelCustomizationJob(StopModelCustomizationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopModelCustomizationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopModelCustomizationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopModelCustomizationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopModelCustomizationJob.</param>
        /// 
        /// <returns>Returns a  StopModelCustomizationJobResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopModelCustomizationJob">REST API Reference for StopModelCustomizationJob Operation</seealso>
        public virtual StopModelCustomizationJobResponse EndStopModelCustomizationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopModelCustomizationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associate tags with a resource. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Remove one or more tags from a resource. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProvisionedModelThroughput

        /// <summary>
        /// Update a provisioned throughput. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedModelThroughput service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateProvisionedModelThroughput">REST API Reference for UpdateProvisionedModelThroughput Operation</seealso>
        public virtual UpdateProvisionedModelThroughputResponse UpdateProvisionedModelThroughput(UpdateProvisionedModelThroughputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisionedModelThroughputResponseUnmarshaller.Instance;

            return Invoke<UpdateProvisionedModelThroughputResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProvisionedModelThroughput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedModelThroughput operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProvisionedModelThroughput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateProvisionedModelThroughput">REST API Reference for UpdateProvisionedModelThroughput Operation</seealso>
        public virtual IAsyncResult BeginUpdateProvisionedModelThroughput(UpdateProvisionedModelThroughputRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProvisionedModelThroughputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProvisionedModelThroughputResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProvisionedModelThroughput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProvisionedModelThroughput.</param>
        /// 
        /// <returns>Returns a  UpdateProvisionedModelThroughputResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateProvisionedModelThroughput">REST API Reference for UpdateProvisionedModelThroughput Operation</seealso>
        public virtual UpdateProvisionedModelThroughputResponse EndUpdateProvisionedModelThroughput(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProvisionedModelThroughputResponse>(asyncResult);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonBedrockEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}