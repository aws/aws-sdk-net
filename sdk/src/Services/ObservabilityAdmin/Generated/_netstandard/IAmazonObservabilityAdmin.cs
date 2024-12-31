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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ObservabilityAdmin.Model;

#pragma warning disable CS1570
namespace Amazon.ObservabilityAdmin
{
    /// <summary>
    /// <para>Interface for accessing ObservabilityAdmin</para>
    ///
    /// Amazon CloudWatch Obsersavability Admin to control temletry config for your AWS Organization
    /// or account. Telemetry config conﬁg to discover and understand the state of telemetry
    /// conﬁguration for your AWS resources from a central view in the CloudWatch console.
    /// Telemetry conﬁg simpliﬁes the process of auditing your telemetry collection conﬁgurations
    /// across multiple resource types across your AWS Organization or account. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/telemetry-config-cloudwatch.html">Auditing
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
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IObservabilityAdminPaginatorFactory Paginators { get; }
#endif
                
        #region  GetTelemetryEvaluationStatus



        /// <summary>
        /// Returns the current onboarding status of the telemetry config feature, including
        /// the status of the feature and reason the feature failed to start or stop.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEvaluationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTelemetryEvaluationStatus service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatus">REST API Reference for GetTelemetryEvaluationStatus Operation</seealso>
        Task<GetTelemetryEvaluationStatusResponse> GetTelemetryEvaluationStatusAsync(GetTelemetryEvaluationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTelemetryEvaluationStatusForOrganization



        /// <summary>
        /// This returns the onboarding status of the telemetry configuration feature for the
        /// organization. It can only be called by a Management Account of an AWS Organization
        /// or an assigned Delegated Admin Account of AWS CloudWatch telemetry config.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEvaluationStatusForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTelemetryEvaluationStatusForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryEvaluationStatusForOrganization">REST API Reference for GetTelemetryEvaluationStatusForOrganization Operation</seealso>
        Task<GetTelemetryEvaluationStatusForOrganizationResponse> GetTelemetryEvaluationStatusForOrganizationAsync(GetTelemetryEvaluationStatusForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourceTelemetry



        /// <summary>
        /// Returns a list of telemetry configurations for AWS resources supported by telemetry
        /// config. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/telemetry-config-cloudwatch.html">Auditing
        /// CloudWatch telemetry configurations</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTelemetry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceTelemetry service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetry">REST API Reference for ListResourceTelemetry Operation</seealso>
        Task<ListResourceTelemetryResponse> ListResourceTelemetryAsync(ListResourceTelemetryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourceTelemetryForOrganization



        /// <summary>
        /// Returns a list of telemetry configurations for AWS resources supported by telemetry
        /// config in the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTelemetryForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceTelemetryForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListResourceTelemetryForOrganization">REST API Reference for ListResourceTelemetryForOrganization Operation</seealso>
        Task<ListResourceTelemetryForOrganizationResponse> ListResourceTelemetryForOrganizationAsync(ListResourceTelemetryForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartTelemetryEvaluation



        /// <summary>
        /// This action begins onboarding onboarding the caller AWS account to the telemetry
        /// config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEvaluation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTelemetryEvaluation service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluation">REST API Reference for StartTelemetryEvaluation Operation</seealso>
        Task<StartTelemetryEvaluationResponse> StartTelemetryEvaluationAsync(StartTelemetryEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartTelemetryEvaluationForOrganization



        /// <summary>
        /// This actions begins onboarding the organization and all member accounts to the telemetry
        /// config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEvaluationForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTelemetryEvaluationForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StartTelemetryEvaluationForOrganization">REST API Reference for StartTelemetryEvaluationForOrganization Operation</seealso>
        Task<StartTelemetryEvaluationForOrganizationResponse> StartTelemetryEvaluationForOrganizationAsync(StartTelemetryEvaluationForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopTelemetryEvaluation



        /// <summary>
        /// This action begins offboarding the caller AWS account from the telemetry config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEvaluation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTelemetryEvaluation service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluation">REST API Reference for StopTelemetryEvaluation Operation</seealso>
        Task<StopTelemetryEvaluationResponse> StopTelemetryEvaluationAsync(StopTelemetryEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopTelemetryEvaluationForOrganization



        /// <summary>
        /// This action offboards the Organization of the caller AWS account from thef telemetry
        /// config feature.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEvaluationForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTelemetryEvaluationForOrganization service method, as returned by ObservabilityAdmin.</returns>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.AccessDeniedException">
        /// Indicates you don't have permissions to perform the requested operation. The user
        /// or role that is making the request must have at least one IAM permissions policy attached
        /// that grants the required permissions. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management for AWS resources</a> in the IAM user guide.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InternalServerException">
        /// Indicates the request has failed to process because of an unknown server error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/StopTelemetryEvaluationForOrganization">REST API Reference for StopTelemetryEvaluationForOrganization Operation</seealso>
        Task<StopTelemetryEvaluationForOrganizationResponse> StopTelemetryEvaluationForOrganizationAsync(StopTelemetryEvaluationForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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