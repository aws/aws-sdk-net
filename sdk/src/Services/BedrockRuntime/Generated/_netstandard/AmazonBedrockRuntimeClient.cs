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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.BedrockRuntime.Model;
using Amazon.BedrockRuntime.Model.Internal.MarshallTransformations;
using Amazon.BedrockRuntime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.BedrockRuntime
{
    /// <summary>
    /// <para>Implementation for accessing BedrockRuntime</para>
    ///
    /// Describes the API operations for running inference using Amazon Bedrock models.
    /// </summary>
    public partial class AmazonBedrockRuntimeClient : AmazonServiceClient, IAmazonBedrockRuntime
    {
        private static IServiceMetadata serviceMetadata = new AmazonBedrockRuntimeMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonBedrockRuntimeClient with the credentials loaded from the application's
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
        public AmazonBedrockRuntimeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBedrockRuntimeConfig()) { }

        /// <summary>
        /// Constructs AmazonBedrockRuntimeClient with the credentials loaded from the application's
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
        public AmazonBedrockRuntimeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBedrockRuntimeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBedrockRuntimeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBedrockRuntimeClient Configuration Object</param>
        public AmazonBedrockRuntimeClient(AmazonBedrockRuntimeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonBedrockRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBedrockRuntimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonBedrockRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockRuntimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBedrockRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockRuntimeClient with AWS Credentials and an
        /// AmazonBedrockRuntimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBedrockRuntimeClient Configuration Object</param>
        public AmazonBedrockRuntimeClient(AWSCredentials credentials, AmazonBedrockRuntimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBedrockRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockRuntimeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBedrockRuntimeClient Configuration Object</param>
        public AmazonBedrockRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBedrockRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBedrockRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBedrockRuntimeClient Configuration Object</param>
        public AmazonBedrockRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBedrockRuntimeConfig clientConfig)
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
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockRuntimeEndpointResolver());
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


        #region  ApplyGuardrail

        internal virtual ApplyGuardrailResponse ApplyGuardrail(ApplyGuardrailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplyGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyGuardrailResponseUnmarshaller.Instance;

            return Invoke<ApplyGuardrailResponse>(request, options);
        }



        /// <summary>
        /// The action to apply a guardrail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplyGuardrail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ApplyGuardrail service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceQuotaExceededException">
        /// Your request exceeds the service quota for your account. You can view your quotas
        /// at <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/gs-request-quota.html">Viewing
        /// service quotas</a>. You can resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was throttled because of service-wide limitations. Resubmit your request
        /// later or in a different region. You can also purchase <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> to increase the rate or number of tokens you can process.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/ApplyGuardrail">REST API Reference for ApplyGuardrail Operation</seealso>
        public virtual Task<ApplyGuardrailResponse> ApplyGuardrailAsync(ApplyGuardrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplyGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyGuardrailResponseUnmarshaller.Instance;

            return InvokeAsync<ApplyGuardrailResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Converse

        internal virtual ConverseResponse Converse(ConverseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConverseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConverseResponseUnmarshaller.Instance;

            return Invoke<ConverseResponse>(request, options);
        }



        /// <summary>
        /// Sends messages to the specified Amazon Bedrock model. <c>Converse</c> provides a consistent
        /// interface that works with all models that support messages. This allows you to write
        /// code once and use it with different models. If a model has unique inference parameters,
        /// you can also pass those unique parameters to the model.
        /// 
        ///  
        /// <para>
        /// Amazon Bedrock doesn't store any text, images, or documents that you provide as content.
        /// The data is only used to generate the response.
        /// </para>
        ///  
        /// <para>
        /// For information about the Converse API, see <i>Use the Converse API</i> in the <i>Amazon
        /// Bedrock User Guide</i>. To use a guardrail, see <i>Use a guardrail with the Converse
        /// API</i> in the <i>Amazon Bedrock User Guide</i>. To use a tool with a model, see <i>Tool
        /// use (Function calling)</i> in the <i>Amazon Bedrock User Guide</i> 
        /// </para>
        ///  
        /// <para>
        /// For example code, see <i>Converse API examples</i> in the <i>Amazon Bedrock User Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <c>bedrock:InvokeModel</c> action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Converse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Converse service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelErrorException">
        /// The request failed due to an error while processing the model.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests. The AWS
        /// SDK will automatically retry the operation up to 5 times. For information about configuring
        /// automatic retries, see <a href="https://docs.aws.amazon.com/sdkref/latest/guide/feature-retry-behavior.html">Retry
        /// behavior</a> in the <i>AWS SDKs and Tools</i> reference guide.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelTimeoutException">
        /// The request took too long to process. Processing time exceeded the model timeout length.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceUnavailableException">
        /// The service isn't currently available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was throttled because of service-wide limitations. Resubmit your request
        /// later or in a different region. You can also purchase <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> to increase the rate or number of tokens you can process.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/Converse">REST API Reference for Converse Operation</seealso>
        public virtual Task<ConverseResponse> ConverseAsync(ConverseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConverseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConverseResponseUnmarshaller.Instance;

            return InvokeAsync<ConverseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConverseStream

        internal virtual ConverseStreamResponse ConverseStream(ConverseStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConverseStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConverseStreamResponseUnmarshaller.Instance;

            return Invoke<ConverseStreamResponse>(request, options);
        }



        /// <summary>
        /// Sends messages to the specified Amazon Bedrock model and returns the response in a
        /// stream. <c>ConverseStream</c> provides a consistent API that works with all Amazon
        /// Bedrock models that support messages. This allows you to write code once and use it
        /// with different models. Should a model have unique inference parameters, you can also
        /// pass those unique parameters to the model. 
        /// 
        ///  
        /// <para>
        /// To find out if a model supports streaming, call <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetFoundationModel.html">GetFoundationModel</a>
        /// and check the <c>responseStreamingSupported</c> field in the response.
        /// </para>
        ///  <note> 
        /// <para>
        /// The CLI doesn't support streaming operations in Amazon Bedrock, including <c>ConverseStream</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Amazon Bedrock doesn't store any text, images, or documents that you provide as content.
        /// The data is only used to generate the response.
        /// </para>
        ///  
        /// <para>
        /// For information about the Converse API, see <i>Use the Converse API</i> in the <i>Amazon
        /// Bedrock User Guide</i>. To use a guardrail, see <i>Use a guardrail with the Converse
        /// API</i> in the <i>Amazon Bedrock User Guide</i>. To use a tool with a model, see <i>Tool
        /// use (Function calling)</i> in the <i>Amazon Bedrock User Guide</i> 
        /// </para>
        ///  
        /// <para>
        /// For example code, see <i>Conversation streaming example</i> in the <i>Amazon Bedrock
        /// User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <c>bedrock:InvokeModelWithResponseStream</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConverseStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConverseStream service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelErrorException">
        /// The request failed due to an error while processing the model.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests. The AWS
        /// SDK will automatically retry the operation up to 5 times. For information about configuring
        /// automatic retries, see <a href="https://docs.aws.amazon.com/sdkref/latest/guide/feature-retry-behavior.html">Retry
        /// behavior</a> in the <i>AWS SDKs and Tools</i> reference guide.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelTimeoutException">
        /// The request took too long to process. Processing time exceeded the model timeout length.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceUnavailableException">
        /// The service isn't currently available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was throttled because of service-wide limitations. Resubmit your request
        /// later or in a different region. You can also purchase <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> to increase the rate or number of tokens you can process.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/ConverseStream">REST API Reference for ConverseStream Operation</seealso>
        public virtual Task<ConverseStreamResponse> ConverseStreamAsync(ConverseStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConverseStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConverseStreamResponseUnmarshaller.Instance;

            return InvokeAsync<ConverseStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InvokeModel

        internal virtual InvokeModelResponse InvokeModel(InvokeModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeModelResponseUnmarshaller.Instance;

            return Invoke<InvokeModelResponse>(request, options);
        }



        /// <summary>
        /// Invokes the specified Amazon Bedrock model to run inference using the prompt and inference
        /// parameters provided in the request body. You use model inference to generate text,
        /// images, and embeddings.
        /// 
        ///  
        /// <para>
        /// For example code, see <i>Invoke model code examples</i> in the <i>Amazon Bedrock User
        /// Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <c>bedrock:InvokeModel</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeModel service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelErrorException">
        /// The request failed due to an error while processing the model.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests. The AWS
        /// SDK will automatically retry the operation up to 5 times. For information about configuring
        /// automatic retries, see <a href="https://docs.aws.amazon.com/sdkref/latest/guide/feature-retry-behavior.html">Retry
        /// behavior</a> in the <i>AWS SDKs and Tools</i> reference guide.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelTimeoutException">
        /// The request took too long to process. Processing time exceeded the model timeout length.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceQuotaExceededException">
        /// Your request exceeds the service quota for your account. You can view your quotas
        /// at <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/gs-request-quota.html">Viewing
        /// service quotas</a>. You can resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceUnavailableException">
        /// The service isn't currently available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was throttled because of service-wide limitations. Resubmit your request
        /// later or in a different region. You can also purchase <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> to increase the rate or number of tokens you can process.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/InvokeModel">REST API Reference for InvokeModel Operation</seealso>
        public virtual Task<InvokeModelResponse> InvokeModelAsync(InvokeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeModelResponseUnmarshaller.Instance;

            return InvokeAsync<InvokeModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InvokeModelWithResponseStream

        internal virtual InvokeModelWithResponseStreamResponse InvokeModelWithResponseStream(InvokeModelWithResponseStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeModelWithResponseStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeModelWithResponseStreamResponseUnmarshaller.Instance;

            return Invoke<InvokeModelWithResponseStreamResponse>(request, options);
        }



        /// <summary>
        /// Invoke the specified Amazon Bedrock model to run inference using the prompt and inference
        /// parameters provided in the request body. The response is returned in a stream.
        /// 
        ///  
        /// <para>
        /// To see if a model supports streaming, call <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetFoundationModel.html">GetFoundationModel</a>
        /// and check the <c>responseStreamingSupported</c> field in the response.
        /// </para>
        ///  <note> 
        /// <para>
        /// The CLI doesn't support streaming operations in Amazon Bedrock, including <c>InvokeModelWithResponseStream</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For example code, see <i>Invoke model with streaming code example</i> in the <i>Amazon
        /// Bedrock User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>bedrock:InvokeModelWithResponseStream</c>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeModelWithResponseStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeModelWithResponseStream service method, as returned by BedrockRuntime.</returns>
        /// <exception cref="Amazon.BedrockRuntime.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelErrorException">
        /// The request failed due to an error while processing the model.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelNotReadyException">
        /// The model specified in the request is not ready to serve inference requests. The AWS
        /// SDK will automatically retry the operation up to 5 times. For information about configuring
        /// automatic retries, see <a href="https://docs.aws.amazon.com/sdkref/latest/guide/feature-retry-behavior.html">Retry
        /// behavior</a> in the <i>AWS SDKs and Tools</i> reference guide.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelStreamErrorException">
        /// An error occurred while streaming the response. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ModelTimeoutException">
        /// The request took too long to process. Processing time exceeded the model timeout length.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceQuotaExceededException">
        /// Your request exceeds the service quota for your account. You can view your quotas
        /// at <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/gs-request-quota.html">Viewing
        /// service quotas</a>. You can resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ServiceUnavailableException">
        /// The service isn't currently available. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ThrottlingException">
        /// Your request was throttled because of service-wide limitations. Resubmit your request
        /// later or in a different region. You can also purchase <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> to increase the rate or number of tokens you can process.
        /// </exception>
        /// <exception cref="Amazon.BedrockRuntime.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-runtime-2023-09-30/InvokeModelWithResponseStream">REST API Reference for InvokeModelWithResponseStream Operation</seealso>
        public virtual Task<InvokeModelWithResponseStreamResponse> InvokeModelWithResponseStreamAsync(InvokeModelWithResponseStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InvokeModelWithResponseStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeModelWithResponseStreamResponseUnmarshaller.Instance;

            return InvokeAsync<InvokeModelWithResponseStreamResponse>(request, options, cancellationToken);
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
            var resolver = new AmazonBedrockRuntimeEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}