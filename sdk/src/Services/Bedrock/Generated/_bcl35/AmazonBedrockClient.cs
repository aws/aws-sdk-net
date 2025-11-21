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

#pragma warning disable CS1570
namespace Amazon.Bedrock
{
    /// <summary>
    /// <para>Implementation for accessing Bedrock</para>
    ///
    /// Describes the API operations for creating, managing, fine-turning, and evaluating
    /// Amazon Bedrock models.
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


        #region  BatchDeleteEvaluationJob

        /// <summary>
        /// Deletes a batch of evaluation jobs. An evaluation job can only be deleted if it has
        /// following status <c>FAILED</c>, <c>COMPLETED</c>, and <c>STOPPED</c>. You can request
        /// up to 25 model evaluation jobs be deleted in a single request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteEvaluationJob service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteEvaluationJob service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/BatchDeleteEvaluationJob">REST API Reference for BatchDeleteEvaluationJob Operation</seealso>
        public virtual BatchDeleteEvaluationJobResponse BatchDeleteEvaluationJob(BatchDeleteEvaluationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteEvaluationJobResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteEvaluationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteEvaluationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteEvaluationJob operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteEvaluationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/BatchDeleteEvaluationJob">REST API Reference for BatchDeleteEvaluationJob Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteEvaluationJob(BatchDeleteEvaluationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteEvaluationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteEvaluationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteEvaluationJob.</param>
        /// 
        /// <returns>Returns a  BatchDeleteEvaluationJobResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/BatchDeleteEvaluationJob">REST API Reference for BatchDeleteEvaluationJob Operation</seealso>
        public virtual BatchDeleteEvaluationJobResponse EndBatchDeleteEvaluationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteEvaluationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelAutomatedReasoningPolicyBuildWorkflow

        /// <summary>
        /// Cancels a running Automated Reasoning policy build workflow. This stops the policy
        /// generation process and prevents further processing of the source documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelAutomatedReasoningPolicyBuildWorkflow service method.</param>
        /// 
        /// <returns>The response from the CancelAutomatedReasoningPolicyBuildWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CancelAutomatedReasoningPolicyBuildWorkflow">REST API Reference for CancelAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual CancelAutomatedReasoningPolicyBuildWorkflowResponse CancelAutomatedReasoningPolicyBuildWorkflow(CancelAutomatedReasoningPolicyBuildWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;

            return Invoke<CancelAutomatedReasoningPolicyBuildWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelAutomatedReasoningPolicyBuildWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelAutomatedReasoningPolicyBuildWorkflow operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelAutomatedReasoningPolicyBuildWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CancelAutomatedReasoningPolicyBuildWorkflow">REST API Reference for CancelAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual IAsyncResult BeginCancelAutomatedReasoningPolicyBuildWorkflow(CancelAutomatedReasoningPolicyBuildWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelAutomatedReasoningPolicyBuildWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelAutomatedReasoningPolicyBuildWorkflow.</param>
        /// 
        /// <returns>Returns a  CancelAutomatedReasoningPolicyBuildWorkflowResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CancelAutomatedReasoningPolicyBuildWorkflow">REST API Reference for CancelAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual CancelAutomatedReasoningPolicyBuildWorkflowResponse EndCancelAutomatedReasoningPolicyBuildWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelAutomatedReasoningPolicyBuildWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAutomatedReasoningPolicy

        /// <summary>
        /// Creates an Automated Reasoning policy for Amazon Bedrock Guardrails. Automated Reasoning
        /// policies use mathematical techniques to detect hallucinations, suggest corrections,
        /// and highlight unstated assumptions in the responses of your GenAI application.
        /// 
        ///  
        /// <para>
        /// To create a policy, you upload a source document that describes the rules that you're
        /// encoding. Automated Reasoning extracts important concepts from the source document
        /// that will become variables in the policy and infers policy rules.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomatedReasoningPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateAutomatedReasoningPolicy service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicy">REST API Reference for CreateAutomatedReasoningPolicy Operation</seealso>
        public virtual CreateAutomatedReasoningPolicyResponse CreateAutomatedReasoningPolicy(CreateAutomatedReasoningPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomatedReasoningPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateAutomatedReasoningPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutomatedReasoningPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomatedReasoningPolicy operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAutomatedReasoningPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicy">REST API Reference for CreateAutomatedReasoningPolicy Operation</seealso>
        public virtual IAsyncResult BeginCreateAutomatedReasoningPolicy(CreateAutomatedReasoningPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomatedReasoningPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAutomatedReasoningPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutomatedReasoningPolicy.</param>
        /// 
        /// <returns>Returns a  CreateAutomatedReasoningPolicyResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicy">REST API Reference for CreateAutomatedReasoningPolicy Operation</seealso>
        public virtual CreateAutomatedReasoningPolicyResponse EndCreateAutomatedReasoningPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAutomatedReasoningPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAutomatedReasoningPolicyTestCase

        /// <summary>
        /// Creates a test for an Automated Reasoning policy. Tests validate that your policy
        /// works as expected by providing sample inputs and expected outcomes. Use tests to verify
        /// policy behavior before deploying to production.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomatedReasoningPolicyTestCase service method.</param>
        /// 
        /// <returns>The response from the CreateAutomatedReasoningPolicyTestCase service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicyTestCase">REST API Reference for CreateAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual CreateAutomatedReasoningPolicyTestCaseResponse CreateAutomatedReasoningPolicyTestCase(CreateAutomatedReasoningPolicyTestCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;

            return Invoke<CreateAutomatedReasoningPolicyTestCaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutomatedReasoningPolicyTestCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomatedReasoningPolicyTestCase operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAutomatedReasoningPolicyTestCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicyTestCase">REST API Reference for CreateAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual IAsyncResult BeginCreateAutomatedReasoningPolicyTestCase(CreateAutomatedReasoningPolicyTestCaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAutomatedReasoningPolicyTestCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutomatedReasoningPolicyTestCase.</param>
        /// 
        /// <returns>Returns a  CreateAutomatedReasoningPolicyTestCaseResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicyTestCase">REST API Reference for CreateAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual CreateAutomatedReasoningPolicyTestCaseResponse EndCreateAutomatedReasoningPolicyTestCase(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAutomatedReasoningPolicyTestCaseResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAutomatedReasoningPolicyVersion

        /// <summary>
        /// Creates a new version of an existing Automated Reasoning policy. This allows you to
        /// iterate on your policy rules while maintaining previous versions for rollback or comparison
        /// purposes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomatedReasoningPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the CreateAutomatedReasoningPolicyVersion service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicyVersion">REST API Reference for CreateAutomatedReasoningPolicyVersion Operation</seealso>
        public virtual CreateAutomatedReasoningPolicyVersionResponse CreateAutomatedReasoningPolicyVersion(CreateAutomatedReasoningPolicyVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomatedReasoningPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomatedReasoningPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<CreateAutomatedReasoningPolicyVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutomatedReasoningPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutomatedReasoningPolicyVersion operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAutomatedReasoningPolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicyVersion">REST API Reference for CreateAutomatedReasoningPolicyVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateAutomatedReasoningPolicyVersion(CreateAutomatedReasoningPolicyVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAutomatedReasoningPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutomatedReasoningPolicyVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAutomatedReasoningPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutomatedReasoningPolicyVersion.</param>
        /// 
        /// <returns>Returns a  CreateAutomatedReasoningPolicyVersionResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateAutomatedReasoningPolicyVersion">REST API Reference for CreateAutomatedReasoningPolicyVersion Operation</seealso>
        public virtual CreateAutomatedReasoningPolicyVersionResponse EndCreateAutomatedReasoningPolicyVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAutomatedReasoningPolicyVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCustomModel

        /// <summary>
        /// Creates a new custom model in Amazon Bedrock. After the model is active, you can use
        /// it for inference.
        /// 
        ///  
        /// <para>
        /// To use the model for inference, you must purchase Provisioned Throughput for it. You
        /// can't use On-demand inference with these custom models. For more information about
        /// Provisioned Throughput, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a>.
        /// </para>
        ///  
        /// <para>
        /// The model appears in <c>ListCustomModels</c> with a <c>customizationType</c> of <c>imported</c>.
        /// To track the status of the new model, you use the <c>GetCustomModel</c> API operation.
        /// The model can be in the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Creating</c> - Initial state during validation and registration
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Active</c> - Model is ready for use in inference
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - Creation process encountered an error
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related APIs</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModel.html">GetCustomModel</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModels.html">ListCustomModels</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModel.html">DeleteCustomModel</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomModel service method.</param>
        /// 
        /// <returns>The response from the CreateCustomModel service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateCustomModel">REST API Reference for CreateCustomModel Operation</seealso>
        public virtual CreateCustomModelResponse CreateCustomModel(CreateCustomModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomModelResponseUnmarshaller.Instance;

            return Invoke<CreateCustomModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomModel operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateCustomModel">REST API Reference for CreateCustomModel Operation</seealso>
        public virtual IAsyncResult BeginCreateCustomModel(CreateCustomModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomModel.</param>
        /// 
        /// <returns>Returns a  CreateCustomModelResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateCustomModel">REST API Reference for CreateCustomModel Operation</seealso>
        public virtual CreateCustomModelResponse EndCreateCustomModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCustomModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCustomModelDeployment

        /// <summary>
        /// Deploys a custom model for on-demand inference in Amazon Bedrock. After you deploy
        /// your custom model, you use the deployment's Amazon Resource Name (ARN) as the <c>modelId</c>
        /// parameter when you submit prompts and generate responses with model inference.
        /// 
        ///  
        /// <para>
        ///  For more information about setting up on-demand inference for custom models, see
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-use.html">Set
        /// up inference for a custom model</a>. 
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to the <c>CreateCustomModelDeployment</c> operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModelDeployment.html">GetCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModelDeployments.html">ListCustomModelDeployments</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModelDeployment.html">DeleteCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomModelDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateCustomModelDeployment service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateCustomModelDeployment">REST API Reference for CreateCustomModelDeployment Operation</seealso>
        public virtual CreateCustomModelDeploymentResponse CreateCustomModelDeployment(CreateCustomModelDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomModelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomModelDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateCustomModelDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomModelDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomModelDeployment operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomModelDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateCustomModelDeployment">REST API Reference for CreateCustomModelDeployment Operation</seealso>
        public virtual IAsyncResult BeginCreateCustomModelDeployment(CreateCustomModelDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomModelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomModelDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomModelDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomModelDeployment.</param>
        /// 
        /// <returns>Returns a  CreateCustomModelDeploymentResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateCustomModelDeployment">REST API Reference for CreateCustomModelDeployment Operation</seealso>
        public virtual CreateCustomModelDeploymentResponse EndCreateCustomModelDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCustomModelDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEvaluationJob

        /// <summary>
        /// Creates an evaluation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEvaluationJob service method.</param>
        /// 
        /// <returns>The response from the CreateEvaluationJob service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateEvaluationJob">REST API Reference for CreateEvaluationJob Operation</seealso>
        public virtual CreateEvaluationJobResponse CreateEvaluationJob(CreateEvaluationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEvaluationJobResponseUnmarshaller.Instance;

            return Invoke<CreateEvaluationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEvaluationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEvaluationJob operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEvaluationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateEvaluationJob">REST API Reference for CreateEvaluationJob Operation</seealso>
        public virtual IAsyncResult BeginCreateEvaluationJob(CreateEvaluationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEvaluationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEvaluationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEvaluationJob.</param>
        /// 
        /// <returns>Returns a  CreateEvaluationJobResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateEvaluationJob">REST API Reference for CreateEvaluationJob Operation</seealso>
        public virtual CreateEvaluationJobResponse EndCreateEvaluationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEvaluationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFoundationModelAgreement

        /// <summary>
        /// Request a model access agreement for the specified model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFoundationModelAgreement service method.</param>
        /// 
        /// <returns>The response from the CreateFoundationModelAgreement service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateFoundationModelAgreement">REST API Reference for CreateFoundationModelAgreement Operation</seealso>
        public virtual CreateFoundationModelAgreementResponse CreateFoundationModelAgreement(CreateFoundationModelAgreementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFoundationModelAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFoundationModelAgreementResponseUnmarshaller.Instance;

            return Invoke<CreateFoundationModelAgreementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFoundationModelAgreement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFoundationModelAgreement operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFoundationModelAgreement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateFoundationModelAgreement">REST API Reference for CreateFoundationModelAgreement Operation</seealso>
        public virtual IAsyncResult BeginCreateFoundationModelAgreement(CreateFoundationModelAgreementRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFoundationModelAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFoundationModelAgreementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFoundationModelAgreement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFoundationModelAgreement.</param>
        /// 
        /// <returns>Returns a  CreateFoundationModelAgreementResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateFoundationModelAgreement">REST API Reference for CreateFoundationModelAgreement Operation</seealso>
        public virtual CreateFoundationModelAgreementResponse EndCreateFoundationModelAgreement(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFoundationModelAgreementResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGuardrail

        /// <summary>
        /// Creates a guardrail to block topics and to implement safeguards for your generative
        /// AI applications.
        /// 
        ///  
        /// <para>
        /// You can configure the following policies in a guardrail to avoid undesirable and harmful
        /// content, filter out denied topics and words, and remove sensitive information for
        /// privacy protection.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Content filters</b> - Adjust filter strengths to block input prompts or model
        /// responses containing harmful content.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Denied topics</b> - Define a set of topics that are undesirable in the context
        /// of your application. These topics will be blocked if detected in user queries or model
        /// responses.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Word filters</b> - Configure filters to block undesirable words, phrases, and
        /// profanity. Such words can include offensive terms, competitor names etc.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Sensitive information filters</b> - Block or mask sensitive information such as
        /// personally identifiable information (PII) or custom regex in user inputs and model
        /// responses.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In addition to the above policies, you can also configure the messages to be returned
        /// to the user if a user input or model response is in violation of the policies defined
        /// in the guardrail.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails.html">Amazon
        /// Bedrock Guardrails</a> in the <i>Amazon Bedrock User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGuardrail service method.</param>
        /// 
        /// <returns>The response from the CreateGuardrail service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateGuardrail">REST API Reference for CreateGuardrail Operation</seealso>
        public virtual CreateGuardrailResponse CreateGuardrail(CreateGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGuardrailResponseUnmarshaller.Instance;

            return Invoke<CreateGuardrailResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGuardrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGuardrail operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGuardrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateGuardrail">REST API Reference for CreateGuardrail Operation</seealso>
        public virtual IAsyncResult BeginCreateGuardrail(CreateGuardrailRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGuardrailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGuardrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGuardrail.</param>
        /// 
        /// <returns>Returns a  CreateGuardrailResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateGuardrail">REST API Reference for CreateGuardrail Operation</seealso>
        public virtual CreateGuardrailResponse EndCreateGuardrail(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGuardrailResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGuardrailVersion

        /// <summary>
        /// Creates a version of the guardrail. Use this API to create a snapshot of the guardrail
        /// when you are satisfied with a configuration, or to compare the configuration with
        /// another version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGuardrailVersion service method.</param>
        /// 
        /// <returns>The response from the CreateGuardrailVersion service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateGuardrailVersion">REST API Reference for CreateGuardrailVersion Operation</seealso>
        public virtual CreateGuardrailVersionResponse CreateGuardrailVersion(CreateGuardrailVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGuardrailVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGuardrailVersionResponseUnmarshaller.Instance;

            return Invoke<CreateGuardrailVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGuardrailVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGuardrailVersion operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGuardrailVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateGuardrailVersion">REST API Reference for CreateGuardrailVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateGuardrailVersion(CreateGuardrailVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGuardrailVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGuardrailVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGuardrailVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGuardrailVersion.</param>
        /// 
        /// <returns>Returns a  CreateGuardrailVersionResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateGuardrailVersion">REST API Reference for CreateGuardrailVersion Operation</seealso>
        public virtual CreateGuardrailVersionResponse EndCreateGuardrailVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGuardrailVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInferenceProfile

        /// <summary>
        /// Creates an application inference profile to track metrics and costs when invoking
        /// a model. To create an application inference profile for a foundation model in one
        /// region, specify the ARN of the model in that region. To create an application inference
        /// profile for a foundation model across multiple regions, specify the ARN of the system-defined
        /// inference profile that contains the regions that you want to route requests to. For
        /// more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
        /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
        /// Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateInferenceProfile service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateInferenceProfile">REST API Reference for CreateInferenceProfile Operation</seealso>
        public virtual CreateInferenceProfileResponse CreateInferenceProfile(CreateInferenceProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInferenceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInferenceProfileResponseUnmarshaller.Instance;

            return Invoke<CreateInferenceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInferenceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceProfile operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInferenceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateInferenceProfile">REST API Reference for CreateInferenceProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateInferenceProfile(CreateInferenceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInferenceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInferenceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInferenceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInferenceProfile.</param>
        /// 
        /// <returns>Returns a  CreateInferenceProfileResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateInferenceProfile">REST API Reference for CreateInferenceProfile Operation</seealso>
        public virtual CreateInferenceProfileResponse EndCreateInferenceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInferenceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateMarketplaceModelEndpoint

        /// <summary>
        /// Creates an endpoint for a model from Amazon Bedrock Marketplace. The endpoint is hosted
        /// by Amazon SageMaker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMarketplaceModelEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateMarketplaceModelEndpoint">REST API Reference for CreateMarketplaceModelEndpoint Operation</seealso>
        public virtual CreateMarketplaceModelEndpointResponse CreateMarketplaceModelEndpoint(CreateMarketplaceModelEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateMarketplaceModelEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMarketplaceModelEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMarketplaceModelEndpoint operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMarketplaceModelEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateMarketplaceModelEndpoint">REST API Reference for CreateMarketplaceModelEndpoint Operation</seealso>
        public virtual IAsyncResult BeginCreateMarketplaceModelEndpoint(CreateMarketplaceModelEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMarketplaceModelEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMarketplaceModelEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateMarketplaceModelEndpointResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateMarketplaceModelEndpoint">REST API Reference for CreateMarketplaceModelEndpoint Operation</seealso>
        public virtual CreateMarketplaceModelEndpointResponse EndCreateMarketplaceModelEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateMarketplaceModelEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateModelCopyJob

        /// <summary>
        /// Copies a model to another region so that it can be used there. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/copy-model.html">Copy
        /// models to be used in other regions</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCopyJob service method.</param>
        /// 
        /// <returns>The response from the CreateModelCopyJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelCopyJob">REST API Reference for CreateModelCopyJob Operation</seealso>
        public virtual CreateModelCopyJobResponse CreateModelCopyJob(CreateModelCopyJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelCopyJobResponseUnmarshaller.Instance;

            return Invoke<CreateModelCopyJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelCopyJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCopyJob operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelCopyJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelCopyJob">REST API Reference for CreateModelCopyJob Operation</seealso>
        public virtual IAsyncResult BeginCreateModelCopyJob(CreateModelCopyJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelCopyJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelCopyJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelCopyJob.</param>
        /// 
        /// <returns>Returns a  CreateModelCopyJobResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelCopyJob">REST API Reference for CreateModelCopyJob Operation</seealso>
        public virtual CreateModelCopyJobResponse EndCreateModelCopyJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelCopyJobResponse>(asyncResult);
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
        /// be ready to use. Amazon Bedrock returns validation loss metrics and output generations
        /// after the job completes. 
        /// </para>
        ///  
        /// <para>
        /// For information on the format of training and validation data, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-prepare.html">Prepare
        /// the datasets</a>.
        /// </para>
        ///  
        /// <para>
        ///  Model-customization jobs are asynchronous and the completion time depends on the
        /// base model and the training/validation data size. To monitor a job, use the <c>GetModelCustomizationJob</c>
        /// operation to retrieve the job status.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  CreateModelImportJob

        /// <summary>
        /// Creates a model import job to import model that you have customized in other environments,
        /// such as Amazon SageMaker. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateModelImportJob service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelImportJob">REST API Reference for CreateModelImportJob Operation</seealso>
        public virtual CreateModelImportJobResponse CreateModelImportJob(CreateModelImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateModelImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelImportJob operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelImportJob">REST API Reference for CreateModelImportJob Operation</seealso>
        public virtual IAsyncResult BeginCreateModelImportJob(CreateModelImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelImportJob.</param>
        /// 
        /// <returns>Returns a  CreateModelImportJobResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelImportJob">REST API Reference for CreateModelImportJob Operation</seealso>
        public virtual CreateModelImportJobResponse EndCreateModelImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateModelInvocationJob

        /// <summary>
        /// Creates a batch inference job to invoke a model on multiple prompts. Format your data
        /// according to <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-data">Format
        /// your inference data</a> and upload it to an Amazon S3 bucket. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference.html">Process
        /// multiple prompts with batch inference</a>.
        /// 
        ///  
        /// <para>
        /// The response returns a <c>jobArn</c> that you can use to stop or get details about
        /// the job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelInvocationJob service method.</param>
        /// 
        /// <returns>The response from the CreateModelInvocationJob service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelInvocationJob">REST API Reference for CreateModelInvocationJob Operation</seealso>
        public virtual CreateModelInvocationJobResponse CreateModelInvocationJob(CreateModelInvocationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelInvocationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelInvocationJobResponseUnmarshaller.Instance;

            return Invoke<CreateModelInvocationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelInvocationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelInvocationJob operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelInvocationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelInvocationJob">REST API Reference for CreateModelInvocationJob Operation</seealso>
        public virtual IAsyncResult BeginCreateModelInvocationJob(CreateModelInvocationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelInvocationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelInvocationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelInvocationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelInvocationJob.</param>
        /// 
        /// <returns>Returns a  CreateModelInvocationJobResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelInvocationJob">REST API Reference for CreateModelInvocationJob Operation</seealso>
        public virtual CreateModelInvocationJobResponse EndCreateModelInvocationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelInvocationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePromptRouter

        /// <summary>
        /// Creates a prompt router that manages the routing of requests between multiple foundation
        /// models based on the routing criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePromptRouter service method.</param>
        /// 
        /// <returns>The response from the CreatePromptRouter service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreatePromptRouter">REST API Reference for CreatePromptRouter Operation</seealso>
        public virtual CreatePromptRouterResponse CreatePromptRouter(CreatePromptRouterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePromptRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePromptRouterResponseUnmarshaller.Instance;

            return Invoke<CreatePromptRouterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePromptRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePromptRouter operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePromptRouter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreatePromptRouter">REST API Reference for CreatePromptRouter Operation</seealso>
        public virtual IAsyncResult BeginCreatePromptRouter(CreatePromptRouterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePromptRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePromptRouterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePromptRouter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePromptRouter.</param>
        /// 
        /// <returns>Returns a  CreatePromptRouterResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreatePromptRouter">REST API Reference for CreatePromptRouter Operation</seealso>
        public virtual CreatePromptRouterResponse EndCreatePromptRouter(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePromptRouterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProvisionedModelThroughput

        /// <summary>
        /// Creates dedicated throughput for a base or custom model with the model units and for
        /// the duration that you specify. For pricing details, see <a href="http://aws.amazon.com/bedrock/pricing/">Amazon
        /// Bedrock Pricing</a>. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  DeleteAutomatedReasoningPolicy

        /// <summary>
        /// Deletes an Automated Reasoning policy or policy version. This operation is idempotent.
        /// If you delete a policy more than once, each call succeeds. Deleting a policy removes
        /// it permanently and cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomatedReasoningPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAutomatedReasoningPolicy service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicy">REST API Reference for DeleteAutomatedReasoningPolicy Operation</seealso>
        public virtual DeleteAutomatedReasoningPolicyResponse DeleteAutomatedReasoningPolicy(DeleteAutomatedReasoningPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomatedReasoningPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteAutomatedReasoningPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAutomatedReasoningPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomatedReasoningPolicy operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAutomatedReasoningPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicy">REST API Reference for DeleteAutomatedReasoningPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteAutomatedReasoningPolicy(DeleteAutomatedReasoningPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomatedReasoningPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAutomatedReasoningPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAutomatedReasoningPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteAutomatedReasoningPolicyResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicy">REST API Reference for DeleteAutomatedReasoningPolicy Operation</seealso>
        public virtual DeleteAutomatedReasoningPolicyResponse EndDeleteAutomatedReasoningPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAutomatedReasoningPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAutomatedReasoningPolicyBuildWorkflow

        /// <summary>
        /// Deletes an Automated Reasoning policy build workflow and its associated artifacts.
        /// This permanently removes the workflow history and any generated assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomatedReasoningPolicyBuildWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteAutomatedReasoningPolicyBuildWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicyBuildWorkflow">REST API Reference for DeleteAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual DeleteAutomatedReasoningPolicyBuildWorkflowResponse DeleteAutomatedReasoningPolicyBuildWorkflow(DeleteAutomatedReasoningPolicyBuildWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;

            return Invoke<DeleteAutomatedReasoningPolicyBuildWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAutomatedReasoningPolicyBuildWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomatedReasoningPolicyBuildWorkflow operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAutomatedReasoningPolicyBuildWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicyBuildWorkflow">REST API Reference for DeleteAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual IAsyncResult BeginDeleteAutomatedReasoningPolicyBuildWorkflow(DeleteAutomatedReasoningPolicyBuildWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAutomatedReasoningPolicyBuildWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAutomatedReasoningPolicyBuildWorkflow.</param>
        /// 
        /// <returns>Returns a  DeleteAutomatedReasoningPolicyBuildWorkflowResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicyBuildWorkflow">REST API Reference for DeleteAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual DeleteAutomatedReasoningPolicyBuildWorkflowResponse EndDeleteAutomatedReasoningPolicyBuildWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAutomatedReasoningPolicyBuildWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAutomatedReasoningPolicyTestCase

        /// <summary>
        /// Deletes an Automated Reasoning policy test. This operation is idempotent; if you delete
        /// a test more than once, each call succeeds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomatedReasoningPolicyTestCase service method.</param>
        /// 
        /// <returns>The response from the DeleteAutomatedReasoningPolicyTestCase service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicyTestCase">REST API Reference for DeleteAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual DeleteAutomatedReasoningPolicyTestCaseResponse DeleteAutomatedReasoningPolicyTestCase(DeleteAutomatedReasoningPolicyTestCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;

            return Invoke<DeleteAutomatedReasoningPolicyTestCaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAutomatedReasoningPolicyTestCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutomatedReasoningPolicyTestCase operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAutomatedReasoningPolicyTestCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicyTestCase">REST API Reference for DeleteAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual IAsyncResult BeginDeleteAutomatedReasoningPolicyTestCase(DeleteAutomatedReasoningPolicyTestCaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAutomatedReasoningPolicyTestCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAutomatedReasoningPolicyTestCase.</param>
        /// 
        /// <returns>Returns a  DeleteAutomatedReasoningPolicyTestCaseResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteAutomatedReasoningPolicyTestCase">REST API Reference for DeleteAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual DeleteAutomatedReasoningPolicyTestCaseResponse EndDeleteAutomatedReasoningPolicyTestCase(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAutomatedReasoningPolicyTestCaseResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCustomModel

        /// <summary>
        /// Deletes a custom model that you created earlier. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  DeleteCustomModelDeployment

        /// <summary>
        /// Deletes a custom model deployment. This operation stops the deployment and removes
        /// it from your account. After deletion, the deployment ARN can no longer be used for
        /// inference requests.
        /// 
        ///  
        /// <para>
        /// The following actions are related to the <c>DeleteCustomModelDeployment</c> operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateCustomModelDeployment.html">CreateCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModelDeployment.html">GetCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModelDeployments.html">ListCustomModelDeployments</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomModelDeployment service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomModelDeployment service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteCustomModelDeployment">REST API Reference for DeleteCustomModelDeployment Operation</seealso>
        public virtual DeleteCustomModelDeploymentResponse DeleteCustomModelDeployment(DeleteCustomModelDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomModelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomModelDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomModelDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomModelDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomModelDeployment operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomModelDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteCustomModelDeployment">REST API Reference for DeleteCustomModelDeployment Operation</seealso>
        public virtual IAsyncResult BeginDeleteCustomModelDeployment(DeleteCustomModelDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomModelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomModelDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomModelDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomModelDeployment.</param>
        /// 
        /// <returns>Returns a  DeleteCustomModelDeploymentResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteCustomModelDeployment">REST API Reference for DeleteCustomModelDeployment Operation</seealso>
        public virtual DeleteCustomModelDeploymentResponse EndDeleteCustomModelDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCustomModelDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnforcedGuardrailConfiguration

        /// <summary>
        /// Deletes the account-level enforced guardrail configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnforcedGuardrailConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteEnforcedGuardrailConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteEnforcedGuardrailConfiguration">REST API Reference for DeleteEnforcedGuardrailConfiguration Operation</seealso>
        public virtual DeleteEnforcedGuardrailConfigurationResponse DeleteEnforcedGuardrailConfiguration(DeleteEnforcedGuardrailConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnforcedGuardrailConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnforcedGuardrailConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteEnforcedGuardrailConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnforcedGuardrailConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnforcedGuardrailConfiguration operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnforcedGuardrailConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteEnforcedGuardrailConfiguration">REST API Reference for DeleteEnforcedGuardrailConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnforcedGuardrailConfiguration(DeleteEnforcedGuardrailConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnforcedGuardrailConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnforcedGuardrailConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnforcedGuardrailConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnforcedGuardrailConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteEnforcedGuardrailConfigurationResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteEnforcedGuardrailConfiguration">REST API Reference for DeleteEnforcedGuardrailConfiguration Operation</seealso>
        public virtual DeleteEnforcedGuardrailConfigurationResponse EndDeleteEnforcedGuardrailConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnforcedGuardrailConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFoundationModelAgreement

        /// <summary>
        /// Delete the model access agreement for the specified model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFoundationModelAgreement service method.</param>
        /// 
        /// <returns>The response from the DeleteFoundationModelAgreement service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteFoundationModelAgreement">REST API Reference for DeleteFoundationModelAgreement Operation</seealso>
        public virtual DeleteFoundationModelAgreementResponse DeleteFoundationModelAgreement(DeleteFoundationModelAgreementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFoundationModelAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFoundationModelAgreementResponseUnmarshaller.Instance;

            return Invoke<DeleteFoundationModelAgreementResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFoundationModelAgreement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFoundationModelAgreement operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFoundationModelAgreement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteFoundationModelAgreement">REST API Reference for DeleteFoundationModelAgreement Operation</seealso>
        public virtual IAsyncResult BeginDeleteFoundationModelAgreement(DeleteFoundationModelAgreementRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFoundationModelAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFoundationModelAgreementResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFoundationModelAgreement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFoundationModelAgreement.</param>
        /// 
        /// <returns>Returns a  DeleteFoundationModelAgreementResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteFoundationModelAgreement">REST API Reference for DeleteFoundationModelAgreement Operation</seealso>
        public virtual DeleteFoundationModelAgreementResponse EndDeleteFoundationModelAgreement(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFoundationModelAgreementResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGuardrail

        /// <summary>
        /// Deletes a guardrail.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// To delete a guardrail, only specify the ARN of the guardrail in the <c>guardrailIdentifier</c>
        /// field. If you delete a guardrail, all of its versions will be deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a version of a guardrail, specify the ARN of the guardrail in the <c>guardrailIdentifier</c>
        /// field and the version in the <c>guardrailVersion</c> field.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGuardrail service method.</param>
        /// 
        /// <returns>The response from the DeleteGuardrail service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteGuardrail">REST API Reference for DeleteGuardrail Operation</seealso>
        public virtual DeleteGuardrailResponse DeleteGuardrail(DeleteGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGuardrailResponseUnmarshaller.Instance;

            return Invoke<DeleteGuardrailResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGuardrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGuardrail operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGuardrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteGuardrail">REST API Reference for DeleteGuardrail Operation</seealso>
        public virtual IAsyncResult BeginDeleteGuardrail(DeleteGuardrailRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGuardrailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGuardrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGuardrail.</param>
        /// 
        /// <returns>Returns a  DeleteGuardrailResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteGuardrail">REST API Reference for DeleteGuardrail Operation</seealso>
        public virtual DeleteGuardrailResponse EndDeleteGuardrail(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGuardrailResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteImportedModel

        /// <summary>
        /// Deletes a custom model that you imported earlier. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportedModel service method.</param>
        /// 
        /// <returns>The response from the DeleteImportedModel service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteImportedModel">REST API Reference for DeleteImportedModel Operation</seealso>
        public virtual DeleteImportedModelResponse DeleteImportedModel(DeleteImportedModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImportedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportedModelResponseUnmarshaller.Instance;

            return Invoke<DeleteImportedModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImportedModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportedModel operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImportedModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteImportedModel">REST API Reference for DeleteImportedModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteImportedModel(DeleteImportedModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteImportedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportedModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImportedModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImportedModel.</param>
        /// 
        /// <returns>Returns a  DeleteImportedModelResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteImportedModel">REST API Reference for DeleteImportedModel Operation</seealso>
        public virtual DeleteImportedModelResponse EndDeleteImportedModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteImportedModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInferenceProfile

        /// <summary>
        /// Deletes an application inference profile. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
        /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
        /// Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInferenceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteInferenceProfile service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteInferenceProfile">REST API Reference for DeleteInferenceProfile Operation</seealso>
        public virtual DeleteInferenceProfileResponse DeleteInferenceProfile(DeleteInferenceProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInferenceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInferenceProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteInferenceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInferenceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInferenceProfile operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInferenceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteInferenceProfile">REST API Reference for DeleteInferenceProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteInferenceProfile(DeleteInferenceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInferenceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInferenceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInferenceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInferenceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteInferenceProfileResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteInferenceProfile">REST API Reference for DeleteInferenceProfile Operation</seealso>
        public virtual DeleteInferenceProfileResponse EndDeleteInferenceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInferenceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMarketplaceModelEndpoint

        /// <summary>
        /// Deletes an endpoint for a model from Amazon Bedrock Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMarketplaceModelEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteMarketplaceModelEndpoint">REST API Reference for DeleteMarketplaceModelEndpoint Operation</seealso>
        public virtual DeleteMarketplaceModelEndpointResponse DeleteMarketplaceModelEndpoint(DeleteMarketplaceModelEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteMarketplaceModelEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMarketplaceModelEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMarketplaceModelEndpoint operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMarketplaceModelEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteMarketplaceModelEndpoint">REST API Reference for DeleteMarketplaceModelEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteMarketplaceModelEndpoint(DeleteMarketplaceModelEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMarketplaceModelEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMarketplaceModelEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteMarketplaceModelEndpointResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteMarketplaceModelEndpoint">REST API Reference for DeleteMarketplaceModelEndpoint Operation</seealso>
        public virtual DeleteMarketplaceModelEndpointResponse EndDeleteMarketplaceModelEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMarketplaceModelEndpointResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  DeletePromptRouter

        /// <summary>
        /// Deletes a specified prompt router. This action cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePromptRouter service method.</param>
        /// 
        /// <returns>The response from the DeletePromptRouter service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeletePromptRouter">REST API Reference for DeletePromptRouter Operation</seealso>
        public virtual DeletePromptRouterResponse DeletePromptRouter(DeletePromptRouterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePromptRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePromptRouterResponseUnmarshaller.Instance;

            return Invoke<DeletePromptRouterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePromptRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePromptRouter operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePromptRouter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeletePromptRouter">REST API Reference for DeletePromptRouter Operation</seealso>
        public virtual IAsyncResult BeginDeletePromptRouter(DeletePromptRouterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePromptRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePromptRouterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePromptRouter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePromptRouter.</param>
        /// 
        /// <returns>Returns a  DeletePromptRouterResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeletePromptRouter">REST API Reference for DeletePromptRouter Operation</seealso>
        public virtual DeletePromptRouterResponse EndDeletePromptRouter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePromptRouterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProvisionedModelThroughput

        /// <summary>
        /// Deletes a Provisioned Throughput. You can't delete a Provisioned Throughput before
        /// the commitment term is over. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  DeregisterMarketplaceModelEndpoint

        /// <summary>
        /// Deregisters an endpoint for a model from Amazon Bedrock Marketplace. This operation
        /// removes the endpoint's association with Amazon Bedrock but does not delete the underlying
        /// Amazon SageMaker endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterMarketplaceModelEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeregisterMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeregisterMarketplaceModelEndpoint">REST API Reference for DeregisterMarketplaceModelEndpoint Operation</seealso>
        public virtual DeregisterMarketplaceModelEndpointResponse DeregisterMarketplaceModelEndpoint(DeregisterMarketplaceModelEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return Invoke<DeregisterMarketplaceModelEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterMarketplaceModelEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterMarketplaceModelEndpoint operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterMarketplaceModelEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeregisterMarketplaceModelEndpoint">REST API Reference for DeregisterMarketplaceModelEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeregisterMarketplaceModelEndpoint(DeregisterMarketplaceModelEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterMarketplaceModelEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterMarketplaceModelEndpoint.</param>
        /// 
        /// <returns>Returns a  DeregisterMarketplaceModelEndpointResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeregisterMarketplaceModelEndpoint">REST API Reference for DeregisterMarketplaceModelEndpoint Operation</seealso>
        public virtual DeregisterMarketplaceModelEndpointResponse EndDeregisterMarketplaceModelEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterMarketplaceModelEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  ExportAutomatedReasoningPolicyVersion

        /// <summary>
        /// Exports the policy definition for an Automated Reasoning policy version. Returns the
        /// complete policy definition including rules, variables, and custom variable types in
        /// a structured format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportAutomatedReasoningPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the ExportAutomatedReasoningPolicyVersion service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ExportAutomatedReasoningPolicyVersion">REST API Reference for ExportAutomatedReasoningPolicyVersion Operation</seealso>
        public virtual ExportAutomatedReasoningPolicyVersionResponse ExportAutomatedReasoningPolicyVersion(ExportAutomatedReasoningPolicyVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportAutomatedReasoningPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportAutomatedReasoningPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<ExportAutomatedReasoningPolicyVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportAutomatedReasoningPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportAutomatedReasoningPolicyVersion operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportAutomatedReasoningPolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ExportAutomatedReasoningPolicyVersion">REST API Reference for ExportAutomatedReasoningPolicyVersion Operation</seealso>
        public virtual IAsyncResult BeginExportAutomatedReasoningPolicyVersion(ExportAutomatedReasoningPolicyVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportAutomatedReasoningPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportAutomatedReasoningPolicyVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExportAutomatedReasoningPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportAutomatedReasoningPolicyVersion.</param>
        /// 
        /// <returns>Returns a  ExportAutomatedReasoningPolicyVersionResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ExportAutomatedReasoningPolicyVersion">REST API Reference for ExportAutomatedReasoningPolicyVersion Operation</seealso>
        public virtual ExportAutomatedReasoningPolicyVersionResponse EndExportAutomatedReasoningPolicyVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<ExportAutomatedReasoningPolicyVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAutomatedReasoningPolicy

        /// <summary>
        /// Retrieves details about an Automated Reasoning policy or policy version. Returns information
        /// including the policy definition, metadata, and timestamps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicy service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicy service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicy">REST API Reference for GetAutomatedReasoningPolicy Operation</seealso>
        public virtual GetAutomatedReasoningPolicyResponse GetAutomatedReasoningPolicy(GetAutomatedReasoningPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedReasoningPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutomatedReasoningPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicy operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutomatedReasoningPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicy">REST API Reference for GetAutomatedReasoningPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetAutomatedReasoningPolicy(GetAutomatedReasoningPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutomatedReasoningPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutomatedReasoningPolicy.</param>
        /// 
        /// <returns>Returns a  GetAutomatedReasoningPolicyResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicy">REST API Reference for GetAutomatedReasoningPolicy Operation</seealso>
        public virtual GetAutomatedReasoningPolicyResponse EndGetAutomatedReasoningPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAutomatedReasoningPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAutomatedReasoningPolicyAnnotations

        /// <summary>
        /// Retrieves the current annotations for an Automated Reasoning policy build workflow.
        /// Annotations contain corrections to the rules, variables and types to be applied to
        /// the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyAnnotations service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyAnnotations service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyAnnotations">REST API Reference for GetAutomatedReasoningPolicyAnnotations Operation</seealso>
        public virtual GetAutomatedReasoningPolicyAnnotationsResponse GetAutomatedReasoningPolicyAnnotations(GetAutomatedReasoningPolicyAnnotationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyAnnotationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyAnnotationsResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedReasoningPolicyAnnotationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutomatedReasoningPolicyAnnotations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyAnnotations operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutomatedReasoningPolicyAnnotations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyAnnotations">REST API Reference for GetAutomatedReasoningPolicyAnnotations Operation</seealso>
        public virtual IAsyncResult BeginGetAutomatedReasoningPolicyAnnotations(GetAutomatedReasoningPolicyAnnotationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyAnnotationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyAnnotationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutomatedReasoningPolicyAnnotations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutomatedReasoningPolicyAnnotations.</param>
        /// 
        /// <returns>Returns a  GetAutomatedReasoningPolicyAnnotationsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyAnnotations">REST API Reference for GetAutomatedReasoningPolicyAnnotations Operation</seealso>
        public virtual GetAutomatedReasoningPolicyAnnotationsResponse EndGetAutomatedReasoningPolicyAnnotations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAutomatedReasoningPolicyAnnotationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAutomatedReasoningPolicyBuildWorkflow

        /// <summary>
        /// Retrieves detailed information about an Automated Reasoning policy build workflow,
        /// including its status, configuration, and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyBuildWorkflow service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyBuildWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyBuildWorkflow">REST API Reference for GetAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual GetAutomatedReasoningPolicyBuildWorkflowResponse GetAutomatedReasoningPolicyBuildWorkflow(GetAutomatedReasoningPolicyBuildWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedReasoningPolicyBuildWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutomatedReasoningPolicyBuildWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyBuildWorkflow operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutomatedReasoningPolicyBuildWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyBuildWorkflow">REST API Reference for GetAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual IAsyncResult BeginGetAutomatedReasoningPolicyBuildWorkflow(GetAutomatedReasoningPolicyBuildWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutomatedReasoningPolicyBuildWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutomatedReasoningPolicyBuildWorkflow.</param>
        /// 
        /// <returns>Returns a  GetAutomatedReasoningPolicyBuildWorkflowResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyBuildWorkflow">REST API Reference for GetAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual GetAutomatedReasoningPolicyBuildWorkflowResponse EndGetAutomatedReasoningPolicyBuildWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAutomatedReasoningPolicyBuildWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAutomatedReasoningPolicyBuildWorkflowResultAssets

        /// <summary>
        /// Retrieves the resulting assets from a completed Automated Reasoning policy build workflow,
        /// including build logs, quality reports, and generated policy artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyBuildWorkflowResultAssets service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyBuildWorkflowResultAssets service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyBuildWorkflowResultAssets">REST API Reference for GetAutomatedReasoningPolicyBuildWorkflowResultAssets Operation</seealso>
        public virtual GetAutomatedReasoningPolicyBuildWorkflowResultAssetsResponse GetAutomatedReasoningPolicyBuildWorkflowResultAssets(GetAutomatedReasoningPolicyBuildWorkflowResultAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyBuildWorkflowResultAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyBuildWorkflowResultAssetsResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedReasoningPolicyBuildWorkflowResultAssetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutomatedReasoningPolicyBuildWorkflowResultAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyBuildWorkflowResultAssets operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutomatedReasoningPolicyBuildWorkflowResultAssets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyBuildWorkflowResultAssets">REST API Reference for GetAutomatedReasoningPolicyBuildWorkflowResultAssets Operation</seealso>
        public virtual IAsyncResult BeginGetAutomatedReasoningPolicyBuildWorkflowResultAssets(GetAutomatedReasoningPolicyBuildWorkflowResultAssetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyBuildWorkflowResultAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyBuildWorkflowResultAssetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutomatedReasoningPolicyBuildWorkflowResultAssets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutomatedReasoningPolicyBuildWorkflowResultAssets.</param>
        /// 
        /// <returns>Returns a  GetAutomatedReasoningPolicyBuildWorkflowResultAssetsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyBuildWorkflowResultAssets">REST API Reference for GetAutomatedReasoningPolicyBuildWorkflowResultAssets Operation</seealso>
        public virtual GetAutomatedReasoningPolicyBuildWorkflowResultAssetsResponse EndGetAutomatedReasoningPolicyBuildWorkflowResultAssets(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAutomatedReasoningPolicyBuildWorkflowResultAssetsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAutomatedReasoningPolicyNextScenario

        /// <summary>
        /// Retrieves the next test scenario for validating an Automated Reasoning policy. This
        /// is used during the interactive policy refinement process to test policy behavior.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyNextScenario service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyNextScenario service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyNextScenario">REST API Reference for GetAutomatedReasoningPolicyNextScenario Operation</seealso>
        public virtual GetAutomatedReasoningPolicyNextScenarioResponse GetAutomatedReasoningPolicyNextScenario(GetAutomatedReasoningPolicyNextScenarioRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyNextScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyNextScenarioResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedReasoningPolicyNextScenarioResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutomatedReasoningPolicyNextScenario operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyNextScenario operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutomatedReasoningPolicyNextScenario
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyNextScenario">REST API Reference for GetAutomatedReasoningPolicyNextScenario Operation</seealso>
        public virtual IAsyncResult BeginGetAutomatedReasoningPolicyNextScenario(GetAutomatedReasoningPolicyNextScenarioRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyNextScenarioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyNextScenarioResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutomatedReasoningPolicyNextScenario operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutomatedReasoningPolicyNextScenario.</param>
        /// 
        /// <returns>Returns a  GetAutomatedReasoningPolicyNextScenarioResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyNextScenario">REST API Reference for GetAutomatedReasoningPolicyNextScenario Operation</seealso>
        public virtual GetAutomatedReasoningPolicyNextScenarioResponse EndGetAutomatedReasoningPolicyNextScenario(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAutomatedReasoningPolicyNextScenarioResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAutomatedReasoningPolicyTestCase

        /// <summary>
        /// Retrieves details about a specific Automated Reasoning policy test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyTestCase service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyTestCase service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyTestCase">REST API Reference for GetAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual GetAutomatedReasoningPolicyTestCaseResponse GetAutomatedReasoningPolicyTestCase(GetAutomatedReasoningPolicyTestCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedReasoningPolicyTestCaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutomatedReasoningPolicyTestCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyTestCase operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutomatedReasoningPolicyTestCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyTestCase">REST API Reference for GetAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual IAsyncResult BeginGetAutomatedReasoningPolicyTestCase(GetAutomatedReasoningPolicyTestCaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutomatedReasoningPolicyTestCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutomatedReasoningPolicyTestCase.</param>
        /// 
        /// <returns>Returns a  GetAutomatedReasoningPolicyTestCaseResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyTestCase">REST API Reference for GetAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual GetAutomatedReasoningPolicyTestCaseResponse EndGetAutomatedReasoningPolicyTestCase(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAutomatedReasoningPolicyTestCaseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAutomatedReasoningPolicyTestResult

        /// <summary>
        /// Retrieves the test result for a specific Automated Reasoning policy test. Returns
        /// detailed validation findings and execution status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyTestResult service method.</param>
        /// 
        /// <returns>The response from the GetAutomatedReasoningPolicyTestResult service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyTestResult">REST API Reference for GetAutomatedReasoningPolicyTestResult Operation</seealso>
        public virtual GetAutomatedReasoningPolicyTestResultResponse GetAutomatedReasoningPolicyTestResult(GetAutomatedReasoningPolicyTestResultRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyTestResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyTestResultResponseUnmarshaller.Instance;

            return Invoke<GetAutomatedReasoningPolicyTestResultResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutomatedReasoningPolicyTestResult operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutomatedReasoningPolicyTestResult operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutomatedReasoningPolicyTestResult
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyTestResult">REST API Reference for GetAutomatedReasoningPolicyTestResult Operation</seealso>
        public virtual IAsyncResult BeginGetAutomatedReasoningPolicyTestResult(GetAutomatedReasoningPolicyTestResultRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAutomatedReasoningPolicyTestResultRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutomatedReasoningPolicyTestResultResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutomatedReasoningPolicyTestResult operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutomatedReasoningPolicyTestResult.</param>
        /// 
        /// <returns>Returns a  GetAutomatedReasoningPolicyTestResultResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetAutomatedReasoningPolicyTestResult">REST API Reference for GetAutomatedReasoningPolicyTestResult Operation</seealso>
        public virtual GetAutomatedReasoningPolicyTestResultResponse EndGetAutomatedReasoningPolicyTestResult(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAutomatedReasoningPolicyTestResultResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCustomModel

        /// <summary>
        /// Get the properties associated with a Amazon Bedrock custom model that you have created.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  GetCustomModelDeployment

        /// <summary>
        /// Retrieves information about a custom model deployment, including its status, configuration,
        /// and metadata. Use this operation to monitor the deployment status and retrieve details
        /// needed for inference requests.
        /// 
        ///  
        /// <para>
        /// The following actions are related to the <c>GetCustomModelDeployment</c> operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateCustomModelDeployment.html">CreateCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_ListCustomModelDeployments.html">ListCustomModelDeployments</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModelDeployment.html">DeleteCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomModelDeployment service method.</param>
        /// 
        /// <returns>The response from the GetCustomModelDeployment service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetCustomModelDeployment">REST API Reference for GetCustomModelDeployment Operation</seealso>
        public virtual GetCustomModelDeploymentResponse GetCustomModelDeployment(GetCustomModelDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCustomModelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomModelDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetCustomModelDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCustomModelDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCustomModelDeployment operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCustomModelDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetCustomModelDeployment">REST API Reference for GetCustomModelDeployment Operation</seealso>
        public virtual IAsyncResult BeginGetCustomModelDeployment(GetCustomModelDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCustomModelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomModelDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCustomModelDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCustomModelDeployment.</param>
        /// 
        /// <returns>Returns a  GetCustomModelDeploymentResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetCustomModelDeployment">REST API Reference for GetCustomModelDeployment Operation</seealso>
        public virtual GetCustomModelDeploymentResponse EndGetCustomModelDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCustomModelDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEvaluationJob

        /// <summary>
        /// Gets information about an evaluation job, such as the status of the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvaluationJob service method.</param>
        /// 
        /// <returns>The response from the GetEvaluationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetEvaluationJob">REST API Reference for GetEvaluationJob Operation</seealso>
        public virtual GetEvaluationJobResponse GetEvaluationJob(GetEvaluationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvaluationJobResponseUnmarshaller.Instance;

            return Invoke<GetEvaluationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvaluationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvaluationJob operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvaluationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetEvaluationJob">REST API Reference for GetEvaluationJob Operation</seealso>
        public virtual IAsyncResult BeginGetEvaluationJob(GetEvaluationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEvaluationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvaluationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvaluationJob.</param>
        /// 
        /// <returns>Returns a  GetEvaluationJobResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetEvaluationJob">REST API Reference for GetEvaluationJob Operation</seealso>
        public virtual GetEvaluationJobResponse EndGetEvaluationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEvaluationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFoundationModel

        /// <summary>
        /// Get details about a Amazon Bedrock foundation model.
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  GetFoundationModelAvailability

        /// <summary>
        /// Get information about the Foundation model availability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFoundationModelAvailability service method.</param>
        /// 
        /// <returns>The response from the GetFoundationModelAvailability service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetFoundationModelAvailability">REST API Reference for GetFoundationModelAvailability Operation</seealso>
        public virtual GetFoundationModelAvailabilityResponse GetFoundationModelAvailability(GetFoundationModelAvailabilityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFoundationModelAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFoundationModelAvailabilityResponseUnmarshaller.Instance;

            return Invoke<GetFoundationModelAvailabilityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFoundationModelAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFoundationModelAvailability operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFoundationModelAvailability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetFoundationModelAvailability">REST API Reference for GetFoundationModelAvailability Operation</seealso>
        public virtual IAsyncResult BeginGetFoundationModelAvailability(GetFoundationModelAvailabilityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFoundationModelAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFoundationModelAvailabilityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFoundationModelAvailability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFoundationModelAvailability.</param>
        /// 
        /// <returns>Returns a  GetFoundationModelAvailabilityResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetFoundationModelAvailability">REST API Reference for GetFoundationModelAvailability Operation</seealso>
        public virtual GetFoundationModelAvailabilityResponse EndGetFoundationModelAvailability(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFoundationModelAvailabilityResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGuardrail

        /// <summary>
        /// Gets details about a guardrail. If you don't specify a version, the response returns
        /// details for the <c>DRAFT</c> version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGuardrail service method.</param>
        /// 
        /// <returns>The response from the GetGuardrail service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetGuardrail">REST API Reference for GetGuardrail Operation</seealso>
        public virtual GetGuardrailResponse GetGuardrail(GetGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGuardrailResponseUnmarshaller.Instance;

            return Invoke<GetGuardrailResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGuardrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGuardrail operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGuardrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetGuardrail">REST API Reference for GetGuardrail Operation</seealso>
        public virtual IAsyncResult BeginGetGuardrail(GetGuardrailRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGuardrailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGuardrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGuardrail.</param>
        /// 
        /// <returns>Returns a  GetGuardrailResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetGuardrail">REST API Reference for GetGuardrail Operation</seealso>
        public virtual GetGuardrailResponse EndGetGuardrail(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGuardrailResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImportedModel

        /// <summary>
        /// Gets properties associated with a customized model you imported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportedModel service method.</param>
        /// 
        /// <returns>The response from the GetImportedModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetImportedModel">REST API Reference for GetImportedModel Operation</seealso>
        public virtual GetImportedModelResponse GetImportedModel(GetImportedModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportedModelResponseUnmarshaller.Instance;

            return Invoke<GetImportedModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportedModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportedModel operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportedModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetImportedModel">REST API Reference for GetImportedModel Operation</seealso>
        public virtual IAsyncResult BeginGetImportedModel(GetImportedModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportedModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportedModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportedModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportedModel.</param>
        /// 
        /// <returns>Returns a  GetImportedModelResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetImportedModel">REST API Reference for GetImportedModel Operation</seealso>
        public virtual GetImportedModelResponse EndGetImportedModel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImportedModelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInferenceProfile

        /// <summary>
        /// Gets information about an inference profile. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
        /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
        /// Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInferenceProfile service method.</param>
        /// 
        /// <returns>The response from the GetInferenceProfile service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetInferenceProfile">REST API Reference for GetInferenceProfile Operation</seealso>
        public virtual GetInferenceProfileResponse GetInferenceProfile(GetInferenceProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInferenceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInferenceProfileResponseUnmarshaller.Instance;

            return Invoke<GetInferenceProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInferenceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInferenceProfile operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInferenceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetInferenceProfile">REST API Reference for GetInferenceProfile Operation</seealso>
        public virtual IAsyncResult BeginGetInferenceProfile(GetInferenceProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInferenceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInferenceProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInferenceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInferenceProfile.</param>
        /// 
        /// <returns>Returns a  GetInferenceProfileResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetInferenceProfile">REST API Reference for GetInferenceProfile Operation</seealso>
        public virtual GetInferenceProfileResponse EndGetInferenceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInferenceProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMarketplaceModelEndpoint

        /// <summary>
        /// Retrieves details about a specific endpoint for a model from Amazon Bedrock Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMarketplaceModelEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetMarketplaceModelEndpoint">REST API Reference for GetMarketplaceModelEndpoint Operation</seealso>
        public virtual GetMarketplaceModelEndpointResponse GetMarketplaceModelEndpoint(GetMarketplaceModelEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return Invoke<GetMarketplaceModelEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMarketplaceModelEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMarketplaceModelEndpoint operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMarketplaceModelEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetMarketplaceModelEndpoint">REST API Reference for GetMarketplaceModelEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetMarketplaceModelEndpoint(GetMarketplaceModelEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMarketplaceModelEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMarketplaceModelEndpoint.</param>
        /// 
        /// <returns>Returns a  GetMarketplaceModelEndpointResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetMarketplaceModelEndpoint">REST API Reference for GetMarketplaceModelEndpoint Operation</seealso>
        public virtual GetMarketplaceModelEndpointResponse EndGetMarketplaceModelEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMarketplaceModelEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModelCopyJob

        /// <summary>
        /// Retrieves information about a model copy job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/copy-model.html">Copy
        /// models to be used in other regions</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelCopyJob service method.</param>
        /// 
        /// <returns>The response from the GetModelCopyJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelCopyJob">REST API Reference for GetModelCopyJob Operation</seealso>
        public virtual GetModelCopyJobResponse GetModelCopyJob(GetModelCopyJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelCopyJobResponseUnmarshaller.Instance;

            return Invoke<GetModelCopyJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetModelCopyJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelCopyJob operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelCopyJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelCopyJob">REST API Reference for GetModelCopyJob Operation</seealso>
        public virtual IAsyncResult BeginGetModelCopyJob(GetModelCopyJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelCopyJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelCopyJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelCopyJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelCopyJob.</param>
        /// 
        /// <returns>Returns a  GetModelCopyJobResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelCopyJob">REST API Reference for GetModelCopyJob Operation</seealso>
        public virtual GetModelCopyJobResponse EndGetModelCopyJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelCopyJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModelCustomizationJob

        /// <summary>
        /// Retrieves the properties associated with a model-customization job, including the
        /// status of the job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  GetModelImportJob

        /// <summary>
        /// Retrieves the properties associated with import model job, including the status of
        /// the job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelImportJob service method.</param>
        /// 
        /// <returns>The response from the GetModelImportJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelImportJob">REST API Reference for GetModelImportJob Operation</seealso>
        public virtual GetModelImportJobResponse GetModelImportJob(GetModelImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelImportJobResponseUnmarshaller.Instance;

            return Invoke<GetModelImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetModelImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelImportJob operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelImportJob">REST API Reference for GetModelImportJob Operation</seealso>
        public virtual IAsyncResult BeginGetModelImportJob(GetModelImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelImportJob.</param>
        /// 
        /// <returns>Returns a  GetModelImportJobResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelImportJob">REST API Reference for GetModelImportJob Operation</seealso>
        public virtual GetModelImportJobResponse EndGetModelImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModelInvocationJob

        /// <summary>
        /// Gets details about a batch inference job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-monitor">Monitor
        /// batch inference jobs</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelInvocationJob service method.</param>
        /// 
        /// <returns>The response from the GetModelInvocationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelInvocationJob">REST API Reference for GetModelInvocationJob Operation</seealso>
        public virtual GetModelInvocationJobResponse GetModelInvocationJob(GetModelInvocationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelInvocationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelInvocationJobResponseUnmarshaller.Instance;

            return Invoke<GetModelInvocationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetModelInvocationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelInvocationJob operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelInvocationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelInvocationJob">REST API Reference for GetModelInvocationJob Operation</seealso>
        public virtual IAsyncResult BeginGetModelInvocationJob(GetModelInvocationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelInvocationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelInvocationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelInvocationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelInvocationJob.</param>
        /// 
        /// <returns>Returns a  GetModelInvocationJobResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelInvocationJob">REST API Reference for GetModelInvocationJob Operation</seealso>
        public virtual GetModelInvocationJobResponse EndGetModelInvocationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelInvocationJobResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  GetPromptRouter

        /// <summary>
        /// Retrieves details about a prompt router.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPromptRouter service method.</param>
        /// 
        /// <returns>The response from the GetPromptRouter service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetPromptRouter">REST API Reference for GetPromptRouter Operation</seealso>
        public virtual GetPromptRouterResponse GetPromptRouter(GetPromptRouterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPromptRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPromptRouterResponseUnmarshaller.Instance;

            return Invoke<GetPromptRouterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPromptRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPromptRouter operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPromptRouter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetPromptRouter">REST API Reference for GetPromptRouter Operation</seealso>
        public virtual IAsyncResult BeginGetPromptRouter(GetPromptRouterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPromptRouterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPromptRouterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPromptRouter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPromptRouter.</param>
        /// 
        /// <returns>Returns a  GetPromptRouterResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetPromptRouter">REST API Reference for GetPromptRouter Operation</seealso>
        public virtual GetPromptRouterResponse EndGetPromptRouter(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPromptRouterResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProvisionedModelThroughput

        /// <summary>
        /// Returns details for a Provisioned Throughput. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  GetUseCaseForModelAccess

        /// <summary>
        /// Get usecase for model access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUseCaseForModelAccess service method.</param>
        /// 
        /// <returns>The response from the GetUseCaseForModelAccess service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetUseCaseForModelAccess">REST API Reference for GetUseCaseForModelAccess Operation</seealso>
        public virtual GetUseCaseForModelAccessResponse GetUseCaseForModelAccess(GetUseCaseForModelAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUseCaseForModelAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUseCaseForModelAccessResponseUnmarshaller.Instance;

            return Invoke<GetUseCaseForModelAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUseCaseForModelAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUseCaseForModelAccess operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUseCaseForModelAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetUseCaseForModelAccess">REST API Reference for GetUseCaseForModelAccess Operation</seealso>
        public virtual IAsyncResult BeginGetUseCaseForModelAccess(GetUseCaseForModelAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUseCaseForModelAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUseCaseForModelAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUseCaseForModelAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUseCaseForModelAccess.</param>
        /// 
        /// <returns>Returns a  GetUseCaseForModelAccessResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetUseCaseForModelAccess">REST API Reference for GetUseCaseForModelAccess Operation</seealso>
        public virtual GetUseCaseForModelAccessResponse EndGetUseCaseForModelAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUseCaseForModelAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAutomatedReasoningPolicies

        /// <summary>
        /// Lists all Automated Reasoning policies in your account, with optional filtering by
        /// policy ARN. This helps you manage and discover existing policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAutomatedReasoningPolicies service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicies">REST API Reference for ListAutomatedReasoningPolicies Operation</seealso>
        public virtual ListAutomatedReasoningPoliciesResponse ListAutomatedReasoningPolicies(ListAutomatedReasoningPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAutomatedReasoningPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutomatedReasoningPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicies operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutomatedReasoningPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicies">REST API Reference for ListAutomatedReasoningPolicies Operation</seealso>
        public virtual IAsyncResult BeginListAutomatedReasoningPolicies(ListAutomatedReasoningPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutomatedReasoningPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutomatedReasoningPolicies.</param>
        /// 
        /// <returns>Returns a  ListAutomatedReasoningPoliciesResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicies">REST API Reference for ListAutomatedReasoningPolicies Operation</seealso>
        public virtual ListAutomatedReasoningPoliciesResponse EndListAutomatedReasoningPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAutomatedReasoningPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAutomatedReasoningPolicyBuildWorkflows

        /// <summary>
        /// Lists all build workflows for an Automated Reasoning policy, showing the history of
        /// policy creation and modification attempts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicyBuildWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListAutomatedReasoningPolicyBuildWorkflows service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyBuildWorkflows">REST API Reference for ListAutomatedReasoningPolicyBuildWorkflows Operation</seealso>
        public virtual ListAutomatedReasoningPolicyBuildWorkflowsResponse ListAutomatedReasoningPolicyBuildWorkflows(ListAutomatedReasoningPolicyBuildWorkflowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPolicyBuildWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPolicyBuildWorkflowsResponseUnmarshaller.Instance;

            return Invoke<ListAutomatedReasoningPolicyBuildWorkflowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutomatedReasoningPolicyBuildWorkflows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicyBuildWorkflows operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutomatedReasoningPolicyBuildWorkflows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyBuildWorkflows">REST API Reference for ListAutomatedReasoningPolicyBuildWorkflows Operation</seealso>
        public virtual IAsyncResult BeginListAutomatedReasoningPolicyBuildWorkflows(ListAutomatedReasoningPolicyBuildWorkflowsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPolicyBuildWorkflowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPolicyBuildWorkflowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutomatedReasoningPolicyBuildWorkflows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutomatedReasoningPolicyBuildWorkflows.</param>
        /// 
        /// <returns>Returns a  ListAutomatedReasoningPolicyBuildWorkflowsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyBuildWorkflows">REST API Reference for ListAutomatedReasoningPolicyBuildWorkflows Operation</seealso>
        public virtual ListAutomatedReasoningPolicyBuildWorkflowsResponse EndListAutomatedReasoningPolicyBuildWorkflows(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAutomatedReasoningPolicyBuildWorkflowsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAutomatedReasoningPolicyTestCases

        /// <summary>
        /// Lists tests for an Automated Reasoning policy. We recommend using pagination to ensure
        /// that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicyTestCases service method.</param>
        /// 
        /// <returns>The response from the ListAutomatedReasoningPolicyTestCases service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyTestCases">REST API Reference for ListAutomatedReasoningPolicyTestCases Operation</seealso>
        public virtual ListAutomatedReasoningPolicyTestCasesResponse ListAutomatedReasoningPolicyTestCases(ListAutomatedReasoningPolicyTestCasesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPolicyTestCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPolicyTestCasesResponseUnmarshaller.Instance;

            return Invoke<ListAutomatedReasoningPolicyTestCasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutomatedReasoningPolicyTestCases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicyTestCases operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutomatedReasoningPolicyTestCases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyTestCases">REST API Reference for ListAutomatedReasoningPolicyTestCases Operation</seealso>
        public virtual IAsyncResult BeginListAutomatedReasoningPolicyTestCases(ListAutomatedReasoningPolicyTestCasesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPolicyTestCasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPolicyTestCasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutomatedReasoningPolicyTestCases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutomatedReasoningPolicyTestCases.</param>
        /// 
        /// <returns>Returns a  ListAutomatedReasoningPolicyTestCasesResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyTestCases">REST API Reference for ListAutomatedReasoningPolicyTestCases Operation</seealso>
        public virtual ListAutomatedReasoningPolicyTestCasesResponse EndListAutomatedReasoningPolicyTestCases(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAutomatedReasoningPolicyTestCasesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAutomatedReasoningPolicyTestResults

        /// <summary>
        /// Lists test results for an Automated Reasoning policy, showing how the policy performed
        /// against various test scenarios and validation checks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicyTestResults service method.</param>
        /// 
        /// <returns>The response from the ListAutomatedReasoningPolicyTestResults service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyTestResults">REST API Reference for ListAutomatedReasoningPolicyTestResults Operation</seealso>
        public virtual ListAutomatedReasoningPolicyTestResultsResponse ListAutomatedReasoningPolicyTestResults(ListAutomatedReasoningPolicyTestResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPolicyTestResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPolicyTestResultsResponseUnmarshaller.Instance;

            return Invoke<ListAutomatedReasoningPolicyTestResultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAutomatedReasoningPolicyTestResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAutomatedReasoningPolicyTestResults operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAutomatedReasoningPolicyTestResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyTestResults">REST API Reference for ListAutomatedReasoningPolicyTestResults Operation</seealso>
        public virtual IAsyncResult BeginListAutomatedReasoningPolicyTestResults(ListAutomatedReasoningPolicyTestResultsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutomatedReasoningPolicyTestResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutomatedReasoningPolicyTestResultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAutomatedReasoningPolicyTestResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAutomatedReasoningPolicyTestResults.</param>
        /// 
        /// <returns>Returns a  ListAutomatedReasoningPolicyTestResultsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListAutomatedReasoningPolicyTestResults">REST API Reference for ListAutomatedReasoningPolicyTestResults Operation</seealso>
        public virtual ListAutomatedReasoningPolicyTestResultsResponse EndListAutomatedReasoningPolicyTestResults(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAutomatedReasoningPolicyTestResultsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCustomModelDeployments

        /// <summary>
        /// Lists custom model deployments in your account. You can filter the results by creation
        /// time, name, status, and associated model. Use this operation to manage and monitor
        /// your custom model deployments.
        /// 
        ///  
        /// <para>
        /// We recommend using pagination to ensure that the operation returns quickly and successfully.
        /// </para>
        ///  
        /// <para>
        /// The following actions are related to the <c>ListCustomModelDeployments</c> operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateCustomModelDeployment.html">CreateCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GetCustomModelDeployment.html">GetCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_DeleteCustomModelDeployment.html">DeleteCustomModelDeployment</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomModelDeployments service method.</param>
        /// 
        /// <returns>The response from the ListCustomModelDeployments service method, as returned by Bedrock.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListCustomModelDeployments">REST API Reference for ListCustomModelDeployments Operation</seealso>
        public virtual ListCustomModelDeploymentsResponse ListCustomModelDeployments(ListCustomModelDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomModelDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomModelDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListCustomModelDeploymentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomModelDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomModelDeployments operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomModelDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListCustomModelDeployments">REST API Reference for ListCustomModelDeployments Operation</seealso>
        public virtual IAsyncResult BeginListCustomModelDeployments(ListCustomModelDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomModelDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomModelDeploymentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomModelDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomModelDeployments.</param>
        /// 
        /// <returns>Returns a  ListCustomModelDeploymentsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListCustomModelDeployments">REST API Reference for ListCustomModelDeployments Operation</seealso>
        public virtual ListCustomModelDeploymentsResponse EndListCustomModelDeployments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCustomModelDeploymentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCustomModels

        /// <summary>
        /// Returns a list of the custom models that you have created with the <c>CreateModelCustomizationJob</c>
        /// operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  ListEnforcedGuardrailsConfiguration

        /// <summary>
        /// Lists the account-level enforced guardrail configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnforcedGuardrailsConfiguration service method.</param>
        /// 
        /// <returns>The response from the ListEnforcedGuardrailsConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListEnforcedGuardrailsConfiguration">REST API Reference for ListEnforcedGuardrailsConfiguration Operation</seealso>
        public virtual ListEnforcedGuardrailsConfigurationResponse ListEnforcedGuardrailsConfiguration(ListEnforcedGuardrailsConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnforcedGuardrailsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnforcedGuardrailsConfigurationResponseUnmarshaller.Instance;

            return Invoke<ListEnforcedGuardrailsConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnforcedGuardrailsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnforcedGuardrailsConfiguration operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnforcedGuardrailsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListEnforcedGuardrailsConfiguration">REST API Reference for ListEnforcedGuardrailsConfiguration Operation</seealso>
        public virtual IAsyncResult BeginListEnforcedGuardrailsConfiguration(ListEnforcedGuardrailsConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnforcedGuardrailsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnforcedGuardrailsConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnforcedGuardrailsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnforcedGuardrailsConfiguration.</param>
        /// 
        /// <returns>Returns a  ListEnforcedGuardrailsConfigurationResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListEnforcedGuardrailsConfiguration">REST API Reference for ListEnforcedGuardrailsConfiguration Operation</seealso>
        public virtual ListEnforcedGuardrailsConfigurationResponse EndListEnforcedGuardrailsConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnforcedGuardrailsConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEvaluationJobs

        /// <summary>
        /// Lists all existing evaluation jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEvaluationJobs service method.</param>
        /// 
        /// <returns>The response from the ListEvaluationJobs service method, as returned by Bedrock.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListEvaluationJobs">REST API Reference for ListEvaluationJobs Operation</seealso>
        public virtual ListEvaluationJobsResponse ListEvaluationJobs(ListEvaluationJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEvaluationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEvaluationJobsResponseUnmarshaller.Instance;

            return Invoke<ListEvaluationJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEvaluationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEvaluationJobs operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEvaluationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListEvaluationJobs">REST API Reference for ListEvaluationJobs Operation</seealso>
        public virtual IAsyncResult BeginListEvaluationJobs(ListEvaluationJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEvaluationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEvaluationJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEvaluationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEvaluationJobs.</param>
        /// 
        /// <returns>Returns a  ListEvaluationJobsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListEvaluationJobs">REST API Reference for ListEvaluationJobs Operation</seealso>
        public virtual ListEvaluationJobsResponse EndListEvaluationJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEvaluationJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFoundationModelAgreementOffers

        /// <summary>
        /// Get the offers associated with the specified model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFoundationModelAgreementOffers service method.</param>
        /// 
        /// <returns>The response from the ListFoundationModelAgreementOffers service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListFoundationModelAgreementOffers">REST API Reference for ListFoundationModelAgreementOffers Operation</seealso>
        public virtual ListFoundationModelAgreementOffersResponse ListFoundationModelAgreementOffers(ListFoundationModelAgreementOffersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFoundationModelAgreementOffersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFoundationModelAgreementOffersResponseUnmarshaller.Instance;

            return Invoke<ListFoundationModelAgreementOffersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFoundationModelAgreementOffers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFoundationModelAgreementOffers operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFoundationModelAgreementOffers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListFoundationModelAgreementOffers">REST API Reference for ListFoundationModelAgreementOffers Operation</seealso>
        public virtual IAsyncResult BeginListFoundationModelAgreementOffers(ListFoundationModelAgreementOffersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFoundationModelAgreementOffersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFoundationModelAgreementOffersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFoundationModelAgreementOffers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFoundationModelAgreementOffers.</param>
        /// 
        /// <returns>Returns a  ListFoundationModelAgreementOffersResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListFoundationModelAgreementOffers">REST API Reference for ListFoundationModelAgreementOffers Operation</seealso>
        public virtual ListFoundationModelAgreementOffersResponse EndListFoundationModelAgreementOffers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFoundationModelAgreementOffersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFoundationModels

        /// <summary>
        /// Lists Amazon Bedrock foundation models that you can use. You can filter the results
        /// with the request parameters. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/foundation-models.html">Foundation
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  ListGuardrails

        /// <summary>
        /// Lists details about all the guardrails in an account. To list the <c>DRAFT</c> version
        /// of all your guardrails, don't specify the <c>guardrailIdentifier</c> field. To list
        /// all versions of a guardrail, specify the ARN of the guardrail in the <c>guardrailIdentifier</c>
        /// field.
        /// 
        ///  
        /// <para>
        /// You can set the maximum number of results to return in a response in the <c>maxResults</c>
        /// field. If there are more results than the number you set, the response returns a <c>nextToken</c>
        /// that you can send in another <c>ListGuardrails</c> request to see the next batch of
        /// results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGuardrails service method.</param>
        /// 
        /// <returns>The response from the ListGuardrails service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListGuardrails">REST API Reference for ListGuardrails Operation</seealso>
        public virtual ListGuardrailsResponse ListGuardrails(ListGuardrailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGuardrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGuardrailsResponseUnmarshaller.Instance;

            return Invoke<ListGuardrailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGuardrails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGuardrails operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGuardrails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListGuardrails">REST API Reference for ListGuardrails Operation</seealso>
        public virtual IAsyncResult BeginListGuardrails(ListGuardrailsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGuardrailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGuardrailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGuardrails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGuardrails.</param>
        /// 
        /// <returns>Returns a  ListGuardrailsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListGuardrails">REST API Reference for ListGuardrails Operation</seealso>
        public virtual ListGuardrailsResponse EndListGuardrails(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGuardrailsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListImportedModels

        /// <summary>
        /// Returns a list of models you've imported. You can filter the results to return based
        /// on one or more criteria. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportedModels service method.</param>
        /// 
        /// <returns>The response from the ListImportedModels service method, as returned by Bedrock.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListImportedModels">REST API Reference for ListImportedModels Operation</seealso>
        public virtual ListImportedModelsResponse ListImportedModels(ListImportedModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportedModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportedModelsResponseUnmarshaller.Instance;

            return Invoke<ListImportedModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListImportedModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImportedModels operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImportedModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListImportedModels">REST API Reference for ListImportedModels Operation</seealso>
        public virtual IAsyncResult BeginListImportedModels(ListImportedModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportedModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportedModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListImportedModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImportedModels.</param>
        /// 
        /// <returns>Returns a  ListImportedModelsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListImportedModels">REST API Reference for ListImportedModels Operation</seealso>
        public virtual ListImportedModelsResponse EndListImportedModels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListImportedModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInferenceProfiles

        /// <summary>
        /// Returns a list of inference profiles that you can use. For more information, see <a
        /// href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">Increase
        /// throughput and resilience with cross-region inference in Amazon Bedrock</a>. in the
        /// Amazon Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListInferenceProfiles service method, as returned by Bedrock.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListInferenceProfiles">REST API Reference for ListInferenceProfiles Operation</seealso>
        public virtual ListInferenceProfilesResponse ListInferenceProfiles(ListInferenceProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInferenceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceProfilesResponseUnmarshaller.Instance;

            return Invoke<ListInferenceProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInferenceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceProfiles operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInferenceProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListInferenceProfiles">REST API Reference for ListInferenceProfiles Operation</seealso>
        public virtual IAsyncResult BeginListInferenceProfiles(ListInferenceProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInferenceProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInferenceProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInferenceProfiles.</param>
        /// 
        /// <returns>Returns a  ListInferenceProfilesResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListInferenceProfiles">REST API Reference for ListInferenceProfiles Operation</seealso>
        public virtual ListInferenceProfilesResponse EndListInferenceProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInferenceProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMarketplaceModelEndpoints

        /// <summary>
        /// Lists the endpoints for models from Amazon Bedrock Marketplace in your Amazon Web
        /// Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMarketplaceModelEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListMarketplaceModelEndpoints service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListMarketplaceModelEndpoints">REST API Reference for ListMarketplaceModelEndpoints Operation</seealso>
        public virtual ListMarketplaceModelEndpointsResponse ListMarketplaceModelEndpoints(ListMarketplaceModelEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMarketplaceModelEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMarketplaceModelEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListMarketplaceModelEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMarketplaceModelEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMarketplaceModelEndpoints operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMarketplaceModelEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListMarketplaceModelEndpoints">REST API Reference for ListMarketplaceModelEndpoints Operation</seealso>
        public virtual IAsyncResult BeginListMarketplaceModelEndpoints(ListMarketplaceModelEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMarketplaceModelEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMarketplaceModelEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMarketplaceModelEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMarketplaceModelEndpoints.</param>
        /// 
        /// <returns>Returns a  ListMarketplaceModelEndpointsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListMarketplaceModelEndpoints">REST API Reference for ListMarketplaceModelEndpoints Operation</seealso>
        public virtual ListMarketplaceModelEndpointsResponse EndListMarketplaceModelEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMarketplaceModelEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListModelCopyJobs

        /// <summary>
        /// Returns a list of model copy jobs that you have submitted. You can filter the jobs
        /// to return based on one or more criteria. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/copy-model.html">Copy
        /// models to be used in other regions</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelCopyJobs service method.</param>
        /// 
        /// <returns>The response from the ListModelCopyJobs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelCopyJobs">REST API Reference for ListModelCopyJobs Operation</seealso>
        public virtual ListModelCopyJobsResponse ListModelCopyJobs(ListModelCopyJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelCopyJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelCopyJobsResponseUnmarshaller.Instance;

            return Invoke<ListModelCopyJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelCopyJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelCopyJobs operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelCopyJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelCopyJobs">REST API Reference for ListModelCopyJobs Operation</seealso>
        public virtual IAsyncResult BeginListModelCopyJobs(ListModelCopyJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelCopyJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelCopyJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelCopyJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelCopyJobs.</param>
        /// 
        /// <returns>Returns a  ListModelCopyJobsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelCopyJobs">REST API Reference for ListModelCopyJobs Operation</seealso>
        public virtual ListModelCopyJobsResponse EndListModelCopyJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListModelCopyJobsResponse>(asyncResult);
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
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  ListModelImportJobs

        /// <summary>
        /// Returns a list of import jobs you've submitted. You can filter the results to return
        /// based on one or more criteria. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-import-model.html">Import
        /// a customized model</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListModelImportJobs service method, as returned by Bedrock.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelImportJobs">REST API Reference for ListModelImportJobs Operation</seealso>
        public virtual ListModelImportJobsResponse ListModelImportJobs(ListModelImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListModelImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelImportJobs operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelImportJobs">REST API Reference for ListModelImportJobs Operation</seealso>
        public virtual IAsyncResult BeginListModelImportJobs(ListModelImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelImportJobs.</param>
        /// 
        /// <returns>Returns a  ListModelImportJobsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelImportJobs">REST API Reference for ListModelImportJobs Operation</seealso>
        public virtual ListModelImportJobsResponse EndListModelImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListModelImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListModelInvocationJobs

        /// <summary>
        /// Lists all batch inference jobs in the account. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-view.html">View
        /// details about a batch inference job</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelInvocationJobs service method.</param>
        /// 
        /// <returns>The response from the ListModelInvocationJobs service method, as returned by Bedrock.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelInvocationJobs">REST API Reference for ListModelInvocationJobs Operation</seealso>
        public virtual ListModelInvocationJobsResponse ListModelInvocationJobs(ListModelInvocationJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelInvocationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelInvocationJobsResponseUnmarshaller.Instance;

            return Invoke<ListModelInvocationJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelInvocationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelInvocationJobs operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelInvocationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelInvocationJobs">REST API Reference for ListModelInvocationJobs Operation</seealso>
        public virtual IAsyncResult BeginListModelInvocationJobs(ListModelInvocationJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelInvocationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelInvocationJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelInvocationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelInvocationJobs.</param>
        /// 
        /// <returns>Returns a  ListModelInvocationJobsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelInvocationJobs">REST API Reference for ListModelInvocationJobs Operation</seealso>
        public virtual ListModelInvocationJobsResponse EndListModelInvocationJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListModelInvocationJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPromptRouters

        /// <summary>
        /// Retrieves a list of prompt routers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPromptRouters service method.</param>
        /// 
        /// <returns>The response from the ListPromptRouters service method, as returned by Bedrock.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListPromptRouters">REST API Reference for ListPromptRouters Operation</seealso>
        public virtual ListPromptRoutersResponse ListPromptRouters(ListPromptRoutersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPromptRoutersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPromptRoutersResponseUnmarshaller.Instance;

            return Invoke<ListPromptRoutersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPromptRouters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPromptRouters operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPromptRouters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListPromptRouters">REST API Reference for ListPromptRouters Operation</seealso>
        public virtual IAsyncResult BeginListPromptRouters(ListPromptRoutersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPromptRoutersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPromptRoutersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPromptRouters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPromptRouters.</param>
        /// 
        /// <returns>Returns a  ListPromptRoutersResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListPromptRouters">REST API Reference for ListPromptRouters Operation</seealso>
        public virtual ListPromptRoutersResponse EndListPromptRouters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPromptRoutersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProvisionedModelThroughputs

        /// <summary>
        /// Lists the Provisioned Throughputs in the account. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// resources</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutEnforcedGuardrailConfiguration

        /// <summary>
        /// Sets the account-level enforced guardrail configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEnforcedGuardrailConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutEnforcedGuardrailConfiguration service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutEnforcedGuardrailConfiguration">REST API Reference for PutEnforcedGuardrailConfiguration Operation</seealso>
        public virtual PutEnforcedGuardrailConfigurationResponse PutEnforcedGuardrailConfiguration(PutEnforcedGuardrailConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEnforcedGuardrailConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEnforcedGuardrailConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutEnforcedGuardrailConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutEnforcedGuardrailConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEnforcedGuardrailConfiguration operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEnforcedGuardrailConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutEnforcedGuardrailConfiguration">REST API Reference for PutEnforcedGuardrailConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutEnforcedGuardrailConfiguration(PutEnforcedGuardrailConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEnforcedGuardrailConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEnforcedGuardrailConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEnforcedGuardrailConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEnforcedGuardrailConfiguration.</param>
        /// 
        /// <returns>Returns a  PutEnforcedGuardrailConfigurationResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutEnforcedGuardrailConfiguration">REST API Reference for PutEnforcedGuardrailConfiguration Operation</seealso>
        public virtual PutEnforcedGuardrailConfigurationResponse EndPutEnforcedGuardrailConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEnforcedGuardrailConfigurationResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  PutUseCaseForModelAccess

        /// <summary>
        /// Put usecase for model access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUseCaseForModelAccess service method.</param>
        /// 
        /// <returns>The response from the PutUseCaseForModelAccess service method, as returned by Bedrock.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutUseCaseForModelAccess">REST API Reference for PutUseCaseForModelAccess Operation</seealso>
        public virtual PutUseCaseForModelAccessResponse PutUseCaseForModelAccess(PutUseCaseForModelAccessRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutUseCaseForModelAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUseCaseForModelAccessResponseUnmarshaller.Instance;

            return Invoke<PutUseCaseForModelAccessResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutUseCaseForModelAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutUseCaseForModelAccess operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutUseCaseForModelAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutUseCaseForModelAccess">REST API Reference for PutUseCaseForModelAccess Operation</seealso>
        public virtual IAsyncResult BeginPutUseCaseForModelAccess(PutUseCaseForModelAccessRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutUseCaseForModelAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutUseCaseForModelAccessResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutUseCaseForModelAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutUseCaseForModelAccess.</param>
        /// 
        /// <returns>Returns a  PutUseCaseForModelAccessResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutUseCaseForModelAccess">REST API Reference for PutUseCaseForModelAccess Operation</seealso>
        public virtual PutUseCaseForModelAccessResponse EndPutUseCaseForModelAccess(IAsyncResult asyncResult)
        {
            return EndInvoke<PutUseCaseForModelAccessResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterMarketplaceModelEndpoint

        /// <summary>
        /// Registers an existing Amazon SageMaker endpoint with Amazon Bedrock Marketplace, allowing
        /// it to be used with Amazon Bedrock APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterMarketplaceModelEndpoint service method.</param>
        /// 
        /// <returns>The response from the RegisterMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/RegisterMarketplaceModelEndpoint">REST API Reference for RegisterMarketplaceModelEndpoint Operation</seealso>
        public virtual RegisterMarketplaceModelEndpointResponse RegisterMarketplaceModelEndpoint(RegisterMarketplaceModelEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return Invoke<RegisterMarketplaceModelEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterMarketplaceModelEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterMarketplaceModelEndpoint operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterMarketplaceModelEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/RegisterMarketplaceModelEndpoint">REST API Reference for RegisterMarketplaceModelEndpoint Operation</seealso>
        public virtual IAsyncResult BeginRegisterMarketplaceModelEndpoint(RegisterMarketplaceModelEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterMarketplaceModelEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterMarketplaceModelEndpoint.</param>
        /// 
        /// <returns>Returns a  RegisterMarketplaceModelEndpointResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/RegisterMarketplaceModelEndpoint">REST API Reference for RegisterMarketplaceModelEndpoint Operation</seealso>
        public virtual RegisterMarketplaceModelEndpointResponse EndRegisterMarketplaceModelEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterMarketplaceModelEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAutomatedReasoningPolicyBuildWorkflow

        /// <summary>
        /// Starts a new build workflow for an Automated Reasoning policy. This initiates the
        /// process of analyzing source documents and generating policy rules, variables, and
        /// types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutomatedReasoningPolicyBuildWorkflow service method.</param>
        /// 
        /// <returns>The response from the StartAutomatedReasoningPolicyBuildWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StartAutomatedReasoningPolicyBuildWorkflow">REST API Reference for StartAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual StartAutomatedReasoningPolicyBuildWorkflowResponse StartAutomatedReasoningPolicyBuildWorkflow(StartAutomatedReasoningPolicyBuildWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;

            return Invoke<StartAutomatedReasoningPolicyBuildWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAutomatedReasoningPolicyBuildWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAutomatedReasoningPolicyBuildWorkflow operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAutomatedReasoningPolicyBuildWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StartAutomatedReasoningPolicyBuildWorkflow">REST API Reference for StartAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual IAsyncResult BeginStartAutomatedReasoningPolicyBuildWorkflow(StartAutomatedReasoningPolicyBuildWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAutomatedReasoningPolicyBuildWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutomatedReasoningPolicyBuildWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAutomatedReasoningPolicyBuildWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAutomatedReasoningPolicyBuildWorkflow.</param>
        /// 
        /// <returns>Returns a  StartAutomatedReasoningPolicyBuildWorkflowResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StartAutomatedReasoningPolicyBuildWorkflow">REST API Reference for StartAutomatedReasoningPolicyBuildWorkflow Operation</seealso>
        public virtual StartAutomatedReasoningPolicyBuildWorkflowResponse EndStartAutomatedReasoningPolicyBuildWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAutomatedReasoningPolicyBuildWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAutomatedReasoningPolicyTestWorkflow

        /// <summary>
        /// Initiates a test workflow to validate Automated Reasoning policy tests. The workflow
        /// executes the specified tests against the policy and generates validation results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAutomatedReasoningPolicyTestWorkflow service method.</param>
        /// 
        /// <returns>The response from the StartAutomatedReasoningPolicyTestWorkflow service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StartAutomatedReasoningPolicyTestWorkflow">REST API Reference for StartAutomatedReasoningPolicyTestWorkflow Operation</seealso>
        public virtual StartAutomatedReasoningPolicyTestWorkflowResponse StartAutomatedReasoningPolicyTestWorkflow(StartAutomatedReasoningPolicyTestWorkflowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAutomatedReasoningPolicyTestWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutomatedReasoningPolicyTestWorkflowResponseUnmarshaller.Instance;

            return Invoke<StartAutomatedReasoningPolicyTestWorkflowResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAutomatedReasoningPolicyTestWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAutomatedReasoningPolicyTestWorkflow operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAutomatedReasoningPolicyTestWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StartAutomatedReasoningPolicyTestWorkflow">REST API Reference for StartAutomatedReasoningPolicyTestWorkflow Operation</seealso>
        public virtual IAsyncResult BeginStartAutomatedReasoningPolicyTestWorkflow(StartAutomatedReasoningPolicyTestWorkflowRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAutomatedReasoningPolicyTestWorkflowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAutomatedReasoningPolicyTestWorkflowResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAutomatedReasoningPolicyTestWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAutomatedReasoningPolicyTestWorkflow.</param>
        /// 
        /// <returns>Returns a  StartAutomatedReasoningPolicyTestWorkflowResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StartAutomatedReasoningPolicyTestWorkflow">REST API Reference for StartAutomatedReasoningPolicyTestWorkflow Operation</seealso>
        public virtual StartAutomatedReasoningPolicyTestWorkflowResponse EndStartAutomatedReasoningPolicyTestWorkflow(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAutomatedReasoningPolicyTestWorkflowResponse>(asyncResult);
        }

        #endregion
        
        #region  StopEvaluationJob

        /// <summary>
        /// Stops an evaluation job that is current being created or running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEvaluationJob service method.</param>
        /// 
        /// <returns>The response from the StopEvaluationJob service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopEvaluationJob">REST API Reference for StopEvaluationJob Operation</seealso>
        public virtual StopEvaluationJobResponse StopEvaluationJob(StopEvaluationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEvaluationJobResponseUnmarshaller.Instance;

            return Invoke<StopEvaluationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopEvaluationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopEvaluationJob operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopEvaluationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopEvaluationJob">REST API Reference for StopEvaluationJob Operation</seealso>
        public virtual IAsyncResult BeginStopEvaluationJob(StopEvaluationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopEvaluationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEvaluationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopEvaluationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopEvaluationJob.</param>
        /// 
        /// <returns>Returns a  StopEvaluationJobResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopEvaluationJob">REST API Reference for StopEvaluationJob Operation</seealso>
        public virtual StopEvaluationJobResponse EndStopEvaluationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopEvaluationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopModelCustomizationJob

        /// <summary>
        /// Stops an active model customization job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        
        #region  StopModelInvocationJob

        /// <summary>
        /// Stops a batch inference job. You're only charged for tokens that were already processed.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/batch-inference-stop.html">Stop
        /// a batch inference job</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopModelInvocationJob service method.</param>
        /// 
        /// <returns>The response from the StopModelInvocationJob service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopModelInvocationJob">REST API Reference for StopModelInvocationJob Operation</seealso>
        public virtual StopModelInvocationJobResponse StopModelInvocationJob(StopModelInvocationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopModelInvocationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopModelInvocationJobResponseUnmarshaller.Instance;

            return Invoke<StopModelInvocationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopModelInvocationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopModelInvocationJob operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopModelInvocationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopModelInvocationJob">REST API Reference for StopModelInvocationJob Operation</seealso>
        public virtual IAsyncResult BeginStopModelInvocationJob(StopModelInvocationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopModelInvocationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopModelInvocationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopModelInvocationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopModelInvocationJob.</param>
        /// 
        /// <returns>Returns a  StopModelInvocationJobResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopModelInvocationJob">REST API Reference for StopModelInvocationJob Operation</seealso>
        public virtual StopModelInvocationJobResponse EndStopModelInvocationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopModelInvocationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associate tags with a resource. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// resources</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAutomatedReasoningPolicy

        /// <summary>
        /// Updates an existing Automated Reasoning policy with new rules, variables, or configuration.
        /// This creates a new version of the policy while preserving the previous version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedReasoningPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAutomatedReasoningPolicy service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicy">REST API Reference for UpdateAutomatedReasoningPolicy Operation</seealso>
        public virtual UpdateAutomatedReasoningPolicyResponse UpdateAutomatedReasoningPolicy(UpdateAutomatedReasoningPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomatedReasoningPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateAutomatedReasoningPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAutomatedReasoningPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedReasoningPolicy operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAutomatedReasoningPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicy">REST API Reference for UpdateAutomatedReasoningPolicy Operation</seealso>
        public virtual IAsyncResult BeginUpdateAutomatedReasoningPolicy(UpdateAutomatedReasoningPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomatedReasoningPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomatedReasoningPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAutomatedReasoningPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAutomatedReasoningPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateAutomatedReasoningPolicyResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicy">REST API Reference for UpdateAutomatedReasoningPolicy Operation</seealso>
        public virtual UpdateAutomatedReasoningPolicyResponse EndUpdateAutomatedReasoningPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAutomatedReasoningPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAutomatedReasoningPolicyAnnotations

        /// <summary>
        /// Updates the annotations for an Automated Reasoning policy build workflow. This allows
        /// you to modify extracted rules, variables, and types before finalizing the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedReasoningPolicyAnnotations service method.</param>
        /// 
        /// <returns>The response from the UpdateAutomatedReasoningPolicyAnnotations service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicyAnnotations">REST API Reference for UpdateAutomatedReasoningPolicyAnnotations Operation</seealso>
        public virtual UpdateAutomatedReasoningPolicyAnnotationsResponse UpdateAutomatedReasoningPolicyAnnotations(UpdateAutomatedReasoningPolicyAnnotationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomatedReasoningPolicyAnnotationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomatedReasoningPolicyAnnotationsResponseUnmarshaller.Instance;

            return Invoke<UpdateAutomatedReasoningPolicyAnnotationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAutomatedReasoningPolicyAnnotations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedReasoningPolicyAnnotations operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAutomatedReasoningPolicyAnnotations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicyAnnotations">REST API Reference for UpdateAutomatedReasoningPolicyAnnotations Operation</seealso>
        public virtual IAsyncResult BeginUpdateAutomatedReasoningPolicyAnnotations(UpdateAutomatedReasoningPolicyAnnotationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomatedReasoningPolicyAnnotationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomatedReasoningPolicyAnnotationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAutomatedReasoningPolicyAnnotations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAutomatedReasoningPolicyAnnotations.</param>
        /// 
        /// <returns>Returns a  UpdateAutomatedReasoningPolicyAnnotationsResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicyAnnotations">REST API Reference for UpdateAutomatedReasoningPolicyAnnotations Operation</seealso>
        public virtual UpdateAutomatedReasoningPolicyAnnotationsResponse EndUpdateAutomatedReasoningPolicyAnnotations(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAutomatedReasoningPolicyAnnotationsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAutomatedReasoningPolicyTestCase

        /// <summary>
        /// Updates an existing Automated Reasoning policy test. You can modify the content, query,
        /// expected result, and confidence threshold.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedReasoningPolicyTestCase service method.</param>
        /// 
        /// <returns>The response from the UpdateAutomatedReasoningPolicyTestCase service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceInUseException">
        /// Thrown when attempting to delete or modify a resource that is currently being used
        /// by other resources or operations. For example, trying to delete an Automated Reasoning
        /// policy that is referenced by an active guardrail.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicyTestCase">REST API Reference for UpdateAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual UpdateAutomatedReasoningPolicyTestCaseResponse UpdateAutomatedReasoningPolicyTestCase(UpdateAutomatedReasoningPolicyTestCaseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;

            return Invoke<UpdateAutomatedReasoningPolicyTestCaseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAutomatedReasoningPolicyTestCase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutomatedReasoningPolicyTestCase operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAutomatedReasoningPolicyTestCase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicyTestCase">REST API Reference for UpdateAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual IAsyncResult BeginUpdateAutomatedReasoningPolicyTestCase(UpdateAutomatedReasoningPolicyTestCaseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAutomatedReasoningPolicyTestCaseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutomatedReasoningPolicyTestCaseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAutomatedReasoningPolicyTestCase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAutomatedReasoningPolicyTestCase.</param>
        /// 
        /// <returns>Returns a  UpdateAutomatedReasoningPolicyTestCaseResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateAutomatedReasoningPolicyTestCase">REST API Reference for UpdateAutomatedReasoningPolicyTestCase Operation</seealso>
        public virtual UpdateAutomatedReasoningPolicyTestCaseResponse EndUpdateAutomatedReasoningPolicyTestCase(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAutomatedReasoningPolicyTestCaseResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGuardrail

        /// <summary>
        /// Updates a guardrail with the values you specify.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Specify a <c>name</c> and optional <c>description</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify messages for when the guardrail successfully blocks a prompt or a model response
        /// in the <c>blockedInputMessaging</c> and <c>blockedOutputsMessaging</c> fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify topics for the guardrail to deny in the <c>topicPolicyConfig</c> object. Each
        /// <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailTopicConfig.html">GuardrailTopicConfig</a>
        /// object in the <c>topicsConfig</c> list pertains to one topic.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Give a <c>name</c> and <c>description</c> so that the guardrail can properly identify
        /// the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <c>DENY</c> in the <c>type</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Provide up to five prompts that you would categorize as belonging to the
        /// topic in the <c>examples</c> list.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Specify filter strengths for the harmful categories defined in Amazon Bedrock in the
        /// <c>contentPolicyConfig</c> object. Each <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailContentFilterConfig.html">GuardrailContentFilterConfig</a>
        /// object in the <c>filtersConfig</c> list pertains to a harmful category. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails-content-filters">Content
        /// filters</a>. For more information about the fields in a content filter, see <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailContentFilterConfig.html">GuardrailContentFilterConfig</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the category in the <c>type</c> field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify the strength of the filter for prompts in the <c>inputStrength</c> field and
        /// for model responses in the <c>strength</c> field of the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_GuardrailContentFilterConfig.html">GuardrailContentFilterConfig</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// (Optional) For security, include the ARN of a KMS key in the <c>kmsKeyId</c> field.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGuardrail service method.</param>
        /// 
        /// <returns>The response from the UpdateGuardrail service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateGuardrail">REST API Reference for UpdateGuardrail Operation</seealso>
        public virtual UpdateGuardrailResponse UpdateGuardrail(UpdateGuardrailRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGuardrailResponseUnmarshaller.Instance;

            return Invoke<UpdateGuardrailResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGuardrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGuardrail operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGuardrail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateGuardrail">REST API Reference for UpdateGuardrail Operation</seealso>
        public virtual IAsyncResult BeginUpdateGuardrail(UpdateGuardrailRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGuardrailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGuardrailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGuardrail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGuardrail.</param>
        /// 
        /// <returns>Returns a  UpdateGuardrailResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateGuardrail">REST API Reference for UpdateGuardrail Operation</seealso>
        public virtual UpdateGuardrailResponse EndUpdateGuardrail(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGuardrailResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMarketplaceModelEndpoint

        /// <summary>
        /// Updates the configuration of an existing endpoint for a model from Amazon Bedrock
        /// Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMarketplaceModelEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateMarketplaceModelEndpoint service method, as returned by Bedrock.</returns>
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateMarketplaceModelEndpoint">REST API Reference for UpdateMarketplaceModelEndpoint Operation</seealso>
        public virtual UpdateMarketplaceModelEndpointResponse UpdateMarketplaceModelEndpoint(UpdateMarketplaceModelEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateMarketplaceModelEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMarketplaceModelEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMarketplaceModelEndpoint operation on AmazonBedrockClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMarketplaceModelEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateMarketplaceModelEndpoint">REST API Reference for UpdateMarketplaceModelEndpoint Operation</seealso>
        public virtual IAsyncResult BeginUpdateMarketplaceModelEndpoint(UpdateMarketplaceModelEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMarketplaceModelEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMarketplaceModelEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMarketplaceModelEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMarketplaceModelEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateMarketplaceModelEndpointResult from Bedrock.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateMarketplaceModelEndpoint">REST API Reference for UpdateMarketplaceModelEndpoint Operation</seealso>
        public virtual UpdateMarketplaceModelEndpointResponse EndUpdateMarketplaceModelEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMarketplaceModelEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProvisionedModelThroughput

        /// <summary>
        /// Updates the name or associated model for a Provisioned Throughput. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prov-throughput.html">Provisioned
        /// Throughput</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
        /// Bedrock User Guide</a>.
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
        /// The specified resource Amazon Resource Name (ARN) was not found. Check the Amazon
        /// Resource Name (ARN) and try your request again.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonBedrockEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}