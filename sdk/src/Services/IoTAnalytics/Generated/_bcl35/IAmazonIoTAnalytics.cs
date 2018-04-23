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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTAnalytics.Model;

namespace Amazon.IoTAnalytics
{
    /// <summary>
    /// Interface for accessing IoTAnalytics
    ///
    /// AWS IoT Analytics provides advanced data analysis for AWS IoT. It allows you to collect
    /// large amounts of device data, process messages, store them, and then query the data
    /// and run sophisticated analytics to make accurate decisions in your IoT applications
    /// and machine learning use cases. AWS IoT Analytics enables advanced data exploration
    /// through integration with Jupyter Notebooks and data visualization through integration
    /// with Amazon QuickSight.
    /// 
    ///  
    /// <para>
    /// Traditional analytics and business intelligence tools are designed to process structured
    /// data. IoT data often comes from devices that record noisy processes (such as temperature,
    /// motion, or sound). As a result, the data from these devices can have significant gaps,
    /// corrupted messages, and false readings that must be cleaned up before analysis can
    /// occur. Also, IoT data is often only meaningful in the context of other data from external
    /// sources. 
    /// </para>
    ///  
    /// <para>
    /// AWS IoT Analytics automates each of the steps required to analyze data from IoT devices.
    /// AWS IoT Analytics filters, transforms, and enriches IoT data before storing it in
    /// a time-series data store for analysis. You can set up the service to collect only
    /// the data you need from your devices, apply mathematical transforms to process the
    /// data, and enrich the data with device-specific metadata such as device type and location
    /// before storing it. Then, you can analyze your data by running queries using the built-in
    /// SQL query engine, or perform more complex analytics and machine learning inference.
    /// AWS IoT Analytics includes models for common IoT use cases so you can answer questions
    /// like which devices are about to fail or which customers are at risk of abandoning
    /// their wearable devices.
    /// </para>
    /// </summary>
    public partial interface IAmazonIoTAnalytics : IAmazonService, IDisposable
    {

        
        #region  BatchPutMessage


        /// <summary>
        /// Sends messages to a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMessage service method.</param>
        /// 
        /// <returns>The response from the BatchPutMessage service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        BatchPutMessageResponse BatchPutMessage(BatchPutMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMessage operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        IAsyncResult BeginBatchPutMessage(BatchPutMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutMessage.</param>
        /// 
        /// <returns>Returns a  BatchPutMessageResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        BatchPutMessageResponse EndBatchPutMessage(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelPipelineReprocessing


