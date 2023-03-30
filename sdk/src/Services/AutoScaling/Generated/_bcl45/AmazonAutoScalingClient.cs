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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AutoScaling.Model;
using Amazon.AutoScaling.Model.Internal.MarshallTransformations;
using Amazon.AutoScaling.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScaling
{
    /// <summary>
    /// Implementation for accessing AutoScaling
    ///
    /// Amazon EC2 Auto Scaling 
    /// <para>
    /// Amazon EC2 Auto Scaling is designed to automatically launch and terminate EC2 instances
    /// based on user-defined scaling policies, scheduled actions, and health checks.
    /// </para>
    ///  
    /// <para>
    /// For more information, see the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/">Amazon
    /// EC2 Auto Scaling User Guide</a> and the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/Welcome.html">Amazon
    /// EC2 Auto Scaling API Reference</a>.
    /// </para>
    /// </summary>
    public partial class AmazonAutoScalingClient : AmazonServiceClient, IAmazonAutoScaling
    {
        private static IServiceMetadata serviceMetadata = new AmazonAutoScalingMetadata();
        private IAutoScalingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAutoScalingPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AutoScalingPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonAutoScalingClient with the credentials loaded from the application's
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
        public AmazonAutoScalingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAutoScalingConfig()) { }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with the credentials loaded from the application's
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
        public AmazonAutoScalingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAutoScalingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(AmazonAutoScalingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAutoScalingClient(AWSCredentials credentials)
            : this(credentials, new AmazonAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAutoScalingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Credentials and an
        /// AmazonAutoScalingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(AWSCredentials credentials, AmazonAutoScalingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAutoScalingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScalingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAutoScalingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAutoScalingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScalingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAutoScalingConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAutoScalingEndpointResolver());
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


        #region  AttachInstances


        /// <summary>
        /// Attaches one or more EC2 instances to the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// When you attach instances, Amazon EC2 Auto Scaling increases the desired capacity
        /// of the group by the number of instances being attached. If the number of instances
        /// being attached plus the desired capacity of the group exceeds the maximum size of
        /// the group, the operation fails.
        /// </para>
        ///  
        /// <para>
        /// If there is a Classic Load Balancer attached to your Auto Scaling group, the instances
        /// are also registered with the load balancer. If there are target groups attached to
        /// your Auto Scaling group, the instances are also registered with the target groups.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/attach-instance-asg.html">Attach
        /// EC2 instances to your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInstances service method.</param>
        /// 
        /// <returns>The response from the AttachInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachInstances">REST API Reference for AttachInstances Operation</seealso>
        public virtual AttachInstancesResponse AttachInstances(AttachInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachInstancesResponseUnmarshaller.Instance;

            return Invoke<AttachInstancesResponse>(request, options);
        }


        /// <summary>
        /// Attaches one or more EC2 instances to the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// When you attach instances, Amazon EC2 Auto Scaling increases the desired capacity
        /// of the group by the number of instances being attached. If the number of instances
        /// being attached plus the desired capacity of the group exceeds the maximum size of
        /// the group, the operation fails.
        /// </para>
        ///  
        /// <para>
        /// If there is a Classic Load Balancer attached to your Auto Scaling group, the instances
        /// are also registered with the load balancer. If there are target groups attached to
        /// your Auto Scaling group, the instances are also registered with the target groups.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/attach-instance-asg.html">Attach
        /// EC2 instances to your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachInstances">REST API Reference for AttachInstances Operation</seealso>
        public virtual Task<AttachInstancesResponse> AttachInstancesAsync(AttachInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<AttachInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachLoadBalancers


        /// <summary>
        /// <note> 
        /// <para>
        /// This API call has been replaced with a new "traffic sources" API call (<code>AttachTrafficSources</code>)
        /// that can attach multiple traffic sources types. While we continue to support <code>AttachLoadBalancers</code>,
        /// and you can use both the original <code>AttachLoadBalancers</code> API call and the
        /// new <code>AttachTrafficSources</code> API call on the same Auto Scaling group, we
        /// recommend using the new "traffic sources" API call to simplify how you manage traffic
        /// sources.
        /// </para>
        ///  </note> 
        /// <para>
        /// Attaches one or more Classic Load Balancers to the specified Auto Scaling group. Amazon
        /// EC2 Auto Scaling registers the running instances with these Classic Load Balancers.
        /// </para>
        ///  
        /// <para>
        /// To describe the load balancers for an Auto Scaling group, call the <a>DescribeLoadBalancers</a>
        /// API. To detach a load balancer from the Auto Scaling group, call the <a>DetachLoadBalancers</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// This operation is additive and does not detach existing Classic Load Balancers or
        /// target groups from the Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Use
        /// Elastic Load Balancing to distribute traffic across the instances in your Auto Scaling
        /// group</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachLoadBalancers">REST API Reference for AttachLoadBalancers Operation</seealso>
        public virtual AttachLoadBalancersResponse AttachLoadBalancers(AttachLoadBalancersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<AttachLoadBalancersResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This API call has been replaced with a new "traffic sources" API call (<code>AttachTrafficSources</code>)
        /// that can attach multiple traffic sources types. While we continue to support <code>AttachLoadBalancers</code>,
        /// and you can use both the original <code>AttachLoadBalancers</code> API call and the
        /// new <code>AttachTrafficSources</code> API call on the same Auto Scaling group, we
        /// recommend using the new "traffic sources" API call to simplify how you manage traffic
        /// sources.
        /// </para>
        ///  </note> 
        /// <para>
        /// Attaches one or more Classic Load Balancers to the specified Auto Scaling group. Amazon
        /// EC2 Auto Scaling registers the running instances with these Classic Load Balancers.
        /// </para>
        ///  
        /// <para>
        /// To describe the load balancers for an Auto Scaling group, call the <a>DescribeLoadBalancers</a>
        /// API. To detach a load balancer from the Auto Scaling group, call the <a>DetachLoadBalancers</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// This operation is additive and does not detach existing Classic Load Balancers or
        /// target groups from the Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Use
        /// Elastic Load Balancing to distribute traffic across the instances in your Auto Scaling
        /// group</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachLoadBalancers">REST API Reference for AttachLoadBalancers Operation</seealso>
        public virtual Task<AttachLoadBalancersResponse> AttachLoadBalancersAsync(AttachLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancersResponseUnmarshaller.Instance;
            
            return InvokeAsync<AttachLoadBalancersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachLoadBalancerTargetGroups


        /// <summary>
        /// <note> 
        /// <para>
        /// This API call has been replaced with a new "traffic sources" API call (<code>AttachTrafficSources</code>)
        /// that can attach multiple traffic sources types. While we continue to support <code>AttachLoadBalancerTargetGroups</code>,
        /// and you can use both the original <code>AttachLoadBalancerTargetGroups</code> API
        /// call and the new <code>AttachTrafficSources</code> API call on the same Auto Scaling
        /// group, we recommend using the new "traffic sources" API call to simplify how you manage
        /// traffic sources.
        /// </para>
        ///  </note> 
        /// <para>
        /// Attaches one or more target groups to the specified Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// This operation is used with the following load balancer types: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Application Load Balancer - Operates at the application layer (layer 7) and supports
        /// HTTP and HTTPS. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Network Load Balancer - Operates at the transport layer (layer 4) and supports TCP,
        /// TLS, and UDP. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Gateway Load Balancer - Operates at the network layer (layer 3).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To describe the target groups for an Auto Scaling group, call the <a>DescribeLoadBalancerTargetGroups</a>
        /// API. To detach the target group from the Auto Scaling group, call the <a>DetachLoadBalancerTargetGroups</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// This operation is additive and does not detach existing target groups or Classic Load
        /// Balancers from the Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Use
        /// Elastic Load Balancing to distribute traffic across the instances in your Auto Scaling
        /// group</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerTargetGroups service method.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachLoadBalancerTargetGroups">REST API Reference for AttachLoadBalancerTargetGroups Operation</seealso>
        public virtual AttachLoadBalancerTargetGroupsResponse AttachLoadBalancerTargetGroups(AttachLoadBalancerTargetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<AttachLoadBalancerTargetGroupsResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This API call has been replaced with a new "traffic sources" API call (<code>AttachTrafficSources</code>)
        /// that can attach multiple traffic sources types. While we continue to support <code>AttachLoadBalancerTargetGroups</code>,
        /// and you can use both the original <code>AttachLoadBalancerTargetGroups</code> API
        /// call and the new <code>AttachTrafficSources</code> API call on the same Auto Scaling
        /// group, we recommend using the new "traffic sources" API call to simplify how you manage
        /// traffic sources.
        /// </para>
        ///  </note> 
        /// <para>
        /// Attaches one or more target groups to the specified Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// This operation is used with the following load balancer types: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Application Load Balancer - Operates at the application layer (layer 7) and supports
        /// HTTP and HTTPS. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Network Load Balancer - Operates at the transport layer (layer 4) and supports TCP,
        /// TLS, and UDP. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Gateway Load Balancer - Operates at the network layer (layer 3).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To describe the target groups for an Auto Scaling group, call the <a>DescribeLoadBalancerTargetGroups</a>
        /// API. To detach the target group from the Auto Scaling group, call the <a>DetachLoadBalancerTargetGroups</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// This operation is additive and does not detach existing target groups or Classic Load
        /// Balancers from the Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Use
        /// Elastic Load Balancing to distribute traffic across the instances in your Auto Scaling
        /// group</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerTargetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachLoadBalancerTargetGroups">REST API Reference for AttachLoadBalancerTargetGroups Operation</seealso>
        public virtual Task<AttachLoadBalancerTargetGroupsResponse> AttachLoadBalancerTargetGroupsAsync(AttachLoadBalancerTargetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancerTargetGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<AttachLoadBalancerTargetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachTrafficSources


        /// <summary>
        /// Attaches one or more traffic sources to the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// You can use any of the following as traffic sources for an Auto Scaling group:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Application Load Balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Classic Load Balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Network Load Balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Gateway Load Balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VPC Lattice
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is additive and does not detach existing traffic sources from the Auto
        /// Scaling group. 
        /// </para>
        ///  
        /// <para>
        /// After the operation completes, use the <a>DescribeTrafficSources</a> API to return
        /// details about the state of the attachments between traffic sources and your Auto Scaling
        /// group. To detach a traffic source from the Auto Scaling group, call the <a>DetachTrafficSources</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachTrafficSources service method.</param>
        /// 
        /// <returns>The response from the AttachTrafficSources service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachTrafficSources">REST API Reference for AttachTrafficSources Operation</seealso>
        public virtual AttachTrafficSourcesResponse AttachTrafficSources(AttachTrafficSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachTrafficSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachTrafficSourcesResponseUnmarshaller.Instance;

            return Invoke<AttachTrafficSourcesResponse>(request, options);
        }


        /// <summary>
        /// Attaches one or more traffic sources to the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// You can use any of the following as traffic sources for an Auto Scaling group:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Application Load Balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Classic Load Balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Network Load Balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Gateway Load Balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VPC Lattice
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is additive and does not detach existing traffic sources from the Auto
        /// Scaling group. 
        /// </para>
        ///  
        /// <para>
        /// After the operation completes, use the <a>DescribeTrafficSources</a> API to return
        /// details about the state of the attachments between traffic sources and your Auto Scaling
        /// group. To detach a traffic source from the Auto Scaling group, call the <a>DetachTrafficSources</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachTrafficSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachTrafficSources service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachTrafficSources">REST API Reference for AttachTrafficSources Operation</seealso>
        public virtual Task<AttachTrafficSourcesResponse> AttachTrafficSourcesAsync(AttachTrafficSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachTrafficSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachTrafficSourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<AttachTrafficSourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteScheduledAction


        /// <summary>
        /// Deletes one or more scheduled actions for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteScheduledAction service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteScheduledAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/BatchDeleteScheduledAction">REST API Reference for BatchDeleteScheduledAction Operation</seealso>
        public virtual BatchDeleteScheduledActionResponse BatchDeleteScheduledAction(BatchDeleteScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteScheduledActionResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteScheduledActionResponse>(request, options);
        }


        /// <summary>
        /// Deletes one or more scheduled actions for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteScheduledAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/BatchDeleteScheduledAction">REST API Reference for BatchDeleteScheduledAction Operation</seealso>
        public virtual Task<BatchDeleteScheduledActionResponse> BatchDeleteScheduledActionAsync(BatchDeleteScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteScheduledActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDeleteScheduledActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchPutScheduledUpdateGroupAction


        /// <summary>
        /// Creates or updates one or more scheduled scaling actions for an Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutScheduledUpdateGroupAction service method.</param>
        /// 
        /// <returns>The response from the BatchPutScheduledUpdateGroupAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/BatchPutScheduledUpdateGroupAction">REST API Reference for BatchPutScheduledUpdateGroupAction Operation</seealso>
        public virtual BatchPutScheduledUpdateGroupActionResponse BatchPutScheduledUpdateGroupAction(BatchPutScheduledUpdateGroupActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutScheduledUpdateGroupActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutScheduledUpdateGroupActionResponseUnmarshaller.Instance;

            return Invoke<BatchPutScheduledUpdateGroupActionResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates one or more scheduled scaling actions for an Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutScheduledUpdateGroupAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutScheduledUpdateGroupAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/BatchPutScheduledUpdateGroupAction">REST API Reference for BatchPutScheduledUpdateGroupAction Operation</seealso>
        public virtual Task<BatchPutScheduledUpdateGroupActionResponse> BatchPutScheduledUpdateGroupActionAsync(BatchPutScheduledUpdateGroupActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutScheduledUpdateGroupActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutScheduledUpdateGroupActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchPutScheduledUpdateGroupActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelInstanceRefresh


        /// <summary>
        /// Cancels an instance refresh or rollback that is in progress. If an instance refresh
        /// or rollback is not in progress, an <code>ActiveInstanceRefreshNotFound</code> error
        /// occurs.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
        /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
        /// your Auto Scaling group after you make configuration changes.
        /// </para>
        ///  
        /// <para>
        /// When you cancel an instance refresh, this does not roll back any changes that it made.
        /// Use the <a>RollbackInstanceRefresh</a> API to roll back instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelInstanceRefresh service method.</param>
        /// 
        /// <returns>The response from the CancelInstanceRefresh service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ActiveInstanceRefreshNotFoundException">
        /// The request failed because an active instance refresh or rollback for the specified
        /// Auto Scaling group was not found.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CancelInstanceRefresh">REST API Reference for CancelInstanceRefresh Operation</seealso>
        public virtual CancelInstanceRefreshResponse CancelInstanceRefresh(CancelInstanceRefreshRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelInstanceRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelInstanceRefreshResponseUnmarshaller.Instance;

            return Invoke<CancelInstanceRefreshResponse>(request, options);
        }


        /// <summary>
        /// Cancels an instance refresh or rollback that is in progress. If an instance refresh
        /// or rollback is not in progress, an <code>ActiveInstanceRefreshNotFound</code> error
        /// occurs.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
        /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
        /// your Auto Scaling group after you make configuration changes.
        /// </para>
        ///  
        /// <para>
        /// When you cancel an instance refresh, this does not roll back any changes that it made.
        /// Use the <a>RollbackInstanceRefresh</a> API to roll back instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelInstanceRefresh service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelInstanceRefresh service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ActiveInstanceRefreshNotFoundException">
        /// The request failed because an active instance refresh or rollback for the specified
        /// Auto Scaling group was not found.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CancelInstanceRefresh">REST API Reference for CancelInstanceRefresh Operation</seealso>
        public virtual Task<CancelInstanceRefreshResponse> CancelInstanceRefreshAsync(CancelInstanceRefreshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelInstanceRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelInstanceRefreshResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelInstanceRefreshResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CompleteLifecycleAction


        /// <summary>
        /// Completes the lifecycle action for the specified token or instance with the specified
        /// result.
        /// 
        ///  
        /// <para>
        /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// (Optional) Create a launch template or launch configuration with a user data script
        /// that runs while an instance is in a wait state due to a lifecycle hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a Lambda function and a rule that allows Amazon EventBridge to invoke
        /// your Lambda function when an instance is put into a wait state due to a lifecycle
        /// hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Amazon EC2 Auto Scaling
        /// to publish lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the lifecycle hook. Specify whether the hook is used when the instances launch
        /// or terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a wait state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If you finish before the timeout period ends, send a callback by using the <a>CompleteLifecycleAction</a>
        /// API call.</b> 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Amazon
        /// EC2 Auto Scaling lifecycle hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteLifecycleAction service method.</param>
        /// 
        /// <returns>The response from the CompleteLifecycleAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CompleteLifecycleAction">REST API Reference for CompleteLifecycleAction Operation</seealso>
        public virtual CompleteLifecycleActionResponse CompleteLifecycleAction(CompleteLifecycleActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteLifecycleActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteLifecycleActionResponseUnmarshaller.Instance;

            return Invoke<CompleteLifecycleActionResponse>(request, options);
        }


        /// <summary>
        /// Completes the lifecycle action for the specified token or instance with the specified
        /// result.
        /// 
        ///  
        /// <para>
        /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// (Optional) Create a launch template or launch configuration with a user data script
        /// that runs while an instance is in a wait state due to a lifecycle hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a Lambda function and a rule that allows Amazon EventBridge to invoke
        /// your Lambda function when an instance is put into a wait state due to a lifecycle
        /// hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Amazon EC2 Auto Scaling
        /// to publish lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the lifecycle hook. Specify whether the hook is used when the instances launch
        /// or terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a wait state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If you finish before the timeout period ends, send a callback by using the <a>CompleteLifecycleAction</a>
        /// API call.</b> 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Amazon
        /// EC2 Auto Scaling lifecycle hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteLifecycleAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CompleteLifecycleAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CompleteLifecycleAction">REST API Reference for CompleteLifecycleAction Operation</seealso>
        public virtual Task<CompleteLifecycleActionResponse> CompleteLifecycleActionAsync(CompleteLifecycleActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteLifecycleActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteLifecycleActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CompleteLifecycleActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAutoScalingGroup


        /// <summary>
        /// <b>We strongly recommend using a launch template when calling this operation to ensure
        /// full functionality for Amazon EC2 Auto Scaling and Amazon EC2.</b> 
        /// 
        ///  
        /// <para>
        /// Creates an Auto Scaling group with the specified name and attributes. 
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of Auto Scaling groups, the call fails. To query
        /// this limit, call the <a>DescribeAccountLimits</a> API. For information about updating
        /// this limit, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-quotas.html">Quotas
        /// for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For introductory exercises for creating an Auto Scaling group, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/GettingStartedTutorial.html">Getting
        /// started with Amazon EC2 Auto Scaling</a> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-register-lbs-with-asg.html">Tutorial:
        /// Set up a scaled and load-balanced application</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/AutoScalingGroup.html">Auto
        /// Scaling groups</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Every Auto Scaling group has three size properties (<code>DesiredCapacity</code>,
        /// <code>MaxSize</code>, and <code>MinSize</code>). Usually, you set these sizes based
        /// on a specific number of instances. However, if you configure a mixed instances policy
        /// that defines weights for the instance types, you must specify these sizes with the
        /// same units that you use for weighting instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateAutoScalingGroup">REST API Reference for CreateAutoScalingGroup Operation</seealso>
        public virtual CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateAutoScalingGroupResponse>(request, options);
        }


        /// <summary>
        /// <b>We strongly recommend using a launch template when calling this operation to ensure
        /// full functionality for Amazon EC2 Auto Scaling and Amazon EC2.</b> 
        /// 
        ///  
        /// <para>
        /// Creates an Auto Scaling group with the specified name and attributes. 
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of Auto Scaling groups, the call fails. To query
        /// this limit, call the <a>DescribeAccountLimits</a> API. For information about updating
        /// this limit, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-quotas.html">Quotas
        /// for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For introductory exercises for creating an Auto Scaling group, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/GettingStartedTutorial.html">Getting
        /// started with Amazon EC2 Auto Scaling</a> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-register-lbs-with-asg.html">Tutorial:
        /// Set up a scaled and load-balanced application</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/AutoScalingGroup.html">Auto
        /// Scaling groups</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Every Auto Scaling group has three size properties (<code>DesiredCapacity</code>,
        /// <code>MaxSize</code>, and <code>MinSize</code>). Usually, you set these sizes based
        /// on a specific number of instances. However, if you configure a mixed instances policy
        /// that defines weights for the instance types, you must specify these sizes with the
        /// same units that you use for weighting instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateAutoScalingGroup">REST API Reference for CreateAutoScalingGroup Operation</seealso>
        public virtual Task<CreateAutoScalingGroupResponse> CreateAutoScalingGroupAsync(CreateAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutoScalingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAutoScalingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLaunchConfiguration


        /// <summary>
        /// Creates a launch configuration.
        /// 
        ///  
        /// <para>
        /// If you exceed your maximum limit of launch configurations, the call fails. To query
        /// this limit, call the <a>DescribeAccountLimits</a> API. For information about updating
        /// this limit, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-quotas.html">Quotas
        /// for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/LaunchConfiguration.html">Launch
        /// configurations</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon EC2 Auto Scaling configures instances launched as part of an Auto Scaling group
        /// using either a launch template or a launch configuration. We strongly recommend that
        /// you do not use launch configurations. They do not provide full functionality for Amazon
        /// EC2 Auto Scaling or Amazon EC2. For information about using launch templates, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/launch-templates.html">Launch
        /// templates</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateLaunchConfiguration">REST API Reference for CreateLaunchConfiguration Operation</seealso>
        public virtual CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateLaunchConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates a launch configuration.
        /// 
        ///  
        /// <para>
        /// If you exceed your maximum limit of launch configurations, the call fails. To query
        /// this limit, call the <a>DescribeAccountLimits</a> API. For information about updating
        /// this limit, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-quotas.html">Quotas
        /// for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/LaunchConfiguration.html">Launch
        /// configurations</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon EC2 Auto Scaling configures instances launched as part of an Auto Scaling group
        /// using either a launch template or a launch configuration. We strongly recommend that
        /// you do not use launch configurations. They do not provide full functionality for Amazon
        /// EC2 Auto Scaling or Amazon EC2. For information about using launch templates, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/launch-templates.html">Launch
        /// templates</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateLaunchConfiguration">REST API Reference for CreateLaunchConfiguration Operation</seealso>
        public virtual Task<CreateLaunchConfigurationResponse> CreateLaunchConfigurationAsync(CreateLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateLaunchConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOrUpdateTags


        /// <summary>
        /// Creates or updates tags for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// When you specify a tag with a key that already exists, the operation overwrites the
        /// previous tag definition, and you do not get an error message.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-tagging.html">Tag
        /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags service method.</param>
        /// 
        /// <returns>The response from the CreateOrUpdateTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateOrUpdateTags">REST API Reference for CreateOrUpdateTags Operation</seealso>
        public virtual CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOrUpdateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOrUpdateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateOrUpdateTagsResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates tags for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// When you specify a tag with a key that already exists, the operation overwrites the
        /// previous tag definition, and you do not get an error message.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-tagging.html">Tag
        /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOrUpdateTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateOrUpdateTags">REST API Reference for CreateOrUpdateTags Operation</seealso>
        public virtual Task<CreateOrUpdateTagsResponse> CreateOrUpdateTagsAsync(CreateOrUpdateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOrUpdateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOrUpdateTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateOrUpdateTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAutoScalingGroup


        /// <summary>
        /// Deletes the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// If the group has instances or scaling activities in progress, you must specify the
        /// option to force the deletion in order for it to succeed. The force delete operation
        /// will also terminate the EC2 instances. If the group has a warm pool, the force delete
        /// option also deletes the warm pool.
        /// </para>
        ///  
        /// <para>
        /// To remove instances from the Auto Scaling group before deleting it, call the <a>DetachInstances</a>
        /// API with the list of instances and the option to decrement the desired capacity. This
        /// ensures that Amazon EC2 Auto Scaling does not launch replacement instances.
        /// </para>
        ///  
        /// <para>
        /// To terminate all instances before deleting the Auto Scaling group, call the <a>UpdateAutoScalingGroup</a>
        /// API and set the minimum size and desired capacity of the Auto Scaling group to zero.
        /// </para>
        ///  
        /// <para>
        /// If the group has scaling policies, deleting the group deletes the policies, the underlying
        /// alarm actions, and any alarm that no longer has an associated action.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-process-shutdown.html">Delete
        /// your Auto Scaling infrastructure</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteAutoScalingGroup">REST API Reference for DeleteAutoScalingGroup Operation</seealso>
        public virtual DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteAutoScalingGroupResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// If the group has instances or scaling activities in progress, you must specify the
        /// option to force the deletion in order for it to succeed. The force delete operation
        /// will also terminate the EC2 instances. If the group has a warm pool, the force delete
        /// option also deletes the warm pool.
        /// </para>
        ///  
        /// <para>
        /// To remove instances from the Auto Scaling group before deleting it, call the <a>DetachInstances</a>
        /// API with the list of instances and the option to decrement the desired capacity. This
        /// ensures that Amazon EC2 Auto Scaling does not launch replacement instances.
        /// </para>
        ///  
        /// <para>
        /// To terminate all instances before deleting the Auto Scaling group, call the <a>UpdateAutoScalingGroup</a>
        /// API and set the minimum size and desired capacity of the Auto Scaling group to zero.
        /// </para>
        ///  
        /// <para>
        /// If the group has scaling policies, deleting the group deletes the policies, the underlying
        /// alarm actions, and any alarm that no longer has an associated action.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-process-shutdown.html">Delete
        /// your Auto Scaling infrastructure</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteAutoScalingGroup">REST API Reference for DeleteAutoScalingGroup Operation</seealso>
        public virtual Task<DeleteAutoScalingGroupResponse> DeleteAutoScalingGroupAsync(DeleteAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutoScalingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAutoScalingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLaunchConfiguration


        /// <summary>
        /// Deletes the specified launch configuration.
        /// 
        ///  
        /// <para>
        /// The launch configuration must not be attached to an Auto Scaling group. When this
        /// call completes, the launch configuration is no longer available for use.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteLaunchConfiguration">REST API Reference for DeleteLaunchConfiguration Operation</seealso>
        public virtual DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLaunchConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified launch configuration.
        /// 
        ///  
        /// <para>
        /// The launch configuration must not be attached to an Auto Scaling group. When this
        /// call completes, the launch configuration is no longer available for use.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteLaunchConfiguration">REST API Reference for DeleteLaunchConfiguration Operation</seealso>
        public virtual Task<DeleteLaunchConfigurationResponse> DeleteLaunchConfigurationAsync(DeleteLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLaunchConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLifecycleHook


        /// <summary>
        /// Deletes the specified lifecycle hook.
        /// 
        ///  
        /// <para>
        /// If there are any outstanding lifecycle actions, they are completed first (<code>ABANDON</code>
        /// for launching instances, <code>CONTINUE</code> for terminating instances).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleHook service method.</param>
        /// 
        /// <returns>The response from the DeleteLifecycleHook service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteLifecycleHook">REST API Reference for DeleteLifecycleHook Operation</seealso>
        public virtual DeleteLifecycleHookResponse DeleteLifecycleHook(DeleteLifecycleHookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecycleHookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecycleHookResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecycleHookResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified lifecycle hook.
        /// 
        ///  
        /// <para>
        /// If there are any outstanding lifecycle actions, they are completed first (<code>ABANDON</code>
        /// for launching instances, <code>CONTINUE</code> for terminating instances).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleHook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLifecycleHook service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteLifecycleHook">REST API Reference for DeleteLifecycleHook Operation</seealso>
        public virtual Task<DeleteLifecycleHookResponse> DeleteLifecycleHookAsync(DeleteLifecycleHookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecycleHookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecycleHookResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLifecycleHookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotificationConfiguration


        /// <summary>
        /// Deletes the specified notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteNotificationConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        public virtual DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotificationConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        public virtual Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Deletes the specified scaling policy.
        /// 
        ///  
        /// <para>
        /// Deleting either a step scaling policy or a simple scaling policy deletes the underlying
        /// alarm action, but does not delete the alarm, even if it no longer has an associated
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/deleting-scaling-policy.html">Deleting
        /// a scaling policy</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified scaling policy.
        /// 
        ///  
        /// <para>
        /// Deleting either a step scaling policy or a simple scaling policy deletes the underlying
        /// alarm action, but does not delete the alarm, even if it no longer has an associated
        /// action.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/deleting-scaling-policy.html">Deleting
        /// a scaling policy</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteScheduledAction


        /// <summary>
        /// Deletes the specified scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method.</param>
        /// 
        /// <returns>The response from the DeleteScheduledAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduledActionResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScheduledAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteScheduledActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Deletes the specified tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWarmPool


        /// <summary>
        /// Deletes the warm pool for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-warm-pools.html">Warm
        /// pools for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWarmPool service method.</param>
        /// 
        /// <returns>The response from the DeleteWarmPool service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteWarmPool">REST API Reference for DeleteWarmPool Operation</seealso>
        public virtual DeleteWarmPoolResponse DeleteWarmPool(DeleteWarmPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWarmPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWarmPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteWarmPoolResponse>(request, options);
        }


        /// <summary>
        /// Deletes the warm pool for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-warm-pools.html">Warm
        /// pools for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWarmPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWarmPool service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteWarmPool">REST API Reference for DeleteWarmPool Operation</seealso>
        public virtual Task<DeleteWarmPoolResponse> DeleteWarmPoolAsync(DeleteWarmPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWarmPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWarmPoolResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWarmPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountLimits


        /// <summary>
        /// Describes the current Amazon EC2 Auto Scaling resource quotas for your account.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial quotas
        /// on the maximum number of Auto Scaling groups and launch configurations that you can
        /// create in a given Region. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-quotas.html">Quotas
        /// for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual DescribeAccountLimitsResponse DescribeAccountLimits()
        {
            return DescribeAccountLimits(new DescribeAccountLimitsRequest());
        }


        /// <summary>
        /// Describes the current Amazon EC2 Auto Scaling resource quotas for your account.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial quotas
        /// on the maximum number of Auto Scaling groups and launch configurations that you can
        /// create in a given Region. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-quotas.html">Quotas
        /// for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountLimitsResponse>(request, options);
        }


        /// <summary>
        /// Describes the current Amazon EC2 Auto Scaling resource quotas for your account.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial quotas
        /// on the maximum number of Auto Scaling groups and launch configurations that you can
        /// create in a given Region. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-quotas.html">Quotas
        /// for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAccountLimitsAsync(new DescribeAccountLimitsRequest(), cancellationToken);
        }

        /// <summary>
        /// Describes the current Amazon EC2 Auto Scaling resource quotas for your account.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial quotas
        /// on the maximum number of Auto Scaling groups and launch configurations that you can
        /// create in a given Region. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-quotas.html">Quotas
        /// for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccountLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAdjustmentTypes


        /// <summary>
        /// Describes the available adjustment types for step scaling and simple scaling policies.
        /// 
        ///  
        /// <para>
        /// The following adjustment types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ChangeInCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ExactCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PercentChangeInCapacity</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAdjustmentTypes">REST API Reference for DescribeAdjustmentTypes Operation</seealso>
        public virtual DescribeAdjustmentTypesResponse DescribeAdjustmentTypes()
        {
            return DescribeAdjustmentTypes(new DescribeAdjustmentTypesRequest());
        }


        /// <summary>
        /// Describes the available adjustment types for step scaling and simple scaling policies.
        /// 
        ///  
        /// <para>
        /// The following adjustment types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ChangeInCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ExactCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PercentChangeInCapacity</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAdjustmentTypes">REST API Reference for DescribeAdjustmentTypes Operation</seealso>
        public virtual DescribeAdjustmentTypesResponse DescribeAdjustmentTypes(DescribeAdjustmentTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAdjustmentTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAdjustmentTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeAdjustmentTypesResponse>(request, options);
        }


        /// <summary>
        /// Describes the available adjustment types for step scaling and simple scaling policies.
        /// 
        ///  
        /// <para>
        /// The following adjustment types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ChangeInCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ExactCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PercentChangeInCapacity</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAdjustmentTypes">REST API Reference for DescribeAdjustmentTypes Operation</seealso>
        public virtual Task<DescribeAdjustmentTypesResponse> DescribeAdjustmentTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAdjustmentTypesAsync(new DescribeAdjustmentTypesRequest(), cancellationToken);
        }

        /// <summary>
        /// Describes the available adjustment types for step scaling and simple scaling policies.
        /// 
        ///  
        /// <para>
        /// The following adjustment types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ChangeInCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ExactCapacity</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PercentChangeInCapacity</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAdjustmentTypes">REST API Reference for DescribeAdjustmentTypes Operation</seealso>
        public virtual Task<DescribeAdjustmentTypesResponse> DescribeAdjustmentTypesAsync(DescribeAdjustmentTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAdjustmentTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAdjustmentTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAdjustmentTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutoScalingGroups


        /// <summary>
        /// Gets information about the Auto Scaling groups in the account and Region.
        /// 
        ///  
        /// <para>
        /// If you specify Auto Scaling group names, the output includes information for only
        /// the specified Auto Scaling groups. If you specify filters, the output includes information
        /// for only those Auto Scaling groups that meet the filter criteria. If you do not specify
        /// group names or filters, the output includes information for all Auto Scaling groups.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This operation also returns information about instances in Auto Scaling groups. To
        /// retrieve information about the instances in a warm pool, you must call the <a>DescribeWarmPool</a>
        /// API. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingGroups">REST API Reference for DescribeAutoScalingGroups Operation</seealso>
        public virtual DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups()
        {
            return DescribeAutoScalingGroups(new DescribeAutoScalingGroupsRequest());
        }


        /// <summary>
        /// Gets information about the Auto Scaling groups in the account and Region.
        /// 
        ///  
        /// <para>
        /// If you specify Auto Scaling group names, the output includes information for only
        /// the specified Auto Scaling groups. If you specify filters, the output includes information
        /// for only those Auto Scaling groups that meet the filter criteria. If you do not specify
        /// group names or filters, the output includes information for all Auto Scaling groups.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This operation also returns information about instances in Auto Scaling groups. To
        /// retrieve information about the instances in a warm pool, you must call the <a>DescribeWarmPool</a>
        /// API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingGroups">REST API Reference for DescribeAutoScalingGroups Operation</seealso>
        public virtual DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoScalingGroupsResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the Auto Scaling groups in the account and Region.
        /// 
        ///  
        /// <para>
        /// If you specify Auto Scaling group names, the output includes information for only
        /// the specified Auto Scaling groups. If you specify filters, the output includes information
        /// for only those Auto Scaling groups that meet the filter criteria. If you do not specify
        /// group names or filters, the output includes information for all Auto Scaling groups.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This operation also returns information about instances in Auto Scaling groups. To
        /// retrieve information about the instances in a warm pool, you must call the <a>DescribeWarmPool</a>
        /// API. 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingGroups">REST API Reference for DescribeAutoScalingGroups Operation</seealso>
        public virtual Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAutoScalingGroupsAsync(new DescribeAutoScalingGroupsRequest(), cancellationToken);
        }

        /// <summary>
        /// Gets information about the Auto Scaling groups in the account and Region.
        /// 
        ///  
        /// <para>
        /// If you specify Auto Scaling group names, the output includes information for only
        /// the specified Auto Scaling groups. If you specify filters, the output includes information
        /// for only those Auto Scaling groups that meet the filter criteria. If you do not specify
        /// group names or filters, the output includes information for all Auto Scaling groups.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This operation also returns information about instances in Auto Scaling groups. To
        /// retrieve information about the instances in a warm pool, you must call the <a>DescribeWarmPool</a>
        /// API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingGroups">REST API Reference for DescribeAutoScalingGroups Operation</seealso>
        public virtual Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroupsAsync(DescribeAutoScalingGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAutoScalingGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutoScalingInstances


        /// <summary>
        /// Gets information about the Auto Scaling instances in the account and Region.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingInstances">REST API Reference for DescribeAutoScalingInstances Operation</seealso>
        public virtual DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances()
        {
            return DescribeAutoScalingInstances(new DescribeAutoScalingInstancesRequest());
        }


        /// <summary>
        /// Gets information about the Auto Scaling instances in the account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingInstances">REST API Reference for DescribeAutoScalingInstances Operation</seealso>
        public virtual DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoScalingInstancesResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the Auto Scaling instances in the account and Region.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingInstances">REST API Reference for DescribeAutoScalingInstances Operation</seealso>
        public virtual Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAutoScalingInstancesAsync(new DescribeAutoScalingInstancesRequest(), cancellationToken);
        }

        /// <summary>
        /// Gets information about the Auto Scaling instances in the account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingInstances">REST API Reference for DescribeAutoScalingInstances Operation</seealso>
        public virtual Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstancesAsync(DescribeAutoScalingInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAutoScalingInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutoScalingNotificationTypes


        /// <summary>
        /// Describes the notification types that are supported by Amazon EC2 Auto Scaling.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingNotificationTypes">REST API Reference for DescribeAutoScalingNotificationTypes Operation</seealso>
        public virtual DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes()
        {
            return DescribeAutoScalingNotificationTypes(new DescribeAutoScalingNotificationTypesRequest());
        }


        /// <summary>
        /// Describes the notification types that are supported by Amazon EC2 Auto Scaling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingNotificationTypes">REST API Reference for DescribeAutoScalingNotificationTypes Operation</seealso>
        public virtual DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingNotificationTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingNotificationTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoScalingNotificationTypesResponse>(request, options);
        }


        /// <summary>
        /// Describes the notification types that are supported by Amazon EC2 Auto Scaling.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingNotificationTypes">REST API Reference for DescribeAutoScalingNotificationTypes Operation</seealso>
        public virtual Task<DescribeAutoScalingNotificationTypesResponse> DescribeAutoScalingNotificationTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAutoScalingNotificationTypesAsync(new DescribeAutoScalingNotificationTypesRequest(), cancellationToken);
        }

        /// <summary>
        /// Describes the notification types that are supported by Amazon EC2 Auto Scaling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingNotificationTypes">REST API Reference for DescribeAutoScalingNotificationTypes Operation</seealso>
        public virtual Task<DescribeAutoScalingNotificationTypesResponse> DescribeAutoScalingNotificationTypesAsync(DescribeAutoScalingNotificationTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingNotificationTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingNotificationTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAutoScalingNotificationTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceRefreshes


        /// <summary>
        /// Gets information about the instance refreshes for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
        /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
        /// your Auto Scaling group after you make configuration changes.
        /// </para>
        ///  
        /// <para>
        /// To help you determine the status of an instance refresh, Amazon EC2 Auto Scaling returns
        /// information about the instance refreshes you previously initiated, including their
        /// status, start time, end time, the percentage of the instance refresh that is complete,
        /// and the number of instances remaining to update before the instance refresh is complete.
        /// If a rollback is initiated while an instance refresh is in progress, Amazon EC2 Auto
        /// Scaling also returns information about the rollback of the instance refresh.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceRefreshes service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceRefreshes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeInstanceRefreshes">REST API Reference for DescribeInstanceRefreshes Operation</seealso>
        public virtual DescribeInstanceRefreshesResponse DescribeInstanceRefreshes(DescribeInstanceRefreshesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceRefreshesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceRefreshesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceRefreshesResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the instance refreshes for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
        /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
        /// your Auto Scaling group after you make configuration changes.
        /// </para>
        ///  
        /// <para>
        /// To help you determine the status of an instance refresh, Amazon EC2 Auto Scaling returns
        /// information about the instance refreshes you previously initiated, including their
        /// status, start time, end time, the percentage of the instance refresh that is complete,
        /// and the number of instances remaining to update before the instance refresh is complete.
        /// If a rollback is initiated while an instance refresh is in progress, Amazon EC2 Auto
        /// Scaling also returns information about the rollback of the instance refresh.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceRefreshes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceRefreshes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeInstanceRefreshes">REST API Reference for DescribeInstanceRefreshes Operation</seealso>
        public virtual Task<DescribeInstanceRefreshesResponse> DescribeInstanceRefreshesAsync(DescribeInstanceRefreshesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceRefreshesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceRefreshesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeInstanceRefreshesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLaunchConfigurations


        /// <summary>
        /// Gets information about the launch configurations in the account and Region.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLaunchConfigurations">REST API Reference for DescribeLaunchConfigurations Operation</seealso>
        public virtual DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations()
        {
            return DescribeLaunchConfigurations(new DescribeLaunchConfigurationsRequest());
        }


        /// <summary>
        /// Gets information about the launch configurations in the account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLaunchConfigurations">REST API Reference for DescribeLaunchConfigurations Operation</seealso>
        public virtual DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeLaunchConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the launch configurations in the account and Region.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLaunchConfigurations">REST API Reference for DescribeLaunchConfigurations Operation</seealso>
        public virtual Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeLaunchConfigurationsAsync(new DescribeLaunchConfigurationsRequest(), cancellationToken);
        }

        /// <summary>
        /// Gets information about the launch configurations in the account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLaunchConfigurations">REST API Reference for DescribeLaunchConfigurations Operation</seealso>
        public virtual Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurationsAsync(DescribeLaunchConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeLaunchConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLifecycleHooks


        /// <summary>
        /// Gets information about the lifecycle hooks for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHooks service method.</param>
        /// 
        /// <returns>The response from the DescribeLifecycleHooks service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLifecycleHooks">REST API Reference for DescribeLifecycleHooks Operation</seealso>
        public virtual DescribeLifecycleHooksResponse DescribeLifecycleHooks(DescribeLifecycleHooksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLifecycleHooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLifecycleHooksResponseUnmarshaller.Instance;

            return Invoke<DescribeLifecycleHooksResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the lifecycle hooks for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHooks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLifecycleHooks service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLifecycleHooks">REST API Reference for DescribeLifecycleHooks Operation</seealso>
        public virtual Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooksAsync(DescribeLifecycleHooksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLifecycleHooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLifecycleHooksResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeLifecycleHooksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLifecycleHookTypes


        /// <summary>
        /// Describes the available types of lifecycle hooks.
        /// 
        ///  
        /// <para>
        /// The following hook types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>autoscaling:EC2_INSTANCE_LAUNCHING</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>autoscaling:EC2_INSTANCE_TERMINATING</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHookTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeLifecycleHookTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLifecycleHookTypes">REST API Reference for DescribeLifecycleHookTypes Operation</seealso>
        public virtual DescribeLifecycleHookTypesResponse DescribeLifecycleHookTypes(DescribeLifecycleHookTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLifecycleHookTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLifecycleHookTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeLifecycleHookTypesResponse>(request, options);
        }


        /// <summary>
        /// Describes the available types of lifecycle hooks.
        /// 
        ///  
        /// <para>
        /// The following hook types are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>autoscaling:EC2_INSTANCE_LAUNCHING</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>autoscaling:EC2_INSTANCE_TERMINATING</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHookTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLifecycleHookTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLifecycleHookTypes">REST API Reference for DescribeLifecycleHookTypes Operation</seealso>
        public virtual Task<DescribeLifecycleHookTypesResponse> DescribeLifecycleHookTypesAsync(DescribeLifecycleHookTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLifecycleHookTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLifecycleHookTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeLifecycleHookTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancers


        /// <summary>
        /// <note> 
        /// <para>
        /// This API call has been replaced with a new "traffic sources" API call (<code>DescribeTrafficSources</code>)
        /// that can describe multiple traffic sources types. While we continue to support <code>DescribeLoadBalancers</code>,
        /// and you can use both the original <code>DescribeLoadBalancers</code> API call and
        /// the new <code>DescribeTrafficSources</code> API call on the same Auto Scaling group,
        /// we recommend using the new "traffic sources" API call to simplify how you manage traffic
        /// sources.
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets information about the load balancers for the specified Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// This operation describes only Classic Load Balancers. If you have Application Load
        /// Balancers, Network Load Balancers, or Gateway Load Balancers, use the <a>DescribeLoadBalancerTargetGroups</a>
        /// API instead.
        /// </para>
        ///  
        /// <para>
        /// To determine the attachment status of the load balancer, use the <code>State</code>
        /// element in the response. When you attach a load balancer to an Auto Scaling group,
        /// the initial <code>State</code> value is <code>Adding</code>. The state transitions
        /// to <code>Added</code> after all Auto Scaling instances are registered with the load
        /// balancer. If Elastic Load Balancing health checks are enabled for the Auto Scaling
        /// group, the state transitions to <code>InService</code> after at least one Auto Scaling
        /// instance passes the health check. When the load balancer is in the <code>InService</code>
        /// state, Amazon EC2 Auto Scaling can terminate and replace any instances that are reported
        /// as unhealthy. If no registered instances pass the health checks, the load balancer
        /// doesn't enter the <code>InService</code> state. 
        /// </para>
        ///  
        /// <para>
        /// Load balancers also have an <code>InService</code> state if you attach them in the
        /// <a>CreateAutoScalingGroup</a> API call. If your load balancer state is <code>InService</code>,
        /// but it is not working properly, check the scaling activities by calling <a>DescribeScalingActivities</a>
        /// and take any corrective actions necessary.
        /// </para>
        ///  
        /// <para>
        /// For help with failed health checks, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ts-as-healthchecks.html">Troubleshooting
        /// Amazon EC2 Auto Scaling: Health checks</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Use
        /// Elastic Load Balancing to distribute traffic across the instances in your Auto Scaling
        /// group</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        public virtual DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancersResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This API call has been replaced with a new "traffic sources" API call (<code>DescribeTrafficSources</code>)
        /// that can describe multiple traffic sources types. While we continue to support <code>DescribeLoadBalancers</code>,
        /// and you can use both the original <code>DescribeLoadBalancers</code> API call and
        /// the new <code>DescribeTrafficSources</code> API call on the same Auto Scaling group,
        /// we recommend using the new "traffic sources" API call to simplify how you manage traffic
        /// sources.
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets information about the load balancers for the specified Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// This operation describes only Classic Load Balancers. If you have Application Load
        /// Balancers, Network Load Balancers, or Gateway Load Balancers, use the <a>DescribeLoadBalancerTargetGroups</a>
        /// API instead.
        /// </para>
        ///  
        /// <para>
        /// To determine the attachment status of the load balancer, use the <code>State</code>
        /// element in the response. When you attach a load balancer to an Auto Scaling group,
        /// the initial <code>State</code> value is <code>Adding</code>. The state transitions
        /// to <code>Added</code> after all Auto Scaling instances are registered with the load
        /// balancer. If Elastic Load Balancing health checks are enabled for the Auto Scaling
        /// group, the state transitions to <code>InService</code> after at least one Auto Scaling
        /// instance passes the health check. When the load balancer is in the <code>InService</code>
        /// state, Amazon EC2 Auto Scaling can terminate and replace any instances that are reported
        /// as unhealthy. If no registered instances pass the health checks, the load balancer
        /// doesn't enter the <code>InService</code> state. 
        /// </para>
        ///  
        /// <para>
        /// Load balancers also have an <code>InService</code> state if you attach them in the
        /// <a>CreateAutoScalingGroup</a> API call. If your load balancer state is <code>InService</code>,
        /// but it is not working properly, check the scaling activities by calling <a>DescribeScalingActivities</a>
        /// and take any corrective actions necessary.
        /// </para>
        ///  
        /// <para>
        /// For help with failed health checks, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ts-as-healthchecks.html">Troubleshooting
        /// Amazon EC2 Auto Scaling: Health checks</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Use
        /// Elastic Load Balancing to distribute traffic across the instances in your Auto Scaling
        /// group</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        public virtual Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeLoadBalancersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancerTargetGroups


        /// <summary>
        /// <note> 
        /// <para>
        /// This API call has been replaced with a new "traffic sources" API call (<code>DescribeTrafficSources</code>)
        /// that can describe multiple traffic sources types. While we continue to support <code>DescribeLoadBalancerTargetGroups</code>,
        /// and you can use both the original <code>DescribeLoadBalancerTargetGroups</code> API
        /// call and the new <code>DescribeTrafficSources</code> API call on the same Auto Scaling
        /// group, we recommend using the new "traffic sources" API call to simplify how you manage
        /// traffic sources.
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets information about the Elastic Load Balancing target groups for the specified
        /// Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// To determine the attachment status of the target group, use the <code>State</code>
        /// element in the response. When you attach a target group to an Auto Scaling group,
        /// the initial <code>State</code> value is <code>Adding</code>. The state transitions
        /// to <code>Added</code> after all Auto Scaling instances are registered with the target
        /// group. If Elastic Load Balancing health checks are enabled for the Auto Scaling group,
        /// the state transitions to <code>InService</code> after at least one Auto Scaling instance
        /// passes the health check. When the target group is in the <code>InService</code> state,
        /// Amazon EC2 Auto Scaling can terminate and replace any instances that are reported
        /// as unhealthy. If no registered instances pass the health checks, the target group
        /// doesn't enter the <code>InService</code> state. 
        /// </para>
        ///  
        /// <para>
        /// Target groups also have an <code>InService</code> state if you attach them in the
        /// <a>CreateAutoScalingGroup</a> API call. If your target group state is <code>InService</code>,
        /// but it is not working properly, check the scaling activities by calling <a>DescribeScalingActivities</a>
        /// and take any corrective actions necessary.
        /// </para>
        ///  
        /// <para>
        /// For help with failed health checks, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ts-as-healthchecks.html">Troubleshooting
        /// Amazon EC2 Auto Scaling: Health checks</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Use
        /// Elastic Load Balancing to distribute traffic across the instances in your Auto Scaling
        /// group</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use this operation to describe target groups that were attached by using <a>AttachLoadBalancerTargetGroups</a>,
        /// but not for target groups that were attached by using <a>AttachTrafficSources</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerTargetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLoadBalancerTargetGroups">REST API Reference for DescribeLoadBalancerTargetGroups Operation</seealso>
        public virtual DescribeLoadBalancerTargetGroupsResponse DescribeLoadBalancerTargetGroups(DescribeLoadBalancerTargetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancerTargetGroupsResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This API call has been replaced with a new "traffic sources" API call (<code>DescribeTrafficSources</code>)
        /// that can describe multiple traffic sources types. While we continue to support <code>DescribeLoadBalancerTargetGroups</code>,
        /// and you can use both the original <code>DescribeLoadBalancerTargetGroups</code> API
        /// call and the new <code>DescribeTrafficSources</code> API call on the same Auto Scaling
        /// group, we recommend using the new "traffic sources" API call to simplify how you manage
        /// traffic sources.
        /// </para>
        ///  </note> 
        /// <para>
        /// Gets information about the Elastic Load Balancing target groups for the specified
        /// Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// To determine the attachment status of the target group, use the <code>State</code>
        /// element in the response. When you attach a target group to an Auto Scaling group,
        /// the initial <code>State</code> value is <code>Adding</code>. The state transitions
        /// to <code>Added</code> after all Auto Scaling instances are registered with the target
        /// group. If Elastic Load Balancing health checks are enabled for the Auto Scaling group,
        /// the state transitions to <code>InService</code> after at least one Auto Scaling instance
        /// passes the health check. When the target group is in the <code>InService</code> state,
        /// Amazon EC2 Auto Scaling can terminate and replace any instances that are reported
        /// as unhealthy. If no registered instances pass the health checks, the target group
        /// doesn't enter the <code>InService</code> state. 
        /// </para>
        ///  
        /// <para>
        /// Target groups also have an <code>InService</code> state if you attach them in the
        /// <a>CreateAutoScalingGroup</a> API call. If your target group state is <code>InService</code>,
        /// but it is not working properly, check the scaling activities by calling <a>DescribeScalingActivities</a>
        /// and take any corrective actions necessary.
        /// </para>
        ///  
        /// <para>
        /// For help with failed health checks, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ts-as-healthchecks.html">Troubleshooting
        /// Amazon EC2 Auto Scaling: Health checks</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Use
        /// Elastic Load Balancing to distribute traffic across the instances in your Auto Scaling
        /// group</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use this operation to describe target groups that were attached by using <a>AttachLoadBalancerTargetGroups</a>,
        /// but not for target groups that were attached by using <a>AttachTrafficSources</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerTargetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLoadBalancerTargetGroups">REST API Reference for DescribeLoadBalancerTargetGroups Operation</seealso>
        public virtual Task<DescribeLoadBalancerTargetGroupsResponse> DescribeLoadBalancerTargetGroupsAsync(DescribeLoadBalancerTargetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancerTargetGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeLoadBalancerTargetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMetricCollectionTypes


        /// <summary>
        /// Describes the available CloudWatch metrics for Amazon EC2 Auto Scaling.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeMetricCollectionTypes">REST API Reference for DescribeMetricCollectionTypes Operation</seealso>
        public virtual DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes()
        {
            return DescribeMetricCollectionTypes(new DescribeMetricCollectionTypesRequest());
        }


        /// <summary>
        /// Describes the available CloudWatch metrics for Amazon EC2 Auto Scaling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeMetricCollectionTypes">REST API Reference for DescribeMetricCollectionTypes Operation</seealso>
        public virtual DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetricCollectionTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetricCollectionTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeMetricCollectionTypesResponse>(request, options);
        }


        /// <summary>
        /// Describes the available CloudWatch metrics for Amazon EC2 Auto Scaling.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeMetricCollectionTypes">REST API Reference for DescribeMetricCollectionTypes Operation</seealso>
        public virtual Task<DescribeMetricCollectionTypesResponse> DescribeMetricCollectionTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeMetricCollectionTypesAsync(new DescribeMetricCollectionTypesRequest(), cancellationToken);
        }

        /// <summary>
        /// Describes the available CloudWatch metrics for Amazon EC2 Auto Scaling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeMetricCollectionTypes">REST API Reference for DescribeMetricCollectionTypes Operation</seealso>
        public virtual Task<DescribeMetricCollectionTypesResponse> DescribeMetricCollectionTypesAsync(DescribeMetricCollectionTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetricCollectionTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetricCollectionTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeMetricCollectionTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNotificationConfigurations


        /// <summary>
        /// Gets information about the Amazon SNS notifications that are configured for one or
        /// more Auto Scaling groups.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeNotificationConfigurations">REST API Reference for DescribeNotificationConfigurations Operation</seealso>
        public virtual DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations()
        {
            return DescribeNotificationConfigurations(new DescribeNotificationConfigurationsRequest());
        }


        /// <summary>
        /// Gets information about the Amazon SNS notifications that are configured for one or
        /// more Auto Scaling groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeNotificationConfigurations">REST API Reference for DescribeNotificationConfigurations Operation</seealso>
        public virtual DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeNotificationConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the Amazon SNS notifications that are configured for one or
        /// more Auto Scaling groups.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeNotificationConfigurations">REST API Reference for DescribeNotificationConfigurations Operation</seealso>
        public virtual Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeNotificationConfigurationsAsync(new DescribeNotificationConfigurationsRequest(), cancellationToken);
        }

        /// <summary>
        /// Gets information about the Amazon SNS notifications that are configured for one or
        /// more Auto Scaling groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeNotificationConfigurations">REST API Reference for DescribeNotificationConfigurations Operation</seealso>
        public virtual Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(DescribeNotificationConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeNotificationConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePolicies


        /// <summary>
        /// Gets information about the scaling policies in the account and Region.
        /// </summary>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribePolicies">REST API Reference for DescribePolicies Operation</seealso>
        public virtual DescribePoliciesResponse DescribePolicies()
        {
            return DescribePolicies(new DescribePoliciesRequest());
        }


        /// <summary>
        /// Gets information about the scaling policies in the account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies service method.</param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribePolicies">REST API Reference for DescribePolicies Operation</seealso>
        public virtual DescribePoliciesResponse DescribePolicies(DescribePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribePoliciesResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the scaling policies in the account and Region.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribePolicies">REST API Reference for DescribePolicies Operation</seealso>
        public virtual Task<DescribePoliciesResponse> DescribePoliciesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribePoliciesAsync(new DescribePoliciesRequest(), cancellationToken);
        }

        /// <summary>
        /// Gets information about the scaling policies in the account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribePolicies">REST API Reference for DescribePolicies Operation</seealso>
        public virtual Task<DescribePoliciesResponse> DescribePoliciesAsync(DescribePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePoliciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingActivities


        /// <summary>
        /// Gets information about the scaling activities in the account and Region.
        /// 
        ///  
        /// <para>
        /// When scaling events occur, you see a record of the scaling activity in the scaling
        /// activities. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-verify-scaling-activity.html">Verifying
        /// a scaling activity for an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the scaling event succeeds, the value of the <code>StatusCode</code> element in
        /// the response is <code>Successful</code>. If an attempt to launch instances failed,
        /// the <code>StatusCode</code> value is <code>Failed</code> or <code>Cancelled</code>
        /// and the <code>StatusMessage</code> element in the response indicates the cause of
        /// the failure. For help interpreting the <code>StatusMessage</code>, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/CHAP_Troubleshooting.html">Troubleshooting
        /// Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        public virtual DescribeScalingActivitiesResponse DescribeScalingActivities()
        {
            return DescribeScalingActivities(new DescribeScalingActivitiesRequest());
        }


        /// <summary>
        /// Gets information about the scaling activities in the account and Region.
        /// 
        ///  
        /// <para>
        /// When scaling events occur, you see a record of the scaling activity in the scaling
        /// activities. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-verify-scaling-activity.html">Verifying
        /// a scaling activity for an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the scaling event succeeds, the value of the <code>StatusCode</code> element in
        /// the response is <code>Successful</code>. If an attempt to launch instances failed,
        /// the <code>StatusCode</code> value is <code>Failed</code> or <code>Cancelled</code>
        /// and the <code>StatusMessage</code> element in the response indicates the cause of
        /// the failure. For help interpreting the <code>StatusMessage</code>, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/CHAP_Troubleshooting.html">Troubleshooting
        /// Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        public virtual DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingActivitiesResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the scaling activities in the account and Region.
        /// 
        ///  
        /// <para>
        /// When scaling events occur, you see a record of the scaling activity in the scaling
        /// activities. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-verify-scaling-activity.html">Verifying
        /// a scaling activity for an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the scaling event succeeds, the value of the <code>StatusCode</code> element in
        /// the response is <code>Successful</code>. If an attempt to launch instances failed,
        /// the <code>StatusCode</code> value is <code>Failed</code> or <code>Cancelled</code>
        /// and the <code>StatusMessage</code> element in the response indicates the cause of
        /// the failure. For help interpreting the <code>StatusMessage</code>, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/CHAP_Troubleshooting.html">Troubleshooting
        /// Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        public virtual Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeScalingActivitiesAsync(new DescribeScalingActivitiesRequest(), cancellationToken);
        }

        /// <summary>
        /// Gets information about the scaling activities in the account and Region.
        /// 
        ///  
        /// <para>
        /// When scaling events occur, you see a record of the scaling activity in the scaling
        /// activities. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-verify-scaling-activity.html">Verifying
        /// a scaling activity for an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the scaling event succeeds, the value of the <code>StatusCode</code> element in
        /// the response is <code>Successful</code>. If an attempt to launch instances failed,
        /// the <code>StatusCode</code> value is <code>Failed</code> or <code>Cancelled</code>
        /// and the <code>StatusMessage</code> element in the response indicates the cause of
        /// the failure. For help interpreting the <code>StatusMessage</code>, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/CHAP_Troubleshooting.html">Troubleshooting
        /// Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        public virtual Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeScalingActivitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingProcessTypes


        /// <summary>
        /// Describes the scaling process types for use with the <a>ResumeProcesses</a> and <a>SuspendProcesses</a>
        /// APIs.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingProcessTypes">REST API Reference for DescribeScalingProcessTypes Operation</seealso>
        public virtual DescribeScalingProcessTypesResponse DescribeScalingProcessTypes()
        {
            return DescribeScalingProcessTypes(new DescribeScalingProcessTypesRequest());
        }


        /// <summary>
        /// Describes the scaling process types for use with the <a>ResumeProcesses</a> and <a>SuspendProcesses</a>
        /// APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingProcessTypes">REST API Reference for DescribeScalingProcessTypes Operation</seealso>
        public virtual DescribeScalingProcessTypesResponse DescribeScalingProcessTypes(DescribeScalingProcessTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingProcessTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingProcessTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingProcessTypesResponse>(request, options);
        }


        /// <summary>
        /// Describes the scaling process types for use with the <a>ResumeProcesses</a> and <a>SuspendProcesses</a>
        /// APIs.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingProcessTypes">REST API Reference for DescribeScalingProcessTypes Operation</seealso>
        public virtual Task<DescribeScalingProcessTypesResponse> DescribeScalingProcessTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeScalingProcessTypesAsync(new DescribeScalingProcessTypesRequest(), cancellationToken);
        }

        /// <summary>
        /// Describes the scaling process types for use with the <a>ResumeProcesses</a> and <a>SuspendProcesses</a>
        /// APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingProcessTypes">REST API Reference for DescribeScalingProcessTypes Operation</seealso>
        public virtual Task<DescribeScalingProcessTypesResponse> DescribeScalingProcessTypesAsync(DescribeScalingProcessTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingProcessTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingProcessTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeScalingProcessTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScheduledActions


        /// <summary>
        /// Gets information about the scheduled actions that haven't run or that have not reached
        /// their end time.
        /// 
        ///  
        /// <para>
        /// To describe the scaling activities for scheduled actions that have already run, call
        /// the <a>DescribeScalingActivities</a> API.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        public virtual DescribeScheduledActionsResponse DescribeScheduledActions()
        {
            return DescribeScheduledActions(new DescribeScheduledActionsRequest());
        }


        /// <summary>
        /// Gets information about the scheduled actions that haven't run or that have not reached
        /// their end time.
        /// 
        ///  
        /// <para>
        /// To describe the scaling activities for scheduled actions that have already run, call
        /// the <a>DescribeScalingActivities</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        public virtual DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledActionsResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the scheduled actions that haven't run or that have not reached
        /// their end time.
        /// 
        ///  
        /// <para>
        /// To describe the scaling activities for scheduled actions that have already run, call
        /// the <a>DescribeScalingActivities</a> API.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        public virtual Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeScheduledActionsAsync(new DescribeScheduledActionsRequest(), cancellationToken);
        }

        /// <summary>
        /// Gets information about the scheduled actions that haven't run or that have not reached
        /// their end time.
        /// 
        ///  
        /// <para>
        /// To describe the scaling activities for scheduled actions that have already run, call
        /// the <a>DescribeScalingActivities</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        public virtual Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(DescribeScheduledActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeScheduledActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Describes the specified tags.
        /// 
        ///  
        /// <para>
        /// You can use filters to limit the results. For example, you can query for the tags
        /// for a specific Auto Scaling group. You can specify multiple values for a filter. A
        /// tag must match at least one of the specified values for it to be included in the results.
        /// </para>
        ///  
        /// <para>
        /// You can also specify multiple filters. The result includes information for a particular
        /// tag only if it matches all the filters. If there's no match, no special message is
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-tagging.html">Tag
        /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual DescribeTagsResponse DescribeTags()
        {
            return DescribeTags(new DescribeTagsRequest());
        }


        /// <summary>
        /// Describes the specified tags.
        /// 
        ///  
        /// <para>
        /// You can use filters to limit the results. For example, you can query for the tags
        /// for a specific Auto Scaling group. You can specify multiple values for a filter. A
        /// tag must match at least one of the specified values for it to be included in the results.
        /// </para>
        ///  
        /// <para>
        /// You can also specify multiple filters. The result includes information for a particular
        /// tag only if it matches all the filters. If there's no match, no special message is
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-tagging.html">Tag
        /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified tags.
        /// 
        ///  
        /// <para>
        /// You can use filters to limit the results. For example, you can query for the tags
        /// for a specific Auto Scaling group. You can specify multiple values for a filter. A
        /// tag must match at least one of the specified values for it to be included in the results.
        /// </para>
        ///  
        /// <para>
        /// You can also specify multiple filters. The result includes information for a particular
        /// tag only if it matches all the filters. If there's no match, no special message is
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-tagging.html">Tag
        /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeTagsAsync(new DescribeTagsRequest(), cancellationToken);
        }

        /// <summary>
        /// Describes the specified tags.
        /// 
        ///  
        /// <para>
        /// You can use filters to limit the results. For example, you can query for the tags
        /// for a specific Auto Scaling group. You can specify multiple values for a filter. A
        /// tag must match at least one of the specified values for it to be included in the results.
        /// </para>
        ///  
        /// <para>
        /// You can also specify multiple filters. The result includes information for a particular
        /// tag only if it matches all the filters. If there's no match, no special message is
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-tagging.html">Tag
        /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTerminationPolicyTypes


        /// <summary>
        /// Describes the termination policies supported by Amazon EC2 Auto Scaling.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-termination-policies.html">Work
        /// with Amazon EC2 Auto Scaling termination policies</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTerminationPolicyTypes">REST API Reference for DescribeTerminationPolicyTypes Operation</seealso>
        public virtual DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes()
        {
            return DescribeTerminationPolicyTypes(new DescribeTerminationPolicyTypesRequest());
        }


        /// <summary>
        /// Describes the termination policies supported by Amazon EC2 Auto Scaling.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-termination-policies.html">Work
        /// with Amazon EC2 Auto Scaling termination policies</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTerminationPolicyTypes">REST API Reference for DescribeTerminationPolicyTypes Operation</seealso>
        public virtual DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTerminationPolicyTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTerminationPolicyTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeTerminationPolicyTypesResponse>(request, options);
        }


        /// <summary>
        /// Describes the termination policies supported by Amazon EC2 Auto Scaling.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-termination-policies.html">Work
        /// with Amazon EC2 Auto Scaling termination policies</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTerminationPolicyTypes">REST API Reference for DescribeTerminationPolicyTypes Operation</seealso>
        public virtual Task<DescribeTerminationPolicyTypesResponse> DescribeTerminationPolicyTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeTerminationPolicyTypesAsync(new DescribeTerminationPolicyTypesRequest(), cancellationToken);
        }

        /// <summary>
        /// Describes the termination policies supported by Amazon EC2 Auto Scaling.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-termination-policies.html">Work
        /// with Amazon EC2 Auto Scaling termination policies</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTerminationPolicyTypes">REST API Reference for DescribeTerminationPolicyTypes Operation</seealso>
        public virtual Task<DescribeTerminationPolicyTypesResponse> DescribeTerminationPolicyTypesAsync(DescribeTerminationPolicyTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTerminationPolicyTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTerminationPolicyTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTerminationPolicyTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrafficSources


        /// <summary>
        /// Gets information about the traffic sources for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// You can optionally provide a traffic source type. If you provide a traffic source
        /// type, then the results only include that traffic source type.
        /// </para>
        ///  
        /// <para>
        /// If you do not provide a traffic source type, then the results include all the traffic
        /// sources for the specified Auto Scaling group. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrafficSources service method.</param>
        /// 
        /// <returns>The response from the DescribeTrafficSources service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTrafficSources">REST API Reference for DescribeTrafficSources Operation</seealso>
        public virtual DescribeTrafficSourcesResponse DescribeTrafficSources(DescribeTrafficSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrafficSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrafficSourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeTrafficSourcesResponse>(request, options);
        }


        /// <summary>
        /// Gets information about the traffic sources for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// You can optionally provide a traffic source type. If you provide a traffic source
        /// type, then the results only include that traffic source type.
        /// </para>
        ///  
        /// <para>
        /// If you do not provide a traffic source type, then the results include all the traffic
        /// sources for the specified Auto Scaling group. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrafficSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrafficSources service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTrafficSources">REST API Reference for DescribeTrafficSources Operation</seealso>
        public virtual Task<DescribeTrafficSourcesResponse> DescribeTrafficSourcesAsync(DescribeTrafficSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrafficSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrafficSourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTrafficSourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWarmPool


        /// <summary>
        /// Gets information about a warm pool and its instances.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-warm-pools.html">Warm
        /// pools for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWarmPool service method.</param>
        /// 
        /// <returns>The response from the DescribeWarmPool service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeWarmPool">REST API Reference for DescribeWarmPool Operation</seealso>
        public virtual DescribeWarmPoolResponse DescribeWarmPool(DescribeWarmPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWarmPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWarmPoolResponseUnmarshaller.Instance;

            return Invoke<DescribeWarmPoolResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a warm pool and its instances.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-warm-pools.html">Warm
        /// pools for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWarmPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWarmPool service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeWarmPool">REST API Reference for DescribeWarmPool Operation</seealso>
        public virtual Task<DescribeWarmPoolResponse> DescribeWarmPoolAsync(DescribeWarmPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWarmPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWarmPoolResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeWarmPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachInstances


        /// <summary>
        /// Removes one or more instances from the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// After the instances are detached, you can manage them independent of the Auto Scaling
        /// group.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify the option to decrement the desired capacity, Amazon EC2 Auto
        /// Scaling launches instances to replace the ones that are detached.
        /// </para>
        ///  
        /// <para>
        /// If there is a Classic Load Balancer attached to the Auto Scaling group, the instances
        /// are deregistered from the load balancer. If there are target groups attached to the
        /// Auto Scaling group, the instances are deregistered from the target groups.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/detach-instance-asg.html">Detach
        /// EC2 instances from your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInstances service method.</param>
        /// 
        /// <returns>The response from the DetachInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachInstances">REST API Reference for DetachInstances Operation</seealso>
        public virtual DetachInstancesResponse DetachInstances(DetachInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachInstancesResponseUnmarshaller.Instance;

            return Invoke<DetachInstancesResponse>(request, options);
        }


        /// <summary>
        /// Removes one or more instances from the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// After the instances are detached, you can manage them independent of the Auto Scaling
        /// group.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify the option to decrement the desired capacity, Amazon EC2 Auto
        /// Scaling launches instances to replace the ones that are detached.
        /// </para>
        ///  
        /// <para>
        /// If there is a Classic Load Balancer attached to the Auto Scaling group, the instances
        /// are deregistered from the load balancer. If there are target groups attached to the
        /// Auto Scaling group, the instances are deregistered from the target groups.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/detach-instance-asg.html">Detach
        /// EC2 instances from your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachInstances">REST API Reference for DetachInstances Operation</seealso>
        public virtual Task<DetachInstancesResponse> DetachInstancesAsync(DetachInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetachInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachLoadBalancers


        /// <summary>
        /// <note> 
        /// <para>
        /// This API call has been replaced with a new "traffic sources" API call (<code>DetachTrafficSources</code>)
        /// that can detach multiple traffic sources types. While we continue to support <code>DetachLoadBalancers</code>,
        /// and you can use both the original <code>DetachLoadBalancers</code> API call and the
        /// new <code>DetachTrafficSources</code> API call on the same Auto Scaling group, we
        /// recommend using the new "traffic sources" API call to simplify how you manage traffic
        /// sources.
        /// </para>
        ///  </note> 
        /// <para>
        /// Detaches one or more Classic Load Balancers from the specified Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// This operation detaches only Classic Load Balancers. If you have Application Load
        /// Balancers, Network Load Balancers, or Gateway Load Balancers, use the <a>DetachLoadBalancerTargetGroups</a>
        /// API instead.
        /// </para>
        ///  
        /// <para>
        /// When you detach a load balancer, it enters the <code>Removing</code> state while deregistering
        /// the instances in the group. When all instances are deregistered, then you can no longer
        /// describe the load balancer using the <a>DescribeLoadBalancers</a> API call. The instances
        /// remain running.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachLoadBalancers">REST API Reference for DetachLoadBalancers Operation</seealso>
        public virtual DetachLoadBalancersResponse DetachLoadBalancers(DetachLoadBalancersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<DetachLoadBalancersResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This API call has been replaced with a new "traffic sources" API call (<code>DetachTrafficSources</code>)
        /// that can detach multiple traffic sources types. While we continue to support <code>DetachLoadBalancers</code>,
        /// and you can use both the original <code>DetachLoadBalancers</code> API call and the
        /// new <code>DetachTrafficSources</code> API call on the same Auto Scaling group, we
        /// recommend using the new "traffic sources" API call to simplify how you manage traffic
        /// sources.
        /// </para>
        ///  </note> 
        /// <para>
        /// Detaches one or more Classic Load Balancers from the specified Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// This operation detaches only Classic Load Balancers. If you have Application Load
        /// Balancers, Network Load Balancers, or Gateway Load Balancers, use the <a>DetachLoadBalancerTargetGroups</a>
        /// API instead.
        /// </para>
        ///  
        /// <para>
        /// When you detach a load balancer, it enters the <code>Removing</code> state while deregistering
        /// the instances in the group. When all instances are deregistered, then you can no longer
        /// describe the load balancer using the <a>DescribeLoadBalancers</a> API call. The instances
        /// remain running.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachLoadBalancers">REST API Reference for DetachLoadBalancers Operation</seealso>
        public virtual Task<DetachLoadBalancersResponse> DetachLoadBalancersAsync(DetachLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachLoadBalancersResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetachLoadBalancersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachLoadBalancerTargetGroups


        /// <summary>
        /// <note> 
        /// <para>
        /// This API call has been replaced with a new "traffic sources" API call (<code>DetachTrafficSources</code>)
        /// that can detach multiple traffic sources types. While we continue to support <code>DetachLoadBalancerTargetGroups</code>,
        /// and you can use both the original <code>DetachLoadBalancerTargetGroups</code> API
        /// call and the new <code>DetachTrafficSources</code> API call on the same Auto Scaling
        /// group, we recommend using the new "traffic sources" API call to simplify how you manage
        /// traffic sources.
        /// </para>
        ///  </note> 
        /// <para>
        /// Detaches one or more target groups from the specified Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// When you detach a target group, it enters the <code>Removing</code> state while deregistering
        /// the instances in the group. When all instances are deregistered, then you can no longer
        /// describe the target group using the <a>DescribeLoadBalancerTargetGroups</a> API call.
        /// The instances remain running.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use this operation to detach target groups that were attached by using <a>AttachLoadBalancerTargetGroups</a>,
        /// but not for target groups that were attached by using <a>AttachTrafficSources</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerTargetGroups service method.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachLoadBalancerTargetGroups">REST API Reference for DetachLoadBalancerTargetGroups Operation</seealso>
        public virtual DetachLoadBalancerTargetGroupsResponse DetachLoadBalancerTargetGroups(DetachLoadBalancerTargetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<DetachLoadBalancerTargetGroupsResponse>(request, options);
        }


        /// <summary>
        /// <note> 
        /// <para>
        /// This API call has been replaced with a new "traffic sources" API call (<code>DetachTrafficSources</code>)
        /// that can detach multiple traffic sources types. While we continue to support <code>DetachLoadBalancerTargetGroups</code>,
        /// and you can use both the original <code>DetachLoadBalancerTargetGroups</code> API
        /// call and the new <code>DetachTrafficSources</code> API call on the same Auto Scaling
        /// group, we recommend using the new "traffic sources" API call to simplify how you manage
        /// traffic sources.
        /// </para>
        ///  </note> 
        /// <para>
        /// Detaches one or more target groups from the specified Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// When you detach a target group, it enters the <code>Removing</code> state while deregistering
        /// the instances in the group. When all instances are deregistered, then you can no longer
        /// describe the target group using the <a>DescribeLoadBalancerTargetGroups</a> API call.
        /// The instances remain running.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use this operation to detach target groups that were attached by using <a>AttachLoadBalancerTargetGroups</a>,
        /// but not for target groups that were attached by using <a>AttachTrafficSources</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerTargetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachLoadBalancerTargetGroups">REST API Reference for DetachLoadBalancerTargetGroups Operation</seealso>
        public virtual Task<DetachLoadBalancerTargetGroupsResponse> DetachLoadBalancerTargetGroupsAsync(DetachLoadBalancerTargetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachLoadBalancerTargetGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetachLoadBalancerTargetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachTrafficSources


        /// <summary>
        /// Detaches one or more traffic sources from the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// When you detach a taffic, it enters the <code>Removing</code> state while deregistering
        /// the instances in the group. When all instances are deregistered, then you can no longer
        /// describe the traffic source using the <a>DescribeTrafficSources</a> API call. The
        /// instances continue to run.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachTrafficSources service method.</param>
        /// 
        /// <returns>The response from the DetachTrafficSources service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachTrafficSources">REST API Reference for DetachTrafficSources Operation</seealso>
        public virtual DetachTrafficSourcesResponse DetachTrafficSources(DetachTrafficSourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachTrafficSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachTrafficSourcesResponseUnmarshaller.Instance;

            return Invoke<DetachTrafficSourcesResponse>(request, options);
        }


        /// <summary>
        /// Detaches one or more traffic sources from the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// When you detach a taffic, it enters the <code>Removing</code> state while deregistering
        /// the instances in the group. When all instances are deregistered, then you can no longer
        /// describe the traffic source using the <a>DescribeTrafficSources</a> API call. The
        /// instances continue to run.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachTrafficSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachTrafficSources service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachTrafficSources">REST API Reference for DetachTrafficSources Operation</seealso>
        public virtual Task<DetachTrafficSourcesResponse> DetachTrafficSourcesAsync(DetachTrafficSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachTrafficSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachTrafficSourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DetachTrafficSourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableMetricsCollection


        /// <summary>
        /// Disables group metrics collection for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection service method.</param>
        /// 
        /// <returns>The response from the DisableMetricsCollection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DisableMetricsCollection">REST API Reference for DisableMetricsCollection Operation</seealso>
        public virtual DisableMetricsCollectionResponse DisableMetricsCollection(DisableMetricsCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableMetricsCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableMetricsCollectionResponseUnmarshaller.Instance;

            return Invoke<DisableMetricsCollectionResponse>(request, options);
        }


        /// <summary>
        /// Disables group metrics collection for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableMetricsCollection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DisableMetricsCollection">REST API Reference for DisableMetricsCollection Operation</seealso>
        public virtual Task<DisableMetricsCollectionResponse> DisableMetricsCollectionAsync(DisableMetricsCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableMetricsCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableMetricsCollectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableMetricsCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableMetricsCollection


        /// <summary>
        /// Enables group metrics collection for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// You can use these metrics to track changes in an Auto Scaling group and to set alarms
        /// on threshold values. You can view group metrics using the Amazon EC2 Auto Scaling
        /// console or the CloudWatch console. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-cloudwatch-monitoring.html">Monitor
        /// CloudWatch metrics for your Auto Scaling groups and instances</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection service method.</param>
        /// 
        /// <returns>The response from the EnableMetricsCollection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/EnableMetricsCollection">REST API Reference for EnableMetricsCollection Operation</seealso>
        public virtual EnableMetricsCollectionResponse EnableMetricsCollection(EnableMetricsCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableMetricsCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableMetricsCollectionResponseUnmarshaller.Instance;

            return Invoke<EnableMetricsCollectionResponse>(request, options);
        }


        /// <summary>
        /// Enables group metrics collection for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// You can use these metrics to track changes in an Auto Scaling group and to set alarms
        /// on threshold values. You can view group metrics using the Amazon EC2 Auto Scaling
        /// console or the CloudWatch console. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-cloudwatch-monitoring.html">Monitor
        /// CloudWatch metrics for your Auto Scaling groups and instances</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableMetricsCollection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/EnableMetricsCollection">REST API Reference for EnableMetricsCollection Operation</seealso>
        public virtual Task<EnableMetricsCollectionResponse> EnableMetricsCollectionAsync(EnableMetricsCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableMetricsCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableMetricsCollectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableMetricsCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnterStandby


        /// <summary>
        /// Moves the specified instances into the standby state.
        /// 
        ///  
        /// <para>
        /// If you choose to decrement the desired capacity of the Auto Scaling group, the instances
        /// can enter standby as long as the desired capacity of the Auto Scaling group after
        /// the instances are placed into standby is equal to or greater than the minimum capacity
        /// of the group.
        /// </para>
        ///  
        /// <para>
        /// If you choose not to decrement the desired capacity of the Auto Scaling group, the
        /// Auto Scaling group launches new instances to replace the instances on standby.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-enter-exit-standby.html">Temporarily
        /// removing instances from your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnterStandby service method.</param>
        /// 
        /// <returns>The response from the EnterStandby service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/EnterStandby">REST API Reference for EnterStandby Operation</seealso>
        public virtual EnterStandbyResponse EnterStandby(EnterStandbyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnterStandbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnterStandbyResponseUnmarshaller.Instance;

            return Invoke<EnterStandbyResponse>(request, options);
        }


        /// <summary>
        /// Moves the specified instances into the standby state.
        /// 
        ///  
        /// <para>
        /// If you choose to decrement the desired capacity of the Auto Scaling group, the instances
        /// can enter standby as long as the desired capacity of the Auto Scaling group after
        /// the instances are placed into standby is equal to or greater than the minimum capacity
        /// of the group.
        /// </para>
        ///  
        /// <para>
        /// If you choose not to decrement the desired capacity of the Auto Scaling group, the
        /// Auto Scaling group launches new instances to replace the instances on standby.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-enter-exit-standby.html">Temporarily
        /// removing instances from your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnterStandby service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnterStandby service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/EnterStandby">REST API Reference for EnterStandby Operation</seealso>
        public virtual Task<EnterStandbyResponse> EnterStandbyAsync(EnterStandbyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnterStandbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnterStandbyResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnterStandbyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecutePolicy


        /// <summary>
        /// Executes the specified policy. This can be useful for testing the design of your scaling
        /// policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy service method.</param>
        /// 
        /// <returns>The response from the ExecutePolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ExecutePolicy">REST API Reference for ExecutePolicy Operation</seealso>
        public virtual ExecutePolicyResponse ExecutePolicy(ExecutePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecutePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecutePolicyResponseUnmarshaller.Instance;

            return Invoke<ExecutePolicyResponse>(request, options);
        }


        /// <summary>
        /// Executes the specified policy. This can be useful for testing the design of your scaling
        /// policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecutePolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ExecutePolicy">REST API Reference for ExecutePolicy Operation</seealso>
        public virtual Task<ExecutePolicyResponse> ExecutePolicyAsync(ExecutePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecutePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecutePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecutePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExitStandby


        /// <summary>
        /// Moves the specified instances out of the standby state.
        /// 
        ///  
        /// <para>
        /// After you put the instances back in service, the desired capacity is incremented.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-enter-exit-standby.html">Temporarily
        /// removing instances from your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExitStandby service method.</param>
        /// 
        /// <returns>The response from the ExitStandby service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ExitStandby">REST API Reference for ExitStandby Operation</seealso>
        public virtual ExitStandbyResponse ExitStandby(ExitStandbyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExitStandbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExitStandbyResponseUnmarshaller.Instance;

            return Invoke<ExitStandbyResponse>(request, options);
        }


        /// <summary>
        /// Moves the specified instances out of the standby state.
        /// 
        ///  
        /// <para>
        /// After you put the instances back in service, the desired capacity is incremented.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-enter-exit-standby.html">Temporarily
        /// removing instances from your Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExitStandby service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExitStandby service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ExitStandby">REST API Reference for ExitStandby Operation</seealso>
        public virtual Task<ExitStandbyResponse> ExitStandbyAsync(ExitStandbyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExitStandbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExitStandbyResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExitStandbyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPredictiveScalingForecast


        /// <summary>
        /// Retrieves the forecast data for a predictive scaling policy.
        /// 
        ///  
        /// <para>
        /// Load forecasts are predictions of the hourly load values using historical load data
        /// from CloudWatch and an analysis of historical trends. Capacity forecasts are represented
        /// as predicted values for the minimum capacity that is needed on an hourly basis, based
        /// on the hourly load forecast.
        /// </para>
        ///  
        /// <para>
        /// A minimum of 24 hours of data is required to create the initial forecasts. However,
        /// having a full 14 days of historical data results in more accurate forecasts.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-predictive-scaling.html">Predictive
        /// scaling for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPredictiveScalingForecast service method.</param>
        /// 
        /// <returns>The response from the GetPredictiveScalingForecast service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/GetPredictiveScalingForecast">REST API Reference for GetPredictiveScalingForecast Operation</seealso>
        public virtual GetPredictiveScalingForecastResponse GetPredictiveScalingForecast(GetPredictiveScalingForecastRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPredictiveScalingForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPredictiveScalingForecastResponseUnmarshaller.Instance;

            return Invoke<GetPredictiveScalingForecastResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the forecast data for a predictive scaling policy.
        /// 
        ///  
        /// <para>
        /// Load forecasts are predictions of the hourly load values using historical load data
        /// from CloudWatch and an analysis of historical trends. Capacity forecasts are represented
        /// as predicted values for the minimum capacity that is needed on an hourly basis, based
        /// on the hourly load forecast.
        /// </para>
        ///  
        /// <para>
        /// A minimum of 24 hours of data is required to create the initial forecasts. However,
        /// having a full 14 days of historical data results in more accurate forecasts.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-predictive-scaling.html">Predictive
        /// scaling for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPredictiveScalingForecast service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPredictiveScalingForecast service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/GetPredictiveScalingForecast">REST API Reference for GetPredictiveScalingForecast Operation</seealso>
        public virtual Task<GetPredictiveScalingForecastResponse> GetPredictiveScalingForecastAsync(GetPredictiveScalingForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPredictiveScalingForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPredictiveScalingForecastResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPredictiveScalingForecastResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutLifecycleHook


        /// <summary>
        /// Creates or updates a lifecycle hook for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// Lifecycle hooks let you create solutions that are aware of events in the Auto Scaling
        /// instance lifecycle, and then perform a custom action on instances when the corresponding
        /// lifecycle event occurs.
        /// </para>
        ///  
        /// <para>
        /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// (Optional) Create a launch template or launch configuration with a user data script
        /// that runs while an instance is in a wait state due to a lifecycle hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a Lambda function and a rule that allows Amazon EventBridge to invoke
        /// your Lambda function when an instance is put into a wait state due to a lifecycle
        /// hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Amazon EC2 Auto Scaling
        /// to publish lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Create the lifecycle hook. Specify whether the hook is used when the instances
        /// launch or terminate.</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a wait state using the <a>RecordLifecycleActionHeartbeat</a> API call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you finish before the timeout period ends, send a callback by using the <a>CompleteLifecycleAction</a>
        /// API call.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Amazon
        /// EC2 Auto Scaling lifecycle hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of lifecycle hooks, which by default is 50 per Auto
        /// Scaling group, the call fails.
        /// </para>
        ///  
        /// <para>
        /// You can view the lifecycle hooks for an Auto Scaling group using the <a>DescribeLifecycleHooks</a>
        /// API call. If you are no longer using a lifecycle hook, you can delete it by calling
        /// the <a>DeleteLifecycleHook</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleHook service method.</param>
        /// 
        /// <returns>The response from the PutLifecycleHook service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutLifecycleHook">REST API Reference for PutLifecycleHook Operation</seealso>
        public virtual PutLifecycleHookResponse PutLifecycleHook(PutLifecycleHookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecycleHookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleHookResponseUnmarshaller.Instance;

            return Invoke<PutLifecycleHookResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates a lifecycle hook for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// Lifecycle hooks let you create solutions that are aware of events in the Auto Scaling
        /// instance lifecycle, and then perform a custom action on instances when the corresponding
        /// lifecycle event occurs.
        /// </para>
        ///  
        /// <para>
        /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// (Optional) Create a launch template or launch configuration with a user data script
        /// that runs while an instance is in a wait state due to a lifecycle hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a Lambda function and a rule that allows Amazon EventBridge to invoke
        /// your Lambda function when an instance is put into a wait state due to a lifecycle
        /// hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Amazon EC2 Auto Scaling
        /// to publish lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Create the lifecycle hook. Specify whether the hook is used when the instances
        /// launch or terminate.</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a wait state using the <a>RecordLifecycleActionHeartbeat</a> API call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you finish before the timeout period ends, send a callback by using the <a>CompleteLifecycleAction</a>
        /// API call.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Amazon
        /// EC2 Auto Scaling lifecycle hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of lifecycle hooks, which by default is 50 per Auto
        /// Scaling group, the call fails.
        /// </para>
        ///  
        /// <para>
        /// You can view the lifecycle hooks for an Auto Scaling group using the <a>DescribeLifecycleHooks</a>
        /// API call. If you are no longer using a lifecycle hook, you can delete it by calling
        /// the <a>DeleteLifecycleHook</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleHook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLifecycleHook service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutLifecycleHook">REST API Reference for PutLifecycleHook Operation</seealso>
        public virtual Task<PutLifecycleHookResponse> PutLifecycleHookAsync(PutLifecycleHookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecycleHookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleHookResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutLifecycleHookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutNotificationConfiguration


        /// <summary>
        /// Configures an Auto Scaling group to send notifications when specified events take
        /// place. Subscribers to the specified topic can have messages delivered to an endpoint
        /// such as a web server or an email address.
        /// 
        ///  
        /// <para>
        /// This configuration overwrites any existing configuration.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ASGettingNotifications.html">Getting
        /// Amazon SNS notifications when your Auto Scaling group scales</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of SNS topics, which is 10 per Auto Scaling group,
        /// the call fails.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutNotificationConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutNotificationConfiguration">REST API Reference for PutNotificationConfiguration Operation</seealso>
        public virtual PutNotificationConfigurationResponse PutNotificationConfiguration(PutNotificationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Configures an Auto Scaling group to send notifications when specified events take
        /// place. Subscribers to the specified topic can have messages delivered to an endpoint
        /// such as a web server or an email address.
        /// 
        ///  
        /// <para>
        /// This configuration overwrites any existing configuration.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ASGettingNotifications.html">Getting
        /// Amazon SNS notifications when your Auto Scaling group scales</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of SNS topics, which is 10 per Auto Scaling group,
        /// the call fails.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutNotificationConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutNotificationConfiguration">REST API Reference for PutNotificationConfiguration Operation</seealso>
        public virtual Task<PutNotificationConfigurationResponse> PutNotificationConfigurationAsync(PutNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutNotificationConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutScalingPolicy


        /// <summary>
        /// Creates or updates a scaling policy for an Auto Scaling group. Scaling policies are
        /// used to scale an Auto Scaling group based on configurable metrics. If no policies
        /// are defined, the dynamic scaling and predictive scaling features are not used. 
        /// 
        ///  
        /// <para>
        /// For more information about using dynamic scaling, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-target-tracking.html">Target
        /// tracking scaling policies</a> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-simple-step.html">Step
        /// and simple scaling policies</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about using predictive scaling, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-predictive-scaling.html">Predictive
        /// scaling for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can view the scaling policies for an Auto Scaling group using the <a>DescribePolicies</a>
        /// API call. If you are no longer using a scaling policy, you can delete it by calling
        /// the <a>DeletePolicy</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public virtual PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutScalingPolicyResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates a scaling policy for an Auto Scaling group. Scaling policies are
        /// used to scale an Auto Scaling group based on configurable metrics. If no policies
        /// are defined, the dynamic scaling and predictive scaling features are not used. 
        /// 
        ///  
        /// <para>
        /// For more information about using dynamic scaling, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-target-tracking.html">Target
        /// tracking scaling policies</a> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-simple-step.html">Step
        /// and simple scaling policies</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about using predictive scaling, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-predictive-scaling.html">Predictive
        /// scaling for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can view the scaling policies for an Auto Scaling group using the <a>DescribePolicies</a>
        /// API call. If you are no longer using a scaling policy, you can delete it by calling
        /// the <a>DeletePolicy</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public virtual Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutScalingPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutScheduledUpdateGroupAction


        /// <summary>
        /// Creates or updates a scheduled scaling action for an Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/schedule_time.html">Scheduled
        /// scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can view the scheduled actions for an Auto Scaling group using the <a>DescribeScheduledActions</a>
        /// API call. If you are no longer using a scheduled action, you can delete it by calling
        /// the <a>DeleteScheduledAction</a> API.
        /// </para>
        ///  
        /// <para>
        /// If you try to schedule your action in the past, Amazon EC2 Auto Scaling returns an
        /// error message.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction service method.</param>
        /// 
        /// <returns>The response from the PutScheduledUpdateGroupAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutScheduledUpdateGroupAction">REST API Reference for PutScheduledUpdateGroupAction Operation</seealso>
        public virtual PutScheduledUpdateGroupActionResponse PutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScheduledUpdateGroupActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScheduledUpdateGroupActionResponseUnmarshaller.Instance;

            return Invoke<PutScheduledUpdateGroupActionResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates a scheduled scaling action for an Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/schedule_time.html">Scheduled
        /// scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can view the scheduled actions for an Auto Scaling group using the <a>DescribeScheduledActions</a>
        /// API call. If you are no longer using a scheduled action, you can delete it by calling
        /// the <a>DeleteScheduledAction</a> API.
        /// </para>
        ///  
        /// <para>
        /// If you try to schedule your action in the past, Amazon EC2 Auto Scaling returns an
        /// error message.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutScheduledUpdateGroupAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutScheduledUpdateGroupAction">REST API Reference for PutScheduledUpdateGroupAction Operation</seealso>
        public virtual Task<PutScheduledUpdateGroupActionResponse> PutScheduledUpdateGroupActionAsync(PutScheduledUpdateGroupActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScheduledUpdateGroupActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScheduledUpdateGroupActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutScheduledUpdateGroupActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutWarmPool


        /// <summary>
        /// Creates or updates a warm pool for the specified Auto Scaling group. A warm pool is
        /// a pool of pre-initialized EC2 instances that sits alongside the Auto Scaling group.
        /// Whenever your application needs to scale out, the Auto Scaling group can draw on the
        /// warm pool to meet its new desired capacity. For more information and example configurations,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-warm-pools.html">Warm
        /// pools for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation must be called from the Region in which the Auto Scaling group was
        /// created. This operation cannot be called on an Auto Scaling group that has a mixed
        /// instances policy or a launch template or launch configuration that requests Spot Instances.
        /// </para>
        ///  
        /// <para>
        /// You can view the instances in the warm pool using the <a>DescribeWarmPool</a> API
        /// call. If you are no longer using a warm pool, you can delete it by calling the <a>DeleteWarmPool</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWarmPool service method.</param>
        /// 
        /// <returns>The response from the PutWarmPool service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutWarmPool">REST API Reference for PutWarmPool Operation</seealso>
        public virtual PutWarmPoolResponse PutWarmPool(PutWarmPoolRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutWarmPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWarmPoolResponseUnmarshaller.Instance;

            return Invoke<PutWarmPoolResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates a warm pool for the specified Auto Scaling group. A warm pool is
        /// a pool of pre-initialized EC2 instances that sits alongside the Auto Scaling group.
        /// Whenever your application needs to scale out, the Auto Scaling group can draw on the
        /// warm pool to meet its new desired capacity. For more information and example configurations,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-warm-pools.html">Warm
        /// pools for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation must be called from the Region in which the Auto Scaling group was
        /// created. This operation cannot be called on an Auto Scaling group that has a mixed
        /// instances policy or a launch template or launch configuration that requests Spot Instances.
        /// </para>
        ///  
        /// <para>
        /// You can view the instances in the warm pool using the <a>DescribeWarmPool</a> API
        /// call. If you are no longer using a warm pool, you can delete it by calling the <a>DeleteWarmPool</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWarmPool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutWarmPool service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutWarmPool">REST API Reference for PutWarmPool Operation</seealso>
        public virtual Task<PutWarmPoolResponse> PutWarmPoolAsync(PutWarmPoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutWarmPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWarmPoolResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutWarmPoolResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RecordLifecycleActionHeartbeat


        /// <summary>
        /// Records a heartbeat for the lifecycle action associated with the specified token or
        /// instance. This extends the timeout by the length of time defined using the <a>PutLifecycleHook</a>
        /// API call.
        /// 
        ///  
        /// <para>
        /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// (Optional) Create a launch template or launch configuration with a user data script
        /// that runs while an instance is in a wait state due to a lifecycle hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a Lambda function and a rule that allows Amazon EventBridge to invoke
        /// your Lambda function when an instance is put into a wait state due to a lifecycle
        /// hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Amazon EC2 Auto Scaling
        /// to publish lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the lifecycle hook. Specify whether the hook is used when the instances launch
        /// or terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a wait state.</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you finish before the timeout period ends, send a callback by using the <a>CompleteLifecycleAction</a>
        /// API call.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Amazon
        /// EC2 Auto Scaling lifecycle hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordLifecycleActionHeartbeat service method.</param>
        /// 
        /// <returns>The response from the RecordLifecycleActionHeartbeat service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/RecordLifecycleActionHeartbeat">REST API Reference for RecordLifecycleActionHeartbeat Operation</seealso>
        public virtual RecordLifecycleActionHeartbeatResponse RecordLifecycleActionHeartbeat(RecordLifecycleActionHeartbeatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecordLifecycleActionHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecordLifecycleActionHeartbeatResponseUnmarshaller.Instance;

            return Invoke<RecordLifecycleActionHeartbeatResponse>(request, options);
        }


        /// <summary>
        /// Records a heartbeat for the lifecycle action associated with the specified token or
        /// instance. This extends the timeout by the length of time defined using the <a>PutLifecycleHook</a>
        /// API call.
        /// 
        ///  
        /// <para>
        /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// (Optional) Create a launch template or launch configuration with a user data script
        /// that runs while an instance is in a wait state due to a lifecycle hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a Lambda function and a rule that allows Amazon EventBridge to invoke
        /// your Lambda function when an instance is put into a wait state due to a lifecycle
        /// hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Amazon EC2 Auto Scaling
        /// to publish lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the lifecycle hook. Specify whether the hook is used when the instances launch
        /// or terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a wait state.</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you finish before the timeout period ends, send a callback by using the <a>CompleteLifecycleAction</a>
        /// API call.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/lifecycle-hooks.html">Amazon
        /// EC2 Auto Scaling lifecycle hooks</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordLifecycleActionHeartbeat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RecordLifecycleActionHeartbeat service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/RecordLifecycleActionHeartbeat">REST API Reference for RecordLifecycleActionHeartbeat Operation</seealso>
        public virtual Task<RecordLifecycleActionHeartbeatResponse> RecordLifecycleActionHeartbeatAsync(RecordLifecycleActionHeartbeatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecordLifecycleActionHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecordLifecycleActionHeartbeatResponseUnmarshaller.Instance;
            
            return InvokeAsync<RecordLifecycleActionHeartbeatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResumeProcesses


        /// <summary>
        /// Resumes the specified suspended auto scaling processes, or all suspended process,
        /// for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-suspend-resume-processes.html">Suspending
        /// and resuming scaling processes</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses service method.</param>
        /// 
        /// <returns>The response from the ResumeProcesses service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ResumeProcesses">REST API Reference for ResumeProcesses Operation</seealso>
        public virtual ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeProcessesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeProcessesResponseUnmarshaller.Instance;

            return Invoke<ResumeProcessesResponse>(request, options);
        }


        /// <summary>
        /// Resumes the specified suspended auto scaling processes, or all suspended process,
        /// for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-suspend-resume-processes.html">Suspending
        /// and resuming scaling processes</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeProcesses service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ResumeProcesses">REST API Reference for ResumeProcesses Operation</seealso>
        public virtual Task<ResumeProcessesResponse> ResumeProcessesAsync(ResumeProcessesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeProcessesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeProcessesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResumeProcessesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RollbackInstanceRefresh


        /// <summary>
        /// Cancels an instance refresh that is in progress and rolls back any changes that it
        /// made. Amazon EC2 Auto Scaling replaces any instances that were replaced during the
        /// instance refresh. This restores your Auto Scaling group to the configuration that
        /// it was using before the start of the instance refresh. 
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
        /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
        /// your Auto Scaling group after you make configuration changes.
        /// </para>
        ///  
        /// <para>
        /// A rollback is not supported in the following situations: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// There is no desired configuration specified for the instance refresh.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Auto Scaling group has a launch template that uses an Amazon Web Services Systems
        /// Manager parameter instead of an AMI ID for the <code>ImageId</code> property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Auto Scaling group uses the launch template's <code>$Latest</code> or <code>$Default</code>
        /// version.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you receive a successful response from this operation, Amazon EC2 Auto Scaling
        /// immediately begins replacing instances. You can check the status of this operation
        /// through the <a>DescribeInstanceRefreshes</a> API operation. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RollbackInstanceRefresh service method.</param>
        /// 
        /// <returns>The response from the RollbackInstanceRefresh service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ActiveInstanceRefreshNotFoundException">
        /// The request failed because an active instance refresh or rollback for the specified
        /// Auto Scaling group was not found.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.IrreversibleInstanceRefreshException">
        /// The request failed because a desired configuration was not found or an incompatible
        /// launch template (uses a Systems Manager parameter instead of an AMI ID) or launch
        /// template version (<code>$Latest</code> or <code>$Default</code>) is present on the
        /// Auto Scaling group.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/RollbackInstanceRefresh">REST API Reference for RollbackInstanceRefresh Operation</seealso>
        public virtual RollbackInstanceRefreshResponse RollbackInstanceRefresh(RollbackInstanceRefreshRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RollbackInstanceRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RollbackInstanceRefreshResponseUnmarshaller.Instance;

            return Invoke<RollbackInstanceRefreshResponse>(request, options);
        }


        /// <summary>
        /// Cancels an instance refresh that is in progress and rolls back any changes that it
        /// made. Amazon EC2 Auto Scaling replaces any instances that were replaced during the
        /// instance refresh. This restores your Auto Scaling group to the configuration that
        /// it was using before the start of the instance refresh. 
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
        /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
        /// your Auto Scaling group after you make configuration changes.
        /// </para>
        ///  
        /// <para>
        /// A rollback is not supported in the following situations: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// There is no desired configuration specified for the instance refresh.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Auto Scaling group has a launch template that uses an Amazon Web Services Systems
        /// Manager parameter instead of an AMI ID for the <code>ImageId</code> property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Auto Scaling group uses the launch template's <code>$Latest</code> or <code>$Default</code>
        /// version.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you receive a successful response from this operation, Amazon EC2 Auto Scaling
        /// immediately begins replacing instances. You can check the status of this operation
        /// through the <a>DescribeInstanceRefreshes</a> API operation. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RollbackInstanceRefresh service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RollbackInstanceRefresh service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ActiveInstanceRefreshNotFoundException">
        /// The request failed because an active instance refresh or rollback for the specified
        /// Auto Scaling group was not found.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.IrreversibleInstanceRefreshException">
        /// The request failed because a desired configuration was not found or an incompatible
        /// launch template (uses a Systems Manager parameter instead of an AMI ID) or launch
        /// template version (<code>$Latest</code> or <code>$Default</code>) is present on the
        /// Auto Scaling group.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/RollbackInstanceRefresh">REST API Reference for RollbackInstanceRefresh Operation</seealso>
        public virtual Task<RollbackInstanceRefreshResponse> RollbackInstanceRefreshAsync(RollbackInstanceRefreshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RollbackInstanceRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RollbackInstanceRefreshResponseUnmarshaller.Instance;
            
            return InvokeAsync<RollbackInstanceRefreshResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetDesiredCapacity


        /// <summary>
        /// Sets the size of the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// If a scale-in activity occurs as a result of a new <code>DesiredCapacity</code> value
        /// that is lower than the current size of the group, the Auto Scaling group uses its
        /// termination policy to determine which instances to terminate. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-manual-scaling.html">Manual
        /// scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity service method.</param>
        /// 
        /// <returns>The response from the SetDesiredCapacity service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetDesiredCapacity">REST API Reference for SetDesiredCapacity Operation</seealso>
        public virtual SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDesiredCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDesiredCapacityResponseUnmarshaller.Instance;

            return Invoke<SetDesiredCapacityResponse>(request, options);
        }


        /// <summary>
        /// Sets the size of the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// If a scale-in activity occurs as a result of a new <code>DesiredCapacity</code> value
        /// that is lower than the current size of the group, the Auto Scaling group uses its
        /// termination policy to determine which instances to terminate. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-manual-scaling.html">Manual
        /// scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetDesiredCapacity service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetDesiredCapacity">REST API Reference for SetDesiredCapacity Operation</seealso>
        public virtual Task<SetDesiredCapacityResponse> SetDesiredCapacityAsync(SetDesiredCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDesiredCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDesiredCapacityResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetDesiredCapacityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetInstanceHealth


        /// <summary>
        /// Sets the health status of the specified instance.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/healthcheck.html">Health
        /// checks for Auto Scaling instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth service method.</param>
        /// 
        /// <returns>The response from the SetInstanceHealth service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetInstanceHealth">REST API Reference for SetInstanceHealth Operation</seealso>
        public virtual SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetInstanceHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetInstanceHealthResponseUnmarshaller.Instance;

            return Invoke<SetInstanceHealthResponse>(request, options);
        }


        /// <summary>
        /// Sets the health status of the specified instance.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/healthcheck.html">Health
        /// checks for Auto Scaling instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetInstanceHealth service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetInstanceHealth">REST API Reference for SetInstanceHealth Operation</seealso>
        public virtual Task<SetInstanceHealthResponse> SetInstanceHealthAsync(SetInstanceHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetInstanceHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetInstanceHealthResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetInstanceHealthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetInstanceProtection


        /// <summary>
        /// Updates the instance protection settings of the specified instances. This operation
        /// cannot be called on instances in a warm pool.
        /// 
        ///  
        /// <para>
        /// For more information about preventing instances that are part of an Auto Scaling group
        /// from terminating on scale in, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-instance-protection.html">Using
        /// instance scale-in protection</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of instance IDs, which is 50 per Auto Scaling group,
        /// the call fails.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceProtection service method.</param>
        /// 
        /// <returns>The response from the SetInstanceProtection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetInstanceProtection">REST API Reference for SetInstanceProtection Operation</seealso>
        public virtual SetInstanceProtectionResponse SetInstanceProtection(SetInstanceProtectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetInstanceProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetInstanceProtectionResponseUnmarshaller.Instance;

            return Invoke<SetInstanceProtectionResponse>(request, options);
        }


        /// <summary>
        /// Updates the instance protection settings of the specified instances. This operation
        /// cannot be called on instances in a warm pool.
        /// 
        ///  
        /// <para>
        /// For more information about preventing instances that are part of an Auto Scaling group
        /// from terminating on scale in, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-instance-protection.html">Using
        /// instance scale-in protection</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of instance IDs, which is 50 per Auto Scaling group,
        /// the call fails.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetInstanceProtection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetInstanceProtection">REST API Reference for SetInstanceProtection Operation</seealso>
        public virtual Task<SetInstanceProtectionResponse> SetInstanceProtectionAsync(SetInstanceProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetInstanceProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetInstanceProtectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<SetInstanceProtectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartInstanceRefresh


        /// <summary>
        /// Starts an instance refresh. During an instance refresh, Amazon EC2 Auto Scaling performs
        /// a rolling update of instances in an Auto Scaling group. Instances are terminated first
        /// and then replaced, which temporarily reduces the capacity available within your Auto
        /// Scaling group.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
        /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
        /// your Auto Scaling group. This feature is helpful, for example, when you have a new
        /// AMI or a new user data script. You just need to create a new launch template that
        /// specifies the new AMI or user data script. Then start an instance refresh to immediately
        /// begin the process of updating instances in the group. 
        /// </para>
        ///  
        /// <para>
        /// If successful, the request's response contains a unique ID that you can use to track
        /// the progress of the instance refresh. To query its status, call the <a>DescribeInstanceRefreshes</a>
        /// API. To describe the instance refreshes that have already run, call the <a>DescribeInstanceRefreshes</a>
        /// API. To cancel an instance refresh that is in progress, use the <a>CancelInstanceRefresh</a>
        /// API. 
        /// </para>
        ///  
        /// <para>
        /// An instance refresh might fail for several reasons, such as EC2 launch failures, misconfigured
        /// health checks, or not ignoring or allowing the termination of instances that are in
        /// <code>Standby</code> state or protected from scale in. You can monitor for failed
        /// EC2 launches using the scaling activities. To find the scaling activities, call the
        /// <a>DescribeScalingActivities</a> API.
        /// </para>
        ///  
        /// <para>
        /// If you enable auto rollback, your Auto Scaling group will be rolled back automatically
        /// when the instance refresh fails. You can enable this feature before starting an instance
        /// refresh by specifying the <code>AutoRollback</code> property in the instance refresh
        /// preferences. Otherwise, to roll back an instance refresh before it finishes, use the
        /// <a>RollbackInstanceRefresh</a> API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstanceRefresh service method.</param>
        /// 
        /// <returns>The response from the StartInstanceRefresh service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InstanceRefreshInProgressException">
        /// The request failed because an active instance refresh already exists for the specified
        /// Auto Scaling group.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/StartInstanceRefresh">REST API Reference for StartInstanceRefresh Operation</seealso>
        public virtual StartInstanceRefreshResponse StartInstanceRefresh(StartInstanceRefreshRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInstanceRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstanceRefreshResponseUnmarshaller.Instance;

            return Invoke<StartInstanceRefreshResponse>(request, options);
        }


        /// <summary>
        /// Starts an instance refresh. During an instance refresh, Amazon EC2 Auto Scaling performs
        /// a rolling update of instances in an Auto Scaling group. Instances are terminated first
        /// and then replaced, which temporarily reduces the capacity available within your Auto
        /// Scaling group.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-instance-refresh.html">instance
        /// refresh feature</a> in Amazon EC2 Auto Scaling, which helps you update instances in
        /// your Auto Scaling group. This feature is helpful, for example, when you have a new
        /// AMI or a new user data script. You just need to create a new launch template that
        /// specifies the new AMI or user data script. Then start an instance refresh to immediately
        /// begin the process of updating instances in the group. 
        /// </para>
        ///  
        /// <para>
        /// If successful, the request's response contains a unique ID that you can use to track
        /// the progress of the instance refresh. To query its status, call the <a>DescribeInstanceRefreshes</a>
        /// API. To describe the instance refreshes that have already run, call the <a>DescribeInstanceRefreshes</a>
        /// API. To cancel an instance refresh that is in progress, use the <a>CancelInstanceRefresh</a>
        /// API. 
        /// </para>
        ///  
        /// <para>
        /// An instance refresh might fail for several reasons, such as EC2 launch failures, misconfigured
        /// health checks, or not ignoring or allowing the termination of instances that are in
        /// <code>Standby</code> state or protected from scale in. You can monitor for failed
        /// EC2 launches using the scaling activities. To find the scaling activities, call the
        /// <a>DescribeScalingActivities</a> API.
        /// </para>
        ///  
        /// <para>
        /// If you enable auto rollback, your Auto Scaling group will be rolled back automatically
        /// when the instance refresh fails. You can enable this feature before starting an instance
        /// refresh by specifying the <code>AutoRollback</code> property in the instance refresh
        /// preferences. Otherwise, to roll back an instance refresh before it finishes, use the
        /// <a>RollbackInstanceRefresh</a> API. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstanceRefresh service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartInstanceRefresh service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InstanceRefreshInProgressException">
        /// The request failed because an active instance refresh already exists for the specified
        /// Auto Scaling group.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Amazon EC2 Auto Scaling resources (for example,
        /// Auto Scaling groups, launch configurations, or lifecycle hooks). For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/StartInstanceRefresh">REST API Reference for StartInstanceRefresh Operation</seealso>
        public virtual Task<StartInstanceRefreshResponse> StartInstanceRefreshAsync(StartInstanceRefreshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInstanceRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstanceRefreshResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartInstanceRefreshResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SuspendProcesses


        /// <summary>
        /// Suspends the specified auto scaling processes, or all processes, for the specified
        /// Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// If you suspend either the <code>Launch</code> or <code>Terminate</code> process types,
        /// it can prevent other process types from functioning properly. For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-suspend-resume-processes.html">Suspending
        /// and resuming scaling processes</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To resume processes that have been suspended, call the <a>ResumeProcesses</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses service method.</param>
        /// 
        /// <returns>The response from the SuspendProcesses service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SuspendProcesses">REST API Reference for SuspendProcesses Operation</seealso>
        public virtual SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SuspendProcessesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendProcessesResponseUnmarshaller.Instance;

            return Invoke<SuspendProcessesResponse>(request, options);
        }


        /// <summary>
        /// Suspends the specified auto scaling processes, or all processes, for the specified
        /// Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// If you suspend either the <code>Launch</code> or <code>Terminate</code> process types,
        /// it can prevent other process types from functioning properly. For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-suspend-resume-processes.html">Suspending
        /// and resuming scaling processes</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To resume processes that have been suspended, call the <a>ResumeProcesses</a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SuspendProcesses service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SuspendProcesses">REST API Reference for SuspendProcesses Operation</seealso>
        public virtual Task<SuspendProcessesResponse> SuspendProcessesAsync(SuspendProcessesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SuspendProcessesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendProcessesResponseUnmarshaller.Instance;
            
            return InvokeAsync<SuspendProcessesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateInstanceInAutoScalingGroup


        /// <summary>
        /// Terminates the specified instance and optionally adjusts the desired group size. This
        /// operation cannot be called on instances in a warm pool.
        /// 
        ///  
        /// <para>
        /// This call simply makes a termination request. The instance is not terminated immediately.
        /// When an instance is terminated, the instance status changes to <code>terminated</code>.
        /// You can't connect to or start an instance after you've terminated it.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify the option to decrement the desired capacity, Amazon EC2 Auto
        /// Scaling launches instances to replace the ones that are terminated. 
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon EC2 Auto Scaling balances instances across all Availability Zones.
        /// If you decrement the desired capacity, your Auto Scaling group can become unbalanced
        /// between Availability Zones. Amazon EC2 Auto Scaling tries to rebalance the group,
        /// and rebalancing might terminate instances in other zones. For more information, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/auto-scaling-benefits.html#AutoScalingBehavior.InstanceUsage">Rebalancing
        /// activities</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the TerminateInstanceInAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/TerminateInstanceInAutoScalingGroup">REST API Reference for TerminateInstanceInAutoScalingGroup Operation</seealso>
        public virtual TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateInstanceInAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateInstanceInAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<TerminateInstanceInAutoScalingGroupResponse>(request, options);
        }


        /// <summary>
        /// Terminates the specified instance and optionally adjusts the desired group size. This
        /// operation cannot be called on instances in a warm pool.
        /// 
        ///  
        /// <para>
        /// This call simply makes a termination request. The instance is not terminated immediately.
        /// When an instance is terminated, the instance status changes to <code>terminated</code>.
        /// You can't connect to or start an instance after you've terminated it.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify the option to decrement the desired capacity, Amazon EC2 Auto
        /// Scaling launches instances to replace the ones that are terminated. 
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon EC2 Auto Scaling balances instances across all Availability Zones.
        /// If you decrement the desired capacity, your Auto Scaling group can become unbalanced
        /// between Availability Zones. Amazon EC2 Auto Scaling tries to rebalance the group,
        /// and rebalancing might terminate instances in other zones. For more information, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/auto-scaling-benefits.html#AutoScalingBehavior.InstanceUsage">Rebalancing
        /// activities</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateInstanceInAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/TerminateInstanceInAutoScalingGroup">REST API Reference for TerminateInstanceInAutoScalingGroup Operation</seealso>
        public virtual Task<TerminateInstanceInAutoScalingGroupResponse> TerminateInstanceInAutoScalingGroupAsync(TerminateInstanceInAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateInstanceInAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateInstanceInAutoScalingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<TerminateInstanceInAutoScalingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAutoScalingGroup


        /// <summary>
        /// <b>We strongly recommend that all Auto Scaling groups use launch templates to ensure
        /// full functionality for Amazon EC2 Auto Scaling and Amazon EC2.</b> 
        /// 
        ///  
        /// <para>
        /// Updates the configuration for the specified Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// To update an Auto Scaling group, specify the name of the group and the property that
        /// you want to change. Any properties that you don't specify are not changed by this
        /// update request. The new settings take effect on any scaling activities after this
        /// call returns. 
        /// </para>
        ///  
        /// <para>
        /// If you associate a new launch configuration or template with an Auto Scaling group,
        /// all new instances will get the updated configuration. Existing instances continue
        /// to run with the configuration that they were originally launched with. When you update
        /// a group to specify a mixed instances policy instead of a launch configuration or template,
        /// existing instances may be replaced to match the new purchasing options that you specified
        /// in the policy. For example, if the group currently has 100% On-Demand capacity and
        /// the policy specifies 50% Spot capacity, this means that half of your instances will
        /// be gradually terminated and relaunched as Spot Instances. When replacing instances,
        /// Amazon EC2 Auto Scaling launches new instances before terminating the old ones, so
        /// that updating your group does not compromise the performance or availability of your
        /// application.
        /// </para>
        ///  
        /// <para>
        /// Note the following about changing <code>DesiredCapacity</code>, <code>MaxSize</code>,
        /// or <code>MinSize</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If a scale-in activity occurs as a result of a new <code>DesiredCapacity</code> value
        /// that is lower than the current size of the group, the Auto Scaling group uses its
        /// termination policy to determine which instances to terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a new value for <code>MinSize</code> without specifying a value for
        /// <code>DesiredCapacity</code>, and the new <code>MinSize</code> is larger than the
        /// current size of the group, this sets the group's <code>DesiredCapacity</code> to the
        /// new <code>MinSize</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a new value for <code>MaxSize</code> without specifying a value for
        /// <code>DesiredCapacity</code>, and the new <code>MaxSize</code> is smaller than the
        /// current size of the group, this sets the group's <code>DesiredCapacity</code> to the
        /// new <code>MaxSize</code> value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To see which properties have been set, call the <a>DescribeAutoScalingGroups</a> API.
        /// To view the scaling policies for an Auto Scaling group, call the <a>DescribePolicies</a>
        /// API. If the group has scaling policies, you can update them by calling the <a>PutScalingPolicy</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/UpdateAutoScalingGroup">REST API Reference for UpdateAutoScalingGroup Operation</seealso>
        public virtual UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateAutoScalingGroupResponse>(request, options);
        }


        /// <summary>
        /// <b>We strongly recommend that all Auto Scaling groups use launch templates to ensure
        /// full functionality for Amazon EC2 Auto Scaling and Amazon EC2.</b> 
        /// 
        ///  
        /// <para>
        /// Updates the configuration for the specified Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// To update an Auto Scaling group, specify the name of the group and the property that
        /// you want to change. Any properties that you don't specify are not changed by this
        /// update request. The new settings take effect on any scaling activities after this
        /// call returns. 
        /// </para>
        ///  
        /// <para>
        /// If you associate a new launch configuration or template with an Auto Scaling group,
        /// all new instances will get the updated configuration. Existing instances continue
        /// to run with the configuration that they were originally launched with. When you update
        /// a group to specify a mixed instances policy instead of a launch configuration or template,
        /// existing instances may be replaced to match the new purchasing options that you specified
        /// in the policy. For example, if the group currently has 100% On-Demand capacity and
        /// the policy specifies 50% Spot capacity, this means that half of your instances will
        /// be gradually terminated and relaunched as Spot Instances. When replacing instances,
        /// Amazon EC2 Auto Scaling launches new instances before terminating the old ones, so
        /// that updating your group does not compromise the performance or availability of your
        /// application.
        /// </para>
        ///  
        /// <para>
        /// Note the following about changing <code>DesiredCapacity</code>, <code>MaxSize</code>,
        /// or <code>MinSize</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If a scale-in activity occurs as a result of a new <code>DesiredCapacity</code> value
        /// that is lower than the current size of the group, the Auto Scaling group uses its
        /// termination policy to determine which instances to terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a new value for <code>MinSize</code> without specifying a value for
        /// <code>DesiredCapacity</code>, and the new <code>MinSize</code> is larger than the
        /// current size of the group, this sets the group's <code>DesiredCapacity</code> to the
        /// new <code>MinSize</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a new value for <code>MaxSize</code> without specifying a value for
        /// <code>DesiredCapacity</code>, and the new <code>MaxSize</code> is smaller than the
        /// current size of the group, this sets the group's <code>DesiredCapacity</code> to the
        /// new <code>MaxSize</code> value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To see which properties have been set, call the <a>DescribeAutoScalingGroups</a> API.
        /// To view the scaling policies for an Auto Scaling group, call the <a>DescribePolicies</a>
        /// API. If the group has scaling policies, you can update them by calling the <a>PutScalingPolicy</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Amazon EC2 Auto Scaling resource (for example,
        /// an Auto Scaling group, instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/UpdateAutoScalingGroup">REST API Reference for UpdateAutoScalingGroup Operation</seealso>
        public virtual Task<UpdateAutoScalingGroupResponse> UpdateAutoScalingGroupAsync(UpdateAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutoScalingGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAutoScalingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}