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
 * Do not modify this file. This file is generated from the iot-roborunner-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTRoboRunner.Model;

namespace Amazon.IoTRoboRunner
{
    /// <summary>
    /// Interface for accessing IoTRoboRunner
    ///
    /// An example service, deployed with the Octane Service creator, which will echo the
    /// string
    /// </summary>
    public partial interface IAmazonIoTRoboRunner : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTRoboRunnerPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateDestination


        /// <summary>
        /// Grants permission to create a destination
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination service method.</param>
        /// 
        /// <returns>The response from the CreateDestination service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ServiceQuotaExceededException">
        /// Exception thrown if the user's AWS account has reached a service limit and the operation
        /// cannot proceed.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        CreateDestinationResponse CreateDestination(CreateDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        IAsyncResult BeginCreateDestination(CreateDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDestination.</param>
        /// 
        /// <returns>Returns a  CreateDestinationResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        CreateDestinationResponse EndCreateDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSite


        /// <summary>
        /// Grants permission to create a site
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSite service method.</param>
        /// 
        /// <returns>The response from the CreateSite service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ServiceQuotaExceededException">
        /// Exception thrown if the user's AWS account has reached a service limit and the operation
        /// cannot proceed.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateSite">REST API Reference for CreateSite Operation</seealso>
        CreateSiteResponse CreateSite(CreateSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSite operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateSite">REST API Reference for CreateSite Operation</seealso>
        IAsyncResult BeginCreateSite(CreateSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSite.</param>
        /// 
        /// <returns>Returns a  CreateSiteResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateSite">REST API Reference for CreateSite Operation</seealso>
        CreateSiteResponse EndCreateSite(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorker


        /// <summary>
        /// Grants permission to create a worker
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorker service method.</param>
        /// 
        /// <returns>The response from the CreateWorker service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ServiceQuotaExceededException">
        /// Exception thrown if the user's AWS account has reached a service limit and the operation
        /// cannot proceed.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateWorker">REST API Reference for CreateWorker Operation</seealso>
        CreateWorkerResponse CreateWorker(CreateWorkerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorker operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateWorker">REST API Reference for CreateWorker Operation</seealso>
        IAsyncResult BeginCreateWorker(CreateWorkerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorker.</param>
        /// 
        /// <returns>Returns a  CreateWorkerResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateWorker">REST API Reference for CreateWorker Operation</seealso>
        CreateWorkerResponse EndCreateWorker(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkerFleet


        /// <summary>
        /// Grants permission to create a worker fleet
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerFleet service method.</param>
        /// 
        /// <returns>The response from the CreateWorkerFleet service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ServiceQuotaExceededException">
        /// Exception thrown if the user's AWS account has reached a service limit and the operation
        /// cannot proceed.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateWorkerFleet">REST API Reference for CreateWorkerFleet Operation</seealso>
        CreateWorkerFleetResponse CreateWorkerFleet(CreateWorkerFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerFleet operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkerFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateWorkerFleet">REST API Reference for CreateWorkerFleet Operation</seealso>
        IAsyncResult BeginCreateWorkerFleet(CreateWorkerFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkerFleet.</param>
        /// 
        /// <returns>Returns a  CreateWorkerFleetResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/CreateWorkerFleet">REST API Reference for CreateWorkerFleet Operation</seealso>
        CreateWorkerFleetResponse EndCreateWorkerFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDestination


        /// <summary>
        /// Grants permission to delete a destination
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteDestination service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        IAsyncResult BeginDeleteDestination(DeleteDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDestination.</param>
        /// 
        /// <returns>Returns a  DeleteDestinationResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        DeleteDestinationResponse EndDeleteDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSite


        /// <summary>
        /// Grants permission to delete a site
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite service method.</param>
        /// 
        /// <returns>The response from the DeleteSite service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        DeleteSiteResponse DeleteSite(DeleteSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        IAsyncResult BeginDeleteSite(DeleteSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSite.</param>
        /// 
        /// <returns>Returns a  DeleteSiteResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        DeleteSiteResponse EndDeleteSite(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorker


        /// <summary>
        /// Grants permission to delete a worker
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorker service method.</param>
        /// 
        /// <returns>The response from the DeleteWorker service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteWorker">REST API Reference for DeleteWorker Operation</seealso>
        DeleteWorkerResponse DeleteWorker(DeleteWorkerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorker operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteWorker">REST API Reference for DeleteWorker Operation</seealso>
        IAsyncResult BeginDeleteWorker(DeleteWorkerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorker.</param>
        /// 
        /// <returns>Returns a  DeleteWorkerResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteWorker">REST API Reference for DeleteWorker Operation</seealso>
        DeleteWorkerResponse EndDeleteWorker(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkerFleet


        /// <summary>
        /// Grants permission to delete a worker fleet
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkerFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkerFleet service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ConflictException">
        /// Exception thrown if a resource in a create request already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteWorkerFleet">REST API Reference for DeleteWorkerFleet Operation</seealso>
        DeleteWorkerFleetResponse DeleteWorkerFleet(DeleteWorkerFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkerFleet operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkerFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteWorkerFleet">REST API Reference for DeleteWorkerFleet Operation</seealso>
        IAsyncResult BeginDeleteWorkerFleet(DeleteWorkerFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkerFleet.</param>
        /// 
        /// <returns>Returns a  DeleteWorkerFleetResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/DeleteWorkerFleet">REST API Reference for DeleteWorkerFleet Operation</seealso>
        DeleteWorkerFleetResponse EndDeleteWorkerFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDestination


        /// <summary>
        /// Grants permission to get a destination
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDestination service method.</param>
        /// 
        /// <returns>The response from the GetDestination service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetDestination">REST API Reference for GetDestination Operation</seealso>
        GetDestinationResponse GetDestination(GetDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDestination operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetDestination">REST API Reference for GetDestination Operation</seealso>
        IAsyncResult BeginGetDestination(GetDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDestination.</param>
        /// 
        /// <returns>Returns a  GetDestinationResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetDestination">REST API Reference for GetDestination Operation</seealso>
        GetDestinationResponse EndGetDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSite


        /// <summary>
        /// Grants permission to get a site
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSite service method.</param>
        /// 
        /// <returns>The response from the GetSite service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetSite">REST API Reference for GetSite Operation</seealso>
        GetSiteResponse GetSite(GetSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSite operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetSite">REST API Reference for GetSite Operation</seealso>
        IAsyncResult BeginGetSite(GetSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSite.</param>
        /// 
        /// <returns>Returns a  GetSiteResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetSite">REST API Reference for GetSite Operation</seealso>
        GetSiteResponse EndGetSite(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorker


        /// <summary>
        /// Grants permission to get a worker
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorker service method.</param>
        /// 
        /// <returns>The response from the GetWorker service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetWorker">REST API Reference for GetWorker Operation</seealso>
        GetWorkerResponse GetWorker(GetWorkerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorker operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetWorker">REST API Reference for GetWorker Operation</seealso>
        IAsyncResult BeginGetWorker(GetWorkerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorker.</param>
        /// 
        /// <returns>Returns a  GetWorkerResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetWorker">REST API Reference for GetWorker Operation</seealso>
        GetWorkerResponse EndGetWorker(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkerFleet


        /// <summary>
        /// Grants permission to get a worker fleet
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkerFleet service method.</param>
        /// 
        /// <returns>The response from the GetWorkerFleet service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetWorkerFleet">REST API Reference for GetWorkerFleet Operation</seealso>
        GetWorkerFleetResponse GetWorkerFleet(GetWorkerFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkerFleet operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkerFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetWorkerFleet">REST API Reference for GetWorkerFleet Operation</seealso>
        IAsyncResult BeginGetWorkerFleet(GetWorkerFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkerFleet.</param>
        /// 
        /// <returns>Returns a  GetWorkerFleetResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/GetWorkerFleet">REST API Reference for GetWorkerFleet Operation</seealso>
        GetWorkerFleetResponse EndGetWorkerFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDestinations


        /// <summary>
        /// Grants permission to list destinations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations service method.</param>
        /// 
        /// <returns>The response from the ListDestinations service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        ListDestinationsResponse ListDestinations(ListDestinationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        IAsyncResult BeginListDestinations(ListDestinationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDestinations.</param>
        /// 
        /// <returns>Returns a  ListDestinationsResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        ListDestinationsResponse EndListDestinations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSites


        /// <summary>
        /// Grants permission to list sites
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSites service method.</param>
        /// 
        /// <returns>The response from the ListSites service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListSites">REST API Reference for ListSites Operation</seealso>
        ListSitesResponse ListSites(ListSitesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSites operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListSites">REST API Reference for ListSites Operation</seealso>
        IAsyncResult BeginListSites(ListSitesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSites.</param>
        /// 
        /// <returns>Returns a  ListSitesResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListSites">REST API Reference for ListSites Operation</seealso>
        ListSitesResponse EndListSites(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkerFleets


        /// <summary>
        /// Grants permission to list worker fleets
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerFleets service method.</param>
        /// 
        /// <returns>The response from the ListWorkerFleets service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListWorkerFleets">REST API Reference for ListWorkerFleets Operation</seealso>
        ListWorkerFleetsResponse ListWorkerFleets(ListWorkerFleetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkerFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerFleets operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkerFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListWorkerFleets">REST API Reference for ListWorkerFleets Operation</seealso>
        IAsyncResult BeginListWorkerFleets(ListWorkerFleetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkerFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkerFleets.</param>
        /// 
        /// <returns>Returns a  ListWorkerFleetsResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListWorkerFleets">REST API Reference for ListWorkerFleets Operation</seealso>
        ListWorkerFleetsResponse EndListWorkerFleets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkers


        /// <summary>
        /// Grants permission to list workers
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkers service method.</param>
        /// 
        /// <returns>The response from the ListWorkers service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListWorkers">REST API Reference for ListWorkers Operation</seealso>
        ListWorkersResponse ListWorkers(ListWorkersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkers operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListWorkers">REST API Reference for ListWorkers Operation</seealso>
        IAsyncResult BeginListWorkers(ListWorkersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkers.</param>
        /// 
        /// <returns>Returns a  ListWorkersResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/ListWorkers">REST API Reference for ListWorkers Operation</seealso>
        ListWorkersResponse EndListWorkers(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDestination


        /// <summary>
        /// Grants permission to update a destination
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateDestination service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        UpdateDestinationResponse UpdateDestination(UpdateDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        IAsyncResult BeginUpdateDestination(UpdateDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDestination.</param>
        /// 
        /// <returns>Returns a  UpdateDestinationResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        UpdateDestinationResponse EndUpdateDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSite


        /// <summary>
        /// Grants permission to update a site
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite service method.</param>
        /// 
        /// <returns>The response from the UpdateSite service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        UpdateSiteResponse UpdateSite(UpdateSiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        IAsyncResult BeginUpdateSite(UpdateSiteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSite.</param>
        /// 
        /// <returns>Returns a  UpdateSiteResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        UpdateSiteResponse EndUpdateSite(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorker


        /// <summary>
        /// Grants permission to update a worker
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorker service method.</param>
        /// 
        /// <returns>The response from the UpdateWorker service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateWorker">REST API Reference for UpdateWorker Operation</seealso>
        UpdateWorkerResponse UpdateWorker(UpdateWorkerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorker operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateWorker">REST API Reference for UpdateWorker Operation</seealso>
        IAsyncResult BeginUpdateWorker(UpdateWorkerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorker.</param>
        /// 
        /// <returns>Returns a  UpdateWorkerResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateWorker">REST API Reference for UpdateWorker Operation</seealso>
        UpdateWorkerResponse EndUpdateWorker(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkerFleet


        /// <summary>
        /// Grants permission to update a worker fleet
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkerFleet service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkerFleet service method, as returned by IoTRoboRunner.</returns>
        /// <exception cref="Amazon.IoTRoboRunner.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.InternalServerException">
        /// Exception thrown if something goes wrong within the service.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ResourceNotFoundException">
        /// Exception thrown if a resource referenced in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ThrottlingException">
        /// Exception thrown if the api has been called too quickly be the client.
        /// </exception>
        /// <exception cref="Amazon.IoTRoboRunner.Model.ValidationException">
        /// Exception thrown if an invalid parameter is provided to an API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateWorkerFleet">REST API Reference for UpdateWorkerFleet Operation</seealso>
        UpdateWorkerFleetResponse UpdateWorkerFleet(UpdateWorkerFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkerFleet operation on AmazonIoTRoboRunnerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkerFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateWorkerFleet">REST API Reference for UpdateWorkerFleet Operation</seealso>
        IAsyncResult BeginUpdateWorkerFleet(UpdateWorkerFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkerFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkerFleet.</param>
        /// 
        /// <returns>Returns a  UpdateWorkerFleetResult from IoTRoboRunner.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-roborunner-2018-05-10/UpdateWorkerFleet">REST API Reference for UpdateWorkerFleet Operation</seealso>
        UpdateWorkerFleetResponse EndUpdateWorkerFleet(IAsyncResult asyncResult);

        #endregion
        
    }
}