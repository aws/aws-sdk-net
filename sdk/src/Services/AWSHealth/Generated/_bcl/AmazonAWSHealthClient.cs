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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AWSHealth.Model;
using Amazon.AWSHealth.Model.Internal.MarshallTransformations;
using Amazon.AWSHealth.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.AWSHealth
{
    /// <summary>
    /// <para>Implementation for accessing AWSHealth</para>
    ///
    /// Health 
    /// <para>
    /// The Health API provides access to the Health information that appears in the <a href="https://health.aws.amazon.com/health/home">Health
    /// Dashboard</a>. You can use the API operations to get information about events that
    /// might affect your Amazon Web Services services and resources.
    /// </para>
    ///  
    /// <para>
    /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan from <a href="http://aws.amazon.com/premiumsupport/">Amazon
    /// Web Services Support</a> to use the Health API. If you call the Health API from an
    /// Amazon Web Services account that doesn't have a Business, Enterprise On-Ramp, or Enterprise
    /// Support plan, you receive a <c>SubscriptionRequiredException</c> error.
    /// </para>
    ///  
    /// <para>
    /// For API access, you need an access key ID and a secret access key. Use temporary credentials
    /// instead of long-term access keys when possible. Temporary credentials include an access
    /// key ID, a secret access key, and a security token that indicates when the credentials
    /// expire. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-access-keys-best-practices.html">Best
    /// practices for managing Amazon Web Services access keys</a> in the <i>Amazon Web Services
    /// General Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// You can use the Health endpoint health.us-east-1.amazonaws.com (HTTPS) to call the
    /// Health API operations. Health supports a multi-Region application architecture and
    /// has two regional endpoints in an active-passive configuration. You can use the high
    /// availability endpoint example to determine which Amazon Web Services Region is active,
    /// so that you can get the latest information from the API. For more information, see
    /// <a href="https://docs.aws.amazon.com/health/latest/ug/health-api.html">Accessing the
    /// Health API</a> in the <i>Health User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For authentication of requests, Health uses the <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a>.
    /// </para>
    ///  
    /// <para>
    /// If your Amazon Web Services account is part of Organizations, you can use the Health
    /// organizational view feature. This feature provides a centralized view of Health events
    /// across all accounts in your organization. You can aggregate Health events in real
    /// time to identify accounts in your organization that are affected by an operational
    /// event or get notified of security vulnerabilities. Use the organizational view API
    /// operations to enable this feature and return event information. For more information,
    /// see <a href="https://docs.aws.amazon.com/health/latest/ug/aggregate-events.html">Aggregating
    /// Health events</a> in the <i>Health User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// When you use the Health API operations to return Health events, see the following
    /// recommendations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html#AWSHealth-Type-Event-eventScopeCode">eventScopeCode</a>
    /// parameter to specify whether to return Health events that are public or account-specific.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use pagination to view all events from the response. For example, if you call the
    /// <c>DescribeEventsForOrganization</c> operation to get all events in your organization,
    /// you might receive several page results. Specify the <c>nextToken</c> in the next request
    /// to return more results.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class AmazonAWSHealthClient : AmazonServiceClient, IAmazonAWSHealth
    {
        private static IServiceMetadata serviceMetadata = new AmazonAWSHealthMetadata();
        private IAWSHealthPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAWSHealthPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AWSHealthPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonAWSHealthClient with the credentials loaded from the application's
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
        public AmazonAWSHealthClient()
            : base(new AmazonAWSHealthConfig()) { }

        /// <summary>
        /// Constructs AmazonAWSHealthClient with the credentials loaded from the application's
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
        public AmazonAWSHealthClient(RegionEndpoint region)
            : base(new AmazonAWSHealthConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAWSHealthClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAWSHealthClient Configuration Object</param>
        public AmazonAWSHealthClient(AmazonAWSHealthConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonAWSHealthClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAWSHealthClient(AWSCredentials credentials)
            : this(credentials, new AmazonAWSHealthConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSHealthClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSHealthClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAWSHealthConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSHealthClient with AWS Credentials and an
        /// AmazonAWSHealthClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAWSHealthClient Configuration Object</param>
        public AmazonAWSHealthClient(AWSCredentials credentials, AmazonAWSHealthConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAWSHealthClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAWSHealthClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAWSHealthConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSHealthClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSHealthClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAWSHealthConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSHealthClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAWSHealthClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAWSHealthClient Configuration Object</param>
        public AmazonAWSHealthClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAWSHealthConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAWSHealthClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAWSHealthClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAWSHealthConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSHealthClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSHealthClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAWSHealthConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSHealthClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAWSHealthClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAWSHealthClient Configuration Object</param>
        public AmazonAWSHealthClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAWSHealthConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAWSHealthEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAWSHealthAuthSchemeHandler());
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


        #region  DescribeAffectedAccountsForOrganization


        /// <summary>
        /// Returns a list of accounts in the organization from Organizations that are affected
        /// by the provided event. For more information about the different types of Health events,
        /// see <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable Health to work with Organizations.
        /// To do this, call the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's management account.
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
        /// next request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedAccountsForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeAffectedAccountsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<c>nextToken</c>) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedAccountsForOrganization">REST API Reference for DescribeAffectedAccountsForOrganization Operation</seealso>
        public virtual DescribeAffectedAccountsForOrganizationResponse DescribeAffectedAccountsForOrganization(DescribeAffectedAccountsForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAffectedAccountsForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAffectedAccountsForOrganizationResponseUnmarshaller.Instance;

            return Invoke<DescribeAffectedAccountsForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of accounts in the organization from Organizations that are affected
        /// by the provided event. For more information about the different types of Health events,
        /// see <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable Health to work with Organizations.
        /// To do this, call the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's management account.
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
        /// next request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedAccountsForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAffectedAccountsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<c>nextToken</c>) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedAccountsForOrganization">REST API Reference for DescribeAffectedAccountsForOrganization Operation</seealso>
        public virtual Task<DescribeAffectedAccountsForOrganizationResponse> DescribeAffectedAccountsForOrganizationAsync(DescribeAffectedAccountsForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAffectedAccountsForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAffectedAccountsForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAffectedAccountsForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAffectedEntities


        /// <summary>
        /// Returns a list of entities that have been affected by the specified events, based
        /// on the specified filter criteria. Entities can refer to individual customer resources,
        /// groups of customer resources, or any other construct, depending on the Amazon Web
        /// Services service. Events that have impact beyond that of the affected entities, or
        /// where the extent of impact is unknown, include at least one entity indicating this.
        /// 
        ///  
        /// <para>
        /// At least one event ARN is required.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
        /// next request to return more results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This operation supports resource-level permissions. You can use this operation to
        /// allow or deny access to specific Health events. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html#resource-action-based-conditions">Resource-
        /// and action-based conditions</a> in the <i>Health User Guide</i>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedEntities service method.</param>
        /// 
        /// <returns>The response from the DescribeAffectedEntities service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<c>nextToken</c>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedEntities">REST API Reference for DescribeAffectedEntities Operation</seealso>
        public virtual DescribeAffectedEntitiesResponse DescribeAffectedEntities(DescribeAffectedEntitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAffectedEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAffectedEntitiesResponseUnmarshaller.Instance;

            return Invoke<DescribeAffectedEntitiesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of entities that have been affected by the specified events, based
        /// on the specified filter criteria. Entities can refer to individual customer resources,
        /// groups of customer resources, or any other construct, depending on the Amazon Web
        /// Services service. Events that have impact beyond that of the affected entities, or
        /// where the extent of impact is unknown, include at least one entity indicating this.
        /// 
        ///  
        /// <para>
        /// At least one event ARN is required.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
        /// next request to return more results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This operation supports resource-level permissions. You can use this operation to
        /// allow or deny access to specific Health events. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html#resource-action-based-conditions">Resource-
        /// and action-based conditions</a> in the <i>Health User Guide</i>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAffectedEntities service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<c>nextToken</c>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedEntities">REST API Reference for DescribeAffectedEntities Operation</seealso>
        public virtual Task<DescribeAffectedEntitiesResponse> DescribeAffectedEntitiesAsync(DescribeAffectedEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAffectedEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAffectedEntitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAffectedEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAffectedEntitiesForOrganization


        /// <summary>
        /// Returns a list of entities that have been affected by one or more events for one or
        /// more accounts in your organization in Organizations, based on the filter criteria.
        /// Entities can refer to individual customer resources, groups of customer resources,
        /// or any other construct, depending on the Amazon Web Services service.
        /// 
        ///  
        /// <para>
        /// At least one event Amazon Resource Name (ARN) and account ID are required.
        /// </para>
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable Health to work with Organizations.
        /// To do this, call the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's management account.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
        /// next request to return more results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This operation doesn't support resource-level permissions. You can't use this operation
        /// to allow or deny access to specific Health events. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html#resource-action-based-conditions">Resource-
        /// and action-based conditions</a> in the <i>Health User Guide</i>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedEntitiesForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeAffectedEntitiesForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<c>nextToken</c>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedEntitiesForOrganization">REST API Reference for DescribeAffectedEntitiesForOrganization Operation</seealso>
        public virtual DescribeAffectedEntitiesForOrganizationResponse DescribeAffectedEntitiesForOrganization(DescribeAffectedEntitiesForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAffectedEntitiesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAffectedEntitiesForOrganizationResponseUnmarshaller.Instance;

            return Invoke<DescribeAffectedEntitiesForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of entities that have been affected by one or more events for one or
        /// more accounts in your organization in Organizations, based on the filter criteria.
        /// Entities can refer to individual customer resources, groups of customer resources,
        /// or any other construct, depending on the Amazon Web Services service.
        /// 
        ///  
        /// <para>
        /// At least one event Amazon Resource Name (ARN) and account ID are required.
        /// </para>
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable Health to work with Organizations.
        /// To do this, call the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's management account.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
        /// next request to return more results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This operation doesn't support resource-level permissions. You can't use this operation
        /// to allow or deny access to specific Health events. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html#resource-action-based-conditions">Resource-
        /// and action-based conditions</a> in the <i>Health User Guide</i>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAffectedEntitiesForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAffectedEntitiesForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<c>nextToken</c>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeAffectedEntitiesForOrganization">REST API Reference for DescribeAffectedEntitiesForOrganization Operation</seealso>
        public virtual Task<DescribeAffectedEntitiesForOrganizationResponse> DescribeAffectedEntitiesForOrganizationAsync(DescribeAffectedEntitiesForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAffectedEntitiesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAffectedEntitiesForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAffectedEntitiesForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEntityAggregates


        /// <summary>
        /// Returns the number of entities that are affected by each of the specified events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntityAggregates service method.</param>
        /// 
        /// <returns>The response from the DescribeEntityAggregates service method, as returned by AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEntityAggregates">REST API Reference for DescribeEntityAggregates Operation</seealso>
        public virtual DescribeEntityAggregatesResponse DescribeEntityAggregates(DescribeEntityAggregatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEntityAggregatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntityAggregatesResponseUnmarshaller.Instance;

            return Invoke<DescribeEntityAggregatesResponse>(request, options);
        }


        /// <summary>
        /// Returns the number of entities that are affected by each of the specified events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntityAggregates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEntityAggregates service method, as returned by AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEntityAggregates">REST API Reference for DescribeEntityAggregates Operation</seealso>
        public virtual Task<DescribeEntityAggregatesResponse> DescribeEntityAggregatesAsync(DescribeEntityAggregatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEntityAggregatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntityAggregatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEntityAggregatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEntityAggregatesForOrganization


        /// <summary>
        /// Returns a list of entity aggregates for your Organizations that are affected by each
        /// of the specified events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntityAggregatesForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeEntityAggregatesForOrganization service method, as returned by AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEntityAggregatesForOrganization">REST API Reference for DescribeEntityAggregatesForOrganization Operation</seealso>
        public virtual DescribeEntityAggregatesForOrganizationResponse DescribeEntityAggregatesForOrganization(DescribeEntityAggregatesForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEntityAggregatesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntityAggregatesForOrganizationResponseUnmarshaller.Instance;

            return Invoke<DescribeEntityAggregatesForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of entity aggregates for your Organizations that are affected by each
        /// of the specified events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntityAggregatesForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEntityAggregatesForOrganization service method, as returned by AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEntityAggregatesForOrganization">REST API Reference for DescribeEntityAggregatesForOrganization Operation</seealso>
        public virtual Task<DescribeEntityAggregatesForOrganizationResponse> DescribeEntityAggregatesForOrganizationAsync(DescribeEntityAggregatesForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEntityAggregatesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntityAggregatesForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEntityAggregatesForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventAggregates


        /// <summary>
        /// Returns the number of events of each event type (issue, scheduled change, and account
        /// notification). If no filter is specified, the counts of all events in each category
        /// are returned.
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
        /// next request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventAggregates service method.</param>
        /// 
        /// <returns>The response from the DescribeEventAggregates service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<c>nextToken</c>) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventAggregates">REST API Reference for DescribeEventAggregates Operation</seealso>
        public virtual DescribeEventAggregatesResponse DescribeEventAggregates(DescribeEventAggregatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventAggregatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventAggregatesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventAggregatesResponse>(request, options);
        }


        /// <summary>
        /// Returns the number of events of each event type (issue, scheduled change, and account
        /// notification). If no filter is specified, the counts of all events in each category
        /// are returned.
        /// 
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
        /// next request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventAggregates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventAggregates service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<c>nextToken</c>) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventAggregates">REST API Reference for DescribeEventAggregates Operation</seealso>
        public virtual Task<DescribeEventAggregatesResponse> DescribeEventAggregatesAsync(DescribeEventAggregatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventAggregatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventAggregatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventAggregatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventDetails


        /// <summary>
        /// Returns detailed information about one or more specified events. Information includes
        /// standard event data (Amazon Web Services Region, service, and so on, as returned by
        /// <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEvents.html">DescribeEvents</a>),
        /// a detailed event description, and possible additional metadata that depends upon the
        /// nature of the event. Affected entities are not included. To retrieve the entities,
        /// use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntities.html">DescribeAffectedEntities</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// If a specified event can't be retrieved, an error message is returned for that event.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation supports resource-level permissions. You can use this operation to
        /// allow or deny access to specific Health events. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html#resource-action-based-conditions">Resource-
        /// and action-based conditions</a> in the <i>Health User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventDetails service method.</param>
        /// 
        /// <returns>The response from the DescribeEventDetails service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventDetails">REST API Reference for DescribeEventDetails Operation</seealso>
        public virtual DescribeEventDetailsResponse DescribeEventDetails(DescribeEventDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventDetailsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventDetailsResponse>(request, options);
        }


        /// <summary>
        /// Returns detailed information about one or more specified events. Information includes
        /// standard event data (Amazon Web Services Region, service, and so on, as returned by
        /// <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEvents.html">DescribeEvents</a>),
        /// a detailed event description, and possible additional metadata that depends upon the
        /// nature of the event. Affected entities are not included. To retrieve the entities,
        /// use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntities.html">DescribeAffectedEntities</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// If a specified event can't be retrieved, an error message is returned for that event.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation supports resource-level permissions. You can use this operation to
        /// allow or deny access to specific Health events. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html#resource-action-based-conditions">Resource-
        /// and action-based conditions</a> in the <i>Health User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventDetails service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventDetails">REST API Reference for DescribeEventDetails Operation</seealso>
        public virtual Task<DescribeEventDetailsResponse> DescribeEventDetailsAsync(DescribeEventDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventDetailsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventDetailsForOrganization


        /// <summary>
        /// Returns detailed information about one or more specified events for one or more Amazon
        /// Web Services accounts in your organization. This information includes standard event
        /// data (such as the Amazon Web Services Region and service), an event description, and
        /// (depending on the event) possible metadata. This operation doesn't return affected
        /// entities, such as the resources related to the event. To return affected entities,
        /// use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntitiesForOrganization.html">DescribeAffectedEntitiesForOrganization</a>
        /// operation.
        /// 
        ///  <note> 
        /// <para>
        /// Before you can call this operation, you must first enable Health to work with Organizations.
        /// To do this, call the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's management account.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you call the <c>DescribeEventDetailsForOrganization</c> operation, specify the
        /// <c>organizationEventDetailFilters</c> object in the request. Depending on the Health
        /// event type, note the following differences:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To return event details for a public event, you must specify a null value for the
        /// <c>awsAccountId</c> parameter. If you specify an account ID for a public event, Health
        /// returns an error message because public events aren't specific to an account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To return event details for an event that is specific to an account in your organization,
        /// you must specify the <c>awsAccountId</c> parameter in the request. If you don't specify
        /// an account ID, Health returns an error message because the event is specific to an
        /// account in your organization. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation doesn't support resource-level permissions. You can't use this operation
        /// to allow or deny access to specific Health events. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html#resource-action-based-conditions">Resource-
        /// and action-based conditions</a> in the <i>Health User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventDetailsForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeEventDetailsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventDetailsForOrganization">REST API Reference for DescribeEventDetailsForOrganization Operation</seealso>
        public virtual DescribeEventDetailsForOrganizationResponse DescribeEventDetailsForOrganization(DescribeEventDetailsForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventDetailsForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventDetailsForOrganizationResponseUnmarshaller.Instance;

            return Invoke<DescribeEventDetailsForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Returns detailed information about one or more specified events for one or more Amazon
        /// Web Services accounts in your organization. This information includes standard event
        /// data (such as the Amazon Web Services Region and service), an event description, and
        /// (depending on the event) possible metadata. This operation doesn't return affected
        /// entities, such as the resources related to the event. To return affected entities,
        /// use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntitiesForOrganization.html">DescribeAffectedEntitiesForOrganization</a>
        /// operation.
        /// 
        ///  <note> 
        /// <para>
        /// Before you can call this operation, you must first enable Health to work with Organizations.
        /// To do this, call the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's management account.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you call the <c>DescribeEventDetailsForOrganization</c> operation, specify the
        /// <c>organizationEventDetailFilters</c> object in the request. Depending on the Health
        /// event type, note the following differences:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To return event details for a public event, you must specify a null value for the
        /// <c>awsAccountId</c> parameter. If you specify an account ID for a public event, Health
        /// returns an error message because public events aren't specific to an account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To return event details for an event that is specific to an account in your organization,
        /// you must specify the <c>awsAccountId</c> parameter in the request. If you don't specify
        /// an account ID, Health returns an error message because the event is specific to an
        /// account in your organization. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation doesn't support resource-level permissions. You can't use this operation
        /// to allow or deny access to specific Health events. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html#resource-action-based-conditions">Resource-
        /// and action-based conditions</a> in the <i>Health User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventDetailsForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventDetailsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventDetailsForOrganization">REST API Reference for DescribeEventDetailsForOrganization Operation</seealso>
        public virtual Task<DescribeEventDetailsForOrganizationResponse> DescribeEventDetailsForOrganizationAsync(DescribeEventDetailsForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventDetailsForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventDetailsForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventDetailsForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Returns information about events that meet the specified filter criteria. Events
        /// are returned in a summary form and do not include the detailed description, any additional
        /// metadata that depends on the event type, or any affected resources. To retrieve that
        /// information, use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventDetails.html">DescribeEventDetails</a>
        /// and <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntities.html">DescribeAffectedEntities</a>
        /// operations.
        /// 
        ///  
        /// <para>
        /// If no filter criteria are specified, all events are returned. Results are sorted by
        /// <c>lastModifiedTime</c>, starting with the most recent event.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// When you call the <c>DescribeEvents</c> operation and specify an entity for the <c>entityValues</c>
        /// parameter, Health might return public events that aren't specific to that resource.
        /// For example, if you call <c>DescribeEvents</c> and specify an ID for an Amazon Elastic
        /// Compute Cloud (Amazon EC2) instance, Health might return events that aren't specific
        /// to that resource or service. To get events that are specific to a service, use the
        /// <c>services</c> parameter in the <c>filter</c> object. For more information, see <a
        /// href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
        /// next request to return more results.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<c>nextToken</c>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about events that meet the specified filter criteria. Events
        /// are returned in a summary form and do not include the detailed description, any additional
        /// metadata that depends on the event type, or any affected resources. To retrieve that
        /// information, use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventDetails.html">DescribeEventDetails</a>
        /// and <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntities.html">DescribeAffectedEntities</a>
        /// operations.
        /// 
        ///  
        /// <para>
        /// If no filter criteria are specified, all events are returned. Results are sorted by
        /// <c>lastModifiedTime</c>, starting with the most recent event.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// When you call the <c>DescribeEvents</c> operation and specify an entity for the <c>entityValues</c>
        /// parameter, Health might return public events that aren't specific to that resource.
        /// For example, if you call <c>DescribeEvents</c> and specify an ID for an Amazon Elastic
        /// Compute Cloud (Amazon EC2) instance, Health might return events that aren't specific
        /// to that resource or service. To get events that are specific to a service, use the
        /// <c>services</c> parameter in the <c>filter</c> object. For more information, see <a
        /// href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
        /// next request to return more results.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<c>nextToken</c>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventsForOrganization


        /// <summary>
        /// Returns information about events across your organization in Organizations. You can
        /// use the<c>filters</c> parameter to specify the events that you want to return. Events
        /// are returned in a summary form and don't include the affected accounts, detailed description,
        /// any additional metadata that depends on the event type, or any affected resources.
        /// To retrieve that information, use the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedAccountsForOrganization.html">DescribeAffectedAccountsForOrganization</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventDetailsForOrganization.html">DescribeEventDetailsForOrganization</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntitiesForOrganization.html">DescribeAffectedEntitiesForOrganization</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a <c>filter</c>, the <c>DescribeEventsForOrganizations</c> returns
        /// all events across your organization. Results are sorted by <c>lastModifiedTime</c>,
        /// starting with the most recent event. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the different types of Health events, see <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>.
        /// </para>
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable Health to work with Organizations.
        /// To do this, call the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's management account.
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
        /// next request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventsForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeEventsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<c>nextToken</c>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventsForOrganization">REST API Reference for DescribeEventsForOrganization Operation</seealso>
        public virtual DescribeEventsForOrganizationResponse DescribeEventsForOrganization(DescribeEventsForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsForOrganizationResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Returns information about events across your organization in Organizations. You can
        /// use the<c>filters</c> parameter to specify the events that you want to return. Events
        /// are returned in a summary form and don't include the affected accounts, detailed description,
        /// any additional metadata that depends on the event type, or any affected resources.
        /// To retrieve that information, use the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedAccountsForOrganization.html">DescribeAffectedAccountsForOrganization</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventDetailsForOrganization.html">DescribeEventDetailsForOrganization</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntitiesForOrganization.html">DescribeAffectedEntitiesForOrganization</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a <c>filter</c>, the <c>DescribeEventsForOrganizations</c> returns
        /// all events across your organization. Results are sorted by <c>lastModifiedTime</c>,
        /// starting with the most recent event. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the different types of Health events, see <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>.
        /// </para>
        ///  
        /// <para>
        /// Before you can call this operation, you must first enable Health to work with Organizations.
        /// To do this, call the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// operation from your organization's management account.
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
        /// next request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventsForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventsForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<c>nextToken</c>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventsForOrganization">REST API Reference for DescribeEventsForOrganization Operation</seealso>
        public virtual Task<DescribeEventsForOrganizationResponse> DescribeEventsForOrganizationAsync(DescribeEventsForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventsForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventTypes


        /// <summary>
        /// Returns the event types that meet the specified filter criteria. You can use this
        /// API operation to find information about the Health event, such as the category, Amazon
        /// Web Services service, and event code. The metadata for each event appears in the <a
        /// href="https://docs.aws.amazon.com/health/latest/APIReference/API_EventType.html">EventType</a>
        /// object. 
        /// 
        ///  
        /// <para>
        /// If you don't specify a filter criteria, the API operation returns all event types,
        /// in no particular order. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
        /// next request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeEventTypes service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<c>nextToken</c>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventTypes">REST API Reference for DescribeEventTypes Operation</seealso>
        public virtual DescribeEventTypesResponse DescribeEventTypes(DescribeEventTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventTypesResponse>(request, options);
        }


        /// <summary>
        /// Returns the event types that meet the specified filter criteria. You can use this
        /// API operation to find information about the Health event, such as the category, Amazon
        /// Web Services service, and event code. The metadata for each event appears in the <a
        /// href="https://docs.aws.amazon.com/health/latest/APIReference/API_EventType.html">EventType</a>
        /// object. 
        /// 
        ///  
        /// <para>
        /// If you don't specify a filter criteria, the API operation returns all event types,
        /// in no particular order. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This API operation uses pagination. Specify the <c>nextToken</c> parameter in the
        /// next request to return more results.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventTypes service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.InvalidPaginationTokenException">
        /// The specified pagination token (<c>nextToken</c>) is not valid.
        /// </exception>
        /// <exception cref="Amazon.AWSHealth.Model.UnsupportedLocaleException">
        /// The specified locale is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeEventTypes">REST API Reference for DescribeEventTypes Operation</seealso>
        public virtual Task<DescribeEventTypesResponse> DescribeEventTypesAsync(DescribeEventTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEventTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHealthServiceStatusForOrganization


        /// <summary>
        /// This operation provides status information on enabling or disabling Health to work
        /// with your organization. To call this operation, you must use the organization's management
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHealthServiceStatusForOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeHealthServiceStatusForOrganization service method, as returned by AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeHealthServiceStatusForOrganization">REST API Reference for DescribeHealthServiceStatusForOrganization Operation</seealso>
        public virtual DescribeHealthServiceStatusForOrganizationResponse DescribeHealthServiceStatusForOrganization(DescribeHealthServiceStatusForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeHealthServiceStatusForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHealthServiceStatusForOrganizationResponseUnmarshaller.Instance;

            return Invoke<DescribeHealthServiceStatusForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// This operation provides status information on enabling or disabling Health to work
        /// with your organization. To call this operation, you must use the organization's management
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHealthServiceStatusForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHealthServiceStatusForOrganization service method, as returned by AWSHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DescribeHealthServiceStatusForOrganization">REST API Reference for DescribeHealthServiceStatusForOrganization Operation</seealso>
        public virtual Task<DescribeHealthServiceStatusForOrganizationResponse> DescribeHealthServiceStatusForOrganizationAsync(DescribeHealthServiceStatusForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeHealthServiceStatusForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHealthServiceStatusForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeHealthServiceStatusForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableHealthServiceAccessForOrganization


        /// <summary>
        /// Disables Health from working with Organizations. To call this operation, you must
        /// sign in to the organization's management account. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/aggregate-events.html">Aggregating
        /// Health events</a> in the <i>Health User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation doesn't remove the service-linked role from the management account
        /// in your organization. You must use the IAM console, API, or Command Line Interface
        /// (CLI) to remove the service-linked role. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html#delete-service-linked-role">Deleting
        /// a Service-Linked Role</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can also disable the organizational feature by using the Organizations <a href="https://docs.aws.amazon.com/organizations/latest/APIReference/API_DisableAWSServiceAccess.html">DisableAWSServiceAccess</a>
        /// API operation. After you call this operation, Health stops aggregating events for
        /// all other Amazon Web Services accounts in your organization. If you call the Health
        /// API operations for organizational view, Health returns an error. Health continues
        /// to aggregate health events for your Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableHealthServiceAccessForOrganization service method.</param>
        /// 
        /// <returns>The response from the DisableHealthServiceAccessForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.ConcurrentModificationException">
        /// <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// is already in progress. Wait for the action to complete before trying again. To get
        /// the current status, use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeHealthServiceStatusForOrganization.html">DescribeHealthServiceStatusForOrganization</a>
        /// operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DisableHealthServiceAccessForOrganization">REST API Reference for DisableHealthServiceAccessForOrganization Operation</seealso>
        public virtual DisableHealthServiceAccessForOrganizationResponse DisableHealthServiceAccessForOrganization(DisableHealthServiceAccessForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableHealthServiceAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableHealthServiceAccessForOrganizationResponseUnmarshaller.Instance;

            return Invoke<DisableHealthServiceAccessForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Disables Health from working with Organizations. To call this operation, you must
        /// sign in to the organization's management account. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/aggregate-events.html">Aggregating
        /// Health events</a> in the <i>Health User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation doesn't remove the service-linked role from the management account
        /// in your organization. You must use the IAM console, API, or Command Line Interface
        /// (CLI) to remove the service-linked role. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html#delete-service-linked-role">Deleting
        /// a Service-Linked Role</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can also disable the organizational feature by using the Organizations <a href="https://docs.aws.amazon.com/organizations/latest/APIReference/API_DisableAWSServiceAccess.html">DisableAWSServiceAccess</a>
        /// API operation. After you call this operation, Health stops aggregating events for
        /// all other Amazon Web Services accounts in your organization. If you call the Health
        /// API operations for organizational view, Health returns an error. Health continues
        /// to aggregate health events for your Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableHealthServiceAccessForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableHealthServiceAccessForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.ConcurrentModificationException">
        /// <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// is already in progress. Wait for the action to complete before trying again. To get
        /// the current status, use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeHealthServiceStatusForOrganization.html">DescribeHealthServiceStatusForOrganization</a>
        /// operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/DisableHealthServiceAccessForOrganization">REST API Reference for DisableHealthServiceAccessForOrganization Operation</seealso>
        public virtual Task<DisableHealthServiceAccessForOrganizationResponse> DisableHealthServiceAccessForOrganizationAsync(DisableHealthServiceAccessForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableHealthServiceAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableHealthServiceAccessForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableHealthServiceAccessForOrganizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableHealthServiceAccessForOrganization


        /// <summary>
        /// Enables Health to work with Organizations. You can use the organizational view feature
        /// to aggregate events from all Amazon Web Services accounts in your organization in
        /// a centralized location. 
        /// 
        ///  
        /// <para>
        /// This operation also creates a service-linked role for the management account in the
        /// organization. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To call this operation, you must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan from <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a> to use the Health API. If you call the Health API from an
        /// Amazon Web Services account that doesn't have a Business, Enterprise On-Ramp, or Enterprise
        /// Support plan, you receive a <c>SubscriptionRequiredException</c> error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have permission to call this operation from the organization's management
        /// account. For example IAM policies, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html">Health
        /// identity-based policy examples</a>.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// If you don't have the required support plan, you can instead use the Health console
        /// to enable the organizational view feature. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/aggregate-events.html">Aggregating
        /// Health events</a> in the <i>Health User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableHealthServiceAccessForOrganization service method.</param>
        /// 
        /// <returns>The response from the EnableHealthServiceAccessForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.ConcurrentModificationException">
        /// <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// is already in progress. Wait for the action to complete before trying again. To get
        /// the current status, use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeHealthServiceStatusForOrganization.html">DescribeHealthServiceStatusForOrganization</a>
        /// operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/EnableHealthServiceAccessForOrganization">REST API Reference for EnableHealthServiceAccessForOrganization Operation</seealso>
        public virtual EnableHealthServiceAccessForOrganizationResponse EnableHealthServiceAccessForOrganization(EnableHealthServiceAccessForOrganizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableHealthServiceAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableHealthServiceAccessForOrganizationResponseUnmarshaller.Instance;

            return Invoke<EnableHealthServiceAccessForOrganizationResponse>(request, options);
        }


        /// <summary>
        /// Enables Health to work with Organizations. You can use the organizational view feature
        /// to aggregate events from all Amazon Web Services accounts in your organization in
        /// a centralized location. 
        /// 
        ///  
        /// <para>
        /// This operation also creates a service-linked role for the management account in the
        /// organization. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To call this operation, you must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must have a Business, Enterprise On-Ramp, or Enterprise Support plan from <a href="http://aws.amazon.com/premiumsupport/">Amazon
        /// Web Services Support</a> to use the Health API. If you call the Health API from an
        /// Amazon Web Services account that doesn't have a Business, Enterprise On-Ramp, or Enterprise
        /// Support plan, you receive a <c>SubscriptionRequiredException</c> error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have permission to call this operation from the organization's management
        /// account. For example IAM policies, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html">Health
        /// identity-based policy examples</a>.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// If you don't have the required support plan, you can instead use the Health console
        /// to enable the organizational view feature. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/aggregate-events.html">Aggregating
        /// Health events</a> in the <i>Health User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableHealthServiceAccessForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableHealthServiceAccessForOrganization service method, as returned by AWSHealth.</returns>
        /// <exception cref="Amazon.AWSHealth.Model.ConcurrentModificationException">
        /// <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
        /// is already in progress. Wait for the action to complete before trying again. To get
        /// the current status, use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeHealthServiceStatusForOrganization.html">DescribeHealthServiceStatusForOrganization</a>
        /// operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/health-2016-08-04/EnableHealthServiceAccessForOrganization">REST API Reference for EnableHealthServiceAccessForOrganization Operation</seealso>
        public virtual Task<EnableHealthServiceAccessForOrganizationResponse> EnableHealthServiceAccessForOrganizationAsync(EnableHealthServiceAccessForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableHealthServiceAccessForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableHealthServiceAccessForOrganizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableHealthServiceAccessForOrganizationResponse>(request, options, cancellationToken);
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