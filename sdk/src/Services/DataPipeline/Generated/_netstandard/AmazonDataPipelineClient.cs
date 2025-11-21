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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.DataPipeline
{
    /// <summary>
    /// <para>Implementation for accessing DataPipeline</para>
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
            : base(new AmazonDataPipelineConfig()) { }

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
            : base(new AmazonDataPipelineConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
        private IDataPipelinePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDataPipelinePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DataPipelinePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDataPipelineEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDataPipelineAuthSchemeHandler());
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivatePipelineResponseUnmarshaller.Instance;

            return Invoke<ActivatePipelineResponse>(request, options);
        }



        /// <summary>
        /// Validates the specified pipeline and starts processing pipeline tasks. If the pipeline
        /// does not pass validation, activation fails.
        /// 
        ///  
        /// <para>
        /// If you need to pause the pipeline to investigate an issue with a component, such as
        /// a data source or script, call <a>DeactivatePipeline</a>.
        /// </para>
        ///  
        /// <para>
        /// To activate a finished pipeline, modify the end date for the pipeline and then activate
        /// it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivatePipeline service method, as returned by DataPipeline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/ActivatePipeline">REST API Reference for ActivatePipeline Operation</seealso>
        public virtual Task<ActivatePipelineResponse> ActivatePipelineAsync(ActivatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ActivatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ActivatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<ActivatePipelineResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Adds or modifies tags for the specified pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
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
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePipeline

        internal virtual CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineResponse>(request, options);
        }



        /// <summary>
        /// Creates a new, empty pipeline. Use <a>PutPipelineDefinition</a> to populate the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePipelineResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeactivatePipeline

        internal virtual DeactivatePipelineResponse DeactivatePipeline(DeactivatePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivatePipelineResponseUnmarshaller.Instance;

            return Invoke<DeactivatePipelineResponse>(request, options);
        }



        /// <summary>
        /// Deactivates the specified running pipeline. The pipeline is set to the <c>DEACTIVATING</c>
        /// state until the deactivation process completes.
        /// 
        ///  
        /// <para>
        /// To resume a deactivated pipeline, use <a>ActivatePipeline</a>. By default, the pipeline
        /// resumes from the last completed execution. Optionally, you can specify the date and
        /// time to resume the pipeline.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivatePipeline service method, as returned by DataPipeline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/DeactivatePipeline">REST API Reference for DeactivatePipeline Operation</seealso>
        public virtual Task<DeactivatePipelineResponse> DeactivatePipelineAsync(DeactivatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeactivatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeactivatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DeactivatePipelineResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePipeline

        internal virtual DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineResponse>(request, options);
        }



        /// <summary>
        /// Deletes a pipeline, its pipeline definition, and its run history. AWS Data Pipeline
        /// attempts to cancel instances associated with the pipeline that are currently being
        /// processed by task runners.
        /// 
        ///  
        /// <para>
        /// Deleting a pipeline cannot be undone. You cannot query or restore a deleted pipeline.
        /// To temporarily pause a pipeline instead of deleting it, call <a>SetStatus</a> with
        /// the status set to <c>PAUSE</c> on individual components. Components that are paused
        /// by <a>SetStatus</a> can be resumed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.PipelineNotFoundException">
        /// The specified pipeline was not found. Verify that you used the correct user and account
        /// identifiers.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePipelineResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeObjects

        internal virtual DescribeObjectsResponse DescribeObjects(DescribeObjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeObjectsResponseUnmarshaller.Instance;

            return Invoke<DescribeObjectsResponse>(request, options);
        }



        /// <summary>
        /// Gets the object definitions for a set of objects associated with the pipeline. Object
        /// definitions are composed of a set of fields that define the properties of the object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeObjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeObjects service method, as returned by DataPipeline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/DescribeObjects">REST API Reference for DescribeObjects Operation</seealso>
        public virtual Task<DescribeObjectsResponse> DescribeObjectsAsync(DescribeObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeObjectsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribePipelines

        internal virtual DescribePipelinesResponse DescribePipelines(DescribePipelinesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelines service method.</param>
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
        public virtual Task<DescribePipelinesResponse> DescribePipelinesAsync(DescribePipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelinesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePipelinesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EvaluateExpression

        internal virtual EvaluateExpressionResponse EvaluateExpression(EvaluateExpressionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EvaluateExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateExpressionResponseUnmarshaller.Instance;

            return Invoke<EvaluateExpressionResponse>(request, options);
        }



        /// <summary>
        /// Task runners call <c>EvaluateExpression</c> to evaluate a string in the context of
        /// the specified object. For example, a task runner can evaluate SQL queries stored in
        /// Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluateExpression service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EvaluateExpression service method, as returned by DataPipeline.</returns>
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
        /// <exception cref="Amazon.DataPipeline.Model.TaskNotFoundException">
        /// The specified task was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/EvaluateExpression">REST API Reference for EvaluateExpression Operation</seealso>
        public virtual Task<EvaluateExpressionResponse> EvaluateExpressionAsync(EvaluateExpressionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EvaluateExpressionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EvaluateExpressionResponseUnmarshaller.Instance;

            return InvokeAsync<EvaluateExpressionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPipelineDefinition

        internal virtual GetPipelineDefinitionResponse GetPipelineDefinition(GetPipelineDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPipelineDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPipelineDefinitionResponseUnmarshaller.Instance;

            return Invoke<GetPipelineDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Gets the definition of the specified pipeline. You can call <c>GetPipelineDefinition</c>
        /// to retrieve the pipeline definition that you provided using <a>PutPipelineDefinition</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPipelineDefinition service method, as returned by DataPipeline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/GetPipelineDefinition">REST API Reference for GetPipelineDefinition Operation</seealso>
        public virtual Task<GetPipelineDefinitionResponse> GetPipelineDefinitionAsync(GetPipelineDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Lists the pipeline identifiers for all active pipelines that you have permission to
        /// access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
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
        public virtual Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelinesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PollForTask

        internal virtual PollForTaskResponse PollForTask(PollForTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PollForTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForTaskResponseUnmarshaller.Instance;

            return Invoke<PollForTaskResponse>(request, options);
        }



        /// <summary>
        /// Task runners call <c>PollForTask</c> to receive a task to perform from AWS Data Pipeline.
        /// The task runner specifies which tasks it can perform by setting a value for the <c>workerGroup</c>
        /// parameter. The task returned can come from any of the pipelines that match the <c>workerGroup</c>
        /// value passed in by the task runner and that was launched using the IAM user credentials
        /// specified by the task runner.
        /// 
        ///  
        /// <para>
        /// If tasks are ready in the work queue, <c>PollForTask</c> returns a response immediately.
        /// If no tasks are available in the queue, <c>PollForTask</c> uses long-polling and holds
        /// on to a poll connection for up to a 90 seconds, during which time the first newly
        /// scheduled task is handed to the task runner. To accomodate this, set the socket timeout
        /// in your task runner to 90 seconds. The task runner should not call <c>PollForTask</c>
        /// again on the same <c>workerGroup</c> until it receives a response, and this can take
        /// up to 90 seconds. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PollForTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PollForTask service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.TaskNotFoundException">
        /// The specified task was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/PollForTask">REST API Reference for PollForTask Operation</seealso>
        public virtual Task<PollForTaskResponse> PollForTaskAsync(PollForTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PollForTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForTaskResponseUnmarshaller.Instance;

            return InvokeAsync<PollForTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutPipelineDefinition

        internal virtual PutPipelineDefinitionResponse PutPipelineDefinition(PutPipelineDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPipelineDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPipelineDefinitionResponseUnmarshaller.Instance;

            return Invoke<PutPipelineDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Adds tasks, schedules, and preconditions to the specified pipeline. You can use <c>PutPipelineDefinition</c>
        /// to populate a new pipeline.
        /// 
        ///  
        /// <para>
        ///  <c>PutPipelineDefinition</c> also validates the configuration as it adds it to the
        /// pipeline. Changes to the pipeline are saved unless one of the following three validation
        /// errors exists in the pipeline. 
        /// </para>
        ///  <ol> <li>An object is missing a name or identifier field.</li> <li>A string or reference
        /// field is empty.</li> <li>The number of objects in the pipeline exceeds the maximum
        /// allowed objects.</li> <li>The pipeline is in a FINISHED state.</li> </ol> 
        /// <para>
        ///  Pipeline object definitions are passed to the <c>PutPipelineDefinition</c> action
        /// and returned by the <a>GetPipelineDefinition</a> action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPipelineDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPipelineDefinition service method, as returned by DataPipeline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/PutPipelineDefinition">REST API Reference for PutPipelineDefinition Operation</seealso>
        public virtual Task<PutPipelineDefinitionResponse> PutPipelineDefinitionAsync(PutPipelineDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPipelineDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPipelineDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<PutPipelineDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  QueryObjects

        internal virtual QueryObjectsResponse QueryObjects(QueryObjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryObjectsResponseUnmarshaller.Instance;

            return Invoke<QueryObjectsResponse>(request, options);
        }



        /// <summary>
        /// Queries the specified pipeline for the names of objects that match the specified set
        /// of conditions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryObjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryObjects service method, as returned by DataPipeline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/QueryObjects">REST API Reference for QueryObjects Operation</seealso>
        public virtual Task<QueryObjectsResponse> QueryObjectsAsync(QueryObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<QueryObjectsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveTags

        internal virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// Removes existing tags from the specified pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
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
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ReportTaskProgress

        internal virtual ReportTaskProgressResponse ReportTaskProgress(ReportTaskProgressRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReportTaskProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReportTaskProgressResponseUnmarshaller.Instance;

            return Invoke<ReportTaskProgressResponse>(request, options);
        }



        /// <summary>
        /// Task runners call <c>ReportTaskProgress</c> when assigned a task to acknowledge that
        /// it has the task. If the web service does not receive this acknowledgement within 2
        /// minutes, it assigns the task in a subsequent <a>PollForTask</a> call. After this initial
        /// acknowledgement, the task runner only needs to report progress every 15 minutes to
        /// maintain its ownership of the task. You can change this reporting time from 15 minutes
        /// by specifying a <c>reportProgressTimeout</c> field in your pipeline.
        /// 
        ///  
        /// <para>
        /// If a task runner does not report its status after 5 minutes, AWS Data Pipeline assumes
        /// that the task runner is unable to process the task and reassigns the task in a subsequent
        /// response to <a>PollForTask</a>. Task runners should call <c>ReportTaskProgress</c>
        /// every 60 seconds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskProgress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReportTaskProgress service method, as returned by DataPipeline.</returns>
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
        /// <exception cref="Amazon.DataPipeline.Model.TaskNotFoundException">
        /// The specified task was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/ReportTaskProgress">REST API Reference for ReportTaskProgress Operation</seealso>
        public virtual Task<ReportTaskProgressResponse> ReportTaskProgressAsync(ReportTaskProgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReportTaskProgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReportTaskProgressResponseUnmarshaller.Instance;

            return InvokeAsync<ReportTaskProgressResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ReportTaskRunnerHeartbeat

        internal virtual ReportTaskRunnerHeartbeatResponse ReportTaskRunnerHeartbeat(ReportTaskRunnerHeartbeatRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReportTaskRunnerHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReportTaskRunnerHeartbeatResponseUnmarshaller.Instance;

            return Invoke<ReportTaskRunnerHeartbeatResponse>(request, options);
        }



        /// <summary>
        /// Task runners call <c>ReportTaskRunnerHeartbeat</c> every 15 minutes to indicate that
        /// they are operational. If the AWS Data Pipeline Task Runner is launched on a resource
        /// managed by AWS Data Pipeline, the web service can use this call to detect when the
        /// task runner application has failed and restart a new instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReportTaskRunnerHeartbeat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReportTaskRunnerHeartbeat service method, as returned by DataPipeline.</returns>
        /// <exception cref="Amazon.DataPipeline.Model.InternalServiceErrorException">
        /// An internal service error occurred.
        /// </exception>
        /// <exception cref="Amazon.DataPipeline.Model.InvalidRequestException">
        /// The request was not valid. Verify that your request was properly formatted, that the
        /// signature was generated with the correct credentials, and that you haven't exceeded
        /// any of the service limits for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/ReportTaskRunnerHeartbeat">REST API Reference for ReportTaskRunnerHeartbeat Operation</seealso>
        public virtual Task<ReportTaskRunnerHeartbeatResponse> ReportTaskRunnerHeartbeatAsync(ReportTaskRunnerHeartbeatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReportTaskRunnerHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReportTaskRunnerHeartbeatResponseUnmarshaller.Instance;

            return InvokeAsync<ReportTaskRunnerHeartbeatResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetStatus

        internal virtual SetStatusResponse SetStatus(SetStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetStatusResponseUnmarshaller.Instance;

            return Invoke<SetStatusResponse>(request, options);
        }



        /// <summary>
        /// Requests that the status of the specified physical or logical pipeline objects be
        /// updated in the specified pipeline. This update might not occur immediately, but is
        /// eventually consistent. The status that can be set depends on the type of object (for
        /// example, DataNode or Activity). You cannot perform this operation on <c>FINISHED</c>
        /// pipelines and attempting to do so returns <c>InvalidRequestException</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetStatus service method, as returned by DataPipeline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/SetStatus">REST API Reference for SetStatus Operation</seealso>
        public virtual Task<SetStatusResponse> SetStatusAsync(SetStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetStatusResponseUnmarshaller.Instance;

            return InvokeAsync<SetStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetTaskStatus

        internal virtual SetTaskStatusResponse SetTaskStatus(SetTaskStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTaskStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTaskStatusResponseUnmarshaller.Instance;

            return Invoke<SetTaskStatusResponse>(request, options);
        }



        /// <summary>
        /// Task runners call <c>SetTaskStatus</c> to notify AWS Data Pipeline that a task is
        /// completed and provide information about the final status. A task runner makes this
        /// call regardless of whether the task was sucessful. A task runner does not need to
        /// call <c>SetTaskStatus</c> for tasks that are canceled by the web service during a
        /// call to <a>ReportTaskProgress</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTaskStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTaskStatus service method, as returned by DataPipeline.</returns>
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
        /// <exception cref="Amazon.DataPipeline.Model.TaskNotFoundException">
        /// The specified task was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/SetTaskStatus">REST API Reference for SetTaskStatus Operation</seealso>
        public virtual Task<SetTaskStatusResponse> SetTaskStatusAsync(SetTaskStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTaskStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTaskStatusResponseUnmarshaller.Instance;

            return InvokeAsync<SetTaskStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ValidatePipelineDefinition

        internal virtual ValidatePipelineDefinitionResponse ValidatePipelineDefinition(ValidatePipelineDefinitionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidatePipelineDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidatePipelineDefinitionResponseUnmarshaller.Instance;

            return Invoke<ValidatePipelineDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Validates the specified pipeline definition to ensure that it is well formed and can
        /// be run without error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidatePipelineDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidatePipelineDefinition service method, as returned by DataPipeline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datapipeline-2012-10-29/ValidatePipelineDefinition">REST API Reference for ValidatePipelineDefinition Operation</seealso>
        public virtual Task<ValidatePipelineDefinitionResponse> ValidatePipelineDefinitionAsync(ValidatePipelineDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidatePipelineDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidatePipelineDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<ValidatePipelineDefinitionResponse>(request, options, cancellationToken);
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