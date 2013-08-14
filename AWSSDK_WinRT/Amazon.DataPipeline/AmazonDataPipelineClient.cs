/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.DataPipeline.Model;
using Amazon.DataPipeline.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DataPipeline
{
    /// <summary>
    /// Implementation for accessing AmazonDataPipeline.
    /// 
    /// 
    /// </summary>
	public partial class AmazonDataPipelineClient : AmazonWebServiceClient, Amazon.DataPipeline.IAmazonDataPipeline
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDataPipelineClient(AWSCredentials credentials)
            : this(credentials, new AmazonDataPipelineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataPipelineClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDataPipelineConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Credentials and an
        /// AmazonDataPipelineClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDataPipelineClient Configuration Object</param>
        public AmazonDataPipelineClient(AWSCredentials credentials, AmazonDataPipelineConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDataPipelineClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataPipelineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataPipelineClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataPipelineConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataPipelineClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDataPipelineClient Configuration Object</param>
        public AmazonDataPipelineClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDataPipelineConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDataPipelineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataPipelineConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataPipelineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataPipelineConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataPipelineClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDataPipelineClient Configuration Object</param>
        public AmazonDataPipelineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDataPipelineConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="activatePipelineRequest">Container for the necessary parameters to execute the ActivatePipeline service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ActivatePipeline service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ActivatePipelineResponse> ActivatePipelineAsync(ActivatePipelineRequest activatePipelineRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ActivatePipelineRequestMarshaller();
            var unmarshaller = ActivatePipelineResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ActivatePipelineRequest, ActivatePipelineResponse>(activatePipelineRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createPipelineRequest">Container for the necessary parameters to execute the CreatePipeline service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest createPipelineRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePipelineRequestMarshaller();
            var unmarshaller = CreatePipelineResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreatePipelineRequest, CreatePipelineResponse>(createPipelineRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deletePipelineRequest">Container for the necessary parameters to execute the DeletePipeline service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest deletePipelineRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePipelineRequestMarshaller();
            var unmarshaller = DeletePipelineResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeletePipelineRequest, DeletePipelineResponse>(deletePipelineRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeObjectsRequest">Container for the necessary parameters to execute the DescribeObjects service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the DescribeObjects service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribeObjectsResponse> DescribeObjectsAsync(DescribeObjectsRequest describeObjectsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeObjectsRequestMarshaller();
            var unmarshaller = DescribeObjectsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeObjectsRequest, DescribeObjectsResponse>(describeObjectsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="describePipelinesRequest">Container for the necessary parameters to execute the DescribePipelines service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the DescribePipelines service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DescribePipelinesResponse> DescribePipelinesAsync(DescribePipelinesRequest describePipelinesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePipelinesRequestMarshaller();
            var unmarshaller = DescribePipelinesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribePipelinesRequest, DescribePipelinesResponse>(describePipelinesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="evaluateExpressionRequest">Container for the necessary parameters to execute the EvaluateExpression service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the EvaluateExpression service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.TaskNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<EvaluateExpressionResponse> EvaluateExpressionAsync(EvaluateExpressionRequest evaluateExpressionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EvaluateExpressionRequestMarshaller();
            var unmarshaller = EvaluateExpressionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, EvaluateExpressionRequest, EvaluateExpressionResponse>(evaluateExpressionRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="getPipelineDefinitionRequest">Container for the necessary parameters to execute the GetPipelineDefinition service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the GetPipelineDefinition service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<GetPipelineDefinitionResponse> GetPipelineDefinitionAsync(GetPipelineDefinitionRequest getPipelineDefinitionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPipelineDefinitionRequestMarshaller();
            var unmarshaller = GetPipelineDefinitionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetPipelineDefinitionRequest, GetPipelineDefinitionResponse>(getPipelineDefinitionRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="listPipelinesRequest">Container for the necessary parameters to execute the ListPipelines service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest listPipelinesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPipelinesRequestMarshaller();
            var unmarshaller = ListPipelinesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListPipelinesRequest, ListPipelinesResponse>(listPipelinesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="pollForTaskRequest">Container for the necessary parameters to execute the PollForTask service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the PollForTask service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.TaskNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<PollForTaskResponse> PollForTaskAsync(PollForTaskRequest pollForTaskRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PollForTaskRequestMarshaller();
            var unmarshaller = PollForTaskResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, PollForTaskRequest, PollForTaskResponse>(pollForTaskRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="putPipelineDefinitionRequest">Container for the necessary parameters to execute the PutPipelineDefinition service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the PutPipelineDefinition service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<PutPipelineDefinitionResponse> PutPipelineDefinitionAsync(PutPipelineDefinitionRequest putPipelineDefinitionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutPipelineDefinitionRequestMarshaller();
            var unmarshaller = PutPipelineDefinitionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, PutPipelineDefinitionRequest, PutPipelineDefinitionResponse>(putPipelineDefinitionRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="queryObjectsRequest">Container for the necessary parameters to execute the QueryObjects service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the QueryObjects service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<QueryObjectsResponse> QueryObjectsAsync(QueryObjectsRequest queryObjectsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new QueryObjectsRequestMarshaller();
            var unmarshaller = QueryObjectsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, QueryObjectsRequest, QueryObjectsResponse>(queryObjectsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="reportTaskProgressRequest">Container for the necessary parameters to execute the ReportTaskProgress service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ReportTaskProgress service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.TaskNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ReportTaskProgressResponse> ReportTaskProgressAsync(ReportTaskProgressRequest reportTaskProgressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReportTaskProgressRequestMarshaller();
            var unmarshaller = ReportTaskProgressResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ReportTaskProgressRequest, ReportTaskProgressResponse>(reportTaskProgressRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="reportTaskRunnerHeartbeatRequest">Container for the necessary parameters to execute the ReportTaskRunnerHeartbeat service
        /// method on AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ReportTaskRunnerHeartbeat service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ReportTaskRunnerHeartbeatResponse> ReportTaskRunnerHeartbeatAsync(ReportTaskRunnerHeartbeatRequest reportTaskRunnerHeartbeatRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReportTaskRunnerHeartbeatRequestMarshaller();
            var unmarshaller = ReportTaskRunnerHeartbeatResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ReportTaskRunnerHeartbeatRequest, ReportTaskRunnerHeartbeatResponse>(reportTaskRunnerHeartbeatRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="setStatusRequest">Container for the necessary parameters to execute the SetStatus service method on AmazonDataPipeline.</param>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<SetStatusResponse> SetStatusAsync(SetStatusRequest setStatusRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetStatusRequestMarshaller();
            var unmarshaller = SetStatusResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SetStatusRequest, SetStatusResponse>(setStatusRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="setTaskStatusRequest">Container for the necessary parameters to execute the SetTaskStatus service method on
        /// AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the SetTaskStatus service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.TaskNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<SetTaskStatusResponse> SetTaskStatusAsync(SetTaskStatusRequest setTaskStatusRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetTaskStatusRequestMarshaller();
            var unmarshaller = SetTaskStatusResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SetTaskStatusRequest, SetTaskStatusResponse>(setTaskStatusRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="validatePipelineDefinitionRequest">Container for the necessary parameters to execute the ValidatePipelineDefinition service
        /// method on AmazonDataPipeline.</param>
        /// 
        /// <returns>The response from the ValidatePipelineDefinition service method, as returned by AmazonDataPipeline.</returns>
        /// 
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineNotFoundException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InternalServiceErrorException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.InvalidRequestException" />
        /// <exception cref="T:Amazon.DataPipeline.Model.PipelineDeletedException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ValidatePipelineDefinitionResponse> ValidatePipelineDefinitionAsync(ValidatePipelineDefinitionRequest validatePipelineDefinitionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ValidatePipelineDefinitionRequestMarshaller();
            var unmarshaller = ValidatePipelineDefinitionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ValidatePipelineDefinitionRequest, ValidatePipelineDefinitionResponse>(validatePipelineDefinitionRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
