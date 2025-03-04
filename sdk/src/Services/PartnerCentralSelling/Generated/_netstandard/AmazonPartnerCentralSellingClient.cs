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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PartnerCentralSelling.Model;
using Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations;
using Amazon.PartnerCentralSelling.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.PartnerCentralSelling
{
    /// <summary>
    /// <para>Implementation for accessing PartnerCentralSelling</para>
    ///
    /// AWS Partner Central API for Selling 
    /// <para>
    ///  <b>AWS Partner Central API for Selling Reference Guide</b> 
    /// 
    ///  
    /// <para>
    /// This Amazon Web Services (AWS) Partner Central API reference is designed to help <a
    /// href="http://aws.amazon.com/partners/programs/">AWS Partners</a> integrate Customer
    /// Relationship Management (CRM) systems with AWS Partner Central. Partners can automate
    /// interactions with AWS Partner Central, which helps to ensure effective engagements
    /// in joint business activities.
    /// </para>
    ///  
    /// <para>
    /// The API provides standard AWS API functionality. Access it by either using API <a
    /// href="https://docs.aws.amazon.com/partner-central/latest/selling-api/API_Operations.html">Actions</a>
    /// or by using an AWS SDK that's tailored to your programming language or platform. For
    /// more information, see <a href="http://aws.amazon.com/getting-started">Getting Started
    /// with AWS</a> and <a href="http://aws.amazon.com/developer/tools/">Tools to Build on
    /// AWS</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Features offered by AWS Partner Central API</b> 
    /// </para>
    ///  <ol> <li> 
    /// <para>
    ///  <b>Opportunity management:</b> Manages coselling opportunities through API actions
    /// such as <c>CreateOpportunity</c>, <c>UpdateOpportunity</c>, <c>ListOpportunities</c>,
    /// <c>GetOpportunity</c>, and <c>AssignOpportunity</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AWS referral management:</b> Manages referrals shared by AWS using actions such
    /// as <c>ListEngagementInvitations</c>, <c>GetEngagementInvitation</c>, <c>StartEngagementByAcceptingInvitation</c>,
    /// and <c>RejectEngagementInvitation</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Entity association:</b> Associates related entities such as <i>AWS Products</i>,
    /// <i>Partner Solutions</i>, and <i>AWS Marketplace Private Offers</i> with opportunities
    /// using the actions <c>AssociateOpportunity</c>, and <c>DisassociateOpportunity</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>View AWS opportunity details:</b> Retrieves real-time summaries of AWS opportunities
    /// using the <c>GetAWSOpportunitySummary</c> action.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>List solutions:</b> Provides list APIs for listing partner offers using <c>ListSolutions</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Event subscription:</b> Subscribe to real-time opportunity updates through AWS
    /// EventBridge by using actions such as <i>Opportunity Created</i>, <i>Opportunity Updated</i>,
    /// <i>Engagement Invitation Accepted</i>, <i>Engagement Invitation Rejected</i>, and
    /// <i>Engagement Invitation Created</i>.
    /// </para>
    ///  </li> </ol>
    /// </para>
    /// </summary>
    public partial class AmazonPartnerCentralSellingClient : AmazonServiceClient, IAmazonPartnerCentralSelling
    {
        private static IServiceMetadata serviceMetadata = new AmazonPartnerCentralSellingMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonPartnerCentralSellingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonPartnerCentralSellingClient()
            : base(new AmazonPartnerCentralSellingConfig()) { }

        /// <summary>
        /// Constructs AmazonPartnerCentralSellingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralSellingClient(RegionEndpoint region)
            : base(new AmazonPartnerCentralSellingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPartnerCentralSellingClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonPartnerCentralSellingClient Configuration Object</param>
        public AmazonPartnerCentralSellingClient(AmazonPartnerCentralSellingConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonPartnerCentralSellingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPartnerCentralSellingClient(AWSCredentials credentials)
            : this(credentials, new AmazonPartnerCentralSellingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralSellingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralSellingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPartnerCentralSellingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralSellingClient with AWS Credentials and an
        /// AmazonPartnerCentralSellingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPartnerCentralSellingClient Configuration Object</param>
        public AmazonPartnerCentralSellingClient(AWSCredentials credentials, AmazonPartnerCentralSellingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralSellingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPartnerCentralSellingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPartnerCentralSellingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralSellingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralSellingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPartnerCentralSellingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralSellingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPartnerCentralSellingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPartnerCentralSellingClient Configuration Object</param>
        public AmazonPartnerCentralSellingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPartnerCentralSellingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralSellingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPartnerCentralSellingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPartnerCentralSellingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralSellingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPartnerCentralSellingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPartnerCentralSellingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPartnerCentralSellingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPartnerCentralSellingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPartnerCentralSellingClient Configuration Object</param>
        public AmazonPartnerCentralSellingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPartnerCentralSellingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IPartnerCentralSellingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPartnerCentralSellingPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PartnerCentralSellingPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPartnerCentralSellingEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPartnerCentralSellingAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AcceptEngagementInvitation

        internal virtual AcceptEngagementInvitationResponse AcceptEngagementInvitation(AcceptEngagementInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptEngagementInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptEngagementInvitationResponseUnmarshaller.Instance;

            return Invoke<AcceptEngagementInvitationResponse>(request, options);
        }



        /// <summary>
        /// Use the <c>AcceptEngagementInvitation</c> action to accept an engagement invitation
        /// shared by AWS. Accepting the invitation indicates your willingness to participate
        /// in the engagement, granting you access to all engagement-related data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptEngagementInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptEngagementInvitation service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/AcceptEngagementInvitation">REST API Reference for AcceptEngagementInvitation Operation</seealso>
        public virtual Task<AcceptEngagementInvitationResponse> AcceptEngagementInvitationAsync(AcceptEngagementInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptEngagementInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptEngagementInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptEngagementInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssignOpportunity

        internal virtual AssignOpportunityResponse AssignOpportunity(AssignOpportunityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssignOpportunityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignOpportunityResponseUnmarshaller.Instance;

            return Invoke<AssignOpportunityResponse>(request, options);
        }



        /// <summary>
        /// Enables you to reassign an existing <c>Opportunity</c> to another user within your
        /// Partner Central account. The specified user receives the opportunity, and it appears
        /// on their Partner Central dashboard, allowing them to take necessary actions or proceed
        /// with the opportunity.
        /// 
        ///  
        /// <para>
        /// This is useful for distributing opportunities to the appropriate team members or departments
        /// within your organization, ensuring that each opportunity is handled by the right person.
        /// By default, the opportunity owner is the one who creates it. Currently, there's no
        /// API to enumerate the list of available users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignOpportunity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssignOpportunity service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        public virtual Task<AssignOpportunityResponse> AssignOpportunityAsync(AssignOpportunityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssignOpportunityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignOpportunityResponseUnmarshaller.Instance;

            return InvokeAsync<AssignOpportunityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateOpportunity

        internal virtual AssociateOpportunityResponse AssociateOpportunity(AssociateOpportunityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateOpportunityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateOpportunityResponseUnmarshaller.Instance;

            return Invoke<AssociateOpportunityResponse>(request, options);
        }



        /// <summary>
        /// Enables you to create a formal association between an <c>Opportunity</c> and various
        /// related entities, enriching the context and details of the opportunity for better
        /// collaboration and decision making. You can associate an opportunity with the following
        /// entity types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Partner Solution: A software product or consulting practice created and delivered
        /// by Partners. Partner Solutions help customers address business challenges using Amazon
        /// Web Services services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Products: Amazon Web Services offers many products and services
        /// that provide scalable, reliable, and cost-effective infrastructure solutions. For
        /// the latest list of Amazon Web Services products, see <a href="https://github.com/aws-samples/partner-crm-integration-samples/blob/main/resources/aws_products.json">Amazon
        /// Web Services products</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Marketplace private offer: Allows Amazon Web Services Marketplace
        /// sellers to extend custom pricing and terms to individual Amazon Web Services customers.
        /// Sellers can negotiate custom prices, payment schedules, and end user license terms
        /// through private offers, enabling Amazon Web Services customers to acquire software
        /// solutions tailored to their specific needs. For more information, see <a href="https://docs.aws.amazon.com/marketplace/latest/buyerguide/buyer-private-offers.html">Private
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
        /// AWS Products: For the latest list of Amazon Web Services products, see <a href="https://github.com/aws-samples/partner-crm-integration-samples/blob/main/resources/aws_products.json">Amazon
        /// Web Services products</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services Marketplace private offer: Use the <a href="https://docs.aws.amazon.com/marketplace/latest/APIReference/catalog-apis.html">Using
        /// the Amazon Web Services Marketplace Catalog API</a> to list entities. Specifically,
        /// use the <c>ListEntities</c> operation to retrieve a list of private offers. The request
        /// returns the details of available private offers. For more information, see <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/API_ListEntities.html">ListEntities</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateOpportunity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateOpportunity service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        public virtual Task<AssociateOpportunityResponse> AssociateOpportunityAsync(AssociateOpportunityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateOpportunityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateOpportunityResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateOpportunityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEngagement

        internal virtual CreateEngagementResponse CreateEngagement(CreateEngagementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEngagementResponseUnmarshaller.Instance;

            return Invoke<CreateEngagementResponse>(request, options);
        }



        /// <summary>
        /// The <c>CreateEngagement</c> action allows you to create an <c>Engagement</c>, which
        /// serves as a collaborative space between different parties such as AWS Partners and
        /// AWS Sellers. This action automatically adds the caller's AWS account as an active
        /// member of the newly created <c>Engagement</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEngagement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEngagement service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// <para>
        /// Suggested action: Fetch the latest state of the resource, verify the state, and retry
        /// the request.
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
        /// Suggested action: Review the <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
        /// for the resource, and either reduce usage or request a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling.
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/CreateEngagement">REST API Reference for CreateEngagement Operation</seealso>
        public virtual Task<CreateEngagementResponse> CreateEngagementAsync(CreateEngagementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEngagementResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEngagementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEngagementInvitation

        internal virtual CreateEngagementInvitationResponse CreateEngagementInvitation(CreateEngagementInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEngagementInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEngagementInvitationResponseUnmarshaller.Instance;

            return Invoke<CreateEngagementInvitationResponse>(request, options);
        }



        /// <summary>
        /// This action creates an invitation from a sender to a single receiver to join an engagement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEngagementInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEngagementInvitation service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// <para>
        /// Suggested action: Fetch the latest state of the resource, verify the state, and retry
        /// the request.
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
        /// Suggested action: Review the <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
        /// for the resource, and either reduce usage or request a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling.
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/CreateEngagementInvitation">REST API Reference for CreateEngagementInvitation Operation</seealso>
        public virtual Task<CreateEngagementInvitationResponse> CreateEngagementInvitationAsync(CreateEngagementInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEngagementInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEngagementInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEngagementInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOpportunity

        internal virtual CreateOpportunityResponse CreateOpportunity(CreateOpportunityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOpportunityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOpportunityResponseUnmarshaller.Instance;

            return Invoke<CreateOpportunityResponse>(request, options);
        }



        /// <summary>
        /// Creates an <c>Opportunity</c> record in Partner Central. Use this operation to create
        /// a potential business opportunity for submission to Amazon Web Services. Creating an
        /// opportunity sets <c>Lifecycle.ReviewStatus</c> to <c>Pending Submission</c>.
        /// 
        ///  
        /// <para>
        /// To submit an opportunity, follow these steps:
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
        /// To start the engagement with AWS, use <c>StartEngagementFromOpportunity</c>.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// After submission, you can't edit the opportunity until the review is complete. But
        /// opportunities in the <c>Pending Submission</c> state must have complete details. You
        /// can update the opportunity while it's in the <c>Pending Submission</c> state.
        /// </para>
        ///  
        /// <para>
        /// There's a set of mandatory fields to create opportunities, but consider providing
        /// optional fields to enrich the opportunity record.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpportunity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOpportunity service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        public virtual Task<CreateOpportunityResponse> CreateOpportunityAsync(CreateOpportunityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOpportunityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOpportunityResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOpportunityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResourceSnapshot

        internal virtual CreateResourceSnapshotResponse CreateResourceSnapshot(CreateResourceSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateResourceSnapshotResponse>(request, options);
        }



        /// <summary>
        /// This action allows you to create an immutable snapshot of a specific resource, such
        /// as an opportunity, within the context of an engagement. The snapshot captures a subset
        /// of the resource's data based on the schema defined by the provided template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResourceSnapshot service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// <para>
        /// Suggested action: Fetch the latest state of the resource, verify the state, and retry
        /// the request.
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
        /// Suggested action: Review the <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
        /// for the resource, and either reduce usage or request a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling.
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/CreateResourceSnapshot">REST API Reference for CreateResourceSnapshot Operation</seealso>
        public virtual Task<CreateResourceSnapshotResponse> CreateResourceSnapshotAsync(CreateResourceSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResourceSnapshotJob

        internal virtual CreateResourceSnapshotJobResponse CreateResourceSnapshotJob(CreateResourceSnapshotJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceSnapshotJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceSnapshotJobResponseUnmarshaller.Instance;

            return Invoke<CreateResourceSnapshotJobResponse>(request, options);
        }



        /// <summary>
        /// Use this action to create a job to generate a snapshot of the specified resource within
        /// an engagement. It initiates an asynchronous process to create a resource snapshot.
        /// The job creates a new snapshot only if the resource state has changed, adhering to
        /// the same access control and immutability rules as direct snapshot creation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceSnapshotJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResourceSnapshotJob service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// <para>
        /// Suggested action: Fetch the latest state of the resource, verify the state, and retry
        /// the request.
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
        /// Suggested action: Review the <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
        /// for the resource, and either reduce usage or request a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling.
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/CreateResourceSnapshotJob">REST API Reference for CreateResourceSnapshotJob Operation</seealso>
        public virtual Task<CreateResourceSnapshotJobResponse> CreateResourceSnapshotJobAsync(CreateResourceSnapshotJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResourceSnapshotJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceSnapshotJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceSnapshotJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourceSnapshotJob

        internal virtual DeleteResourceSnapshotJobResponse DeleteResourceSnapshotJob(DeleteResourceSnapshotJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceSnapshotJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceSnapshotJobResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceSnapshotJobResponse>(request, options);
        }



        /// <summary>
        /// Use this action to deletes a previously created resource snapshot job. The job must
        /// be in a stopped state before it can be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceSnapshotJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourceSnapshotJob service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// <para>
        /// Suggested action: Fetch the latest state of the resource, verify the state, and retry
        /// the request.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/DeleteResourceSnapshotJob">REST API Reference for DeleteResourceSnapshotJob Operation</seealso>
        public virtual Task<DeleteResourceSnapshotJobResponse> DeleteResourceSnapshotJobAsync(DeleteResourceSnapshotJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourceSnapshotJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceSnapshotJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourceSnapshotJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateOpportunity

        internal virtual DisassociateOpportunityResponse DisassociateOpportunity(DisassociateOpportunityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateOpportunityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateOpportunityResponseUnmarshaller.Instance;

            return Invoke<DisassociateOpportunityResponse>(request, options);
        }



        /// <summary>
        /// Allows you to remove an existing association between an <c>Opportunity</c> and related
        /// entities, such as a Partner Solution, Amazon Web Services product, or an Amazon Web
        /// Services Marketplace offer. This operation is the counterpart to <c>AssociateOpportunity</c>,
        /// and it provides flexibility to manage associations as business needs change.
        /// 
        ///  
        /// <para>
        /// Use this operation to update the associations of an <c>Opportunity</c> due to changes
        /// in the related entities, or if an association was made in error. Ensuring accurate
        /// associations helps maintain clarity and accuracy to track and manage business opportunities.
        /// When you replace an entity, first attach the new entity and then disassociate the
        /// one to be removed, especially if it's the last remaining entity that's required.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOpportunity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateOpportunity service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        public virtual Task<DisassociateOpportunityResponse> DisassociateOpportunityAsync(DisassociateOpportunityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateOpportunityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateOpportunityResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateOpportunityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAwsOpportunitySummary

        internal virtual GetAwsOpportunitySummaryResponse GetAwsOpportunitySummary(GetAwsOpportunitySummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAwsOpportunitySummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAwsOpportunitySummaryResponseUnmarshaller.Instance;

            return Invoke<GetAwsOpportunitySummaryResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a summary of an AWS Opportunity. This summary includes high-level details
        /// about the opportunity sourced from AWS, such as lifecycle information, customer details,
        /// and involvement type. It is useful for tracking updates on the AWS opportunity corresponding
        /// to an opportunity in the partner's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAwsOpportunitySummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAwsOpportunitySummary service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        public virtual Task<GetAwsOpportunitySummaryResponse> GetAwsOpportunitySummaryAsync(GetAwsOpportunitySummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAwsOpportunitySummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAwsOpportunitySummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetAwsOpportunitySummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEngagement

        internal virtual GetEngagementResponse GetEngagement(GetEngagementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEngagementResponseUnmarshaller.Instance;

            return Invoke<GetEngagementResponse>(request, options);
        }



        /// <summary>
        /// Use this action to retrieve the engagement record for a given <c>EngagementIdentifier</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEngagement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEngagement service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/GetEngagement">REST API Reference for GetEngagement Operation</seealso>
        public virtual Task<GetEngagementResponse> GetEngagementAsync(GetEngagementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEngagementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEngagementResponseUnmarshaller.Instance;

            return InvokeAsync<GetEngagementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEngagementInvitation

        internal virtual GetEngagementInvitationResponse GetEngagementInvitation(GetEngagementInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEngagementInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEngagementInvitationResponseUnmarshaller.Instance;

            return Invoke<GetEngagementInvitationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of an engagement invitation shared by AWS with a partner. The
        /// information includes aspects such as customer, project details, and lifecycle information.
        /// To connect an engagement invitation with an opportunity, match the invitation’s <c>Payload.Project.Title</c>
        /// with opportunity <c>Project.Title</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEngagementInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEngagementInvitation service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        public virtual Task<GetEngagementInvitationResponse> GetEngagementInvitationAsync(GetEngagementInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEngagementInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEngagementInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<GetEngagementInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetOpportunity

        internal virtual GetOpportunityResponse GetOpportunity(GetOpportunityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpportunityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpportunityResponseUnmarshaller.Instance;

            return Invoke<GetOpportunityResponse>(request, options);
        }



        /// <summary>
        /// Fetches the <c>Opportunity</c> record from Partner Central by a given <c>Identifier</c>.
        /// 
        ///  
        /// <para>
        /// Use the <c>ListOpportunities</c> action or the event notification (from Amazon EventBridge)
        /// to obtain this identifier.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpportunity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOpportunity service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        public virtual Task<GetOpportunityResponse> GetOpportunityAsync(GetOpportunityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOpportunityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOpportunityResponseUnmarshaller.Instance;

            return InvokeAsync<GetOpportunityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourceSnapshot

        internal virtual GetResourceSnapshotResponse GetResourceSnapshot(GetResourceSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetResourceSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Use this action to retrieve a specific snapshot record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceSnapshot service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/GetResourceSnapshot">REST API Reference for GetResourceSnapshot Operation</seealso>
        public virtual Task<GetResourceSnapshotResponse> GetResourceSnapshotAsync(GetResourceSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourceSnapshotJob

        internal virtual GetResourceSnapshotJobResponse GetResourceSnapshotJob(GetResourceSnapshotJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceSnapshotJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSnapshotJobResponseUnmarshaller.Instance;

            return Invoke<GetResourceSnapshotJobResponse>(request, options);
        }



        /// <summary>
        /// Use this action to retrieves information about a specific resource snapshot job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSnapshotJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourceSnapshotJob service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/GetResourceSnapshotJob">REST API Reference for GetResourceSnapshotJob Operation</seealso>
        public virtual Task<GetResourceSnapshotJobResponse> GetResourceSnapshotJobAsync(GetResourceSnapshotJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceSnapshotJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceSnapshotJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceSnapshotJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSellingSystemSettings

        internal virtual GetSellingSystemSettingsResponse GetSellingSystemSettings(GetSellingSystemSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSellingSystemSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSellingSystemSettingsResponseUnmarshaller.Instance;

            return Invoke<GetSellingSystemSettingsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the currently set system settings, which include the IAM Role used for resource
        /// snapshot jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSellingSystemSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSellingSystemSettings service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/GetSellingSystemSettings">REST API Reference for GetSellingSystemSettings Operation</seealso>
        public virtual Task<GetSellingSystemSettingsResponse> GetSellingSystemSettingsAsync(GetSellingSystemSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSellingSystemSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSellingSystemSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSellingSystemSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEngagementByAcceptingInvitationTasks

        internal virtual ListEngagementByAcceptingInvitationTasksResponse ListEngagementByAcceptingInvitationTasks(ListEngagementByAcceptingInvitationTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngagementByAcceptingInvitationTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngagementByAcceptingInvitationTasksResponseUnmarshaller.Instance;

            return Invoke<ListEngagementByAcceptingInvitationTasksResponse>(request, options);
        }



        /// <summary>
        /// Lists all in-progress, completed, or failed StartEngagementByAcceptingInvitationTask
        /// tasks that were initiated by the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngagementByAcceptingInvitationTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEngagementByAcceptingInvitationTasks service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListEngagementByAcceptingInvitationTasks">REST API Reference for ListEngagementByAcceptingInvitationTasks Operation</seealso>
        public virtual Task<ListEngagementByAcceptingInvitationTasksResponse> ListEngagementByAcceptingInvitationTasksAsync(ListEngagementByAcceptingInvitationTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngagementByAcceptingInvitationTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngagementByAcceptingInvitationTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListEngagementByAcceptingInvitationTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEngagementFromOpportunityTasks

        internal virtual ListEngagementFromOpportunityTasksResponse ListEngagementFromOpportunityTasks(ListEngagementFromOpportunityTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngagementFromOpportunityTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngagementFromOpportunityTasksResponseUnmarshaller.Instance;

            return Invoke<ListEngagementFromOpportunityTasksResponse>(request, options);
        }



        /// <summary>
        /// Lists all in-progress, completed, or failed <c>EngagementFromOpportunity</c> tasks
        /// that were initiated by the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngagementFromOpportunityTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEngagementFromOpportunityTasks service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListEngagementFromOpportunityTasks">REST API Reference for ListEngagementFromOpportunityTasks Operation</seealso>
        public virtual Task<ListEngagementFromOpportunityTasksResponse> ListEngagementFromOpportunityTasksAsync(ListEngagementFromOpportunityTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngagementFromOpportunityTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngagementFromOpportunityTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListEngagementFromOpportunityTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEngagementInvitations

        internal virtual ListEngagementInvitationsResponse ListEngagementInvitations(ListEngagementInvitationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngagementInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngagementInvitationsResponseUnmarshaller.Instance;

            return Invoke<ListEngagementInvitationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of engagement invitations sent to the partner. This allows partners
        /// to view all pending or past engagement invitations, helping them track opportunities
        /// shared by AWS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngagementInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEngagementInvitations service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        public virtual Task<ListEngagementInvitationsResponse> ListEngagementInvitationsAsync(ListEngagementInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngagementInvitationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngagementInvitationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEngagementInvitationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEngagementMembers

        internal virtual ListEngagementMembersResponse ListEngagementMembers(ListEngagementMembersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngagementMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngagementMembersResponseUnmarshaller.Instance;

            return Invoke<ListEngagementMembersResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details of member partners in an Engagement. This operation can only
        /// be invoked by members of the Engagement. The <c>ListEngagementMembers</c> operation
        /// allows you to fetch information about the members of a specific Engagement. This action
        /// is restricted to members of the Engagement being queried.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngagementMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEngagementMembers service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListEngagementMembers">REST API Reference for ListEngagementMembers Operation</seealso>
        public virtual Task<ListEngagementMembersResponse> ListEngagementMembersAsync(ListEngagementMembersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngagementMembersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngagementMembersResponseUnmarshaller.Instance;

            return InvokeAsync<ListEngagementMembersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEngagementResourceAssociations

        internal virtual ListEngagementResourceAssociationsResponse ListEngagementResourceAssociations(ListEngagementResourceAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngagementResourceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngagementResourceAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListEngagementResourceAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the associations between resources and engagements where the caller is a member
        /// and has at least one snapshot in the engagement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngagementResourceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEngagementResourceAssociations service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListEngagementResourceAssociations">REST API Reference for ListEngagementResourceAssociations Operation</seealso>
        public virtual Task<ListEngagementResourceAssociationsResponse> ListEngagementResourceAssociationsAsync(ListEngagementResourceAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngagementResourceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngagementResourceAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEngagementResourceAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEngagements

        internal virtual ListEngagementsResponse ListEngagements(ListEngagementsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngagementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngagementsResponseUnmarshaller.Instance;

            return Invoke<ListEngagementsResponse>(request, options);
        }



        /// <summary>
        /// This action allows users to retrieve a list of Engagement records from Partner Central.
        /// This action can be used to manage and track various engagements across different stages
        /// of the partner selling process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngagements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEngagements service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListEngagements">REST API Reference for ListEngagements Operation</seealso>
        public virtual Task<ListEngagementsResponse> ListEngagementsAsync(ListEngagementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEngagementsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEngagementsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEngagementsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOpportunities

        internal virtual ListOpportunitiesResponse ListOpportunities(ListOpportunitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpportunitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpportunitiesResponseUnmarshaller.Instance;

            return Invoke<ListOpportunitiesResponse>(request, options);
        }



        /// <summary>
        /// This request accepts a list of filters that retrieve opportunity subsets as well as
        /// sort options. This feature is available to partners from <a href="https://partnercentral.awspartner.com/">Partner
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOpportunities service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        public virtual Task<ListOpportunitiesResponse> ListOpportunitiesAsync(ListOpportunitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpportunitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpportunitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListOpportunitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceSnapshotJobs

        internal virtual ListResourceSnapshotJobsResponse ListResourceSnapshotJobs(ListResourceSnapshotJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceSnapshotJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSnapshotJobsResponseUnmarshaller.Instance;

            return Invoke<ListResourceSnapshotJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists resource snapshot jobs owned by the customer. This operation supports various
        /// filtering scenarios, including listing all jobs owned by the caller, jobs for a specific
        /// engagement, jobs with a specific status, or any combination of these filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSnapshotJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceSnapshotJobs service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListResourceSnapshotJobs">REST API Reference for ListResourceSnapshotJobs Operation</seealso>
        public virtual Task<ListResourceSnapshotJobsResponse> ListResourceSnapshotJobsAsync(ListResourceSnapshotJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceSnapshotJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSnapshotJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceSnapshotJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceSnapshots

        internal virtual ListResourceSnapshotsResponse ListResourceSnapshots(ListResourceSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListResourceSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of resource view snapshots based on specified criteria. This operation
        /// supports various use cases, including: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Fetching all snapshots associated with an engagement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Retrieving snapshots of a specific resource type within an engagement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Obtaining snapshots for a particular resource using a specified template.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Accessing the latest snapshot of a resource within an engagement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Filtering snapshots by resource owner.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceSnapshots service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListResourceSnapshots">REST API Reference for ListResourceSnapshots Operation</seealso>
        public virtual Task<ListResourceSnapshotsResponse> ListResourceSnapshotsAsync(ListResourceSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSolutions

        internal virtual ListSolutionsResponse ListSolutions(ListSolutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolutionsResponseUnmarshaller.Instance;

            return Invoke<ListSolutionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of Partner Solutions that the partner registered on Partner Central.
        /// This API is used to generate a list of solutions that an end user selects from for
        /// association with an opportunity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSolutions service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        public virtual Task<ListSolutionsResponse> ListSolutionsAsync(ListSolutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSolutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSellingSystemSettings

        internal virtual PutSellingSystemSettingsResponse PutSellingSystemSettings(PutSellingSystemSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSellingSystemSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSellingSystemSettingsResponseUnmarshaller.Instance;

            return Invoke<PutSellingSystemSettingsResponse>(request, options);
        }



        /// <summary>
        /// Updates the currently set system settings, which include the IAM Role used for resource
        /// snapshot jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSellingSystemSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSellingSystemSettings service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/PutSellingSystemSettings">REST API Reference for PutSellingSystemSettings Operation</seealso>
        public virtual Task<PutSellingSystemSettingsResponse> PutSellingSystemSettingsAsync(PutSellingSystemSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSellingSystemSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSellingSystemSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<PutSellingSystemSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectEngagementInvitation

        internal virtual RejectEngagementInvitationResponse RejectEngagementInvitation(RejectEngagementInvitationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectEngagementInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectEngagementInvitationResponseUnmarshaller.Instance;

            return Invoke<RejectEngagementInvitationResponse>(request, options);
        }



        /// <summary>
        /// This action rejects an <c>EngagementInvitation</c> that AWS shared. Rejecting an invitation
        /// indicates that the partner doesn't want to pursue the opportunity, and all related
        /// data will become inaccessible thereafter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectEngagementInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectEngagementInvitation service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        public virtual Task<RejectEngagementInvitationResponse> RejectEngagementInvitationAsync(RejectEngagementInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectEngagementInvitationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectEngagementInvitationResponseUnmarshaller.Instance;

            return InvokeAsync<RejectEngagementInvitationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartEngagementByAcceptingInvitationTask

        internal virtual StartEngagementByAcceptingInvitationTaskResponse StartEngagementByAcceptingInvitationTask(StartEngagementByAcceptingInvitationTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEngagementByAcceptingInvitationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEngagementByAcceptingInvitationTaskResponseUnmarshaller.Instance;

            return Invoke<StartEngagementByAcceptingInvitationTaskResponse>(request, options);
        }



        /// <summary>
        /// This action starts the engagement by accepting an <c>EngagementInvitation</c>. The
        /// task is asynchronous and involves the following steps: accepting the invitation, creating
        /// an opportunity in the partner’s account from the AWS opportunity, and copying details
        /// for tracking. When completed, an <c>Opportunity Created</c> event is generated, indicating
        /// that the opportunity has been successfully created in the partner's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEngagementByAcceptingInvitationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartEngagementByAcceptingInvitationTask service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// Suggested action: Review the <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
        /// for the resource, and either reduce usage or request a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling.
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        public virtual Task<StartEngagementByAcceptingInvitationTaskResponse> StartEngagementByAcceptingInvitationTaskAsync(StartEngagementByAcceptingInvitationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEngagementByAcceptingInvitationTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEngagementByAcceptingInvitationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartEngagementByAcceptingInvitationTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartEngagementFromOpportunityTask

        internal virtual StartEngagementFromOpportunityTaskResponse StartEngagementFromOpportunityTask(StartEngagementFromOpportunityTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEngagementFromOpportunityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEngagementFromOpportunityTaskResponseUnmarshaller.Instance;

            return Invoke<StartEngagementFromOpportunityTaskResponse>(request, options);
        }



        /// <summary>
        /// This action initiates the engagement process from an existing opportunity by accepting
        /// the engagement invitation and creating a corresponding opportunity in the partner’s
        /// system. Similar to <c>StartEngagementByAcceptingInvitationTask</c>, this action is
        /// asynchronous and performs multiple steps before completion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEngagementFromOpportunityTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartEngagementFromOpportunityTask service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// Suggested action: Review the <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
        /// for the resource, and either reduce usage or request a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.ThrottlingException">
        /// This error occurs when there are too many requests sent. Review the provided quotas
        /// and adapt your usage to avoid throttling.
        /// 
        ///  
        /// <para>
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        public virtual Task<StartEngagementFromOpportunityTaskResponse> StartEngagementFromOpportunityTaskAsync(StartEngagementFromOpportunityTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEngagementFromOpportunityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEngagementFromOpportunityTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartEngagementFromOpportunityTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartResourceSnapshotJob

        internal virtual StartResourceSnapshotJobResponse StartResourceSnapshotJob(StartResourceSnapshotJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartResourceSnapshotJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartResourceSnapshotJobResponseUnmarshaller.Instance;

            return Invoke<StartResourceSnapshotJobResponse>(request, options);
        }



        /// <summary>
        /// Starts a resource snapshot job that has been previously created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartResourceSnapshotJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartResourceSnapshotJob service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/StartResourceSnapshotJob">REST API Reference for StartResourceSnapshotJob Operation</seealso>
        public virtual Task<StartResourceSnapshotJobResponse> StartResourceSnapshotJobAsync(StartResourceSnapshotJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartResourceSnapshotJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartResourceSnapshotJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartResourceSnapshotJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopResourceSnapshotJob

        internal virtual StopResourceSnapshotJobResponse StopResourceSnapshotJob(StopResourceSnapshotJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopResourceSnapshotJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopResourceSnapshotJobResponseUnmarshaller.Instance;

            return Invoke<StopResourceSnapshotJobResponse>(request, options);
        }



        /// <summary>
        /// Stops a resource snapshot job. The job must be started prior to being stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopResourceSnapshotJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopResourceSnapshotJob service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
        /// 
        ///  
        /// <para>
        /// You don’t have access to this action or resource. Review IAM policies or contact your
        /// AWS administrator for assistance.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/StopResourceSnapshotJob">REST API Reference for StopResourceSnapshotJob Operation</seealso>
        public virtual Task<StopResourceSnapshotJobResponse> StopResourceSnapshotJobAsync(StopResourceSnapshotJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopResourceSnapshotJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopResourceSnapshotJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopResourceSnapshotJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SubmitOpportunity

        internal virtual SubmitOpportunityResponse SubmitOpportunity(SubmitOpportunityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitOpportunityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitOpportunityResponseUnmarshaller.Instance;

            return Invoke<SubmitOpportunityResponse>(request, options);
        }



        /// <summary>
        /// Use this action to submit an Opportunity that was previously created by partner for
        /// AWS review. After you perform this action, the Opportunity becomes non-editable until
        /// it is reviewed by AWS and has <c> LifeCycle.ReviewStatus </c> as either <c>Approved</c>
        /// or <c>Action Required</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitOpportunity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitOpportunity service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/SubmitOpportunity">REST API Reference for SubmitOpportunity Operation</seealso>
        public virtual Task<SubmitOpportunityResponse> SubmitOpportunityAsync(SubmitOpportunityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitOpportunityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitOpportunityResponseUnmarshaller.Instance;

            return InvokeAsync<SubmitOpportunityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes a tag or tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-selling-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateOpportunity

        internal virtual UpdateOpportunityResponse UpdateOpportunity(UpdateOpportunityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOpportunityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOpportunityResponseUnmarshaller.Instance;

            return Invoke<UpdateOpportunityResponse>(request, options);
        }



        /// <summary>
        /// Updates the <c>Opportunity</c> record identified by a given <c>Identifier</c>. This
        /// operation allows you to modify the details of an existing opportunity to reflect the
        /// latest information and progress. Use this action to keep the opportunity record up-to-date
        /// and accurate.
        /// 
        ///  
        /// <para>
        /// When you perform updates, include the entire payload with each request. If any field
        /// is omitted, the API assumes that the field is set to <c>null</c>. The best practice
        /// is to always perform a <c>GetOpportunity</c> to retrieve the latest values, then send
        /// the complete payload with the updated values to be changed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpportunity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOpportunity service method, as returned by PartnerCentralSelling.</returns>
        /// <exception cref="Amazon.PartnerCentralSelling.Model.AccessDeniedException">
        /// This error occurs when you don't have permission to perform the requested action.
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
        /// This error occurs when there are too many requests sent. Review the provided <a href="https://docs.aws.amazon.com/partner-central/latest/selling-api/quotas.html">Quotas</a>
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
        public virtual Task<UpdateOpportunityResponse> UpdateOpportunityAsync(UpdateOpportunityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateOpportunityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOpportunityResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOpportunityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}