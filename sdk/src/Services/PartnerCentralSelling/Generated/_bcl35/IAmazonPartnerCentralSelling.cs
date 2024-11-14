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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PartnerCentralSelling.Model;

#pragma warning disable CS1570
namespace Amazon.PartnerCentralSelling
{
    /// <summary>
    /// <para>Interface for accessing PartnerCentralSelling</para>
    ///
    /// AWS Partner Central API for Selling 
    /// <para>
    ///  <b>AWS Partner Central API for Selling Reference Guide</b> 
    /// 
    ///  
    /// <para>
    ///  Amazon Web Services (AWS) Partner Central API reference guide is designed to help
    /// <a href="https://docs.aws.amazon.com/partners/programs/">AWS Partners</a> programmatically
    /// integrate their Customer Relationship Management (CRM) systems with AWS Partner Central.
    /// Through the Partner Central APIs, partners can automate and streamline their interactions
    /// with AWS Partner Central, ensuring a more efficient and effective engagement in joint
    /// business activities. 
    /// </para>
    ///  
    /// <para>
    ///  The AWS Partner Central API service provides standard AWS API functionality. You
    /// can directly use the API <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/API_Operations.html">Actions</a>,
    /// or you can use an AWS SDK to access an API that's tailored to the programming language
    /// or platform that you're using. For more information about AWS application development,
    /// see <a href="https://docs.aws.amazon.com/getting-started">Getting Started with AWS</a>.
    /// For more information about using AWS SDKs, see <a href="https://docs.aws.amazon.com/aws-sdk">AWS
    /// SDKs</a>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Features offered by AWS Partner Central API</b> 
    /// </para>
    ///  <ol> <li> 
    /// <para>
    ///  <b>Opportunity management:</b> Facilitates the management of co-selling opportunities
    /// with AWS using API actions such as <c>CreateOpportunity</c>, <c>UpdateOpportunity</c>,
    /// <c>ListOpportunities</c>, <c>GetOpportunity</c>, and <c>AssignOpportunity</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AWS referral management:</b> Facilitates receiving referrals shared by AWS using
    /// actions like <c>ListEngagementInvitations</c>, <c>GetEngagementInvitation</c>, <c>StartEngagementByAcceptingInvitation</c>,
    /// and <c>RejectEngagementInvitation</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Entity association:</b> Associate related entities such as <i>AWS Products</i>,
    /// <i>Partner Solutions</i>, and <i>AWS Marketplace Private Offers</i> with opportunities
    /// using the actions <c>AssociateOpportunity</c> and <c>DisassociateOpportunity</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>View AWS opportunity details:</b> Use the <c>GetAWSOpportunitySummary</c> action
    /// to retrieve real-time summaries of AWS opportunities that are linked to your opportunities.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>List solutions:</b> Provides list APIs for listing solutions partners offer using
    /// <c>ListSolutions</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Event subscription:</b> Partners can subscribe to real-time updates on opportunities
    /// by listening to events such as <i>Opportunity Created</i>, <i>Opportunity Updated</i>,
    /// <i>Engagement Invitation Accepted</i>, <i>Engagement Invitation Rejected</i> and <i>Engagement
    /// Invitation Created</i> using AWS EventBridge.
    /// </para>
    ///  </li> </ol>
    /// </para>
    /// </summary>
    public partial interface IAmazonPartnerCentralSelling : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPartnerCentralSellingPaginatorFactory Paginators { get; }
#endif


        
        #region  AssignOpportunity


