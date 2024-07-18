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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CleanRoomsML.Model;
using Amazon.CleanRoomsML.Model.Internal.MarshallTransformations;
using Amazon.CleanRoomsML.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.CleanRoomsML
{
    /// <summary>
    /// <para>Implementation for accessing CleanRoomsML</para>
    ///
    /// Welcome to the <i>Amazon Web Services Clean Rooms ML API Reference</i>.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services Clean Rooms ML provides a privacy-enhancing method for two parties
    /// to identify similar users in their data without the need to share their data with
    /// each other. The first party brings the training data to Clean Rooms so that they can
    /// create and configure an audience model (lookalike model) and associate it with a collaboration.
    /// The second party then brings their seed data to Clean Rooms and generates an audience
    /// (lookalike segment) that resembles the training data.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Amazon Web Services Clean Rooms ML concepts, procedures, and best
    /// practices, see the <a href="https://docs.aws.amazon.com/clean-rooms/latest/userguide/machine-learning.html">Clean
    /// Rooms User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// To learn more about SQL commands, functions, and conditions supported in Clean Rooms,
    /// see the <a href="https://docs.aws.amazon.com/clean-rooms/latest/sql-reference/sql-reference.html">Clean
    /// Rooms SQL Reference</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCleanRoomsMLClient : AmazonServiceClient, IAmazonCleanRoomsML
    {
        private static IServiceMetadata serviceMetadata = new AmazonCleanRoomsMLMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with the credentials loaded from the application's
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
        public AmazonCleanRoomsMLClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCleanRoomsMLConfig()) { }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with the credentials loaded from the application's
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
        public AmazonCleanRoomsMLClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCleanRoomsMLConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCleanRoomsMLClient Configuration Object</param>
        public AmazonCleanRoomsMLClient(AmazonCleanRoomsMLConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCleanRoomsMLClient(AWSCredentials credentials)
            : this(credentials, new AmazonCleanRoomsMLConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCleanRoomsMLClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCleanRoomsMLConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Credentials and an
        /// AmazonCleanRoomsMLClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCleanRoomsMLClient Configuration Object</param>
        public AmazonCleanRoomsMLClient(AWSCredentials credentials, AmazonCleanRoomsMLConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCleanRoomsMLClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCleanRoomsMLConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCleanRoomsMLClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCleanRoomsMLConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCleanRoomsMLClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCleanRoomsMLClient Configuration Object</param>
        public AmazonCleanRoomsMLClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCleanRoomsMLConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCleanRoomsMLClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCleanRoomsMLConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCleanRoomsMLClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCleanRoomsMLConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCleanRoomsMLClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCleanRoomsMLClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCleanRoomsMLClient Configuration Object</param>
        public AmazonCleanRoomsMLClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCleanRoomsMLConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ICleanRoomsMLPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICleanRoomsMLPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CleanRoomsMLPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCleanRoomsMLEndpointResolver());
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


        #region  CreateAudienceModel

        internal virtual CreateAudienceModelResponse CreateAudienceModel(CreateAudienceModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAudienceModelResponseUnmarshaller.Instance;

            return Invoke<CreateAudienceModelResponse>(request, options);
        }



        /// <summary>
        /// Defines the information necessary to create an audience model. An audience model is
        /// a machine learning model that Clean Rooms ML trains to measure similarity between
        /// users. Clean Rooms ML manages training and storing the audience model. The audience
        /// model can be used in multiple calls to the <a>StartAudienceGenerationJob</a> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAudienceModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateAudienceModel">REST API Reference for CreateAudienceModel Operation</seealso>
        public virtual Task<CreateAudienceModelResponse> CreateAudienceModelAsync(CreateAudienceModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAudienceModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAudienceModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConfiguredAudienceModel

        internal virtual CreateConfiguredAudienceModelResponse CreateConfiguredAudienceModel(CreateConfiguredAudienceModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredAudienceModelResponseUnmarshaller.Instance;

            return Invoke<CreateConfiguredAudienceModelResponse>(request, options);
        }



        /// <summary>
        /// Defines the information necessary to create a configured audience model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredAudienceModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfiguredAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateConfiguredAudienceModel">REST API Reference for CreateConfiguredAudienceModel Operation</seealso>
        public virtual Task<CreateConfiguredAudienceModelResponse> CreateConfiguredAudienceModelAsync(CreateConfiguredAudienceModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfiguredAudienceModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfiguredAudienceModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTrainingDataset

        internal virtual CreateTrainingDatasetResponse CreateTrainingDataset(CreateTrainingDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrainingDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrainingDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateTrainingDatasetResponse>(request, options);
        }



        /// <summary>
        /// Defines the information necessary to create a training dataset. In Clean Rooms ML,
        /// the <c>TrainingDataset</c> is metadata that points to a Glue table, which is read
        /// only during <c>AudienceModel</c> creation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrainingDataset service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/CreateTrainingDataset">REST API Reference for CreateTrainingDataset Operation</seealso>
        public virtual Task<CreateTrainingDatasetResponse> CreateTrainingDatasetAsync(CreateTrainingDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrainingDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrainingDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrainingDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAudienceGenerationJob

        internal virtual DeleteAudienceGenerationJobResponse DeleteAudienceGenerationJob(DeleteAudienceGenerationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAudienceGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAudienceGenerationJobResponseUnmarshaller.Instance;

            return Invoke<DeleteAudienceGenerationJobResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified audience generation job, and removes all data associated with
        /// the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAudienceGenerationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAudienceGenerationJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteAudienceGenerationJob">REST API Reference for DeleteAudienceGenerationJob Operation</seealso>
        public virtual Task<DeleteAudienceGenerationJobResponse> DeleteAudienceGenerationJobAsync(DeleteAudienceGenerationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAudienceGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAudienceGenerationJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAudienceGenerationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAudienceModel

        internal virtual DeleteAudienceModelResponse DeleteAudienceModel(DeleteAudienceModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAudienceModelResponseUnmarshaller.Instance;

            return Invoke<DeleteAudienceModelResponse>(request, options);
        }



        /// <summary>
        /// Specifies an audience model that you want to delete. You can't delete an audience
        /// model if there are any configured audience models that depend on the audience model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAudienceModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteAudienceModel">REST API Reference for DeleteAudienceModel Operation</seealso>
        public virtual Task<DeleteAudienceModelResponse> DeleteAudienceModelAsync(DeleteAudienceModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAudienceModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAudienceModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfiguredAudienceModel

        internal virtual DeleteConfiguredAudienceModelResponse DeleteConfiguredAudienceModel(DeleteConfiguredAudienceModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredAudienceModelResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredAudienceModelResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified configured audience model. You can't delete a configured audience
        /// model if there are any lookalike models that use the configured audience model. If
        /// you delete a configured audience model, it will be removed from any collaborations
        /// that it is associated to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredAudienceModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfiguredAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredAudienceModel">REST API Reference for DeleteConfiguredAudienceModel Operation</seealso>
        public virtual Task<DeleteConfiguredAudienceModelResponse> DeleteConfiguredAudienceModelAsync(DeleteConfiguredAudienceModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredAudienceModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfiguredAudienceModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfiguredAudienceModelPolicy

        internal virtual DeleteConfiguredAudienceModelPolicyResponse DeleteConfiguredAudienceModelPolicy(DeleteConfiguredAudienceModelPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredAudienceModelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredAudienceModelPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteConfiguredAudienceModelPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified configured audience model policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredAudienceModelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfiguredAudienceModelPolicy service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteConfiguredAudienceModelPolicy">REST API Reference for DeleteConfiguredAudienceModelPolicy Operation</seealso>
        public virtual Task<DeleteConfiguredAudienceModelPolicyResponse> DeleteConfiguredAudienceModelPolicyAsync(DeleteConfiguredAudienceModelPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfiguredAudienceModelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfiguredAudienceModelPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfiguredAudienceModelPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrainingDataset

        internal virtual DeleteTrainingDatasetResponse DeleteTrainingDataset(DeleteTrainingDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrainingDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrainingDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteTrainingDatasetResponse>(request, options);
        }



        /// <summary>
        /// Specifies a training dataset that you want to delete. You can't delete a training
        /// dataset if there are any audience models that depend on the training dataset. In Clean
        /// Rooms ML, the <c>TrainingDataset</c> is metadata that points to a Glue table, which
        /// is read only during <c>AudienceModel</c> creation. This action deletes the metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrainingDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrainingDataset service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/DeleteTrainingDataset">REST API Reference for DeleteTrainingDataset Operation</seealso>
        public virtual Task<DeleteTrainingDatasetResponse> DeleteTrainingDatasetAsync(DeleteTrainingDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrainingDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrainingDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrainingDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAudienceGenerationJob

        internal virtual GetAudienceGenerationJobResponse GetAudienceGenerationJob(GetAudienceGenerationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAudienceGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAudienceGenerationJobResponseUnmarshaller.Instance;

            return Invoke<GetAudienceGenerationJobResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an audience generation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAudienceGenerationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAudienceGenerationJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetAudienceGenerationJob">REST API Reference for GetAudienceGenerationJob Operation</seealso>
        public virtual Task<GetAudienceGenerationJobResponse> GetAudienceGenerationJobAsync(GetAudienceGenerationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAudienceGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAudienceGenerationJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetAudienceGenerationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAudienceModel

        internal virtual GetAudienceModelResponse GetAudienceModel(GetAudienceModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAudienceModelResponseUnmarshaller.Instance;

            return Invoke<GetAudienceModelResponse>(request, options);
        }



        /// <summary>
        /// Returns information about an audience model
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAudienceModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetAudienceModel">REST API Reference for GetAudienceModel Operation</seealso>
        public virtual Task<GetAudienceModelResponse> GetAudienceModelAsync(GetAudienceModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAudienceModelResponseUnmarshaller.Instance;

            return InvokeAsync<GetAudienceModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConfiguredAudienceModel

        internal virtual GetConfiguredAudienceModelResponse GetConfiguredAudienceModel(GetConfiguredAudienceModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredAudienceModelResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredAudienceModelResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specified configured audience model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredAudienceModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguredAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredAudienceModel">REST API Reference for GetConfiguredAudienceModel Operation</seealso>
        public virtual Task<GetConfiguredAudienceModelResponse> GetConfiguredAudienceModelAsync(GetConfiguredAudienceModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredAudienceModelResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfiguredAudienceModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConfiguredAudienceModelPolicy

        internal virtual GetConfiguredAudienceModelPolicyResponse GetConfiguredAudienceModelPolicy(GetConfiguredAudienceModelPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfiguredAudienceModelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredAudienceModelPolicyResponseUnmarshaller.Instance;

            return Invoke<GetConfiguredAudienceModelPolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a configured audience model policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredAudienceModelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConfiguredAudienceModelPolicy service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetConfiguredAudienceModelPolicy">REST API Reference for GetConfiguredAudienceModelPolicy Operation</seealso>
        public virtual Task<GetConfiguredAudienceModelPolicyResponse> GetConfiguredAudienceModelPolicyAsync(GetConfiguredAudienceModelPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConfiguredAudienceModelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConfiguredAudienceModelPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetConfiguredAudienceModelPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTrainingDataset

        internal virtual GetTrainingDatasetResponse GetTrainingDataset(GetTrainingDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrainingDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrainingDatasetResponseUnmarshaller.Instance;

            return Invoke<GetTrainingDatasetResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a training dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrainingDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrainingDataset service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/GetTrainingDataset">REST API Reference for GetTrainingDataset Operation</seealso>
        public virtual Task<GetTrainingDatasetResponse> GetTrainingDatasetAsync(GetTrainingDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTrainingDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrainingDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrainingDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAudienceExportJobs

        internal virtual ListAudienceExportJobsResponse ListAudienceExportJobs(ListAudienceExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAudienceExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAudienceExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListAudienceExportJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the audience export jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAudienceExportJobs service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceExportJobs">REST API Reference for ListAudienceExportJobs Operation</seealso>
        public virtual Task<ListAudienceExportJobsResponse> ListAudienceExportJobsAsync(ListAudienceExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAudienceExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAudienceExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAudienceExportJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAudienceGenerationJobs

        internal virtual ListAudienceGenerationJobsResponse ListAudienceGenerationJobs(ListAudienceGenerationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAudienceGenerationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAudienceGenerationJobsResponseUnmarshaller.Instance;

            return Invoke<ListAudienceGenerationJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of audience generation jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceGenerationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAudienceGenerationJobs service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceGenerationJobs">REST API Reference for ListAudienceGenerationJobs Operation</seealso>
        public virtual Task<ListAudienceGenerationJobsResponse> ListAudienceGenerationJobsAsync(ListAudienceGenerationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAudienceGenerationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAudienceGenerationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAudienceGenerationJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAudienceModels

        internal virtual ListAudienceModelsResponse ListAudienceModels(ListAudienceModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAudienceModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAudienceModelsResponseUnmarshaller.Instance;

            return Invoke<ListAudienceModelsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of audience models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAudienceModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAudienceModels service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListAudienceModels">REST API Reference for ListAudienceModels Operation</seealso>
        public virtual Task<ListAudienceModelsResponse> ListAudienceModelsAsync(ListAudienceModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAudienceModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAudienceModelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAudienceModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConfiguredAudienceModels

        internal virtual ListConfiguredAudienceModelsResponse ListConfiguredAudienceModels(ListConfiguredAudienceModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfiguredAudienceModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredAudienceModelsResponseUnmarshaller.Instance;

            return Invoke<ListConfiguredAudienceModelsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the configured audience models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredAudienceModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConfiguredAudienceModels service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListConfiguredAudienceModels">REST API Reference for ListConfiguredAudienceModels Operation</seealso>
        public virtual Task<ListConfiguredAudienceModelsResponse> ListConfiguredAudienceModelsAsync(ListConfiguredAudienceModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConfiguredAudienceModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConfiguredAudienceModelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListConfiguredAudienceModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of tags for a provided resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTrainingDatasets

        internal virtual ListTrainingDatasetsResponse ListTrainingDatasets(ListTrainingDatasetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrainingDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListTrainingDatasetsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of training datasets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingDatasets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrainingDatasets service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/ListTrainingDatasets">REST API Reference for ListTrainingDatasets Operation</seealso>
        public virtual Task<ListTrainingDatasetsResponse> ListTrainingDatasetsAsync(ListTrainingDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTrainingDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrainingDatasetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrainingDatasetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutConfiguredAudienceModelPolicy

        internal virtual PutConfiguredAudienceModelPolicyResponse PutConfiguredAudienceModelPolicy(PutConfiguredAudienceModelPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfiguredAudienceModelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfiguredAudienceModelPolicyResponseUnmarshaller.Instance;

            return Invoke<PutConfiguredAudienceModelPolicyResponse>(request, options);
        }



        /// <summary>
        /// Create or update the resource policy for a configured audience model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfiguredAudienceModelPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutConfiguredAudienceModelPolicy service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/PutConfiguredAudienceModelPolicy">REST API Reference for PutConfiguredAudienceModelPolicy Operation</seealso>
        public virtual Task<PutConfiguredAudienceModelPolicyResponse> PutConfiguredAudienceModelPolicyAsync(PutConfiguredAudienceModelPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfiguredAudienceModelPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfiguredAudienceModelPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutConfiguredAudienceModelPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartAudienceExportJob

        internal virtual StartAudienceExportJobResponse StartAudienceExportJob(StartAudienceExportJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAudienceExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAudienceExportJobResponseUnmarshaller.Instance;

            return Invoke<StartAudienceExportJobResponse>(request, options);
        }



        /// <summary>
        /// Export an audience of a specified size after you have generated an audience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAudienceExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAudienceExportJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartAudienceExportJob">REST API Reference for StartAudienceExportJob Operation</seealso>
        public virtual Task<StartAudienceExportJobResponse> StartAudienceExportJobAsync(StartAudienceExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAudienceExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAudienceExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartAudienceExportJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartAudienceGenerationJob

        internal virtual StartAudienceGenerationJobResponse StartAudienceGenerationJob(StartAudienceGenerationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAudienceGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAudienceGenerationJobResponseUnmarshaller.Instance;

            return Invoke<StartAudienceGenerationJobResponse>(request, options);
        }



        /// <summary>
        /// Information necessary to start the audience generation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAudienceGenerationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAudienceGenerationJob service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/StartAudienceGenerationJob">REST API Reference for StartAudienceGenerationJob Operation</seealso>
        public virtual Task<StartAudienceGenerationJobResponse> StartAudienceGenerationJobAsync(StartAudienceGenerationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAudienceGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAudienceGenerationJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartAudienceGenerationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds metadata tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes metadata tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfiguredAudienceModel

        internal virtual UpdateConfiguredAudienceModelResponse UpdateConfiguredAudienceModel(UpdateConfiguredAudienceModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredAudienceModelResponseUnmarshaller.Instance;

            return Invoke<UpdateConfiguredAudienceModelResponse>(request, options);
        }



        /// <summary>
        /// Provides the information necessary to update a configured audience model. Updates
        /// that impact audience generation jobs take effect when a new job starts, but do not
        /// impact currently running jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredAudienceModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConfiguredAudienceModel service method, as returned by CleanRoomsML.</returns>
        /// <exception cref="Amazon.CleanRoomsML.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ConflictException">
        /// You can't complete this action because another resource depends on this resource.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ResourceNotFoundException">
        /// The resource you are requesting does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRoomsML.Model.ValidationException">
        /// The request parameters for this request are incorrect.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanroomsml-2023-09-06/UpdateConfiguredAudienceModel">REST API Reference for UpdateConfiguredAudienceModel Operation</seealso>
        public virtual Task<UpdateConfiguredAudienceModelResponse> UpdateConfiguredAudienceModelAsync(UpdateConfiguredAudienceModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfiguredAudienceModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfiguredAudienceModelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfiguredAudienceModelResponse>(request, options, cancellationToken);
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
            var resolver = new AmazonCleanRoomsMLEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}