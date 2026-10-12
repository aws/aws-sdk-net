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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.HealthLake.Model;

#pragma warning disable CS1570

namespace Amazon.HealthLake
{
    /// <summary>
    /// <para>Interface for accessing HealthLake</para>
    ///
    /// This is the <i>HealthLake API Reference</i>. For an introduction to the service, see
    /// <a href="https://docs.aws.amazon.com/healthlake/latest/devguide/what-is.html">What
    /// is HealthLake?</a> in the <i>HealthLake Developer Guide</i>.
    /// </summary>
    public partial interface IAmazonHealthLake : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IHealthLakePaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a data transformation profile in DRAFT state. Specify a built-in starter profile,
        /// an existing profile version, raw profile content, or a sample data file as the source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataTransformationProfile service method.</param>
        /// <returns>The response from the CreateDataTransformationProfile service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ConflictException">
        /// The data store is in a transition state and the user requested action cannot be performed.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/CreateDataTransformationProfile">REST API Reference for CreateDataTransformationProfile Operation</seealso>
        CreateDataTransformationProfileResponse CreateDataTransformationProfile(CreateDataTransformationProfileRequest request);
#endif

        /// <summary>
        /// Creates a data transformation profile in DRAFT state. Specify a built-in starter profile,
        /// an existing profile version, raw profile content, or a sample data file as the source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataTransformationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateDataTransformationProfile service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ConflictException">
        /// The data store is in a transition state and the user requested action cannot be performed.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/CreateDataTransformationProfile">REST API Reference for CreateDataTransformationProfile Operation</seealso>
        Task<CreateDataTransformationProfileResponse> CreateDataTransformationProfileAsync(CreateDataTransformationProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create a FHIR-enabled data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFHIRDatastore service method.</param>
        /// <returns>The response from the CreateFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/CreateFHIRDatastore">REST API Reference for CreateFHIRDatastore Operation</seealso>
        CreateFHIRDatastoreResponse CreateFHIRDatastore(CreateFHIRDatastoreRequest request);
#endif

        /// <summary>
        /// Create a FHIR-enabled data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFHIRDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/CreateFHIRDatastore">REST API Reference for CreateFHIRDatastore Operation</seealso>
        Task<CreateFHIRDatastoreResponse> CreateFHIRDatastoreAsync(CreateFHIRDatastoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a data transformation profile and all its versions, including the DRAFT and
        /// all published versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataTransformationProfile service method.</param>
        /// <returns>The response from the DeleteDataTransformationProfile service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DeleteDataTransformationProfile">REST API Reference for DeleteDataTransformationProfile Operation</seealso>
        DeleteDataTransformationProfileResponse DeleteDataTransformationProfile(DeleteDataTransformationProfileRequest request);
#endif

        /// <summary>
        /// Deletes a data transformation profile and all its versions, including the DRAFT and
        /// all published versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataTransformationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteDataTransformationProfile service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DeleteDataTransformationProfile">REST API Reference for DeleteDataTransformationProfile Operation</seealso>
        Task<DeleteDataTransformationProfileResponse> DeleteDataTransformationProfileAsync(DeleteDataTransformationProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete a FHIR-enabled data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFHIRDatastore service method.</param>
        /// <returns>The response from the DeleteFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ConflictException">
        /// The data store is in a transition state and the user requested action cannot be performed.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DeleteFHIRDatastore">REST API Reference for DeleteFHIRDatastore Operation</seealso>
        DeleteFHIRDatastoreResponse DeleteFHIRDatastore(DeleteFHIRDatastoreRequest request);
#endif

        /// <summary>
        /// Delete a FHIR-enabled data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFHIRDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ConflictException">
        /// The data store is in a transition state and the user requested action cannot be performed.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DeleteFHIRDatastore">REST API Reference for DeleteFHIRDatastore Operation</seealso>
        Task<DeleteFHIRDatastoreResponse> DeleteFHIRDatastoreAsync(DeleteFHIRDatastoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Describes a data transformation job, including its current status, configuration,
        /// and progress information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataTransformationJob service method.</param>
        /// <returns>The response from the DescribeDataTransformationJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DescribeDataTransformationJob">REST API Reference for DescribeDataTransformationJob Operation</seealso>
        DescribeDataTransformationJobResponse DescribeDataTransformationJob(DescribeDataTransformationJobRequest request);
#endif

        /// <summary>
        /// Describes a data transformation job, including its current status, configuration,
        /// and progress information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataTransformationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeDataTransformationJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DescribeDataTransformationJob">REST API Reference for DescribeDataTransformationJob Operation</seealso>
        Task<DescribeDataTransformationJobResponse> DescribeDataTransformationJobAsync(DescribeDataTransformationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get properties for a FHIR-enabled data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRDatastore service method.</param>
        /// <returns>The response from the DescribeFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DescribeFHIRDatastore">REST API Reference for DescribeFHIRDatastore Operation</seealso>
        DescribeFHIRDatastoreResponse DescribeFHIRDatastore(DescribeFHIRDatastoreRequest request);
#endif

        /// <summary>
        /// Get properties for a FHIR-enabled data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DescribeFHIRDatastore">REST API Reference for DescribeFHIRDatastore Operation</seealso>
        Task<DescribeFHIRDatastoreResponse> DescribeFHIRDatastoreAsync(DescribeFHIRDatastoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get FHIR export job properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRExportJob service method.</param>
        /// <returns>The response from the DescribeFHIRExportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DescribeFHIRExportJob">REST API Reference for DescribeFHIRExportJob Operation</seealso>
        DescribeFHIRExportJobResponse DescribeFHIRExportJob(DescribeFHIRExportJobRequest request);
#endif

        /// <summary>
        /// Get FHIR export job properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeFHIRExportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DescribeFHIRExportJob">REST API Reference for DescribeFHIRExportJob Operation</seealso>
        Task<DescribeFHIRExportJobResponse> DescribeFHIRExportJobAsync(DescribeFHIRExportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get the import job properties to learn more about the job or job progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRImportJob service method.</param>
        /// <returns>The response from the DescribeFHIRImportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DescribeFHIRImportJob">REST API Reference for DescribeFHIRImportJob Operation</seealso>
        DescribeFHIRImportJobResponse DescribeFHIRImportJob(DescribeFHIRImportJobRequest request);
#endif

        /// <summary>
        /// Get the import job properties to learn more about the job or job progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFHIRImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeFHIRImportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/DescribeFHIRImportJob">REST API Reference for DescribeFHIRImportJob Operation</seealso>
        Task<DescribeFHIRImportJobResponse> DescribeFHIRImportJobAsync(DescribeFHIRImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a data transformation profile's metadata and profile content at a specific
        /// version. Specify version 0 to retrieve the DRAFT, a version number between 1 and 99
        /// to retrieve a specific published version, or omit the version to retrieve the latest
        /// published version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataTransformationProfile service method.</param>
        /// <returns>The response from the GetDataTransformationProfile service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/GetDataTransformationProfile">REST API Reference for GetDataTransformationProfile Operation</seealso>
        GetDataTransformationProfileResponse GetDataTransformationProfile(GetDataTransformationProfileRequest request);
#endif

        /// <summary>
        /// Retrieves a data transformation profile's metadata and profile content at a specific
        /// version. Specify version 0 to retrieve the DRAFT, a version number between 1 and 99
        /// to retrieve a specific published version, or omit the version to retrieve the latest
        /// published version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataTransformationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDataTransformationProfile service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/GetDataTransformationProfile">REST API Reference for GetDataTransformationProfile Operation</seealso>
        Task<GetDataTransformationProfileResponse> GetDataTransformationProfileAsync(GetDataTransformationProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists data transformation jobs for your Amazon Web Services account. Results can be
        /// filtered by status, job name, and submit time window. Results are paginated. Use the
        /// <c>NextToken</c> parameter to retrieve additional results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataTransformationJobs service method.</param>
        /// <returns>The response from the ListDataTransformationJobs service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListDataTransformationJobs">REST API Reference for ListDataTransformationJobs Operation</seealso>
        ListDataTransformationJobsResponse ListDataTransformationJobs(ListDataTransformationJobsRequest request);
#endif

        /// <summary>
        /// Lists data transformation jobs for your Amazon Web Services account. Results can be
        /// filtered by status, job name, and submit time window. Results are paginated. Use the
        /// <c>NextToken</c> parameter to retrieve additional results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataTransformationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDataTransformationJobs service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListDataTransformationJobs">REST API Reference for ListDataTransformationJobs Operation</seealso>
        Task<ListDataTransformationJobsResponse> ListDataTransformationJobsAsync(ListDataTransformationJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all versions of a specific data transformation profile (DRAFT and published),
        /// in reverse chronological order (newest first). Use <c>GetDataTransformationProfile</c>
        /// to retrieve profile content. Results are paginated. Use the <c>NextToken</c> parameter
        /// to retrieve additional results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataTransformationProfileVersions service method.</param>
        /// <returns>The response from the ListDataTransformationProfileVersions service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListDataTransformationProfileVersions">REST API Reference for ListDataTransformationProfileVersions Operation</seealso>
        ListDataTransformationProfileVersionsResponse ListDataTransformationProfileVersions(ListDataTransformationProfileVersionsRequest request);
#endif

        /// <summary>
        /// Lists all versions of a specific data transformation profile (DRAFT and published),
        /// in reverse chronological order (newest first). Use <c>GetDataTransformationProfile</c>
        /// to retrieve profile content. Results are paginated. Use the <c>NextToken</c> parameter
        /// to retrieve additional results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataTransformationProfileVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDataTransformationProfileVersions service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListDataTransformationProfileVersions">REST API Reference for ListDataTransformationProfileVersions Operation</seealso>
        Task<ListDataTransformationProfileVersionsResponse> ListDataTransformationProfileVersionsAsync(ListDataTransformationProfileVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all data transformation profiles in your account, returning the latest version
        /// summary for each. Use <c>GetDataTransformationProfile</c> to retrieve profile content.
        /// Results are paginated. Use the <c>NextToken</c> parameter to retrieve additional results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataTransformationProfiles service method.</param>
        /// <returns>The response from the ListDataTransformationProfiles service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListDataTransformationProfiles">REST API Reference for ListDataTransformationProfiles Operation</seealso>
        ListDataTransformationProfilesResponse ListDataTransformationProfiles(ListDataTransformationProfilesRequest request);
#endif

        /// <summary>
        /// Lists all data transformation profiles in your account, returning the latest version
        /// summary for each. Use <c>GetDataTransformationProfile</c> to retrieve profile content.
        /// Results are paginated. Use the <c>NextToken</c> parameter to retrieve additional results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataTransformationProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDataTransformationProfiles service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListDataTransformationProfiles">REST API Reference for ListDataTransformationProfiles Operation</seealso>
        Task<ListDataTransformationProfilesResponse> ListDataTransformationProfilesAsync(ListDataTransformationProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List all FHIR-enabled data stores in a user’s account, regardless of data store status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFHIRDatastores service method.</param>
        /// <returns>The response from the ListFHIRDatastores service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListFHIRDatastores">REST API Reference for ListFHIRDatastores Operation</seealso>
        ListFHIRDatastoresResponse ListFHIRDatastores(ListFHIRDatastoresRequest request);
#endif

        /// <summary>
        /// List all FHIR-enabled data stores in a user’s account, regardless of data store status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFHIRDatastores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListFHIRDatastores service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListFHIRDatastores">REST API Reference for ListFHIRDatastores Operation</seealso>
        Task<ListFHIRDatastoresResponse> ListFHIRDatastoresAsync(ListFHIRDatastoresRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all FHIR export jobs associated with an account and their statuses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFHIRExportJobs service method.</param>
        /// <returns>The response from the ListFHIRExportJobs service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListFHIRExportJobs">REST API Reference for ListFHIRExportJobs Operation</seealso>
        ListFHIRExportJobsResponse ListFHIRExportJobs(ListFHIRExportJobsRequest request);
#endif

        /// <summary>
        /// Lists all FHIR export jobs associated with an account and their statuses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFHIRExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListFHIRExportJobs service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListFHIRExportJobs">REST API Reference for ListFHIRExportJobs Operation</seealso>
        Task<ListFHIRExportJobsResponse> ListFHIRExportJobsAsync(ListFHIRExportJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List all FHIR import jobs associated with an account and their statuses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFHIRImportJobs service method.</param>
        /// <returns>The response from the ListFHIRImportJobs service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListFHIRImportJobs">REST API Reference for ListFHIRImportJobs Operation</seealso>
        ListFHIRImportJobsResponse ListFHIRImportJobs(ListFHIRImportJobsRequest request);
#endif

        /// <summary>
        /// List all FHIR import jobs associated with an account and their statuses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFHIRImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListFHIRImportJobs service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListFHIRImportJobs">REST API Reference for ListFHIRImportJobs Operation</seealso>
        Task<ListFHIRImportJobsResponse> ListFHIRImportJobsAsync(ListFHIRImportJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of all existing tags associated with a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// Returns a list of all existing tags associated with a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Promotes the current DRAFT version of a data transformation profile to a new immutable
        /// published version. Also supports rollback by publishing from a previously published
        /// version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishDataTransformationProfile service method.</param>
        /// <returns>The response from the PublishDataTransformationProfile service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/PublishDataTransformationProfile">REST API Reference for PublishDataTransformationProfile Operation</seealso>
        PublishDataTransformationProfileResponse PublishDataTransformationProfile(PublishDataTransformationProfileRequest request);
#endif

        /// <summary>
        /// Promotes the current DRAFT version of a data transformation profile to a new immutable
        /// published version. Also supports rollback by publishing from a previously published
        /// version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishDataTransformationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PublishDataTransformationProfile service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/PublishDataTransformationProfile">REST API Reference for PublishDataTransformationProfile Operation</seealso>
        Task<PublishDataTransformationProfileResponse> PublishDataTransformationProfileAsync(PublishDataTransformationProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Restore a backup-enabled data store to a point in time. Creates a new data store from
        /// the backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFHIRDatastore service method.</param>
        /// <returns>The response from the RestoreFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ConflictException">
        /// The data store is in a transition state and the user requested action cannot be performed.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/RestoreFHIRDatastore">REST API Reference for RestoreFHIRDatastore Operation</seealso>
        RestoreFHIRDatastoreResponse RestoreFHIRDatastore(RestoreFHIRDatastoreRequest request);
#endif

        /// <summary>
        /// Restore a backup-enabled data store to a point in time. Creates a new data store from
        /// the backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFHIRDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RestoreFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ConflictException">
        /// The data store is in a transition state and the user requested action cannot be performed.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/RestoreFHIRDatastore">REST API Reference for RestoreFHIRDatastore Operation</seealso>
        Task<RestoreFHIRDatastoreResponse> RestoreFHIRDatastoreAsync(RestoreFHIRDatastoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts an asynchronous data transformation job that converts source files from Amazon
        /// Simple Storage Service (Amazon S3) and writes the output to Amazon S3 or HealthLake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataTransformationJob service method.</param>
        /// <returns>The response from the StartDataTransformationJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/StartDataTransformationJob">REST API Reference for StartDataTransformationJob Operation</seealso>
        StartDataTransformationJobResponse StartDataTransformationJob(StartDataTransformationJobRequest request);
#endif

        /// <summary>
        /// Starts an asynchronous data transformation job that converts source files from Amazon
        /// Simple Storage Service (Amazon S3) and writes the output to Amazon S3 or HealthLake.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataTransformationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartDataTransformationJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/StartDataTransformationJob">REST API Reference for StartDataTransformationJob Operation</seealso>
        Task<StartDataTransformationJobResponse> StartDataTransformationJobAsync(StartDataTransformationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Start a FHIR export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFHIRExportJob service method.</param>
        /// <returns>The response from the StartFHIRExportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.FailedDependencyException">
        /// A dependent service failed to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/StartFHIRExportJob">REST API Reference for StartFHIRExportJob Operation</seealso>
        StartFHIRExportJobResponse StartFHIRExportJob(StartFHIRExportJobRequest request);
#endif

        /// <summary>
        /// Start a FHIR export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFHIRExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartFHIRExportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.FailedDependencyException">
        /// A dependent service failed to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/StartFHIRExportJob">REST API Reference for StartFHIRExportJob Operation</seealso>
        Task<StartFHIRExportJobResponse> StartFHIRExportJobAsync(StartFHIRExportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Start importing bulk FHIR data into an ACTIVE data store. The import job imports FHIR
        /// data found in the <c>InputDataConfig</c> object and stores processing results in the
        /// <c>JobOutputDataConfig</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFHIRImportJob service method.</param>
        /// <returns>The response from the StartFHIRImportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.FailedDependencyException">
        /// A dependent service failed to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/StartFHIRImportJob">REST API Reference for StartFHIRImportJob Operation</seealso>
        StartFHIRImportJobResponse StartFHIRImportJob(StartFHIRImportJobRequest request);
#endif

        /// <summary>
        /// Start importing bulk FHIR data into an ACTIVE data store. The import job imports FHIR
        /// data found in the <c>InputDataConfig</c> object and stores processing results in the
        /// <c>JobOutputDataConfig</c> object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFHIRImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartFHIRImportJob service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.FailedDependencyException">
        /// A dependent service failed to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/StartFHIRImportJob">REST API Reference for StartFHIRImportJob Operation</seealso>
        Task<StartFHIRImportJobResponse> StartFHIRImportJobAsync(StartFHIRImportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Add a user-specifed key and value tag to a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Add a user-specifed key and value tag to a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Remove a user-specifed key and value tag from a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Remove a user-specifed key and value tag from a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the DRAFT version (version 0) of a data transformation profile with new profile
        /// content. The update replaces all existing DRAFT content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataTransformationProfile service method.</param>
        /// <returns>The response from the UpdateDataTransformationProfile service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/UpdateDataTransformationProfile">REST API Reference for UpdateDataTransformationProfile Operation</seealso>
        UpdateDataTransformationProfileResponse UpdateDataTransformationProfile(UpdateDataTransformationProfileRequest request);
#endif

        /// <summary>
        /// Updates the DRAFT version (version 0) of a data transformation profile with new profile
        /// content. The update replaces all existing DRAFT content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataTransformationProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateDataTransformationProfile service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/UpdateDataTransformationProfile">REST API Reference for UpdateDataTransformationProfile Operation</seealso>
        Task<UpdateDataTransformationProfileResponse> UpdateDataTransformationProfileAsync(UpdateDataTransformationProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update the properties of a FHIR-enabled data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFHIRDatastore service method.</param>
        /// <returns>The response from the UpdateFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ConflictException">
        /// The data store is in a transition state and the user requested action cannot be performed.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/UpdateFHIRDatastore">REST API Reference for UpdateFHIRDatastore Operation</seealso>
        UpdateFHIRDatastoreResponse UpdateFHIRDatastore(UpdateFHIRDatastoreRequest request);
#endif

        /// <summary>
        /// Update the properties of a FHIR-enabled data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFHIRDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateFHIRDatastore service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ConflictException">
        /// The data store is in a transition state and the user requested action cannot be performed.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/UpdateFHIRDatastore">REST API Reference for UpdateFHIRDatastore Operation</seealso>
        Task<UpdateFHIRDatastoreResponse> UpdateFHIRDatastoreAsync(UpdateFHIRDatastoreRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a data transformation profile using chat-based interaction with an agent.
        /// Supports multi-turn conversations for iteratively customizing profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfileWithAgent service method.</param>
        /// <returns>The response from the UpdateProfileWithAgent service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.AgentMessageOutOfContextException">
        /// The agent message does not fit within the current conversation context. Start a new
        /// conversation or provide a message that relates to the current profile customization
        /// session.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ConversationNotFoundException">
        /// The specified conversation identifier does not exist. Verify the conversation ID or
        /// omit it to start a new conversation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.NotImplementedOperationException">
        /// The requested operation is not yet available. Check the service documentation for
        /// a list of supported operations.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.UnauthorizedException">
        /// You are not authorized to make this request. Verify that your Amazon Web Services
        /// credentials are valid and that you have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.UnsupportedMIMETypeException">
        /// The content type in your request is not supported. Use a supported content type for
        /// this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/UpdateProfileWithAgent">REST API Reference for UpdateProfileWithAgent Operation</seealso>
        UpdateProfileWithAgentResponse UpdateProfileWithAgent(UpdateProfileWithAgentRequest request);
#endif

        /// <summary>
        /// Updates a data transformation profile using chat-based interaction with an agent.
        /// Supports multi-turn conversations for iteratively customizing profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfileWithAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProfileWithAgent service method, as returned by HealthLake.</returns>
        /// <exception cref="Amazon.HealthLake.Model.AccessDeniedException">
        /// Access is denied. Your account is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.AgentMessageOutOfContextException">
        /// The agent message does not fit within the current conversation context. Start a new
        /// conversation or provide a message that relates to the current profile customization
        /// session.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ConversationNotFoundException">
        /// The specified conversation identifier does not exist. Verify the conversation ID or
        /// omit it to start a new conversation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.InternalServerException">
        /// An unknown internal error occurred in the service.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.NotImplementedOperationException">
        /// The requested operation is not yet available. Check the service documentation for
        /// a list of supported operations.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ResourceNotFoundException">
        /// The requested data store was not found.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ThrottlingException">
        /// The user has exceeded their maximum number of allowed calls to the given API.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.UnauthorizedException">
        /// You are not authorized to make this request. Verify that your Amazon Web Services
        /// credentials are valid and that you have the required permissions.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.UnsupportedMIMETypeException">
        /// The content type in your request is not supported. Use a supported content type for
        /// this operation.
        /// </exception>
        /// <exception cref="Amazon.HealthLake.Model.ValidationException">
        /// The user input parameter was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/healthlake-2017-07-01/UpdateProfileWithAgent">REST API Reference for UpdateProfileWithAgent Operation</seealso>
        Task<UpdateProfileWithAgentResponse> UpdateProfileWithAgentAsync(UpdateProfileWithAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonHealthLakeConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonHealthLakeConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonHealthLakeConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonHealthLakeConfig to create AmazonHealthLakeClient");
            }

            return awsCredentials == null ?
                    new AmazonHealthLakeClient(serviceClientConfig) :
                    new AmazonHealthLakeClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
