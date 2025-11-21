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
 * Do not modify this file. This file is generated from the marketplace-reporting-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MarketplaceReporting.Model;
using Amazon.MarketplaceReporting.Model.Internal.MarshallTransformations;
using Amazon.MarketplaceReporting.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.MarketplaceReporting
{
    /// <summary>
    /// <para>Implementation for accessing MarketplaceReporting</para>
    ///
    /// The Amazon Web Services Marketplace <c>GetBuyerDashboard</c> API enables you to get
    /// a procurement insights dashboard programmatically. The API gets the agreement and
    /// cost analysis dashboards with data for all of the Amazon Web Services accounts in
    /// your Amazon Web Services Organization. 
    /// 
    ///  
    /// <para>
    /// To use the Amazon Web Services Marketplace Reporting API, you must complete the following
    /// prerequisites:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Enable all features for your organization. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">Enabling
    /// all features for an organization with Organizations</a>, in the <i>Organizations User
    /// Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Call the service as the Organizations management account or an account registered
    /// as a delegated administrator for the procurement insights service.
    /// </para>
    ///  
    /// <para>
    /// For more information about management accounts, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_tutorials_basic.html">Tutorial:
    /// Creating and configuring an organization</a> and <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs-manage_accounts_management.html">Managing
    /// the management account with Organizations</a>, both in the <i>Organizations User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about delegated administrators, see <a href="https://docs.aws.amazon.com/marketplace/latest/buyerguide/management-delegates.html">Using
    /// delegated administrators</a>, in the <i>Amazon Web Services Marketplace Buyer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create an IAM policy that enables the <c>aws-marketplace:GetBuyerDashboard</c> and
    /// <c>organizations:DescribeOrganization</c> permissions. In addition, the management
    /// account requires the <c>organizations:EnableAWSServiceAccess</c> and <c>iam:CreateServiceLinkedRole</c>
    /// permissions to create. For more information about creating the policy, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html">Policies
    /// and permissions in Identity and Access Management</a>, in the <i>IAM User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Access can be shared only by registering the desired linked account as a delegated
    /// administrator. That requires <c>organizations:RegisterDelegatedAdministrator</c> <c>organizations:ListDelegatedAdministrators</c>
    /// and <c>organizations:DeregisterDelegatedAdministrator</c> permissions.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// Use the Amazon Web Services Marketplace console to create the <c>AWSServiceRoleForProcurementInsightsPolicy</c>
    /// service-linked role. The role enables Amazon Web Services Marketplace procurement
    /// visibility integration. The management account requires an IAM policy with the <c>organizations:EnableAWSServiceAccess</c>
    /// and <c>iam:CreateServiceLinkedRole</c> permissions to create the service-linked role
    /// and enable the service access. For more information, see <a href="https://docs.aws.amazon.com/marketplace/latest/buyerguide/orgs-access-slr.html">Granting
    /// access to Organizations</a> and <a href="https://docs.aws.amazon.com/marketplace/latest/buyerguide/buyer-service-linked-role-procurement.html">Service-linked
    /// role to share procurement data</a> in the <i>Amazon Web Services Marketplace Buyer
    /// Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After creating the service-linked role, you must enable trusted access that grants
    /// Amazon Web Services Marketplace permission to access data from your Organizations.
    /// For more information, see <a href="https://docs.aws.amazon.com/marketplace/latest/buyerguide/orgs-access-slr.html">Granting
    /// access to Organizations</a> in the <i>Amazon Web Services Marketplace Buyer Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonMarketplaceReportingClient : AmazonServiceClient, IAmazonMarketplaceReporting
    {
        private static IServiceMetadata serviceMetadata = new AmazonMarketplaceReportingMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMarketplaceReportingClient with the credentials loaded from the application's
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
        public AmazonMarketplaceReportingClient()
            : base(new AmazonMarketplaceReportingConfig()) { }

        /// <summary>
        /// Constructs AmazonMarketplaceReportingClient with the credentials loaded from the application's
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
        public AmazonMarketplaceReportingClient(RegionEndpoint region)
            : base(new AmazonMarketplaceReportingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMarketplaceReportingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMarketplaceReportingClient Configuration Object</param>
        public AmazonMarketplaceReportingClient(AmazonMarketplaceReportingConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonMarketplaceReportingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMarketplaceReportingClient(AWSCredentials credentials)
            : this(credentials, new AmazonMarketplaceReportingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceReportingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceReportingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMarketplaceReportingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceReportingClient with AWS Credentials and an
        /// AmazonMarketplaceReportingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMarketplaceReportingClient Configuration Object</param>
        public AmazonMarketplaceReportingClient(AWSCredentials credentials, AmazonMarketplaceReportingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceReportingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMarketplaceReportingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceReportingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceReportingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceReportingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMarketplaceReportingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceReportingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMarketplaceReportingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMarketplaceReportingClient Configuration Object</param>
        public AmazonMarketplaceReportingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMarketplaceReportingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceReportingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMarketplaceReportingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceReportingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceReportingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMarketplaceReportingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMarketplaceReportingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMarketplaceReportingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMarketplaceReportingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMarketplaceReportingClient Configuration Object</param>
        public AmazonMarketplaceReportingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMarketplaceReportingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMarketplaceReportingEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMarketplaceReportingAuthSchemeHandler());
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


        #region  GetBuyerDashboard

        internal virtual GetBuyerDashboardResponse GetBuyerDashboard(GetBuyerDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBuyerDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBuyerDashboardResponseUnmarshaller.Instance;

            return Invoke<GetBuyerDashboardResponse>(request, options);
        }



        /// <summary>
        /// Generates an embedding URL for an Amazon QuickSight dashboard for an anonymous user.
        /// 
        ///  <note> 
        /// <para>
        /// This API is available only to Amazon Web Services Organization management accounts
        /// or delegated administrators registered for the procurement insights (<c>procurement-insights.marketplace.amazonaws.com</c>)
        /// feature.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following rules apply to a generated URL:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It contains a temporary bearer token, valid for 5 minutes after it is generated. Once
        /// redeemed within that period, it cannot be re-used again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It has a session lifetime of one hour. The 5-minute validity period runs separately
        /// from the session lifetime.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBuyerDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBuyerDashboard service method, as returned by MarketplaceReporting.</returns>
        /// <exception cref="Amazon.MarketplaceReporting.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceReporting.Model.BadRequestException">
        /// The request is malformed, or it contains an error such as an invalid parameter. Ensure
        /// the request has all required parameters.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceReporting.Model.InternalServerException">
        /// The operation failed due to a server error.
        /// </exception>
        /// <exception cref="Amazon.MarketplaceReporting.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/marketplace-reporting-2018-05-10/GetBuyerDashboard">REST API Reference for GetBuyerDashboard Operation</seealso>
        public virtual Task<GetBuyerDashboardResponse> GetBuyerDashboardAsync(GetBuyerDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBuyerDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBuyerDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<GetBuyerDashboardResponse>(request, options, cancellationToken);
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