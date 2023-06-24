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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DataExchange.Model;

namespace Amazon.DataExchange
{
    /// <summary>
    /// Interface for accessing DataExchange
    ///
    /// AWS Data Exchange is a service that makes it easy for AWS customers to exchange data
    /// in the cloud. You can use the AWS Data Exchange APIs to create, update, manage, and
    /// access file-based data set in the AWS Cloud.
    /// 
    ///  
    /// <para>
    /// As a subscriber, you can view and access the data sets that you have an entitlement
    /// to through a subscription. You can use the APIs to download or copy your entitled
    /// data sets to Amazon Simple Storage Service (Amazon S3) for use across a variety of
    /// AWS analytics and machine learning services.
    /// </para>
    ///  
    /// <para>
    /// As a provider, you can create and manage your data sets that you would like to publish
    /// to a product. Being able to package and provide your data sets into products requires
    /// a few steps to determine eligibility. For more information, visit the <i>AWS Data
    /// Exchange User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// A data set is a collection of data that can be changed or updated over time. Data
    /// sets can be updated using revisions, which represent a new version or incremental
    /// change to a data set. A revision contains one or more assets. An asset in AWS Data
    /// Exchange is a piece of data that can be stored as an Amazon S3 object, Redshift datashare,
    /// API Gateway API, AWS Lake Formation data permission, or Amazon S3 data access. The
    /// asset can be a structured data file, an image file, or some other data file. Jobs
    /// are asynchronous import or export operations used to create or copy assets.
    /// </para>
    /// </summary>
    public partial interface IAmazonDataExchange : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDataExchangePaginatorFactory Paginators { get; }
#endif
                
        #region  CancelJob



        /// <summary>
        /// This operation cancels a job. Jobs can be cancelled only when they are in the WAITING
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CancelJob">REST API Reference for CancelJob Operation</seealso>
        Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataSet



