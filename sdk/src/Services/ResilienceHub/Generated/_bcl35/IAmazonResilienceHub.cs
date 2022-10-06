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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ResilienceHub.Model;

namespace Amazon.ResilienceHub
{
    /// <summary>
    /// Interface for accessing ResilienceHub
    ///
    /// AWS Resilience Hub helps you proactively prepare and protect your Amazon Web Services
    /// applications from disruptions. Resilience Hub offers continuous resiliency assessment
    /// and validation that integrates into your software development lifecycle. This enables
    /// you to uncover resiliency weaknesses, ensure recovery time objective (RTO) and recovery
    /// point objective (RPO) targets for your applications are met, and resolve issues before
    /// they are released into production.
    /// </summary>
    public partial interface IAmazonResilienceHub : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IResilienceHubPaginatorFactory Paginators { get; }
#endif


        
        #region  AddDraftAppVersionResourceMappings


        /// <summary>
        /// Adds the resource mapping for the draft application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddDraftAppVersionResourceMappings service method.</param>
        /// 
        /// <returns>The response from the AddDraftAppVersionResourceMappings service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/AddDraftAppVersionResourceMappings">REST API Reference for AddDraftAppVersionResourceMappings Operation</seealso>
        AddDraftAppVersionResourceMappingsResponse AddDraftAppVersionResourceMappings(AddDraftAppVersionResourceMappingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddDraftAppVersionResourceMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddDraftAppVersionResourceMappings operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddDraftAppVersionResourceMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/AddDraftAppVersionResourceMappings">REST API Reference for AddDraftAppVersionResourceMappings Operation</seealso>
        IAsyncResult BeginAddDraftAppVersionResourceMappings(AddDraftAppVersionResourceMappingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddDraftAppVersionResourceMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddDraftAppVersionResourceMappings.</param>
        /// 
        /// <returns>Returns a  AddDraftAppVersionResourceMappingsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/AddDraftAppVersionResourceMappings">REST API Reference for AddDraftAppVersionResourceMappings Operation</seealso>
        AddDraftAppVersionResourceMappingsResponse EndAddDraftAppVersionResourceMappings(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApp


        /// <summary>
        /// Creates a Resilience Hub application. A Resilience Hub application is a collection
        /// of Amazon Web Services resources structured to prevent and recover Amazon Web Services
        /// application disruptions. To describe a Resilience Hub application, you provide an
        /// application name, resources from one or more–up to five–CloudFormation stacks, and
        /// an appropriate resiliency policy.
        /// 
        ///  
        /// <para>
        /// After you create a Resilience Hub application, you publish it so that you can run
        /// a resiliency assessment on it. You can then use recommendations from the assessment
        /// to improve resiliency by running another assessment, comparing results, and then iterating
        /// the process until you achieve your goals for recovery time objective (RTO) and recovery
        /// point objective (RPO).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateApp">REST API Reference for CreateApp Operation</seealso>
        CreateAppResponse CreateApp(CreateAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateApp">REST API Reference for CreateApp Operation</seealso>
        IAsyncResult BeginCreateApp(CreateAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApp.</param>
        /// 
        /// <returns>Returns a  CreateAppResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateApp">REST API Reference for CreateApp Operation</seealso>
        CreateAppResponse EndCreateApp(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRecommendationTemplate


        /// <summary>
        /// Creates a new recommendation template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommendationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateRecommendationTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateRecommendationTemplate">REST API Reference for CreateRecommendationTemplate Operation</seealso>
        CreateRecommendationTemplateResponse CreateRecommendationTemplate(CreateRecommendationTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRecommendationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommendationTemplate operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRecommendationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateRecommendationTemplate">REST API Reference for CreateRecommendationTemplate Operation</seealso>
        IAsyncResult BeginCreateRecommendationTemplate(CreateRecommendationTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRecommendationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRecommendationTemplate.</param>
        /// 
        /// <returns>Returns a  CreateRecommendationTemplateResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateRecommendationTemplate">REST API Reference for CreateRecommendationTemplate Operation</seealso>
        CreateRecommendationTemplateResponse EndCreateRecommendationTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResiliencyPolicy


        /// <summary>
        /// Creates a resiliency policy for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResiliencyPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateResiliencyPolicy">REST API Reference for CreateResiliencyPolicy Operation</seealso>
        CreateResiliencyPolicyResponse CreateResiliencyPolicy(CreateResiliencyPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResiliencyPolicy operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResiliencyPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateResiliencyPolicy">REST API Reference for CreateResiliencyPolicy Operation</seealso>
        IAsyncResult BeginCreateResiliencyPolicy(CreateResiliencyPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResiliencyPolicy.</param>
        /// 
        /// <returns>Returns a  CreateResiliencyPolicyResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateResiliencyPolicy">REST API Reference for CreateResiliencyPolicy Operation</seealso>
        CreateResiliencyPolicyResponse EndCreateResiliencyPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApp


        /// <summary>
        /// Deletes an AWS Resilience Hub application. This is a destructive action that can't
        /// be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        DeleteAppResponse DeleteApp(DeleteAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        IAsyncResult BeginDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        /// 
        /// <returns>Returns a  DeleteAppResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAppAssessment


        /// <summary>
        /// Deletes an AWS Resilience Hub application assessment. This is a destructive action
        /// that can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppAssessment service method.</param>
        /// 
        /// <returns>The response from the DeleteAppAssessment service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppAssessment">REST API Reference for DeleteAppAssessment Operation</seealso>
        DeleteAppAssessmentResponse DeleteAppAssessment(DeleteAppAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAppAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppAssessment operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAppAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppAssessment">REST API Reference for DeleteAppAssessment Operation</seealso>
        IAsyncResult BeginDeleteAppAssessment(DeleteAppAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAppAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAppAssessment.</param>
        /// 
        /// <returns>Returns a  DeleteAppAssessmentResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppAssessment">REST API Reference for DeleteAppAssessment Operation</seealso>
        DeleteAppAssessmentResponse EndDeleteAppAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRecommendationTemplate


        /// <summary>
        /// Deletes a recommendation template. This is a destructive action that can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommendationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteRecommendationTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteRecommendationTemplate">REST API Reference for DeleteRecommendationTemplate Operation</seealso>
        DeleteRecommendationTemplateResponse DeleteRecommendationTemplate(DeleteRecommendationTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecommendationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommendationTemplate operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRecommendationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteRecommendationTemplate">REST API Reference for DeleteRecommendationTemplate Operation</seealso>
        IAsyncResult BeginDeleteRecommendationTemplate(DeleteRecommendationTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRecommendationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRecommendationTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteRecommendationTemplateResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteRecommendationTemplate">REST API Reference for DeleteRecommendationTemplate Operation</seealso>
        DeleteRecommendationTemplateResponse EndDeleteRecommendationTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResiliencyPolicy


        /// <summary>
        /// Deletes a resiliency policy. This is a destructive action that can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResiliencyPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteResiliencyPolicy">REST API Reference for DeleteResiliencyPolicy Operation</seealso>
        DeleteResiliencyPolicyResponse DeleteResiliencyPolicy(DeleteResiliencyPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResiliencyPolicy operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResiliencyPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteResiliencyPolicy">REST API Reference for DeleteResiliencyPolicy Operation</seealso>
        IAsyncResult BeginDeleteResiliencyPolicy(DeleteResiliencyPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResiliencyPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResiliencyPolicyResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteResiliencyPolicy">REST API Reference for DeleteResiliencyPolicy Operation</seealso>
        DeleteResiliencyPolicyResponse EndDeleteResiliencyPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeApp


        /// <summary>
        /// Describes an AWS Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp service method.</param>
        /// 
        /// <returns>The response from the DescribeApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        DescribeAppResponse DescribeApp(DescribeAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        IAsyncResult BeginDescribeApp(DescribeAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeApp.</param>
        /// 
        /// <returns>Returns a  DescribeAppResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        DescribeAppResponse EndDescribeApp(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAppAssessment


        /// <summary>
        /// Describes an assessment for an AWS Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppAssessment service method.</param>
        /// 
        /// <returns>The response from the DescribeAppAssessment service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppAssessment">REST API Reference for DescribeAppAssessment Operation</seealso>
        DescribeAppAssessmentResponse DescribeAppAssessment(DescribeAppAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppAssessment operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppAssessment">REST API Reference for DescribeAppAssessment Operation</seealso>
        IAsyncResult BeginDescribeAppAssessment(DescribeAppAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppAssessment.</param>
        /// 
        /// <returns>Returns a  DescribeAppAssessmentResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppAssessment">REST API Reference for DescribeAppAssessment Operation</seealso>
        DescribeAppAssessmentResponse EndDescribeAppAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAppVersionResourcesResolutionStatus


        /// <summary>
        /// Returns the resolution status for the specified resolution identifier for an application
        /// version. If <code>resolutionId</code> is not specified, the current resolution status
        /// is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionResourcesResolutionStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeAppVersionResourcesResolutionStatus service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionResourcesResolutionStatus">REST API Reference for DescribeAppVersionResourcesResolutionStatus Operation</seealso>
        DescribeAppVersionResourcesResolutionStatusResponse DescribeAppVersionResourcesResolutionStatus(DescribeAppVersionResourcesResolutionStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppVersionResourcesResolutionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionResourcesResolutionStatus operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppVersionResourcesResolutionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionResourcesResolutionStatus">REST API Reference for DescribeAppVersionResourcesResolutionStatus Operation</seealso>
        IAsyncResult BeginDescribeAppVersionResourcesResolutionStatus(DescribeAppVersionResourcesResolutionStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppVersionResourcesResolutionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppVersionResourcesResolutionStatus.</param>
        /// 
        /// <returns>Returns a  DescribeAppVersionResourcesResolutionStatusResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionResourcesResolutionStatus">REST API Reference for DescribeAppVersionResourcesResolutionStatus Operation</seealso>
        DescribeAppVersionResourcesResolutionStatusResponse EndDescribeAppVersionResourcesResolutionStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAppVersionTemplate


        /// <summary>
        /// Describes details about an AWS Resilience Hub
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionTemplate service method.</param>
        /// 
        /// <returns>The response from the DescribeAppVersionTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionTemplate">REST API Reference for DescribeAppVersionTemplate Operation</seealso>
        DescribeAppVersionTemplateResponse DescribeAppVersionTemplate(DescribeAppVersionTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAppVersionTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionTemplate operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAppVersionTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionTemplate">REST API Reference for DescribeAppVersionTemplate Operation</seealso>
        IAsyncResult BeginDescribeAppVersionTemplate(DescribeAppVersionTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAppVersionTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAppVersionTemplate.</param>
        /// 
        /// <returns>Returns a  DescribeAppVersionTemplateResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionTemplate">REST API Reference for DescribeAppVersionTemplate Operation</seealso>
        DescribeAppVersionTemplateResponse EndDescribeAppVersionTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDraftAppVersionResourcesImportStatus


        /// <summary>
        /// Describes the status of importing resources to an application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDraftAppVersionResourcesImportStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeDraftAppVersionResourcesImportStatus service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeDraftAppVersionResourcesImportStatus">REST API Reference for DescribeDraftAppVersionResourcesImportStatus Operation</seealso>
        DescribeDraftAppVersionResourcesImportStatusResponse DescribeDraftAppVersionResourcesImportStatus(DescribeDraftAppVersionResourcesImportStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDraftAppVersionResourcesImportStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDraftAppVersionResourcesImportStatus operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDraftAppVersionResourcesImportStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeDraftAppVersionResourcesImportStatus">REST API Reference for DescribeDraftAppVersionResourcesImportStatus Operation</seealso>
        IAsyncResult BeginDescribeDraftAppVersionResourcesImportStatus(DescribeDraftAppVersionResourcesImportStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDraftAppVersionResourcesImportStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDraftAppVersionResourcesImportStatus.</param>
        /// 
        /// <returns>Returns a  DescribeDraftAppVersionResourcesImportStatusResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeDraftAppVersionResourcesImportStatus">REST API Reference for DescribeDraftAppVersionResourcesImportStatus Operation</seealso>
        DescribeDraftAppVersionResourcesImportStatusResponse EndDescribeDraftAppVersionResourcesImportStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeResiliencyPolicy


        /// <summary>
        /// Describes a specified resiliency policy for an AWS Resilience Hub application. The
        /// returned policy object includes creation time, data location constraints, the Amazon
        /// Resource Name (ARN) for the policy, tags, tier, and more.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResiliencyPolicy service method.</param>
        /// 
        /// <returns>The response from the DescribeResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeResiliencyPolicy">REST API Reference for DescribeResiliencyPolicy Operation</seealso>
        DescribeResiliencyPolicyResponse DescribeResiliencyPolicy(DescribeResiliencyPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResiliencyPolicy operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResiliencyPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeResiliencyPolicy">REST API Reference for DescribeResiliencyPolicy Operation</seealso>
        IAsyncResult BeginDescribeResiliencyPolicy(DescribeResiliencyPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResiliencyPolicy.</param>
        /// 
        /// <returns>Returns a  DescribeResiliencyPolicyResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeResiliencyPolicy">REST API Reference for DescribeResiliencyPolicy Operation</seealso>
        DescribeResiliencyPolicyResponse EndDescribeResiliencyPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportResourcesToDraftAppVersion


        /// <summary>
        /// Imports resources from sources such as a CloudFormation stack, resource-groups, or
        /// application registry app to a draft application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportResourcesToDraftAppVersion service method.</param>
        /// 
        /// <returns>The response from the ImportResourcesToDraftAppVersion service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ImportResourcesToDraftAppVersion">REST API Reference for ImportResourcesToDraftAppVersion Operation</seealso>
        ImportResourcesToDraftAppVersionResponse ImportResourcesToDraftAppVersion(ImportResourcesToDraftAppVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportResourcesToDraftAppVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportResourcesToDraftAppVersion operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportResourcesToDraftAppVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ImportResourcesToDraftAppVersion">REST API Reference for ImportResourcesToDraftAppVersion Operation</seealso>
        IAsyncResult BeginImportResourcesToDraftAppVersion(ImportResourcesToDraftAppVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportResourcesToDraftAppVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportResourcesToDraftAppVersion.</param>
        /// 
        /// <returns>Returns a  ImportResourcesToDraftAppVersionResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ImportResourcesToDraftAppVersion">REST API Reference for ImportResourcesToDraftAppVersion Operation</seealso>
        ImportResourcesToDraftAppVersionResponse EndImportResourcesToDraftAppVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAlarmRecommendations


        /// <summary>
        /// Lists the alarm recommendations for a AWS Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlarmRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListAlarmRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAlarmRecommendations">REST API Reference for ListAlarmRecommendations Operation</seealso>
        ListAlarmRecommendationsResponse ListAlarmRecommendations(ListAlarmRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAlarmRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAlarmRecommendations operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAlarmRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAlarmRecommendations">REST API Reference for ListAlarmRecommendations Operation</seealso>
        IAsyncResult BeginListAlarmRecommendations(ListAlarmRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAlarmRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAlarmRecommendations.</param>
        /// 
        /// <returns>Returns a  ListAlarmRecommendationsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAlarmRecommendations">REST API Reference for ListAlarmRecommendations Operation</seealso>
        ListAlarmRecommendationsResponse EndListAlarmRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAppAssessments


        /// <summary>
        /// Lists the assessments for an AWS Resilience Hub application. You can use request parameters
        /// to refine the results for the response object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppAssessments service method.</param>
        /// 
        /// <returns>The response from the ListAppAssessments service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppAssessments">REST API Reference for ListAppAssessments Operation</seealso>
        ListAppAssessmentsResponse ListAppAssessments(ListAppAssessmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppAssessments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppAssessments operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppAssessments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppAssessments">REST API Reference for ListAppAssessments Operation</seealso>
        IAsyncResult BeginListAppAssessments(ListAppAssessmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppAssessments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppAssessments.</param>
        /// 
        /// <returns>Returns a  ListAppAssessmentsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppAssessments">REST API Reference for ListAppAssessments Operation</seealso>
        ListAppAssessmentsResponse EndListAppAssessments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAppComponentCompliances


        /// <summary>
        /// Lists the compliances for an AWS Resilience Hub component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppComponentCompliances service method.</param>
        /// 
        /// <returns>The response from the ListAppComponentCompliances service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentCompliances">REST API Reference for ListAppComponentCompliances Operation</seealso>
        ListAppComponentCompliancesResponse ListAppComponentCompliances(ListAppComponentCompliancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppComponentCompliances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppComponentCompliances operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppComponentCompliances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentCompliances">REST API Reference for ListAppComponentCompliances Operation</seealso>
        IAsyncResult BeginListAppComponentCompliances(ListAppComponentCompliancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppComponentCompliances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppComponentCompliances.</param>
        /// 
        /// <returns>Returns a  ListAppComponentCompliancesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentCompliances">REST API Reference for ListAppComponentCompliances Operation</seealso>
        ListAppComponentCompliancesResponse EndListAppComponentCompliances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAppComponentRecommendations


        /// <summary>
        /// Lists the recommendations for an AWS Resilience Hub component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppComponentRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListAppComponentRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentRecommendations">REST API Reference for ListAppComponentRecommendations Operation</seealso>
        ListAppComponentRecommendationsResponse ListAppComponentRecommendations(ListAppComponentRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppComponentRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppComponentRecommendations operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppComponentRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentRecommendations">REST API Reference for ListAppComponentRecommendations Operation</seealso>
        IAsyncResult BeginListAppComponentRecommendations(ListAppComponentRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppComponentRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppComponentRecommendations.</param>
        /// 
        /// <returns>Returns a  ListAppComponentRecommendationsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentRecommendations">REST API Reference for ListAppComponentRecommendations Operation</seealso>
        ListAppComponentRecommendationsResponse EndListAppComponentRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApps


        /// <summary>
        /// Lists your Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListApps">REST API Reference for ListApps Operation</seealso>
        ListAppsResponse ListApps(ListAppsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApps operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListApps">REST API Reference for ListApps Operation</seealso>
        IAsyncResult BeginListApps(ListAppsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApps.</param>
        /// 
        /// <returns>Returns a  ListAppsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListApps">REST API Reference for ListApps Operation</seealso>
        ListAppsResponse EndListApps(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAppVersionResourceMappings


        /// <summary>
        /// Lists how the resources in an application version are mapped/sourced from. Mappings
        /// can be physical resource identifiers, CloudFormation stacks, resource-groups, or an
        /// application registry app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersionResourceMappings service method.</param>
        /// 
        /// <returns>The response from the ListAppVersionResourceMappings service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResourceMappings">REST API Reference for ListAppVersionResourceMappings Operation</seealso>
        ListAppVersionResourceMappingsResponse ListAppVersionResourceMappings(ListAppVersionResourceMappingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppVersionResourceMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersionResourceMappings operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppVersionResourceMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResourceMappings">REST API Reference for ListAppVersionResourceMappings Operation</seealso>
        IAsyncResult BeginListAppVersionResourceMappings(ListAppVersionResourceMappingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppVersionResourceMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppVersionResourceMappings.</param>
        /// 
        /// <returns>Returns a  ListAppVersionResourceMappingsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResourceMappings">REST API Reference for ListAppVersionResourceMappings Operation</seealso>
        ListAppVersionResourceMappingsResponse EndListAppVersionResourceMappings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAppVersionResources


        /// <summary>
        /// Lists all the resources in an application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersionResources service method.</param>
        /// 
        /// <returns>The response from the ListAppVersionResources service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResources">REST API Reference for ListAppVersionResources Operation</seealso>
        ListAppVersionResourcesResponse ListAppVersionResources(ListAppVersionResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppVersionResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersionResources operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppVersionResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResources">REST API Reference for ListAppVersionResources Operation</seealso>
        IAsyncResult BeginListAppVersionResources(ListAppVersionResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppVersionResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppVersionResources.</param>
        /// 
        /// <returns>Returns a  ListAppVersionResourcesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResources">REST API Reference for ListAppVersionResources Operation</seealso>
        ListAppVersionResourcesResponse EndListAppVersionResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAppVersions


        /// <summary>
        /// Lists the different versions for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersions service method.</param>
        /// 
        /// <returns>The response from the ListAppVersions service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersions">REST API Reference for ListAppVersions Operation</seealso>
        ListAppVersionsResponse ListAppVersions(ListAppVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAppVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersions operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAppVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersions">REST API Reference for ListAppVersions Operation</seealso>
        IAsyncResult BeginListAppVersions(ListAppVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAppVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAppVersions.</param>
        /// 
        /// <returns>Returns a  ListAppVersionsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersions">REST API Reference for ListAppVersions Operation</seealso>
        ListAppVersionsResponse EndListAppVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRecommendationTemplates


        /// <summary>
        /// Lists the recommendation templates for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationTemplates service method.</param>
        /// 
        /// <returns>The response from the ListRecommendationTemplates service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListRecommendationTemplates">REST API Reference for ListRecommendationTemplates Operation</seealso>
        ListRecommendationTemplatesResponse ListRecommendationTemplates(ListRecommendationTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecommendationTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationTemplates operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecommendationTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListRecommendationTemplates">REST API Reference for ListRecommendationTemplates Operation</seealso>
        IAsyncResult BeginListRecommendationTemplates(ListRecommendationTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecommendationTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecommendationTemplates.</param>
        /// 
        /// <returns>Returns a  ListRecommendationTemplatesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListRecommendationTemplates">REST API Reference for ListRecommendationTemplates Operation</seealso>
        ListRecommendationTemplatesResponse EndListRecommendationTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResiliencyPolicies


        /// <summary>
        /// Lists the resiliency policies for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResiliencyPolicies service method.</param>
        /// 
        /// <returns>The response from the ListResiliencyPolicies service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListResiliencyPolicies">REST API Reference for ListResiliencyPolicies Operation</seealso>
        ListResiliencyPoliciesResponse ListResiliencyPolicies(ListResiliencyPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResiliencyPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResiliencyPolicies operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResiliencyPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListResiliencyPolicies">REST API Reference for ListResiliencyPolicies Operation</seealso>
        IAsyncResult BeginListResiliencyPolicies(ListResiliencyPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResiliencyPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResiliencyPolicies.</param>
        /// 
        /// <returns>Returns a  ListResiliencyPoliciesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListResiliencyPolicies">REST API Reference for ListResiliencyPolicies Operation</seealso>
        ListResiliencyPoliciesResponse EndListResiliencyPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSopRecommendations


        /// <summary>
        /// Lists the standard operating procedure (SOP) recommendations for the Resilience Hub
        /// applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSopRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListSopRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSopRecommendations">REST API Reference for ListSopRecommendations Operation</seealso>
        ListSopRecommendationsResponse ListSopRecommendations(ListSopRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSopRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSopRecommendations operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSopRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSopRecommendations">REST API Reference for ListSopRecommendations Operation</seealso>
        IAsyncResult BeginListSopRecommendations(ListSopRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSopRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSopRecommendations.</param>
        /// 
        /// <returns>Returns a  ListSopRecommendationsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSopRecommendations">REST API Reference for ListSopRecommendations Operation</seealso>
        ListSopRecommendationsResponse EndListSopRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSuggestedResiliencyPolicies


        /// <summary>
        /// Lists the suggested resiliency policies for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuggestedResiliencyPolicies service method.</param>
        /// 
        /// <returns>The response from the ListSuggestedResiliencyPolicies service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSuggestedResiliencyPolicies">REST API Reference for ListSuggestedResiliencyPolicies Operation</seealso>
        ListSuggestedResiliencyPoliciesResponse ListSuggestedResiliencyPolicies(ListSuggestedResiliencyPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSuggestedResiliencyPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSuggestedResiliencyPolicies operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSuggestedResiliencyPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSuggestedResiliencyPolicies">REST API Reference for ListSuggestedResiliencyPolicies Operation</seealso>
        IAsyncResult BeginListSuggestedResiliencyPolicies(ListSuggestedResiliencyPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSuggestedResiliencyPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSuggestedResiliencyPolicies.</param>
        /// 
        /// <returns>Returns a  ListSuggestedResiliencyPoliciesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSuggestedResiliencyPolicies">REST API Reference for ListSuggestedResiliencyPolicies Operation</seealso>
        ListSuggestedResiliencyPoliciesResponse EndListSuggestedResiliencyPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for your resources in your Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTestRecommendations


        /// <summary>
        /// Lists the test recommendations for the Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListTestRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTestRecommendations">REST API Reference for ListTestRecommendations Operation</seealso>
        ListTestRecommendationsResponse ListTestRecommendations(ListTestRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTestRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTestRecommendations operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTestRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTestRecommendations">REST API Reference for ListTestRecommendations Operation</seealso>
        IAsyncResult BeginListTestRecommendations(ListTestRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTestRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTestRecommendations.</param>
        /// 
        /// <returns>Returns a  ListTestRecommendationsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTestRecommendations">REST API Reference for ListTestRecommendations Operation</seealso>
        ListTestRecommendationsResponse EndListTestRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUnsupportedAppVersionResources


        /// <summary>
        /// Lists the resources that are not currently supported in AWS Resilience Hub. An unsupported
        /// resource is a resource that exists in the object that was used to create an app, but
        /// is not supported by Resilience Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUnsupportedAppVersionResources service method.</param>
        /// 
        /// <returns>The response from the ListUnsupportedAppVersionResources service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListUnsupportedAppVersionResources">REST API Reference for ListUnsupportedAppVersionResources Operation</seealso>
        ListUnsupportedAppVersionResourcesResponse ListUnsupportedAppVersionResources(ListUnsupportedAppVersionResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUnsupportedAppVersionResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUnsupportedAppVersionResources operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUnsupportedAppVersionResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListUnsupportedAppVersionResources">REST API Reference for ListUnsupportedAppVersionResources Operation</seealso>
        IAsyncResult BeginListUnsupportedAppVersionResources(ListUnsupportedAppVersionResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUnsupportedAppVersionResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUnsupportedAppVersionResources.</param>
        /// 
        /// <returns>Returns a  ListUnsupportedAppVersionResourcesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListUnsupportedAppVersionResources">REST API Reference for ListUnsupportedAppVersionResources Operation</seealso>
        ListUnsupportedAppVersionResourcesResponse EndListUnsupportedAppVersionResources(IAsyncResult asyncResult);

        #endregion
        
        #region  PublishAppVersion


        /// <summary>
        /// Publishes a new version of a specific Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishAppVersion service method.</param>
        /// 
        /// <returns>The response from the PublishAppVersion service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PublishAppVersion">REST API Reference for PublishAppVersion Operation</seealso>
        PublishAppVersionResponse PublishAppVersion(PublishAppVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PublishAppVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishAppVersion operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishAppVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PublishAppVersion">REST API Reference for PublishAppVersion Operation</seealso>
        IAsyncResult BeginPublishAppVersion(PublishAppVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PublishAppVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishAppVersion.</param>
        /// 
        /// <returns>Returns a  PublishAppVersionResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PublishAppVersion">REST API Reference for PublishAppVersion Operation</seealso>
        PublishAppVersionResponse EndPublishAppVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  PutDraftAppVersionTemplate


        /// <summary>
        /// Adds or updates the app template for a draft version of a Resilience Hub app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDraftAppVersionTemplate service method.</param>
        /// 
        /// <returns>The response from the PutDraftAppVersionTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PutDraftAppVersionTemplate">REST API Reference for PutDraftAppVersionTemplate Operation</seealso>
        PutDraftAppVersionTemplateResponse PutDraftAppVersionTemplate(PutDraftAppVersionTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutDraftAppVersionTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDraftAppVersionTemplate operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDraftAppVersionTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PutDraftAppVersionTemplate">REST API Reference for PutDraftAppVersionTemplate Operation</seealso>
        IAsyncResult BeginPutDraftAppVersionTemplate(PutDraftAppVersionTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutDraftAppVersionTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDraftAppVersionTemplate.</param>
        /// 
        /// <returns>Returns a  PutDraftAppVersionTemplateResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PutDraftAppVersionTemplate">REST API Reference for PutDraftAppVersionTemplate Operation</seealso>
        PutDraftAppVersionTemplateResponse EndPutDraftAppVersionTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveDraftAppVersionResourceMappings


        /// <summary>
        /// Removes resource mappings from a draft application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveDraftAppVersionResourceMappings service method.</param>
        /// 
        /// <returns>The response from the RemoveDraftAppVersionResourceMappings service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/RemoveDraftAppVersionResourceMappings">REST API Reference for RemoveDraftAppVersionResourceMappings Operation</seealso>
        RemoveDraftAppVersionResourceMappingsResponse RemoveDraftAppVersionResourceMappings(RemoveDraftAppVersionResourceMappingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveDraftAppVersionResourceMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveDraftAppVersionResourceMappings operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveDraftAppVersionResourceMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/RemoveDraftAppVersionResourceMappings">REST API Reference for RemoveDraftAppVersionResourceMappings Operation</seealso>
        IAsyncResult BeginRemoveDraftAppVersionResourceMappings(RemoveDraftAppVersionResourceMappingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveDraftAppVersionResourceMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveDraftAppVersionResourceMappings.</param>
        /// 
        /// <returns>Returns a  RemoveDraftAppVersionResourceMappingsResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/RemoveDraftAppVersionResourceMappings">REST API Reference for RemoveDraftAppVersionResourceMappings Operation</seealso>
        RemoveDraftAppVersionResourceMappingsResponse EndRemoveDraftAppVersionResourceMappings(IAsyncResult asyncResult);

        #endregion
        
        #region  ResolveAppVersionResources


        /// <summary>
        /// Resolves the resources for an application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveAppVersionResources service method.</param>
        /// 
        /// <returns>The response from the ResolveAppVersionResources service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ResolveAppVersionResources">REST API Reference for ResolveAppVersionResources Operation</seealso>
        ResolveAppVersionResourcesResponse ResolveAppVersionResources(ResolveAppVersionResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResolveAppVersionResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveAppVersionResources operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResolveAppVersionResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ResolveAppVersionResources">REST API Reference for ResolveAppVersionResources Operation</seealso>
        IAsyncResult BeginResolveAppVersionResources(ResolveAppVersionResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResolveAppVersionResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResolveAppVersionResources.</param>
        /// 
        /// <returns>Returns a  ResolveAppVersionResourcesResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ResolveAppVersionResources">REST API Reference for ResolveAppVersionResources Operation</seealso>
        ResolveAppVersionResourcesResponse EndResolveAppVersionResources(IAsyncResult asyncResult);

        #endregion
        
        #region  StartAppAssessment


        /// <summary>
        /// Creates a new application assessment for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAppAssessment service method.</param>
        /// 
        /// <returns>The response from the StartAppAssessment service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/StartAppAssessment">REST API Reference for StartAppAssessment Operation</seealso>
        StartAppAssessmentResponse StartAppAssessment(StartAppAssessmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartAppAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAppAssessment operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAppAssessment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/StartAppAssessment">REST API Reference for StartAppAssessment Operation</seealso>
        IAsyncResult BeginStartAppAssessment(StartAppAssessmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartAppAssessment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAppAssessment.</param>
        /// 
        /// <returns>Returns a  StartAppAssessmentResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/StartAppAssessment">REST API Reference for StartAppAssessment Operation</seealso>
        StartAppAssessmentResponse EndStartAppAssessment(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Applies one or more tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApp


        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp service method.</param>
        /// 
        /// <returns>The response from the UpdateApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        UpdateAppResponse UpdateApp(UpdateAppRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        IAsyncResult BeginUpdateApp(UpdateAppRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApp.</param>
        /// 
        /// <returns>Returns a  UpdateAppResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        UpdateAppResponse EndUpdateApp(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResiliencyPolicy


        /// <summary>
        /// Updates a resiliency policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResiliencyPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateResiliencyPolicy">REST API Reference for UpdateResiliencyPolicy Operation</seealso>
        UpdateResiliencyPolicyResponse UpdateResiliencyPolicy(UpdateResiliencyPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResiliencyPolicy operation on AmazonResilienceHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResiliencyPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateResiliencyPolicy">REST API Reference for UpdateResiliencyPolicy Operation</seealso>
        IAsyncResult BeginUpdateResiliencyPolicy(UpdateResiliencyPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResiliencyPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResiliencyPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateResiliencyPolicyResult from ResilienceHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateResiliencyPolicy">REST API Reference for UpdateResiliencyPolicy Operation</seealso>
        UpdateResiliencyPolicyResponse EndUpdateResiliencyPolicy(IAsyncResult asyncResult);

        #endregion
        
    }
}