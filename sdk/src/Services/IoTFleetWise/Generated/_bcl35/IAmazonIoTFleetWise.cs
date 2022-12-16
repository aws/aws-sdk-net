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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTFleetWisePaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the AssociateVehicleFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVehicleFleet operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateVehicleFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/AssociateVehicleFleet">REST API Reference for AssociateVehicleFleet Operation</seealso>
        IAsyncResult BeginAssociateVehicleFleet(AssociateVehicleFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateVehicleFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateVehicleFleet.</param>
        /// 
        /// <returns>Returns a  AssociateVehicleFleetResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/AssociateVehicleFleet">REST API Reference for AssociateVehicleFleet Operation</seealso>
        AssociateVehicleFleetResponse EndAssociateVehicleFleet(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the BatchCreateVehicle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateVehicle operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateVehicle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/BatchCreateVehicle">REST API Reference for BatchCreateVehicle Operation</seealso>
        IAsyncResult BeginBatchCreateVehicle(BatchCreateVehicleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateVehicle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateVehicle.</param>
        /// 
        /// <returns>Returns a  BatchCreateVehicleResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/BatchCreateVehicle">REST API Reference for BatchCreateVehicle Operation</seealso>
        BatchCreateVehicleResponse EndBatchCreateVehicle(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the BatchUpdateVehicle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateVehicle operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateVehicle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/BatchUpdateVehicle">REST API Reference for BatchUpdateVehicle Operation</seealso>
        IAsyncResult BeginBatchUpdateVehicle(BatchUpdateVehicleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateVehicle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateVehicle.</param>
        /// 
        /// <returns>Returns a  BatchUpdateVehicleResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/BatchUpdateVehicle">REST API Reference for BatchUpdateVehicle Operation</seealso>
        BatchUpdateVehicleResponse EndBatchUpdateVehicle(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        IAsyncResult BeginCreateCampaign(CreateCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCampaign.</param>
        /// 
        /// <returns>Returns a  CreateCampaignResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        CreateCampaignResponse EndCreateCampaign(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDecoderManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDecoderManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateDecoderManifest">REST API Reference for CreateDecoderManifest Operation</seealso>
        IAsyncResult BeginCreateDecoderManifest(CreateDecoderManifestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDecoderManifest.</param>
        /// 
        /// <returns>Returns a  CreateDecoderManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateDecoderManifest">REST API Reference for CreateDecoderManifest Operation</seealso>
        CreateDecoderManifestResponse EndCreateDecoderManifest(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        IAsyncResult BeginCreateFleet(CreateFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleet.</param>
        /// 
        /// <returns>Returns a  CreateFleetResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateModelManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateModelManifest">REST API Reference for CreateModelManifest Operation</seealso>
        IAsyncResult BeginCreateModelManifest(CreateModelManifestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelManifest.</param>
        /// 
        /// <returns>Returns a  CreateModelManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateModelManifest">REST API Reference for CreateModelManifest Operation</seealso>
        CreateModelManifestResponse EndCreateModelManifest(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSignalCatalog operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSignalCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateSignalCatalog">REST API Reference for CreateSignalCatalog Operation</seealso>
        IAsyncResult BeginCreateSignalCatalog(CreateSignalCatalogRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSignalCatalog.</param>
        /// 
        /// <returns>Returns a  CreateSignalCatalogResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateSignalCatalog">REST API Reference for CreateSignalCatalog Operation</seealso>
        CreateSignalCatalogResponse EndCreateSignalCatalog(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateVehicle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVehicle operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVehicle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateVehicle">REST API Reference for CreateVehicle Operation</seealso>
        IAsyncResult BeginCreateVehicle(CreateVehicleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVehicle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVehicle.</param>
        /// 
        /// <returns>Returns a  CreateVehicleResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/CreateVehicle">REST API Reference for CreateVehicle Operation</seealso>
        CreateVehicleResponse EndCreateVehicle(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        IAsyncResult BeginDeleteCampaign(DeleteCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaign.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        DeleteCampaignResponse EndDeleteCampaign(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDecoderManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDecoderManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteDecoderManifest">REST API Reference for DeleteDecoderManifest Operation</seealso>
        IAsyncResult BeginDeleteDecoderManifest(DeleteDecoderManifestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDecoderManifest.</param>
        /// 
        /// <returns>Returns a  DeleteDecoderManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteDecoderManifest">REST API Reference for DeleteDecoderManifest Operation</seealso>
        DeleteDecoderManifestResponse EndDeleteDecoderManifest(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        IAsyncResult BeginDeleteFleet(DeleteFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleet.</param>
        /// 
        /// <returns>Returns a  DeleteFleetResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        DeleteFleetResponse EndDeleteFleet(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteModelManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModelManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteModelManifest">REST API Reference for DeleteModelManifest Operation</seealso>
        IAsyncResult BeginDeleteModelManifest(DeleteModelManifestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModelManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModelManifest.</param>
        /// 
        /// <returns>Returns a  DeleteModelManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteModelManifest">REST API Reference for DeleteModelManifest Operation</seealso>
        DeleteModelManifestResponse EndDeleteModelManifest(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSignalCatalog operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSignalCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteSignalCatalog">REST API Reference for DeleteSignalCatalog Operation</seealso>
        IAsyncResult BeginDeleteSignalCatalog(DeleteSignalCatalogRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSignalCatalog.</param>
        /// 
        /// <returns>Returns a  DeleteSignalCatalogResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteSignalCatalog">REST API Reference for DeleteSignalCatalog Operation</seealso>
        DeleteSignalCatalogResponse EndDeleteSignalCatalog(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteVehicle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVehicle operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVehicle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteVehicle">REST API Reference for DeleteVehicle Operation</seealso>
        IAsyncResult BeginDeleteVehicle(DeleteVehicleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVehicle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVehicle.</param>
        /// 
        /// <returns>Returns a  DeleteVehicleResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DeleteVehicle">REST API Reference for DeleteVehicle Operation</seealso>
        DeleteVehicleResponse EndDeleteVehicle(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DisassociateVehicleFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVehicleFleet operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateVehicleFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DisassociateVehicleFleet">REST API Reference for DisassociateVehicleFleet Operation</seealso>
        IAsyncResult BeginDisassociateVehicleFleet(DisassociateVehicleFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateVehicleFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateVehicleFleet.</param>
        /// 
        /// <returns>Returns a  DisassociateVehicleFleetResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/DisassociateVehicleFleet">REST API Reference for DisassociateVehicleFleet Operation</seealso>
        DisassociateVehicleFleetResponse EndDisassociateVehicleFleet(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
        IAsyncResult BeginGetCampaign(GetCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaign.</param>
        /// 
        /// <returns>Returns a  GetCampaignResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
        GetCampaignResponse EndGetCampaign(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDecoderManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDecoderManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetDecoderManifest">REST API Reference for GetDecoderManifest Operation</seealso>
        IAsyncResult BeginGetDecoderManifest(GetDecoderManifestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDecoderManifest.</param>
        /// 
        /// <returns>Returns a  GetDecoderManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetDecoderManifest">REST API Reference for GetDecoderManifest Operation</seealso>
        GetDecoderManifestResponse EndGetDecoderManifest(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFleet operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetFleet">REST API Reference for GetFleet Operation</seealso>
        IAsyncResult BeginGetFleet(GetFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFleet.</param>
        /// 
        /// <returns>Returns a  GetFleetResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetFleet">REST API Reference for GetFleet Operation</seealso>
        GetFleetResponse EndGetFleet(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingOptions operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetLoggingOptions">REST API Reference for GetLoggingOptions Operation</seealso>
        IAsyncResult BeginGetLoggingOptions(GetLoggingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoggingOptions.</param>
        /// 
        /// <returns>Returns a  GetLoggingOptionsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetLoggingOptions">REST API Reference for GetLoggingOptions Operation</seealso>
        GetLoggingOptionsResponse EndGetLoggingOptions(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetModelManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetModelManifest">REST API Reference for GetModelManifest Operation</seealso>
        IAsyncResult BeginGetModelManifest(GetModelManifestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelManifest.</param>
        /// 
        /// <returns>Returns a  GetModelManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetModelManifest">REST API Reference for GetModelManifest Operation</seealso>
        GetModelManifestResponse EndGetModelManifest(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetRegisterAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegisterAccountStatus operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRegisterAccountStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetRegisterAccountStatus">REST API Reference for GetRegisterAccountStatus Operation</seealso>
        IAsyncResult BeginGetRegisterAccountStatus(GetRegisterAccountStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRegisterAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRegisterAccountStatus.</param>
        /// 
        /// <returns>Returns a  GetRegisterAccountStatusResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetRegisterAccountStatus">REST API Reference for GetRegisterAccountStatus Operation</seealso>
        GetRegisterAccountStatusResponse EndGetRegisterAccountStatus(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSignalCatalog operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSignalCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetSignalCatalog">REST API Reference for GetSignalCatalog Operation</seealso>
        IAsyncResult BeginGetSignalCatalog(GetSignalCatalogRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSignalCatalog.</param>
        /// 
        /// <returns>Returns a  GetSignalCatalogResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetSignalCatalog">REST API Reference for GetSignalCatalog Operation</seealso>
        GetSignalCatalogResponse EndGetSignalCatalog(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetVehicle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVehicle operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVehicle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetVehicle">REST API Reference for GetVehicle Operation</seealso>
        IAsyncResult BeginGetVehicle(GetVehicleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVehicle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVehicle.</param>
        /// 
        /// <returns>Returns a  GetVehicleResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetVehicle">REST API Reference for GetVehicle Operation</seealso>
        GetVehicleResponse EndGetVehicle(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetVehicleStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVehicleStatus operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVehicleStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetVehicleStatus">REST API Reference for GetVehicleStatus Operation</seealso>
        IAsyncResult BeginGetVehicleStatus(GetVehicleStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVehicleStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVehicleStatus.</param>
        /// 
        /// <returns>Returns a  GetVehicleStatusResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/GetVehicleStatus">REST API Reference for GetVehicleStatus Operation</seealso>
        GetVehicleStatusResponse EndGetVehicleStatus(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ImportDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportDecoderManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportDecoderManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ImportDecoderManifest">REST API Reference for ImportDecoderManifest Operation</seealso>
        IAsyncResult BeginImportDecoderManifest(ImportDecoderManifestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportDecoderManifest.</param>
        /// 
        /// <returns>Returns a  ImportDecoderManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ImportDecoderManifest">REST API Reference for ImportDecoderManifest Operation</seealso>
        ImportDecoderManifestResponse EndImportDecoderManifest(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ImportSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportSignalCatalog operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportSignalCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ImportSignalCatalog">REST API Reference for ImportSignalCatalog Operation</seealso>
        IAsyncResult BeginImportSignalCatalog(ImportSignalCatalogRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportSignalCatalog.</param>
        /// 
        /// <returns>Returns a  ImportSignalCatalogResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ImportSignalCatalog">REST API Reference for ImportSignalCatalog Operation</seealso>
        ImportSignalCatalogResponse EndImportSignalCatalog(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListCampaigns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCampaigns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        IAsyncResult BeginListCampaigns(ListCampaignsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCampaigns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCampaigns.</param>
        /// 
        /// <returns>Returns a  ListCampaignsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        ListCampaignsResponse EndListCampaigns(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListDecoderManifestNetworkInterfaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifestNetworkInterfaces operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDecoderManifestNetworkInterfaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifestNetworkInterfaces">REST API Reference for ListDecoderManifestNetworkInterfaces Operation</seealso>
        IAsyncResult BeginListDecoderManifestNetworkInterfaces(ListDecoderManifestNetworkInterfacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDecoderManifestNetworkInterfaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDecoderManifestNetworkInterfaces.</param>
        /// 
        /// <returns>Returns a  ListDecoderManifestNetworkInterfacesResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifestNetworkInterfaces">REST API Reference for ListDecoderManifestNetworkInterfaces Operation</seealso>
        ListDecoderManifestNetworkInterfacesResponse EndListDecoderManifestNetworkInterfaces(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListDecoderManifests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifests operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDecoderManifests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifests">REST API Reference for ListDecoderManifests Operation</seealso>
        IAsyncResult BeginListDecoderManifests(ListDecoderManifestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDecoderManifests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDecoderManifests.</param>
        /// 
        /// <returns>Returns a  ListDecoderManifestsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifests">REST API Reference for ListDecoderManifests Operation</seealso>
        ListDecoderManifestsResponse EndListDecoderManifests(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListDecoderManifestSignals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDecoderManifestSignals operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDecoderManifestSignals
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifestSignals">REST API Reference for ListDecoderManifestSignals Operation</seealso>
        IAsyncResult BeginListDecoderManifestSignals(ListDecoderManifestSignalsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDecoderManifestSignals operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDecoderManifestSignals.</param>
        /// 
        /// <returns>Returns a  ListDecoderManifestSignalsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListDecoderManifestSignals">REST API Reference for ListDecoderManifestSignals Operation</seealso>
        ListDecoderManifestSignalsResponse EndListDecoderManifestSignals(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListFleets">REST API Reference for ListFleets Operation</seealso>
        IAsyncResult BeginListFleets(ListFleetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleets.</param>
        /// 
        /// <returns>Returns a  ListFleetsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListFleets">REST API Reference for ListFleets Operation</seealso>
        ListFleetsResponse EndListFleets(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListFleetsForVehicle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleetsForVehicle operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleetsForVehicle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListFleetsForVehicle">REST API Reference for ListFleetsForVehicle Operation</seealso>
        IAsyncResult BeginListFleetsForVehicle(ListFleetsForVehicleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleetsForVehicle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleetsForVehicle.</param>
        /// 
        /// <returns>Returns a  ListFleetsForVehicleResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListFleetsForVehicle">REST API Reference for ListFleetsForVehicle Operation</seealso>
        ListFleetsForVehicleResponse EndListFleetsForVehicle(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListModelManifestNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelManifestNodes operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelManifestNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListModelManifestNodes">REST API Reference for ListModelManifestNodes Operation</seealso>
        IAsyncResult BeginListModelManifestNodes(ListModelManifestNodesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelManifestNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelManifestNodes.</param>
        /// 
        /// <returns>Returns a  ListModelManifestNodesResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListModelManifestNodes">REST API Reference for ListModelManifestNodes Operation</seealso>
        ListModelManifestNodesResponse EndListModelManifestNodes(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListModelManifests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelManifests operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelManifests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListModelManifests">REST API Reference for ListModelManifests Operation</seealso>
        IAsyncResult BeginListModelManifests(ListModelManifestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelManifests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelManifests.</param>
        /// 
        /// <returns>Returns a  ListModelManifestsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListModelManifests">REST API Reference for ListModelManifests Operation</seealso>
        ListModelManifestsResponse EndListModelManifests(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListSignalCatalogNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSignalCatalogNodes operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSignalCatalogNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListSignalCatalogNodes">REST API Reference for ListSignalCatalogNodes Operation</seealso>
        IAsyncResult BeginListSignalCatalogNodes(ListSignalCatalogNodesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSignalCatalogNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSignalCatalogNodes.</param>
        /// 
        /// <returns>Returns a  ListSignalCatalogNodesResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListSignalCatalogNodes">REST API Reference for ListSignalCatalogNodes Operation</seealso>
        ListSignalCatalogNodesResponse EndListSignalCatalogNodes(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListSignalCatalogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSignalCatalogs operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSignalCatalogs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListSignalCatalogs">REST API Reference for ListSignalCatalogs Operation</seealso>
        IAsyncResult BeginListSignalCatalogs(ListSignalCatalogsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSignalCatalogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSignalCatalogs.</param>
        /// 
        /// <returns>Returns a  ListSignalCatalogsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListSignalCatalogs">REST API Reference for ListSignalCatalogs Operation</seealso>
        ListSignalCatalogsResponse EndListSignalCatalogs(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListVehicles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVehicles operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVehicles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListVehicles">REST API Reference for ListVehicles Operation</seealso>
        IAsyncResult BeginListVehicles(ListVehiclesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVehicles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVehicles.</param>
        /// 
        /// <returns>Returns a  ListVehiclesResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListVehicles">REST API Reference for ListVehicles Operation</seealso>
        ListVehiclesResponse EndListVehicles(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListVehiclesInFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVehiclesInFleet operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVehiclesInFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListVehiclesInFleet">REST API Reference for ListVehiclesInFleet Operation</seealso>
        IAsyncResult BeginListVehiclesInFleet(ListVehiclesInFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVehiclesInFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVehiclesInFleet.</param>
        /// 
        /// <returns>Returns a  ListVehiclesInFleetResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/ListVehiclesInFleet">REST API Reference for ListVehiclesInFleet Operation</seealso>
        ListVehiclesInFleetResponse EndListVehiclesInFleet(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the PutLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        IAsyncResult BeginPutLoggingOptions(PutLoggingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLoggingOptions.</param>
        /// 
        /// <returns>Returns a  PutLoggingOptionsResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        PutLoggingOptionsResponse EndPutLoggingOptions(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the RegisterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterAccount operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/RegisterAccount">REST API Reference for RegisterAccount Operation</seealso>
        IAsyncResult BeginRegisterAccount(RegisterAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterAccount.</param>
        /// 
        /// <returns>Returns a  RegisterAccountResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/RegisterAccount">REST API Reference for RegisterAccount Operation</seealso>
        RegisterAccountResponse EndRegisterAccount(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        IAsyncResult BeginUpdateCampaign(UpdateCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaign.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        UpdateCampaignResponse EndUpdateCampaign(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDecoderManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDecoderManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateDecoderManifest">REST API Reference for UpdateDecoderManifest Operation</seealso>
        IAsyncResult BeginUpdateDecoderManifest(UpdateDecoderManifestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDecoderManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDecoderManifest.</param>
        /// 
        /// <returns>Returns a  UpdateDecoderManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateDecoderManifest">REST API Reference for UpdateDecoderManifest Operation</seealso>
        UpdateDecoderManifestResponse EndUpdateDecoderManifest(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        IAsyncResult BeginUpdateFleet(UpdateFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleet.</param>
        /// 
        /// <returns>Returns a  UpdateFleetResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        UpdateFleetResponse EndUpdateFleet(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateModelManifest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelManifest operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModelManifest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateModelManifest">REST API Reference for UpdateModelManifest Operation</seealso>
        IAsyncResult BeginUpdateModelManifest(UpdateModelManifestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModelManifest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModelManifest.</param>
        /// 
        /// <returns>Returns a  UpdateModelManifestResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateModelManifest">REST API Reference for UpdateModelManifest Operation</seealso>
        UpdateModelManifestResponse EndUpdateModelManifest(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSignalCatalog operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSignalCatalog
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateSignalCatalog">REST API Reference for UpdateSignalCatalog Operation</seealso>
        IAsyncResult BeginUpdateSignalCatalog(UpdateSignalCatalogRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSignalCatalog operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSignalCatalog.</param>
        /// 
        /// <returns>Returns a  UpdateSignalCatalogResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateSignalCatalog">REST API Reference for UpdateSignalCatalog Operation</seealso>
        UpdateSignalCatalogResponse EndUpdateSignalCatalog(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateVehicle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVehicle operation on AmazonIoTFleetWiseClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVehicle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateVehicle">REST API Reference for UpdateVehicle Operation</seealso>
        IAsyncResult BeginUpdateVehicle(UpdateVehicleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVehicle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVehicle.</param>
        /// 
        /// <returns>Returns a  UpdateVehicleResult from IoTFleetWise.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotfleetwise-2021-06-17/UpdateVehicle">REST API Reference for UpdateVehicle Operation</seealso>
        UpdateVehicleResponse EndUpdateVehicle(IAsyncResult asyncResult);

        #endregion
        
    }
}