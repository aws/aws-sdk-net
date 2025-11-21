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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SavingsPlans.Model;
using Amazon.SavingsPlans.Model.Internal.MarshallTransformations;
using Amazon.SavingsPlans.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SavingsPlans
{
    /// <summary>
    /// <para>Implementation for accessing SavingsPlans</para>
    ///
    /// Savings Plans are a pricing model that offer significant savings on Amazon Web Services
    /// usage (for example, on Amazon EC2 instances). You commit to a consistent amount of
    /// usage per hour, in the specified currency, for a term of one or three years, and receive
    /// a lower price for that usage. For more information, see the <a href="https://docs.aws.amazon.com/savingsplans/latest/userguide/">Amazon
    /// Web Services Savings Plans User Guide</a>.
    /// </summary>
    public partial class AmazonSavingsPlansClient : AmazonServiceClient, IAmazonSavingsPlans
    {
        private static IServiceMetadata serviceMetadata = new AmazonSavingsPlansMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with the credentials loaded from the application's
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
        public AmazonSavingsPlansClient()
            : base(new AmazonSavingsPlansConfig()) { }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with the credentials loaded from the application's
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
        public AmazonSavingsPlansClient(RegionEndpoint region)
            : base(new AmazonSavingsPlansConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSavingsPlansClient Configuration Object</param>
        public AmazonSavingsPlansClient(AmazonSavingsPlansConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSavingsPlansClient(AWSCredentials credentials)
            : this(credentials, new AmazonSavingsPlansConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSavingsPlansClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSavingsPlansConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Credentials and an
        /// AmazonSavingsPlansClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSavingsPlansClient Configuration Object</param>
        public AmazonSavingsPlansClient(AWSCredentials credentials, AmazonSavingsPlansConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSavingsPlansClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSavingsPlansConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSavingsPlansClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSavingsPlansConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSavingsPlansClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSavingsPlansClient Configuration Object</param>
        public AmazonSavingsPlansClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSavingsPlansConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSavingsPlansClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSavingsPlansConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSavingsPlansClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSavingsPlansConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSavingsPlansClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSavingsPlansClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSavingsPlansClient Configuration Object</param>
        public AmazonSavingsPlansClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSavingsPlansConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSavingsPlansEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSavingsPlansAuthSchemeHandler());
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


        #region  CreateSavingsPlan


        /// <summary>
        /// Creates a Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSavingsPlan service method.</param>
        /// 
        /// <returns>The response from the CreateSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/CreateSavingsPlan">REST API Reference for CreateSavingsPlan Operation</seealso>
        public virtual CreateSavingsPlanResponse CreateSavingsPlan(CreateSavingsPlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSavingsPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSavingsPlanResponseUnmarshaller.Instance;

            return Invoke<CreateSavingsPlanResponse>(request, options);
        }


        /// <summary>
        /// Creates a Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSavingsPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/CreateSavingsPlan">REST API Reference for CreateSavingsPlan Operation</seealso>
        public virtual Task<CreateSavingsPlanResponse> CreateSavingsPlanAsync(CreateSavingsPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSavingsPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSavingsPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSavingsPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteQueuedSavingsPlan


        /// <summary>
        /// Deletes the queued purchase for the specified Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueuedSavingsPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteQueuedSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DeleteQueuedSavingsPlan">REST API Reference for DeleteQueuedSavingsPlan Operation</seealso>
        public virtual DeleteQueuedSavingsPlanResponse DeleteQueuedSavingsPlan(DeleteQueuedSavingsPlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueuedSavingsPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueuedSavingsPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteQueuedSavingsPlanResponse>(request, options);
        }


        /// <summary>
        /// Deletes the queued purchase for the specified Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueuedSavingsPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueuedSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DeleteQueuedSavingsPlan">REST API Reference for DeleteQueuedSavingsPlan Operation</seealso>
        public virtual Task<DeleteQueuedSavingsPlanResponse> DeleteQueuedSavingsPlanAsync(DeleteQueuedSavingsPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteQueuedSavingsPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueuedSavingsPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteQueuedSavingsPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSavingsPlanRates


        /// <summary>
        /// Describes the rates for the specified Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlanRates service method.</param>
        /// 
        /// <returns>The response from the DescribeSavingsPlanRates service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlanRates">REST API Reference for DescribeSavingsPlanRates Operation</seealso>
        public virtual DescribeSavingsPlanRatesResponse DescribeSavingsPlanRates(DescribeSavingsPlanRatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlanRatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlanRatesResponseUnmarshaller.Instance;

            return Invoke<DescribeSavingsPlanRatesResponse>(request, options);
        }


        /// <summary>
        /// Describes the rates for the specified Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlanRates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSavingsPlanRates service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlanRates">REST API Reference for DescribeSavingsPlanRates Operation</seealso>
        public virtual Task<DescribeSavingsPlanRatesResponse> DescribeSavingsPlanRatesAsync(DescribeSavingsPlanRatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlanRatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlanRatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSavingsPlanRatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSavingsPlans


        /// <summary>
        /// Describes the specified Savings Plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlans service method.</param>
        /// 
        /// <returns>The response from the DescribeSavingsPlans service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlans">REST API Reference for DescribeSavingsPlans Operation</seealso>
        public virtual DescribeSavingsPlansResponse DescribeSavingsPlans(DescribeSavingsPlansRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlansResponseUnmarshaller.Instance;

            return Invoke<DescribeSavingsPlansResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified Savings Plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSavingsPlans service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlans">REST API Reference for DescribeSavingsPlans Operation</seealso>
        public virtual Task<DescribeSavingsPlansResponse> DescribeSavingsPlansAsync(DescribeSavingsPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlansResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSavingsPlansResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSavingsPlansOfferingRates


        /// <summary>
        /// Describes the offering rates for the specified Savings Plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlansOfferingRates service method.</param>
        /// 
        /// <returns>The response from the DescribeSavingsPlansOfferingRates service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferingRates">REST API Reference for DescribeSavingsPlansOfferingRates Operation</seealso>
        public virtual DescribeSavingsPlansOfferingRatesResponse DescribeSavingsPlansOfferingRates(DescribeSavingsPlansOfferingRatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlansOfferingRatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlansOfferingRatesResponseUnmarshaller.Instance;

            return Invoke<DescribeSavingsPlansOfferingRatesResponse>(request, options);
        }


        /// <summary>
        /// Describes the offering rates for the specified Savings Plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlansOfferingRates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSavingsPlansOfferingRates service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferingRates">REST API Reference for DescribeSavingsPlansOfferingRates Operation</seealso>
        public virtual Task<DescribeSavingsPlansOfferingRatesResponse> DescribeSavingsPlansOfferingRatesAsync(DescribeSavingsPlansOfferingRatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlansOfferingRatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlansOfferingRatesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSavingsPlansOfferingRatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSavingsPlansOfferings


        /// <summary>
        /// Describes the offerings for the specified Savings Plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlansOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeSavingsPlansOfferings service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferings">REST API Reference for DescribeSavingsPlansOfferings Operation</seealso>
        public virtual DescribeSavingsPlansOfferingsResponse DescribeSavingsPlansOfferings(DescribeSavingsPlansOfferingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlansOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlansOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeSavingsPlansOfferingsResponse>(request, options);
        }


        /// <summary>
        /// Describes the offerings for the specified Savings Plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlansOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSavingsPlansOfferings service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferings">REST API Reference for DescribeSavingsPlansOfferings Operation</seealso>
        public virtual Task<DescribeSavingsPlansOfferingsResponse> DescribeSavingsPlansOfferingsAsync(DescribeSavingsPlansOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSavingsPlansOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSavingsPlansOfferingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSavingsPlansOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReturnSavingsPlan


        /// <summary>
        /// Returns the specified Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReturnSavingsPlan service method.</param>
        /// 
        /// <returns>The response from the ReturnSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ReturnSavingsPlan">REST API Reference for ReturnSavingsPlan Operation</seealso>
        public virtual ReturnSavingsPlanResponse ReturnSavingsPlan(ReturnSavingsPlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReturnSavingsPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReturnSavingsPlanResponseUnmarshaller.Instance;

            return Invoke<ReturnSavingsPlanResponse>(request, options);
        }


        /// <summary>
        /// Returns the specified Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReturnSavingsPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReturnSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ReturnSavingsPlan">REST API Reference for ReturnSavingsPlan Operation</seealso>
        public virtual Task<ReturnSavingsPlanResponse> ReturnSavingsPlanAsync(ReturnSavingsPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReturnSavingsPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReturnSavingsPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReturnSavingsPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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