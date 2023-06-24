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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DataExchange.Model;

namespace Amazon.DataExchange
{
    /// <summary>
    /// Interface for accessing DataExchange
    ///
    /// AWS Data Exchange is a service that makes it easy for AWS customers to exchange data
    /// in the cloud. You can use the AWS Data Exchange APIs to create, update, manage, and
    /// access file-based data set in the AWS Cloud.
    /// 
    ///  
    /// <para>
    /// As a subscriber, you can view and access the data sets that you have an entitlement
    /// to through a subscription. You can use the APIs to download or copy your entitled
    /// data sets to Amazon Simple Storage Service (Amazon S3) for use across a variety of
    /// AWS analytics and machine learning services.
    /// </para>
    ///  
    /// <para>
    /// As a provider, you can create and manage your data sets that you would like to publish
    /// to a product. Being able to package and provide your data sets into products requires
    /// a few steps to determine eligibility. For more information, visit the <i>AWS Data
    /// Exchange User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// A data set is a collection of data that can be changed or updated over time. Data
    /// sets can be updated using revisions, which represent a new version or incremental
    /// change to a data set. A revision contains one or more assets. An asset in AWS Data
    /// Exchange is a piece of data that can be stored as an Amazon S3 object, Redshift datashare,
    /// API Gateway API, AWS Lake Formation data permission, or Amazon S3 data access. The
    /// asset can be a structured data file, an image file, or some other data file. Jobs
    /// are asynchronous import or export operations used to create or copy assets.
    /// </para>
    /// </summary>
    public partial interface IAmazonDataExchange : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDataExchangePaginatorFactory Paginators { get; }
#endif


        
        #region  CancelJob


