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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTFleetWise.Model;

namespace Amazon.IoTFleetWise
{
    /// <summary>
    /// Interface for accessing IoTFleetWise
    ///
    /// Amazon Web Services IoT FleetWise is a fully managed service that you can use to collect,
    /// model, and transfer vehicle data to the Amazon Web Services cloud at scale. With Amazon
    /// Web Services IoT FleetWise, you can standardize all of your vehicle data models, independent
    /// of the in-vehicle communication architecture, and define data collection rules to
    /// transfer only high-value data to the cloud. 
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/">What
    /// is Amazon Web Services IoT FleetWise?</a> in the <i>Amazon Web Services IoT FleetWise
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonIoTFleetWise : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTFleetWisePaginatorFactory Paginators { get; }

        
        #region  AssociateVehicleFleet


        /// <summary>
        /// Adds, or associates, a vehicle with a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVehicleFleet service method.</param>
        /// 
        /// <returns>The response from the AssociateVehicleFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/AssociateVehicleFleet">REST API Reference for AssociateVehicleFleet Operation</seealso>
        AssociateVehicleFleetResponse AssociateVehicleFleet(AssociateVehicleFleetRequest request);



        /// <summary>
        /// Adds, or associates, a vehicle with a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVehicleFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateVehicleFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/AssociateVehicleFleet">REST API Reference for AssociateVehicleFleet Operation</seealso>
        Task<AssociateVehicleFleetResponse> AssociateVehicleFleetAsync(AssociateVehicleFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchCreateVehicle


        /// <summary>
        /// Creates a group, or batch, of vehicles. 
        /// 
        ///  <note> 
        /// <para>
        ///  You must specify a decoder manifest and a vehicle model (model manifest) for each
        /// vehicle. 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/create-vehicles-cli.html">Create
        /// multiple vehicles (AWS CLI)</a> in the <i>Amazon Web Services IoT FleetWise Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateVehicle service method.</param>
        /// 
        /// <returns>The response from the BatchCreateVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/BatchCreateVehicle">REST API Reference for BatchCreateVehicle Operation</seealso>
        BatchCreateVehicleResponse BatchCreateVehicle(BatchCreateVehicleRequest request);



        /// <summary>
        /// Creates a group, or batch, of vehicles. 
        /// 
        ///  <note> 
        /// <para>
        ///  You must specify a decoder manifest and a vehicle model (model manifest) for each
        /// vehicle. 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/create-vehicles-cli.html">Create
        /// multiple vehicles (AWS CLI)</a> in the <i>Amazon Web Services IoT FleetWise Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateVehicle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/BatchCreateVehicle">REST API Reference for BatchCreateVehicle Operation</seealso>
        Task<BatchCreateVehicleResponse> BatchCreateVehicleAsync(BatchCreateVehicleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchUpdateVehicle


        /// <summary>
        /// Updates a group, or batch, of vehicles.
        /// 
        ///  <note> 
        /// <para>
        ///  You must specify a decoder manifest and a vehicle model (model manifest) for each
        /// vehicle. 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/update-vehicles-cli.html">Update
        /// multiple vehicles (AWS CLI)</a> in the <i>Amazon Web Services IoT FleetWise Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateVehicle service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/BatchUpdateVehicle">REST API Reference for BatchUpdateVehicle Operation</seealso>
        BatchUpdateVehicleResponse BatchUpdateVehicle(BatchUpdateVehicleRequest request);



        /// <summary>
        /// Updates a group, or batch, of vehicles.
        /// 
        ///  <note> 
        /// <para>
        ///  You must specify a decoder manifest and a vehicle model (model manifest) for each
        /// vehicle. 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/update-vehicles-cli.html">Update
        /// multiple vehicles (AWS CLI)</a> in the <i>Amazon Web Services IoT FleetWise Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateVehicle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/BatchUpdateVehicle">REST API Reference for BatchUpdateVehicle Operation</seealso>
        Task<BatchUpdateVehicleResponse> BatchUpdateVehicleAsync(BatchUpdateVehicleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCampaign


        /// <summary>
        /// Creates an orchestration of data collection rules. The Amazon Web Services IoT FleetWise
        /// Edge Agent software running in vehicles uses campaigns to decide how to collect and
        /// transfer data to the cloud. You create campaigns in the cloud. After you or your team
        /// approve campaigns, Amazon Web Services IoT FleetWise automatically deploys them to
        /// vehicles. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/campaigns.html">Collect
        /// and transfer data with campaigns</a> in the <i>Amazon Web Services IoT FleetWise Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// 
        /// <returns>The response from the CreateCampaign service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        CreateCampaignResponse CreateCampaign(CreateCampaignRequest request);



        /// <summary>
        /// Creates an orchestration of data collection rules. The Amazon Web Services IoT FleetWise
        /// Edge Agent software running in vehicles uses campaigns to decide how to collect and
        /// transfer data to the cloud. You create campaigns in the cloud. After you or your team
        /// approve campaigns, Amazon Web Services IoT FleetWise automatically deploys them to
        /// vehicles. 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/campaigns.html">Collect
        /// and transfer data with campaigns</a> in the <i>Amazon Web Services IoT FleetWise Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCampaign service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        Task<CreateCampaignResponse> CreateCampaignAsync(CreateCampaignRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDecoderManifest


        /// <summary>
        /// Creates the decoder manifest associated with a model manifest. To create a decoder
        /// manifest, the following must be true:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Every signal decoder has a unique name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each signal decoder is associated with a network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each network interface has a unique ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The signal decoders are specified in the model manifest.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDecoderManifest service method.</param>
        /// 
        /// <returns>The response from the CreateDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.DecoderManifestValidationException">
        /// The request couldn't be completed because it contains signal decoders with one or
        /// more validation errors.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateDecoderManifest">REST API Reference for CreateDecoderManifest Operation</seealso>
        CreateDecoderManifestResponse CreateDecoderManifest(CreateDecoderManifestRequest request);



        /// <summary>
        /// Creates the decoder manifest associated with a model manifest. To create a decoder
        /// manifest, the following must be true:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Every signal decoder has a unique name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each signal decoder is associated with a network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each network interface has a unique ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The signal decoders are specified in the model manifest.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDecoderManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.DecoderManifestValidationException">
        /// The request couldn't be completed because it contains signal decoders with one or
        /// more validation errors.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateDecoderManifest">REST API Reference for CreateDecoderManifest Operation</seealso>
        Task<CreateDecoderManifestResponse> CreateDecoderManifestAsync(CreateDecoderManifestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFleet


        /// <summary>
        /// Creates a fleet that represents a group of vehicles. 
        /// 
        ///  <note> 
        /// <para>
        /// You must create both a signal catalog and vehicles before you can create a fleet.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/fleets.html">Fleets</a>
        /// in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        CreateFleetResponse CreateFleet(CreateFleetRequest request);



        /// <summary>
        /// Creates a fleet that represents a group of vehicles. 
        /// 
        ///  <note> 
        /// <para>
        /// You must create both a signal catalog and vehicles before you can create a fleet.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/fleets.html">Fleets</a>
        /// in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateModelManifest


        /// <summary>
        /// Creates a vehicle model (model manifest) that specifies signals (attributes, branches,
        /// sensors, and actuators). 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/vehicle-models.html">Vehicle
        /// models</a> in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelManifest service method.</param>
        /// 
        /// <returns>The response from the CreateModelManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateModelManifest">REST API Reference for CreateModelManifest Operation</seealso>
        CreateModelManifestResponse CreateModelManifest(CreateModelManifestRequest request);



        /// <summary>
        /// Creates a vehicle model (model manifest) that specifies signals (attributes, branches,
        /// sensors, and actuators). 
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/vehicle-models.html">Vehicle
        /// models</a> in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateModelManifest">REST API Reference for CreateModelManifest Operation</seealso>
        Task<CreateModelManifestResponse> CreateModelManifestAsync(CreateModelManifestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSignalCatalog


        /// <summary>
        /// Creates a collection of standardized signals that can be reused to create vehicle
        /// models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSignalCatalog service method.</param>
        /// 
        /// <returns>The response from the CreateSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidNodeException">
        /// The specified node type doesn't match the expected node type for a node. You can specify
        /// the node type as branch, sensor, actuator, or attribute.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateSignalCatalog">REST API Reference for CreateSignalCatalog Operation</seealso>
        CreateSignalCatalogResponse CreateSignalCatalog(CreateSignalCatalogRequest request);



        /// <summary>
        /// Creates a collection of standardized signals that can be reused to create vehicle
        /// models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSignalCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidNodeException">
        /// The specified node type doesn't match the expected node type for a node. You can specify
        /// the node type as branch, sensor, actuator, or attribute.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateSignalCatalog">REST API Reference for CreateSignalCatalog Operation</seealso>
        Task<CreateSignalCatalogResponse> CreateSignalCatalogAsync(CreateSignalCatalogRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateVehicle


        /// <summary>
        /// Creates a vehicle, which is an instance of a vehicle model (model manifest). Vehicles
        /// created from the same vehicle model consist of the same signals inherited from the
        /// vehicle model.
        /// 
        ///  <note> 
        /// <para>
        ///  If you have an existing Amazon Web Services IoT Thing, you can use Amazon Web Services
        /// IoT FleetWise to create a vehicle and collect data from your thing. 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/create-vehicle-cli.html">Create
        /// a vehicle (AWS CLI)</a> in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVehicle service method.</param>
        /// 
        /// <returns>The response from the CreateVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateVehicle">REST API Reference for CreateVehicle Operation</seealso>
        CreateVehicleResponse CreateVehicle(CreateVehicleRequest request);



        /// <summary>
        /// Creates a vehicle, which is an instance of a vehicle model (model manifest). Vehicles
        /// created from the same vehicle model consist of the same signals inherited from the
        /// vehicle model.
        /// 
        ///  <note> 
        /// <para>
        ///  If you have an existing Amazon Web Services IoT Thing, you can use Amazon Web Services
        /// IoT FleetWise to create a vehicle and collect data from your thing. 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/create-vehicle-cli.html">Create
        /// a vehicle (AWS CLI)</a> in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVehicle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateVehicle">REST API Reference for CreateVehicle Operation</seealso>
        Task<CreateVehicleResponse> CreateVehicleAsync(CreateVehicleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCampaign


        /// <summary>
        /// Deletes a data collection campaign. Deleting a campaign suspends all data collection
        /// and removes it from any vehicles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaign service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request);



        /// <summary>
        /// Deletes a data collection campaign. Deleting a campaign suspends all data collection
        /// and removes it from any vehicles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCampaign service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        Task<DeleteCampaignResponse> DeleteCampaignAsync(DeleteCampaignRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDecoderManifest


        /// <summary>
        /// Deletes a decoder manifest. You can't delete a decoder manifest if it has vehicles
        /// associated with it. 
        /// 
        ///  <note> 
        /// <para>
        /// If the decoder manifest is successfully deleted, Amazon Web Services IoT FleetWise
        /// sends back an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDecoderManifest service method.</param>
        /// 
        /// <returns>The response from the DeleteDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteDecoderManifest">REST API Reference for DeleteDecoderManifest Operation</seealso>
        DeleteDecoderManifestResponse DeleteDecoderManifest(DeleteDecoderManifestRequest request);



        /// <summary>
        /// Deletes a decoder manifest. You can't delete a decoder manifest if it has vehicles
        /// associated with it. 
        /// 
        ///  <note> 
        /// <para>
        /// If the decoder manifest is successfully deleted, Amazon Web Services IoT FleetWise
        /// sends back an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDecoderManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteDecoderManifest">REST API Reference for DeleteDecoderManifest Operation</seealso>
        Task<DeleteDecoderManifestResponse> DeleteDecoderManifestAsync(DeleteDecoderManifestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFleet


        /// <summary>
        /// Deletes a fleet. Before you delete a fleet, all vehicles must be dissociated from
        /// the fleet. For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/delete-fleet-cli.html">Delete
        /// a fleet (AWS CLI)</a> in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// If the fleet is successfully deleted, Amazon Web Services IoT FleetWise sends back
        /// an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        DeleteFleetResponse DeleteFleet(DeleteFleetRequest request);



        /// <summary>
        /// Deletes a fleet. Before you delete a fleet, all vehicles must be dissociated from
        /// the fleet. For more information, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/delete-fleet-cli.html">Delete
        /// a fleet (AWS CLI)</a> in the <i>Amazon Web Services IoT FleetWise Developer Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// If the fleet is successfully deleted, Amazon Web Services IoT FleetWise sends back
        /// an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteModelManifest


        /// <summary>
        /// Deletes a vehicle model (model manifest).
        /// 
        ///  <note> 
        /// <para>
        /// If the vehicle model is successfully deleted, Amazon Web Services IoT FleetWise sends
        /// back an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelManifest service method.</param>
        /// 
        /// <returns>The response from the DeleteModelManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteModelManifest">REST API Reference for DeleteModelManifest Operation</seealso>
        DeleteModelManifestResponse DeleteModelManifest(DeleteModelManifestRequest request);



        /// <summary>
        /// Deletes a vehicle model (model manifest).
        /// 
        ///  <note> 
        /// <para>
        /// If the vehicle model is successfully deleted, Amazon Web Services IoT FleetWise sends
        /// back an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteModelManifest">REST API Reference for DeleteModelManifest Operation</seealso>
        Task<DeleteModelManifestResponse> DeleteModelManifestAsync(DeleteModelManifestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSignalCatalog


        /// <summary>
        /// Deletes a signal catalog. 
        /// 
        ///  <note> 
        /// <para>
        /// If the signal catalog is successfully deleted, Amazon Web Services IoT FleetWise sends
        /// back an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSignalCatalog service method.</param>
        /// 
        /// <returns>The response from the DeleteSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteSignalCatalog">REST API Reference for DeleteSignalCatalog Operation</seealso>
        DeleteSignalCatalogResponse DeleteSignalCatalog(DeleteSignalCatalogRequest request);



        /// <summary>
        /// Deletes a signal catalog. 
        /// 
        ///  <note> 
        /// <para>
        /// If the signal catalog is successfully deleted, Amazon Web Services IoT FleetWise sends
        /// back an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSignalCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteSignalCatalog">REST API Reference for DeleteSignalCatalog Operation</seealso>
        Task<DeleteSignalCatalogResponse> DeleteSignalCatalogAsync(DeleteSignalCatalogRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVehicle


        /// <summary>
        /// Deletes a vehicle and removes it from any campaigns.
        /// 
        ///  <note> 
        /// <para>
        /// If the vehicle is successfully deleted, Amazon Web Services IoT FleetWise sends back
        /// an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVehicle service method.</param>
        /// 
        /// <returns>The response from the DeleteVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteVehicle">REST API Reference for DeleteVehicle Operation</seealso>
        DeleteVehicleResponse DeleteVehicle(DeleteVehicleRequest request);



        /// <summary>
        /// Deletes a vehicle and removes it from any campaigns.
        /// 
        ///  <note> 
        /// <para>
        /// If the vehicle is successfully deleted, Amazon Web Services IoT FleetWise sends back
        /// an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVehicle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteVehicle">REST API Reference for DeleteVehicle Operation</seealso>
        Task<DeleteVehicleResponse> DeleteVehicleAsync(DeleteVehicleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateVehicleFleet


        /// <summary>
        /// Removes, or disassociates, a vehicle from a fleet. Disassociating a vehicle from a
        /// fleet doesn't delete the vehicle.
        /// 
        ///  <note> 
        /// <para>
        /// If the vehicle is successfully dissociated from a fleet, Amazon Web Services IoT FleetWise
        /// sends back an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVehicleFleet service method.</param>
        /// 
        /// <returns>The response from the DisassociateVehicleFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DisassociateVehicleFleet">REST API Reference for DisassociateVehicleFleet Operation</seealso>
        DisassociateVehicleFleetResponse DisassociateVehicleFleet(DisassociateVehicleFleetRequest request);



        /// <summary>
        /// Removes, or disassociates, a vehicle from a fleet. Disassociating a vehicle from a
        /// fleet doesn't delete the vehicle.
        /// 
        ///  <note> 
        /// <para>
        /// If the vehicle is successfully dissociated from a fleet, Amazon Web Services IoT FleetWise
        /// sends back an HTTP 200 response with an empty body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVehicleFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateVehicleFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DisassociateVehicleFleet">REST API Reference for DisassociateVehicleFleet Operation</seealso>
        Task<DisassociateVehicleFleetResponse> DisassociateVehicleFleetAsync(DisassociateVehicleFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCampaign


        /// <summary>
        /// Retrieves information about a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign service method.</param>
        /// 
        /// <returns>The response from the GetCampaign service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
        GetCampaignResponse GetCampaign(GetCampaignRequest request);



        /// <summary>
        /// Retrieves information about a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCampaign service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
        Task<GetCampaignResponse> GetCampaignAsync(GetCampaignRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDecoderManifest


        /// <summary>
        /// Retrieves information about a created decoder manifest.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDecoderManifest service method.</param>
        /// 
        /// <returns>The response from the GetDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetDecoderManifest">REST API Reference for GetDecoderManifest Operation</seealso>
        GetDecoderManifestResponse GetDecoderManifest(GetDecoderManifestRequest request);



        /// <summary>
        /// Retrieves information about a created decoder manifest.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDecoderManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetDecoderManifest">REST API Reference for GetDecoderManifest Operation</seealso>
        Task<GetDecoderManifestResponse> GetDecoderManifestAsync(GetDecoderManifestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFleet


        /// <summary>
        /// Retrieves information about a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFleet service method.</param>
        /// 
        /// <returns>The response from the GetFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetFleet">REST API Reference for GetFleet Operation</seealso>
        GetFleetResponse GetFleet(GetFleetRequest request);



        /// <summary>
        /// Retrieves information about a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetFleet">REST API Reference for GetFleet Operation</seealso>
        Task<GetFleetResponse> GetFleetAsync(GetFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLoggingOptions


        /// <summary>
        /// Retrieves the logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the GetLoggingOptions service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetLoggingOptions">REST API Reference for GetLoggingOptions Operation</seealso>
        GetLoggingOptionsResponse GetLoggingOptions(GetLoggingOptionsRequest request);



        /// <summary>
        /// Retrieves the logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLoggingOptions service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetLoggingOptions">REST API Reference for GetLoggingOptions Operation</seealso>
        Task<GetLoggingOptionsResponse> GetLoggingOptionsAsync(GetLoggingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetModelManifest


        /// <summary>
        /// Retrieves information about a vehicle model (model manifest).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelManifest service method.</param>
        /// 
        /// <returns>The response from the GetModelManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetModelManifest">REST API Reference for GetModelManifest Operation</seealso>
        GetModelManifestResponse GetModelManifest(GetModelManifestRequest request);



        /// <summary>
        /// Retrieves information about a vehicle model (model manifest).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModelManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetModelManifest">REST API Reference for GetModelManifest Operation</seealso>
        Task<GetModelManifestResponse> GetModelManifestAsync(GetModelManifestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRegisterAccountStatus


        /// <summary>
        /// Retrieves information about the status of registering your Amazon Web Services account,
        /// IAM, and Amazon Timestream resources so that Amazon Web Services IoT FleetWise can
        /// transfer your vehicle data to the Amazon Web Services Cloud. 
        /// 
        ///  
        /// <para>
        /// For more information, including step-by-step procedures, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/setting-up.html">Setting
        /// up Amazon Web Services IoT FleetWise</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation doesn't require input parameters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegisterAccountStatus service method.</param>
        /// 
        /// <returns>The response from the GetRegisterAccountStatus service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetRegisterAccountStatus">REST API Reference for GetRegisterAccountStatus Operation</seealso>
        GetRegisterAccountStatusResponse GetRegisterAccountStatus(GetRegisterAccountStatusRequest request);



        /// <summary>
        /// Retrieves information about the status of registering your Amazon Web Services account,
        /// IAM, and Amazon Timestream resources so that Amazon Web Services IoT FleetWise can
        /// transfer your vehicle data to the Amazon Web Services Cloud. 
        /// 
        ///  
        /// <para>
        /// For more information, including step-by-step procedures, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/setting-up.html">Setting
        /// up Amazon Web Services IoT FleetWise</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation doesn't require input parameters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegisterAccountStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRegisterAccountStatus service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetRegisterAccountStatus">REST API Reference for GetRegisterAccountStatus Operation</seealso>
        Task<GetRegisterAccountStatusResponse> GetRegisterAccountStatusAsync(GetRegisterAccountStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSignalCatalog


        /// <summary>
        /// Retrieves information about a signal catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSignalCatalog service method.</param>
        /// 
        /// <returns>The response from the GetSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetSignalCatalog">REST API Reference for GetSignalCatalog Operation</seealso>
        GetSignalCatalogResponse GetSignalCatalog(GetSignalCatalogRequest request);



        /// <summary>
        /// Retrieves information about a signal catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSignalCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetSignalCatalog">REST API Reference for GetSignalCatalog Operation</seealso>
        Task<GetSignalCatalogResponse> GetSignalCatalogAsync(GetSignalCatalogRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetVehicle


        /// <summary>
        /// Retrieves information about a vehicle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVehicle service method.</param>
        /// 
        /// <returns>The response from the GetVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetVehicle">REST API Reference for GetVehicle Operation</seealso>
        GetVehicleResponse GetVehicle(GetVehicleRequest request);



        /// <summary>
        /// Retrieves information about a vehicle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVehicle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetVehicle">REST API Reference for GetVehicle Operation</seealso>
        Task<GetVehicleResponse> GetVehicleAsync(GetVehicleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetVehicleStatus


        /// <summary>
        /// Retrieves information about the status of a vehicle with any associated campaigns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVehicleStatus service method.</param>
        /// 
        /// <returns>The response from the GetVehicleStatus service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetVehicleStatus">REST API Reference for GetVehicleStatus Operation</seealso>
        GetVehicleStatusResponse GetVehicleStatus(GetVehicleStatusRequest request);



        /// <summary>
        /// Retrieves information about the status of a vehicle with any associated campaigns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVehicleStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVehicleStatus service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetVehicleStatus">REST API Reference for GetVehicleStatus Operation</seealso>
        Task<GetVehicleStatusResponse> GetVehicleStatusAsync(GetVehicleStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportDecoderManifest


        /// <summary>
        /// Creates a decoder manifest using your existing CAN DBC file from your local device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDecoderManifest service method.</param>
        /// 
        /// <returns>The response from the ImportDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.DecoderManifestValidationException">
        /// The request couldn't be completed because it contains signal decoders with one or
        /// more validation errors.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ImportDecoderManifest">REST API Reference for ImportDecoderManifest Operation</seealso>
        ImportDecoderManifestResponse ImportDecoderManifest(ImportDecoderManifestRequest request);



        /// <summary>
        /// Creates a decoder manifest using your existing CAN DBC file from your local device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDecoderManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.DecoderManifestValidationException">
        /// The request couldn't be completed because it contains signal decoders with one or
        /// more validation errors.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ImportDecoderManifest">REST API Reference for ImportDecoderManifest Operation</seealso>
        Task<ImportDecoderManifestResponse> ImportDecoderManifestAsync(ImportDecoderManifestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportSignalCatalog


        /// <summary>
        /// Creates a signal catalog using your existing VSS formatted content from your local
        /// device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSignalCatalog service method.</param>
        /// 
        /// <returns>The response from the ImportSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ImportSignalCatalog">REST API Reference for ImportSignalCatalog Operation</seealso>
        ImportSignalCatalogResponse ImportSignalCatalog(ImportSignalCatalogRequest request);



        /// <summary>
        /// Creates a signal catalog using your existing VSS formatted content from your local
        /// device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSignalCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ImportSignalCatalog">REST API Reference for ImportSignalCatalog Operation</seealso>
        Task<ImportSignalCatalogResponse> ImportSignalCatalogAsync(ImportSignalCatalogRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCampaigns


        /// <summary>
        /// Lists information about created campaigns. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns service method.</param>
        /// 
        /// <returns>The response from the ListCampaigns service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        ListCampaignsResponse ListCampaigns(ListCampaignsRequest request);



        /// <summary>
        /// Lists information about created campaigns. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCampaigns service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        Task<ListCampaignsResponse> ListCampaignsAsync(ListCampaignsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDecoderManifestNetworkInterfaces


        /// <summary>
        /// Lists the network interfaces specified in a decoder manifest. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifestNetworkInterfaces service method.</param>
        /// 
        /// <returns>The response from the ListDecoderManifestNetworkInterfaces service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifestNetworkInterfaces">REST API Reference for ListDecoderManifestNetworkInterfaces Operation</seealso>
        ListDecoderManifestNetworkInterfacesResponse ListDecoderManifestNetworkInterfaces(ListDecoderManifestNetworkInterfacesRequest request);



        /// <summary>
        /// Lists the network interfaces specified in a decoder manifest. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifestNetworkInterfaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDecoderManifestNetworkInterfaces service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifestNetworkInterfaces">REST API Reference for ListDecoderManifestNetworkInterfaces Operation</seealso>
        Task<ListDecoderManifestNetworkInterfacesResponse> ListDecoderManifestNetworkInterfacesAsync(ListDecoderManifestNetworkInterfacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDecoderManifests


        /// <summary>
        /// Lists decoder manifests. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifests service method.</param>
        /// 
        /// <returns>The response from the ListDecoderManifests service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifests">REST API Reference for ListDecoderManifests Operation</seealso>
        ListDecoderManifestsResponse ListDecoderManifests(ListDecoderManifestsRequest request);



        /// <summary>
        /// Lists decoder manifests. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDecoderManifests service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifests">REST API Reference for ListDecoderManifests Operation</seealso>
        Task<ListDecoderManifestsResponse> ListDecoderManifestsAsync(ListDecoderManifestsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDecoderManifestSignals


        /// <summary>
        /// A list of information about signal decoders specified in a decoder manifest. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifestSignals service method.</param>
        /// 
        /// <returns>The response from the ListDecoderManifestSignals service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifestSignals">REST API Reference for ListDecoderManifestSignals Operation</seealso>
        ListDecoderManifestSignalsResponse ListDecoderManifestSignals(ListDecoderManifestSignalsRequest request);



        /// <summary>
        /// A list of information about signal decoders specified in a decoder manifest. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifestSignals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDecoderManifestSignals service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifestSignals">REST API Reference for ListDecoderManifestSignals Operation</seealso>
        Task<ListDecoderManifestSignalsResponse> ListDecoderManifestSignalsAsync(ListDecoderManifestSignalsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFleets


        /// <summary>
        /// Retrieves information for each created fleet in an Amazon Web Services account. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListFleets">REST API Reference for ListFleets Operation</seealso>
        ListFleetsResponse ListFleets(ListFleetsRequest request);



        /// <summary>
        /// Retrieves information for each created fleet in an Amazon Web Services account. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListFleets">REST API Reference for ListFleets Operation</seealso>
        Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFleetsForVehicle


        /// <summary>
        /// Retrieves a list of IDs for all fleets that the vehicle is associated with.
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleetsForVehicle service method.</param>
        /// 
        /// <returns>The response from the ListFleetsForVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListFleetsForVehicle">REST API Reference for ListFleetsForVehicle Operation</seealso>
        ListFleetsForVehicleResponse ListFleetsForVehicle(ListFleetsForVehicleRequest request);



        /// <summary>
        /// Retrieves a list of IDs for all fleets that the vehicle is associated with.
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleetsForVehicle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFleetsForVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListFleetsForVehicle">REST API Reference for ListFleetsForVehicle Operation</seealso>
        Task<ListFleetsForVehicleResponse> ListFleetsForVehicleAsync(ListFleetsForVehicleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListModelManifestNodes


        /// <summary>
        /// Lists information about nodes specified in a vehicle model (model manifest). 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelManifestNodes service method.</param>
        /// 
        /// <returns>The response from the ListModelManifestNodes service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListModelManifestNodes">REST API Reference for ListModelManifestNodes Operation</seealso>
        ListModelManifestNodesResponse ListModelManifestNodes(ListModelManifestNodesRequest request);



        /// <summary>
        /// Lists information about nodes specified in a vehicle model (model manifest). 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelManifestNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelManifestNodes service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListModelManifestNodes">REST API Reference for ListModelManifestNodes Operation</seealso>
        Task<ListModelManifestNodesResponse> ListModelManifestNodesAsync(ListModelManifestNodesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListModelManifests


        /// <summary>
        /// Retrieves a list of vehicle models (model manifests). 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelManifests service method.</param>
        /// 
        /// <returns>The response from the ListModelManifests service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListModelManifests">REST API Reference for ListModelManifests Operation</seealso>
        ListModelManifestsResponse ListModelManifests(ListModelManifestsRequest request);



        /// <summary>
        /// Retrieves a list of vehicle models (model manifests). 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelManifests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelManifests service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListModelManifests">REST API Reference for ListModelManifests Operation</seealso>
        Task<ListModelManifestsResponse> ListModelManifestsAsync(ListModelManifestsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSignalCatalogNodes


        /// <summary>
        /// Lists of information about the signals (nodes) specified in a signal catalog. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSignalCatalogNodes service method.</param>
        /// 
        /// <returns>The response from the ListSignalCatalogNodes service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListSignalCatalogNodes">REST API Reference for ListSignalCatalogNodes Operation</seealso>
        ListSignalCatalogNodesResponse ListSignalCatalogNodes(ListSignalCatalogNodesRequest request);



        /// <summary>
        /// Lists of information about the signals (nodes) specified in a signal catalog. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSignalCatalogNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSignalCatalogNodes service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListSignalCatalogNodes">REST API Reference for ListSignalCatalogNodes Operation</seealso>
        Task<ListSignalCatalogNodesResponse> ListSignalCatalogNodesAsync(ListSignalCatalogNodesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSignalCatalogs


        /// <summary>
        /// Lists all the created signal catalogs in an Amazon Web Services account. 
        /// 
        ///  
        /// <para>
        /// You can use to list information about each signal (node) specified in a signal catalog.
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSignalCatalogs service method.</param>
        /// 
        /// <returns>The response from the ListSignalCatalogs service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListSignalCatalogs">REST API Reference for ListSignalCatalogs Operation</seealso>
        ListSignalCatalogsResponse ListSignalCatalogs(ListSignalCatalogsRequest request);



        /// <summary>
        /// Lists all the created signal catalogs in an Amazon Web Services account. 
        /// 
        ///  
        /// <para>
        /// You can use to list information about each signal (node) specified in a signal catalog.
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSignalCatalogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSignalCatalogs service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListSignalCatalogs">REST API Reference for ListSignalCatalogs Operation</seealso>
        Task<ListSignalCatalogsResponse> ListSignalCatalogsAsync(ListSignalCatalogsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVehicles


        /// <summary>
        /// Retrieves a list of summaries of created vehicles. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVehicles service method.</param>
        /// 
        /// <returns>The response from the ListVehicles service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListVehicles">REST API Reference for ListVehicles Operation</seealso>
        ListVehiclesResponse ListVehicles(ListVehiclesRequest request);



        /// <summary>
        /// Retrieves a list of summaries of created vehicles. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVehicles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVehicles service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListVehicles">REST API Reference for ListVehicles Operation</seealso>
        Task<ListVehiclesResponse> ListVehiclesAsync(ListVehiclesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVehiclesInFleet


        /// <summary>
        /// Retrieves a list of summaries of all vehicles associated with a fleet. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVehiclesInFleet service method.</param>
        /// 
        /// <returns>The response from the ListVehiclesInFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListVehiclesInFleet">REST API Reference for ListVehiclesInFleet Operation</seealso>
        ListVehiclesInFleetResponse ListVehiclesInFleet(ListVehiclesInFleetRequest request);



        /// <summary>
        /// Retrieves a list of summaries of all vehicles associated with a fleet. 
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <code>nextToken</code> parameter in
        /// the request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVehiclesInFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVehiclesInFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListVehiclesInFleet">REST API Reference for ListVehiclesInFleet Operation</seealso>
        Task<ListVehiclesInFleetResponse> ListVehiclesInFleetAsync(ListVehiclesInFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutLoggingOptions


        /// <summary>
        /// Creates or updates the logging option.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the PutLoggingOptions service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        PutLoggingOptionsResponse PutLoggingOptions(PutLoggingOptionsRequest request);



        /// <summary>
        /// Creates or updates the logging option.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLoggingOptions service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        Task<PutLoggingOptionsResponse> PutLoggingOptionsAsync(PutLoggingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterAccount


        /// <summary>
        /// Registers your Amazon Web Services account, IAM, and Amazon Timestream resources so
        /// Amazon Web Services IoT FleetWise can transfer your vehicle data to the Amazon Web
        /// Services Cloud. For more information, including step-by-step procedures, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/setting-up.html">Setting
        /// up Amazon Web Services IoT FleetWise</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// An Amazon Web Services account is <b>not</b> the same thing as a "user account". An
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/introduction_identity-management.html#intro-identity-users">Amazon
        /// Web Services user</a> is an identity that you create using Identity and Access Management
        /// (IAM) and takes the form of either an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users.html">IAM
        /// user</a> or an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// role, both with credentials</a>. A single Amazon Web Services account can, and typically
        /// does, contain many users and roles.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccount service method.</param>
        /// 
        /// <returns>The response from the RegisterAccount service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/RegisterAccount">REST API Reference for RegisterAccount Operation</seealso>
        RegisterAccountResponse RegisterAccount(RegisterAccountRequest request);



        /// <summary>
        /// Registers your Amazon Web Services account, IAM, and Amazon Timestream resources so
        /// Amazon Web Services IoT FleetWise can transfer your vehicle data to the Amazon Web
        /// Services Cloud. For more information, including step-by-step procedures, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/setting-up.html">Setting
        /// up Amazon Web Services IoT FleetWise</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// An Amazon Web Services account is <b>not</b> the same thing as a "user account". An
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/introduction_identity-management.html#intro-identity-users">Amazon
        /// Web Services user</a> is an identity that you create using Identity and Access Management
        /// (IAM) and takes the form of either an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users.html">IAM
        /// user</a> or an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// role, both with credentials</a>. A single Amazon Web Services account can, and typically
        /// does, contain many users and roles.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterAccount service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/RegisterAccount">REST API Reference for RegisterAccount Operation</seealso>
        Task<RegisterAccountResponse> RegisterAccountAsync(RegisterAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata which can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata which can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the given tags (metadata) from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes the given tags (metadata) from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCampaign


        /// <summary>
        /// Updates a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaign service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        UpdateCampaignResponse UpdateCampaign(UpdateCampaignRequest request);



        /// <summary>
        /// Updates a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCampaign service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        Task<UpdateCampaignResponse> UpdateCampaignAsync(UpdateCampaignRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDecoderManifest


        /// <summary>
        /// Updates a decoder manifest.
        /// 
        ///  
        /// <para>
        /// A decoder manifest can only be updated when the status is <code>DRAFT</code>. Only
        /// <code>ACTIVE</code> decoder manifests can be associated with vehicles.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDecoderManifest service method.</param>
        /// 
        /// <returns>The response from the UpdateDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.DecoderManifestValidationException">
        /// The request couldn't be completed because it contains signal decoders with one or
        /// more validation errors.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateDecoderManifest">REST API Reference for UpdateDecoderManifest Operation</seealso>
        UpdateDecoderManifestResponse UpdateDecoderManifest(UpdateDecoderManifestRequest request);



        /// <summary>
        /// Updates a decoder manifest.
        /// 
        ///  
        /// <para>
        /// A decoder manifest can only be updated when the status is <code>DRAFT</code>. Only
        /// <code>ACTIVE</code> decoder manifests can be associated with vehicles.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDecoderManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDecoderManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.DecoderManifestValidationException">
        /// The request couldn't be completed because it contains signal decoders with one or
        /// more validation errors.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateDecoderManifest">REST API Reference for UpdateDecoderManifest Operation</seealso>
        Task<UpdateDecoderManifestResponse> UpdateDecoderManifestAsync(UpdateDecoderManifestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFleet


        /// <summary>
        /// Updates the description of an existing fleet. 
        /// 
        ///  <note> 
        /// <para>
        /// If the fleet is successfully updated, Amazon Web Services IoT FleetWise sends back
        /// an HTTP 200 response with an empty HTTP body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet service method.</param>
        /// 
        /// <returns>The response from the UpdateFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        UpdateFleetResponse UpdateFleet(UpdateFleetRequest request);



        /// <summary>
        /// Updates the description of an existing fleet. 
        /// 
        ///  <note> 
        /// <para>
        /// If the fleet is successfully updated, Amazon Web Services IoT FleetWise sends back
        /// an HTTP 200 response with an empty HTTP body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFleet service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        Task<UpdateFleetResponse> UpdateFleetAsync(UpdateFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateModelManifest


        /// <summary>
        /// Updates a vehicle model (model manifest). If created vehicles are associated with
        /// a vehicle model, it can't be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelManifest service method.</param>
        /// 
        /// <returns>The response from the UpdateModelManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateModelManifest">REST API Reference for UpdateModelManifest Operation</seealso>
        UpdateModelManifestResponse UpdateModelManifest(UpdateModelManifestRequest request);



        /// <summary>
        /// Updates a vehicle model (model manifest). If created vehicles are associated with
        /// a vehicle model, it can't be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelManifest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateModelManifest service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateModelManifest">REST API Reference for UpdateModelManifest Operation</seealso>
        Task<UpdateModelManifestResponse> UpdateModelManifestAsync(UpdateModelManifestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSignalCatalog


        /// <summary>
        /// Updates a signal catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSignalCatalog service method.</param>
        /// 
        /// <returns>The response from the UpdateSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidNodeException">
        /// The specified node type doesn't match the expected node type for a node. You can specify
        /// the node type as branch, sensor, actuator, or attribute.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateSignalCatalog">REST API Reference for UpdateSignalCatalog Operation</seealso>
        UpdateSignalCatalogResponse UpdateSignalCatalog(UpdateSignalCatalogRequest request);



        /// <summary>
        /// Updates a signal catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSignalCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSignalCatalog service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidNodeException">
        /// The specified node type doesn't match the expected node type for a node. You can specify
        /// the node type as branch, sensor, actuator, or attribute.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InvalidSignalsException">
        /// The request couldn't be completed because it contains signals that aren't valid.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.LimitExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateSignalCatalog">REST API Reference for UpdateSignalCatalog Operation</seealso>
        Task<UpdateSignalCatalogResponse> UpdateSignalCatalogAsync(UpdateSignalCatalogRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateVehicle


        /// <summary>
        /// Updates a vehicle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVehicle service method.</param>
        /// 
        /// <returns>The response from the UpdateVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateVehicle">REST API Reference for UpdateVehicle Operation</seealso>
        UpdateVehicleResponse UpdateVehicle(UpdateVehicleRequest request);



        /// <summary>
        /// Updates a vehicle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVehicle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVehicle service method, as returned by IoTFleetWise.</returns>
        /// <exception cref="Amazon.IoTFleetWise.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ConflictException">
        /// The request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.InternalServerException">
        /// The request couldn't be completed because the server temporarily failed.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ThrottlingException">
        /// The request couldn't be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTFleetWise.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateVehicle">REST API Reference for UpdateVehicle Operation</seealso>
        Task<UpdateVehicleResponse> UpdateVehicleAsync(UpdateVehicleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}