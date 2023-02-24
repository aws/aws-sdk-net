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
    /// Service Catalog 
    /// <para>
    ///  <a href="http://aws.amazon.com/servicecatalog">Service Catalog</a> enables organizations
    /// to create and manage catalogs of IT services that are approved for Amazon Web Services.
    /// To get the most out of this documentation, you should be familiar with the terminology
    /// discussed in <a href="http://docs.aws.amazon.com/servicecatalog/latest/adminguide/what-is_concepts.html">Service
    /// Catalog Concepts</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonServiceCatalog : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IServiceCatalogPaginatorFactory Paginators { get; }
#endif


        
        #region  AcceptPortfolioShare


        /// <summary>
        /// Accepts an offer to share the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPortfolioShare service method.</param>
        /// 
        /// <returns>The response from the AcceptPortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AcceptPortfolioShare">REST API Reference for AcceptPortfolioShare Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AcceptPortfolioShare">REST API Reference for AcceptPortfolioShare Operation</seealso>
        IAsyncResult BeginAcceptPortfolioShare(AcceptPortfolioShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptPortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptPortfolioShare.</param>
        /// 
        /// <returns>Returns a  AcceptPortfolioShareResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AcceptPortfolioShare">REST API Reference for AcceptPortfolioShare Operation</seealso>
        AcceptPortfolioShareResponse EndAcceptPortfolioShare(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateBudgetWithResource


        /// <summary>
        /// Associates the specified budget with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateBudgetWithResource service method.</param>
        /// 
        /// <returns>The response from the AssociateBudgetWithResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateBudgetWithResource">REST API Reference for AssociateBudgetWithResource Operation</seealso>
        AssociateBudgetWithResourceResponse AssociateBudgetWithResource(AssociateBudgetWithResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateBudgetWithResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateBudgetWithResource operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateBudgetWithResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateBudgetWithResource">REST API Reference for AssociateBudgetWithResource Operation</seealso>
        IAsyncResult BeginAssociateBudgetWithResource(AssociateBudgetWithResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateBudgetWithResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateBudgetWithResource.</param>
        /// 
        /// <returns>Returns a  AssociateBudgetWithResourceResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateBudgetWithResource">REST API Reference for AssociateBudgetWithResource Operation</seealso>
        AssociateBudgetWithResourceResponse EndAssociateBudgetWithResource(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociatePrincipalWithPortfolio


        /// <summary>
        /// Associates the specified principal ARN with the specified portfolio.
        /// 
        ///  
        /// <para>
        /// If you share the portfolio with principal name sharing enabled, the <code>PrincipalARN</code>
        /// association is included in the share. 
        /// </para>
        ///  
        /// <para>
        /// The <code>PortfolioID</code>, <code>PrincipalARN</code>, and <code>PrincipalType</code>
        /// parameters are required. 
        /// </para>
        ///  
        /// <para>
        /// You can associate a maximum of 10 Principals with a portfolio using <code>PrincipalType</code>
        /// as <code>IAM_PATTERN</code> 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you associate a principal with portfolio, a potential privilege escalation path
        /// may occur when that portfolio is then shared with other accounts. For a user in a
        /// recipient account who is <i>not</i> an Service Catalog Admin, but still has the ability
        /// to create Principals (Users/Groups/Roles), that user could create a role that matches
        /// a principal name association for the portfolio. Although this user may not know which
        /// principal names are associated through Service Catalog, they may be able to guess
        /// the user. If this potential escalation path is a concern, then Service Catalog recommends
        /// using <code>PrincipalType</code> as <code>IAM</code>. With this configuration, the
        /// <code>PrincipalARN</code> must already exist in the recipient account before it can
        /// be associated. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePrincipalWithPortfolio service method.</param>
        /// 
        /// <returns>The response from the AssociatePrincipalWithPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociatePrincipalWithPortfolio">REST API Reference for AssociatePrincipalWithPortfolio Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociatePrincipalWithPortfolio">REST API Reference for AssociatePrincipalWithPortfolio Operation</seealso>
        IAsyncResult BeginAssociatePrincipalWithPortfolio(AssociatePrincipalWithPortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePrincipalWithPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePrincipalWithPortfolio.</param>
        /// 
        /// <returns>Returns a  AssociatePrincipalWithPortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociatePrincipalWithPortfolio">REST API Reference for AssociatePrincipalWithPortfolio Operation</seealso>
        AssociatePrincipalWithPortfolioResponse EndAssociatePrincipalWithPortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateProductWithPortfolio


        /// <summary>
        /// Associates the specified product with the specified portfolio.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProductWithPortfolio service method.</param>
        /// 
        /// <returns>The response from the AssociateProductWithPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateProductWithPortfolio">REST API Reference for AssociateProductWithPortfolio Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateProductWithPortfolio">REST API Reference for AssociateProductWithPortfolio Operation</seealso>
        IAsyncResult BeginAssociateProductWithPortfolio(AssociateProductWithPortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateProductWithPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateProductWithPortfolio.</param>
        /// 
        /// <returns>Returns a  AssociateProductWithPortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateProductWithPortfolio">REST API Reference for AssociateProductWithPortfolio Operation</seealso>
        AssociateProductWithPortfolioResponse EndAssociateProductWithPortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateServiceActionWithProvisioningArtifact


        /// <summary>
        /// Associates a self-service action with a provisioning artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceActionWithProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the AssociateServiceActionWithProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateServiceActionWithProvisioningArtifact">REST API Reference for AssociateServiceActionWithProvisioningArtifact Operation</seealso>
        AssociateServiceActionWithProvisioningArtifactResponse AssociateServiceActionWithProvisioningArtifact(AssociateServiceActionWithProvisioningArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateServiceActionWithProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateServiceActionWithProvisioningArtifact operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateServiceActionWithProvisioningArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateServiceActionWithProvisioningArtifact">REST API Reference for AssociateServiceActionWithProvisioningArtifact Operation</seealso>
        IAsyncResult BeginAssociateServiceActionWithProvisioningArtifact(AssociateServiceActionWithProvisioningArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateServiceActionWithProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateServiceActionWithProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  AssociateServiceActionWithProvisioningArtifactResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateServiceActionWithProvisioningArtifact">REST API Reference for AssociateServiceActionWithProvisioningArtifact Operation</seealso>
        AssociateServiceActionWithProvisioningArtifactResponse EndAssociateServiceActionWithProvisioningArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateTagOptionWithResource


        /// <summary>
        /// Associate the specified TagOption with the specified portfolio or product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTagOptionWithResource service method.</param>
        /// 
        /// <returns>The response from the AssociateTagOptionWithResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateTagOptionWithResource">REST API Reference for AssociateTagOptionWithResource Operation</seealso>
        AssociateTagOptionWithResourceResponse AssociateTagOptionWithResource(AssociateTagOptionWithResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTagOptionWithResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTagOptionWithResource operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateTagOptionWithResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateTagOptionWithResource">REST API Reference for AssociateTagOptionWithResource Operation</seealso>
        IAsyncResult BeginAssociateTagOptionWithResource(AssociateTagOptionWithResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateTagOptionWithResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateTagOptionWithResource.</param>
        /// 
        /// <returns>Returns a  AssociateTagOptionWithResourceResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/AssociateTagOptionWithResource">REST API Reference for AssociateTagOptionWithResource Operation</seealso>
        AssociateTagOptionWithResourceResponse EndAssociateTagOptionWithResource(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchAssociateServiceActionWithProvisioningArtifact


        /// <summary>
        /// Associates multiple self-service actions with provisioning artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateServiceActionWithProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateServiceActionWithProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/BatchAssociateServiceActionWithProvisioningArtifact">REST API Reference for BatchAssociateServiceActionWithProvisioningArtifact Operation</seealso>
        BatchAssociateServiceActionWithProvisioningArtifactResponse BatchAssociateServiceActionWithProvisioningArtifact(BatchAssociateServiceActionWithProvisioningArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateServiceActionWithProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateServiceActionWithProvisioningArtifact operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAssociateServiceActionWithProvisioningArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/BatchAssociateServiceActionWithProvisioningArtifact">REST API Reference for BatchAssociateServiceActionWithProvisioningArtifact Operation</seealso>
        IAsyncResult BeginBatchAssociateServiceActionWithProvisioningArtifact(BatchAssociateServiceActionWithProvisioningArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateServiceActionWithProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateServiceActionWithProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  BatchAssociateServiceActionWithProvisioningArtifactResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/BatchAssociateServiceActionWithProvisioningArtifact">REST API Reference for BatchAssociateServiceActionWithProvisioningArtifact Operation</seealso>
        BatchAssociateServiceActionWithProvisioningArtifactResponse EndBatchAssociateServiceActionWithProvisioningArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDisassociateServiceActionFromProvisioningArtifact


        /// <summary>
        /// Disassociates a batch of self-service actions from the specified provisioning artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateServiceActionFromProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateServiceActionFromProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/BatchDisassociateServiceActionFromProvisioningArtifact">REST API Reference for BatchDisassociateServiceActionFromProvisioningArtifact Operation</seealso>
        BatchDisassociateServiceActionFromProvisioningArtifactResponse BatchDisassociateServiceActionFromProvisioningArtifact(BatchDisassociateServiceActionFromProvisioningArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateServiceActionFromProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateServiceActionFromProvisioningArtifact operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisassociateServiceActionFromProvisioningArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/BatchDisassociateServiceActionFromProvisioningArtifact">REST API Reference for BatchDisassociateServiceActionFromProvisioningArtifact Operation</seealso>
        IAsyncResult BeginBatchDisassociateServiceActionFromProvisioningArtifact(BatchDisassociateServiceActionFromProvisioningArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateServiceActionFromProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateServiceActionFromProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateServiceActionFromProvisioningArtifactResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/BatchDisassociateServiceActionFromProvisioningArtifact">REST API Reference for BatchDisassociateServiceActionFromProvisioningArtifact Operation</seealso>
        BatchDisassociateServiceActionFromProvisioningArtifactResponse EndBatchDisassociateServiceActionFromProvisioningArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  CopyProduct


        /// <summary>
        /// Copies the specified source product to the specified target product or a new product.
        /// 
        ///  
        /// <para>
        /// You can copy a product to the same account or another account. You can copy a product
        /// to the same Region or another Region. If you copy a product to another account, you
        /// must first share the product in a portfolio using <a>CreatePortfolioShare</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation is performed asynchronously. To track the progress of the operation,
        /// use <a>DescribeCopyProductStatus</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyProduct service method.</param>
        /// 
        /// <returns>The response from the CopyProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CopyProduct">REST API Reference for CopyProduct Operation</seealso>
        CopyProductResponse CopyProduct(CopyProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CopyProduct">REST API Reference for CopyProduct Operation</seealso>
        IAsyncResult BeginCopyProduct(CopyProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopyProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyProduct.</param>
        /// 
        /// <returns>Returns a  CopyProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CopyProduct">REST API Reference for CopyProduct Operation</seealso>
        CopyProductResponse EndCopyProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConstraint


        /// <summary>
        /// Creates a constraint.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConstraint service method.</param>
        /// 
        /// <returns>The response from the CreateConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateConstraint">REST API Reference for CreateConstraint Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateConstraint">REST API Reference for CreateConstraint Operation</seealso>
        IAsyncResult BeginCreateConstraint(CreateConstraintRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConstraint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConstraint.</param>
        /// 
        /// <returns>Returns a  CreateConstraintResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateConstraint">REST API Reference for CreateConstraint Operation</seealso>
        CreateConstraintResponse EndCreateConstraint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePortfolio


        /// <summary>
        /// Creates a portfolio.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolio service method.</param>
        /// 
        /// <returns>The response from the CreatePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolio">REST API Reference for CreatePortfolio Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolio">REST API Reference for CreatePortfolio Operation</seealso>
        IAsyncResult BeginCreatePortfolio(CreatePortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePortfolio.</param>
        /// 
        /// <returns>Returns a  CreatePortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolio">REST API Reference for CreatePortfolio Operation</seealso>
        CreatePortfolioResponse EndCreatePortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePortfolioShare


        /// <summary>
        /// Shares the specified portfolio with the specified account or organization node. Shares
        /// to an organization node can only be created by the management account of an organization
        /// or by a delegated administrator. You can share portfolios to an organization, an organizational
        /// unit, or a specific account.
        /// 
        ///  
        /// <para>
        /// Note that if a delegated admin is de-registered, they can no longer create portfolio
        /// shares.
        /// </para>
        ///  
        /// <para>
        ///  <code>AWSOrganizationsAccess</code> must be enabled in order to create a portfolio
        /// share to an organization node.
        /// </para>
        ///  
        /// <para>
        /// You can't share a shared resource, including portfolios that contain a shared product.
        /// </para>
        ///  
        /// <para>
        /// If the portfolio share with the specified account or organization node already exists,
        /// this action will have no effect and will not return an error. To update an existing
        /// share, you must use the <code> UpdatePortfolioShare</code> API instead. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you associate a principal with portfolio, a potential privilege escalation path
        /// may occur when that portfolio is then shared with other accounts. For a user in a
        /// recipient account who is <i>not</i> an Service Catalog Admin, but still has the ability
        /// to create Principals (Users/Groups/Roles), that user could create a role that matches
        /// a principal name association for the portfolio. Although this user may not know which
        /// principal names are associated through Service Catalog, they may be able to guess
        /// the user. If this potential escalation path is a concern, then Service Catalog recommends
        /// using <code>PrincipalType</code> as <code>IAM</code>. With this configuration, the
        /// <code>PrincipalARN</code> must already exist in the recipient account before it can
        /// be associated. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortfolioShare service method.</param>
        /// 
        /// <returns>The response from the CreatePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolioShare">REST API Reference for CreatePortfolioShare Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolioShare">REST API Reference for CreatePortfolioShare Operation</seealso>
        IAsyncResult BeginCreatePortfolioShare(CreatePortfolioShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePortfolioShare.</param>
        /// 
        /// <returns>Returns a  CreatePortfolioShareResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreatePortfolioShare">REST API Reference for CreatePortfolioShare Operation</seealso>
        CreatePortfolioShareResponse EndCreatePortfolioShare(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProduct


        /// <summary>
        /// Creates a product.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        ///  
        /// <para>
        /// The user or role that performs this operation must have the <code>cloudformation:GetTemplate</code>
        /// IAM policy permission. This policy permission is required when using the <code>ImportFromPhysicalId</code>
        /// template source in the information data section.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProduct service method.</param>
        /// 
        /// <returns>The response from the CreateProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        IAsyncResult BeginCreateProduct(CreateProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProduct.</param>
        /// 
        /// <returns>Returns a  CreateProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        CreateProductResponse EndCreateProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProvisionedProductPlan


        /// <summary>
        /// Creates a plan.
        /// 
        ///  
        /// <para>
        /// A plan includes the list of resources to be created (when provisioning a new product)
        /// or modified (when updating a provisioned product) when the plan is executed.
        /// </para>
        ///  
        /// <para>
        /// You can create one plan for each provisioned product. To create a plan for an existing
        /// provisioned product, the product status must be AVAILABLE or TAINTED.
        /// </para>
        ///  
        /// <para>
        /// To view the resource changes in the change set, use <a>DescribeProvisionedProductPlan</a>.
        /// To create or modify the provisioned product, use <a>ExecuteProvisionedProductPlan</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisionedProductPlan service method.</param>
        /// 
        /// <returns>The response from the CreateProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisionedProductPlan">REST API Reference for CreateProvisionedProductPlan Operation</seealso>
        CreateProvisionedProductPlanResponse CreateProvisionedProductPlan(CreateProvisionedProductPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisionedProductPlan operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProvisionedProductPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisionedProductPlan">REST API Reference for CreateProvisionedProductPlan Operation</seealso>
        IAsyncResult BeginCreateProvisionedProductPlan(CreateProvisionedProductPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProvisionedProductPlan.</param>
        /// 
        /// <returns>Returns a  CreateProvisionedProductPlanResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisionedProductPlan">REST API Reference for CreateProvisionedProductPlan Operation</seealso>
        CreateProvisionedProductPlanResponse EndCreateProvisionedProductPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProvisioningArtifact


        /// <summary>
        /// Creates a provisioning artifact (also known as a version) for the specified product.
        /// 
        ///  
        /// <para>
        /// You cannot create a provisioning artifact for a product that was shared with you.
        /// </para>
        ///  
        /// <para>
        /// The user or role that performs this operation must have the <code>cloudformation:GetTemplate</code>
        /// IAM policy permission. This policy permission is required when using the <code>ImportFromPhysicalId</code>
        /// template source in the information data section.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the CreateProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisioningArtifact">REST API Reference for CreateProvisioningArtifact Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisioningArtifact">REST API Reference for CreateProvisioningArtifact Operation</seealso>
        IAsyncResult BeginCreateProvisioningArtifact(CreateProvisioningArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  CreateProvisioningArtifactResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateProvisioningArtifact">REST API Reference for CreateProvisioningArtifact Operation</seealso>
        CreateProvisioningArtifactResponse EndCreateProvisioningArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateServiceAction


        /// <summary>
        /// Creates a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceAction service method.</param>
        /// 
        /// <returns>The response from the CreateServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateServiceAction">REST API Reference for CreateServiceAction Operation</seealso>
        CreateServiceActionResponse CreateServiceAction(CreateServiceActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceAction operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServiceAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateServiceAction">REST API Reference for CreateServiceAction Operation</seealso>
        IAsyncResult BeginCreateServiceAction(CreateServiceActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServiceAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServiceAction.</param>
        /// 
        /// <returns>Returns a  CreateServiceActionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateServiceAction">REST API Reference for CreateServiceAction Operation</seealso>
        CreateServiceActionResponse EndCreateServiceAction(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTagOption


        /// <summary>
        /// Creates a TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTagOption service method.</param>
        /// 
        /// <returns>The response from the CreateTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateTagOption">REST API Reference for CreateTagOption Operation</seealso>
        CreateTagOptionResponse CreateTagOption(CreateTagOptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTagOption operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTagOption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateTagOption">REST API Reference for CreateTagOption Operation</seealso>
        IAsyncResult BeginCreateTagOption(CreateTagOptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTagOption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTagOption.</param>
        /// 
        /// <returns>Returns a  CreateTagOptionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/CreateTagOption">REST API Reference for CreateTagOption Operation</seealso>
        CreateTagOptionResponse EndCreateTagOption(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConstraint


        /// <summary>
        /// Deletes the specified constraint.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConstraint service method.</param>
        /// 
        /// <returns>The response from the DeleteConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteConstraint">REST API Reference for DeleteConstraint Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteConstraint">REST API Reference for DeleteConstraint Operation</seealso>
        IAsyncResult BeginDeleteConstraint(DeleteConstraintRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConstraint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConstraint.</param>
        /// 
        /// <returns>Returns a  DeleteConstraintResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteConstraint">REST API Reference for DeleteConstraint Operation</seealso>
        DeleteConstraintResponse EndDeleteConstraint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePortfolio


        /// <summary>
        /// Deletes the specified portfolio.
        /// 
        ///  
        /// <para>
        /// You cannot delete a portfolio if it was shared with you or if it has associated products,
        /// users, constraints, or shared accounts.
        /// </para>
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolio service method.</param>
        /// 
        /// <returns>The response from the DeletePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolio">REST API Reference for DeletePortfolio Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolio">REST API Reference for DeletePortfolio Operation</seealso>
        IAsyncResult BeginDeletePortfolio(DeletePortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePortfolio.</param>
        /// 
        /// <returns>Returns a  DeletePortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolio">REST API Reference for DeletePortfolio Operation</seealso>
        DeletePortfolioResponse EndDeletePortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePortfolioShare


        /// <summary>
        /// Stops sharing the specified portfolio with the specified account or organization node.
        /// Shares to an organization node can only be deleted by the management account of an
        /// organization or by a delegated administrator.
        /// 
        ///  
        /// <para>
        /// Note that if a delegated admin is de-registered, portfolio shares created from that
        /// account are removed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortfolioShare service method.</param>
        /// 
        /// <returns>The response from the DeletePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolioShare">REST API Reference for DeletePortfolioShare Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolioShare">REST API Reference for DeletePortfolioShare Operation</seealso>
        IAsyncResult BeginDeletePortfolioShare(DeletePortfolioShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePortfolioShare.</param>
        /// 
        /// <returns>Returns a  DeletePortfolioShareResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeletePortfolioShare">REST API Reference for DeletePortfolioShare Operation</seealso>
        DeletePortfolioShareResponse EndDeletePortfolioShare(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProduct


        /// <summary>
        /// Deletes the specified product.
        /// 
        ///  
        /// <para>
        /// You cannot delete a product if it was shared with you or is associated with a portfolio.
        /// </para>
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProduct service method.</param>
        /// 
        /// <returns>The response from the DeleteProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
        IAsyncResult BeginDeleteProduct(DeleteProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProduct.</param>
        /// 
        /// <returns>Returns a  DeleteProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
        DeleteProductResponse EndDeleteProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProvisionedProductPlan


        /// <summary>
        /// Deletes the specified plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedProductPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisionedProductPlan">REST API Reference for DeleteProvisionedProductPlan Operation</seealso>
        DeleteProvisionedProductPlanResponse DeleteProvisionedProductPlan(DeleteProvisionedProductPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedProductPlan operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProvisionedProductPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisionedProductPlan">REST API Reference for DeleteProvisionedProductPlan Operation</seealso>
        IAsyncResult BeginDeleteProvisionedProductPlan(DeleteProvisionedProductPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProvisionedProductPlan.</param>
        /// 
        /// <returns>Returns a  DeleteProvisionedProductPlanResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisionedProductPlan">REST API Reference for DeleteProvisionedProductPlan Operation</seealso>
        DeleteProvisionedProductPlanResponse EndDeleteProvisionedProductPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProvisioningArtifact


        /// <summary>
        /// Deletes the specified provisioning artifact (also known as a version) for the specified
        /// product.
        /// 
        ///  
        /// <para>
        /// You cannot delete a provisioning artifact associated with a product that was shared
        /// with you. You cannot delete the last provisioning artifact for a product, because
        /// a product must have at least one provisioning artifact.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisioningArtifact">REST API Reference for DeleteProvisioningArtifact Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisioningArtifact">REST API Reference for DeleteProvisioningArtifact Operation</seealso>
        IAsyncResult BeginDeleteProvisioningArtifact(DeleteProvisioningArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  DeleteProvisioningArtifactResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteProvisioningArtifact">REST API Reference for DeleteProvisioningArtifact Operation</seealso>
        DeleteProvisioningArtifactResponse EndDeleteProvisioningArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteServiceAction


        /// <summary>
        /// Deletes a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceAction service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteServiceAction">REST API Reference for DeleteServiceAction Operation</seealso>
        DeleteServiceActionResponse DeleteServiceAction(DeleteServiceActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceAction operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteServiceAction">REST API Reference for DeleteServiceAction Operation</seealso>
        IAsyncResult BeginDeleteServiceAction(DeleteServiceActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceAction.</param>
        /// 
        /// <returns>Returns a  DeleteServiceActionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteServiceAction">REST API Reference for DeleteServiceAction Operation</seealso>
        DeleteServiceActionResponse EndDeleteServiceAction(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTagOption


        /// <summary>
        /// Deletes the specified TagOption.
        /// 
        ///  
        /// <para>
        /// You cannot delete a TagOption if it is associated with a product or portfolio.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagOption service method.</param>
        /// 
        /// <returns>The response from the DeleteTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteTagOption">REST API Reference for DeleteTagOption Operation</seealso>
        DeleteTagOptionResponse DeleteTagOption(DeleteTagOptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTagOption operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTagOption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteTagOption">REST API Reference for DeleteTagOption Operation</seealso>
        IAsyncResult BeginDeleteTagOption(DeleteTagOptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTagOption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTagOption.</param>
        /// 
        /// <returns>Returns a  DeleteTagOptionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DeleteTagOption">REST API Reference for DeleteTagOption Operation</seealso>
        DeleteTagOptionResponse EndDeleteTagOption(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConstraint


        /// <summary>
        /// Gets information about the specified constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConstraint service method.</param>
        /// 
        /// <returns>The response from the DescribeConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeConstraint">REST API Reference for DescribeConstraint Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeConstraint">REST API Reference for DescribeConstraint Operation</seealso>
        IAsyncResult BeginDescribeConstraint(DescribeConstraintRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConstraint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConstraint.</param>
        /// 
        /// <returns>Returns a  DescribeConstraintResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeConstraint">REST API Reference for DescribeConstraint Operation</seealso>
        DescribeConstraintResponse EndDescribeConstraint(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCopyProductStatus


        /// <summary>
        /// Gets the status of the specified copy product operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCopyProductStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeCopyProductStatus service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeCopyProductStatus">REST API Reference for DescribeCopyProductStatus Operation</seealso>
        DescribeCopyProductStatusResponse DescribeCopyProductStatus(DescribeCopyProductStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCopyProductStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCopyProductStatus operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCopyProductStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeCopyProductStatus">REST API Reference for DescribeCopyProductStatus Operation</seealso>
        IAsyncResult BeginDescribeCopyProductStatus(DescribeCopyProductStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCopyProductStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCopyProductStatus.</param>
        /// 
        /// <returns>Returns a  DescribeCopyProductStatusResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeCopyProductStatus">REST API Reference for DescribeCopyProductStatus Operation</seealso>
        DescribeCopyProductStatusResponse EndDescribeCopyProductStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePortfolio


        /// <summary>
        /// Gets information about the specified portfolio.
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolio service method.</param>
        /// 
        /// <returns>The response from the DescribePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolio">REST API Reference for DescribePortfolio Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolio">REST API Reference for DescribePortfolio Operation</seealso>
        IAsyncResult BeginDescribePortfolio(DescribePortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePortfolio.</param>
        /// 
        /// <returns>Returns a  DescribePortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolio">REST API Reference for DescribePortfolio Operation</seealso>
        DescribePortfolioResponse EndDescribePortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePortfolioShares


        /// <summary>
        /// Returns a summary of each of the portfolio shares that were created for the specified
        /// portfolio.
        /// 
        ///  
        /// <para>
        /// You can use this API to determine which accounts or organizational nodes this portfolio
        /// have been shared, whether the recipient entity has imported the share, and whether
        /// TagOptions are included with the share.
        /// </para>
        ///  
        /// <para>
        /// The <code>PortfolioId</code> and <code>Type</code> parameters are both required.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolioShares service method.</param>
        /// 
        /// <returns>The response from the DescribePortfolioShares service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolioShares">REST API Reference for DescribePortfolioShares Operation</seealso>
        DescribePortfolioSharesResponse DescribePortfolioShares(DescribePortfolioSharesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePortfolioShares operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolioShares operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePortfolioShares
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolioShares">REST API Reference for DescribePortfolioShares Operation</seealso>
        IAsyncResult BeginDescribePortfolioShares(DescribePortfolioSharesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePortfolioShares operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePortfolioShares.</param>
        /// 
        /// <returns>Returns a  DescribePortfolioSharesResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolioShares">REST API Reference for DescribePortfolioShares Operation</seealso>
        DescribePortfolioSharesResponse EndDescribePortfolioShares(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePortfolioShareStatus


        /// <summary>
        /// Gets the status of the specified portfolio share operation. This API can only be called
        /// by the management account in the organization or by a delegated admin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolioShareStatus service method.</param>
        /// 
        /// <returns>The response from the DescribePortfolioShareStatus service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolioShareStatus">REST API Reference for DescribePortfolioShareStatus Operation</seealso>
        DescribePortfolioShareStatusResponse DescribePortfolioShareStatus(DescribePortfolioShareStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePortfolioShareStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePortfolioShareStatus operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePortfolioShareStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolioShareStatus">REST API Reference for DescribePortfolioShareStatus Operation</seealso>
        IAsyncResult BeginDescribePortfolioShareStatus(DescribePortfolioShareStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePortfolioShareStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePortfolioShareStatus.</param>
        /// 
        /// <returns>Returns a  DescribePortfolioShareStatusResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribePortfolioShareStatus">REST API Reference for DescribePortfolioShareStatus Operation</seealso>
        DescribePortfolioShareStatusResponse EndDescribePortfolioShareStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProduct


        /// <summary>
        /// Gets information about the specified product.
        /// 
        ///  <note> 
        /// <para>
        ///  Running this operation with administrator access results in a failure. <a>DescribeProductAsAdmin</a>
        /// should be used instead. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProduct service method.</param>
        /// 
        /// <returns>The response from the DescribeProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProduct">REST API Reference for DescribeProduct Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProduct">REST API Reference for DescribeProduct Operation</seealso>
        IAsyncResult BeginDescribeProduct(DescribeProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProduct.</param>
        /// 
        /// <returns>Returns a  DescribeProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProduct">REST API Reference for DescribeProduct Operation</seealso>
        DescribeProductResponse EndDescribeProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProductAsAdmin


        /// <summary>
        /// Gets information about the specified product. This operation is run with administrator
        /// access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductAsAdmin service method.</param>
        /// 
        /// <returns>The response from the DescribeProductAsAdmin service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductAsAdmin">REST API Reference for DescribeProductAsAdmin Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductAsAdmin">REST API Reference for DescribeProductAsAdmin Operation</seealso>
        IAsyncResult BeginDescribeProductAsAdmin(DescribeProductAsAdminRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProductAsAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProductAsAdmin.</param>
        /// 
        /// <returns>Returns a  DescribeProductAsAdminResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductAsAdmin">REST API Reference for DescribeProductAsAdmin Operation</seealso>
        DescribeProductAsAdminResponse EndDescribeProductAsAdmin(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProductView


        /// <summary>
        /// Gets information about the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProductView service method.</param>
        /// 
        /// <returns>The response from the DescribeProductView service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductView">REST API Reference for DescribeProductView Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductView">REST API Reference for DescribeProductView Operation</seealso>
        IAsyncResult BeginDescribeProductView(DescribeProductViewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProductView operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProductView.</param>
        /// 
        /// <returns>Returns a  DescribeProductViewResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProductView">REST API Reference for DescribeProductView Operation</seealso>
        DescribeProductViewResponse EndDescribeProductView(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProvisionedProduct


        /// <summary>
        /// Gets information about the specified provisioned product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProduct">REST API Reference for DescribeProvisionedProduct Operation</seealso>
        DescribeProvisionedProductResponse DescribeProvisionedProduct(DescribeProvisionedProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProvisionedProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProduct">REST API Reference for DescribeProvisionedProduct Operation</seealso>
        IAsyncResult BeginDescribeProvisionedProduct(DescribeProvisionedProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProvisionedProduct.</param>
        /// 
        /// <returns>Returns a  DescribeProvisionedProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProduct">REST API Reference for DescribeProvisionedProduct Operation</seealso>
        DescribeProvisionedProductResponse EndDescribeProvisionedProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProvisionedProductPlan


        /// <summary>
        /// Gets information about the resource changes for the specified plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProductPlan service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProductPlan">REST API Reference for DescribeProvisionedProductPlan Operation</seealso>
        DescribeProvisionedProductPlanResponse DescribeProvisionedProductPlan(DescribeProvisionedProductPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisionedProductPlan operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProvisionedProductPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProductPlan">REST API Reference for DescribeProvisionedProductPlan Operation</seealso>
        IAsyncResult BeginDescribeProvisionedProductPlan(DescribeProvisionedProductPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProvisionedProductPlan.</param>
        /// 
        /// <returns>Returns a  DescribeProvisionedProductPlanResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisionedProductPlan">REST API Reference for DescribeProvisionedProductPlan Operation</seealso>
        DescribeProvisionedProductPlanResponse EndDescribeProvisionedProductPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProvisioningArtifact


        /// <summary>
        /// Gets information about the specified provisioning artifact (also known as a version)
        /// for the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningArtifact">REST API Reference for DescribeProvisioningArtifact Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningArtifact">REST API Reference for DescribeProvisioningArtifact Operation</seealso>
        IAsyncResult BeginDescribeProvisioningArtifact(DescribeProvisioningArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  DescribeProvisioningArtifactResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningArtifact">REST API Reference for DescribeProvisioningArtifact Operation</seealso>
        DescribeProvisioningArtifactResponse EndDescribeProvisioningArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProvisioningParameters


        /// <summary>
        /// Gets information about the configuration required to provision the specified product
        /// using the specified provisioning artifact.
        /// 
        ///  
        /// <para>
        /// If the output contains a TagOption key with an empty list of values, there is a TagOption
        /// conflict for that key. The end user cannot take action to fix the conflict, and launch
        /// is not blocked. In subsequent calls to <a>ProvisionProduct</a>, do not include conflicted
        /// TagOption keys as tags, or this causes the error "Parameter validation failed: Missing
        /// required parameter in Tags[<i>N</i>]:<i>Value</i>". Tag the provisioned product with
        /// the value <code>sc-tagoption-conflict-portfolioId-productId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisioningParameters service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningParameters">REST API Reference for DescribeProvisioningParameters Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningParameters">REST API Reference for DescribeProvisioningParameters Operation</seealso>
        IAsyncResult BeginDescribeProvisioningParameters(DescribeProvisioningParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProvisioningParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProvisioningParameters.</param>
        /// 
        /// <returns>Returns a  DescribeProvisioningParametersResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeProvisioningParameters">REST API Reference for DescribeProvisioningParameters Operation</seealso>
        DescribeProvisioningParametersResponse EndDescribeProvisioningParameters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRecord


        /// <summary>
        /// Gets information about the specified request operation.
        /// 
        ///  
        /// <para>
        /// Use this operation after calling a request operation (for example, <a>ProvisionProduct</a>,
        /// <a>TerminateProvisionedProduct</a>, or <a>UpdateProvisionedProduct</a>). 
        /// </para>
        ///  <note> 
        /// <para>
        /// If a provisioned product was transferred to a new owner using <a>UpdateProvisionedProductProperties</a>,
        /// the new owner will be able to describe all past records for that product. The previous
        /// owner will no longer be able to describe the records, but will be able to use <a>ListRecordHistory</a>
        /// to see the product's history from when he was the owner.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecord service method.</param>
        /// 
        /// <returns>The response from the DescribeRecord service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeRecord">REST API Reference for DescribeRecord Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeRecord">REST API Reference for DescribeRecord Operation</seealso>
        IAsyncResult BeginDescribeRecord(DescribeRecordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecord.</param>
        /// 
        /// <returns>Returns a  DescribeRecordResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeRecord">REST API Reference for DescribeRecord Operation</seealso>
        DescribeRecordResponse EndDescribeRecord(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeServiceAction


        /// <summary>
        /// Describes a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAction service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeServiceAction">REST API Reference for DescribeServiceAction Operation</seealso>
        DescribeServiceActionResponse DescribeServiceAction(DescribeServiceActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceAction operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServiceAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeServiceAction">REST API Reference for DescribeServiceAction Operation</seealso>
        IAsyncResult BeginDescribeServiceAction(DescribeServiceActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServiceAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceAction.</param>
        /// 
        /// <returns>Returns a  DescribeServiceActionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeServiceAction">REST API Reference for DescribeServiceAction Operation</seealso>
        DescribeServiceActionResponse EndDescribeServiceAction(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeServiceActionExecutionParameters


        /// <summary>
        /// Finds the default parameters for a specific self-service action on a specific provisioned
        /// product and returns a map of the results to the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceActionExecutionParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceActionExecutionParameters service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeServiceActionExecutionParameters">REST API Reference for DescribeServiceActionExecutionParameters Operation</seealso>
        DescribeServiceActionExecutionParametersResponse DescribeServiceActionExecutionParameters(DescribeServiceActionExecutionParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceActionExecutionParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceActionExecutionParameters operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServiceActionExecutionParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeServiceActionExecutionParameters">REST API Reference for DescribeServiceActionExecutionParameters Operation</seealso>
        IAsyncResult BeginDescribeServiceActionExecutionParameters(DescribeServiceActionExecutionParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServiceActionExecutionParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceActionExecutionParameters.</param>
        /// 
        /// <returns>Returns a  DescribeServiceActionExecutionParametersResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeServiceActionExecutionParameters">REST API Reference for DescribeServiceActionExecutionParameters Operation</seealso>
        DescribeServiceActionExecutionParametersResponse EndDescribeServiceActionExecutionParameters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTagOption


        /// <summary>
        /// Gets information about the specified TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTagOption service method.</param>
        /// 
        /// <returns>The response from the DescribeTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeTagOption">REST API Reference for DescribeTagOption Operation</seealso>
        DescribeTagOptionResponse DescribeTagOption(DescribeTagOptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTagOption operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTagOption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeTagOption">REST API Reference for DescribeTagOption Operation</seealso>
        IAsyncResult BeginDescribeTagOption(DescribeTagOptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTagOption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTagOption.</param>
        /// 
        /// <returns>Returns a  DescribeTagOptionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DescribeTagOption">REST API Reference for DescribeTagOption Operation</seealso>
        DescribeTagOptionResponse EndDescribeTagOption(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableAWSOrganizationsAccess


        /// <summary>
        /// Disable portfolio sharing through the Organizations service. This command will not
        /// delete your current shares, but prevents you from creating new shares throughout your
        /// organization. Current shares are not kept in sync with your organization structure
        /// if the structure changes after calling this API. Only the management account in the
        /// organization can call this API.
        /// 
        ///  
        /// <para>
        /// You cannot call this API if there are active delegated administrators in the organization.
        /// </para>
        ///  
        /// <para>
        /// Note that a delegated administrator is not authorized to invoke <code>DisableAWSOrganizationsAccess</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you share an Service Catalog portfolio in an organization within Organizations,
        /// and then disable Organizations access for Service Catalog, the portfolio access permissions
        /// will not sync with the latest changes to the organization structure. Specifically,
        /// accounts that you removed from the organization after disabling Service Catalog access
        /// will retain access to the previously shared portfolio.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAWSOrganizationsAccess service method.</param>
        /// 
        /// <returns>The response from the DisableAWSOrganizationsAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisableAWSOrganizationsAccess">REST API Reference for DisableAWSOrganizationsAccess Operation</seealso>
        DisableAWSOrganizationsAccessResponse DisableAWSOrganizationsAccess(DisableAWSOrganizationsAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAWSOrganizationsAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAWSOrganizationsAccess operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableAWSOrganizationsAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisableAWSOrganizationsAccess">REST API Reference for DisableAWSOrganizationsAccess Operation</seealso>
        IAsyncResult BeginDisableAWSOrganizationsAccess(DisableAWSOrganizationsAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableAWSOrganizationsAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableAWSOrganizationsAccess.</param>
        /// 
        /// <returns>Returns a  DisableAWSOrganizationsAccessResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisableAWSOrganizationsAccess">REST API Reference for DisableAWSOrganizationsAccess Operation</seealso>
        DisableAWSOrganizationsAccessResponse EndDisableAWSOrganizationsAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateBudgetFromResource


        /// <summary>
        /// Disassociates the specified budget from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBudgetFromResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateBudgetFromResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateBudgetFromResource">REST API Reference for DisassociateBudgetFromResource Operation</seealso>
        DisassociateBudgetFromResourceResponse DisassociateBudgetFromResource(DisassociateBudgetFromResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateBudgetFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateBudgetFromResource operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateBudgetFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateBudgetFromResource">REST API Reference for DisassociateBudgetFromResource Operation</seealso>
        IAsyncResult BeginDisassociateBudgetFromResource(DisassociateBudgetFromResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateBudgetFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateBudgetFromResource.</param>
        /// 
        /// <returns>Returns a  DisassociateBudgetFromResourceResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateBudgetFromResource">REST API Reference for DisassociateBudgetFromResource Operation</seealso>
        DisassociateBudgetFromResourceResponse EndDisassociateBudgetFromResource(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociatePrincipalFromPortfolio


        /// <summary>
        /// Disassociates a previously associated principal ARN from a specified portfolio.
        /// 
        ///  
        /// <para>
        /// The <code>PrincipalType</code> and <code>PrincipalARN</code> must match the <code>AssociatePrincipalWithPortfolio</code>
        /// call request details. For example, to disassociate an association created with a <code>PrincipalARN</code>
        /// of <code>PrincipalType</code> IAM you must use the <code>PrincipalType</code> IAM
        /// when calling <code>DisassociatePrincipalFromPortfolio</code>. 
        /// </para>
        ///  
        /// <para>
        /// For portfolios that have been shared with principal name sharing enabled: after disassociating
        /// a principal, share recipient accounts will no longer be able to provision products
        /// in this portfolio using a role matching the name of the associated principal. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePrincipalFromPortfolio service method.</param>
        /// 
        /// <returns>The response from the DisassociatePrincipalFromPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociatePrincipalFromPortfolio">REST API Reference for DisassociatePrincipalFromPortfolio Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociatePrincipalFromPortfolio">REST API Reference for DisassociatePrincipalFromPortfolio Operation</seealso>
        IAsyncResult BeginDisassociatePrincipalFromPortfolio(DisassociatePrincipalFromPortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePrincipalFromPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePrincipalFromPortfolio.</param>
        /// 
        /// <returns>Returns a  DisassociatePrincipalFromPortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociatePrincipalFromPortfolio">REST API Reference for DisassociatePrincipalFromPortfolio Operation</seealso>
        DisassociatePrincipalFromPortfolioResponse EndDisassociatePrincipalFromPortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateProductFromPortfolio


        /// <summary>
        /// Disassociates the specified product from the specified portfolio. 
        /// 
        ///  
        /// <para>
        /// A delegated admin is authorized to invoke this command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProductFromPortfolio service method.</param>
        /// 
        /// <returns>The response from the DisassociateProductFromPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceInUseException">
        /// A resource that is currently in use. Ensure that the resource is not in use and retry
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateProductFromPortfolio">REST API Reference for DisassociateProductFromPortfolio Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateProductFromPortfolio">REST API Reference for DisassociateProductFromPortfolio Operation</seealso>
        IAsyncResult BeginDisassociateProductFromPortfolio(DisassociateProductFromPortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateProductFromPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateProductFromPortfolio.</param>
        /// 
        /// <returns>Returns a  DisassociateProductFromPortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateProductFromPortfolio">REST API Reference for DisassociateProductFromPortfolio Operation</seealso>
        DisassociateProductFromPortfolioResponse EndDisassociateProductFromPortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateServiceActionFromProvisioningArtifact


        /// <summary>
        /// Disassociates the specified self-service action association from the specified provisioning
        /// artifact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceActionFromProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the DisassociateServiceActionFromProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateServiceActionFromProvisioningArtifact">REST API Reference for DisassociateServiceActionFromProvisioningArtifact Operation</seealso>
        DisassociateServiceActionFromProvisioningArtifactResponse DisassociateServiceActionFromProvisioningArtifact(DisassociateServiceActionFromProvisioningArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateServiceActionFromProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateServiceActionFromProvisioningArtifact operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateServiceActionFromProvisioningArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateServiceActionFromProvisioningArtifact">REST API Reference for DisassociateServiceActionFromProvisioningArtifact Operation</seealso>
        IAsyncResult BeginDisassociateServiceActionFromProvisioningArtifact(DisassociateServiceActionFromProvisioningArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateServiceActionFromProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateServiceActionFromProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  DisassociateServiceActionFromProvisioningArtifactResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateServiceActionFromProvisioningArtifact">REST API Reference for DisassociateServiceActionFromProvisioningArtifact Operation</seealso>
        DisassociateServiceActionFromProvisioningArtifactResponse EndDisassociateServiceActionFromProvisioningArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateTagOptionFromResource


        /// <summary>
        /// Disassociates the specified TagOption from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTagOptionFromResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateTagOptionFromResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateTagOptionFromResource">REST API Reference for DisassociateTagOptionFromResource Operation</seealso>
        DisassociateTagOptionFromResourceResponse DisassociateTagOptionFromResource(DisassociateTagOptionFromResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTagOptionFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTagOptionFromResource operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateTagOptionFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateTagOptionFromResource">REST API Reference for DisassociateTagOptionFromResource Operation</seealso>
        IAsyncResult BeginDisassociateTagOptionFromResource(DisassociateTagOptionFromResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateTagOptionFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateTagOptionFromResource.</param>
        /// 
        /// <returns>Returns a  DisassociateTagOptionFromResourceResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/DisassociateTagOptionFromResource">REST API Reference for DisassociateTagOptionFromResource Operation</seealso>
        DisassociateTagOptionFromResourceResponse EndDisassociateTagOptionFromResource(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableAWSOrganizationsAccess


        /// <summary>
        /// Enable portfolio sharing feature through Organizations. This API will allow Service
        /// Catalog to receive updates on your organization in order to sync your shares with
        /// the current structure. This API can only be called by the management account in the
        /// organization.
        /// 
        ///  
        /// <para>
        /// When you call this API, Service Catalog calls <code>organizations:EnableAWSServiceAccess</code>
        /// on your behalf so that your shares stay in sync with any changes in your Organizations
        /// structure.
        /// </para>
        ///  
        /// <para>
        /// Note that a delegated administrator is not authorized to invoke <code>EnableAWSOrganizationsAccess</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you have previously disabled Organizations access for Service Catalog, and then
        /// enable access again, the portfolio access permissions might not sync with the latest
        /// changes to the organization structure. Specifically, accounts that you removed from
        /// the organization after disabling Service Catalog access, and before you enabled access
        /// again, can retain access to the previously shared portfolio. As a result, an account
        /// that has been removed from the organization might still be able to create or manage
        /// Amazon Web Services resources when it is no longer authorized to do so. Amazon Web
        /// Services is working to resolve this issue.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAWSOrganizationsAccess service method.</param>
        /// 
        /// <returns>The response from the EnableAWSOrganizationsAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/EnableAWSOrganizationsAccess">REST API Reference for EnableAWSOrganizationsAccess Operation</seealso>
        EnableAWSOrganizationsAccessResponse EnableAWSOrganizationsAccess(EnableAWSOrganizationsAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAWSOrganizationsAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAWSOrganizationsAccess operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableAWSOrganizationsAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/EnableAWSOrganizationsAccess">REST API Reference for EnableAWSOrganizationsAccess Operation</seealso>
        IAsyncResult BeginEnableAWSOrganizationsAccess(EnableAWSOrganizationsAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableAWSOrganizationsAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableAWSOrganizationsAccess.</param>
        /// 
        /// <returns>Returns a  EnableAWSOrganizationsAccessResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/EnableAWSOrganizationsAccess">REST API Reference for EnableAWSOrganizationsAccess Operation</seealso>
        EnableAWSOrganizationsAccessResponse EndEnableAWSOrganizationsAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  ExecuteProvisionedProductPlan


        /// <summary>
        /// Provisions or modifies a product based on the resource changes for the specified plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductPlan service method.</param>
        /// 
        /// <returns>The response from the ExecuteProvisionedProductPlan service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductPlan">REST API Reference for ExecuteProvisionedProductPlan Operation</seealso>
        ExecuteProvisionedProductPlanResponse ExecuteProvisionedProductPlan(ExecuteProvisionedProductPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductPlan operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteProvisionedProductPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductPlan">REST API Reference for ExecuteProvisionedProductPlan Operation</seealso>
        IAsyncResult BeginExecuteProvisionedProductPlan(ExecuteProvisionedProductPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteProvisionedProductPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteProvisionedProductPlan.</param>
        /// 
        /// <returns>Returns a  ExecuteProvisionedProductPlanResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductPlan">REST API Reference for ExecuteProvisionedProductPlan Operation</seealso>
        ExecuteProvisionedProductPlanResponse EndExecuteProvisionedProductPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  ExecuteProvisionedProductServiceAction


        /// <summary>
        /// Executes a self-service action against a provisioned product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductServiceAction service method.</param>
        /// 
        /// <returns>The response from the ExecuteProvisionedProductServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductServiceAction">REST API Reference for ExecuteProvisionedProductServiceAction Operation</seealso>
        ExecuteProvisionedProductServiceActionResponse ExecuteProvisionedProductServiceAction(ExecuteProvisionedProductServiceActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteProvisionedProductServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteProvisionedProductServiceAction operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteProvisionedProductServiceAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductServiceAction">REST API Reference for ExecuteProvisionedProductServiceAction Operation</seealso>
        IAsyncResult BeginExecuteProvisionedProductServiceAction(ExecuteProvisionedProductServiceActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteProvisionedProductServiceAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteProvisionedProductServiceAction.</param>
        /// 
        /// <returns>Returns a  ExecuteProvisionedProductServiceActionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ExecuteProvisionedProductServiceAction">REST API Reference for ExecuteProvisionedProductServiceAction Operation</seealso>
        ExecuteProvisionedProductServiceActionResponse EndExecuteProvisionedProductServiceAction(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAWSOrganizationsAccessStatus


        /// <summary>
        /// Get the Access Status for Organizations portfolio share feature. This API can only
        /// be called by the management account in the organization or by a delegated admin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAWSOrganizationsAccessStatus service method.</param>
        /// 
        /// <returns>The response from the GetAWSOrganizationsAccessStatus service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/GetAWSOrganizationsAccessStatus">REST API Reference for GetAWSOrganizationsAccessStatus Operation</seealso>
        GetAWSOrganizationsAccessStatusResponse GetAWSOrganizationsAccessStatus(GetAWSOrganizationsAccessStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAWSOrganizationsAccessStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAWSOrganizationsAccessStatus operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAWSOrganizationsAccessStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/GetAWSOrganizationsAccessStatus">REST API Reference for GetAWSOrganizationsAccessStatus Operation</seealso>
        IAsyncResult BeginGetAWSOrganizationsAccessStatus(GetAWSOrganizationsAccessStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAWSOrganizationsAccessStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAWSOrganizationsAccessStatus.</param>
        /// 
        /// <returns>Returns a  GetAWSOrganizationsAccessStatusResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/GetAWSOrganizationsAccessStatus">REST API Reference for GetAWSOrganizationsAccessStatus Operation</seealso>
        GetAWSOrganizationsAccessStatusResponse EndGetAWSOrganizationsAccessStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetProvisionedProductOutputs


        /// <summary>
        /// This API takes either a <code>ProvisonedProductId</code> or a <code>ProvisionedProductName</code>,
        /// along with a list of one or more output keys, and responds with the key/value pairs
        /// of those outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProvisionedProductOutputs service method.</param>
        /// 
        /// <returns>The response from the GetProvisionedProductOutputs service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/GetProvisionedProductOutputs">REST API Reference for GetProvisionedProductOutputs Operation</seealso>
        GetProvisionedProductOutputsResponse GetProvisionedProductOutputs(GetProvisionedProductOutputsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProvisionedProductOutputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProvisionedProductOutputs operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProvisionedProductOutputs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/GetProvisionedProductOutputs">REST API Reference for GetProvisionedProductOutputs Operation</seealso>
        IAsyncResult BeginGetProvisionedProductOutputs(GetProvisionedProductOutputsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProvisionedProductOutputs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProvisionedProductOutputs.</param>
        /// 
        /// <returns>Returns a  GetProvisionedProductOutputsResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/GetProvisionedProductOutputs">REST API Reference for GetProvisionedProductOutputs Operation</seealso>
        GetProvisionedProductOutputsResponse EndGetProvisionedProductOutputs(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportAsProvisionedProduct


        /// <summary>
        /// Requests the import of a resource as an Service Catalog provisioned product that
        /// is associated to an Service Catalog product and provisioning artifact. Once imported,
        /// all supported governance actions are supported on the provisioned product. 
        /// 
        ///  
        /// <para>
        ///  Resource import only supports CloudFormation stack ARNs. CloudFormation StackSets,
        /// and non-root nested stacks are not supported. 
        /// </para>
        ///  
        /// <para>
        ///  The CloudFormation stack must have one of the following statuses to be imported:
        /// <code>CREATE_COMPLETE</code>, <code>UPDATE_COMPLETE</code>, <code>UPDATE_ROLLBACK_COMPLETE</code>,
        /// <code>IMPORT_COMPLETE</code>, and <code>IMPORT_ROLLBACK_COMPLETE</code>. 
        /// </para>
        ///  
        /// <para>
        ///  Import of the resource requires that the CloudFormation stack template matches the
        /// associated Service Catalog product provisioning artifact. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  When you import an existing CloudFormation stack into a portfolio, constraints that
        /// are associated with the product aren't applied during the import process. The constraints
        /// are applied after you call <code>UpdateProvisionedProduct</code> for the provisioned
        /// product. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  The user or role that performs this operation must have the <code>cloudformation:GetTemplate</code>
        /// and <code>cloudformation:DescribeStacks</code> IAM policy permissions. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportAsProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the ImportAsProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ImportAsProvisionedProduct">REST API Reference for ImportAsProvisionedProduct Operation</seealso>
        ImportAsProvisionedProductResponse ImportAsProvisionedProduct(ImportAsProvisionedProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportAsProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportAsProvisionedProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportAsProvisionedProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ImportAsProvisionedProduct">REST API Reference for ImportAsProvisionedProduct Operation</seealso>
        IAsyncResult BeginImportAsProvisionedProduct(ImportAsProvisionedProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportAsProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportAsProvisionedProduct.</param>
        /// 
        /// <returns>Returns a  ImportAsProvisionedProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ImportAsProvisionedProduct">REST API Reference for ImportAsProvisionedProduct Operation</seealso>
        ImportAsProvisionedProductResponse EndImportAsProvisionedProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAcceptedPortfolioShares


        /// <summary>
        /// Lists all imported portfolios for which account-to-account shares were accepted by
        /// this account. By specifying the <code>PortfolioShareType</code>, you can list portfolios
        /// for which organizational shares were accepted by this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAcceptedPortfolioShares service method.</param>
        /// 
        /// <returns>The response from the ListAcceptedPortfolioShares service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListAcceptedPortfolioShares">REST API Reference for ListAcceptedPortfolioShares Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListAcceptedPortfolioShares">REST API Reference for ListAcceptedPortfolioShares Operation</seealso>
        IAsyncResult BeginListAcceptedPortfolioShares(ListAcceptedPortfolioSharesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAcceptedPortfolioShares operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAcceptedPortfolioShares.</param>
        /// 
        /// <returns>Returns a  ListAcceptedPortfolioSharesResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListAcceptedPortfolioShares">REST API Reference for ListAcceptedPortfolioShares Operation</seealso>
        ListAcceptedPortfolioSharesResponse EndListAcceptedPortfolioShares(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBudgetsForResource


        /// <summary>
        /// Lists all the budgets associated to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBudgetsForResource service method.</param>
        /// 
        /// <returns>The response from the ListBudgetsForResource service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListBudgetsForResource">REST API Reference for ListBudgetsForResource Operation</seealso>
        ListBudgetsForResourceResponse ListBudgetsForResource(ListBudgetsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBudgetsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBudgetsForResource operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBudgetsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListBudgetsForResource">REST API Reference for ListBudgetsForResource Operation</seealso>
        IAsyncResult BeginListBudgetsForResource(ListBudgetsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBudgetsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBudgetsForResource.</param>
        /// 
        /// <returns>Returns a  ListBudgetsForResourceResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListBudgetsForResource">REST API Reference for ListBudgetsForResource Operation</seealso>
        ListBudgetsForResourceResponse EndListBudgetsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConstraintsForPortfolio


        /// <summary>
        /// Lists the constraints for the specified portfolio and product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConstraintsForPortfolio service method.</param>
        /// 
        /// <returns>The response from the ListConstraintsForPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListConstraintsForPortfolio">REST API Reference for ListConstraintsForPortfolio Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListConstraintsForPortfolio">REST API Reference for ListConstraintsForPortfolio Operation</seealso>
        IAsyncResult BeginListConstraintsForPortfolio(ListConstraintsForPortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConstraintsForPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConstraintsForPortfolio.</param>
        /// 
        /// <returns>Returns a  ListConstraintsForPortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListConstraintsForPortfolio">REST API Reference for ListConstraintsForPortfolio Operation</seealso>
        ListConstraintsForPortfolioResponse EndListConstraintsForPortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLaunchPaths


        /// <summary>
        /// Lists the paths to the specified product. A path describes how the user gets access
        /// to a specified product and is necessary when provisioning a product. A path also determines
        /// the constraints that are put on a product. A path is dependent on a specific product,
        /// porfolio, and principal. 
        /// 
        ///  <note> 
        /// <para>
        ///  When provisioning a product that's been added to a portfolio, you must grant your
        /// user, group, or role access to the portfolio. For more information, see <a href="https://docs.aws.amazon.com/servicecatalog/latest/adminguide/catalogs_portfolios_users.html">Granting
        /// users access</a> in the <i>Service Catalog User Guide</i>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLaunchPaths service method.</param>
        /// 
        /// <returns>The response from the ListLaunchPaths service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListLaunchPaths">REST API Reference for ListLaunchPaths Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListLaunchPaths">REST API Reference for ListLaunchPaths Operation</seealso>
        IAsyncResult BeginListLaunchPaths(ListLaunchPathsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLaunchPaths operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLaunchPaths.</param>
        /// 
        /// <returns>Returns a  ListLaunchPathsResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListLaunchPaths">REST API Reference for ListLaunchPaths Operation</seealso>
        ListLaunchPathsResponse EndListLaunchPaths(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOrganizationPortfolioAccess


        /// <summary>
        /// Lists the organization nodes that have access to the specified portfolio. This API
        /// can only be called by the management account in the organization or by a delegated
        /// admin.
        /// 
        ///  
        /// <para>
        /// If a delegated admin is de-registered, they can no longer perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationPortfolioAccess service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationPortfolioAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListOrganizationPortfolioAccess">REST API Reference for ListOrganizationPortfolioAccess Operation</seealso>
        ListOrganizationPortfolioAccessResponse ListOrganizationPortfolioAccess(ListOrganizationPortfolioAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationPortfolioAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationPortfolioAccess operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationPortfolioAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListOrganizationPortfolioAccess">REST API Reference for ListOrganizationPortfolioAccess Operation</seealso>
        IAsyncResult BeginListOrganizationPortfolioAccess(ListOrganizationPortfolioAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizationPortfolioAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizationPortfolioAccess.</param>
        /// 
        /// <returns>Returns a  ListOrganizationPortfolioAccessResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListOrganizationPortfolioAccess">REST API Reference for ListOrganizationPortfolioAccess Operation</seealso>
        ListOrganizationPortfolioAccessResponse EndListOrganizationPortfolioAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPortfolioAccess


        /// <summary>
        /// Lists the account IDs that have access to the specified portfolio.
        /// 
        ///  
        /// <para>
        /// A delegated admin can list the accounts that have access to the shared portfolio.
        /// Note that if a delegated admin is de-registered, they can no longer perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortfolioAccess service method.</param>
        /// 
        /// <returns>The response from the ListPortfolioAccess service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolioAccess">REST API Reference for ListPortfolioAccess Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolioAccess">REST API Reference for ListPortfolioAccess Operation</seealso>
        IAsyncResult BeginListPortfolioAccess(ListPortfolioAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPortfolioAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPortfolioAccess.</param>
        /// 
        /// <returns>Returns a  ListPortfolioAccessResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolioAccess">REST API Reference for ListPortfolioAccess Operation</seealso>
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
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolios">REST API Reference for ListPortfolios Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolios">REST API Reference for ListPortfolios Operation</seealso>
        IAsyncResult BeginListPortfolios(ListPortfoliosRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPortfolios operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPortfolios.</param>
        /// 
        /// <returns>Returns a  ListPortfoliosResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfolios">REST API Reference for ListPortfolios Operation</seealso>
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
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfoliosForProduct">REST API Reference for ListPortfoliosForProduct Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfoliosForProduct">REST API Reference for ListPortfoliosForProduct Operation</seealso>
        IAsyncResult BeginListPortfoliosForProduct(ListPortfoliosForProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPortfoliosForProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPortfoliosForProduct.</param>
        /// 
        /// <returns>Returns a  ListPortfoliosForProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPortfoliosForProduct">REST API Reference for ListPortfoliosForProduct Operation</seealso>
        ListPortfoliosForProductResponse EndListPortfoliosForProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPrincipalsForPortfolio


        /// <summary>
        /// Lists all <code>PrincipalARN</code>s and corresponding <code>PrincipalType</code>s
        /// associated with the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalsForPortfolio service method.</param>
        /// 
        /// <returns>The response from the ListPrincipalsForPortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPrincipalsForPortfolio">REST API Reference for ListPrincipalsForPortfolio Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPrincipalsForPortfolio">REST API Reference for ListPrincipalsForPortfolio Operation</seealso>
        IAsyncResult BeginListPrincipalsForPortfolio(ListPrincipalsForPortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPrincipalsForPortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPrincipalsForPortfolio.</param>
        /// 
        /// <returns>Returns a  ListPrincipalsForPortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListPrincipalsForPortfolio">REST API Reference for ListPrincipalsForPortfolio Operation</seealso>
        ListPrincipalsForPortfolioResponse EndListPrincipalsForPortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProvisionedProductPlans


        /// <summary>
        /// Lists the plans for the specified provisioned product or all plans to which the user
        /// has access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedProductPlans service method.</param>
        /// 
        /// <returns>The response from the ListProvisionedProductPlans service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisionedProductPlans">REST API Reference for ListProvisionedProductPlans Operation</seealso>
        ListProvisionedProductPlansResponse ListProvisionedProductPlans(ListProvisionedProductPlansRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisionedProductPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedProductPlans operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProvisionedProductPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisionedProductPlans">REST API Reference for ListProvisionedProductPlans Operation</seealso>
        IAsyncResult BeginListProvisionedProductPlans(ListProvisionedProductPlansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProvisionedProductPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProvisionedProductPlans.</param>
        /// 
        /// <returns>Returns a  ListProvisionedProductPlansResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisionedProductPlans">REST API Reference for ListProvisionedProductPlans Operation</seealso>
        ListProvisionedProductPlansResponse EndListProvisionedProductPlans(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProvisioningArtifacts


        /// <summary>
        /// Lists all provisioning artifacts (also known as versions) for the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListProvisioningArtifacts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifacts">REST API Reference for ListProvisioningArtifacts Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifacts">REST API Reference for ListProvisioningArtifacts Operation</seealso>
        IAsyncResult BeginListProvisioningArtifacts(ListProvisioningArtifactsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProvisioningArtifacts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProvisioningArtifacts.</param>
        /// 
        /// <returns>Returns a  ListProvisioningArtifactsResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifacts">REST API Reference for ListProvisioningArtifacts Operation</seealso>
        ListProvisioningArtifactsResponse EndListProvisioningArtifacts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProvisioningArtifactsForServiceAction


        /// <summary>
        /// Lists all provisioning artifacts (also known as versions) for the specified self-service
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifactsForServiceAction service method.</param>
        /// 
        /// <returns>The response from the ListProvisioningArtifactsForServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifactsForServiceAction">REST API Reference for ListProvisioningArtifactsForServiceAction Operation</seealso>
        ListProvisioningArtifactsForServiceActionResponse ListProvisioningArtifactsForServiceAction(ListProvisioningArtifactsForServiceActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisioningArtifactsForServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningArtifactsForServiceAction operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProvisioningArtifactsForServiceAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifactsForServiceAction">REST API Reference for ListProvisioningArtifactsForServiceAction Operation</seealso>
        IAsyncResult BeginListProvisioningArtifactsForServiceAction(ListProvisioningArtifactsForServiceActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProvisioningArtifactsForServiceAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProvisioningArtifactsForServiceAction.</param>
        /// 
        /// <returns>Returns a  ListProvisioningArtifactsForServiceActionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListProvisioningArtifactsForServiceAction">REST API Reference for ListProvisioningArtifactsForServiceAction Operation</seealso>
        ListProvisioningArtifactsForServiceActionResponse EndListProvisioningArtifactsForServiceAction(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRecordHistory


        /// <summary>
        /// Lists the specified requests or all performed requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecordHistory service method.</param>
        /// 
        /// <returns>The response from the ListRecordHistory service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListRecordHistory">REST API Reference for ListRecordHistory Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListRecordHistory">REST API Reference for ListRecordHistory Operation</seealso>
        IAsyncResult BeginListRecordHistory(ListRecordHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecordHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecordHistory.</param>
        /// 
        /// <returns>Returns a  ListRecordHistoryResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListRecordHistory">REST API Reference for ListRecordHistory Operation</seealso>
        ListRecordHistoryResponse EndListRecordHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourcesForTagOption


        /// <summary>
        /// Lists the resources associated with the specified TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForTagOption service method.</param>
        /// 
        /// <returns>The response from the ListResourcesForTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListResourcesForTagOption">REST API Reference for ListResourcesForTagOption Operation</seealso>
        ListResourcesForTagOptionResponse ListResourcesForTagOption(ListResourcesForTagOptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourcesForTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourcesForTagOption operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourcesForTagOption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListResourcesForTagOption">REST API Reference for ListResourcesForTagOption Operation</seealso>
        IAsyncResult BeginListResourcesForTagOption(ListResourcesForTagOptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourcesForTagOption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourcesForTagOption.</param>
        /// 
        /// <returns>Returns a  ListResourcesForTagOptionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListResourcesForTagOption">REST API Reference for ListResourcesForTagOption Operation</seealso>
        ListResourcesForTagOptionResponse EndListResourcesForTagOption(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServiceActions


        /// <summary>
        /// Lists all self-service actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceActions service method.</param>
        /// 
        /// <returns>The response from the ListServiceActions service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActions">REST API Reference for ListServiceActions Operation</seealso>
        ListServiceActionsResponse ListServiceActions(ListServiceActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceActions operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActions">REST API Reference for ListServiceActions Operation</seealso>
        IAsyncResult BeginListServiceActions(ListServiceActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceActions.</param>
        /// 
        /// <returns>Returns a  ListServiceActionsResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActions">REST API Reference for ListServiceActions Operation</seealso>
        ListServiceActionsResponse EndListServiceActions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServiceActionsForProvisioningArtifact


        /// <summary>
        /// Returns a paginated list of self-service actions associated with the specified Product
        /// ID and Provisioning Artifact ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceActionsForProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the ListServiceActionsForProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActionsForProvisioningArtifact">REST API Reference for ListServiceActionsForProvisioningArtifact Operation</seealso>
        ListServiceActionsForProvisioningArtifactResponse ListServiceActionsForProvisioningArtifact(ListServiceActionsForProvisioningArtifactRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceActionsForProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceActionsForProvisioningArtifact operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceActionsForProvisioningArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActionsForProvisioningArtifact">REST API Reference for ListServiceActionsForProvisioningArtifact Operation</seealso>
        IAsyncResult BeginListServiceActionsForProvisioningArtifact(ListServiceActionsForProvisioningArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceActionsForProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceActionsForProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  ListServiceActionsForProvisioningArtifactResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListServiceActionsForProvisioningArtifact">REST API Reference for ListServiceActionsForProvisioningArtifact Operation</seealso>
        ListServiceActionsForProvisioningArtifactResponse EndListServiceActionsForProvisioningArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStackInstancesForProvisionedProduct


        /// <summary>
        /// Returns summary information about stack instances that are associated with the specified
        /// <code>CFN_STACKSET</code> type provisioned product. You can filter for stack instances
        /// that are associated with a specific Amazon Web Services account name or Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstancesForProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the ListStackInstancesForProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListStackInstancesForProvisionedProduct">REST API Reference for ListStackInstancesForProvisionedProduct Operation</seealso>
        ListStackInstancesForProvisionedProductResponse ListStackInstancesForProvisionedProduct(ListStackInstancesForProvisionedProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStackInstancesForProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstancesForProvisionedProduct operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStackInstancesForProvisionedProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListStackInstancesForProvisionedProduct">REST API Reference for ListStackInstancesForProvisionedProduct Operation</seealso>
        IAsyncResult BeginListStackInstancesForProvisionedProduct(ListStackInstancesForProvisionedProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStackInstancesForProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStackInstancesForProvisionedProduct.</param>
        /// 
        /// <returns>Returns a  ListStackInstancesForProvisionedProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListStackInstancesForProvisionedProduct">REST API Reference for ListStackInstancesForProvisionedProduct Operation</seealso>
        ListStackInstancesForProvisionedProductResponse EndListStackInstancesForProvisionedProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagOptions


        /// <summary>
        /// Lists the specified TagOptions or all TagOptions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagOptions service method.</param>
        /// 
        /// <returns>The response from the ListTagOptions service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListTagOptions">REST API Reference for ListTagOptions Operation</seealso>
        ListTagOptionsResponse ListTagOptions(ListTagOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagOptions operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListTagOptions">REST API Reference for ListTagOptions Operation</seealso>
        IAsyncResult BeginListTagOptions(ListTagOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagOptions.</param>
        /// 
        /// <returns>Returns a  ListTagOptionsResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ListTagOptions">REST API Reference for ListTagOptions Operation</seealso>
        ListTagOptionsResponse EndListTagOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  ProvisionProduct


        /// <summary>
        /// Provisions the specified product. 
        /// 
        ///  
        /// <para>
        ///  A provisioned product is a resourced instance of a product. For example, provisioning
        /// a product that's based on an CloudFormation template launches an CloudFormation stack
        /// and its underlying resources. You can check the status of this request using <a>DescribeRecord</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  If the request contains a tag key with an empty list of values, there's a tag conflict
        /// for that key. Don't include conflicted keys as tags, or this will cause the error
        /// "Parameter validation failed: Missing required parameter in Tags[<i>N</i>]:<i>Value</i>".
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  When provisioning a product that's been added to a portfolio, you must grant your
        /// user, group, or role access to the portfolio. For more information, see <a href="https://docs.aws.amazon.com/servicecatalog/latest/adminguide/catalogs_portfolios_users.html">Granting
        /// users access</a> in the <i>Service Catalog User Guide</i>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionProduct service method.</param>
        /// 
        /// <returns>The response from the ProvisionProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ProvisionProduct">REST API Reference for ProvisionProduct Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ProvisionProduct">REST API Reference for ProvisionProduct Operation</seealso>
        IAsyncResult BeginProvisionProduct(ProvisionProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ProvisionProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginProvisionProduct.</param>
        /// 
        /// <returns>Returns a  ProvisionProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ProvisionProduct">REST API Reference for ProvisionProduct Operation</seealso>
        ProvisionProductResponse EndProvisionProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectPortfolioShare


        /// <summary>
        /// Rejects an offer to share the specified portfolio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectPortfolioShare service method.</param>
        /// 
        /// <returns>The response from the RejectPortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/RejectPortfolioShare">REST API Reference for RejectPortfolioShare Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/RejectPortfolioShare">REST API Reference for RejectPortfolioShare Operation</seealso>
        IAsyncResult BeginRejectPortfolioShare(RejectPortfolioShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectPortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectPortfolioShare.</param>
        /// 
        /// <returns>Returns a  RejectPortfolioShareResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/RejectPortfolioShare">REST API Reference for RejectPortfolioShare Operation</seealso>
        RejectPortfolioShareResponse EndRejectPortfolioShare(IAsyncResult asyncResult);

        #endregion
        
        #region  ScanProvisionedProducts


        /// <summary>
        /// Lists the provisioned products that are available (not terminated).
        /// 
        ///  
        /// <para>
        /// To use additional filtering, see <a>SearchProvisionedProducts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScanProvisionedProducts service method.</param>
        /// 
        /// <returns>The response from the ScanProvisionedProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ScanProvisionedProducts">REST API Reference for ScanProvisionedProducts Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ScanProvisionedProducts">REST API Reference for ScanProvisionedProducts Operation</seealso>
        IAsyncResult BeginScanProvisionedProducts(ScanProvisionedProductsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ScanProvisionedProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginScanProvisionedProducts.</param>
        /// 
        /// <returns>Returns a  ScanProvisionedProductsResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/ScanProvisionedProducts">REST API Reference for ScanProvisionedProducts Operation</seealso>
        ScanProvisionedProductsResponse EndScanProvisionedProducts(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchProducts


        /// <summary>
        /// Gets information about the products to which the caller has access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProducts service method.</param>
        /// 
        /// <returns>The response from the SearchProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProducts">REST API Reference for SearchProducts Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProducts">REST API Reference for SearchProducts Operation</seealso>
        IAsyncResult BeginSearchProducts(SearchProductsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchProducts.</param>
        /// 
        /// <returns>Returns a  SearchProductsResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProducts">REST API Reference for SearchProducts Operation</seealso>
        SearchProductsResponse EndSearchProducts(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchProductsAsAdmin


        /// <summary>
        /// Gets information about the products for the specified portfolio or all products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProductsAsAdmin service method.</param>
        /// 
        /// <returns>The response from the SearchProductsAsAdmin service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProductsAsAdmin">REST API Reference for SearchProductsAsAdmin Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProductsAsAdmin">REST API Reference for SearchProductsAsAdmin Operation</seealso>
        IAsyncResult BeginSearchProductsAsAdmin(SearchProductsAsAdminRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchProductsAsAdmin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchProductsAsAdmin.</param>
        /// 
        /// <returns>Returns a  SearchProductsAsAdminResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProductsAsAdmin">REST API Reference for SearchProductsAsAdmin Operation</seealso>
        SearchProductsAsAdminResponse EndSearchProductsAsAdmin(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchProvisionedProducts


        /// <summary>
        /// Gets information about the provisioned products that meet the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchProvisionedProducts service method.</param>
        /// 
        /// <returns>The response from the SearchProvisionedProducts service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProvisionedProducts">REST API Reference for SearchProvisionedProducts Operation</seealso>
        SearchProvisionedProductsResponse SearchProvisionedProducts(SearchProvisionedProductsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchProvisionedProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchProvisionedProducts operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchProvisionedProducts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProvisionedProducts">REST API Reference for SearchProvisionedProducts Operation</seealso>
        IAsyncResult BeginSearchProvisionedProducts(SearchProvisionedProductsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchProvisionedProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchProvisionedProducts.</param>
        /// 
        /// <returns>Returns a  SearchProvisionedProductsResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/SearchProvisionedProducts">REST API Reference for SearchProvisionedProducts Operation</seealso>
        SearchProvisionedProductsResponse EndSearchProvisionedProducts(IAsyncResult asyncResult);

        #endregion
        
        #region  TerminateProvisionedProduct


        /// <summary>
        /// Terminates the specified provisioned product.
        /// 
        ///  
        /// <para>
        /// This operation does not delete any records associated with the provisioned product.
        /// </para>
        ///  
        /// <para>
        /// You can check the status of this request using <a>DescribeRecord</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the TerminateProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/TerminateProvisionedProduct">REST API Reference for TerminateProvisionedProduct Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/TerminateProvisionedProduct">REST API Reference for TerminateProvisionedProduct Operation</seealso>
        IAsyncResult BeginTerminateProvisionedProduct(TerminateProvisionedProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateProvisionedProduct.</param>
        /// 
        /// <returns>Returns a  TerminateProvisionedProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/TerminateProvisionedProduct">REST API Reference for TerminateProvisionedProduct Operation</seealso>
        TerminateProvisionedProductResponse EndTerminateProvisionedProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConstraint


        /// <summary>
        /// Updates the specified constraint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConstraint service method.</param>
        /// 
        /// <returns>The response from the UpdateConstraint service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateConstraint">REST API Reference for UpdateConstraint Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateConstraint">REST API Reference for UpdateConstraint Operation</seealso>
        IAsyncResult BeginUpdateConstraint(UpdateConstraintRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConstraint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConstraint.</param>
        /// 
        /// <returns>Returns a  UpdateConstraintResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateConstraint">REST API Reference for UpdateConstraint Operation</seealso>
        UpdateConstraintResponse EndUpdateConstraint(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePortfolio


        /// <summary>
        /// Updates the specified portfolio.
        /// 
        ///  
        /// <para>
        /// You cannot update a product that was shared with you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortfolio service method.</param>
        /// 
        /// <returns>The response from the UpdatePortfolio service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.LimitExceededException">
        /// The current limits of the service would have been exceeded by this operation. Decrease
        /// your resource use or increase your service limits and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolio">REST API Reference for UpdatePortfolio Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolio">REST API Reference for UpdatePortfolio Operation</seealso>
        IAsyncResult BeginUpdatePortfolio(UpdatePortfolioRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePortfolio operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePortfolio.</param>
        /// 
        /// <returns>Returns a  UpdatePortfolioResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolio">REST API Reference for UpdatePortfolio Operation</seealso>
        UpdatePortfolioResponse EndUpdatePortfolio(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePortfolioShare


        /// <summary>
        /// Updates the specified portfolio share. You can use this API to enable or disable <code>TagOptions</code>
        /// sharing or Principal sharing for an existing portfolio share. 
        /// 
        ///  
        /// <para>
        /// The portfolio share cannot be updated if the <code>CreatePortfolioShare</code> operation
        /// is <code>IN_PROGRESS</code>, as the share is not available to recipient entities.
        /// In this case, you must wait for the portfolio share to be COMPLETED.
        /// </para>
        ///  
        /// <para>
        /// You must provide the <code>accountId</code> or organization node in the input, but
        /// not both.
        /// </para>
        ///  
        /// <para>
        /// If the portfolio is shared to both an external account and an organization node, and
        /// both shares need to be updated, you must invoke <code>UpdatePortfolioShare</code>
        /// separately for each share type. 
        /// </para>
        ///  
        /// <para>
        /// This API cannot be used for removing the portfolio share. You must use <code>DeletePortfolioShare</code>
        /// API for that action. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you associate a principal with portfolio, a potential privilege escalation path
        /// may occur when that portfolio is then shared with other accounts. For a user in a
        /// recipient account who is <i>not</i> an Service Catalog Admin, but still has the ability
        /// to create Principals (Users/Groups/Roles), that user could create a role that matches
        /// a principal name association for the portfolio. Although this user may not know which
        /// principal names are associated through Service Catalog, they may be able to guess
        /// the user. If this potential escalation path is a concern, then Service Catalog recommends
        /// using <code>PrincipalType</code> as <code>IAM</code>. With this configuration, the
        /// <code>PrincipalARN</code> must already exist in the recipient account before it can
        /// be associated. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortfolioShare service method.</param>
        /// 
        /// <returns>The response from the UpdatePortfolioShare service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.OperationNotSupportedException">
        /// The operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolioShare">REST API Reference for UpdatePortfolioShare Operation</seealso>
        UpdatePortfolioShareResponse UpdatePortfolioShare(UpdatePortfolioShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortfolioShare operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePortfolioShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolioShare">REST API Reference for UpdatePortfolioShare Operation</seealso>
        IAsyncResult BeginUpdatePortfolioShare(UpdatePortfolioShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePortfolioShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePortfolioShare.</param>
        /// 
        /// <returns>Returns a  UpdatePortfolioShareResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdatePortfolioShare">REST API Reference for UpdatePortfolioShare Operation</seealso>
        UpdatePortfolioShareResponse EndUpdatePortfolioShare(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProduct


        /// <summary>
        /// Updates the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProduct service method.</param>
        /// 
        /// <returns>The response from the UpdateProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
        IAsyncResult BeginUpdateProduct(UpdateProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProduct.</param>
        /// 
        /// <returns>Returns a  UpdateProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
        UpdateProductResponse EndUpdateProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProvisionedProduct


        /// <summary>
        /// Requests updates to the configuration of the specified provisioned product.
        /// 
        ///  
        /// <para>
        /// If there are tags associated with the object, they cannot be updated or added. Depending
        /// on the specific updates requested, this operation can update with no interruption,
        /// with some interruption, or replace the provisioned product entirely.
        /// </para>
        ///  
        /// <para>
        /// You can check the status of this request using <a>DescribeRecord</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProduct service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisionedProduct service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProduct">REST API Reference for UpdateProvisionedProduct Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProduct">REST API Reference for UpdateProvisionedProduct Operation</seealso>
        IAsyncResult BeginUpdateProvisionedProduct(UpdateProvisionedProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProvisionedProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProvisionedProduct.</param>
        /// 
        /// <returns>Returns a  UpdateProvisionedProductResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProduct">REST API Reference for UpdateProvisionedProduct Operation</seealso>
        UpdateProvisionedProductResponse EndUpdateProvisionedProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProvisionedProductProperties


        /// <summary>
        /// Requests updates to the properties of the specified provisioned product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProductProperties service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisionedProductProperties service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidStateException">
        /// An attempt was made to modify a resource that is in a state that is not valid. Check
        /// your resources to ensure that they are in valid states before retrying the operation.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProductProperties">REST API Reference for UpdateProvisionedProductProperties Operation</seealso>
        UpdateProvisionedProductPropertiesResponse UpdateProvisionedProductProperties(UpdateProvisionedProductPropertiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProvisionedProductProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedProductProperties operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProvisionedProductProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProductProperties">REST API Reference for UpdateProvisionedProductProperties Operation</seealso>
        IAsyncResult BeginUpdateProvisionedProductProperties(UpdateProvisionedProductPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProvisionedProductProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProvisionedProductProperties.</param>
        /// 
        /// <returns>Returns a  UpdateProvisionedProductPropertiesResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisionedProductProperties">REST API Reference for UpdateProvisionedProductProperties Operation</seealso>
        UpdateProvisionedProductPropertiesResponse EndUpdateProvisionedProductProperties(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProvisioningArtifact


        /// <summary>
        /// Updates the specified provisioning artifact (also known as a version) for the specified
        /// product.
        /// 
        ///  
        /// <para>
        /// You cannot update a provisioning artifact for a product that was shared with you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisioningArtifact service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisioningArtifact service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisioningArtifact">REST API Reference for UpdateProvisioningArtifact Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisioningArtifact">REST API Reference for UpdateProvisioningArtifact Operation</seealso>
        IAsyncResult BeginUpdateProvisioningArtifact(UpdateProvisioningArtifactRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProvisioningArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProvisioningArtifact.</param>
        /// 
        /// <returns>Returns a  UpdateProvisioningArtifactResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateProvisioningArtifact">REST API Reference for UpdateProvisioningArtifact Operation</seealso>
        UpdateProvisioningArtifactResponse EndUpdateProvisioningArtifact(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateServiceAction


        /// <summary>
        /// Updates a self-service action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAction service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceAction service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateServiceAction">REST API Reference for UpdateServiceAction Operation</seealso>
        UpdateServiceActionResponse UpdateServiceAction(UpdateServiceActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceAction operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateServiceAction">REST API Reference for UpdateServiceAction Operation</seealso>
        IAsyncResult BeginUpdateServiceAction(UpdateServiceActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceAction.</param>
        /// 
        /// <returns>Returns a  UpdateServiceActionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateServiceAction">REST API Reference for UpdateServiceAction Operation</seealso>
        UpdateServiceActionResponse EndUpdateServiceAction(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTagOption


        /// <summary>
        /// Updates the specified TagOption.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagOption service method.</param>
        /// 
        /// <returns>The response from the UpdateTagOption service method, as returned by ServiceCatalog.</returns>
        /// <exception cref="Amazon.ServiceCatalog.Model.DuplicateResourceException">
        /// The specified resource is a duplicate.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.InvalidParametersException">
        /// One or more parameters provided to the operation are not valid.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ServiceCatalog.Model.TagOptionNotMigratedException">
        /// An operation requiring TagOptions failed because the TagOptions migration process
        /// has not been performed for this account. Use the Amazon Web Services Management Console
        /// to perform the migration process before retrying the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateTagOption">REST API Reference for UpdateTagOption Operation</seealso>
        UpdateTagOptionResponse UpdateTagOption(UpdateTagOptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTagOption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagOption operation on AmazonServiceCatalogClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTagOption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateTagOption">REST API Reference for UpdateTagOption Operation</seealso>
        IAsyncResult BeginUpdateTagOption(UpdateTagOptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTagOption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTagOption.</param>
        /// 
        /// <returns>Returns a  UpdateTagOptionResult from ServiceCatalog.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/servicecatalog-2015-12-10/UpdateTagOption">REST API Reference for UpdateTagOption Operation</seealso>
        UpdateTagOptionResponse EndUpdateTagOption(IAsyncResult asyncResult);

        #endregion
        
    }
}