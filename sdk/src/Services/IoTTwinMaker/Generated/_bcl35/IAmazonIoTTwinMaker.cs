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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTTwinMaker.Model;

namespace Amazon.IoTTwinMaker
{
    /// <summary>
    /// Interface for accessing IoTTwinMaker
    ///
    /// IoT TwinMaker is a service with which you can build operational digital twins of physical
    /// systems. IoT TwinMaker overlays measurements and analysis from real-world sensors,
    /// cameras, and enterprise applications so you can create data visualizations to monitor
    /// your physical factory, building, or industrial plant. You can use this real-world
    /// data to monitor operations and diagnose and repair errors.
    /// </summary>
    public partial interface IAmazonIoTTwinMaker : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTTwinMakerPaginatorFactory Paginators { get; }
#endif


        
        #region  BatchPutPropertyValues


        /// <summary>
        /// Sets values for multiple time series properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutPropertyValues service method.</param>
        /// 
        /// <returns>The response from the BatchPutPropertyValues service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/BatchPutPropertyValues">REST API Reference for BatchPutPropertyValues Operation</seealso>
        BatchPutPropertyValuesResponse BatchPutPropertyValues(BatchPutPropertyValuesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutPropertyValues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutPropertyValues operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutPropertyValues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/BatchPutPropertyValues">REST API Reference for BatchPutPropertyValues Operation</seealso>
        IAsyncResult BeginBatchPutPropertyValues(BatchPutPropertyValuesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutPropertyValues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutPropertyValues.</param>
        /// 
        /// <returns>Returns a  BatchPutPropertyValuesResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/BatchPutPropertyValues">REST API Reference for BatchPutPropertyValues Operation</seealso>
        BatchPutPropertyValuesResponse EndBatchPutPropertyValues(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateComponentType


        /// <summary>
        /// Creates a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponentType service method.</param>
        /// 
        /// <returns>The response from the CreateComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateComponentType">REST API Reference for CreateComponentType Operation</seealso>
        CreateComponentTypeResponse CreateComponentType(CreateComponentTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComponentType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComponentType operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComponentType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateComponentType">REST API Reference for CreateComponentType Operation</seealso>
        IAsyncResult BeginCreateComponentType(CreateComponentTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateComponentType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateComponentType.</param>
        /// 
        /// <returns>Returns a  CreateComponentTypeResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateComponentType">REST API Reference for CreateComponentType Operation</seealso>
        CreateComponentTypeResponse EndCreateComponentType(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEntity


        /// <summary>
        /// Creates an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEntity service method.</param>
        /// 
        /// <returns>The response from the CreateEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateEntity">REST API Reference for CreateEntity Operation</seealso>
        CreateEntityResponse CreateEntity(CreateEntityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEntity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEntity operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEntity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateEntity">REST API Reference for CreateEntity Operation</seealso>
        IAsyncResult BeginCreateEntity(CreateEntityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEntity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEntity.</param>
        /// 
        /// <returns>Returns a  CreateEntityResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateEntity">REST API Reference for CreateEntity Operation</seealso>
        CreateEntityResponse EndCreateEntity(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateScene


        /// <summary>
        /// Creates a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScene service method.</param>
        /// 
        /// <returns>The response from the CreateScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateScene">REST API Reference for CreateScene Operation</seealso>
        CreateSceneResponse CreateScene(CreateSceneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateScene operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScene operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateScene
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateScene">REST API Reference for CreateScene Operation</seealso>
        IAsyncResult BeginCreateScene(CreateSceneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateScene operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateScene.</param>
        /// 
        /// <returns>Returns a  CreateSceneResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateScene">REST API Reference for CreateScene Operation</seealso>
        CreateSceneResponse EndCreateScene(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSyncJob


        /// <summary>
        /// This action creates a SyncJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSyncJob service method.</param>
        /// 
        /// <returns>The response from the CreateSyncJob service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateSyncJob">REST API Reference for CreateSyncJob Operation</seealso>
        CreateSyncJobResponse CreateSyncJob(CreateSyncJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSyncJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSyncJob operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSyncJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateSyncJob">REST API Reference for CreateSyncJob Operation</seealso>
        IAsyncResult BeginCreateSyncJob(CreateSyncJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSyncJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSyncJob.</param>
        /// 
        /// <returns>Returns a  CreateSyncJobResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateSyncJob">REST API Reference for CreateSyncJob Operation</seealso>
        CreateSyncJobResponse EndCreateSyncJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkspace


        /// <summary>
        /// Creates a workplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        IAsyncResult BeginCreateWorkspace(CreateWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspace.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        CreateWorkspaceResponse EndCreateWorkspace(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteComponentType


        /// <summary>
        /// Deletes a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponentType service method.</param>
        /// 
        /// <returns>The response from the DeleteComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteComponentType">REST API Reference for DeleteComponentType Operation</seealso>
        DeleteComponentTypeResponse DeleteComponentType(DeleteComponentTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComponentType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponentType operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteComponentType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteComponentType">REST API Reference for DeleteComponentType Operation</seealso>
        IAsyncResult BeginDeleteComponentType(DeleteComponentTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteComponentType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteComponentType.</param>
        /// 
        /// <returns>Returns a  DeleteComponentTypeResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteComponentType">REST API Reference for DeleteComponentType Operation</seealso>
        DeleteComponentTypeResponse EndDeleteComponentType(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEntity


        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntity service method.</param>
        /// 
        /// <returns>The response from the DeleteEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteEntity">REST API Reference for DeleteEntity Operation</seealso>
        DeleteEntityResponse DeleteEntity(DeleteEntityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEntity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntity operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEntity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteEntity">REST API Reference for DeleteEntity Operation</seealso>
        IAsyncResult BeginDeleteEntity(DeleteEntityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEntity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEntity.</param>
        /// 
        /// <returns>Returns a  DeleteEntityResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteEntity">REST API Reference for DeleteEntity Operation</seealso>
        DeleteEntityResponse EndDeleteEntity(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteScene


        /// <summary>
        /// Deletes a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScene service method.</param>
        /// 
        /// <returns>The response from the DeleteScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteScene">REST API Reference for DeleteScene Operation</seealso>
        DeleteSceneResponse DeleteScene(DeleteSceneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScene operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScene operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScene
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteScene">REST API Reference for DeleteScene Operation</seealso>
        IAsyncResult BeginDeleteScene(DeleteSceneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScene operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScene.</param>
        /// 
        /// <returns>Returns a  DeleteSceneResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteScene">REST API Reference for DeleteScene Operation</seealso>
        DeleteSceneResponse EndDeleteScene(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSyncJob


        /// <summary>
        /// Delete the SyncJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSyncJob service method.</param>
        /// 
        /// <returns>The response from the DeleteSyncJob service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteSyncJob">REST API Reference for DeleteSyncJob Operation</seealso>
        DeleteSyncJobResponse DeleteSyncJob(DeleteSyncJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSyncJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSyncJob operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSyncJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteSyncJob">REST API Reference for DeleteSyncJob Operation</seealso>
        IAsyncResult BeginDeleteSyncJob(DeleteSyncJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSyncJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSyncJob.</param>
        /// 
        /// <returns>Returns a  DeleteSyncJobResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteSyncJob">REST API Reference for DeleteSyncJob Operation</seealso>
        DeleteSyncJobResponse EndDeleteSyncJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkspace


        /// <summary>
        /// Deletes a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        DeleteWorkspaceResponse DeleteWorkspace(DeleteWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        IAsyncResult BeginDeleteWorkspace(DeleteWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspace.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        DeleteWorkspaceResponse EndDeleteWorkspace(IAsyncResult asyncResult);

        #endregion
        
        #region  ExecuteQuery


        /// <summary>
        /// Run queries to access information from your knowledge graph of entities within individual
        /// workspaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteQuery service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.QueryTimeoutException">
        /// The query timeout exception.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        ExecuteQueryResponse ExecuteQuery(ExecuteQueryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        IAsyncResult BeginExecuteQuery(ExecuteQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteQuery.</param>
        /// 
        /// <returns>Returns a  ExecuteQueryResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        ExecuteQueryResponse EndExecuteQuery(IAsyncResult asyncResult);

        #endregion
        
        #region  GetComponentType


        /// <summary>
        /// Retrieves information about a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponentType service method.</param>
        /// 
        /// <returns>The response from the GetComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetComponentType">REST API Reference for GetComponentType Operation</seealso>
        GetComponentTypeResponse GetComponentType(GetComponentTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetComponentType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComponentType operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComponentType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetComponentType">REST API Reference for GetComponentType Operation</seealso>
        IAsyncResult BeginGetComponentType(GetComponentTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetComponentType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComponentType.</param>
        /// 
        /// <returns>Returns a  GetComponentTypeResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetComponentType">REST API Reference for GetComponentType Operation</seealso>
        GetComponentTypeResponse EndGetComponentType(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEntity


        /// <summary>
        /// Retrieves information about an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntity service method.</param>
        /// 
        /// <returns>The response from the GetEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetEntity">REST API Reference for GetEntity Operation</seealso>
        GetEntityResponse GetEntity(GetEntityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEntity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEntity operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEntity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetEntity">REST API Reference for GetEntity Operation</seealso>
        IAsyncResult BeginGetEntity(GetEntityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEntity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEntity.</param>
        /// 
        /// <returns>Returns a  GetEntityResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetEntity">REST API Reference for GetEntity Operation</seealso>
        GetEntityResponse EndGetEntity(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPricingPlan


        /// <summary>
        /// Gets the pricing plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPricingPlan service method.</param>
        /// 
        /// <returns>The response from the GetPricingPlan service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPricingPlan">REST API Reference for GetPricingPlan Operation</seealso>
        GetPricingPlanResponse GetPricingPlan(GetPricingPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPricingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPricingPlan operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPricingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPricingPlan">REST API Reference for GetPricingPlan Operation</seealso>
        IAsyncResult BeginGetPricingPlan(GetPricingPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPricingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPricingPlan.</param>
        /// 
        /// <returns>Returns a  GetPricingPlanResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPricingPlan">REST API Reference for GetPricingPlan Operation</seealso>
        GetPricingPlanResponse EndGetPricingPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPropertyValue


        /// <summary>
        /// Gets the property values for a component, component type, entity, or workspace.
        /// 
        ///  
        /// <para>
        /// You must specify a value for either <code>componentName</code>, <code>componentTypeId</code>,
        /// <code>entityId</code>, or <code>workspaceId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertyValue service method.</param>
        /// 
        /// <returns>The response from the GetPropertyValue service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorFailureException">
        /// The connector failed.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorTimeoutException">
        /// The connector timed out.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPropertyValue">REST API Reference for GetPropertyValue Operation</seealso>
        GetPropertyValueResponse GetPropertyValue(GetPropertyValueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPropertyValue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPropertyValue operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPropertyValue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPropertyValue">REST API Reference for GetPropertyValue Operation</seealso>
        IAsyncResult BeginGetPropertyValue(GetPropertyValueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPropertyValue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPropertyValue.</param>
        /// 
        /// <returns>Returns a  GetPropertyValueResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPropertyValue">REST API Reference for GetPropertyValue Operation</seealso>
        GetPropertyValueResponse EndGetPropertyValue(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPropertyValueHistory


        /// <summary>
        /// Retrieves information about the history of a time series property value for a component,
        /// component type, entity, or workspace.
        /// 
        ///  
        /// <para>
        /// You must specify a value for <code>workspaceId</code>. For entity-specific queries,
        /// specify values for <code>componentName</code> and <code>entityId</code>. For cross-entity
        /// quries, specify a value for <code>componentTypeId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertyValueHistory service method.</param>
        /// 
        /// <returns>The response from the GetPropertyValueHistory service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorFailureException">
        /// The connector failed.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorTimeoutException">
        /// The connector timed out.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPropertyValueHistory">REST API Reference for GetPropertyValueHistory Operation</seealso>
        GetPropertyValueHistoryResponse GetPropertyValueHistory(GetPropertyValueHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPropertyValueHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPropertyValueHistory operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPropertyValueHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPropertyValueHistory">REST API Reference for GetPropertyValueHistory Operation</seealso>
        IAsyncResult BeginGetPropertyValueHistory(GetPropertyValueHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPropertyValueHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPropertyValueHistory.</param>
        /// 
        /// <returns>Returns a  GetPropertyValueHistoryResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPropertyValueHistory">REST API Reference for GetPropertyValueHistory Operation</seealso>
        GetPropertyValueHistoryResponse EndGetPropertyValueHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  GetScene


        /// <summary>
        /// Retrieves information about a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScene service method.</param>
        /// 
        /// <returns>The response from the GetScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetScene">REST API Reference for GetScene Operation</seealso>
        GetSceneResponse GetScene(GetSceneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetScene operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetScene operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetScene
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetScene">REST API Reference for GetScene Operation</seealso>
        IAsyncResult BeginGetScene(GetSceneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetScene operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetScene.</param>
        /// 
        /// <returns>Returns a  GetSceneResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetScene">REST API Reference for GetScene Operation</seealso>
        GetSceneResponse EndGetScene(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSyncJob


        /// <summary>
        /// Gets the SyncJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSyncJob service method.</param>
        /// 
        /// <returns>The response from the GetSyncJob service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetSyncJob">REST API Reference for GetSyncJob Operation</seealso>
        GetSyncJobResponse GetSyncJob(GetSyncJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSyncJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSyncJob operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSyncJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetSyncJob">REST API Reference for GetSyncJob Operation</seealso>
        IAsyncResult BeginGetSyncJob(GetSyncJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSyncJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSyncJob.</param>
        /// 
        /// <returns>Returns a  GetSyncJobResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetSyncJob">REST API Reference for GetSyncJob Operation</seealso>
        GetSyncJobResponse EndGetSyncJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkspace


        /// <summary>
        /// Retrieves information about a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkspace service method.</param>
        /// 
        /// <returns>The response from the GetWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetWorkspace">REST API Reference for GetWorkspace Operation</seealso>
        GetWorkspaceResponse GetWorkspace(GetWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkspace operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetWorkspace">REST API Reference for GetWorkspace Operation</seealso>
        IAsyncResult BeginGetWorkspace(GetWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkspace.</param>
        /// 
        /// <returns>Returns a  GetWorkspaceResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetWorkspace">REST API Reference for GetWorkspace Operation</seealso>
        GetWorkspaceResponse EndGetWorkspace(IAsyncResult asyncResult);

        #endregion
        
        #region  ListComponentTypes


        /// <summary>
        /// Lists all component types in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponentTypes service method.</param>
        /// 
        /// <returns>The response from the ListComponentTypes service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListComponentTypes">REST API Reference for ListComponentTypes Operation</seealso>
        ListComponentTypesResponse ListComponentTypes(ListComponentTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponentTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponentTypes operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponentTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListComponentTypes">REST API Reference for ListComponentTypes Operation</seealso>
        IAsyncResult BeginListComponentTypes(ListComponentTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponentTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponentTypes.</param>
        /// 
        /// <returns>Returns a  ListComponentTypesResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListComponentTypes">REST API Reference for ListComponentTypes Operation</seealso>
        ListComponentTypesResponse EndListComponentTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEntities


        /// <summary>
        /// Lists all entities in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntities service method.</param>
        /// 
        /// <returns>The response from the ListEntities service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListEntities">REST API Reference for ListEntities Operation</seealso>
        ListEntitiesResponse ListEntities(ListEntitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntities operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListEntities">REST API Reference for ListEntities Operation</seealso>
        IAsyncResult BeginListEntities(ListEntitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntities.</param>
        /// 
        /// <returns>Returns a  ListEntitiesResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListEntities">REST API Reference for ListEntities Operation</seealso>
        ListEntitiesResponse EndListEntities(IAsyncResult asyncResult);

        #endregion
        
        #region  ListScenes


        /// <summary>
        /// Lists all scenes in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScenes service method.</param>
        /// 
        /// <returns>The response from the ListScenes service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListScenes">REST API Reference for ListScenes Operation</seealso>
        ListScenesResponse ListScenes(ListScenesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListScenes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListScenes operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListScenes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListScenes">REST API Reference for ListScenes Operation</seealso>
        IAsyncResult BeginListScenes(ListScenesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListScenes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListScenes.</param>
        /// 
        /// <returns>Returns a  ListScenesResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListScenes">REST API Reference for ListScenes Operation</seealso>
        ListScenesResponse EndListScenes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSyncJobs


        /// <summary>
        /// List all SyncJobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSyncJobs service method.</param>
        /// 
        /// <returns>The response from the ListSyncJobs service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListSyncJobs">REST API Reference for ListSyncJobs Operation</seealso>
        ListSyncJobsResponse ListSyncJobs(ListSyncJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSyncJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSyncJobs operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSyncJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListSyncJobs">REST API Reference for ListSyncJobs Operation</seealso>
        IAsyncResult BeginListSyncJobs(ListSyncJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSyncJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSyncJobs.</param>
        /// 
        /// <returns>Returns a  ListSyncJobsResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListSyncJobs">REST API Reference for ListSyncJobs Operation</seealso>
        ListSyncJobsResponse EndListSyncJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSyncResources


        /// <summary>
        /// Lists the sync resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSyncResources service method.</param>
        /// 
        /// <returns>The response from the ListSyncResources service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListSyncResources">REST API Reference for ListSyncResources Operation</seealso>
        ListSyncResourcesResponse ListSyncResources(ListSyncResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSyncResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSyncResources operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSyncResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListSyncResources">REST API Reference for ListSyncResources Operation</seealso>
        IAsyncResult BeginListSyncResources(ListSyncResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSyncResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSyncResources.</param>
        /// 
        /// <returns>Returns a  ListSyncResourcesResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListSyncResources">REST API Reference for ListSyncResources Operation</seealso>
        ListSyncResourcesResponse EndListSyncResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkspaces


        /// <summary>
        /// Retrieves information about workspaces in the current account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
        /// 
        /// <returns>The response from the ListWorkspaces service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        IAsyncResult BeginListWorkspaces(ListWorkspacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkspaces.</param>
        /// 
        /// <returns>Returns a  ListWorkspacesResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        ListWorkspacesResponse EndListWorkspaces(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.TooManyTagsException">
        /// The number of tags exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateComponentType


        /// <summary>
        /// Updates information in a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponentType service method.</param>
        /// 
        /// <returns>The response from the UpdateComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateComponentType">REST API Reference for UpdateComponentType Operation</seealso>
        UpdateComponentTypeResponse UpdateComponentType(UpdateComponentTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComponentType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponentType operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateComponentType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateComponentType">REST API Reference for UpdateComponentType Operation</seealso>
        IAsyncResult BeginUpdateComponentType(UpdateComponentTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateComponentType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateComponentType.</param>
        /// 
        /// <returns>Returns a  UpdateComponentTypeResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateComponentType">REST API Reference for UpdateComponentType Operation</seealso>
        UpdateComponentTypeResponse EndUpdateComponentType(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEntity


        /// <summary>
        /// Updates an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEntity service method.</param>
        /// 
        /// <returns>The response from the UpdateEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateEntity">REST API Reference for UpdateEntity Operation</seealso>
        UpdateEntityResponse UpdateEntity(UpdateEntityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEntity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEntity operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEntity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateEntity">REST API Reference for UpdateEntity Operation</seealso>
        IAsyncResult BeginUpdateEntity(UpdateEntityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEntity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEntity.</param>
        /// 
        /// <returns>Returns a  UpdateEntityResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateEntity">REST API Reference for UpdateEntity Operation</seealso>
        UpdateEntityResponse EndUpdateEntity(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePricingPlan


        /// <summary>
        /// Update the pricing plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePricingPlan service method.</param>
        /// 
        /// <returns>The response from the UpdatePricingPlan service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdatePricingPlan">REST API Reference for UpdatePricingPlan Operation</seealso>
        UpdatePricingPlanResponse UpdatePricingPlan(UpdatePricingPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePricingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePricingPlan operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePricingPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdatePricingPlan">REST API Reference for UpdatePricingPlan Operation</seealso>
        IAsyncResult BeginUpdatePricingPlan(UpdatePricingPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePricingPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePricingPlan.</param>
        /// 
        /// <returns>Returns a  UpdatePricingPlanResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdatePricingPlan">REST API Reference for UpdatePricingPlan Operation</seealso>
        UpdatePricingPlanResponse EndUpdatePricingPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateScene


        /// <summary>
        /// Updates a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScene service method.</param>
        /// 
        /// <returns>The response from the UpdateScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateScene">REST API Reference for UpdateScene Operation</seealso>
        UpdateSceneResponse UpdateScene(UpdateSceneRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScene operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScene operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateScene
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateScene">REST API Reference for UpdateScene Operation</seealso>
        IAsyncResult BeginUpdateScene(UpdateSceneRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateScene operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateScene.</param>
        /// 
        /// <returns>Returns a  UpdateSceneResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateScene">REST API Reference for UpdateScene Operation</seealso>
        UpdateSceneResponse EndUpdateScene(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkspace


        /// <summary>
        /// Updates a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspace service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        UpdateWorkspaceResponse UpdateWorkspace(UpdateWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspace operation on AmazonIoTTwinMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        IAsyncResult BeginUpdateWorkspace(UpdateWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspace.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspaceResult from IoTTwinMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        UpdateWorkspaceResponse EndUpdateWorkspace(IAsyncResult asyncResult);

        #endregion
        
    }
}