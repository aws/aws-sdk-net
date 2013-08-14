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

using Amazon.ElasticTranscoder.Model;
using Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticTranscoder
{
    /// <summary>
    /// Implementation for accessing AmazonElasticTranscoder.
    /// 
    /// 
    /// </summary>
	public partial class AmazonElasticTranscoderClient : AmazonWebServiceClient, Amazon.ElasticTranscoder.IAmazonElasticTranscoder
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticTranscoderClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticTranscoderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticTranscoderClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticTranscoderConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Credentials and an
        /// AmazonElasticTranscoderClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticTranscoderClient Configuration Object</param>
        public AmazonElasticTranscoderClient(AWSCredentials credentials, AmazonElasticTranscoderConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticTranscoderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticTranscoderConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticTranscoderClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticTranscoderClient Configuration Object</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticTranscoderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticTranscoderConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticTranscoderConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticTranscoderClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticTranscoderClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticTranscoderClient Configuration Object</param>
        public AmazonElasticTranscoderClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticTranscoderConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="cancelJobRequest">Container for the necessary parameters to execute the CancelJob service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CancelJobResponse> CancelJobAsync(CancelJobRequest cancelJobRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelJobRequestMarshaller();
            var unmarshaller = CancelJobResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CancelJobRequest, CancelJobResponse>(cancelJobRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createJobRequest">Container for the necessary parameters to execute the CreateJob service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest createJobRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateJobRequestMarshaller();
            var unmarshaller = CreateJobResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateJobRequest, CreateJobResponse>(createJobRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createPipelineRequest">Container for the necessary parameters to execute the CreatePipeline service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
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
        /// <param name="createPresetRequest">Container for the necessary parameters to execute the CreatePreset service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the CreatePreset service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreatePresetResponse> CreatePresetAsync(CreatePresetRequest createPresetRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePresetRequestMarshaller();
            var unmarshaller = CreatePresetResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreatePresetRequest, CreatePresetResponse>(createPresetRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deletePipelineRequest">Container for the necessary parameters to execute the DeletePipeline service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
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
        /// <param name="deletePresetRequest">Container for the necessary parameters to execute the DeletePreset service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the DeletePreset service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeletePresetResponse> DeletePresetAsync(DeletePresetRequest deletePresetRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePresetRequestMarshaller();
            var unmarshaller = DeletePresetResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeletePresetRequest, DeletePresetResponse>(deletePresetRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="listJobsByPipelineRequest">Container for the necessary parameters to execute the ListJobsByPipeline service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListJobsByPipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ListJobsByPipelineResponse> ListJobsByPipelineAsync(ListJobsByPipelineRequest listJobsByPipelineRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListJobsByPipelineRequestMarshaller();
            var unmarshaller = ListJobsByPipelineResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListJobsByPipelineRequest, ListJobsByPipelineResponse>(listJobsByPipelineRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="listJobsByStatusRequest">Container for the necessary parameters to execute the ListJobsByStatus service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListJobsByStatus service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ListJobsByStatusResponse> ListJobsByStatusAsync(ListJobsByStatusRequest listJobsByStatusRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListJobsByStatusRequestMarshaller();
            var unmarshaller = ListJobsByStatusResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListJobsByStatusRequest, ListJobsByStatusResponse>(listJobsByStatusRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="listPipelinesRequest">Container for the necessary parameters to execute the ListPipelines service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
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
        /// <param name="listPresetsRequest">Container for the necessary parameters to execute the ListPresets service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ListPresets service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ListPresetsResponse> ListPresetsAsync(ListPresetsRequest listPresetsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPresetsRequestMarshaller();
            var unmarshaller = ListPresetsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListPresetsRequest, ListPresetsResponse>(listPresetsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="readJobRequest">Container for the necessary parameters to execute the ReadJob service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ReadJob service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ReadJobResponse> ReadJobAsync(ReadJobRequest readJobRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReadJobRequestMarshaller();
            var unmarshaller = ReadJobResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ReadJobRequest, ReadJobResponse>(readJobRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="readPipelineRequest">Container for the necessary parameters to execute the ReadPipeline service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ReadPipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ReadPipelineResponse> ReadPipelineAsync(ReadPipelineRequest readPipelineRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReadPipelineRequestMarshaller();
            var unmarshaller = ReadPipelineResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ReadPipelineRequest, ReadPipelineResponse>(readPipelineRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="readPresetRequest">Container for the necessary parameters to execute the ReadPreset service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the ReadPreset service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ReadPresetResponse> ReadPresetAsync(ReadPresetRequest readPresetRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReadPresetRequestMarshaller();
            var unmarshaller = ReadPresetResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ReadPresetRequest, ReadPresetResponse>(readPresetRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="testRoleRequest">Container for the necessary parameters to execute the TestRole service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the TestRole service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<TestRoleResponse> TestRoleAsync(TestRoleRequest testRoleRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TestRoleRequestMarshaller();
            var unmarshaller = TestRoleResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, TestRoleRequest, TestRoleResponse>(testRoleRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="updatePipelineRequest">Container for the necessary parameters to execute the UpdatePipeline service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest updatePipelineRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdatePipelineRequestMarshaller();
            var unmarshaller = UpdatePipelineResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdatePipelineRequest, UpdatePipelineResponse>(updatePipelineRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="updatePipelineNotificationsRequest">Container for the necessary parameters to execute the UpdatePipelineNotifications service
        /// method on AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the UpdatePipelineNotifications service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdatePipelineNotificationsResponse> UpdatePipelineNotificationsAsync(UpdatePipelineNotificationsRequest updatePipelineNotificationsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdatePipelineNotificationsRequestMarshaller();
            var unmarshaller = UpdatePipelineNotificationsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdatePipelineNotificationsRequest, UpdatePipelineNotificationsResponse>(updatePipelineNotificationsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="updatePipelineStatusRequest">Container for the necessary parameters to execute the UpdatePipelineStatus service method on
        /// AmazonElasticTranscoder.</param>
        /// 
        /// <returns>The response from the UpdatePipelineStatus service method, as returned by AmazonElasticTranscoder.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.AccessDeniedException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.ValidationException" />
        /// <exception cref="T:Amazon.ElasticTranscoder.Model.IncompatibleVersionException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UpdatePipelineStatusResponse> UpdatePipelineStatusAsync(UpdatePipelineStatusRequest updatePipelineStatusRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdatePipelineStatusRequestMarshaller();
            var unmarshaller = UpdatePipelineStatusResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UpdatePipelineStatusRequest, UpdatePipelineStatusResponse>(updatePipelineStatusRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
