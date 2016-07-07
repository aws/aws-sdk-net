/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ServiceCatalog.Model;

namespace Amazon.ServiceCatalog
{
    /// <summary>
    /// Interface for accessing ServiceCatalog
    ///
    /// AWS Service Catalog 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://aws.amazon.com/servicecatalog/">AWS Service Catalog</a> allows organizations
    /// to create and manage catalogs of IT services that are approved for use on AWS. This
    /// documentation provides reference material for the AWS Service Catalog end user API.
    /// To get the most out of this documentation, you need to be familiar with the terminology
    /// discussed in <a href="http://docs.aws.amazon.com/servicecatalog/latest/userguide/what-is_concepts.html">AWS
    /// Service Catalog Concepts</a>.
    /// </para>
    ///  
    /// <para>
    ///  <i>Additional Resources</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/servicecatalog/latest/adminguide/introduction.html">AWS
    /// Service Catalog Administrator Guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/servicecatalog/latest/userguide/introduction.html">AWS
    /// Service Catalog User Guide</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonServiceCatalog : IDisposable
    {

        
        #region  DescribeProduct


        /// <summary>
        /// Retrieves information about a specified product.
        /// 
        ///  
        /// <para>
        /// This operation is functionally identical to <a>DescribeProductView</a> except that
        /// it takes as input <code>ProductId</code> instead of <code>ProductViewId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProduct service method.</param>
        /// 
        /// <returns>The response from the DescribeProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DescribeProductResponse DescribeProduct(DescribeProductRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeProductResponse> DescribeProductAsync(DescribeProductRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeProductView


        /// <summary>
        /// Retrieves information about a specified product.
        /// 
        ///  
        /// <para>
        /// This operation is functionally identical to <a>DescribeProduct</a> except that it
        /// takes as input <code>ProductViewId</code> instead of <code>ProductId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductView service method.</param>
        /// 
        /// <returns>The response from the DescribeProductView service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DescribeProductViewResponse DescribeProductView(DescribeProductViewRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProductView operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductView operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeProductViewResponse> DescribeProductViewAsync(DescribeProductViewRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeProvisioningParameters


        /// <summary>
        /// Provides information about parameters required to provision a specified product in
        /// a specified manner. Use this operation to obtain the list of <code>ProvisioningArtifactParameters</code>
        /// parameters available to call the <a>ProvisionProduct</a> operation for the specified
        /// product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisioningParameters service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DescribeProvisioningParametersResponse DescribeProvisioningParameters(DescribeProvisioningParametersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisioningParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeProvisioningParametersResponse> DescribeProvisioningParametersAsync(DescribeProvisioningParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRecord


        /// <summary>
        /// Retrieves a paginated list of the full details of a specific request. Use this operation
        /// after calling a request operation (<a>ProvisionProduct</a>, <a>TerminateProvisionedProduct</a>,
        /// or <a>UpdateProvisionedProduct</a>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecord service method.</param>
        /// 
        /// <returns>The response from the DescribeRecord service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DescribeRecordResponse DescribeRecord(DescribeRecordRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecord operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeRecordResponse> DescribeRecordAsync(DescribeRecordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLaunchPaths


        /// <summary>
        /// Returns a paginated list of all paths to a specified product. A path is how the user
        /// has access to a specified product, and is necessary when provisioning a product. A
        /// path also determines the constraints put on the product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchPaths service method.</param>
        /// 
        /// <returns>The response from the ListLaunchPaths service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        ListLaunchPathsResponse ListLaunchPaths(ListLaunchPathsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListLaunchPaths operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchPaths operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListLaunchPathsResponse> ListLaunchPathsAsync(ListLaunchPathsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRecordHistory


        /// <summary>
        /// Returns a paginated list of all performed requests, in the form of RecordDetails objects
        /// that are filtered as specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecordHistory service method.</param>
        /// 
        /// <returns>The response from the ListRecordHistory service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        ListRecordHistoryResponse ListRecordHistory(ListRecordHistoryRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListRecordHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecordHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListRecordHistoryResponse> ListRecordHistoryAsync(ListRecordHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ProvisionProduct


        /// <summary>
        /// Requests a <i>Provision</i> of a specified product. A <i>ProvisionedProduct</i> is
        /// a resourced instance for a product. For example, provisioning a CloudFormation-template-backed
        /// product results in launching a CloudFormation stack and all the underlying resources
        /// that come with it. 
        /// 
        ///  
        /// <para>
        /// You can check the status of this request using the <a>DescribeRecord</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionProduct service method.</param>
        /// 
        /// <returns>The response from the ProvisionProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        ProvisionProductResponse ProvisionProduct(ProvisionProductRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ProvisionProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ProvisionProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ProvisionProductResponse> ProvisionProductAsync(ProvisionProductRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ScanProvisionedProducts


        /// <summary>
        /// Returns a paginated list of all the ProvisionedProduct objects that are currently
        /// available (not terminated).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScanProvisionedProducts service method.</param>
        /// 
        /// <returns>The response from the ScanProvisionedProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        ScanProvisionedProductsResponse ScanProvisionedProducts(ScanProvisionedProductsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ScanProvisionedProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ScanProvisionedProducts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ScanProvisionedProductsResponse> ScanProvisionedProductsAsync(ScanProvisionedProductsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchProducts


        /// <summary>
        /// Returns a paginated list all of the <code>Products</code> objects to which the caller
        /// has access. 
        /// 
        ///  
        /// <para>
        /// The output of this operation can be used as input for other operations, such as <a>DescribeProductView</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProducts service method.</param>
        /// 
        /// <returns>The response from the SearchProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        SearchProductsResponse SearchProducts(SearchProductsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SearchProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProducts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SearchProductsResponse> SearchProductsAsync(SearchProductsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TerminateProvisionedProduct


        /// <summary>
        /// Requests termination of an existing ProvisionedProduct object. If there are <code>Tags</code>
        /// associated with the object, they are terminated when the ProvisionedProduct object
        /// is terminated. 
        /// 
        ///  
        /// <para>
        /// This operation does not delete any records associated with the ProvisionedProduct
        /// object.
        /// </para>
        ///  
        /// <para>
        /// You can check the status of this request using the <a>DescribeRecord</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the TerminateProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        TerminateProvisionedProductResponse TerminateProvisionedProduct(TerminateProvisionedProductRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateProvisionedProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TerminateProvisionedProductResponse> TerminateProvisionedProductAsync(TerminateProvisionedProductRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateProvisionedProduct


        /// <summary>
        /// Requests updates to the configuration of an existing ProvisionedProduct object. If
        /// there are tags associated with the object, they cannot be updated or added with this
        /// operation. Depending on the specific updates requested, this operation may update
        /// with no interruption, with some interruption, or replace the ProvisionedProduct object
        /// entirely. 
        /// 
        ///  
        /// <para>
        /// You can check the status of this request using the <a>DescribeRecord</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        UpdateProvisionedProductResponse UpdateProvisionedProduct(UpdateProvisionedProductRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProduct operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateProvisionedProductResponse> UpdateProvisionedProductAsync(UpdateProvisionedProductRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}