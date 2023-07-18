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
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AWSMarketplaceMetering.Model;
using Amazon.AWSMarketplaceMetering.Model.Internal.MarshallTransformations;
using Amazon.AWSMarketplaceMetering.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AWSMarketplaceMetering
{
    /// <summary>
    /// Implementation for accessing AWSMarketplaceMetering
    ///
    /// AWS Marketplace Metering Service 
    /// <para>
    /// This reference provides descriptions of the low-level AWS Marketplace Metering Service
    /// API.
    /// </para>
    ///  
    /// <para>
    /// AWS Marketplace sellers can use this API to submit usage data for custom usage dimensions.
    /// </para>
    ///  
    /// <para>
    /// For information on the permissions you need to use this API, see <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/iam-user-policy-for-aws-marketplace-actions.html">AWS
    /// Marketplace metering and entitlement API permissions</a> in the <i>AWS Marketplace
    /// Seller Guide.</i> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Submitting Metering Records</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>MeterUsage</i> - Submits the metering record for an AWS Marketplace product. <code>MeterUsage</code>
    /// is called from an EC2 instance or a container running on EKS or ECS.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>BatchMeterUsage</i> - Submits the metering record for a set of customers. <code>BatchMeterUsage</code>
    /// is called from a software-as-a-service (SaaS) application.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Accepting New Customers</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>ResolveCustomer</i> - Called by a SaaS application during the registration process.
    /// When a buyer visits your website during the registration process, the buyer submits
    /// a Registration Token through the browser. The Registration Token is resolved through
    /// this API to obtain a <code>CustomerIdentifier</code> along with the <code>CustomerAWSAccountId</code>
    /// and <code>ProductCode</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Entitlement and Metering for Paid Container Products</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Paid container software products sold through AWS Marketplace must integrate with
    /// the AWS Marketplace Metering Service and call the <code>RegisterUsage</code> operation
    /// for software entitlement and metering. Free and BYOL products for Amazon ECS or Amazon
    /// EKS aren't required to call <code>RegisterUsage</code>, but you can do so if you want
    /// to receive usage data in your seller reports. For more information on using the <code>RegisterUsage</code>
    /// operation, see <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/container-based-products.html">Container-Based
    /// Products</a>. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <code>BatchMeterUsage</code> API calls are captured by AWS CloudTrail. You can use
    /// Cloudtrail to verify that the SaaS metering records that you sent are accurate by
    /// searching for records with the <code>eventName</code> of <code>BatchMeterUsage</code>.
    /// You can also use CloudTrail to audit records over time. For more information, see
    /// the <i> <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html">AWS
    /// CloudTrail User Guide</a>.</i> 
    /// </para>
    /// </summary>
    public partial class AmazonAWSMarketplaceMeteringClient : AmazonServiceClient, IAmazonAWSMarketplaceMetering
    {
        private static IServiceMetadata serviceMetadata = new AmazonAWSMarketplaceMeteringMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAWSMarketplaceMeteringClient with the credentials loaded from the application's
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
        public AmazonAWSMarketplaceMeteringClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAWSMarketplaceMeteringConfig()) { }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceMeteringClient with the credentials loaded from the application's
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
        public AmazonAWSMarketplaceMeteringClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAWSMarketplaceMeteringConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceMeteringClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAWSMarketplaceMeteringClient Configuration Object</param>
        public AmazonAWSMarketplaceMeteringClient(AmazonAWSMarketplaceMeteringConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonAWSMarketplaceMeteringClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAWSMarketplaceMeteringClient(AWSCredentials credentials)
            : this(credentials, new AmazonAWSMarketplaceMeteringConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceMeteringClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSMarketplaceMeteringClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAWSMarketplaceMeteringConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceMeteringClient with AWS Credentials and an
        /// AmazonAWSMarketplaceMeteringClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAWSMarketplaceMeteringClient Configuration Object</param>
        public AmazonAWSMarketplaceMeteringClient(AWSCredentials credentials, AmazonAWSMarketplaceMeteringConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceMeteringClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAWSMarketplaceMeteringClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAWSMarketplaceMeteringConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceMeteringClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSMarketplaceMeteringClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAWSMarketplaceMeteringConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceMeteringClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAWSMarketplaceMeteringClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAWSMarketplaceMeteringClient Configuration Object</param>
        public AmazonAWSMarketplaceMeteringClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAWSMarketplaceMeteringConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceMeteringClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAWSMarketplaceMeteringClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAWSMarketplaceMeteringConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceMeteringClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAWSMarketplaceMeteringClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAWSMarketplaceMeteringConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAWSMarketplaceMeteringClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAWSMarketplaceMeteringClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAWSMarketplaceMeteringClient Configuration Object</param>
        public AmazonAWSMarketplaceMeteringClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAWSMarketplaceMeteringConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAWSMarketplaceMeteringEndpointResolver());
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


        #region  BatchMeterUsage

        internal virtual BatchMeterUsageResponse BatchMeterUsage(BatchMeterUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchMeterUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchMeterUsageResponseUnmarshaller.Instance;

            return Invoke<BatchMeterUsageResponse>(request, options);
        }



        /// <summary>
        /// <code>BatchMeterUsage</code> is called from a SaaS application listed on AWS Marketplace
        /// to post metering records for a set of customers.
        /// 
        ///  
        /// <para>
        /// For identical requests, the API is idempotent; requests can be retried with the same
        /// records or a subset of the input records.
        /// </para>
        ///  
        /// <para>
        /// Every request to <code>BatchMeterUsage</code> is for one product. If you need to meter
        /// usage for multiple products, you must make multiple calls to <code>BatchMeterUsage</code>.
        /// </para>
        ///  
        /// <para>
        /// Usage records are expected to be submitted as quickly as possible after the event
        /// that is being recorded, and are not accepted more than 6 hours after the event.
        /// </para>
        ///  
        /// <para>
        ///  <code>BatchMeterUsage</code> can process up to 25 <code>UsageRecords</code> at a
        /// time.
        /// </para>
        ///  
        /// <para>
        /// A <code>UsageRecord</code> can optionally include multiple usage allocations, to provide
        /// customers with usage data split into buckets by tags that you define (or allow the
        /// customer to define).
        /// </para>
        ///  
        /// <para>
        ///  <code>BatchMeterUsage</code> returns a list of <code>UsageRecordResult</code> objects,
        /// showing the result for each <code>UsageRecord</code>, as well as a list of <code>UnprocessedRecords</code>,
        /// indicating errors in the service side that you should retry.
        /// </para>
        ///  
        /// <para>
        ///  <code>BatchMeterUsage</code> requests must be less than 1MB in size.
        /// </para>
        ///  <note> 
        /// <para>
        /// For an example of using <code>BatchMeterUsage</code>, see <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/saas-code-examples.html#saas-batchmeterusage-example">
        /// BatchMeterUsage code example</a> in the <i>AWS Marketplace Seller Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchMeterUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchMeterUsage service method, as returned by AWSMarketplaceMetering.</returns>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.DisabledApiException">
        /// The API is disabled in the Region.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InternalServiceErrorException">
        /// An internal error has occurred. Retry your request. If the problem persists, post
        /// a message with details on the AWS forums.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidCustomerIdentifierException">
        /// You have metered usage for a <code>CustomerIdentifier</code> that does not exist.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidProductCodeException">
        /// The product code passed does not match the product code used for publishing the product.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidTagException">
        /// The tag is invalid, or the number of tags is greater than 5.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidUsageAllocationsException">
        /// The usage allocation objects are invalid, or the number of allocations is greater
        /// than 500 for a single usage record.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidUsageDimensionException">
        /// The usage dimension does not match one of the <code>UsageDimensions</code> associated
        /// with products.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the API are throttled.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.TimestampOutOfBoundsException">
        /// The <code>timestamp</code> value passed in the <code>UsageRecord</code> is out of
        /// allowed range.
        /// 
        ///  
        /// <para>
        /// For <code>BatchMeterUsage</code>, if any of the records are outside of the allowed
        /// range, the entire batch is not processed. You must remove invalid records and try
        /// again.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/BatchMeterUsage">REST API Reference for BatchMeterUsage Operation</seealso>
        public virtual Task<BatchMeterUsageResponse> BatchMeterUsageAsync(BatchMeterUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchMeterUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchMeterUsageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchMeterUsageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MeterUsage

        internal virtual MeterUsageResponse MeterUsage(MeterUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MeterUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MeterUsageResponseUnmarshaller.Instance;

            return Invoke<MeterUsageResponse>(request, options);
        }



        /// <summary>
        /// API to emit metering records. For identical requests, the API is idempotent. It simply
        /// returns the metering record ID.
        /// 
        ///  
        /// <para>
        ///  <code>MeterUsage</code> is authenticated on the buyer's AWS account using credentials
        /// from the EC2 instance, ECS task, or EKS pod.
        /// </para>
        ///  
        /// <para>
        ///  <code>MeterUsage</code> can optionally include multiple usage allocations, to provide
        /// customers with usage data split into buckets by tags that you define (or allow the
        /// customer to define).
        /// </para>
        ///  
        /// <para>
        /// Usage records are expected to be submitted as quickly as possible after the event
        /// that is being recorded, and are not accepted more than 6 hours after the event.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MeterUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MeterUsage service method, as returned by AWSMarketplaceMetering.</returns>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.CustomerNotEntitledException">
        /// Exception thrown when the customer does not have a valid subscription for the product.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.DuplicateRequestException">
        /// A metering record has already been emitted by the same EC2 instance, ECS task, or
        /// EKS pod for the given {<code>usageDimension</code>, <code>timestamp</code>} with a
        /// different <code>usageQuantity</code>.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InternalServiceErrorException">
        /// An internal error has occurred. Retry your request. If the problem persists, post
        /// a message with details on the AWS forums.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidEndpointRegionException">
        /// The endpoint being called is in a AWS Region different from your EC2 instance, ECS
        /// task, or EKS pod. The Region of the Metering Service endpoint and the AWS Region of
        /// the resource must match.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidProductCodeException">
        /// The product code passed does not match the product code used for publishing the product.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidTagException">
        /// The tag is invalid, or the number of tags is greater than 5.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidUsageAllocationsException">
        /// The usage allocation objects are invalid, or the number of allocations is greater
        /// than 500 for a single usage record.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidUsageDimensionException">
        /// The usage dimension does not match one of the <code>UsageDimensions</code> associated
        /// with products.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the API are throttled.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.TimestampOutOfBoundsException">
        /// The <code>timestamp</code> value passed in the <code>UsageRecord</code> is out of
        /// allowed range.
        /// 
        ///  
        /// <para>
        /// For <code>BatchMeterUsage</code>, if any of the records are outside of the allowed
        /// range, the entire batch is not processed. You must remove invalid records and try
        /// again.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/MeterUsage">REST API Reference for MeterUsage Operation</seealso>
        public virtual Task<MeterUsageResponse> MeterUsageAsync(MeterUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MeterUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MeterUsageResponseUnmarshaller.Instance;

            return InvokeAsync<MeterUsageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterUsage

        internal virtual RegisterUsageResponse RegisterUsage(RegisterUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterUsageResponseUnmarshaller.Instance;

            return Invoke<RegisterUsageResponse>(request, options);
        }



        /// <summary>
        /// Paid container software products sold through AWS Marketplace must integrate with
        /// the AWS Marketplace Metering Service and call the <code>RegisterUsage</code> operation
        /// for software entitlement and metering. Free and BYOL products for Amazon ECS or Amazon
        /// EKS aren't required to call <code>RegisterUsage</code>, but you may choose to do so
        /// if you would like to receive usage data in your seller reports. The sections below
        /// explain the behavior of <code>RegisterUsage</code>. <code>RegisterUsage</code> performs
        /// two primary functions: metering and entitlement.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <i>Entitlement</i>: <code>RegisterUsage</code> allows you to verify that the customer
        /// running your paid software is subscribed to your product on AWS Marketplace, enabling
        /// you to guard against unauthorized use. Your container image that integrates with <code>RegisterUsage</code>
        /// is only required to guard against unauthorized use at container startup, as such a
        /// <code>CustomerNotSubscribedException</code> or <code>PlatformNotSupportedException</code>
        /// will only be thrown on the initial call to <code>RegisterUsage</code>. Subsequent
        /// calls from the same Amazon ECS task instance (e.g. task-id) or Amazon EKS pod will
        /// not throw a <code>CustomerNotSubscribedException</code>, even if the customer unsubscribes
        /// while the Amazon ECS task or Amazon EKS pod is still running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Metering</i>: <code>RegisterUsage</code> meters software use per ECS task, per
        /// hour, or per pod for Amazon EKS with usage prorated to the second. A minimum of 1
        /// minute of usage applies to tasks that are short lived. For example, if a customer
        /// has a 10 node Amazon ECS or Amazon EKS cluster and a service configured as a Daemon
        /// Set, then Amazon ECS or Amazon EKS will launch a task on all 10 cluster nodes and
        /// the customer will be charged: (10 * hourly_rate). Metering for software use is automatically
        /// handled by the AWS Marketplace Metering Control Plane -- your software is not required
        /// to perform any metering specific actions, other than call <code>RegisterUsage</code>
        /// once for metering of software use to commence. The AWS Marketplace Metering Control
        /// Plane will also continue to bill customers for running ECS tasks and Amazon EKS pods,
        /// regardless of the customers subscription state, removing the need for your software
        /// to perform entitlement checks at runtime.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterUsage service method, as returned by AWSMarketplaceMetering.</returns>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.CustomerNotEntitledException">
        /// Exception thrown when the customer does not have a valid subscription for the product.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.DisabledApiException">
        /// The API is disabled in the Region.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InternalServiceErrorException">
        /// An internal error has occurred. Retry your request. If the problem persists, post
        /// a message with details on the AWS forums.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidProductCodeException">
        /// The product code passed does not match the product code used for publishing the product.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidPublicKeyVersionException">
        /// Public Key version is invalid.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidRegionException">
        /// <code>RegisterUsage</code> must be called in the same AWS Region the ECS task was
        /// launched in. This prevents a container from hardcoding a Region (e.g. withRegion(“us-east-1”)
        /// when calling <code>RegisterUsage</code>.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.PlatformNotSupportedException">
        /// AWS Marketplace does not support metering usage from the underlying platform. Currently,
        /// Amazon ECS, Amazon EKS, and AWS Fargate are supported.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the API are throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/RegisterUsage">REST API Reference for RegisterUsage Operation</seealso>
        public virtual Task<RegisterUsageResponse> RegisterUsageAsync(RegisterUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterUsageResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterUsageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResolveCustomer

        internal virtual ResolveCustomerResponse ResolveCustomer(ResolveCustomerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveCustomerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveCustomerResponseUnmarshaller.Instance;

            return Invoke<ResolveCustomerResponse>(request, options);
        }



        /// <summary>
        /// <code>ResolveCustomer</code> is called by a SaaS application during the registration
        /// process. When a buyer visits your website during the registration process, the buyer
        /// submits a registration token through their browser. The registration token is resolved
        /// through this API to obtain a <code>CustomerIdentifier</code> along with the <code>CustomerAWSAccountId</code>
        /// and <code>ProductCode</code>.
        /// 
        ///  <note> 
        /// <para>
        /// The API needs to called from the seller account id used to publish the SaaS application
        /// to successfully resolve the token.
        /// </para>
        ///  
        /// <para>
        /// For an example of using <code>ResolveCustomer</code>, see <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/saas-code-examples.html#saas-resolvecustomer-example">
        /// ResolveCustomer code example</a> in the <i>AWS Marketplace Seller Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveCustomer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResolveCustomer service method, as returned by AWSMarketplaceMetering.</returns>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.DisabledApiException">
        /// The API is disabled in the Region.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ExpiredTokenException">
        /// The submitted registration token has expired. This can happen if the buyer's browser
        /// takes too long to redirect to your page, the buyer has resubmitted the registration
        /// token, or your application has held on to the registration token for too long. Your
        /// SaaS registration website should redeem this token as soon as it is submitted by the
        /// buyer's browser.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InternalServiceErrorException">
        /// An internal error has occurred. Retry your request. If the problem persists, post
        /// a message with details on the AWS forums.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidTokenException">
        /// Registration token is invalid.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the API are throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/ResolveCustomer">REST API Reference for ResolveCustomer Operation</seealso>
        public virtual Task<ResolveCustomerResponse> ResolveCustomerAsync(ResolveCustomerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveCustomerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveCustomerResponseUnmarshaller.Instance;

            return InvokeAsync<ResolveCustomerResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}