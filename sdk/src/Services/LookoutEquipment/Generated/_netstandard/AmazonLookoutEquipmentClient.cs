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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.LookoutEquipment.Model;
using Amazon.LookoutEquipment.Model.Internal.MarshallTransformations;
using Amazon.LookoutEquipment.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.LookoutEquipment
{
    /// <summary>
    /// <para>Implementation for accessing LookoutEquipment</para>
    ///
    /// Amazon Lookout for Equipment is a machine learning service that uses advanced analytics
    /// to identify anomalies in machines from sensor data for use in predictive maintenance.
    /// </summary>
    public partial class AmazonLookoutEquipmentClient : AmazonServiceClient, IAmazonLookoutEquipment
    {
        private static IServiceMetadata serviceMetadata = new AmazonLookoutEquipmentMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with the credentials loaded from the application's
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
        public AmazonLookoutEquipmentClient()
            : base(new AmazonLookoutEquipmentConfig()) { }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with the credentials loaded from the application's
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
        public AmazonLookoutEquipmentClient(RegionEndpoint region)
            : base(new AmazonLookoutEquipmentConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLookoutEquipmentClient Configuration Object</param>
        public AmazonLookoutEquipmentClient(AmazonLookoutEquipmentConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLookoutEquipmentClient(AWSCredentials credentials)
            : this(credentials, new AmazonLookoutEquipmentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLookoutEquipmentClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLookoutEquipmentConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Credentials and an
        /// AmazonLookoutEquipmentClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLookoutEquipmentClient Configuration Object</param>
        public AmazonLookoutEquipmentClient(AWSCredentials credentials, AmazonLookoutEquipmentConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLookoutEquipmentClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLookoutEquipmentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLookoutEquipmentClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLookoutEquipmentConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLookoutEquipmentClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLookoutEquipmentClient Configuration Object</param>
        public AmazonLookoutEquipmentClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLookoutEquipmentConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLookoutEquipmentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLookoutEquipmentConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLookoutEquipmentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLookoutEquipmentConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLookoutEquipmentClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLookoutEquipmentClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLookoutEquipmentClient Configuration Object</param>
        public AmazonLookoutEquipmentClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLookoutEquipmentConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ILookoutEquipmentPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILookoutEquipmentPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new LookoutEquipmentPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLookoutEquipmentEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLookoutEquipmentAuthSchemeHandler());
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


        #region  CreateDataset

        internal virtual CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetResponse>(request, options);
        }



        /// <summary>
        /// Creates a container for a collection of data being ingested for analysis. The dataset
        /// contains the metadata describing where the data is and what the data actually looks
        /// like. For example, it contains the location of the data source, the data schema, and
        /// other information. A dataset also contains any tags associated with the ingested data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateInferenceScheduler

        internal virtual CreateInferenceSchedulerResponse CreateInferenceScheduler(CreateInferenceSchedulerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInferenceSchedulerResponseUnmarshaller.Instance;

            return Invoke<CreateInferenceSchedulerResponse>(request, options);
        }



        /// <summary>
        /// Creates a scheduled inference. Scheduling an inference is setting up a continuous
        /// real-time inference plan to analyze new measurement data. When setting up the schedule,
        /// you provide an S3 bucket location for the input data, assign it a delimiter between
        /// separate entries in the data, set an offset delay if desired, and set the frequency
        /// of inferencing. You must also provide an S3 bucket location for the output data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceScheduler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInferenceScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateInferenceScheduler">REST API Reference for CreateInferenceScheduler Operation</seealso>
        public virtual Task<CreateInferenceSchedulerResponse> CreateInferenceSchedulerAsync(CreateInferenceSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInferenceSchedulerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInferenceSchedulerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateLabel

        internal virtual CreateLabelResponse CreateLabel(CreateLabelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelResponseUnmarshaller.Instance;

            return Invoke<CreateLabelResponse>(request, options);
        }



        /// <summary>
        /// Creates a label for an event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLabel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLabel service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateLabel">REST API Reference for CreateLabel Operation</seealso>
        public virtual Task<CreateLabelResponse> CreateLabelAsync(CreateLabelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLabelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateLabelGroup

        internal virtual CreateLabelGroupResponse CreateLabelGroup(CreateLabelGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelGroupResponseUnmarshaller.Instance;

            return Invoke<CreateLabelGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a group of labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLabelGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLabelGroup service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateLabelGroup">REST API Reference for CreateLabelGroup Operation</seealso>
        public virtual Task<CreateLabelGroupResponse> CreateLabelGroupAsync(CreateLabelGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLabelGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLabelGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateModel

        internal virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelResponse>(request, options);
        }



        /// <summary>
        /// Creates a machine learning model for data inference. 
        /// 
        ///  
        /// <para>
        /// A machine-learning (ML) model is a mathematical model that finds patterns in your
        /// data. In Amazon Lookout for Equipment, the model learns the patterns of normal behavior
        /// and detects abnormal behavior that could be potential equipment failure (or maintenance
        /// events). The models are made by analyzing normal data and abnormalities in machine
        /// behavior that have already occurred.
        /// </para>
        ///  
        /// <para>
        /// Your model is trained using a portion of the data from your dataset and uses that
        /// data to learn patterns of normal behavior and abnormal patterns that lead to equipment
        /// failure. Another portion of the data is used to evaluate the model's accuracy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRetrainingScheduler

        internal virtual CreateRetrainingSchedulerResponse CreateRetrainingScheduler(CreateRetrainingSchedulerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRetrainingSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRetrainingSchedulerResponseUnmarshaller.Instance;

            return Invoke<CreateRetrainingSchedulerResponse>(request, options);
        }



        /// <summary>
        /// Creates a retraining scheduler on the specified model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRetrainingScheduler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRetrainingScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateRetrainingScheduler">REST API Reference for CreateRetrainingScheduler Operation</seealso>
        public virtual Task<CreateRetrainingSchedulerResponse> CreateRetrainingSchedulerAsync(CreateRetrainingSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRetrainingSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRetrainingSchedulerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRetrainingSchedulerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDataset

        internal virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetResponse>(request, options);
        }



        /// <summary>
        /// Deletes a dataset and associated artifacts. The operation will check to see if any
        /// inference scheduler or data ingestion job is currently using the dataset, and if there
        /// isn't, the dataset, its metadata, and any associated data stored in S3 will be deleted.
        /// This does not affect any models that used this dataset for training and evaluation,
        /// but does prevent it from being used in the future.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteInferenceScheduler

        internal virtual DeleteInferenceSchedulerResponse DeleteInferenceScheduler(DeleteInferenceSchedulerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInferenceSchedulerResponseUnmarshaller.Instance;

            return Invoke<DeleteInferenceSchedulerResponse>(request, options);
        }



        /// <summary>
        /// Deletes an inference scheduler that has been set up. Prior inference results will
        /// not be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInferenceScheduler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInferenceScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteInferenceScheduler">REST API Reference for DeleteInferenceScheduler Operation</seealso>
        public virtual Task<DeleteInferenceSchedulerResponse> DeleteInferenceSchedulerAsync(DeleteInferenceSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInferenceSchedulerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInferenceSchedulerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteLabel

        internal virtual DeleteLabelResponse DeleteLabel(DeleteLabelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLabelResponseUnmarshaller.Instance;

            return Invoke<DeleteLabelResponse>(request, options);
        }



        /// <summary>
        /// Deletes a label.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLabel service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        public virtual Task<DeleteLabelResponse> DeleteLabelAsync(DeleteLabelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLabelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLabelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteLabelGroup

        internal virtual DeleteLabelGroupResponse DeleteLabelGroup(DeleteLabelGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLabelGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteLabelGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a group of labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabelGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLabelGroup service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteLabelGroup">REST API Reference for DeleteLabelGroup Operation</seealso>
        public virtual Task<DeleteLabelGroupResponse> DeleteLabelGroupAsync(DeleteLabelGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLabelGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLabelGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteModel

        internal virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelResponse>(request, options);
        }



        /// <summary>
        /// Deletes a machine learning model currently available for Amazon Lookout for Equipment.
        /// This will prevent it from being used with an inference scheduler, even one that is
        /// already set up.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the resource policy attached to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRetrainingScheduler

        internal virtual DeleteRetrainingSchedulerResponse DeleteRetrainingScheduler(DeleteRetrainingSchedulerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRetrainingSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetrainingSchedulerResponseUnmarshaller.Instance;

            return Invoke<DeleteRetrainingSchedulerResponse>(request, options);
        }



        /// <summary>
        /// Deletes a retraining scheduler from a model. The retraining scheduler must be in the
        /// <c>STOPPED</c> status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetrainingScheduler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRetrainingScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteRetrainingScheduler">REST API Reference for DeleteRetrainingScheduler Operation</seealso>
        public virtual Task<DeleteRetrainingSchedulerResponse> DeleteRetrainingSchedulerAsync(DeleteRetrainingSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRetrainingSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetrainingSchedulerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRetrainingSchedulerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDataIngestionJob

        internal virtual DescribeDataIngestionJobResponse DescribeDataIngestionJob(DescribeDataIngestionJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDataIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataIngestionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDataIngestionJobResponse>(request, options);
        }



        /// <summary>
        /// Provides information on a specific data ingestion job such as creation time, dataset
        /// ARN, and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataIngestionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataIngestionJob service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeDataIngestionJob">REST API Reference for DescribeDataIngestionJob Operation</seealso>
        public virtual Task<DescribeDataIngestionJobResponse> DescribeDataIngestionJobAsync(DescribeDataIngestionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDataIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDataIngestionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDataIngestionJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDataset

        internal virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetResponse>(request, options);
        }



        /// <summary>
        /// Provides a JSON description of the data in each time series dataset, including names,
        /// column names, and data types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeInferenceScheduler

        internal virtual DescribeInferenceSchedulerResponse DescribeInferenceScheduler(DescribeInferenceSchedulerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInferenceSchedulerResponseUnmarshaller.Instance;

            return Invoke<DescribeInferenceSchedulerResponse>(request, options);
        }



        /// <summary>
        /// Specifies information about the inference scheduler being used, including name, model,
        /// status, and associated metadata
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInferenceScheduler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInferenceScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeInferenceScheduler">REST API Reference for DescribeInferenceScheduler Operation</seealso>
        public virtual Task<DescribeInferenceSchedulerResponse> DescribeInferenceSchedulerAsync(DescribeInferenceSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInferenceSchedulerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInferenceSchedulerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeLabel

        internal virtual DescribeLabelResponse DescribeLabel(DescribeLabelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLabelResponseUnmarshaller.Instance;

            return Invoke<DescribeLabelResponse>(request, options);
        }



        /// <summary>
        /// Returns the name of the label.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLabel service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeLabel">REST API Reference for DescribeLabel Operation</seealso>
        public virtual Task<DescribeLabelResponse> DescribeLabelAsync(DescribeLabelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLabelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLabelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeLabelGroup

        internal virtual DescribeLabelGroupResponse DescribeLabelGroup(DescribeLabelGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLabelGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeLabelGroupResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the label group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabelGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLabelGroup service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeLabelGroup">REST API Reference for DescribeLabelGroup Operation</seealso>
        public virtual Task<DescribeLabelGroupResponse> DescribeLabelGroupAsync(DescribeLabelGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLabelGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLabelGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeModel

        internal virtual DescribeModelResponse DescribeModel(DescribeModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelResponseUnmarshaller.Instance;

            return Invoke<DescribeModelResponse>(request, options);
        }



        /// <summary>
        /// Provides a JSON containing the overall information about a specific machine learning
        /// model, including model name and ARN, dataset, training and evaluation information,
        /// status, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModel service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        public virtual Task<DescribeModelResponse> DescribeModelAsync(DescribeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeModelVersion

        internal virtual DescribeModelVersionResponse DescribeModelVersion(DescribeModelVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelVersionResponseUnmarshaller.Instance;

            return Invoke<DescribeModelVersionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a specific machine learning model version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeModelVersion service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeModelVersion">REST API Reference for DescribeModelVersion Operation</seealso>
        public virtual Task<DescribeModelVersionResponse> DescribeModelVersionAsync(DescribeModelVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeModelVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeModelVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeResourcePolicy

        internal virtual DescribeResourcePolicyResponse DescribeResourcePolicy(DescribeResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Provides the details of a resource policy attached to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResourcePolicy service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        public virtual Task<DescribeResourcePolicyResponse> DescribeResourcePolicyAsync(DescribeResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRetrainingScheduler

        internal virtual DescribeRetrainingSchedulerResponse DescribeRetrainingScheduler(DescribeRetrainingSchedulerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRetrainingSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRetrainingSchedulerResponseUnmarshaller.Instance;

            return Invoke<DescribeRetrainingSchedulerResponse>(request, options);
        }



        /// <summary>
        /// Provides a description of the retraining scheduler, including information such as
        /// the model name and retraining parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRetrainingScheduler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRetrainingScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeRetrainingScheduler">REST API Reference for DescribeRetrainingScheduler Operation</seealso>
        public virtual Task<DescribeRetrainingSchedulerResponse> DescribeRetrainingSchedulerAsync(DescribeRetrainingSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRetrainingSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRetrainingSchedulerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRetrainingSchedulerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ImportDataset

        internal virtual ImportDatasetResponse ImportDataset(ImportDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportDatasetResponseUnmarshaller.Instance;

            return Invoke<ImportDatasetResponse>(request, options);
        }



        /// <summary>
        /// Imports a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportDataset service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ImportDataset">REST API Reference for ImportDataset Operation</seealso>
        public virtual Task<ImportDatasetResponse> ImportDatasetAsync(ImportDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<ImportDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ImportModelVersion

        internal virtual ImportModelVersionResponse ImportModelVersion(ImportModelVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportModelVersionResponseUnmarshaller.Instance;

            return Invoke<ImportModelVersionResponse>(request, options);
        }



        /// <summary>
        /// Imports a model that has been trained successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportModelVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportModelVersion service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ImportModelVersion">REST API Reference for ImportModelVersion Operation</seealso>
        public virtual Task<ImportModelVersionResponse> ImportModelVersionAsync(ImportModelVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportModelVersionResponseUnmarshaller.Instance;

            return InvokeAsync<ImportModelVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDataIngestionJobs

        internal virtual ListDataIngestionJobsResponse ListDataIngestionJobs(ListDataIngestionJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataIngestionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIngestionJobsResponseUnmarshaller.Instance;

            return Invoke<ListDataIngestionJobsResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of all data ingestion jobs, including dataset name and ARN, S3 location
        /// of the input data, status, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIngestionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataIngestionJobs service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListDataIngestionJobs">REST API Reference for ListDataIngestionJobs Operation</seealso>
        public virtual Task<ListDataIngestionJobsResponse> ListDataIngestionJobsAsync(ListDataIngestionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataIngestionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataIngestionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDataIngestionJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDatasets

        internal virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsResponse>(request, options);
        }



        /// <summary>
        /// Lists all datasets currently available in your account, filtering on the dataset name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListInferenceEvents

        internal virtual ListInferenceEventsResponse ListInferenceEvents(ListInferenceEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInferenceEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceEventsResponseUnmarshaller.Instance;

            return Invoke<ListInferenceEventsResponse>(request, options);
        }



        /// <summary>
        /// Lists all inference events that have been found for the specified inference scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInferenceEvents service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceEvents">REST API Reference for ListInferenceEvents Operation</seealso>
        public virtual Task<ListInferenceEventsResponse> ListInferenceEventsAsync(ListInferenceEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInferenceEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceEventsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInferenceEventsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListInferenceExecutions

        internal virtual ListInferenceExecutionsResponse ListInferenceExecutions(ListInferenceExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInferenceExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListInferenceExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all inference executions that have been performed by the specified inference
        /// scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInferenceExecutions service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceExecutions">REST API Reference for ListInferenceExecutions Operation</seealso>
        public virtual Task<ListInferenceExecutionsResponse> ListInferenceExecutionsAsync(ListInferenceExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInferenceExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInferenceExecutionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListInferenceSchedulers

        internal virtual ListInferenceSchedulersResponse ListInferenceSchedulers(ListInferenceSchedulersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInferenceSchedulersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceSchedulersResponseUnmarshaller.Instance;

            return Invoke<ListInferenceSchedulersResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of all inference schedulers currently available for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceSchedulers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInferenceSchedulers service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceSchedulers">REST API Reference for ListInferenceSchedulers Operation</seealso>
        public virtual Task<ListInferenceSchedulersResponse> ListInferenceSchedulersAsync(ListInferenceSchedulersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInferenceSchedulersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInferenceSchedulersResponseUnmarshaller.Instance;

            return InvokeAsync<ListInferenceSchedulersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLabelGroups

        internal virtual ListLabelGroupsResponse ListLabelGroups(ListLabelGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLabelGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelGroupsResponseUnmarshaller.Instance;

            return Invoke<ListLabelGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the label groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabelGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLabelGroups service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListLabelGroups">REST API Reference for ListLabelGroups Operation</seealso>
        public virtual Task<ListLabelGroupsResponse> ListLabelGroupsAsync(ListLabelGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLabelGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLabelGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLabels

        internal virtual ListLabelsResponse ListLabels(ListLabelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelsResponseUnmarshaller.Instance;

            return Invoke<ListLabelsResponse>(request, options);
        }



        /// <summary>
        /// Provides a list of labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLabels service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListLabels">REST API Reference for ListLabels Operation</seealso>
        public virtual Task<ListLabelsResponse> ListLabelsAsync(ListLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLabelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListModels

        internal virtual ListModelsResponse ListModels(ListModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return Invoke<ListModelsResponse>(request, options);
        }



        /// <summary>
        /// Generates a list of all models in the account, including model name and ARN, dataset,
        /// and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModels service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListModels">REST API Reference for ListModels Operation</seealso>
        public virtual Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListModelVersions

        internal virtual ListModelVersionsResponse ListModelVersions(ListModelVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelVersionsResponseUnmarshaller.Instance;

            return Invoke<ListModelVersionsResponse>(request, options);
        }



        /// <summary>
        /// Generates a list of all model versions for a given model, including the model version,
        /// model version ARN, and status. To list a subset of versions, use the <c>MaxModelVersion</c>
        /// and <c>MinModelVersion</c> fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelVersions service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListModelVersions">REST API Reference for ListModelVersions Operation</seealso>
        public virtual Task<ListModelVersionsResponse> ListModelVersionsAsync(ListModelVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListModelVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListModelVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListModelVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRetrainingSchedulers

        internal virtual ListRetrainingSchedulersResponse ListRetrainingSchedulers(ListRetrainingSchedulersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRetrainingSchedulersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetrainingSchedulersResponseUnmarshaller.Instance;

            return Invoke<ListRetrainingSchedulersResponse>(request, options);
        }



        /// <summary>
        /// Lists all retraining schedulers in your account, filtering by model name prefix and
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetrainingSchedulers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetrainingSchedulers service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListRetrainingSchedulers">REST API Reference for ListRetrainingSchedulers Operation</seealso>
        public virtual Task<ListRetrainingSchedulersResponse> ListRetrainingSchedulersAsync(ListRetrainingSchedulersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRetrainingSchedulersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetrainingSchedulersResponseUnmarshaller.Instance;

            return InvokeAsync<ListRetrainingSchedulersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSensorStatistics

        internal virtual ListSensorStatisticsResponse ListSensorStatistics(ListSensorStatisticsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSensorStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSensorStatisticsResponseUnmarshaller.Instance;

            return Invoke<ListSensorStatisticsResponse>(request, options);
        }



        /// <summary>
        /// Lists statistics about the data collected for each of the sensors that have been
        /// successfully ingested in the particular dataset. Can also be used to retreive Sensor
        /// Statistics for a previous ingestion job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSensorStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSensorStatistics service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListSensorStatistics">REST API Reference for ListSensorStatistics Operation</seealso>
        public virtual Task<ListSensorStatisticsResponse> ListSensorStatisticsAsync(ListSensorStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSensorStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSensorStatisticsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSensorStatisticsResponse>(request, options, cancellationToken);
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
        /// Lists all the tags for a specified resource, including key and value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates a resource control policy for a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartDataIngestionJob

        internal virtual StartDataIngestionJobResponse StartDataIngestionJob(StartDataIngestionJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDataIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataIngestionJobResponseUnmarshaller.Instance;

            return Invoke<StartDataIngestionJobResponse>(request, options);
        }



        /// <summary>
        /// Starts a data ingestion job. Amazon Lookout for Equipment returns the job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataIngestionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDataIngestionJob service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartDataIngestionJob">REST API Reference for StartDataIngestionJob Operation</seealso>
        public virtual Task<StartDataIngestionJobResponse> StartDataIngestionJobAsync(StartDataIngestionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDataIngestionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataIngestionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartDataIngestionJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartInferenceScheduler

        internal virtual StartInferenceSchedulerResponse StartInferenceScheduler(StartInferenceSchedulerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInferenceSchedulerResponseUnmarshaller.Instance;

            return Invoke<StartInferenceSchedulerResponse>(request, options);
        }



        /// <summary>
        /// Starts an inference scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInferenceScheduler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartInferenceScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartInferenceScheduler">REST API Reference for StartInferenceScheduler Operation</seealso>
        public virtual Task<StartInferenceSchedulerResponse> StartInferenceSchedulerAsync(StartInferenceSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInferenceSchedulerResponseUnmarshaller.Instance;

            return InvokeAsync<StartInferenceSchedulerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartRetrainingScheduler

        internal virtual StartRetrainingSchedulerResponse StartRetrainingScheduler(StartRetrainingSchedulerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRetrainingSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRetrainingSchedulerResponseUnmarshaller.Instance;

            return Invoke<StartRetrainingSchedulerResponse>(request, options);
        }



        /// <summary>
        /// Starts a retraining scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRetrainingScheduler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartRetrainingScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartRetrainingScheduler">REST API Reference for StartRetrainingScheduler Operation</seealso>
        public virtual Task<StartRetrainingSchedulerResponse> StartRetrainingSchedulerAsync(StartRetrainingSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartRetrainingSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRetrainingSchedulerResponseUnmarshaller.Instance;

            return InvokeAsync<StartRetrainingSchedulerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopInferenceScheduler

        internal virtual StopInferenceSchedulerResponse StopInferenceScheduler(StopInferenceSchedulerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInferenceSchedulerResponseUnmarshaller.Instance;

            return Invoke<StopInferenceSchedulerResponse>(request, options);
        }



        /// <summary>
        /// Stops an inference scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInferenceScheduler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopInferenceScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StopInferenceScheduler">REST API Reference for StopInferenceScheduler Operation</seealso>
        public virtual Task<StopInferenceSchedulerResponse> StopInferenceSchedulerAsync(StopInferenceSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInferenceSchedulerResponseUnmarshaller.Instance;

            return InvokeAsync<StopInferenceSchedulerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopRetrainingScheduler

        internal virtual StopRetrainingSchedulerResponse StopRetrainingScheduler(StopRetrainingSchedulerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopRetrainingSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRetrainingSchedulerResponseUnmarshaller.Instance;

            return Invoke<StopRetrainingSchedulerResponse>(request, options);
        }



        /// <summary>
        /// Stops a retraining scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRetrainingScheduler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopRetrainingScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StopRetrainingScheduler">REST API Reference for StopRetrainingScheduler Operation</seealso>
        public virtual Task<StopRetrainingSchedulerResponse> StopRetrainingSchedulerAsync(StopRetrainingSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopRetrainingSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopRetrainingSchedulerResponseUnmarshaller.Instance;

            return InvokeAsync<StopRetrainingSchedulerResponse>(request, options, cancellationToken);
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
        /// Associates a given tag to a resource in your account. A tag is a key-value pair which
        /// can be added to an Amazon Lookout for Equipment resource as metadata. Tags can be
        /// used for organizing your resources as well as helping you to search and filter by
        /// tag. Multiple tags can be added to a resource, either when you create it, or later.
        /// Up to 50 tags can be associated with each resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ServiceQuotaExceededException">
        /// Resource limitations have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes a specific tag from a given resource. The tag is specified by its key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateActiveModelVersion

        internal virtual UpdateActiveModelVersionResponse UpdateActiveModelVersion(UpdateActiveModelVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateActiveModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateActiveModelVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateActiveModelVersionResponse>(request, options);
        }



        /// <summary>
        /// Sets the active model version for a given machine learning model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateActiveModelVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateActiveModelVersion service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateActiveModelVersion">REST API Reference for UpdateActiveModelVersion Operation</seealso>
        public virtual Task<UpdateActiveModelVersionResponse> UpdateActiveModelVersionAsync(UpdateActiveModelVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateActiveModelVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateActiveModelVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateActiveModelVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateInferenceScheduler

        internal virtual UpdateInferenceSchedulerResponse UpdateInferenceScheduler(UpdateInferenceSchedulerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInferenceSchedulerResponseUnmarshaller.Instance;

            return Invoke<UpdateInferenceSchedulerResponse>(request, options);
        }



        /// <summary>
        /// Updates an inference scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInferenceScheduler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInferenceScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateInferenceScheduler">REST API Reference for UpdateInferenceScheduler Operation</seealso>
        public virtual Task<UpdateInferenceSchedulerResponse> UpdateInferenceSchedulerAsync(UpdateInferenceSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInferenceSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInferenceSchedulerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateInferenceSchedulerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateLabelGroup

        internal virtual UpdateLabelGroupResponse UpdateLabelGroup(UpdateLabelGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLabelGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateLabelGroupResponse>(request, options);
        }



        /// <summary>
        /// Updates the label group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLabelGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLabelGroup service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateLabelGroup">REST API Reference for UpdateLabelGroup Operation</seealso>
        public virtual Task<UpdateLabelGroupResponse> UpdateLabelGroupAsync(UpdateLabelGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLabelGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLabelGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLabelGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateModel

        internal virtual UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return Invoke<UpdateModelResponse>(request, options);
        }



        /// <summary>
        /// Updates a model in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateModel service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        public virtual Task<UpdateModelResponse> UpdateModelAsync(UpdateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRetrainingScheduler

        internal virtual UpdateRetrainingSchedulerResponse UpdateRetrainingScheduler(UpdateRetrainingSchedulerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRetrainingSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRetrainingSchedulerResponseUnmarshaller.Instance;

            return Invoke<UpdateRetrainingSchedulerResponse>(request, options);
        }



        /// <summary>
        /// Updates a retraining scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRetrainingScheduler service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRetrainingScheduler service method, as returned by LookoutEquipment.</returns>
        /// <exception cref="Amazon.LookoutEquipment.Model.AccessDeniedException">
        /// The request could not be completed because you do not have access to the resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.InternalServerException">
        /// Processing of the request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ResourceNotFoundException">
        /// The resource requested could not be found. Verify the resource ID and retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.LookoutEquipment.Model.ValidationException">
        /// The input fails to satisfy constraints specified by Amazon Lookout for Equipment
        /// or a related Amazon Web Services service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateRetrainingScheduler">REST API Reference for UpdateRetrainingScheduler Operation</seealso>
        public virtual Task<UpdateRetrainingSchedulerResponse> UpdateRetrainingSchedulerAsync(UpdateRetrainingSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRetrainingSchedulerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRetrainingSchedulerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRetrainingSchedulerResponse>(request, options, cancellationToken);
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