        /// <summary>
        /// Enables you to reassign an existing <c>Opportunity</c> to another user within your
        /// Partner Central account. The specified user receives the opportunity, and it appears
        /// on their Partner Central dashboard, allowing them to take necessary actions or proceed
        /// with the opportunity. 
        /// 
        ///  
        /// <para>
        ///  This is useful for distributing opportunities to the appropriate team members or
        /// departments within your organization, ensuring that each opportunity is handled by
        /// the right person. By default, the opportunity owner is the one who creates it. Currently,
        /// there's no API to enumerate the list of available users. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignOpportunity service method.</param>
        /// 
        /// <returns>The response from the AssignOpportunity service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.InternalServerException">
        /// This error occurs when the specified resource can’t be found or doesn't exist. Resource
        /// ID and type might be incorrect. 
        /// 
        ///  
        /// <para>
        /// Suggested action: This is usually a transient error. Retry after the provided retry
        /// delay or a short interval. If the problem persists, contact AWS support. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ResourceNotFoundException">
        /// This error occurs when the specified resource can't be found. The resource might not
        /// exist, or isn't visible with the current credentials. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Verify that the resource ID is correct and the resource is in the
        /// expected AWS region. Check IAM permissions for accessing the resource. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling. 
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">quotas</a>
        /// and retry after the provided delay. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service or business validation
        /// rules. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the error message, including the failed fields and reasons,
        /// to correct the request payload. 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/AssignOpportunity">REST API Reference for AssignOpportunity Operation</seealso>
        AssignOpportunityResponse AssignOpportunity(AssignOpportunityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssignOpportunity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignOpportunity operation on AmazonPartnerCentralSellingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssignOpportunity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/AssignOpportunity">REST API Reference for AssignOpportunity Operation</seealso>
        IAsyncResult BeginAssignOpportunity(AssignOpportunityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssignOpportunity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssignOpportunity.</param>
        /// 
        /// <returns>Returns a  AssignOpportunityResult from PartnerCentralSelling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/AssignOpportunity">REST API Reference for AssignOpportunity Operation</seealso>
        AssignOpportunityResponse EndAssignOpportunity(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateOpportunity


        /// <summary>
        /// Enables you to create a formal association between an <c>Opportunity</c> and various
        /// related entities, enriching the context and details of the opportunity for better
        /// collaboration and decision-making. You can associate an opportunity with the following
        /// types of entities: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  Partner Solution: A software product or consulting practice created and delivered
        /// by Partners. Partner Solutions help customers address specific business challenges
        /// or achieve particular goals using Amazon Web Services services. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Amazon Web Services Product: Amazon Web Services offers a wide range of products
        /// and services designed to provide scalable, reliable, and cost-effective infrastructure
        /// solutions. For the latest list of Amazon Web Services products, refer to <a href="https://github.com/aws-samples/partner-crm-integration-samples/blob/main/resources/aws_products.json">Amazon
        /// Web Services products</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Amazon Web Services Marketplace private offer: Allows Amazon Web Services Marketplace
        /// sellers to extend custom pricing and terms to individual Amazon Web Services customers.
        /// Sellers can negotiate custom prices, payment schedules, and end user license terms
        /// through private offers, enabling Amazon Web Services customers to acquire software
        /// solutions tailored to their specific needs. For more information, refer to <a href="https://docs.aws.amazon.com/marketplace/latest/buyerguide/buyer-private-offers.html">Private
        /// offers in Amazon Web Services Marketplace</a>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To obtain identifiers for these entities, use the following methods:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Solution: Use the <c>ListSolutions</c> operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  AWS products: For the latest list of Amazon Web Services products, refer to the Amazon
        /// Web Services products list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Amazon Web Services Marketplace private offer: Use the <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html">AWS
        /// Marketplace Catalog API</a> to list entities. Specifically, use the <c>ListEntities</c>
        /// operation to retrieve a list of private offers. The request to the <c>ListEntities</c>
        /// API returns the details of the private offers available to you. For more information,
        /// refer to <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/API_ListEntities.html">ListEntities</a>.
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateOpportunity service method.</param>
        /// 
        /// <returns>The response from the AssociateOpportunity service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.InternalServerException">
        /// This error occurs when the specified resource can’t be found or doesn't exist. Resource
        /// ID and type might be incorrect. 
        /// 
        ///  
        /// <para>
        /// Suggested action: This is usually a transient error. Retry after the provided retry
        /// delay or a short interval. If the problem persists, contact AWS support. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ResourceNotFoundException">
        /// This error occurs when the specified resource can't be found. The resource might not
        /// exist, or isn't visible with the current credentials. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Verify that the resource ID is correct and the resource is in the
        /// expected AWS region. Check IAM permissions for accessing the resource. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling. 
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">quotas</a>
        /// and retry after the provided delay. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service or business validation
        /// rules. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the error message, including the failed fields and reasons,
        /// to correct the request payload. 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/AssociateOpportunity">REST API Reference for AssociateOpportunity Operation</seealso>
        AssociateOpportunityResponse AssociateOpportunity(AssociateOpportunityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateOpportunity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateOpportunity operation on AmazonPartnerCentralSellingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateOpportunity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/AssociateOpportunity">REST API Reference for AssociateOpportunity Operation</seealso>
        IAsyncResult BeginAssociateOpportunity(AssociateOpportunityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateOpportunity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateOpportunity.</param>
        /// 
        /// <returns>Returns a  AssociateOpportunityResult from PartnerCentralSelling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/AssociateOpportunity">REST API Reference for AssociateOpportunity Operation</seealso>
        AssociateOpportunityResponse EndAssociateOpportunity(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOpportunity


        /// <summary>
        /// Creates an <c>Opportunity</c> record in Partner Central. Use this operation to create
        /// a potential business opportunity intended to be submitted to Amazon Web Services.
        /// Creating an opportunity sets its <c>Lifecycle.ReviewStatus</c> to <c>Pending Submission</c>.
        /// 
        /// 
        ///  
        /// <para>
        ///  To fully submit an opportunity, follow these steps: 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// To create the opportunity, use <c>CreateOpportunity</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To associate a solution with the opportunity, use <c>AssociateOpportunity</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To submit the opportunity, use <c>SubmitOpportunity</c>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        ///  After submission, you can't edit the opportunity until the review is complete. However,
        /// opportunities in the <c>Pending Submission</c> state still need all details completed.
        /// You can update the opportunity while it's in the <c>Pending Submission</c> state.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  There's a set of mandatory fields required to create opportunities, but consider
        /// providing optional fields to enrich the opportunity record. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpportunity service method.</param>
        /// 
        /// <returns>The response from the CreateOpportunity service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ConflictException">
        /// This error occurs when the request can’t be processed due to a conflict with the target
        /// resource's current state, which could result from updating or deleting the resource.
        /// 
        /// 
        ///  
        /// <para>
        /// Suggested action: Fetch the latest state of the resource, verify the state, and retry
        /// the request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.InternalServerException">
        /// This error occurs when the specified resource can’t be found or doesn't exist. Resource
        /// ID and type might be incorrect. 
        /// 
        ///  
        /// <para>
        /// Suggested action: This is usually a transient error. Retry after the provided retry
        /// delay or a short interval. If the problem persists, contact AWS support. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ResourceNotFoundException">
        /// This error occurs when the specified resource can't be found. The resource might not
        /// exist, or isn't visible with the current credentials. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Verify that the resource ID is correct and the resource is in the
        /// expected AWS region. Check IAM permissions for accessing the resource. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling. 
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">quotas</a>
        /// and retry after the provided delay. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service or business validation
        /// rules. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the error message, including the failed fields and reasons,
        /// to correct the request payload. 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/CreateOpportunity">REST API Reference for CreateOpportunity Operation</seealso>
        CreateOpportunityResponse CreateOpportunity(CreateOpportunityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOpportunity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOpportunity operation on AmazonPartnerCentralSellingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOpportunity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/CreateOpportunity">REST API Reference for CreateOpportunity Operation</seealso>
        IAsyncResult BeginCreateOpportunity(CreateOpportunityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOpportunity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOpportunity.</param>
        /// 
        /// <returns>Returns a  CreateOpportunityResult from PartnerCentralSelling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/CreateOpportunity">REST API Reference for CreateOpportunity Operation</seealso>
        CreateOpportunityResponse EndCreateOpportunity(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateOpportunity


        /// <summary>
        /// Allows you to remove an existing association between an <c>Opportunity</c> and related
        /// entities such as a Partner Solution, Amazon Web Services product, or an Amazon Web
        /// Services Marketplace offer. This operation is the counterpart to <c>AssociateOpportunity</c>,
        /// and it provides flexibility to manage associations as business needs change. 
        /// 
        ///  
        /// <para>
        ///  Use this operation to update the associations of an <c>Opportunity</c> due to changes
        /// in the related entities, or if an association was made in error. Ensuring accurate
        /// associations helps maintain clarity and accuracy to track and manage business opportunities.
        /// When you replace an entity, first attach the new entity and then disassociate the
        /// one to be removed, especially if it's the last remaining related entity that's required.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOpportunity service method.</param>
        /// 
        /// <returns>The response from the DisassociateOpportunity service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.InternalServerException">
        /// This error occurs when the specified resource can’t be found or doesn't exist. Resource
        /// ID and type might be incorrect. 
        /// 
        ///  
        /// <para>
        /// Suggested action: This is usually a transient error. Retry after the provided retry
        /// delay or a short interval. If the problem persists, contact AWS support. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ResourceNotFoundException">
        /// This error occurs when the specified resource can't be found. The resource might not
        /// exist, or isn't visible with the current credentials. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Verify that the resource ID is correct and the resource is in the
        /// expected AWS region. Check IAM permissions for accessing the resource. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling. 
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">quotas</a>
        /// and retry after the provided delay. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service or business validation
        /// rules. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the error message, including the failed fields and reasons,
        /// to correct the request payload. 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/DisassociateOpportunity">REST API Reference for DisassociateOpportunity Operation</seealso>
        DisassociateOpportunityResponse DisassociateOpportunity(DisassociateOpportunityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateOpportunity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOpportunity operation on AmazonPartnerCentralSellingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateOpportunity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/DisassociateOpportunity">REST API Reference for DisassociateOpportunity Operation</seealso>
        IAsyncResult BeginDisassociateOpportunity(DisassociateOpportunityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateOpportunity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateOpportunity.</param>
        /// 
        /// <returns>Returns a  DisassociateOpportunityResult from PartnerCentralSelling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/DisassociateOpportunity">REST API Reference for DisassociateOpportunity Operation</seealso>
        DisassociateOpportunityResponse EndDisassociateOpportunity(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAwsOpportunitySummary


        /// <summary>
        /// Retrieves a summary of an AWS Opportunity. This summary includes high-level details
        /// about the opportunity sourced from AWS, such as lifecycle information, customer details,
        /// and involvement type. It is useful for tracking updates on the AWS opportunity corresponding
        /// to an opportunity in the partner's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAwsOpportunitySummary service method.</param>
        /// 
        /// <returns>The response from the GetAwsOpportunitySummary service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.InternalServerException">
        /// This error occurs when the specified resource can’t be found or doesn't exist. Resource
        /// ID and type might be incorrect. 
        /// 
        ///  
        /// <para>
        /// Suggested action: This is usually a transient error. Retry after the provided retry
        /// delay or a short interval. If the problem persists, contact AWS support. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ResourceNotFoundException">
        /// This error occurs when the specified resource can't be found. The resource might not
        /// exist, or isn't visible with the current credentials. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Verify that the resource ID is correct and the resource is in the
        /// expected AWS region. Check IAM permissions for accessing the resource. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling. 
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">quotas</a>
        /// and retry after the provided delay. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service or business validation
        /// rules. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the error message, including the failed fields and reasons,
        /// to correct the request payload. 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/GetAwsOpportunitySummary">REST API Reference for GetAwsOpportunitySummary Operation</seealso>
        GetAwsOpportunitySummaryResponse GetAwsOpportunitySummary(GetAwsOpportunitySummaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAwsOpportunitySummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAwsOpportunitySummary operation on AmazonPartnerCentralSellingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAwsOpportunitySummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/GetAwsOpportunitySummary">REST API Reference for GetAwsOpportunitySummary Operation</seealso>
        IAsyncResult BeginGetAwsOpportunitySummary(GetAwsOpportunitySummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAwsOpportunitySummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAwsOpportunitySummary.</param>
        /// 
        /// <returns>Returns a  GetAwsOpportunitySummaryResult from PartnerCentralSelling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/GetAwsOpportunitySummary">REST API Reference for GetAwsOpportunitySummary Operation</seealso>
        GetAwsOpportunitySummaryResponse EndGetAwsOpportunitySummary(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEngagementInvitation


        /// <summary>
        /// Retrieves the details of an engagement invitation shared by AWS with a partner. The
        /// information includes key aspects such as the customer, project details, and lifecycle
        /// information related to the engagement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEngagementInvitation service method.</param>
        /// 
        /// <returns>The response from the GetEngagementInvitation service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.InternalServerException">
        /// This error occurs when the specified resource can’t be found or doesn't exist. Resource
        /// ID and type might be incorrect. 
        /// 
        ///  
        /// <para>
        /// Suggested action: This is usually a transient error. Retry after the provided retry
        /// delay or a short interval. If the problem persists, contact AWS support. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ResourceNotFoundException">
        /// This error occurs when the specified resource can't be found. The resource might not
        /// exist, or isn't visible with the current credentials. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Verify that the resource ID is correct and the resource is in the
        /// expected AWS region. Check IAM permissions for accessing the resource. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling. 
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">quotas</a>
        /// and retry after the provided delay. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service or business validation
        /// rules. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the error message, including the failed fields and reasons,
        /// to correct the request payload. 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/GetEngagementInvitation">REST API Reference for GetEngagementInvitation Operation</seealso>
        GetEngagementInvitationResponse GetEngagementInvitation(GetEngagementInvitationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEngagementInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEngagementInvitation operation on AmazonPartnerCentralSellingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEngagementInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/GetEngagementInvitation">REST API Reference for GetEngagementInvitation Operation</seealso>
        IAsyncResult BeginGetEngagementInvitation(GetEngagementInvitationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEngagementInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEngagementInvitation.</param>
        /// 
        /// <returns>Returns a  GetEngagementInvitationResult from PartnerCentralSelling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/GetEngagementInvitation">REST API Reference for GetEngagementInvitation Operation</seealso>
        GetEngagementInvitationResponse EndGetEngagementInvitation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOpportunity


        /// <summary>
        /// Fetches the <c>Opportunity</c> record from Partner Central by a given <c>Identifier</c>.
        /// 
        /// 
        ///  
        /// <para>
        ///  Use the <c>ListOpportunities</c> action or the event notification (from Amazon EventBridge)
        /// to obtain this identifier. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpportunity service method.</param>
        /// 
        /// <returns>The response from the GetOpportunity service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.InternalServerException">
        /// This error occurs when the specified resource can’t be found or doesn't exist. Resource
        /// ID and type might be incorrect. 
        /// 
        ///  
        /// <para>
        /// Suggested action: This is usually a transient error. Retry after the provided retry
        /// delay or a short interval. If the problem persists, contact AWS support. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ResourceNotFoundException">
        /// This error occurs when the specified resource can't be found. The resource might not
        /// exist, or isn't visible with the current credentials. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Verify that the resource ID is correct and the resource is in the
        /// expected AWS region. Check IAM permissions for accessing the resource. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling. 
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">quotas</a>
        /// and retry after the provided delay. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service or business validation
        /// rules. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the error message, including the failed fields and reasons,
        /// to correct the request payload. 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/GetOpportunity">REST API Reference for GetOpportunity Operation</seealso>
        GetOpportunityResponse GetOpportunity(GetOpportunityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOpportunity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpportunity operation on AmazonPartnerCentralSellingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOpportunity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/GetOpportunity">REST API Reference for GetOpportunity Operation</seealso>
        IAsyncResult BeginGetOpportunity(GetOpportunityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOpportunity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOpportunity.</param>
        /// 
        /// <returns>Returns a  GetOpportunityResult from PartnerCentralSelling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/GetOpportunity">REST API Reference for GetOpportunity Operation</seealso>
        GetOpportunityResponse EndGetOpportunity(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEngagementInvitations


        /// <summary>
        /// Retrieves a list of engagement invitations sent to the partner. This allows partners
        /// to view all pending or past engagement invitations, helping them track opportunities
        /// shared by AWS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngagementInvitations service method.</param>
        /// 
        /// <returns>The response from the ListEngagementInvitations service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.InternalServerException">
        /// This error occurs when the specified resource can’t be found or doesn't exist. Resource
        /// ID and type might be incorrect. 
        /// 
        ///  
        /// <para>
        /// Suggested action: This is usually a transient error. Retry after the provided retry
        /// delay or a short interval. If the problem persists, contact AWS support. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ResourceNotFoundException">
        /// This error occurs when the specified resource can't be found. The resource might not
        /// exist, or isn't visible with the current credentials. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Verify that the resource ID is correct and the resource is in the
        /// expected AWS region. Check IAM permissions for accessing the resource. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling. 
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">quotas</a>
        /// and retry after the provided delay. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service or business validation
        /// rules. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the error message, including the failed fields and reasons,
        /// to correct the request payload. 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListEngagementInvitations">REST API Reference for ListEngagementInvitations Operation</seealso>
        ListEngagementInvitationsResponse ListEngagementInvitations(ListEngagementInvitationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEngagementInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEngagementInvitations operation on AmazonPartnerCentralSellingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEngagementInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListEngagementInvitations">REST API Reference for ListEngagementInvitations Operation</seealso>
        IAsyncResult BeginListEngagementInvitations(ListEngagementInvitationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEngagementInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEngagementInvitations.</param>
        /// 
        /// <returns>Returns a  ListEngagementInvitationsResult from PartnerCentralSelling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListEngagementInvitations">REST API Reference for ListEngagementInvitations Operation</seealso>
        ListEngagementInvitationsResponse EndListEngagementInvitations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOpportunities


        /// <summary>
        /// This request accepts a list of filters to use to retrieve a specific subset of opportunities,
        /// as well as sort options. This feature is available to partners from <a href="https://partnercentral.awspartner.com/">Partner
        /// Central</a> using the <c>ListOpportunities</c> API action. 
        /// 
        ///  
        /// <para>
        /// To synchronize your system with Amazon Web Services, only list the opportunities that
        /// were newly created or updated. We recommend you rely on events emitted by the service
        /// into your Amazon Web Services account’s Amazon EventBridge default event bus, you
        /// can also use the <c>ListOpportunities</c> action. 
        /// </para>
        ///  
        /// <para>
        /// We recommend the following approach:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Find the latest <c>LastModifiedDate</c> that you stored, and only use the values that
        /// came from Amazon Web Services. Don’t use values generated by your system. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you send a <c>ListOpportunities</c> request, submit the date in ISO 8601 format
        /// in the <c>AfterLastModifiedDate</c> filter. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services only returns opportunities created or updated on or after that
        /// date and time. Use <c>NextToken</c> to iterate over all pages. 
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpportunities service method.</param>
        /// 
        /// <returns>The response from the ListOpportunities service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.InternalServerException">
        /// This error occurs when the specified resource can’t be found or doesn't exist. Resource
        /// ID and type might be incorrect. 
        /// 
        ///  
        /// <para>
        /// Suggested action: This is usually a transient error. Retry after the provided retry
        /// delay or a short interval. If the problem persists, contact AWS support. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ResourceNotFoundException">
        /// This error occurs when the specified resource can't be found. The resource might not
        /// exist, or isn't visible with the current credentials. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Verify that the resource ID is correct and the resource is in the
        /// expected AWS region. Check IAM permissions for accessing the resource. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling. 
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">quotas</a>
        /// and retry after the provided delay. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service or business validation
        /// rules. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the error message, including the failed fields and reasons,
        /// to correct the request payload. 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListOpportunities">REST API Reference for ListOpportunities Operation</seealso>
        ListOpportunitiesResponse ListOpportunities(ListOpportunitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOpportunities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpportunities operation on AmazonPartnerCentralSellingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOpportunities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListOpportunities">REST API Reference for ListOpportunities Operation</seealso>
        IAsyncResult BeginListOpportunities(ListOpportunitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOpportunities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOpportunities.</param>
        /// 
        /// <returns>Returns a  ListOpportunitiesResult from PartnerCentralSelling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListOpportunities">REST API Reference for ListOpportunities Operation</seealso>
        ListOpportunitiesResponse EndListOpportunities(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSolutions


        /// <summary>
        /// Retrieves a list of Partner Solutions that the partner registered on Partner Central.
        /// This API is used to generate a list of solutions that an end user selects from for
        /// association with an opportunity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolutions service method.</param>
        /// 
        /// <returns>The response from the ListSolutions service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.InternalServerException">
        /// This error occurs when the specified resource can’t be found or doesn't exist. Resource
        /// ID and type might be incorrect. 
        /// 
        ///  
        /// <para>
        /// Suggested action: This is usually a transient error. Retry after the provided retry
        /// delay or a short interval. If the problem persists, contact AWS support. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ResourceNotFoundException">
        /// This error occurs when the specified resource can't be found. The resource might not
        /// exist, or isn't visible with the current credentials. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Verify that the resource ID is correct and the resource is in the
        /// expected AWS region. Check IAM permissions for accessing the resource. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service or business validation
        /// rules. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the error message, including the failed fields and reasons,
        /// to correct the request payload. 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListSolutions">REST API Reference for ListSolutions Operation</seealso>
        ListSolutionsResponse ListSolutions(ListSolutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSolutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSolutions operation on AmazonPartnerCentralSellingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSolutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListSolutions">REST API Reference for ListSolutions Operation</seealso>
        IAsyncResult BeginListSolutions(ListSolutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSolutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSolutions.</param>
        /// 
        /// <returns>Returns a  ListSolutionsResult from PartnerCentralSelling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListSolutions">REST API Reference for ListSolutions Operation</seealso>
        ListSolutionsResponse EndListSolutions(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectEngagementInvitation


        /// <summary>
        /// Use this action to reject an <c>EngagementInvitation</c> that has been shared by AWS.
        /// Rejecting the engagement invitation indicates that the partner does not wish to pursue
        /// the opportunity, and all related data will be inaccessible after the rejection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectEngagementInvitation service method.</param>
        /// 
        /// <returns>The response from the RejectEngagementInvitation service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.InternalServerException">
        /// This error occurs when the specified resource can’t be found or doesn't exist. Resource
        /// ID and type might be incorrect. 
        /// 
        ///  
        /// <para>
        /// Suggested action: This is usually a transient error. Retry after the provided retry
        /// delay or a short interval. If the problem persists, contact AWS support. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ResourceNotFoundException">
        /// This error occurs when the specified resource can't be found. The resource might not
        /// exist, or isn't visible with the current credentials. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Verify that the resource ID is correct and the resource is in the
        /// expected AWS region. Check IAM permissions for accessing the resource. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling. 
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">quotas</a>
        /// and retry after the provided delay. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service or business validation
        /// rules. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the error message, including the failed fields and reasons,
        /// to correct the request payload. 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/RejectEngagementInvitation">REST API Reference for RejectEngagementInvitation Operation</seealso>
        RejectEngagementInvitationResponse RejectEngagementInvitation(RejectEngagementInvitationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectEngagementInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectEngagementInvitation operation on AmazonPartnerCentralSellingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectEngagementInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/RejectEngagementInvitation">REST API Reference for RejectEngagementInvitation Operation</seealso>
        IAsyncResult BeginRejectEngagementInvitation(RejectEngagementInvitationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectEngagementInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectEngagementInvitation.</param>
        /// 
        /// <returns>Returns a  RejectEngagementInvitationResult from PartnerCentralSelling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/RejectEngagementInvitation">REST API Reference for RejectEngagementInvitation Operation</seealso>
        RejectEngagementInvitationResponse EndRejectEngagementInvitation(IAsyncResult asyncResult);

        #endregion
        
        #region  StartEngagementByAcceptingInvitationTask


        /// <summary>
        /// This action starts the engagement by accepting an <c>EngagementInvitation</c>. The
        /// task is asynchronous and involves several steps: accepting the invitation, creating
        /// an opportunity in the partner’s account from the AWS Opportunity, and copying over
        /// key details for tracking. Once completed, an <c>Opportunity Created</c> event is generated,
        /// indicating that the opportunity has been successfully created in the partner's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEngagementByAcceptingInvitationTask service method.</param>
        /// 
        /// <returns>The response from the StartEngagementByAcceptingInvitationTask service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ConflictException">
        /// This error occurs when the request can’t be processed due to a conflict with the target
        /// resource's current state, which could result from updating or deleting the resource.
        /// 
        /// 
        ///  
        /// <para>
        /// Suggested action: Fetch the latest state of the resource, verify the state, and retry
        /// the request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.InternalServerException">
        /// This error occurs when the specified resource can’t be found or doesn't exist. Resource
        /// ID and type might be incorrect. 
        /// 
        ///  
        /// <para>
        /// Suggested action: This is usually a transient error. Retry after the provided retry
        /// delay or a short interval. If the problem persists, contact AWS support. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ResourceNotFoundException">
        /// This error occurs when the specified resource can't be found. The resource might not
        /// exist, or isn't visible with the current credentials. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Verify that the resource ID is correct and the resource is in the
        /// expected AWS region. Check IAM permissions for accessing the resource. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ServiceQuotaExceededException">
        /// This error occurs when the request would cause a service quota to be exceeded. Service
        /// quotas represent the maximum allowed use of a specific resource, and this error indicates
        /// that the request would surpass that limit. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">service
        /// quotas</a> for the specific resource, and reduce the usage or request a quota increase
        /// through support if necessary. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling. 
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">quotas</a>
        /// and retry after the provided delay. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service or business validation
        /// rules. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the error message, including the failed fields and reasons,
        /// to correct the request payload. 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/StartEngagementByAcceptingInvitationTask">REST API Reference for StartEngagementByAcceptingInvitationTask Operation</seealso>
        StartEngagementByAcceptingInvitationTaskResponse StartEngagementByAcceptingInvitationTask(StartEngagementByAcceptingInvitationTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartEngagementByAcceptingInvitationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartEngagementByAcceptingInvitationTask operation on AmazonPartnerCentralSellingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartEngagementByAcceptingInvitationTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/StartEngagementByAcceptingInvitationTask">REST API Reference for StartEngagementByAcceptingInvitationTask Operation</seealso>
        IAsyncResult BeginStartEngagementByAcceptingInvitationTask(StartEngagementByAcceptingInvitationTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartEngagementByAcceptingInvitationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartEngagementByAcceptingInvitationTask.</param>
        /// 
        /// <returns>Returns a  StartEngagementByAcceptingInvitationTaskResult from PartnerCentralSelling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/StartEngagementByAcceptingInvitationTask">REST API Reference for StartEngagementByAcceptingInvitationTask Operation</seealso>
        StartEngagementByAcceptingInvitationTaskResponse EndStartEngagementByAcceptingInvitationTask(IAsyncResult asyncResult);

        #endregion
        
        #region  StartEngagementFromOpportunityTask


        /// <summary>
        /// This action initiates the engagement process from an existing opportunity by accepting
        /// the engagement invitation and creating a corresponding opportunity in the partner’s
        /// system. Similar to <c>StartEngagementByAcceptingInvitationTask</c>, this action is
        /// asynchronous and performs multiple steps before completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEngagementFromOpportunityTask service method.</param>
        /// 
        /// <returns>The response from the StartEngagementFromOpportunityTask service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ConflictException">
        /// This error occurs when the request can’t be processed due to a conflict with the target
        /// resource's current state, which could result from updating or deleting the resource.
        /// 
        /// 
        ///  
        /// <para>
        /// Suggested action: Fetch the latest state of the resource, verify the state, and retry
        /// the request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.InternalServerException">
        /// This error occurs when the specified resource can’t be found or doesn't exist. Resource
        /// ID and type might be incorrect. 
        /// 
        ///  
        /// <para>
        /// Suggested action: This is usually a transient error. Retry after the provided retry
        /// delay or a short interval. If the problem persists, contact AWS support. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ResourceNotFoundException">
        /// This error occurs when the specified resource can't be found. The resource might not
        /// exist, or isn't visible with the current credentials. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Verify that the resource ID is correct and the resource is in the
        /// expected AWS region. Check IAM permissions for accessing the resource. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ServiceQuotaExceededException">
        /// This error occurs when the request would cause a service quota to be exceeded. Service
        /// quotas represent the maximum allowed use of a specific resource, and this error indicates
        /// that the request would surpass that limit. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">service
        /// quotas</a> for the specific resource, and reduce the usage or request a quota increase
        /// through support if necessary. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling. 
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">quotas</a>
        /// and retry after the provided delay. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service or business validation
        /// rules. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the error message, including the failed fields and reasons,
        /// to correct the request payload. 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/StartEngagementFromOpportunityTask">REST API Reference for StartEngagementFromOpportunityTask Operation</seealso>
        StartEngagementFromOpportunityTaskResponse StartEngagementFromOpportunityTask(StartEngagementFromOpportunityTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartEngagementFromOpportunityTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartEngagementFromOpportunityTask operation on AmazonPartnerCentralSellingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartEngagementFromOpportunityTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/StartEngagementFromOpportunityTask">REST API Reference for StartEngagementFromOpportunityTask Operation</seealso>
        IAsyncResult BeginStartEngagementFromOpportunityTask(StartEngagementFromOpportunityTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartEngagementFromOpportunityTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartEngagementFromOpportunityTask.</param>
        /// 
        /// <returns>Returns a  StartEngagementFromOpportunityTaskResult from PartnerCentralSelling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/StartEngagementFromOpportunityTask">REST API Reference for StartEngagementFromOpportunityTask Operation</seealso>
        StartEngagementFromOpportunityTaskResponse EndStartEngagementFromOpportunityTask(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOpportunity


        /// <summary>
        /// Updates the <c>Opportunity</c> record identified by a given <c>Identifier</c>. This
        /// operation allows you to modify the details of an existing opportunity to reflect the
        /// latest information and progress. Use this action to keep the opportunity record up-to-date
        /// and accurate. 
        /// 
        ///  
        /// <para>
        ///  When you perform updates, include the entire payload with each request. If any field
        /// is omitted, the API assumes that the field is set to <c>null</c>. The best practice
        /// is to always perform a <c>GetOpportunity</c> to retrieve the latest values, then send
        /// the complete payload with the updated values to be changed. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpportunity service method.</param>
        /// 
        /// <returns>The response from the UpdateOpportunity service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ConflictException">
        /// This error occurs when the request can’t be processed due to a conflict with the target
        /// resource's current state, which could result from updating or deleting the resource.
        /// 
        /// 
        ///  
        /// <para>
        /// Suggested action: Fetch the latest state of the resource, verify the state, and retry
        /// the request. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.InternalServerException">
        /// This error occurs when the specified resource can’t be found or doesn't exist. Resource
        /// ID and type might be incorrect. 
        /// 
        ///  
        /// <para>
        /// Suggested action: This is usually a transient error. Retry after the provided retry
        /// delay or a short interval. If the problem persists, contact AWS support. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ResourceNotFoundException">
        /// This error occurs when the specified resource can't be found. The resource might not
        /// exist, or isn't visible with the current credentials. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Verify that the resource ID is correct and the resource is in the
        /// expected AWS region. Check IAM permissions for accessing the resource. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling. 
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">quotas</a>
        /// and retry after the provided delay. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service or business validation
        /// rules. 
        /// 
        ///  
        /// <para>
        /// Suggested action: Review the error message, including the failed fields and reasons,
        /// to correct the request payload. 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/UpdateOpportunity">REST API Reference for UpdateOpportunity Operation</seealso>
        UpdateOpportunityResponse UpdateOpportunity(UpdateOpportunityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOpportunity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpportunity operation on AmazonPartnerCentralSellingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOpportunity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/UpdateOpportunity">REST API Reference for UpdateOpportunity Operation</seealso>
        IAsyncResult BeginUpdateOpportunity(UpdateOpportunityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOpportunity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOpportunity.</param>
        /// 
        /// <returns>Returns a  UpdateOpportunityResult from PartnerCentralSelling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/UpdateOpportunity">REST API Reference for UpdateOpportunity Operation</seealso>
        UpdateOpportunityResponse EndUpdateOpportunity(IAsyncResult asyncResult);

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