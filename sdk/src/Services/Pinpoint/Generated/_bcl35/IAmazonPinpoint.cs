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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateApp">REST API Reference for CreateApp Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateApp">REST API Reference for CreateApp Operation</seealso>
        IAsyncResult BeginCreateApp(CreateAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApp.</param>
        /// 
        /// <returns>Returns a  CreateAppResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateApp">REST API Reference for CreateApp Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        IAsyncResult BeginCreateCampaign(CreateCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCampaign.</param>
        /// 
        /// <returns>Returns a  CreateCampaignResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        CreateCampaignResponse EndCreateCampaign(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEmailTemplate


        /// <summary>
        /// Creates a message template for messages that are sent through the email channel.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateEmailTemplate">REST API Reference for CreateEmailTemplate Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateEmailTemplate">REST API Reference for CreateEmailTemplate Operation</seealso>
        IAsyncResult BeginCreateEmailTemplate(CreateEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEmailTemplate.</param>
        /// 
        /// <returns>Returns a  CreateEmailTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateEmailTemplate">REST API Reference for CreateEmailTemplate Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateExportJob">REST API Reference for CreateExportJob Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateExportJob">REST API Reference for CreateExportJob Operation</seealso>
        IAsyncResult BeginCreateExportJob(CreateExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExportJob.</param>
        /// 
        /// <returns>Returns a  CreateExportJobResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateExportJob">REST API Reference for CreateExportJob Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateImportJob">REST API Reference for CreateImportJob Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateImportJob">REST API Reference for CreateImportJob Operation</seealso>
        IAsyncResult BeginCreateImportJob(CreateImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImportJob.</param>
        /// 
        /// <returns>Returns a  CreateImportJobResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateImportJob">REST API Reference for CreateImportJob Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateJourney">REST API Reference for CreateJourney Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateJourney">REST API Reference for CreateJourney Operation</seealso>
        IAsyncResult BeginCreateJourney(CreateJourneyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJourney operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJourney.</param>
        /// 
        /// <returns>Returns a  CreateJourneyResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateJourney">REST API Reference for CreateJourney Operation</seealso>
        CreateJourneyResponse EndCreateJourney(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePushTemplate


        /// <summary>
        /// Creates a message template for messages that are sent through a push notification
        /// channel.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreatePushTemplate">REST API Reference for CreatePushTemplate Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreatePushTemplate">REST API Reference for CreatePushTemplate Operation</seealso>
        IAsyncResult BeginCreatePushTemplate(CreatePushTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePushTemplate.</param>
        /// 
        /// <returns>Returns a  CreatePushTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreatePushTemplate">REST API Reference for CreatePushTemplate Operation</seealso>
        CreatePushTemplateResponse EndCreatePushTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRecommenderConfiguration


        /// <summary>
        /// Creates an Amazon Pinpoint configuration for a recommender model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommenderConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateRecommenderConfiguration service method, as returned by Pinpoint.</returns>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateRecommenderConfiguration">REST API Reference for CreateRecommenderConfiguration Operation</seealso>
        CreateRecommenderConfigurationResponse CreateRecommenderConfiguration(CreateRecommenderConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommenderConfiguration operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRecommenderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateRecommenderConfiguration">REST API Reference for CreateRecommenderConfiguration Operation</seealso>
        IAsyncResult BeginCreateRecommenderConfiguration(CreateRecommenderConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRecommenderConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateRecommenderConfigurationResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateRecommenderConfiguration">REST API Reference for CreateRecommenderConfiguration Operation</seealso>
        CreateRecommenderConfigurationResponse EndCreateRecommenderConfiguration(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateSegment">REST API Reference for CreateSegment Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateSegment">REST API Reference for CreateSegment Operation</seealso>
        IAsyncResult BeginCreateSegment(CreateSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSegment.</param>
        /// 
        /// <returns>Returns a  CreateSegmentResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateSegment">REST API Reference for CreateSegment Operation</seealso>
        CreateSegmentResponse EndCreateSegment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSmsTemplate


        /// <summary>
        /// Creates a message template for messages that are sent through the SMS channel.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateSmsTemplate">REST API Reference for CreateSmsTemplate Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateSmsTemplate">REST API Reference for CreateSmsTemplate Operation</seealso>
        IAsyncResult BeginCreateSmsTemplate(CreateSmsTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSmsTemplate.</param>
        /// 
        /// <returns>Returns a  CreateSmsTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateSmsTemplate">REST API Reference for CreateSmsTemplate Operation</seealso>
        CreateSmsTemplateResponse EndCreateSmsTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVoiceTemplate


        /// <summary>
        /// Creates a message template for messages that are sent through the voice channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateVoiceTemplate service method, as returned by Pinpoint.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateVoiceTemplate">REST API Reference for CreateVoiceTemplate Operation</seealso>
        CreateVoiceTemplateResponse CreateVoiceTemplate(CreateVoiceTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVoiceTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateVoiceTemplate">REST API Reference for CreateVoiceTemplate Operation</seealso>
        IAsyncResult BeginCreateVoiceTemplate(CreateVoiceTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVoiceTemplate.</param>
        /// 
        /// <returns>Returns a  CreateVoiceTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateVoiceTemplate">REST API Reference for CreateVoiceTemplate Operation</seealso>
        CreateVoiceTemplateResponse EndCreateVoiceTemplate(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteAdmChannel">REST API Reference for DeleteAdmChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteAdmChannel">REST API Reference for DeleteAdmChannel Operation</seealso>
        IAsyncResult BeginDeleteAdmChannel(DeleteAdmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAdmChannel.</param>
        /// 
        /// <returns>Returns a  DeleteAdmChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteAdmChannel">REST API Reference for DeleteAdmChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsChannel">REST API Reference for DeleteApnsChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsChannel">REST API Reference for DeleteApnsChannel Operation</seealso>
        IAsyncResult BeginDeleteApnsChannel(DeleteApnsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsChannel">REST API Reference for DeleteApnsChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsSandboxChannel">REST API Reference for DeleteApnsSandboxChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsSandboxChannel">REST API Reference for DeleteApnsSandboxChannel Operation</seealso>
        IAsyncResult BeginDeleteApnsSandboxChannel(DeleteApnsSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsSandboxChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsSandboxChannel">REST API Reference for DeleteApnsSandboxChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsVoipChannel">REST API Reference for DeleteApnsVoipChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsVoipChannel">REST API Reference for DeleteApnsVoipChannel Operation</seealso>
        IAsyncResult BeginDeleteApnsVoipChannel(DeleteApnsVoipChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsVoipChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsVoipChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsVoipChannel">REST API Reference for DeleteApnsVoipChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsVoipSandboxChannel">REST API Reference for DeleteApnsVoipSandboxChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsVoipSandboxChannel">REST API Reference for DeleteApnsVoipSandboxChannel Operation</seealso>
        IAsyncResult BeginDeleteApnsVoipSandboxChannel(DeleteApnsVoipSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsVoipSandboxChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsVoipSandboxChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsVoipSandboxChannel">REST API Reference for DeleteApnsVoipSandboxChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        IAsyncResult BeginDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        /// 
        /// <returns>Returns a  DeleteAppResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteBaiduChannel">REST API Reference for DeleteBaiduChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteBaiduChannel">REST API Reference for DeleteBaiduChannel Operation</seealso>
        IAsyncResult BeginDeleteBaiduChannel(DeleteBaiduChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBaiduChannel.</param>
        /// 
        /// <returns>Returns a  DeleteBaiduChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteBaiduChannel">REST API Reference for DeleteBaiduChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        IAsyncResult BeginDeleteCampaign(DeleteCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaign.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEmailChannel">REST API Reference for DeleteEmailChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEmailChannel">REST API Reference for DeleteEmailChannel Operation</seealso>
        IAsyncResult BeginDeleteEmailChannel(DeleteEmailChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEmailChannel.</param>
        /// 
        /// <returns>Returns a  DeleteEmailChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEmailChannel">REST API Reference for DeleteEmailChannel Operation</seealso>
        DeleteEmailChannelResponse EndDeleteEmailChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEmailTemplate


        /// <summary>
        /// Deletes a message template for messages that were sent through the email channel.
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEmailTemplate">REST API Reference for DeleteEmailTemplate Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEmailTemplate">REST API Reference for DeleteEmailTemplate Operation</seealso>
        IAsyncResult BeginDeleteEmailTemplate(DeleteEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEmailTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteEmailTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEmailTemplate">REST API Reference for DeleteEmailTemplate Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEventStream">REST API Reference for DeleteEventStream Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEventStream">REST API Reference for DeleteEventStream Operation</seealso>
        IAsyncResult BeginDeleteEventStream(DeleteEventStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventStream.</param>
        /// 
        /// <returns>Returns a  DeleteEventStreamResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEventStream">REST API Reference for DeleteEventStream Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteGcmChannel">REST API Reference for DeleteGcmChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteGcmChannel">REST API Reference for DeleteGcmChannel Operation</seealso>
        IAsyncResult BeginDeleteGcmChannel(DeleteGcmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGcmChannel.</param>
        /// 
        /// <returns>Returns a  DeleteGcmChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteGcmChannel">REST API Reference for DeleteGcmChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteJourney">REST API Reference for DeleteJourney Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteJourney">REST API Reference for DeleteJourney Operation</seealso>
        IAsyncResult BeginDeleteJourney(DeleteJourneyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJourney operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJourney.</param>
        /// 
        /// <returns>Returns a  DeleteJourneyResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteJourney">REST API Reference for DeleteJourney Operation</seealso>
        DeleteJourneyResponse EndDeleteJourney(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePushTemplate


        /// <summary>
        /// Deletes a message template for messages that were sent through a push notification
        /// channel.
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeletePushTemplate">REST API Reference for DeletePushTemplate Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeletePushTemplate">REST API Reference for DeletePushTemplate Operation</seealso>
        IAsyncResult BeginDeletePushTemplate(DeletePushTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePushTemplate.</param>
        /// 
        /// <returns>Returns a  DeletePushTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeletePushTemplate">REST API Reference for DeletePushTemplate Operation</seealso>
        DeletePushTemplateResponse EndDeletePushTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRecommenderConfiguration


        /// <summary>
        /// Deletes an Amazon Pinpoint configuration for a recommender model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommenderConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteRecommenderConfiguration service method, as returned by Pinpoint.</returns>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteRecommenderConfiguration">REST API Reference for DeleteRecommenderConfiguration Operation</seealso>
        DeleteRecommenderConfigurationResponse DeleteRecommenderConfiguration(DeleteRecommenderConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommenderConfiguration operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRecommenderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteRecommenderConfiguration">REST API Reference for DeleteRecommenderConfiguration Operation</seealso>
        IAsyncResult BeginDeleteRecommenderConfiguration(DeleteRecommenderConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRecommenderConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteRecommenderConfigurationResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteRecommenderConfiguration">REST API Reference for DeleteRecommenderConfiguration Operation</seealso>
        DeleteRecommenderConfigurationResponse EndDeleteRecommenderConfiguration(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSegment">REST API Reference for DeleteSegment Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSegment">REST API Reference for DeleteSegment Operation</seealso>
        IAsyncResult BeginDeleteSegment(DeleteSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSegment.</param>
        /// 
        /// <returns>Returns a  DeleteSegmentResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSegment">REST API Reference for DeleteSegment Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSmsChannel">REST API Reference for DeleteSmsChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSmsChannel">REST API Reference for DeleteSmsChannel Operation</seealso>
        IAsyncResult BeginDeleteSmsChannel(DeleteSmsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSmsChannel.</param>
        /// 
        /// <returns>Returns a  DeleteSmsChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSmsChannel">REST API Reference for DeleteSmsChannel Operation</seealso>
        DeleteSmsChannelResponse EndDeleteSmsChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSmsTemplate


        /// <summary>
        /// Deletes a message template for messages that were sent through the SMS channel.
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSmsTemplate">REST API Reference for DeleteSmsTemplate Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSmsTemplate">REST API Reference for DeleteSmsTemplate Operation</seealso>
        IAsyncResult BeginDeleteSmsTemplate(DeleteSmsTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSmsTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteSmsTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSmsTemplate">REST API Reference for DeleteSmsTemplate Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteUserEndpoints">REST API Reference for DeleteUserEndpoints Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteUserEndpoints">REST API Reference for DeleteUserEndpoints Operation</seealso>
        IAsyncResult BeginDeleteUserEndpoints(DeleteUserEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserEndpoints.</param>
        /// 
        /// <returns>Returns a  DeleteUserEndpointsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteUserEndpoints">REST API Reference for DeleteUserEndpoints Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteVoiceChannel">REST API Reference for DeleteVoiceChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteVoiceChannel">REST API Reference for DeleteVoiceChannel Operation</seealso>
        IAsyncResult BeginDeleteVoiceChannel(DeleteVoiceChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceChannel.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteVoiceChannel">REST API Reference for DeleteVoiceChannel Operation</seealso>
        DeleteVoiceChannelResponse EndDeleteVoiceChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVoiceTemplate


        /// <summary>
        /// Deletes a message template for messages that were sent through the voice channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceTemplate service method, as returned by Pinpoint.</returns>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteVoiceTemplate">REST API Reference for DeleteVoiceTemplate Operation</seealso>
        DeleteVoiceTemplateResponse DeleteVoiceTemplate(DeleteVoiceTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteVoiceTemplate">REST API Reference for DeleteVoiceTemplate Operation</seealso>
        IAsyncResult BeginDeleteVoiceTemplate(DeleteVoiceTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteVoiceTemplate">REST API Reference for DeleteVoiceTemplate Operation</seealso>
        DeleteVoiceTemplateResponse EndDeleteVoiceTemplate(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetAdmChannel">REST API Reference for GetAdmChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetAdmChannel">REST API Reference for GetAdmChannel Operation</seealso>
        IAsyncResult BeginGetAdmChannel(GetAdmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAdmChannel.</param>
        /// 
        /// <returns>Returns a  GetAdmChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetAdmChannel">REST API Reference for GetAdmChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsChannel">REST API Reference for GetApnsChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsChannel">REST API Reference for GetApnsChannel Operation</seealso>
        IAsyncResult BeginGetApnsChannel(GetApnsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsChannel">REST API Reference for GetApnsChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsSandboxChannel">REST API Reference for GetApnsSandboxChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsSandboxChannel">REST API Reference for GetApnsSandboxChannel Operation</seealso>
        IAsyncResult BeginGetApnsSandboxChannel(GetApnsSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsSandboxChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsSandboxChannel">REST API Reference for GetApnsSandboxChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsVoipChannel">REST API Reference for GetApnsVoipChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsVoipChannel">REST API Reference for GetApnsVoipChannel Operation</seealso>
        IAsyncResult BeginGetApnsVoipChannel(GetApnsVoipChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsVoipChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsVoipChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsVoipChannel">REST API Reference for GetApnsVoipChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsVoipSandboxChannel">REST API Reference for GetApnsVoipSandboxChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsVoipSandboxChannel">REST API Reference for GetApnsVoipSandboxChannel Operation</seealso>
        IAsyncResult BeginGetApnsVoipSandboxChannel(GetApnsVoipSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsVoipSandboxChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsVoipSandboxChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsVoipSandboxChannel">REST API Reference for GetApnsVoipSandboxChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApp">REST API Reference for GetApp Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApp">REST API Reference for GetApp Operation</seealso>
        IAsyncResult BeginGetApp(GetAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApp.</param>
        /// 
        /// <returns>Returns a  GetAppResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApp">REST API Reference for GetApp Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApplicationDateRangeKpi">REST API Reference for GetApplicationDateRangeKpi Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApplicationDateRangeKpi">REST API Reference for GetApplicationDateRangeKpi Operation</seealso>
        IAsyncResult BeginGetApplicationDateRangeKpi(GetApplicationDateRangeKpiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationDateRangeKpi.</param>
        /// 
        /// <returns>Returns a  GetApplicationDateRangeKpiResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApplicationDateRangeKpi">REST API Reference for GetApplicationDateRangeKpi Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApplicationSettings">REST API Reference for GetApplicationSettings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApplicationSettings">REST API Reference for GetApplicationSettings Operation</seealso>
        IAsyncResult BeginGetApplicationSettings(GetApplicationSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationSettings.</param>
        /// 
        /// <returns>Returns a  GetApplicationSettingsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApplicationSettings">REST API Reference for GetApplicationSettings Operation</seealso>
        GetApplicationSettingsResponse EndGetApplicationSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApps


        /// <summary>
        /// Retrieves information about all the applications that are associated with your Amazon
        /// Pinpoint account.
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApps">REST API Reference for GetApps Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApps">REST API Reference for GetApps Operation</seealso>
        IAsyncResult BeginGetApps(GetAppsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApps.</param>
        /// 
        /// <returns>Returns a  GetAppsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApps">REST API Reference for GetApps Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetBaiduChannel">REST API Reference for GetBaiduChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetBaiduChannel">REST API Reference for GetBaiduChannel Operation</seealso>
        IAsyncResult BeginGetBaiduChannel(GetBaiduChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBaiduChannel.</param>
        /// 
        /// <returns>Returns a  GetBaiduChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetBaiduChannel">REST API Reference for GetBaiduChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
        IAsyncResult BeginGetCampaign(GetCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaign.</param>
        /// 
        /// <returns>Returns a  GetCampaignResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignActivities">REST API Reference for GetCampaignActivities Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignActivities">REST API Reference for GetCampaignActivities Operation</seealso>
        IAsyncResult BeginGetCampaignActivities(GetCampaignActivitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignActivities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignActivities.</param>
        /// 
        /// <returns>Returns a  GetCampaignActivitiesResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignActivities">REST API Reference for GetCampaignActivities Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignDateRangeKpi">REST API Reference for GetCampaignDateRangeKpi Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignDateRangeKpi">REST API Reference for GetCampaignDateRangeKpi Operation</seealso>
        IAsyncResult BeginGetCampaignDateRangeKpi(GetCampaignDateRangeKpiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignDateRangeKpi.</param>
        /// 
        /// <returns>Returns a  GetCampaignDateRangeKpiResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignDateRangeKpi">REST API Reference for GetCampaignDateRangeKpi Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaigns">REST API Reference for GetCampaigns Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaigns">REST API Reference for GetCampaigns Operation</seealso>
        IAsyncResult BeginGetCampaigns(GetCampaignsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaigns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaigns.</param>
        /// 
        /// <returns>Returns a  GetCampaignsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaigns">REST API Reference for GetCampaigns Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignVersion">REST API Reference for GetCampaignVersion Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignVersion">REST API Reference for GetCampaignVersion Operation</seealso>
        IAsyncResult BeginGetCampaignVersion(GetCampaignVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignVersion.</param>
        /// 
        /// <returns>Returns a  GetCampaignVersionResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignVersion">REST API Reference for GetCampaignVersion Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignVersions">REST API Reference for GetCampaignVersions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignVersions">REST API Reference for GetCampaignVersions Operation</seealso>
        IAsyncResult BeginGetCampaignVersions(GetCampaignVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignVersions.</param>
        /// 
        /// <returns>Returns a  GetCampaignVersionsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignVersions">REST API Reference for GetCampaignVersions Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetChannels">REST API Reference for GetChannels Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetChannels">REST API Reference for GetChannels Operation</seealso>
        IAsyncResult BeginGetChannels(GetChannelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannels.</param>
        /// 
        /// <returns>Returns a  GetChannelsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetChannels">REST API Reference for GetChannels Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEmailChannel">REST API Reference for GetEmailChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEmailChannel">REST API Reference for GetEmailChannel Operation</seealso>
        IAsyncResult BeginGetEmailChannel(GetEmailChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEmailChannel.</param>
        /// 
        /// <returns>Returns a  GetEmailChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEmailChannel">REST API Reference for GetEmailChannel Operation</seealso>
        GetEmailChannelResponse EndGetEmailChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEmailTemplate


        /// <summary>
        /// Retrieves the content and settings of a message template for messages that are sent
        /// through the email channel.
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEmailTemplate">REST API Reference for GetEmailTemplate Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEmailTemplate">REST API Reference for GetEmailTemplate Operation</seealso>
        IAsyncResult BeginGetEmailTemplate(GetEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEmailTemplate.</param>
        /// 
        /// <returns>Returns a  GetEmailTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEmailTemplate">REST API Reference for GetEmailTemplate Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEndpoint">REST API Reference for GetEndpoint Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEndpoint">REST API Reference for GetEndpoint Operation</seealso>
        IAsyncResult BeginGetEndpoint(GetEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEndpoint.</param>
        /// 
        /// <returns>Returns a  GetEndpointResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEndpoint">REST API Reference for GetEndpoint Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEventStream">REST API Reference for GetEventStream Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEventStream">REST API Reference for GetEventStream Operation</seealso>
        IAsyncResult BeginGetEventStream(GetEventStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventStream.</param>
        /// 
        /// <returns>Returns a  GetEventStreamResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEventStream">REST API Reference for GetEventStream Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetExportJob">REST API Reference for GetExportJob Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetExportJob">REST API Reference for GetExportJob Operation</seealso>
        IAsyncResult BeginGetExportJob(GetExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExportJob.</param>
        /// 
        /// <returns>Returns a  GetExportJobResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetExportJob">REST API Reference for GetExportJob Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetExportJobs">REST API Reference for GetExportJobs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetExportJobs">REST API Reference for GetExportJobs Operation</seealso>
        IAsyncResult BeginGetExportJobs(GetExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExportJobs.</param>
        /// 
        /// <returns>Returns a  GetExportJobsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetExportJobs">REST API Reference for GetExportJobs Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetGcmChannel">REST API Reference for GetGcmChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetGcmChannel">REST API Reference for GetGcmChannel Operation</seealso>
        IAsyncResult BeginGetGcmChannel(GetGcmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGcmChannel.</param>
        /// 
        /// <returns>Returns a  GetGcmChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetGcmChannel">REST API Reference for GetGcmChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        IAsyncResult BeginGetImportJob(GetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportJob.</param>
        /// 
        /// <returns>Returns a  GetImportJobResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetImportJobs">REST API Reference for GetImportJobs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetImportJobs">REST API Reference for GetImportJobs Operation</seealso>
        IAsyncResult BeginGetImportJobs(GetImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportJobs.</param>
        /// 
        /// <returns>Returns a  GetImportJobsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetImportJobs">REST API Reference for GetImportJobs Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourney">REST API Reference for GetJourney Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourney">REST API Reference for GetJourney Operation</seealso>
        IAsyncResult BeginGetJourney(GetJourneyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourney operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourney.</param>
        /// 
        /// <returns>Returns a  GetJourneyResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourney">REST API Reference for GetJourney Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyDateRangeKpi">REST API Reference for GetJourneyDateRangeKpi Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyDateRangeKpi">REST API Reference for GetJourneyDateRangeKpi Operation</seealso>
        IAsyncResult BeginGetJourneyDateRangeKpi(GetJourneyDateRangeKpiRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourneyDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourneyDateRangeKpi.</param>
        /// 
        /// <returns>Returns a  GetJourneyDateRangeKpiResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyDateRangeKpi">REST API Reference for GetJourneyDateRangeKpi Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyExecutionActivityMetrics">REST API Reference for GetJourneyExecutionActivityMetrics Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyExecutionActivityMetrics">REST API Reference for GetJourneyExecutionActivityMetrics Operation</seealso>
        IAsyncResult BeginGetJourneyExecutionActivityMetrics(GetJourneyExecutionActivityMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourneyExecutionActivityMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourneyExecutionActivityMetrics.</param>
        /// 
        /// <returns>Returns a  GetJourneyExecutionActivityMetricsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyExecutionActivityMetrics">REST API Reference for GetJourneyExecutionActivityMetrics Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyExecutionMetrics">REST API Reference for GetJourneyExecutionMetrics Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyExecutionMetrics">REST API Reference for GetJourneyExecutionMetrics Operation</seealso>
        IAsyncResult BeginGetJourneyExecutionMetrics(GetJourneyExecutionMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourneyExecutionMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourneyExecutionMetrics.</param>
        /// 
        /// <returns>Returns a  GetJourneyExecutionMetricsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyExecutionMetrics">REST API Reference for GetJourneyExecutionMetrics Operation</seealso>
        GetJourneyExecutionMetricsResponse EndGetJourneyExecutionMetrics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPushTemplate


        /// <summary>
        /// Retrieves the content and settings of a message template for messages that are sent
        /// through a push notification channel.
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetPushTemplate">REST API Reference for GetPushTemplate Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetPushTemplate">REST API Reference for GetPushTemplate Operation</seealso>
        IAsyncResult BeginGetPushTemplate(GetPushTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPushTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPushTemplate.</param>
        /// 
        /// <returns>Returns a  GetPushTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetPushTemplate">REST API Reference for GetPushTemplate Operation</seealso>
        GetPushTemplateResponse EndGetPushTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRecommenderConfiguration


        /// <summary>
        /// Retrieves information about an Amazon Pinpoint configuration for a recommender model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommenderConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetRecommenderConfiguration service method, as returned by Pinpoint.</returns>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetRecommenderConfiguration">REST API Reference for GetRecommenderConfiguration Operation</seealso>
        GetRecommenderConfigurationResponse GetRecommenderConfiguration(GetRecommenderConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommenderConfiguration operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommenderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetRecommenderConfiguration">REST API Reference for GetRecommenderConfiguration Operation</seealso>
        IAsyncResult BeginGetRecommenderConfiguration(GetRecommenderConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommenderConfiguration.</param>
        /// 
        /// <returns>Returns a  GetRecommenderConfigurationResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetRecommenderConfiguration">REST API Reference for GetRecommenderConfiguration Operation</seealso>
        GetRecommenderConfigurationResponse EndGetRecommenderConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRecommenderConfigurations


        /// <summary>
        /// Retrieves information about all the recommender model configurations that are associated
        /// with your Amazon Pinpoint account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommenderConfigurations service method.</param>
        /// 
        /// <returns>The response from the GetRecommenderConfigurations service method, as returned by Pinpoint.</returns>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetRecommenderConfigurations">REST API Reference for GetRecommenderConfigurations Operation</seealso>
        GetRecommenderConfigurationsResponse GetRecommenderConfigurations(GetRecommenderConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommenderConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommenderConfigurations operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommenderConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetRecommenderConfigurations">REST API Reference for GetRecommenderConfigurations Operation</seealso>
        IAsyncResult BeginGetRecommenderConfigurations(GetRecommenderConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommenderConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommenderConfigurations.</param>
        /// 
        /// <returns>Returns a  GetRecommenderConfigurationsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetRecommenderConfigurations">REST API Reference for GetRecommenderConfigurations Operation</seealso>
        GetRecommenderConfigurationsResponse EndGetRecommenderConfigurations(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegment">REST API Reference for GetSegment Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegment">REST API Reference for GetSegment Operation</seealso>
        IAsyncResult BeginGetSegment(GetSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegment.</param>
        /// 
        /// <returns>Returns a  GetSegmentResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegment">REST API Reference for GetSegment Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentExportJobs">REST API Reference for GetSegmentExportJobs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentExportJobs">REST API Reference for GetSegmentExportJobs Operation</seealso>
        IAsyncResult BeginGetSegmentExportJobs(GetSegmentExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentExportJobs.</param>
        /// 
        /// <returns>Returns a  GetSegmentExportJobsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentExportJobs">REST API Reference for GetSegmentExportJobs Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentImportJobs">REST API Reference for GetSegmentImportJobs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentImportJobs">REST API Reference for GetSegmentImportJobs Operation</seealso>
        IAsyncResult BeginGetSegmentImportJobs(GetSegmentImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentImportJobs.</param>
        /// 
        /// <returns>Returns a  GetSegmentImportJobsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentImportJobs">REST API Reference for GetSegmentImportJobs Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegments">REST API Reference for GetSegments Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegments">REST API Reference for GetSegments Operation</seealso>
        IAsyncResult BeginGetSegments(GetSegmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegments.</param>
        /// 
        /// <returns>Returns a  GetSegmentsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegments">REST API Reference for GetSegments Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentVersion">REST API Reference for GetSegmentVersion Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentVersion">REST API Reference for GetSegmentVersion Operation</seealso>
        IAsyncResult BeginGetSegmentVersion(GetSegmentVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentVersion.</param>
        /// 
        /// <returns>Returns a  GetSegmentVersionResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentVersion">REST API Reference for GetSegmentVersion Operation</seealso>
        GetSegmentVersionResponse EndGetSegmentVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSegmentVersions


        /// <summary>
        /// Retrieves information about the configuration, dimension, and other settings for all
        /// the versions of a specific segment that's associated with an application.
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentVersions">REST API Reference for GetSegmentVersions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentVersions">REST API Reference for GetSegmentVersions Operation</seealso>
        IAsyncResult BeginGetSegmentVersions(GetSegmentVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentVersions.</param>
        /// 
        /// <returns>Returns a  GetSegmentVersionsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentVersions">REST API Reference for GetSegmentVersions Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSmsChannel">REST API Reference for GetSmsChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSmsChannel">REST API Reference for GetSmsChannel Operation</seealso>
        IAsyncResult BeginGetSmsChannel(GetSmsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSmsChannel.</param>
        /// 
        /// <returns>Returns a  GetSmsChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSmsChannel">REST API Reference for GetSmsChannel Operation</seealso>
        GetSmsChannelResponse EndGetSmsChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSmsTemplate


        /// <summary>
        /// Retrieves the content and settings of a message template for messages that are sent
        /// through the SMS channel.
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSmsTemplate">REST API Reference for GetSmsTemplate Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSmsTemplate">REST API Reference for GetSmsTemplate Operation</seealso>
        IAsyncResult BeginGetSmsTemplate(GetSmsTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSmsTemplate.</param>
        /// 
        /// <returns>Returns a  GetSmsTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSmsTemplate">REST API Reference for GetSmsTemplate Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetUserEndpoints">REST API Reference for GetUserEndpoints Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetUserEndpoints">REST API Reference for GetUserEndpoints Operation</seealso>
        IAsyncResult BeginGetUserEndpoints(GetUserEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserEndpoints.</param>
        /// 
        /// <returns>Returns a  GetUserEndpointsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetUserEndpoints">REST API Reference for GetUserEndpoints Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetVoiceChannel">REST API Reference for GetVoiceChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetVoiceChannel">REST API Reference for GetVoiceChannel Operation</seealso>
        IAsyncResult BeginGetVoiceChannel(GetVoiceChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceChannel.</param>
        /// 
        /// <returns>Returns a  GetVoiceChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetVoiceChannel">REST API Reference for GetVoiceChannel Operation</seealso>
        GetVoiceChannelResponse EndGetVoiceChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVoiceTemplate


        /// <summary>
        /// Retrieves the content and settings of a message template for messages that are sent
        /// through the voice channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceTemplate service method.</param>
        /// 
        /// <returns>The response from the GetVoiceTemplate service method, as returned by Pinpoint.</returns>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetVoiceTemplate">REST API Reference for GetVoiceTemplate Operation</seealso>
        GetVoiceTemplateResponse GetVoiceTemplate(GetVoiceTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetVoiceTemplate">REST API Reference for GetVoiceTemplate Operation</seealso>
        IAsyncResult BeginGetVoiceTemplate(GetVoiceTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceTemplate.</param>
        /// 
        /// <returns>Returns a  GetVoiceTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetVoiceTemplate">REST API Reference for GetVoiceTemplate Operation</seealso>
        GetVoiceTemplateResponse EndGetVoiceTemplate(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListJourneys">REST API Reference for ListJourneys Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListJourneys">REST API Reference for ListJourneys Operation</seealso>
        IAsyncResult BeginListJourneys(ListJourneysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJourneys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJourneys.</param>
        /// 
        /// <returns>Returns a  ListJourneysResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListJourneys">REST API Reference for ListJourneys Operation</seealso>
        ListJourneysResponse EndListJourneys(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves all the tags (keys and values) that are associated with an application,
        /// campaign, message template, or segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        IAsyncResult BeginListTemplates(ListTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplates.</param>
        /// 
        /// <returns>Returns a  ListTemplatesResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        ListTemplatesResponse EndListTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTemplateVersions


        /// <summary>
        /// Retrieves information about all the versions of a specific message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateVersions service method.</param>
        /// 
        /// <returns>The response from the ListTemplateVersions service method, as returned by Pinpoint.</returns>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        ListTemplateVersionsResponse ListTemplateVersions(ListTemplateVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateVersions operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplateVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        IAsyncResult BeginListTemplateVersions(ListTemplateVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplateVersions.</param>
        /// 
        /// <returns>Returns a  ListTemplateVersionsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        ListTemplateVersionsResponse EndListTemplateVersions(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PhoneNumberValidate">REST API Reference for PhoneNumberValidate Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PhoneNumberValidate">REST API Reference for PhoneNumberValidate Operation</seealso>
        IAsyncResult BeginPhoneNumberValidate(PhoneNumberValidateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PhoneNumberValidate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPhoneNumberValidate.</param>
        /// 
        /// <returns>Returns a  PhoneNumberValidateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PhoneNumberValidate">REST API Reference for PhoneNumberValidate Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PutEvents">REST API Reference for PutEvents Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PutEvents">REST API Reference for PutEvents Operation</seealso>
        IAsyncResult BeginPutEvents(PutEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEvents.</param>
        /// 
        /// <returns>Returns a  PutEventsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PutEvents">REST API Reference for PutEvents Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PutEventStream">REST API Reference for PutEventStream Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PutEventStream">REST API Reference for PutEventStream Operation</seealso>
        IAsyncResult BeginPutEventStream(PutEventStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEventStream.</param>
        /// 
        /// <returns>Returns a  PutEventStreamResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PutEventStream">REST API Reference for PutEventStream Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/RemoveAttributes">REST API Reference for RemoveAttributes Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/RemoveAttributes">REST API Reference for RemoveAttributes Operation</seealso>
        IAsyncResult BeginRemoveAttributes(RemoveAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAttributes.</param>
        /// 
        /// <returns>Returns a  RemoveAttributesResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/RemoveAttributes">REST API Reference for RemoveAttributes Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendMessages">REST API Reference for SendMessages Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendMessages">REST API Reference for SendMessages Operation</seealso>
        IAsyncResult BeginSendMessages(SendMessagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendMessages.</param>
        /// 
        /// <returns>Returns a  SendMessagesResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendMessages">REST API Reference for SendMessages Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendUsersMessages">REST API Reference for SendUsersMessages Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendUsersMessages">REST API Reference for SendUsersMessages Operation</seealso>
        IAsyncResult BeginSendUsersMessages(SendUsersMessagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendUsersMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendUsersMessages.</param>
        /// 
        /// <returns>Returns a  SendUsersMessagesResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendUsersMessages">REST API Reference for SendUsersMessages Operation</seealso>
        SendUsersMessagesResponse EndSendUsersMessages(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags (keys and values) to an application, campaign, message template,
        /// or segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags (keys and values) from an application, campaign, message
        /// template, or segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateAdmChannel">REST API Reference for UpdateAdmChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateAdmChannel">REST API Reference for UpdateAdmChannel Operation</seealso>
        IAsyncResult BeginUpdateAdmChannel(UpdateAdmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAdmChannel.</param>
        /// 
        /// <returns>Returns a  UpdateAdmChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateAdmChannel">REST API Reference for UpdateAdmChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsChannel">REST API Reference for UpdateApnsChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsChannel">REST API Reference for UpdateApnsChannel Operation</seealso>
        IAsyncResult BeginUpdateApnsChannel(UpdateApnsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsChannel">REST API Reference for UpdateApnsChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsSandboxChannel">REST API Reference for UpdateApnsSandboxChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsSandboxChannel">REST API Reference for UpdateApnsSandboxChannel Operation</seealso>
        IAsyncResult BeginUpdateApnsSandboxChannel(UpdateApnsSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsSandboxChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsSandboxChannel">REST API Reference for UpdateApnsSandboxChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsVoipChannel">REST API Reference for UpdateApnsVoipChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsVoipChannel">REST API Reference for UpdateApnsVoipChannel Operation</seealso>
        IAsyncResult BeginUpdateApnsVoipChannel(UpdateApnsVoipChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsVoipChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsVoipChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsVoipChannel">REST API Reference for UpdateApnsVoipChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsVoipSandboxChannel">REST API Reference for UpdateApnsVoipSandboxChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsVoipSandboxChannel">REST API Reference for UpdateApnsVoipSandboxChannel Operation</seealso>
        IAsyncResult BeginUpdateApnsVoipSandboxChannel(UpdateApnsVoipSandboxChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsVoipSandboxChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsVoipSandboxChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsVoipSandboxChannel">REST API Reference for UpdateApnsVoipSandboxChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApplicationSettings">REST API Reference for UpdateApplicationSettings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApplicationSettings">REST API Reference for UpdateApplicationSettings Operation</seealso>
        IAsyncResult BeginUpdateApplicationSettings(UpdateApplicationSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationSettings.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationSettingsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApplicationSettings">REST API Reference for UpdateApplicationSettings Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateBaiduChannel">REST API Reference for UpdateBaiduChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateBaiduChannel">REST API Reference for UpdateBaiduChannel Operation</seealso>
        IAsyncResult BeginUpdateBaiduChannel(UpdateBaiduChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBaiduChannel.</param>
        /// 
        /// <returns>Returns a  UpdateBaiduChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateBaiduChannel">REST API Reference for UpdateBaiduChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        IAsyncResult BeginUpdateCampaign(UpdateCampaignRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaign.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEmailChannel">REST API Reference for UpdateEmailChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEmailChannel">REST API Reference for UpdateEmailChannel Operation</seealso>
        IAsyncResult BeginUpdateEmailChannel(UpdateEmailChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEmailChannel.</param>
        /// 
        /// <returns>Returns a  UpdateEmailChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEmailChannel">REST API Reference for UpdateEmailChannel Operation</seealso>
        UpdateEmailChannelResponse EndUpdateEmailChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEmailTemplate


        /// <summary>
        /// Updates an existing message template for messages that are sent through the email
        /// channel.
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEmailTemplate">REST API Reference for UpdateEmailTemplate Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEmailTemplate">REST API Reference for UpdateEmailTemplate Operation</seealso>
        IAsyncResult BeginUpdateEmailTemplate(UpdateEmailTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEmailTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateEmailTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEmailTemplate">REST API Reference for UpdateEmailTemplate Operation</seealso>
        UpdateEmailTemplateResponse EndUpdateEmailTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEndpoint


        /// <summary>
        /// Creates a new endpoint for an application or updates the settings and attributes of
        /// an existing endpoint for an application. You can also use this operation to define
        /// custom attributes for an endpoint. If an update includes one or more values for a
        /// custom attribute, Amazon Pinpoint replaces (overwrites) any existing values with the
        /// new values.
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        IAsyncResult BeginUpdateEndpoint(UpdateEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        UpdateEndpointResponse EndUpdateEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEndpointsBatch


        /// <summary>
        /// Creates a new batch of endpoints for an application or updates the settings and attributes
        /// of a batch of existing endpoints for an application. You can also use this operation
        /// to define custom attributes for a batch of endpoints. If an update includes one or
        /// more values for a custom attribute, Amazon Pinpoint replaces (overwrites) any existing
        /// values with the new values.
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEndpointsBatch">REST API Reference for UpdateEndpointsBatch Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEndpointsBatch">REST API Reference for UpdateEndpointsBatch Operation</seealso>
        IAsyncResult BeginUpdateEndpointsBatch(UpdateEndpointsBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpointsBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpointsBatch.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointsBatchResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEndpointsBatch">REST API Reference for UpdateEndpointsBatch Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateGcmChannel">REST API Reference for UpdateGcmChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateGcmChannel">REST API Reference for UpdateGcmChannel Operation</seealso>
        IAsyncResult BeginUpdateGcmChannel(UpdateGcmChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGcmChannel.</param>
        /// 
        /// <returns>Returns a  UpdateGcmChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateGcmChannel">REST API Reference for UpdateGcmChannel Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.ConflictException">
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateJourney">REST API Reference for UpdateJourney Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateJourney">REST API Reference for UpdateJourney Operation</seealso>
        IAsyncResult BeginUpdateJourney(UpdateJourneyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJourney operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJourney.</param>
        /// 
        /// <returns>Returns a  UpdateJourneyResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateJourney">REST API Reference for UpdateJourney Operation</seealso>
        UpdateJourneyResponse EndUpdateJourney(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateJourneyState


        /// <summary>
        /// Cancels (stops) an active journey.
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateJourneyState">REST API Reference for UpdateJourneyState Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateJourneyState">REST API Reference for UpdateJourneyState Operation</seealso>
        IAsyncResult BeginUpdateJourneyState(UpdateJourneyStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJourneyState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJourneyState.</param>
        /// 
        /// <returns>Returns a  UpdateJourneyStateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateJourneyState">REST API Reference for UpdateJourneyState Operation</seealso>
        UpdateJourneyStateResponse EndUpdateJourneyState(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePushTemplate


        /// <summary>
        /// Updates an existing message template for messages that are sent through a push notification
        /// channel.
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdatePushTemplate">REST API Reference for UpdatePushTemplate Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdatePushTemplate">REST API Reference for UpdatePushTemplate Operation</seealso>
        IAsyncResult BeginUpdatePushTemplate(UpdatePushTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePushTemplate.</param>
        /// 
        /// <returns>Returns a  UpdatePushTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdatePushTemplate">REST API Reference for UpdatePushTemplate Operation</seealso>
        UpdatePushTemplateResponse EndUpdatePushTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRecommenderConfiguration


        /// <summary>
        /// Updates an Amazon Pinpoint configuration for a recommender model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommenderConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateRecommenderConfiguration service method, as returned by Pinpoint.</returns>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateRecommenderConfiguration">REST API Reference for UpdateRecommenderConfiguration Operation</seealso>
        UpdateRecommenderConfigurationResponse UpdateRecommenderConfiguration(UpdateRecommenderConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommenderConfiguration operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRecommenderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateRecommenderConfiguration">REST API Reference for UpdateRecommenderConfiguration Operation</seealso>
        IAsyncResult BeginUpdateRecommenderConfiguration(UpdateRecommenderConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRecommenderConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateRecommenderConfigurationResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateRecommenderConfiguration">REST API Reference for UpdateRecommenderConfiguration Operation</seealso>
        UpdateRecommenderConfigurationResponse EndUpdateRecommenderConfiguration(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSegment">REST API Reference for UpdateSegment Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSegment">REST API Reference for UpdateSegment Operation</seealso>
        IAsyncResult BeginUpdateSegment(UpdateSegmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSegment.</param>
        /// 
        /// <returns>Returns a  UpdateSegmentResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSegment">REST API Reference for UpdateSegment Operation</seealso>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSmsChannel">REST API Reference for UpdateSmsChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSmsChannel">REST API Reference for UpdateSmsChannel Operation</seealso>
        IAsyncResult BeginUpdateSmsChannel(UpdateSmsChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSmsChannel.</param>
        /// 
        /// <returns>Returns a  UpdateSmsChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSmsChannel">REST API Reference for UpdateSmsChannel Operation</seealso>
        UpdateSmsChannelResponse EndUpdateSmsChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSmsTemplate


        /// <summary>
        /// Updates an existing message template for messages that are sent through the SMS channel.
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSmsTemplate">REST API Reference for UpdateSmsTemplate Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSmsTemplate">REST API Reference for UpdateSmsTemplate Operation</seealso>
        IAsyncResult BeginUpdateSmsTemplate(UpdateSmsTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSmsTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateSmsTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSmsTemplate">REST API Reference for UpdateSmsTemplate Operation</seealso>
        UpdateSmsTemplateResponse EndUpdateSmsTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTemplateActiveVersion


        /// <summary>
        /// Changes the status of a specific version of a message template to <i>active</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateActiveVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplateActiveVersion service method, as returned by Pinpoint.</returns>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateTemplateActiveVersion">REST API Reference for UpdateTemplateActiveVersion Operation</seealso>
        UpdateTemplateActiveVersionResponse UpdateTemplateActiveVersion(UpdateTemplateActiveVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplateActiveVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateActiveVersion operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplateActiveVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateTemplateActiveVersion">REST API Reference for UpdateTemplateActiveVersion Operation</seealso>
        IAsyncResult BeginUpdateTemplateActiveVersion(UpdateTemplateActiveVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplateActiveVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplateActiveVersion.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateActiveVersionResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateTemplateActiveVersion">REST API Reference for UpdateTemplateActiveVersion Operation</seealso>
        UpdateTemplateActiveVersionResponse EndUpdateTemplateActiveVersion(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateVoiceChannel">REST API Reference for UpdateVoiceChannel Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateVoiceChannel">REST API Reference for UpdateVoiceChannel Operation</seealso>
        IAsyncResult BeginUpdateVoiceChannel(UpdateVoiceChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceChannel.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateVoiceChannel">REST API Reference for UpdateVoiceChannel Operation</seealso>
        UpdateVoiceChannelResponse EndUpdateVoiceChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVoiceTemplate


        /// <summary>
        /// Updates an existing message template for messages that are sent through the voice
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateVoiceTemplate service method, as returned by Pinpoint.</returns>
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
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateVoiceTemplate">REST API Reference for UpdateVoiceTemplate Operation</seealso>
        UpdateVoiceTemplateResponse UpdateVoiceTemplate(UpdateVoiceTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateVoiceTemplate">REST API Reference for UpdateVoiceTemplate Operation</seealso>
        IAsyncResult BeginUpdateVoiceTemplate(UpdateVoiceTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateVoiceTemplate">REST API Reference for UpdateVoiceTemplate Operation</seealso>
        UpdateVoiceTemplateResponse EndUpdateVoiceTemplate(IAsyncResult asyncResult);

        #endregion
        
    }
}