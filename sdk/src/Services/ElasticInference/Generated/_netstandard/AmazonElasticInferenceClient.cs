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
 * Do not modify this file. This file is generated from the elastic-inference-2017-07-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ElasticInference.Model;
using Amazon.ElasticInference.Model.Internal.MarshallTransformations;
using Amazon.ElasticInference.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticInference
{
    /// <summary>
    /// Implementation for accessing ElasticInference
    ///
    /// Elastic Inference public APIs. 
    /// 
    ///  
    /// <para>
    ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
    /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
    /// to options that offer better price and performance. After April 15, 2023, new customers
    /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
    /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
    /// during the past 30-day period are considered current customers and will be able to
    /// continue using the service. 
    /// </para>
    /// </summary>
    public partial class AmazonElasticInferenceClient : AmazonServiceClient, IAmazonElasticInference
    {
        private static IServiceMetadata serviceMetadata = new AmazonElasticInferenceMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with the credentials loaded from the application's
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
        public AmazonElasticInferenceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticInferenceConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with the credentials loaded from the application's
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
        public AmazonElasticInferenceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticInferenceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticInferenceClient Configuration Object</param>
        public AmazonElasticInferenceClient(AmazonElasticInferenceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticInferenceClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticInferenceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticInferenceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticInferenceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Credentials and an
        /// AmazonElasticInferenceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticInferenceClient Configuration Object</param>
        public AmazonElasticInferenceClient(AWSCredentials credentials, AmazonElasticInferenceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticInferenceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticInferenceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticInferenceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticInferenceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticInferenceClient Configuration Object</param>
        public AmazonElasticInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticInferenceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticInferenceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticInferenceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticInferenceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticInferenceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticInferenceClient Configuration Object</param>
        public AmazonElasticInferenceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticInferenceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IElasticInferencePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IElasticInferencePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ElasticInferencePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonElasticInferenceEndpointResolver());
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


        #region  DescribeAcceleratorOfferings

        internal virtual DescribeAcceleratorOfferingsResponse DescribeAcceleratorOfferings(DescribeAcceleratorOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeAcceleratorOfferingsResponse>(request, options);
        }



        /// <summary>
        /// Describes the locations in which a given accelerator type or set of types is present
        /// in a given region. 
        /// 
        ///  
        /// <para>
        ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
        /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
        /// to options that offer better price and performance. After April 15, 2023, new customers
        /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
        /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
        /// during the past 30-day period are considered current customers and will be able to
        /// continue using the service. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAcceleratorOfferings service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAcceleratorOfferings">REST API Reference for DescribeAcceleratorOfferings Operation</seealso>
        public virtual Task<DescribeAcceleratorOfferingsResponse> DescribeAcceleratorOfferingsAsync(DescribeAcceleratorOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAcceleratorOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccelerators

        internal virtual DescribeAcceleratorsResponse DescribeAccelerators(DescribeAcceleratorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorsResponseUnmarshaller.Instance;

            return Invoke<DescribeAcceleratorsResponse>(request, options);
        }



        /// <summary>
        /// Describes information over a provided set of accelerators belonging to an account.
        /// 
        /// 
        ///  
        /// <para>
        ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
        /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
        /// to options that offer better price and performance. After April 15, 2023, new customers
        /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
        /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
        /// during the past 30-day period are considered current customers and will be able to
        /// continue using the service. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccelerators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccelerators service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAccelerators">REST API Reference for DescribeAccelerators Operation</seealso>
        public virtual Task<DescribeAcceleratorsResponse> DescribeAcceleratorsAsync(DescribeAcceleratorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAcceleratorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAcceleratorTypes

        internal virtual DescribeAcceleratorTypesResponse DescribeAcceleratorTypes(DescribeAcceleratorTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeAcceleratorTypesResponse>(request, options);
        }



        /// <summary>
        /// Describes the accelerator types available in a given region, as well as their characteristics,
        /// such as memory and throughput. 
        /// 
        ///  
        /// <para>
        ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
        /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
        /// to options that offer better price and performance. After April 15, 2023, new customers
        /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
        /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
        /// during the past 30-day period are considered current customers and will be able to
        /// continue using the service. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAcceleratorTypes service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAcceleratorTypes">REST API Reference for DescribeAcceleratorTypes Operation</seealso>
        public virtual Task<DescribeAcceleratorTypesResponse> DescribeAcceleratorTypesAsync(DescribeAcceleratorTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAcceleratorTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAcceleratorTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAcceleratorTypesResponse>(request, options, cancellationToken);
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
        /// Returns all tags of an Elastic Inference Accelerator. 
        /// 
        ///  
        /// <para>
        ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
        /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
        /// to options that offer better price and performance. After April 15, 2023, new customers
        /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
        /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
        /// during the past 30-day period are considered current customers and will be able to
        /// continue using the service. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// Adds the specified tags to an Elastic Inference Accelerator. 
        /// 
        ///  
        /// <para>
        ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
        /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
        /// to options that offer better price and performance. After April 15, 2023, new customers
        /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
        /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
        /// during the past 30-day period are considered current customers and will be able to
        /// continue using the service. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes the specified tags from an Elastic Inference Accelerator. 
        /// 
        ///  
        /// <para>
        ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
        /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
        /// to options that offer better price and performance. After April 15, 2023, new customers
        /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
        /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
        /// during the past 30-day period are considered current customers and will be able to
        /// continue using the service. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}