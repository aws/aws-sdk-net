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
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTRoboRunnerPaginatorFactory Paginators { get; }

        
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
        /// Grants permission to create a destination
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDestinationResponse> CreateDestinationAsync(CreateDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to create a site
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateSiteResponse> CreateSiteAsync(CreateSiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to create a worker
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateWorkerResponse> CreateWorkerAsync(CreateWorkerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to create a worker fleet
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateWorkerFleetResponse> CreateWorkerFleetAsync(CreateWorkerFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to delete a destination
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDestinationResponse> DeleteDestinationAsync(DeleteDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to delete a site
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteSiteResponse> DeleteSiteAsync(DeleteSiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to delete a worker
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteWorkerResponse> DeleteWorkerAsync(DeleteWorkerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to delete a worker fleet
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkerFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteWorkerFleetResponse> DeleteWorkerFleetAsync(DeleteWorkerFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to get a destination
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDestinationResponse> GetDestinationAsync(GetDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to get a site
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSiteResponse> GetSiteAsync(GetSiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to get a worker
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetWorkerResponse> GetWorkerAsync(GetWorkerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to get a worker fleet
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkerFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetWorkerFleetResponse> GetWorkerFleetAsync(GetWorkerFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to list destinations
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDestinationsResponse> ListDestinationsAsync(ListDestinationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to list sites
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSites service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSitesResponse> ListSitesAsync(ListSitesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to list worker fleets
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListWorkerFleetsResponse> ListWorkerFleetsAsync(ListWorkerFleetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to list workers
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListWorkersResponse> ListWorkersAsync(ListWorkersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to update a destination
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateDestinationResponse> UpdateDestinationAsync(UpdateDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to update a site
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateSiteResponse> UpdateSiteAsync(UpdateSiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to update a worker
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateWorkerResponse> UpdateWorkerAsync(UpdateWorkerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Grants permission to update a worker fleet
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkerFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateWorkerFleetResponse> UpdateWorkerFleetAsync(UpdateWorkerFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}