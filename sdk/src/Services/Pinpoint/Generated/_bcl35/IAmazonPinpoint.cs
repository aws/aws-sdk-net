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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Pinpoint.Model;

namespace Amazon.Pinpoint
{
    /// <summary>
    /// Interface for accessing Pinpoint
    ///
    /// Doc Engage API - Amazon Pinpoint API
    /// </summary>
    public partial interface IAmazonPinpoint : IAmazonService, IDisposable
    {

        
        #region  CreateApp


        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        CreateAppResponse CreateApp(CreateAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApp
        ///         operation.</returns>
        IAsyncResult BeginCreateApp(CreateAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApp.</param>
        /// 
        /// <returns>Returns a  CreateAppResult from Pinpoint.</returns>
        CreateAppResponse EndCreateApp(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCampaign


        /// <summary>
        /// Creates a new campaign for an application or updates the settings of an existing campaign
        /// for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// 
        /// <returns>The response from the CreateCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        CreateCampaignResponse CreateCampaign(CreateCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCampaign
        ///         operation.</returns>
        IAsyncResult BeginCreateCampaign(CreateCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCampaign.</param>
        /// 
        /// <returns>Returns a  CreateCampaignResult from Pinpoint.</returns>
        CreateCampaignResponse EndCreateCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEmailTemplate


        /// <summary>
        /// Creates a message template that you can use in messages that are sent through the
        /// email channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateEmailTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        CreateEmailTemplateResponse CreateEmailTemplate(CreateEmailTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEmailTemplate
        ///         operation.</returns>
        IAsyncResult BeginCreateEmailTemplate(CreateEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEmailTemplate.</param>
        /// 
        /// <returns>Returns a  CreateEmailTemplateResult from Pinpoint.</returns>
        CreateEmailTemplateResponse EndCreateEmailTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateExportJob


        /// <summary>
        /// Creates an export job for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExportJob service method.</param>
        /// 
        /// <returns>The response from the CreateExportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        CreateExportJobResponse CreateExportJob(CreateExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExportJob operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExportJob
        ///         operation.</returns>
        IAsyncResult BeginCreateExportJob(CreateExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExportJob.</param>
        /// 
        /// <returns>Returns a  CreateExportJobResult from Pinpoint.</returns>
        CreateExportJobResponse EndCreateExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateImportJob


        /// <summary>
        /// Creates an import job for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateImportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        CreateImportJobResponse CreateImportJob(CreateImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImportJob
        ///         operation.</returns>
        IAsyncResult BeginCreateImportJob(CreateImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImportJob.</param>
        /// 
        /// <returns>Returns a  CreateImportJobResult from Pinpoint.</returns>
        CreateImportJobResponse EndCreateImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateJourney


        /// <summary>
        /// Creates a journey for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJourney service method.</param>
        /// 
        /// <returns>The response from the CreateJourney service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        CreateJourneyResponse CreateJourney(CreateJourneyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJourney operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJourney operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJourney
        ///         operation.</returns>
        IAsyncResult BeginCreateJourney(CreateJourneyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJourney operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJourney.</param>
        /// 
        /// <returns>Returns a  CreateJourneyResult from Pinpoint.</returns>
        CreateJourneyResponse EndCreateJourney(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePushTemplate


        /// <summary>
        /// Creates a message template that you can use in messages that are sent through a push
        /// notification channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePushTemplate service method.</param>
        /// 
        /// <returns>The response from the CreatePushTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        CreatePushTemplateResponse CreatePushTemplate(CreatePushTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePushTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePushTemplate
        ///         operation.</returns>
        IAsyncResult BeginCreatePushTemplate(CreatePushTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePushTemplate.</param>
        /// 
        /// <returns>Returns a  CreatePushTemplateResult from Pinpoint.</returns>
        CreatePushTemplateResponse EndCreatePushTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSegment


        /// <summary>
        /// Creates a new segment for an application or updates the configuration, dimension,
        /// and other settings for an existing segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegment service method.</param>
        /// 
        /// <returns>The response from the CreateSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        CreateSegmentResponse CreateSegment(CreateSegmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSegment
        ///         operation.</returns>
        IAsyncResult BeginCreateSegment(CreateSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSegment.</param>
        /// 
        /// <returns>Returns a  CreateSegmentResult from Pinpoint.</returns>
        CreateSegmentResponse EndCreateSegment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSmsTemplate


        /// <summary>
        /// Creates a message template that you can use in messages that are sent through the
        /// SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSmsTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateSmsTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        CreateSmsTemplateResponse CreateSmsTemplate(CreateSmsTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSmsTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSmsTemplate
        ///         operation.</returns>
        IAsyncResult BeginCreateSmsTemplate(CreateSmsTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSmsTemplate.</param>
        /// 
        /// <returns>Returns a  CreateSmsTemplateResult from Pinpoint.</returns>
        CreateSmsTemplateResponse EndCreateSmsTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAdmChannel


        /// <summary>
        /// Disables the ADM channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAdmChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteAdmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteAdmChannelResponse DeleteAdmChannel(DeleteAdmChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAdmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAdmChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteAdmChannel(DeleteAdmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAdmChannel.</param>
        /// 
        /// <returns>Returns a  DeleteAdmChannelResult from Pinpoint.</returns>
        DeleteAdmChannelResponse EndDeleteAdmChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApnsChannel


        /// <summary>
        /// Disables the APNs channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteApnsChannelResponse DeleteApnsChannel(DeleteApnsChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApnsChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteApnsChannel(DeleteApnsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsChannelResult from Pinpoint.</returns>
        DeleteApnsChannelResponse EndDeleteApnsChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApnsSandboxChannel


        /// <summary>
        /// Disables the APNs sandbox channel for an application and deletes any existing settings
        /// for the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteApnsSandboxChannelResponse DeleteApnsSandboxChannel(DeleteApnsSandboxChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApnsSandboxChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteApnsSandboxChannel(DeleteApnsSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsSandboxChannelResult from Pinpoint.</returns>
        DeleteApnsSandboxChannelResponse EndDeleteApnsSandboxChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApnsVoipChannel


        /// <summary>
        /// Disables the APNs VoIP channel for an application and deletes any existing settings
        /// for the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteApnsVoipChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteApnsVoipChannelResponse DeleteApnsVoipChannel(DeleteApnsVoipChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApnsVoipChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteApnsVoipChannel(DeleteApnsVoipChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsVoipChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsVoipChannelResult from Pinpoint.</returns>
        DeleteApnsVoipChannelResponse EndDeleteApnsVoipChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApnsVoipSandboxChannel


        /// <summary>
        /// Disables the APNs VoIP sandbox channel for an application and deletes any existing
        /// settings for the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteApnsVoipSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteApnsVoipSandboxChannelResponse DeleteApnsVoipSandboxChannel(DeleteApnsVoipSandboxChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApnsVoipSandboxChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteApnsVoipSandboxChannel(DeleteApnsVoipSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsVoipSandboxChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsVoipSandboxChannelResult from Pinpoint.</returns>
        DeleteApnsVoipSandboxChannelResponse EndDeleteApnsVoipSandboxChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApp


        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteAppResponse DeleteApp(DeleteAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApp
        ///         operation.</returns>
        IAsyncResult BeginDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        /// 
        /// <returns>Returns a  DeleteAppResult from Pinpoint.</returns>
        DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBaiduChannel


        /// <summary>
        /// Disables the Baidu channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBaiduChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteBaiduChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteBaiduChannelResponse DeleteBaiduChannel(DeleteBaiduChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBaiduChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBaiduChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteBaiduChannel(DeleteBaiduChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBaiduChannel.</param>
        /// 
        /// <returns>Returns a  DeleteBaiduChannelResult from Pinpoint.</returns>
        DeleteBaiduChannelResponse EndDeleteBaiduChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCampaign


        /// <summary>
        /// Deletes a campaign from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaign
        ///         operation.</returns>
        IAsyncResult BeginDeleteCampaign(DeleteCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaign.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignResult from Pinpoint.</returns>
        DeleteCampaignResponse EndDeleteCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEmailChannel


        /// <summary>
        /// Disables the email channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteEmailChannelResponse DeleteEmailChannel(DeleteEmailChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEmailChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteEmailChannel(DeleteEmailChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEmailChannel.</param>
        /// 
        /// <returns>Returns a  DeleteEmailChannelResult from Pinpoint.</returns>
        DeleteEmailChannelResponse EndDeleteEmailChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEmailTemplate


        /// <summary>
        /// Deletes a message template that was designed for use in messages that were sent through
        /// the email channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteEmailTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteEmailTemplateResponse DeleteEmailTemplate(DeleteEmailTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEmailTemplate
        ///         operation.</returns>
        IAsyncResult BeginDeleteEmailTemplate(DeleteEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEmailTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteEmailTemplateResult from Pinpoint.</returns>
        DeleteEmailTemplateResponse EndDeleteEmailTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEndpoint


        /// <summary>
        /// Deletes an endpoint from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpoint
        ///         operation.</returns>
        IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from Pinpoint.</returns>
        DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEventStream


        /// <summary>
        /// Deletes the event stream for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream service method.</param>
        /// 
        /// <returns>The response from the DeleteEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteEventStreamResponse DeleteEventStream(DeleteEventStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventStream
        ///         operation.</returns>
        IAsyncResult BeginDeleteEventStream(DeleteEventStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventStream.</param>
        /// 
        /// <returns>Returns a  DeleteEventStreamResult from Pinpoint.</returns>
        DeleteEventStreamResponse EndDeleteEventStream(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGcmChannel


        /// <summary>
        /// Disables the GCM channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGcmChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteGcmChannelResponse DeleteGcmChannel(DeleteGcmChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGcmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGcmChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteGcmChannel(DeleteGcmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGcmChannel.</param>
        /// 
        /// <returns>Returns a  DeleteGcmChannelResult from Pinpoint.</returns>
        DeleteGcmChannelResponse EndDeleteGcmChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteJourney


        /// <summary>
        /// Deletes a journey from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJourney service method.</param>
        /// 
        /// <returns>The response from the DeleteJourney service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteJourneyResponse DeleteJourney(DeleteJourneyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJourney operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJourney operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJourney
        ///         operation.</returns>
        IAsyncResult BeginDeleteJourney(DeleteJourneyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJourney operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJourney.</param>
        /// 
        /// <returns>Returns a  DeleteJourneyResult from Pinpoint.</returns>
        DeleteJourneyResponse EndDeleteJourney(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePushTemplate


        /// <summary>
        /// Deletes a message template that was designed for use in messages that were sent through
        /// a push notification channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePushTemplate service method.</param>
        /// 
        /// <returns>The response from the DeletePushTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeletePushTemplateResponse DeletePushTemplate(DeletePushTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePushTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePushTemplate
        ///         operation.</returns>
        IAsyncResult BeginDeletePushTemplate(DeletePushTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePushTemplate.</param>
        /// 
        /// <returns>Returns a  DeletePushTemplateResult from Pinpoint.</returns>
        DeletePushTemplateResponse EndDeletePushTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSegment


        /// <summary>
        /// Deletes a segment from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegment service method.</param>
        /// 
        /// <returns>The response from the DeleteSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteSegmentResponse DeleteSegment(DeleteSegmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSegment
        ///         operation.</returns>
        IAsyncResult BeginDeleteSegment(DeleteSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSegment.</param>
        /// 
        /// <returns>Returns a  DeleteSegmentResult from Pinpoint.</returns>
        DeleteSegmentResponse EndDeleteSegment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSmsChannel


        /// <summary>
        /// Disables the SMS channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteSmsChannelResponse DeleteSmsChannel(DeleteSmsChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSmsChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteSmsChannel(DeleteSmsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSmsChannel.</param>
        /// 
        /// <returns>Returns a  DeleteSmsChannelResult from Pinpoint.</returns>
        DeleteSmsChannelResponse EndDeleteSmsChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSmsTemplate


        /// <summary>
        /// Deletes a message template that was designed for use in messages that were sent through
        /// the SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteSmsTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteSmsTemplateResponse DeleteSmsTemplate(DeleteSmsTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSmsTemplate
        ///         operation.</returns>
        IAsyncResult BeginDeleteSmsTemplate(DeleteSmsTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSmsTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteSmsTemplateResult from Pinpoint.</returns>
        DeleteSmsTemplateResponse EndDeleteSmsTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUserEndpoints


        /// <summary>
        /// Deletes all the endpoints that are associated with a specific user ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserEndpoints service method.</param>
        /// 
        /// <returns>The response from the DeleteUserEndpoints service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteUserEndpointsResponse DeleteUserEndpoints(DeleteUserEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserEndpoints operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserEndpoints
        ///         operation.</returns>
        IAsyncResult BeginDeleteUserEndpoints(DeleteUserEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserEndpoints.</param>
        /// 
        /// <returns>Returns a  DeleteUserEndpointsResult from Pinpoint.</returns>
        DeleteUserEndpointsResponse EndDeleteUserEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVoiceChannel


        /// <summary>
        /// Disables the voice channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        DeleteVoiceChannelResponse DeleteVoiceChannel(DeleteVoiceChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceChannel
        ///         operation.</returns>
        IAsyncResult BeginDeleteVoiceChannel(DeleteVoiceChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceChannel.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceChannelResult from Pinpoint.</returns>
        DeleteVoiceChannelResponse EndDeleteVoiceChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAdmChannel


        /// <summary>
        /// Retrieves information about the status and settings of the ADM channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdmChannel service method.</param>
        /// 
        /// <returns>The response from the GetAdmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetAdmChannelResponse GetAdmChannel(GetAdmChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAdmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAdmChannel
        ///         operation.</returns>
        IAsyncResult BeginGetAdmChannel(GetAdmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAdmChannel.</param>
        /// 
        /// <returns>Returns a  GetAdmChannelResult from Pinpoint.</returns>
        GetAdmChannelResponse EndGetAdmChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApnsChannel


        /// <summary>
        /// Retrieves information about the status and settings of the APNs channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsChannel service method.</param>
        /// 
        /// <returns>The response from the GetApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetApnsChannelResponse GetApnsChannel(GetApnsChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApnsChannel
        ///         operation.</returns>
        IAsyncResult BeginGetApnsChannel(GetApnsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsChannelResult from Pinpoint.</returns>
        GetApnsChannelResponse EndGetApnsChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApnsSandboxChannel


        /// <summary>
        /// Retrieves information about the status and settings of the APNs sandbox channel for
        /// an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the GetApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetApnsSandboxChannelResponse GetApnsSandboxChannel(GetApnsSandboxChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApnsSandboxChannel
        ///         operation.</returns>
        IAsyncResult BeginGetApnsSandboxChannel(GetApnsSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsSandboxChannelResult from Pinpoint.</returns>
        GetApnsSandboxChannelResponse EndGetApnsSandboxChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApnsVoipChannel


        /// <summary>
        /// Retrieves information about the status and settings of the APNs VoIP channel for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipChannel service method.</param>
        /// 
        /// <returns>The response from the GetApnsVoipChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetApnsVoipChannelResponse GetApnsVoipChannel(GetApnsVoipChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApnsVoipChannel
        ///         operation.</returns>
        IAsyncResult BeginGetApnsVoipChannel(GetApnsVoipChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsVoipChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsVoipChannelResult from Pinpoint.</returns>
        GetApnsVoipChannelResponse EndGetApnsVoipChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApnsVoipSandboxChannel


        /// <summary>
        /// Retrieves information about the status and settings of the APNs VoIP sandbox channel
        /// for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the GetApnsVoipSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetApnsVoipSandboxChannelResponse GetApnsVoipSandboxChannel(GetApnsVoipSandboxChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApnsVoipSandboxChannel
        ///         operation.</returns>
        IAsyncResult BeginGetApnsVoipSandboxChannel(GetApnsVoipSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsVoipSandboxChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsVoipSandboxChannelResult from Pinpoint.</returns>
        GetApnsVoipSandboxChannelResponse EndGetApnsVoipSandboxChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApp


        /// <summary>
        /// Retrieves information about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApp service method.</param>
        /// 
        /// <returns>The response from the GetApp service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetAppResponse GetApp(GetAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApp operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApp
        ///         operation.</returns>
        IAsyncResult BeginGetApp(GetAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApp.</param>
        /// 
        /// <returns>Returns a  GetAppResult from Pinpoint.</returns>
        GetAppResponse EndGetApp(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApplicationDateRangeKpi


        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard metric that applies to an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationDateRangeKpi service method.</param>
        /// 
        /// <returns>The response from the GetApplicationDateRangeKpi service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetApplicationDateRangeKpiResponse GetApplicationDateRangeKpi(GetApplicationDateRangeKpiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationDateRangeKpi operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationDateRangeKpi
        ///         operation.</returns>
        IAsyncResult BeginGetApplicationDateRangeKpi(GetApplicationDateRangeKpiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationDateRangeKpi.</param>
        /// 
        /// <returns>Returns a  GetApplicationDateRangeKpiResult from Pinpoint.</returns>
        GetApplicationDateRangeKpiResponse EndGetApplicationDateRangeKpi(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApplicationSettings


        /// <summary>
        /// Retrieves information about the settings for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSettings service method.</param>
        /// 
        /// <returns>The response from the GetApplicationSettings service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetApplicationSettingsResponse GetApplicationSettings(GetApplicationSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSettings operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationSettings
        ///         operation.</returns>
        IAsyncResult BeginGetApplicationSettings(GetApplicationSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationSettings.</param>
        /// 
        /// <returns>Returns a  GetApplicationSettingsResult from Pinpoint.</returns>
        GetApplicationSettingsResponse EndGetApplicationSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApps


        /// <summary>
        /// Retrieves information about all of your applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApps service method.</param>
        /// 
        /// <returns>The response from the GetApps service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetAppsResponse GetApps(GetAppsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApps operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApps
        ///         operation.</returns>
        IAsyncResult BeginGetApps(GetAppsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApps.</param>
        /// 
        /// <returns>Returns a  GetAppsResult from Pinpoint.</returns>
        GetAppsResponse EndGetApps(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBaiduChannel


        /// <summary>
        /// Retrieves information about the status and settings of the Baidu channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBaiduChannel service method.</param>
        /// 
        /// <returns>The response from the GetBaiduChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetBaiduChannelResponse GetBaiduChannel(GetBaiduChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBaiduChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBaiduChannel
        ///         operation.</returns>
        IAsyncResult BeginGetBaiduChannel(GetBaiduChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBaiduChannel.</param>
        /// 
        /// <returns>Returns a  GetBaiduChannelResult from Pinpoint.</returns>
        GetBaiduChannelResponse EndGetBaiduChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCampaign


        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign service method.</param>
        /// 
        /// <returns>The response from the GetCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetCampaignResponse GetCampaign(GetCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaign
        ///         operation.</returns>
        IAsyncResult BeginGetCampaign(GetCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaign.</param>
        /// 
        /// <returns>Returns a  GetCampaignResult from Pinpoint.</returns>
        GetCampaignResponse EndGetCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCampaignActivities


        /// <summary>
        /// Retrieves information about all the activities for a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignActivities service method.</param>
        /// 
        /// <returns>The response from the GetCampaignActivities service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetCampaignActivitiesResponse GetCampaignActivities(GetCampaignActivitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignActivities operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignActivities
        ///         operation.</returns>
        IAsyncResult BeginGetCampaignActivities(GetCampaignActivitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignActivities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignActivities.</param>
        /// 
        /// <returns>Returns a  GetCampaignActivitiesResult from Pinpoint.</returns>
        GetCampaignActivitiesResponse EndGetCampaignActivities(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCampaignDateRangeKpi


        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard metric that applies to a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignDateRangeKpi service method.</param>
        /// 
        /// <returns>The response from the GetCampaignDateRangeKpi service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetCampaignDateRangeKpiResponse GetCampaignDateRangeKpi(GetCampaignDateRangeKpiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignDateRangeKpi operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignDateRangeKpi
        ///         operation.</returns>
        IAsyncResult BeginGetCampaignDateRangeKpi(GetCampaignDateRangeKpiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignDateRangeKpi.</param>
        /// 
        /// <returns>Returns a  GetCampaignDateRangeKpiResult from Pinpoint.</returns>
        GetCampaignDateRangeKpiResponse EndGetCampaignDateRangeKpi(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCampaigns


        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for all
        /// the campaigns that are associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaigns service method.</param>
        /// 
        /// <returns>The response from the GetCampaigns service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetCampaignsResponse GetCampaigns(GetCampaignsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaigns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaigns operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaigns
        ///         operation.</returns>
        IAsyncResult BeginGetCampaigns(GetCampaignsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaigns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaigns.</param>
        /// 
        /// <returns>Returns a  GetCampaignsResult from Pinpoint.</returns>
        GetCampaignsResponse EndGetCampaigns(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCampaignVersion


        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for a specific
        /// version of a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersion service method.</param>
        /// 
        /// <returns>The response from the GetCampaignVersion service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetCampaignVersionResponse GetCampaignVersion(GetCampaignVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersion operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignVersion
        ///         operation.</returns>
        IAsyncResult BeginGetCampaignVersion(GetCampaignVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignVersion.</param>
        /// 
        /// <returns>Returns a  GetCampaignVersionResult from Pinpoint.</returns>
        GetCampaignVersionResponse EndGetCampaignVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCampaignVersions


        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for all
        /// versions of a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersions service method.</param>
        /// 
        /// <returns>The response from the GetCampaignVersions service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetCampaignVersionsResponse GetCampaignVersions(GetCampaignVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersions operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignVersions
        ///         operation.</returns>
        IAsyncResult BeginGetCampaignVersions(GetCampaignVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignVersions.</param>
        /// 
        /// <returns>Returns a  GetCampaignVersionsResult from Pinpoint.</returns>
        GetCampaignVersionsResponse EndGetCampaignVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChannels


        /// <summary>
        /// Retrieves information about the history and status of each channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannels service method.</param>
        /// 
        /// <returns>The response from the GetChannels service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetChannelsResponse GetChannels(GetChannelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannels operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannels
        ///         operation.</returns>
        IAsyncResult BeginGetChannels(GetChannelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannels.</param>
        /// 
        /// <returns>Returns a  GetChannelsResult from Pinpoint.</returns>
        GetChannelsResponse EndGetChannels(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEmailChannel


        /// <summary>
        /// Retrieves information about the status and settings of the email channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailChannel service method.</param>
        /// 
        /// <returns>The response from the GetEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetEmailChannelResponse GetEmailChannel(GetEmailChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEmailChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEmailChannel
        ///         operation.</returns>
        IAsyncResult BeginGetEmailChannel(GetEmailChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEmailChannel.</param>
        /// 
        /// <returns>Returns a  GetEmailChannelResult from Pinpoint.</returns>
        GetEmailChannelResponse EndGetEmailChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEmailTemplate


        /// <summary>
        /// Retrieves the content and settings for a message template that you can use in messages
        /// that are sent through the email channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the GetEmailTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetEmailTemplateResponse GetEmailTemplate(GetEmailTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEmailTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEmailTemplate
        ///         operation.</returns>
        IAsyncResult BeginGetEmailTemplate(GetEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEmailTemplate.</param>
        /// 
        /// <returns>Returns a  GetEmailTemplateResult from Pinpoint.</returns>
        GetEmailTemplateResponse EndGetEmailTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEndpoint


        /// <summary>
        /// Retrieves information about the settings and attributes of a specific endpoint for
        /// an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetEndpoint service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetEndpointResponse GetEndpoint(GetEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEndpoint operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEndpoint
        ///         operation.</returns>
        IAsyncResult BeginGetEndpoint(GetEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEndpoint.</param>
        /// 
        /// <returns>Returns a  GetEndpointResult from Pinpoint.</returns>
        GetEndpointResponse EndGetEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEventStream


        /// <summary>
        /// Retrieves information about the event stream settings for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream service method.</param>
        /// 
        /// <returns>The response from the GetEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetEventStreamResponse GetEventStream(GetEventStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventStream
        ///         operation.</returns>
        IAsyncResult BeginGetEventStream(GetEventStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventStream.</param>
        /// 
        /// <returns>Returns a  GetEventStreamResult from Pinpoint.</returns>
        GetEventStreamResponse EndGetEventStream(IAsyncResult asyncResult);

        #endregion
        
        #region  GetExportJob


        /// <summary>
        /// Retrieves information about the status and settings of a specific export job for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportJob service method.</param>
        /// 
        /// <returns>The response from the GetExportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetExportJobResponse GetExportJob(GetExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportJob operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExportJob
        ///         operation.</returns>
        IAsyncResult BeginGetExportJob(GetExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExportJob.</param>
        /// 
        /// <returns>Returns a  GetExportJobResult from Pinpoint.</returns>
        GetExportJobResponse EndGetExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetExportJobs


        /// <summary>
        /// Retrieves information about the status and settings of all the export jobs for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportJobs service method.</param>
        /// 
        /// <returns>The response from the GetExportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetExportJobsResponse GetExportJobs(GetExportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportJobs operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExportJobs
        ///         operation.</returns>
        IAsyncResult BeginGetExportJobs(GetExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExportJobs.</param>
        /// 
        /// <returns>Returns a  GetExportJobsResult from Pinpoint.</returns>
        GetExportJobsResponse EndGetExportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGcmChannel


        /// <summary>
        /// Retrieves information about the status and settings of the GCM channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGcmChannel service method.</param>
        /// 
        /// <returns>The response from the GetGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetGcmChannelResponse GetGcmChannel(GetGcmChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGcmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGcmChannel
        ///         operation.</returns>
        IAsyncResult BeginGetGcmChannel(GetGcmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGcmChannel.</param>
        /// 
        /// <returns>Returns a  GetGcmChannelResult from Pinpoint.</returns>
        GetGcmChannelResponse EndGetGcmChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetImportJob


        /// <summary>
        /// Retrieves information about the status and settings of a specific import job for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob service method.</param>
        /// 
        /// <returns>The response from the GetImportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetImportJobResponse GetImportJob(GetImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportJob
        ///         operation.</returns>
        IAsyncResult BeginGetImportJob(GetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportJob.</param>
        /// 
        /// <returns>Returns a  GetImportJobResult from Pinpoint.</returns>
        GetImportJobResponse EndGetImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetImportJobs


        /// <summary>
        /// Retrieves information about the status and settings of all the import jobs for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJobs service method.</param>
        /// 
        /// <returns>The response from the GetImportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetImportJobsResponse GetImportJobs(GetImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJobs operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportJobs
        ///         operation.</returns>
        IAsyncResult BeginGetImportJobs(GetImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportJobs.</param>
        /// 
        /// <returns>Returns a  GetImportJobsResult from Pinpoint.</returns>
        GetImportJobsResponse EndGetImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  GetJourney


        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for a journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourney service method.</param>
        /// 
        /// <returns>The response from the GetJourney service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetJourneyResponse GetJourney(GetJourneyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetJourney operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJourney operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJourney
        ///         operation.</returns>
        IAsyncResult BeginGetJourney(GetJourneyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourney operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourney.</param>
        /// 
        /// <returns>Returns a  GetJourneyResult from Pinpoint.</returns>
        GetJourneyResponse EndGetJourney(IAsyncResult asyncResult);

        #endregion
        
        #region  GetJourneyDateRangeKpi


        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard engagement metric that applies
        /// to a journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyDateRangeKpi service method.</param>
        /// 
        /// <returns>The response from the GetJourneyDateRangeKpi service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetJourneyDateRangeKpiResponse GetJourneyDateRangeKpi(GetJourneyDateRangeKpiRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetJourneyDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyDateRangeKpi operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJourneyDateRangeKpi
        ///         operation.</returns>
        IAsyncResult BeginGetJourneyDateRangeKpi(GetJourneyDateRangeKpiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourneyDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourneyDateRangeKpi.</param>
        /// 
        /// <returns>Returns a  GetJourneyDateRangeKpiResult from Pinpoint.</returns>
        GetJourneyDateRangeKpiResponse EndGetJourneyDateRangeKpi(IAsyncResult asyncResult);

        #endregion
        
        #region  GetJourneyExecutionActivityMetrics


        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard execution metric that applies
        /// to a journey activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyExecutionActivityMetrics service method.</param>
        /// 
        /// <returns>The response from the GetJourneyExecutionActivityMetrics service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetJourneyExecutionActivityMetricsResponse GetJourneyExecutionActivityMetrics(GetJourneyExecutionActivityMetricsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetJourneyExecutionActivityMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyExecutionActivityMetrics operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJourneyExecutionActivityMetrics
        ///         operation.</returns>
        IAsyncResult BeginGetJourneyExecutionActivityMetrics(GetJourneyExecutionActivityMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourneyExecutionActivityMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourneyExecutionActivityMetrics.</param>
        /// 
        /// <returns>Returns a  GetJourneyExecutionActivityMetricsResult from Pinpoint.</returns>
        GetJourneyExecutionActivityMetricsResponse EndGetJourneyExecutionActivityMetrics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetJourneyExecutionMetrics


        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard execution metric that applies
        /// to a journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyExecutionMetrics service method.</param>
        /// 
        /// <returns>The response from the GetJourneyExecutionMetrics service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetJourneyExecutionMetricsResponse GetJourneyExecutionMetrics(GetJourneyExecutionMetricsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetJourneyExecutionMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyExecutionMetrics operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJourneyExecutionMetrics
        ///         operation.</returns>
        IAsyncResult BeginGetJourneyExecutionMetrics(GetJourneyExecutionMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourneyExecutionMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourneyExecutionMetrics.</param>
        /// 
        /// <returns>Returns a  GetJourneyExecutionMetricsResult from Pinpoint.</returns>
        GetJourneyExecutionMetricsResponse EndGetJourneyExecutionMetrics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPushTemplate


        /// <summary>
        /// Retrieves the content and settings for a message template that you can use in messages
        /// that are sent through a push notification channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPushTemplate service method.</param>
        /// 
        /// <returns>The response from the GetPushTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetPushTemplateResponse GetPushTemplate(GetPushTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPushTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPushTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPushTemplate
        ///         operation.</returns>
        IAsyncResult BeginGetPushTemplate(GetPushTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPushTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPushTemplate.</param>
        /// 
        /// <returns>Returns a  GetPushTemplateResult from Pinpoint.</returns>
        GetPushTemplateResponse EndGetPushTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegment


        /// <summary>
        /// Retrieves information about the configuration, dimension, and other settings for a
        /// specific segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegment service method.</param>
        /// 
        /// <returns>The response from the GetSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetSegmentResponse GetSegment(GetSegmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegment
        ///         operation.</returns>
        IAsyncResult BeginGetSegment(GetSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegment.</param>
        /// 
        /// <returns>Returns a  GetSegmentResult from Pinpoint.</returns>
        GetSegmentResponse EndGetSegment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegmentExportJobs


        /// <summary>
        /// Retrieves information about the status and settings of the export jobs for a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentExportJobs service method.</param>
        /// 
        /// <returns>The response from the GetSegmentExportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetSegmentExportJobsResponse GetSegmentExportJobs(GetSegmentExportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentExportJobs operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentExportJobs
        ///         operation.</returns>
        IAsyncResult BeginGetSegmentExportJobs(GetSegmentExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentExportJobs.</param>
        /// 
        /// <returns>Returns a  GetSegmentExportJobsResult from Pinpoint.</returns>
        GetSegmentExportJobsResponse EndGetSegmentExportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegmentImportJobs


        /// <summary>
        /// Retrieves information about the status and settings of the import jobs for a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentImportJobs service method.</param>
        /// 
        /// <returns>The response from the GetSegmentImportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetSegmentImportJobsResponse GetSegmentImportJobs(GetSegmentImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentImportJobs operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentImportJobs
        ///         operation.</returns>
        IAsyncResult BeginGetSegmentImportJobs(GetSegmentImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentImportJobs.</param>
        /// 
        /// <returns>Returns a  GetSegmentImportJobsResult from Pinpoint.</returns>
        GetSegmentImportJobsResponse EndGetSegmentImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegments


        /// <summary>
        /// Retrieves information about the configuration, dimension, and other settings for all
        /// the segments that are associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegments service method.</param>
        /// 
        /// <returns>The response from the GetSegments service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetSegmentsResponse GetSegments(GetSegmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegments operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegments
        ///         operation.</returns>
        IAsyncResult BeginGetSegments(GetSegmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegments.</param>
        /// 
        /// <returns>Returns a  GetSegmentsResult from Pinpoint.</returns>
        GetSegmentsResponse EndGetSegments(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegmentVersion


        /// <summary>
        /// Retrieves information about the configuration, dimension, and other settings for a
        /// specific version of a segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersion service method.</param>
        /// 
        /// <returns>The response from the GetSegmentVersion service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetSegmentVersionResponse GetSegmentVersion(GetSegmentVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersion operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentVersion
        ///         operation.</returns>
        IAsyncResult BeginGetSegmentVersion(GetSegmentVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentVersion.</param>
        /// 
        /// <returns>Returns a  GetSegmentVersionResult from Pinpoint.</returns>
        GetSegmentVersionResponse EndGetSegmentVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegmentVersions


        /// <summary>
        /// Retrieves information about the configuration, dimension, and other settings for all
        /// versions of a specific segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersions service method.</param>
        /// 
        /// <returns>The response from the GetSegmentVersions service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetSegmentVersionsResponse GetSegmentVersions(GetSegmentVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersions operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentVersions
        ///         operation.</returns>
        IAsyncResult BeginGetSegmentVersions(GetSegmentVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentVersions.</param>
        /// 
        /// <returns>Returns a  GetSegmentVersionsResult from Pinpoint.</returns>
        GetSegmentVersionsResponse EndGetSegmentVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSmsChannel


        /// <summary>
        /// Retrieves information about the status and settings of the SMS channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSmsChannel service method.</param>
        /// 
        /// <returns>The response from the GetSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetSmsChannelResponse GetSmsChannel(GetSmsChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSmsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSmsChannel
        ///         operation.</returns>
        IAsyncResult BeginGetSmsChannel(GetSmsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSmsChannel.</param>
        /// 
        /// <returns>Returns a  GetSmsChannelResult from Pinpoint.</returns>
        GetSmsChannelResponse EndGetSmsChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSmsTemplate


        /// <summary>
        /// Retrieves the content and settings for a message template that you can use in messages
        /// that are sent through the SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSmsTemplate service method.</param>
        /// 
        /// <returns>The response from the GetSmsTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetSmsTemplateResponse GetSmsTemplate(GetSmsTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSmsTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSmsTemplate
        ///         operation.</returns>
        IAsyncResult BeginGetSmsTemplate(GetSmsTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSmsTemplate.</param>
        /// 
        /// <returns>Returns a  GetSmsTemplateResult from Pinpoint.</returns>
        GetSmsTemplateResponse EndGetSmsTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUserEndpoints


        /// <summary>
        /// Retrieves information about all the endpoints that are associated with a specific
        /// user ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserEndpoints service method.</param>
        /// 
        /// <returns>The response from the GetUserEndpoints service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetUserEndpointsResponse GetUserEndpoints(GetUserEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserEndpoints operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserEndpoints
        ///         operation.</returns>
        IAsyncResult BeginGetUserEndpoints(GetUserEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserEndpoints.</param>
        /// 
        /// <returns>Returns a  GetUserEndpointsResult from Pinpoint.</returns>
        GetUserEndpointsResponse EndGetUserEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVoiceChannel


        /// <summary>
        /// Retrieves information about the status and settings of the voice channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceChannel service method.</param>
        /// 
        /// <returns>The response from the GetVoiceChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        GetVoiceChannelResponse GetVoiceChannel(GetVoiceChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceChannel
        ///         operation.</returns>
        IAsyncResult BeginGetVoiceChannel(GetVoiceChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceChannel.</param>
        /// 
        /// <returns>Returns a  GetVoiceChannelResult from Pinpoint.</returns>
        GetVoiceChannelResponse EndGetVoiceChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJourneys


        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for all
        /// the journeys that are associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJourneys service method.</param>
        /// 
        /// <returns>The response from the ListJourneys service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        ListJourneysResponse ListJourneys(ListJourneysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJourneys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJourneys operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJourneys
        ///         operation.</returns>
        IAsyncResult BeginListJourneys(ListJourneysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJourneys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJourneys.</param>
        /// 
        /// <returns>Returns a  ListJourneysResult from Pinpoint.</returns>
        ListJourneysResponse EndListJourneys(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves all the tags (keys and values) that are associated with an application,
        /// campaign, journey, message template, or segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Pinpoint.</returns>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Pinpoint.</returns>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTemplates


        /// <summary>
        /// Retrieves information about all the message templates that are associated with your
        /// Amazon Pinpoint account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        ListTemplatesResponse ListTemplates(ListTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplates
        ///         operation.</returns>
        IAsyncResult BeginListTemplates(ListTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplates.</param>
        /// 
        /// <returns>Returns a  ListTemplatesResult from Pinpoint.</returns>
        ListTemplatesResponse EndListTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  PhoneNumberValidate


        /// <summary>
        /// Retrieves information about a phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PhoneNumberValidate service method.</param>
        /// 
        /// <returns>The response from the PhoneNumberValidate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        PhoneNumberValidateResponse PhoneNumberValidate(PhoneNumberValidateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PhoneNumberValidate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PhoneNumberValidate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPhoneNumberValidate
        ///         operation.</returns>
        IAsyncResult BeginPhoneNumberValidate(PhoneNumberValidateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PhoneNumberValidate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPhoneNumberValidate.</param>
        /// 
        /// <returns>Returns a  PhoneNumberValidateResult from Pinpoint.</returns>
        PhoneNumberValidateResponse EndPhoneNumberValidate(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEvents


        /// <summary>
        /// Creates a new event to record for endpoints, or creates or updates endpoint data that
        /// existing events are associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        PutEventsResponse PutEvents(PutEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEvents operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEvents
        ///         operation.</returns>
        IAsyncResult BeginPutEvents(PutEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEvents.</param>
        /// 
        /// <returns>Returns a  PutEventsResult from Pinpoint.</returns>
        PutEventsResponse EndPutEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEventStream


        /// <summary>
        /// Creates a new event stream for an application or updates the settings of an existing
        /// event stream for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventStream service method.</param>
        /// 
        /// <returns>The response from the PutEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        PutEventStreamResponse PutEventStream(PutEventStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEventStream operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEventStream
        ///         operation.</returns>
        IAsyncResult BeginPutEventStream(PutEventStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEventStream.</param>
        /// 
        /// <returns>Returns a  PutEventStreamResult from Pinpoint.</returns>
        PutEventStreamResponse EndPutEventStream(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveAttributes


        /// <summary>
        /// Removes one or more attributes, of the same attribute type, from all the endpoints
        /// that are associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributes service method.</param>
        /// 
        /// <returns>The response from the RemoveAttributes service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        RemoveAttributesResponse RemoveAttributes(RemoveAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributes operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveAttributes
        ///         operation.</returns>
        IAsyncResult BeginRemoveAttributes(RemoveAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAttributes.</param>
        /// 
        /// <returns>Returns a  RemoveAttributesResult from Pinpoint.</returns>
        RemoveAttributesResponse EndRemoveAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  SendMessages


        /// <summary>
        /// Creates and sends a direct message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessages service method.</param>
        /// 
        /// <returns>The response from the SendMessages service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        SendMessagesResponse SendMessages(SendMessagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessages operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendMessages
        ///         operation.</returns>
        IAsyncResult BeginSendMessages(SendMessagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendMessages.</param>
        /// 
        /// <returns>Returns a  SendMessagesResult from Pinpoint.</returns>
        SendMessagesResponse EndSendMessages(IAsyncResult asyncResult);

        #endregion
        
        #region  SendUsersMessages


        /// <summary>
        /// Creates and sends a message to a list of users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendUsersMessages service method.</param>
        /// 
        /// <returns>The response from the SendUsersMessages service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        SendUsersMessagesResponse SendUsersMessages(SendUsersMessagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendUsersMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendUsersMessages operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendUsersMessages
        ///         operation.</returns>
        IAsyncResult BeginSendUsersMessages(SendUsersMessagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendUsersMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendUsersMessages.</param>
        /// 
        /// <returns>Returns a  SendUsersMessagesResult from Pinpoint.</returns>
        SendUsersMessagesResponse EndSendUsersMessages(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags (keys and values) to an application, campaign, journey, message
        /// template, or segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Pinpoint.</returns>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Pinpoint.</returns>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags (keys and values) from an application, campaign, journey,
        /// message template, or segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Pinpoint.</returns>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Pinpoint.</returns>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAdmChannel


        /// <summary>
        /// Enables the ADM channel for an application or updates the status and settings of the
        /// ADM channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAdmChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateAdmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateAdmChannelResponse UpdateAdmChannel(UpdateAdmChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAdmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAdmChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateAdmChannel(UpdateAdmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAdmChannel.</param>
        /// 
        /// <returns>Returns a  UpdateAdmChannelResult from Pinpoint.</returns>
        UpdateAdmChannelResponse EndUpdateAdmChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApnsChannel


        /// <summary>
        /// Enables the APNs channel for an application or updates the status and settings of
        /// the APNs channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateApnsChannelResponse UpdateApnsChannel(UpdateApnsChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApnsChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateApnsChannel(UpdateApnsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsChannelResult from Pinpoint.</returns>
        UpdateApnsChannelResponse EndUpdateApnsChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApnsSandboxChannel


        /// <summary>
        /// Enables the APNs sandbox channel for an application or updates the status and settings
        /// of the APNs sandbox channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateApnsSandboxChannelResponse UpdateApnsSandboxChannel(UpdateApnsSandboxChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApnsSandboxChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateApnsSandboxChannel(UpdateApnsSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsSandboxChannelResult from Pinpoint.</returns>
        UpdateApnsSandboxChannelResponse EndUpdateApnsSandboxChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApnsVoipChannel


        /// <summary>
        /// Enables the APNs VoIP channel for an application or updates the status and settings
        /// of the APNs VoIP channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateApnsVoipChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateApnsVoipChannelResponse UpdateApnsVoipChannel(UpdateApnsVoipChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApnsVoipChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateApnsVoipChannel(UpdateApnsVoipChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsVoipChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsVoipChannelResult from Pinpoint.</returns>
        UpdateApnsVoipChannelResponse EndUpdateApnsVoipChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApnsVoipSandboxChannel


        /// <summary>
        /// Enables the APNs VoIP sandbox channel for an application or updates the status and
        /// settings of the APNs VoIP sandbox channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateApnsVoipSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateApnsVoipSandboxChannelResponse UpdateApnsVoipSandboxChannel(UpdateApnsVoipSandboxChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApnsVoipSandboxChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateApnsVoipSandboxChannel(UpdateApnsVoipSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsVoipSandboxChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsVoipSandboxChannelResult from Pinpoint.</returns>
        UpdateApnsVoipSandboxChannelResponse EndUpdateApnsVoipSandboxChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApplicationSettings


        /// <summary>
        /// Updates the settings for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationSettings service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateApplicationSettingsResponse UpdateApplicationSettings(UpdateApplicationSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplicationSettings
        ///         operation.</returns>
        IAsyncResult BeginUpdateApplicationSettings(UpdateApplicationSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationSettings.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationSettingsResult from Pinpoint.</returns>
        UpdateApplicationSettingsResponse EndUpdateApplicationSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBaiduChannel


        /// <summary>
        /// Enables the Baidu channel for an application or updates the status and settings of
        /// the Baidu channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBaiduChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateBaiduChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateBaiduChannelResponse UpdateBaiduChannel(UpdateBaiduChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBaiduChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBaiduChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateBaiduChannel(UpdateBaiduChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBaiduChannel.</param>
        /// 
        /// <returns>Returns a  UpdateBaiduChannelResult from Pinpoint.</returns>
        UpdateBaiduChannelResponse EndUpdateBaiduChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCampaign


        /// <summary>
        /// Updates the configuration and other settings for a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateCampaignResponse UpdateCampaign(UpdateCampaignRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaign
        ///         operation.</returns>
        IAsyncResult BeginUpdateCampaign(UpdateCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaign.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignResult from Pinpoint.</returns>
        UpdateCampaignResponse EndUpdateCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEmailChannel


        /// <summary>
        /// Enables the email channel for an application or updates the status and settings of
        /// the email channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateEmailChannelResponse UpdateEmailChannel(UpdateEmailChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEmailChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateEmailChannel(UpdateEmailChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEmailChannel.</param>
        /// 
        /// <returns>Returns a  UpdateEmailChannelResult from Pinpoint.</returns>
        UpdateEmailChannelResponse EndUpdateEmailChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEmailTemplate


        /// <summary>
        /// Updates an existing message template that you can use in messages that are sent through
        /// the email channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateEmailTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateEmailTemplateResponse UpdateEmailTemplate(UpdateEmailTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEmailTemplate
        ///         operation.</returns>
        IAsyncResult BeginUpdateEmailTemplate(UpdateEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEmailTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateEmailTemplateResult from Pinpoint.</returns>
        UpdateEmailTemplateResponse EndUpdateEmailTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEndpoint


        /// <summary>
        /// Creates a new endpoint for an application or updates the settings and attributes of
        /// an existing endpoint for an application. You can also use this operation to define
        /// custom attributes (Attributes, Metrics, and UserAttributes properties) for an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpoint
        ///         operation.</returns>
        IAsyncResult BeginUpdateEndpoint(UpdateEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointResult from Pinpoint.</returns>
        UpdateEndpointResponse EndUpdateEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEndpointsBatch


        /// <summary>
        /// Creates a new batch of endpoints for an application or updates the settings and attributes
        /// of a batch of existing endpoints for an application. You can also use this operation
        /// to define custom attributes (Attributes, Metrics, and UserAttributes properties) for
        /// a batch of endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointsBatch service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpointsBatch service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateEndpointsBatchResponse UpdateEndpointsBatch(UpdateEndpointsBatchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointsBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointsBatch operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpointsBatch
        ///         operation.</returns>
        IAsyncResult BeginUpdateEndpointsBatch(UpdateEndpointsBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpointsBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpointsBatch.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointsBatchResult from Pinpoint.</returns>
        UpdateEndpointsBatchResponse EndUpdateEndpointsBatch(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGcmChannel


        /// <summary>
        /// Enables the GCM channel for an application or updates the status and settings of the
        /// GCM channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGcmChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateGcmChannelResponse UpdateGcmChannel(UpdateGcmChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGcmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGcmChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateGcmChannel(UpdateGcmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGcmChannel.</param>
        /// 
        /// <returns>Returns a  UpdateGcmChannelResult from Pinpoint.</returns>
        UpdateGcmChannelResponse EndUpdateGcmChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateJourney


        /// <summary>
        /// Updates the configuration and other settings for a journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJourney service method.</param>
        /// 
        /// <returns>The response from the UpdateJourney service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateJourneyResponse UpdateJourney(UpdateJourneyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJourney operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJourney operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJourney
        ///         operation.</returns>
        IAsyncResult BeginUpdateJourney(UpdateJourneyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJourney operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJourney.</param>
        /// 
        /// <returns>Returns a  UpdateJourneyResult from Pinpoint.</returns>
        UpdateJourneyResponse EndUpdateJourney(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateJourneyState


        /// <summary>
        /// Cancels an active journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJourneyState service method.</param>
        /// 
        /// <returns>The response from the UpdateJourneyState service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateJourneyStateResponse UpdateJourneyState(UpdateJourneyStateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJourneyState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJourneyState operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJourneyState
        ///         operation.</returns>
        IAsyncResult BeginUpdateJourneyState(UpdateJourneyStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJourneyState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJourneyState.</param>
        /// 
        /// <returns>Returns a  UpdateJourneyStateResult from Pinpoint.</returns>
        UpdateJourneyStateResponse EndUpdateJourneyState(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePushTemplate


        /// <summary>
        /// Updates an existing message template that you can use in messages that are sent through
        /// a push notification channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePushTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdatePushTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdatePushTemplateResponse UpdatePushTemplate(UpdatePushTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePushTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePushTemplate
        ///         operation.</returns>
        IAsyncResult BeginUpdatePushTemplate(UpdatePushTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePushTemplate.</param>
        /// 
        /// <returns>Returns a  UpdatePushTemplateResult from Pinpoint.</returns>
        UpdatePushTemplateResponse EndUpdatePushTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSegment


        /// <summary>
        /// Creates a new segment for an application or updates the configuration, dimension,
        /// and other settings for an existing segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSegment service method.</param>
        /// 
        /// <returns>The response from the UpdateSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateSegmentResponse UpdateSegment(UpdateSegmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSegment
        ///         operation.</returns>
        IAsyncResult BeginUpdateSegment(UpdateSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSegment.</param>
        /// 
        /// <returns>Returns a  UpdateSegmentResult from Pinpoint.</returns>
        UpdateSegmentResponse EndUpdateSegment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSmsChannel


        /// <summary>
        /// Enables the SMS channel for an application or updates the status and settings of the
        /// SMS channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateSmsChannelResponse UpdateSmsChannel(UpdateSmsChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSmsChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateSmsChannel(UpdateSmsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSmsChannel.</param>
        /// 
        /// <returns>Returns a  UpdateSmsChannelResult from Pinpoint.</returns>
        UpdateSmsChannelResponse EndUpdateSmsChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSmsTemplate


        /// <summary>
        /// Updates an existing message template that you can use in messages that are sent through
        /// the SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateSmsTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateSmsTemplateResponse UpdateSmsTemplate(UpdateSmsTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSmsTemplate
        ///         operation.</returns>
        IAsyncResult BeginUpdateSmsTemplate(UpdateSmsTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSmsTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateSmsTemplateResult from Pinpoint.</returns>
        UpdateSmsTemplateResponse EndUpdateSmsTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVoiceChannel


        /// <summary>
        /// Enables the voice channel for an application or updates the status and settings of
        /// the voice channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateVoiceChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        UpdateVoiceChannelResponse UpdateVoiceChannel(UpdateVoiceChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceChannel
        ///         operation.</returns>
        IAsyncResult BeginUpdateVoiceChannel(UpdateVoiceChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceChannel.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceChannelResult from Pinpoint.</returns>
        UpdateVoiceChannelResponse EndUpdateVoiceChannel(IAsyncResult asyncResult);

        #endregion
        
    }
}