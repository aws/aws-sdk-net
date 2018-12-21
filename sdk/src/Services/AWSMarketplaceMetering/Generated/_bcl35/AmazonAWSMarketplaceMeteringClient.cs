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
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
 */


using System;
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
    ///  <b>Submitting Metering Records</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>MeterUsage</i>- Submits the metering record for a Marketplace product. MeterUsage
    /// is called from an EC2 instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>BatchMeterUsage</i>- Submits the metering record for a set of customers. BatchMeterUsage
    /// is called from a software-as-a-service (SaaS) application.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Accepting New Customers</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>ResolveCustomer</i>- Called by a SaaS application during the registration process.
    /// When a buyer visits your website during the registration process, the buyer submits
    /// a Registration Token through the browser. The Registration Token is resolved through
    /// this API to obtain a CustomerIdentifier and Product Code.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Entitlement and Metering for Paid Container Products</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  Paid container software products sold through AWS Marketplace must integrate with
    /// the AWS Marketplace Metering Service and call the RegisterUsage operation for software
    /// entitlement and metering. Calling RegisterUsage from containers running outside of
    /// Amazon Elastic Container Service (Amazon ECR) isn't supported. Free and BYOL products
    /// for ECS aren't required to call RegisterUsage, but you can do so if you want to receive
    /// usage data in your seller reports. For more information on using the RegisterUsage
    /// operation, see <a href="https://docs.aws.amazon.com/latest/userguide/entitlement-and-metering-for-paid-products.html">Container-Based
    /// Products</a>. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// BatchMeterUsage API calls are captured by AWS CloudTrail. You can use Cloudtrail to
    /// verify that the SaaS metering records that you sent are accurate by searching for
    /// records with the eventName of BatchMeterUsage. You can also use CloudTrail to audit
    /// records over time. For more information, see the <i> <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-concepts.html">AWS
    /// CloudTrail User Guide</a> </i>.
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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

        /// <summary>
        /// BatchMeterUsage is called from a SaaS application listed on the AWS Marketplace to
        /// post metering records for a set of customers.
        /// 
        ///  
        /// <para>
        /// For identical requests, the API is idempotent; requests can be retried with the same
        /// records or a subset of the input records.
        /// </para>
        ///  
        /// <para>
        /// Every request to BatchMeterUsage is for one product. If you need to meter usage for
        /// multiple products, you must make multiple calls to BatchMeterUsage.
        /// </para>
        ///  
        /// <para>
        /// BatchMeterUsage can process up to 25 UsageRecords at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchMeterUsage service method.</param>
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
        /// You have metered usage for a CustomerIdentifier that does not exist.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidProductCodeException">
        /// The product code passed does not match the product code used for publishing the product.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidUsageDimensionException">
        /// The usage dimension does not match one of the UsageDimensions associated with products.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the API are throttled.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.TimestampOutOfBoundsException">
        /// The timestamp value passed in the meterUsage() is out of allowed range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/BatchMeterUsage">REST API Reference for BatchMeterUsage Operation</seealso>
        public virtual BatchMeterUsageResponse BatchMeterUsage(BatchMeterUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchMeterUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchMeterUsageResponseUnmarshaller.Instance;

            return Invoke<BatchMeterUsageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchMeterUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchMeterUsage operation on AmazonAWSMarketplaceMeteringClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchMeterUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/BatchMeterUsage">REST API Reference for BatchMeterUsage Operation</seealso>
        public virtual IAsyncResult BeginBatchMeterUsage(BatchMeterUsageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchMeterUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchMeterUsageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchMeterUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchMeterUsage.</param>
        /// 
        /// <returns>Returns a  BatchMeterUsageResult from AWSMarketplaceMetering.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/BatchMeterUsage">REST API Reference for BatchMeterUsage Operation</seealso>
        public virtual BatchMeterUsageResponse EndBatchMeterUsage(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchMeterUsageResponse>(asyncResult);
        }

        #endregion
        
        #region  MeterUsage

        /// <summary>
        /// API to emit metering records. For identical requests, the API is idempotent. It simply
        /// returns the metering record ID.
        /// 
        ///  
        /// <para>
        /// MeterUsage is authenticated on the buyer's AWS account, generally when running from
        /// an EC2 instance on the AWS Marketplace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MeterUsage service method.</param>
        /// 
        /// <returns>The response from the MeterUsage service method, as returned by AWSMarketplaceMetering.</returns>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.DuplicateRequestException">
        /// A metering record has already been emitted by the same EC2 instance for the given
        /// {usageDimension, timestamp} with a different usageQuantity.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InternalServiceErrorException">
        /// An internal error has occurred. Retry your request. If the problem persists, post
        /// a message with details on the AWS forums.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidEndpointRegionException">
        /// The endpoint being called is in a Region different from your EC2 instance. The Region
        /// of the Metering Service endpoint and the Region of the EC2 instance must match.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidProductCodeException">
        /// The product code passed does not match the product code used for publishing the product.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.InvalidUsageDimensionException">
        /// The usage dimension does not match one of the UsageDimensions associated with products.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the API are throttled.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.TimestampOutOfBoundsException">
        /// The timestamp value passed in the meterUsage() is out of allowed range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/MeterUsage">REST API Reference for MeterUsage Operation</seealso>
        public virtual MeterUsageResponse MeterUsage(MeterUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MeterUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MeterUsageResponseUnmarshaller.Instance;

            return Invoke<MeterUsageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MeterUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MeterUsage operation on AmazonAWSMarketplaceMeteringClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMeterUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/MeterUsage">REST API Reference for MeterUsage Operation</seealso>
        public virtual IAsyncResult BeginMeterUsage(MeterUsageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MeterUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MeterUsageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MeterUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMeterUsage.</param>
        /// 
        /// <returns>Returns a  MeterUsageResult from AWSMarketplaceMetering.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/MeterUsage">REST API Reference for MeterUsage Operation</seealso>
        public virtual MeterUsageResponse EndMeterUsage(IAsyncResult asyncResult)
        {
            return EndInvoke<MeterUsageResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterUsage

        /// <summary>
        /// Paid container software products sold through AWS Marketplace must integrate with
        /// the AWS Marketplace Metering Service and call the RegisterUsage operation for software
        /// entitlement and metering. Calling RegisterUsage from containers running outside of
        /// ECS is not currently supported. Free and BYOL products for ECS aren't required to
        /// call RegisterUsage, but you may choose to do so if you would like to receive usage
        /// data in your seller reports. The sections below explain the behavior of RegisterUsage.
        /// RegisterUsage performs two primary functions: metering and entitlement.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <i>Entitlement</i>: RegisterUsage allows you to verify that the customer running
        /// your paid software is subscribed to your product on AWS Marketplace, enabling you
        /// to guard against unauthorized use. Your container image that integrates with RegisterUsage
        /// is only required to guard against unauthorized use at container startup, as such a
        /// CustomerNotSubscribedException/PlatformNotSupportedException will only be thrown on
        /// the initial call to RegisterUsage. Subsequent calls from the same Amazon ECS task
        /// instance (e.g. task-id) will not throw a CustomerNotSubscribedException, even if the
        /// customer unsubscribes while the Amazon ECS task is still running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Metering</i>: RegisterUsage meters software use per ECS task, per hour, with usage
        /// prorated to the second. A minimum of 1 minute of usage applies to tasks that are short
        /// lived. For example, if a customer has a 10 node ECS cluster and creates an ECS service
        /// configured as a Daemon Set, then ECS will launch a task on all 10 cluster nodes and
        /// the customer will be charged: (10 * hourly_rate). Metering for software use is automatically
        /// handled by the AWS Marketplace Metering Control Plane -- your software is not required
        /// to perform any metering specific actions, other than call RegisterUsage once for metering
        /// of software use to commence. The AWS Marketplace Metering Control Plane will also
        /// continue to bill customers for running ECS tasks, regardless of the customers subscription
        /// state, removing the need for your software to perform entitlement checks at runtime.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterUsage service method.</param>
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
        /// RegisterUsage must be called in the same AWS Region the ECS task was launched in.
        /// This prevents a container from hardcoding a Region (e.g. withRegion(“us-east-1”) when
        /// calling RegisterUsage.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.PlatformNotSupportedException">
        /// AWS Marketplace does not support metering usage from the underlying platform. Currently,
        /// only Amazon ECS is supported.
        /// </exception>
        /// <exception cref="Amazon.AWSMarketplaceMetering.Model.ThrottlingException">
        /// The calls to the API are throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/RegisterUsage">REST API Reference for RegisterUsage Operation</seealso>
        public virtual RegisterUsageResponse RegisterUsage(RegisterUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterUsageResponseUnmarshaller.Instance;

            return Invoke<RegisterUsageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterUsage operation on AmazonAWSMarketplaceMeteringClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/RegisterUsage">REST API Reference for RegisterUsage Operation</seealso>
        public virtual IAsyncResult BeginRegisterUsage(RegisterUsageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterUsageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterUsage.</param>
        /// 
        /// <returns>Returns a  RegisterUsageResult from AWSMarketplaceMetering.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/RegisterUsage">REST API Reference for RegisterUsage Operation</seealso>
        public virtual RegisterUsageResponse EndRegisterUsage(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterUsageResponse>(asyncResult);
        }

        #endregion
        
        #region  ResolveCustomer

        /// <summary>
        /// ResolveCustomer is called by a SaaS application during the registration process. When
        /// a buyer visits your website during the registration process, the buyer submits a registration
        /// token through their browser. The registration token is resolved through this API to
        /// obtain a CustomerIdentifier and product code.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveCustomer service method.</param>
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
        public virtual ResolveCustomerResponse ResolveCustomer(ResolveCustomerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveCustomerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveCustomerResponseUnmarshaller.Instance;

            return Invoke<ResolveCustomerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResolveCustomer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveCustomer operation on AmazonAWSMarketplaceMeteringClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResolveCustomer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/ResolveCustomer">REST API Reference for ResolveCustomer Operation</seealso>
        public virtual IAsyncResult BeginResolveCustomer(ResolveCustomerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveCustomerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveCustomerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResolveCustomer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResolveCustomer.</param>
        /// 
        /// <returns>Returns a  ResolveCustomerResult from AWSMarketplaceMetering.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/ResolveCustomer">REST API Reference for ResolveCustomer Operation</seealso>
        public virtual ResolveCustomerResponse EndResolveCustomer(IAsyncResult asyncResult)
        {
            return EndInvoke<ResolveCustomerResponse>(asyncResult);
        }

        #endregion
        
    }
}