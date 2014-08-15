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


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations;
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
    /// Elastic Load Balancing is a way to automatically distribute incoming web traffic across
    /// applications that run on multiple Amazon Elastic Compute Cloud (Amazon EC2) instances.
    /// 
    /// </para>
    ///  
    /// <para>
    /// You can create, access, and manage Elastic Load Balancing using the AWS Management
    /// Console or the Elastic Load Balancing API. For more information about Elastic Load
    /// Balancing interfaces, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/SvcIntro_Interfaces.html">Accessing
    /// Elastic Load Balancing</a>.
    /// </para>
    ///  
    /// <para>
    /// This reference guide contains documentation for the Query API and the AWS command
    /// line interface commands, to manage Elastic Load Balancing. 
    /// </para>
    ///  
    /// <para>
    /// For detailed information about Elastic Load Balancing features and their associated
    /// actions or commands, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenarios.html">Managing
    /// Load Balancers</a> in the <i>Elastic Load Balancing Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This reference guide is based on the current WSDL, which is available at: <a href="http://ec2-downloads.s3.amazonaws.com/ElasticLoadBalancing.wsdl"></a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// <b>Endpoints</b>
    /// </para>
    ///  
    /// <para>
    /// The examples in this guide assume that your load balancers are created in the US East
    /// (Northern Virginia) region and use us-east-1 as the endpoint.
    /// </para>
    ///  
    /// <para>
    /// You can create your load balancers in other AWS regions. For information about regions
    /// and endpoints supported by Elastic Load Balancing, see <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">Regions
    /// and Endpoints</a> in the Amazon Web Services General Reference. 
    /// </para>
    /// </summary>
    public partial class AmazonElasticLoadBalancingClient : AmazonWebServiceClient, IAmazonElasticLoadBalancing
    {
        AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

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
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

        
        #region  AddTags

        internal AddTagsResponse AddTags(AddTagsRequest request)
        {
            var task = AddTagsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsRequestMarshaller();
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;
            return Invoke<IRequest, AddTagsRequest, AddTagsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ApplySecurityGroupsToLoadBalancer

        internal ApplySecurityGroupsToLoadBalancerResponse ApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest request)
        {
            var task = ApplySecurityGroupsToLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ApplySecurityGroupsToLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ApplySecurityGroupsToLoadBalancerResponse> ApplySecurityGroupsToLoadBalancerAsync(ApplySecurityGroupsToLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ApplySecurityGroupsToLoadBalancerRequestMarshaller();
            var unmarshaller = ApplySecurityGroupsToLoadBalancerResponseUnmarshaller.Instance;
            return Invoke<IRequest, ApplySecurityGroupsToLoadBalancerRequest, ApplySecurityGroupsToLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  AttachLoadBalancerToSubnets

        internal AttachLoadBalancerToSubnetsResponse AttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest request)
        {
            var task = AttachLoadBalancerToSubnetsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancerToSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AttachLoadBalancerToSubnetsResponse> AttachLoadBalancerToSubnetsAsync(AttachLoadBalancerToSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachLoadBalancerToSubnetsRequestMarshaller();
            var unmarshaller = AttachLoadBalancerToSubnetsResponseUnmarshaller.Instance;
            return Invoke<IRequest, AttachLoadBalancerToSubnetsRequest, AttachLoadBalancerToSubnetsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ConfigureHealthCheck

        internal ConfigureHealthCheckResponse ConfigureHealthCheck(ConfigureHealthCheckRequest request)
        {
            var task = ConfigureHealthCheckAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureHealthCheck operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ConfigureHealthCheckResponse> ConfigureHealthCheckAsync(ConfigureHealthCheckRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ConfigureHealthCheckRequestMarshaller();
            var unmarshaller = ConfigureHealthCheckResponseUnmarshaller.Instance;
            return Invoke<IRequest, ConfigureHealthCheckRequest, ConfigureHealthCheckResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateAppCookieStickinessPolicy

        internal CreateAppCookieStickinessPolicyResponse CreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest request)
        {
            var task = CreateAppCookieStickinessPolicyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateAppCookieStickinessPolicyResponse> CreateAppCookieStickinessPolicyAsync(CreateAppCookieStickinessPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAppCookieStickinessPolicyRequestMarshaller();
            var unmarshaller = CreateAppCookieStickinessPolicyResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateAppCookieStickinessPolicyRequest, CreateAppCookieStickinessPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateLBCookieStickinessPolicy

        internal CreateLBCookieStickinessPolicyResponse CreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest request)
        {
            var task = CreateLBCookieStickinessPolicyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLBCookieStickinessPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateLBCookieStickinessPolicyResponse> CreateLBCookieStickinessPolicyAsync(CreateLBCookieStickinessPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLBCookieStickinessPolicyRequestMarshaller();
            var unmarshaller = CreateLBCookieStickinessPolicyResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateLBCookieStickinessPolicyRequest, CreateLBCookieStickinessPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateLoadBalancer

        internal CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            var task = CreateLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var unmarshaller = CreateLoadBalancerResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateLoadBalancerRequest, CreateLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateLoadBalancerListeners

        internal CreateLoadBalancerListenersResponse CreateLoadBalancerListeners(CreateLoadBalancerListenersRequest request)
        {
            var task = CreateLoadBalancerListenersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateLoadBalancerListenersResponse> CreateLoadBalancerListenersAsync(CreateLoadBalancerListenersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLoadBalancerListenersRequestMarshaller();
            var unmarshaller = CreateLoadBalancerListenersResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateLoadBalancerListenersRequest, CreateLoadBalancerListenersResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  CreateLoadBalancerPolicy

        internal CreateLoadBalancerPolicyResponse CreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest request)
        {
            var task = CreateLoadBalancerPolicyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateLoadBalancerPolicyResponse> CreateLoadBalancerPolicyAsync(CreateLoadBalancerPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLoadBalancerPolicyRequestMarshaller();
            var unmarshaller = CreateLoadBalancerPolicyResponseUnmarshaller.Instance;
            return Invoke<IRequest, CreateLoadBalancerPolicyRequest, CreateLoadBalancerPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteLoadBalancer

        internal DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            var task = DeleteLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLoadBalancerRequestMarshaller();
            var unmarshaller = DeleteLoadBalancerResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteLoadBalancerRequest, DeleteLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteLoadBalancerListeners

        internal DeleteLoadBalancerListenersResponse DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest request)
        {
            var task = DeleteLoadBalancerListenersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerListeners operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListenersAsync(DeleteLoadBalancerListenersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLoadBalancerListenersRequestMarshaller();
            var unmarshaller = DeleteLoadBalancerListenersResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteLoadBalancerListenersRequest, DeleteLoadBalancerListenersResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeleteLoadBalancerPolicy

        internal DeleteLoadBalancerPolicyResponse DeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest request)
        {
            var task = DeleteLoadBalancerPolicyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerPolicy operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteLoadBalancerPolicyResponse> DeleteLoadBalancerPolicyAsync(DeleteLoadBalancerPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLoadBalancerPolicyRequestMarshaller();
            var unmarshaller = DeleteLoadBalancerPolicyResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeleteLoadBalancerPolicyRequest, DeleteLoadBalancerPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DeregisterInstancesFromLoadBalancer

        internal DeregisterInstancesFromLoadBalancerResponse DeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest request)
        {
            var task = DeregisterInstancesFromLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstancesFromLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstancesFromLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeregisterInstancesFromLoadBalancerResponse> DeregisterInstancesFromLoadBalancerAsync(DeregisterInstancesFromLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterInstancesFromLoadBalancerRequestMarshaller();
            var unmarshaller = DeregisterInstancesFromLoadBalancerResponseUnmarshaller.Instance;
            return Invoke<IRequest, DeregisterInstancesFromLoadBalancerRequest, DeregisterInstancesFromLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeInstanceHealth

        internal DescribeInstanceHealthResponse DescribeInstanceHealth(DescribeInstanceHealthRequest request)
        {
            var task = DescribeInstanceHealthAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceHealth operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeInstanceHealthResponse> DescribeInstanceHealthAsync(DescribeInstanceHealthRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstanceHealthRequestMarshaller();
            var unmarshaller = DescribeInstanceHealthResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeInstanceHealthRequest, DescribeInstanceHealthResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeLoadBalancerAttributes

        internal DescribeLoadBalancerAttributesResponse DescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request)
        {
            var task = DescribeLoadBalancerAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerAttributes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLoadBalancerAttributesResponse> DescribeLoadBalancerAttributesAsync(DescribeLoadBalancerAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBalancerAttributesRequestMarshaller();
            var unmarshaller = DescribeLoadBalancerAttributesResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeLoadBalancerAttributesRequest, DescribeLoadBalancerAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeLoadBalancerPolicies

        internal DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies()
        {
            return DescribeLoadBalancerPolicies(new DescribeLoadBalancerPoliciesRequest());
        }
        internal DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest request)
        {
            var task = DescribeLoadBalancerPoliciesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicies operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLoadBalancerPoliciesResponse> DescribeLoadBalancerPoliciesAsync(DescribeLoadBalancerPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBalancerPoliciesRequestMarshaller();
            var unmarshaller = DescribeLoadBalancerPoliciesResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeLoadBalancerPoliciesRequest, DescribeLoadBalancerPoliciesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeLoadBalancerPolicyTypes

        internal DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes()
        {
            return DescribeLoadBalancerPolicyTypes(new DescribeLoadBalancerPolicyTypesRequest());
        }
        internal DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest request)
        {
            var task = DescribeLoadBalancerPolicyTypesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicyTypes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLoadBalancerPolicyTypesResponse> DescribeLoadBalancerPolicyTypesAsync(DescribeLoadBalancerPolicyTypesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBalancerPolicyTypesRequestMarshaller();
            var unmarshaller = DescribeLoadBalancerPolicyTypesResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeLoadBalancerPolicyTypesRequest, DescribeLoadBalancerPolicyTypesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeLoadBalancers

        internal DescribeLoadBalancersResponse DescribeLoadBalancers()
        {
            return DescribeLoadBalancers(new DescribeLoadBalancersRequest());
        }
        internal DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            var task = DescribeLoadBalancersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBalancersRequestMarshaller();
            var unmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeLoadBalancersRequest, DescribeLoadBalancersResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DescribeTags

        internal DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var task = DescribeTagsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DescribeTagsRequest, DescribeTagsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DetachLoadBalancerFromSubnets

        internal DetachLoadBalancerFromSubnetsResponse DetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest request)
        {
            var task = DetachLoadBalancerFromSubnetsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachLoadBalancerFromSubnets operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DetachLoadBalancerFromSubnetsResponse> DetachLoadBalancerFromSubnetsAsync(DetachLoadBalancerFromSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachLoadBalancerFromSubnetsRequestMarshaller();
            var unmarshaller = DetachLoadBalancerFromSubnetsResponseUnmarshaller.Instance;
            return Invoke<IRequest, DetachLoadBalancerFromSubnetsRequest, DetachLoadBalancerFromSubnetsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  DisableAvailabilityZonesForLoadBalancer

        internal DisableAvailabilityZonesForLoadBalancerResponse DisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest request)
        {
            var task = DisableAvailabilityZonesForLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAvailabilityZonesForLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisableAvailabilityZonesForLoadBalancerResponse> DisableAvailabilityZonesForLoadBalancerAsync(DisableAvailabilityZonesForLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableAvailabilityZonesForLoadBalancerRequestMarshaller();
            var unmarshaller = DisableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance;
            return Invoke<IRequest, DisableAvailabilityZonesForLoadBalancerRequest, DisableAvailabilityZonesForLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  EnableAvailabilityZonesForLoadBalancer

        internal EnableAvailabilityZonesForLoadBalancerResponse EnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest request)
        {
            var task = EnableAvailabilityZonesForLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAvailabilityZonesForLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAvailabilityZonesForLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableAvailabilityZonesForLoadBalancerResponse> EnableAvailabilityZonesForLoadBalancerAsync(EnableAvailabilityZonesForLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableAvailabilityZonesForLoadBalancerRequestMarshaller();
            var unmarshaller = EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance;
            return Invoke<IRequest, EnableAvailabilityZonesForLoadBalancerRequest, EnableAvailabilityZonesForLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  ModifyLoadBalancerAttributes

        internal ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request)
        {
            var task = ModifyLoadBalancerAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLoadBalancerAttributes operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributesAsync(ModifyLoadBalancerAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyLoadBalancerAttributesRequestMarshaller();
            var unmarshaller = ModifyLoadBalancerAttributesResponseUnmarshaller.Instance;
            return Invoke<IRequest, ModifyLoadBalancerAttributesRequest, ModifyLoadBalancerAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  RegisterInstancesWithLoadBalancer

        internal RegisterInstancesWithLoadBalancerResponse RegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest request)
        {
            var task = RegisterInstancesWithLoadBalancerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstancesWithLoadBalancer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstancesWithLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RegisterInstancesWithLoadBalancerResponse> RegisterInstancesWithLoadBalancerAsync(RegisterInstancesWithLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterInstancesWithLoadBalancerRequestMarshaller();
            var unmarshaller = RegisterInstancesWithLoadBalancerResponseUnmarshaller.Instance;
            return Invoke<IRequest, RegisterInstancesWithLoadBalancerRequest, RegisterInstancesWithLoadBalancerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  RemoveTags

        internal RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var task = RemoveTagsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveTagsRequestMarshaller();
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;
            return Invoke<IRequest, RemoveTagsRequest, RemoveTagsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  SetLoadBalancerListenerSSLCertificate

        internal SetLoadBalancerListenerSSLCertificateResponse SetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest request)
        {
            var task = SetLoadBalancerListenerSSLCertificateAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerListenerSSLCertificate operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerListenerSSLCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetLoadBalancerListenerSSLCertificateResponse> SetLoadBalancerListenerSSLCertificateAsync(SetLoadBalancerListenerSSLCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetLoadBalancerListenerSSLCertificateRequestMarshaller();
            var unmarshaller = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.Instance;
            return Invoke<IRequest, SetLoadBalancerListenerSSLCertificateRequest, SetLoadBalancerListenerSSLCertificateResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  SetLoadBalancerPoliciesForBackendServer

        internal SetLoadBalancerPoliciesForBackendServerResponse SetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest request)
        {
            var task = SetLoadBalancerPoliciesForBackendServerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesForBackendServer operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesForBackendServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetLoadBalancerPoliciesForBackendServerResponse> SetLoadBalancerPoliciesForBackendServerAsync(SetLoadBalancerPoliciesForBackendServerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetLoadBalancerPoliciesForBackendServerRequestMarshaller();
            var unmarshaller = SetLoadBalancerPoliciesForBackendServerResponseUnmarshaller.Instance;
            return Invoke<IRequest, SetLoadBalancerPoliciesForBackendServerRequest, SetLoadBalancerPoliciesForBackendServerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
        #region  SetLoadBalancerPoliciesOfListener

        internal SetLoadBalancerPoliciesOfListenerResponse SetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest request)
        {
            var task = SetLoadBalancerPoliciesOfListenerAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesOfListener operation.
        /// <seealso cref="Amazon.ElasticLoadBalancing.IAmazonElasticLoadBalancing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesOfListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetLoadBalancerPoliciesOfListenerResponse> SetLoadBalancerPoliciesOfListenerAsync(SetLoadBalancerPoliciesOfListenerRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetLoadBalancerPoliciesOfListenerRequestMarshaller();
            var unmarshaller = SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.Instance;
            return Invoke<IRequest, SetLoadBalancerPoliciesOfListenerRequest, SetLoadBalancerPoliciesOfListenerResponse>(request, marshaller, unmarshaller, signer, cancellationToken);            
        }

        #endregion
        
    }
}