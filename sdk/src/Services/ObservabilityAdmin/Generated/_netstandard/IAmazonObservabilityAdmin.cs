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
#if AWS_ASYNC_ENUMERABLES_API
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateCentralizationRuleForOrganizationResponse> CreateCentralizationRuleForOrganizationAsync(CreateCentralizationRuleForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateS3TableIntegration



        /// <summary>
        /// Creates an integration between CloudWatch and S3 Tables for analytics. This integration
        /// enables querying CloudWatch telemetry data using analytics engines like Amazon Athena,
        /// Amazon Redshift, and Apache Spark.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateS3TableIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateS3TableIntegration service method, as returned by ObservabilityAdmin.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateS3TableIntegration">REST API Reference for CreateS3TableIntegration Operation</seealso>
        Task<CreateS3TableIntegrationResponse> CreateS3TableIntegrationAsync(CreateS3TableIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTelemetryPipeline



        /// <summary>
        /// Creates a telemetry pipeline for processing and transforming telemetry data. The pipeline
        /// defines how data flows from sources through processors to destinations, enabling data
        /// transformation and delivering capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTelemetryPipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTelemetryPipeline service method, as returned by ObservabilityAdmin.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/CreateTelemetryPipeline">REST API Reference for CreateTelemetryPipeline Operation</seealso>
        Task<CreateTelemetryPipelineResponse> CreateTelemetryPipelineAsync(CreateTelemetryPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTelemetryRule



        /// <summary>
        /// Creates a telemetry rule that defines how telemetry should be configured for Amazon
        /// Web Services resources in your account. The rule specifies which resources should
        /// have telemetry enabled and how that telemetry data should be collected based on resource
        /// type, telemetry type, and selection criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTelemetryRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateTelemetryRuleResponse> CreateTelemetryRuleAsync(CreateTelemetryRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTelemetryRuleForOrganization



        /// <summary>
        /// Creates a telemetry rule that applies across an Amazon Web Services Organization.
        /// This operation can only be called by the organization's management account or a delegated
        /// administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTelemetryRuleForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateTelemetryRuleForOrganizationResponse> CreateTelemetryRuleForOrganizationAsync(CreateTelemetryRuleForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCentralizationRuleForOrganization



        /// <summary>
        /// Deletes an organization-wide centralization rule. This operation can only be called
        /// by the organization's management account or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCentralizationRuleForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteCentralizationRuleForOrganizationResponse> DeleteCentralizationRuleForOrganizationAsync(DeleteCentralizationRuleForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteS3TableIntegration



        /// <summary>
        /// Deletes an S3 Table integration and its associated data. This operation removes the
        /// connection between CloudWatch Observability Admin and S3 Tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteS3TableIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteS3TableIntegration service method, as returned by ObservabilityAdmin.</returns>
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
        /// <exception cref="Amazon.ObservabilityAdmin.Model.InvalidStateException">
        /// The requested operation cannot be completed on the specified resource in the current
        /// state.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteS3TableIntegration">REST API Reference for DeleteS3TableIntegration Operation</seealso>
        Task<DeleteS3TableIntegrationResponse> DeleteS3TableIntegrationAsync(DeleteS3TableIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTelemetryPipeline



        /// <summary>
        /// Deletes a telemetry pipeline and its associated resources. This operation stops data
        /// processing and removes the pipeline configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTelemetryPipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTelemetryPipeline service method, as returned by ObservabilityAdmin.</returns>
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
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ResourceNotFoundException">
        /// The specified resource (such as a telemetry rule) could not be found.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.TooManyRequestsException">
        /// The request throughput limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ObservabilityAdmin.Model.ValidationException">
        /// Indicates input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/DeleteTelemetryPipeline">REST API Reference for DeleteTelemetryPipeline Operation</seealso>
        Task<DeleteTelemetryPipelineResponse> DeleteTelemetryPipelineAsync(DeleteTelemetryPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTelemetryRule



        /// <summary>
        /// Deletes a telemetry rule from your account. Any telemetry configurations previously
        /// created by the rule will remain but no new resources will be configured by this rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTelemetryRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteTelemetryRuleResponse> DeleteTelemetryRuleAsync(DeleteTelemetryRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTelemetryRuleForOrganization



        /// <summary>
        /// Deletes an organization-wide telemetry rule. This operation can only be called by
        /// the organization's management account or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTelemetryRuleForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteTelemetryRuleForOrganizationResponse> DeleteTelemetryRuleForOrganizationAsync(DeleteTelemetryRuleForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCentralizationRuleForOrganization



        /// <summary>
        /// Retrieves the details of a specific organization centralization rule. This operation
        /// can only be called by the organization's management account or a delegated administrator
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCentralizationRuleForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetCentralizationRuleForOrganizationResponse> GetCentralizationRuleForOrganizationAsync(GetCentralizationRuleForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetS3TableIntegration



        /// <summary>
        /// Retrieves information about a specific S3 Table integration, including its configuration,
        /// status, and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetS3TableIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetS3TableIntegration service method, as returned by ObservabilityAdmin.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetS3TableIntegration">REST API Reference for GetS3TableIntegration Operation</seealso>
        Task<GetS3TableIntegrationResponse> GetS3TableIntegrationAsync(GetS3TableIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTelemetryEnrichmentStatus



        /// <summary>
        /// Returns the current status of the resource tags for telemetry feature, which enhances
        /// telemetry data with additional resource metadata from Resource Explorer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryEnrichmentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetTelemetryEnrichmentStatusResponse> GetTelemetryEnrichmentStatusAsync(GetTelemetryEnrichmentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
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
        Task<GetTelemetryEvaluationStatusResponse> GetTelemetryEvaluationStatusAsync(GetTelemetryEvaluationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTelemetryEvaluationStatusForOrganization



        /// <summary>
        /// This returns the onboarding status of the telemetry configuration feature for the
        /// organization. It can only be called by a Management Account of an Amazon Web Services
        /// Organization or an assigned Delegated Admin Account of Amazon CloudWatch telemetry
        /// config.
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
        Task<GetTelemetryEvaluationStatusForOrganizationResponse> GetTelemetryEvaluationStatusForOrganizationAsync(GetTelemetryEvaluationStatusForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTelemetryPipeline



        /// <summary>
        /// Retrieves information about a specific telemetry pipeline, including its configuration,
        /// status, and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryPipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTelemetryPipeline service method, as returned by ObservabilityAdmin.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/GetTelemetryPipeline">REST API Reference for GetTelemetryPipeline Operation</seealso>
        Task<GetTelemetryPipelineResponse> GetTelemetryPipelineAsync(GetTelemetryPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTelemetryRule



        /// <summary>
        /// Retrieves the details of a specific telemetry rule in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetTelemetryRuleResponse> GetTelemetryRuleAsync(GetTelemetryRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTelemetryRuleForOrganization



        /// <summary>
        /// Retrieves the details of a specific organization telemetry rule. This operation can
        /// only be called by the organization's management account or a delegated administrator
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTelemetryRuleForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetTelemetryRuleForOrganizationResponse> GetTelemetryRuleForOrganizationAsync(GetTelemetryRuleForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCentralizationRulesForOrganization



        /// <summary>
        /// Lists all centralization rules in your organization. This operation can only be called
        /// by the organization's management account or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCentralizationRulesForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListCentralizationRulesForOrganizationResponse> ListCentralizationRulesForOrganizationAsync(ListCentralizationRulesForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourceTelemetry



        /// <summary>
        /// Returns a list of telemetry configurations for Amazon Web Services resources supported
        /// by telemetry config. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/telemetry-config-cloudwatch.html">Auditing
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
        Task<ListResourceTelemetryResponse> ListResourceTelemetryAsync(ListResourceTelemetryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourceTelemetryForOrganization



        /// <summary>
        /// Returns a list of telemetry configurations for Amazon Web Services resources supported
        /// by telemetry config in the organization.
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
        Task<ListResourceTelemetryForOrganizationResponse> ListResourceTelemetryForOrganizationAsync(ListResourceTelemetryForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListS3TableIntegrations



        /// <summary>
        /// Lists all S3 Table integrations in your account. We recommend using pagination to
        /// ensure that the operation returns quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListS3TableIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListS3TableIntegrations service method, as returned by ObservabilityAdmin.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListS3TableIntegrations">REST API Reference for ListS3TableIntegrations Operation</seealso>
        Task<ListS3TableIntegrationsResponse> ListS3TableIntegrationsAsync(ListS3TableIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all tags attached to the specified resource. Supports telemetry rule resources
        /// and telemetry pipeline resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTelemetryPipelines



        /// <summary>
        /// Returns a list of telemetry pipelines in your account. Returns up to 100 results.
        /// If more than 100 telemetry pipelines exist, include the <c>NextToken</c> value from
        /// the response to retrieve the next set of results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryPipelines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTelemetryPipelines service method, as returned by ObservabilityAdmin.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ListTelemetryPipelines">REST API Reference for ListTelemetryPipelines Operation</seealso>
        Task<ListTelemetryPipelinesResponse> ListTelemetryPipelinesAsync(ListTelemetryPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTelemetryRules



        /// <summary>
        /// Lists all telemetry rules in your account. You can filter the results by specifying
        /// a rule name prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTelemetryRulesResponse> ListTelemetryRulesAsync(ListTelemetryRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTelemetryRulesForOrganization



        /// <summary>
        /// Lists all telemetry rules in your organization. This operation can only be called
        /// by the organization's management account or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTelemetryRulesForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTelemetryRulesForOrganizationResponse> ListTelemetryRulesForOrganizationAsync(ListTelemetryRulesForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartTelemetryEnrichment



        /// <summary>
        /// Enables the resource tags for telemetry feature for your account, which enhances
        /// telemetry data with additional resource metadata from Resource Explorer to provide
        /// richer context for monitoring and observability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTelemetryEnrichment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartTelemetryEnrichmentResponse> StartTelemetryEnrichmentAsync(StartTelemetryEnrichmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartTelemetryEvaluation



        /// <summary>
        /// This action begins onboarding the caller Amazon Web Services account to the telemetry
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
        Task<StartTelemetryEvaluationForOrganizationResponse> StartTelemetryEvaluationForOrganizationAsync(StartTelemetryEvaluationForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopTelemetryEnrichment



        /// <summary>
        /// Disables the resource tags for telemetry feature for your account, stopping the enhancement
        /// of telemetry data with additional resource metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTelemetryEnrichment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopTelemetryEnrichmentResponse> StopTelemetryEnrichmentAsync(StopTelemetryEnrichmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopTelemetryEvaluation



        /// <summary>
        /// This action begins offboarding the caller Amazon Web Services account from the telemetry
        /// config feature.
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
        Task<StopTelemetryEvaluationResponse> StopTelemetryEvaluationAsync(StopTelemetryEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopTelemetryEvaluationForOrganization



        /// <summary>
        /// This action offboards the Organization of the caller Amazon Web Services account
        /// from the telemetry config feature.
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
        Task<StopTelemetryEvaluationForOrganizationResponse> StopTelemetryEvaluationForOrganizationAsync(StopTelemetryEvaluationForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds or updates tags for a resource. Supports telemetry rule resources and telemetry
        /// pipeline resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TestTelemetryPipeline



        /// <summary>
        /// Tests a pipeline configuration with sample records to validate data processing before
        /// deployment. This operation helps ensure your pipeline configuration works as expected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestTelemetryPipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestTelemetryPipeline service method, as returned by ObservabilityAdmin.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/TestTelemetryPipeline">REST API Reference for TestTelemetryPipeline Operation</seealso>
        Task<TestTelemetryPipelineResponse> TestTelemetryPipelineAsync(TestTelemetryPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a resource. Supports telemetry rule resources and telemetry pipeline
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCentralizationRuleForOrganization



        /// <summary>
        /// Updates an existing centralization rule that applies across an Amazon Web Services
        /// Organization. This operation can only be called by the organization's management account
        /// or a delegated administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCentralizationRuleForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateCentralizationRuleForOrganizationResponse> UpdateCentralizationRuleForOrganizationAsync(UpdateCentralizationRuleForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTelemetryPipeline



        /// <summary>
        /// Updates the configuration of an existing telemetry pipeline.
        /// 
        ///  <note> 
        /// <para>
        /// The following attributes cannot be updated after pipeline creation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Pipeline name</b> - The pipeline name is immutable
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Pipeline ARN</b> - The ARN is automatically generated and cannot be changed
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Source type</b> - Once a pipeline is created with a specific source type (such
        /// as S3, CloudWatch Logs, GitHub, or third-party sources), it cannot be changed to a
        /// different source type
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Processors can be added, removed, or modified. However, some processors are not supported
        /// for third-party pipelines and cannot be added through updates.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Source-Specific Update Rules</b> 
        /// </para>
        ///  <dl> <dt>CloudWatch Logs Sources (Vended and Custom)</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> <c>sts_role_arn</c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Fixed:</b> <c>data_source_name</c>, <c>data_source_type</c>, sink (must remain
        /// <c>@original</c>)
        /// </para>
        ///  </dd> <dt>S3 Sources (Crowdstrike, Zscaler, SentinelOne, Custom)</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> All SQS configuration parameters, <c>sts_role_arn</c>, codec settings,
        /// compression type, bucket ownership settings, sink log group
        /// </para>
        ///  
        /// <para>
        ///  <b>Fixed:</b> <c>notification_type</c>, <c>aws.region</c> 
        /// </para>
        ///  </dd> <dt>GitHub Audit Logs</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>scope</c>
        /// (can switch between ORGANIZATION/ENTERPRISE), <c>organization</c> or <c>enterprise</c>
        /// name, <c>range</c>, authentication credentials (PAT or GitHub App)
        /// </para>
        ///  </dd> <dt>Microsoft Sources (Entra ID, Office365, Windows)</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>tenant_id</c>,
        /// <c>workspace_id</c> (Windows only), OAuth2 credentials (<c>client_id</c>, <c>client_secret</c>)
        /// </para>
        ///  </dd> <dt>Okta Sources (SSO, Auth0)</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>domain</c>,
        /// <c>range</c> (SSO only), OAuth2 credentials (<c>client_id</c>, <c>client_secret</c>)
        /// </para>
        ///  </dd> <dt>Palo Alto Networks</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>hostname</c>,
        /// basic authentication credentials (<c>username</c>, <c>password</c>)
        /// </para>
        ///  </dd> <dt>ServiceNow CMDB</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>instance_url</c>,
        /// <c>range</c>, OAuth2 credentials (<c>client_id</c>, <c>client_secret</c>)
        /// </para>
        ///  </dd> <dt>Wiz CNAPP</dt> <dd> 
        /// <para>
        ///  <b>Updatable:</b> All Amazon Web Services Secrets Manager attributes, <c>region</c>,
        /// <c>range</c>, OAuth2 credentials (<c>client_id</c>, <c>client_secret</c>)
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTelemetryPipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTelemetryPipeline service method, as returned by ObservabilityAdmin.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/UpdateTelemetryPipeline">REST API Reference for UpdateTelemetryPipeline Operation</seealso>
        Task<UpdateTelemetryPipelineResponse> UpdateTelemetryPipelineAsync(UpdateTelemetryPipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTelemetryRule



        /// <summary>
        /// Updates an existing telemetry rule in your account. If multiple users attempt to
        /// modify the same telemetry rule simultaneously, a ConflictException is returned to
        /// provide specific error information for concurrent modification scenarios.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTelemetryRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTelemetryRule service method, as returned by ObservabilityAdmin.</returns>
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
        Task<UpdateTelemetryRuleResponse> UpdateTelemetryRuleAsync(UpdateTelemetryRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTelemetryRuleForOrganization



        /// <summary>
        /// Updates an existing telemetry rule that applies across an Amazon Web Services Organization.
        /// This operation can only be called by the organization's management account or a delegated
        /// administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTelemetryRuleForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateTelemetryRuleForOrganizationResponse> UpdateTelemetryRuleForOrganizationAsync(UpdateTelemetryRuleForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ValidateTelemetryPipelineConfiguration



        /// <summary>
        /// Validates a pipeline configuration without creating the pipeline. This operation checks
        /// the configuration for syntax errors and compatibility issues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateTelemetryPipelineConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateTelemetryPipelineConfiguration service method, as returned by ObservabilityAdmin.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/observabilityadmin-2018-05-10/ValidateTelemetryPipelineConfiguration">REST API Reference for ValidateTelemetryPipelineConfiguration Operation</seealso>
        Task<ValidateTelemetryPipelineConfigurationResponse> ValidateTelemetryPipelineConfigurationAsync(ValidateTelemetryPipelineConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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