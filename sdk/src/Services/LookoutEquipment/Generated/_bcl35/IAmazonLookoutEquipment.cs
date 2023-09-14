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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILookoutEquipmentPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateDataset


        /// <summary>
        /// Creates a container for a collection of data being ingested for analysis. The dataset
        /// contains the metadata describing where the data is and what the data actually looks
        /// like. For example, it contains the location of the data source, the data schema, and
        /// other information. A dataset also contains any tags associated with the ingested data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
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
        CreateDatasetResponse CreateDataset(CreateDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        IAsyncResult BeginCreateDataset(CreateDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataset.</param>
        /// 
        /// <returns>Returns a  CreateDatasetResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse EndCreateDataset(IAsyncResult asyncResult);

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
        CreateInferenceSchedulerResponse CreateInferenceScheduler(CreateInferenceSchedulerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInferenceScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInferenceScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateInferenceScheduler">REST API Reference for CreateInferenceScheduler Operation</seealso>
        IAsyncResult BeginCreateInferenceScheduler(CreateInferenceSchedulerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInferenceScheduler.</param>
        /// 
        /// <returns>Returns a  CreateInferenceSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateInferenceScheduler">REST API Reference for CreateInferenceScheduler Operation</seealso>
        CreateInferenceSchedulerResponse EndCreateInferenceScheduler(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLabel


        /// <summary>
        /// Creates a label for an event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLabel service method.</param>
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
        CreateLabelResponse CreateLabel(CreateLabelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLabel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLabel operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLabel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateLabel">REST API Reference for CreateLabel Operation</seealso>
        IAsyncResult BeginCreateLabel(CreateLabelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLabel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLabel.</param>
        /// 
        /// <returns>Returns a  CreateLabelResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateLabel">REST API Reference for CreateLabel Operation</seealso>
        CreateLabelResponse EndCreateLabel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLabelGroup


        /// <summary>
        /// Creates a group of labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLabelGroup service method.</param>
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
        CreateLabelGroupResponse CreateLabelGroup(CreateLabelGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLabelGroup operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLabelGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateLabelGroup">REST API Reference for CreateLabelGroup Operation</seealso>
        IAsyncResult BeginCreateLabelGroup(CreateLabelGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLabelGroup.</param>
        /// 
        /// <returns>Returns a  CreateLabelGroupResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateLabelGroup">REST API Reference for CreateLabelGroup Operation</seealso>
        CreateLabelGroupResponse EndCreateLabelGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateModel


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
        CreateModelResponse CreateModel(CreateModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        CreateModelResponse EndCreateModel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRetrainingScheduler


        /// <summary>
        /// Creates a retraining scheduler on the specified model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRetrainingScheduler service method.</param>
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
        CreateRetrainingSchedulerResponse CreateRetrainingScheduler(CreateRetrainingSchedulerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRetrainingScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRetrainingScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRetrainingScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateRetrainingScheduler">REST API Reference for CreateRetrainingScheduler Operation</seealso>
        IAsyncResult BeginCreateRetrainingScheduler(CreateRetrainingSchedulerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRetrainingScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRetrainingScheduler.</param>
        /// 
        /// <returns>Returns a  CreateRetrainingSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/CreateRetrainingScheduler">REST API Reference for CreateRetrainingScheduler Operation</seealso>
        CreateRetrainingSchedulerResponse EndCreateRetrainingScheduler(IAsyncResult asyncResult);

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
        DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInferenceScheduler


        /// <summary>
        /// Deletes an inference scheduler that has been set up. Prior inference results will
        /// not be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInferenceScheduler service method.</param>
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
        DeleteInferenceSchedulerResponse DeleteInferenceScheduler(DeleteInferenceSchedulerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInferenceScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInferenceScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteInferenceScheduler">REST API Reference for DeleteInferenceScheduler Operation</seealso>
        IAsyncResult BeginDeleteInferenceScheduler(DeleteInferenceSchedulerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInferenceScheduler.</param>
        /// 
        /// <returns>Returns a  DeleteInferenceSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteInferenceScheduler">REST API Reference for DeleteInferenceScheduler Operation</seealso>
        DeleteInferenceSchedulerResponse EndDeleteInferenceScheduler(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLabel


        /// <summary>
        /// Deletes a label.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabel service method.</param>
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
        DeleteLabelResponse DeleteLabel(DeleteLabelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLabel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabel operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLabel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        IAsyncResult BeginDeleteLabel(DeleteLabelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLabel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLabel.</param>
        /// 
        /// <returns>Returns a  DeleteLabelResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        DeleteLabelResponse EndDeleteLabel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLabelGroup


        /// <summary>
        /// Deletes a group of labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabelGroup service method.</param>
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
        DeleteLabelGroupResponse DeleteLabelGroup(DeleteLabelGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabelGroup operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLabelGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteLabelGroup">REST API Reference for DeleteLabelGroup Operation</seealso>
        IAsyncResult BeginDeleteLabelGroup(DeleteLabelGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLabelGroup.</param>
        /// 
        /// <returns>Returns a  DeleteLabelGroupResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteLabelGroup">REST API Reference for DeleteLabelGroup Operation</seealso>
        DeleteLabelGroupResponse EndDeleteLabelGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModel


        /// <summary>
        /// Deletes a machine learning model currently available for Amazon Lookout for Equipment.
        /// This will prevent it from being used with an inference scheduler, even one that is
        /// already set up.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
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
        DeleteModelResponse DeleteModel(DeleteModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes the resource policy attached to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
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
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRetrainingScheduler


        /// <summary>
        /// Deletes a retraining scheduler from a model. The retraining scheduler must be in the
        /// <code>STOPPED</code> status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetrainingScheduler service method.</param>
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
        DeleteRetrainingSchedulerResponse DeleteRetrainingScheduler(DeleteRetrainingSchedulerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRetrainingScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetrainingScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRetrainingScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteRetrainingScheduler">REST API Reference for DeleteRetrainingScheduler Operation</seealso>
        IAsyncResult BeginDeleteRetrainingScheduler(DeleteRetrainingSchedulerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRetrainingScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRetrainingScheduler.</param>
        /// 
        /// <returns>Returns a  DeleteRetrainingSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DeleteRetrainingScheduler">REST API Reference for DeleteRetrainingScheduler Operation</seealso>
        DeleteRetrainingSchedulerResponse EndDeleteRetrainingScheduler(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataIngestionJob


        /// <summary>
        /// Provides information on a specific data ingestion job such as creation time, dataset
        /// ARN, and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataIngestionJob service method.</param>
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
        DescribeDataIngestionJobResponse DescribeDataIngestionJob(DescribeDataIngestionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataIngestionJob operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataIngestionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeDataIngestionJob">REST API Reference for DescribeDataIngestionJob Operation</seealso>
        IAsyncResult BeginDescribeDataIngestionJob(DescribeDataIngestionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataIngestionJob.</param>
        /// 
        /// <returns>Returns a  DescribeDataIngestionJobResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeDataIngestionJob">REST API Reference for DescribeDataIngestionJob Operation</seealso>
        DescribeDataIngestionJobResponse EndDescribeDataIngestionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataset


        /// <summary>
        /// Provides a JSON description of the data in each time series dataset, including names,
        /// column names, and data types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
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
        DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInferenceScheduler


        /// <summary>
        /// Specifies information about the inference scheduler being used, including name, model,
        /// status, and associated metadata
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInferenceScheduler service method.</param>
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
        DescribeInferenceSchedulerResponse DescribeInferenceScheduler(DescribeInferenceSchedulerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInferenceScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInferenceScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeInferenceScheduler">REST API Reference for DescribeInferenceScheduler Operation</seealso>
        IAsyncResult BeginDescribeInferenceScheduler(DescribeInferenceSchedulerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInferenceScheduler.</param>
        /// 
        /// <returns>Returns a  DescribeInferenceSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeInferenceScheduler">REST API Reference for DescribeInferenceScheduler Operation</seealso>
        DescribeInferenceSchedulerResponse EndDescribeInferenceScheduler(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLabel


        /// <summary>
        /// Returns the name of the label.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabel service method.</param>
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
        DescribeLabelResponse DescribeLabel(DescribeLabelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLabel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabel operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLabel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeLabel">REST API Reference for DescribeLabel Operation</seealso>
        IAsyncResult BeginDescribeLabel(DescribeLabelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLabel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLabel.</param>
        /// 
        /// <returns>Returns a  DescribeLabelResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeLabel">REST API Reference for DescribeLabel Operation</seealso>
        DescribeLabelResponse EndDescribeLabel(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLabelGroup


        /// <summary>
        /// Returns information about the label group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabelGroup service method.</param>
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
        DescribeLabelGroupResponse DescribeLabelGroup(DescribeLabelGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabelGroup operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLabelGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeLabelGroup">REST API Reference for DescribeLabelGroup Operation</seealso>
        IAsyncResult BeginDescribeLabelGroup(DescribeLabelGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLabelGroup.</param>
        /// 
        /// <returns>Returns a  DescribeLabelGroupResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeLabelGroup">REST API Reference for DescribeLabelGroup Operation</seealso>
        DescribeLabelGroupResponse EndDescribeLabelGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeModel


        /// <summary>
        /// Provides a JSON containing the overall information about a specific machine learning
        /// model, including model name and ARN, dataset, training and evaluation information,
        /// status, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel service method.</param>
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
        DescribeModelResponse DescribeModel(DescribeModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        IAsyncResult BeginDescribeModel(DescribeModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModel.</param>
        /// 
        /// <returns>Returns a  DescribeModelResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        DescribeModelResponse EndDescribeModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeModelVersion


        /// <summary>
        /// Retrieves information about a specific machine learning model version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelVersion service method.</param>
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
        DescribeModelVersionResponse DescribeModelVersion(DescribeModelVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModelVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelVersion operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModelVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeModelVersion">REST API Reference for DescribeModelVersion Operation</seealso>
        IAsyncResult BeginDescribeModelVersion(DescribeModelVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModelVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModelVersion.</param>
        /// 
        /// <returns>Returns a  DescribeModelVersionResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeModelVersion">REST API Reference for DescribeModelVersion Operation</seealso>
        DescribeModelVersionResponse EndDescribeModelVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeResourcePolicy


        /// <summary>
        /// Provides the details of a resource policy attached to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy service method.</param>
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
        DescribeResourcePolicyResponse DescribeResourcePolicy(DescribeResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        IAsyncResult BeginDescribeResourcePolicy(DescribeResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DescribeResourcePolicyResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        DescribeResourcePolicyResponse EndDescribeResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRetrainingScheduler


        /// <summary>
        /// Provides a description of the retraining scheduler, including information such as
        /// the model name and retraining parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRetrainingScheduler service method.</param>
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
        DescribeRetrainingSchedulerResponse DescribeRetrainingScheduler(DescribeRetrainingSchedulerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRetrainingScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRetrainingScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRetrainingScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeRetrainingScheduler">REST API Reference for DescribeRetrainingScheduler Operation</seealso>
        IAsyncResult BeginDescribeRetrainingScheduler(DescribeRetrainingSchedulerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRetrainingScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRetrainingScheduler.</param>
        /// 
        /// <returns>Returns a  DescribeRetrainingSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/DescribeRetrainingScheduler">REST API Reference for DescribeRetrainingScheduler Operation</seealso>
        DescribeRetrainingSchedulerResponse EndDescribeRetrainingScheduler(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportDataset


        /// <summary>
        /// Imports a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDataset service method.</param>
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
        ImportDatasetResponse ImportDataset(ImportDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportDataset operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ImportDataset">REST API Reference for ImportDataset Operation</seealso>
        IAsyncResult BeginImportDataset(ImportDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportDataset.</param>
        /// 
        /// <returns>Returns a  ImportDatasetResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ImportDataset">REST API Reference for ImportDataset Operation</seealso>
        ImportDatasetResponse EndImportDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportModelVersion


        /// <summary>
        /// Imports a model that has been trained successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportModelVersion service method.</param>
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
        ImportModelVersionResponse ImportModelVersion(ImportModelVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportModelVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportModelVersion operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportModelVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ImportModelVersion">REST API Reference for ImportModelVersion Operation</seealso>
        IAsyncResult BeginImportModelVersion(ImportModelVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportModelVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportModelVersion.</param>
        /// 
        /// <returns>Returns a  ImportModelVersionResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ImportModelVersion">REST API Reference for ImportModelVersion Operation</seealso>
        ImportModelVersionResponse EndImportModelVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataIngestionJobs


        /// <summary>
        /// Provides a list of all data ingestion jobs, including dataset name and ARN, S3 location
        /// of the input data, status, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataIngestionJobs service method.</param>
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
        ListDataIngestionJobsResponse ListDataIngestionJobs(ListDataIngestionJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataIngestionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataIngestionJobs operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataIngestionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListDataIngestionJobs">REST API Reference for ListDataIngestionJobs Operation</seealso>
        IAsyncResult BeginListDataIngestionJobs(ListDataIngestionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataIngestionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataIngestionJobs.</param>
        /// 
        /// <returns>Returns a  ListDataIngestionJobsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListDataIngestionJobs">REST API Reference for ListDataIngestionJobs Operation</seealso>
        ListDataIngestionJobsResponse EndListDataIngestionJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasets


        /// <summary>
        /// Lists all datasets currently available in your account, filtering on the dataset name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
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
        ListDatasetsResponse ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInferenceEvents


        /// <summary>
        /// Lists all inference events that have been found for the specified inference scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceEvents service method.</param>
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
        ListInferenceEventsResponse ListInferenceEvents(ListInferenceEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInferenceEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceEvents operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInferenceEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceEvents">REST API Reference for ListInferenceEvents Operation</seealso>
        IAsyncResult BeginListInferenceEvents(ListInferenceEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInferenceEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInferenceEvents.</param>
        /// 
        /// <returns>Returns a  ListInferenceEventsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceEvents">REST API Reference for ListInferenceEvents Operation</seealso>
        ListInferenceEventsResponse EndListInferenceEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInferenceExecutions


        /// <summary>
        /// Lists all inference executions that have been performed by the specified inference
        /// scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceExecutions service method.</param>
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
        ListInferenceExecutionsResponse ListInferenceExecutions(ListInferenceExecutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInferenceExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceExecutions operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInferenceExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceExecutions">REST API Reference for ListInferenceExecutions Operation</seealso>
        IAsyncResult BeginListInferenceExecutions(ListInferenceExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInferenceExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInferenceExecutions.</param>
        /// 
        /// <returns>Returns a  ListInferenceExecutionsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceExecutions">REST API Reference for ListInferenceExecutions Operation</seealso>
        ListInferenceExecutionsResponse EndListInferenceExecutions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInferenceSchedulers


        /// <summary>
        /// Retrieves a list of all inference schedulers currently available for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceSchedulers service method.</param>
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
        ListInferenceSchedulersResponse ListInferenceSchedulers(ListInferenceSchedulersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInferenceSchedulers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInferenceSchedulers operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInferenceSchedulers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceSchedulers">REST API Reference for ListInferenceSchedulers Operation</seealso>
        IAsyncResult BeginListInferenceSchedulers(ListInferenceSchedulersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInferenceSchedulers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInferenceSchedulers.</param>
        /// 
        /// <returns>Returns a  ListInferenceSchedulersResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListInferenceSchedulers">REST API Reference for ListInferenceSchedulers Operation</seealso>
        ListInferenceSchedulersResponse EndListInferenceSchedulers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLabelGroups


        /// <summary>
        /// Returns a list of the label groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabelGroups service method.</param>
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
        ListLabelGroupsResponse ListLabelGroups(ListLabelGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLabelGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLabelGroups operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLabelGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListLabelGroups">REST API Reference for ListLabelGroups Operation</seealso>
        IAsyncResult BeginListLabelGroups(ListLabelGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLabelGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLabelGroups.</param>
        /// 
        /// <returns>Returns a  ListLabelGroupsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListLabelGroups">REST API Reference for ListLabelGroups Operation</seealso>
        ListLabelGroupsResponse EndListLabelGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLabels


        /// <summary>
        /// Provides a list of labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabels service method.</param>
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
        ListLabelsResponse ListLabels(ListLabelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLabels operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListLabels">REST API Reference for ListLabels Operation</seealso>
        IAsyncResult BeginListLabels(ListLabelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLabels.</param>
        /// 
        /// <returns>Returns a  ListLabelsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListLabels">REST API Reference for ListLabels Operation</seealso>
        ListLabelsResponse EndListLabels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModels


        /// <summary>
        /// Generates a list of all models in the account, including model name and ARN, dataset,
        /// and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
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
        ListModelsResponse ListModels(ListModelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModels operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListModels">REST API Reference for ListModels Operation</seealso>
        IAsyncResult BeginListModels(ListModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModels.</param>
        /// 
        /// <returns>Returns a  ListModelsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListModels">REST API Reference for ListModels Operation</seealso>
        ListModelsResponse EndListModels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModelVersions


        /// <summary>
        /// Generates a list of all model versions for a given model, including the model version,
        /// model version ARN, and status. To list a subset of versions, use the <code>MaxModelVersion</code>
        /// and <code>MinModelVersion</code> fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelVersions service method.</param>
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
        ListModelVersionsResponse ListModelVersions(ListModelVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelVersions operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListModelVersions">REST API Reference for ListModelVersions Operation</seealso>
        IAsyncResult BeginListModelVersions(ListModelVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelVersions.</param>
        /// 
        /// <returns>Returns a  ListModelVersionsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListModelVersions">REST API Reference for ListModelVersions Operation</seealso>
        ListModelVersionsResponse EndListModelVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRetrainingSchedulers


        /// <summary>
        /// Lists all retraining schedulers in your account, filtering by model name prefix and
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetrainingSchedulers service method.</param>
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
        ListRetrainingSchedulersResponse ListRetrainingSchedulers(ListRetrainingSchedulersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRetrainingSchedulers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRetrainingSchedulers operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRetrainingSchedulers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListRetrainingSchedulers">REST API Reference for ListRetrainingSchedulers Operation</seealso>
        IAsyncResult BeginListRetrainingSchedulers(ListRetrainingSchedulersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRetrainingSchedulers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRetrainingSchedulers.</param>
        /// 
        /// <returns>Returns a  ListRetrainingSchedulersResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListRetrainingSchedulers">REST API Reference for ListRetrainingSchedulers Operation</seealso>
        ListRetrainingSchedulersResponse EndListRetrainingSchedulers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSensorStatistics


        /// <summary>
        /// Lists statistics about the data collected for each of the sensors that have been
        /// successfully ingested in the particular dataset. Can also be used to retreive Sensor
        /// Statistics for a previous ingestion job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSensorStatistics service method.</param>
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
        ListSensorStatisticsResponse ListSensorStatistics(ListSensorStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSensorStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSensorStatistics operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSensorStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListSensorStatistics">REST API Reference for ListSensorStatistics Operation</seealso>
        IAsyncResult BeginListSensorStatistics(ListSensorStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSensorStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSensorStatistics.</param>
        /// 
        /// <returns>Returns a  ListSensorStatisticsResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListSensorStatistics">REST API Reference for ListSensorStatistics Operation</seealso>
        ListSensorStatisticsResponse EndListSensorStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all the tags for a specified resource, including key and value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Creates a resource control policy for a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
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
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDataIngestionJob


        /// <summary>
        /// Starts a data ingestion job. Amazon Lookout for Equipment returns the job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataIngestionJob service method.</param>
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
        StartDataIngestionJobResponse StartDataIngestionJob(StartDataIngestionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataIngestionJob operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDataIngestionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartDataIngestionJob">REST API Reference for StartDataIngestionJob Operation</seealso>
        IAsyncResult BeginStartDataIngestionJob(StartDataIngestionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDataIngestionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDataIngestionJob.</param>
        /// 
        /// <returns>Returns a  StartDataIngestionJobResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartDataIngestionJob">REST API Reference for StartDataIngestionJob Operation</seealso>
        StartDataIngestionJobResponse EndStartDataIngestionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartInferenceScheduler


        /// <summary>
        /// Starts an inference scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInferenceScheduler service method.</param>
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
        StartInferenceSchedulerResponse StartInferenceScheduler(StartInferenceSchedulerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInferenceScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInferenceScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartInferenceScheduler">REST API Reference for StartInferenceScheduler Operation</seealso>
        IAsyncResult BeginStartInferenceScheduler(StartInferenceSchedulerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInferenceScheduler.</param>
        /// 
        /// <returns>Returns a  StartInferenceSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartInferenceScheduler">REST API Reference for StartInferenceScheduler Operation</seealso>
        StartInferenceSchedulerResponse EndStartInferenceScheduler(IAsyncResult asyncResult);

        #endregion
        
        #region  StartRetrainingScheduler


        /// <summary>
        /// Starts a retraining scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRetrainingScheduler service method.</param>
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
        StartRetrainingSchedulerResponse StartRetrainingScheduler(StartRetrainingSchedulerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartRetrainingScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRetrainingScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRetrainingScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartRetrainingScheduler">REST API Reference for StartRetrainingScheduler Operation</seealso>
        IAsyncResult BeginStartRetrainingScheduler(StartRetrainingSchedulerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartRetrainingScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRetrainingScheduler.</param>
        /// 
        /// <returns>Returns a  StartRetrainingSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StartRetrainingScheduler">REST API Reference for StartRetrainingScheduler Operation</seealso>
        StartRetrainingSchedulerResponse EndStartRetrainingScheduler(IAsyncResult asyncResult);

        #endregion
        
        #region  StopInferenceScheduler


        /// <summary>
        /// Stops an inference scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInferenceScheduler service method.</param>
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
        StopInferenceSchedulerResponse StopInferenceScheduler(StopInferenceSchedulerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInferenceScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopInferenceScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StopInferenceScheduler">REST API Reference for StopInferenceScheduler Operation</seealso>
        IAsyncResult BeginStopInferenceScheduler(StopInferenceSchedulerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInferenceScheduler.</param>
        /// 
        /// <returns>Returns a  StopInferenceSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StopInferenceScheduler">REST API Reference for StopInferenceScheduler Operation</seealso>
        StopInferenceSchedulerResponse EndStopInferenceScheduler(IAsyncResult asyncResult);

        #endregion
        
        #region  StopRetrainingScheduler


        /// <summary>
        /// Stops a retraining scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRetrainingScheduler service method.</param>
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
        StopRetrainingSchedulerResponse StopRetrainingScheduler(StopRetrainingSchedulerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopRetrainingScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopRetrainingScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopRetrainingScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StopRetrainingScheduler">REST API Reference for StopRetrainingScheduler Operation</seealso>
        IAsyncResult BeginStopRetrainingScheduler(StopRetrainingSchedulerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopRetrainingScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopRetrainingScheduler.</param>
        /// 
        /// <returns>Returns a  StopRetrainingSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/StopRetrainingScheduler">REST API Reference for StopRetrainingScheduler Operation</seealso>
        StopRetrainingSchedulerResponse EndStopRetrainingScheduler(IAsyncResult asyncResult);

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
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a specific tag from a given resource. The tag is specified by its key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateActiveModelVersion


        /// <summary>
        /// Sets the active model version for a given machine learning model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateActiveModelVersion service method.</param>
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
        UpdateActiveModelVersionResponse UpdateActiveModelVersion(UpdateActiveModelVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateActiveModelVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateActiveModelVersion operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateActiveModelVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateActiveModelVersion">REST API Reference for UpdateActiveModelVersion Operation</seealso>
        IAsyncResult BeginUpdateActiveModelVersion(UpdateActiveModelVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateActiveModelVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateActiveModelVersion.</param>
        /// 
        /// <returns>Returns a  UpdateActiveModelVersionResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateActiveModelVersion">REST API Reference for UpdateActiveModelVersion Operation</seealso>
        UpdateActiveModelVersionResponse EndUpdateActiveModelVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateInferenceScheduler


        /// <summary>
        /// Updates an inference scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInferenceScheduler service method.</param>
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
        UpdateInferenceSchedulerResponse UpdateInferenceScheduler(UpdateInferenceSchedulerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInferenceScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInferenceScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateInferenceScheduler">REST API Reference for UpdateInferenceScheduler Operation</seealso>
        IAsyncResult BeginUpdateInferenceScheduler(UpdateInferenceSchedulerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInferenceScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInferenceScheduler.</param>
        /// 
        /// <returns>Returns a  UpdateInferenceSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateInferenceScheduler">REST API Reference for UpdateInferenceScheduler Operation</seealso>
        UpdateInferenceSchedulerResponse EndUpdateInferenceScheduler(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLabelGroup


        /// <summary>
        /// Updates the label group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLabelGroup service method.</param>
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
        UpdateLabelGroupResponse UpdateLabelGroup(UpdateLabelGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLabelGroup operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLabelGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateLabelGroup">REST API Reference for UpdateLabelGroup Operation</seealso>
        IAsyncResult BeginUpdateLabelGroup(UpdateLabelGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLabelGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLabelGroup.</param>
        /// 
        /// <returns>Returns a  UpdateLabelGroupResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateLabelGroup">REST API Reference for UpdateLabelGroup Operation</seealso>
        UpdateLabelGroupResponse EndUpdateLabelGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateModel


        /// <summary>
        /// Updates a model in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
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
        UpdateModelResponse UpdateModel(UpdateModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        IAsyncResult BeginUpdateModel(UpdateModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModel.</param>
        /// 
        /// <returns>Returns a  UpdateModelResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        UpdateModelResponse EndUpdateModel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRetrainingScheduler


        /// <summary>
        /// Updates a retraining scheduler.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRetrainingScheduler service method.</param>
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
        UpdateRetrainingSchedulerResponse UpdateRetrainingScheduler(UpdateRetrainingSchedulerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRetrainingScheduler operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRetrainingScheduler operation on AmazonLookoutEquipmentClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRetrainingScheduler
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateRetrainingScheduler">REST API Reference for UpdateRetrainingScheduler Operation</seealso>
        IAsyncResult BeginUpdateRetrainingScheduler(UpdateRetrainingSchedulerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRetrainingScheduler operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRetrainingScheduler.</param>
        /// 
        /// <returns>Returns a  UpdateRetrainingSchedulerResult from LookoutEquipment.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutequipment-2020-12-15/UpdateRetrainingScheduler">REST API Reference for UpdateRetrainingScheduler Operation</seealso>
        UpdateRetrainingSchedulerResponse EndUpdateRetrainingScheduler(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}