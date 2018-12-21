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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DataPipeline.Model;
using Amazon.DataPipeline.Model.Internal.MarshallTransformations;
using Amazon.DataPipeline.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DataPipeline
{
    /// <summary>
    /// Implementation for accessing DataPipeline
    ///
    /// AWS Data Pipeline configures and manages a data-driven workflow called a pipeline.
    /// AWS Data Pipeline handles the details of scheduling and ensuring that data dependencies
    /// are met so that your application can focus on processing the data.
    /// 
    ///  
    /// <para>
    /// AWS Data Pipeline provides a JAR implementation of a task runner called AWS Data Pipeline
    /// Task Runner. AWS Data Pipeline Task Runner provides logic for common data management
    /// scenarios, such as performing database queries and running data analysis using Amazon
    /// Elastic MapReduce (Amazon EMR). You can use AWS Data Pipeline Task Runner as your
    /// task runner, or you can write your own task runner to provide custom data management.
    /// </para>
    ///  
    /// <para>
    /// AWS Data Pipeline implements two main sets of functionality. Use the first set to
    /// create a pipeline and define data sources, schedules, dependencies, and the transforms
    /// to be performed on the data. Use the second set in your task runner application to
    /// receive the next task ready for processing. The logic for performing the task, such
    /// as querying the data, running data analysis, or converting the data from one format
    /// to another, is contained within the task runner. The task runner performs the task
    /// assigned to it by the web service, reporting progress to the web service as it does
    /// so. When the task is done, the task runner reports the final success or failure of
    /// the task to the web service.
    /// </para>
    /// </summary>
    public partial class AmazonDataPipelineClient : AmazonServiceClient, IAmazonDataPipeline
    {
        private static IServiceMetadata serviceMetadata = new AmazonDataPipelineMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonDataPipelineClient with the credentials loaded from the application's
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
        public AmazonDataPipelineClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataPipelineConfig()) { }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with the credentials loaded from the application's
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
        public AmazonDataPipelineClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataPipelineConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDataPipelineClient Configuration Object</param>
        public AmazonDataPipelineClient(AmazonDataPipelineConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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
            : this(credentials, new AmazonDataPipelineConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Credentials and an
        /// AmazonDataPipelineClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDataPipelineClient Configuration Object</param>
        public AmazonDataPipelineClient(AWSCredentials credentials, AmazonDataPipelineConfig clientConfig)
            : base(credentials, clientConfig)
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
        /// AmazonDataPipelineClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDataPipelineClient Configuration Object</param>
        public AmazonDataPipelineClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDataPipelineConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataPipelineConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataPipelineClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataPipelineClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDataPipelineClient Configuration Object</param>
        public AmazonDataPipelineClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDataPipelineConfig clientConfig)
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


        #region  ActivatePipeline

        internal virtual ActivatePipelineResponse ActivatePipeline(ActivatePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ActivatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivatePipelineResponseUnmarshaller.Instance;

            return Invoke<ActivatePipelineResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ActivatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/ActivatePipeline">REST API Reference for ActivatePipeline Operation</seealso>
        public virtual Task<ActivatePipelineResponse> ActivatePipelineAsync(ActivatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ActivatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<ActivatePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }


        /// <summary>
        /// Adds or modifies tags for the specified pipeline.
        /// </summary>
        /// <param name="pipelineId">The ID of the pipeline.</param>
        /// <param name="tags">The tags to add, as key/value pairs.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(string pipelineId, List<Tag> tags, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new AddTagsRequest();
            request.PipelineId = pipelineId;
            request.Tags = tags;
            return AddTagsAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePipeline

        internal virtual CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeactivatePipeline

        internal virtual DeactivatePipelineResponse DeactivatePipeline(DeactivatePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeactivatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivatePipelineResponseUnmarshaller.Instance;

            return Invoke<DeactivatePipelineResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeactivatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/DeactivatePipeline">REST API Reference for DeactivatePipeline Operation</seealso>
        public virtual Task<DeactivatePipelineResponse> DeactivatePipelineAsync(DeactivatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeactivatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DeactivatePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePipeline

        internal virtual DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeObjects

        internal virtual DescribeObjectsResponse DescribeObjects(DescribeObjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeObjectsResponseUnmarshaller.Instance;

            return Invoke<DescribeObjectsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/DescribeObjects">REST API Reference for DescribeObjects Operation</seealso>
        public virtual Task<DescribeObjectsResponse> DescribeObjectsAsync(DescribeObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeObjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePipelines

        internal virtual DescribePipelinesResponse DescribePipelines(DescribePipelinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelinesResponseUnmarshaller.Instance;

            return Invoke<DescribePipelinesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves metadata about one or more pipelines. The information retrieved includes
        /// the name of the pipeline, the pipeline identifier, its current state, and the user
        /// account that owns the pipeline. Using account credentials, you can retrieve metadata
        /// about pipelines that you or your IAM users have created. If you are using an IAM user
        /// account, you can retrieve metadata about only those pipelines for which you have read
        /// permissions.
        /// 
        ///  
        /// <para>
        /// To retrieve the full pipeline definition instead of metadata about the pipeline, call
        /// <a>GetPipelineDefinition</a>.
        /// </para>
        /// </summary>
        /// <param name="pipelineIds">The IDs of the pipelines to describe. You can pass as many as 25 identifiers in a single call. To obtain pipeline IDs, call <a>ListPipelines</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePipelines service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/DescribePipelines">REST API Reference for DescribePipelines Operation</seealso>
        public virtual Task<DescribePipelinesResponse> DescribePipelinesAsync(List<string> pipelineIds, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribePipelinesRequest();
            request.PipelineIds = pipelineIds;
            return DescribePipelinesAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/DescribePipelines">REST API Reference for DescribePipelines Operation</seealso>
        public virtual Task<DescribePipelinesResponse> DescribePipelinesAsync(DescribePipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelinesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePipelinesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EvaluateExpression

        internal virtual EvaluateExpressionResponse EvaluateExpression(EvaluateExpressionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EvaluateExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateExpressionResponseUnmarshaller.Instance;

            return Invoke<EvaluateExpressionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EvaluateExpression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EvaluateExpression operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/EvaluateExpression">REST API Reference for EvaluateExpression Operation</seealso>
        public virtual Task<EvaluateExpressionResponse> EvaluateExpressionAsync(EvaluateExpressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EvaluateExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateExpressionResponseUnmarshaller.Instance;

            return InvokeAsync<EvaluateExpressionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPipelineDefinition

        internal virtual GetPipelineDefinitionResponse GetPipelineDefinition(GetPipelineDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPipelineDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetPipelineDefinitionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/GetPipelineDefinition">REST API Reference for GetPipelineDefinition Operation</seealso>
        public virtual Task<GetPipelineDefinitionResponse> GetPipelineDefinitionAsync(GetPipelineDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPipelineDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetPipelineDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPipelines

        internal virtual ListPipelinesResponse ListPipelines()
        {
            return ListPipelines(new ListPipelinesRequest());
        }
        internal virtual ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListPipelinesResponse>(request, options);
        }


        /// <summary>
        /// Lists the pipeline identifiers for all active pipelines that you have permission to
        /// access.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual Task<ListPipelinesResponse> ListPipelinesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListPipelinesAsync(new ListPipelinesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelinesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PollForTask

        internal virtual PollForTaskResponse PollForTask(PollForTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PollForTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForTaskResponseUnmarshaller.Instance;

            return Invoke<PollForTaskResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PollForTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/PollForTask">REST API Reference for PollForTask Operation</seealso>
        public virtual Task<PollForTaskResponse> PollForTaskAsync(PollForTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PollForTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForTaskResponseUnmarshaller.Instance;

            return InvokeAsync<PollForTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutPipelineDefinition

        internal virtual PutPipelineDefinitionResponse PutPipelineDefinition(PutPipelineDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPipelineDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPipelineDefinitionResponseUnmarshaller.Instance;

            return Invoke<PutPipelineDefinitionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutPipelineDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPipelineDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/PutPipelineDefinition">REST API Reference for PutPipelineDefinition Operation</seealso>
        public virtual Task<PutPipelineDefinitionResponse> PutPipelineDefinitionAsync(PutPipelineDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPipelineDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPipelineDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<PutPipelineDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  QueryObjects

        internal virtual QueryObjectsResponse QueryObjects(QueryObjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryObjectsResponseUnmarshaller.Instance;

            return Invoke<QueryObjectsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the QueryObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/QueryObjects">REST API Reference for QueryObjects Operation</seealso>
        public virtual Task<QueryObjectsResponse> QueryObjectsAsync(QueryObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = QueryObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<QueryObjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags

        internal virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsResponse>(request, options);
        }


        /// <summary>
        /// Removes existing tags from the specified pipeline.
        /// </summary>
        /// <param name="pipelineId">The ID of the pipeline.</param>
        /// <param name="tagKeys">The keys of the tags to remove.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineDeletedException">
        /// The specified pipeline has been deleted.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(string pipelineId, List<string> tagKeys, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RemoveTagsRequest();
            request.PipelineId = pipelineId;
            request.TagKeys = tagKeys;
            return RemoveTagsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReportTaskProgress

        internal virtual ReportTaskProgressResponse ReportTaskProgress(ReportTaskProgressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReportTaskProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReportTaskProgressResponseUnmarshaller.Instance;

            return Invoke<ReportTaskProgressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReportTaskProgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskProgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/ReportTaskProgress">REST API Reference for ReportTaskProgress Operation</seealso>
        public virtual Task<ReportTaskProgressResponse> ReportTaskProgressAsync(ReportTaskProgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReportTaskProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReportTaskProgressResponseUnmarshaller.Instance;

            return InvokeAsync<ReportTaskProgressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReportTaskRunnerHeartbeat

        internal virtual ReportTaskRunnerHeartbeatResponse ReportTaskRunnerHeartbeat(ReportTaskRunnerHeartbeatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReportTaskRunnerHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReportTaskRunnerHeartbeatResponseUnmarshaller.Instance;

            return Invoke<ReportTaskRunnerHeartbeatResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReportTaskRunnerHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskRunnerHeartbeat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/ReportTaskRunnerHeartbeat">REST API Reference for ReportTaskRunnerHeartbeat Operation</seealso>
        public virtual Task<ReportTaskRunnerHeartbeatResponse> ReportTaskRunnerHeartbeatAsync(ReportTaskRunnerHeartbeatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReportTaskRunnerHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReportTaskRunnerHeartbeatResponseUnmarshaller.Instance;

            return InvokeAsync<ReportTaskRunnerHeartbeatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetStatus

        internal virtual SetStatusResponse SetStatus(SetStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetStatusResponseUnmarshaller.Instance;

            return Invoke<SetStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/SetStatus">REST API Reference for SetStatus Operation</seealso>
        public virtual Task<SetStatusResponse> SetStatusAsync(SetStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetStatusResponseUnmarshaller.Instance;

            return InvokeAsync<SetStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetTaskStatus

        internal virtual SetTaskStatusResponse SetTaskStatus(SetTaskStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTaskStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTaskStatusResponseUnmarshaller.Instance;

            return Invoke<SetTaskStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetTaskStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTaskStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/SetTaskStatus">REST API Reference for SetTaskStatus Operation</seealso>
        public virtual Task<SetTaskStatusResponse> SetTaskStatusAsync(SetTaskStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTaskStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTaskStatusResponseUnmarshaller.Instance;

            return InvokeAsync<SetTaskStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ValidatePipelineDefinition

        internal virtual ValidatePipelineDefinitionResponse ValidatePipelineDefinition(ValidatePipelineDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidatePipelineDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidatePipelineDefinitionResponseUnmarshaller.Instance;

            return Invoke<ValidatePipelineDefinitionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ValidatePipelineDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidatePipelineDefinition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/ValidatePipelineDefinition">REST API Reference for ValidatePipelineDefinition Operation</seealso>
        public virtual Task<ValidatePipelineDefinitionResponse> ValidatePipelineDefinitionAsync(ValidatePipelineDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidatePipelineDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidatePipelineDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<ValidatePipelineDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}