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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MarketplaceCatalog.Model;

#pragma warning disable CS1570
namespace Amazon.MarketplaceCatalog
{
    /// <summary>
    /// <para>Interface for accessing MarketplaceCatalog</para>
    ///
    /// Catalog API actions allow you to manage your entities through list, describe, and
    /// update capabilities. An <i>entity</i> can be a product or an offer on AWS Marketplace.
    /// 
    /// 
    ///  
    /// <para>
    /// You can automate your entity update process by integrating the AWS Marketplace Catalog
    /// API with your AWS Marketplace product build or deployment pipelines. You can also
    /// create your own applications on top of the Catalog API to manage your products on
    /// AWS Marketplace.
    /// </para>
    /// </summary>
    public partial interface IAmazonMarketplaceCatalog : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMarketplaceCatalogPaginatorFactory Paginators { get; }

        
        #region  BatchDescribeEntities


        /// <summary>
        /// Returns metadata and content for multiple entities. This is the Batch version of the
        /// <c>DescribeEntity</c> API and uses the same IAM permission action as <c>DescribeEntity</c>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeEntities service method.</param>
        /// 
        /// <returns>The response from the BatchDescribeEntities service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/BatchDescribeEntities">REST API Reference for BatchDescribeEntities Operation</seealso>
        BatchDescribeEntitiesResponse BatchDescribeEntities(BatchDescribeEntitiesRequest request);



