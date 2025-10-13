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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ObservabilityAdmin.Model;

#pragma warning disable CS1570
namespace Amazon.ObservabilityAdmin
{
    /// <summary>
    /// <para>Interface for accessing ObservabilityAdmin</para>
    ///
    /// You can use Amazon CloudWatch Observability Admin to discover and understand the
    /// state of telemetry configuration in CloudWatch for your Amazon Web Services Organization
    /// or account. This simplifies the process of auditing your telemetry collection configurations
    /// across multiple resource types within your Amazon Web Services Organization or account.
    /// By providing a consolidated view, it allows you to easily review and manage telemetry
    /// settings, helping you ensure proper monitoring and data collection across your Amazon
    /// Web Services environment. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/telemetry-config-cloudwatch.html">Auditing
    /// CloudWatch telemetry conﬁgurations</a> in the CloudWatch User Guide.
    /// 
    ///  
    /// <para>
    /// For information on the permissions you need to use this API, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/auth-and-access-control-cw.html">Identity
    /// and access management for Amazon CloudWatch</a> in the CloudWatch User Guide.
    /// </para>
    /// </summary>
    public partial interface IAmazonObservabilityAdmin : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IObservabilityAdminPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateCentralizationRuleForOrganization


        /// <summary>
        /// Creates a centralization rule that applies across an Amazon Web Services Organization.
        /// This operation can only be called by the organization's management account or a delegated
        /// administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCentralizationRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the CreateCentralizationRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ConflictException">
        /// The requested operation conflicts with the current state of the specified resource
        /// or with another request.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateCentralizationRuleForOrganization">REST API Reference for CreateCentralizationRuleForOrganization Operation</seealso>
        CreateCentralizationRuleForOrganizationResponse CreateCentralizationRuleForOrganization(CreateCentralizationRuleForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCentralizationRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCentralizationRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateCentralizationRuleForOrganization">REST API Reference for CreateCentralizationRuleForOrganization Operation</seealso>
        IAsyncResult BeginCreateCentralizationRuleForOrganization(CreateCentralizationRuleForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCentralizationRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  CreateCentralizationRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateCentralizationRuleForOrganization">REST API Reference for CreateCentralizationRuleForOrganization Operation</seealso>
        CreateCentralizationRuleForOrganizationResponse EndCreateCentralizationRuleForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTelemetryRule


        /// <summary>
        /// Creates a telemetry rule that defines how telemetry should be configured for Amazon
        /// Web Services resources in your account. The rule specifies which resources should
        /// have telemetry enabled and how that telemetry data should be collected based on resource
        /// type, telemetry type, and selection criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTelemetryRule service method.</param>
        /// 
        /// <returns>The response from the CreateTelemetryRule service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ConflictException">
        /// The requested operation conflicts with the current state of the specified resource
        /// or with another request.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryRule">REST API Reference for CreateTelemetryRule Operation</seealso>
        CreateTelemetryRuleResponse CreateTelemetryRule(CreateTelemetryRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTelemetryRule operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTelemetryRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryRule">REST API Reference for CreateTelemetryRule Operation</seealso>
        IAsyncResult BeginCreateTelemetryRule(CreateTelemetryRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTelemetryRule.</param>
        /// 
        /// <returns>Returns a  CreateTelemetryRuleResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryRule">REST API Reference for CreateTelemetryRule Operation</seealso>
        CreateTelemetryRuleResponse EndCreateTelemetryRule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTelemetryRuleForOrganization


        /// <summary>
        /// Creates a telemetry rule that applies across an Amazon Web Services Organization.
        /// This operation can only be called by the organization's management account or a delegated
        /// administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTelemetryRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the CreateTelemetryRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ConflictException">
        /// The requested operation conflicts with the current state of the specified resource
        /// or with another request.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryRuleForOrganization">REST API Reference for CreateTelemetryRuleForOrganization Operation</seealso>
        CreateTelemetryRuleForOrganizationResponse CreateTelemetryRuleForOrganization(CreateTelemetryRuleForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTelemetryRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTelemetryRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryRuleForOrganization">REST API Reference for CreateTelemetryRuleForOrganization Operation</seealso>
        IAsyncResult BeginCreateTelemetryRuleForOrganization(CreateTelemetryRuleForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTelemetryRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  CreateTelemetryRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryRuleForOrganization">REST API Reference for CreateTelemetryRuleForOrganization Operation</seealso>
        CreateTelemetryRuleForOrganizationResponse EndCreateTelemetryRuleForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCentralizationRuleForOrganization


        /// <summary>
        /// Deletes an organization-wide centralization rule. This operation can only be called
        /// by the organization's management account or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCentralizationRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the DeleteCentralizationRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteCentralizationRuleForOrganization">REST API Reference for DeleteCentralizationRuleForOrganization Operation</seealso>
        DeleteCentralizationRuleForOrganizationResponse DeleteCentralizationRuleForOrganization(DeleteCentralizationRuleForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCentralizationRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCentralizationRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteCentralizationRuleForOrganization">REST API Reference for DeleteCentralizationRuleForOrganization Operation</seealso>
        IAsyncResult BeginDeleteCentralizationRuleForOrganization(DeleteCentralizationRuleForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCentralizationRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  DeleteCentralizationRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteCentralizationRuleForOrganization">REST API Reference for DeleteCentralizationRuleForOrganization Operation</seealso>
        DeleteCentralizationRuleForOrganizationResponse EndDeleteCentralizationRuleForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTelemetryRule


        /// <summary>
        /// Deletes a telemetry rule from your account. Any telemetry configurations previously
        /// created by the rule will remain but no new resources will be configured by this rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTelemetryRule service method.</param>
        /// 
        /// <returns>The response from the DeleteTelemetryRule service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryRule">REST API Reference for DeleteTelemetryRule Operation</seealso>
        DeleteTelemetryRuleResponse DeleteTelemetryRule(DeleteTelemetryRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTelemetryRule operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTelemetryRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryRule">REST API Reference for DeleteTelemetryRule Operation</seealso>
        IAsyncResult BeginDeleteTelemetryRule(DeleteTelemetryRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTelemetryRule.</param>
        /// 
        /// <returns>Returns a  DeleteTelemetryRuleResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryRule">REST API Reference for DeleteTelemetryRule Operation</seealso>
        DeleteTelemetryRuleResponse EndDeleteTelemetryRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTelemetryRuleForOrganization


        /// <summary>
        /// Deletes an organization-wide telemetry rule. This operation can only be called by
        /// the organization's management account or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTelemetryRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the DeleteTelemetryRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryRuleForOrganization">REST API Reference for DeleteTelemetryRuleForOrganization Operation</seealso>
        DeleteTelemetryRuleForOrganizationResponse DeleteTelemetryRuleForOrganization(DeleteTelemetryRuleForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTelemetryRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTelemetryRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryRuleForOrganization">REST API Reference for DeleteTelemetryRuleForOrganization Operation</seealso>
        IAsyncResult BeginDeleteTelemetryRuleForOrganization(DeleteTelemetryRuleForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTelemetryRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  DeleteTelemetryRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryRuleForOrganization">REST API Reference for DeleteTelemetryRuleForOrganization Operation</seealso>
        DeleteTelemetryRuleForOrganizationResponse EndDeleteTelemetryRuleForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCentralizationRuleForOrganization


        /// <summary>
        /// Retrieves the details of a specific organization centralization rule. This operation
        /// can only be called by the organization's management account or a delegated administrator
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCentralizationRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the GetCentralizationRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetCentralizationRuleForOrganization">REST API Reference for GetCentralizationRuleForOrganization Operation</seealso>
        GetCentralizationRuleForOrganizationResponse GetCentralizationRuleForOrganization(GetCentralizationRuleForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCentralizationRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCentralizationRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetCentralizationRuleForOrganization">REST API Reference for GetCentralizationRuleForOrganization Operation</seealso>
        IAsyncResult BeginGetCentralizationRuleForOrganization(GetCentralizationRuleForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCentralizationRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  GetCentralizationRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetCentralizationRuleForOrganization">REST API Reference for GetCentralizationRuleForOrganization Operation</seealso>
        GetCentralizationRuleForOrganizationResponse EndGetCentralizationRuleForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTelemetryEnrichmentStatus


        /// <summary>
        /// Returns the current status of the resource tags for telemetry feature, which enhances
        /// telemetry data with additional resource metadata from Amazon Web Services Resource
        /// Explorer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEnrichmentStatus service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryEnrichmentStatus service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEnrichmentStatus">REST API Reference for GetTelemetryEnrichmentStatus Operation</seealso>
        GetTelemetryEnrichmentStatusResponse GetTelemetryEnrichmentStatus(GetTelemetryEnrichmentStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryEnrichmentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEnrichmentStatus operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTelemetryEnrichmentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEnrichmentStatus">REST API Reference for GetTelemetryEnrichmentStatus Operation</seealso>
        IAsyncResult BeginGetTelemetryEnrichmentStatus(GetTelemetryEnrichmentStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTelemetryEnrichmentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTelemetryEnrichmentStatus.</param>
        /// 
        /// <returns>Returns a  GetTelemetryEnrichmentStatusResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEnrichmentStatus">REST API Reference for GetTelemetryEnrichmentStatus Operation</seealso>
        GetTelemetryEnrichmentStatusResponse EndGetTelemetryEnrichmentStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTelemetryEvaluationStatus


        /// <summary>
        /// Returns the current onboarding status of the telemetry config feature, including
        /// the status of the feature and reason the feature failed to start or stop.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEvaluationStatus service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryEvaluationStatus service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatus">REST API Reference for GetTelemetryEvaluationStatus Operation</seealso>
        GetTelemetryEvaluationStatusResponse GetTelemetryEvaluationStatus(GetTelemetryEvaluationStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryEvaluationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEvaluationStatus operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTelemetryEvaluationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatus">REST API Reference for GetTelemetryEvaluationStatus Operation</seealso>
        IAsyncResult BeginGetTelemetryEvaluationStatus(GetTelemetryEvaluationStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTelemetryEvaluationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTelemetryEvaluationStatus.</param>
        /// 
        /// <returns>Returns a  GetTelemetryEvaluationStatusResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatus">REST API Reference for GetTelemetryEvaluationStatus Operation</seealso>
        GetTelemetryEvaluationStatusResponse EndGetTelemetryEvaluationStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTelemetryEvaluationStatusForOrganization


        /// <summary>
        /// This returns the onboarding status of the telemetry configuration feature for the
        /// organization. It can only be called by a Management Account of an Amazon Web Services
        /// Organization or an assigned Delegated Admin Account of Amazon CloudWatch telemetry
        /// config.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEvaluationStatusForOrganization service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryEvaluationStatusForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatusForOrganization">REST API Reference for GetTelemetryEvaluationStatusForOrganization Operation</seealso>
        GetTelemetryEvaluationStatusForOrganizationResponse GetTelemetryEvaluationStatusForOrganization(GetTelemetryEvaluationStatusForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryEvaluationStatusForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEvaluationStatusForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTelemetryEvaluationStatusForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatusForOrganization">REST API Reference for GetTelemetryEvaluationStatusForOrganization Operation</seealso>
        IAsyncResult BeginGetTelemetryEvaluationStatusForOrganization(GetTelemetryEvaluationStatusForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTelemetryEvaluationStatusForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTelemetryEvaluationStatusForOrganization.</param>
        /// 
        /// <returns>Returns a  GetTelemetryEvaluationStatusForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatusForOrganization">REST API Reference for GetTelemetryEvaluationStatusForOrganization Operation</seealso>
        GetTelemetryEvaluationStatusForOrganizationResponse EndGetTelemetryEvaluationStatusForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTelemetryRule


        /// <summary>
        /// Retrieves the details of a specific telemetry rule in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryRule service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryRule service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryRule">REST API Reference for GetTelemetryRule Operation</seealso>
        GetTelemetryRuleResponse GetTelemetryRule(GetTelemetryRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryRule operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTelemetryRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryRule">REST API Reference for GetTelemetryRule Operation</seealso>
        IAsyncResult BeginGetTelemetryRule(GetTelemetryRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTelemetryRule.</param>
        /// 
        /// <returns>Returns a  GetTelemetryRuleResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryRule">REST API Reference for GetTelemetryRule Operation</seealso>
        GetTelemetryRuleResponse EndGetTelemetryRule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTelemetryRuleForOrganization


        /// <summary>
        /// Retrieves the details of a specific organization telemetry rule. This operation can
        /// only be called by the organization's management account or a delegated administrator
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the GetTelemetryRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryRuleForOrganization">REST API Reference for GetTelemetryRuleForOrganization Operation</seealso>
        GetTelemetryRuleForOrganizationResponse GetTelemetryRuleForOrganization(GetTelemetryRuleForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTelemetryRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryRuleForOrganization">REST API Reference for GetTelemetryRuleForOrganization Operation</seealso>
        IAsyncResult BeginGetTelemetryRuleForOrganization(GetTelemetryRuleForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTelemetryRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  GetTelemetryRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryRuleForOrganization">REST API Reference for GetTelemetryRuleForOrganization Operation</seealso>
        GetTelemetryRuleForOrganizationResponse EndGetTelemetryRuleForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCentralizationRulesForOrganization


        /// <summary>
        /// Lists all centralization rules in your organization. This operation can only be called
        /// by the organization's management account or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCentralizationRulesForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListCentralizationRulesForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListCentralizationRulesForOrganization">REST API Reference for ListCentralizationRulesForOrganization Operation</seealso>
        ListCentralizationRulesForOrganizationResponse ListCentralizationRulesForOrganization(ListCentralizationRulesForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCentralizationRulesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCentralizationRulesForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCentralizationRulesForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListCentralizationRulesForOrganization">REST API Reference for ListCentralizationRulesForOrganization Operation</seealso>
        IAsyncResult BeginListCentralizationRulesForOrganization(ListCentralizationRulesForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCentralizationRulesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCentralizationRulesForOrganization.</param>
        /// 
        /// <returns>Returns a  ListCentralizationRulesForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListCentralizationRulesForOrganization">REST API Reference for ListCentralizationRulesForOrganization Operation</seealso>
        ListCentralizationRulesForOrganizationResponse EndListCentralizationRulesForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceTelemetry


        /// <summary>
        /// Returns a list of telemetry configurations for Amazon Web Services resources supported
        /// by telemetry config. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/telemetry-config-cloudwatch.html">Auditing
        /// CloudWatch telemetry configurations</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTelemetry service method.</param>
        /// 
        /// <returns>The response from the ListResourceTelemetry service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetry">REST API Reference for ListResourceTelemetry Operation</seealso>
        ListResourceTelemetryResponse ListResourceTelemetry(ListResourceTelemetryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceTelemetry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTelemetry operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceTelemetry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetry">REST API Reference for ListResourceTelemetry Operation</seealso>
        IAsyncResult BeginListResourceTelemetry(ListResourceTelemetryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceTelemetry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceTelemetry.</param>
        /// 
        /// <returns>Returns a  ListResourceTelemetryResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetry">REST API Reference for ListResourceTelemetry Operation</seealso>
        ListResourceTelemetryResponse EndListResourceTelemetry(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceTelemetryForOrganization


        /// <summary>
        /// Returns a list of telemetry configurations for Amazon Web Services resources supported
        /// by telemetry config in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTelemetryForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListResourceTelemetryForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetryForOrganization">REST API Reference for ListResourceTelemetryForOrganization Operation</seealso>
        ListResourceTelemetryForOrganizationResponse ListResourceTelemetryForOrganization(ListResourceTelemetryForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceTelemetryForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTelemetryForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceTelemetryForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetryForOrganization">REST API Reference for ListResourceTelemetryForOrganization Operation</seealso>
        IAsyncResult BeginListResourceTelemetryForOrganization(ListResourceTelemetryForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceTelemetryForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceTelemetryForOrganization.</param>
        /// 
        /// <returns>Returns a  ListResourceTelemetryForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetryForOrganization">REST API Reference for ListResourceTelemetryForOrganization Operation</seealso>
        ListResourceTelemetryForOrganizationResponse EndListResourceTelemetryForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags attached to the specified telemetry rule resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTelemetryRules


        /// <summary>
        /// Lists all telemetry rules in your account. You can filter the results by specifying
        /// a rule name prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryRules service method.</param>
        /// 
        /// <returns>The response from the ListTelemetryRules service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryRules">REST API Reference for ListTelemetryRules Operation</seealso>
        ListTelemetryRulesResponse ListTelemetryRules(ListTelemetryRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTelemetryRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryRules operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTelemetryRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryRules">REST API Reference for ListTelemetryRules Operation</seealso>
        IAsyncResult BeginListTelemetryRules(ListTelemetryRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTelemetryRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTelemetryRules.</param>
        /// 
        /// <returns>Returns a  ListTelemetryRulesResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryRules">REST API Reference for ListTelemetryRules Operation</seealso>
        ListTelemetryRulesResponse EndListTelemetryRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTelemetryRulesForOrganization


        /// <summary>
        /// Lists all telemetry rules in your organization. This operation can only be called
        /// by the organization's management account or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryRulesForOrganization service method.</param>
        /// 
        /// <returns>The response from the ListTelemetryRulesForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryRulesForOrganization">REST API Reference for ListTelemetryRulesForOrganization Operation</seealso>
        ListTelemetryRulesForOrganizationResponse ListTelemetryRulesForOrganization(ListTelemetryRulesForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTelemetryRulesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryRulesForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTelemetryRulesForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryRulesForOrganization">REST API Reference for ListTelemetryRulesForOrganization Operation</seealso>
        IAsyncResult BeginListTelemetryRulesForOrganization(ListTelemetryRulesForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTelemetryRulesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTelemetryRulesForOrganization.</param>
        /// 
        /// <returns>Returns a  ListTelemetryRulesForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryRulesForOrganization">REST API Reference for ListTelemetryRulesForOrganization Operation</seealso>
        ListTelemetryRulesForOrganizationResponse EndListTelemetryRulesForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  StartTelemetryEnrichment


        /// <summary>
        /// Enables the resource tags for telemetry feature for your account, which enhances
        /// telemetry data with additional resource metadata from Amazon Web Services Resource
        /// Explorer to provide richer context for monitoring and observability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEnrichment service method.</param>
        /// 
        /// <returns>The response from the StartTelemetryEnrichment service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ConflictException">
        /// The requested operation conflicts with the current state of the specified resource
        /// or with another request.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEnrichment">REST API Reference for StartTelemetryEnrichment Operation</seealso>
        StartTelemetryEnrichmentResponse StartTelemetryEnrichment(StartTelemetryEnrichmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartTelemetryEnrichment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEnrichment operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTelemetryEnrichment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEnrichment">REST API Reference for StartTelemetryEnrichment Operation</seealso>
        IAsyncResult BeginStartTelemetryEnrichment(StartTelemetryEnrichmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartTelemetryEnrichment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTelemetryEnrichment.</param>
        /// 
        /// <returns>Returns a  StartTelemetryEnrichmentResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEnrichment">REST API Reference for StartTelemetryEnrichment Operation</seealso>
        StartTelemetryEnrichmentResponse EndStartTelemetryEnrichment(IAsyncResult asyncResult);

        #endregion
        
        #region  StartTelemetryEvaluation


        /// <summary>
        /// This action begins onboarding the caller Amazon Web Services account to the telemetry
        /// config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEvaluation service method.</param>
        /// 
        /// <returns>The response from the StartTelemetryEvaluation service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluation">REST API Reference for StartTelemetryEvaluation Operation</seealso>
        StartTelemetryEvaluationResponse StartTelemetryEvaluation(StartTelemetryEvaluationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartTelemetryEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEvaluation operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTelemetryEvaluation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluation">REST API Reference for StartTelemetryEvaluation Operation</seealso>
        IAsyncResult BeginStartTelemetryEvaluation(StartTelemetryEvaluationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartTelemetryEvaluation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTelemetryEvaluation.</param>
        /// 
        /// <returns>Returns a  StartTelemetryEvaluationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluation">REST API Reference for StartTelemetryEvaluation Operation</seealso>
        StartTelemetryEvaluationResponse EndStartTelemetryEvaluation(IAsyncResult asyncResult);

        #endregion
        
        #region  StartTelemetryEvaluationForOrganization


        /// <summary>
        /// This actions begins onboarding the organization and all member accounts to the telemetry
        /// config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEvaluationForOrganization service method.</param>
        /// 
        /// <returns>The response from the StartTelemetryEvaluationForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluationForOrganization">REST API Reference for StartTelemetryEvaluationForOrganization Operation</seealso>
        StartTelemetryEvaluationForOrganizationResponse StartTelemetryEvaluationForOrganization(StartTelemetryEvaluationForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartTelemetryEvaluationForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEvaluationForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTelemetryEvaluationForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluationForOrganization">REST API Reference for StartTelemetryEvaluationForOrganization Operation</seealso>
        IAsyncResult BeginStartTelemetryEvaluationForOrganization(StartTelemetryEvaluationForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartTelemetryEvaluationForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTelemetryEvaluationForOrganization.</param>
        /// 
        /// <returns>Returns a  StartTelemetryEvaluationForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluationForOrganization">REST API Reference for StartTelemetryEvaluationForOrganization Operation</seealso>
        StartTelemetryEvaluationForOrganizationResponse EndStartTelemetryEvaluationForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  StopTelemetryEnrichment


        /// <summary>
        /// Disables the resource tags for telemetry feature for your account, stopping the enhancement
        /// of telemetry data with additional resource metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEnrichment service method.</param>
        /// 
        /// <returns>The response from the StopTelemetryEnrichment service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ConflictException">
        /// The requested operation conflicts with the current state of the specified resource
        /// or with another request.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEnrichment">REST API Reference for StopTelemetryEnrichment Operation</seealso>
        StopTelemetryEnrichmentResponse StopTelemetryEnrichment(StopTelemetryEnrichmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopTelemetryEnrichment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEnrichment operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTelemetryEnrichment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEnrichment">REST API Reference for StopTelemetryEnrichment Operation</seealso>
        IAsyncResult BeginStopTelemetryEnrichment(StopTelemetryEnrichmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopTelemetryEnrichment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTelemetryEnrichment.</param>
        /// 
        /// <returns>Returns a  StopTelemetryEnrichmentResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEnrichment">REST API Reference for StopTelemetryEnrichment Operation</seealso>
        StopTelemetryEnrichmentResponse EndStopTelemetryEnrichment(IAsyncResult asyncResult);

        #endregion
        
        #region  StopTelemetryEvaluation


        /// <summary>
        /// This action begins offboarding the caller Amazon Web Services account from the telemetry
        /// config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEvaluation service method.</param>
        /// 
        /// <returns>The response from the StopTelemetryEvaluation service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluation">REST API Reference for StopTelemetryEvaluation Operation</seealso>
        StopTelemetryEvaluationResponse StopTelemetryEvaluation(StopTelemetryEvaluationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopTelemetryEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEvaluation operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTelemetryEvaluation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluation">REST API Reference for StopTelemetryEvaluation Operation</seealso>
        IAsyncResult BeginStopTelemetryEvaluation(StopTelemetryEvaluationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopTelemetryEvaluation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTelemetryEvaluation.</param>
        /// 
        /// <returns>Returns a  StopTelemetryEvaluationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluation">REST API Reference for StopTelemetryEvaluation Operation</seealso>
        StopTelemetryEvaluationResponse EndStopTelemetryEvaluation(IAsyncResult asyncResult);

        #endregion
        
        #region  StopTelemetryEvaluationForOrganization


        /// <summary>
        /// This action offboards the Organization of the caller Amazon Web Services account
        /// from the telemetry config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEvaluationForOrganization service method.</param>
        /// 
        /// <returns>The response from the StopTelemetryEvaluationForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluationForOrganization">REST API Reference for StopTelemetryEvaluationForOrganization Operation</seealso>
        StopTelemetryEvaluationForOrganizationResponse StopTelemetryEvaluationForOrganization(StopTelemetryEvaluationForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopTelemetryEvaluationForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEvaluationForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTelemetryEvaluationForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluationForOrganization">REST API Reference for StopTelemetryEvaluationForOrganization Operation</seealso>
        IAsyncResult BeginStopTelemetryEvaluationForOrganization(StopTelemetryEvaluationForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopTelemetryEvaluationForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTelemetryEvaluationForOrganization.</param>
        /// 
        /// <returns>Returns a  StopTelemetryEvaluationForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluationForOrganization">REST API Reference for StopTelemetryEvaluationForOrganization Operation</seealso>
        StopTelemetryEvaluationForOrganizationResponse EndStopTelemetryEvaluationForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates tags for a telemetry rule resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a telemetry rule resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCentralizationRuleForOrganization


        /// <summary>
        /// Updates an existing centralization rule that applies across an Amazon Web Services
        /// Organization. This operation can only be called by the organization's management account
        /// or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCentralizationRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the UpdateCentralizationRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateCentralizationRuleForOrganization">REST API Reference for UpdateCentralizationRuleForOrganization Operation</seealso>
        UpdateCentralizationRuleForOrganizationResponse UpdateCentralizationRuleForOrganization(UpdateCentralizationRuleForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCentralizationRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCentralizationRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateCentralizationRuleForOrganization">REST API Reference for UpdateCentralizationRuleForOrganization Operation</seealso>
        IAsyncResult BeginUpdateCentralizationRuleForOrganization(UpdateCentralizationRuleForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCentralizationRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCentralizationRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  UpdateCentralizationRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateCentralizationRuleForOrganization">REST API Reference for UpdateCentralizationRuleForOrganization Operation</seealso>
        UpdateCentralizationRuleForOrganizationResponse EndUpdateCentralizationRuleForOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTelemetryRule


        /// <summary>
        /// Updates an existing telemetry rule in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTelemetryRule service method.</param>
        /// 
        /// <returns>The response from the UpdateTelemetryRule service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryRule">REST API Reference for UpdateTelemetryRule Operation</seealso>
        UpdateTelemetryRuleResponse UpdateTelemetryRule(UpdateTelemetryRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTelemetryRule operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTelemetryRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryRule">REST API Reference for UpdateTelemetryRule Operation</seealso>
        IAsyncResult BeginUpdateTelemetryRule(UpdateTelemetryRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTelemetryRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTelemetryRule.</param>
        /// 
        /// <returns>Returns a  UpdateTelemetryRuleResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryRule">REST API Reference for UpdateTelemetryRule Operation</seealso>
        UpdateTelemetryRuleResponse EndUpdateTelemetryRule(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTelemetryRuleForOrganization


        /// <summary>
        /// Updates an existing telemetry rule that applies across an Amazon Web Services Organization.
        /// This operation can only be called by the organization's management account or a delegated
        /// administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTelemetryRuleForOrganization service method.</param>
        /// 
        /// <returns>The response from the UpdateTelemetryRuleForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for Amazon Web Services resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ServiceQuotaExceededException">
        /// The requested operation would exceed the allowed quota for the specified resource
        /// type.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryRuleForOrganization">REST API Reference for UpdateTelemetryRuleForOrganization Operation</seealso>
        UpdateTelemetryRuleForOrganizationResponse UpdateTelemetryRuleForOrganization(UpdateTelemetryRuleForOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTelemetryRuleForOrganization operation on AmazonObservabilityAdminClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTelemetryRuleForOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryRuleForOrganization">REST API Reference for UpdateTelemetryRuleForOrganization Operation</seealso>
        IAsyncResult BeginUpdateTelemetryRuleForOrganization(UpdateTelemetryRuleForOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTelemetryRuleForOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTelemetryRuleForOrganization.</param>
        /// 
        /// <returns>Returns a  UpdateTelemetryRuleForOrganizationResult from ObservabilityAdmin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryRuleForOrganization">REST API Reference for UpdateTelemetryRuleForOrganization Operation</seealso>
        UpdateTelemetryRuleForOrganizationResponse EndUpdateTelemetryRuleForOrganization(IAsyncResult asyncResult);

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