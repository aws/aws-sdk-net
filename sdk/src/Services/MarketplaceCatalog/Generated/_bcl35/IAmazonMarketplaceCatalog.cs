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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MarketplaceCatalog.Model;

namespace Amazon.MarketplaceCatalog
{
    /// <summary>
    /// Interface for accessing MarketplaceCatalog
    ///
    /// Catalog API actions allow you to manage your entities through list, describe, and
    /// update capabilities. An entity can be a product or an offer on AWS Marketplace. 
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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMarketplaceCatalogPaginatorFactory Paginators { get; }
#endif


        
        #region  CancelChangeSet


        /// <summary>
        /// Used to cancel an open change request. Must be sent before the status of the request
        /// changes to <code>APPLYING</code>, the final stage of completing your change request.
        /// You can describe a change during the 60-day request history retention period for API
        /// calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelChangeSet service method.</param>
        /// 
        /// <returns>The response from the CancelChangeSet service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceInUseException">
        /// The resource is currently in use.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/CancelChangeSet">REST API Reference for CancelChangeSet Operation</seealso>
        CancelChangeSetResponse CancelChangeSet(CancelChangeSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelChangeSet operation on AmazonMarketplaceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelChangeSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/CancelChangeSet">REST API Reference for CancelChangeSet Operation</seealso>
        IAsyncResult BeginCancelChangeSet(CancelChangeSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelChangeSet.</param>
        /// 
        /// <returns>Returns a  CancelChangeSetResult from MarketplaceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/CancelChangeSet">REST API Reference for CancelChangeSet Operation</seealso>
        CancelChangeSetResponse EndCancelChangeSet(IAsyncResult asyncResult);

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
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        DescribeChangeSetResponse DescribeChangeSet(DescribeChangeSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet operation on AmazonMarketplaceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChangeSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        IAsyncResult BeginDescribeChangeSet(DescribeChangeSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChangeSet.</param>
        /// 
        /// <returns>Returns a  DescribeChangeSetResult from MarketplaceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        DescribeChangeSetResponse EndDescribeChangeSet(IAsyncResult asyncResult);

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
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotSupportedException">
        /// Currently, the specified resource is not supported.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/DescribeEntity">REST API Reference for DescribeEntity Operation</seealso>
        DescribeEntityResponse DescribeEntity(DescribeEntityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEntity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntity operation on AmazonMarketplaceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEntity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/DescribeEntity">REST API Reference for DescribeEntity Operation</seealso>
        IAsyncResult BeginDescribeEntity(DescribeEntityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEntity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEntity.</param>
        /// 
        /// <returns>Returns a  DescribeEntityResult from MarketplaceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/DescribeEntity">REST API Reference for DescribeEntity Operation</seealso>
        DescribeEntityResponse EndDescribeEntity(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChangeSets


        /// <summary>
        /// Returns the list of change sets owned by the account being used to make the call.
        /// You can filter this list by providing any combination of <code>entityId</code>, <code>ChangeSetName</code>,
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
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        ListChangeSetsResponse ListChangeSets(ListChangeSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChangeSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangeSets operation on AmazonMarketplaceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChangeSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        IAsyncResult BeginListChangeSets(ListChangeSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChangeSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChangeSets.</param>
        /// 
        /// <returns>Returns a  ListChangeSetsResult from MarketplaceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        ListChangeSetsResponse EndListChangeSets(IAsyncResult asyncResult);

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
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/ListEntities">REST API Reference for ListEntities Operation</seealso>
        ListEntitiesResponse ListEntities(ListEntitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntities operation on AmazonMarketplaceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/ListEntities">REST API Reference for ListEntities Operation</seealso>
        IAsyncResult BeginListEntities(ListEntitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntities.</param>
        /// 
        /// <returns>Returns a  ListEntitiesResult from MarketplaceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/ListEntities">REST API Reference for ListEntities Operation</seealso>
        ListEntitiesResponse EndListEntities(IAsyncResult asyncResult);

        #endregion
        
        #region  StartChangeSet


        /// <summary>
        /// This operation allows you to request changes for your entities. Within a single ChangeSet,
        /// you cannot start the same change type against the same entity multiple times. Additionally,
        /// when a ChangeSet is running, all the entities targeted by the different changes are
        /// locked until the ChangeSet has completed (either succeeded, cancelled, or failed).
        /// If you try to start a ChangeSet containing a change against an entity that is already
        /// locked, you will receive a <code>ResourceInUseException</code>.
        /// 
        ///  
        /// <para>
        /// For example, you cannot start the ChangeSet described in the <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/API_StartChangeSet.html#API_StartChangeSet_Examples">example</a>
        /// below because it contains two changes to execute the same change type (<code>AddRevisions</code>)
        /// against the same entity (<code>entity-id@1)</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChangeSet service method.</param>
        /// 
        /// <returns>The response from the StartChangeSet service method, as returned by MarketplaceCatalog.</returns>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.InternalServiceException">
        /// There was an internal service exception.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceInUseException">
        /// The resource is currently in use.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ResourceNotFoundException">
        /// The specified resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ServiceQuotaExceededException">
        /// The maximum number of open requests per account has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ThrottlingException">
        /// Too many requests.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceCatalog.Model.ValidationException">
        /// An error occurred during validation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/StartChangeSet">REST API Reference for StartChangeSet Operation</seealso>
        StartChangeSetResponse StartChangeSet(StartChangeSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartChangeSet operation on AmazonMarketplaceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartChangeSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/StartChangeSet">REST API Reference for StartChangeSet Operation</seealso>
        IAsyncResult BeginStartChangeSet(StartChangeSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartChangeSet.</param>
        /// 
        /// <returns>Returns a  StartChangeSetResult from MarketplaceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-catalog-2018-09-17/StartChangeSet">REST API Reference for StartChangeSet Operation</seealso>
        StartChangeSetResponse EndStartChangeSet(IAsyncResult asyncResult);

        #endregion
        
    }
}