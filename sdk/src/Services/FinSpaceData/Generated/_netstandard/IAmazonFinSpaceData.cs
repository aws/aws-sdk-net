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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.FinSpaceData.Model;

namespace Amazon.FinSpaceData
{
    /// <summary>
    /// Interface for accessing FinSpaceData
    ///
    /// The FinSpace APIs let you take actions inside the FinSpace.
    /// </summary>
    public partial interface IAmazonFinSpaceData : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IFinSpaceDataPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateChangeset



        /// <summary>
        /// Creates a new Changeset in a FinSpace Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChangeset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.LimitExceededException">
        /// A limit has exceeded.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateChangeset">REST API Reference for CreateChangeset Operation</seealso>
        Task<CreateChangesetResponse> CreateChangesetAsync(CreateChangesetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataset



        /// <summary>
        /// Creates a new FinSpace Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.LimitExceededException">
        /// A limit has exceeded.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataView



        /// <summary>
        /// Creates a Dataview for a Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataView service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.LimitExceededException">
        /// A limit has exceeded.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateDataView">REST API Reference for CreateDataView Operation</seealso>
        Task<CreateDataViewResponse> CreateDataViewAsync(CreateDataViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataset



        /// <summary>
        /// Deletes a FinSpace Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.LimitExceededException">
        /// A limit has exceeded.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetChangeset



        /// <summary>
        /// Get information about a Changeset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChangeset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChangeset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetChangeset">REST API Reference for GetChangeset Operation</seealso>
        Task<GetChangesetResponse> GetChangesetAsync(GetChangesetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataset



        /// <summary>
        /// Returns information about a Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetDataset">REST API Reference for GetDataset Operation</seealso>
        Task<GetDatasetResponse> GetDatasetAsync(GetDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataView



        /// <summary>
        /// Gets information about a Dataview.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataView service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataView service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetDataView">REST API Reference for GetDataView Operation</seealso>
        Task<GetDataViewResponse> GetDataViewAsync(GetDataViewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProgrammaticAccessCredentials



        /// <summary>
        /// Request programmatic credentials to use with FinSpace SDK.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProgrammaticAccessCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProgrammaticAccessCredentials service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetProgrammaticAccessCredentials">REST API Reference for GetProgrammaticAccessCredentials Operation</seealso>
        Task<GetProgrammaticAccessCredentialsResponse> GetProgrammaticAccessCredentialsAsync(GetProgrammaticAccessCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetWorkingLocation



        /// <summary>
        /// A temporary Amazon S3 location, where you can copy your files from a source location
        /// to stage or use as a scratch space in FinSpace notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkingLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkingLocation service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetWorkingLocation">REST API Reference for GetWorkingLocation Operation</seealso>
        Task<GetWorkingLocationResponse> GetWorkingLocationAsync(GetWorkingLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListChangesets



        /// <summary>
        /// Lists the FinSpace Changesets for a Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangesets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChangesets service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListChangesets">REST API Reference for ListChangesets Operation</seealso>
        Task<ListChangesetsResponse> ListChangesetsAsync(ListChangesetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDatasets



        /// <summary>
        /// Lists all of the active Datasets that a user has access to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataViews



        /// <summary>
        /// Lists all available Dataviews for a Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataViews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataViews service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/ListDataViews">REST API Reference for ListDataViews Operation</seealso>
        Task<ListDataViewsResponse> ListDataViewsAsync(ListDataViewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateChangeset



        /// <summary>
        /// Updates a FinSpace Changeset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChangeset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChangeset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/UpdateChangeset">REST API Reference for UpdateChangeset Operation</seealso>
        Task<UpdateChangesetResponse> UpdateChangesetAsync(UpdateChangesetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDataset



        /// <summary>
        /// Updates a FinSpace Dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ConflictException">
        /// The request conflicts with an existing resource.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        Task<UpdateDatasetResponse> UpdateDatasetAsync(UpdateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}