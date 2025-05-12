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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AWSMarketplaceMetering.Model;

#pragma warning disable CS1570
namespace Amazon.AWSMarketplaceMetering
{
    /// <summary>
    /// <para>Interface for accessing AWSMarketplaceMetering</para>
    ///
    /// Amazon Web Services Marketplace Metering Service 
    /// <para>
    /// This reference provides descriptions of the low-level Marketplace Metering Service
    /// API.
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services Marketplace sellers can use this API to submit usage data for
    /// custom usage dimensions.
    /// </para>
    ///  
    /// <para>
    /// For information about the permissions that you need to use this API, see <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/iam-user-policy-for-aws-marketplace-actions.html">Amazon
    /// Web Services Marketplace metering and entitlement API permissions</a> in the <i>Amazon
    /// Web Services Marketplace Seller Guide.</i> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Submitting metering records</b> 
    /// </para>
    ///  
    /// <para>
    ///  <i>MeterUsage</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Submits the metering record for an Amazon Web Services Marketplace product.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Called from: Amazon Elastic Compute Cloud (Amazon EC2) instance or a container running
    /// on either Amazon Elastic Kubernetes Service (Amazon EKS) or Amazon Elastic Container
    /// Service (Amazon ECS)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Supported product types: Amazon Machine Images (AMIs) and containers
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Vendor-metered tagging: Supported allocation tagging
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <i>BatchMeterUsage</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Submits the metering record for a set of customers. <c>BatchMeterUsage</c> API calls
    /// are captured by CloudTrail. You can use CloudTrail to verify that the software as
    /// a subscription (SaaS) metering records that you sent are accurate by searching for
    /// records with the <c>eventName</c> of <c>BatchMeterUsage</c>. You can also use CloudTrail
    /// to audit records over time. For more information, see the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html">CloudTrail
    /// User Guide</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Called from: SaaS applications
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Supported product type: SaaS
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Vendor-metered tagging: Supports allocation tagging
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Accepting new customers</b> 
    /// </para>
    ///  
    /// <para>
    ///  <i>ResolveCustomer</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Resolves the registration token that the buyer submits through the browser during
    /// the registration process. Obtains a <c>CustomerIdentifier</c> along with the <c>CustomerAWSAccountId</c>
    /// and <c>ProductCode</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Called from: SaaS application during the registration process
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Supported product type: SaaS
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Vendor-metered tagging: Not applicable
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Entitlement and metering for paid container products</b> 
    /// </para>
    ///  
    /// <para>
    ///  <i>RegisteredUsage</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Provides software entitlement and metering. Paid container software products sold
    /// through Amazon Web Services Marketplace must integrate with the Marketplace Metering
    /// Service and call the <c>RegisterUsage</c> operation. Free and Bring Your Own License
    /// model (BYOL) products for Amazon ECS or Amazon EKS aren't required to call <c>RegisterUsage</c>.
    /// However, you can do so if you want to receive usage data in your seller reports. For
    /// more information about using the <c>RegisterUsage</c> operation, see <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/container-based-products.html">Container-based
    /// products</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Called from: Paid container software products
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Supported product type: Containers
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Vendor-metered tagging: Not applicable
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Entitlement custom metering for container products</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// MeterUsage API is available in GovCloud Regions but only supports AMI FCP products
    /// in GovCloud Regions. Flexible Consumption Pricing (FCP) Container products aren’t
    /// supported in GovCloud Regions: us-gov-west-1 and us-gov-east-1. For more information,
    /// see <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/container-based-products.html">Container-based
    /// products</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Custom metering for container products are called using the MeterUsage API. The API
    /// is used for FCP AMI and FCP Container product metering.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Custom metering for Amazon EKS is available in 17 Amazon Web Services Regions</b>
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The metering service supports Amazon ECS and EKS for Flexible Consumption Pricing
    /// (FCP) products using MeterUsage API. Amazon ECS is supported in all Amazon Web Services
    /// Regions that MeterUsage API is available except for GovCloud.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EKS is supported in the following: us-east-1, us-east-2, us-west-1, us-west-2,
    /// eu-west-1, eu-central-1, eu-west-2, eu-west-3, eu-north-1, ap-east-1, ap-southeast-1,
    /// ap-northeast-1, ap-southeast-2, ap-northeast-2, ap-south-1, ca-central-1, sa-east-1.
    /// </para>
    ///  <note> 
    /// <para>
    /// For questions about adding Amazon Web Services Regions for metering, contact <a href="mailto://aws.amazon.com/marketplace/management/contact-us/">Amazon
    /// Web Services Marketplace Seller Operations</a>.
    /// </para>
    ///  </note> </li> </ul>
    /// </summary>
    public partial interface IAmazonAWSMarketplaceMetering : IAmazonService, IDisposable
    {
                
