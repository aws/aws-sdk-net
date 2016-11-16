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
using System.Collections.Generic;

using Amazon.Runtime;
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
    public partial interface IAmazonServiceCatalog : IAmazonService, IDisposable
    {

        
        #region  AcceptPortfolioShare


        /// <summary>
        /// Accepts an offer to share a portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPortfolioShare service method.</param>
        /// 
        /// <returns>The response from the AcceptPortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        AcceptPortfolioShareResponse AcceptPortfolioShare(AcceptPortfolioShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptPortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptPortfolioShare operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptPortfolioShare
        ///         operation.</returns>
        IAsyncResult BeginAcceptPortfolioShare(AcceptPortfolioShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptPortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptPortfolioShare.</param>
        /// 
        /// <returns>Returns a  AcceptPortfolioShareResult from ServiceCatalog.</returns>
        AcceptPortfolioShareResponse EndAcceptPortfolioShare(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociatePrincipalWithPortfolio


        /// <summary>
        /// Associates the specified principal ARN with the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePrincipalWithPortfolio service method.</param>
        /// 
        /// <returns>The response from the AssociatePrincipalWithPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        AssociatePrincipalWithPortfolioResponse AssociatePrincipalWithPortfolio(AssociatePrincipalWithPortfolioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePrincipalWithPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePrincipalWithPortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePrincipalWithPortfolio
        ///         operation.</returns>
        IAsyncResult BeginAssociatePrincipalWithPortfolio(AssociatePrincipalWithPortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePrincipalWithPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePrincipalWithPortfolio.</param>
        /// 
        /// <returns>Returns a  AssociatePrincipalWithPortfolioResult from ServiceCatalog.</returns>
        AssociatePrincipalWithPortfolioResponse EndAssociatePrincipalWithPortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateProductWithPortfolio


        /// <summary>
        /// Associates a product with a portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProductWithPortfolio service method.</param>
        /// 
        /// <returns>The response from the AssociateProductWithPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        AssociateProductWithPortfolioResponse AssociateProductWithPortfolio(AssociateProductWithPortfolioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateProductWithPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateProductWithPortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateProductWithPortfolio
        ///         operation.</returns>
        IAsyncResult BeginAssociateProductWithPortfolio(AssociateProductWithPortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateProductWithPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateProductWithPortfolio.</param>
        /// 
        /// <returns>Returns a  AssociateProductWithPortfolioResult from ServiceCatalog.</returns>
        AssociateProductWithPortfolioResponse EndAssociateProductWithPortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConstraint


        /// <summary>
        /// Creates a new constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConstraint service method.</param>
        /// 
        /// <returns>The response from the CreateConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        CreateConstraintResponse CreateConstraint(CreateConstraintRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConstraint operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConstraint
        ///         operation.</returns>
        IAsyncResult BeginCreateConstraint(CreateConstraintRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConstraint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConstraint.</param>
        /// 
        /// <returns>Returns a  CreateConstraintResult from ServiceCatalog.</returns>
        CreateConstraintResponse EndCreateConstraint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePortfolio


        /// <summary>
        /// Creates a new portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolio service method.</param>
        /// 
        /// <returns>The response from the CreatePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        CreatePortfolioResponse CreatePortfolio(CreatePortfolioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePortfolio
        ///         operation.</returns>
        IAsyncResult BeginCreatePortfolio(CreatePortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePortfolio.</param>
        /// 
        /// <returns>Returns a  CreatePortfolioResult from ServiceCatalog.</returns>
        CreatePortfolioResponse EndCreatePortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePortfolioShare


        /// <summary>
        /// Creates a new portfolio share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolioShare service method.</param>
        /// 
        /// <returns>The response from the CreatePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        CreatePortfolioShareResponse CreatePortfolioShare(CreatePortfolioShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolioShare operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePortfolioShare
        ///         operation.</returns>
        IAsyncResult BeginCreatePortfolioShare(CreatePortfolioShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePortfolioShare.</param>
        /// 
        /// <returns>Returns a  CreatePortfolioShareResult from ServiceCatalog.</returns>
        CreatePortfolioShareResponse EndCreatePortfolioShare(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProduct


        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProduct service method.</param>
        /// 
        /// <returns>The response from the CreateProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        CreateProductResponse CreateProduct(CreateProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProduct
        ///         operation.</returns>
        IAsyncResult BeginCreateProduct(CreateProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProduct.</param>
        /// 
        /// <returns>Returns a  CreateProductResult from ServiceCatalog.</returns>
        CreateProductResponse EndCreateProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProvisioningArtifact


        /// <summary>
        /// Create a new provisioning artifact for the specified product. This operation will
        /// not work with a product that has been shared with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the CreateProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        CreateProvisioningArtifactResponse CreateProvisioningArtifact(CreateProvisioningArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningArtifact operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProvisioningArtifact
        ///         operation.</returns>
        IAsyncResult BeginCreateProvisioningArtifact(CreateProvisioningArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  CreateProvisioningArtifactResult from ServiceCatalog.</returns>
        CreateProvisioningArtifactResponse EndCreateProvisioningArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConstraint


        /// <summary>
        /// Deletes the specified constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConstraint service method.</param>
        /// 
        /// <returns>The response from the DeleteConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DeleteConstraintResponse DeleteConstraint(DeleteConstraintRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConstraint operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConstraint
        ///         operation.</returns>
        IAsyncResult BeginDeleteConstraint(DeleteConstraintRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConstraint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConstraint.</param>
        /// 
        /// <returns>Returns a  DeleteConstraintResult from ServiceCatalog.</returns>
        DeleteConstraintResponse EndDeleteConstraint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePortfolio


        /// <summary>
        /// Deletes the specified portfolio. This operation will not work with a portfolio that
        /// has been shared with you or if it has products, users, constraints, or shared accounts
        /// associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolio service method.</param>
        /// 
        /// <returns>The response from the DeletePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// The operation was requested against a resource that is currently in use. Free the
        /// resource from use and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DeletePortfolioResponse DeletePortfolio(DeletePortfolioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePortfolio
        ///         operation.</returns>
        IAsyncResult BeginDeletePortfolio(DeletePortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePortfolio.</param>
        /// 
        /// <returns>Returns a  DeletePortfolioResult from ServiceCatalog.</returns>
        DeletePortfolioResponse EndDeletePortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePortfolioShare


        /// <summary>
        /// Deletes the specified portfolio share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolioShare service method.</param>
        /// 
        /// <returns>The response from the DeletePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DeletePortfolioShareResponse DeletePortfolioShare(DeletePortfolioShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolioShare operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePortfolioShare
        ///         operation.</returns>
        IAsyncResult BeginDeletePortfolioShare(DeletePortfolioShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePortfolioShare.</param>
        /// 
        /// <returns>Returns a  DeletePortfolioShareResult from ServiceCatalog.</returns>
        DeletePortfolioShareResponse EndDeletePortfolioShare(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProduct


        /// <summary>
        /// Deletes the specified product. This operation will not work with a product that has
        /// been shared with you or is associated with a portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProduct service method.</param>
        /// 
        /// <returns>The response from the DeleteProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// The operation was requested against a resource that is currently in use. Free the
        /// resource from use and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DeleteProductResponse DeleteProduct(DeleteProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProduct
        ///         operation.</returns>
        IAsyncResult BeginDeleteProduct(DeleteProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProduct.</param>
        /// 
        /// <returns>Returns a  DeleteProductResult from ServiceCatalog.</returns>
        DeleteProductResponse EndDeleteProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProvisioningArtifact


        /// <summary>
        /// Deletes the specified provisioning artifact. This operation will not work on a provisioning
        /// artifact associated with a product that has been shared with you, or on the last provisioning
        /// artifact associated with a product (a product must have at least one provisioning
        /// artifact).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// The operation was requested against a resource that is currently in use. Free the
        /// resource from use and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DeleteProvisioningArtifactResponse DeleteProvisioningArtifact(DeleteProvisioningArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningArtifact operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProvisioningArtifact
        ///         operation.</returns>
        IAsyncResult BeginDeleteProvisioningArtifact(DeleteProvisioningArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  DeleteProvisioningArtifactResult from ServiceCatalog.</returns>
        DeleteProvisioningArtifactResponse EndDeleteProvisioningArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConstraint


        /// <summary>
        /// Retrieves detailed information for a specified constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConstraint service method.</param>
        /// 
        /// <returns>The response from the DescribeConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DescribeConstraintResponse DescribeConstraint(DescribeConstraintRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConstraint operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConstraint
        ///         operation.</returns>
        IAsyncResult BeginDescribeConstraint(DescribeConstraintRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConstraint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConstraint.</param>
        /// 
        /// <returns>Returns a  DescribeConstraintResult from ServiceCatalog.</returns>
        DescribeConstraintResponse EndDescribeConstraint(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePortfolio


        /// <summary>
        /// Retrieves detailed information and any tags associated with the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolio service method.</param>
        /// 
        /// <returns>The response from the DescribePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DescribePortfolioResponse DescribePortfolio(DescribePortfolioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePortfolio
        ///         operation.</returns>
        IAsyncResult BeginDescribePortfolio(DescribePortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePortfolio.</param>
        /// 
        /// <returns>Returns a  DescribePortfolioResult from ServiceCatalog.</returns>
        DescribePortfolioResponse EndDescribePortfolio(IAsyncResult asyncResult);

        #endregion
        
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProduct
        ///         operation.</returns>
        IAsyncResult BeginDescribeProduct(DescribeProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProduct.</param>
        /// 
        /// <returns>Returns a  DescribeProductResult from ServiceCatalog.</returns>
        DescribeProductResponse EndDescribeProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProductAsAdmin


        /// <summary>
        /// Retrieves information about a specified product, run with administrator access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductAsAdmin service method.</param>
        /// 
        /// <returns>The response from the DescribeProductAsAdmin service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DescribeProductAsAdminResponse DescribeProductAsAdmin(DescribeProductAsAdminRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProductAsAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductAsAdmin operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProductAsAdmin
        ///         operation.</returns>
        IAsyncResult BeginDescribeProductAsAdmin(DescribeProductAsAdminRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProductAsAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProductAsAdmin.</param>
        /// 
        /// <returns>Returns a  DescribeProductAsAdminResult from ServiceCatalog.</returns>
        DescribeProductAsAdminResponse EndDescribeProductAsAdmin(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductView operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProductView
        ///         operation.</returns>
        IAsyncResult BeginDescribeProductView(DescribeProductViewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProductView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProductView.</param>
        /// 
        /// <returns>Returns a  DescribeProductViewResult from ServiceCatalog.</returns>
        DescribeProductViewResponse EndDescribeProductView(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProvisioningArtifact


        /// <summary>
        /// Retrieves detailed information about the specified provisioning artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DescribeProvisioningArtifactResponse DescribeProvisioningArtifact(DescribeProvisioningArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningArtifact operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProvisioningArtifact
        ///         operation.</returns>
        IAsyncResult BeginDescribeProvisioningArtifact(DescribeProvisioningArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  DescribeProvisioningArtifactResult from ServiceCatalog.</returns>
        DescribeProvisioningArtifactResponse EndDescribeProvisioningArtifact(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningParameters operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProvisioningParameters
        ///         operation.</returns>
        IAsyncResult BeginDescribeProvisioningParameters(DescribeProvisioningParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProvisioningParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProvisioningParameters.</param>
        /// 
        /// <returns>Returns a  DescribeProvisioningParametersResult from ServiceCatalog.</returns>
        DescribeProvisioningParametersResponse EndDescribeProvisioningParameters(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecord operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecord
        ///         operation.</returns>
        IAsyncResult BeginDescribeRecord(DescribeRecordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecord.</param>
        /// 
        /// <returns>Returns a  DescribeRecordResult from ServiceCatalog.</returns>
        DescribeRecordResponse EndDescribeRecord(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociatePrincipalFromPortfolio


        /// <summary>
        /// Disassociates a previously associated principal ARN from a specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePrincipalFromPortfolio service method.</param>
        /// 
        /// <returns>The response from the DisassociatePrincipalFromPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DisassociatePrincipalFromPortfolioResponse DisassociatePrincipalFromPortfolio(DisassociatePrincipalFromPortfolioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePrincipalFromPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePrincipalFromPortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePrincipalFromPortfolio
        ///         operation.</returns>
        IAsyncResult BeginDisassociatePrincipalFromPortfolio(DisassociatePrincipalFromPortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePrincipalFromPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePrincipalFromPortfolio.</param>
        /// 
        /// <returns>Returns a  DisassociatePrincipalFromPortfolioResult from ServiceCatalog.</returns>
        DisassociatePrincipalFromPortfolioResponse EndDisassociatePrincipalFromPortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateProductFromPortfolio


        /// <summary>
        /// Disassociates the specified product from the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProductFromPortfolio service method.</param>
        /// 
        /// <returns>The response from the DisassociateProductFromPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        DisassociateProductFromPortfolioResponse DisassociateProductFromPortfolio(DisassociateProductFromPortfolioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateProductFromPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProductFromPortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateProductFromPortfolio
        ///         operation.</returns>
        IAsyncResult BeginDisassociateProductFromPortfolio(DisassociateProductFromPortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateProductFromPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateProductFromPortfolio.</param>
        /// 
        /// <returns>Returns a  DisassociateProductFromPortfolioResult from ServiceCatalog.</returns>
        DisassociateProductFromPortfolioResponse EndDisassociateProductFromPortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAcceptedPortfolioShares


        /// <summary>
        /// Lists details of all portfolios for which sharing was accepted by this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAcceptedPortfolioShares service method.</param>
        /// 
        /// <returns>The response from the ListAcceptedPortfolioShares service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        ListAcceptedPortfolioSharesResponse ListAcceptedPortfolioShares(ListAcceptedPortfolioSharesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAcceptedPortfolioShares operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAcceptedPortfolioShares operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAcceptedPortfolioShares
        ///         operation.</returns>
        IAsyncResult BeginListAcceptedPortfolioShares(ListAcceptedPortfolioSharesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAcceptedPortfolioShares operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAcceptedPortfolioShares.</param>
        /// 
        /// <returns>Returns a  ListAcceptedPortfolioSharesResult from ServiceCatalog.</returns>
        ListAcceptedPortfolioSharesResponse EndListAcceptedPortfolioShares(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConstraintsForPortfolio


        /// <summary>
        /// Retrieves detailed constraint information for the specified portfolio and product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConstraintsForPortfolio service method.</param>
        /// 
        /// <returns>The response from the ListConstraintsForPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        ListConstraintsForPortfolioResponse ListConstraintsForPortfolio(ListConstraintsForPortfolioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConstraintsForPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConstraintsForPortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConstraintsForPortfolio
        ///         operation.</returns>
        IAsyncResult BeginListConstraintsForPortfolio(ListConstraintsForPortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConstraintsForPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConstraintsForPortfolio.</param>
        /// 
        /// <returns>Returns a  ListConstraintsForPortfolioResult from ServiceCatalog.</returns>
        ListConstraintsForPortfolioResponse EndListConstraintsForPortfolio(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchPaths operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLaunchPaths
        ///         operation.</returns>
        IAsyncResult BeginListLaunchPaths(ListLaunchPathsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLaunchPaths operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLaunchPaths.</param>
        /// 
        /// <returns>Returns a  ListLaunchPathsResult from ServiceCatalog.</returns>
        ListLaunchPathsResponse EndListLaunchPaths(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPortfolioAccess


        /// <summary>
        /// Lists the account IDs that have been authorized sharing of the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolioAccess service method.</param>
        /// 
        /// <returns>The response from the ListPortfolioAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        ListPortfolioAccessResponse ListPortfolioAccess(ListPortfolioAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPortfolioAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolioAccess operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPortfolioAccess
        ///         operation.</returns>
        IAsyncResult BeginListPortfolioAccess(ListPortfolioAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPortfolioAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPortfolioAccess.</param>
        /// 
        /// <returns>Returns a  ListPortfolioAccessResult from ServiceCatalog.</returns>
        ListPortfolioAccessResponse EndListPortfolioAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPortfolios


        /// <summary>
        /// Lists all portfolios in the catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolios service method.</param>
        /// 
        /// <returns>The response from the ListPortfolios service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        ListPortfoliosResponse ListPortfolios(ListPortfoliosRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPortfolios operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolios operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPortfolios
        ///         operation.</returns>
        IAsyncResult BeginListPortfolios(ListPortfoliosRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPortfolios operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPortfolios.</param>
        /// 
        /// <returns>Returns a  ListPortfoliosResult from ServiceCatalog.</returns>
        ListPortfoliosResponse EndListPortfolios(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPortfoliosForProduct


        /// <summary>
        /// Lists all portfolios that the specified product is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfoliosForProduct service method.</param>
        /// 
        /// <returns>The response from the ListPortfoliosForProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        ListPortfoliosForProductResponse ListPortfoliosForProduct(ListPortfoliosForProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPortfoliosForProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPortfoliosForProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPortfoliosForProduct
        ///         operation.</returns>
        IAsyncResult BeginListPortfoliosForProduct(ListPortfoliosForProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPortfoliosForProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPortfoliosForProduct.</param>
        /// 
        /// <returns>Returns a  ListPortfoliosForProductResult from ServiceCatalog.</returns>
        ListPortfoliosForProductResponse EndListPortfoliosForProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPrincipalsForPortfolio


        /// <summary>
        /// Lists all principal ARNs associated with the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalsForPortfolio service method.</param>
        /// 
        /// <returns>The response from the ListPrincipalsForPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        ListPrincipalsForPortfolioResponse ListPrincipalsForPortfolio(ListPrincipalsForPortfolioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrincipalsForPortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalsForPortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPrincipalsForPortfolio
        ///         operation.</returns>
        IAsyncResult BeginListPrincipalsForPortfolio(ListPrincipalsForPortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPrincipalsForPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPrincipalsForPortfolio.</param>
        /// 
        /// <returns>Returns a  ListPrincipalsForPortfolioResult from ServiceCatalog.</returns>
        ListPrincipalsForPortfolioResponse EndListPrincipalsForPortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProvisioningArtifacts


        /// <summary>
        /// Lists all provisioning artifacts associated with the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListProvisioningArtifacts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        ListProvisioningArtifactsResponse ListProvisioningArtifacts(ListProvisioningArtifactsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisioningArtifacts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifacts operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProvisioningArtifacts
        ///         operation.</returns>
        IAsyncResult BeginListProvisioningArtifacts(ListProvisioningArtifactsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProvisioningArtifacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProvisioningArtifacts.</param>
        /// 
        /// <returns>Returns a  ListProvisioningArtifactsResult from ServiceCatalog.</returns>
        ListProvisioningArtifactsResponse EndListProvisioningArtifacts(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListRecordHistory operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecordHistory
        ///         operation.</returns>
        IAsyncResult BeginListRecordHistory(ListRecordHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecordHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecordHistory.</param>
        /// 
        /// <returns>Returns a  ListRecordHistoryResult from ServiceCatalog.</returns>
        ListRecordHistoryResponse EndListRecordHistory(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ProvisionProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndProvisionProduct
        ///         operation.</returns>
        IAsyncResult BeginProvisionProduct(ProvisionProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ProvisionProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginProvisionProduct.</param>
        /// 
        /// <returns>Returns a  ProvisionProductResult from ServiceCatalog.</returns>
        ProvisionProductResponse EndProvisionProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectPortfolioShare


        /// <summary>
        /// Rejects an offer to share a portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectPortfolioShare service method.</param>
        /// 
        /// <returns>The response from the RejectPortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        RejectPortfolioShareResponse RejectPortfolioShare(RejectPortfolioShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectPortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectPortfolioShare operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectPortfolioShare
        ///         operation.</returns>
        IAsyncResult BeginRejectPortfolioShare(RejectPortfolioShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectPortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectPortfolioShare.</param>
        /// 
        /// <returns>Returns a  RejectPortfolioShareResult from ServiceCatalog.</returns>
        RejectPortfolioShareResponse EndRejectPortfolioShare(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ScanProvisionedProducts operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndScanProvisionedProducts
        ///         operation.</returns>
        IAsyncResult BeginScanProvisionedProducts(ScanProvisionedProductsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ScanProvisionedProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginScanProvisionedProducts.</param>
        /// 
        /// <returns>Returns a  ScanProvisionedProductsResult from ServiceCatalog.</returns>
        ScanProvisionedProductsResponse EndScanProvisionedProducts(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the SearchProducts operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchProducts
        ///         operation.</returns>
        IAsyncResult BeginSearchProducts(SearchProductsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchProducts.</param>
        /// 
        /// <returns>Returns a  SearchProductsResult from ServiceCatalog.</returns>
        SearchProductsResponse EndSearchProducts(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchProductsAsAdmin


        /// <summary>
        /// Retrieves summary and status information about all products created within the caller's
        /// account. If a portfolio ID is provided, this operation retrieves information for only
        /// those products that are associated with the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProductsAsAdmin service method.</param>
        /// 
        /// <returns>The response from the SearchProductsAsAdmin service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        SearchProductsAsAdminResponse SearchProductsAsAdmin(SearchProductsAsAdminRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchProductsAsAdmin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProductsAsAdmin operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchProductsAsAdmin
        ///         operation.</returns>
        IAsyncResult BeginSearchProductsAsAdmin(SearchProductsAsAdminRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchProductsAsAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchProductsAsAdmin.</param>
        /// 
        /// <returns>Returns a  SearchProductsAsAdminResult from ServiceCatalog.</returns>
        SearchProductsAsAdminResponse EndSearchProductsAsAdmin(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the TerminateProvisionedProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateProvisionedProduct
        ///         operation.</returns>
        IAsyncResult BeginTerminateProvisionedProduct(TerminateProvisionedProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateProvisionedProduct.</param>
        /// 
        /// <returns>Returns a  TerminateProvisionedProductResult from ServiceCatalog.</returns>
        TerminateProvisionedProductResponse EndTerminateProvisionedProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConstraint


        /// <summary>
        /// Updates an existing constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConstraint service method.</param>
        /// 
        /// <returns>The response from the UpdateConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        UpdateConstraintResponse UpdateConstraint(UpdateConstraintRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConstraint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConstraint operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConstraint
        ///         operation.</returns>
        IAsyncResult BeginUpdateConstraint(UpdateConstraintRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConstraint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConstraint.</param>
        /// 
        /// <returns>Returns a  UpdateConstraintResult from ServiceCatalog.</returns>
        UpdateConstraintResponse EndUpdateConstraint(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePortfolio


        /// <summary>
        /// Updates the specified portfolio's details. This operation will not work with a product
        /// that has been shared with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortfolio service method.</param>
        /// 
        /// <returns>The response from the UpdatePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Reduce
        /// the resource use or increase the service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        UpdatePortfolioResponse UpdatePortfolio(UpdatePortfolioRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePortfolio operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortfolio operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePortfolio
        ///         operation.</returns>
        IAsyncResult BeginUpdatePortfolio(UpdatePortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePortfolio.</param>
        /// 
        /// <returns>Returns a  UpdatePortfolioResult from ServiceCatalog.</returns>
        UpdatePortfolioResponse EndUpdatePortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProduct


        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProduct service method.</param>
        /// 
        /// <returns>The response from the UpdateProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        UpdateProductResponse UpdateProduct(UpdateProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProduct
        ///         operation.</returns>
        IAsyncResult BeginUpdateProduct(UpdateProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProduct.</param>
        /// 
        /// <returns>Returns a  UpdateProductResult from ServiceCatalog.</returns>
        UpdateProductResponse EndUpdateProduct(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProvisionedProduct
        ///         operation.</returns>
        IAsyncResult BeginUpdateProvisionedProduct(UpdateProvisionedProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProvisionedProduct.</param>
        /// 
        /// <returns>Returns a  UpdateProvisionedProductResult from ServiceCatalog.</returns>
        UpdateProvisionedProductResponse EndUpdateProvisionedProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProvisioningArtifact


        /// <summary>
        /// Updates an existing provisioning artifact's information. This operation will not work
        /// on a provisioning artifact associated with a product that has been shared with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are invalid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        UpdateProvisioningArtifactResponse UpdateProvisioningArtifact(UpdateProvisioningArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisioningArtifact operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProvisioningArtifact
        ///         operation.</returns>
        IAsyncResult BeginUpdateProvisioningArtifact(UpdateProvisioningArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  UpdateProvisioningArtifactResult from ServiceCatalog.</returns>
        UpdateProvisioningArtifactResponse EndUpdateProvisioningArtifact(IAsyncResult asyncResult);

        #endregion
        
    }
}