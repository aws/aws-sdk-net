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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AppFabric.Model;

#pragma warning disable CS1570
namespace Amazon.AppFabric
{
    /// <summary>
    /// <para>Interface for accessing AppFabric</para>
    ///
    /// Amazon Web Services AppFabric quickly connects software as a service (SaaS) applications
    /// across your organization. This allows IT and security teams to easily manage and secure
    /// applications using a standard schema, and employees can complete everyday tasks faster
    /// using generative artificial intelligence (AI). You can use these APIs to complete
    /// AppFabric tasks, such as setting up audit log ingestions or viewing user access. For
    /// more information about AppFabric, including the required permissions to use the service,
    /// see the <a href="https://docs.aws.amazon.com/appfabric/latest/adminguide/">Amazon
    /// Web Services AppFabric Administration Guide</a>. For more information about using
    /// the Command Line Interface (CLI) to manage your AppFabric resources, see the <a href="https://docs.aws.amazon.com/cli/latest/reference/appfabric/index.html">AppFabric
    /// section of the CLI Reference</a>.
    /// </summary>
    public partial interface IAmazonAppFabric : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAppFabricPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchGetUserAccessTasks



        /// <summary>
        /// Gets user access details in a batch request.
        /// 
        ///  
        /// <para>
        /// This action polls data from the tasks that are kicked off by the <c>StartUserAccessTasks</c>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetUserAccessTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetUserAccessTasks service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/BatchGetUserAccessTasks">REST API Reference for BatchGetUserAccessTasks Operation</seealso>
        Task<BatchGetUserAccessTasksResponse> BatchGetUserAccessTasksAsync(BatchGetUserAccessTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ConnectAppAuthorization



        /// <summary>
        /// Establishes a connection between Amazon Web Services AppFabric and an application,
        /// which allows AppFabric to call the APIs of the application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConnectAppAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConnectAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ConnectAppAuthorization">REST API Reference for ConnectAppAuthorization Operation</seealso>
        Task<ConnectAppAuthorizationResponse> ConnectAppAuthorizationAsync(ConnectAppAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAppAuthorization



        /// <summary>
        /// Creates an app authorization within an app bundle, which allows AppFabric to connect
        /// to an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/CreateAppAuthorization">REST API Reference for CreateAppAuthorization Operation</seealso>
        Task<CreateAppAuthorizationResponse> CreateAppAuthorizationAsync(CreateAppAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAppBundle



        /// <summary>
        /// Creates an app bundle to collect data from an application using AppFabric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppBundle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppBundle service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/CreateAppBundle">REST API Reference for CreateAppBundle Operation</seealso>
        Task<CreateAppBundleResponse> CreateAppBundleAsync(CreateAppBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIngestion



        /// <summary>
        /// Creates a data ingestion for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/CreateIngestion">REST API Reference for CreateIngestion Operation</seealso>
        Task<CreateIngestionResponse> CreateIngestionAsync(CreateIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIngestionDestination



        /// <summary>
        /// Creates an ingestion destination, which specifies how an application's ingested data
        /// is processed by Amazon Web Services AppFabric and where it's delivered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIngestionDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIngestionDestination service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/CreateIngestionDestination">REST API Reference for CreateIngestionDestination Operation</seealso>
        Task<CreateIngestionDestinationResponse> CreateIngestionDestinationAsync(CreateIngestionDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAppAuthorization



        /// <summary>
        /// Deletes an app authorization. You must delete the associated ingestion before you
        /// can delete an app authorization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/DeleteAppAuthorization">REST API Reference for DeleteAppAuthorization Operation</seealso>
        Task<DeleteAppAuthorizationResponse> DeleteAppAuthorizationAsync(DeleteAppAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAppBundle



        /// <summary>
        /// Deletes an app bundle. You must delete all associated app authorizations before you
        /// can delete an app bundle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppBundle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppBundle service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/DeleteAppBundle">REST API Reference for DeleteAppBundle Operation</seealso>
        Task<DeleteAppBundleResponse> DeleteAppBundleAsync(DeleteAppBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIngestion



        /// <summary>
        /// Deletes an ingestion. You must stop (disable) the ingestion and you must delete all
        /// associated ingestion destinations before you can delete an app ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/DeleteIngestion">REST API Reference for DeleteIngestion Operation</seealso>
        Task<DeleteIngestionResponse> DeleteIngestionAsync(DeleteIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIngestionDestination



        /// <summary>
        /// Deletes an ingestion destination.
        /// 
        ///  
        /// <para>
        /// This deletes the association between an ingestion and it's destination. It doesn't
        /// delete previously ingested data or the storage destination, such as the Amazon S3
        /// bucket where the data is delivered. If the ingestion destination is deleted while
        /// the associated ingestion is enabled, the ingestion will fail and is eventually disabled.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIngestionDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIngestionDestination service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/DeleteIngestionDestination">REST API Reference for DeleteIngestionDestination Operation</seealso>
        Task<DeleteIngestionDestinationResponse> DeleteIngestionDestinationAsync(DeleteIngestionDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAppAuthorization



        /// <summary>
        /// Returns information about an app authorization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/GetAppAuthorization">REST API Reference for GetAppAuthorization Operation</seealso>
        Task<GetAppAuthorizationResponse> GetAppAuthorizationAsync(GetAppAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAppBundle



        /// <summary>
        /// Returns information about an app bundle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppBundle service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppBundle service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/GetAppBundle">REST API Reference for GetAppBundle Operation</seealso>
        Task<GetAppBundleResponse> GetAppBundleAsync(GetAppBundleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIngestion



        /// <summary>
        /// Returns information about an ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/GetIngestion">REST API Reference for GetIngestion Operation</seealso>
        Task<GetIngestionResponse> GetIngestionAsync(GetIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIngestionDestination



        /// <summary>
        /// Returns information about an ingestion destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIngestionDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIngestionDestination service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/GetIngestionDestination">REST API Reference for GetIngestionDestination Operation</seealso>
        Task<GetIngestionDestinationResponse> GetIngestionDestinationAsync(GetIngestionDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppAuthorizations



        /// <summary>
        /// Returns a list of all app authorizations configured for an app bundle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppAuthorizations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppAuthorizations service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListAppAuthorizations">REST API Reference for ListAppAuthorizations Operation</seealso>
        Task<ListAppAuthorizationsResponse> ListAppAuthorizationsAsync(ListAppAuthorizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppBundles



        /// <summary>
        /// Returns a list of app bundles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppBundles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppBundles service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListAppBundles">REST API Reference for ListAppBundles Operation</seealso>
        Task<ListAppBundlesResponse> ListAppBundlesAsync(ListAppBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIngestionDestinations



        /// <summary>
        /// Returns a list of all ingestion destinations configured for an ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestionDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIngestionDestinations service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListIngestionDestinations">REST API Reference for ListIngestionDestinations Operation</seealso>
        Task<ListIngestionDestinationsResponse> ListIngestionDestinationsAsync(ListIngestionDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIngestions



        /// <summary>
        /// Returns a list of all ingestions configured for an app bundle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIngestions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIngestions service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListIngestions">REST API Reference for ListIngestions Operation</seealso>
        Task<ListIngestionsResponse> ListIngestionsAsync(ListIngestionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartIngestion



        /// <summary>
        /// Starts (enables) an ingestion, which collects data from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/StartIngestion">REST API Reference for StartIngestion Operation</seealso>
        Task<StartIngestionResponse> StartIngestionAsync(StartIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartUserAccessTasks



        /// <summary>
        /// Starts the tasks to search user access status for a specific email address.
        /// 
        ///  
        /// <para>
        /// The tasks are stopped when the user access status data is found. The tasks are terminated
        /// when the API calls to the application time out.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartUserAccessTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartUserAccessTasks service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/StartUserAccessTasks">REST API Reference for StartUserAccessTasks Operation</seealso>
        Task<StartUserAccessTasksResponse> StartUserAccessTasksAsync(StartUserAccessTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopIngestion



        /// <summary>
        /// Stops (disables) an ingestion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopIngestion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopIngestion service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/StopIngestion">REST API Reference for StopIngestion Operation</seealso>
        Task<StopIngestionResponse> StopIngestionAsync(StopIngestionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAppAuthorization



        /// <summary>
        /// Updates an app authorization within an app bundle, which allows AppFabric to connect
        /// to an application.
        /// 
        ///  
        /// <para>
        /// If the app authorization was in a <c>connected</c> state, updating the app authorization
        /// will set it back to a <c>PendingConnect</c> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAppAuthorization service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/UpdateAppAuthorization">REST API Reference for UpdateAppAuthorization Operation</seealso>
        Task<UpdateAppAuthorizationResponse> UpdateAppAuthorizationAsync(UpdateAppAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIngestionDestination



        /// <summary>
        /// Updates an ingestion destination, which specifies how an application's ingested data
        /// is processed by Amazon Web Services AppFabric and where it's delivered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIngestionDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIngestionDestination service method, as returned by AppFabric.</returns>
        /// <exception cref="Amazon.AppFabric.Model.AccessDeniedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ConflictException">
        /// The request has created a conflict. Check the request parameters and try again.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ThrottlingException">
        /// The request rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.AppFabric.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appfabric-2023-05-19/UpdateIngestionDestination">REST API Reference for UpdateIngestionDestination Operation</seealso>
        Task<UpdateIngestionDestinationResponse> UpdateIngestionDestinationAsync(UpdateIngestionDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonAppFabricConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonAppFabricConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonAppFabricConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonAppFabricConfig to create AmazonAppFabricClient");
            }

            return awsCredentials == null ? 
                    new AmazonAppFabricClient(serviceClientConfig) :
                    new AmazonAppFabricClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}