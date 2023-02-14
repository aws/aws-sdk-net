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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
        /// Initiates the asynchronous execution of the AttachInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInstances operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachInstances">REST API Reference for AttachInstances Operation</seealso>
        public virtual IAsyncResult BeginAttachInstances(AttachInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachInstances.</param>
        /// 
        /// <returns>Returns a  AttachInstancesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachInstances">REST API Reference for AttachInstances Operation</seealso>
        public virtual AttachInstancesResponse EndAttachInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachLoadBalancers

        /// <summary>
        /// <note> 
        /// <para>
        /// To attach an Application Load Balancer, Network Load Balancer, or Gateway Load Balancer,
        /// use the <a>AttachLoadBalancerTargetGroups</a> API operation instead.
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
        /// Initiates the asynchronous execution of the AttachLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancers operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachLoadBalancers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachLoadBalancers">REST API Reference for AttachLoadBalancers Operation</seealso>
        public virtual IAsyncResult BeginAttachLoadBalancers(AttachLoadBalancersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachLoadBalancers.</param>
        /// 
        /// <returns>Returns a  AttachLoadBalancersResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachLoadBalancers">REST API Reference for AttachLoadBalancers Operation</seealso>
        public virtual AttachLoadBalancersResponse EndAttachLoadBalancers(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachLoadBalancersResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachLoadBalancerTargetGroups

        /// <summary>
        /// Attaches one or more target groups to the specified Auto Scaling group.
        /// 
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
        /// Initiates the asynchronous execution of the AttachLoadBalancerTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerTargetGroups operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachLoadBalancerTargetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachLoadBalancerTargetGroups">REST API Reference for AttachLoadBalancerTargetGroups Operation</seealso>
        public virtual IAsyncResult BeginAttachLoadBalancerTargetGroups(AttachLoadBalancerTargetGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachLoadBalancerTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachLoadBalancerTargetGroups.</param>
        /// 
        /// <returns>Returns a  AttachLoadBalancerTargetGroupsResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachLoadBalancerTargetGroups">REST API Reference for AttachLoadBalancerTargetGroups Operation</seealso>
        public virtual AttachLoadBalancerTargetGroupsResponse EndAttachLoadBalancerTargetGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachLoadBalancerTargetGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachTrafficSources

        /// <summary>
        /// <b>Reserved for use with Amazon VPC Lattice, which is in preview and subject to change.
        /// Do not use this API for production workloads. This API is also subject to change.</b>
        /// 
        /// 
        ///  
        /// <para>
        /// Attaches one or more traffic sources to the specified Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// To describe the traffic sources for an Auto Scaling group, call the <a>DescribeTrafficSources</a>
        /// API. To detach a traffic source from the Auto Scaling group, call the <a>DetachTrafficSources</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// This operation is additive and does not detach existing traffic sources from the Auto
        /// Scaling group.
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
        /// Initiates the asynchronous execution of the AttachTrafficSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachTrafficSources operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachTrafficSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachTrafficSources">REST API Reference for AttachTrafficSources Operation</seealso>
        public virtual IAsyncResult BeginAttachTrafficSources(AttachTrafficSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachTrafficSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachTrafficSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachTrafficSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachTrafficSources.</param>
        /// 
        /// <returns>Returns a  AttachTrafficSourcesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachTrafficSources">REST API Reference for AttachTrafficSources Operation</seealso>
        public virtual AttachTrafficSourcesResponse EndAttachTrafficSources(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachTrafficSourcesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the BatchDeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteScheduledAction operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteScheduledAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/BatchDeleteScheduledAction">REST API Reference for BatchDeleteScheduledAction Operation</seealso>
        public virtual IAsyncResult BeginBatchDeleteScheduledAction(BatchDeleteScheduledActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteScheduledActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteScheduledAction.</param>
        /// 
        /// <returns>Returns a  BatchDeleteScheduledActionResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/BatchDeleteScheduledAction">REST API Reference for BatchDeleteScheduledAction Operation</seealso>
        public virtual BatchDeleteScheduledActionResponse EndBatchDeleteScheduledAction(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDeleteScheduledActionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the BatchPutScheduledUpdateGroupAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutScheduledUpdateGroupAction operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutScheduledUpdateGroupAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/BatchPutScheduledUpdateGroupAction">REST API Reference for BatchPutScheduledUpdateGroupAction Operation</seealso>
        public virtual IAsyncResult BeginBatchPutScheduledUpdateGroupAction(BatchPutScheduledUpdateGroupActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutScheduledUpdateGroupActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutScheduledUpdateGroupActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutScheduledUpdateGroupAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutScheduledUpdateGroupAction.</param>
        /// 
        /// <returns>Returns a  BatchPutScheduledUpdateGroupActionResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/BatchPutScheduledUpdateGroupAction">REST API Reference for BatchPutScheduledUpdateGroupAction Operation</seealso>
        public virtual BatchPutScheduledUpdateGroupActionResponse EndBatchPutScheduledUpdateGroupAction(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchPutScheduledUpdateGroupActionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CancelInstanceRefresh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelInstanceRefresh operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelInstanceRefresh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CancelInstanceRefresh">REST API Reference for CancelInstanceRefresh Operation</seealso>
        public virtual IAsyncResult BeginCancelInstanceRefresh(CancelInstanceRefreshRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelInstanceRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelInstanceRefreshResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelInstanceRefresh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelInstanceRefresh.</param>
        /// 
        /// <returns>Returns a  CancelInstanceRefreshResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CancelInstanceRefresh">REST API Reference for CancelInstanceRefresh Operation</seealso>
        public virtual CancelInstanceRefreshResponse EndCancelInstanceRefresh(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelInstanceRefreshResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CompleteLifecycleAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteLifecycleAction operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCompleteLifecycleAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CompleteLifecycleAction">REST API Reference for CompleteLifecycleAction Operation</seealso>
        public virtual IAsyncResult BeginCompleteLifecycleAction(CompleteLifecycleActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteLifecycleActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteLifecycleActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CompleteLifecycleAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteLifecycleAction.</param>
        /// 
        /// <returns>Returns a  CompleteLifecycleActionResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CompleteLifecycleAction">REST API Reference for CompleteLifecycleAction Operation</seealso>
        public virtual CompleteLifecycleActionResponse EndCompleteLifecycleAction(IAsyncResult asyncResult)
        {
            return EndInvoke<CompleteLifecycleActionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAutoScalingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateAutoScalingGroup">REST API Reference for CreateAutoScalingGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateAutoScalingGroup(CreateAutoScalingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutoScalingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutoScalingGroup.</param>
        /// 
        /// <returns>Returns a  CreateAutoScalingGroupResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateAutoScalingGroup">REST API Reference for CreateAutoScalingGroup Operation</seealso>
        public virtual CreateAutoScalingGroupResponse EndCreateAutoScalingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAutoScalingGroupResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLaunchConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateLaunchConfiguration">REST API Reference for CreateLaunchConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateLaunchConfiguration(CreateLaunchConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateLaunchConfigurationResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateLaunchConfiguration">REST API Reference for CreateLaunchConfiguration Operation</seealso>
        public virtual CreateLaunchConfigurationResponse EndCreateLaunchConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLaunchConfigurationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateOrUpdateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOrUpdateTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateOrUpdateTags">REST API Reference for CreateOrUpdateTags Operation</seealso>
        public virtual IAsyncResult BeginCreateOrUpdateTags(CreateOrUpdateTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOrUpdateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOrUpdateTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOrUpdateTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOrUpdateTags.</param>
        /// 
        /// <returns>Returns a  CreateOrUpdateTagsResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateOrUpdateTags">REST API Reference for CreateOrUpdateTags Operation</seealso>
        public virtual CreateOrUpdateTagsResponse EndCreateOrUpdateTags(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateOrUpdateTagsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAutoScalingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteAutoScalingGroup">REST API Reference for DeleteAutoScalingGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutoScalingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAutoScalingGroup.</param>
        /// 
        /// <returns>Returns a  DeleteAutoScalingGroupResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteAutoScalingGroup">REST API Reference for DeleteAutoScalingGroup Operation</seealso>
        public virtual DeleteAutoScalingGroupResponse EndDeleteAutoScalingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAutoScalingGroupResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLaunchConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteLaunchConfiguration">REST API Reference for DeleteLaunchConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteLaunchConfigurationResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteLaunchConfiguration">REST API Reference for DeleteLaunchConfiguration Operation</seealso>
        public virtual DeleteLaunchConfigurationResponse EndDeleteLaunchConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLaunchConfigurationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteLifecycleHook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleHook operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLifecycleHook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteLifecycleHook">REST API Reference for DeleteLifecycleHook Operation</seealso>
        public virtual IAsyncResult BeginDeleteLifecycleHook(DeleteLifecycleHookRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecycleHookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecycleHookResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLifecycleHook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLifecycleHook.</param>
        /// 
        /// <returns>Returns a  DeleteLifecycleHookResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteLifecycleHook">REST API Reference for DeleteLifecycleHook Operation</seealso>
        public virtual DeleteLifecycleHookResponse EndDeleteLifecycleHook(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLifecycleHookResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationConfigurationResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        public virtual DeleteNotificationConfigurationResponse EndDeleteNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNotificationConfigurationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual IAsyncResult BeginDeletePolicy(DeletePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicy.</param>
        /// 
        /// <returns>Returns a  DeletePolicyResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual DeletePolicyResponse EndDeletePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePolicyResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScheduledAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual IAsyncResult BeginDeleteScheduledAction(DeleteScheduledActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScheduledAction.</param>
        /// 
        /// <returns>Returns a  DeleteScheduledActionResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual DeleteScheduledActionResponse EndDeleteScheduledAction(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteScheduledActionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTagsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteWarmPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWarmPool operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWarmPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteWarmPool">REST API Reference for DeleteWarmPool Operation</seealso>
        public virtual IAsyncResult BeginDeleteWarmPool(DeleteWarmPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWarmPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWarmPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWarmPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWarmPool.</param>
        /// 
        /// <returns>Returns a  DeleteWarmPoolResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteWarmPool">REST API Reference for DeleteWarmPool Operation</seealso>
        public virtual DeleteWarmPoolResponse EndDeleteWarmPool(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWarmPoolResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountLimits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccountLimits(DescribeAccountLimitsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountLimits.</param>
        /// 
        /// <returns>Returns a  DescribeAccountLimitsResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual DescribeAccountLimitsResponse EndDescribeAccountLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountLimitsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeAdjustmentTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAdjustmentTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAdjustmentTypes">REST API Reference for DescribeAdjustmentTypes Operation</seealso>
        public virtual IAsyncResult BeginDescribeAdjustmentTypes(DescribeAdjustmentTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAdjustmentTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAdjustmentTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAdjustmentTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAdjustmentTypes.</param>
        /// 
        /// <returns>Returns a  DescribeAdjustmentTypesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAdjustmentTypes">REST API Reference for DescribeAdjustmentTypes Operation</seealso>
        public virtual DescribeAdjustmentTypesResponse EndDescribeAdjustmentTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAdjustmentTypesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeAutoScalingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAutoScalingGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingGroups">REST API Reference for DescribeAutoScalingGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutoScalingGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingGroups.</param>
        /// 
        /// <returns>Returns a  DescribeAutoScalingGroupsResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingGroups">REST API Reference for DescribeAutoScalingGroups Operation</seealso>
        public virtual DescribeAutoScalingGroupsResponse EndDescribeAutoScalingGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAutoScalingGroupsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeAutoScalingInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAutoScalingInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingInstances">REST API Reference for DescribeAutoScalingInstances Operation</seealso>
        public virtual IAsyncResult BeginDescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutoScalingInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingInstances.</param>
        /// 
        /// <returns>Returns a  DescribeAutoScalingInstancesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingInstances">REST API Reference for DescribeAutoScalingInstances Operation</seealso>
        public virtual DescribeAutoScalingInstancesResponse EndDescribeAutoScalingInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAutoScalingInstancesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeAutoScalingNotificationTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAutoScalingNotificationTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingNotificationTypes">REST API Reference for DescribeAutoScalingNotificationTypes Operation</seealso>
        public virtual IAsyncResult BeginDescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingNotificationTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingNotificationTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutoScalingNotificationTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingNotificationTypes.</param>
        /// 
        /// <returns>Returns a  DescribeAutoScalingNotificationTypesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingNotificationTypes">REST API Reference for DescribeAutoScalingNotificationTypes Operation</seealso>
        public virtual DescribeAutoScalingNotificationTypesResponse EndDescribeAutoScalingNotificationTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAutoScalingNotificationTypesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeInstanceRefreshes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceRefreshes operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceRefreshes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeInstanceRefreshes">REST API Reference for DescribeInstanceRefreshes Operation</seealso>
        public virtual IAsyncResult BeginDescribeInstanceRefreshes(DescribeInstanceRefreshesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceRefreshesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceRefreshesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceRefreshes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceRefreshes.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceRefreshesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeInstanceRefreshes">REST API Reference for DescribeInstanceRefreshes Operation</seealso>
        public virtual DescribeInstanceRefreshesResponse EndDescribeInstanceRefreshes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstanceRefreshesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeLaunchConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLaunchConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLaunchConfigurations">REST API Reference for DescribeLaunchConfigurations Operation</seealso>
        public virtual IAsyncResult BeginDescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLaunchConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLaunchConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeLaunchConfigurationsResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLaunchConfigurations">REST API Reference for DescribeLaunchConfigurations Operation</seealso>
        public virtual DescribeLaunchConfigurationsResponse EndDescribeLaunchConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLaunchConfigurationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeLifecycleHooks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHooks operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLifecycleHooks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLifecycleHooks">REST API Reference for DescribeLifecycleHooks Operation</seealso>
        public virtual IAsyncResult BeginDescribeLifecycleHooks(DescribeLifecycleHooksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLifecycleHooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLifecycleHooksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLifecycleHooks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLifecycleHooks.</param>
        /// 
        /// <returns>Returns a  DescribeLifecycleHooksResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLifecycleHooks">REST API Reference for DescribeLifecycleHooks Operation</seealso>
        public virtual DescribeLifecycleHooksResponse EndDescribeLifecycleHooks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLifecycleHooksResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeLifecycleHookTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHookTypes operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLifecycleHookTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLifecycleHookTypes">REST API Reference for DescribeLifecycleHookTypes Operation</seealso>
        public virtual IAsyncResult BeginDescribeLifecycleHookTypes(DescribeLifecycleHookTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLifecycleHookTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLifecycleHookTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLifecycleHookTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLifecycleHookTypes.</param>
        /// 
        /// <returns>Returns a  DescribeLifecycleHookTypesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLifecycleHookTypes">REST API Reference for DescribeLifecycleHookTypes Operation</seealso>
        public virtual DescribeLifecycleHookTypesResponse EndDescribeLifecycleHookTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLifecycleHookTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLoadBalancers

        /// <summary>
        /// Gets information about the load balancers for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// This operation describes only Classic Load Balancers. If you have Application Load
        /// Balancers, Network Load Balancers, or Gateway Load Balancer, use the <a>DescribeLoadBalancerTargetGroups</a>
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
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBalancers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        public virtual IAsyncResult BeginDescribeLoadBalancers(DescribeLoadBalancersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancers.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBalancersResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        public virtual DescribeLoadBalancersResponse EndDescribeLoadBalancers(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLoadBalancersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLoadBalancerTargetGroups

        /// <summary>
        /// Gets information about the Elastic Load Balancing target groups for the specified
        /// Auto Scaling group.
        /// 
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
        /// Initiates the asynchronous execution of the DescribeLoadBalancerTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerTargetGroups operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoadBalancerTargetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLoadBalancerTargetGroups">REST API Reference for DescribeLoadBalancerTargetGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeLoadBalancerTargetGroups(DescribeLoadBalancerTargetGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBalancerTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancerTargetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBalancerTargetGroupsResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLoadBalancerTargetGroups">REST API Reference for DescribeLoadBalancerTargetGroups Operation</seealso>
        public virtual DescribeLoadBalancerTargetGroupsResponse EndDescribeLoadBalancerTargetGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLoadBalancerTargetGroupsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeMetricCollectionTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMetricCollectionTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeMetricCollectionTypes">REST API Reference for DescribeMetricCollectionTypes Operation</seealso>
        public virtual IAsyncResult BeginDescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetricCollectionTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetricCollectionTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMetricCollectionTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMetricCollectionTypes.</param>
        /// 
        /// <returns>Returns a  DescribeMetricCollectionTypesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeMetricCollectionTypes">REST API Reference for DescribeMetricCollectionTypes Operation</seealso>
        public virtual DescribeMetricCollectionTypesResponse EndDescribeMetricCollectionTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMetricCollectionTypesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeNotificationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotificationConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeNotificationConfigurations">REST API Reference for DescribeNotificationConfigurations Operation</seealso>
        public virtual IAsyncResult BeginDescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotificationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotificationConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeNotificationConfigurationsResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeNotificationConfigurations">REST API Reference for DescribeNotificationConfigurations Operation</seealso>
        public virtual DescribeNotificationConfigurationsResponse EndDescribeNotificationConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNotificationConfigurationsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribePolicies">REST API Reference for DescribePolicies Operation</seealso>
        public virtual IAsyncResult BeginDescribePolicies(DescribePoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePolicies.</param>
        /// 
        /// <returns>Returns a  DescribePoliciesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribePolicies">REST API Reference for DescribePolicies Operation</seealso>
        public virtual DescribePoliciesResponse EndDescribePolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePoliciesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeScalingActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalingActivities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        public virtual IAsyncResult BeginDescribeScalingActivities(DescribeScalingActivitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingActivities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingActivities.</param>
        /// 
        /// <returns>Returns a  DescribeScalingActivitiesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        public virtual DescribeScalingActivitiesResponse EndDescribeScalingActivities(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScalingActivitiesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeScalingProcessTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalingProcessTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingProcessTypes">REST API Reference for DescribeScalingProcessTypes Operation</seealso>
        public virtual IAsyncResult BeginDescribeScalingProcessTypes(DescribeScalingProcessTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingProcessTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingProcessTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingProcessTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingProcessTypes.</param>
        /// 
        /// <returns>Returns a  DescribeScalingProcessTypesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingProcessTypes">REST API Reference for DescribeScalingProcessTypes Operation</seealso>
        public virtual DescribeScalingProcessTypesResponse EndDescribeScalingProcessTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScalingProcessTypesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeScheduledActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScheduledActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        public virtual IAsyncResult BeginDescribeScheduledActions(DescribeScheduledActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScheduledActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScheduledActions.</param>
        /// 
        /// <returns>Returns a  DescribeScheduledActionsResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        public virtual DescribeScheduledActionsResponse EndDescribeScheduledActions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScheduledActionsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTagsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeTerminationPolicyTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTerminationPolicyTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTerminationPolicyTypes">REST API Reference for DescribeTerminationPolicyTypes Operation</seealso>
        public virtual IAsyncResult BeginDescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTerminationPolicyTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTerminationPolicyTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTerminationPolicyTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTerminationPolicyTypes.</param>
        /// 
        /// <returns>Returns a  DescribeTerminationPolicyTypesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTerminationPolicyTypes">REST API Reference for DescribeTerminationPolicyTypes Operation</seealso>
        public virtual DescribeTerminationPolicyTypesResponse EndDescribeTerminationPolicyTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTerminationPolicyTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTrafficSources

        /// <summary>
        /// <b>Reserved for use with Amazon VPC Lattice, which is in preview and subject to change.
        /// Do not use this API for production workloads. This API is also subject to change.</b>
        /// 
        /// 
        ///  
        /// <para>
        /// Gets information about the traffic sources for the specified Auto Scaling group.
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
        /// Initiates the asynchronous execution of the DescribeTrafficSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrafficSources operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrafficSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTrafficSources">REST API Reference for DescribeTrafficSources Operation</seealso>
        public virtual IAsyncResult BeginDescribeTrafficSources(DescribeTrafficSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrafficSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrafficSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrafficSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrafficSources.</param>
        /// 
        /// <returns>Returns a  DescribeTrafficSourcesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTrafficSources">REST API Reference for DescribeTrafficSources Operation</seealso>
        public virtual DescribeTrafficSourcesResponse EndDescribeTrafficSources(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTrafficSourcesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeWarmPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWarmPool operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWarmPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeWarmPool">REST API Reference for DescribeWarmPool Operation</seealso>
        public virtual IAsyncResult BeginDescribeWarmPool(DescribeWarmPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWarmPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWarmPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWarmPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWarmPool.</param>
        /// 
        /// <returns>Returns a  DescribeWarmPoolResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeWarmPool">REST API Reference for DescribeWarmPool Operation</seealso>
        public virtual DescribeWarmPoolResponse EndDescribeWarmPool(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeWarmPoolResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DetachInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInstances operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachInstances">REST API Reference for DetachInstances Operation</seealso>
        public virtual IAsyncResult BeginDetachInstances(DetachInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachInstances.</param>
        /// 
        /// <returns>Returns a  DetachInstancesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachInstances">REST API Reference for DetachInstances Operation</seealso>
        public virtual DetachInstancesResponse EndDetachInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachLoadBalancers

        /// <summary>
        /// Detaches one or more Classic Load Balancers from the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// This operation detaches only Classic Load Balancers. If you have Application Load
        /// Balancers, Network Load Balancers, or Gateway Load Balancer, use the <a>DetachLoadBalancerTargetGroups</a>
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
        /// Initiates the asynchronous execution of the DetachLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancers operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachLoadBalancers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachLoadBalancers">REST API Reference for DetachLoadBalancers Operation</seealso>
        public virtual IAsyncResult BeginDetachLoadBalancers(DetachLoadBalancersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachLoadBalancersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachLoadBalancers.</param>
        /// 
        /// <returns>Returns a  DetachLoadBalancersResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachLoadBalancers">REST API Reference for DetachLoadBalancers Operation</seealso>
        public virtual DetachLoadBalancersResponse EndDetachLoadBalancers(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachLoadBalancersResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachLoadBalancerTargetGroups

        /// <summary>
        /// Detaches one or more target groups from the specified Auto Scaling group.
        /// 
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
        /// Initiates the asynchronous execution of the DetachLoadBalancerTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerTargetGroups operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachLoadBalancerTargetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachLoadBalancerTargetGroups">REST API Reference for DetachLoadBalancerTargetGroups Operation</seealso>
        public virtual IAsyncResult BeginDetachLoadBalancerTargetGroups(DetachLoadBalancerTargetGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachLoadBalancerTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachLoadBalancerTargetGroups.</param>
        /// 
        /// <returns>Returns a  DetachLoadBalancerTargetGroupsResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachLoadBalancerTargetGroups">REST API Reference for DetachLoadBalancerTargetGroups Operation</seealso>
        public virtual DetachLoadBalancerTargetGroupsResponse EndDetachLoadBalancerTargetGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachLoadBalancerTargetGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachTrafficSources

        /// <summary>
        /// <b>Reserved for use with Amazon VPC Lattice, which is in preview and subject to change.
        /// Do not use this API for production workloads. This API is also subject to change.</b>
        /// 
        /// 
        ///  
        /// <para>
        /// Detaches one or more traffic sources from the specified Auto Scaling group.
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
        /// Initiates the asynchronous execution of the DetachTrafficSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachTrafficSources operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachTrafficSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachTrafficSources">REST API Reference for DetachTrafficSources Operation</seealso>
        public virtual IAsyncResult BeginDetachTrafficSources(DetachTrafficSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachTrafficSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachTrafficSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachTrafficSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachTrafficSources.</param>
        /// 
        /// <returns>Returns a  DetachTrafficSourcesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachTrafficSources">REST API Reference for DetachTrafficSources Operation</seealso>
        public virtual DetachTrafficSourcesResponse EndDetachTrafficSources(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachTrafficSourcesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DisableMetricsCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableMetricsCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DisableMetricsCollection">REST API Reference for DisableMetricsCollection Operation</seealso>
        public virtual IAsyncResult BeginDisableMetricsCollection(DisableMetricsCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableMetricsCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableMetricsCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableMetricsCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableMetricsCollection.</param>
        /// 
        /// <returns>Returns a  DisableMetricsCollectionResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DisableMetricsCollection">REST API Reference for DisableMetricsCollection Operation</seealso>
        public virtual DisableMetricsCollectionResponse EndDisableMetricsCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableMetricsCollectionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the EnableMetricsCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableMetricsCollection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/EnableMetricsCollection">REST API Reference for EnableMetricsCollection Operation</seealso>
        public virtual IAsyncResult BeginEnableMetricsCollection(EnableMetricsCollectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableMetricsCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableMetricsCollectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableMetricsCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableMetricsCollection.</param>
        /// 
        /// <returns>Returns a  EnableMetricsCollectionResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/EnableMetricsCollection">REST API Reference for EnableMetricsCollection Operation</seealso>
        public virtual EnableMetricsCollectionResponse EndEnableMetricsCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableMetricsCollectionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the EnterStandby operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnterStandby operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnterStandby
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/EnterStandby">REST API Reference for EnterStandby Operation</seealso>
        public virtual IAsyncResult BeginEnterStandby(EnterStandbyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnterStandbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnterStandbyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnterStandby operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnterStandby.</param>
        /// 
        /// <returns>Returns a  EnterStandbyResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/EnterStandby">REST API Reference for EnterStandby Operation</seealso>
        public virtual EnterStandbyResponse EndEnterStandby(IAsyncResult asyncResult)
        {
            return EndInvoke<EnterStandbyResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ExecutePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecutePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ExecutePolicy">REST API Reference for ExecutePolicy Operation</seealso>
        public virtual IAsyncResult BeginExecutePolicy(ExecutePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecutePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecutePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExecutePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecutePolicy.</param>
        /// 
        /// <returns>Returns a  ExecutePolicyResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ExecutePolicy">REST API Reference for ExecutePolicy Operation</seealso>
        public virtual ExecutePolicyResponse EndExecutePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<ExecutePolicyResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ExitStandby operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExitStandby operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExitStandby
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ExitStandby">REST API Reference for ExitStandby Operation</seealso>
        public virtual IAsyncResult BeginExitStandby(ExitStandbyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExitStandbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExitStandbyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExitStandby operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExitStandby.</param>
        /// 
        /// <returns>Returns a  ExitStandbyResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ExitStandby">REST API Reference for ExitStandby Operation</seealso>
        public virtual ExitStandbyResponse EndExitStandby(IAsyncResult asyncResult)
        {
            return EndInvoke<ExitStandbyResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetPredictiveScalingForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPredictiveScalingForecast operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPredictiveScalingForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/GetPredictiveScalingForecast">REST API Reference for GetPredictiveScalingForecast Operation</seealso>
        public virtual IAsyncResult BeginGetPredictiveScalingForecast(GetPredictiveScalingForecastRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPredictiveScalingForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPredictiveScalingForecastResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPredictiveScalingForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPredictiveScalingForecast.</param>
        /// 
        /// <returns>Returns a  GetPredictiveScalingForecastResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/GetPredictiveScalingForecast">REST API Reference for GetPredictiveScalingForecast Operation</seealso>
        public virtual GetPredictiveScalingForecastResponse EndGetPredictiveScalingForecast(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPredictiveScalingForecastResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PutLifecycleHook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleHook operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLifecycleHook
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutLifecycleHook">REST API Reference for PutLifecycleHook Operation</seealso>
        public virtual IAsyncResult BeginPutLifecycleHook(PutLifecycleHookRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecycleHookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleHookResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutLifecycleHook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLifecycleHook.</param>
        /// 
        /// <returns>Returns a  PutLifecycleHookResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutLifecycleHook">REST API Reference for PutLifecycleHook Operation</seealso>
        public virtual PutLifecycleHookResponse EndPutLifecycleHook(IAsyncResult asyncResult)
        {
            return EndInvoke<PutLifecycleHookResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PutNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutNotificationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutNotificationConfiguration">REST API Reference for PutNotificationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutNotificationConfiguration(PutNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  PutNotificationConfigurationResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutNotificationConfiguration">REST API Reference for PutNotificationConfiguration Operation</seealso>
        public virtual PutNotificationConfigurationResponse EndPutNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutNotificationConfigurationResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutScalingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutScalingPolicy(PutScalingPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScalingPolicy.</param>
        /// 
        /// <returns>Returns a  PutScalingPolicyResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public virtual PutScalingPolicyResponse EndPutScalingPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutScalingPolicyResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PutScheduledUpdateGroupAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutScheduledUpdateGroupAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutScheduledUpdateGroupAction">REST API Reference for PutScheduledUpdateGroupAction Operation</seealso>
        public virtual IAsyncResult BeginPutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScheduledUpdateGroupActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScheduledUpdateGroupActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutScheduledUpdateGroupAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScheduledUpdateGroupAction.</param>
        /// 
        /// <returns>Returns a  PutScheduledUpdateGroupActionResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutScheduledUpdateGroupAction">REST API Reference for PutScheduledUpdateGroupAction Operation</seealso>
        public virtual PutScheduledUpdateGroupActionResponse EndPutScheduledUpdateGroupAction(IAsyncResult asyncResult)
        {
            return EndInvoke<PutScheduledUpdateGroupActionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the PutWarmPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutWarmPool operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutWarmPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutWarmPool">REST API Reference for PutWarmPool Operation</seealso>
        public virtual IAsyncResult BeginPutWarmPool(PutWarmPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutWarmPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWarmPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutWarmPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutWarmPool.</param>
        /// 
        /// <returns>Returns a  PutWarmPoolResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutWarmPool">REST API Reference for PutWarmPool Operation</seealso>
        public virtual PutWarmPoolResponse EndPutWarmPool(IAsyncResult asyncResult)
        {
            return EndInvoke<PutWarmPoolResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the RecordLifecycleActionHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecordLifecycleActionHeartbeat operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRecordLifecycleActionHeartbeat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/RecordLifecycleActionHeartbeat">REST API Reference for RecordLifecycleActionHeartbeat Operation</seealso>
        public virtual IAsyncResult BeginRecordLifecycleActionHeartbeat(RecordLifecycleActionHeartbeatRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecordLifecycleActionHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecordLifecycleActionHeartbeatResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RecordLifecycleActionHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecordLifecycleActionHeartbeat.</param>
        /// 
        /// <returns>Returns a  RecordLifecycleActionHeartbeatResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/RecordLifecycleActionHeartbeat">REST API Reference for RecordLifecycleActionHeartbeat Operation</seealso>
        public virtual RecordLifecycleActionHeartbeatResponse EndRecordLifecycleActionHeartbeat(IAsyncResult asyncResult)
        {
            return EndInvoke<RecordLifecycleActionHeartbeatResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ResumeProcesses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeProcesses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ResumeProcesses">REST API Reference for ResumeProcesses Operation</seealso>
        public virtual IAsyncResult BeginResumeProcesses(ResumeProcessesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeProcessesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeProcessesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeProcesses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeProcesses.</param>
        /// 
        /// <returns>Returns a  ResumeProcessesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ResumeProcesses">REST API Reference for ResumeProcesses Operation</seealso>
        public virtual ResumeProcessesResponse EndResumeProcesses(IAsyncResult asyncResult)
        {
            return EndInvoke<ResumeProcessesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the RollbackInstanceRefresh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RollbackInstanceRefresh operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRollbackInstanceRefresh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/RollbackInstanceRefresh">REST API Reference for RollbackInstanceRefresh Operation</seealso>
        public virtual IAsyncResult BeginRollbackInstanceRefresh(RollbackInstanceRefreshRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RollbackInstanceRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RollbackInstanceRefreshResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RollbackInstanceRefresh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRollbackInstanceRefresh.</param>
        /// 
        /// <returns>Returns a  RollbackInstanceRefreshResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/RollbackInstanceRefresh">REST API Reference for RollbackInstanceRefresh Operation</seealso>
        public virtual RollbackInstanceRefreshResponse EndRollbackInstanceRefresh(IAsyncResult asyncResult)
        {
            return EndInvoke<RollbackInstanceRefreshResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the SetDesiredCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetDesiredCapacity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetDesiredCapacity">REST API Reference for SetDesiredCapacity Operation</seealso>
        public virtual IAsyncResult BeginSetDesiredCapacity(SetDesiredCapacityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDesiredCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDesiredCapacityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetDesiredCapacity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetDesiredCapacity.</param>
        /// 
        /// <returns>Returns a  SetDesiredCapacityResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetDesiredCapacity">REST API Reference for SetDesiredCapacity Operation</seealso>
        public virtual SetDesiredCapacityResponse EndSetDesiredCapacity(IAsyncResult asyncResult)
        {
            return EndInvoke<SetDesiredCapacityResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the SetInstanceHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetInstanceHealth
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetInstanceHealth">REST API Reference for SetInstanceHealth Operation</seealso>
        public virtual IAsyncResult BeginSetInstanceHealth(SetInstanceHealthRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetInstanceHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetInstanceHealthResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetInstanceHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetInstanceHealth.</param>
        /// 
        /// <returns>Returns a  SetInstanceHealthResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetInstanceHealth">REST API Reference for SetInstanceHealth Operation</seealso>
        public virtual SetInstanceHealthResponse EndSetInstanceHealth(IAsyncResult asyncResult)
        {
            return EndInvoke<SetInstanceHealthResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the SetInstanceProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceProtection operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetInstanceProtection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetInstanceProtection">REST API Reference for SetInstanceProtection Operation</seealso>
        public virtual IAsyncResult BeginSetInstanceProtection(SetInstanceProtectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetInstanceProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetInstanceProtectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetInstanceProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetInstanceProtection.</param>
        /// 
        /// <returns>Returns a  SetInstanceProtectionResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetInstanceProtection">REST API Reference for SetInstanceProtection Operation</seealso>
        public virtual SetInstanceProtectionResponse EndSetInstanceProtection(IAsyncResult asyncResult)
        {
            return EndInvoke<SetInstanceProtectionResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the StartInstanceRefresh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstanceRefresh operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInstanceRefresh
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/StartInstanceRefresh">REST API Reference for StartInstanceRefresh Operation</seealso>
        public virtual IAsyncResult BeginStartInstanceRefresh(StartInstanceRefreshRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInstanceRefreshRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstanceRefreshResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartInstanceRefresh operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstanceRefresh.</param>
        /// 
        /// <returns>Returns a  StartInstanceRefreshResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/StartInstanceRefresh">REST API Reference for StartInstanceRefresh Operation</seealso>
        public virtual StartInstanceRefreshResponse EndStartInstanceRefresh(IAsyncResult asyncResult)
        {
            return EndInvoke<StartInstanceRefreshResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the SuspendProcesses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSuspendProcesses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SuspendProcesses">REST API Reference for SuspendProcesses Operation</seealso>
        public virtual IAsyncResult BeginSuspendProcesses(SuspendProcessesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SuspendProcessesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendProcessesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SuspendProcesses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSuspendProcesses.</param>
        /// 
        /// <returns>Returns a  SuspendProcessesResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SuspendProcesses">REST API Reference for SuspendProcesses Operation</seealso>
        public virtual SuspendProcessesResponse EndSuspendProcesses(IAsyncResult asyncResult)
        {
            return EndInvoke<SuspendProcessesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the TerminateInstanceInAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateInstanceInAutoScalingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/TerminateInstanceInAutoScalingGroup">REST API Reference for TerminateInstanceInAutoScalingGroup Operation</seealso>
        public virtual IAsyncResult BeginTerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateInstanceInAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateInstanceInAutoScalingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateInstanceInAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateInstanceInAutoScalingGroup.</param>
        /// 
        /// <returns>Returns a  TerminateInstanceInAutoScalingGroupResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/TerminateInstanceInAutoScalingGroup">REST API Reference for TerminateInstanceInAutoScalingGroup Operation</seealso>
        public virtual TerminateInstanceInAutoScalingGroupResponse EndTerminateInstanceInAutoScalingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateInstanceInAutoScalingGroupResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup operation on AmazonAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAutoScalingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/UpdateAutoScalingGroup">REST API Reference for UpdateAutoScalingGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutoScalingGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAutoScalingGroup.</param>
        /// 
        /// <returns>Returns a  UpdateAutoScalingGroupResult from AutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/UpdateAutoScalingGroup">REST API Reference for UpdateAutoScalingGroup Operation</seealso>
        public virtual UpdateAutoScalingGroupResponse EndUpdateAutoScalingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAutoScalingGroupResponse>(asyncResult);
        }

        #endregion
        
    }
}