        /// <summary>
        /// Returns metadata and content for multiple entities. This is the Batch version of the
        /// <c>DescribeEntity</c> API and uses the same IAM permission action as <c>DescribeEntity</c>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDescribeEntities service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/BatchDescribeEntities">REST API Reference for BatchDescribeEntities Operation</seealso>
        Task<BatchDescribeEntitiesResponse> BatchDescribeEntitiesAsync(BatchDescribeEntitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelChangeSet


        /// <summary>
        /// Used to cancel an open change request. Must be sent before the status of the request
        /// changes to <c>APPLYING</c>, the final stage of completing your change request. You
        /// can describe a change during the 60-day request history retention period for API calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelChangeSet service method.</param>
        /// 
        /// <returns>The response from the CancelChangeSet service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceInUseException">
        /// The resource is currently in use.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/CancelChangeSet">REST API Reference for CancelChangeSet Operation</seealso>
        CancelChangeSetResponse CancelChangeSet(CancelChangeSetRequest request);



        /// <summary>
        /// Used to cancel an open change request. Must be sent before the status of the request
        /// changes to <c>APPLYING</c>, the final stage of completing your change request. You
        /// can describe a change during the 60-day request history retention period for API calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelChangeSet service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceInUseException">
        /// The resource is currently in use.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/CancelChangeSet">REST API Reference for CancelChangeSet Operation</seealso>
        Task<CancelChangeSetResponse> CancelChangeSetAsync(CancelChangeSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes a resource-based policy on an entity that is identified by its resource ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);



        /// <summary>
        /// Deletes a resource-based policy on an entity that is identified by its resource ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeChangeSet


        /// <summary>
        /// Provides information about a given change set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet service method.</param>
        /// 
        /// <returns>The response from the DescribeChangeSet service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        DescribeChangeSetResponse DescribeChangeSet(DescribeChangeSetRequest request);



        /// <summary>
        /// Provides information about a given change set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChangeSet service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        Task<DescribeChangeSetResponse> DescribeChangeSetAsync(DescribeChangeSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEntity


        /// <summary>
        /// Returns the metadata and content of the entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntity service method.</param>
        /// 
        /// <returns>The response from the DescribeEntity service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotSupportedException">
        /// Currently, the specified resource is not supported.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/DescribeEntity">REST API Reference for DescribeEntity Operation</seealso>
        DescribeEntityResponse DescribeEntity(DescribeEntityRequest request);



        /// <summary>
        /// Returns the metadata and content of the entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEntity service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotSupportedException">
        /// Currently, the specified resource is not supported.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/DescribeEntity">REST API Reference for DescribeEntity Operation</seealso>
        Task<DescribeEntityResponse> DescribeEntityAsync(DescribeEntityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Gets a resource-based policy of an entity that is identified by its resource ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);



        /// <summary>
        /// Gets a resource-based policy of an entity that is identified by its resource ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListChangeSets


        /// <summary>
        /// Returns the list of change sets owned by the account being used to make the call.
        /// You can filter this list by providing any combination of <c>entityId</c>, <c>ChangeSetName</c>,
        /// and status. If you provide more than one filter, the API operation applies a logical
        /// AND between the filters.
        /// 
        ///  
        /// <para>
        /// You can describe a change during the 60-day request history retention period for API
        /// calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeSets service method.</param>
        /// 
        /// <returns>The response from the ListChangeSets service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        ListChangeSetsResponse ListChangeSets(ListChangeSetsRequest request);



        /// <summary>
        /// Returns the list of change sets owned by the account being used to make the call.
        /// You can filter this list by providing any combination of <c>entityId</c>, <c>ChangeSetName</c>,
        /// and status. If you provide more than one filter, the API operation applies a logical
        /// AND between the filters.
        /// 
        ///  
        /// <para>
        /// You can describe a change during the 60-day request history retention period for API
        /// calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChangeSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChangeSets service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        Task<ListChangeSetsResponse> ListChangeSetsAsync(ListChangeSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEntities


        /// <summary>
        /// Provides the list of entities of a given type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntities service method.</param>
        /// 
        /// <returns>The response from the ListEntities service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/ListEntities">REST API Reference for ListEntities Operation</seealso>
        ListEntitiesResponse ListEntities(ListEntitiesRequest request);



        /// <summary>
        /// Provides the list of entities of a given type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntities service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/ListEntities">REST API Reference for ListEntities Operation</seealso>
        Task<ListEntitiesResponse> ListEntitiesAsync(ListEntitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags that have been added to a resource (either an <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#catalog-api-entities">entity</a>
        /// or <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#working-with-change-sets">change
        /// set</a>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists all tags that have been added to a resource (either an <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#catalog-api-entities">entity</a>
        /// or <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#working-with-change-sets">change
        /// set</a>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Attaches a resource-based policy to an entity. Examples of an entity include: <c>AmiProduct</c>
        /// and <c>ContainerProduct</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);



        /// <summary>
        /// Attaches a resource-based policy to an entity. Examples of an entity include: <c>AmiProduct</c>
        /// and <c>ContainerProduct</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartChangeSet


        /// <summary>
        /// Allows you to request changes for your entities. Within a single <c>ChangeSet</c>,
        /// you can't start the same change type against the same entity multiple times. Additionally,
        /// when a <c>ChangeSet</c> is running, all the entities targeted by the different changes
        /// are locked until the change set has completed (either succeeded, cancelled, or failed).
        /// If you try to start a change set containing a change against an entity that is already
        /// locked, you will receive a <c>ResourceInUseException</c> error.
        /// 
        ///  
        /// <para>
        /// For example, you can't start the <c>ChangeSet</c> described in the <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/API_StartChangeSet.html#API_StartChangeSet_Examples">example</a>
        /// later in this topic because it contains two changes to run the same change type (<c>AddRevisions</c>)
        /// against the same entity (<c>entity-id@1</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information about working with change sets, see <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#working-with-change-sets">
        /// Working with change sets</a>. For information about change types for single-AMI products,
        /// see <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/ami-products.html#working-with-single-AMI-products">Working
        /// with single-AMI products</a>. Also, for more information about change types available
        /// for container-based products, see <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/container-products.html#working-with-container-products">Working
        /// with container products</a>.
        /// </para>
        ///  
        /// <para>
        /// To download "DetailsDocument" shapes, see <a href="https://github.com/awslabs/aws-marketplace-catalog-api-shapes-for-python">Python</a>
        /// and <a href="https://github.com/awslabs/aws-marketplace-catalog-api-shapes-for-java/tree/main">Java</a>
        /// shapes on GitHub.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChangeSet service method.</param>
        /// 
        /// <returns>The response from the StartChangeSet service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceInUseException">
        /// The resource is currently in use.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ServiceQuotaExceededException">
        /// The maximum number of open requests per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/StartChangeSet">REST API Reference for StartChangeSet Operation</seealso>
        StartChangeSetResponse StartChangeSet(StartChangeSetRequest request);



        /// <summary>
        /// Allows you to request changes for your entities. Within a single <c>ChangeSet</c>,
        /// you can't start the same change type against the same entity multiple times. Additionally,
        /// when a <c>ChangeSet</c> is running, all the entities targeted by the different changes
        /// are locked until the change set has completed (either succeeded, cancelled, or failed).
        /// If you try to start a change set containing a change against an entity that is already
        /// locked, you will receive a <c>ResourceInUseException</c> error.
        /// 
        ///  
        /// <para>
        /// For example, you can't start the <c>ChangeSet</c> described in the <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/API_StartChangeSet.html#API_StartChangeSet_Examples">example</a>
        /// later in this topic because it contains two changes to run the same change type (<c>AddRevisions</c>)
        /// against the same entity (<c>entity-id@1</c>).
        /// </para>
        ///  
        /// <para>
        /// For more information about working with change sets, see <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#working-with-change-sets">
        /// Working with change sets</a>. For information about change types for single-AMI products,
        /// see <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/ami-products.html#working-with-single-AMI-products">Working
        /// with single-AMI products</a>. Also, for more information about change types available
        /// for container-based products, see <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/container-products.html#working-with-container-products">Working
        /// with container products</a>.
        /// </para>
        ///  
        /// <para>
        /// To download "DetailsDocument" shapes, see <a href="https://github.com/awslabs/aws-marketplace-catalog-api-shapes-for-python">Python</a>
        /// and <a href="https://github.com/awslabs/aws-marketplace-catalog-api-shapes-for-java/tree/main">Java</a>
        /// shapes on GitHub.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartChangeSet service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceInUseException">
        /// The resource is currently in use.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ServiceQuotaExceededException">
        /// The maximum number of open requests per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/StartChangeSet">REST API Reference for StartChangeSet Operation</seealso>
        Task<StartChangeSetResponse> StartChangeSetAsync(StartChangeSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags a resource (either an <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#catalog-api-entities">entity</a>
        /// or <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#working-with-change-sets">change
        /// set</a>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Tags a resource (either an <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#catalog-api-entities">entity</a>
        /// or <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#working-with-change-sets">change
        /// set</a>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag or list of tags from a resource (either an <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#catalog-api-entities">entity</a>
        /// or <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#working-with-change-sets">change
        /// set</a>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes a tag or list of tags from a resource (either an <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#catalog-api-entities">entity</a>
        /// or <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#working-with-change-sets">change
        /// set</a>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 403
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 500
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 404
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 429
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// 
        ///  
        /// <para>
        /// HTTP status code: 422
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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