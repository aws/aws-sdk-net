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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.AutoScaling.Model;
using Amazon.AutoScaling.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScaling
{
    /// <summary>
    /// Implementation for accessing AutoScaling
    ///
    /// Auto Scaling 
    /// <para>
    /// Auto Scaling is designed to automatically launch or terminate EC2 instances based
    /// on user-defined policies, schedules, and health checks. Use this service in conjunction
    /// with the Amazon CloudWatch and Elastic Load Balancing services.
    /// </para>
    /// </summary>
    public partial class AmazonAutoScalingClient : AmazonServiceClient, IAmazonAutoScaling
    {
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
        /// When you attach instances, Auto Scaling increases the desired capacity of the group
        /// by the number of instances being attached. If the number of instances being attached
        /// plus the desired capacity of the group exceeds the maximum size of the group, the
        /// operation fails.
        /// </para>
        ///  
        /// <para>
        /// If there is a Classic load balancer attached to your Auto Scaling group, the instances
        /// are also registered with the load balancer. If there are target groups attached to
        /// your Auto Scaling group, the instances are also registered with the target groups.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/attach-instance-asg.html">Attach
        /// EC2 Instances to Your Auto Scaling Group</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInstances service method.</param>
        /// 
        /// <returns>The response from the AttachInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public AttachInstancesResponse AttachInstances(AttachInstancesRequest request)
        {
            var marshaller = new AttachInstancesRequestMarshaller();
            var unmarshaller = AttachInstancesResponseUnmarshaller.Instance;

            return Invoke<AttachInstancesRequest,AttachInstancesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginAttachInstances(AttachInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachInstancesRequestMarshaller();
            var unmarshaller = AttachInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<AttachInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachInstances.</param>
        /// 
        /// <returns>Returns a  AttachInstancesResult from AutoScaling.</returns>
        public  AttachInstancesResponse EndAttachInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachLoadBalancers

        /// <summary>
        /// Attaches one or more Classic load balancers to the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// To attach an Application load balancer instead, see <a>AttachLoadBalancerTargetGroups</a>.
        /// </para>
        ///  
        /// <para>
        /// To describe the load balancers for an Auto Scaling group, use <a>DescribeLoadBalancers</a>.
        /// To detach the load balancer from the Auto Scaling group, use <a>DetachLoadBalancers</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/attach-load-balancer-asg.html">Attach
        /// a Load Balancer to Your Auto Scaling Group</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public AttachLoadBalancersResponse AttachLoadBalancers(AttachLoadBalancersRequest request)
        {
            var marshaller = new AttachLoadBalancersRequestMarshaller();
            var unmarshaller = AttachLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<AttachLoadBalancersRequest,AttachLoadBalancersResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginAttachLoadBalancers(AttachLoadBalancersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachLoadBalancersRequestMarshaller();
            var unmarshaller = AttachLoadBalancersResponseUnmarshaller.Instance;

            return BeginInvoke<AttachLoadBalancersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachLoadBalancers.</param>
        /// 
        /// <returns>Returns a  AttachLoadBalancersResult from AutoScaling.</returns>
        public  AttachLoadBalancersResponse EndAttachLoadBalancers(IAsyncResult asyncResult)
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
        /// To describe the target groups for an Auto Scaling group, use <a>DescribeLoadBalancerTargetGroups</a>.
        /// To detach the target group from the Auto Scaling group, use <a>DetachLoadBalancerTargetGroups</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/attach-load-balancer-asg.html">Attach
        /// a Load Balancer to Your Auto Scaling Group</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerTargetGroups service method.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public AttachLoadBalancerTargetGroupsResponse AttachLoadBalancerTargetGroups(AttachLoadBalancerTargetGroupsRequest request)
        {
            var marshaller = new AttachLoadBalancerTargetGroupsRequestMarshaller();
            var unmarshaller = AttachLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<AttachLoadBalancerTargetGroupsRequest,AttachLoadBalancerTargetGroupsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginAttachLoadBalancerTargetGroups(AttachLoadBalancerTargetGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachLoadBalancerTargetGroupsRequestMarshaller();
            var unmarshaller = AttachLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<AttachLoadBalancerTargetGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachLoadBalancerTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachLoadBalancerTargetGroups.</param>
        /// 
        /// <returns>Returns a  AttachLoadBalancerTargetGroupsResult from AutoScaling.</returns>
        public  AttachLoadBalancerTargetGroupsResponse EndAttachLoadBalancerTargetGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachLoadBalancerTargetGroupsResponse>(asyncResult);
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
        /// (Optional) Create a Lambda function and a rule that allows CloudWatch Events to invoke
        /// your Lambda function when Auto Scaling launches or terminates instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Auto Scaling to publish
        /// lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the lifecycle hook. Specify whether the hook is used when the instances launch
        /// or terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a pending state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If you finish before the timeout period ends, complete the lifecycle action.</b>
        /// 
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingGroupLifecycle.html">Auto
        /// Scaling Lifecycle</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteLifecycleAction service method.</param>
        /// 
        /// <returns>The response from the CompleteLifecycleAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public CompleteLifecycleActionResponse CompleteLifecycleAction(CompleteLifecycleActionRequest request)
        {
            var marshaller = new CompleteLifecycleActionRequestMarshaller();
            var unmarshaller = CompleteLifecycleActionResponseUnmarshaller.Instance;

            return Invoke<CompleteLifecycleActionRequest,CompleteLifecycleActionResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginCompleteLifecycleAction(CompleteLifecycleActionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CompleteLifecycleActionRequestMarshaller();
            var unmarshaller = CompleteLifecycleActionResponseUnmarshaller.Instance;

            return BeginInvoke<CompleteLifecycleActionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CompleteLifecycleAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteLifecycleAction.</param>
        /// 
        /// <returns>Returns a  CompleteLifecycleActionResult from AutoScaling.</returns>
        public  CompleteLifecycleActionResponse EndCompleteLifecycleAction(IAsyncResult asyncResult)
        {
            return EndInvoke<CompleteLifecycleActionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAutoScalingGroup

        /// <summary>
        /// Creates an Auto Scaling group with the specified name and attributes.
        /// 
        ///  
        /// <para>
        /// If you exceed your maximum limit of Auto Scaling groups, which by default is 20 per
        /// region, the call fails. For information about viewing and updating this limit, see
        /// <a>DescribeAccountLimits</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingGroup.html">Auto
        /// Scaling Groups</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Auto Scaling resources (for example, groups,
        /// launch configurations, or lifecycle hooks). For more information, see <a>DescribeAccountLimits</a>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest request)
        {
            var marshaller = new CreateAutoScalingGroupRequestMarshaller();
            var unmarshaller = CreateAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateAutoScalingGroupRequest,CreateAutoScalingGroupResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginCreateAutoScalingGroup(CreateAutoScalingGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateAutoScalingGroupRequestMarshaller();
            var unmarshaller = CreateAutoScalingGroupResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAutoScalingGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAutoScalingGroup.</param>
        /// 
        /// <returns>Returns a  CreateAutoScalingGroupResult from AutoScaling.</returns>
        public  CreateAutoScalingGroupResponse EndCreateAutoScalingGroup(IAsyncResult asyncResult)
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
        /// If you exceed your maximum limit of launch configurations, which by default is 100
        /// per region, the call fails. For information about viewing and updating this limit,
        /// see <a>DescribeAccountLimits</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/LaunchConfiguration.html">Launch
        /// Configurations</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Auto Scaling resources (for example, groups,
        /// launch configurations, or lifecycle hooks). For more information, see <a>DescribeAccountLimits</a>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest request)
        {
            var marshaller = new CreateLaunchConfigurationRequestMarshaller();
            var unmarshaller = CreateLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateLaunchConfigurationRequest,CreateLaunchConfigurationResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginCreateLaunchConfiguration(CreateLaunchConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateLaunchConfigurationRequestMarshaller();
            var unmarshaller = CreateLaunchConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<CreateLaunchConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateLaunchConfigurationResult from AutoScaling.</returns>
        public  CreateLaunchConfigurationResponse EndCreateLaunchConfiguration(IAsyncResult asyncResult)
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
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASTagging.html">Tagging
        /// Auto Scaling Groups and Instances</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags service method.</param>
        /// 
        /// <returns>The response from the CreateOrUpdateTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Auto Scaling resources (for example, groups,
        /// launch configurations, or lifecycle hooks). For more information, see <a>DescribeAccountLimits</a>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest request)
        {
            var marshaller = new CreateOrUpdateTagsRequestMarshaller();
            var unmarshaller = CreateOrUpdateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateOrUpdateTagsRequest,CreateOrUpdateTagsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginCreateOrUpdateTags(CreateOrUpdateTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateOrUpdateTagsRequestMarshaller();
            var unmarshaller = CreateOrUpdateTagsResponseUnmarshaller.Instance;

            return BeginInvoke<CreateOrUpdateTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOrUpdateTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOrUpdateTags.</param>
        /// 
        /// <returns>Returns a  CreateOrUpdateTagsResult from AutoScaling.</returns>
        public  CreateOrUpdateTagsResponse EndCreateOrUpdateTags(IAsyncResult asyncResult)
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
        /// option to force the deletion in order for it to succeed.
        /// </para>
        ///  
        /// <para>
        /// If the group has policies, deleting the group deletes the policies, the underlying
        /// alarm actions, and any alarm that no longer has an associated action.
        /// </para>
        ///  
        /// <para>
        /// To remove instances from the Auto Scaling group before deleting it, call <a>DetachInstances</a>
        /// with the list of instances and the option to decrement the desired capacity so that
        /// Auto Scaling does not launch replacement instances.
        /// </para>
        ///  
        /// <para>
        /// To terminate all instances before deleting the Auto Scaling group, call <a>UpdateAutoScalingGroup</a>
        /// and set the minimum size and desired capacity of the Auto Scaling group to zero.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        public DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request)
        {
            var marshaller = new DeleteAutoScalingGroupRequestMarshaller();
            var unmarshaller = DeleteAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteAutoScalingGroupRequest,DeleteAutoScalingGroupResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteAutoScalingGroupRequestMarshaller();
            var unmarshaller = DeleteAutoScalingGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAutoScalingGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAutoScalingGroup.</param>
        /// 
        /// <returns>Returns a  DeleteAutoScalingGroupResult from AutoScaling.</returns>
        public  DeleteAutoScalingGroupResponse EndDeleteAutoScalingGroup(IAsyncResult asyncResult)
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
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        public DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request)
        {
            var marshaller = new DeleteLaunchConfigurationRequestMarshaller();
            var unmarshaller = DeleteLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLaunchConfigurationRequest,DeleteLaunchConfigurationResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteLaunchConfigurationRequestMarshaller();
            var unmarshaller = DeleteLaunchConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteLaunchConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteLaunchConfigurationResult from AutoScaling.</returns>
        public  DeleteLaunchConfigurationResponse EndDeleteLaunchConfiguration(IAsyncResult asyncResult)
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
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DeleteLifecycleHookResponse DeleteLifecycleHook(DeleteLifecycleHookRequest request)
        {
            var marshaller = new DeleteLifecycleHookRequestMarshaller();
            var unmarshaller = DeleteLifecycleHookResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecycleHookRequest,DeleteLifecycleHookResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDeleteLifecycleHook(DeleteLifecycleHookRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteLifecycleHookRequestMarshaller();
            var unmarshaller = DeleteLifecycleHookResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteLifecycleHookRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLifecycleHook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLifecycleHook.</param>
        /// 
        /// <returns>Returns a  DeleteLifecycleHookResult from AutoScaling.</returns>
        public  DeleteLifecycleHookResponse EndDeleteLifecycleHook(IAsyncResult asyncResult)
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
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request)
        {
            var marshaller = new DeleteNotificationConfigurationRequestMarshaller();
            var unmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationConfigurationRequest,DeleteNotificationConfigurationResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteNotificationConfigurationRequestMarshaller();
            var unmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteNotificationConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteNotificationConfigurationResult from AutoScaling.</returns>
        public  DeleteNotificationConfigurationResponse EndDeleteNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNotificationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePolicy

        /// <summary>
        /// Deletes the specified Auto Scaling policy.
        /// 
        ///  
        /// <para>
        /// Deleting a policy deletes the underlying alarm action, but does not delete the alarm,
        /// even if it no longer has an associated action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var marshaller = new DeletePolicyRequestMarshaller();
            var unmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyRequest,DeletePolicyResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDeletePolicy(DeletePolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeletePolicyRequestMarshaller();
            var unmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return BeginInvoke<DeletePolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicy.</param>
        /// 
        /// <returns>Returns a  DeletePolicyResult from AutoScaling.</returns>
        public  DeletePolicyResponse EndDeletePolicy(IAsyncResult asyncResult)
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
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request)
        {
            var marshaller = new DeleteScheduledActionRequestMarshaller();
            var unmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduledActionRequest,DeleteScheduledActionResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDeleteScheduledAction(DeleteScheduledActionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteScheduledActionRequestMarshaller();
            var unmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteScheduledActionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScheduledAction.</param>
        /// 
        /// <returns>Returns a  DeleteScheduledActionResult from AutoScaling.</returns>
        public  DeleteScheduledActionResponse EndDeleteScheduledAction(IAsyncResult asyncResult)
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
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from AutoScaling.</returns>
        public  DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountLimits

        /// <summary>
        /// Describes the current Auto Scaling resource limits for your AWS account.
        /// 
        ///  
        /// <para>
        /// For information about requesting an increase in these limits, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">AWS
        /// Service Limits</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeAccountLimitsResponse DescribeAccountLimits()
        {
            return DescribeAccountLimits(new DescribeAccountLimitsRequest());
        }

        /// <summary>
        /// Describes the current Auto Scaling resource limits for your AWS account.
        /// 
        ///  
        /// <para>
        /// For information about requesting an increase in these limits, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">AWS
        /// Service Limits</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var marshaller = new DescribeAccountLimitsRequestMarshaller();
            var unmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountLimitsRequest,DescribeAccountLimitsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeAccountLimits(DescribeAccountLimitsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAccountLimitsRequestMarshaller();
            var unmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAccountLimitsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountLimits.</param>
        /// 
        /// <returns>Returns a  DescribeAccountLimitsResult from AutoScaling.</returns>
        public  DescribeAccountLimitsResponse EndDescribeAccountLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAdjustmentTypes

        /// <summary>
        /// Describes the policy adjustment types for use with <a>PutScalingPolicy</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeAdjustmentTypesResponse DescribeAdjustmentTypes()
        {
            return DescribeAdjustmentTypes(new DescribeAdjustmentTypesRequest());
        }

        /// <summary>
        /// Describes the policy adjustment types for use with <a>PutScalingPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeAdjustmentTypesResponse DescribeAdjustmentTypes(DescribeAdjustmentTypesRequest request)
        {
            var marshaller = new DescribeAdjustmentTypesRequestMarshaller();
            var unmarshaller = DescribeAdjustmentTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeAdjustmentTypesRequest,DescribeAdjustmentTypesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeAdjustmentTypes(DescribeAdjustmentTypesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAdjustmentTypesRequestMarshaller();
            var unmarshaller = DescribeAdjustmentTypesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAdjustmentTypesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAdjustmentTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAdjustmentTypes.</param>
        /// 
        /// <returns>Returns a  DescribeAdjustmentTypesResult from AutoScaling.</returns>
        public  DescribeAdjustmentTypesResponse EndDescribeAdjustmentTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAdjustmentTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAutoScalingGroups

        /// <summary>
        /// Describes one or more Auto Scaling groups.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups()
        {
            return DescribeAutoScalingGroups(new DescribeAutoScalingGroupsRequest());
        }

        /// <summary>
        /// Describes one or more Auto Scaling groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request)
        {
            var marshaller = new DescribeAutoScalingGroupsRequestMarshaller();
            var unmarshaller = DescribeAutoScalingGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoScalingGroupsRequest,DescribeAutoScalingGroupsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAutoScalingGroupsRequestMarshaller();
            var unmarshaller = DescribeAutoScalingGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAutoScalingGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutoScalingGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingGroups.</param>
        /// 
        /// <returns>Returns a  DescribeAutoScalingGroupsResult from AutoScaling.</returns>
        public  DescribeAutoScalingGroupsResponse EndDescribeAutoScalingGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAutoScalingGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAutoScalingInstances

        /// <summary>
        /// Describes one or more Auto Scaling instances.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances()
        {
            return DescribeAutoScalingInstances(new DescribeAutoScalingInstancesRequest());
        }

        /// <summary>
        /// Describes one or more Auto Scaling instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request)
        {
            var marshaller = new DescribeAutoScalingInstancesRequestMarshaller();
            var unmarshaller = DescribeAutoScalingInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoScalingInstancesRequest,DescribeAutoScalingInstancesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAutoScalingInstancesRequestMarshaller();
            var unmarshaller = DescribeAutoScalingInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAutoScalingInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutoScalingInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingInstances.</param>
        /// 
        /// <returns>Returns a  DescribeAutoScalingInstancesResult from AutoScaling.</returns>
        public  DescribeAutoScalingInstancesResponse EndDescribeAutoScalingInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAutoScalingInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAutoScalingNotificationTypes

        /// <summary>
        /// Describes the notification types that are supported by Auto Scaling.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes()
        {
            return DescribeAutoScalingNotificationTypes(new DescribeAutoScalingNotificationTypesRequest());
        }

        /// <summary>
        /// Describes the notification types that are supported by Auto Scaling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest request)
        {
            var marshaller = new DescribeAutoScalingNotificationTypesRequestMarshaller();
            var unmarshaller = DescribeAutoScalingNotificationTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoScalingNotificationTypesRequest,DescribeAutoScalingNotificationTypesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAutoScalingNotificationTypesRequestMarshaller();
            var unmarshaller = DescribeAutoScalingNotificationTypesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAutoScalingNotificationTypesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAutoScalingNotificationTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAutoScalingNotificationTypes.</param>
        /// 
        /// <returns>Returns a  DescribeAutoScalingNotificationTypesResult from AutoScaling.</returns>
        public  DescribeAutoScalingNotificationTypesResponse EndDescribeAutoScalingNotificationTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAutoScalingNotificationTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLaunchConfigurations

        /// <summary>
        /// Describes one or more launch configurations.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations()
        {
            return DescribeLaunchConfigurations(new DescribeLaunchConfigurationsRequest());
        }

        /// <summary>
        /// Describes one or more launch configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request)
        {
            var marshaller = new DescribeLaunchConfigurationsRequestMarshaller();
            var unmarshaller = DescribeLaunchConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeLaunchConfigurationsRequest,DescribeLaunchConfigurationsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeLaunchConfigurationsRequestMarshaller();
            var unmarshaller = DescribeLaunchConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeLaunchConfigurationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLaunchConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLaunchConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeLaunchConfigurationsResult from AutoScaling.</returns>
        public  DescribeLaunchConfigurationsResponse EndDescribeLaunchConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLaunchConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLifecycleHooks

        /// <summary>
        /// Describes the lifecycle hooks for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHooks service method.</param>
        /// 
        /// <returns>The response from the DescribeLifecycleHooks service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeLifecycleHooksResponse DescribeLifecycleHooks(DescribeLifecycleHooksRequest request)
        {
            var marshaller = new DescribeLifecycleHooksRequestMarshaller();
            var unmarshaller = DescribeLifecycleHooksResponseUnmarshaller.Instance;

            return Invoke<DescribeLifecycleHooksRequest,DescribeLifecycleHooksResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeLifecycleHooks(DescribeLifecycleHooksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeLifecycleHooksRequestMarshaller();
            var unmarshaller = DescribeLifecycleHooksResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeLifecycleHooksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLifecycleHooks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLifecycleHooks.</param>
        /// 
        /// <returns>Returns a  DescribeLifecycleHooksResult from AutoScaling.</returns>
        public  DescribeLifecycleHooksResponse EndDescribeLifecycleHooks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLifecycleHooksResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLifecycleHookTypes

        /// <summary>
        /// Describes the available types of lifecycle hooks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHookTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeLifecycleHookTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeLifecycleHookTypesResponse DescribeLifecycleHookTypes(DescribeLifecycleHookTypesRequest request)
        {
            var marshaller = new DescribeLifecycleHookTypesRequestMarshaller();
            var unmarshaller = DescribeLifecycleHookTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeLifecycleHookTypesRequest,DescribeLifecycleHookTypesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeLifecycleHookTypes(DescribeLifecycleHookTypesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeLifecycleHookTypesRequestMarshaller();
            var unmarshaller = DescribeLifecycleHookTypesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeLifecycleHookTypesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLifecycleHookTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLifecycleHookTypes.</param>
        /// 
        /// <returns>Returns a  DescribeLifecycleHookTypesResult from AutoScaling.</returns>
        public  DescribeLifecycleHookTypesResponse EndDescribeLifecycleHookTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLifecycleHookTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLoadBalancers

        /// <summary>
        /// Describes the load balancers for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// Note that this operation describes only Classic load balancers. If you have Application
        /// load balancers, use <a>DescribeLoadBalancerTargetGroups</a> instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            var marshaller = new DescribeLoadBalancersRequestMarshaller();
            var unmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancersRequest,DescribeLoadBalancersResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeLoadBalancers(DescribeLoadBalancersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeLoadBalancersRequestMarshaller();
            var unmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeLoadBalancersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancers.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBalancersResult from AutoScaling.</returns>
        public  DescribeLoadBalancersResponse EndDescribeLoadBalancers(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLoadBalancersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLoadBalancerTargetGroups

        /// <summary>
        /// Describes the target groups for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerTargetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeLoadBalancerTargetGroupsResponse DescribeLoadBalancerTargetGroups(DescribeLoadBalancerTargetGroupsRequest request)
        {
            var marshaller = new DescribeLoadBalancerTargetGroupsRequestMarshaller();
            var unmarshaller = DescribeLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancerTargetGroupsRequest,DescribeLoadBalancerTargetGroupsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeLoadBalancerTargetGroups(DescribeLoadBalancerTargetGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeLoadBalancerTargetGroupsRequestMarshaller();
            var unmarshaller = DescribeLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeLoadBalancerTargetGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoadBalancerTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoadBalancerTargetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeLoadBalancerTargetGroupsResult from AutoScaling.</returns>
        public  DescribeLoadBalancerTargetGroupsResponse EndDescribeLoadBalancerTargetGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLoadBalancerTargetGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMetricCollectionTypes

        /// <summary>
        /// Describes the available CloudWatch metrics for Auto Scaling.
        /// 
        ///  
        /// <para>
        /// Note that the <code>GroupStandbyInstances</code> metric is not returned by default.
        /// You must explicitly request this metric when calling <a>EnableMetricsCollection</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes()
        {
            return DescribeMetricCollectionTypes(new DescribeMetricCollectionTypesRequest());
        }

        /// <summary>
        /// Describes the available CloudWatch metrics for Auto Scaling.
        /// 
        ///  
        /// <para>
        /// Note that the <code>GroupStandbyInstances</code> metric is not returned by default.
        /// You must explicitly request this metric when calling <a>EnableMetricsCollection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest request)
        {
            var marshaller = new DescribeMetricCollectionTypesRequestMarshaller();
            var unmarshaller = DescribeMetricCollectionTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeMetricCollectionTypesRequest,DescribeMetricCollectionTypesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeMetricCollectionTypesRequestMarshaller();
            var unmarshaller = DescribeMetricCollectionTypesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeMetricCollectionTypesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMetricCollectionTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMetricCollectionTypes.</param>
        /// 
        /// <returns>Returns a  DescribeMetricCollectionTypesResult from AutoScaling.</returns>
        public  DescribeMetricCollectionTypesResponse EndDescribeMetricCollectionTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMetricCollectionTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNotificationConfigurations

        /// <summary>
        /// Describes the notification actions associated with the specified Auto Scaling group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations()
        {
            return DescribeNotificationConfigurations(new DescribeNotificationConfigurationsRequest());
        }

        /// <summary>
        /// Describes the notification actions associated with the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request)
        {
            var marshaller = new DescribeNotificationConfigurationsRequestMarshaller();
            var unmarshaller = DescribeNotificationConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeNotificationConfigurationsRequest,DescribeNotificationConfigurationsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeNotificationConfigurationsRequestMarshaller();
            var unmarshaller = DescribeNotificationConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeNotificationConfigurationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotificationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotificationConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeNotificationConfigurationsResult from AutoScaling.</returns>
        public  DescribeNotificationConfigurationsResponse EndDescribeNotificationConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNotificationConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePolicies

        /// <summary>
        /// Describes the policies for the specified Auto Scaling group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribePoliciesResponse DescribePolicies()
        {
            return DescribePolicies(new DescribePoliciesRequest());
        }

        /// <summary>
        /// Describes the policies for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies service method.</param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribePoliciesResponse DescribePolicies(DescribePoliciesRequest request)
        {
            var marshaller = new DescribePoliciesRequestMarshaller();
            var unmarshaller = DescribePoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribePoliciesRequest,DescribePoliciesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribePolicies(DescribePoliciesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribePoliciesRequestMarshaller();
            var unmarshaller = DescribePoliciesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribePoliciesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePolicies.</param>
        /// 
        /// <returns>Returns a  DescribePoliciesResult from AutoScaling.</returns>
        public  DescribePoliciesResponse EndDescribePolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeScalingActivities

        /// <summary>
        /// Describes one or more scaling activities for the specified Auto Scaling group.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeScalingActivitiesResponse DescribeScalingActivities()
        {
            return DescribeScalingActivities(new DescribeScalingActivitiesRequest());
        }

        /// <summary>
        /// Describes one or more scaling activities for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request)
        {
            var marshaller = new DescribeScalingActivitiesRequestMarshaller();
            var unmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingActivitiesRequest,DescribeScalingActivitiesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeScalingActivities(DescribeScalingActivitiesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeScalingActivitiesRequestMarshaller();
            var unmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeScalingActivitiesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingActivities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingActivities.</param>
        /// 
        /// <returns>Returns a  DescribeScalingActivitiesResult from AutoScaling.</returns>
        public  DescribeScalingActivitiesResponse EndDescribeScalingActivities(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScalingActivitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeScalingProcessTypes

        /// <summary>
        /// Describes the scaling process types for use with <a>ResumeProcesses</a> and <a>SuspendProcesses</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeScalingProcessTypesResponse DescribeScalingProcessTypes()
        {
            return DescribeScalingProcessTypes(new DescribeScalingProcessTypesRequest());
        }

        /// <summary>
        /// Describes the scaling process types for use with <a>ResumeProcesses</a> and <a>SuspendProcesses</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeScalingProcessTypesResponse DescribeScalingProcessTypes(DescribeScalingProcessTypesRequest request)
        {
            var marshaller = new DescribeScalingProcessTypesRequestMarshaller();
            var unmarshaller = DescribeScalingProcessTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingProcessTypesRequest,DescribeScalingProcessTypesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeScalingProcessTypes(DescribeScalingProcessTypesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeScalingProcessTypesRequestMarshaller();
            var unmarshaller = DescribeScalingProcessTypesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeScalingProcessTypesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingProcessTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingProcessTypes.</param>
        /// 
        /// <returns>Returns a  DescribeScalingProcessTypesResult from AutoScaling.</returns>
        public  DescribeScalingProcessTypesResponse EndDescribeScalingProcessTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScalingProcessTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeScheduledActions

        /// <summary>
        /// Describes the actions scheduled for your Auto Scaling group that haven't run. To describe
        /// the actions that have already run, use <a>DescribeScalingActivities</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeScheduledActionsResponse DescribeScheduledActions()
        {
            return DescribeScheduledActions(new DescribeScheduledActionsRequest());
        }

        /// <summary>
        /// Describes the actions scheduled for your Auto Scaling group that haven't run. To describe
        /// the actions that have already run, use <a>DescribeScalingActivities</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request)
        {
            var marshaller = new DescribeScheduledActionsRequestMarshaller();
            var unmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledActionsRequest,DescribeScheduledActionsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeScheduledActions(DescribeScheduledActionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeScheduledActionsRequestMarshaller();
            var unmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeScheduledActionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScheduledActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScheduledActions.</param>
        /// 
        /// <returns>Returns a  DescribeScheduledActionsResult from AutoScaling.</returns>
        public  DescribeScheduledActionsResponse EndDescribeScheduledActions(IAsyncResult asyncResult)
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
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeTagsResponse DescribeTags()
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from AutoScaling.</returns>
        public  DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTerminationPolicyTypes

        /// <summary>
        /// Describes the termination policies supported by Auto Scaling.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes()
        {
            return DescribeTerminationPolicyTypes(new DescribeTerminationPolicyTypesRequest());
        }

        /// <summary>
        /// Describes the termination policies supported by Auto Scaling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest request)
        {
            var marshaller = new DescribeTerminationPolicyTypesRequestMarshaller();
            var unmarshaller = DescribeTerminationPolicyTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeTerminationPolicyTypesRequest,DescribeTerminationPolicyTypesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeTerminationPolicyTypesRequestMarshaller();
            var unmarshaller = DescribeTerminationPolicyTypesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeTerminationPolicyTypesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTerminationPolicyTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTerminationPolicyTypes.</param>
        /// 
        /// <returns>Returns a  DescribeTerminationPolicyTypesResult from AutoScaling.</returns>
        public  DescribeTerminationPolicyTypesResponse EndDescribeTerminationPolicyTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTerminationPolicyTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachInstances

        /// <summary>
        /// Removes one or more instances from the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// After the instances are detached, you can manage them independently from the rest
        /// of the Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify the option to decrement the desired capacity, Auto Scaling launches
        /// instances to replace the ones that are detached.
        /// </para>
        ///  
        /// <para>
        /// If there is a Classic load balancer attached to the Auto Scaling group, the instances
        /// are deregistered from the load balancer. If there are target groups attached to the
        /// Auto Scaling group, the instances are deregistered from the target groups.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/detach-instance-asg.html">Detach
        /// EC2 Instances from Your Auto Scaling Group</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInstances service method.</param>
        /// 
        /// <returns>The response from the DetachInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DetachInstancesResponse DetachInstances(DetachInstancesRequest request)
        {
            var marshaller = new DetachInstancesRequestMarshaller();
            var unmarshaller = DetachInstancesResponseUnmarshaller.Instance;

            return Invoke<DetachInstancesRequest,DetachInstancesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDetachInstances(DetachInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachInstancesRequestMarshaller();
            var unmarshaller = DetachInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<DetachInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachInstances.</param>
        /// 
        /// <returns>Returns a  DetachInstancesResult from AutoScaling.</returns>
        public  DetachInstancesResponse EndDetachInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachLoadBalancers

        /// <summary>
        /// Detaches one or more Classic load balancers from the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// Note that this operation detaches only Classic load balancers. If you have Application
        /// load balancers, use <a>DetachLoadBalancerTargetGroups</a> instead.
        /// </para>
        ///  
        /// <para>
        /// When you detach a load balancer, it enters the <code>Removing</code> state while deregistering
        /// the instances in the group. When all instances are deregistered, then you can no longer
        /// describe the load balancer using <a>DescribeLoadBalancers</a>. Note that the instances
        /// remain running.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancers service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DetachLoadBalancersResponse DetachLoadBalancers(DetachLoadBalancersRequest request)
        {
            var marshaller = new DetachLoadBalancersRequestMarshaller();
            var unmarshaller = DetachLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<DetachLoadBalancersRequest,DetachLoadBalancersResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDetachLoadBalancers(DetachLoadBalancersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachLoadBalancersRequestMarshaller();
            var unmarshaller = DetachLoadBalancersResponseUnmarshaller.Instance;

            return BeginInvoke<DetachLoadBalancersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachLoadBalancers.</param>
        /// 
        /// <returns>Returns a  DetachLoadBalancersResult from AutoScaling.</returns>
        public  DetachLoadBalancersResponse EndDetachLoadBalancers(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachLoadBalancersResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachLoadBalancerTargetGroups

        /// <summary>
        /// Detaches one or more target groups from the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerTargetGroups service method.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancerTargetGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DetachLoadBalancerTargetGroupsResponse DetachLoadBalancerTargetGroups(DetachLoadBalancerTargetGroupsRequest request)
        {
            var marshaller = new DetachLoadBalancerTargetGroupsRequestMarshaller();
            var unmarshaller = DetachLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<DetachLoadBalancerTargetGroupsRequest,DetachLoadBalancerTargetGroupsResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDetachLoadBalancerTargetGroups(DetachLoadBalancerTargetGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachLoadBalancerTargetGroupsRequestMarshaller();
            var unmarshaller = DetachLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<DetachLoadBalancerTargetGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachLoadBalancerTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachLoadBalancerTargetGroups.</param>
        /// 
        /// <returns>Returns a  DetachLoadBalancerTargetGroupsResult from AutoScaling.</returns>
        public  DetachLoadBalancerTargetGroupsResponse EndDetachLoadBalancerTargetGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachLoadBalancerTargetGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableMetricsCollection

        /// <summary>
        /// Disables group metrics for the specified Auto Scaling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection service method.</param>
        /// 
        /// <returns>The response from the DisableMetricsCollection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public DisableMetricsCollectionResponse DisableMetricsCollection(DisableMetricsCollectionRequest request)
        {
            var marshaller = new DisableMetricsCollectionRequestMarshaller();
            var unmarshaller = DisableMetricsCollectionResponseUnmarshaller.Instance;

            return Invoke<DisableMetricsCollectionRequest,DisableMetricsCollectionResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginDisableMetricsCollection(DisableMetricsCollectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisableMetricsCollectionRequestMarshaller();
            var unmarshaller = DisableMetricsCollectionResponseUnmarshaller.Instance;

            return BeginInvoke<DisableMetricsCollectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableMetricsCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableMetricsCollection.</param>
        /// 
        /// <returns>Returns a  DisableMetricsCollectionResult from AutoScaling.</returns>
        public  DisableMetricsCollectionResponse EndDisableMetricsCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableMetricsCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableMetricsCollection

        /// <summary>
        /// Enables group metrics for the specified Auto Scaling group. For more information,
        /// see <a href="http://docs.aws.amazon.com/AutoScaling/latest/userguide/as-instance-monitoring.html">Monitoring
        /// Your Auto Scaling Groups and Instances</a> in the <i>Auto Scaling User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection service method.</param>
        /// 
        /// <returns>The response from the EnableMetricsCollection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public EnableMetricsCollectionResponse EnableMetricsCollection(EnableMetricsCollectionRequest request)
        {
            var marshaller = new EnableMetricsCollectionRequestMarshaller();
            var unmarshaller = EnableMetricsCollectionResponseUnmarshaller.Instance;

            return Invoke<EnableMetricsCollectionRequest,EnableMetricsCollectionResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginEnableMetricsCollection(EnableMetricsCollectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new EnableMetricsCollectionRequestMarshaller();
            var unmarshaller = EnableMetricsCollectionResponseUnmarshaller.Instance;

            return BeginInvoke<EnableMetricsCollectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableMetricsCollection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableMetricsCollection.</param>
        /// 
        /// <returns>Returns a  EnableMetricsCollectionResult from AutoScaling.</returns>
        public  EnableMetricsCollectionResponse EndEnableMetricsCollection(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableMetricsCollectionResponse>(asyncResult);
        }

        #endregion
        
        #region  EnterStandby

        /// <summary>
        /// Moves the specified instances into <code>Standby</code> mode.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingGroupLifecycle.html">Auto
        /// Scaling Lifecycle</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnterStandby service method.</param>
        /// 
        /// <returns>The response from the EnterStandby service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public EnterStandbyResponse EnterStandby(EnterStandbyRequest request)
        {
            var marshaller = new EnterStandbyRequestMarshaller();
            var unmarshaller = EnterStandbyResponseUnmarshaller.Instance;

            return Invoke<EnterStandbyRequest,EnterStandbyResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginEnterStandby(EnterStandbyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new EnterStandbyRequestMarshaller();
            var unmarshaller = EnterStandbyResponseUnmarshaller.Instance;

            return BeginInvoke<EnterStandbyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnterStandby operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnterStandby.</param>
        /// 
        /// <returns>Returns a  EnterStandbyResult from AutoScaling.</returns>
        public  EnterStandbyResponse EndEnterStandby(IAsyncResult asyncResult)
        {
            return EndInvoke<EnterStandbyResponse>(asyncResult);
        }

        #endregion
        
        #region  ExecutePolicy

        /// <summary>
        /// Executes the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy service method.</param>
        /// 
        /// <returns>The response from the ExecutePolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        public ExecutePolicyResponse ExecutePolicy(ExecutePolicyRequest request)
        {
            var marshaller = new ExecutePolicyRequestMarshaller();
            var unmarshaller = ExecutePolicyResponseUnmarshaller.Instance;

            return Invoke<ExecutePolicyRequest,ExecutePolicyResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginExecutePolicy(ExecutePolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ExecutePolicyRequestMarshaller();
            var unmarshaller = ExecutePolicyResponseUnmarshaller.Instance;

            return BeginInvoke<ExecutePolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExecutePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecutePolicy.</param>
        /// 
        /// <returns>Returns a  ExecutePolicyResult from AutoScaling.</returns>
        public  ExecutePolicyResponse EndExecutePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<ExecutePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  ExitStandby

        /// <summary>
        /// Moves the specified instances out of <code>Standby</code> mode.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingGroupLifecycle.html">Auto
        /// Scaling Lifecycle</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExitStandby service method.</param>
        /// 
        /// <returns>The response from the ExitStandby service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public ExitStandbyResponse ExitStandby(ExitStandbyRequest request)
        {
            var marshaller = new ExitStandbyRequestMarshaller();
            var unmarshaller = ExitStandbyResponseUnmarshaller.Instance;

            return Invoke<ExitStandbyRequest,ExitStandbyResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginExitStandby(ExitStandbyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ExitStandbyRequestMarshaller();
            var unmarshaller = ExitStandbyResponseUnmarshaller.Instance;

            return BeginInvoke<ExitStandbyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExitStandby operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExitStandby.</param>
        /// 
        /// <returns>Returns a  ExitStandbyResult from AutoScaling.</returns>
        public  ExitStandbyResponse EndExitStandby(IAsyncResult asyncResult)
        {
            return EndInvoke<ExitStandbyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutLifecycleHook

        /// <summary>
        /// Creates or updates a lifecycle hook for the specified Auto Scaling Group.
        /// 
        ///  
        /// <para>
        /// A lifecycle hook tells Auto Scaling that you want to perform an action on an instance
        /// that is not actively in service; for example, either when the instance launches or
        /// before the instance terminates.
        /// </para>
        ///  
        /// <para>
        /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// (Optional) Create a Lambda function and a rule that allows CloudWatch Events to invoke
        /// your Lambda function when Auto Scaling launches or terminates instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Auto Scaling to publish
        /// lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Create the lifecycle hook. Specify whether the hook is used when the instances
        /// launch or terminate.</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a pending state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you finish before the timeout period ends, complete the lifecycle action.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingGroupLifecycle.html">Auto
        /// Scaling Lifecycle</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you exceed your maximum limit of lifecycle hooks, which by default is 50 per Auto
        /// Scaling group, the call fails. For information about updating this limit, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">AWS
        /// Service Limits</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleHook service method.</param>
        /// 
        /// <returns>The response from the PutLifecycleHook service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Auto Scaling resources (for example, groups,
        /// launch configurations, or lifecycle hooks). For more information, see <a>DescribeAccountLimits</a>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public PutLifecycleHookResponse PutLifecycleHook(PutLifecycleHookRequest request)
        {
            var marshaller = new PutLifecycleHookRequestMarshaller();
            var unmarshaller = PutLifecycleHookResponseUnmarshaller.Instance;

            return Invoke<PutLifecycleHookRequest,PutLifecycleHookResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginPutLifecycleHook(PutLifecycleHookRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutLifecycleHookRequestMarshaller();
            var unmarshaller = PutLifecycleHookResponseUnmarshaller.Instance;

            return BeginInvoke<PutLifecycleHookRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutLifecycleHook operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLifecycleHook.</param>
        /// 
        /// <returns>Returns a  PutLifecycleHookResult from AutoScaling.</returns>
        public  PutLifecycleHookResponse EndPutLifecycleHook(IAsyncResult asyncResult)
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
        /// For more information see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASGettingNotifications.html">Getting
        /// SNS Notifications When Your Auto Scaling Group Scales</a> in the <i>Auto Scaling User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutNotificationConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Auto Scaling resources (for example, groups,
        /// launch configurations, or lifecycle hooks). For more information, see <a>DescribeAccountLimits</a>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public PutNotificationConfigurationResponse PutNotificationConfiguration(PutNotificationConfigurationRequest request)
        {
            var marshaller = new PutNotificationConfigurationRequestMarshaller();
            var unmarshaller = PutNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutNotificationConfigurationRequest,PutNotificationConfigurationResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginPutNotificationConfiguration(PutNotificationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutNotificationConfigurationRequestMarshaller();
            var unmarshaller = PutNotificationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke<PutNotificationConfigurationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutNotificationConfiguration.</param>
        /// 
        /// <returns>Returns a  PutNotificationConfigurationResult from AutoScaling.</returns>
        public  PutNotificationConfigurationResponse EndPutNotificationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutNotificationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutScalingPolicy

        /// <summary>
        /// Creates or updates a policy for an Auto Scaling group. To update an existing policy,
        /// use the existing policy name and set the parameters you want to change. Any existing
        /// parameter not changed in an update to an existing policy is not changed in this update
        /// request.
        /// 
        ///  
        /// <para>
        /// If you exceed your maximum limit of step adjustments, which by default is 20 per region,
        /// the call fails. For information about updating this limit, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">AWS
        /// Service Limits</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Auto Scaling resources (for example, groups,
        /// launch configurations, or lifecycle hooks). For more information, see <a>DescribeAccountLimits</a>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request)
        {
            var marshaller = new PutScalingPolicyRequestMarshaller();
            var unmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutScalingPolicyRequest,PutScalingPolicyResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginPutScalingPolicy(PutScalingPolicyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutScalingPolicyRequestMarshaller();
            var unmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return BeginInvoke<PutScalingPolicyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScalingPolicy.</param>
        /// 
        /// <returns>Returns a  PutScalingPolicyResult from AutoScaling.</returns>
        public  PutScalingPolicyResponse EndPutScalingPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutScalingPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutScheduledUpdateGroupAction

        /// <summary>
        /// Creates or updates a scheduled scaling action for an Auto Scaling group. When updating
        /// a scheduled scaling action, if you leave a parameter unspecified, the corresponding
        /// value remains unchanged in the affected Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/schedule_time.html">Scheduled
        /// Scaling</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction service method.</param>
        /// 
        /// <returns>The response from the PutScheduledUpdateGroupAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.AlreadyExistsException">
        /// You already have an Auto Scaling group or launch configuration with this name.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Auto Scaling resources (for example, groups,
        /// launch configurations, or lifecycle hooks). For more information, see <a>DescribeAccountLimits</a>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public PutScheduledUpdateGroupActionResponse PutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest request)
        {
            var marshaller = new PutScheduledUpdateGroupActionRequestMarshaller();
            var unmarshaller = PutScheduledUpdateGroupActionResponseUnmarshaller.Instance;

            return Invoke<PutScheduledUpdateGroupActionRequest,PutScheduledUpdateGroupActionResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginPutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutScheduledUpdateGroupActionRequestMarshaller();
            var unmarshaller = PutScheduledUpdateGroupActionResponseUnmarshaller.Instance;

            return BeginInvoke<PutScheduledUpdateGroupActionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutScheduledUpdateGroupAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScheduledUpdateGroupAction.</param>
        /// 
        /// <returns>Returns a  PutScheduledUpdateGroupActionResult from AutoScaling.</returns>
        public  PutScheduledUpdateGroupActionResponse EndPutScheduledUpdateGroupAction(IAsyncResult asyncResult)
        {
            return EndInvoke<PutScheduledUpdateGroupActionResponse>(asyncResult);
        }

        #endregion
        
        #region  RecordLifecycleActionHeartbeat

        /// <summary>
        /// Records a heartbeat for the lifecycle action associated with the specified token or
        /// instance. This extends the timeout by the length of time defined using <a>PutLifecycleHook</a>.
        /// 
        ///  
        /// <para>
        /// This step is a part of the procedure for adding a lifecycle hook to an Auto Scaling
        /// group:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// (Optional) Create a Lambda function and a rule that allows CloudWatch Events to invoke
        /// your Lambda function when Auto Scaling launches or terminates instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Optional) Create a notification target and an IAM role. The target can be either
        /// an Amazon SQS queue or an Amazon SNS topic. The role allows Auto Scaling to publish
        /// lifecycle notifications to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create the lifecycle hook. Specify whether the hook is used when the instances launch
        /// or terminate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>If you need more time, record the lifecycle action heartbeat to keep the instance
        /// in a pending state.</b> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you finish before the timeout period ends, complete the lifecycle action.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingGroupLifecycle.html">Auto
        /// Scaling Lifecycle</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordLifecycleActionHeartbeat service method.</param>
        /// 
        /// <returns>The response from the RecordLifecycleActionHeartbeat service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public RecordLifecycleActionHeartbeatResponse RecordLifecycleActionHeartbeat(RecordLifecycleActionHeartbeatRequest request)
        {
            var marshaller = new RecordLifecycleActionHeartbeatRequestMarshaller();
            var unmarshaller = RecordLifecycleActionHeartbeatResponseUnmarshaller.Instance;

            return Invoke<RecordLifecycleActionHeartbeatRequest,RecordLifecycleActionHeartbeatResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginRecordLifecycleActionHeartbeat(RecordLifecycleActionHeartbeatRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RecordLifecycleActionHeartbeatRequestMarshaller();
            var unmarshaller = RecordLifecycleActionHeartbeatResponseUnmarshaller.Instance;

            return BeginInvoke<RecordLifecycleActionHeartbeatRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RecordLifecycleActionHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecordLifecycleActionHeartbeat.</param>
        /// 
        /// <returns>Returns a  RecordLifecycleActionHeartbeatResult from AutoScaling.</returns>
        public  RecordLifecycleActionHeartbeatResponse EndRecordLifecycleActionHeartbeat(IAsyncResult asyncResult)
        {
            return EndInvoke<RecordLifecycleActionHeartbeatResponse>(asyncResult);
        }

        #endregion
        
        #region  ResumeProcesses

        /// <summary>
        /// Resumes the specified suspended Auto Scaling processes, or all suspended process,
        /// for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspending
        /// and Resuming Auto Scaling Processes</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses service method.</param>
        /// 
        /// <returns>The response from the ResumeProcesses service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        public ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest request)
        {
            var marshaller = new ResumeProcessesRequestMarshaller();
            var unmarshaller = ResumeProcessesResponseUnmarshaller.Instance;

            return Invoke<ResumeProcessesRequest,ResumeProcessesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginResumeProcesses(ResumeProcessesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ResumeProcessesRequestMarshaller();
            var unmarshaller = ResumeProcessesResponseUnmarshaller.Instance;

            return BeginInvoke<ResumeProcessesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeProcesses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeProcesses.</param>
        /// 
        /// <returns>Returns a  ResumeProcessesResult from AutoScaling.</returns>
        public  ResumeProcessesResponse EndResumeProcesses(IAsyncResult asyncResult)
        {
            return EndInvoke<ResumeProcessesResponse>(asyncResult);
        }

        #endregion
        
        #region  SetDesiredCapacity

        /// <summary>
        /// Sets the size of the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information about desired capacity, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/WhatIsAutoScaling.html">What
        /// Is Auto Scaling?</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity service method.</param>
        /// 
        /// <returns>The response from the SetDesiredCapacity service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        public SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest request)
        {
            var marshaller = new SetDesiredCapacityRequestMarshaller();
            var unmarshaller = SetDesiredCapacityResponseUnmarshaller.Instance;

            return Invoke<SetDesiredCapacityRequest,SetDesiredCapacityResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginSetDesiredCapacity(SetDesiredCapacityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SetDesiredCapacityRequestMarshaller();
            var unmarshaller = SetDesiredCapacityResponseUnmarshaller.Instance;

            return BeginInvoke<SetDesiredCapacityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetDesiredCapacity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetDesiredCapacity.</param>
        /// 
        /// <returns>Returns a  SetDesiredCapacityResult from AutoScaling.</returns>
        public  SetDesiredCapacityResponse EndSetDesiredCapacity(IAsyncResult asyncResult)
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
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/healthcheck.html">Health
        /// Checks</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth service method.</param>
        /// 
        /// <returns>The response from the SetInstanceHealth service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest request)
        {
            var marshaller = new SetInstanceHealthRequestMarshaller();
            var unmarshaller = SetInstanceHealthResponseUnmarshaller.Instance;

            return Invoke<SetInstanceHealthRequest,SetInstanceHealthResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginSetInstanceHealth(SetInstanceHealthRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SetInstanceHealthRequestMarshaller();
            var unmarshaller = SetInstanceHealthResponseUnmarshaller.Instance;

            return BeginInvoke<SetInstanceHealthRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetInstanceHealth operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetInstanceHealth.</param>
        /// 
        /// <returns>Returns a  SetInstanceHealthResult from AutoScaling.</returns>
        public  SetInstanceHealthResponse EndSetInstanceHealth(IAsyncResult asyncResult)
        {
            return EndInvoke<SetInstanceHealthResponse>(asyncResult);
        }

        #endregion
        
        #region  SetInstanceProtection

        /// <summary>
        /// Updates the instance protection settings of the specified instances.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingBehavior.InstanceTermination.html#instance-protection">Instance
        /// Protection</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceProtection service method.</param>
        /// 
        /// <returns>The response from the SetInstanceProtection service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.LimitExceededException">
        /// You have already reached a limit for your Auto Scaling resources (for example, groups,
        /// launch configurations, or lifecycle hooks). For more information, see <a>DescribeAccountLimits</a>.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        public SetInstanceProtectionResponse SetInstanceProtection(SetInstanceProtectionRequest request)
        {
            var marshaller = new SetInstanceProtectionRequestMarshaller();
            var unmarshaller = SetInstanceProtectionResponseUnmarshaller.Instance;

            return Invoke<SetInstanceProtectionRequest,SetInstanceProtectionResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginSetInstanceProtection(SetInstanceProtectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SetInstanceProtectionRequestMarshaller();
            var unmarshaller = SetInstanceProtectionResponseUnmarshaller.Instance;

            return BeginInvoke<SetInstanceProtectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetInstanceProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetInstanceProtection.</param>
        /// 
        /// <returns>Returns a  SetInstanceProtectionResult from AutoScaling.</returns>
        public  SetInstanceProtectionResponse EndSetInstanceProtection(IAsyncResult asyncResult)
        {
            return EndInvoke<SetInstanceProtectionResponse>(asyncResult);
        }

        #endregion
        
        #region  SuspendProcesses

        /// <summary>
        /// Suspends the specified Auto Scaling processes, or all processes, for the specified
        /// Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// Note that if you suspend either the <code>Launch</code> or <code>Terminate</code>
        /// process types, it can prevent other process types from functioning properly.
        /// </para>
        ///  
        /// <para>
        /// To resume processes that have been suspended, use <a>ResumeProcesses</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspending
        /// and Resuming Auto Scaling Processes</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses service method.</param>
        /// 
        /// <returns>The response from the SuspendProcesses service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The operation can't be performed because the resource is in use.
        /// </exception>
        public SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest request)
        {
            var marshaller = new SuspendProcessesRequestMarshaller();
            var unmarshaller = SuspendProcessesResponseUnmarshaller.Instance;

            return Invoke<SuspendProcessesRequest,SuspendProcessesResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginSuspendProcesses(SuspendProcessesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SuspendProcessesRequestMarshaller();
            var unmarshaller = SuspendProcessesResponseUnmarshaller.Instance;

            return BeginInvoke<SuspendProcessesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SuspendProcesses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSuspendProcesses.</param>
        /// 
        /// <returns>Returns a  SuspendProcessesResult from AutoScaling.</returns>
        public  SuspendProcessesResponse EndSuspendProcesses(IAsyncResult asyncResult)
        {
            return EndInvoke<SuspendProcessesResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateInstanceInAutoScalingGroup

        /// <summary>
        /// Terminates the specified instance and optionally adjusts the desired group size.
        /// 
        ///  
        /// <para>
        /// This call simply makes a termination request. The instance is not terminated immediately.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the TerminateInstanceInAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        public TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request)
        {
            var marshaller = new TerminateInstanceInAutoScalingGroupRequestMarshaller();
            var unmarshaller = TerminateInstanceInAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<TerminateInstanceInAutoScalingGroupRequest,TerminateInstanceInAutoScalingGroupResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginTerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new TerminateInstanceInAutoScalingGroupRequestMarshaller();
            var unmarshaller = TerminateInstanceInAutoScalingGroupResponseUnmarshaller.Instance;

            return BeginInvoke<TerminateInstanceInAutoScalingGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateInstanceInAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateInstanceInAutoScalingGroup.</param>
        /// 
        /// <returns>Returns a  TerminateInstanceInAutoScalingGroupResult from AutoScaling.</returns>
        public  TerminateInstanceInAutoScalingGroupResponse EndTerminateInstanceInAutoScalingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateInstanceInAutoScalingGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAutoScalingGroup

        /// <summary>
        /// Updates the configuration for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// To update an Auto Scaling group with a launch configuration with <code>InstanceMonitoring</code>
        /// set to <code>False</code>, you must first disable the collection of group metrics.
        /// Otherwise, you will get an error. If you have previously enabled the collection of
        /// group metrics, you can disable it using <a>DisableMetricsCollection</a>.
        /// </para>
        ///  
        /// <para>
        /// The new settings are registered upon the completion of this call. Any launch configuration
        /// settings take effect on any triggers after this call returns. Scaling activities that
        /// are currently in progress aren't affected.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify a new value for <code>MinSize</code> without specifying a value for
        /// <code>DesiredCapacity</code>, and the new <code>MinSize</code> is larger than the
        /// current size of the group, we implicitly call <a>SetDesiredCapacity</a> to set the
        /// size of the group to the new value of <code>MinSize</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a new value for <code>MaxSize</code> without specifying a value for
        /// <code>DesiredCapacity</code>, and the new <code>MaxSize</code> is smaller than the
        /// current size of the group, we implicitly call <a>SetDesiredCapacity</a> to set the
        /// size of the group to the new value of <code>MaxSize</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All other optional parameters are left unchanged if not specified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The operation can't be performed because there are scaling activities in progress.
        /// </exception>
        public UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request)
        {
            var marshaller = new UpdateAutoScalingGroupRequestMarshaller();
            var unmarshaller = UpdateAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateAutoScalingGroupRequest,UpdateAutoScalingGroupResponse>(request, marshaller, unmarshaller);
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
        public IAsyncResult BeginUpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateAutoScalingGroupRequestMarshaller();
            var unmarshaller = UpdateAutoScalingGroupResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAutoScalingGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAutoScalingGroup.</param>
        /// 
        /// <returns>Returns a  UpdateAutoScalingGroupResult from AutoScaling.</returns>
        public  UpdateAutoScalingGroupResponse EndUpdateAutoScalingGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAutoScalingGroupResponse>(asyncResult);
        }

        #endregion
        
    }
}