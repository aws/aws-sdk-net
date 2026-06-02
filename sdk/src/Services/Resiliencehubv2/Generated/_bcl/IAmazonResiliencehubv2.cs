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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Resiliencehubv2.Model;

#pragma warning disable CS1570
namespace Amazon.Resiliencehubv2
{
    /// <summary>
    /// <para>Interface for accessing Resiliencehubv2</para>
    ///
    /// The next generation of AWS Resilience Hub is the single location in AWS where you
    /// assess and improve the resilience of your critical applications. It helps Site Reliability
    /// Engineers (SREs) and development teams proactively reason about resilience at scale
    /// — identifying failure modes, discovering hidden dependencies, and report on progress
    /// across the enterprise.
    /// </summary>
    public partial interface IAmazonResiliencehubv2 : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IResiliencehubv2PaginatorFactory Paginators { get; }

        
        #region  CreateAssertion


        /// <summary>
        /// Creates a resilience assertion for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssertion service method.</param>
        /// 
        /// <returns>The response from the CreateAssertion service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateAssertion">REST API Reference for CreateAssertion Operation</seealso>
        CreateAssertionResponse CreateAssertion(CreateAssertionRequest request);



        /// <summary>
        /// Creates a resilience assertion for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssertion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssertion service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateAssertion">REST API Reference for CreateAssertion Operation</seealso>
        Task<CreateAssertionResponse> CreateAssertionAsync(CreateAssertionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateInputSource


        /// <summary>
        /// Creates an input source for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInputSource service method.</param>
        /// 
        /// <returns>The response from the CreateInputSource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateInputSource">REST API Reference for CreateInputSource Operation</seealso>
        CreateInputSourceResponse CreateInputSource(CreateInputSourceRequest request);



        /// <summary>
        /// Creates an input source for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInputSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInputSource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateInputSource">REST API Reference for CreateInputSource Operation</seealso>
        Task<CreateInputSourceResponse> CreateInputSourceAsync(CreateInputSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePolicy


        /// <summary>
        /// Creates a resilience policy that defines availability and disaster recovery requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        CreatePolicyResponse CreatePolicy(CreatePolicyRequest request);



        /// <summary>
        /// Creates a resilience policy that defines availability and disaster recovery requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateReport


        /// <summary>
        /// On-demand report creation. Idempotent — duplicate requests with same clientToken return
        /// existing result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReport service method.</param>
        /// 
        /// <returns>The response from the CreateReport service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateReport">REST API Reference for CreateReport Operation</seealso>
        CreateReportResponse CreateReport(CreateReportRequest request);



        /// <summary>
        /// On-demand report creation. Idempotent — duplicate requests with same clientToken return
        /// existing result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateReport service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateReport">REST API Reference for CreateReport Operation</seealso>
        Task<CreateReportResponse> CreateReportAsync(CreateReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateService


        /// <summary>
        /// Creates a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateService">REST API Reference for CreateService Operation</seealso>
        CreateServiceResponse CreateService(CreateServiceRequest request);



        /// <summary>
        /// Creates a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateService">REST API Reference for CreateService Operation</seealso>
        Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateServiceFunction


        /// <summary>
        /// Creates a service function within a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceFunction service method.</param>
        /// 
        /// <returns>The response from the CreateServiceFunction service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateServiceFunction">REST API Reference for CreateServiceFunction Operation</seealso>
        CreateServiceFunctionResponse CreateServiceFunction(CreateServiceFunctionRequest request);



        /// <summary>
        /// Creates a service function within a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServiceFunction service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateServiceFunction">REST API Reference for CreateServiceFunction Operation</seealso>
        Task<CreateServiceFunctionResponse> CreateServiceFunctionAsync(CreateServiceFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateServiceFunctionResources


        /// <summary>
        /// Associates resources with a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceFunctionResources service method.</param>
        /// 
        /// <returns>The response from the CreateServiceFunctionResources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateServiceFunctionResources">REST API Reference for CreateServiceFunctionResources Operation</seealso>
        CreateServiceFunctionResourcesResponse CreateServiceFunctionResources(CreateServiceFunctionResourcesRequest request);



        /// <summary>
        /// Associates resources with a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceFunctionResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServiceFunctionResources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateServiceFunctionResources">REST API Reference for CreateServiceFunctionResources Operation</seealso>
        Task<CreateServiceFunctionResourcesResponse> CreateServiceFunctionResourcesAsync(CreateServiceFunctionResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSystem


        /// <summary>
        /// Creates a system that represents a logical grouping of services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSystem service method.</param>
        /// 
        /// <returns>The response from the CreateSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateSystem">REST API Reference for CreateSystem Operation</seealso>
        CreateSystemResponse CreateSystem(CreateSystemRequest request);



        /// <summary>
        /// Creates a system that represents a logical grouping of services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateSystem">REST API Reference for CreateSystem Operation</seealso>
        Task<CreateSystemResponse> CreateSystemAsync(CreateSystemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUserJourney


        /// <summary>
        /// Creates a user journey within a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserJourney service method.</param>
        /// 
        /// <returns>The response from the CreateUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateUserJourney">REST API Reference for CreateUserJourney Operation</seealso>
        CreateUserJourneyResponse CreateUserJourney(CreateUserJourneyRequest request);



        /// <summary>
        /// Creates a user journey within a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserJourney service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/CreateUserJourney">REST API Reference for CreateUserJourney Operation</seealso>
        Task<CreateUserJourneyResponse> CreateUserJourneyAsync(CreateUserJourneyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAssertion


        /// <summary>
        /// Deletes a resilience assertion from a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssertion service method.</param>
        /// 
        /// <returns>The response from the DeleteAssertion service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteAssertion">REST API Reference for DeleteAssertion Operation</seealso>
        DeleteAssertionResponse DeleteAssertion(DeleteAssertionRequest request);



        /// <summary>
        /// Deletes a resilience assertion from a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssertion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssertion service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteAssertion">REST API Reference for DeleteAssertion Operation</seealso>
        Task<DeleteAssertionResponse> DeleteAssertionAsync(DeleteAssertionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteInputSource


        /// <summary>
        /// Deletes an input source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInputSource service method.</param>
        /// 
        /// <returns>The response from the DeleteInputSource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteInputSource">REST API Reference for DeleteInputSource Operation</seealso>
        DeleteInputSourceResponse DeleteInputSource(DeleteInputSourceRequest request);



        /// <summary>
        /// Deletes an input source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInputSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInputSource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteInputSource">REST API Reference for DeleteInputSource Operation</seealso>
        Task<DeleteInputSourceResponse> DeleteInputSourceAsync(DeleteInputSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Deletes a resilience policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        DeletePolicyResponse DeletePolicy(DeletePolicyRequest request);



        /// <summary>
        /// Deletes a resilience policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteService


        /// <summary>
        /// Deletes a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteService">REST API Reference for DeleteService Operation</seealso>
        DeleteServiceResponse DeleteService(DeleteServiceRequest request);



        /// <summary>
        /// Deletes a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteService">REST API Reference for DeleteService Operation</seealso>
        Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteServiceFunction


        /// <summary>
        /// Deletes a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceFunction service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceFunction service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteServiceFunction">REST API Reference for DeleteServiceFunction Operation</seealso>
        DeleteServiceFunctionResponse DeleteServiceFunction(DeleteServiceFunctionRequest request);



        /// <summary>
        /// Deletes a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceFunction service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteServiceFunction">REST API Reference for DeleteServiceFunction Operation</seealso>
        Task<DeleteServiceFunctionResponse> DeleteServiceFunctionAsync(DeleteServiceFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteServiceFunctionResources


        /// <summary>
        /// Removes resources from a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceFunctionResources service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceFunctionResources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteServiceFunctionResources">REST API Reference for DeleteServiceFunctionResources Operation</seealso>
        DeleteServiceFunctionResourcesResponse DeleteServiceFunctionResources(DeleteServiceFunctionResourcesRequest request);



        /// <summary>
        /// Removes resources from a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceFunctionResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceFunctionResources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteServiceFunctionResources">REST API Reference for DeleteServiceFunctionResources Operation</seealso>
        Task<DeleteServiceFunctionResourcesResponse> DeleteServiceFunctionResourcesAsync(DeleteServiceFunctionResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSystem


        /// <summary>
        /// Deletes a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystem service method.</param>
        /// 
        /// <returns>The response from the DeleteSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteSystem">REST API Reference for DeleteSystem Operation</seealso>
        DeleteSystemResponse DeleteSystem(DeleteSystemRequest request);



        /// <summary>
        /// Deletes a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteSystem">REST API Reference for DeleteSystem Operation</seealso>
        Task<DeleteSystemResponse> DeleteSystemAsync(DeleteSystemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserJourney


        /// <summary>
        /// Deletes a user journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserJourney service method.</param>
        /// 
        /// <returns>The response from the DeleteUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteUserJourney">REST API Reference for DeleteUserJourney Operation</seealso>
        DeleteUserJourneyResponse DeleteUserJourney(DeleteUserJourneyRequest request);



        /// <summary>
        /// Deletes a user journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserJourney service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/DeleteUserJourney">REST API Reference for DeleteUserJourney Operation</seealso>
        Task<DeleteUserJourneyResponse> DeleteUserJourneyAsync(DeleteUserJourneyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFailureModeFinding


        /// <summary>
        /// Retrieves a finding by findingId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFailureModeFinding service method.</param>
        /// 
        /// <returns>The response from the GetFailureModeFinding service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetFailureModeFinding">REST API Reference for GetFailureModeFinding Operation</seealso>
        GetFailureModeFindingResponse GetFailureModeFinding(GetFailureModeFindingRequest request);



        /// <summary>
        /// Retrieves a finding by findingId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFailureModeFinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFailureModeFinding service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetFailureModeFinding">REST API Reference for GetFailureModeFinding Operation</seealso>
        Task<GetFailureModeFindingResponse> GetFailureModeFindingAsync(GetFailureModeFindingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Retrieves a resilience policy by ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse GetPolicy(GetPolicyRequest request);



        /// <summary>
        /// Retrieves a resilience policy by ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetService


        /// <summary>
        /// Retrieves a service by ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// 
        /// <returns>The response from the GetService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetService">REST API Reference for GetService Operation</seealso>
        GetServiceResponse GetService(GetServiceRequest request);



        /// <summary>
        /// Retrieves a service by ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetService">REST API Reference for GetService Operation</seealso>
        Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSystem


        /// <summary>
        /// Retrieves a system by ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystem service method.</param>
        /// 
        /// <returns>The response from the GetSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetSystem">REST API Reference for GetSystem Operation</seealso>
        GetSystemResponse GetSystem(GetSystemRequest request);



        /// <summary>
        /// Retrieves a system by ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetSystem">REST API Reference for GetSystem Operation</seealso>
        Task<GetSystemResponse> GetSystemAsync(GetSystemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUserJourney


        /// <summary>
        /// Retrieves a user journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserJourney service method.</param>
        /// 
        /// <returns>The response from the GetUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetUserJourney">REST API Reference for GetUserJourney Operation</seealso>
        GetUserJourneyResponse GetUserJourney(GetUserJourneyRequest request);



        /// <summary>
        /// Retrieves a user journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserJourney service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/GetUserJourney">REST API Reference for GetUserJourney Operation</seealso>
        Task<GetUserJourneyResponse> GetUserJourneyAsync(GetUserJourneyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportApp


        /// <summary>
        /// Imports a V1 app into the V2 resource model, creating a service with the same name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApp service method.</param>
        /// 
        /// <returns>The response from the ImportApp service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ImportApp">REST API Reference for ImportApp Operation</seealso>
        ImportAppResponse ImportApp(ImportAppRequest request);



        /// <summary>
        /// Imports a V1 app into the V2 resource model, creating a service with the same name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportApp service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ImportApp">REST API Reference for ImportApp Operation</seealso>
        Task<ImportAppResponse> ImportAppAsync(ImportAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportPolicy


        /// <summary>
        /// Imports a V1 policy into V2, mapping RTO/RPO values from V1 scenarios.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportPolicy service method.</param>
        /// 
        /// <returns>The response from the ImportPolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ImportPolicy">REST API Reference for ImportPolicy Operation</seealso>
        ImportPolicyResponse ImportPolicy(ImportPolicyRequest request);



        /// <summary>
        /// Imports a V1 policy into V2, mapping RTO/RPO values from V1 scenarios.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportPolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ImportPolicy">REST API Reference for ImportPolicy Operation</seealso>
        Task<ImportPolicyResponse> ImportPolicyAsync(ImportPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssertions


        /// <summary>
        /// Lists resilience assertions for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssertions service method.</param>
        /// 
        /// <returns>The response from the ListAssertions service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListAssertions">REST API Reference for ListAssertions Operation</seealso>
        ListAssertionsResponse ListAssertions(ListAssertionsRequest request);



        /// <summary>
        /// Lists resilience assertions for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssertions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssertions service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListAssertions">REST API Reference for ListAssertions Operation</seealso>
        Task<ListAssertionsResponse> ListAssertionsAsync(ListAssertionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDependencies


        /// <summary>
        /// Lists dependencies discovered for services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDependencies service method.</param>
        /// 
        /// <returns>The response from the ListDependencies service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListDependencies">REST API Reference for ListDependencies Operation</seealso>
        ListDependenciesResponse ListDependencies(ListDependenciesRequest request);



        /// <summary>
        /// Lists dependencies discovered for services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDependencies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDependencies service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListDependencies">REST API Reference for ListDependencies Operation</seealso>
        Task<ListDependenciesResponse> ListDependenciesAsync(ListDependenciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFailureModeAssessments


        /// <summary>
        /// Lists failure mode assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFailureModeAssessments service method.</param>
        /// 
        /// <returns>The response from the ListFailureModeAssessments service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListFailureModeAssessments">REST API Reference for ListFailureModeAssessments Operation</seealso>
        ListFailureModeAssessmentsResponse ListFailureModeAssessments(ListFailureModeAssessmentsRequest request);



        /// <summary>
        /// Lists failure mode assessments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFailureModeAssessments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFailureModeAssessments service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListFailureModeAssessments">REST API Reference for ListFailureModeAssessments Operation</seealso>
        Task<ListFailureModeAssessmentsResponse> ListFailureModeAssessmentsAsync(ListFailureModeAssessmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFailureModeFindings


        /// <summary>
        /// List findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFailureModeFindings service method.</param>
        /// 
        /// <returns>The response from the ListFailureModeFindings service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListFailureModeFindings">REST API Reference for ListFailureModeFindings Operation</seealso>
        ListFailureModeFindingsResponse ListFailureModeFindings(ListFailureModeFindingsRequest request);



        /// <summary>
        /// List findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFailureModeFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFailureModeFindings service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListFailureModeFindings">REST API Reference for ListFailureModeFindings Operation</seealso>
        Task<ListFailureModeFindingsResponse> ListFailureModeFindingsAsync(ListFailureModeFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListInputSources


        /// <summary>
        /// Lists input sources for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputSources service method.</param>
        /// 
        /// <returns>The response from the ListInputSources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListInputSources">REST API Reference for ListInputSources Operation</seealso>
        ListInputSourcesResponse ListInputSources(ListInputSourcesRequest request);



        /// <summary>
        /// Lists input sources for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInputSources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListInputSources">REST API Reference for ListInputSources Operation</seealso>
        Task<ListInputSourcesResponse> ListInputSourcesAsync(ListInputSourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPolicies


        /// <summary>
        /// Lists resilience policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        ListPoliciesResponse ListPolicies(ListPoliciesRequest request);



        /// <summary>
        /// Lists resilience policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReports


        /// <summary>
        /// List reports for a service, or all reports owned by the account if serviceArn is not
        /// provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReports service method.</param>
        /// 
        /// <returns>The response from the ListReports service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListReports">REST API Reference for ListReports Operation</seealso>
        ListReportsResponse ListReports(ListReportsRequest request);



        /// <summary>
        /// List reports for a service, or all reports owned by the account if serviceArn is not
        /// provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReports service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListReports">REST API Reference for ListReports Operation</seealso>
        Task<ListReportsResponse> ListReportsAsync(ListReportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResources


        /// <summary>
        /// List resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListResources">REST API Reference for ListResources Operation</seealso>
        ListResourcesResponse ListResources(ListResourcesRequest request);



        /// <summary>
        /// List resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListResources">REST API Reference for ListResources Operation</seealso>
        Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListServiceEvents


        /// <summary>
        /// Lists events for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceEvents service method.</param>
        /// 
        /// <returns>The response from the ListServiceEvents service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServiceEvents">REST API Reference for ListServiceEvents Operation</seealso>
        ListServiceEventsResponse ListServiceEvents(ListServiceEventsRequest request);



        /// <summary>
        /// Lists events for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceEvents service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServiceEvents">REST API Reference for ListServiceEvents Operation</seealso>
        Task<ListServiceEventsResponse> ListServiceEventsAsync(ListServiceEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListServiceFunctions


        /// <summary>
        /// Lists service functions for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceFunctions service method.</param>
        /// 
        /// <returns>The response from the ListServiceFunctions service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServiceFunctions">REST API Reference for ListServiceFunctions Operation</seealso>
        ListServiceFunctionsResponse ListServiceFunctions(ListServiceFunctionsRequest request);



        /// <summary>
        /// Lists service functions for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceFunctions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceFunctions service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServiceFunctions">REST API Reference for ListServiceFunctions Operation</seealso>
        Task<ListServiceFunctionsResponse> ListServiceFunctionsAsync(ListServiceFunctionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListServices


        /// <summary>
        /// Lists services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServices">REST API Reference for ListServices Operation</seealso>
        ListServicesResponse ListServices(ListServicesRequest request);



        /// <summary>
        /// Lists services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServices">REST API Reference for ListServices Operation</seealso>
        Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListServiceTopologyEdges


        /// <summary>
        /// Lists topology edges for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceTopologyEdges service method.</param>
        /// 
        /// <returns>The response from the ListServiceTopologyEdges service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServiceTopologyEdges">REST API Reference for ListServiceTopologyEdges Operation</seealso>
        ListServiceTopologyEdgesResponse ListServiceTopologyEdges(ListServiceTopologyEdgesRequest request);



        /// <summary>
        /// Lists topology edges for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceTopologyEdges service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceTopologyEdges service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListServiceTopologyEdges">REST API Reference for ListServiceTopologyEdges Operation</seealso>
        Task<ListServiceTopologyEdgesResponse> ListServiceTopologyEdgesAsync(ListServiceTopologyEdgesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSystemEvents


        /// <summary>
        /// Lists events for a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSystemEvents service method.</param>
        /// 
        /// <returns>The response from the ListSystemEvents service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListSystemEvents">REST API Reference for ListSystemEvents Operation</seealso>
        ListSystemEventsResponse ListSystemEvents(ListSystemEventsRequest request);



        /// <summary>
        /// Lists events for a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSystemEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSystemEvents service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListSystemEvents">REST API Reference for ListSystemEvents Operation</seealso>
        Task<ListSystemEventsResponse> ListSystemEventsAsync(ListSystemEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSystems


        /// <summary>
        /// Lists systems.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSystems service method.</param>
        /// 
        /// <returns>The response from the ListSystems service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListSystems">REST API Reference for ListSystems Operation</seealso>
        ListSystemsResponse ListSystems(ListSystemsRequest request);



        /// <summary>
        /// Lists systems.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSystems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSystems service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListSystems">REST API Reference for ListSystems Operation</seealso>
        Task<ListSystemsResponse> ListSystemsAsync(ListSystemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUserJourneys


        /// <summary>
        /// Lists user journeys for a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserJourneys service method.</param>
        /// 
        /// <returns>The response from the ListUserJourneys service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListUserJourneys">REST API Reference for ListUserJourneys Operation</seealso>
        ListUserJourneysResponse ListUserJourneys(ListUserJourneysRequest request);



        /// <summary>
        /// Lists user journeys for a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserJourneys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUserJourneys service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/ListUserJourneys">REST API Reference for ListUserJourneys Operation</seealso>
        Task<ListUserJourneysResponse> ListUserJourneysAsync(ListUserJourneysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartFailureModeAssessment


        /// <summary>
        /// Start a failure mode assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFailureModeAssessment service method.</param>
        /// 
        /// <returns>The response from the StartFailureModeAssessment service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/StartFailureModeAssessment">REST API Reference for StartFailureModeAssessment Operation</seealso>
        StartFailureModeAssessmentResponse StartFailureModeAssessment(StartFailureModeAssessmentRequest request);



        /// <summary>
        /// Start a failure mode assessment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFailureModeAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFailureModeAssessment service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/StartFailureModeAssessment">REST API Reference for StartFailureModeAssessment Operation</seealso>
        Task<StartFailureModeAssessmentResponse> StartFailureModeAssessmentAsync(StartFailureModeAssessmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ThrottlingException">
        /// Too many requests — rate limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAssertion


        /// <summary>
        /// Updates a resilience assertion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssertion service method.</param>
        /// 
        /// <returns>The response from the UpdateAssertion service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateAssertion">REST API Reference for UpdateAssertion Operation</seealso>
        UpdateAssertionResponse UpdateAssertion(UpdateAssertionRequest request);



        /// <summary>
        /// Updates a resilience assertion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssertion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssertion service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateAssertion">REST API Reference for UpdateAssertion Operation</seealso>
        Task<UpdateAssertionResponse> UpdateAssertionAsync(UpdateAssertionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDependency


        /// <summary>
        /// Updates a dependency classification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDependency service method.</param>
        /// 
        /// <returns>The response from the UpdateDependency service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateDependency">REST API Reference for UpdateDependency Operation</seealso>
        UpdateDependencyResponse UpdateDependency(UpdateDependencyRequest request);



        /// <summary>
        /// Updates a dependency classification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDependency service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDependency service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateDependency">REST API Reference for UpdateDependency Operation</seealso>
        Task<UpdateDependencyResponse> UpdateDependencyAsync(UpdateDependencyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFailureModeFinding


        /// <summary>
        /// Updates an existing finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFailureModeFinding service method.</param>
        /// 
        /// <returns>The response from the UpdateFailureModeFinding service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateFailureModeFinding">REST API Reference for UpdateFailureModeFinding Operation</seealso>
        UpdateFailureModeFindingResponse UpdateFailureModeFinding(UpdateFailureModeFindingRequest request);



        /// <summary>
        /// Updates an existing finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFailureModeFinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFailureModeFinding service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateFailureModeFinding">REST API Reference for UpdateFailureModeFinding Operation</seealso>
        Task<UpdateFailureModeFindingResponse> UpdateFailureModeFindingAsync(UpdateFailureModeFindingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePolicy


        /// <summary>
        /// Updates an existing resilience policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdatePolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest request);



        /// <summary>
        /// Updates an existing resilience policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePolicy service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateService


        /// <summary>
        /// Updates an existing service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateService">REST API Reference for UpdateService Operation</seealso>
        UpdateServiceResponse UpdateService(UpdateServiceRequest request);



        /// <summary>
        /// Updates an existing service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ServiceQuotaExceededException">
        /// Service quota exceeded.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateService">REST API Reference for UpdateService Operation</seealso>
        Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateServiceFunction


        /// <summary>
        /// Updates a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceFunction service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceFunction service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateServiceFunction">REST API Reference for UpdateServiceFunction Operation</seealso>
        UpdateServiceFunctionResponse UpdateServiceFunction(UpdateServiceFunctionRequest request);



        /// <summary>
        /// Updates a service function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceFunction service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateServiceFunction">REST API Reference for UpdateServiceFunction Operation</seealso>
        Task<UpdateServiceFunctionResponse> UpdateServiceFunctionAsync(UpdateServiceFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSystem


        /// <summary>
        /// Updates an existing system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSystem service method.</param>
        /// 
        /// <returns>The response from the UpdateSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateSystem">REST API Reference for UpdateSystem Operation</seealso>
        UpdateSystemResponse UpdateSystem(UpdateSystemRequest request);



        /// <summary>
        /// Updates an existing system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSystem service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateSystem">REST API Reference for UpdateSystem Operation</seealso>
        Task<UpdateSystemResponse> UpdateSystemAsync(UpdateSystemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUserJourney


        /// <summary>
        /// Updates an existing user journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserJourney service method.</param>
        /// 
        /// <returns>The response from the UpdateUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateUserJourney">REST API Reference for UpdateUserJourney Operation</seealso>
        UpdateUserJourneyResponse UpdateUserJourney(UpdateUserJourneyRequest request);



        /// <summary>
        /// Updates an existing user journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserJourney service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserJourney service method, as returned by Resiliencehubv2.</returns>
        /// <exception cref="Amazon.Resiliencehubv2.Model.AccessDeniedException">
        /// Access denied — caller lacks required permissions.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ConflictException">
        /// Conflict — resource already exists.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.InternalServerException">
        /// Internal service error.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.Resiliencehubv2.Model.ValidationException">
        /// Validation error — invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehubv2-2026-02-17/UpdateUserJourney">REST API Reference for UpdateUserJourney Operation</seealso>
        Task<UpdateUserJourneyResponse> UpdateUserJourneyAsync(UpdateUserJourneyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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