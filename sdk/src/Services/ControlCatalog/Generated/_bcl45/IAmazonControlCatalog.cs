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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ControlCatalog.Model;

#pragma warning disable CS1570
namespace Amazon.ControlCatalog
{
    /// <summary>
    /// <para>Interface for accessing ControlCatalog</para>
    ///
    /// Welcome to the Amazon Web Services Control Catalog API reference. This guide is for
    /// developers who need detailed information about how to programmatically identify and
    /// filter the common controls and related metadata that are available to Amazon Web Services
    /// customers. This API reference provides descriptions, syntax, and usage examples for
    /// each of the actions and data types that are supported by Amazon Web Services Control
    /// Catalog. 
    /// 
    ///  
    /// <para>
    /// Use the following links to get started with the Amazon Web Services Control Catalog
    /// API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/API_Operations.html">Actions</a>:
    /// An alphabetical list of all Control Catalog API operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/API_Types.html">Data
    /// types</a>: An alphabetical list of all Control Catalog data types.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/CommonParameters.html">Common
    /// parameters</a>: Parameters that all operations can use.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/controlcatalog/latest/APIReference/CommonErrors.html">Common
    /// errors</a>: Client and server errors that all operations can return.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonControlCatalog : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IControlCatalogPaginatorFactory Paginators { get; }

        
        #region  ListCommonControls


        /// <summary>
        /// Returns a paginated list of common controls from the Amazon Web Services Control Catalog.
        /// 
        ///  
        /// <para>
        /// You can apply an optional filter to see common controls that have a specific objective.
        /// If you don’t provide a filter, the operation returns all common controls. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommonControls service method.</param>
        /// 
        /// <returns>The response from the ListCommonControls service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListCommonControls">REST API Reference for ListCommonControls Operation</seealso>
        ListCommonControlsResponse ListCommonControls(ListCommonControlsRequest request);



        /// <summary>
        /// Returns a paginated list of common controls from the Amazon Web Services Control Catalog.
        /// 
        ///  
        /// <para>
        /// You can apply an optional filter to see common controls that have a specific objective.
        /// If you don’t provide a filter, the operation returns all common controls. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommonControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommonControls service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListCommonControls">REST API Reference for ListCommonControls Operation</seealso>
        Task<ListCommonControlsResponse> ListCommonControlsAsync(ListCommonControlsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// Returns a paginated list of domains from the Amazon Web Services Control Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse ListDomains(ListDomainsRequest request);



        /// <summary>
        /// Returns a paginated list of domains from the Amazon Web Services Control Catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListDomains">REST API Reference for ListDomains Operation</seealso>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListObjectives


        /// <summary>
        /// Returns a paginated list of objectives from the Amazon Web Services Control Catalog.
        /// 
        ///  
        /// <para>
        /// You can apply an optional filter to see the objectives that belong to a specific domain.
        /// If you don’t provide a filter, the operation returns all objectives. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectives service method.</param>
        /// 
        /// <returns>The response from the ListObjectives service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListObjectives">REST API Reference for ListObjectives Operation</seealso>
        ListObjectivesResponse ListObjectives(ListObjectivesRequest request);



        /// <summary>
        /// Returns a paginated list of objectives from the Amazon Web Services Control Catalog.
        /// 
        ///  
        /// <para>
        /// You can apply an optional filter to see the objectives that belong to a specific domain.
        /// If you don’t provide a filter, the operation returns all objectives. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjectives service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjectives service method, as returned by ControlCatalog.</returns>
        /// <exception cref="Amazon.ControlCatalog.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.InternalServerException">
        /// An internal service error occurred during the processing of your request. Try again
        /// later.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.ControlCatalog.Model.ValidationException">
        /// The request has invalid or missing parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/controlcatalog-2018-05-10/ListObjectives">REST API Reference for ListObjectives Operation</seealso>
        Task<ListObjectivesResponse> ListObjectivesAsync(ListObjectivesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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