        /// <summary>
        /// This operation creates a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ServiceLimitExceededException">
        /// The request has exceeded the quotas imposed by the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateDataSet">REST API Reference for CreateDataSet Operation</seealso>
        Task<CreateDataSetResponse> CreateDataSetAsync(CreateDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEventAction



        /// <summary>
        /// This operation creates an event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ServiceLimitExceededException">
        /// The request has exceeded the quotas imposed by the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateEventAction">REST API Reference for CreateEventAction Operation</seealso>
        Task<CreateEventActionResponse> CreateEventActionAsync(CreateEventActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateJob



        /// <summary>
        /// This operation creates a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateJob">REST API Reference for CreateJob Operation</seealso>
        Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRevision



        /// <summary>
        /// This operation creates a revision for a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/CreateRevision">REST API Reference for CreateRevision Operation</seealso>
        Task<CreateRevisionResponse> CreateRevisionAsync(CreateRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAsset



        /// <summary>
        /// This operation deletes an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        Task<DeleteAssetResponse> DeleteAssetAsync(DeleteAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataSet



        /// <summary>
        /// This operation deletes a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteDataSet">REST API Reference for DeleteDataSet Operation</seealso>
        Task<DeleteDataSetResponse> DeleteDataSetAsync(DeleteDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEventAction



        /// <summary>
        /// This operation deletes the event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteEventAction">REST API Reference for DeleteEventAction Operation</seealso>
        Task<DeleteEventActionResponse> DeleteEventActionAsync(DeleteEventActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRevision



        /// <summary>
        /// This operation deletes a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/DeleteRevision">REST API Reference for DeleteRevision Operation</seealso>
        Task<DeleteRevisionResponse> DeleteRevisionAsync(DeleteRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAsset



        /// <summary>
        /// This operation returns information about an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetAsset">REST API Reference for GetAsset Operation</seealso>
        Task<GetAssetResponse> GetAssetAsync(GetAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataSet



        /// <summary>
        /// This operation returns information about a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetDataSet">REST API Reference for GetDataSet Operation</seealso>
        Task<GetDataSetResponse> GetDataSetAsync(GetDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEventAction



        /// <summary>
        /// This operation retrieves information about an event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetEventAction">REST API Reference for GetEventAction Operation</seealso>
        Task<GetEventActionResponse> GetEventActionAsync(GetEventActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetJob



        /// <summary>
        /// This operation returns information about a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRevision



        /// <summary>
        /// This operation returns information about a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/GetRevision">REST API Reference for GetRevision Operation</seealso>
        Task<GetRevisionResponse> GetRevisionAsync(GetRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataSetRevisions



        /// <summary>
        /// This operation lists a data set's revisions sorted by CreatedAt in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSetRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSetRevisions service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSetRevisions">REST API Reference for ListDataSetRevisions Operation</seealso>
        Task<ListDataSetRevisionsResponse> ListDataSetRevisionsAsync(ListDataSetRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataSets



        /// <summary>
        /// This operation lists your data sets. When listing by origin OWNED, results are sorted
        /// by CreatedAt in descending order. When listing by origin ENTITLED, there is no order
        /// and the maxResults parameter is ignored.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSets service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListDataSets">REST API Reference for ListDataSets Operation</seealso>
        Task<ListDataSetsResponse> ListDataSetsAsync(ListDataSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEventActions



        /// <summary>
        /// This operation lists your event actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventActions service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListEventActions">REST API Reference for ListEventActions Operation</seealso>
        Task<ListEventActionsResponse> ListEventActionsAsync(ListEventActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListJobs



        /// <summary>
        /// This operation lists your jobs sorted by CreatedAt in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRevisionAssets



        /// <summary>
        /// This operation lists a revision's assets sorted alphabetically in descending order.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRevisionAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRevisionAssets service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListRevisionAssets">REST API Reference for ListRevisionAssets Operation</seealso>
        Task<ListRevisionAssetsResponse> ListRevisionAssetsAsync(ListRevisionAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// This operation lists the tags on the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeRevision



        /// <summary>
        /// This operation revokes subscribers' access to a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/RevokeRevision">REST API Reference for RevokeRevision Operation</seealso>
        Task<RevokeRevisionResponse> RevokeRevisionAsync(RevokeRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendApiAsset



        /// <summary>
        /// This operation invokes an API Gateway API asset. The request is proxied to the provider’s
        /// API Gateway API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendApiAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendApiAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/SendApiAsset">REST API Reference for SendApiAsset Operation</seealso>
        Task<SendApiAssetResponse> SendApiAssetAsync(SendApiAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartJob



        /// <summary>
        /// This operation starts a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartJob service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        Task<StartJobResponse> StartJobAsync(StartJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// This operation tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// This operation removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataExchange.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAsset



        /// <summary>
        /// This operation updates an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAsset service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateAsset">REST API Reference for UpdateAsset Operation</seealso>
        Task<UpdateAssetResponse> UpdateAssetAsync(UpdateAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDataSet



        /// <summary>
        /// This operation updates a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSet service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateDataSet">REST API Reference for UpdateDataSet Operation</seealso>
        Task<UpdateDataSetResponse> UpdateDataSetAsync(UpdateDataSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEventAction



        /// <summary>
        /// This operation updates the event action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventAction service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateEventAction">REST API Reference for UpdateEventAction Operation</seealso>
        Task<UpdateEventActionResponse> UpdateEventActionAsync(UpdateEventActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRevision



        /// <summary>
        /// This operation updates a revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRevision service method, as returned by DataExchange.</returns>
        /// <exception cref="Amazon.DataExchange.Model.AccessDeniedException">
        /// Access to the resource is denied.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ConflictException">
        /// The request couldn't be completed because it conflicted with the current state of
        /// the resource.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.InternalServerException">
        /// An exception occurred with the service.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DataExchange.Model.ValidationException">
        /// The request was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dataexchange-2017-07-25/UpdateRevision">REST API Reference for UpdateRevision Operation</seealso>
        Task<UpdateRevisionResponse> UpdateRevisionAsync(UpdateRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}