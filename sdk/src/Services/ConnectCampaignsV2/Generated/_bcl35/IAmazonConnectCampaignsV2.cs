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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ConnectCampaignsV2.Model;

#pragma warning disable CS1570
namespace Amazon.ConnectCampaignsV2
{
    /// <summary>
    /// <para>Interface for accessing ConnectCampaignsV2</para>
    ///
    /// Provide APIs to create and manage Amazon Connect Campaigns.
    /// </summary>
    public partial interface IAmazonConnectCampaignsV2 : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IConnectCampaignsV2PaginatorFactory Paginators { get; }
#endif


        
        #region  CreateCampaign


        /// <summary>
        /// Creates a campaign for the specified Amazon Connect account. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// 
        /// <returns>The response from the CreateCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        CreateCampaignResponse CreateCampaign(CreateCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        IAsyncResult BeginCreateCampaign(CreateCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCampaign.</param>
        /// 
        /// <returns>Returns a  CreateCampaignResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        CreateCampaignResponse EndCreateCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCampaign


        /// <summary>
        /// Deletes a campaign from the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        IAsyncResult BeginDeleteCampaign(DeleteCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaign.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        DeleteCampaignResponse EndDeleteCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCampaignChannelSubtypeConfig


        /// <summary>
        /// Deletes the channel subtype config of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignChannelSubtypeConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaignChannelSubtypeConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignChannelSubtypeConfig">REST API Reference for DeleteCampaignChannelSubtypeConfig Operation</seealso>
        DeleteCampaignChannelSubtypeConfigResponse DeleteCampaignChannelSubtypeConfig(DeleteCampaignChannelSubtypeConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaignChannelSubtypeConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignChannelSubtypeConfig operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaignChannelSubtypeConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignChannelSubtypeConfig">REST API Reference for DeleteCampaignChannelSubtypeConfig Operation</seealso>
        IAsyncResult BeginDeleteCampaignChannelSubtypeConfig(DeleteCampaignChannelSubtypeConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaignChannelSubtypeConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaignChannelSubtypeConfig.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignChannelSubtypeConfigResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignChannelSubtypeConfig">REST API Reference for DeleteCampaignChannelSubtypeConfig Operation</seealso>
        DeleteCampaignChannelSubtypeConfigResponse EndDeleteCampaignChannelSubtypeConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCampaignCommunicationLimits


        /// <summary>
        /// Deletes the communication limits config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignCommunicationLimits service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaignCommunicationLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationLimits">REST API Reference for DeleteCampaignCommunicationLimits Operation</seealso>
        DeleteCampaignCommunicationLimitsResponse DeleteCampaignCommunicationLimits(DeleteCampaignCommunicationLimitsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaignCommunicationLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignCommunicationLimits operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaignCommunicationLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationLimits">REST API Reference for DeleteCampaignCommunicationLimits Operation</seealso>
        IAsyncResult BeginDeleteCampaignCommunicationLimits(DeleteCampaignCommunicationLimitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaignCommunicationLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaignCommunicationLimits.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignCommunicationLimitsResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationLimits">REST API Reference for DeleteCampaignCommunicationLimits Operation</seealso>
        DeleteCampaignCommunicationLimitsResponse EndDeleteCampaignCommunicationLimits(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCampaignCommunicationTime


        /// <summary>
        /// Deletes the communication time config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignCommunicationTime service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaignCommunicationTime service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationTime">REST API Reference for DeleteCampaignCommunicationTime Operation</seealso>
        DeleteCampaignCommunicationTimeResponse DeleteCampaignCommunicationTime(DeleteCampaignCommunicationTimeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaignCommunicationTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaignCommunicationTime operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaignCommunicationTime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationTime">REST API Reference for DeleteCampaignCommunicationTime Operation</seealso>
        IAsyncResult BeginDeleteCampaignCommunicationTime(DeleteCampaignCommunicationTimeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaignCommunicationTime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaignCommunicationTime.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignCommunicationTimeResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteCampaignCommunicationTime">REST API Reference for DeleteCampaignCommunicationTime Operation</seealso>
        DeleteCampaignCommunicationTimeResponse EndDeleteCampaignCommunicationTime(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConnectInstanceConfig


        /// <summary>
        /// Deletes a connect instance config from the specified AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteConnectInstanceConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidStateException">
        /// The request could not be processed because of conflict in the current state.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceConfig">REST API Reference for DeleteConnectInstanceConfig Operation</seealso>
        DeleteConnectInstanceConfigResponse DeleteConnectInstanceConfig(DeleteConnectInstanceConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnectInstanceConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceConfig operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnectInstanceConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceConfig">REST API Reference for DeleteConnectInstanceConfig Operation</seealso>
        IAsyncResult BeginDeleteConnectInstanceConfig(DeleteConnectInstanceConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectInstanceConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectInstanceConfig.</param>
        /// 
        /// <returns>Returns a  DeleteConnectInstanceConfigResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceConfig">REST API Reference for DeleteConnectInstanceConfig Operation</seealso>
        DeleteConnectInstanceConfigResponse EndDeleteConnectInstanceConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConnectInstanceIntegration


        /// <summary>
        /// Delete the integration for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteConnectInstanceIntegration service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceIntegration">REST API Reference for DeleteConnectInstanceIntegration Operation</seealso>
        DeleteConnectInstanceIntegrationResponse DeleteConnectInstanceIntegration(DeleteConnectInstanceIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnectInstanceIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectInstanceIntegration operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnectInstanceIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceIntegration">REST API Reference for DeleteConnectInstanceIntegration Operation</seealso>
        IAsyncResult BeginDeleteConnectInstanceIntegration(DeleteConnectInstanceIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectInstanceIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectInstanceIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteConnectInstanceIntegrationResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteConnectInstanceIntegration">REST API Reference for DeleteConnectInstanceIntegration Operation</seealso>
        DeleteConnectInstanceIntegrationResponse EndDeleteConnectInstanceIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInstanceOnboardingJob


        /// <summary>
        /// Delete the Connect Campaigns onboarding job for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceOnboardingJob service method.</param>
        /// 
        /// <returns>The response from the DeleteInstanceOnboardingJob service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidStateException">
        /// The request could not be processed because of conflict in the current state.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteInstanceOnboardingJob">REST API Reference for DeleteInstanceOnboardingJob Operation</seealso>
        DeleteInstanceOnboardingJobResponse DeleteInstanceOnboardingJob(DeleteInstanceOnboardingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceOnboardingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceOnboardingJob operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstanceOnboardingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteInstanceOnboardingJob">REST API Reference for DeleteInstanceOnboardingJob Operation</seealso>
        IAsyncResult BeginDeleteInstanceOnboardingJob(DeleteInstanceOnboardingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstanceOnboardingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceOnboardingJob.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceOnboardingJobResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DeleteInstanceOnboardingJob">REST API Reference for DeleteInstanceOnboardingJob Operation</seealso>
        DeleteInstanceOnboardingJobResponse EndDeleteInstanceOnboardingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCampaign


        /// <summary>
        /// Describes the specific campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCampaign service method.</param>
        /// 
        /// <returns>The response from the DescribeCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        DescribeCampaignResponse DescribeCampaign(DescribeCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCampaign operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        IAsyncResult BeginDescribeCampaign(DescribeCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCampaign.</param>
        /// 
        /// <returns>Returns a  DescribeCampaignResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/DescribeCampaign">REST API Reference for DescribeCampaign Operation</seealso>
        DescribeCampaignResponse EndDescribeCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCampaignState


        /// <summary>
        /// Get state of a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignState service method.</param>
        /// 
        /// <returns>The response from the GetCampaignState service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignState">REST API Reference for GetCampaignState Operation</seealso>
        GetCampaignStateResponse GetCampaignState(GetCampaignStateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignState operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignState">REST API Reference for GetCampaignState Operation</seealso>
        IAsyncResult BeginGetCampaignState(GetCampaignStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignState.</param>
        /// 
        /// <returns>Returns a  GetCampaignStateResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignState">REST API Reference for GetCampaignState Operation</seealso>
        GetCampaignStateResponse EndGetCampaignState(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCampaignStateBatch


        /// <summary>
        /// Get state of campaigns for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignStateBatch service method.</param>
        /// 
        /// <returns>The response from the GetCampaignStateBatch service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignStateBatch">REST API Reference for GetCampaignStateBatch Operation</seealso>
        GetCampaignStateBatchResponse GetCampaignStateBatch(GetCampaignStateBatchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignStateBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignStateBatch operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignStateBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignStateBatch">REST API Reference for GetCampaignStateBatch Operation</seealso>
        IAsyncResult BeginGetCampaignStateBatch(GetCampaignStateBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignStateBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignStateBatch.</param>
        /// 
        /// <returns>Returns a  GetCampaignStateBatchResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetCampaignStateBatch">REST API Reference for GetCampaignStateBatch Operation</seealso>
        GetCampaignStateBatchResponse EndGetCampaignStateBatch(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConnectInstanceConfig


        /// <summary>
        /// Get the specific Connect instance config.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectInstanceConfig service method.</param>
        /// 
        /// <returns>The response from the GetConnectInstanceConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetConnectInstanceConfig">REST API Reference for GetConnectInstanceConfig Operation</seealso>
        GetConnectInstanceConfigResponse GetConnectInstanceConfig(GetConnectInstanceConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectInstanceConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectInstanceConfig operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectInstanceConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetConnectInstanceConfig">REST API Reference for GetConnectInstanceConfig Operation</seealso>
        IAsyncResult BeginGetConnectInstanceConfig(GetConnectInstanceConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectInstanceConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectInstanceConfig.</param>
        /// 
        /// <returns>Returns a  GetConnectInstanceConfigResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetConnectInstanceConfig">REST API Reference for GetConnectInstanceConfig Operation</seealso>
        GetConnectInstanceConfigResponse EndGetConnectInstanceConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInstanceOnboardingJobStatus


        /// <summary>
        /// Get the specific instance onboarding job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceOnboardingJobStatus service method.</param>
        /// 
        /// <returns>The response from the GetInstanceOnboardingJobStatus service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetInstanceOnboardingJobStatus">REST API Reference for GetInstanceOnboardingJobStatus Operation</seealso>
        GetInstanceOnboardingJobStatusResponse GetInstanceOnboardingJobStatus(GetInstanceOnboardingJobStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceOnboardingJobStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceOnboardingJobStatus operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceOnboardingJobStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetInstanceOnboardingJobStatus">REST API Reference for GetInstanceOnboardingJobStatus Operation</seealso>
        IAsyncResult BeginGetInstanceOnboardingJobStatus(GetInstanceOnboardingJobStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceOnboardingJobStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceOnboardingJobStatus.</param>
        /// 
        /// <returns>Returns a  GetInstanceOnboardingJobStatusResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/GetInstanceOnboardingJobStatus">REST API Reference for GetInstanceOnboardingJobStatus Operation</seealso>
        GetInstanceOnboardingJobStatusResponse EndGetInstanceOnboardingJobStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCampaigns


        /// <summary>
        /// Provides summary information about the campaigns under the specified Amazon Connect
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns service method.</param>
        /// 
        /// <returns>The response from the ListCampaigns service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        ListCampaignsResponse ListCampaigns(ListCampaignsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCampaigns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCampaigns operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCampaigns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        IAsyncResult BeginListCampaigns(ListCampaignsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCampaigns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCampaigns.</param>
        /// 
        /// <returns>Returns a  ListCampaignsResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListCampaigns">REST API Reference for ListCampaigns Operation</seealso>
        ListCampaignsResponse EndListCampaigns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConnectInstanceIntegrations


        /// <summary>
        /// Provides summary information about the integration under the specified Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectInstanceIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListConnectInstanceIntegrations service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListConnectInstanceIntegrations">REST API Reference for ListConnectInstanceIntegrations Operation</seealso>
        ListConnectInstanceIntegrationsResponse ListConnectInstanceIntegrations(ListConnectInstanceIntegrationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnectInstanceIntegrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnectInstanceIntegrations operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectInstanceIntegrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListConnectInstanceIntegrations">REST API Reference for ListConnectInstanceIntegrations Operation</seealso>
        IAsyncResult BeginListConnectInstanceIntegrations(ListConnectInstanceIntegrationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectInstanceIntegrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectInstanceIntegrations.</param>
        /// 
        /// <returns>Returns a  ListConnectInstanceIntegrationsResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListConnectInstanceIntegrations">REST API Reference for ListConnectInstanceIntegrations Operation</seealso>
        ListConnectInstanceIntegrationsResponse EndListConnectInstanceIntegrations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PauseCampaign


        /// <summary>
        /// Pauses a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseCampaign service method.</param>
        /// 
        /// <returns>The response from the PauseCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PauseCampaign">REST API Reference for PauseCampaign Operation</seealso>
        PauseCampaignResponse PauseCampaign(PauseCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PauseCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PauseCampaign operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPauseCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PauseCampaign">REST API Reference for PauseCampaign Operation</seealso>
        IAsyncResult BeginPauseCampaign(PauseCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PauseCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPauseCampaign.</param>
        /// 
        /// <returns>Returns a  PauseCampaignResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PauseCampaign">REST API Reference for PauseCampaign Operation</seealso>
        PauseCampaignResponse EndPauseCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  PutConnectInstanceIntegration


        /// <summary>
        /// Put or update the integration for the specified Amazon Connect instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConnectInstanceIntegration service method.</param>
        /// 
        /// <returns>The response from the PutConnectInstanceIntegration service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutConnectInstanceIntegration">REST API Reference for PutConnectInstanceIntegration Operation</seealso>
        PutConnectInstanceIntegrationResponse PutConnectInstanceIntegration(PutConnectInstanceIntegrationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutConnectInstanceIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConnectInstanceIntegration operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConnectInstanceIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutConnectInstanceIntegration">REST API Reference for PutConnectInstanceIntegration Operation</seealso>
        IAsyncResult BeginPutConnectInstanceIntegration(PutConnectInstanceIntegrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutConnectInstanceIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConnectInstanceIntegration.</param>
        /// 
        /// <returns>Returns a  PutConnectInstanceIntegrationResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutConnectInstanceIntegration">REST API Reference for PutConnectInstanceIntegration Operation</seealso>
        PutConnectInstanceIntegrationResponse EndPutConnectInstanceIntegration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutOutboundRequestBatch


        /// <summary>
        /// Creates outbound requests for the specified campaign Amazon Connect account. This
        /// API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOutboundRequestBatch service method.</param>
        /// 
        /// <returns>The response from the PutOutboundRequestBatch service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutOutboundRequestBatch">REST API Reference for PutOutboundRequestBatch Operation</seealso>
        PutOutboundRequestBatchResponse PutOutboundRequestBatch(PutOutboundRequestBatchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutOutboundRequestBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutOutboundRequestBatch operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutOutboundRequestBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutOutboundRequestBatch">REST API Reference for PutOutboundRequestBatch Operation</seealso>
        IAsyncResult BeginPutOutboundRequestBatch(PutOutboundRequestBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutOutboundRequestBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutOutboundRequestBatch.</param>
        /// 
        /// <returns>Returns a  PutOutboundRequestBatchResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutOutboundRequestBatch">REST API Reference for PutOutboundRequestBatch Operation</seealso>
        PutOutboundRequestBatchResponse EndPutOutboundRequestBatch(IAsyncResult asyncResult);

        #endregion
        
        #region  PutProfileOutboundRequestBatch


        /// <summary>
        /// Takes in a list of profile outbound requests to be placed as part of an outbound campaign.
        /// This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProfileOutboundRequestBatch service method.</param>
        /// 
        /// <returns>The response from the PutProfileOutboundRequestBatch service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutProfileOutboundRequestBatch">REST API Reference for PutProfileOutboundRequestBatch Operation</seealso>
        PutProfileOutboundRequestBatchResponse PutProfileOutboundRequestBatch(PutProfileOutboundRequestBatchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutProfileOutboundRequestBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutProfileOutboundRequestBatch operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutProfileOutboundRequestBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutProfileOutboundRequestBatch">REST API Reference for PutProfileOutboundRequestBatch Operation</seealso>
        IAsyncResult BeginPutProfileOutboundRequestBatch(PutProfileOutboundRequestBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutProfileOutboundRequestBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutProfileOutboundRequestBatch.</param>
        /// 
        /// <returns>Returns a  PutProfileOutboundRequestBatchResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/PutProfileOutboundRequestBatch">REST API Reference for PutProfileOutboundRequestBatch Operation</seealso>
        PutProfileOutboundRequestBatchResponse EndPutProfileOutboundRequestBatch(IAsyncResult asyncResult);

        #endregion
        
        #region  ResumeCampaign


        /// <summary>
        /// Stops a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeCampaign service method.</param>
        /// 
        /// <returns>The response from the ResumeCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ResumeCampaign">REST API Reference for ResumeCampaign Operation</seealso>
        ResumeCampaignResponse ResumeCampaign(ResumeCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResumeCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeCampaign operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ResumeCampaign">REST API Reference for ResumeCampaign Operation</seealso>
        IAsyncResult BeginResumeCampaign(ResumeCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeCampaign.</param>
        /// 
        /// <returns>Returns a  ResumeCampaignResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/ResumeCampaign">REST API Reference for ResumeCampaign Operation</seealso>
        ResumeCampaignResponse EndResumeCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  StartCampaign


        /// <summary>
        /// Starts a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCampaign service method.</param>
        /// 
        /// <returns>The response from the StartCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartCampaign">REST API Reference for StartCampaign Operation</seealso>
        StartCampaignResponse StartCampaign(StartCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCampaign operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartCampaign">REST API Reference for StartCampaign Operation</seealso>
        IAsyncResult BeginStartCampaign(StartCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCampaign.</param>
        /// 
        /// <returns>Returns a  StartCampaignResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartCampaign">REST API Reference for StartCampaign Operation</seealso>
        StartCampaignResponse EndStartCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  StartInstanceOnboardingJob


        /// <summary>
        /// Onboard the specific Amazon Connect instance to Connect Campaigns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstanceOnboardingJob service method.</param>
        /// 
        /// <returns>The response from the StartInstanceOnboardingJob service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartInstanceOnboardingJob">REST API Reference for StartInstanceOnboardingJob Operation</seealso>
        StartInstanceOnboardingJobResponse StartInstanceOnboardingJob(StartInstanceOnboardingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstanceOnboardingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstanceOnboardingJob operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInstanceOnboardingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartInstanceOnboardingJob">REST API Reference for StartInstanceOnboardingJob Operation</seealso>
        IAsyncResult BeginStartInstanceOnboardingJob(StartInstanceOnboardingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartInstanceOnboardingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstanceOnboardingJob.</param>
        /// 
        /// <returns>Returns a  StartInstanceOnboardingJobResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StartInstanceOnboardingJob">REST API Reference for StartInstanceOnboardingJob Operation</seealso>
        StartInstanceOnboardingJobResponse EndStartInstanceOnboardingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopCampaign


        /// <summary>
        /// Stops a campaign for the specified Amazon Connect account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCampaign service method.</param>
        /// 
        /// <returns>The response from the StopCampaign service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StopCampaign">REST API Reference for StopCampaign Operation</seealso>
        StopCampaignResponse StopCampaign(StopCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCampaign operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StopCampaign">REST API Reference for StopCampaign Operation</seealso>
        IAsyncResult BeginStopCampaign(StopCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCampaign.</param>
        /// 
        /// <returns>Returns a  StopCampaignResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/StopCampaign">REST API Reference for StopCampaign Operation</seealso>
        StopCampaignResponse EndStopCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tag a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untag a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCampaignChannelSubtypeConfig


        /// <summary>
        /// Updates the channel subtype config of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignChannelSubtypeConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignChannelSubtypeConfig service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignChannelSubtypeConfig">REST API Reference for UpdateCampaignChannelSubtypeConfig Operation</seealso>
        UpdateCampaignChannelSubtypeConfigResponse UpdateCampaignChannelSubtypeConfig(UpdateCampaignChannelSubtypeConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaignChannelSubtypeConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignChannelSubtypeConfig operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignChannelSubtypeConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignChannelSubtypeConfig">REST API Reference for UpdateCampaignChannelSubtypeConfig Operation</seealso>
        IAsyncResult BeginUpdateCampaignChannelSubtypeConfig(UpdateCampaignChannelSubtypeConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignChannelSubtypeConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignChannelSubtypeConfig.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignChannelSubtypeConfigResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignChannelSubtypeConfig">REST API Reference for UpdateCampaignChannelSubtypeConfig Operation</seealso>
        UpdateCampaignChannelSubtypeConfigResponse EndUpdateCampaignChannelSubtypeConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCampaignCommunicationLimits


        /// <summary>
        /// Updates the communication limits config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignCommunicationLimits service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignCommunicationLimits service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationLimits">REST API Reference for UpdateCampaignCommunicationLimits Operation</seealso>
        UpdateCampaignCommunicationLimitsResponse UpdateCampaignCommunicationLimits(UpdateCampaignCommunicationLimitsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaignCommunicationLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignCommunicationLimits operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignCommunicationLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationLimits">REST API Reference for UpdateCampaignCommunicationLimits Operation</seealso>
        IAsyncResult BeginUpdateCampaignCommunicationLimits(UpdateCampaignCommunicationLimitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignCommunicationLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignCommunicationLimits.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignCommunicationLimitsResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationLimits">REST API Reference for UpdateCampaignCommunicationLimits Operation</seealso>
        UpdateCampaignCommunicationLimitsResponse EndUpdateCampaignCommunicationLimits(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCampaignCommunicationTime


        /// <summary>
        /// Updates the communication time config for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignCommunicationTime service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignCommunicationTime service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationTime">REST API Reference for UpdateCampaignCommunicationTime Operation</seealso>
        UpdateCampaignCommunicationTimeResponse UpdateCampaignCommunicationTime(UpdateCampaignCommunicationTimeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaignCommunicationTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignCommunicationTime operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignCommunicationTime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationTime">REST API Reference for UpdateCampaignCommunicationTime Operation</seealso>
        IAsyncResult BeginUpdateCampaignCommunicationTime(UpdateCampaignCommunicationTimeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignCommunicationTime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignCommunicationTime.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignCommunicationTimeResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignCommunicationTime">REST API Reference for UpdateCampaignCommunicationTime Operation</seealso>
        UpdateCampaignCommunicationTimeResponse EndUpdateCampaignCommunicationTime(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCampaignFlowAssociation


        /// <summary>
        /// Updates the campaign flow associated with a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignFlowAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignFlowAssociation service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignFlowAssociation">REST API Reference for UpdateCampaignFlowAssociation Operation</seealso>
        UpdateCampaignFlowAssociationResponse UpdateCampaignFlowAssociation(UpdateCampaignFlowAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaignFlowAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignFlowAssociation operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignFlowAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignFlowAssociation">REST API Reference for UpdateCampaignFlowAssociation Operation</seealso>
        IAsyncResult BeginUpdateCampaignFlowAssociation(UpdateCampaignFlowAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignFlowAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignFlowAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignFlowAssociationResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignFlowAssociation">REST API Reference for UpdateCampaignFlowAssociation Operation</seealso>
        UpdateCampaignFlowAssociationResponse EndUpdateCampaignFlowAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCampaignName


        /// <summary>
        /// Updates the name of a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignName service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignName service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignName">REST API Reference for UpdateCampaignName Operation</seealso>
        UpdateCampaignNameResponse UpdateCampaignName(UpdateCampaignNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaignName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignName operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignName">REST API Reference for UpdateCampaignName Operation</seealso>
        IAsyncResult BeginUpdateCampaignName(UpdateCampaignNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignName.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignNameResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignName">REST API Reference for UpdateCampaignName Operation</seealso>
        UpdateCampaignNameResponse EndUpdateCampaignName(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCampaignSchedule


        /// <summary>
        /// Updates the schedule for a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignSchedule service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSchedule">REST API Reference for UpdateCampaignSchedule Operation</seealso>
        UpdateCampaignScheduleResponse UpdateCampaignSchedule(UpdateCampaignScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaignSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignSchedule operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSchedule">REST API Reference for UpdateCampaignSchedule Operation</seealso>
        IAsyncResult BeginUpdateCampaignSchedule(UpdateCampaignScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignScheduleResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSchedule">REST API Reference for UpdateCampaignSchedule Operation</seealso>
        UpdateCampaignScheduleResponse EndUpdateCampaignSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCampaignSource


        /// <summary>
        /// Updates the campaign source with a campaign. This API is idempotent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignSource service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaignSource service method, as returned by ConnectCampaignsV2.</returns>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InternalServerException">
        /// Request processing failed because of an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.InvalidCampaignStateException">
        /// The request could not be processed because of conflict in the current state of the
        /// campaign.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectCampaignsV2.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSource">REST API Reference for UpdateCampaignSource Operation</seealso>
        UpdateCampaignSourceResponse UpdateCampaignSource(UpdateCampaignSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaignSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaignSource operation on AmazonConnectCampaignsV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaignSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSource">REST API Reference for UpdateCampaignSource Operation</seealso>
        IAsyncResult BeginUpdateCampaignSource(UpdateCampaignSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaignSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaignSource.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignSourceResult from ConnectCampaignsV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connectcampaignsv2-2024-04-23/UpdateCampaignSource">REST API Reference for UpdateCampaignSource Operation</seealso>
        UpdateCampaignSourceResponse EndUpdateCampaignSource(IAsyncResult asyncResult);

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