        /// <summary>
        /// Cancels the reprocessing of data through the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelPipelineReprocessing service method.</param>
        /// 
        /// <returns>The response from the CancelPipelineReprocessing service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CancelPipelineReprocessing">REST API Reference for CancelPipelineReprocessing Operation</seealso>
        CancelPipelineReprocessingResponse CancelPipelineReprocessing(CancelPipelineReprocessingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelPipelineReprocessing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelPipelineReprocessing operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelPipelineReprocessing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CancelPipelineReprocessing">REST API Reference for CancelPipelineReprocessing Operation</seealso>
        IAsyncResult BeginCancelPipelineReprocessing(CancelPipelineReprocessingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelPipelineReprocessing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelPipelineReprocessing.</param>
        /// 
        /// <returns>Returns a  CancelPipelineReprocessingResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CancelPipelineReprocessing">REST API Reference for CancelPipelineReprocessing Operation</seealso>
        CancelPipelineReprocessingResponse EndCancelPipelineReprocessing(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateChannel


        /// <summary>
        /// Creates a channel. A channel collects data from an MQTT topic and archives the raw,
        /// unprocessed messages before publishing the data to a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.LimitExceededException">
        /// The command caused an internal limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceAlreadyExistsException">
        /// A resource with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse CreateChannel(CreateChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataset


        /// <summary>
        /// Creates a data set. A data set stores data retrieved from a data store by applying
        /// an SQL action.
        /// 
        ///  <note> 
        /// <para>
        /// This operation creates the skeleton of a data set. To populate the data set, call
        /// "CreateDatasetContent".
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.LimitExceededException">
        /// The command caused an internal limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceAlreadyExistsException">
        /// A resource with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse CreateDataset(CreateDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        IAsyncResult BeginCreateDataset(CreateDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataset.</param>
        /// 
        /// <returns>Returns a  CreateDatasetResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse EndCreateDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDatasetContent


        /// <summary>
        /// Creates the content of a data set by applying an SQL action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetContent service method.</param>
        /// 
        /// <returns>The response from the CreateDatasetContent service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDatasetContent">REST API Reference for CreateDatasetContent Operation</seealso>
        CreateDatasetContentResponse CreateDatasetContent(CreateDatasetContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetContent operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatasetContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDatasetContent">REST API Reference for CreateDatasetContent Operation</seealso>
        IAsyncResult BeginCreateDatasetContent(CreateDatasetContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatasetContent.</param>
        /// 
        /// <returns>Returns a  CreateDatasetContentResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDatasetContent">REST API Reference for CreateDatasetContent Operation</seealso>
        CreateDatasetContentResponse EndCreateDatasetContent(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDatastore


        /// <summary>
        /// Creates a data store, which is a repository for messages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatastore service method.</param>
        /// 
        /// <returns>The response from the CreateDatastore service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.LimitExceededException">
        /// The command caused an internal limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceAlreadyExistsException">
        /// A resource with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDatastore">REST API Reference for CreateDatastore Operation</seealso>
        CreateDatastoreResponse CreateDatastore(CreateDatastoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatastore operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatastore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDatastore">REST API Reference for CreateDatastore Operation</seealso>
        IAsyncResult BeginCreateDatastore(CreateDatastoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatastore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatastore.</param>
        /// 
        /// <returns>Returns a  CreateDatastoreResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDatastore">REST API Reference for CreateDatastore Operation</seealso>
        CreateDatastoreResponse EndCreateDatastore(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePipeline


        /// <summary>
        /// Creates a pipeline. A pipeline consumes messages from one or more channels and allows
        /// you to process the messages before storing them in a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.LimitExceededException">
        /// The command caused an internal limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceAlreadyExistsException">
        /// A resource with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        CreatePipelineResponse CreatePipeline(CreatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        IAsyncResult BeginCreatePipeline(CreatePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePipeline.</param>
        /// 
        /// <returns>Returns a  CreatePipelineResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        CreatePipelineResponse EndCreatePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChannel


        /// <summary>
        /// Deletes the specified channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse DeleteChannel(DeleteChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        IAsyncResult BeginDeleteChannel(DeleteChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannel.</param>
        /// 
        /// <returns>Returns a  DeleteChannelResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse EndDeleteChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataset


        /// <summary>
        /// Deletes the specified data set.
        /// 
        ///  
        /// <para>
        /// You do not have to delete the content of the data set before you perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDatasetContent


        /// <summary>
        /// Deletes the content of the specified data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetContent service method.</param>
        /// 
        /// <returns>The response from the DeleteDatasetContent service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDatasetContent">REST API Reference for DeleteDatasetContent Operation</seealso>
        DeleteDatasetContentResponse DeleteDatasetContent(DeleteDatasetContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetContent operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatasetContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDatasetContent">REST API Reference for DeleteDatasetContent Operation</seealso>
        IAsyncResult BeginDeleteDatasetContent(DeleteDatasetContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatasetContent.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetContentResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDatasetContent">REST API Reference for DeleteDatasetContent Operation</seealso>
        DeleteDatasetContentResponse EndDeleteDatasetContent(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDatastore


        /// <summary>
        /// Deletes the specified data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatastore service method.</param>
        /// 
        /// <returns>The response from the DeleteDatastore service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDatastore">REST API Reference for DeleteDatastore Operation</seealso>
        DeleteDatastoreResponse DeleteDatastore(DeleteDatastoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatastore operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatastore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDatastore">REST API Reference for DeleteDatastore Operation</seealso>
        IAsyncResult BeginDeleteDatastore(DeleteDatastoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatastore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatastore.</param>
        /// 
        /// <returns>Returns a  DeleteDatastoreResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDatastore">REST API Reference for DeleteDatastore Operation</seealso>
        DeleteDatastoreResponse EndDeleteDatastore(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePipeline


        /// <summary>
        /// Deletes the specified pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        DeletePipelineResponse DeletePipeline(DeletePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        IAsyncResult BeginDeletePipeline(DeletePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePipeline.</param>
        /// 
        /// <returns>Returns a  DeletePipelineResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        DeletePipelineResponse EndDeletePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeChannel


        /// <summary>
        /// Retrieves information about a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        DescribeChannelResponse DescribeChannel(DescribeChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        IAsyncResult BeginDescribeChannel(DescribeChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannel.</param>
        /// 
        /// <returns>Returns a  DescribeChannelResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        DescribeChannelResponse EndDescribeChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataset


        /// <summary>
        /// Retrieves information about a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDatastore


        /// <summary>
        /// Retrieves information about a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatastore service method.</param>
        /// 
        /// <returns>The response from the DescribeDatastore service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeDatastore">REST API Reference for DescribeDatastore Operation</seealso>
        DescribeDatastoreResponse DescribeDatastore(DescribeDatastoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatastore operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDatastore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeDatastore">REST API Reference for DescribeDatastore Operation</seealso>
        IAsyncResult BeginDescribeDatastore(DescribeDatastoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDatastore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDatastore.</param>
        /// 
        /// <returns>Returns a  DescribeDatastoreResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeDatastore">REST API Reference for DescribeDatastore Operation</seealso>
        DescribeDatastoreResponse EndDescribeDatastore(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLoggingOptions


        /// <summary>
        /// Retrieves the current settings of the AWS IoT Analytics logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeLoggingOptions service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        DescribeLoggingOptionsResponse DescribeLoggingOptions(DescribeLoggingOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        IAsyncResult BeginDescribeLoggingOptions(DescribeLoggingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoggingOptions.</param>
        /// 
        /// <returns>Returns a  DescribeLoggingOptionsResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        DescribeLoggingOptionsResponse EndDescribeLoggingOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePipeline


        /// <summary>
        /// Retrieves information about a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipeline service method.</param>
        /// 
        /// <returns>The response from the DescribePipeline service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribePipeline">REST API Reference for DescribePipeline Operation</seealso>
        DescribePipelineResponse DescribePipeline(DescribePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePipeline operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribePipeline">REST API Reference for DescribePipeline Operation</seealso>
        IAsyncResult BeginDescribePipeline(DescribePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePipeline.</param>
        /// 
        /// <returns>Returns a  DescribePipelineResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribePipeline">REST API Reference for DescribePipeline Operation</seealso>
        DescribePipelineResponse EndDescribePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDatasetContent


        /// <summary>
        /// Retrieves the contents of a data set as pre-signed URIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatasetContent service method.</param>
        /// 
        /// <returns>The response from the GetDatasetContent service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/GetDatasetContent">REST API Reference for GetDatasetContent Operation</seealso>
        GetDatasetContentResponse GetDatasetContent(GetDatasetContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatasetContent operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatasetContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/GetDatasetContent">REST API Reference for GetDatasetContent Operation</seealso>
        IAsyncResult BeginGetDatasetContent(GetDatasetContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatasetContent.</param>
        /// 
        /// <returns>Returns a  GetDatasetContentResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/GetDatasetContent">REST API Reference for GetDatasetContent Operation</seealso>
        GetDatasetContentResponse EndGetDatasetContent(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChannels


        /// <summary>
        /// Retrieves a list of channels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListChannels">REST API Reference for ListChannels Operation</seealso>
        IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse EndListChannels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasets


        /// <summary>
        /// Retrieves information about data sets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        ListDatasetsResponse ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatastores


        /// <summary>
        /// Retrieves a list of data stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatastores service method.</param>
        /// 
        /// <returns>The response from the ListDatastores service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatastores">REST API Reference for ListDatastores Operation</seealso>
        ListDatastoresResponse ListDatastores(ListDatastoresRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatastores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatastores operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatastores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatastores">REST API Reference for ListDatastores Operation</seealso>
        IAsyncResult BeginListDatastores(ListDatastoresRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatastores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatastores.</param>
        /// 
        /// <returns>Returns a  ListDatastoresResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatastores">REST API Reference for ListDatastores Operation</seealso>
        ListDatastoresResponse EndListDatastores(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPipelines


        /// <summary>
        /// Retrieves a list of pipelines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        ListPipelinesResponse ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        IAsyncResult BeginListPipelines(ListPipelinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelines.</param>
        /// 
        /// <returns>Returns a  ListPipelinesResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        ListPipelinesResponse EndListPipelines(IAsyncResult asyncResult);

        #endregion
        
        #region  PutLoggingOptions


        /// <summary>
        /// Sets or updates the AWS IoT Analytics logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the PutLoggingOptions service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        PutLoggingOptionsResponse PutLoggingOptions(PutLoggingOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        IAsyncResult BeginPutLoggingOptions(PutLoggingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLoggingOptions.</param>
        /// 
        /// <returns>Returns a  PutLoggingOptionsResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        PutLoggingOptionsResponse EndPutLoggingOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  RunPipelineActivity


        /// <summary>
        /// Simulates the results of running a pipeline activity on a message payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunPipelineActivity service method.</param>
        /// 
        /// <returns>The response from the RunPipelineActivity service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/RunPipelineActivity">REST API Reference for RunPipelineActivity Operation</seealso>
        RunPipelineActivityResponse RunPipelineActivity(RunPipelineActivityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RunPipelineActivity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunPipelineActivity operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunPipelineActivity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/RunPipelineActivity">REST API Reference for RunPipelineActivity Operation</seealso>
        IAsyncResult BeginRunPipelineActivity(RunPipelineActivityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RunPipelineActivity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunPipelineActivity.</param>
        /// 
        /// <returns>Returns a  RunPipelineActivityResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/RunPipelineActivity">REST API Reference for RunPipelineActivity Operation</seealso>
        RunPipelineActivityResponse EndRunPipelineActivity(IAsyncResult asyncResult);

        #endregion
        
        #region  SampleChannelData


        /// <summary>
        /// Retrieves a sample of messages from the specified channel ingested during the specified
        /// timeframe. Up to 10 messages can be retrieved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SampleChannelData service method.</param>
        /// 
        /// <returns>The response from the SampleChannelData service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/SampleChannelData">REST API Reference for SampleChannelData Operation</seealso>
        SampleChannelDataResponse SampleChannelData(SampleChannelDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SampleChannelData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SampleChannelData operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSampleChannelData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/SampleChannelData">REST API Reference for SampleChannelData Operation</seealso>
        IAsyncResult BeginSampleChannelData(SampleChannelDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SampleChannelData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSampleChannelData.</param>
        /// 
        /// <returns>Returns a  SampleChannelDataResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/SampleChannelData">REST API Reference for SampleChannelData Operation</seealso>
        SampleChannelDataResponse EndSampleChannelData(IAsyncResult asyncResult);

        #endregion
        
        #region  StartPipelineReprocessing


        /// <summary>
        /// Starts the reprocessing of raw message data through the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineReprocessing service method.</param>
        /// 
        /// <returns>The response from the StartPipelineReprocessing service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceAlreadyExistsException">
        /// A resource with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/StartPipelineReprocessing">REST API Reference for StartPipelineReprocessing Operation</seealso>
        StartPipelineReprocessingResponse StartPipelineReprocessing(StartPipelineReprocessingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartPipelineReprocessing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineReprocessing operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPipelineReprocessing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/StartPipelineReprocessing">REST API Reference for StartPipelineReprocessing Operation</seealso>
        IAsyncResult BeginStartPipelineReprocessing(StartPipelineReprocessingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartPipelineReprocessing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPipelineReprocessing.</param>
        /// 
        /// <returns>Returns a  StartPipelineReprocessingResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/StartPipelineReprocessing">REST API Reference for StartPipelineReprocessing Operation</seealso>
        StartPipelineReprocessingResponse EndStartPipelineReprocessing(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateChannel


        /// <summary>
        /// Updates the settings of a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse UpdateChannel(UpdateChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataset


        /// <summary>
        /// Updates the settings of a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset service method.</param>
        /// 
        /// <returns>The response from the UpdateDataset service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        UpdateDatasetResponse UpdateDataset(UpdateDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        IAsyncResult BeginUpdateDataset(UpdateDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataset.</param>
        /// 
        /// <returns>Returns a  UpdateDatasetResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        UpdateDatasetResponse EndUpdateDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDatastore


        /// <summary>
        /// Updates the settings of a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatastore service method.</param>
        /// 
        /// <returns>The response from the UpdateDatastore service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateDatastore">REST API Reference for UpdateDatastore Operation</seealso>
        UpdateDatastoreResponse UpdateDatastore(UpdateDatastoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatastore operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDatastore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateDatastore">REST API Reference for UpdateDatastore Operation</seealso>
        IAsyncResult BeginUpdateDatastore(UpdateDatastoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDatastore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDatastore.</param>
        /// 
        /// <returns>Returns a  UpdateDatastoreResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateDatastore">REST API Reference for UpdateDatastore Operation</seealso>
        UpdateDatastoreResponse EndUpdateDatastore(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePipeline


        /// <summary>
        /// Updates the settings of a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.LimitExceededException">
        /// The command caused an internal limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        IAsyncResult BeginUpdatePipeline(UpdatePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipeline.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        UpdatePipelineResponse EndUpdatePipeline(IAsyncResult asyncResult);

        #endregion
        
    }
}