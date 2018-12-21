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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations;
using Amazon.ElasticLoadBalancing.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancing
{
    /// <summary>
    /// Implementation for accessing ElasticLoadBalancing
    ///
    /// Elastic Load Balancing 
    /// <para>
    /// A load balancer can distribute incoming traffic across your EC2 instances. This enables
    /// you to increase the availability of your application. The load balancer also monitors
    /// the health of its registered instances and ensures that it routes traffic only to
    /// healthy instances. You configure your load balancer to accept incoming traffic by
    /// specifying one or more listeners, which are configured with a protocol and port number
    /// for connections from clients to the load balancer and a protocol and port number for
    /// connections from the load balancer to the instances.
    /// </para>
    ///  
    /// <para>
    /// Elastic Load Balancing supports three types of load balancers: Application Load Balancers,
    /// Network Load Balancers, and Classic Load Balancers. You can select a load balancer
    /// based on your application needs. For more information, see the <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/userguide/">Elastic
    /// Load Balancing User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// This reference covers the 2012-06-01 API, which supports Classic Load Balancers. The
    /// 2015-12-01 API supports Application Load Balancers and Network Load Balancers.
    /// </para>
    ///  
    /// <para>
    /// To get started, create a load balancer with one or more listeners using <a>CreateLoadBalancer</a>.
    /// Register your instances with the load balancer using <a>RegisterInstancesWithLoadBalancer</a>.
    /// </para>
    ///  
    /// <para>
    /// All Elastic Load Balancing operations are <i>idempotent</i>, which means that they
    /// complete at most one time. If you repeat an operation, it succeeds with a 200 OK response
    /// code.
    /// </para>
    /// </summary>
    public partial class AmazonElasticLoadBalancingClient : AmazonServiceClient, IAmazonElasticLoadBalancing
    {
        private static IServiceMetadata serviceMetadata = new AmazonElasticLoadBalancingMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        public AmazonElasticLoadBalancingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticLoadBalancingConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        public AmazonElasticLoadBalancingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticLoadBalancingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(AmazonElasticLoadBalancingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticLoadBalancingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials and an
        /// AmazonElasticLoadBalancingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials, AmazonElasticLoadBalancingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticLoadBalancingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticLoadBalancingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticLoadBalancingConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.ElasticLoadBalancing.Internal.ProcessRequestHandler());
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


        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ApplySecurityGroupsToLoadBalancer

        internal virtual ApplySecurityGroupsToLoadBalancerResponse ApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplySecurityGroupsToLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplySecurityGroupsToLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<ApplySecurityGroupsToLoadBalancerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ApplySecurityGroupsToLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/ApplySecurityGroupsToLoadBalancer">REST API Reference for ApplySecurityGroupsToLoadBalancer Operation</seealso>
        public virtual Task<ApplySecurityGroupsToLoadBalancerResponse> ApplySecurityGroupsToLoadBalancerAsync(ApplySecurityGroupsToLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplySecurityGroupsToLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplySecurityGroupsToLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<ApplySecurityGroupsToLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachLoadBalancerToSubnets

        internal virtual AttachLoadBalancerToSubnetsResponse AttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancerToSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancerToSubnetsResponseUnmarshaller.Instance;

            return Invoke<AttachLoadBalancerToSubnetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancerToSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/AttachLoadBalancerToSubnets">REST API Reference for AttachLoadBalancerToSubnets Operation</seealso>
        public virtual Task<AttachLoadBalancerToSubnetsResponse> AttachLoadBalancerToSubnetsAsync(AttachLoadBalancerToSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancerToSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancerToSubnetsResponseUnmarshaller.Instance;

            return InvokeAsync<AttachLoadBalancerToSubnetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfigureHealthCheck

        internal virtual ConfigureHealthCheckResponse ConfigureHealthCheck(ConfigureHealthCheckRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureHealthCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureHealthCheckResponseUnmarshaller.Instance;

            return Invoke<ConfigureHealthCheckResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/ConfigureHealthCheck">REST API Reference for ConfigureHealthCheck Operation</seealso>
        public virtual Task<ConfigureHealthCheckResponse> ConfigureHealthCheckAsync(ConfigureHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfigureHealthCheckRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfigureHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<ConfigureHealthCheckResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAppCookieStickinessPolicy

        internal virtual CreateAppCookieStickinessPolicyResponse CreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppCookieStickinessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppCookieStickinessPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateAppCookieStickinessPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppCookieStickinessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateAppCookieStickinessPolicy">REST API Reference for CreateAppCookieStickinessPolicy Operation</seealso>
        public virtual Task<CreateAppCookieStickinessPolicyResponse> CreateAppCookieStickinessPolicyAsync(CreateAppCookieStickinessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppCookieStickinessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppCookieStickinessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppCookieStickinessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLBCookieStickinessPolicy

        internal virtual CreateLBCookieStickinessPolicyResponse CreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLBCookieStickinessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLBCookieStickinessPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateLBCookieStickinessPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLBCookieStickinessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateLBCookieStickinessPolicy">REST API Reference for CreateLBCookieStickinessPolicy Operation</seealso>
        public virtual Task<CreateLBCookieStickinessPolicyResponse> CreateLBCookieStickinessPolicyAsync(CreateLBCookieStickinessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLBCookieStickinessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLBCookieStickinessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLBCookieStickinessPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLoadBalancer

        internal virtual CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<CreateLoadBalancerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        public virtual Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLoadBalancerListeners

        internal virtual CreateLoadBalancerListenersResponse CreateLoadBalancerListeners(CreateLoadBalancerListenersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerListenersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerListenersResponseUnmarshaller.Instance;

            return Invoke<CreateLoadBalancerListenersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateLoadBalancerListeners">REST API Reference for CreateLoadBalancerListeners Operation</seealso>
        public virtual Task<CreateLoadBalancerListenersResponse> CreateLoadBalancerListenersAsync(CreateLoadBalancerListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerListenersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerListenersResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoadBalancerListenersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLoadBalancerPolicy

        internal virtual CreateLoadBalancerPolicyResponse CreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateLoadBalancerPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateLoadBalancerPolicy">REST API Reference for CreateLoadBalancerPolicy Operation</seealso>
        public virtual Task<CreateLoadBalancerPolicyResponse> CreateLoadBalancerPolicyAsync(CreateLoadBalancerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoadBalancerPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoadBalancer

        internal virtual DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<DeleteLoadBalancerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        public virtual Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoadBalancerListeners

        internal virtual DeleteLoadBalancerListenersResponse DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerListenersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerListenersResponseUnmarshaller.Instance;

            return Invoke<DeleteLoadBalancerListenersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DeleteLoadBalancerListeners">REST API Reference for DeleteLoadBalancerListeners Operation</seealso>
        public virtual Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListenersAsync(DeleteLoadBalancerListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerListenersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerListenersResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoadBalancerListenersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoadBalancerPolicy

        internal virtual DeleteLoadBalancerPolicyResponse DeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteLoadBalancerPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DeleteLoadBalancerPolicy">REST API Reference for DeleteLoadBalancerPolicy Operation</seealso>
        public virtual Task<DeleteLoadBalancerPolicyResponse> DeleteLoadBalancerPolicyAsync(DeleteLoadBalancerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoadBalancerPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterInstancesFromLoadBalancer

        internal virtual DeregisterInstancesFromLoadBalancerResponse DeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterInstancesFromLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterInstancesFromLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<DeregisterInstancesFromLoadBalancerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstancesFromLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstancesFromLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DeregisterInstancesFromLoadBalancer">REST API Reference for DeregisterInstancesFromLoadBalancer Operation</seealso>
        public virtual Task<DeregisterInstancesFromLoadBalancerResponse> DeregisterInstancesFromLoadBalancerAsync(DeregisterInstancesFromLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterInstancesFromLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterInstancesFromLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterInstancesFromLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountLimits

        internal virtual DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountLimitsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceHealth

        internal virtual DescribeInstanceHealthResponse DescribeInstanceHealth(DescribeInstanceHealthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceHealthResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeInstanceHealth">REST API Reference for DescribeInstanceHealth Operation</seealso>
        public virtual Task<DescribeInstanceHealthResponse> DescribeInstanceHealthAsync(DescribeInstanceHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceHealthResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceHealthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancerAttributes

        internal virtual DescribeLoadBalancerAttributesResponse DescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancerAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancerAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancerAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerAttributes">REST API Reference for DescribeLoadBalancerAttributes Operation</seealso>
        public virtual Task<DescribeLoadBalancerAttributesResponse> DescribeLoadBalancerAttributesAsync(DescribeLoadBalancerAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancerAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancerAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancerAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancerPolicies

        internal virtual DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies()
        {
            return DescribeLoadBalancerPolicies(new DescribeLoadBalancerPoliciesRequest());
        }
        internal virtual DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancerPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancerPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancerPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified policies.
        /// 
        ///  
        /// <para>
        /// If you specify a load balancer name, the action returns the descriptions of all policies
        /// created for the load balancer. If you specify a policy name associated with your load
        /// balancer, the action returns the description of that policy. If you don't specify
        /// a load balancer name, the action returns descriptions of the specified sample policies,
        /// or descriptions of all sample policies. The names of the sample policies have the
        /// <code>ELBSample-</code> prefix.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerPolicies">REST API Reference for DescribeLoadBalancerPolicies Operation</seealso>
        public virtual Task<DescribeLoadBalancerPoliciesResponse> DescribeLoadBalancerPoliciesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeLoadBalancerPoliciesAsync(new DescribeLoadBalancerPoliciesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerPolicies">REST API Reference for DescribeLoadBalancerPolicies Operation</seealso>
        public virtual Task<DescribeLoadBalancerPoliciesResponse> DescribeLoadBalancerPoliciesAsync(DescribeLoadBalancerPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancerPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancerPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancerPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancerPolicyTypes

        internal virtual DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes()
        {
            return DescribeLoadBalancerPolicyTypes(new DescribeLoadBalancerPolicyTypesRequest());
        }
        internal virtual DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancerPolicyTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancerPolicyTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancerPolicyTypesResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified load balancer policy types or all load balancer policy types.
        /// 
        ///  
        /// <para>
        /// The description of each type indicates how it can be used. For example, some policies
        /// can be used only with layer 7 listeners, some policies can be used only with layer
        /// 4 listeners, and some policies can be used only with your EC2 instances.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>CreateLoadBalancerPolicy</a> to create a policy configuration for any
        /// of these policy types. Then, depending on the policy type, use either <a>SetLoadBalancerPoliciesOfListener</a>
        /// or <a>SetLoadBalancerPoliciesForBackendServer</a> to set the policy.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerPolicyTypes">REST API Reference for DescribeLoadBalancerPolicyTypes Operation</seealso>
        public virtual Task<DescribeLoadBalancerPolicyTypesResponse> DescribeLoadBalancerPolicyTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeLoadBalancerPolicyTypesAsync(new DescribeLoadBalancerPolicyTypesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicyTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerPolicyTypes">REST API Reference for DescribeLoadBalancerPolicyTypes Operation</seealso>
        public virtual Task<DescribeLoadBalancerPolicyTypesResponse> DescribeLoadBalancerPolicyTypesAsync(DescribeLoadBalancerPolicyTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancerPolicyTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancerPolicyTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancerPolicyTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancers

        internal virtual DescribeLoadBalancersResponse DescribeLoadBalancers()
        {
            return DescribeLoadBalancers(new DescribeLoadBalancersRequest());
        }
        internal virtual DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancersResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified the load balancers. If no load balancers are specified, the
        /// call describes all of your load balancers.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DependencyThrottleException">
        /// A request made by Elastic Load Balancing to another service exceeds the maximum request
        /// rate permitted for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        public virtual Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeLoadBalancersAsync(new DescribeLoadBalancersRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        public virtual Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachLoadBalancerFromSubnets

        internal virtual DetachLoadBalancerFromSubnetsResponse DetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachLoadBalancerFromSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachLoadBalancerFromSubnetsResponseUnmarshaller.Instance;

            return Invoke<DetachLoadBalancerFromSubnetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachLoadBalancerFromSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DetachLoadBalancerFromSubnets">REST API Reference for DetachLoadBalancerFromSubnets Operation</seealso>
        public virtual Task<DetachLoadBalancerFromSubnetsResponse> DetachLoadBalancerFromSubnetsAsync(DetachLoadBalancerFromSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachLoadBalancerFromSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachLoadBalancerFromSubnetsResponseUnmarshaller.Instance;

            return InvokeAsync<DetachLoadBalancerFromSubnetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableAvailabilityZonesForLoadBalancer

        internal virtual DisableAvailabilityZonesForLoadBalancerResponse DisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableAvailabilityZonesForLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<DisableAvailabilityZonesForLoadBalancerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableAvailabilityZonesForLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAvailabilityZonesForLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DisableAvailabilityZonesForLoadBalancer">REST API Reference for DisableAvailabilityZonesForLoadBalancer Operation</seealso>
        public virtual Task<DisableAvailabilityZonesForLoadBalancerResponse> DisableAvailabilityZonesForLoadBalancerAsync(DisableAvailabilityZonesForLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableAvailabilityZonesForLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<DisableAvailabilityZonesForLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableAvailabilityZonesForLoadBalancer

        internal virtual EnableAvailabilityZonesForLoadBalancerResponse EnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAvailabilityZonesForLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<EnableAvailabilityZonesForLoadBalancerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableAvailabilityZonesForLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAvailabilityZonesForLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/EnableAvailabilityZonesForLoadBalancer">REST API Reference for EnableAvailabilityZonesForLoadBalancer Operation</seealso>
        public virtual Task<EnableAvailabilityZonesForLoadBalancerResponse> EnableAvailabilityZonesForLoadBalancerAsync(EnableAvailabilityZonesForLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAvailabilityZonesForLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<EnableAvailabilityZonesForLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyLoadBalancerAttributes

        internal virtual ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyLoadBalancerAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyLoadBalancerAttributesResponseUnmarshaller.Instance;

            return Invoke<ModifyLoadBalancerAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/ModifyLoadBalancerAttributes">REST API Reference for ModifyLoadBalancerAttributes Operation</seealso>
        public virtual Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributesAsync(ModifyLoadBalancerAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyLoadBalancerAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyLoadBalancerAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyLoadBalancerAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterInstancesWithLoadBalancer

        internal virtual RegisterInstancesWithLoadBalancerResponse RegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterInstancesWithLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterInstancesWithLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<RegisterInstancesWithLoadBalancerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstancesWithLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstancesWithLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/RegisterInstancesWithLoadBalancer">REST API Reference for RegisterInstancesWithLoadBalancer Operation</seealso>
        public virtual Task<RegisterInstancesWithLoadBalancerResponse> RegisterInstancesWithLoadBalancerAsync(RegisterInstancesWithLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterInstancesWithLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterInstancesWithLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterInstancesWithLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags

        internal virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetLoadBalancerListenerSSLCertificate

        internal virtual SetLoadBalancerListenerSSLCertificateResponse SetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLoadBalancerListenerSSLCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.Instance;

            return Invoke<SetLoadBalancerListenerSSLCertificateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerListenerSSLCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerListenerSSLCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/SetLoadBalancerListenerSSLCertificate">REST API Reference for SetLoadBalancerListenerSSLCertificate Operation</seealso>
        public virtual Task<SetLoadBalancerListenerSSLCertificateResponse> SetLoadBalancerListenerSSLCertificateAsync(SetLoadBalancerListenerSSLCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLoadBalancerListenerSSLCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<SetLoadBalancerListenerSSLCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetLoadBalancerPoliciesForBackendServer

        internal virtual SetLoadBalancerPoliciesForBackendServerResponse SetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLoadBalancerPoliciesForBackendServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLoadBalancerPoliciesForBackendServerResponseUnmarshaller.Instance;

            return Invoke<SetLoadBalancerPoliciesForBackendServerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesForBackendServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesForBackendServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/SetLoadBalancerPoliciesForBackendServer">REST API Reference for SetLoadBalancerPoliciesForBackendServer Operation</seealso>
        public virtual Task<SetLoadBalancerPoliciesForBackendServerResponse> SetLoadBalancerPoliciesForBackendServerAsync(SetLoadBalancerPoliciesForBackendServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLoadBalancerPoliciesForBackendServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLoadBalancerPoliciesForBackendServerResponseUnmarshaller.Instance;

            return InvokeAsync<SetLoadBalancerPoliciesForBackendServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetLoadBalancerPoliciesOfListener

        internal virtual SetLoadBalancerPoliciesOfListenerResponse SetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLoadBalancerPoliciesOfListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.Instance;

            return Invoke<SetLoadBalancerPoliciesOfListenerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesOfListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesOfListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/SetLoadBalancerPoliciesOfListener">REST API Reference for SetLoadBalancerPoliciesOfListener Operation</seealso>
        public virtual Task<SetLoadBalancerPoliciesOfListenerResponse> SetLoadBalancerPoliciesOfListenerAsync(SetLoadBalancerPoliciesOfListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetLoadBalancerPoliciesOfListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.Instance;

            return InvokeAsync<SetLoadBalancerPoliciesOfListenerResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}