        #region  BatchMeterUsage



        /// <summary>
        /// <important> 
        /// <para>
        ///  The <c>CustomerIdentifier</c> parameter is scheduled for deprecation. Use <c>CustomerAWSAccountID</c>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// These parameters are mutually exclusive. You can't specify both <c>CustomerIdentifier</c>
        /// and <c>CustomerAWSAccountID</c> in the same request. 
        /// </para>
        ///  </important> 
        /// <para>
        /// To post metering records for customers, SaaS applications call <c>BatchMeterUsage</c>,
        /// which is used for metering SaaS flexible consumption pricing (FCP). Identical requests
        /// are idempotent and can be retried with the same records or a subset of records. Each
        /// <c>BatchMeterUsage</c> request is for only one product. If you want to meter usage
        /// for multiple products, you must make multiple <c>BatchMeterUsage</c> calls.
        /// </para>
        ///  
        /// <para>
        /// Usage records should be submitted in quick succession following a recorded event.
        /// Usage records aren't accepted 6 hours or more after an event.
        /// </para>
        ///  
        /// <para>
        ///  <c>BatchMeterUsage</c> can process up to 25 <c>UsageRecords</c> at a time, and each
        /// request must be less than 1 MB in size. Optionally, you can have multiple usage allocations
        /// for usage data that's split into buckets according to predefined tags.
        /// </para>
        ///  
        /// <para>
        ///  <c>BatchMeterUsage</c> returns a list of <c>UsageRecordResult</c> objects, which
        /// have each <c>UsageRecord</c>. It also returns a list of <c>UnprocessedRecords</c>,
        /// which indicate errors on the service side that should be retried.
        /// </para>
        ///  
        /// <para>
        /// For Amazon Web Services Regions that support <c>BatchMeterUsage</c>, see <a href="https://docs.aws.amazon.com/marketplace/latest/APIReference/metering-regions.html#batchmeterusage-region-support">BatchMeterUsage
        /// Region support</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// For an example of <c>BatchMeterUsage</c>, see <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/saas-code-examples.html#saas-batchmeterusage-example">
        /// BatchMeterUsage code example</a> in the <i>Amazon Web Services Marketplace Seller
        /// Guide</i>.
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
        /// a message with details on the Amazon Web Services forums.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidCustomerIdentifierException">
        /// You have metered usage for a <c>CustomerIdentifier</c> that does not exist.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidProductCodeException">
        /// The product code passed does not match the product code used for publishing the product.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidTagException">
        /// The tag is invalid, or the number of tags is greater than 5.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidUsageAllocationsException">
        /// Sum of allocated usage quantities is not equal to the usage quantity.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidUsageDimensionException">
        /// The usage dimension does not match one of the <c>UsageDimensions</c> associated with
        /// products.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the API are throttled.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.TimestampOutOfBoundsException">
        /// The <c>timestamp</c> value passed in the <c>UsageRecord</c> is out of allowed range.
        /// 
        ///  
        /// <para>
        /// For <c>BatchMeterUsage</c>, if any of the records are outside of the allowed range,
        /// the entire batch is not processed. You must remove invalid records and try again.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/BatchMeterUsage">REST API Reference for BatchMeterUsage Operation</seealso>
        Task<BatchMeterUsageResponse> BatchMeterUsageAsync(BatchMeterUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  MeterUsage



        /// <summary>
        /// API to emit metering records. For identical requests, the API is idempotent and returns
        /// the metering record ID. This is used for metering flexible consumption pricing (FCP)
        /// Amazon Machine Images (AMI) and container products.
        /// 
        ///  
        /// <para>
        ///  <c>MeterUsage</c> is authenticated on the buyer's Amazon Web Services account using
        /// credentials from the Amazon EC2 instance, Amazon ECS task, or Amazon EKS pod.
        /// </para>
        ///  
        /// <para>
        ///  <c>MeterUsage</c> can optionally include multiple usage allocations, to provide customers
        /// with usage data split into buckets by tags that you define (or allow the customer
        /// to define).
        /// </para>
        ///  
        /// <para>
        /// Usage records are expected to be submitted as quickly as possible after the event
        /// that is being recorded, and are not accepted more than 6 hours after the event.
        /// </para>
        ///  
        /// <para>
        /// For Amazon Web Services Regions that support <c>MeterUsage</c>, see <a href="https://docs.aws.amazon.com/marketplace/latest/APIReference/metering-regions.html#meterusage-region-support-ec2">MeterUsage
        /// Region support for Amazon EC2</a> and <a href="https://docs.aws.amazon.com/marketplace/latest/APIReference/metering-regions.html#meterusage-region-support-ecs-eks">MeterUsage
        /// Region support for Amazon ECS and Amazon EKS</a>. 
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
        /// EKS pod for the given {<c>usageDimension</c>, <c>timestamp</c>} with a different <c>usageQuantity</c>.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InternalServiceErrorException">
        /// An internal error has occurred. Retry your request. If the problem persists, post
        /// a message with details on the Amazon Web Services forums.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidEndpointRegionException">
        /// The endpoint being called is in a Amazon Web Services Region different from your EC2
        /// instance, ECS task, or EKS pod. The Region of the Metering Service endpoint and the
        /// Amazon Web Services Region of the resource must match.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidProductCodeException">
        /// The product code passed does not match the product code used for publishing the product.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidTagException">
        /// The tag is invalid, or the number of tags is greater than 5.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidUsageAllocationsException">
        /// Sum of allocated usage quantities is not equal to the usage quantity.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidUsageDimensionException">
        /// The usage dimension does not match one of the <c>UsageDimensions</c> associated with
        /// products.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the API are throttled.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.TimestampOutOfBoundsException">
        /// The <c>timestamp</c> value passed in the <c>UsageRecord</c> is out of allowed range.
        /// 
        ///  
        /// <para>
        /// For <c>BatchMeterUsage</c>, if any of the records are outside of the allowed range,
        /// the entire batch is not processed. You must remove invalid records and try again.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/MeterUsage">REST API Reference for MeterUsage Operation</seealso>
        Task<MeterUsageResponse> MeterUsageAsync(MeterUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterUsage



        /// <summary>
        /// Paid container software products sold through Amazon Web Services Marketplace must
        /// integrate with the Amazon Web Services Marketplace Metering Service and call the <c>RegisterUsage</c>
        /// operation for software entitlement and metering. Free and BYOL products for Amazon
        /// ECS or Amazon EKS aren't required to call <c>RegisterUsage</c>, but you may choose
        /// to do so if you would like to receive usage data in your seller reports. The sections
        /// below explain the behavior of <c>RegisterUsage</c>. <c>RegisterUsage</c> performs
        /// two primary functions: metering and entitlement.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <i>Entitlement</i>: <c>RegisterUsage</c> allows you to verify that the customer running
        /// your paid software is subscribed to your product on Amazon Web Services Marketplace,
        /// enabling you to guard against unauthorized use. Your container image that integrates
        /// with <c>RegisterUsage</c> is only required to guard against unauthorized use at container
        /// startup, as such a <c>CustomerNotSubscribedException</c> or <c>PlatformNotSupportedException</c>
        /// will only be thrown on the initial call to <c>RegisterUsage</c>. Subsequent calls
        /// from the same Amazon ECS task instance (e.g. task-id) or Amazon EKS pod will not throw
        /// a <c>CustomerNotSubscribedException</c>, even if the customer unsubscribes while the
        /// Amazon ECS task or Amazon EKS pod is still running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Metering</i>: <c>RegisterUsage</c> meters software use per ECS task, per hour,
        /// or per pod for Amazon EKS with usage prorated to the second. A minimum of 1 minute
        /// of usage applies to tasks that are short lived. For example, if a customer has a 10
        /// node Amazon ECS or Amazon EKS cluster and a service configured as a Daemon Set, then
        /// Amazon ECS or Amazon EKS will launch a task on all 10 cluster nodes and the customer
        /// will be charged for 10 tasks. Software metering is handled by the Amazon Web Services
        /// Marketplace metering control plane—your software is not required to perform metering-specific
        /// actions other than to call <c>RegisterUsage</c> to commence metering. The Amazon Web
        /// Services Marketplace metering control plane will also bill customers for running ECS
        /// tasks and Amazon EKS pods, regardless of the customer's subscription state, which
        /// removes the need for your software to run entitlement checks at runtime. For containers,
        /// <c>RegisterUsage</c> should be called immediately at launch. If you don’t register
        /// the container within the first 6 hours of the launch, Amazon Web Services Marketplace
        /// Metering Service doesn’t provide any metering guarantees for previous months. Metering
        /// will continue, however, for the current month forward until the container ends. <c>RegisterUsage</c>
        /// is for metering paid hourly container products.
        /// </para>
        ///  
        /// <para>
        /// For Amazon Web Services Regions that support <c>RegisterUsage</c>, see <a href="https://docs.aws.amazon.com/marketplace/latest/APIReference/metering-regions.html#registerusage-region-support">RegisterUsage
        /// Region support</a>. 
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
        /// a message with details on the Amazon Web Services forums.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidProductCodeException">
        /// The product code passed does not match the product code used for publishing the product.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidPublicKeyVersionException">
        /// Public Key version is invalid.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidRegionException">
        /// <c>RegisterUsage</c> must be called in the same Amazon Web Services Region the ECS
        /// task was launched in. This prevents a container from hardcoding a Region (e.g. withRegion(“us-east-1”)
        /// when calling <c>RegisterUsage</c>.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.PlatformNotSupportedException">
        /// Amazon Web Services Marketplace does not support metering usage from the underlying
        /// platform. Currently, Amazon ECS, Amazon EKS, and Fargate are supported.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the API are throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/RegisterUsage">REST API Reference for RegisterUsage Operation</seealso>
        Task<RegisterUsageResponse> RegisterUsageAsync(RegisterUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResolveCustomer



        /// <summary>
        /// <c>ResolveCustomer</c> is called by a SaaS application during the registration process.
        /// When a buyer visits your website during the registration process, the buyer submits
        /// a registration token through their browser. The registration token is resolved through
        /// this API to obtain a <c>CustomerIdentifier</c> along with the <c>CustomerAWSAccountId</c>
        /// and <c>ProductCode</c>.
        /// 
        ///  <note> 
        /// <para>
        /// To successfully resolve the token, the API must be called from the account that was
        /// used to publish the SaaS application. For an example of using <c>ResolveCustomer</c>,
        /// see <a href="https://docs.aws.amazon.com/marketplace/latest/userguide/saas-code-examples.html#saas-resolvecustomer-example">
        /// ResolveCustomer code example</a> in the <i>Amazon Web Services Marketplace Seller
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Permission is required for this operation. Your IAM role or user performing this operation
        /// requires a policy to allow the <c>aws-marketplace:ResolveCustomer</c> action. For
        /// more information, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsmarketplacemeteringservice.html">Actions,
        /// resources, and condition keys for Amazon Web Services Marketplace Metering Service</a>
        /// in the <i>Service Authorization Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// For Amazon Web Services Regions that support <c>ResolveCustomer</c>, see <a href="https://docs.aws.amazon.com/marketplace/latest/APIReference/metering-regions.html#resolvecustomer-region-support">ResolveCustomer
        /// Region support</a>. 
        /// </para>
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
        /// a message with details on the Amazon Web Services forums.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidTokenException">
        /// Registration token is invalid.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the API are throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/ResolveCustomer">REST API Reference for ResolveCustomer Operation</seealso>
        Task<ResolveCustomerResponse> ResolveCustomerAsync(ResolveCustomerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonAWSMarketplaceMeteringConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonAWSMarketplaceMeteringConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonAWSMarketplaceMeteringConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonAWSMarketplaceMeteringConfig to create AmazonAWSMarketplaceMeteringClient");
            }

            return awsCredentials == null ? 
                    new AmazonAWSMarketplaceMeteringClient(serviceClientConfig) :
                    new AmazonAWSMarketplaceMeteringClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}