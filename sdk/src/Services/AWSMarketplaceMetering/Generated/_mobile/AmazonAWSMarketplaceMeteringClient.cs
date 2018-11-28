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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

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

#if CORECLR
    
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

#endif

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

        internal virtual BatchMeterUsageResponse BatchMeterUsage(BatchMeterUsageRequest request)
        {
            var marshaller = BatchMeterUsageRequestMarshaller.Instance;
            var unmarshaller = BatchMeterUsageResponseUnmarshaller.Instance;

            return Invoke<BatchMeterUsageRequest,BatchMeterUsageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchMeterUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchMeterUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/BatchMeterUsage">REST API Reference for BatchMeterUsage Operation</seealso>
        public virtual Task<BatchMeterUsageResponse> BatchMeterUsageAsync(BatchMeterUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BatchMeterUsageRequestMarshaller.Instance;
            var unmarshaller = BatchMeterUsageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchMeterUsageRequest,BatchMeterUsageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  MeterUsage

        internal virtual MeterUsageResponse MeterUsage(MeterUsageRequest request)
        {
            var marshaller = MeterUsageRequestMarshaller.Instance;
            var unmarshaller = MeterUsageResponseUnmarshaller.Instance;

            return Invoke<MeterUsageRequest,MeterUsageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the MeterUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MeterUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/MeterUsage">REST API Reference for MeterUsage Operation</seealso>
        public virtual Task<MeterUsageResponse> MeterUsageAsync(MeterUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = MeterUsageRequestMarshaller.Instance;
            var unmarshaller = MeterUsageResponseUnmarshaller.Instance;

            return InvokeAsync<MeterUsageRequest,MeterUsageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterUsage

        internal virtual RegisterUsageResponse RegisterUsage(RegisterUsageRequest request)
        {
            var marshaller = RegisterUsageRequestMarshaller.Instance;
            var unmarshaller = RegisterUsageResponseUnmarshaller.Instance;

            return Invoke<RegisterUsageRequest,RegisterUsageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/RegisterUsage">REST API Reference for RegisterUsage Operation</seealso>
        public virtual Task<RegisterUsageResponse> RegisterUsageAsync(RegisterUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterUsageRequestMarshaller.Instance;
            var unmarshaller = RegisterUsageResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterUsageRequest,RegisterUsageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResolveCustomer

        internal virtual ResolveCustomerResponse ResolveCustomer(ResolveCustomerRequest request)
        {
            var marshaller = ResolveCustomerRequestMarshaller.Instance;
            var unmarshaller = ResolveCustomerResponseUnmarshaller.Instance;

            return Invoke<ResolveCustomerRequest,ResolveCustomerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResolveCustomer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveCustomer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/meteringmarketplace-2016-01-14/ResolveCustomer">REST API Reference for ResolveCustomer Operation</seealso>
        public virtual Task<ResolveCustomerResponse> ResolveCustomerAsync(ResolveCustomerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResolveCustomerRequestMarshaller.Instance;
            var unmarshaller = ResolveCustomerResponseUnmarshaller.Instance;

            return InvokeAsync<ResolveCustomerRequest,ResolveCustomerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}