        /// <summary>
        /// This operation cancels a job. Jobs can be cancelled only when they are in the WAITING
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CancelJob">REST API Reference for CancelJob Operation</seealso>
        CancelJobResponse CancelJob(CancelJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CancelJob">REST API Reference for CancelJob Operation</seealso>
        IAsyncResult BeginCancelJob(CancelJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJob.</param>
        /// 
        /// <returns>Returns a  CancelJobResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CancelJob">REST API Reference for CancelJob Operation</seealso>
        CancelJobResponse EndCancelJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataSet


        /// <summary>
        /// This operation creates a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet service method.</param>
        /// 
        /// <returns>The response from the CreateDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ServiceLimitExceededException">
        /// The request has exceeded the quotas imposed by the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        CreateDataSetResponse CreateDataSet(CreateDataSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        IAsyncResult BeginCreateDataSet(CreateDataSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSet.</param>
        /// 
        /// <returns>Returns a  CreateDataSetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        CreateDataSetResponse EndCreateDataSet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEventAction


        /// <summary>
        /// This operation creates an event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventAction service method.</param>
        /// 
        /// <returns>The response from the CreateEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ServiceLimitExceededException">
        /// The request has exceeded the quotas imposed by the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateEventAction">REST API Reference for CreateEventAction Operation</seealso>
        CreateEventActionResponse CreateEventAction(CreateEventActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventAction operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateEventAction">REST API Reference for CreateEventAction Operation</seealso>
        IAsyncResult BeginCreateEventAction(CreateEventActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventAction.</param>
        /// 
        /// <returns>Returns a  CreateEventActionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateEventAction">REST API Reference for CreateEventAction Operation</seealso>
        CreateEventActionResponse EndCreateEventAction(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// This operation creates a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateJob">REST API Reference for CreateJob Operation</seealso>
        CreateJobResponse CreateJob(CreateJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateJob">REST API Reference for CreateJob Operation</seealso>
        IAsyncResult BeginCreateJob(CreateJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a  CreateJobResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateJob">REST API Reference for CreateJob Operation</seealso>
        CreateJobResponse EndCreateJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRevision


        /// <summary>
        /// This operation creates a revision for a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRevision service method.</param>
        /// 
        /// <returns>The response from the CreateRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateRevision">REST API Reference for CreateRevision Operation</seealso>
        CreateRevisionResponse CreateRevision(CreateRevisionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRevision operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateRevision">REST API Reference for CreateRevision Operation</seealso>
        IAsyncResult BeginCreateRevision(CreateRevisionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRevision.</param>
        /// 
        /// <returns>Returns a  CreateRevisionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateRevision">REST API Reference for CreateRevision Operation</seealso>
        CreateRevisionResponse EndCreateRevision(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAsset


        /// <summary>
        /// This operation deletes an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset service method.</param>
        /// 
        /// <returns>The response from the DeleteAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        DeleteAssetResponse DeleteAsset(DeleteAssetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        IAsyncResult BeginDeleteAsset(DeleteAssetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAsset.</param>
        /// 
        /// <returns>Returns a  DeleteAssetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        DeleteAssetResponse EndDeleteAsset(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataSet


        /// <summary>
        /// This operation deletes a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        DeleteDataSetResponse DeleteDataSet(DeleteDataSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        IAsyncResult BeginDeleteDataSet(DeleteDataSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSet.</param>
        /// 
        /// <returns>Returns a  DeleteDataSetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        DeleteDataSetResponse EndDeleteDataSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEventAction


        /// <summary>
        /// This operation deletes the event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventAction service method.</param>
        /// 
        /// <returns>The response from the DeleteEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteEventAction">REST API Reference for DeleteEventAction Operation</seealso>
        DeleteEventActionResponse DeleteEventAction(DeleteEventActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventAction operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteEventAction">REST API Reference for DeleteEventAction Operation</seealso>
        IAsyncResult BeginDeleteEventAction(DeleteEventActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventAction.</param>
        /// 
        /// <returns>Returns a  DeleteEventActionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteEventAction">REST API Reference for DeleteEventAction Operation</seealso>
        DeleteEventActionResponse EndDeleteEventAction(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRevision


        /// <summary>
        /// This operation deletes a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRevision service method.</param>
        /// 
        /// <returns>The response from the DeleteRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteRevision">REST API Reference for DeleteRevision Operation</seealso>
        DeleteRevisionResponse DeleteRevision(DeleteRevisionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRevision operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteRevision">REST API Reference for DeleteRevision Operation</seealso>
        IAsyncResult BeginDeleteRevision(DeleteRevisionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRevision.</param>
        /// 
        /// <returns>Returns a  DeleteRevisionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteRevision">REST API Reference for DeleteRevision Operation</seealso>
        DeleteRevisionResponse EndDeleteRevision(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAsset


        /// <summary>
        /// This operation returns information about an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAsset service method.</param>
        /// 
        /// <returns>The response from the GetAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetAsset">REST API Reference for GetAsset Operation</seealso>
        GetAssetResponse GetAsset(GetAssetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAsset operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetAsset">REST API Reference for GetAsset Operation</seealso>
        IAsyncResult BeginGetAsset(GetAssetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAsset.</param>
        /// 
        /// <returns>Returns a  GetAssetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetAsset">REST API Reference for GetAsset Operation</seealso>
        GetAssetResponse EndGetAsset(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDataSet


        /// <summary>
        /// This operation returns information about a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSet service method.</param>
        /// 
        /// <returns>The response from the GetDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetDataSet">REST API Reference for GetDataSet Operation</seealso>
        GetDataSetResponse GetDataSet(GetDataSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataSet operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetDataSet">REST API Reference for GetDataSet Operation</seealso>
        IAsyncResult BeginGetDataSet(GetDataSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataSet.</param>
        /// 
        /// <returns>Returns a  GetDataSetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetDataSet">REST API Reference for GetDataSet Operation</seealso>
        GetDataSetResponse EndGetDataSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEventAction


        /// <summary>
        /// This operation retrieves information about an event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventAction service method.</param>
        /// 
        /// <returns>The response from the GetEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetEventAction">REST API Reference for GetEventAction Operation</seealso>
        GetEventActionResponse GetEventAction(GetEventActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventAction operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetEventAction">REST API Reference for GetEventAction Operation</seealso>
        IAsyncResult BeginGetEventAction(GetEventActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventAction.</param>
        /// 
        /// <returns>Returns a  GetEventActionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetEventAction">REST API Reference for GetEventAction Operation</seealso>
        GetEventActionResponse EndGetEventAction(IAsyncResult asyncResult);

        #endregion
        
        #region  GetJob


        /// <summary>
        /// This operation returns information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        GetJobResponse GetJob(GetJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        IAsyncResult BeginGetJob(GetJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJob.</param>
        /// 
        /// <returns>Returns a  GetJobResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        GetJobResponse EndGetJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRevision


        /// <summary>
        /// This operation returns information about a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevision service method.</param>
        /// 
        /// <returns>The response from the GetRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetRevision">REST API Reference for GetRevision Operation</seealso>
        GetRevisionResponse GetRevision(GetRevisionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRevision operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetRevision">REST API Reference for GetRevision Operation</seealso>
        IAsyncResult BeginGetRevision(GetRevisionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRevision.</param>
        /// 
        /// <returns>Returns a  GetRevisionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetRevision">REST API Reference for GetRevision Operation</seealso>
        GetRevisionResponse EndGetRevision(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataSetRevisions


        /// <summary>
        /// This operation lists a data set's revisions sorted by CreatedAt in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSetRevisions service method.</param>
        /// 
        /// <returns>The response from the ListDataSetRevisions service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSetRevisions">REST API Reference for ListDataSetRevisions Operation</seealso>
        ListDataSetRevisionsResponse ListDataSetRevisions(ListDataSetRevisionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSetRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSetRevisions operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSetRevisions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSetRevisions">REST API Reference for ListDataSetRevisions Operation</seealso>
        IAsyncResult BeginListDataSetRevisions(ListDataSetRevisionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSetRevisions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSetRevisions.</param>
        /// 
        /// <returns>Returns a  ListDataSetRevisionsResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSetRevisions">REST API Reference for ListDataSetRevisions Operation</seealso>
        ListDataSetRevisionsResponse EndListDataSetRevisions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataSets


        /// <summary>
        /// This operation lists your data sets. When listing by origin OWNED, results are sorted
        /// by CreatedAt in descending order. When listing by origin ENTITLED, there is no order
        /// and the maxResults parameter is ignored.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets service method.</param>
        /// 
        /// <returns>The response from the ListDataSets service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        ListDataSetsResponse ListDataSets(ListDataSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        IAsyncResult BeginListDataSets(ListDataSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSets.</param>
        /// 
        /// <returns>Returns a  ListDataSetsResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        ListDataSetsResponse EndListDataSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEventActions


        /// <summary>
        /// This operation lists your event actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventActions service method.</param>
        /// 
        /// <returns>The response from the ListEventActions service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListEventActions">REST API Reference for ListEventActions Operation</seealso>
        ListEventActionsResponse ListEventActions(ListEventActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventActions operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListEventActions">REST API Reference for ListEventActions Operation</seealso>
        IAsyncResult BeginListEventActions(ListEventActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventActions.</param>
        /// 
        /// <returns>Returns a  ListEventActionsResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListEventActions">REST API Reference for ListEventActions Operation</seealso>
        ListEventActionsResponse EndListEventActions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// This operation lists your jobs sorted by CreatedAt in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse ListJobs(ListJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse EndListJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRevisionAssets


        /// <summary>
        /// This operation lists a revision's assets sorted alphabetically in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRevisionAssets service method.</param>
        /// 
        /// <returns>The response from the ListRevisionAssets service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListRevisionAssets">REST API Reference for ListRevisionAssets Operation</seealso>
        ListRevisionAssetsResponse ListRevisionAssets(ListRevisionAssetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRevisionAssets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRevisionAssets operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRevisionAssets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListRevisionAssets">REST API Reference for ListRevisionAssets Operation</seealso>
        IAsyncResult BeginListRevisionAssets(ListRevisionAssetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRevisionAssets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRevisionAssets.</param>
        /// 
        /// <returns>Returns a  ListRevisionAssetsResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListRevisionAssets">REST API Reference for ListRevisionAssets Operation</seealso>
        ListRevisionAssetsResponse EndListRevisionAssets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// This operation lists the tags on the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  RevokeRevision


        /// <summary>
        /// This operation revokes subscribers' access to a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeRevision service method.</param>
        /// 
        /// <returns>The response from the RevokeRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/RevokeRevision">REST API Reference for RevokeRevision Operation</seealso>
        RevokeRevisionResponse RevokeRevision(RevokeRevisionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeRevision operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/RevokeRevision">REST API Reference for RevokeRevision Operation</seealso>
        IAsyncResult BeginRevokeRevision(RevokeRevisionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeRevision.</param>
        /// 
        /// <returns>Returns a  RevokeRevisionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/RevokeRevision">REST API Reference for RevokeRevision Operation</seealso>
        RevokeRevisionResponse EndRevokeRevision(IAsyncResult asyncResult);

        #endregion
        
        #region  SendApiAsset


        /// <summary>
        /// This operation invokes an API Gateway API asset. The request is proxied to the provider’s
        /// API Gateway API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendApiAsset service method.</param>
        /// 
        /// <returns>The response from the SendApiAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/SendApiAsset">REST API Reference for SendApiAsset Operation</seealso>
        SendApiAssetResponse SendApiAsset(SendApiAssetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendApiAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendApiAsset operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendApiAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/SendApiAsset">REST API Reference for SendApiAsset Operation</seealso>
        IAsyncResult BeginSendApiAsset(SendApiAssetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendApiAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendApiAsset.</param>
        /// 
        /// <returns>Returns a  SendApiAssetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/SendApiAsset">REST API Reference for SendApiAsset Operation</seealso>
        SendApiAssetResponse EndSendApiAsset(IAsyncResult asyncResult);

        #endregion
        
        #region  StartJob


        /// <summary>
        /// This operation starts a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJob service method.</param>
        /// 
        /// <returns>The response from the StartJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        StartJobResponse StartJob(StartJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartJob operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        IAsyncResult BeginStartJob(StartJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartJob.</param>
        /// 
        /// <returns>Returns a  StartJobResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        StartJobResponse EndStartJob(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// This operation tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// This operation removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAsset


        /// <summary>
        /// This operation updates an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAsset service method.</param>
        /// 
        /// <returns>The response from the UpdateAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateAsset">REST API Reference for UpdateAsset Operation</seealso>
        UpdateAssetResponse UpdateAsset(UpdateAssetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAsset operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateAsset">REST API Reference for UpdateAsset Operation</seealso>
        IAsyncResult BeginUpdateAsset(UpdateAssetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAsset.</param>
        /// 
        /// <returns>Returns a  UpdateAssetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateAsset">REST API Reference for UpdateAsset Operation</seealso>
        UpdateAssetResponse EndUpdateAsset(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataSet


        /// <summary>
        /// This operation updates a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        UpdateDataSetResponse UpdateDataSet(UpdateDataSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        IAsyncResult BeginUpdateDataSet(UpdateDataSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSet.</param>
        /// 
        /// <returns>Returns a  UpdateDataSetResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        UpdateDataSetResponse EndUpdateDataSet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEventAction


        /// <summary>
        /// This operation updates the event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventAction service method.</param>
        /// 
        /// <returns>The response from the UpdateEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateEventAction">REST API Reference for UpdateEventAction Operation</seealso>
        UpdateEventActionResponse UpdateEventAction(UpdateEventActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventAction operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateEventAction">REST API Reference for UpdateEventAction Operation</seealso>
        IAsyncResult BeginUpdateEventAction(UpdateEventActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventAction.</param>
        /// 
        /// <returns>Returns a  UpdateEventActionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateEventAction">REST API Reference for UpdateEventAction Operation</seealso>
        UpdateEventActionResponse EndUpdateEventAction(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRevision


        /// <summary>
        /// This operation updates a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevision service method.</param>
        /// 
        /// <returns>The response from the UpdateRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateRevision">REST API Reference for UpdateRevision Operation</seealso>
        UpdateRevisionResponse UpdateRevision(UpdateRevisionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevision operation on AmazonDataExchangeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateRevision">REST API Reference for UpdateRevision Operation</seealso>
        IAsyncResult BeginUpdateRevision(UpdateRevisionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRevision.</param>
        /// 
        /// <returns>Returns a  UpdateRevisionResult from DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateRevision">REST API Reference for UpdateRevision Operation</seealso>
        UpdateRevisionResponse EndUpdateRevision(IAsyncResult asyncResult);

        #endregion
        
    }
}