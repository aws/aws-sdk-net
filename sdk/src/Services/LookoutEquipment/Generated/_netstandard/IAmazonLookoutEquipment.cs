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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LookoutEquipment.Model;

namespace Amazon.LookoutEquipment
{
    /// <summary>
    /// Interface for accessing LookoutEquipment
    ///
    /// Amazon Lookout for Equipment is a machine learning service that uses advanced analytics
    /// to identify anomalies in machines from sensor data for use in predictive maintenance.
    /// </summary>
    public partial interface IAmazonLookoutEquipment : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILookoutEquipmentPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateDataset



        /// <summary>
        /// Creates a container for a collection of data being ingested for analysis. The dataset
        /// contains the metadata describing where the data is and what the data actually looks
        /// like. In other words, it contains the location of the data source, the data schema,
        /// and other information. A dataset also contains any tags associated with the ingested
        /// data.
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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInferenceScheduler



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateInferenceScheduler">REST API Reference for CreateInferenceScheduler Operation</seealso>
        Task<CreateInferenceSchedulerResponse> CreateInferenceSchedulerAsync(CreateInferenceSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLabel



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateLabel">REST API Reference for CreateLabel Operation</seealso>
        Task<CreateLabelResponse> CreateLabelAsync(CreateLabelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLabelGroup



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateLabelGroup">REST API Reference for CreateLabelGroup Operation</seealso>
        Task<CreateLabelGroupResponse> CreateLabelGroupAsync(CreateLabelGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModel



        /// <summary>
        /// Creates an ML model for data inference. 
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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataset



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInferenceScheduler



        /// <summary>
        /// Deletes an inference scheduler that has been set up. Already processed output results
        /// are not affected.
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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteInferenceScheduler">REST API Reference for DeleteInferenceScheduler Operation</seealso>
        Task<DeleteInferenceSchedulerResponse> DeleteInferenceSchedulerAsync(DeleteInferenceSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLabel



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        Task<DeleteLabelResponse> DeleteLabelAsync(DeleteLabelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLabelGroup



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteLabelGroup">REST API Reference for DeleteLabelGroup Operation</seealso>
        Task<DeleteLabelGroupResponse> DeleteLabelGroupAsync(DeleteLabelGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModel



        /// <summary>
        /// Deletes an ML model currently available for Amazon Lookout for Equipment. This will
        /// prevent it from being used with an inference scheduler, even one that is already set
        /// up.
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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDataIngestionJob



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeDataIngestionJob">REST API Reference for DescribeDataIngestionJob Operation</seealso>
        Task<DescribeDataIngestionJobResponse> DescribeDataIngestionJobAsync(DescribeDataIngestionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDataset



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInferenceScheduler



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeInferenceScheduler">REST API Reference for DescribeInferenceScheduler Operation</seealso>
        Task<DescribeInferenceSchedulerResponse> DescribeInferenceSchedulerAsync(DescribeInferenceSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLabel



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeLabel">REST API Reference for DescribeLabel Operation</seealso>
        Task<DescribeLabelResponse> DescribeLabelAsync(DescribeLabelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLabelGroup



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeLabelGroup">REST API Reference for DescribeLabelGroup Operation</seealso>
        Task<DescribeLabelGroupResponse> DescribeLabelGroupAsync(DescribeLabelGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeModel



        /// <summary>
        /// Provides a JSON containing the overall information about a specific ML model, including
        /// model name and ARN, dataset, training and evaluation information, status, and so on.
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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        Task<DescribeModelResponse> DescribeModelAsync(DescribeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataIngestionJobs



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListDataIngestionJobs">REST API Reference for ListDataIngestionJobs Operation</seealso>
        Task<ListDataIngestionJobsResponse> ListDataIngestionJobsAsync(ListDataIngestionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDatasets



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInferenceEvents



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceEvents">REST API Reference for ListInferenceEvents Operation</seealso>
        Task<ListInferenceEventsResponse> ListInferenceEventsAsync(ListInferenceEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInferenceExecutions



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceExecutions">REST API Reference for ListInferenceExecutions Operation</seealso>
        Task<ListInferenceExecutionsResponse> ListInferenceExecutionsAsync(ListInferenceExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInferenceSchedulers



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceSchedulers">REST API Reference for ListInferenceSchedulers Operation</seealso>
        Task<ListInferenceSchedulersResponse> ListInferenceSchedulersAsync(ListInferenceSchedulersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLabelGroups



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListLabelGroups">REST API Reference for ListLabelGroups Operation</seealso>
        Task<ListLabelGroupsResponse> ListLabelGroupsAsync(ListLabelGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLabels



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListLabels">REST API Reference for ListLabels Operation</seealso>
        Task<ListLabelsResponse> ListLabelsAsync(ListLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListModels



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListModels">REST API Reference for ListModels Operation</seealso>
        Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSensorStatistics



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListSensorStatistics">REST API Reference for ListSensorStatistics Operation</seealso>
        Task<ListSensorStatisticsResponse> ListSensorStatisticsAsync(ListSensorStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDataIngestionJob



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartDataIngestionJob">REST API Reference for StartDataIngestionJob Operation</seealso>
        Task<StartDataIngestionJobResponse> StartDataIngestionJobAsync(StartDataIngestionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartInferenceScheduler



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartInferenceScheduler">REST API Reference for StartInferenceScheduler Operation</seealso>
        Task<StartInferenceSchedulerResponse> StartInferenceSchedulerAsync(StartInferenceSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopInferenceScheduler



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StopInferenceScheduler">REST API Reference for StopInferenceScheduler Operation</seealso>
        Task<StopInferenceSchedulerResponse> StopInferenceSchedulerAsync(StopInferenceSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateInferenceScheduler



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateInferenceScheduler">REST API Reference for UpdateInferenceScheduler Operation</seealso>
        Task<UpdateInferenceSchedulerResponse> UpdateInferenceSchedulerAsync(UpdateInferenceSchedulerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateLabelGroup



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
        /// or a related AWS service that's being utilized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateLabelGroup">REST API Reference for UpdateLabelGroup Operation</seealso>
        Task<UpdateLabelGroupResponse> UpdateLabelGroupAsync(UpdateLabelGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}