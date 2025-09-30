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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.RoboMaker.Model;
using Amazon.RoboMaker.Model.Internal.MarshallTransformations;
using Amazon.RoboMaker.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.RoboMaker
{
    /// <summary>
    /// <para>Implementation for accessing RoboMaker</para>
    ///
    /// This section provides documentation for the AWS RoboMaker API operations.
    /// </summary>
    public partial class AmazonRoboMakerClient : AmazonServiceClient, IAmazonRoboMaker
    {
        private static IServiceMetadata serviceMetadata = new AmazonRoboMakerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRoboMakerClient with the credentials loaded from the application's
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
        public AmazonRoboMakerClient()
            : base(new AmazonRoboMakerConfig()) { }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with the credentials loaded from the application's
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
        public AmazonRoboMakerClient(RegionEndpoint region)
            : base(new AmazonRoboMakerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRoboMakerClient Configuration Object</param>
        public AmazonRoboMakerClient(AmazonRoboMakerConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoboMakerClient(AWSCredentials credentials)
            : this(credentials, new AmazonRoboMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoboMakerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoboMakerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Credentials and an
        /// AmazonRoboMakerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoboMakerClient Configuration Object</param>
        public AmazonRoboMakerClient(AWSCredentials credentials, AmazonRoboMakerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoboMakerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoboMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoboMakerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoboMakerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoboMakerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoboMakerClient Configuration Object</param>
        public AmazonRoboMakerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoboMakerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoboMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoboMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoboMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoboMakerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoboMakerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoboMakerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoboMakerClient Configuration Object</param>
        public AmazonRoboMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoboMakerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IRoboMakerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRoboMakerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new RoboMakerPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRoboMakerEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRoboMakerAuthSchemeHandler());
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


        #region  BatchDeleteWorlds

        internal virtual BatchDeleteWorldsResponse BatchDeleteWorlds(BatchDeleteWorldsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteWorldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteWorldsResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteWorldsResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes one or more worlds in a batch operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteWorlds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteWorlds service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/BatchDeleteWorlds">REST API Reference for BatchDeleteWorlds Operation</seealso>
        public virtual Task<BatchDeleteWorldsResponse> BatchDeleteWorldsAsync(BatchDeleteWorldsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteWorldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteWorldsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteWorldsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDescribeSimulationJob

        internal virtual BatchDescribeSimulationJobResponse BatchDescribeSimulationJob(BatchDescribeSimulationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDescribeSimulationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDescribeSimulationJobResponseUnmarshaller.Instance;

            return Invoke<BatchDescribeSimulationJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes one or more simulation jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeSimulationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDescribeSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/BatchDescribeSimulationJob">REST API Reference for BatchDescribeSimulationJob Operation</seealso>
        public virtual Task<BatchDescribeSimulationJobResponse> BatchDescribeSimulationJobAsync(BatchDescribeSimulationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDescribeSimulationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDescribeSimulationJobResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDescribeSimulationJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelDeploymentJob

        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual CancelDeploymentJobResponse CancelDeploymentJob(CancelDeploymentJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelDeploymentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDeploymentJobResponseUnmarshaller.Instance;

            return Invoke<CancelDeploymentJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels the specified deployment job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDeploymentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelDeploymentJob">REST API Reference for CancelDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<CancelDeploymentJobResponse> CancelDeploymentJobAsync(CancelDeploymentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelDeploymentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDeploymentJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelDeploymentJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelSimulationJob

        internal virtual CancelSimulationJobResponse CancelSimulationJob(CancelSimulationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSimulationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSimulationJobResponseUnmarshaller.Instance;

            return Invoke<CancelSimulationJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels the specified simulation job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSimulationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelSimulationJob">REST API Reference for CancelSimulationJob Operation</seealso>
        public virtual Task<CancelSimulationJobResponse> CancelSimulationJobAsync(CancelSimulationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSimulationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSimulationJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSimulationJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelSimulationJobBatch

        internal virtual CancelSimulationJobBatchResponse CancelSimulationJobBatch(CancelSimulationJobBatchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSimulationJobBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSimulationJobBatchResponseUnmarshaller.Instance;

            return Invoke<CancelSimulationJobBatchResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels a simulation job batch. When you cancel a simulation job batch, you are also
        /// cancelling all of the active simulation jobs created as part of the batch. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSimulationJobBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSimulationJobBatch service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelSimulationJobBatch">REST API Reference for CancelSimulationJobBatch Operation</seealso>
        public virtual Task<CancelSimulationJobBatchResponse> CancelSimulationJobBatchAsync(CancelSimulationJobBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSimulationJobBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSimulationJobBatchResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSimulationJobBatchResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelWorldExportJob

        internal virtual CancelWorldExportJobResponse CancelWorldExportJob(CancelWorldExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelWorldExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelWorldExportJobResponseUnmarshaller.Instance;

            return Invoke<CancelWorldExportJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels the specified export job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelWorldExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelWorldExportJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelWorldExportJob">REST API Reference for CancelWorldExportJob Operation</seealso>
        public virtual Task<CancelWorldExportJobResponse> CancelWorldExportJobAsync(CancelWorldExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelWorldExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelWorldExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelWorldExportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelWorldGenerationJob

        internal virtual CancelWorldGenerationJobResponse CancelWorldGenerationJob(CancelWorldGenerationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelWorldGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelWorldGenerationJobResponseUnmarshaller.Instance;

            return Invoke<CancelWorldGenerationJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels the specified world generator job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelWorldGenerationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelWorldGenerationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelWorldGenerationJob">REST API Reference for CancelWorldGenerationJob Operation</seealso>
        public virtual Task<CancelWorldGenerationJobResponse> CancelWorldGenerationJobAsync(CancelWorldGenerationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelWorldGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelWorldGenerationJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelWorldGenerationJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDeploymentJob

        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual CreateDeploymentJobResponse CreateDeploymentJob(CreateDeploymentJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentJobResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used. For more information,
        /// see the January 31, 2022 update in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-january2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Deploys a specific version of a robot application to robots in a fleet.
        /// </para>
        ///  
        /// <para>
        /// The robot application must have a numbered <c>applicationVersion</c> for consistency
        /// reasons. To create a new version, use <c>CreateRobotApplicationVersion</c> or see
        /// <a href="https://docs.aws.amazon.com/robomaker/latest/dg/create-robot-application-version.html">Creating
        /// a Robot Application Version</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// After 90 days, deployment jobs expire and will be deleted. They will no longer be
        /// accessible. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.ConcurrentDeploymentException">
        /// The failure percentage threshold percentage was met.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateDeploymentJob">REST API Reference for CreateDeploymentJob Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<CreateDeploymentJobResponse> CreateDeploymentJobAsync(CreateDeploymentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFleet

        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used. For more information,
        /// see the January 31, 2022 update in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-january2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a fleet, a logical group of robots running the same robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRobot

        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual CreateRobotResponse CreateRobot(CreateRobotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRobotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRobotResponseUnmarshaller.Instance;

            return Invoke<CreateRobotResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used. For more information,
        /// see the January 31, 2022 update in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-january2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a robot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRobot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobot">REST API Reference for CreateRobot Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<CreateRobotResponse> CreateRobotAsync(CreateRobotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRobotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRobotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRobotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRobotApplication

        internal virtual CreateRobotApplicationResponse CreateRobotApplication(CreateRobotApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRobotApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRobotApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateRobotApplicationResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a robot application. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRobotApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobotApplication">REST API Reference for CreateRobotApplication Operation</seealso>
        public virtual Task<CreateRobotApplicationResponse> CreateRobotApplicationAsync(CreateRobotApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRobotApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRobotApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRobotApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRobotApplicationVersion

        internal virtual CreateRobotApplicationVersionResponse CreateRobotApplicationVersion(CreateRobotApplicationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRobotApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRobotApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateRobotApplicationVersionResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a version of a robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRobotApplicationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRobotApplicationVersion service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobotApplicationVersion">REST API Reference for CreateRobotApplicationVersion Operation</seealso>
        public virtual Task<CreateRobotApplicationVersionResponse> CreateRobotApplicationVersionAsync(CreateRobotApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRobotApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRobotApplicationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRobotApplicationVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSimulationApplication

        internal virtual CreateSimulationApplicationResponse CreateSimulationApplication(CreateSimulationApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSimulationApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSimulationApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateSimulationApplicationResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a simulation application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationApplication">REST API Reference for CreateSimulationApplication Operation</seealso>
        public virtual Task<CreateSimulationApplicationResponse> CreateSimulationApplicationAsync(CreateSimulationApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSimulationApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSimulationApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSimulationApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSimulationApplicationVersion

        internal virtual CreateSimulationApplicationVersionResponse CreateSimulationApplicationVersion(CreateSimulationApplicationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSimulationApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSimulationApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateSimulationApplicationVersionResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a simulation application with a specific revision id.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationApplicationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSimulationApplicationVersion service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationApplicationVersion">REST API Reference for CreateSimulationApplicationVersion Operation</seealso>
        public virtual Task<CreateSimulationApplicationVersionResponse> CreateSimulationApplicationVersionAsync(CreateSimulationApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSimulationApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSimulationApplicationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSimulationApplicationVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSimulationJob

        internal virtual CreateSimulationJobResponse CreateSimulationJob(CreateSimulationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSimulationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSimulationJobResponseUnmarshaller.Instance;

            return Invoke<CreateSimulationJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a simulation job.
        /// </para>
        ///  <note> 
        /// <para>
        /// After 90 days, simulation jobs expire and will be deleted. They will no longer be
        /// accessible. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationJob">REST API Reference for CreateSimulationJob Operation</seealso>
        public virtual Task<CreateSimulationJobResponse> CreateSimulationJobAsync(CreateSimulationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSimulationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSimulationJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSimulationJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWorldExportJob

        internal virtual CreateWorldExportJobResponse CreateWorldExportJob(CreateWorldExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorldExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorldExportJobResponseUnmarshaller.Instance;

            return Invoke<CreateWorldExportJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a world export job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorldExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorldExportJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldExportJob">REST API Reference for CreateWorldExportJob Operation</seealso>
        public virtual Task<CreateWorldExportJobResponse> CreateWorldExportJobAsync(CreateWorldExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorldExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorldExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorldExportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWorldGenerationJob

        internal virtual CreateWorldGenerationJobResponse CreateWorldGenerationJob(CreateWorldGenerationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorldGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorldGenerationJobResponseUnmarshaller.Instance;

            return Invoke<CreateWorldGenerationJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates worlds using the specified template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorldGenerationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorldGenerationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldGenerationJob">REST API Reference for CreateWorldGenerationJob Operation</seealso>
        public virtual Task<CreateWorldGenerationJobResponse> CreateWorldGenerationJobAsync(CreateWorldGenerationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorldGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorldGenerationJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorldGenerationJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWorldTemplate

        internal virtual CreateWorldTemplateResponse CreateWorldTemplate(CreateWorldTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorldTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorldTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateWorldTemplateResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a world template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorldTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorldTemplate service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldTemplate">REST API Reference for CreateWorldTemplate Operation</seealso>
        public virtual Task<CreateWorldTemplateResponse> CreateWorldTemplateAsync(CreateWorldTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorldTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorldTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorldTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFleet

        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a fleet.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRobot

        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual DeleteRobotResponse DeleteRobot(DeleteRobotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRobotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRobotResponseUnmarshaller.Instance;

            return Invoke<DeleteRobotResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a robot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRobot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteRobot">REST API Reference for DeleteRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<DeleteRobotResponse> DeleteRobotAsync(DeleteRobotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRobotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRobotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRobotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRobotApplication

        internal virtual DeleteRobotApplicationResponse DeleteRobotApplication(DeleteRobotApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRobotApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRobotApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteRobotApplicationResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRobotApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteRobotApplication">REST API Reference for DeleteRobotApplication Operation</seealso>
        public virtual Task<DeleteRobotApplicationResponse> DeleteRobotApplicationAsync(DeleteRobotApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRobotApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRobotApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRobotApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSimulationApplication

        internal virtual DeleteSimulationApplicationResponse DeleteSimulationApplication(DeleteSimulationApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSimulationApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSimulationApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteSimulationApplicationResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a simulation application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSimulationApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteSimulationApplication">REST API Reference for DeleteSimulationApplication Operation</seealso>
        public virtual Task<DeleteSimulationApplicationResponse> DeleteSimulationApplicationAsync(DeleteSimulationApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSimulationApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSimulationApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSimulationApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWorldTemplate

        internal virtual DeleteWorldTemplateResponse DeleteWorldTemplate(DeleteWorldTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorldTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorldTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteWorldTemplateResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a world template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorldTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorldTemplate service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteWorldTemplate">REST API Reference for DeleteWorldTemplate Operation</seealso>
        public virtual Task<DeleteWorldTemplateResponse> DeleteWorldTemplateAsync(DeleteWorldTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorldTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorldTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorldTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeregisterRobot

        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual DeregisterRobotResponse DeregisterRobot(DeregisterRobotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterRobotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterRobotResponseUnmarshaller.Instance;

            return Invoke<DeregisterRobotResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Deregisters a robot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRobot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeregisterRobot">REST API Reference for DeregisterRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<DeregisterRobotResponse> DeregisterRobotAsync(DeregisterRobotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeregisterRobotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterRobotResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterRobotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDeploymentJob

        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual DescribeDeploymentJobResponse DescribeDeploymentJob(DescribeDeploymentJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDeploymentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeploymentJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDeploymentJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a deployment job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeploymentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeDeploymentJob">REST API Reference for DescribeDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<DescribeDeploymentJobResponse> DescribeDeploymentJobAsync(DescribeDeploymentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDeploymentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeploymentJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeploymentJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFleet

        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual DescribeFleetResponse DescribeFleet(DescribeFleetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a fleet.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleet service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeFleet">REST API Reference for DescribeFleet Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<DescribeFleetResponse> DescribeFleetAsync(DescribeFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRobot

        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual DescribeRobotResponse DescribeRobot(DescribeRobotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRobotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRobotResponseUnmarshaller.Instance;

            return Invoke<DescribeRobotResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a robot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRobot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeRobot">REST API Reference for DescribeRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<DescribeRobotResponse> DescribeRobotAsync(DescribeRobotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRobotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRobotResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRobotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRobotApplication

        internal virtual DescribeRobotApplicationResponse DescribeRobotApplication(DescribeRobotApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRobotApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRobotApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeRobotApplicationResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRobotApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeRobotApplication">REST API Reference for DescribeRobotApplication Operation</seealso>
        public virtual Task<DescribeRobotApplicationResponse> DescribeRobotApplicationAsync(DescribeRobotApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRobotApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRobotApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRobotApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSimulationApplication

        internal virtual DescribeSimulationApplicationResponse DescribeSimulationApplication(DescribeSimulationApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSimulationApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSimulationApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeSimulationApplicationResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a simulation application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationApplication">REST API Reference for DescribeSimulationApplication Operation</seealso>
        public virtual Task<DescribeSimulationApplicationResponse> DescribeSimulationApplicationAsync(DescribeSimulationApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSimulationApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSimulationApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSimulationApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSimulationJob

        internal virtual DescribeSimulationJobResponse DescribeSimulationJob(DescribeSimulationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSimulationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSimulationJobResponseUnmarshaller.Instance;

            return Invoke<DescribeSimulationJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a simulation job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationJob">REST API Reference for DescribeSimulationJob Operation</seealso>
        public virtual Task<DescribeSimulationJobResponse> DescribeSimulationJobAsync(DescribeSimulationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSimulationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSimulationJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSimulationJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSimulationJobBatch

        internal virtual DescribeSimulationJobBatchResponse DescribeSimulationJobBatch(DescribeSimulationJobBatchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSimulationJobBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSimulationJobBatchResponseUnmarshaller.Instance;

            return Invoke<DescribeSimulationJobBatchResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a simulation job batch.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationJobBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSimulationJobBatch service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationJobBatch">REST API Reference for DescribeSimulationJobBatch Operation</seealso>
        public virtual Task<DescribeSimulationJobBatchResponse> DescribeSimulationJobBatchAsync(DescribeSimulationJobBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSimulationJobBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSimulationJobBatchResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSimulationJobBatchResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeWorld

        internal virtual DescribeWorldResponse DescribeWorld(DescribeWorldRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorldResponseUnmarshaller.Instance;

            return Invoke<DescribeWorldResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a world.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorld service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorld service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorld">REST API Reference for DescribeWorld Operation</seealso>
        public virtual Task<DescribeWorldResponse> DescribeWorldAsync(DescribeWorldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorldResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorldResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeWorldExportJob

        internal virtual DescribeWorldExportJobResponse DescribeWorldExportJob(DescribeWorldExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorldExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorldExportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeWorldExportJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a world export job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorldExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorldExportJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldExportJob">REST API Reference for DescribeWorldExportJob Operation</seealso>
        public virtual Task<DescribeWorldExportJobResponse> DescribeWorldExportJobAsync(DescribeWorldExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorldExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorldExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorldExportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeWorldGenerationJob

        internal virtual DescribeWorldGenerationJobResponse DescribeWorldGenerationJob(DescribeWorldGenerationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorldGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorldGenerationJobResponseUnmarshaller.Instance;

            return Invoke<DescribeWorldGenerationJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a world generation job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorldGenerationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorldGenerationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldGenerationJob">REST API Reference for DescribeWorldGenerationJob Operation</seealso>
        public virtual Task<DescribeWorldGenerationJobResponse> DescribeWorldGenerationJobAsync(DescribeWorldGenerationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorldGenerationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorldGenerationJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorldGenerationJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeWorldTemplate

        internal virtual DescribeWorldTemplateResponse DescribeWorldTemplate(DescribeWorldTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorldTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorldTemplateResponseUnmarshaller.Instance;

            return Invoke<DescribeWorldTemplateResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a world template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorldTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorldTemplate service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldTemplate">REST API Reference for DescribeWorldTemplate Operation</seealso>
        public virtual Task<DescribeWorldTemplateResponse> DescribeWorldTemplateAsync(DescribeWorldTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorldTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorldTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorldTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWorldTemplateBody

        internal virtual GetWorldTemplateBodyResponse GetWorldTemplateBody(GetWorldTemplateBodyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorldTemplateBodyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorldTemplateBodyResponseUnmarshaller.Instance;

            return Invoke<GetWorldTemplateBodyResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Gets the world template body.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorldTemplateBody service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorldTemplateBody service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/GetWorldTemplateBody">REST API Reference for GetWorldTemplateBody Operation</seealso>
        public virtual Task<GetWorldTemplateBodyResponse> GetWorldTemplateBodyAsync(GetWorldTemplateBodyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorldTemplateBodyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorldTemplateBodyResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorldTemplateBodyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDeploymentJobs

        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual ListDeploymentJobsResponse ListDeploymentJobs(ListDeploymentJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentJobsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentJobsResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        ///  Returns a list of deployment jobs for a fleet. You can optionally provide filters
        /// to retrieve specific deployment jobs. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeploymentJobs service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListDeploymentJobs">REST API Reference for ListDeploymentJobs Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<ListDeploymentJobsResponse> ListDeploymentJobsAsync(ListDeploymentJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeploymentJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeploymentJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFleets

        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual ListFleetsResponse ListFleets(ListFleetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return Invoke<ListFleetsResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        ///  Returns a list of fleets. You can optionally provide filters to retrieve specific
        /// fleets. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListFleets">REST API Reference for ListFleets Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFleetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRobotApplications

        internal virtual ListRobotApplicationsResponse ListRobotApplications(ListRobotApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRobotApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRobotApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListRobotApplicationsResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of robot application. You can optionally provide filters to retrieve
        /// specific robot applications.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRobotApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRobotApplications service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListRobotApplications">REST API Reference for ListRobotApplications Operation</seealso>
        public virtual Task<ListRobotApplicationsResponse> ListRobotApplicationsAsync(ListRobotApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRobotApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRobotApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRobotApplicationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRobots

        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual ListRobotsResponse ListRobots(ListRobotsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRobotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRobotsResponseUnmarshaller.Instance;

            return Invoke<ListRobotsResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        ///  Returns a list of robots. You can optionally provide filters to retrieve specific
        /// robots. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRobots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRobots service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListRobots">REST API Reference for ListRobots Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<ListRobotsResponse> ListRobotsAsync(ListRobotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRobotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRobotsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRobotsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSimulationApplications

        internal virtual ListSimulationApplicationsResponse ListSimulationApplications(ListSimulationApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSimulationApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSimulationApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListSimulationApplicationsResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of simulation applications. You can optionally provide filters to retrieve
        /// specific simulation applications. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSimulationApplications service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationApplications">REST API Reference for ListSimulationApplications Operation</seealso>
        public virtual Task<ListSimulationApplicationsResponse> ListSimulationApplicationsAsync(ListSimulationApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSimulationApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSimulationApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSimulationApplicationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSimulationJobBatches

        internal virtual ListSimulationJobBatchesResponse ListSimulationJobBatches(ListSimulationJobBatchesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSimulationJobBatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSimulationJobBatchesResponseUnmarshaller.Instance;

            return Invoke<ListSimulationJobBatchesResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list simulation job batches. You can optionally provide filters to retrieve
        /// specific simulation batch jobs. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationJobBatches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSimulationJobBatches service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationJobBatches">REST API Reference for ListSimulationJobBatches Operation</seealso>
        public virtual Task<ListSimulationJobBatchesResponse> ListSimulationJobBatchesAsync(ListSimulationJobBatchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSimulationJobBatchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSimulationJobBatchesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSimulationJobBatchesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSimulationJobs

        internal virtual ListSimulationJobsResponse ListSimulationJobs(ListSimulationJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSimulationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSimulationJobsResponseUnmarshaller.Instance;

            return Invoke<ListSimulationJobsResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of simulation jobs. You can optionally provide filters to retrieve
        /// specific simulation jobs. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSimulationJobs service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationJobs">REST API Reference for ListSimulationJobs Operation</seealso>
        public virtual Task<ListSimulationJobsResponse> ListSimulationJobsAsync(ListSimulationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSimulationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSimulationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSimulationJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists all tags on a AWS RoboMaker resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorldExportJobs

        internal virtual ListWorldExportJobsResponse ListWorldExportJobs(ListWorldExportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorldExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorldExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListWorldExportJobsResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists world export jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorldExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorldExportJobs service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldExportJobs">REST API Reference for ListWorldExportJobs Operation</seealso>
        public virtual Task<ListWorldExportJobsResponse> ListWorldExportJobsAsync(ListWorldExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorldExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorldExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorldExportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorldGenerationJobs

        internal virtual ListWorldGenerationJobsResponse ListWorldGenerationJobs(ListWorldGenerationJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorldGenerationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorldGenerationJobsResponseUnmarshaller.Instance;

            return Invoke<ListWorldGenerationJobsResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists world generator jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorldGenerationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorldGenerationJobs service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldGenerationJobs">REST API Reference for ListWorldGenerationJobs Operation</seealso>
        public virtual Task<ListWorldGenerationJobsResponse> ListWorldGenerationJobsAsync(ListWorldGenerationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorldGenerationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorldGenerationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorldGenerationJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorlds

        internal virtual ListWorldsResponse ListWorlds(ListWorldsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorldsResponseUnmarshaller.Instance;

            return Invoke<ListWorldsResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists worlds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorlds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorlds service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorlds">REST API Reference for ListWorlds Operation</seealso>
        public virtual Task<ListWorldsResponse> ListWorldsAsync(ListWorldsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorldsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorldsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorldTemplates

        internal virtual ListWorldTemplatesResponse ListWorldTemplates(ListWorldTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorldTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorldTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListWorldTemplatesResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists world templates.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorldTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorldTemplates service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldTemplates">REST API Reference for ListWorldTemplates Operation</seealso>
        public virtual Task<ListWorldTemplatesResponse> ListWorldTemplatesAsync(ListWorldTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorldTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorldTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorldTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RegisterRobot

        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual RegisterRobotResponse RegisterRobot(RegisterRobotRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterRobotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterRobotResponseUnmarshaller.Instance;

            return Invoke<RegisterRobotResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Registers a robot with a fleet.
        /// </para>
        ///  <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used. For more information,
        /// see the January 31, 2022 update in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-january2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterRobot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/RegisterRobot">REST API Reference for RegisterRobot Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<RegisterRobotResponse> RegisterRobotAsync(RegisterRobotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RegisterRobotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterRobotResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterRobotResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RestartSimulationJob

        internal virtual RestartSimulationJobResponse RestartSimulationJob(RestartSimulationJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestartSimulationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestartSimulationJobResponseUnmarshaller.Instance;

            return Invoke<RestartSimulationJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Restarts a running simulation job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestartSimulationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestartSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/RestartSimulationJob">REST API Reference for RestartSimulationJob Operation</seealso>
        public virtual Task<RestartSimulationJobResponse> RestartSimulationJobAsync(RestartSimulationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestartSimulationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestartSimulationJobResponseUnmarshaller.Instance;

            return InvokeAsync<RestartSimulationJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartSimulationJobBatch

        internal virtual StartSimulationJobBatchResponse StartSimulationJobBatch(StartSimulationJobBatchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSimulationJobBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSimulationJobBatchResponseUnmarshaller.Instance;

            return Invoke<StartSimulationJobBatchResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Starts a new simulation job batch. The batch is defined using one or more <c>SimulationJobRequest</c>
        /// objects. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSimulationJobBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSimulationJobBatch service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/StartSimulationJobBatch">REST API Reference for StartSimulationJobBatch Operation</seealso>
        public virtual Task<StartSimulationJobBatchResponse> StartSimulationJobBatchAsync(StartSimulationJobBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSimulationJobBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSimulationJobBatchResponseUnmarshaller.Instance;

            return InvokeAsync<StartSimulationJobBatchResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SyncDeploymentJob

        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        internal virtual SyncDeploymentJobResponse SyncDeploymentJob(SyncDeploymentJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SyncDeploymentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SyncDeploymentJobResponseUnmarshaller.Instance;

            return Invoke<SyncDeploymentJobResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        ///  Syncrhonizes robots in a fleet to the latest deployment. This is helpful if robots
        /// were added after a deployment. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SyncDeploymentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SyncDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.ConcurrentDeploymentException">
        /// The failure percentage threshold percentage was met.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/SyncDeploymentJob">REST API Reference for SyncDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        public virtual Task<SyncDeploymentJobResponse> SyncDeploymentJobAsync(SyncDeploymentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SyncDeploymentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SyncDeploymentJobResponseUnmarshaller.Instance;

            return InvokeAsync<SyncDeploymentJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Adds or edits tags for a AWS RoboMaker resource.
        /// </para>
        ///  
        /// <para>
        /// Each tag consists of a tag key and a tag value. Tag keys and tag values are both required,
        /// but tag values can be empty strings. 
        /// </para>
        ///  
        /// <para>
        /// For information about the rules that apply to tag keys and tag values, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">User-Defined
        /// Tag Restrictions</a> in the <i>AWS Billing and Cost Management User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Removes the specified tags from the specified AWS RoboMaker resource.
        /// </para>
        ///  
        /// <para>
        /// To remove a tag, specify the tag key. To change the tag value of an existing tag key,
        /// use <a href="https://docs.aws.amazon.com/robomaker/latest/dg/API_TagResource.html">
        /// <c>TagResource</c> </a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRobotApplication

        internal virtual UpdateRobotApplicationResponse UpdateRobotApplication(UpdateRobotApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRobotApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRobotApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateRobotApplicationResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Updates a robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRobotApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateRobotApplication">REST API Reference for UpdateRobotApplication Operation</seealso>
        public virtual Task<UpdateRobotApplicationResponse> UpdateRobotApplicationAsync(UpdateRobotApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRobotApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRobotApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRobotApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSimulationApplication

        internal virtual UpdateSimulationApplicationResponse UpdateSimulationApplication(UpdateSimulationApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSimulationApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSimulationApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateSimulationApplicationResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Updates a simulation application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSimulationApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateSimulationApplication">REST API Reference for UpdateSimulationApplication Operation</seealso>
        public virtual Task<UpdateSimulationApplicationResponse> UpdateSimulationApplicationAsync(UpdateSimulationApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSimulationApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSimulationApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSimulationApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWorldTemplate

        internal virtual UpdateWorldTemplateResponse UpdateWorldTemplate(UpdateWorldTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorldTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorldTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateWorldTemplateResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Updates a world template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorldTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorldTemplate service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateWorldTemplate">REST API Reference for UpdateWorldTemplate Operation</seealso>
        public virtual Task<UpdateWorldTemplateResponse> UpdateWorldTemplateAsync(UpdateWorldTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorldTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorldTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorldTemplateResponse>(request, options, cancellationToken);
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