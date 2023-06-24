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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MainframeModernization.Model;

namespace Amazon.MainframeModernization
{
    /// <summary>
    /// Interface for accessing MainframeModernization
    ///
    /// Amazon Web Services Mainframe Modernization provides tools and resources to help you
    /// plan and implement migration and modernization from mainframes to Amazon Web Services
    /// managed runtime environments. It provides tools for analyzing existing mainframe applications,
    /// developing or updating mainframe applications using COBOL or PL/I, and implementing
    /// an automated pipeline for continuous integration and continuous delivery (CI/CD) of
    /// the applications.
    /// </summary>
    public partial interface IAmazonMainframeModernization : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMainframeModernizationPaginatorFactory Paginators { get; }
#endif
                
        #region  CancelBatchJobExecution



        /// <summary>
        /// Cancels the running of a specific batch job execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBatchJobExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelBatchJobExecution service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/CancelBatchJobExecution">REST API Reference for CancelBatchJobExecution Operation</seealso>
        Task<CancelBatchJobExecutionResponse> CancelBatchJobExecutionAsync(CancelBatchJobExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateApplication



        /// <summary>
        /// Creates a new application with given parameters. Requires an existing runtime environment
        /// and application definition file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ServiceQuotaExceededException">
        /// One or more quotas for Amazon Web Services Mainframe Modernization exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataSetImportTask



        /// <summary>
        /// Starts a data set import task for a specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSetImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSetImportTask service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ServiceQuotaExceededException">
        /// One or more quotas for Amazon Web Services Mainframe Modernization exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/CreateDataSetImportTask">REST API Reference for CreateDataSetImportTask Operation</seealso>
        Task<CreateDataSetImportTaskResponse> CreateDataSetImportTaskAsync(CreateDataSetImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDeployment



        /// <summary>
        /// Creates and starts a deployment to deploy an application into a runtime environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ServiceQuotaExceededException">
        /// One or more quotas for Amazon Web Services Mainframe Modernization exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEnvironment



        /// <summary>
        /// Creates a runtime environment for a given runtime engine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ServiceQuotaExceededException">
        /// One or more quotas for Amazon Web Services Mainframe Modernization exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApplication



        /// <summary>
        /// Deletes a specific application. You cannot delete a running application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApplicationFromEnvironment



        /// <summary>
        /// Deletes a specific application from the specific runtime environment where it was
        /// previously deployed. You cannot delete a runtime environment using DeleteEnvironment
        /// if any application has ever been deployed to it. This API removes the association
        /// of the application with the runtime environment so you can delete the environment
        /// smoothly.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationFromEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplicationFromEnvironment service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/DeleteApplicationFromEnvironment">REST API Reference for DeleteApplicationFromEnvironment Operation</seealso>
        Task<DeleteApplicationFromEnvironmentResponse> DeleteApplicationFromEnvironmentAsync(DeleteApplicationFromEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEnvironment



        /// <summary>
        /// Deletes a specific runtime environment. The environment cannot contain deployed applications.
        /// If it does, you must delete those applications before you delete the environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApplication



        /// <summary>
        /// Describes the details of a specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/GetApplication">REST API Reference for GetApplication Operation</seealso>
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApplicationVersion



        /// <summary>
        /// Returns details about a specific version of a specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplicationVersion service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/GetApplicationVersion">REST API Reference for GetApplicationVersion Operation</seealso>
        Task<GetApplicationVersionResponse> GetApplicationVersionAsync(GetApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBatchJobExecution



        /// <summary>
        /// Gets the details of a specific batch job execution for a specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBatchJobExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBatchJobExecution service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/GetBatchJobExecution">REST API Reference for GetBatchJobExecution Operation</seealso>
        Task<GetBatchJobExecutionResponse> GetBatchJobExecutionAsync(GetBatchJobExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataSetDetails



        /// <summary>
        /// Gets the details of a specific data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSetDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSetDetails service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/GetDataSetDetails">REST API Reference for GetDataSetDetails Operation</seealso>
        Task<GetDataSetDetailsResponse> GetDataSetDetailsAsync(GetDataSetDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataSetImportTask



        /// <summary>
        /// Gets the status of a data set import task initiated with the <a>CreateDataSetImportTask</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSetImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSetImportTask service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/GetDataSetImportTask">REST API Reference for GetDataSetImportTask Operation</seealso>
        Task<GetDataSetImportTaskResponse> GetDataSetImportTaskAsync(GetDataSetImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDeployment



        /// <summary>
        /// Gets details of a specific deployment with a given deployment identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEnvironment



        /// <summary>
        /// Describes a specific runtime environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplications



        /// <summary>
        /// Lists the applications associated with a specific Amazon Web Services account. You
        /// can provide the unique identifier of a specific runtime environment in a query parameter
        /// to see all applications associated with that environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListApplications">REST API Reference for ListApplications Operation</seealso>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplicationVersions



        /// <summary>
        /// Returns a list of the application versions for a specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationVersions service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListApplicationVersions">REST API Reference for ListApplicationVersions Operation</seealso>
        Task<ListApplicationVersionsResponse> ListApplicationVersionsAsync(ListApplicationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBatchJobDefinitions



        /// <summary>
        /// Lists all the available batch job definitions based on the batch job resources uploaded
        /// during the application creation. You can use the batch job definitions in the list
        /// to start a batch job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBatchJobDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBatchJobDefinitions service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListBatchJobDefinitions">REST API Reference for ListBatchJobDefinitions Operation</seealso>
        Task<ListBatchJobDefinitionsResponse> ListBatchJobDefinitionsAsync(ListBatchJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBatchJobExecutions



        /// <summary>
        /// Lists historical, current, and scheduled batch job executions for a specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBatchJobExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBatchJobExecutions service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListBatchJobExecutions">REST API Reference for ListBatchJobExecutions Operation</seealso>
        Task<ListBatchJobExecutionsResponse> ListBatchJobExecutionsAsync(ListBatchJobExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataSetImportHistory



        /// <summary>
        /// Lists the data set imports for the specified application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSetImportHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSetImportHistory service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListDataSetImportHistory">REST API Reference for ListDataSetImportHistory Operation</seealso>
        Task<ListDataSetImportHistoryResponse> ListDataSetImportHistoryAsync(ListDataSetImportHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataSets



        /// <summary>
        /// Lists the data sets imported for a specific application. In Amazon Web Services Mainframe
        /// Modernization, data sets are associated with applications deployed on runtime environments.
        /// This is known as importing data sets. Currently, Amazon Web Services Mainframe Modernization
        /// can import data sets into catalogs using <a href="https://docs.aws.amazon.com/m2/latest/APIReference/API_CreateDataSetImportTask.html">CreateDataSetImportTask</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSets service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        Task<ListDataSetsResponse> ListDataSetsAsync(ListDataSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDeployments



        /// <summary>
        /// Returns a list of all deployments of a specific application. A deployment is a combination
        /// of a specific application and a specific version of that application. Each deployment
        /// is mapped to a particular application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        Task<ListDeploymentsResponse> ListDeploymentsAsync(ListDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEngineVersions



        /// <summary>
        /// Lists the available engine versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngineVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEngineVersions service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListEngineVersions">REST API Reference for ListEngineVersions Operation</seealso>
        Task<ListEngineVersionsResponse> ListEngineVersionsAsync(ListEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEnvironments



        /// <summary>
        /// Lists the runtime environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartApplication



        /// <summary>
        /// Starts an application that is currently stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartApplication service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/StartApplication">REST API Reference for StartApplication Operation</seealso>
        Task<StartApplicationResponse> StartApplicationAsync(StartApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartBatchJob



        /// <summary>
        /// Starts a batch job and returns the unique identifier of this execution of the batch
        /// job. The associated application must be running in order to start the batch job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBatchJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartBatchJob service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/StartBatchJob">REST API Reference for StartBatchJob Operation</seealso>
        Task<StartBatchJobResponse> StartBatchJobAsync(StartBatchJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopApplication



        /// <summary>
        /// Stops a running application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopApplication service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/StopApplication">REST API Reference for StopApplication Operation</seealso>
        Task<StopApplicationResponse> StopApplicationAsync(StopApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds one or more tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ServiceQuotaExceededException">
        /// One or more quotas for Amazon Web Services Mainframe Modernization exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApplication



        /// <summary>
        /// Updates an application and creates a new version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEnvironment



        /// <summary>
        /// Updates the configuration details for a specific runtime environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by MainframeModernization.</returns>
        /// <exception cref="Amazon.MainframeModernization.Model.AccessDeniedException">
        /// The account or role doesn't have the right permissions to make the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ConflictException">
        /// The parameters provided in the request conflict with existing resources.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ServiceQuotaExceededException">
        /// One or more quotas for Amazon Web Services Mainframe Modernization exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ThrottlingException">
        /// The number of requests made exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.MainframeModernization.Model.ValidationException">
        /// One or more parameters provided in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/m2-2021-04-28/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}